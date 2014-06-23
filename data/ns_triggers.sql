------------------------------------------------
-- блокирование таблицы на время работы триггера
CREATE OR REPLACE FUNCTION lock_ns_tree(integer)
    RETURNS boolean AS
$BODY$
DECLARE tree_id ALIAS FOR $1;
    _id INTEGER;
BEGIN
    SELECT id
        INTO _id
        FROM ns_tree
        WHERE tree = tree_id FOR UPDATE;
    RETURN TRUE;
END;
$BODY$
  LANGUAGE 'plpgsql' VOLATILE
  COST 100;
ALTER FUNCTION lock_ns_tree(integer) OWNER TO postgres;
------------------------------------------------
-- создание записи
CREATE OR REPLACE FUNCTION ns_tree_before_insert_func()
    RETURNS trigger AS
$BODY$
DECLARE
    _left_key       INTEGER;
    _level          INTEGER;
    _tmp_left_key   INTEGER;
    _tmp_right_key  INTEGER;
    _tmp_level      INTEGER;
    _tmp_id         INTEGER;
    _tmp_parent_id  INTEGER;
BEGIN
    PERFORM lock_ns_tree(NEW.tree);
-- Нельзя эти поля ручками ставить:
    NEW._trigger_for_delete := FALSE;
    NEW._trigger_lock_update := FALSE;
    _left_key := 0;
    _level := 0;
-- Если мы указали родителя:
    IF NEW.parent_id IS NOT NULL AND NEW.parent_id > 0 THEN
        SELECT right_key, "level" + 1
            INTO _left_key, _level
            FROM ns_tree
            WHERE id = NEW.parent_id AND
                  tree = NEW.tree;
    END IF;
-- Если мы указали левый ключ:
    IF NEW.left_key IS NOT NULL AND
       NEW.left_key > 0 AND 
       (_left_key IS NULL OR _left_key = 0) THEN
        SELECT id, left_key, right_key, "level", parent_id 
            INTO _tmp_id, _tmp_left_key, _tmp_right_key, _tmp_level, _tmp_parent_id
            FROM ns_tree
            WHERE tree = NEW.tree AND (left_key = NEW.left_key OR right_key = NEW.left_key);
        IF _tmp_left_key IS NOT NULL AND _tmp_left_key > 0 AND NEW.left_key = _tmp_left_key THEN
            NEW.parent_id := _tmp_parent_id;
            _left_key := NEW.left_key;
            _level := _tmp_level;
        ELSIF _tmp_left_key IS NOT NULL AND _tmp_left_key > 0 AND NEW.left_key = _tmp_right_key THEN
            NEW.parent_id := _tmp_id;
            _left_key := NEW.left_key;
            _level := _tmp_level + 1;
        END IF;
    END IF;
-- Если родитель или левый ключ не указан, или мы ничего не нашли:
    IF _left_key IS NULL OR _left_key = 0 THEN
        SELECT MAX(right_key) + 1
            INTO _left_key
            FROM ns_tree
            WHERE tree = NEW.tree;
        IF _left_key IS NULL OR _left_key = 0 THEN
            _left_key := 1;
        END IF;
        _level := 0;
        NEW.parent_id := 0; 
    END IF;
-- Устанавливаем полученные ключи для узла:
    NEW.left_key := _left_key;
    NEW.right_key := _left_key + 1;
    NEW."level" := _level;
-- Формируем развыв в дереве на месте вставки:
    UPDATE ns_tree
        SET left_key = left_key + 
            CASE WHEN left_key >= _left_key 
              THEN 2 
              ELSE 0 
            END,
            right_key = right_key + 2,
            _trigger_lock_update = TRUE
        WHERE tree = NEW.tree AND right_key >= _left_key;
    RETURN NEW;
END;
$BODY$
  LANGUAGE 'plpgsql' VOLATILE
  COST 100;
ALTER FUNCTION ns_tree_before_insert_func() OWNER TO postgres;
------------------------------------------------
--Изменение записи
CREATE OR REPLACE FUNCTION ns_tree_before_update_func()
  RETURNS trigger AS
$BODY$
DECLARE
    _left_key       INTEGER;
    _level          INTEGER;
    _skew_tree      INTEGER;
    _skew_level     INTEGER;
    _skew_edit      INTEGER;
    _tmp_left_key   INTEGER;
    _tmp_right_key  INTEGER;
    _tmp_level      INTEGER;
    _tmp_id         INTEGER;
    _tmp_parent_id  INTEGER;
BEGIN
    PERFORM lock_ns_tree(OLD.tree);
-- А стоит ли нам вообще что либо делать:
    IF NEW._trigger_lock_update = TRUE THEN
        NEW._trigger_lock_update := FALSE;
        IF NEW._trigger_for_delete = TRUE THEN
            NEW = OLD;
            NEW._trigger_for_delete = TRUE;
            RETURN NEW;
        END IF;
        RETURN NEW;
    END IF;
-- Сбрасываем значения полей, которые пользователь менять не может:
    NEW._trigger_for_delete := FALSE;
    NEW.tree := OLD.tree;
    NEW.right_key := OLD.right_key;
    NEW."level" := OLD."level";
    IF NEW.parent_id IS NULL THEN NEW.parent_id := 0; END IF;
-- Проверяем, а есть ли изменения связанные со структурой дерева
    IF NEW.parent_id = OLD.parent_id AND NEW.left_key = OLD.left_key
    THEN
        RETURN NEW;
    END IF;
-- Дерево таки перестраиваем, что ж, приступим:
    _left_key := 0;
    _level := 0;
    _skew_tree := OLD.right_key - OLD.left_key + 1;
-- Определяем куда мы его переносим:
-- Если сменен parent_id:
    IF NEW.parent_id <> OLD.parent_id THEN
-- Если в подчинение другому злу:
        IF NEW.parent_id > 0 THEN
            SELECT right_key, level + 1
                INTO _left_key, _level
                FROM ns_tree
                WHERE id = NEW.parent_id AND tree = NEW.tree;
-- Иначе в корень дерева переносим:
        ELSE
            SELECT MAX(right_key) + 1 
                INTO _left_key
                FROM ns_tree
                WHERE tree = NEW.tree;
            _level := 0;
        END IF;
-- Если вдруг родитель в диапазоне перемещаемого узла, проверка:
        IF _left_key IS NOT NULL AND 
           _left_key > 0 AND
           _left_key > OLD.left_key AND
           _left_key <= OLD.right_key 
        THEN
           NEW.parent_id := OLD.parent_id;
           NEW.left_key := OLD.left_key;
           RETURN NEW;
        END IF;
    END IF;
-- Если же указан left_key, а parent_id - нет
    IF _left_key IS NULL OR _left_key = 0 THEN
        SELECT id, left_key, right_key, "level", parent_id 
            INTO _tmp_id, _tmp_left_key, _tmp_right_key, _tmp_level, _tmp_parent_id
            FROM ns_tree
            WHERE tree = NEW.tree AND (right_key = NEW.left_key OR right_key = NEW.left_key - 1)
            LIMIT 1;
        IF _tmp_left_key IS NOT NULL AND _tmp_left_key > 0 AND NEW.left_key - 1 = _tmp_right_key THEN
            NEW.parent_id := _tmp_parent_id;
            _left_key := NEW.left_key;
            _level := _tmp_level;
        ELSIF _tmp_left_key IS NOT NULL AND _tmp_left_key > 0 AND NEW.left_key = _tmp_right_key THEN
            NEW.parent_id := _tmp_id;
            _left_key := NEW.left_key;
            _level := _tmp_level + 1;
        ELSIF NEW.left_key = 1 THEN
            NEW.parent_id := 0;
            _left_key := NEW.left_key;
            _level := 0;
        ELSE
           NEW.parent_id := OLD.parent_id;
           NEW.left_key := OLD.left_key;
           RETURN NEW;
        END IF;
    END IF;
-- Теперь мы знаем куда мы перемещаем дерево
        _skew_level := _level - OLD."level";
    IF _left_key > OLD.left_key THEN
-- Перемещение вверх по дереву
        _skew_edit := _left_key - OLD.left_key - _skew_tree;
        UPDATE ns_tree
            SET left_key =  CASE WHEN right_key <= OLD.right_key
                                 THEN left_key + _skew_edit
                                 ELSE CASE WHEN left_key > OLD.right_key
                                           THEN left_key - _skew_tree
                                           ELSE left_key
                                      END
                            END,
                "level" =   CASE WHEN right_key <= OLD.right_key 
                                 THEN "level" + _skew_level
                                 ELSE "level"
                            END,
                right_key = CASE WHEN right_key <= OLD.right_key 
                                 THEN right_key + _skew_edit
                                 ELSE CASE WHEN right_key < _left_key
                                           THEN right_key - _skew_tree
                                           ELSE right_key
                                      END
                            END,
                _trigger_lock_update = TRUE
            WHERE tree = OLD.tree AND
                  right_key > OLD.left_key AND
                  left_key < _left_key AND
                  id <> OLD.id;
        _left_key := _left_key - _skew_tree;
    ELSE
-- Перемещение вниз по дереву:
        _skew_edit := _left_key - OLD.left_key;
        UPDATE ns_tree
            SET
                right_key = CASE WHEN left_key >= OLD.left_key
                                 THEN right_key + _skew_edit
                                 ELSE CASE WHEN right_key < OLD.left_key
                                           THEN right_key + _skew_tree
                                           ELSE right_key
                                      END
                            END,
                "level" =   CASE WHEN left_key >= OLD.left_key
                                 THEN "level" + _skew_level
                                 ELSE "level"
                            END,
                left_key =  CASE WHEN left_key >= OLD.left_key
                                 THEN left_key + _skew_edit
                                 ELSE CASE WHEN left_key >= _left_key
                                           THEN left_key + _skew_tree
                                           ELSE left_key
                                      END
                            END,
                 _trigger_lock_update = TRUE
            WHERE tree = OLD.tree AND
                  right_key >= _left_key AND
                  left_key < OLD.right_key AND
                  id <> OLD.id;
    END IF;
-- Дерево перестроили, остался только наш текущий узел
    NEW.left_key := _left_key;
    NEW."level" := _level;
    NEW.right_key := _left_key + _skew_tree - 1;
    RETURN NEW;
END;
$BODY$
    LANGUAGE 'plpgsql' VOLATILE
    COST 100;
ALTER FUNCTION ns_tree_before_update_func() OWNER TO postgres;
-----------------------------------------------------



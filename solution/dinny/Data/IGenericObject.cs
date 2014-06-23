using System.Collections.Generic;
using NHibernate.Criterion;

namespace dinny.Core.Data
{
    // Основные методы для работы с объектами данных в базе
    //
    public interface IGenericObject<IdT, T>
    {
        /// <summary>
        /// Получить объект по ключевому полю
        /// </summary>
        /// <param name="id"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        T GetByID(IdT id, string key);

        /// <summary>
        /// Получить список все объекты из таблицы
        /// </summary>
        /// <returns></returns>
        IList<T> GetAll();

        /// <summary>
        /// Получить список объектов, исходя из заданных критериев
        /// </summary>
        /// <param name="Criterion"></param>
        /// <returns></returns>
        IList<T> GetByCriteria(params ICriterion[] Criterion);

        /// <summary>
        /// Сохранить объект
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        void SaveOrUpdate(T entity);

        /// <summary>
        /// Удалить объект
        /// </summary>
        /// <param name="entity"></param>
        void Delete(T entity);
    }
}

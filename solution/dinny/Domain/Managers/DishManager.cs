using System;
using NHibernate;
using NHibernate.Criterion;
using dinny.Core.Data;

namespace dinny.Domain
{
    public partial class DishManager : DomainObject<int, Dish>
    {
        /// <summary>
        /// Проверка использования в каком либо документе
        /// </summary>
        /// <returns>int</returns>
        public void CheckRelations(Dish lpDish)
        {
            // DishNmk
            if (lpDish.DishNmks.Count > 0)
                throw new Exception("Найдены связанные документы(Рецептуры). Удаление запрещено");
        }
    }
}

using NHibernate;
using dinny.Core.Data;

namespace dinny.Domain
{
    public partial class RecipeManager : DomainObject<int, Recipe>
    {
        /// <summary>
        /// Получение MAX номера docNumber
        /// </summary>
        /// <returns>int</returns>
        public int GetMaxDocNumber()
        {
            using (DataContext dataContext = new DataContext())
            {
                IQuery q = dataContext.CurrentSession.CreateSQLQuery("SELECT max(docnumber) from public.\"doc_Recipe\"");
                return q.UniqueResult<int>();
            }
        }
    }
}

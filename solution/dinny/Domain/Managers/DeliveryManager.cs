using NHibernate;
using dinny.Core.Data;

namespace dinny.Domain
{
    public partial class DeliveryManager : DomainObject<int, Delivery>
    {
        /// <summary>
        /// Получение MAX номера docNumber
        /// </summary>
        /// <returns>int</returns>
        public int GetMaxDocNumber()
        {
            using (DataContext dataContext = new DataContext())
            {
                IQuery q = dataContext.CurrentSession.CreateSQLQuery("SELECT max(docnumber) from public.\"doc_Delivery\"");
                return q.UniqueResult<int>();
            }
        }
    }
}

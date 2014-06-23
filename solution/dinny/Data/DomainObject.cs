using System;
using System.Collections;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;

//using DevExpress.Data.Filtering;
//using expertAccounts.Utils;

namespace dinny.Core.Data
{
    public abstract class DomainObject<IdT, T> : IGenericObject<IdT, T>
    {
        #region Generic Search Methods
        
        public T GetByID(IdT id, string key="id")
        {
            try
            {
                using (var dataContext = new DataContext())
                {
                    return dataContext.CurrentSession.CreateCriteria(typeof(T))
                        .Add(Restrictions.Eq(key, id))
                        .UniqueResult<T>();
                }
            }
            catch (Exception exp)
            {
                var lcError = "Ошибка получения данных: \r\n" +
                            (null == exp.InnerException ? exp.Message : "\r\n" + exp.InnerException.Message);
                Program.MainLog.Error(lcError);
                throw new Exception(lcError, exp);
            }
        }
        /// 
        /// This method returns a generic list of data based of search criteria.
        /// Expected parameters are criteria expression type and values 
        /// ie: GetByCriteria(new EqExpression("Table Column", "Search data"))
        /// 
        /// new EqExpression("Table Column", "Search data")
        /// Generic List
        
        public IList<T> GetByCriteria(params ICriterion[] Criterion)
        {
            try
            {
                using (var dataContext = new DataContext())
                {
                    // Get a criteria object to retrieve a collection
                    ICriteria genericCriteria = dataContext.CurrentSession.CreateCriteria(typeof(T));
                    // Add search to a criteria 
                    foreach (ICriterion crit in Criterion)
                    {
                        genericCriteria.Add(crit);
                    }
                    return genericCriteria.List<T>();                    
                }
            }
            catch (Exception exp)
            {
                var lcError = "Ошибка получения данных: \r\n" +
                            (null == exp.InnerException ? exp.Message : "\r\n" + exp.InnerException.Message);
                Program.MainLog.Error(lcError);
                throw new Exception(lcError, exp);
            }
        }
        /// <summary>
        /// Get all records
        /// </summary>
        /// <param name="pageStartRow">The page start row.</param>
        /// <param name="pageSize">Size of the page.</param>
        public IList<T> GetAll()
        {
            try
            {
                using (DataContext dataContext = new DataContext())
                {
                    ICriteria criteria = dataContext.CurrentSession.CreateCriteria(typeof(T));
                    return criteria.List<T>();
                }
            }
            catch (Exception exp)
            {
                var lcError = "Ошибка получения данных: \r\n" +
                            (null == exp.InnerException ? exp.Message : "\r\n" + exp.InnerException.Message);
                Program.MainLog.Error(lcError);
                throw new Exception(lcError, exp);
            }
        }

        /// <summary>
        /// Counts the number of records.
        /// </summary>
        //public int Count<T>(CriteriaOperator filter)
        //{
        //    try
        //    {
        //        using (DataContext dataContext = new DataContext())
        //        {
        //            ICriteria criteria = dataContext.CurrentSession.CreateCriteria(typeof(T));
        //            FilterUtils.FilterToCritereas<T>(ref criteria, filter);
        //            return criteria.SetProjection(NHibernate.Criterion.Projections.RowCount()).UniqueResult<int>();
        //        }
        //    }
        //    catch (Exception exp)
        //    {
        //        var lcError = "Ошибка получения данных: \r\n" +
        //                    (null == exp.InnerException ? exp.Message : "\r\n" + exp.InnerException.Message);
        //        Program.MainLog.Error(lcError);
        //        throw new Exception(lcError, exp);
        //    }            
        //}

        /// <summary>
        /// Get records by page.
        /// </summary>
        /// <param name="pageStartRow">The page start row.</param>
        /// <param name="pageSize">Size of the page.</param>
        //public IList<T> GetPage(int pageStartRow, int pageSize, CriteriaOperator filter = null)
        //{
        //    try
        //    {
        //        using (DataContext dataContext = new DataContext())
        //        {
        //            ICriteria criteria = dataContext.CurrentSession.CreateCriteria(typeof(T));
        //            FilterUtils.FilterToCritereas<T>(ref criteria, filter);
        //            criteria.SetFirstResult(pageStartRow);
        //            criteria.SetMaxResults(pageSize);
        //            return criteria.List<T>();
        //        }
        //    }
        //    catch (Exception exp)
        //    {
        //        var lcError = "Ошибка получения данных: \r\n" +
        //                    (null == exp.InnerException ? exp.Message : "\r\n" + exp.InnerException.Message);
        //        Program.MainLog.Error(lcError);
        //        throw new Exception(lcError, exp);
        //    }            
        //}

        /// <summary>
        /// Get records by page, sorted.
        /// </summary>
        //public IList<T> GetSortedPage(int pageStartRow, int pageSize, CriteriaOperator filter, string sortBy, bool descending)
        //{
        //    IList<T> lcList = null;
        //    try
        //    {            
        //        using (DataContext dataContext = new DataContext())
        //        {
        //            ICriteria criteria = dataContext.CurrentSession.CreateCriteria(typeof(T));
        //            FilterUtils.FilterToCritereas<T>(ref criteria, filter);
        //            if (descending)
        //                criteria.AddOrder(NHibernate.Criterion.Order.Desc(sortBy));
        //            else
        //                criteria.AddOrder(NHibernate.Criterion.Order.Asc(sortBy));

        //            criteria.SetFirstResult(pageStartRow);
        //            criteria.SetMaxResults(pageSize);
        //            return criteria.List<T>();
        //        }
        //    }
        //    catch (Exception exp)
        //    {
        //        var lcError = "Ошибка получения данных: \r\n" +
        //                    (null == exp.InnerException ? exp.Message : "\r\n" + exp.InnerException.Message);
        //        Program.MainLog.Error(lcError);
        //        throw new Exception(lcError, exp);
        //    }            
        //}

        #endregion

        #region Generic Data Manipulation Public Methods
        
        public void Delete(T obj)
        {
            using (var dataContext = new DataContext())
            {
                dataContext.CurrentSession.Delete(obj);
                dataContext.CurrentSession.Flush();
                dataContext.CurrentSession.Close();
            }
        }
        public void SaveOrUpdate(T obj)
        {
            using (var dataContext = new DataContext())
            {
                dataContext.CurrentSession.SaveOrUpdate(obj);
                dataContext.CurrentSession.Flush();
                dataContext.CurrentSession.Close();
            }
        }
        
        #endregion        
    }
}
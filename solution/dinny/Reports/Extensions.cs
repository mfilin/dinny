using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;

namespace dinny.Reports
{
    public static class Extensions
    {
        public static DataTable ToDataTable<T>(this IList<T> data)
        {
            var properties = TypeDescriptor.GetProperties(typeof(T));
            var table = new DataTable();

            foreach (PropertyDescriptor prop in properties)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            foreach (var item in data)
            {
                var row = table.NewRow();

                foreach (PropertyDescriptor prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }

                table.Rows.Add(row);
            }

            return table;
        }

        public static DataSet ToDataSet<T>(this IList<T> list)
        {
            Type elementType = typeof(T);
            DataSet ds = new DataSet();
            DataTable t = new DataTable();
            ds.Tables.Add(t);

            foreach (var propInfo in elementType.GetProperties())
            {
                t.Columns.Add(propInfo.Name, propInfo.PropertyType);
            }

            foreach (T item in list)
            {
                DataRow row = t.NewRow();
                foreach (var propInfo in elementType.GetProperties())
                {
                    row[propInfo.Name] = propInfo.GetValue(item, null);
                }

                t.Rows.Add(row);
            }

            return ds;
        }

    }
}

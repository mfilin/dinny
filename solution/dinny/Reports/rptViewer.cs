using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
using System.Data;
using NHibernate;

using dinny.Core.Data;
using dinny.Domain;
using dinny.Reports.dataview;

using Crystal = CrystalDecisions.CrystalReports.Engine;

namespace dinny.Reports
{
    public static class rptViewer
    {
        public static void ExecOP1(Recipe lpRecipe)
        {
            //frmMessage frmMsg = new frmMessage(2);
            //frmMsg.SetCurrentText = "Инициализация отчета...";
            /* инициализация отчета */

            Reports.rptOP1 report = new rptOP1();
            
            //frmMsg.SetCurrentText = "Загрузка данных...";
            //frmMsg.IncrementBarWithText();
            /* загрузка данных */
            IList<view_rptOP1> data;            
            using (DataContext dc = new DataContext())
            {
                IQuery q = dc.CurrentSession.CreateSQLQuery("SELECT * FROM public.\"view_rptOP1\" WHERE docnum=:p1")
                    .SetResultTransformer(NHibernate.Transform.Transformers.AliasToBean<view_rptOP1>());
                q.SetInt64("p1", lpRecipe.id);
                data = q.List<view_rptOP1>();
            }
            
            report.SetDataSource(data);
            
            //if (frmMsg != null) frmMsg.Close();

            frmReport frm = new frmReport();
            frm.RptViewer.ReportSource = report;
            frm.Show();
        }
    }
}

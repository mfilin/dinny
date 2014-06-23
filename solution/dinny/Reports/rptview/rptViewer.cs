using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
using System.Data;
using NHibernate;

using dinny.Core.Data;
using dinny.Domain;
using dinny.Reports.dataview;
using dinny.Reports.rptview;

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

            rptOP1 report = new rptOP1();
            
            //frmMsg.SetCurrentText = "Загрузка данных...";
            //frmMsg.IncrementBarWithText();
            /* загрузка данных */
            IList<view_rptOP1> data;            
            using (DataContext dc = new DataContext())
            {
                IQuery q = dc.CurrentSession.CreateSQLQuery("SELECT * FROM public.\"view_rptOP1\" WHERE id=:p1")
                    .SetResultTransformer(NHibernate.Transform.Transformers.AliasToBean<view_rptOP1>());
                q.SetInt64("p1", lpRecipe.id);
                data = q.List<view_rptOP1>();
            }
            
            report.SetDataSource(data);
            
            //if (frmMsg != null) frmMsg.Close();

            frmReport frm = new frmReport();
            frm.RptViewer.ReportSource = report;
            frm.SetReportName("Форма ОП-1");
            frm.Show();
        }

        public static void ExecTCard(Dish lpDish)
        {
            //frmMessage frmMsg = new frmMessage(2);
            //frmMsg.SetCurrentText = "Инициализация отчета...";
            /* инициализация отчета */

            rptTCard report = new rptTCard();

            //frmMsg.SetCurrentText = "Загрузка данных...";
            //frmMsg.IncrementBarWithText();
            /* загрузка данных */
            IList<view_rptTCard> data;
            using (DataContext dc = new DataContext())
            {
                IQuery q = dc.CurrentSession.CreateSQLQuery("SELECT * FROM public.\"view_rptTCard\" WHERE docnum=:p1")
                    .SetResultTransformer(NHibernate.Transform.Transformers.AliasToBean<view_rptTCard>());
                q.SetInt32("p1", lpDish.id);
                data = q.List<view_rptTCard>();
            }

            report.SetDataSource(data);
            report.Subreports["rptSubRecipe.rpt"].SetDataSource(data);

            // получение параметров
            Setting NDSet = new SettingManager().GetByCriteria(NHibernate.Criterion.Restrictions.Eq("name", "DIR_NAME"))[0];
            Setting OrgSet = new SettingManager().GetByCriteria(NHibernate.Criterion.Restrictions.Eq("name", "ORG_NAME"))[0];
            Crystal.TextObject nameDir = (Crystal.TextObject)report.Section1.ReportObjects["NameDirParam"];
            nameDir.Text = (null != NDSet) ? NDSet.value : "";
            if (null != OrgSet)
                nameDir.Text += " " + OrgSet.value;

            Setting FIOSet = new SettingManager().GetByCriteria(NHibernate.Criterion.Restrictions.Eq("name", "DIR_FIO"))[0];
            Crystal.TextObject fioDir = (Crystal.TextObject)report.Section1.ReportObjects["FIODirParam"];
            fioDir.Text = (null != FIOSet) ? FIOSet.value : "";

            //if (frmMsg != null) frmMsg.Close();

            frmReport frm = new frmReport();
            frm.RptViewer.ReportSource = report;
            frm.SetReportName("Технико-технологическая карта");
            frm.Show();
        }

        public static void ExecDelivery(Delivery lpDelivery)
        {
            //frmMessage frmMsg = new frmMessage(2);
            //frmMsg.SetCurrentText = "Инициализация отчета...";
            /* инициализация отчета */

            rptDelivery report = new rptDelivery();

            //frmMsg.SetCurrentText = "Загрузка данных...";
            //frmMsg.IncrementBarWithText();
            /* загрузка данных */
            IList<view_rptDelivery> data;
            using (DataContext dc = new DataContext())
            {
                IQuery q = dc.CurrentSession.CreateSQLQuery("SELECT * FROM public.\"view_rptDelivery\" WHERE id=:p1")
                    .SetResultTransformer(NHibernate.Transform.Transformers.AliasToBean<view_rptDelivery>());
                q.SetInt64("p1", lpDelivery.id);
                data = q.List<view_rptDelivery>();
            }

            report.SetDataSource(data);

            // получение параметров
            Setting OrgSet = new SettingManager().GetByCriteria(NHibernate.Criterion.Restrictions.Eq("name", "ORG_NAME"))[0];
            Setting AdrSet = new SettingManager().GetByCriteria(NHibernate.Criterion.Restrictions.Eq("name", "ORG_ADRES"))[0];
            Setting InnSet = new SettingManager().GetByCriteria(NHibernate.Criterion.Restrictions.Eq("name", "INN"))[0];
            Setting SubOrgSet = new SettingManager().GetByCriteria(NHibernate.Criterion.Restrictions.Eq("name", "SUB_ORG"))[0];
            Crystal.TextObject p1 = (Crystal.TextObject)report.Section1.ReportObjects["p1"];
            p1.Text = (null != OrgSet) ? OrgSet.value : "";
            if (null != AdrSet)
                p1.Text += " " + AdrSet.value;
            Crystal.TextObject p2 = (Crystal.TextObject)report.Section1.ReportObjects["p2"];
            p2.Text = (null != InnSet) ? InnSet.value : "";
            Crystal.TextObject p3 = (Crystal.TextObject)report.Section1.ReportObjects["p3"];
            p3.Text = (null != SubOrgSet) ? SubOrgSet.value : "";            

            //if (frmMsg != null) frmMsg.Close();

            frmReport frm = new frmReport();
            frm.RptViewer.ReportSource = report;
            frm.SetReportName("Форма накладной");
            frm.Show();
        }
    }
}

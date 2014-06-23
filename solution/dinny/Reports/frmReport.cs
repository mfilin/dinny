using dinny.Forms;
using System.Windows.Forms;

namespace dinny.Reports
{
    public partial class frmReport : frmChild
    {
        public CrystalDecisions.Windows.Forms.CrystalReportViewer RptViewer
        {
            get { return this.rptViewer; }
            set { this.rptViewer = value; }
        }

        public frmReport()
        {
            InitializeComponent();
        }

        public void SetReportName(string newName)
        {
            foreach (Control control in this.RptViewer.Controls)
                if (control is CrystalDecisions.Windows.Forms.PageView)
                    foreach (Control controlInPage in control.Controls)
                        if (controlInPage is TabControl)
                            foreach (TabPage tabPage in (controlInPage as TabControl).TabPages)
                                if (tabPage.Text == "Главный отчет")
                                {
                                    tabPage.Text = newName;
                                    return;
                                }
        }
    }
}

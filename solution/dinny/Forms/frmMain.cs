using Qios.DevSuite.Components;
using dinny.Forms.ctl;
using dinny.Forms.docs;
using ExtControl2;

namespace dinny.Forms
{
    public partial class frmMain : ExtForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void NMKRibbonItem_ItemActivated(object sender, QCompositeEventArgs e)
        {
            frmNmkList frm1 = new frmNmkList();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void UNITRibbonItem_ItemActivated(object sender, QCompositeEventArgs e)
        {
            frmUnitList frm1 = new frmUnitList();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void DISHRibbonItem_ItemActivated(object sender, QCompositeEventArgs e)
        {
            frmDishList frm1 = new frmDishList();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void PERSONRibbonItem_ItemActivated(object sender, QCompositeEventArgs e)
        {
            frmPersonList frm1 = new frmPersonList();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void RECIPERibbonItem_ItemActivated(object sender, QCompositeEventArgs e)
        {
            frmRecipeList frm1 = new frmRecipeList();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void qRibbonApplicationButton1_ItemActivated(object sender, QCompositeEventArgs e)
        {
            this.qCompositeMenu1.ShowMenu(this.PointToScreen(               
                new System.Drawing.Point(10, 45)));
        }

        private void qCompositeMenuItem1_ItemActivated(object sender, QCompositeEventArgs e)
        {
            frmSettingList frm1 = new frmSettingList();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void qCompositeMenuItem2_ItemActivated(object sender, QCompositeEventArgs e)
        {
            this.Close();
        }

        private void INCOMERibbonItem_ItemActivated(object sender, QCompositeEventArgs e)
        {
            frmDeliveryList frm1 = new frmDeliveryList();
            frm1.MdiParent = this;
            frm1.Show();
        }

        //private void tEST1ToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    frmTypeNmkList frm1 = new frmTypeNmkList();
        //    frm1.MdiParent = this;
        //    frm1.Show();
        //}

        //private void tEST2ToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    frmCountryList frm1 = new frmCountryList();
        //    frm1.MdiParent = this;
        //    frm1.Show();
        //}
    }
}

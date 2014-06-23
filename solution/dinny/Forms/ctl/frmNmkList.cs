using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using dinny.Domain;
using ExtControl2;

namespace dinny.Forms.ctl
{
    public partial class frmNmkList : frmChild
    {
        private Nmk _selected;
        public Nmk Selected
        {
            get
            {
                return (null == this.dataTree.SelectedObject) ? _selected :
                    this.dataTree.SelectedObject as Nmk;
            }
            set
            {
                this._selected = this.dataTree.SelectedObject as Nmk;
            }
        }

        public frmNmkList()
        {
            InitializeComponent();
            this.RefreshGrid();

            this.dataTree.StateImageList = new ImageList();
        }

        private void frmNmkList_Load(object sender, EventArgs e)
        {
            // если есть дочерние узлы, то ставим +
            this.dataTree.CanExpandGetter = x => (x as Nmk).ChildCount() > 0;
            this.dataTree.ChildrenGetter = x => (x as Nmk).Children;
            // картинки для узлов
            this.olvColumnID.ImageGetter = x => (x as Nmk).parent == null && (x as Nmk).parentid == null ? 0 : -1; 
        }

        private void RefreshGrid()
        {
            IList<Nmk> treesource = new NmkManager().GetByCriteria(NHibernate.Criterion.Restrictions.IsNull("parentid")
                                                                    && NHibernate.Criterion.Restrictions.IsNull("parent"));
            this.dataTree.Roots = treesource;
            this.dataTree.RebuildAll(false);
            //if (null != treesource[0])
            //    this.dataTree.Expand(treesource[0]);
            
            //DevExpress.Utils.WaitDialogForm dlg = new DevExpress.Utils.WaitDialogForm("Подождите...", "Загрузка данных");
            //IList<TypeNmk> source = new TypeNmkManager().GetPage(this.loCurrentPage, this.loPageDef, this.gridFilter);
            //if (null != source)
            //{
            //    this.loRowCount = new CaseManager().Count<Case>(this.gridFilter);
            //    this.loPageCount = (int)this.loRowCount / this.loPageDef + 1;
            //    this.grid.DataSource = source;
            //    this.toolStripGrid.Text = "Всего записей: " + this.loRowCount;
            //}
            //dlg.Close();
        }

        private void Edit(Nmk lpEntity)
        {
            frmNmk frm = new frmNmk
            {
                StartPosition = FormStartPosition.CenterParent,
                entity = lpEntity,
                action = eActions.Edit
            };
            if (frm.ShowDialog() == DialogResult.OK)
                this.RefreshGrid();
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (null != this.Selected)
                Edit(this.Selected);
        }

        private void extToolStrip_OnAddClick(object sender, EventArgs e)
        {
            // выделен родитель ?
            Nmk child = null;
            if (null != this.Selected)
            {
                child = new Nmk("", this.Selected);
            }
            else
                child = new Nmk("");

            Edit(child);
        }

        private void extToolStrip_OnEditClick(object sender, EventArgs e)
        {
            if (null != this.Selected)
                Edit(this.Selected);
        }

        private void extToolStrip_OnDeleteClick(object sender, EventArgs e)
        {
            if (null != this.Selected)
            {
                //if (null == this.Selected.Parent && this.Selected.parentid == 0)
                //{
                //    MessageBox.Show("Удаление корневых элементов запрещено", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    return;
                //}

                new NmkManager().Delete(this.Selected);
                this.RefreshGrid();
            }
        }

        private void extToolStrip_OnRefreshClick(object sender, EventArgs e)
        {
            this.RefreshGrid();
        }

        private void dataTree_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // временный хак...запоминаем выбранную позицию
            this.Selected = this.dataTree.SelectedObject as Nmk;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        /* Параметры фильтра */
        //private int loCurrentPage = 0;
        //private int loPageCount = 0;
        //private int loRowCount = 0;
        //private int loPageDef = 100;
        //private CriteriaOperator gridFilter = null;

        //private void grid_EmbeddedNavigator_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        //{
        //    switch (e.Button.ButtonType)
        //    {
        //        case NavigatorButtonType.NextPage:
        //            if (this.loCurrentPage < this.loPageCount)
        //            {
        //                this.loCurrentPage++;
        //                refreshGrid();
        //            }
        //            break;
        //        case NavigatorButtonType.PrevPage:
        //            if (this.loCurrentPage > 0)
        //            {
        //                this.loCurrentPage--;
        //                refreshGrid();
        //            }
        //            break;
        //        case NavigatorButtonType.First:
        //            this.loCurrentPage = 0;
        //            refreshGrid();
        //            break;
        //        case NavigatorButtonType.Last:
        //            this.loCurrentPage = loPageCount;
        //            refreshGrid();
        //            break;
        //    }
        //}

        //private void gridView_ColumnFilterChanged(object sender, EventArgs e)
        //{
        //    if (this.gridView.FilterPanelText == "")
        //        this.gridFilter = null;
        //    this.refreshGrid();
        //}

        //private void gridView_CustomFilterDisplayText(object sender, DevExpress.XtraEditors.Controls.ConvertEditValueEventArgs e)
        //{
        //    CriteriaOperator filter = e.Value as CriteriaOperator; // коллекция фильтров
        //    if (!ReferenceEquals(filter, null))
        //    {
        //        gridFilter = filter;
        //    }
        //    else
        //        gridFilter = null;
        //}
    }
}

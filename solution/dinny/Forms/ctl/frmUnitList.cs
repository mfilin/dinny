﻿using System;
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
    public partial class frmUnitList : frmChild
    {
        public Unit Selected
        {
            get
            {
                if (this.grid.CurrentRow != null)
                {
                    Unit row = this.grid.CurrentRow.DataBoundItem as Unit;
                    return row;
                }
                return null;
            }
        }

        public frmUnitList()
        {
            InitializeComponent();
            this.RefreshGrid();
        }

        private void RefreshGrid()
        {
            IList<Unit> source = new UnitManager().GetAll();
            this.grid.DataSource = source;

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

        private void Edit(Unit lpEntity)
        {
            frmUnit frm = new frmUnit
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
            //if (null != this.Selected)
            //    Edit(this.Selected);

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void extToolStrip_OnAddClick(object sender, EventArgs e)
        {
            Edit(new Unit());
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
                new UnitManager().Delete(this.Selected);
                this.RefreshGrid();
            }
        }

        private void extToolStrip_OnRefreshClick(object sender, EventArgs e)
        {
            this.RefreshGrid();
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

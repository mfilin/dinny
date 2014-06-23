namespace dinny.Forms.docs
{
    partial class frmRecipeList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.extToolStrip = new ExtControl2.ExtFormToolStrip();
            this.grid = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn9 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn10 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn11 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource
            // 
            this.bindingSource.AllowNew = false;
            this.bindingSource.DataSource = typeof(dinny.Domain.Recipe);
            // 
            // extToolStrip
            // 
            this.extToolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.extToolStrip.LabelInfo = "Всего записей:";
            this.extToolStrip.Location = new System.Drawing.Point(12, 34);
            this.extToolStrip.Name = "extToolStrip";
            this.extToolStrip.Size = new System.Drawing.Size(551, 42);
            this.extToolStrip.TabIndex = 2;
            this.extToolStrip.OnRefreshClick += new ExtControl2.ExtFormToolStrip.RefreshClickEventHandler(this.extToolStrip_OnRefreshClick);
            this.extToolStrip.OnAddClick += new ExtControl2.ExtFormToolStrip.AddClickEventHandler(this.extToolStrip_OnAddClick);
            this.extToolStrip.OnEditClick += new ExtControl2.ExtFormToolStrip.EditClickEventHandler(this.extToolStrip_OnEditClick);
            this.extToolStrip.OnDeleteClick += new ExtControl2.ExtFormToolStrip.DeleteClickEventHandler(this.extToolStrip_OnDeleteClick);
            this.extToolStrip.OnPrintClick += new ExtControl2.ExtFormToolStrip.PrintClickEventHandler(this.extToolStrip_OnPrintClick);
            // 
            // grid
            // 
            this.grid.AllColumns.Add(this.olvColumn9);
            this.grid.AllColumns.Add(this.olvColumn10);
            this.grid.AllColumns.Add(this.olvColumn1);
            this.grid.AllColumns.Add(this.olvColumn2);
            this.grid.AllColumns.Add(this.olvColumn11);
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn9,
            this.olvColumn10,
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn11});
            this.grid.EmptyListMsg = "";
            this.grid.FullRowSelect = true;
            this.grid.GridLines = true;
            this.grid.Location = new System.Drawing.Point(12, 78);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(553, 323);
            this.grid.TabIndex = 22;
            this.grid.UseCompatibleStateImageBehavior = false;
            this.grid.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn9
            // 
            this.olvColumn9.AspectName = "docnumber";
            this.olvColumn9.CellPadding = null;
            this.olvColumn9.Text = "Номер документа";
            // 
            // olvColumn10
            // 
            this.olvColumn10.AspectName = "docdate";
            this.olvColumn10.CellPadding = null;
            this.olvColumn10.Text = "Дата документа";
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "quantity";
            this.olvColumn1.CellPadding = null;
            this.olvColumn1.Text = "Порций";
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "sumcost";
            this.olvColumn2.CellPadding = null;
            this.olvColumn2.Text = "Сумма документа";
            // 
            // olvColumn11
            // 
            this.olvColumn11.AspectName = "Org.name";
            this.olvColumn11.CellPadding = null;
            this.olvColumn11.FillsFreeSpace = true;
            this.olvColumn11.Text = "Организация";
            this.olvColumn11.Width = 131;
            // 
            // frmRecipeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(577, 413);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.extToolStrip);
            this.Name = "frmRecipeList";
            this.Text = "frmRecipeList";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private ExtControl2.ExtFormToolStrip extToolStrip;
        private System.Windows.Forms.BindingSource bindingSource;
        private BrightIdeasSoftware.ObjectListView grid;
        private BrightIdeasSoftware.OLVColumn olvColumn9;
        private BrightIdeasSoftware.OLVColumn olvColumn10;
        private BrightIdeasSoftware.OLVColumn olvColumn11;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
    }
}
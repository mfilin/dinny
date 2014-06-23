namespace dinny.Forms.ctl
{
    partial class frmSettingList
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
            this.grid = new ExtControl2.ExtGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.extToolStrip = new ExtControl2.ExtFormToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowUserToDeleteRows = false;
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.AutoGenerateColumns = false;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn});
            this.grid.DataSource = this.bindingSource;
            this.grid.Location = new System.Drawing.Point(12, 82);
            this.grid.Name = "grid";
            this.grid.PaintEmpty = true;
            this.grid.ReadOnly = true;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(551, 319);
            this.grid.TabIndex = 0;
            this.grid.UseFilter = false;
            this.grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.FillWeight = 106.599F;
            this.idDataGridViewTextBoxColumn.HeaderText = "Код";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idDataGridViewTextBoxColumn.Width = 70;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 96.70051F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "value";
            this.valueDataGridViewTextBoxColumn.FillWeight = 96.70051F;
            this.valueDataGridViewTextBoxColumn.HeaderText = "Значение";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            this.valueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSource
            // 
            this.bindingSource.AllowNew = false;
            this.bindingSource.DataSource = typeof(dinny.Domain.Setting);
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
            // 
            // frmSettingList
            // 
            this.Appearance.Shape = new Qios.DevSuite.Components.QShape(Qios.DevSuite.Components.QBaseShapeType.RoundedRectangleShapedWindow);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(577, 413);
            this.Controls.Add(this.extToolStrip);
            this.Controls.Add(this.grid);
            this.Name = "frmSettingList";
            this.Text = "frmSettingList";
            this.Controls.SetChildIndex(this.grid, 0);
            this.Controls.SetChildIndex(this.extToolStrip, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ExtControl2.ExtGridView grid;
        private ExtControl2.ExtFormToolStrip extToolStrip;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
    }
}
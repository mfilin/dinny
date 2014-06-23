namespace dinny.Forms.ctl
{
    partial class frmUnitList
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
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.extToolStrip = new ExtControl2.ExtFormToolStrip();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOKEI = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.snameDataGridViewTextBoxColumn,
            this.idOKEI});
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
            // bindingSource
            // 
            this.bindingSource.AllowNew = false;
            this.bindingSource.DataSource = typeof(dinny.Domain.Unit);
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // snameDataGridViewTextBoxColumn
            // 
            this.snameDataGridViewTextBoxColumn.DataPropertyName = "sname";
            this.snameDataGridViewTextBoxColumn.HeaderText = "Краткое наименование";
            this.snameDataGridViewTextBoxColumn.Name = "snameDataGridViewTextBoxColumn";
            this.snameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idOKEI
            // 
            this.idOKEI.DataPropertyName = "idOKEI";
            this.idOKEI.HeaderText = "Код по ОКЕИ";
            this.idOKEI.Name = "idOKEI";
            this.idOKEI.ReadOnly = true;
            // 
            // frmUnitList
            // 
            this.Appearance.Shape = new Qios.DevSuite.Components.QShape(Qios.DevSuite.Components.QBaseShapeType.RoundedRectangleShapedWindow);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(577, 413);
            this.Controls.Add(this.extToolStrip);
            this.Controls.Add(this.grid);
            this.Name = "frmUnitList";
            this.Text = "frmUnitList";
            this.Controls.SetChildIndex(this.grid, 0);
            this.Controls.SetChildIndex(this.extToolStrip, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ExtControl2.ExtGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private ExtControl2.ExtFormToolStrip extToolStrip;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn snameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOKEI;
    }
}
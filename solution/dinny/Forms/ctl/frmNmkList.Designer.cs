namespace dinny.Forms.ctl
{
    partial class frmNmkList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNmkList));
            BrightIdeasSoftware.HeaderStateStyle headerStateStyle1 = new BrightIdeasSoftware.HeaderStateStyle();
            BrightIdeasSoftware.HeaderStateStyle headerStateStyle2 = new BrightIdeasSoftware.HeaderStateStyle();
            BrightIdeasSoftware.HeaderStateStyle headerStateStyle3 = new BrightIdeasSoftware.HeaderStateStyle();
            this.extToolStrip = new ExtControl2.ExtFormToolStrip();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.headerFormatStyle1 = new BrightIdeasSoftware.HeaderFormatStyle();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.dataTree = new BrightIdeasSoftware.DataTreeListView();
            ((System.ComponentModel.ISupportInitialize)(this.dataTree)).BeginInit();
            this.SuspendLayout();
            // 
            // extToolStrip
            // 
            this.extToolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.extToolStrip.LabelInfo = "Всего записей:";
            this.extToolStrip.Location = new System.Drawing.Point(12, 34);
            this.extToolStrip.Name = "extToolStrip";
            this.extToolStrip.Size = new System.Drawing.Size(655, 42);
            this.extToolStrip.TabIndex = 2;
            this.extToolStrip.OnRefreshClick += new ExtControl2.ExtFormToolStrip.RefreshClickEventHandler(this.extToolStrip_OnRefreshClick);
            this.extToolStrip.OnAddClick += new ExtControl2.ExtFormToolStrip.AddClickEventHandler(this.extToolStrip_OnAddClick);
            this.extToolStrip.OnEditClick += new ExtControl2.ExtFormToolStrip.EditClickEventHandler(this.extToolStrip_OnEditClick);
            this.extToolStrip.OnDeleteClick += new ExtControl2.ExtFormToolStrip.DeleteClickEventHandler(this.extToolStrip_OnDeleteClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder_yellow_1616.png");
            // 
            // headerFormatStyle1
            // 
            this.headerFormatStyle1.Hot = headerStateStyle1;
            this.headerFormatStyle1.Normal = headerStateStyle2;
            this.headerFormatStyle1.Pressed = headerStateStyle3;
            // 
            // olvColumn1
            // 
            this.olvColumn1.CellPadding = null;
            this.olvColumn1.Text = "";
            this.olvColumn1.Width = 20;
            // 
            // olvColumnID
            // 
            this.olvColumnID.AspectName = "id";
            this.olvColumnID.CellPadding = null;
            this.olvColumnID.Text = "Код";
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "unit.name";
            this.olvColumn4.CellPadding = null;
            this.olvColumn4.Text = "Ед.Изм.";
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "name";
            this.olvColumn3.CellPadding = null;
            this.olvColumn3.FillsFreeSpace = true;
            this.olvColumn3.Text = "Наименование";
            // 
            // dataTree
            // 
            this.dataTree.AllColumns.Add(this.olvColumn1);
            this.dataTree.AllColumns.Add(this.olvColumnID);
            this.dataTree.AllColumns.Add(this.olvColumn4);
            this.dataTree.AllColumns.Add(this.olvColumn3);
            this.dataTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTree.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumnID,
            this.olvColumn4,
            this.olvColumn3});
            this.dataTree.DataSource = null;
            this.dataTree.FullRowSelect = true;
            this.dataTree.GridLines = true;
            this.dataTree.KeyAspectName = "id";
            this.dataTree.Location = new System.Drawing.Point(14, 82);
            this.dataTree.MultiSelect = false;
            this.dataTree.Name = "dataTree";
            this.dataTree.OwnerDraw = true;
            this.dataTree.ParentKeyAspectName = "parentid";
            this.dataTree.RootKeyValueString = "";
            this.dataTree.ShowGroups = false;
            this.dataTree.Size = new System.Drawing.Size(655, 293);
            this.dataTree.SmallImageList = this.imageList1;
            this.dataTree.TabIndex = 5;
            this.dataTree.UseCompatibleStateImageBehavior = false;
            this.dataTree.UseTranslucentSelection = true;
            this.dataTree.View = System.Windows.Forms.View.Details;
            this.dataTree.VirtualMode = true;
            this.dataTree.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataTree_MouseDoubleClick);
            // 
            // frmNmkList
            // 
            this.Appearance.Shape = new Qios.DevSuite.Components.QShape(Qios.DevSuite.Components.QBaseShapeType.RoundedRectangleShapedWindow);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(681, 390);
            this.Controls.Add(this.extToolStrip);
            this.Controls.Add(this.dataTree);
            this.Name = "frmNmkList";
            this.Text = "frmNmkList";
            this.Load += new System.EventHandler(this.frmNmkList_Load);
            this.Controls.SetChildIndex(this.dataTree, 0);
            this.Controls.SetChildIndex(this.extToolStrip, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataTree)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ExtControl2.ExtFormToolStrip extToolStrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn sernmksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rftypeproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rfvolumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rfmodeproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rfunitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rftypenmkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rfweightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn articulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rfcountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.ImageList imageList1;
        private BrightIdeasSoftware.HeaderFormatStyle headerFormatStyle1;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumnID;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.DataTreeListView dataTree;
    }
}
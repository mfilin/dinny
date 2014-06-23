namespace dinny.Forms.ctl
{
    partial class frmDish
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDish));
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRecipe = new System.Windows.Forms.TextBox();
            this.txtOutDish = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbRFUnit = new DevExpress.XtraEditors.ButtonEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.gridDishNmk = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.rtbDoc = new ExtendedRichTextBox.RichTextBoxPrintCtrl();
            this.toolstripTProcess = new System.Windows.Forms.ToolStrip();
            this.tbrFont = new System.Windows.Forms.ToolStripButton();
            this.tbrLeft = new System.Windows.Forms.ToolStripButton();
            this.tbrCenter = new System.Windows.Forms.ToolStripButton();
            this.tbrRight = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbrBold = new System.Windows.Forms.ToolStripButton();
            this.tbrItalic = new System.Windows.Forms.ToolStripButton();
            this.tbrUnderline = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tbrFind = new System.Windows.Forms.ToolStripButton();
            this.FontDialog1 = new System.Windows.Forms.FontDialog();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRFUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDishNmk)).BeginInit();
            this.toolstripTProcess.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_OK.Location = new System.Drawing.Point(483, 512);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 0;
            this.btn_OK.Text = "Ok";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(564, 512);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "id", true));
            this.txtID.Location = new System.Drawing.Point(101, 34);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 2;
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(dinny.Domain.Dish);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Код";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Наименование";
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "name", true));
            this.txtName.Location = new System.Drawing.Point(101, 57);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(538, 20);
            this.txtName.TabIndex = 5;
            // 
            // txtSName
            // 
            this.txtSName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "sname", true));
            this.txtSName.Location = new System.Drawing.Point(101, 80);
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(538, 20);
            this.txtSName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Краткое";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Рецепт";
            // 
            // txtRecipe
            // 
            this.txtRecipe.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "recipe", true));
            this.txtRecipe.Location = new System.Drawing.Point(287, 34);
            this.txtRecipe.Name = "txtRecipe";
            this.txtRecipe.Size = new System.Drawing.Size(115, 20);
            this.txtRecipe.TabIndex = 9;
            // 
            // txtOutDish
            // 
            this.txtOutDish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtOutDish.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "outdish", true));
            this.txtOutDish.Location = new System.Drawing.Point(101, 174);
            this.txtOutDish.Name = "txtOutDish";
            this.txtOutDish.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtOutDish.Size = new System.Drawing.Size(106, 20);
            this.txtOutDish.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Выход продукта";
            // 
            // cmbRFUnit
            // 
            this.cmbRFUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbRFUnit.Location = new System.Drawing.Point(265, 173);
            this.cmbRFUnit.Name = "cmbRFUnit";
            this.cmbRFUnit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmbRFUnit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cmbRFUnit.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmbRFUnit.Properties.ReadOnly = true;
            this.cmbRFUnit.Size = new System.Drawing.Size(106, 22);
            this.cmbRFUnit.TabIndex = 20;
            this.cmbRFUnit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmbRFUnit_ButtonClick);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Ед.изм.";
            // 
            // gridDishNmk
            // 
            this.gridDishNmk.AllColumns.Add(this.olvColumn2);
            this.gridDishNmk.AllColumns.Add(this.olvColumn4);
            this.gridDishNmk.AllColumns.Add(this.olvColumn5);
            this.gridDishNmk.AllColumns.Add(this.olvColumn1);
            this.gridDishNmk.AllColumns.Add(this.olvColumn3);
            this.gridDishNmk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDishNmk.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn2,
            this.olvColumn4,
            this.olvColumn5,
            this.olvColumn1,
            this.olvColumn3});
            this.gridDishNmk.EmptyListMsg = "";
            this.gridDishNmk.FullRowSelect = true;
            this.gridDishNmk.GridLines = true;
            this.gridDishNmk.Location = new System.Drawing.Point(15, 132);
            this.gridDishNmk.MultiSelect = false;
            this.gridDishNmk.Name = "gridDishNmk";
            this.gridDishNmk.Size = new System.Drawing.Size(624, 147);
            this.gridDishNmk.TabIndex = 21;
            this.gridDishNmk.UseCompatibleStateImageBehavior = false;
            this.gridDishNmk.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "nmk.name";
            this.olvColumn2.CellPadding = null;
            this.olvColumn2.Text = "Номенклатура";
            this.olvColumn2.Width = 253;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "nmk.unit.name";
            this.olvColumn4.CellPadding = null;
            this.olvColumn4.Text = "Ед.Изм.";
            this.olvColumn4.Width = 85;
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "brutto";
            this.olvColumn5.CellPadding = null;
            this.olvColumn5.Text = "Норма брутто";
            this.olvColumn5.Width = 88;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "netto";
            this.olvColumn1.CellPadding = null;
            this.olvColumn1.Text = "Норма нетто";
            this.olvColumn1.Width = 88;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "loss";
            this.olvColumn3.CellPadding = null;
            this.olvColumn3.FillsFreeSpace = true;
            this.olvColumn3.Text = "Потеря(%)";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAdd.Location = new System.Drawing.Point(564, 104);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(32, 21);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnDelete.Location = new System.Drawing.Point(607, 104);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(32, 22);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Технологический процесс";
            // 
            // rtbDoc
            // 
            this.rtbDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbDoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "tprocess", true));
            this.rtbDoc.Location = new System.Drawing.Point(18, 323);
            this.rtbDoc.Name = "rtbDoc";
            this.rtbDoc.Size = new System.Drawing.Size(621, 183);
            this.rtbDoc.TabIndex = 26;
            this.rtbDoc.Text = "\t\t\t\t\t";
            this.rtbDoc.SelectionChanged += new System.EventHandler(this.rtbDoc_SelectionChanged);
            // 
            // toolstripTProcess
            // 
            this.toolstripTProcess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.toolstripTProcess.Dock = System.Windows.Forms.DockStyle.None;
            this.toolstripTProcess.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbrFont,
            this.tbrLeft,
            this.tbrCenter,
            this.tbrRight,
            this.ToolStripSeparator2,
            this.tbrBold,
            this.tbrItalic,
            this.tbrUnderline,
            this.ToolStripSeparator3,
            this.tbrFind});
            this.toolstripTProcess.Location = new System.Drawing.Point(18, 295);
            this.toolstripTProcess.Name = "toolstripTProcess";
            this.toolstripTProcess.Size = new System.Drawing.Size(208, 25);
            this.toolstripTProcess.TabIndex = 27;
            this.toolstripTProcess.Text = "ToolStrip1";
            // 
            // tbrFont
            // 
            this.tbrFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbrFont.Image = ((System.Drawing.Image)(resources.GetObject("tbrFont.Image")));
            this.tbrFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbrFont.Name = "tbrFont";
            this.tbrFont.Size = new System.Drawing.Size(23, 22);
            this.tbrFont.Text = "Font";
            this.tbrFont.Click += new System.EventHandler(this.tbrFont_Click);
            // 
            // tbrLeft
            // 
            this.tbrLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbrLeft.Image = ((System.Drawing.Image)(resources.GetObject("tbrLeft.Image")));
            this.tbrLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbrLeft.Name = "tbrLeft";
            this.tbrLeft.Size = new System.Drawing.Size(23, 22);
            this.tbrLeft.Text = "Left";
            this.tbrLeft.Click += new System.EventHandler(this.tbrLeft_Click);
            // 
            // tbrCenter
            // 
            this.tbrCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbrCenter.Image = ((System.Drawing.Image)(resources.GetObject("tbrCenter.Image")));
            this.tbrCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbrCenter.Name = "tbrCenter";
            this.tbrCenter.Size = new System.Drawing.Size(23, 22);
            this.tbrCenter.Text = "Center";
            this.tbrCenter.Click += new System.EventHandler(this.tbrCenter_Click);
            // 
            // tbrRight
            // 
            this.tbrRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbrRight.Image = ((System.Drawing.Image)(resources.GetObject("tbrRight.Image")));
            this.tbrRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbrRight.Name = "tbrRight";
            this.tbrRight.Size = new System.Drawing.Size(23, 22);
            this.tbrRight.Text = "Right";
            this.tbrRight.Click += new System.EventHandler(this.tbrRight_Click);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tbrBold
            // 
            this.tbrBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbrBold.Image = ((System.Drawing.Image)(resources.GetObject("tbrBold.Image")));
            this.tbrBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbrBold.Name = "tbrBold";
            this.tbrBold.Size = new System.Drawing.Size(23, 22);
            this.tbrBold.Text = "Bold";
            this.tbrBold.Click += new System.EventHandler(this.tbrBold_Click);
            // 
            // tbrItalic
            // 
            this.tbrItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbrItalic.Image = ((System.Drawing.Image)(resources.GetObject("tbrItalic.Image")));
            this.tbrItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbrItalic.Name = "tbrItalic";
            this.tbrItalic.Size = new System.Drawing.Size(23, 22);
            this.tbrItalic.Text = "Italic";
            this.tbrItalic.Click += new System.EventHandler(this.tbrItalic_Click);
            // 
            // tbrUnderline
            // 
            this.tbrUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbrUnderline.Image = ((System.Drawing.Image)(resources.GetObject("tbrUnderline.Image")));
            this.tbrUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbrUnderline.Name = "tbrUnderline";
            this.tbrUnderline.Size = new System.Drawing.Size(23, 22);
            this.tbrUnderline.Text = "Underline";
            this.tbrUnderline.Click += new System.EventHandler(this.tbrUnderline_Click);
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tbrFind
            // 
            this.tbrFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbrFind.Enabled = false;
            this.tbrFind.Image = ((System.Drawing.Image)(resources.GetObject("tbrFind.Image")));
            this.tbrFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbrFind.Name = "tbrFind";
            this.tbrFind.Size = new System.Drawing.Size(23, 22);
            this.tbrFind.Text = "Find";
            // 
            // frmDish
            // 
            this.Appearance.Shape = new Qios.DevSuite.Components.QShape(Qios.DevSuite.Components.QBaseShapeType.RoundedRectangleShapedWindow);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(651, 547);
            this.Controls.Add(this.toolstripTProcess);
            this.Controls.Add(this.rtbDoc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gridDishNmk);
            this.Controls.Add(this.cmbRFUnit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOutDish);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRecipe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btn_OK);
            this.Name = "frmDish";
            this.Text = "frmDish";
            this.Load += new System.EventHandler(this.xfrmSetting_Load);
            this.Controls.SetChildIndex(this.btn_OK, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.btn_Cancel, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtSName, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtRecipe, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtOutDish, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.cmbRFUnit, 0);
            this.Controls.SetChildIndex(this.gridDishNmk, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.rtbDoc, 0);
            this.Controls.SetChildIndex(this.toolstripTProcess, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRFUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDishNmk)).EndInit();
            this.toolstripTProcess.ResumeLayout(false);
            this.toolstripTProcess.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.TextBox txtSName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRecipe;
        private System.Windows.Forms.TextBox txtOutDish;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.ButtonEdit cmbRFUnit;
        private System.Windows.Forms.Label label6;
        private BrightIdeasSoftware.ObjectListView gridDishNmk;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private System.Windows.Forms.Label label7;
        private ExtendedRichTextBox.RichTextBoxPrintCtrl rtbDoc;
        internal System.Windows.Forms.ToolStrip toolstripTProcess;
        internal System.Windows.Forms.ToolStripButton tbrFont;
        internal System.Windows.Forms.ToolStripButton tbrLeft;
        internal System.Windows.Forms.ToolStripButton tbrCenter;
        internal System.Windows.Forms.ToolStripButton tbrRight;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        internal System.Windows.Forms.ToolStripButton tbrBold;
        internal System.Windows.Forms.ToolStripButton tbrItalic;
        internal System.Windows.Forms.ToolStripButton tbrUnderline;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
        internal System.Windows.Forms.ToolStripButton tbrFind;
        internal System.Windows.Forms.FontDialog FontDialog1;
    }
}
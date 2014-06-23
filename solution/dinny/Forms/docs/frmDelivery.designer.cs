namespace dinny.Forms.docs
{
    partial class frmDelivery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDelivery));
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.gridDeliveryNmkCost = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrice = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSumDoc = new System.Windows.Forms.TextBox();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.cmbDate = new DevExpress.XtraEditors.DateEdit();
            this.cmbDepart = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDeliveryNmkCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDepart.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_OK.Location = new System.Drawing.Point(407, 347);
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
            this.btn_Cancel.Location = new System.Drawing.Point(488, 347);
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
            this.bindingSource.DataSource = typeof(dinny.Domain.Delivery);
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
            // gridDeliveryNmkCost
            // 
            this.gridDeliveryNmkCost.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.gridDeliveryNmkCost.AllColumns.Add(this.olvColumn1);
            this.gridDeliveryNmkCost.AllColumns.Add(this.olvColumn2);
            this.gridDeliveryNmkCost.AllColumns.Add(this.olvColumn3);
            this.gridDeliveryNmkCost.AllColumns.Add(this.olvColumn4);
            this.gridDeliveryNmkCost.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
            this.gridDeliveryNmkCost.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3,
            this.olvColumn4});
            this.gridDeliveryNmkCost.EmptyListMsg = "";
            this.gridDeliveryNmkCost.FullRowSelect = true;
            this.gridDeliveryNmkCost.GridLines = true;
            this.gridDeliveryNmkCost.Location = new System.Drawing.Point(15, 88);
            this.gridDeliveryNmkCost.MultiSelect = false;
            this.gridDeliveryNmkCost.Name = "gridDeliveryNmkCost";
            this.gridDeliveryNmkCost.Size = new System.Drawing.Size(550, 223);
            this.gridDeliveryNmkCost.TabIndex = 21;
            this.gridDeliveryNmkCost.UseCompatibleStateImageBehavior = false;
            this.gridDeliveryNmkCost.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Nmk.name";
            this.olvColumn1.CellPadding = null;
            this.olvColumn1.IsEditable = false;
            this.olvColumn1.Text = "Номенклатура";
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "quantity";
            this.olvColumn2.CellPadding = null;
            this.olvColumn2.Text = "Кол-во";
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "price";
            this.olvColumn3.CellPadding = null;
            this.olvColumn3.Text = "Цена пост.";
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "pricep";
            this.olvColumn4.CellPadding = null;
            this.olvColumn4.FillsFreeSpace = true;
            this.olvColumn4.Text = "Цена прод.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(340, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Сумма поставки";
            // 
            // txtPrice
            // 
            this.txtPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "docNumber", true));
            this.txtPrice.Location = new System.Drawing.Point(299, 34);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtPrice.Properties.Appearance.Options.UseBackColor = true;
            this.txtPrice.Properties.Mask.EditMask = "\\d{1,8}((,|\\.)\\d{2})?";
            this.txtPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtPrice.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPrice.Properties.ReadOnly = true;
            this.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "№ документа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "На дату";
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnDelete.Location = new System.Drawing.Point(530, 60);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(32, 22);
            this.btnDelete.TabIndex = 42;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAdd.Location = new System.Drawing.Point(454, 60);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(32, 21);
            this.btnAdd.TabIndex = 41;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Продукция в";
            // 
            // txtSumDoc
            // 
            this.txtSumDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtSumDoc.Location = new System.Drawing.Point(459, 317);
            this.txtSumDoc.Name = "txtSumDoc";
            this.txtSumDoc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSumDoc.Size = new System.Drawing.Size(106, 20);
            this.txtSumDoc.TabIndex = 44;
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnEdit.Location = new System.Drawing.Point(492, 60);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(32, 21);
            this.btnEdit.TabIndex = 45;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cmbDate
            // 
            this.cmbDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "docdate", true));
            this.cmbDate.EditValue = null;
            this.cmbDate.Location = new System.Drawing.Point(463, 34);
            this.cmbDate.Name = "cmbDate";
            this.cmbDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cmbDate.Size = new System.Drawing.Size(100, 20);
            this.cmbDate.TabIndex = 46;
            // 
            // cmbDepart
            // 
            this.cmbDepart.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "department", true));
            this.cmbDepart.Location = new System.Drawing.Point(101, 60);
            this.cmbDepart.Name = "cmbDepart";
            this.cmbDepart.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cmbDepart.Properties.Appearance.Options.UseFont = true;
            this.cmbDepart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDepart.Properties.Items.AddRange(new object[] {
            "БАР",
            "КУХНЯ"});
            this.cmbDepart.Size = new System.Drawing.Size(100, 20);
            this.cmbDepart.TabIndex = 47;
            // 
            // frmDelivery
            // 
            this.AcceptButton = this.btn_OK;
            this.Appearance.Shape = new Qios.DevSuite.Components.QShape(Qios.DevSuite.Components.QBaseShapeType.RoundedRectangleShapedWindow);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(574, 382);
            this.Controls.Add(this.cmbDepart);
            this.Controls.Add(this.cmbDate);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtSumDoc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gridDeliveryNmkCost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btn_OK);
            this.Name = "frmDelivery";
            this.Text = "frmDelivery";
            this.Load += new System.EventHandler(this.xfrmSetting_Load);
            this.Controls.SetChildIndex(this.btn_OK, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.btn_Cancel, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.gridDeliveryNmkCost, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtPrice, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtSumDoc, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.cmbDate, 0);
            this.Controls.SetChildIndex(this.cmbDepart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDeliveryNmkCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDepart.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource;
        private BrightIdeasSoftware.ObjectListView gridDeliveryNmkCost;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSumDoc;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.DateEdit cmbDate;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbDepart;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
    }
}
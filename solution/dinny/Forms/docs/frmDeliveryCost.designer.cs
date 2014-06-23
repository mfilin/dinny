namespace dinny.Forms.docs
{
    partial class frmDeliveryCost
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
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbRFNmk = new DevExpress.XtraEditors.ButtonEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRFUnit = new DevExpress.XtraEditors.ButtonEdit();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPCitchen = new System.Windows.Forms.TextBox();
            this.txtPBar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRFNmk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRFUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_OK.Location = new System.Drawing.Point(418, 88);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(63, 23);
            this.btn_OK.TabIndex = 0;
            this.btn_OK.Text = "Ok";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(487, 88);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(64, 23);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(dinny.Domain.DeliveryCost);
            // 
            // cmbRFNmk
            // 
            this.cmbRFNmk.Location = new System.Drawing.Point(99, 34);
            this.cmbRFNmk.Name = "cmbRFNmk";
            this.cmbRFNmk.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmbRFNmk.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cmbRFNmk.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmbRFNmk.Properties.ReadOnly = true;
            this.cmbRFNmk.Size = new System.Drawing.Size(343, 22);
            this.cmbRFNmk.TabIndex = 1;
            this.cmbRFNmk.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmbRFNmk_ButtonClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Номенклатура";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Кол-во";
            // 
            // cmbRFUnit
            // 
            this.cmbRFUnit.EditValue = "Ед.Изм.";
            this.cmbRFUnit.Location = new System.Drawing.Point(448, 34);
            this.cmbRFUnit.Name = "cmbRFUnit";
            this.cmbRFUnit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmbRFUnit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cmbRFUnit.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmbRFUnit.Properties.ReadOnly = true;
            this.cmbRFUnit.Size = new System.Drawing.Size(103, 22);
            this.cmbRFUnit.TabIndex = 2;
            this.cmbRFUnit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmbRFUnit_ButtonClick);
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtQuantity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "quantity", true));
            this.txtQuantity.Location = new System.Drawing.Point(15, 88);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtQuantity.Size = new System.Drawing.Size(106, 20);
            this.txtQuantity.TabIndex = 3;
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(-18, -18);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Size = new System.Drawing.Size(100, 20);
            this.comboBoxEdit1.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Цена поставки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Цена продажи";
            // 
            // txtPCitchen
            // 
            this.txtPCitchen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtPCitchen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "price", true));
            this.txtPCitchen.Location = new System.Drawing.Point(140, 88);
            this.txtPCitchen.Name = "txtPCitchen";
            this.txtPCitchen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPCitchen.Size = new System.Drawing.Size(106, 20);
            this.txtPCitchen.TabIndex = 4;
            // 
            // txtPBar
            // 
            this.txtPBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtPBar.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "pricep", true));
            this.txtPBar.Location = new System.Drawing.Point(261, 88);
            this.txtPBar.Name = "txtPBar";
            this.txtPBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPBar.Size = new System.Drawing.Size(106, 20);
            this.txtPBar.TabIndex = 6;
            // 
            // frmDeliveryCost
            // 
            this.AcceptButton = this.btn_OK;
            this.Appearance.Shape = new Qios.DevSuite.Components.QShape(Qios.DevSuite.Components.QBaseShapeType.RoundedRectangleShapedWindow);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(560, 120);
            this.Controls.Add(this.txtPBar);
            this.Controls.Add(this.txtPCitchen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxEdit1);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.cmbRFUnit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbRFNmk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Name = "frmDeliveryCost";
            this.Text = "frmDeliveryCost";
            this.Load += new System.EventHandler(this.xfrmSetting_Load);
            this.Controls.SetChildIndex(this.btn_OK, 0);
            this.Controls.SetChildIndex(this.btn_Cancel, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.cmbRFNmk, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cmbRFUnit, 0);
            this.Controls.SetChildIndex(this.txtQuantity, 0);
            this.Controls.SetChildIndex(this.comboBoxEdit1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtPCitchen, 0);
            this.Controls.SetChildIndex(this.txtPBar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRFNmk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRFUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.BindingSource bindingSource;
        private DevExpress.XtraEditors.ButtonEdit cmbRFNmk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.ButtonEdit cmbRFUnit;
        private System.Windows.Forms.TextBox txtQuantity;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPCitchen;
        private System.Windows.Forms.TextBox txtPBar;
    }
}
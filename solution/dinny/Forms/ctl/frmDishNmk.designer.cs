namespace dinny.Forms.ctl
{
    partial class frmDishNmk
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
            this.label2 = new System.Windows.Forms.Label();
            this.qComboBox1 = new Qios.DevSuite.Components.QComboBox();
            this.txtBrutto = new Qios.DevSuite.Components.QTextBox();
            this.cmbRFNmk = new DevExpress.XtraEditors.ButtonEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNetto = new Qios.DevSuite.Components.QTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLoss = new Qios.DevSuite.Components.QTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRFNmk.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_OK.Location = new System.Drawing.Point(315, 93);
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
            this.btn_Cancel.Location = new System.Drawing.Point(396, 93);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(dinny.Domain.DishNmk);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Наименование";
            // 
            // qComboBox1
            // 
            this.qComboBox1.Location = new System.Drawing.Point(-18, -18);
            this.qComboBox1.Name = "qComboBox1";
            this.qComboBox1.Size = new System.Drawing.Size(100, 19);
            this.qComboBox1.TabIndex = 17;
            // 
            // txtBrutto
            // 
            this.txtBrutto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "brutto", true));
            this.txtBrutto.Location = new System.Drawing.Point(101, 62);
            this.txtBrutto.Name = "txtBrutto";
            this.txtBrutto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBrutto.Size = new System.Drawing.Size(99, 19);
            this.txtBrutto.TabIndex = 15;
            // 
            // cmbRFNmk
            // 
            this.cmbRFNmk.Location = new System.Drawing.Point(101, 34);
            this.cmbRFNmk.Name = "cmbRFNmk";
            this.cmbRFNmk.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmbRFNmk.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cmbRFNmk.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmbRFNmk.Properties.ReadOnly = true;
            this.cmbRFNmk.Size = new System.Drawing.Size(370, 22);
            this.cmbRFNmk.TabIndex = 21;
            this.cmbRFNmk.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmbRFNmk_ButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Брутто";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Нетто";
            // 
            // txtNetto
            // 
            this.txtNetto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "netto", true));
            this.txtNetto.Location = new System.Drawing.Point(101, 87);
            this.txtNetto.Name = "txtNetto";
            this.txtNetto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNetto.Size = new System.Drawing.Size(99, 19);
            this.txtNetto.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Потери";
            // 
            // txtLoss
            // 
            this.txtLoss.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "loss", true));
            this.txtLoss.Location = new System.Drawing.Point(372, 62);
            this.txtLoss.Name = "txtLoss";
            this.txtLoss.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLoss.Size = new System.Drawing.Size(99, 19);
            this.txtLoss.TabIndex = 25;
            // 
            // frmDishNmk
            // 
            this.AcceptButton = this.btn_OK;
            this.Appearance.Shape = new Qios.DevSuite.Components.QShape(Qios.DevSuite.Components.QBaseShapeType.RoundedRectangleShapedWindow);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(477, 128);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLoss);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNetto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbRFNmk);
            this.Controls.Add(this.qComboBox1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.txtBrutto);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmDishNmk";
            this.Text = "frmDishNmk";
            this.Load += new System.EventHandler(this.xfrmSetting_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btn_OK, 0);
            this.Controls.SetChildIndex(this.txtBrutto, 0);
            this.Controls.SetChildIndex(this.btn_Cancel, 0);
            this.Controls.SetChildIndex(this.qComboBox1, 0);
            this.Controls.SetChildIndex(this.cmbRFNmk, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtNetto, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtLoss, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRFNmk.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label2;
        private Qios.DevSuite.Components.QComboBox qComboBox1;
        private Qios.DevSuite.Components.QTextBox txtBrutto;
        private DevExpress.XtraEditors.ButtonEdit cmbRFNmk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Qios.DevSuite.Components.QTextBox txtNetto;
        private System.Windows.Forms.Label label4;
        private Qios.DevSuite.Components.QTextBox txtLoss;
    }
}
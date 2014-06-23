namespace dinny.Forms.ctl
{
    partial class frmPerson
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new Qios.DevSuite.Components.QTextBox();
            this.txtName = new Qios.DevSuite.Components.QTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInn = new Qios.DevSuite.Components.QTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKpp = new Qios.DevSuite.Components.QTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_OK.Location = new System.Drawing.Point(328, 108);
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
            this.btn_Cancel.Location = new System.Drawing.Point(409, 108);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(dinny.Domain.Person);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
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
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "id", true));
            this.txtID.Location = new System.Drawing.Point(101, 35);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 19);
            this.txtID.TabIndex = 13;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "name", true));
            this.txtName.Location = new System.Drawing.Point(101, 57);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(380, 19);
            this.txtName.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Код ИНН";
            // 
            // txtInn
            // 
            this.txtInn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "inn", true));
            this.txtInn.Location = new System.Drawing.Point(101, 80);
            this.txtInn.Name = "txtInn";
            this.txtInn.Size = new System.Drawing.Size(150, 19);
            this.txtInn.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "КПП";
            // 
            // txtKpp
            // 
            this.txtKpp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "kpp", true));
            this.txtKpp.Location = new System.Drawing.Point(331, 80);
            this.txtKpp.Name = "txtKpp";
            this.txtKpp.Size = new System.Drawing.Size(150, 19);
            this.txtKpp.TabIndex = 19;
            // 
            // frmPerson
            // 
            this.AcceptButton = this.btn_OK;
            this.Appearance.Shape = new Qios.DevSuite.Components.QShape(Qios.DevSuite.Components.QBaseShapeType.RoundedRectangleShapedWindow);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(496, 143);
            this.Controls.Add(this.txtKpp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtInn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Name = "frmPerson";
            this.Text = "frmPerson";
            this.Load += new System.EventHandler(this.frmPerson_Load);
            this.Controls.SetChildIndex(this.btn_OK, 0);
            this.Controls.SetChildIndex(this.btn_Cancel, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtInn, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtKpp, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Qios.DevSuite.Components.QTextBox txtID;
        private Qios.DevSuite.Components.QTextBox txtName;
        private System.Windows.Forms.Label label3;
        private Qios.DevSuite.Components.QTextBox txtInn;
        private System.Windows.Forms.Label label4;
        private Qios.DevSuite.Components.QTextBox txtKpp;
    }
}
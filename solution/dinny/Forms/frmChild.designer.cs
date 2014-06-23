namespace dinny.Forms
{
    partial class frmChild
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
            this.qRibbonCaption1 = new Qios.DevSuite.Components.Ribbon.QRibbonCaption();
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonCaption1)).BeginInit();
            this.SuspendLayout();
            // 
            // qRibbonCaption1
            // 
            this.qRibbonCaption1.Location = new System.Drawing.Point(0, 0);
            this.qRibbonCaption1.Name = "qRibbonCaption1";
            this.qRibbonCaption1.Size = new System.Drawing.Size(410, 28);
            this.qRibbonCaption1.TabIndex = 0;
            this.qRibbonCaption1.Text = "qRibbonCaption1";
            // 
            // frmChild
            // 
            this.Appearance.Shape = new Qios.DevSuite.Components.QShape(Qios.DevSuite.Components.QBaseShapeType.RoundedRectangleShapedWindow);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 349);
            this.Controls.Add(this.qRibbonCaption1);
            this.Name = "frmChild";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "qRibbonCaption1";
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonCaption1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Qios.DevSuite.Components.Ribbon.QRibbonCaption qRibbonCaption1;

    }
}
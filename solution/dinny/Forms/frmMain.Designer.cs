namespace dinny.Forms
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.qRibbonCaption1 = new Qios.DevSuite.Components.Ribbon.QRibbonCaption();
            this.qRibbonApplicationButton1 = new Qios.DevSuite.Components.Ribbon.QRibbonApplicationButton();
            this.qMAINRibbon = new Qios.DevSuite.Components.Ribbon.QRibbon();
            this.qDOCRibbonPage = new Qios.DevSuite.Components.Ribbon.QRibbonPage();
            this.qRibbonPanel3 = new Qios.DevSuite.Components.Ribbon.QRibbonPanel();
            this.RECIPERibbonItem = new Qios.DevSuite.Components.Ribbon.QRibbonItem();
            this.INCOMERibbonItem = new Qios.DevSuite.Components.Ribbon.QRibbonItem();
            this.qREFRibbonPage = new Qios.DevSuite.Components.Ribbon.QRibbonPage();
            this.qRibbonPanel1 = new Qios.DevSuite.Components.Ribbon.QRibbonPanel();
            this.NMKRibbonItem = new Qios.DevSuite.Components.Ribbon.QRibbonItem();
            this.UNITRibbonItem = new Qios.DevSuite.Components.Ribbon.QRibbonItem();
            this.DISHRibbonItem = new Qios.DevSuite.Components.Ribbon.QRibbonItem();
            this.qRibbonPanel2 = new Qios.DevSuite.Components.Ribbon.QRibbonPanel();
            this.PERSONRibbonItem = new Qios.DevSuite.Components.Ribbon.QRibbonItem();
            this.qREPRibbonPage = new Qios.DevSuite.Components.Ribbon.QRibbonPage();
            this.qRibbonItem2 = new Qios.DevSuite.Components.Ribbon.QRibbonItem();
            this.qCompositeMenu1 = new Qios.DevSuite.Components.QCompositeMenu();
            this.qCompositeMenuItem1 = new Qios.DevSuite.Components.QCompositeMenuItem();
            this.qCompositeMenuItem2 = new Qios.DevSuite.Components.QCompositeMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonCaption1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qMAINRibbon)).BeginInit();
            this.qMAINRibbon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qDOCRibbonPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qREFRibbonPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qREPRibbonPage)).BeginInit();
            this.SuspendLayout();
            // 
            // qRibbonCaption1
            // 
            this.qRibbonCaption1.ApplicationButton = this.qRibbonApplicationButton1;
            this.qRibbonCaption1.Configuration.IconConfiguration.Visible = Qios.DevSuite.Components.QTristateBool.False;
            this.qRibbonCaption1.Location = new System.Drawing.Point(0, 0);
            this.qRibbonCaption1.Name = "qRibbonCaption1";
            this.qRibbonCaption1.Size = new System.Drawing.Size(794, 28);
            this.qRibbonCaption1.TabIndex = 2;
            this.qRibbonCaption1.Text = "dinny";
            // 
            // qRibbonApplicationButton1
            // 
            this.qRibbonApplicationButton1.ItemActivated += new Qios.DevSuite.Components.QCompositeEventHandler(this.qRibbonApplicationButton1_ItemActivated);
            // 
            // qMAINRibbon
            // 
            this.qMAINRibbon.ActiveTabPage = this.qDOCRibbonPage;
            this.qMAINRibbon.Caption = this.qRibbonCaption1;
            this.qMAINRibbon.Controls.Add(this.qREFRibbonPage);
            this.qMAINRibbon.Controls.Add(this.qDOCRibbonPage);
            this.qMAINRibbon.Controls.Add(this.qREPRibbonPage);
            this.qMAINRibbon.Cursor = System.Windows.Forms.Cursors.Default;
            this.qMAINRibbon.Dock = System.Windows.Forms.DockStyle.Top;
            this.qMAINRibbon.Form = this;
            this.qMAINRibbon.Location = new System.Drawing.Point(0, 28);
            this.qMAINRibbon.Name = "qMAINRibbon";
            this.qMAINRibbon.PersistGuid = new System.Guid("198d6059-e168-4294-99b2-5822d53c1ffe");
            this.qMAINRibbon.Size = new System.Drawing.Size(794, 141);
            this.qMAINRibbon.TabIndex = 3;
            this.qMAINRibbon.TabStripConfiguration.HelpButtonVisible = false;
            this.qMAINRibbon.Text = "qRibbon1";
            // 
            // qDOCRibbonPage
            // 
            this.qDOCRibbonPage.ButtonOrder = 0;
            this.qDOCRibbonPage.Items.Add(this.qRibbonPanel3);
            this.qDOCRibbonPage.Location = new System.Drawing.Point(2, 31);
            this.qDOCRibbonPage.Name = "qDOCRibbonPage";
            this.qDOCRibbonPage.PersistGuid = new System.Guid("fbabc3dd-4efd-449c-9a98-928ca1557ade");
            this.qDOCRibbonPage.Size = new System.Drawing.Size(788, 106);
            this.qDOCRibbonPage.Text = "Документы";
            // 
            // qRibbonPanel3
            // 
            this.qRibbonPanel3.Items.Add(this.RECIPERibbonItem);
            this.qRibbonPanel3.Items.Add(this.INCOMERibbonItem);
            this.qRibbonPanel3.Title = "";
            // 
            // RECIPERibbonItem
            // 
            this.RECIPERibbonItem.Configuration.AlignmentVertical = Qios.DevSuite.Components.QPartAlignment.Centered;
            this.RECIPERibbonItem.Configuration.Direction = Qios.DevSuite.Components.QPartDirection.Vertical;
            this.RECIPERibbonItem.Configuration.IconConfiguration.IconSize = new System.Drawing.Size(32, 32);
            this.RECIPERibbonItem.Configuration.MinimumSize = new System.Drawing.Size(22, 60);
            this.RECIPERibbonItem.Icon = ((System.Drawing.Icon)(resources.GetObject("RECIPERibbonItem.Icon")));
            this.RECIPERibbonItem.Title = "Рецептура";
            this.RECIPERibbonItem.ItemActivated += new Qios.DevSuite.Components.QCompositeEventHandler(this.RECIPERibbonItem_ItemActivated);
            // 
            // INCOMERibbonItem
            // 
            this.INCOMERibbonItem.Configuration.AlignmentVertical = Qios.DevSuite.Components.QPartAlignment.Centered;
            this.INCOMERibbonItem.Configuration.Direction = Qios.DevSuite.Components.QPartDirection.Vertical;
            this.INCOMERibbonItem.Configuration.IconConfiguration.IconSize = new System.Drawing.Size(32, 32);
            this.INCOMERibbonItem.Configuration.MinimumSize = new System.Drawing.Size(22, 60);
            this.INCOMERibbonItem.Icon = ((System.Drawing.Icon)(resources.GetObject("INCOMERibbonItem.Icon")));
            this.INCOMERibbonItem.Title = "Поступление";
            this.INCOMERibbonItem.ItemActivated += new Qios.DevSuite.Components.QCompositeEventHandler(this.INCOMERibbonItem_ItemActivated);
            // 
            // qREFRibbonPage
            // 
            this.qREFRibbonPage.ButtonOrder = 1;
            this.qREFRibbonPage.Configuration.HotkeyPrefixVisibilityType = Qios.DevSuite.Components.QHotkeyVisibilityType.Never;
            this.qREFRibbonPage.Configuration.MaximumSize = new System.Drawing.Size(0, 100);
            this.qREFRibbonPage.Configuration.MinimumSize = new System.Drawing.Size(0, 100);
            this.qREFRibbonPage.Items.Add(this.qRibbonPanel1);
            this.qREFRibbonPage.Items.Add(this.qRibbonPanel2);
            this.qREFRibbonPage.Location = new System.Drawing.Point(2, 31);
            this.qREFRibbonPage.MaximumSize = new System.Drawing.Size(0, 100);
            this.qREFRibbonPage.Name = "qREFRibbonPage";
            this.qREFRibbonPage.PersistGuid = new System.Guid("4fe3c3f7-7b0e-47f9-b31c-ca032e8bb64a");
            this.qREFRibbonPage.Size = new System.Drawing.Size(788, 100);
            this.qREFRibbonPage.Text = "Справочники";
            // 
            // qRibbonPanel1
            // 
            this.qRibbonPanel1.Configuration.MinimumSize = new System.Drawing.Size(0, 80);
            this.qRibbonPanel1.Items.Add(this.NMKRibbonItem);
            this.qRibbonPanel1.Items.Add(this.UNITRibbonItem);
            this.qRibbonPanel1.Items.Add(this.DISHRibbonItem);
            this.qRibbonPanel1.Title = "Товары";
            // 
            // NMKRibbonItem
            // 
            this.NMKRibbonItem.Configuration.AlignmentVertical = Qios.DevSuite.Components.QPartAlignment.Centered;
            this.NMKRibbonItem.Configuration.Direction = Qios.DevSuite.Components.QPartDirection.Vertical;
            this.NMKRibbonItem.Configuration.IconConfiguration.IconSize = new System.Drawing.Size(32, 32);
            this.NMKRibbonItem.Configuration.MinimumSize = new System.Drawing.Size(22, 60);
            this.NMKRibbonItem.Icon = ((System.Drawing.Icon)(resources.GetObject("NMKRibbonItem.Icon")));
            this.NMKRibbonItem.Title = "Продукты";
            this.NMKRibbonItem.ItemActivated += new Qios.DevSuite.Components.QCompositeEventHandler(this.NMKRibbonItem_ItemActivated);
            // 
            // UNITRibbonItem
            // 
            this.UNITRibbonItem.Configuration.AlignmentHorizontal = Qios.DevSuite.Components.QPartAlignment.Far;
            this.UNITRibbonItem.Configuration.AlignmentVertical = Qios.DevSuite.Components.QPartAlignment.Centered;
            this.UNITRibbonItem.Configuration.Direction = Qios.DevSuite.Components.QPartDirection.Vertical;
            this.UNITRibbonItem.Configuration.IconConfiguration.IconSize = new System.Drawing.Size(32, 32);
            this.UNITRibbonItem.Configuration.MaximumSize = new System.Drawing.Size(80, 0);
            this.UNITRibbonItem.Configuration.MinimumSize = new System.Drawing.Size(22, 60);
            this.UNITRibbonItem.Configuration.TitleConfiguration.ContentAlignmentVertical = Qios.DevSuite.Components.QPartAlignment.Centered;
            this.UNITRibbonItem.Icon = ((System.Drawing.Icon)(resources.GetObject("UNITRibbonItem.Icon")));
            this.UNITRibbonItem.Title = "Ед.Изм.";
            this.UNITRibbonItem.ItemActivated += new Qios.DevSuite.Components.QCompositeEventHandler(this.UNITRibbonItem_ItemActivated);
            // 
            // DISHRibbonItem
            // 
            this.DISHRibbonItem.Configuration.AlignmentVertical = Qios.DevSuite.Components.QPartAlignment.Centered;
            this.DISHRibbonItem.Configuration.Direction = Qios.DevSuite.Components.QPartDirection.Vertical;
            this.DISHRibbonItem.Configuration.IconConfiguration.IconSize = new System.Drawing.Size(32, 32);
            this.DISHRibbonItem.Configuration.MinimumSize = new System.Drawing.Size(22, 60);
            this.DISHRibbonItem.Icon = ((System.Drawing.Icon)(resources.GetObject("DISHRibbonItem.Icon")));
            this.DISHRibbonItem.Title = "Блюда";
            this.DISHRibbonItem.ItemActivated += new Qios.DevSuite.Components.QCompositeEventHandler(this.DISHRibbonItem_ItemActivated);
            // 
            // qRibbonPanel2
            // 
            this.qRibbonPanel2.Configuration.MinimumSize = new System.Drawing.Size(0, 80);
            this.qRibbonPanel2.Items.Add(this.PERSONRibbonItem);
            this.qRibbonPanel2.Title = "Субъекты";
            // 
            // PERSONRibbonItem
            // 
            this.PERSONRibbonItem.Configuration.AlignmentVertical = Qios.DevSuite.Components.QPartAlignment.Centered;
            this.PERSONRibbonItem.Configuration.Direction = Qios.DevSuite.Components.QPartDirection.Vertical;
            this.PERSONRibbonItem.Configuration.IconConfiguration.IconSize = new System.Drawing.Size(32, 32);
            this.PERSONRibbonItem.Configuration.MinimumSize = new System.Drawing.Size(22, 60);
            this.PERSONRibbonItem.Icon = ((System.Drawing.Icon)(resources.GetObject("PERSONRibbonItem.Icon")));
            this.PERSONRibbonItem.Title = "Поставщики";
            this.PERSONRibbonItem.ItemActivated += new Qios.DevSuite.Components.QCompositeEventHandler(this.PERSONRibbonItem_ItemActivated);
            // 
            // qREPRibbonPage
            // 
            this.qREPRibbonPage.ButtonOrder = 2;
            this.qREPRibbonPage.Location = new System.Drawing.Point(2, 31);
            this.qREPRibbonPage.Name = "qREPRibbonPage";
            this.qREPRibbonPage.PersistGuid = new System.Guid("cde911e3-4471-4049-906b-6c14f4c04ea4");
            this.qREPRibbonPage.Size = new System.Drawing.Size(788, 106);
            this.qREPRibbonPage.Text = "Отчеты";
            // 
            // qRibbonItem2
            // 
            this.qRibbonItem2.Configuration.AlignmentHorizontal = Qios.DevSuite.Components.QPartAlignment.Far;
            this.qRibbonItem2.Configuration.AlignmentVertical = Qios.DevSuite.Components.QPartAlignment.Centered;
            this.qRibbonItem2.Configuration.Direction = Qios.DevSuite.Components.QPartDirection.Vertical;
            this.qRibbonItem2.Configuration.IconConfiguration.IconSize = new System.Drawing.Size(32, 32);
            this.qRibbonItem2.Configuration.MaximumSize = new System.Drawing.Size(80, 0);
            this.qRibbonItem2.Configuration.MinimumSize = new System.Drawing.Size(22, 60);
            this.qRibbonItem2.Configuration.TitleConfiguration.ContentAlignmentVertical = Qios.DevSuite.Components.QPartAlignment.Centered;
            this.qRibbonItem2.Icon = ((System.Drawing.Icon)(resources.GetObject("qRibbonItem2.Icon")));
            this.qRibbonItem2.Title = "Серии НМК";
            // 
            // qCompositeMenu1
            // 
            this.qCompositeMenu1.Items.Add(this.qCompositeMenuItem1);
            this.qCompositeMenu1.Items.Add(this.qCompositeMenuItem2);
            this.qCompositeMenu1.OwnerForm = this;
            this.qCompositeMenu1.AddListener(this.qRibbonCaption1);
            // 
            // qCompositeMenuItem1
            // 
            this.qCompositeMenuItem1.ItemName = "Settings";
            this.qCompositeMenuItem1.Title = "Настройки";
            this.qCompositeMenuItem1.ItemActivated += new Qios.DevSuite.Components.QCompositeEventHandler(this.qCompositeMenuItem1_ItemActivated);
            // 
            // qCompositeMenuItem2
            // 
            this.qCompositeMenuItem2.ItemName = "Quit";
            this.qCompositeMenuItem2.Title = "Выход";
            this.qCompositeMenuItem2.ItemActivated += new Qios.DevSuite.Components.QCompositeEventHandler(this.qCompositeMenuItem2_ItemActivated);
            // 
            // frmMain
            // 
            this.Appearance.Shape = new Qios.DevSuite.Components.QShape(Qios.DevSuite.Components.QBaseShapeType.RoundedRectangleShapedWindow);
            this.AppearanceSimple = false;
            this.ClientSize = new System.Drawing.Size(794, 594);
            this.Controls.Add(this.qMAINRibbon);
            this.Controls.Add(this.qRibbonCaption1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "dinny";
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonCaption1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qMAINRibbon)).EndInit();
            this.qMAINRibbon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qDOCRibbonPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qREFRibbonPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qREPRibbonPage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MAINpanel;
        private Qios.DevSuite.Components.Ribbon.QRibbonCaption qRibbonCaption1;
        private Qios.DevSuite.Components.Ribbon.QRibbon qMAINRibbon;
        private Qios.DevSuite.Components.Ribbon.QRibbonPage qREFRibbonPage;
        private Qios.DevSuite.Components.Ribbon.QRibbonPanel qRibbonPanel1;
        private Qios.DevSuite.Components.Ribbon.QRibbonItem NMKRibbonItem;
        private Qios.DevSuite.Components.Ribbon.QRibbonItem UNITRibbonItem;
        private Qios.DevSuite.Components.Ribbon.QRibbonItem qRibbonItem2;
        private Qios.DevSuite.Components.Ribbon.QRibbonPage qDOCRibbonPage;
        private Qios.DevSuite.Components.Ribbon.QRibbonPage qREPRibbonPage;
        private Qios.DevSuite.Components.Ribbon.QRibbonPanel qRibbonPanel2;
        private Qios.DevSuite.Components.Ribbon.QRibbonItem PERSONRibbonItem;
        private Qios.DevSuite.Components.Ribbon.QRibbonItem DISHRibbonItem;
        private Qios.DevSuite.Components.Ribbon.QRibbonPanel qRibbonPanel3;
        private Qios.DevSuite.Components.Ribbon.QRibbonItem RECIPERibbonItem;
        private Qios.DevSuite.Components.Ribbon.QRibbonItem INCOMERibbonItem;
        private Qios.DevSuite.Components.Ribbon.QRibbonApplicationButton qRibbonApplicationButton1;
        private Qios.DevSuite.Components.QCompositeMenu qCompositeMenu1;
        private Qios.DevSuite.Components.QCompositeMenuItem qCompositeMenuItem1;
        private Qios.DevSuite.Components.QCompositeMenuItem qCompositeMenuItem2;
    }
}


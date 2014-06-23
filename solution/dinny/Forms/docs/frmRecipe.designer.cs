namespace dinny.Forms.docs
{
    partial class frmRecipe
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRecipe = new System.Windows.Forms.TextBox();
            this.txtOutDish = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gridRecipeNmkCost = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn7 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn8 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.cmbRFOrg = new DevExpress.XtraEditors.ButtonEdit();
            this.cmbRFDish = new DevExpress.XtraEditors.ButtonEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnLoadNmks = new System.Windows.Forms.Button();
            this.lbUnit = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSumCost = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOneSum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPrice = new DevExpress.XtraEditors.TextEdit();
            this.txtPercent = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRecipeNmkCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRFOrg.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRFDish.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPercent.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_OK.Location = new System.Drawing.Point(483, 454);
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
            this.btn_Cancel.Location = new System.Drawing.Point(564, 454);
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
            this.bindingSource.DataSource = typeof(dinny.Domain.Recipe);
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
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Организация";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Номенклатура";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "№ Рецептуры";
            // 
            // txtRecipe
            // 
            this.txtRecipe.Location = new System.Drawing.Point(320, 34);
            this.txtRecipe.Name = "txtRecipe";
            this.txtRecipe.ReadOnly = true;
            this.txtRecipe.Size = new System.Drawing.Size(115, 20);
            this.txtRecipe.TabIndex = 9;
            // 
            // txtOutDish
            // 
            this.txtOutDish.Location = new System.Drawing.Point(485, 34);
            this.txtOutDish.Name = "txtOutDish";
            this.txtOutDish.ReadOnly = true;
            this.txtOutDish.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtOutDish.Size = new System.Drawing.Size(73, 20);
            this.txtOutDish.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(441, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Выход";
            // 
            // gridRecipeNmkCost
            // 
            this.gridRecipeNmkCost.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.gridRecipeNmkCost.AllColumns.Add(this.olvColumn1);
            this.gridRecipeNmkCost.AllColumns.Add(this.olvColumn3);
            this.gridRecipeNmkCost.AllColumns.Add(this.olvColumn2);
            this.gridRecipeNmkCost.AllColumns.Add(this.olvColumn4);
            this.gridRecipeNmkCost.AllColumns.Add(this.olvColumn5);
            this.gridRecipeNmkCost.AllColumns.Add(this.olvColumn6);
            this.gridRecipeNmkCost.AllColumns.Add(this.olvColumn7);
            this.gridRecipeNmkCost.AllColumns.Add(this.olvColumn8);
            this.gridRecipeNmkCost.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
            this.gridRecipeNmkCost.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn3,
            this.olvColumn2,
            this.olvColumn4,
            this.olvColumn5,
            this.olvColumn6,
            this.olvColumn7,
            this.olvColumn8});
            this.gridRecipeNmkCost.EmptyListMsg = "";
            this.gridRecipeNmkCost.FullRowSelect = true;
            this.gridRecipeNmkCost.GridLines = true;
            this.gridRecipeNmkCost.Location = new System.Drawing.Point(15, 143);
            this.gridRecipeNmkCost.MultiSelect = false;
            this.gridRecipeNmkCost.Name = "gridRecipeNmkCost";
            this.gridRecipeNmkCost.Size = new System.Drawing.Size(624, 256);
            this.gridRecipeNmkCost.TabIndex = 21;
            this.gridRecipeNmkCost.UseCompatibleStateImageBehavior = false;
            this.gridRecipeNmkCost.View = System.Windows.Forms.View.Details;
            this.gridRecipeNmkCost.CellEditFinishing += new BrightIdeasSoftware.CellEditEventHandler(this.gridRecipeNmkCost_CellEditFinishing);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "DishNmk.nmk.name";
            this.olvColumn1.CellPadding = null;
            this.olvColumn1.IsEditable = false;
            this.olvColumn1.Text = "Номенклатура";
            this.olvColumn1.Width = 145;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "DishNmk.nmk.unit.sname";
            this.olvColumn3.CellPadding = null;
            this.olvColumn3.IsEditable = false;
            this.olvColumn3.Text = "Ед.изм.";
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "cost";
            this.olvColumn2.CellPadding = null;
            this.olvColumn2.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn2.Text = "Цена";
            this.olvColumn2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn2.Width = 100;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "DishNmk.brutto";
            this.olvColumn4.CellPadding = null;
            this.olvColumn4.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn4.IsEditable = false;
            this.olvColumn4.Text = "Норма брутто";
            this.olvColumn4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "DishNmk.netto";
            this.olvColumn5.CellPadding = null;
            this.olvColumn5.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn5.IsEditable = false;
            this.olvColumn5.Text = "Норма нетто";
            this.olvColumn5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // olvColumn6
            // 
            this.olvColumn6.AspectName = "DishNmk.loss";
            this.olvColumn6.CellPadding = null;
            this.olvColumn6.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn6.IsEditable = false;
            this.olvColumn6.Text = "% потери";
            this.olvColumn6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // olvColumn7
            // 
            this.olvColumn7.AspectName = "DishNmk.result";
            this.olvColumn7.AspectToStringFormat = "{0:#,##0.00}";
            this.olvColumn7.CellPadding = null;
            this.olvColumn7.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn7.IsEditable = false;
            this.olvColumn7.Text = "Выход";
            this.olvColumn7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // olvColumn8
            // 
            this.olvColumn8.AspectName = "summa";
            this.olvColumn8.AspectToStringFormat = "{0:#,##0.00}";
            this.olvColumn8.CellPadding = null;
            this.olvColumn8.FillsFreeSpace = true;
            this.olvColumn8.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn8.IsEditable = false;
            this.olvColumn8.Text = "Сумма";
            this.olvColumn8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbRFOrg
            // 
            this.cmbRFOrg.Location = new System.Drawing.Point(101, 60);
            this.cmbRFOrg.Name = "cmbRFOrg";
            this.cmbRFOrg.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmbRFOrg.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cmbRFOrg.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmbRFOrg.Properties.ReadOnly = true;
            this.cmbRFOrg.Size = new System.Drawing.Size(334, 22);
            this.cmbRFOrg.TabIndex = 22;
            this.cmbRFOrg.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmbRFOrg_ButtonClick);
            // 
            // cmbRFDish
            // 
            this.cmbRFDish.Location = new System.Drawing.Point(101, 87);
            this.cmbRFDish.Name = "cmbRFDish";
            this.cmbRFDish.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmbRFDish.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cmbRFDish.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmbRFDish.Properties.ReadOnly = true;
            this.cmbRFDish.Size = new System.Drawing.Size(334, 22);
            this.cmbRFDish.TabIndex = 23;
            this.cmbRFDish.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmbRFDish_ButtonClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(441, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Составлено на";
            // 
            // txtQuantity
            // 
            this.txtQuantity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "quantity", true));
            this.txtQuantity.Location = new System.Drawing.Point(532, 88);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtQuantity.Size = new System.Drawing.Size(106, 20);
            this.txtQuantity.TabIndex = 25;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // btnLoadNmks
            // 
            this.btnLoadNmks.Location = new System.Drawing.Point(448, 113);
            this.btnLoadNmks.Name = "btnLoadNmks";
            this.btnLoadNmks.Size = new System.Drawing.Size(191, 23);
            this.btnLoadNmks.TabIndex = 26;
            this.btnLoadNmks.Text = "LoadNmks";
            this.btnLoadNmks.UseVisualStyleBackColor = true;
            this.btnLoadNmks.Click += new System.EventHandler(this.btnLoadNmks_Click);
            // 
            // lbUnit
            // 
            this.lbUnit.AutoSize = true;
            this.lbUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbUnit.Location = new System.Drawing.Point(564, 37);
            this.lbUnit.Name = "lbUnit";
            this.lbUnit.Size = new System.Drawing.Size(25, 13);
            this.lbUnit.TabIndex = 27;
            this.lbUnit.Text = "      ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(480, 405);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Сумма";
            // 
            // txtSumCost
            // 
            this.txtSumCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtSumCost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "sumcost", true));
            this.txtSumCost.Location = new System.Drawing.Point(532, 402);
            this.txtSumCost.Name = "txtSumCost";
            this.txtSumCost.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSumCost.Size = new System.Drawing.Size(106, 20);
            this.txtSumCost.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(370, 427);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Стоимость одной порции";
            // 
            // txtOneSum
            // 
            this.txtOneSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtOneSum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "onecost", true));
            this.txtOneSum.Location = new System.Drawing.Point(532, 427);
            this.txtOneSum.Name = "txtOneSum";
            this.txtOneSum.ReadOnly = true;
            this.txtOneSum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtOneSum.Size = new System.Drawing.Size(106, 20);
            this.txtOneSum.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 430);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Процент наценки %";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(12, 405);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Продажная цена";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(12, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Компоненты";
            // 
            // txtPrice
            // 
            this.txtPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "price", true));
            this.txtPrice.Location = new System.Drawing.Point(149, 402);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Properties.Mask.EditMask = "\\d{1,8}((,|\\.)\\d{2})?";
            this.txtPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtPrice.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 37;
            this.txtPrice.EditValueChanged += new System.EventHandler(this.txtPrice_EditValueChanged);
            this.txtPrice.Enter += new System.EventHandler(this.txtPrice_Enter);
            this.txtPrice.Leave += new System.EventHandler(this.txtPrice_Leave);
            // 
            // txtPercent
            // 
            this.txtPercent.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "ppercent", true));
            this.txtPercent.Location = new System.Drawing.Point(149, 428);
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.Properties.Mask.EditMask = "\\d{1,8}((,|\\.)\\d{2})?";
            this.txtPercent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtPercent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPercent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPercent.Size = new System.Drawing.Size(100, 20);
            this.txtPercent.TabIndex = 38;
            this.txtPercent.EditValueChanged += new System.EventHandler(this.txtPercent_EditValueChanged);
            this.txtPercent.Enter += new System.EventHandler(this.txtPercent_Enter);
            this.txtPercent.Leave += new System.EventHandler(this.txtPercent_Leave);
            // 
            // frmRecipe
            // 
            this.AcceptButton = this.btn_OK;
            this.Appearance.Shape = new Qios.DevSuite.Components.QShape(Qios.DevSuite.Components.QBaseShapeType.RoundedRectangleShapedWindow);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(651, 489);
            this.Controls.Add(this.txtPercent);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtOneSum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSumCost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbUnit);
            this.Controls.Add(this.btnLoadNmks);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbRFDish);
            this.Controls.Add(this.cmbRFOrg);
            this.Controls.Add(this.gridRecipeNmkCost);
            this.Controls.Add(this.txtOutDish);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRecipe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btn_OK);
            this.Name = "frmRecipe";
            this.Text = "frmRecipe";
            this.Load += new System.EventHandler(this.xfrmSetting_Load);
            this.Controls.SetChildIndex(this.btn_OK, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.btn_Cancel, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtRecipe, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtOutDish, 0);
            this.Controls.SetChildIndex(this.gridRecipeNmkCost, 0);
            this.Controls.SetChildIndex(this.cmbRFOrg, 0);
            this.Controls.SetChildIndex(this.cmbRFDish, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtQuantity, 0);
            this.Controls.SetChildIndex(this.btnLoadNmks, 0);
            this.Controls.SetChildIndex(this.lbUnit, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtSumCost, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtOneSum, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.txtPrice, 0);
            this.Controls.SetChildIndex(this.txtPercent, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRecipeNmkCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRFOrg.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRFDish.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPercent.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRecipe;
        private System.Windows.Forms.TextBox txtOutDish;
        private System.Windows.Forms.Label label5;
        private BrightIdeasSoftware.ObjectListView gridRecipeNmkCost;
        private DevExpress.XtraEditors.ButtonEdit cmbRFOrg;
        private DevExpress.XtraEditors.ButtonEdit cmbRFDish;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnLoadNmks;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private BrightIdeasSoftware.OLVColumn olvColumn6;
        private BrightIdeasSoftware.OLVColumn olvColumn7;
        private BrightIdeasSoftware.OLVColumn olvColumn8;
        private System.Windows.Forms.Label lbUnit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSumCost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOneSum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.TextEdit txtPrice;
        private DevExpress.XtraEditors.TextEdit txtPercent;
    }
}
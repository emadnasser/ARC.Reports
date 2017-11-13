namespace DevExpress.XtraPivotGrid.Demos.Modules {
    partial class FieldsCustomization {
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dsSalesPerson1 = new DevExpress.XtraPivotGrid.Demos.dsSalesPerson();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.icbCustomizationStyle = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.icbHideFields = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.sbCustomizationForm = new DevExpress.XtraEditors.SimpleButton();
            this.pcSplitter = new DevExpress.XtraEditors.PanelControl();
            this.paddingPanel = new DevExpress.XtraEditors.PanelControl();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldCountry = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSalesPerson = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQuarter = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldExtendedPrice = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQuantity = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCategoryName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOrderID = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.dsSalesPerson1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icbCustomizationStyle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbHideFields.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSplitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddingPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // dsSalesPerson1
            // 
            this.dsSalesPerson1.DataSetName = "dsSalesPerson";
            this.dsSalesPerson1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dsSalesPerson1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.icbCustomizationStyle);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.icbHideFields);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.sbCustomizationForm);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(707, 72);
            this.panelControl1.TabIndex = 1;
            // 
            // icbCustomizationStyle
            // 
            this.icbCustomizationStyle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icbCustomizationStyle.EditValue = "imageComboBoxEdit1";
            this.icbCustomizationStyle.Location = new System.Drawing.Point(510, 41);
            this.icbCustomizationStyle.Name = "icbCustomizationStyle";
            this.icbCustomizationStyle.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbCustomizationStyle.Properties.DropDownRows = 10;
            this.icbCustomizationStyle.Size = new System.Drawing.Size(184, 20);
            this.icbCustomizationStyle.TabIndex = 8;
            this.icbCustomizationStyle.SelectedIndexChanged += new System.EventHandler(this.icbCustomizationStyle_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(400, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Customization Style:";
            // 
            // icbHideFields
            // 
            this.icbHideFields.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icbHideFields.EditValue = "imageComboBoxEdit1";
            this.icbHideFields.Location = new System.Drawing.Point(510, 15);
            this.icbHideFields.Name = "icbHideFields";
            this.icbHideFields.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbHideFields.Properties.DropDownRows = 10;
            this.icbHideFields.Size = new System.Drawing.Size(184, 20);
            this.icbHideFields.TabIndex = 6;
            this.icbHideFields.SelectedIndexChanged += new System.EventHandler(this.icbHideFields_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(409, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Allow Hiding Fields:";
            // 
            // sbCustomizationForm
            // 
            this.sbCustomizationForm.Location = new System.Drawing.Point(12, 25);
            this.sbCustomizationForm.Name = "sbCustomizationForm";
            this.sbCustomizationForm.Size = new System.Drawing.Size(212, 24);
            this.sbCustomizationForm.TabIndex = 0;
            this.sbCustomizationForm.Click += new System.EventHandler(this.sbCustomizationForm_Click);
            // 
            // pcSplitter
            // 
            this.pcSplitter.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcSplitter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pcSplitter.Location = new System.Drawing.Point(0, 72);
            this.pcSplitter.Name = "pcSplitter";
            this.pcSplitter.Size = new System.Drawing.Size(707, 2);
            this.pcSplitter.TabIndex = 9;
            // 
            // paddingPanel
            // 
            this.paddingPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.paddingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.paddingPanel.Location = new System.Drawing.Point(0, 74);
            this.paddingPanel.Name = "paddingPanel";
            this.paddingPanel.Size = new System.Drawing.Size(707, 8);
            this.paddingPanel.TabIndex = 11;
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pivotGridControl1.DataSource = this.dsSalesPerson1.SalesPerson;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldCountry,
            this.fieldSalesPerson,
            this.fieldYear,
            this.fieldQuarter,
            this.fieldExtendedPrice,
            this.fieldQuantity,
            this.fieldProductName,
            this.fieldCategoryName,
            this.fieldOrderID});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 82);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(707, 334);
            this.pivotGridControl1.TabIndex = 12;
            this.pivotGridControl1.FieldValueImageIndex += new DevExpress.XtraPivotGrid.PivotFieldImageIndexEventHandler(this.pivotGridControl1_FieldValueImageIndex);
            this.pivotGridControl1.HideCustomizationForm += new System.EventHandler(this.pivotGridControl1_HideCustomizationForm);
            this.pivotGridControl1.ShowCustomizationForm += new System.EventHandler(this.pivotGridControl1_ShowCustomizationForm);
            // 
            // fieldCountry
            // 
            this.fieldCountry.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldCountry.AreaIndex = 0;
            this.fieldCountry.FieldName = "Country";
            this.fieldCountry.Name = "fieldCountry";
            // 
            // fieldSalesPerson
            // 
            this.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldSalesPerson.AreaIndex = 1;
            this.fieldSalesPerson.FieldName = "Sales Person";
            this.fieldSalesPerson.Name = "fieldSalesPerson";
            this.fieldSalesPerson.Width = 130;
            // 
            // fieldYear
            // 
            this.fieldYear.AreaIndex = 0;
            this.fieldYear.Caption = "Order Year";
            this.fieldYear.FieldName = "OrderDate";
            this.fieldYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldYear.Name = "fieldYear";
            this.fieldYear.UnboundFieldName = "fieldYear";
            this.fieldYear.Width = 120;
            // 
            // fieldQuarter
            // 
            this.fieldQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldQuarter.AreaIndex = 0;
            this.fieldQuarter.Caption = "Order Quarter";
            this.fieldQuarter.FieldName = "OrderDate";
            this.fieldQuarter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter;
            this.fieldQuarter.Name = "fieldQuarter";
            this.fieldQuarter.TotalValueFormat.FormatString = "Quarter {0} Total";
            this.fieldQuarter.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldQuarter.UnboundFieldName = "fieldQuarter";
            this.fieldQuarter.ValueFormat.FormatString = "Quarter {0}";
            this.fieldQuarter.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldQuarter.Width = 140;
            // 
            // fieldExtendedPrice
            // 
            this.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldExtendedPrice.AreaIndex = 0;
            this.fieldExtendedPrice.Caption = "Order Amount";
            this.fieldExtendedPrice.CellFormat.FormatString = "c";
            this.fieldExtendedPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldExtendedPrice.FieldName = "Extended Price";
            this.fieldExtendedPrice.Name = "fieldExtendedPrice";
            // 
            // fieldQuantity
            // 
            this.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldQuantity.FieldName = "Quantity";
            this.fieldQuantity.Name = "fieldQuantity";
            this.fieldQuantity.Visible = false;
            // 
            // fieldProductName
            // 
            this.fieldProductName.Caption = "Product Name";
            this.fieldProductName.FieldName = "ProductName";
            this.fieldProductName.Name = "fieldProductName";
            this.fieldProductName.Visible = false;
            // 
            // fieldCategoryName
            // 
            this.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCategoryName.AreaIndex = 1;
            this.fieldCategoryName.Caption = "Category Name";
            this.fieldCategoryName.FieldName = "CategoryName";
            this.fieldCategoryName.Name = "fieldCategoryName";
            this.fieldCategoryName.Width = 139;
            // 
            // fieldOrderID
            // 
            this.fieldOrderID.FieldName = "OrderID";
            this.fieldOrderID.Name = "fieldOrderID";
            this.fieldOrderID.Visible = false;
            // 
            // FieldsCustomization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.paddingPanel);
            this.Controls.Add(this.pcSplitter);
            this.Controls.Add(this.panelControl1);
            this.Name = "FieldsCustomization";
            this.Size = new System.Drawing.Size(707, 416);
            this.Load += new System.EventHandler(this.FieldsCustomization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSalesPerson1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icbCustomizationStyle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbHideFields.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSplitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddingPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
		private DevExpress.XtraPivotGrid.Demos.dsSalesPerson dsSalesPerson1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraEditors.PanelControl pcSplitter;
        private DevExpress.XtraEditors.SimpleButton sbCustomizationForm;
        private DevExpress.XtraEditors.LabelControl label2;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbHideFields;
        private System.ComponentModel.IContainer components = null;
		private DevExpress.XtraEditors.PanelControl paddingPanel;
		private PivotGridControl pivotGridControl1;
		private PivotGridField fieldCountry;
		private PivotGridField fieldSalesPerson;
		private PivotGridField fieldYear;
		private PivotGridField fieldQuarter;
		private PivotGridField fieldExtendedPrice;
		private PivotGridField fieldQuantity;
		private PivotGridField fieldProductName;
		private PivotGridField fieldCategoryName;
		private PivotGridField fieldOrderID;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbCustomizationStyle;
        private DevExpress.XtraEditors.LabelControl label1;

    }
}

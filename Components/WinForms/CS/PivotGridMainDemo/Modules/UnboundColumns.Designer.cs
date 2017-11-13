namespace DevExpress.XtraPivotGrid.Demos.Modules {
    partial class UnboundColumns {
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
            this.icbOrderAmount = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.icbSalesPerson = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.paddingPanel = new DevExpress.XtraEditors.PanelControl();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldQuarter = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSalesPerson = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldExtendedPrice = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOrderAmount = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPercent = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldBonusAmount = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.dsSalesPerson1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icbOrderAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbSalesPerson.Properties)).BeginInit();
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
            this.panelControl1.Controls.Add(this.icbOrderAmount);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.icbSalesPerson);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(706, 64);
            this.panelControl1.TabIndex = 1;
            // 
            // icbOrderAmount
            // 
            this.icbOrderAmount.EditValue = 0;
            this.icbOrderAmount.Location = new System.Drawing.Point(126, 37);
            this.icbOrderAmount.Name = "icbOrderAmount";
            this.icbOrderAmount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbOrderAmount.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("with Discount", 0, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("without Discount", 1, -1)});
            this.icbOrderAmount.Size = new System.Drawing.Size(172, 20);
            this.icbOrderAmount.TabIndex = 4;
            this.icbOrderAmount.SelectedIndexChanged += new System.EventHandler(this.icb_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.label2.Appearance.Options.UseBackColor = true;
            this.label2.Location = new System.Drawing.Point(18, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Order Amount Rule: ";
            // 
            // icbSalesPerson
            // 
            this.icbSalesPerson.EditValue = "{0} {1}";
            this.icbSalesPerson.Location = new System.Drawing.Point(126, 11);
            this.icbSalesPerson.Name = "icbSalesPerson";
            this.icbSalesPerson.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbSalesPerson.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("First Name + Last Name", "{0} {1}", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Last Name + First Name", "{1} {0}", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Last Name only", "{1}", -1)});
            this.icbSalesPerson.Size = new System.Drawing.Size(172, 20);
            this.icbSalesPerson.TabIndex = 2;
            this.icbSalesPerson.SelectedIndexChanged += new System.EventHandler(this.icb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.label1.Appearance.Options.UseBackColor = true;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sales Person Format: ";
            // 
            // paddingPanel
            // 
            this.paddingPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.paddingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.paddingPanel.Location = new System.Drawing.Point(0, 64);
            this.paddingPanel.Name = "paddingPanel";
            this.paddingPanel.Size = new System.Drawing.Size(706, 8);
            this.paddingPanel.TabIndex = 10;
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pivotGridControl1.DataSource = this.dsSalesPerson1.SalesPerson;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldQuarter,
            this.fieldSalesPerson,
            this.fieldExtendedPrice,
            this.fieldOrderAmount,
            this.fieldPercent,
            this.fieldBonusAmount});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 72);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsView.ShowColumnHeaders = false;
            this.pivotGridControl1.Size = new System.Drawing.Size(706, 344);
            this.pivotGridControl1.TabIndex = 11;
            this.pivotGridControl1.FieldAreaChanged += new DevExpress.XtraPivotGrid.PivotFieldEventHandler(this.pivotGridControl1_FieldAreaChanged);
            this.pivotGridControl1.CustomUnboundFieldData += new DevExpress.XtraPivotGrid.CustomFieldDataEventHandler(this.pivotGridControl1_CustomUnboundFieldData);
            this.pivotGridControl1.CustomCellDisplayText += new DevExpress.XtraPivotGrid.PivotCellDisplayTextEventHandler(this.pivotGridControl1_CustomCellDisplayText);
            // 
            // fieldQuarter
            // 
            this.fieldQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldQuarter.AreaIndex = 1;
            this.fieldQuarter.Caption = "Quarter";
            this.fieldQuarter.FieldName = "OrderDate";
            this.fieldQuarter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter;
            this.fieldQuarter.Name = "fieldQuarter";
            this.fieldQuarter.TotalValueFormat.FormatString = "Qtr {0} Total";
            this.fieldQuarter.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldQuarter.UnboundFieldName = "fieldQuarter";
            this.fieldQuarter.ValueFormat.FormatString = "Qtr {0}";
            this.fieldQuarter.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldQuarter.Width = 140;
            // 
            // fieldSalesPerson
            // 
            this.fieldSalesPerson.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fieldSalesPerson.Appearance.Header.Options.UseFont = true;
            this.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldSalesPerson.AreaIndex = 0;
            this.fieldSalesPerson.Caption = "Sales Person";
            this.fieldSalesPerson.Name = "fieldSalesPerson";
            this.fieldSalesPerson.UnboundFieldName = "fieldSalesPerson";
            this.fieldSalesPerson.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.fieldSalesPerson.Width = 219;
            // 
            // fieldExtendedPrice
            // 
            this.fieldExtendedPrice.AreaIndex = 0;
            this.fieldExtendedPrice.CellFormat.FormatString = "c";
            this.fieldExtendedPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldExtendedPrice.FieldName = "Extended Price";
            this.fieldExtendedPrice.Name = "fieldExtendedPrice";
            this.fieldExtendedPrice.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.False;
            // 
            // fieldOrderAmount
            // 
            this.fieldOrderAmount.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fieldOrderAmount.Appearance.Header.Options.UseFont = true;
            this.fieldOrderAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldOrderAmount.AreaIndex = 0;
            this.fieldOrderAmount.Caption = "Order Amount";
            this.fieldOrderAmount.CellFormat.FormatString = "c";
            this.fieldOrderAmount.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldOrderAmount.Name = "fieldOrderAmount";
            this.fieldOrderAmount.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.False;
            this.fieldOrderAmount.UnboundFieldName = "fieldOrderAmount";
            this.fieldOrderAmount.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            // 
            // fieldPercent
            // 
            this.fieldPercent.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic);
            this.fieldPercent.Appearance.Header.Options.UseFont = true;
            this.fieldPercent.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldPercent.AreaIndex = 1;
            this.fieldPercent.Caption = "Percent of OrderTotal";
            this.fieldPercent.Name = "fieldPercent";
            this.fieldPercent.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.False;
            this.fieldPercent.Options.AllowFilterBySummary = DevExpress.Utils.DefaultBoolean.False;
            this.fieldPercent.Width = 131;
            // 
            // fieldBonusAmount
            // 
            this.fieldBonusAmount.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic);
            this.fieldBonusAmount.Appearance.Header.Options.UseFont = true;
            this.fieldBonusAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldBonusAmount.AreaIndex = 2;
            this.fieldBonusAmount.Caption = "Bonus Amount";
            this.fieldBonusAmount.Name = "fieldBonusAmount";
            this.fieldBonusAmount.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.False;
            this.fieldBonusAmount.Options.AllowFilterBySummary = DevExpress.Utils.DefaultBoolean.False;
            // 
            // UnboundColumns
            // 
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.paddingPanel);
            this.Controls.Add(this.panelControl1);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UnboundColumns";
            this.Size = new System.Drawing.Size(706, 416);
            this.Load += new System.EventHandler(this.UnboundColumns_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSalesPerson1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icbOrderAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbSalesPerson.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddingPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
		private DevExpress.XtraPivotGrid.Demos.dsSalesPerson dsSalesPerson1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl label1;
		private DevExpress.XtraEditors.ImageComboBoxEdit icbSalesPerson;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbOrderAmount;
		private DevExpress.XtraEditors.LabelControl label2;
        private System.ComponentModel.IContainer components = null;
		private DevExpress.XtraEditors.PanelControl paddingPanel;
		private PivotGridControl pivotGridControl1;
		private PivotGridField fieldQuarter;
		private PivotGridField fieldSalesPerson;
		private PivotGridField fieldExtendedPrice;
		private PivotGridField fieldOrderAmount;
		private PivotGridField fieldPercent;
		private PivotGridField fieldBonusAmount;

    }
}

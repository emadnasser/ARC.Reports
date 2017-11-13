namespace DevExpress.XtraPivotGrid.Demos.Modules {
    partial class UnboundExpressions {
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
            this.paddingPanel = new DevExpress.XtraEditors.PanelControl();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldFirstName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldLastName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSalesPerson = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQuarter = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldExtendedPrice = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQuantity = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOrderCount = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldNewYearBonus = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOrderCountBonus = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldBonusAmount = new DevExpress.XtraPivotGrid.PivotGridField();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.icbSalesPerson = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnAddBonus = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dsSalesPerson1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddingPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbSalesPerson.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsSalesPerson1
            // 
            this.dsSalesPerson1.DataSetName = "dsSalesPerson";
            this.dsSalesPerson1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dsSalesPerson1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paddingPanel
            // 
            this.paddingPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.paddingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.paddingPanel.Location = new System.Drawing.Point(0, 37);
            this.paddingPanel.Name = "paddingPanel";
            this.paddingPanel.Size = new System.Drawing.Size(706, 8);
            this.paddingPanel.TabIndex = 10;
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pivotGridControl1.DataSource = this.dsSalesPerson1.SalesPerson;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldFirstName,
            this.fieldLastName,
            this.fieldSalesPerson,
            this.fieldQuarter,
            this.fieldExtendedPrice,
            this.fieldQuantity,
            this.fieldOrderCount,
            this.fieldNewYearBonus,
            this.fieldOrderCountBonus,
            this.fieldBonusAmount});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 45);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsCustomization.AllowExpand = false;
            this.pivotGridControl1.OptionsCustomization.AllowResizing = false;
            this.pivotGridControl1.OptionsData.DataFieldUnboundExpressionMode = DevExpress.XtraPivotGrid.DataFieldUnboundExpressionMode.UseSummaryValues;
            this.pivotGridControl1.OptionsSelection.CellSelection = false;
            this.pivotGridControl1.OptionsView.ShowColumnGrandTotalHeader = false;
            this.pivotGridControl1.OptionsView.ShowColumnHeaders = false;
            this.pivotGridControl1.OptionsView.ShowDataHeaders = false;
            this.pivotGridControl1.OptionsView.ShowFilterHeaders = false;
            this.pivotGridControl1.OptionsView.ShowRowGrandTotals = false;
            this.pivotGridControl1.OptionsView.ShowRowTotals = false;
            this.pivotGridControl1.Size = new System.Drawing.Size(706, 371);
            this.pivotGridControl1.TabIndex = 11;
            this.pivotGridControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pivotGridControl1_MouseClick);
            this.pivotGridControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pivotGridControl1_MouseMove);
            this.pivotGridControl1.FieldUnboundExpressionChanged += new DevExpress.XtraPivotGrid.PivotFieldEventHandler(this.pivotGridControl1_FieldUnboundExpressionChanged);
            this.pivotGridControl1.PopupMenuShowing += new DevExpress.XtraPivotGrid.PopupMenuShowingEventHandler(this.pivotGridControl1_PopupMenuShowing);
            this.pivotGridControl1.CustomDrawFieldValue += new DevExpress.XtraPivotGrid.PivotCustomDrawFieldValueEventHandler(this.pivotGridControl1_CustomDrawFieldValue);
            // 
            // fieldFirstName
            // 
            this.fieldFirstName.AreaIndex = 0;
            this.fieldFirstName.FieldName = "FirstName";
            this.fieldFirstName.Name = "fieldFirstName";
            this.fieldFirstName.Visible = false;
            // 
            // fieldLastName
            // 
            this.fieldLastName.AreaIndex = 0;
            this.fieldLastName.FieldName = "LastName";
            this.fieldLastName.Name = "fieldLastName";
            this.fieldLastName.Visible = false;
            // 
            // fieldSalesPerson
            // 
            this.fieldSalesPerson.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea;
            this.fieldSalesPerson.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fieldSalesPerson.Appearance.Header.Options.UseFont = true;
            this.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldSalesPerson.AreaIndex = 0;
            this.fieldSalesPerson.Caption = "Sales Person";
            this.fieldSalesPerson.Name = "fieldSalesPerson";
            this.fieldSalesPerson.Options.ShowUnboundExpressionMenu = true;
            this.fieldSalesPerson.UnboundFieldName = "SalesPerson";
            this.fieldSalesPerson.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.fieldSalesPerson.Width = 219;
            // 
            // fieldQuarter
            // 
            this.fieldQuarter.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea;
            this.fieldQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldQuarter.AreaIndex = 1;
            this.fieldQuarter.Caption = "Quarter";
            this.fieldQuarter.FieldName = "OrderDate";
            this.fieldQuarter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter;
            this.fieldQuarter.Name = "fieldQuarter";
            this.fieldQuarter.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldQuarter.UnboundFieldName = "Quarter";
            this.fieldQuarter.ValueFormat.FormatString = "Qtr {0}";
            this.fieldQuarter.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldQuarter.Width = 140;
            // 
            // fieldExtendedPrice
            // 
            this.fieldExtendedPrice.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;
            this.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldExtendedPrice.AreaIndex = 2;
            this.fieldExtendedPrice.Caption = "Extended Price";
            this.fieldExtendedPrice.FieldName = "Extended Price";
            this.fieldExtendedPrice.Name = "fieldExtendedPrice";
            // 
            // fieldQuantity
            // 
            this.fieldQuantity.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;
            this.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldQuantity.AreaIndex = 1;
            this.fieldQuantity.Caption = "Quantity";
            this.fieldQuantity.FieldName = "Quantity";
            this.fieldQuantity.Name = "fieldQuantity";
            // 
            // fieldOrderCount
            // 
            this.fieldOrderCount.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;
            this.fieldOrderCount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldOrderCount.AreaIndex = 0;
            this.fieldOrderCount.Caption = "Order Count";
            this.fieldOrderCount.FieldName = "OrderID";
            this.fieldOrderCount.Name = "fieldOrderCount";
            this.fieldOrderCount.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count;
            // 
            // fieldNewYearBonus
            // 
            this.fieldNewYearBonus.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;
            this.fieldNewYearBonus.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldNewYearBonus.AreaIndex = 3;
            this.fieldNewYearBonus.Caption = "New Year Bonus";
            this.fieldNewYearBonus.Name = "fieldNewYearBonus";
            this.fieldNewYearBonus.Options.ShowUnboundExpressionMenu = true;
            this.fieldNewYearBonus.UnboundExpression = "Iif([Quarter] == 4, Iif([fieldExtendedPrice] > 40000, 600, 400), 0)";
            this.fieldNewYearBonus.UnboundFieldName = "NewYearBonus";
            this.fieldNewYearBonus.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            // 
            // fieldOrderCountBonus
            // 
            this.fieldOrderCountBonus.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;
            this.fieldOrderCountBonus.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldOrderCountBonus.AreaIndex = 4;
            this.fieldOrderCountBonus.Caption = "Order Count Bonus";
            this.fieldOrderCountBonus.Name = "fieldOrderCountBonus";
            this.fieldOrderCountBonus.Options.ShowUnboundExpressionMenu = true;
            this.fieldOrderCountBonus.UnboundExpression = "Iif([fieldOrderCount] > 50 and [fieldExtendedPrice] / [fieldOrderCount] > 500, 15" +
                " * [fieldExtendedPrice] / [fieldQuantity] , 0)";
            this.fieldOrderCountBonus.UnboundFieldName = "OrderCountBonus";
            this.fieldOrderCountBonus.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            // 
            // fieldBonusAmount
            // 
            this.fieldBonusAmount.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;
            this.fieldBonusAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldBonusAmount.AreaIndex = 5;
            this.fieldBonusAmount.Caption = "Bonus Amount";
            this.fieldBonusAmount.Name = "fieldBonusAmount";
            this.fieldBonusAmount.Options.ShowUnboundExpressionMenu = true;
            this.fieldBonusAmount.UnboundExpression = "[fieldNewYearBonus] + [fieldOrderCountBonus]";
            this.fieldBonusAmount.UnboundFieldName = "BonusAmount";
            this.fieldBonusAmount.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            // 
            // label1
            // 
            this.label1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sales Person Format: ";
            // 
            // icbSalesPerson
            // 
            this.icbSalesPerson.Location = new System.Drawing.Point(130, 9);
            this.icbSalesPerson.Name = "icbSalesPerson";
            this.icbSalesPerson.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbSalesPerson.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("First Name + Last Name", "[fieldFirstName] + \' \' + [fieldLastName]", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Last Name + First Name", "[fieldLastName] + \' \' + [fieldFirstName]", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Last Name only", "[fieldLastName]", -1)});
            this.icbSalesPerson.Size = new System.Drawing.Size(172, 20);
            this.icbSalesPerson.TabIndex = 2;
            this.icbSalesPerson.SelectedIndexChanged += new System.EventHandler(this.icb_SelectedIndexChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(706, 37);
            this.panelControl1.TabIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Controls.Add(this.btnAddBonus);
            this.panelControl2.Controls.Add(this.icbSalesPerson);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.panelControl2.Size = new System.Drawing.Size(706, 34);
            this.panelControl2.TabIndex = 4;
            // 
            // btnAddBonus
            // 
            this.btnAddBonus.Location = new System.Drawing.Point(357, 7);
            this.btnAddBonus.Name = "btnAddBonus";
            this.btnAddBonus.Size = new System.Drawing.Size(88, 22);
            this.btnAddBonus.TabIndex = 3;
            this.btnAddBonus.Text = "Add Bonus";
            this.btnAddBonus.Click += new System.EventHandler(this.btnAddBonus_Click);
            // 
            // UnboundExpressions
            // 
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.paddingPanel);
            this.Controls.Add(this.panelControl1);
            this.Name = "UnboundExpressions";
            this.Size = new System.Drawing.Size(706, 416);
            this.Load += new System.EventHandler(this.UnboundColumns_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSalesPerson1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddingPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbSalesPerson.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraPivotGrid.Demos.dsSalesPerson dsSalesPerson1;
        private System.ComponentModel.IContainer components = null;
		private DevExpress.XtraEditors.PanelControl paddingPanel;
		private PivotGridControl pivotGridControl1;
        private PivotGridField fieldFirstName;
        private PivotGridField fieldLastName;
        private PivotGridField fieldSalesPerson;
        private PivotGridField fieldQuarter;
        private PivotGridField fieldExtendedPrice;
        private PivotGridField fieldQuantity;
        private PivotGridField fieldOrderCount;
        private PivotGridField fieldNewYearBonus;
        private PivotGridField fieldOrderCountBonus;
        private PivotGridField fieldBonusAmount;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbSalesPerson;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnAddBonus;
        private DevExpress.XtraEditors.PanelControl panelControl2;
    }
}

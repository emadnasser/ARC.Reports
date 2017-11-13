namespace DevExpress.XtraPivotGrid.Demos.Modules {
	partial class ConditionalSortBySummary {
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition pivotGridStyleFormatCondition1 = new DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition();
			DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition pivotGridStyleFormatCondition2 = new DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition();
			DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition pivotGridStyleFormatCondition3 = new DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition();
			this.fieldExtendedPrice = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldQuantity = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldDiscount = new DevExpress.XtraPivotGrid.PivotGridField();
			this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
			this.fieldMonth = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldSalesPerson = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldYear = new DevExpress.XtraPivotGrid.PivotGridField();
			((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
			this.SuspendLayout();
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
			this.fieldQuantity.AreaIndex = 1;
			this.fieldQuantity.Caption = "Quantity";
			this.fieldQuantity.FieldName = "Quantity";
			this.fieldQuantity.Name = "fieldQuantity";
			// 
			// fieldDiscount
			// 
			this.fieldDiscount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldDiscount.AreaIndex = 2;
			this.fieldDiscount.Caption = "Discount (Avg)";
			this.fieldDiscount.CellFormat.FormatString = "p";
			this.fieldDiscount.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldDiscount.FieldName = "Discount";
			this.fieldDiscount.Name = "fieldDiscount";
			this.fieldDiscount.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average;
			// 
			// pivotGridControl1
			// 
			this.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
			this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldMonth,
            this.fieldSalesPerson,
            this.fieldExtendedPrice,
            this.fieldYear,
            this.fieldQuantity,
            this.fieldDiscount});
			pivotGridStyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
			pivotGridStyleFormatCondition1.Appearance.Options.UseForeColor = true;
			pivotGridStyleFormatCondition1.ApplyToCustomTotalCell = false;
			pivotGridStyleFormatCondition1.ApplyToGrandTotalCell = false;
			pivotGridStyleFormatCondition1.ApplyToTotalCell = false;
			pivotGridStyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater;
			pivotGridStyleFormatCondition1.Field = this.fieldExtendedPrice;
			pivotGridStyleFormatCondition1.FieldName = "fieldExtendedPrice";
			pivotGridStyleFormatCondition1.Value1 = 10000;
			pivotGridStyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Blue;
			pivotGridStyleFormatCondition2.Appearance.Options.UseForeColor = true;
			pivotGridStyleFormatCondition2.ApplyToCustomTotalCell = false;
			pivotGridStyleFormatCondition2.ApplyToGrandTotalCell = false;
			pivotGridStyleFormatCondition2.ApplyToTotalCell = false;
			pivotGridStyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater;
			pivotGridStyleFormatCondition2.Field = this.fieldQuantity;
			pivotGridStyleFormatCondition2.FieldName = "fieldQuantity";
			pivotGridStyleFormatCondition2.Value1 = 350;
			pivotGridStyleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.Green;
			pivotGridStyleFormatCondition3.Appearance.Options.UseForeColor = true;
			pivotGridStyleFormatCondition3.ApplyToCustomTotalCell = false;
			pivotGridStyleFormatCondition3.ApplyToGrandTotalCell = false;
			pivotGridStyleFormatCondition3.ApplyToTotalCell = false;
			pivotGridStyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater;
			pivotGridStyleFormatCondition3.Field = this.fieldDiscount;
			pivotGridStyleFormatCondition3.FieldName = "fieldDiscount";
			pivotGridStyleFormatCondition3.Value1 = 0.1F;
			this.pivotGridControl1.FormatConditions.AddRange(new DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition[] {
            pivotGridStyleFormatCondition1,
            pivotGridStyleFormatCondition2,
            pivotGridStyleFormatCondition3});
			this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
			this.pivotGridControl1.Name = "pivotGridControl1";
			this.pivotGridControl1.Size = new System.Drawing.Size(707, 416);
			this.pivotGridControl1.TabIndex = 14;
			// 
			// fieldMonth
			// 
			this.fieldMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldMonth.AreaIndex = 1;
			this.fieldMonth.Caption = "Order Month";
			this.fieldMonth.FieldName = "OrderDate";
			this.fieldMonth.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
			this.fieldMonth.Name = "fieldMonth";
			this.fieldMonth.UnboundFieldName = "fieldQuarter";
			this.fieldMonth.Width = 120;
			// 
			// fieldSalesPerson
			// 
			this.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fieldSalesPerson.AreaIndex = 0;
			this.fieldSalesPerson.FieldName = "Sales Person";
			this.fieldSalesPerson.Name = "fieldSalesPerson";
			this.fieldSalesPerson.SortBySummaryInfo.Field = this.fieldExtendedPrice;
			this.fieldSalesPerson.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
			this.fieldSalesPerson.Width = 150;
			// 
			// fieldYear
			// 
			this.fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldYear.AreaIndex = 0;
			this.fieldYear.Caption = "Order Year";
			this.fieldYear.FieldName = "OrderDate";
			this.fieldYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
			this.fieldYear.Name = "fieldYear";
			this.fieldYear.Options.AllowSortBySummary = DevExpress.Utils.DefaultBoolean.False;
			this.fieldYear.UnboundFieldName = "fieldYear";
			// 
			// ConditionalSortBySummary
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pivotGridControl1);
			this.Name = "ConditionalSortBySummary";
			this.Size = new System.Drawing.Size(707, 416);
			this.Load += new System.EventHandler(this.ConditionalSortBySummary_Load);
			((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private PivotGridControl pivotGridControl1;
		private PivotGridField fieldMonth;
		private PivotGridField fieldSalesPerson;
		private PivotGridField fieldExtendedPrice;
		private PivotGridField fieldYear;
		private PivotGridField fieldQuantity;
		private PivotGridField fieldDiscount;
	}
}

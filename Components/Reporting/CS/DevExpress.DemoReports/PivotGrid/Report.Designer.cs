using System;
using System.Collections.Generic;
using System.Text;

namespace XtraReportsDemos.PivotGrid {
    public partial class Report {
        private DevExpress.XtraReports.UI.DetailBand Detail;
        
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.fieldOrderID = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldProduct = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldUnitPrice = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldQuantity = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldDiscount = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldSum = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrPivotGrid1 = new DevExpress.XtraReports.UI.XRPivotGrid();
            this.dsOrderReports = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.fieldProductID = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrPivotGridCellStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.xrPivotGridFieldStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // fieldOrderID
            // 
            this.fieldOrderID.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldOrderID.AreaIndex = 0;
            this.fieldOrderID.Caption = "Order";
            this.fieldOrderID.FieldName = "OrderID";
            this.fieldOrderID.Name = "fieldOrderID";
            this.fieldOrderID.Width = 54;
            // 
            // fieldProduct
            // 
            this.fieldProduct.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProduct.AreaIndex = 2;
            this.fieldProduct.Caption = "Product Name";
            this.fieldProduct.FieldName = "ProductName";
            this.fieldProduct.Name = "fieldProduct";
            this.fieldProduct.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
            this.fieldProduct.Width = 185;
            // 
            // fieldUnitPrice
            // 
            this.fieldUnitPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldUnitPrice.AreaIndex = 0;
            this.fieldUnitPrice.Caption = "Unit Price";
            this.fieldUnitPrice.CellFormat.FormatString = "c";
            this.fieldUnitPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldUnitPrice.FieldName = "UnitPrice";
            this.fieldUnitPrice.Name = "fieldUnitPrice";
            this.fieldUnitPrice.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.False;
            this.fieldUnitPrice.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average;
            this.fieldUnitPrice.Width = 122;
            // 
            // fieldQuantity
            // 
            this.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldQuantity.AreaIndex = 1;
            this.fieldQuantity.FieldName = "Quantity";
            this.fieldQuantity.Name = "fieldQuantity";
            this.fieldQuantity.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.False;
            this.fieldQuantity.Width = 125;
            // 
            // fieldDiscount
            // 
            this.fieldDiscount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldDiscount.AreaIndex = 2;
            this.fieldDiscount.FieldName = "Discount";
            this.fieldDiscount.Name = "fieldDiscount";
            this.fieldDiscount.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.False;
            this.fieldDiscount.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average;
            this.fieldDiscount.TotalCellFormat.FormatString = "P";
            this.fieldDiscount.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldDiscount.Width = 126;
            // 
            // fieldSum
            // 
            this.fieldSum.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldSum.AreaIndex = 3;
            this.fieldSum.CellFormat.FormatString = "c";
            this.fieldSum.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldSum.FieldName = "ExtendedPrice";
            this.fieldSum.Name = "fieldSum";
            this.fieldSum.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.False;
            this.fieldSum.Width = 134;
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPivotGrid1});
            this.Detail.HeightF = 75F;
            this.Detail.Name = "Detail";
            // 
            // xrPivotGrid1
            // 
            this.xrPivotGrid1.CellStyleName = "xrPivotGridCellStyle";
            this.xrPivotGrid1.DataMember = "OrderReports";
            this.xrPivotGrid1.DataSource = this.dsOrderReports;
            this.xrPivotGrid1.FieldHeaderStyleName = "xrPivotGridFieldStyle";
            this.xrPivotGrid1.Fields.AddRange(new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField[] {
            this.fieldOrderID,
            this.fieldProduct,
            this.fieldUnitPrice,
            this.fieldQuantity,
            this.fieldDiscount,
            this.fieldSum,
            this.fieldProductID});
            this.xrPivotGrid1.FieldValueStyleName = "xrPivotGridFieldStyle";
            this.xrPivotGrid1.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 0F);
            this.xrPivotGrid1.Name = "xrPivotGrid1";
            this.xrPivotGrid1.OptionsDataField.AreaIndex = 0;
            this.xrPivotGrid1.OptionsPrint.FilterSeparatorBarPadding = 3;
            this.xrPivotGrid1.OptionsView.ShowDataHeaders = false;
            this.xrPivotGrid1.Prefilter.CriteriaString = "[fieldOrderID] < 10261";
            this.xrPivotGrid1.SizeF = new System.Drawing.SizeF(879.9999F, 70.00002F);
            // 
            // dsOrderReports
            // 
            this.dsOrderReports.ConnectionName = "NWindConnectionString";
            this.dsOrderReports.Name = "dsOrderReports";
            columnExpression1.ColumnName = "OrderID";
            table1.Name = "OrderDetailsExtended";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "ProductID";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "ProductName";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "UnitPrice";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "Quantity";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "Discount";
            columnExpression6.Table = table1;
            column6.Expression = columnExpression6;
            columnExpression7.ColumnName = "ExtendedPrice";
            columnExpression7.Table = table1;
            column7.Expression = columnExpression7;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Columns.Add(column6);
            selectQuery1.Columns.Add(column7);
            selectQuery1.Name = "OrderReports";
            selectQuery1.Tables.Add(table1);
            this.dsOrderReports.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.dsOrderReports.ResultSchemaSerializable = resources.GetString("dsOrderReports.ResultSchemaSerializable");
            // 
            // fieldProductID
            // 
            this.fieldProductID.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProductID.AreaIndex = 1;
            this.fieldProductID.FieldName = "ProductID";
            this.fieldProductID.Name = "fieldProductID";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2});
            this.ReportHeader.HeightF = 73F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Underline);
            this.xrLabel2.ForeColor = System.Drawing.Color.Black;
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(289.2083F, 0F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(324F, 42F);
            this.xrLabel2.Text = "Orders Report";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox1,
            this.xrPageInfo1});
            this.BottomMargin.HeightF = 84.99998F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox1.Image")));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(382.3333F, 38.3333F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.NavigateUrl = "http://www.devexpress.com/Products/NET/Reporting/";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(165.625F, 30.20833F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize;
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrPageInfo1.Format = "Page : {0 } / {1}";
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(791.9999F, 10.00001F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(98F, 17F);
            // 
            // xrPivotGridCellStyle
            // 
            this.xrPivotGridCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(216)))));
            this.xrPivotGridCellStyle.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrPivotGridCellStyle.Name = "xrPivotGridCellStyle";
            this.xrPivotGridCellStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            // 
            // xrPivotGridFieldStyle
            // 
            this.xrPivotGridFieldStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(223)))), ((int)(((byte)(201)))));
            this.xrPivotGridFieldStyle.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrPivotGridFieldStyle.Name = "xrPivotGridFieldStyle";
            this.xrPivotGridFieldStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.HeightF = 100F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // Report
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.ReportHeader,
            this.BottomMargin,
            this.topMarginBand1});
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 100, 85);
            this.PageHeight = 850;
            this.PageWidth = 1100;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.xrPivotGridCellStyle,
            this.xrPivotGridFieldStyle});
            this.Version = "16.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

		private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldOrderID;
		private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldProduct;
		private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldUnitPrice;
		private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldQuantity;
		private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldDiscount;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldSum;
		private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
		private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
		internal DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
		private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
		private DevExpress.XtraReports.UI.XRLabel xrLabel2;
		private DevExpress.XtraReports.UI.XRControlStyle xrPivotGridCellStyle;
		private DevExpress.XtraReports.UI.XRControlStyle xrPivotGridFieldStyle;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldProductID;
        public DevExpress.XtraReports.UI.XRPivotGrid xrPivotGrid1;
        private DevExpress.DataAccess.Sql.SqlDataSource dsOrderReports;
        private System.ComponentModel.IContainer components;
    }
}

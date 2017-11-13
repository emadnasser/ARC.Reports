using System;
using System.Collections.Generic;
using System.Text;

namespace XtraReportsDemos.NorthwindTraders {
    partial class InvoiceReport {
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader0;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter0;
        private DevExpress.XtraReports.UI.XRLabel lbShipName;
        private DevExpress.XtraReports.UI.XRLabel lbShipAddress;
        private DevExpress.XtraReports.UI.XRLabel lbShipCityRegionPostalCode;
        private DevExpress.XtraReports.UI.XRLabel lbShipCountry;
        private DevExpress.XtraReports.UI.XRLabel lbAddress1;
        private DevExpress.XtraReports.UI.XRLabel lbCountry;
        private DevExpress.XtraReports.UI.XRLabel lbCompanyName;
        private DevExpress.XtraReports.UI.XRLabel lbCityRegionPostalCode;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTable xrTable3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell22;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell25;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell26;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell27;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell28;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell29;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell30;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell31;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell32;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell33;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell34;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell35;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell10;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell24;
        private DevExpress.XtraReports.UI.XRTableCell clExtPrice;
        private DevExpress.XtraReports.UI.XRTableCell clSubtotal;
        private DevExpress.XtraReports.UI.XRTableCell clTotal;
        private DevExpress.XtraReports.UI.XRTableCell clProductID;
        private DevExpress.XtraReports.UI.XRTableCell clProductName;
        private DevExpress.XtraReports.UI.XRTableCell clQuantity;
        private DevExpress.XtraReports.UI.XRTableCell clUnitPrice;
        private DevExpress.XtraReports.UI.XRTableCell clDiscount;
        private DevExpress.XtraReports.UI.XRTableCell clOrderID;
        private DevExpress.XtraReports.UI.XRTableCell clCustomerID;
        private DevExpress.XtraReports.UI.XRTableCell clSalesperson;
        private DevExpress.XtraReports.UI.XRTableCell clOrderDate;
        private DevExpress.XtraReports.UI.XRTableCell clRequiredDate;
        private DevExpress.XtraReports.UI.XRTableCell clShippedDate;
        private DevExpress.XtraReports.UI.XRTableCell clShipVia;
        private DevExpress.XtraReports.UI.XRTableCell clFreight;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow5;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow6;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow7;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow8;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRLabel lbDate;
        private DevExpress.XtraReports.UI.XRLabel lbAddress;
        private DevExpress.XtraReports.UI.XRLabel lbInvoice;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox2;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
		private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLabel lbBillTo;
        private DevExpress.XtraReports.UI.XRLabel lbShipTo;
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceReport));
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
            DevExpress.DataAccess.Sql.Column column8 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression8 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column9 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression9 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column10 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression10 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column11 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression11 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column12 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression12 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column13 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression13 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column14 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression14 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column15 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression15 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column16 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression16 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column17 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression17 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column18 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression18 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table3 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column19 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression19 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column20 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression20 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table4 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column21 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression21 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column22 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression22 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table5 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column23 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression23 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column24 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression24 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column25 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression25 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column26 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression26 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column27 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression27 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column28 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression28 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table6 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Join join1 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Join join2 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo2 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Join join3 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo3 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Join join4 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo4 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Join join5 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo5 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.clProductID = new DevExpress.XtraReports.UI.XRTableCell();
            this.clProductName = new DevExpress.XtraReports.UI.XRTableCell();
            this.clQuantity = new DevExpress.XtraReports.UI.XRTableCell();
            this.clUnitPrice = new DevExpress.XtraReports.UI.XRTableCell();
            this.clDiscount = new DevExpress.XtraReports.UI.XRTableCell();
            this.clExtPrice = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader0 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.lbShipTo = new DevExpress.XtraReports.UI.XRLabel();
            this.lbBillTo = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell30 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell31 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell32 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell33 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell34 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell35 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.clOrderID = new DevExpress.XtraReports.UI.XRTableCell();
            this.clCustomerID = new DevExpress.XtraReports.UI.XRTableCell();
            this.clSalesperson = new DevExpress.XtraReports.UI.XRTableCell();
            this.clOrderDate = new DevExpress.XtraReports.UI.XRTableCell();
            this.clRequiredDate = new DevExpress.XtraReports.UI.XRTableCell();
            this.clShippedDate = new DevExpress.XtraReports.UI.XRTableCell();
            this.clShipVia = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lbShipName = new DevExpress.XtraReports.UI.XRLabel();
            this.lbShipAddress = new DevExpress.XtraReports.UI.XRLabel();
            this.lbShipCityRegionPostalCode = new DevExpress.XtraReports.UI.XRLabel();
            this.lbShipCountry = new DevExpress.XtraReports.UI.XRLabel();
            this.lbAddress1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbCountry = new DevExpress.XtraReports.UI.XRLabel();
            this.lbCompanyName = new DevExpress.XtraReports.UI.XRLabel();
            this.lbCityRegionPostalCode = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupFooter0 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.clSubtotal = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.clFreight = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.clTotal = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.lbDate = new DevExpress.XtraReports.UI.XRLabel();
            this.lbAddress = new DevExpress.XtraReports.UI.XRLabel();
            this.lbInvoice = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPictureBox2 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrPictureBox3 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.ExtendedPrice = new DevExpress.XtraReports.UI.CalculatedField();
            this.SalesPerson = new DevExpress.XtraReports.UI.CalculatedField();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
            this.Detail.HeightF = 23F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable2
            // 
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow5});
            this.xrTable2.SizeF = new System.Drawing.SizeF(651F, 23F);
            this.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTableRow5
            // 
            this.xrTableRow5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.xrTableRow5.BorderColor = System.Drawing.Color.White;
            this.xrTableRow5.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableRow5.BorderWidth = 1F;
            this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.clProductID,
            this.clProductName,
            this.clQuantity,
            this.clUnitPrice,
            this.clDiscount,
            this.clExtPrice});
            this.xrTableRow5.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrTableRow5.Name = "xrTableRow5";
            this.xrTableRow5.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow5.Weight = 1D;
            // 
            // clProductID
            // 
            this.clProductID.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Invoices.ProductID")});
            this.clProductID.Name = "clProductID";
            this.clProductID.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.clProductID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.clProductID.Weight = 0.10906298003072197D;
            // 
            // clProductName
            // 
            this.clProductName.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Invoices.ProductName")});
            this.clProductName.Name = "clProductName";
            this.clProductName.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 0, 0, 0, 100F);
            this.clProductName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.clProductName.Weight = 0.30261136712749614D;
            // 
            // clQuantity
            // 
            this.clQuantity.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Invoices.Quantity")});
            this.clQuantity.Name = "clQuantity";
            this.clQuantity.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 100F);
            this.clQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.clQuantity.Weight = 0.13671274961597543D;
            // 
            // clUnitPrice
            // 
            this.clUnitPrice.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Invoices.UnitPrice", "{0:$#,##.00}")});
            this.clUnitPrice.Name = "clUnitPrice";
            this.clUnitPrice.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 100F);
            this.clUnitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.clUnitPrice.Weight = 0.13671274961597543D;
            // 
            // clDiscount
            // 
            this.clDiscount.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Invoices.Discount", "{0:0%}")});
            this.clDiscount.Name = "clDiscount";
            this.clDiscount.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 100F);
            this.clDiscount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.clDiscount.Weight = 0.13671274961597543D;
            // 
            // clExtPrice
            // 
            this.clExtPrice.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Invoices.ExtendedPrice", "{0:$#,##.00}")});
            this.clExtPrice.Name = "clExtPrice";
            this.clExtPrice.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 100F);
            this.clExtPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.clExtPrice.Weight = 0.1781874039938556D;
            // 
            // GroupHeader0
            // 
            this.GroupHeader0.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbShipTo,
            this.lbBillTo,
            this.xrTable1,
            this.lbShipName,
            this.lbShipAddress,
            this.lbShipCityRegionPostalCode,
            this.lbShipCountry,
            this.lbAddress1,
            this.lbCountry,
            this.lbCompanyName,
            this.lbCityRegionPostalCode});
            this.GroupHeader0.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("OrderID", DevExpress.XtraReports.UI.XRColumnSortOrder.Descending)});
            this.GroupHeader0.HeightF = 219F;
            this.GroupHeader0.Name = "GroupHeader0";
            this.GroupHeader0.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader0.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lbShipTo
            // 
            this.lbShipTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.lbShipTo.BorderColor = System.Drawing.Color.White;
            this.lbShipTo.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.lbShipTo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbShipTo.ForeColor = System.Drawing.Color.Black;
            this.lbShipTo.LocationFloat = new DevExpress.Utils.PointFloat(0F, 17F);
            this.lbShipTo.Name = "lbShipTo";
            this.lbShipTo.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 0, 0, 0, 100F);
            this.lbShipTo.SizeF = new System.Drawing.SizeF(72F, 25F);
            this.lbShipTo.Text = "Ship To:";
            this.lbShipTo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lbBillTo
            // 
            this.lbBillTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.lbBillTo.BorderColor = System.Drawing.Color.White;
            this.lbBillTo.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.lbBillTo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbBillTo.ForeColor = System.Drawing.Color.Black;
            this.lbBillTo.LocationFloat = new DevExpress.Utils.PointFloat(359F, 17F);
            this.lbBillTo.Name = "lbBillTo";
            this.lbBillTo.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 0, 0, 0, 100F);
            this.lbBillTo.SizeF = new System.Drawing.SizeF(66F, 25F);
            this.lbBillTo.Text = "Bill To:";
            this.lbBillTo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTable1
            // 
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 130F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1,
            this.xrTableRow2,
            this.xrTableRow3,
            this.xrTableRow4});
            this.xrTable1.SizeF = new System.Drawing.SizeF(651F, 89F);
            this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(167)))), ((int)(((byte)(73)))));
            this.xrTableRow1.BorderColor = System.Drawing.Color.White;
            this.xrTableRow1.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell29,
            this.xrTableCell30,
            this.xrTableCell31,
            this.xrTableCell32,
            this.xrTableCell33,
            this.xrTableCell34,
            this.xrTableCell35});
            this.xrTableRow1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.xrTableRow1.ForeColor = System.Drawing.Color.White;
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow1.Weight = 0.25842696629213485D;
            // 
            // xrTableCell29
            // 
            this.xrTableCell29.Name = "xrTableCell29";
            this.xrTableCell29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell29.Text = "Order ID:";
            this.xrTableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell29.Weight = 0.10906298003072197D;
            // 
            // xrTableCell30
            // 
            this.xrTableCell30.Name = "xrTableCell30";
            this.xrTableCell30.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell30.Text = "Customer ID:";
            this.xrTableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell30.Weight = 0.130568356374808D;
            // 
            // xrTableCell31
            // 
            this.xrTableCell31.Name = "xrTableCell31";
            this.xrTableCell31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell31.Text = "Salesperson:";
            this.xrTableCell31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell31.Weight = 0.17357910906298002D;
            // 
            // xrTableCell32
            // 
            this.xrTableCell32.Name = "xrTableCell32";
            this.xrTableCell32.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell32.Text = "Order Date:";
            this.xrTableCell32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell32.Weight = 0.13671274961597543D;
            // 
            // xrTableCell33
            // 
            this.xrTableCell33.Name = "xrTableCell33";
            this.xrTableCell33.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell33.Text = "Required Date:";
            this.xrTableCell33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell33.Weight = 0.13671274961597543D;
            // 
            // xrTableCell34
            // 
            this.xrTableCell34.Name = "xrTableCell34";
            this.xrTableCell34.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell34.Text = "Shipped Date:";
            this.xrTableCell34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell34.Weight = 0.13671274961597543D;
            // 
            // xrTableCell35
            // 
            this.xrTableCell35.Name = "xrTableCell35";
            this.xrTableCell35.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell35.Text = "Ship Via:";
            this.xrTableCell35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell35.Weight = 0.17665130568356374D;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.xrTableRow2.BorderColor = System.Drawing.Color.White;
            this.xrTableRow2.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.clOrderID,
            this.clCustomerID,
            this.clSalesperson,
            this.clOrderDate,
            this.clRequiredDate,
            this.clShippedDate,
            this.clShipVia});
            this.xrTableRow2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow2.Weight = 0.25842696629213485D;
            // 
            // clOrderID
            // 
            this.clOrderID.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Invoices.OrderID")});
            this.clOrderID.Name = "clOrderID";
            this.clOrderID.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.clOrderID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.clOrderID.Weight = 0.10906298003072197D;
            // 
            // clCustomerID
            // 
            this.clCustomerID.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Invoices.CustomerID")});
            this.clCustomerID.Name = "clCustomerID";
            this.clCustomerID.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.clCustomerID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.clCustomerID.Weight = 0.130568356374808D;
            // 
            // clSalesperson
            // 
            this.clSalesperson.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Invoices.Salesperson")});
            this.clSalesperson.Name = "clSalesperson";
            this.clSalesperson.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.clSalesperson.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.clSalesperson.Weight = 0.17357910906298002D;
            // 
            // clOrderDate
            // 
            this.clOrderDate.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Invoices.OrderDate", "{0:MM/dd/yyyy}")});
            this.clOrderDate.Name = "clOrderDate";
            this.clOrderDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.clOrderDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.clOrderDate.Weight = 0.13671274961597543D;
            // 
            // clRequiredDate
            // 
            this.clRequiredDate.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Invoices.RequiredDate", "{0:MM/dd/yyyy}")});
            this.clRequiredDate.Name = "clRequiredDate";
            this.clRequiredDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.clRequiredDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.clRequiredDate.Weight = 0.13671274961597543D;
            // 
            // clShippedDate
            // 
            this.clShippedDate.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Invoices.ShippedDate", "{0:MM/dd/yyyy}")});
            this.clShippedDate.Name = "clShippedDate";
            this.clShippedDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.clShippedDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.clShippedDate.Weight = 0.13671274961597543D;
            // 
            // clShipVia
            // 
            this.clShipVia.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Invoices.ShippersCompanyName")});
            this.clShipVia.Name = "clShipVia";
            this.clShipVia.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.clShipVia.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.clShipVia.Weight = 0.17665130568356374D;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow3.Weight = 0.2247191011235955D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell1.Weight = 1D;
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(167)))), ((int)(((byte)(73)))));
            this.xrTableRow4.BorderColor = System.Drawing.Color.White;
            this.xrTableRow4.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell22,
            this.xrTableCell24,
            this.xrTableCell25,
            this.xrTableCell26,
            this.xrTableCell27,
            this.xrTableCell28});
            this.xrTableRow4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.xrTableRow4.ForeColor = System.Drawing.Color.White;
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow4.Weight = 0.25842696629213485D;
            // 
            // xrTableCell22
            // 
            this.xrTableCell22.Name = "xrTableCell22";
            this.xrTableCell22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell22.Text = "Product ID:";
            this.xrTableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell22.Weight = 0.10906298003072197D;
            // 
            // xrTableCell24
            // 
            this.xrTableCell24.Name = "xrTableCell24";
            this.xrTableCell24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell24.Text = "Product Name:";
            this.xrTableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell24.Weight = 0.30261136712749614D;
            // 
            // xrTableCell25
            // 
            this.xrTableCell25.Name = "xrTableCell25";
            this.xrTableCell25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell25.Text = "Quantity:";
            this.xrTableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell25.Weight = 0.13671274961597543D;
            // 
            // xrTableCell26
            // 
            this.xrTableCell26.Name = "xrTableCell26";
            this.xrTableCell26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell26.Text = "Unit Price:";
            this.xrTableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell26.Weight = 0.13671274961597543D;
            // 
            // xrTableCell27
            // 
            this.xrTableCell27.Name = "xrTableCell27";
            this.xrTableCell27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell27.Text = "Discount:";
            this.xrTableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell27.Weight = 0.13671274961597543D;
            // 
            // xrTableCell28
            // 
            this.xrTableCell28.Name = "xrTableCell28";
            this.xrTableCell28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell28.Text = "Extended Price:";
            this.xrTableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell28.Weight = 0.1781874039938556D;
            // 
            // lbShipName
            // 
            this.lbShipName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lbShipName.BorderColor = System.Drawing.Color.White;
            this.lbShipName.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.lbShipName.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Invoices.ShipName")});
            this.lbShipName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lbShipName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbShipName.LocationFloat = new DevExpress.Utils.PointFloat(72F, 17F);
            this.lbShipName.Name = "lbShipName";
            this.lbShipName.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 0, 0, 0, 100F);
            this.lbShipName.SizeF = new System.Drawing.SizeF(225F, 25F);
            this.lbShipName.Text = "ShipName";
            this.lbShipName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lbShipAddress
            // 
            this.lbShipAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lbShipAddress.BorderColor = System.Drawing.Color.White;
            this.lbShipAddress.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.lbShipAddress.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Invoices.ShipAddress")});
            this.lbShipAddress.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lbShipAddress.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbShipAddress.LocationFloat = new DevExpress.Utils.PointFloat(72F, 42F);
            this.lbShipAddress.Name = "lbShipAddress";
            this.lbShipAddress.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 0, 0, 0, 100F);
            this.lbShipAddress.SizeF = new System.Drawing.SizeF(225F, 25F);
            this.lbShipAddress.Text = "ShipAddress";
            this.lbShipAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lbShipCityRegionPostalCode
            // 
            this.lbShipCityRegionPostalCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lbShipCityRegionPostalCode.BorderColor = System.Drawing.Color.White;
            this.lbShipCityRegionPostalCode.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.lbShipCityRegionPostalCode.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lbShipCityRegionPostalCode.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbShipCityRegionPostalCode.LocationFloat = new DevExpress.Utils.PointFloat(72F, 67F);
            this.lbShipCityRegionPostalCode.Name = "lbShipCityRegionPostalCode";
            this.lbShipCityRegionPostalCode.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 0, 0, 0, 100F);
            this.lbShipCityRegionPostalCode.SizeF = new System.Drawing.SizeF(225F, 25F);
            this.lbShipCityRegionPostalCode.Text = "ShipCityRegionPostalCode";
            this.lbShipCityRegionPostalCode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lbShipCityRegionPostalCode.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.lbShipCityRegionPostalCode_BeforePrint);
            // 
            // lbShipCountry
            // 
            this.lbShipCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lbShipCountry.BorderColor = System.Drawing.Color.White;
            this.lbShipCountry.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.lbShipCountry.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Invoices.ShipCountry")});
            this.lbShipCountry.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lbShipCountry.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbShipCountry.LocationFloat = new DevExpress.Utils.PointFloat(72F, 92F);
            this.lbShipCountry.Name = "lbShipCountry";
            this.lbShipCountry.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 0, 0, 0, 100F);
            this.lbShipCountry.SizeF = new System.Drawing.SizeF(225F, 25F);
            this.lbShipCountry.Text = "ShipCountry";
            this.lbShipCountry.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lbAddress1
            // 
            this.lbAddress1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lbAddress1.BorderColor = System.Drawing.Color.White;
            this.lbAddress1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.lbAddress1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Invoices.Address")});
            this.lbAddress1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lbAddress1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbAddress1.LocationFloat = new DevExpress.Utils.PointFloat(425F, 42F);
            this.lbAddress1.Name = "lbAddress1";
            this.lbAddress1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 0, 0, 0, 100F);
            this.lbAddress1.SizeF = new System.Drawing.SizeF(225F, 25F);
            this.lbAddress1.Text = "Address";
            this.lbAddress1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lbCountry
            // 
            this.lbCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lbCountry.BorderColor = System.Drawing.Color.White;
            this.lbCountry.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.lbCountry.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Invoices.Country")});
            this.lbCountry.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lbCountry.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbCountry.LocationFloat = new DevExpress.Utils.PointFloat(425F, 92F);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 0, 0, 0, 100F);
            this.lbCountry.SizeF = new System.Drawing.SizeF(225F, 25F);
            this.lbCountry.Text = "Country";
            this.lbCountry.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lbCompanyName
            // 
            this.lbCompanyName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lbCompanyName.BorderColor = System.Drawing.Color.White;
            this.lbCompanyName.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.lbCompanyName.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Invoices.CustomersCompanyName")});
            this.lbCompanyName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lbCompanyName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbCompanyName.LocationFloat = new DevExpress.Utils.PointFloat(425F, 17F);
            this.lbCompanyName.Name = "lbCompanyName";
            this.lbCompanyName.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 0, 0, 0, 100F);
            this.lbCompanyName.SizeF = new System.Drawing.SizeF(225F, 25F);
            this.lbCompanyName.Text = "CompanyName";
            this.lbCompanyName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lbCityRegionPostalCode
            // 
            this.lbCityRegionPostalCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lbCityRegionPostalCode.BorderColor = System.Drawing.Color.White;
            this.lbCityRegionPostalCode.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.lbCityRegionPostalCode.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lbCityRegionPostalCode.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbCityRegionPostalCode.LocationFloat = new DevExpress.Utils.PointFloat(425F, 67F);
            this.lbCityRegionPostalCode.Name = "lbCityRegionPostalCode";
            this.lbCityRegionPostalCode.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 0, 0, 0, 100F);
            this.lbCityRegionPostalCode.SizeF = new System.Drawing.SizeF(225F, 25F);
            this.lbCityRegionPostalCode.Text = "CityRegionPostalCode";
            this.lbCityRegionPostalCode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lbCityRegionPostalCode.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.lbCityRegionPostalCode_BeforePrint);
            // 
            // GroupFooter0
            // 
            this.GroupFooter0.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable3});
            this.GroupFooter0.HeightF = 79.99998F;
            this.GroupFooter0.Name = "GroupFooter0";
            this.GroupFooter0.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupFooter0.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
            this.GroupFooter0.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable3
            // 
            this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(1F, 0F);
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow6,
            this.xrTableRow7,
            this.xrTableRow8});
            this.xrTable3.SizeF = new System.Drawing.SizeF(648F, 75F);
            this.xrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTableRow6
            // 
            this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell8,
            this.clSubtotal});
            this.xrTableRow6.Name = "xrTableRow6";
            this.xrTableRow6.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow6.Weight = 0.33333333333333331D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell8.Weight = 0.68827160493827155D;
            // 
            // clSubtotal
            // 
            this.clSubtotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.clSubtotal.BorderColor = System.Drawing.Color.White;
            this.clSubtotal.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.clSubtotal.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Invoices.ExtendedPrice")});
            this.clSubtotal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.clSubtotal.ForeColor = System.Drawing.Color.Black;
            this.clSubtotal.Name = "clSubtotal";
            this.clSubtotal.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 100F);
            xrSummary1.FormatString = "{0:\'SubTotal:  \'$#,##.00}";
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.clSubtotal.Summary = xrSummary1;
            this.clSubtotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.clSubtotal.Weight = 0.31172839506172839D;
            this.clSubtotal.XlsxFormatString = "\"SubTotal: \"$#,##.00";
            // 
            // xrTableRow7
            // 
            this.xrTableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell2,
            this.clFreight});
            this.xrTableRow7.Name = "xrTableRow7";
            this.xrTableRow7.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow7.Weight = 0.33333333333333331D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell2.Weight = 0.68827160493827155D;
            // 
            // clFreight
            // 
            this.clFreight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.clFreight.BorderColor = System.Drawing.Color.White;
            this.clFreight.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.clFreight.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Invoices.Freight", "{0:\'Frieght:  \'$#,##.00}")});
            this.clFreight.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.clFreight.ForeColor = System.Drawing.Color.Black;
            this.clFreight.Name = "clFreight";
            this.clFreight.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 100F);
            this.clFreight.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.clFreight.Weight = 0.31172839506172839D;
            this.clFreight.XlsxFormatString = "\"Frieght: \"$#,##.00";
            // 
            // xrTableRow8
            // 
            this.xrTableRow8.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell10,
            this.clTotal});
            this.xrTableRow8.Name = "xrTableRow8";
            this.xrTableRow8.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow8.Weight = 0.33333333333333331D;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell10.Weight = 0.68827160493827155D;
            // 
            // clTotal
            // 
            this.clTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.clTotal.BorderColor = System.Drawing.Color.White;
            this.clTotal.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.clTotal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.clTotal.ForeColor = System.Drawing.Color.Black;
            this.clTotal.Name = "clTotal";
            this.clTotal.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 4, 0, 0, 100F);
            this.clTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.clTotal.Weight = 0.31172839506172839D;
            this.clTotal.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.clTotal_BeforePrint);
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Format = "{0:d}";
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(561F, 100F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(87F, 16F);
            this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLine1
            // 
            this.xrLine1.LineWidth = 3;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 92F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLine1.SizeF = new System.Drawing.SizeF(648F, 8F);
            // 
            // lbDate
            // 
            this.lbDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbDate.ForeColor = System.Drawing.Color.Black;
            this.lbDate.LocationFloat = new DevExpress.Utils.PointFloat(511F, 100F);
            this.lbDate.Name = "lbDate";
            this.lbDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbDate.SizeF = new System.Drawing.SizeF(49F, 20F);
            this.lbDate.Text = "Date:";
            this.lbDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lbAddress
            // 
            this.lbAddress.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic);
            this.lbAddress.ForeColor = System.Drawing.Color.Black;
            this.lbAddress.LocationFloat = new DevExpress.Utils.PointFloat(8F, 100F);
            this.lbAddress.Multiline = true;
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbAddress.SizeF = new System.Drawing.SizeF(258F, 33F);
            this.lbAddress.Text = "One Portals Way, Twin Points WA  98156\r\nPhone: 1-206-555-1417   Fax: 1-206-555-59" +
    "38";
            this.lbAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lbInvoice
            // 
            this.lbInvoice.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.lbInvoice.ForeColor = System.Drawing.Color.Black;
            this.lbInvoice.LocationFloat = new DevExpress.Utils.PointFloat(511F, 0F);
            this.lbInvoice.Name = "lbInvoice";
            this.lbInvoice.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbInvoice.SizeF = new System.Drawing.SizeF(129F, 33F);
            this.lbInvoice.Text = "INVOICE";
            this.lbInvoice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPictureBox2
            // 
            this.xrPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox2.Image")));
            this.xrPictureBox2.LocationFloat = new DevExpress.Utils.PointFloat(94F, 18F);
            this.xrPictureBox2.Name = "xrPictureBox2";
            this.xrPictureBox2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrPictureBox2.SizeF = new System.Drawing.SizeF(189F, 45F);
            this.xrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox1,
            this.xrPageInfo1,
            this.lbDate,
            this.lbInvoice,
            this.xrPictureBox2,
            this.xrLine1,
            this.lbAddress});
            this.PageHeader.HeightF = 136F;
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox1.Image")));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(6F, 1F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(87.5F, 87.5F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox3});
            this.BottomMargin.HeightF = 75F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPictureBox3
            // 
            this.xrPictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox3.Image")));
            this.xrPictureBox3.LocationFloat = new DevExpress.Utils.PointFloat(254F, 13F);
            this.xrPictureBox3.Name = "xrPictureBox3";
            this.xrPictureBox3.NavigateUrl = "http://www.devexpress.com/Products/NET/Reporting/";
            this.xrPictureBox3.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrPictureBox3.SizeF = new System.Drawing.SizeF(165.625F, 30.20833F);
            this.xrPictureBox3.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize;
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.HeightF = 100F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "NWindConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "OrderID";
            table1.Name = "Orders";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "CustomerID";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "EmployeeID";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "OrderDate";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "RequiredDate";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "ShippedDate";
            columnExpression6.Table = table1;
            column6.Expression = columnExpression6;
            columnExpression7.ColumnName = "ShipVia";
            columnExpression7.Table = table1;
            column7.Expression = columnExpression7;
            columnExpression8.ColumnName = "Freight";
            columnExpression8.Table = table1;
            column8.Expression = columnExpression8;
            columnExpression9.ColumnName = "ShipName";
            columnExpression9.Table = table1;
            column9.Expression = columnExpression9;
            columnExpression10.ColumnName = "ShipAddress";
            columnExpression10.Table = table1;
            column10.Expression = columnExpression10;
            columnExpression11.ColumnName = "ShipCity";
            columnExpression11.Table = table1;
            column11.Expression = columnExpression11;
            columnExpression12.ColumnName = "ShipRegion";
            columnExpression12.Table = table1;
            column12.Expression = columnExpression12;
            columnExpression13.ColumnName = "ShipPostalCode";
            columnExpression13.Table = table1;
            column13.Expression = columnExpression13;
            columnExpression14.ColumnName = "ShipCountry";
            columnExpression14.Table = table1;
            column14.Expression = columnExpression14;
            columnExpression15.ColumnName = "UnitPrice";
            table2.Name = "OrderDetails";
            columnExpression15.Table = table2;
            column15.Expression = columnExpression15;
            columnExpression16.ColumnName = "Quantity";
            columnExpression16.Table = table2;
            column16.Expression = columnExpression16;
            columnExpression17.ColumnName = "Discount";
            columnExpression17.Table = table2;
            column17.Expression = columnExpression17;
            columnExpression18.ColumnName = "ProductID";
            table3.Name = "Products";
            columnExpression18.Table = table3;
            column18.Expression = columnExpression18;
            columnExpression19.ColumnName = "ProductName";
            columnExpression19.Table = table3;
            column19.Expression = columnExpression19;
            columnExpression20.ColumnName = "LastName";
            table4.Name = "Employees";
            columnExpression20.Table = table4;
            column20.Expression = columnExpression20;
            columnExpression21.ColumnName = "FirstName";
            columnExpression21.Table = table4;
            column21.Expression = columnExpression21;
            column22.Alias = "CustomersCompanyName";
            columnExpression22.ColumnName = "CompanyName";
            table5.Name = "Customers";
            columnExpression22.Table = table5;
            column22.Expression = columnExpression22;
            columnExpression23.ColumnName = "Address";
            columnExpression23.Table = table5;
            column23.Expression = columnExpression23;
            columnExpression24.ColumnName = "City";
            columnExpression24.Table = table5;
            column24.Expression = columnExpression24;
            columnExpression25.ColumnName = "Region";
            columnExpression25.Table = table5;
            column25.Expression = columnExpression25;
            columnExpression26.ColumnName = "PostalCode";
            columnExpression26.Table = table5;
            column26.Expression = columnExpression26;
            columnExpression27.ColumnName = "Country";
            columnExpression27.Table = table5;
            column27.Expression = columnExpression27;
            column28.Alias = "ShippersCompanyName";
            columnExpression28.ColumnName = "CompanyName";
            table6.Name = "Shippers";
            columnExpression28.Table = table6;
            column28.Expression = columnExpression28;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Columns.Add(column6);
            selectQuery1.Columns.Add(column7);
            selectQuery1.Columns.Add(column8);
            selectQuery1.Columns.Add(column9);
            selectQuery1.Columns.Add(column10);
            selectQuery1.Columns.Add(column11);
            selectQuery1.Columns.Add(column12);
            selectQuery1.Columns.Add(column13);
            selectQuery1.Columns.Add(column14);
            selectQuery1.Columns.Add(column15);
            selectQuery1.Columns.Add(column16);
            selectQuery1.Columns.Add(column17);
            selectQuery1.Columns.Add(column18);
            selectQuery1.Columns.Add(column19);
            selectQuery1.Columns.Add(column20);
            selectQuery1.Columns.Add(column21);
            selectQuery1.Columns.Add(column22);
            selectQuery1.Columns.Add(column23);
            selectQuery1.Columns.Add(column24);
            selectQuery1.Columns.Add(column25);
            selectQuery1.Columns.Add(column26);
            selectQuery1.Columns.Add(column27);
            selectQuery1.Columns.Add(column28);
            selectQuery1.FilterString = "Orders.OrderID < 10261";
            selectQuery1.Name = "Invoices";
            relationColumnInfo1.NestedKeyColumn = "OrderID";
            relationColumnInfo1.ParentKeyColumn = "OrderID";
            join1.KeyColumns.Add(relationColumnInfo1);
            join1.Nested = table2;
            join1.Parent = table1;
            relationColumnInfo2.NestedKeyColumn = "ProductID";
            relationColumnInfo2.ParentKeyColumn = "ProductID";
            join2.KeyColumns.Add(relationColumnInfo2);
            join2.Nested = table3;
            join2.Parent = table2;
            relationColumnInfo3.NestedKeyColumn = "EmployeeID";
            relationColumnInfo3.ParentKeyColumn = "EmployeeID";
            join3.KeyColumns.Add(relationColumnInfo3);
            join3.Nested = table4;
            join3.Parent = table1;
            relationColumnInfo4.NestedKeyColumn = "CustomerID";
            relationColumnInfo4.ParentKeyColumn = "CustomerID";
            join4.KeyColumns.Add(relationColumnInfo4);
            join4.Nested = table5;
            join4.Parent = table1;
            relationColumnInfo5.NestedKeyColumn = "ShipperID";
            relationColumnInfo5.ParentKeyColumn = "ShipVia";
            join5.KeyColumns.Add(relationColumnInfo5);
            join5.Nested = table6;
            join5.Parent = table1;
            selectQuery1.Relations.Add(join1);
            selectQuery1.Relations.Add(join2);
            selectQuery1.Relations.Add(join3);
            selectQuery1.Relations.Add(join4);
            selectQuery1.Relations.Add(join5);
            selectQuery1.Tables.Add(table1);
            selectQuery1.Tables.Add(table2);
            selectQuery1.Tables.Add(table3);
            selectQuery1.Tables.Add(table4);
            selectQuery1.Tables.Add(table5);
            selectQuery1.Tables.Add(table6);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // ExtendedPrice
            // 
            this.ExtendedPrice.DataMember = "Invoices";
            this.ExtendedPrice.Expression = "[UnitPrice]*[Quantity]*(1-[Discount])";
            this.ExtendedPrice.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
            this.ExtendedPrice.Name = "ExtendedPrice";
            // 
            // SalesPerson
            // 
            this.SalesPerson.DataMember = "Invoices";
            this.SalesPerson.Expression = "[FirstName] + \' \' + [LastName]";
            this.SalesPerson.Name = "SalesPerson";
            // 
            // InvoiceReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.GroupHeader0,
            this.Detail,
            this.GroupFooter0,
            this.PageHeader,
            this.BottomMargin,
            this.topMarginBand1});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.ExtendedPrice,
            this.SalesPerson});
            this.DataMember = "Invoices";
            this.DataSource = this.sqlDataSource1;
            this.Margins = new System.Drawing.Printing.Margins(99, 95, 100, 75);
            this.ReportPrintOptions.DetailCountAtDesignTime = 4;
            this.Version = "16.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        internal DevExpress.XtraReports.UI.XRPictureBox xrPictureBox3;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.CalculatedField ExtendedPrice;
        private DevExpress.XtraReports.UI.CalculatedField SalesPerson;
        private System.ComponentModel.IContainer components;
    }
}

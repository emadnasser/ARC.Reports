using System;
using System.Collections.Generic;
using System.Text;

namespace XtraReportsDemos.Subreports {
    partial class MasterReport {
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRLabel lbCompany;
        private DevExpress.XtraReports.UI.XRLabel lbCompany1;
        private DevExpress.XtraReports.UI.XRLabel lbOccupation;
        private DevExpress.XtraReports.UI.XRLabel lbOccupation1;
        private DevExpress.XtraReports.UI.XRLabel lbCustomer;
        private DevExpress.XtraReports.UI.XRLabel lbTitle;
        private DevExpress.XtraReports.UI.XRLabel lbDate;
		private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
		internal DevExpress.XtraReports.UI.XRPictureBox xrPictureBox4;
        private DevExpress.XtraReports.UI.XRLabel lbPersonName;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRSubreport subreport1;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterReport));
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.CustomExpression customExpression1 = new DevExpress.DataAccess.Sql.CustomExpression();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.lbDate = new DevExpress.XtraReports.UI.XRLabel();
            this.lbTitle = new DevExpress.XtraReports.UI.XRLabel();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lbPersonName = new DevExpress.XtraReports.UI.XRLabel();
            this.lbCustomer = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lbOccupation1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbOccupation = new DevExpress.XtraReports.UI.XRLabel();
            this.lbCompany1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbCompany = new DevExpress.XtraReports.UI.XRLabel();
            this.fromDateParameter = new DevExpress.XtraReports.Parameters.Parameter();
            this.toDateParameter = new DevExpress.XtraReports.Parameters.Parameter();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrPictureBox4 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.dsCust1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.subreport1 = new DevExpress.XtraReports.UI.XRSubreport();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbDate,
            this.lbTitle});
            this.ReportHeader.HeightF = 88F;
            this.ReportHeader.Name = "ReportHeader";
            this.ReportHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lbDate
            // 
            this.lbDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lbDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(142)))), ((int)(((byte)(158)))));
            this.lbDate.LocationFloat = new DevExpress.Utils.PointFloat(17F, 48F);
            this.lbDate.Name = "lbDate";
            this.lbDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbDate.SizeF = new System.Drawing.SizeF(628F, 16F);
            this.lbDate.Text = "Orders with purchase dates from [Parameters.fromDateParameter!d] to [Parameters.t" +
    "oDateParameter!d]";
            this.lbDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lbTitle
            // 
            this.lbTitle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(142)))), ((int)(((byte)(158)))));
            this.lbTitle.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.lbTitle.BorderWidth = 2F;
            this.lbTitle.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(142)))), ((int)(((byte)(158)))));
            this.lbTitle.LocationFloat = new DevExpress.Utils.PointFloat(17F, 20F);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbTitle.SizeF = new System.Drawing.SizeF(628F, 28F);
            this.lbTitle.Text = "Customer list with order information";
            this.lbTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1,
            this.subreport1});
            this.Detail.HeightF = 112F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // xrTable1
            // 
            this.xrTable1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(237)))));
            this.xrTable1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(214)))), ((int)(((byte)(200)))));
            this.xrTable1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Bookmark", null, "Customers.PersonName")});
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(15F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(628F, 60F);
            this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)));
            this.xrTableCell1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbPersonName,
            this.lbCustomer});
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell1.Text = "xrTableCell1";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell1.Weight = 0.39331210191082805D;
            // 
            // lbPersonName
            // 
            this.lbPersonName.BorderColor = System.Drawing.SystemColors.ControlText;
            this.lbPersonName.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lbPersonName.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Customers.PersonName")});
            this.lbPersonName.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbPersonName.LocationFloat = new DevExpress.Utils.PointFloat(80F, 8F);
            this.lbPersonName.Name = "lbPersonName";
            this.lbPersonName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbPersonName.SizeF = new System.Drawing.SizeF(106F, 25F);
            this.lbPersonName.Text = "lbPersonName";
            this.lbPersonName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lbCustomer
            // 
            this.lbCustomer.BorderColor = System.Drawing.SystemColors.ControlText;
            this.lbCustomer.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lbCustomer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(157)))), ((int)(((byte)(134)))));
            this.lbCustomer.LocationFloat = new DevExpress.Utils.PointFloat(8F, 8F);
            this.lbCustomer.Name = "lbCustomer";
            this.lbCustomer.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbCustomer.SizeF = new System.Drawing.SizeF(70F, 25F);
            this.lbCustomer.Text = "Customer:";
            this.lbCustomer.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbOccupation1,
            this.lbOccupation,
            this.lbCompany1,
            this.lbCompany});
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell2.Text = "xrTableCell2";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell2.Weight = 0.606687898089172D;
            // 
            // lbOccupation1
            // 
            this.lbOccupation1.BorderColor = System.Drawing.SystemColors.ControlText;
            this.lbOccupation1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lbOccupation1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Customers.Occupation")});
            this.lbOccupation1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbOccupation1.LocationFloat = new DevExpress.Utils.PointFloat(104F, 28F);
            this.lbOccupation1.Name = "lbOccupation1";
            this.lbOccupation1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbOccupation1.SizeF = new System.Drawing.SizeF(150F, 20F);
            this.lbOccupation1.Text = "xrLabel4";
            this.lbOccupation1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lbOccupation
            // 
            this.lbOccupation.BorderColor = System.Drawing.SystemColors.ControlText;
            this.lbOccupation.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lbOccupation.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbOccupation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(157)))), ((int)(((byte)(134)))));
            this.lbOccupation.LocationFloat = new DevExpress.Utils.PointFloat(12F, 28F);
            this.lbOccupation.Name = "lbOccupation";
            this.lbOccupation.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbOccupation.SizeF = new System.Drawing.SizeF(91F, 20F);
            this.lbOccupation.Text = "Occupation:";
            this.lbOccupation.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lbCompany1
            // 
            this.lbCompany1.BorderColor = System.Drawing.SystemColors.ControlText;
            this.lbCompany1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lbCompany1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Customers.Company")});
            this.lbCompany1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbCompany1.LocationFloat = new DevExpress.Utils.PointFloat(104F, 8F);
            this.lbCompany1.Name = "lbCompany1";
            this.lbCompany1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbCompany1.SizeF = new System.Drawing.SizeF(150F, 17F);
            this.lbCompany1.Text = "xrLabel3";
            this.lbCompany1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lbCompany
            // 
            this.lbCompany.BorderColor = System.Drawing.SystemColors.ControlText;
            this.lbCompany.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lbCompany.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(157)))), ((int)(((byte)(134)))));
            this.lbCompany.LocationFloat = new DevExpress.Utils.PointFloat(12F, 8F);
            this.lbCompany.Name = "lbCompany";
            this.lbCompany.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbCompany.SizeF = new System.Drawing.SizeF(83F, 17F);
            this.lbCompany.Text = "Company:";
            this.lbCompany.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // fromDateParameter
            // 
            this.fromDateParameter.Description = "From date:";
            this.fromDateParameter.Name = "fromDateParameter";
            this.fromDateParameter.Type = typeof(System.DateTime);
            this.fromDateParameter.ValueInfo = "2016-11-20";
            // 
            // toDateParameter
            // 
            this.toDateParameter.Description = "To date:";
            this.toDateParameter.Name = "toDateParameter";
            this.toDateParameter.Type = typeof(System.DateTime);
            this.toDateParameter.ValueInfo = "2016-12-20";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox4});
            this.BottomMargin.HeightF = 75F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPictureBox4
            // 
            this.xrPictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox4.Image")));
            this.xrPictureBox4.LocationFloat = new DevExpress.Utils.PointFloat(249F, 13F);
            this.xrPictureBox4.Name = "xrPictureBox4";
            this.xrPictureBox4.NavigateUrl = "http://www.devexpress.com/Products/NET/Reporting/";
            this.xrPictureBox4.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrPictureBox4.SizeF = new System.Drawing.SizeF(165.625F, 30.20833F);
            this.xrPictureBox4.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize;
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.HeightF = 100F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // dsCust1
            // 
            this.dsCust1.ConnectionName = "HomesConnectionString";
            this.dsCust1.Name = "dsCust1";
            columnExpression1.ColumnName = "ID";
            table1.Name = "Customers";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "Company";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "Occupation";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            column4.Alias = "PersonName";
            customExpression1.Expression = "Concat([Customers].[FirstName], \' \', [Customers].[LastName])";
            column4.Expression = customExpression1;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Name = "Customers";
            selectQuery1.Tables.Add(table1);
            this.dsCust1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.dsCust1.ResultSchemaSerializable = resources.GetString("dsCust1.ResultSchemaSerializable");
            // 
            // subreport1
            // 
            this.subreport1.LocationFloat = new DevExpress.Utils.PointFloat(15F, 60F);
            this.subreport1.Name = "subreport1";
            this.subreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("customerIDParameter", null, "Customers.ID"));
            this.subreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("fromDateParameter", this.fromDateParameter));
            this.subreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("toDateParameter", this.toDateParameter));
            this.subreport1.ReportSource = new XtraReportsDemos.Subreports.DetailReport();
            this.subreport1.SizeF = new System.Drawing.SizeF(628F, 52F);
            // 
            // MasterReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.ReportHeader,
            this.Detail,
            this.BottomMargin,
            this.topMarginBand1});
            this.DataMember = "Customers";
            this.DataSource = this.dsCust1;
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 100, 75);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.fromDateParameter,
            this.toDateParameter});
            this.ReportPrintOptions.DetailCountAtDesignTime = 2;
            this.RequestParameters = false;
            this.Version = "16.1";
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.MasterReport_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        public DetailReport detailReport1;
        private DevExpress.DataAccess.Sql.SqlDataSource dsCust1;
        private DevExpress.XtraReports.Parameters.Parameter fromDateParameter;
        private DevExpress.XtraReports.Parameters.Parameter toDateParameter;
        private System.ComponentModel.IContainer components;
    }
}

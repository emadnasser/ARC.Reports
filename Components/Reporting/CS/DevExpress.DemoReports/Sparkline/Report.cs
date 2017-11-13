using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraReports.UI;

namespace XtraReportsDemos.Sparkline {
    public class Report : XtraReport {
        private TopMarginBand topMarginBand1;
        private DetailBand Detail;
        private BottomMarginBand bottomMarginBand1;
        private GroupHeaderBand GroupHeader;
        private CalculatedField calcSum;
        private CalculatedField calcAverage;
        private GroupFooterBand GroupFooter;
        private XRTable tableDetail;
        private XRTableRow xrTableRow1;
        private XRTableCell xrTableCell1;
        private XRTableCell xrTableCell2;
        private XRTableCell xrTableCell3;
        private XRTableCell xrTableCell4;
        private XRSparkline sparkline;
        private XRTable tableGroupFooter;
        private XRTableRow xrTableRow3;
        private XRTableCell xrTableCell10;
        private XRTableCell xrTableCell11;
        private XRTableCell xrTableCell12;
        private XRTableCell xrTableCell13;
        private PageHeaderBand PageHeader;
        private XRTable tablePageHeader;
        private XRTableRow xrTableRow2;
        private XRTableCell xrTableCell5;
        private XRTableCell xrTableCell6;
        private XRTableCell xrTableCell7;
        private XRTableCell xrTableCell8;
        private XRTableCell xrTableCell9;
        private XRTable tableGroupHeader;
        private XRTableRow xrTableRow4;
        private XRTableCell xrTableCell14;
        private XRTableCell xrTableCell15;
        internal XRPictureBox xrPictureBox1;
        private XRPageInfo xrPageInfo1;
        private XRTableCell xrTableCell16;
        private XRControlStyle oddStyle;
        private DevExpress.DataAccess.Sql.SqlDataSource dsContacts1;
        private System.ComponentModel.IContainer components;
        private XRControlStyle evenStyle;

        public Report() {
            InitializeComponent();
            this.sparkline.BeforePrint += new System.Drawing.Printing.PrintEventHandler(xrSparkline1_BeforePrint);
        }

        void xrSparkline1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            List<double> values = new List<double>();
            string[] months = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            foreach(string month in months)
                values.Add(GetCurrentColumnValue<double>(month));
            sparkline.DataSource = values;
        }

        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.Sparkline.LineSparklineView lineSparklineView1 = new DevExpress.Sparkline.LineSparklineView();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
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
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.sparkline = new DevExpress.XtraReports.UI.XRSparkline();
            this.tableDetail = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.GroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.tableGroupHeader = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.calcSum = new DevExpress.XtraReports.UI.CalculatedField();
            this.calcAverage = new DevExpress.XtraReports.UI.CalculatedField();
            this.GroupFooter = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.tableGroupFooter = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.tablePageHeader = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.oddStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.evenStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.dsContacts1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tableDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableGroupHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableGroupFooter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePageHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.HeightF = 100F;
            this.topMarginBand1.Name = "topMarginBand1";
            this.topMarginBand1.StylePriority.UseFont = false;
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.sparkline,
            this.tableDetail});
            this.Detail.EvenStyleName = "evenStyle";
            this.Detail.HeightF = 43F;
            this.Detail.Name = "Detail";
            this.Detail.OddStyleName = "oddStyle";
            // 
            // sparkline
            // 
            this.sparkline.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
            this.sparkline.LocationFloat = new DevExpress.Utils.PointFloat(435F, 0F);
            this.sparkline.Name = "sparkline";
            this.sparkline.SizeF = new System.Drawing.SizeF(215F, 43F);
            this.sparkline.StylePriority.UseBorders = false;
            lineSparklineView1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(197)))), ((int)(((byte)(195)))));
            lineSparklineView1.HighlightMaxPoint = true;
            lineSparklineView1.HighlightMinPoint = true;
            lineSparklineView1.MaxPointColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(3)))), ((int)(((byte)(94)))));
            lineSparklineView1.MaxPointMarkerSize = 6;
            lineSparklineView1.MinPointColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(116)))), ((int)(((byte)(167)))));
            lineSparklineView1.MinPointMarkerSize = 6;
            this.sparkline.View = lineSparklineView1;
            this.sparkline.XlsxFormatString = null;
            // 
            // tableDetail
            // 
            this.tableDetail.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.tableDetail.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.tableDetail.Name = "tableDetail";
            this.tableDetail.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.tableDetail.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.tableDetail.SizeF = new System.Drawing.SizeF(435F, 43F);
            this.tableDetail.StylePriority.UseBorders = false;
            this.tableDetail.StylePriority.UsePadding = false;
            this.tableDetail.StylePriority.UseTextAlignment = false;
            this.tableDetail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3,
            this.xrTableCell4});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomersPayment.ID")});
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Text = "xrTableCell1";
            this.xrTableCell1.Weight = 0.280021918927671D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomersPayment.Customer Name")});
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell2.Weight = 1.4401123702185D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomersPayment.calcSum", "{0:c}")});
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Weight = 0.880068677022519D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomersPayment.calcAverage", "{0:c}")});
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            this.xrTableCell4.Weight = 0.880068815054061D;
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1,
            this.xrPictureBox1});
            this.bottomMarginBand1.HeightF = 100F;
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Format = "Page : {0 } / {1}";
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(570.75F, 10.00001F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(79.25F, 21.16667F);
            this.xrPageInfo1.StylePriority.UseFont = false;
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox1.Image")));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(249F, 30F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.NavigateUrl = "http://www.devexpress.com/Products/NET/Reporting/";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(165.625F, 30.20833F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize;
            // 
            // GroupHeader
            // 
            this.GroupHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.tableGroupHeader});
            this.GroupHeader.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Year", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader.HeightF = 36F;
            this.GroupHeader.Name = "GroupHeader";
            // 
            // tableGroupHeader
            // 
            this.tableGroupHeader.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.tableGroupHeader.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.tableGroupHeader.Name = "tableGroupHeader";
            this.tableGroupHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100F);
            this.tableGroupHeader.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow4});
            this.tableGroupHeader.SizeF = new System.Drawing.SizeF(650F, 36F);
            this.tableGroupHeader.StylePriority.UseTextAlignment = false;
            this.tableGroupHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell14,
            this.xrTableCell15});
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.Weight = 1D;
            // 
            // xrTableCell14
            // 
            this.xrTableCell14.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomersPayment.Year", "Year: {0}")});
            this.xrTableCell14.Name = "xrTableCell14";
            this.xrTableCell14.StylePriority.UseTextAlignment = false;
            this.xrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell14.Weight = 1.40576914860652D;
            // 
            // xrTableCell15
            // 
            this.xrTableCell15.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomersPayment.Customer Name", "(count==={0})")});
            this.xrTableCell15.Name = "xrTableCell15";
            this.xrTableCell15.StylePriority.UseBorders = false;
            xrSummary1.FormatString = "(count={0})";
            xrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.Count;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrTableCell15.Summary = xrSummary1;
            this.xrTableCell15.Weight = 1.59423085139348D;
            // 
            // calcSum
            // 
            this.calcSum.DataMember = "CustomersPayment";
            this.calcSum.DisplayName = "Sum";
            this.calcSum.Expression = "[April] + [August] + [December] + [February] + [January] + [July] + [June] + [Mar" +
    "ch] + [May] + [November] + [October] + [September]";
            this.calcSum.FieldType = DevExpress.XtraReports.UI.FieldType.Double;
            this.calcSum.Name = "calcSum";
            // 
            // calcAverage
            // 
            this.calcAverage.DataMember = "CustomersPayment";
            this.calcAverage.DisplayName = "Average";
            this.calcAverage.Expression = "[calcSum] / 12.0";
            this.calcAverage.FieldType = DevExpress.XtraReports.UI.FieldType.Double;
            this.calcAverage.Name = "calcAverage";
            // 
            // GroupFooter
            // 
            this.GroupFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.tableGroupFooter});
            this.GroupFooter.HeightF = 30F;
            this.GroupFooter.Name = "GroupFooter";
            // 
            // tableGroupFooter
            // 
            this.tableGroupFooter.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableGroupFooter.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.tableGroupFooter.Name = "tableGroupFooter";
            this.tableGroupFooter.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.tableGroupFooter.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
            this.tableGroupFooter.SizeF = new System.Drawing.SizeF(650F, 30F);
            this.tableGroupFooter.StylePriority.UseBorders = false;
            this.tableGroupFooter.StylePriority.UsePadding = false;
            this.tableGroupFooter.StylePriority.UseTextAlignment = false;
            this.tableGroupFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell10,
            this.xrTableCell16,
            this.xrTableCell11,
            this.xrTableCell12,
            this.xrTableCell13});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 1D;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.Weight = 0.203225842748793D;
            // 
            // xrTableCell16
            // 
            this.xrTableCell16.Name = "xrTableCell16";
            this.xrTableCell16.Weight = 1.04516120486701D;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomersPayment.calcSum")});
            this.xrTableCell11.Name = "xrTableCell11";
            xrSummary2.FormatString = "{0:c}";
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrTableCell11.Summary = xrSummary2;
            this.xrTableCell11.Weight = 0.638709829467386D;
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomersPayment.calcAverage")});
            this.xrTableCell12.Name = "xrTableCell12";
            xrSummary3.FormatString = "{0:c}";
            xrSummary3.Func = DevExpress.XtraReports.UI.SummaryFunc.Avg;
            xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrTableCell12.Summary = xrSummary3;
            this.xrTableCell12.Weight = 0.638709652268553D;
            // 
            // xrTableCell13
            // 
            this.xrTableCell13.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell13.Name = "xrTableCell13";
            this.xrTableCell13.StylePriority.UseBorders = false;
            this.xrTableCell13.Weight = 1.24838687041697D;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.tablePageHeader});
            this.PageHeader.HeightF = 26F;
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.StylePriority.UseFont = false;
            // 
            // tablePageHeader
            // 
            this.tablePageHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.tablePageHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.tablePageHeader.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tablePageHeader.ForeColor = System.Drawing.Color.White;
            this.tablePageHeader.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.tablePageHeader.Name = "tablePageHeader";
            this.tablePageHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 3, 0, 0, 100F);
            this.tablePageHeader.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.tablePageHeader.SizeF = new System.Drawing.SizeF(650F, 26F);
            this.tablePageHeader.StylePriority.UseBackColor = false;
            this.tablePageHeader.StylePriority.UseBorderColor = false;
            this.tablePageHeader.StylePriority.UseBorders = false;
            this.tablePageHeader.StylePriority.UseForeColor = false;
            this.tablePageHeader.StylePriority.UsePadding = false;
            this.tablePageHeader.StylePriority.UseTextAlignment = false;
            this.tablePageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell5,
            this.xrTableCell6,
            this.xrTableCell7,
            this.xrTableCell8,
            this.xrTableCell9});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Text = "ID";
            this.xrTableCell5.Weight = 0.161538455669696D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.StylePriority.UseBackColor = false;
            this.xrTableCell6.Text = "Customer Name";
            this.xrTableCell6.Weight = 0.830769260113056D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.Text = "Sum";
            this.xrTableCell7.Weight = 0.507692295954778D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.Text = "Average";
            this.xrTableCell8.Weight = 0.507692319429838D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.Text = "Payments";
            this.xrTableCell9.Weight = 0.992307668832632D;
            // 
            // oddStyle
            // 
            this.oddStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.oddStyle.Name = "oddStyle";
            this.oddStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            // 
            // evenStyle
            // 
            this.evenStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.evenStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.evenStyle.Name = "evenStyle";
            this.evenStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            // 
            // dsContacts1
            // 
            this.dsContacts1.ConnectionName = "ContactsConnectionString";
            this.dsContacts1.Name = "dsContacts1";
            columnExpression1.ColumnName = "ID";
            table1.Name = "CustomersPayment";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "Customer Name";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "Year";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "January";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "February";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "March";
            columnExpression6.Table = table1;
            column6.Expression = columnExpression6;
            columnExpression7.ColumnName = "April";
            columnExpression7.Table = table1;
            column7.Expression = columnExpression7;
            columnExpression8.ColumnName = "May";
            columnExpression8.Table = table1;
            column8.Expression = columnExpression8;
            columnExpression9.ColumnName = "June";
            columnExpression9.Table = table1;
            column9.Expression = columnExpression9;
            columnExpression10.ColumnName = "July";
            columnExpression10.Table = table1;
            column10.Expression = columnExpression10;
            columnExpression11.ColumnName = "August";
            columnExpression11.Table = table1;
            column11.Expression = columnExpression11;
            columnExpression12.ColumnName = "September";
            columnExpression12.Table = table1;
            column12.Expression = columnExpression12;
            columnExpression13.ColumnName = "October";
            columnExpression13.Table = table1;
            column13.Expression = columnExpression13;
            columnExpression14.ColumnName = "November";
            columnExpression14.Table = table1;
            column14.Expression = columnExpression14;
            columnExpression15.ColumnName = "December";
            columnExpression15.Table = table1;
            column15.Expression = columnExpression15;
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
            selectQuery1.Name = "CustomersPayment";
            selectQuery1.Tables.Add(table1);
            this.dsContacts1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.dsContacts1.ResultSchemaSerializable = resources.GetString("dsContacts1.ResultSchemaSerializable");
            // 
            // Report
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.Detail,
            this.bottomMarginBand1,
            this.GroupHeader,
            this.GroupFooter,
            this.PageHeader});
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.calcSum,
            this.calcAverage});
            this.DataMember = "CustomersPayment";
            this.DataSource = this.dsContacts1;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.oddStyle,
            this.evenStyle});
            this.Version = "16.1";
            ((System.ComponentModel.ISupportInitialize)(this.tableDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableGroupHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableGroupFooter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePageHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
    }
}

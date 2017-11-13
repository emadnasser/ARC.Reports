using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.XtraCharts;
using DevExpress.XtraReports.UI;

namespace XtraReportsDemos.PollingReport {
    public class ResultingReport : XtraReport {
        private TopMarginBand topMarginBand1;
        private DetailBand detailBand1;
        private System.ComponentModel.IContainer components;
        private BottomMarginBand bottomMarginBand1;
        public XRLabel PollingLink;
        private ReportFooterBand ReportFooter;
        private ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.Parameters.Parameter paramPollCount;
        private XRChart xrChart1;
        private XRControlStyle ghStyle1;
        private XRControlStyle ghStyle2;
        private XRControlStyle detStyle1Odd;
        private XRTable xrTable1;
        private XRTableRow xrTableRow5;
        private XRTableCell xrTableCell9;
        private XRTableCell xrTableCell10;
        private XRControlStyle detStyle1Even;
        private XRLine xrLine2;
        private XRLine xrLine1;
        private XRSubreport xrSubreport1;
        private GroupHeaderBand GroupHeader1;
        public DevExpress.DataAccess.ObjectBinding.ObjectDataSource ResultingReportDS;

        public ResultingReport() {
            InitializeComponent();

            ResultingTableReport subreport = xrSubreport1.ReportSource as ResultingTableReport;
            if(subreport != null) {
                subreport.ResultingTableReportDS.DataSource = ResultingReportDS;
                subreport.Colors = GetColorList(xrChart1.PaletteRepository[this.xrChart1.PaletteName]);
            }
        }

        List<Color> GetColorList(Palette palette) {
            List<Color> list = new List<Color>();
            foreach(PaletteEntry item in palette)
                list.Add(item.Color);
            return list;
        }

        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.SimpleDiagram simpleDiagram1 = new DevExpress.XtraCharts.SimpleDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesLabel pieSeriesLabel1 = new DevExpress.XtraCharts.PieSeriesLabel();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrChart1 = new DevExpress.XtraReports.UI.XRChart();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.PollingLink = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.paramPollCount = new DevExpress.XtraReports.Parameters.Parameter();
            this.ghStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.ghStyle2 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.detStyle1Odd = new DevExpress.XtraReports.UI.XRControlStyle();
            this.detStyle1Even = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrSubreport1 = new DevExpress.XtraReports.UI.XRSubreport();
            this.ResultingReportDS = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xrChart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultingReportDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.Dpi = 100F;
            this.topMarginBand1.HeightF = 100F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // detailBand1
            // 
            this.detailBand1.Dpi = 100F;
            this.detailBand1.HeightF = 0F;
            this.detailBand1.Name = "detailBand1";
            this.detailBand1.StylePriority.UseFont = false;
            // 
            // xrChart1
            // 
            this.xrChart1.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.xrChart1.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrChart1.AppearanceNameSerializable = "Light";
            this.xrChart1.BorderColor = System.Drawing.Color.Black;
            this.xrChart1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            simpleDiagram1.EqualPieSize = true;
            simpleDiagram1.LayoutDirection = DevExpress.XtraCharts.LayoutDirection.Vertical;
            this.xrChart1.Diagram = simpleDiagram1;
            this.xrChart1.Dpi = 100F;
            this.xrChart1.Legend.Name = "Default Legend";
            this.xrChart1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.xrChart1.LocationFloat = new DevExpress.Utils.PointFloat(350F, 37.5F);
            this.xrChart1.Name = "xrChart1";
            this.xrChart1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F);
            series1.ArgumentDataMember = "Answer";
            series1.DataFilters.ClearAndAddRange(new DevExpress.XtraCharts.DataFilter[] {
            new DevExpress.XtraCharts.DataFilter("QuestionID", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, null)});
            pieSeriesLabel1.TextPattern = "{A}";
            series1.Label = pieSeriesLabel1;
            series1.Name = "Series 1";
            series1.ValueDataMembersSerializable = "AnswerCount";
            pieSeriesView1.MinAllowedSizePercentage = 75D;
            series1.View = pieSeriesView1;
            this.xrChart1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.xrChart1.SizeF = new System.Drawing.SizeF(300F, 187.5F);
            this.xrChart1.StylePriority.UsePadding = false;
            this.xrChart1.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrChart1_BeforePrint);
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.Dpi = 100F;
            this.bottomMarginBand1.HeightF = 100F;
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // PollingLink
            // 
            this.PollingLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(114)))), ((int)(((byte)(45)))));
            this.PollingLink.Dpi = 100F;
            this.PollingLink.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PollingLink.ForeColor = System.Drawing.Color.White;
            this.PollingLink.LocationFloat = new DevExpress.Utils.PointFloat(25F, 25F);
            this.PollingLink.Name = "PollingLink";
            this.PollingLink.NavigateUrl = "empty";
            this.PollingLink.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.PollingLink.SizeF = new System.Drawing.SizeF(150F, 32.5F);
            this.PollingLink.StylePriority.UseBackColor = false;
            this.PollingLink.StylePriority.UseFont = false;
            this.PollingLink.StylePriority.UseForeColor = false;
            this.PollingLink.StylePriority.UseTextAlignment = false;
            this.PollingLink.Text = "Start a new poll";
            this.PollingLink.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLine1
            // 
            this.xrLine1.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.xrLine1.Dpi = 100F;
            this.xrLine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(650F, 12.49997F);
            this.xrLine1.StylePriority.UseForeColor = false;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.PollingLink});
            this.ReportFooter.Dpi = 100F;
            this.ReportFooter.HeightF = 57.5F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine2,
            this.xrTable1});
            this.ReportHeader.Dpi = 100F;
            this.ReportHeader.HeightF = 62.49999F;
            this.ReportHeader.Name = "ReportHeader";
            this.ReportHeader.StylePriority.UseFont = false;
            // 
            // xrLine2
            // 
            this.xrLine2.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.xrLine2.Dpi = 100F;
            this.xrLine2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.xrLine2.LineWidth = 2;
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(650F, 2.083333F);
            this.xrLine2.StylePriority.UseForeColor = false;
            // 
            // xrTable1
            // 
            this.xrTable1.Dpi = 100F;
            this.xrTable1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTable1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(25F, 25F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow5});
            this.xrTable1.SizeF = new System.Drawing.SizeF(600F, 33F);
            this.xrTable1.StylePriority.UseFont = false;
            this.xrTable1.StylePriority.UseForeColor = false;
            this.xrTable1.StylePriority.UseTextAlignment = false;
            // 
            // xrTableRow5
            // 
            this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell9,
            this.xrTableCell10});
            this.xrTableRow5.Dpi = 100F;
            this.xrTableRow5.Name = "xrTableRow5";
            this.xrTableRow5.Weight = 0.65999999999999992D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.Dpi = 100F;
            this.xrTableCell9.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(114)))), ((int)(((byte)(45)))));
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.StylePriority.UseFont = false;
            this.xrTableCell9.StylePriority.UseForeColor = false;
            this.xrTableCell9.StylePriority.UseTextAlignment = false;
            this.xrTableCell9.Text = "Polling results";
            this.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell9.Weight = 1.4950000859781933D;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.Dpi = 100F;
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.StylePriority.UseTextAlignment = false;
            this.xrTableCell10.Text = "Number of people polled : [Parameters.paramPollCount]";
            this.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell10.Weight = 1.26500004317221D;
            this.xrTableCell10.WordWrap = false;
            // 
            // paramPollCount
            // 
            this.paramPollCount.Description = "Poll Count";
            this.paramPollCount.Name = "paramPollCount";
            this.paramPollCount.Type = typeof(int);
            this.paramPollCount.ValueInfo = "0";
            this.paramPollCount.Visible = false;
            // 
            // ghStyle1
            // 
            this.ghStyle1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.ghStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.ghStyle1.Name = "ghStyle1";
            this.ghStyle1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.ghStyle1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // ghStyle2
            // 
            this.ghStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ghStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ghStyle2.ForeColor = System.Drawing.Color.White;
            this.ghStyle2.Name = "ghStyle2";
            this.ghStyle2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // detStyle1Odd
            // 
            this.detStyle1Odd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detStyle1Odd.Name = "detStyle1Odd";
            // 
            // detStyle1Even
            // 
            this.detStyle1Even.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.detStyle1Even.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detStyle1Even.Name = "detStyle1Even";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine1,
            this.xrSubreport1,
            this.xrChart1});
            this.GroupHeader1.Dpi = 100F;
            this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("QuestionID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader1.HeightF = 225F;
            this.GroupHeader1.KeepTogether = true;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // xrSubreport1
            // 
            this.xrSubreport1.Dpi = 100F;
            this.xrSubreport1.LocationFloat = new DevExpress.Utils.PointFloat(25.00003F, 37.5F);
            this.xrSubreport1.Name = "xrSubreport1";
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("paramQuestionID", null, "QuestionID"));
            this.xrSubreport1.ReportSource = new XtraReportsDemos.PollingReport.ResultingTableReport();
            this.xrSubreport1.SizeF = new System.Drawing.SizeF(325F, 187.5F);
            // 
            // ResultingReportDS
            // 
            this.ResultingReportDS.DataSource = typeof(XtraReportsDemos.PollingReport.ResultingData);
            this.ResultingReportDS.Name = "ResultingReportDS";
            // 
            // ResultingReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.detailBand1,
            this.bottomMarginBand1,
            this.ReportFooter,
            this.ReportHeader,
            this.GroupHeader1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.ResultingReportDS});
            this.DataSource = this.ResultingReportDS;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.paramPollCount});
            this.SnappingMode = ((DevExpress.XtraReports.UI.SnappingMode)((DevExpress.XtraReports.UI.SnappingMode.SnapLines | DevExpress.XtraReports.UI.SnappingMode.SnapToGrid)));
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.ghStyle1,
            this.ghStyle2,
            this.detStyle1Odd,
            this.detStyle1Even});
            this.Version = "16.2";
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrChart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultingReportDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        private void xrChart1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            this.xrChart1.Series[0].DataFilters[0].Value = GetCurrentColumnValue("QuestionID");
        }
    }
}

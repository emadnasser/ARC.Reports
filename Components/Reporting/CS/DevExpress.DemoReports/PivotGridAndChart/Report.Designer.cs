using System;
using System.Collections.Generic;
using System.Text;

namespace XtraReportsDemos.PivotGridAndChart {
    public partial class Report : DevExpress.XtraReports.UI.XtraReport {
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRPageInfo xpiPageCount;
        private DevExpress.XtraReports.UI.XRControlStyle OddStyle;
        private DevExpress.XtraReports.UI.XRControlStyle GroupHeader;
        private DevExpress.XtraReports.UI.XRControlStyle EvenStyle;
        private DevExpress.XtraReports.UI.XRControlStyle CategoryStyle;
        private System.ComponentModel.IContainer components = null;
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

        #region Component Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.StackedSplineAreaSeriesView stackedSplineAreaSeriesView1 = new DevExpress.XtraCharts.StackedSplineAreaSeriesView();
            DevExpress.DataAccess.EntityFramework.EFConnectionParameters efConnectionParameters1 = new DevExpress.DataAccess.EntityFramework.EFConnectionParameters();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.OddStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupHeader = new DevExpress.XtraReports.UI.XRControlStyle();
            this.EvenStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrChart = new DevExpress.XtraReports.UI.XRChart();
            this.xrPivotGrid = new DevExpress.XtraReports.UI.XRPivotGrid();
            this.efDataSource1 = new DevExpress.DataAccess.EntityFramework.EFDataSource();
            this.pgfSalesPerson = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.pgfSalesTotal = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.pgfYear = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.pgfQuarter = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xpbDevExpress = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xpiPageCount = new DevExpress.XtraReports.UI.XRPageInfo();
            this.CategoryStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrlTitle = new DevExpress.XtraReports.UI.XRLabel();
            this.parameterShowLabels = new DevExpress.XtraReports.Parameters.Parameter();
            this.parameterGenerateSeriesFromColumns = new DevExpress.XtraReports.Parameters.Parameter();
            this.parameterShowRowGrandTotals = new DevExpress.XtraReports.Parameters.Parameter();
            this.parameterShowColumnGrandTotals = new DevExpress.XtraReports.Parameters.Parameter();
            this.parameterViewType = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this.xrChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedSplineAreaSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.efDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // OddStyle
            // 
            this.OddStyle.BackColor = System.Drawing.Color.Transparent;
            this.OddStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(205)))), ((int)(((byte)(162)))));
            this.OddStyle.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)));
            this.OddStyle.BorderWidth = 1F;
            this.OddStyle.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.OddStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OddStyle.Name = "OddStyle";
            // 
            // GroupHeader
            // 
            this.GroupHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.GroupHeader.BorderColor = System.Drawing.Color.White;
            this.GroupHeader.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.GroupHeader.BorderWidth = 1F;
            this.GroupHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.GroupHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.GroupHeader.Name = "GroupHeader";
            // 
            // EvenStyle
            // 
            this.EvenStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(196)))));
            this.EvenStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(205)))), ((int)(((byte)(162)))));
            this.EvenStyle.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)));
            this.EvenStyle.BorderWidth = 1F;
            this.EvenStyle.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.EvenStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EvenStyle.Name = "EvenStyle";
            // 
            // Detail
            // 
            this.Detail.BackColor = System.Drawing.Color.Transparent;
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrChart,
            this.xrPivotGrid});
            this.Detail.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.Detail.HeightF = 592F;
            this.Detail.KeepTogether = true;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrChart
            // 
            this.xrChart.BorderColor = System.Drawing.SystemColors.ControlText;
            this.xrChart.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrChart.DataSource = this.xrPivotGrid;
            xyDiagram1.AxisLabelsResolveOverlappingMinIndent = 0;
            xyDiagram1.AxisX.Label.Staggered = true;
            xyDiagram1.AxisX.Title.Text = "Year Quarter";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = false;
            xyDiagram1.AxisX.WholeRange.SideMarginsValue = 0D;
            xyDiagram1.AxisY.Title.Text = "Sales Total";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.xrChart.Diagram = xyDiagram1;
            this.xrChart.Legend.MaxHorizontalPercentage = 30D;
            this.xrChart.LocationFloat = new DevExpress.Utils.PointFloat(7.947286E-05F, 217F);
            this.xrChart.Name = "xrChart";
            this.xrChart.SeriesDataMember = "Series";
            this.xrChart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.xrChart.SeriesTemplate.ArgumentDataMember = "Arguments";
            this.xrChart.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            this.xrChart.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            this.xrChart.SeriesTemplate.ValueDataMembersSerializable = "Values";
            stackedSplineAreaSeriesView1.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Gradient;
            stackedSplineAreaSeriesView1.Transparency = ((byte)(100));
            this.xrChart.SeriesTemplate.View = stackedSplineAreaSeriesView1;
            this.xrChart.SizeF = new System.Drawing.SizeF(919.9999F, 295F);
            // 
            // xrPivotGrid
            // 
            this.xrPivotGrid.DataMember = "SalesPersons";
            this.xrPivotGrid.DataSource = this.efDataSource1;
            this.xrPivotGrid.Fields.AddRange(new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField[] {
            this.pgfSalesPerson,
            this.pgfSalesTotal,
            this.pgfYear,
            this.pgfQuarter});
            this.xrPivotGrid.HeaderGroupLineStyleName = "GroupHeader";
            this.xrPivotGrid.LocationFloat = new DevExpress.Utils.PointFloat(1F, 0F);
            this.xrPivotGrid.Name = "xrPivotGrid";
            this.xrPivotGrid.OptionsChartDataSource.DataProvideMode = DevExpress.XtraPivotGrid.PivotChartDataProvideMode.UseCustomSettings;
            this.xrPivotGrid.OptionsChartDataSource.FieldValuesProvideMode = DevExpress.XtraPivotGrid.PivotChartFieldValuesProvideMode.Value;
            this.xrPivotGrid.OptionsChartDataSource.ProvideDataByColumns = false;
            this.xrPivotGrid.OptionsPrint.FilterSeparatorBarPadding = 3;
            this.xrPivotGrid.OptionsView.ShowColumnTotals = false;
            this.xrPivotGrid.OptionsView.ShowRowTotals = false;
            this.xrPivotGrid.SizeF = new System.Drawing.SizeF(920F, 215.625F);
            // 
            // efDataSource1
            // 
            efConnectionParameters1.ConnectionStringName = "NWindEntities_ConnectionString";
            efConnectionParameters1.Source = typeof(DevExpress.DemoData.Models.NWindEntities);
            this.efDataSource1.ConnectionParameters = efConnectionParameters1;
            this.efDataSource1.Name = "efDataSource1";
            // 
            // pgfSalesPerson
            // 
            this.pgfSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pgfSalesPerson.AreaIndex = 0;
            this.pgfSalesPerson.Caption = "Sales Person";
            this.pgfSalesPerson.FieldName = "FullName";
            this.pgfSalesPerson.Name = "pgfSalesPerson";
            // 
            // pgfSalesTotal
            // 
            this.pgfSalesTotal.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pgfSalesTotal.AreaIndex = 0;
            this.pgfSalesTotal.Caption = "Sales Total";
            this.pgfSalesTotal.FieldName = "ExtendedPrice";
            this.pgfSalesTotal.Name = "pgfSalesTotal";
            // 
            // pgfYear
            // 
            this.pgfYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pgfYear.AreaIndex = 0;
            this.pgfYear.Caption = "Year";
            this.pgfYear.FieldName = "OrderDate";
            this.pgfYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.pgfYear.Name = "pgfYear";
            this.pgfYear.UnboundFieldName = "pgfYear";
            // 
            // pgfQuarter
            // 
            this.pgfQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pgfQuarter.AreaIndex = 1;
            this.pgfQuarter.Caption = "Quarter";
            this.pgfQuarter.FieldName = "OrderDate";
            this.pgfQuarter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter;
            this.pgfQuarter.Name = "pgfQuarter";
            this.pgfQuarter.UnboundFieldName = "pgfQuarter";
            this.pgfQuarter.Width = 87;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xpbDevExpress,
            this.xpiPageCount});
            this.BottomMargin.HeightF = 87F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xpbDevExpress
            // 
            this.xpbDevExpress.Image = ((System.Drawing.Image)(resources.GetObject("xpbDevExpress.Image")));
            this.xpbDevExpress.LocationFloat = new DevExpress.Utils.PointFloat(382F, 22F);
            this.xpbDevExpress.Name = "xpbDevExpress";
            this.xpbDevExpress.NavigateUrl = "http://www.devexpress.com/Products/NET/Reporting/";
            this.xpbDevExpress.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xpbDevExpress.SizeF = new System.Drawing.SizeF(165.625F, 30.20833F);
            this.xpbDevExpress.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize;
            // 
            // xpiPageCount
            // 
            this.xpiPageCount.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic);
            this.xpiPageCount.Format = "Page : {0 } / {1}";
            this.xpiPageCount.LocationFloat = new DevExpress.Utils.PointFloat(817F, 0F);
            this.xpiPageCount.Name = "xpiPageCount";
            this.xpiPageCount.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xpiPageCount.SizeF = new System.Drawing.SizeF(98F, 17F);
            this.xpiPageCount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // CategoryStyle
            // 
            this.CategoryStyle.BackColor = System.Drawing.Color.Transparent;
            this.CategoryStyle.BorderColor = System.Drawing.SystemColors.ControlText;
            this.CategoryStyle.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.CategoryStyle.BorderWidth = 1F;
            this.CategoryStyle.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.CategoryStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.CategoryStyle.Name = "CategoryStyle";
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.HeightF = 119F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrlTitle});
            this.ReportHeader.HeightF = 48.95833F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrlTitle
            // 
            this.xrlTitle.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Underline);
            this.xrlTitle.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrlTitle.Name = "xrlTitle";
            this.xrlTitle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlTitle.SizeF = new System.Drawing.SizeF(920F, 48.95833F);
            this.xrlTitle.StylePriority.UseFont = false;
            this.xrlTitle.StylePriority.UseTextAlignment = false;
            this.xrlTitle.Text = "Sales by Person";
            this.xrlTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // parameterShowLabels
            // 
            this.parameterShowLabels.Description = "Show Labels";
            this.parameterShowLabels.Name = "parameterShowLabels";
            this.parameterShowLabels.Type = typeof(bool);
            this.parameterShowLabels.ValueInfo = "False";
            // 
            // parameterGenerateSeriesFromColumns
            // 
            this.parameterGenerateSeriesFromColumns.Description = "Generate Series from Columns";
            this.parameterGenerateSeriesFromColumns.Name = "parameterGenerateSeriesFromColumns";
            this.parameterGenerateSeriesFromColumns.Type = typeof(bool);
            this.parameterGenerateSeriesFromColumns.ValueInfo = "False";
            // 
            // parameterShowRowGrandTotals
            // 
            this.parameterShowRowGrandTotals.Description = "Show Row Grand Totals";
            this.parameterShowRowGrandTotals.Name = "parameterShowRowGrandTotals";
            this.parameterShowRowGrandTotals.Type = typeof(bool);
            this.parameterShowRowGrandTotals.ValueInfo = "False";
            // 
            // parameterShowColumnGrandTotals
            // 
            this.parameterShowColumnGrandTotals.Description = "Show Column Grand Totals";
            this.parameterShowColumnGrandTotals.Name = "parameterShowColumnGrandTotals";
            this.parameterShowColumnGrandTotals.Type = typeof(bool);
            this.parameterShowColumnGrandTotals.ValueInfo = "False";
            // 
            // parameterViewType
            // 
            this.parameterViewType.Description = "View Type";
            this.parameterViewType.Name = "parameterViewType";
            // 
            // Report
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.BottomMargin,
            this.topMarginBand1,
            this.ReportHeader});
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(100, 78, 119, 87);
            this.PageHeight = 850;
            this.PageWidth = 1100;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.parameterViewType,
            this.parameterShowLabels,
            this.parameterGenerateSeriesFromColumns,
            this.parameterShowRowGrandTotals,
            this.parameterShowColumnGrandTotals});
            this.RequestParameters = false;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.OddStyle,
            this.GroupHeader,
            this.EvenStyle,
            this.CategoryStyle});
            this.Version = "14.2";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedSplineAreaSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.efDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        internal DevExpress.XtraReports.UI.XRPictureBox xpbDevExpress;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.XRChart xrChart;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField pgfSalesPerson;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField pgfSalesTotal;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField pgfYear;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField pgfQuarter;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel xrlTitle;
        private DevExpress.XtraReports.Parameters.Parameter parameterShowLabels;
        private DevExpress.XtraReports.Parameters.Parameter parameterGenerateSeriesFromColumns;
        private DevExpress.XtraReports.Parameters.Parameter parameterShowRowGrandTotals;
        private DevExpress.XtraReports.Parameters.Parameter parameterShowColumnGrandTotals;
        private DevExpress.XtraReports.Parameters.Parameter parameterViewType;
        public DevExpress.XtraReports.UI.XRPivotGrid xrPivotGrid;
        private DevExpress.DataAccess.EntityFramework.EFDataSource efDataSource1;
    }
}

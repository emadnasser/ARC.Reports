using DashboardMainDemo;
using DevExpress.DashboardCommon;

/// <summary>
/// Summary description
/// </summary>
public class SalesPerformanceDashboard : Dashboard {
    private DashboardObjectDataSource dsTotalSales;
    private GridDashboardItem gridProductSales;
    private CardDashboardItem cardKeyMetrics;
    private DashboardObjectDataSource dsKeyMetrics;
    private ChartDashboardItem chartProductMonthlySales;
    private DashboardObjectDataSource dsMonthlySales;
    private ChoroplethMapDashboardItem choroplethMapDashboardItem1;
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public SalesPerformanceDashboard() {
        InitializeComponent();
    }

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

    #region Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            System.Resources.ResourceManager resources = global::Resources.SalesPerformanceDashboard.ResourceManager;
            DevExpress.DashboardCommon.Dimension dimension1 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure1 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure2 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure3 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure4 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure5 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure6 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.ValueMap valueMap1 = new DevExpress.DashboardCommon.ValueMap();
            DevExpress.DashboardCommon.CustomScale customScale1 = new DevExpress.DashboardCommon.CustomScale();
            DevExpress.DashboardCommon.DeltaMap deltaMap1 = new DevExpress.DashboardCommon.DeltaMap();
            DevExpress.DashboardCommon.ValueMap valueMap2 = new DevExpress.DashboardCommon.ValueMap();
            DevExpress.DashboardCommon.CustomScale customScale2 = new DevExpress.DashboardCommon.CustomScale();
            DevExpress.DashboardCommon.DeltaMap deltaMap2 = new DevExpress.DashboardCommon.DeltaMap();
            DevExpress.DashboardCommon.Dimension dimension2 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.GridDimensionColumn gridDimensionColumn1 = new DevExpress.DashboardCommon.GridDimensionColumn();
            DevExpress.DashboardCommon.Measure measure7 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.GridMeasureColumn gridMeasureColumn1 = new DevExpress.DashboardCommon.GridMeasureColumn();
            DevExpress.DashboardCommon.GridColumnTotal gridColumnTotal1 = new DevExpress.DashboardCommon.GridColumnTotal();
            DevExpress.DashboardCommon.Measure measure8 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure9 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.GridDeltaColumn gridDeltaColumn1 = new DevExpress.DashboardCommon.GridDeltaColumn();
            DevExpress.DashboardCommon.GridItemFormatRule gridItemFormatRule1 = new DevExpress.DashboardCommon.GridItemFormatRule();
            DevExpress.DashboardCommon.FormatConditionTopBottom formatConditionTopBottom1 = new DevExpress.DashboardCommon.FormatConditionTopBottom();
            DevExpress.DashboardCommon.IconSettings iconSettings1 = new DevExpress.DashboardCommon.IconSettings();
            DevExpress.DashboardCommon.GridItemFormatRule gridItemFormatRule2 = new DevExpress.DashboardCommon.GridItemFormatRule();
            DevExpress.DashboardCommon.FormatConditionTopBottom formatConditionTopBottom2 = new DevExpress.DashboardCommon.FormatConditionTopBottom();
            DevExpress.DashboardCommon.IconSettings iconSettings2 = new DevExpress.DashboardCommon.IconSettings();
            DevExpress.DashboardCommon.GridItemFormatRule gridItemFormatRule3 = new DevExpress.DashboardCommon.GridItemFormatRule();
            DevExpress.DashboardCommon.FormatConditionAverage formatConditionAverage1 = new DevExpress.DashboardCommon.FormatConditionAverage();
            DevExpress.DashboardCommon.AppearanceSettings appearanceSettings1 = new DevExpress.DashboardCommon.AppearanceSettings();
            DevExpress.DashboardCommon.GridItemFormatRule gridItemFormatRule4 = new DevExpress.DashboardCommon.GridItemFormatRule();
            DevExpress.DashboardCommon.FormatConditionAverage formatConditionAverage2 = new DevExpress.DashboardCommon.FormatConditionAverage();
            DevExpress.DashboardCommon.AppearanceSettings appearanceSettings2 = new DevExpress.DashboardCommon.AppearanceSettings();
            DevExpress.DashboardCommon.Measure measure10 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure11 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Card card1 = new DevExpress.DashboardCommon.Card();
            DevExpress.DashboardCommon.Measure measure12 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure13 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Card card2 = new DevExpress.DashboardCommon.Card();
            DevExpress.DashboardCommon.Measure measure14 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure15 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Card card3 = new DevExpress.DashboardCommon.Card();
            DevExpress.DashboardCommon.Measure measure16 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure17 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Card card4 = new DevExpress.DashboardCommon.Card();
            DevExpress.DashboardCommon.Measure measure18 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure19 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Card card5 = new DevExpress.DashboardCommon.Card();
            DevExpress.DashboardCommon.Measure measure20 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Card card6 = new DevExpress.DashboardCommon.Card();
            DevExpress.DashboardCommon.Dimension dimension3 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure21 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Dimension dimension4 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.ChartPane chartPane1 = new DevExpress.DashboardCommon.ChartPane();
            DevExpress.DashboardCommon.SimpleSeries simpleSeries1 = new DevExpress.DashboardCommon.SimpleSeries();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup2 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem2 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup3 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem3 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem4 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            this.choroplethMapDashboardItem1 = new DevExpress.DashboardCommon.ChoroplethMapDashboardItem();
            this.dsTotalSales = new DevExpress.DashboardCommon.DashboardObjectDataSource();
            this.gridProductSales = new DevExpress.DashboardCommon.GridDashboardItem();
            this.cardKeyMetrics = new DevExpress.DashboardCommon.CardDashboardItem();
            this.dsKeyMetrics = new DevExpress.DashboardCommon.DashboardObjectDataSource();
            this.chartProductMonthlySales = new DevExpress.DashboardCommon.ChartDashboardItem();
            this.dsMonthlySales = new DevExpress.DashboardCommon.DashboardObjectDataSource();
            ((System.ComponentModel.ISupportInitialize)(this.choroplethMapDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTotalSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardKeyMetrics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKeyMetrics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProductMonthlySales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMonthlySales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // choroplethMapDashboardItem1
            // 
            this.choroplethMapDashboardItem1.Area = DevExpress.DashboardCommon.ShapefileArea.USA;
            dimension1.DataMember = "State";
            this.choroplethMapDashboardItem1.AttributeDimension = dimension1;
            this.choroplethMapDashboardItem1.AttributeName = "NAME";
            this.choroplethMapDashboardItem1.ComponentName = "choroplethMapDashboardItem1";
            measure1.DataMember = "RevenueYTD";
            measure2.DataMember = "RevenueYTD";
            measure3.DataMember = "RevenueYTDTarget";
            measure4.DataMember = "RevenueQTD";
            measure5.DataMember = "RevenueQTD";
            measure6.DataMember = "RevenueQTDTarget";
            this.choroplethMapDashboardItem1.DataItemRepository.Clear();
            this.choroplethMapDashboardItem1.DataItemRepository.Add(dimension1, "DataItem0");
            this.choroplethMapDashboardItem1.DataItemRepository.Add(measure1, "DataItem2");
            this.choroplethMapDashboardItem1.DataItemRepository.Add(measure2, "DataItem1");
            this.choroplethMapDashboardItem1.DataItemRepository.Add(measure3, "DataItem3");
            this.choroplethMapDashboardItem1.DataItemRepository.Add(measure4, "DataItem4");
            this.choroplethMapDashboardItem1.DataItemRepository.Add(measure5, "DataItem5");
            this.choroplethMapDashboardItem1.DataItemRepository.Add(measure6, "DataItem6");
            this.choroplethMapDashboardItem1.DataSource = this.dsTotalSales;
            this.choroplethMapDashboardItem1.IncludeSummaryValueToShapeTitle = true;
            this.choroplethMapDashboardItem1.InteractivityOptions.IgnoreMasterFilters = false;
            this.choroplethMapDashboardItem1.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Multiple;
            this.choroplethMapDashboardItem1.IsMasterFilterCrossDataSource = true;
            this.choroplethMapDashboardItem1.LockNavigation = true;
            valueMap1.Name = "Revenue YTD";
            customScale1.RangeStops.Add(1D);
            customScale1.RangeStops.Add(2D);
            customScale1.RangeStops.Add(4D);
            customScale1.RangeStops.Add(6D);
            customScale1.RangeStops.Add(10D);
            customScale1.RangeStops.Add(14D);
            customScale1.RangeStops.Add(18D);
            customScale1.RangeStops.Add(22D);
            customScale1.RangeStops.Add(26D);
            customScale1.RangeStops.Add(30D);
            customScale1.RangeStops.Add(40D);
            customScale1.RangeStops.Add(50D);
            customScale1.RangeStops.Add(70D);
            customScale1.RangeStops.Add(90D);
            valueMap1.Scale = customScale1;
            valueMap1.ValueName = "Revenue";
            valueMap1.AddDataItem("Value", measure2);
            deltaMap1.ActualValueName = "Revenue";
            deltaMap1.DeltaName = "vs Target";
            deltaMap1.Name = "Revenue YTD vs Target";
            deltaMap1.AddDataItem("ActualValue", measure1);
            deltaMap1.AddDataItem("TargetValue", measure3);
            valueMap2.Name = "Revenue QTD";
            customScale2.RangeStops.Add(1D);
            customScale2.RangeStops.Add(2D);
            customScale2.RangeStops.Add(4D);
            customScale2.RangeStops.Add(6D);
            customScale2.RangeStops.Add(10D);
            customScale2.RangeStops.Add(14D);
            customScale2.RangeStops.Add(18D);
            customScale2.RangeStops.Add(22D);
            customScale2.RangeStops.Add(26D);
            customScale2.RangeStops.Add(30D);
            customScale2.RangeStops.Add(40D);
            customScale2.RangeStops.Add(50D);
            customScale2.RangeStops.Add(70D);
            customScale2.RangeStops.Add(90D);
            valueMap2.Scale = customScale2;
            valueMap2.ValueName = "Revenue";
            valueMap2.AddDataItem("Value", measure4);
            deltaMap2.ActualValueName = "Revenue";
            deltaMap2.DeltaName = "vs Target";
            deltaMap2.Name = "Revenue QTD vs Target";
            deltaMap2.AddDataItem("ActualValue", measure5);
            deltaMap2.AddDataItem("TargetValue", measure6);
            this.choroplethMapDashboardItem1.Maps.AddRange(new DevExpress.DashboardCommon.ChoroplethMap[] {
            valueMap1,
            deltaMap1,
            valueMap2,
            deltaMap2});
            this.choroplethMapDashboardItem1.Name = "Sales by State";
            this.choroplethMapDashboardItem1.ShowCaption = true;
            this.choroplethMapDashboardItem1.Viewport.BottomLatitude = 22.722765208057595D;
            this.choroplethMapDashboardItem1.Viewport.CenterPointLatitude = 37.20824763267364D;
            this.choroplethMapDashboardItem1.Viewport.CenterPointLongitude = -95.848499902568008D;
            this.choroplethMapDashboardItem1.Viewport.LeftLongitude = -124.70997774915153D;
            this.choroplethMapDashboardItem1.Viewport.RightLongitude = -66.987022055984482D;
            this.choroplethMapDashboardItem1.Viewport.TopLatitude = 49.369672064487254D;
            // 
            // dsTotalSales
            // 
            this.dsTotalSales.ComponentName = "dsTotalSales";
            this.dsTotalSales.DataMember = "TotalSalesItem";
            this.dsTotalSales.DataSchema = resources.GetString("dsTotalSales.DataSchema");
            this.dsTotalSales.Name = "Total Sales";
            // 
            // gridProductSales
            // 
            dimension2.DataMember = "Product";
            gridDimensionColumn1.Name = "Product";
            gridDimensionColumn1.Weight = 47.492163009404386D;
            gridDimensionColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight;
            gridDimensionColumn1.AddDataItem("Dimension", dimension2);
            measure7.DataMember = "RevenueYTD";
            gridMeasureColumn1.Name = "Revenue YTD";
            gridColumnTotal1.TotalType = DevExpress.DashboardCommon.GridColumnTotalType.Sum;
            gridMeasureColumn1.Totals.AddRange(new DevExpress.DashboardCommon.GridColumnTotal[] {
            gridColumnTotal1});
            gridMeasureColumn1.Weight = 70.532915360501562D;
            gridMeasureColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight;
            gridMeasureColumn1.AddDataItem("Measure", measure7);
            measure8.DataMember = "RevenueYTD";
            measure9.DataMember = "RevenueYTDTarget";
            gridDeltaColumn1.DeltaOptions.ResultIndicationThreshold = new decimal(new int[] {
            1,
            0,
            0,
            0});
            gridDeltaColumn1.DeltaOptions.ValueType = DevExpress.DashboardCommon.DeltaValueType.PercentVariation;
            gridDeltaColumn1.Name = "Revenue YTD vs Target";
            gridDeltaColumn1.Weight = 111.44200626959248D;
            gridDeltaColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight;
            gridDeltaColumn1.AddDataItem("ActualValue", measure8);
            gridDeltaColumn1.AddDataItem("TargetValue", measure9);
            this.gridProductSales.Columns.AddRange(new DevExpress.DashboardCommon.GridColumnBase[] {
            gridDimensionColumn1,
            gridMeasureColumn1,
            gridDeltaColumn1});
            this.gridProductSales.ComponentName = "gridProductSales";
            this.gridProductSales.DataItemRepository.Clear();
            this.gridProductSales.DataItemRepository.Add(dimension2, "DataItem1");
            this.gridProductSales.DataItemRepository.Add(measure9, "DataItem5");
            this.gridProductSales.DataItemRepository.Add(measure7, "DataItem3");
            this.gridProductSales.DataItemRepository.Add(measure8, "DataItem4");
            this.gridProductSales.DataSource = this.dsTotalSales;
            iconSettings1.IconType = DevExpress.DashboardCommon.FormatConditionIconType.ShapeGreenCircle;
            formatConditionTopBottom1.StyleSettings = iconSettings1;
            gridItemFormatRule1.Condition = formatConditionTopBottom1;
            gridItemFormatRule1.DataItem = measure7;
            gridItemFormatRule1.DataItemApplyTo = dimension2;
            gridItemFormatRule1.Name = "FormatRule 1";
            iconSettings2.IconType = DevExpress.DashboardCommon.FormatConditionIconType.ShapeRedCircle;
            formatConditionTopBottom2.StyleSettings = iconSettings2;
            formatConditionTopBottom2.TopBottom = DevExpress.DashboardCommon.DashboardFormatConditionTopBottomType.Bottom;
            gridItemFormatRule2.Condition = formatConditionTopBottom2;
            gridItemFormatRule2.DataItem = measure7;
            gridItemFormatRule2.DataItemApplyTo = dimension2;
            gridItemFormatRule2.Name = "FormatRule 2";
            formatConditionAverage1.AverageType = DevExpress.DashboardCommon.DashboardFormatConditionAboveBelowType.AboveOrEqual;
            appearanceSettings1.AppearanceType = DevExpress.DashboardCommon.FormatConditionAppearanceType.FontGreen;
            formatConditionAverage1.StyleSettings = appearanceSettings1;
            gridItemFormatRule3.Condition = formatConditionAverage1;
            gridItemFormatRule3.DataItem = measure7;
            gridItemFormatRule3.Name = "FormatRule 3";
            formatConditionAverage2.AverageType = DevExpress.DashboardCommon.DashboardFormatConditionAboveBelowType.Below;
            appearanceSettings2.AppearanceType = DevExpress.DashboardCommon.FormatConditionAppearanceType.FontRed;
            formatConditionAverage2.StyleSettings = appearanceSettings2;
            gridItemFormatRule4.Condition = formatConditionAverage2;
            gridItemFormatRule4.DataItem = measure7;
            gridItemFormatRule4.Name = "FormatRule 4";
            this.gridProductSales.FormatRules.AddRange(new DevExpress.DashboardCommon.GridItemFormatRule[] {
            gridItemFormatRule1,
            gridItemFormatRule2,
            gridItemFormatRule3,
            gridItemFormatRule4});
            this.gridProductSales.GridOptions.AllowCellMerge = true;
            this.gridProductSales.GridOptions.ShowHorizontalLines = false;
            this.gridProductSales.InteractivityOptions.IgnoreMasterFilters = false;
            this.gridProductSales.Name = "Product Sales YTD";
            this.gridProductSales.ShowCaption = true;
            // 
            // cardKeyMetrics
            // 
            measure10.DataMember = "RevenueYTD";
            measure11.DataMember = "RevenueYTDTarget";
            card1.Name = "Revenue YTD";
            card1.AddDataItem("ActualValue", measure10);
            card1.AddDataItem("TargetValue", measure11);
            measure12.DataMember = "ExpencesYTD";
            measure13.DataMember = "ExpencesYTDTarget";
            card2.DeltaOptions.ResultIndicationMode = DevExpress.DashboardCommon.DeltaIndicationMode.LessIsGood;
            card2.Name = "Expenses YTD";
            card2.AddDataItem("ActualValue", measure12);
            card2.AddDataItem("TargetValue", measure13);
            measure14.DataMember = "ProfitYTD";
            measure15.DataMember = "ProfitYTDTarget";
            card3.Name = "Profit YTD";
            card3.AddDataItem("ActualValue", measure14);
            card3.AddDataItem("TargetValue", measure15);
            measure16.DataMember = "AvgOrderSizeYTD";
            measure17.DataMember = "AvgOrderSizeYTDTarget";
            card4.Name = "Avg Order Size";
            card4.AddDataItem("ActualValue", measure16);
            card4.AddDataItem("TargetValue", measure17);
            measure18.DataMember = "NewCustomersYTD";
            measure19.DataMember = "NewCustomersYTDTarget";
            card5.Name = "New Customers";
            card5.AddDataItem("ActualValue", measure18);
            card5.AddDataItem("TargetValue", measure19);
            measure20.DataMember = "MarketShare";
            measure20.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Percent;
            measure20.NumericFormat.Precision = 0;
            card6.DeltaOptions.ValueType = DevExpress.DashboardCommon.DeltaValueType.ActualValue;
            card6.Name = "Market Share";
            card6.AddDataItem("ActualValue", measure20);
            this.cardKeyMetrics.Cards.AddRange(new DevExpress.DashboardCommon.Card[] {
            card1,
            card2,
            card3,
            card4,
            card5,
            card6});
            this.cardKeyMetrics.ComponentName = "cardKeyMetrics";
            this.cardKeyMetrics.ContentLineCount = 2;
            this.cardKeyMetrics.DataItemRepository.Clear();
            this.cardKeyMetrics.DataItemRepository.Add(measure10, "DataItem0");
            this.cardKeyMetrics.DataItemRepository.Add(measure11, "DataItem1");
            this.cardKeyMetrics.DataItemRepository.Add(measure12, "DataItem2");
            this.cardKeyMetrics.DataItemRepository.Add(measure13, "DataItem3");
            this.cardKeyMetrics.DataItemRepository.Add(measure14, "DataItem4");
            this.cardKeyMetrics.DataItemRepository.Add(measure15, "DataItem5");
            this.cardKeyMetrics.DataItemRepository.Add(measure16, "DataItem6");
            this.cardKeyMetrics.DataItemRepository.Add(measure18, "DataItem7");
            this.cardKeyMetrics.DataItemRepository.Add(measure20, "DataItem8");
            this.cardKeyMetrics.DataItemRepository.Add(measure17, "DataItem9");
            this.cardKeyMetrics.DataItemRepository.Add(measure19, "DataItem10");
            this.cardKeyMetrics.DataSource = this.dsKeyMetrics;
            this.cardKeyMetrics.InteractivityOptions.IgnoreMasterFilters = true;
            this.cardKeyMetrics.Name = "Key Metrics YTD";
            this.cardKeyMetrics.ShowCaption = false;
            // 
            // dsKeyMetrics
            // 
            this.dsKeyMetrics.ComponentName = "dsKeyMetrics";
            this.dsKeyMetrics.DataMember = "KeyMetricsItem";
            this.dsKeyMetrics.DataSchema = resources.GetString("dsKeyMetrics.DataSchema");
            this.dsKeyMetrics.Name = "Key Metrics";
            // 
            // chartProductMonthlySales
            // 
            dimension3.DataMember = "CurrentDate";
            dimension3.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.Month;
            this.chartProductMonthlySales.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension3});
            this.chartProductMonthlySales.AxisX.TitleVisible = false;
            this.chartProductMonthlySales.ColoringOptions.UseGlobalColors = false;
            this.chartProductMonthlySales.ComponentName = "chartProductMonthlySales";
            measure21.DataMember = "Revenue";
            dimension4.DataMember = "Product";
            dimension4.TopNOptions.Enabled = true;
            dimension4.TopNOptions.Measure = measure21;
            this.chartProductMonthlySales.DataItemRepository.Clear();
            this.chartProductMonthlySales.DataItemRepository.Add(measure21, "DataItem0");
            this.chartProductMonthlySales.DataItemRepository.Add(dimension3, "DataItem1");
            this.chartProductMonthlySales.DataItemRepository.Add(dimension4, "DataItem2");
            this.chartProductMonthlySales.DataSource = this.dsMonthlySales;
            this.chartProductMonthlySales.InteractivityOptions.IgnoreMasterFilters = false;
            this.chartProductMonthlySales.Legend.OutsidePosition = DevExpress.DashboardCommon.ChartLegendOutsidePosition.BottomCenterHorizontal;
            this.chartProductMonthlySales.Name = "Top 5 Products - Monthly Sales";
            chartPane1.Name = "Pane 1";
            chartPane1.PrimaryAxisY.AlwaysShowZeroLevel = true;
            chartPane1.PrimaryAxisY.ShowGridLines = true;
            chartPane1.PrimaryAxisY.Title = "Revenue";
            chartPane1.PrimaryAxisY.TitleVisible = true;
            chartPane1.SecondaryAxisY.AlwaysShowZeroLevel = true;
            chartPane1.SecondaryAxisY.ShowGridLines = false;
            chartPane1.SecondaryAxisY.TitleVisible = true;
            simpleSeries1.Name = "Revenue (Sum)";
            simpleSeries1.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.Line;
            simpleSeries1.AddDataItem("Value", measure21);
            chartPane1.Series.AddRange(new DevExpress.DashboardCommon.ChartSeries[] {
            simpleSeries1});
            this.chartProductMonthlySales.Panes.AddRange(new DevExpress.DashboardCommon.ChartPane[] {
            chartPane1});
            this.chartProductMonthlySales.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension4});
            this.chartProductMonthlySales.ShowCaption = true;
            // 
            // dsMonthlySales
            // 
            this.dsMonthlySales.ComponentName = "dsMonthlySales";
            this.dsMonthlySales.DataMember = "MonthlySalesItem";
            this.dsMonthlySales.DataSchema = resources.GetString("dsMonthlySales.DataSchema");
            this.dsMonthlySales.Name = "Monthly Sales";
            // 
            // SalesPerformanceDashboard
            // 
            this.DataSources.AddRange(new DevExpress.DashboardCommon.IDashboardDataSource[] {
            this.dsMonthlySales,
            this.dsTotalSales,
            this.dsKeyMetrics});
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.gridProductSales,
            this.cardKeyMetrics,
            this.chartProductMonthlySales,
            this.choroplethMapDashboardItem1});
            dashboardLayoutItem1.DashboardItem = this.choroplethMapDashboardItem1;
            dashboardLayoutItem1.Weight = 42.0940170940171D;
            dashboardLayoutItem2.DashboardItem = this.gridProductSales;
            dashboardLayoutItem2.Weight = 57.9059829059829D;
            dashboardLayoutGroup2.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1,
            dashboardLayoutItem2});
            dashboardLayoutGroup2.DashboardItem = null;
            dashboardLayoutGroup2.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
            dashboardLayoutGroup2.Weight = 54.037267080745345D;
            dashboardLayoutItem3.DashboardItem = this.cardKeyMetrics;
            dashboardLayoutItem3.Weight = 42.0940170940171D;
            dashboardLayoutItem4.DashboardItem = this.chartProductMonthlySales;
            dashboardLayoutItem4.Weight = 57.9059829059829D;
            dashboardLayoutGroup3.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem3,
            dashboardLayoutItem4});
            dashboardLayoutGroup3.DashboardItem = null;
            dashboardLayoutGroup3.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
            dashboardLayoutGroup3.Weight = 45.962732919254655D;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutGroup2,
            dashboardLayoutGroup3});
            dashboardLayoutGroup1.DashboardItem = null;
            this.LayoutRoot = dashboardLayoutGroup1;
            this.Title.Text = "Sales Performance";
            this.DataLoading += new DevExpress.DashboardCommon.DashboardDataLoadingEventHandler(this.SalesPerformanceDashboard_DataLoading);
            ((System.ComponentModel.ISupportInitialize)(dimension1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choroplethMapDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTotalSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardKeyMetrics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKeyMetrics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProductMonthlySales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMonthlySales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    void SalesPerformanceDashboard_DataLoading(object sender, DashboardDataLoadingEventArgs e) {
        if(e.DataSource == dsMonthlySales)
            e.Data = DataLoader.SalesPerformanceData.MonthlySales;
        else if(e.DataSource == dsTotalSales)
            e.Data = DataLoader.SalesPerformanceData.TotalSales;
        else if(e.DataSource == dsKeyMetrics)
            e.Data = DataLoader.SalesPerformanceData.KeyMetrics;
    }
}

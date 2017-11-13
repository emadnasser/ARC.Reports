Imports Microsoft.VisualBasic
Imports System
Imports DashboardMainDemo
Imports DevExpress.DashboardCommon

''' <summary>
''' Summary description
''' </summary>
Public Class SalesPerformanceDashboard
	Inherits Dashboard
	Private dsTotalSales As DashboardObjectDataSource
	Private gridProductSales As GridDashboardItem
	Private cardKeyMetrics As CardDashboardItem
	Private dsKeyMetrics As DashboardObjectDataSource
	Private chartProductMonthlySales As ChartDashboardItem
	Private dsMonthlySales As DashboardObjectDataSource
	Private choroplethMapDashboardItem1 As ChoroplethMapDashboardItem
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	Public Sub New()
		InitializeComponent()
	End Sub

	''' <summary> 
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
			Dim resources As System.Resources.ResourceManager = Global.Resources.SalesPerformanceDashboard.ResourceManager
			Dim dimension1 As New DevExpress.DashboardCommon.Dimension()
			Dim measure1 As New DevExpress.DashboardCommon.Measure()
			Dim measure2 As New DevExpress.DashboardCommon.Measure()
			Dim measure3 As New DevExpress.DashboardCommon.Measure()
			Dim measure4 As New DevExpress.DashboardCommon.Measure()
			Dim measure5 As New DevExpress.DashboardCommon.Measure()
			Dim measure6 As New DevExpress.DashboardCommon.Measure()
			Dim valueMap1 As New DevExpress.DashboardCommon.ValueMap()
			Dim customScale1 As New DevExpress.DashboardCommon.CustomScale()
			Dim deltaMap1 As New DevExpress.DashboardCommon.DeltaMap()
			Dim valueMap2 As New DevExpress.DashboardCommon.ValueMap()
			Dim customScale2 As New DevExpress.DashboardCommon.CustomScale()
			Dim deltaMap2 As New DevExpress.DashboardCommon.DeltaMap()
			Dim dimension2 As New DevExpress.DashboardCommon.Dimension()
			Dim gridDimensionColumn1 As New DevExpress.DashboardCommon.GridDimensionColumn()
			Dim measure7 As New DevExpress.DashboardCommon.Measure()
			Dim gridMeasureColumn1 As New DevExpress.DashboardCommon.GridMeasureColumn()
			Dim gridColumnTotal1 As New DevExpress.DashboardCommon.GridColumnTotal()
			Dim measure8 As New DevExpress.DashboardCommon.Measure()
			Dim measure9 As New DevExpress.DashboardCommon.Measure()
			Dim gridDeltaColumn1 As New DevExpress.DashboardCommon.GridDeltaColumn()
			Dim gridItemFormatRule1 As New DevExpress.DashboardCommon.GridItemFormatRule()
			Dim formatConditionTopBottom1 As New DevExpress.DashboardCommon.FormatConditionTopBottom()
			Dim iconSettings1 As New DevExpress.DashboardCommon.IconSettings()
			Dim gridItemFormatRule2 As New DevExpress.DashboardCommon.GridItemFormatRule()
			Dim formatConditionTopBottom2 As New DevExpress.DashboardCommon.FormatConditionTopBottom()
			Dim iconSettings2 As New DevExpress.DashboardCommon.IconSettings()
			Dim gridItemFormatRule3 As New DevExpress.DashboardCommon.GridItemFormatRule()
			Dim formatConditionAverage1 As New DevExpress.DashboardCommon.FormatConditionAverage()
			Dim appearanceSettings1 As New DevExpress.DashboardCommon.AppearanceSettings()
			Dim gridItemFormatRule4 As New DevExpress.DashboardCommon.GridItemFormatRule()
			Dim formatConditionAverage2 As New DevExpress.DashboardCommon.FormatConditionAverage()
			Dim appearanceSettings2 As New DevExpress.DashboardCommon.AppearanceSettings()
			Dim measure10 As New DevExpress.DashboardCommon.Measure()
			Dim measure11 As New DevExpress.DashboardCommon.Measure()
			Dim card1 As New DevExpress.DashboardCommon.Card()
			Dim measure12 As New DevExpress.DashboardCommon.Measure()
			Dim measure13 As New DevExpress.DashboardCommon.Measure()
			Dim card2 As New DevExpress.DashboardCommon.Card()
			Dim measure14 As New DevExpress.DashboardCommon.Measure()
			Dim measure15 As New DevExpress.DashboardCommon.Measure()
			Dim card3 As New DevExpress.DashboardCommon.Card()
			Dim measure16 As New DevExpress.DashboardCommon.Measure()
			Dim measure17 As New DevExpress.DashboardCommon.Measure()
			Dim card4 As New DevExpress.DashboardCommon.Card()
			Dim measure18 As New DevExpress.DashboardCommon.Measure()
			Dim measure19 As New DevExpress.DashboardCommon.Measure()
			Dim card5 As New DevExpress.DashboardCommon.Card()
			Dim measure20 As New DevExpress.DashboardCommon.Measure()
			Dim card6 As New DevExpress.DashboardCommon.Card()
			Dim dimension3 As New DevExpress.DashboardCommon.Dimension()
			Dim measure21 As New DevExpress.DashboardCommon.Measure()
			Dim dimension4 As New DevExpress.DashboardCommon.Dimension()
			Dim chartPane1 As New DevExpress.DashboardCommon.ChartPane()
			Dim simpleSeries1 As New DevExpress.DashboardCommon.SimpleSeries()
			Dim dashboardLayoutGroup1 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutGroup2 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutItem1 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem2 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutGroup3 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutItem3 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem4 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Me.choroplethMapDashboardItem1 = New DevExpress.DashboardCommon.ChoroplethMapDashboardItem()
			Me.dsTotalSales = New DevExpress.DashboardCommon.DashboardObjectDataSource()
			Me.gridProductSales = New DevExpress.DashboardCommon.GridDashboardItem()
			Me.cardKeyMetrics = New DevExpress.DashboardCommon.CardDashboardItem()
			Me.dsKeyMetrics = New DevExpress.DashboardCommon.DashboardObjectDataSource()
			Me.chartProductMonthlySales = New DevExpress.DashboardCommon.ChartDashboardItem()
			Me.dsMonthlySales = New DevExpress.DashboardCommon.DashboardObjectDataSource()
			CType(Me.choroplethMapDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dsTotalSales, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridProductSales, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure8, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure9, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cardKeyMetrics, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure10, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure12, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure13, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure14, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure15, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure16, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure17, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure18, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure19, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure20, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dsKeyMetrics, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chartProductMonthlySales, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure21, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dsMonthlySales, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' choroplethMapDashboardItem1
			' 
			Me.choroplethMapDashboardItem1.Area = DevExpress.DashboardCommon.ShapefileArea.USA
			dimension1.DataMember = "State"
			Me.choroplethMapDashboardItem1.AttributeDimension = dimension1
			Me.choroplethMapDashboardItem1.AttributeName = "NAME"
			Me.choroplethMapDashboardItem1.ComponentName = "choroplethMapDashboardItem1"
			measure1.DataMember = "RevenueYTD"
			measure2.DataMember = "RevenueYTD"
			measure3.DataMember = "RevenueYTDTarget"
			measure4.DataMember = "RevenueQTD"
			measure5.DataMember = "RevenueQTD"
			measure6.DataMember = "RevenueQTDTarget"
			Me.choroplethMapDashboardItem1.DataItemRepository.Clear()
			Me.choroplethMapDashboardItem1.DataItemRepository.Add(dimension1, "DataItem0")
			Me.choroplethMapDashboardItem1.DataItemRepository.Add(measure1, "DataItem2")
			Me.choroplethMapDashboardItem1.DataItemRepository.Add(measure2, "DataItem1")
			Me.choroplethMapDashboardItem1.DataItemRepository.Add(measure3, "DataItem3")
			Me.choroplethMapDashboardItem1.DataItemRepository.Add(measure4, "DataItem4")
			Me.choroplethMapDashboardItem1.DataItemRepository.Add(measure5, "DataItem5")
			Me.choroplethMapDashboardItem1.DataItemRepository.Add(measure6, "DataItem6")
			Me.choroplethMapDashboardItem1.DataSource = Me.dsTotalSales
			Me.choroplethMapDashboardItem1.IncludeSummaryValueToShapeTitle = True
			Me.choroplethMapDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
			Me.choroplethMapDashboardItem1.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Multiple
			Me.choroplethMapDashboardItem1.IsMasterFilterCrossDataSource = True
			Me.choroplethMapDashboardItem1.LockNavigation = True
			valueMap1.Name = "Revenue YTD"
			customScale1.RangeStops.Add(1R)
			customScale1.RangeStops.Add(2R)
			customScale1.RangeStops.Add(4R)
			customScale1.RangeStops.Add(6R)
			customScale1.RangeStops.Add(10R)
			customScale1.RangeStops.Add(14R)
			customScale1.RangeStops.Add(18R)
			customScale1.RangeStops.Add(22R)
			customScale1.RangeStops.Add(26R)
			customScale1.RangeStops.Add(30R)
			customScale1.RangeStops.Add(40R)
			customScale1.RangeStops.Add(50R)
			customScale1.RangeStops.Add(70R)
			customScale1.RangeStops.Add(90R)
			valueMap1.Scale = customScale1
			valueMap1.ValueName = "Revenue"
			valueMap1.AddDataItem("Value", measure2)
			deltaMap1.ActualValueName = "Revenue"
			deltaMap1.DeltaName = "vs Target"
			deltaMap1.Name = "Revenue YTD vs Target"
			deltaMap1.AddDataItem("ActualValue", measure1)
			deltaMap1.AddDataItem("TargetValue", measure3)
			valueMap2.Name = "Revenue QTD"
			customScale2.RangeStops.Add(1R)
			customScale2.RangeStops.Add(2R)
			customScale2.RangeStops.Add(4R)
			customScale2.RangeStops.Add(6R)
			customScale2.RangeStops.Add(10R)
			customScale2.RangeStops.Add(14R)
			customScale2.RangeStops.Add(18R)
			customScale2.RangeStops.Add(22R)
			customScale2.RangeStops.Add(26R)
			customScale2.RangeStops.Add(30R)
			customScale2.RangeStops.Add(40R)
			customScale2.RangeStops.Add(50R)
			customScale2.RangeStops.Add(70R)
			customScale2.RangeStops.Add(90R)
			valueMap2.Scale = customScale2
			valueMap2.ValueName = "Revenue"
			valueMap2.AddDataItem("Value", measure4)
			deltaMap2.ActualValueName = "Revenue"
			deltaMap2.DeltaName = "vs Target"
			deltaMap2.Name = "Revenue QTD vs Target"
			deltaMap2.AddDataItem("ActualValue", measure5)
			deltaMap2.AddDataItem("TargetValue", measure6)
			Me.choroplethMapDashboardItem1.Maps.AddRange(New DevExpress.DashboardCommon.ChoroplethMap() { valueMap1, deltaMap1, valueMap2, deltaMap2})
			Me.choroplethMapDashboardItem1.Name = "Sales by State"
			Me.choroplethMapDashboardItem1.ShowCaption = True
			Me.choroplethMapDashboardItem1.Viewport.BottomLatitude = 22.722765208057595R
			Me.choroplethMapDashboardItem1.Viewport.CenterPointLatitude = 37.20824763267364R
			Me.choroplethMapDashboardItem1.Viewport.CenterPointLongitude = -95.848499902568008R
			Me.choroplethMapDashboardItem1.Viewport.LeftLongitude = -124.70997774915153R
			Me.choroplethMapDashboardItem1.Viewport.RightLongitude = -66.987022055984482R
			Me.choroplethMapDashboardItem1.Viewport.TopLatitude = 49.369672064487254R
			' 
			' dsTotalSales
			' 
			Me.dsTotalSales.ComponentName = "dsTotalSales"
			Me.dsTotalSales.DataMember = "TotalSalesItem"
			Me.dsTotalSales.DataSchema = resources.GetString("dsTotalSales.DataSchema")
			Me.dsTotalSales.Name = "Total Sales"
			' 
			' gridProductSales
			' 
			dimension2.DataMember = "Product"
			gridDimensionColumn1.Name = "Product"
			gridDimensionColumn1.Weight = 47.492163009404386R
			gridDimensionColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
			gridDimensionColumn1.AddDataItem("Dimension", dimension2)
			measure7.DataMember = "RevenueYTD"
			gridMeasureColumn1.Name = "Revenue YTD"
			gridColumnTotal1.TotalType = DevExpress.DashboardCommon.GridColumnTotalType.Sum
			gridMeasureColumn1.Totals.AddRange(New DevExpress.DashboardCommon.GridColumnTotal() { gridColumnTotal1})
			gridMeasureColumn1.Weight = 70.532915360501562R
			gridMeasureColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
			gridMeasureColumn1.AddDataItem("Measure", measure7)
			measure8.DataMember = "RevenueYTD"
			measure9.DataMember = "RevenueYTDTarget"
			gridDeltaColumn1.DeltaOptions.ResultIndicationThreshold = New Decimal(New Integer() { 1, 0, 0, 0})
			gridDeltaColumn1.DeltaOptions.ValueType = DevExpress.DashboardCommon.DeltaValueType.PercentVariation
			gridDeltaColumn1.Name = "Revenue YTD vs Target"
			gridDeltaColumn1.Weight = 111.44200626959248R
			gridDeltaColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
			gridDeltaColumn1.AddDataItem("ActualValue", measure8)
			gridDeltaColumn1.AddDataItem("TargetValue", measure9)
			Me.gridProductSales.Columns.AddRange(New DevExpress.DashboardCommon.GridColumnBase() { gridDimensionColumn1, gridMeasureColumn1, gridDeltaColumn1})
			Me.gridProductSales.ComponentName = "gridProductSales"
			Me.gridProductSales.DataItemRepository.Clear()
			Me.gridProductSales.DataItemRepository.Add(dimension2, "DataItem1")
			Me.gridProductSales.DataItemRepository.Add(measure9, "DataItem5")
			Me.gridProductSales.DataItemRepository.Add(measure7, "DataItem3")
			Me.gridProductSales.DataItemRepository.Add(measure8, "DataItem4")
			Me.gridProductSales.DataSource = Me.dsTotalSales
			iconSettings1.IconType = DevExpress.DashboardCommon.FormatConditionIconType.ShapeGreenCircle
			formatConditionTopBottom1.StyleSettings = iconSettings1
			gridItemFormatRule1.Condition = formatConditionTopBottom1
			gridItemFormatRule1.DataItem = measure7
			gridItemFormatRule1.DataItemApplyTo = dimension2
			gridItemFormatRule1.Name = "FormatRule 1"
			iconSettings2.IconType = DevExpress.DashboardCommon.FormatConditionIconType.ShapeRedCircle
			formatConditionTopBottom2.StyleSettings = iconSettings2
			formatConditionTopBottom2.TopBottom = DevExpress.DashboardCommon.DashboardFormatConditionTopBottomType.Bottom
			gridItemFormatRule2.Condition = formatConditionTopBottom2
			gridItemFormatRule2.DataItem = measure7
			gridItemFormatRule2.DataItemApplyTo = dimension2
			gridItemFormatRule2.Name = "FormatRule 2"
			formatConditionAverage1.AverageType = DevExpress.DashboardCommon.DashboardFormatConditionAboveBelowType.AboveOrEqual
			appearanceSettings1.AppearanceType = DevExpress.DashboardCommon.FormatConditionAppearanceType.FontGreen
			formatConditionAverage1.StyleSettings = appearanceSettings1
			gridItemFormatRule3.Condition = formatConditionAverage1
			gridItemFormatRule3.DataItem = measure7
			gridItemFormatRule3.Name = "FormatRule 3"
			formatConditionAverage2.AverageType = DevExpress.DashboardCommon.DashboardFormatConditionAboveBelowType.Below
			appearanceSettings2.AppearanceType = DevExpress.DashboardCommon.FormatConditionAppearanceType.FontRed
			formatConditionAverage2.StyleSettings = appearanceSettings2
			gridItemFormatRule4.Condition = formatConditionAverage2
			gridItemFormatRule4.DataItem = measure7
			gridItemFormatRule4.Name = "FormatRule 4"
			Me.gridProductSales.FormatRules.AddRange(New DevExpress.DashboardCommon.GridItemFormatRule() { gridItemFormatRule1, gridItemFormatRule2, gridItemFormatRule3, gridItemFormatRule4})
			Me.gridProductSales.GridOptions.AllowCellMerge = True
			Me.gridProductSales.GridOptions.ShowHorizontalLines = False
			Me.gridProductSales.InteractivityOptions.IgnoreMasterFilters = False
			Me.gridProductSales.Name = "Product Sales YTD"
			Me.gridProductSales.ShowCaption = True
			' 
			' cardKeyMetrics
			' 
			measure10.DataMember = "RevenueYTD"
			measure11.DataMember = "RevenueYTDTarget"
			card1.Name = "Revenue YTD"
			card1.AddDataItem("ActualValue", measure10)
			card1.AddDataItem("TargetValue", measure11)
			measure12.DataMember = "ExpencesYTD"
			measure13.DataMember = "ExpencesYTDTarget"
			card2.DeltaOptions.ResultIndicationMode = DevExpress.DashboardCommon.DeltaIndicationMode.LessIsGood
			card2.Name = "Expenses YTD"
			card2.AddDataItem("ActualValue", measure12)
			card2.AddDataItem("TargetValue", measure13)
			measure14.DataMember = "ProfitYTD"
			measure15.DataMember = "ProfitYTDTarget"
			card3.Name = "Profit YTD"
			card3.AddDataItem("ActualValue", measure14)
			card3.AddDataItem("TargetValue", measure15)
			measure16.DataMember = "AvgOrderSizeYTD"
			measure17.DataMember = "AvgOrderSizeYTDTarget"
			card4.Name = "Avg Order Size"
			card4.AddDataItem("ActualValue", measure16)
			card4.AddDataItem("TargetValue", measure17)
			measure18.DataMember = "NewCustomersYTD"
			measure19.DataMember = "NewCustomersYTDTarget"
			card5.Name = "New Customers"
			card5.AddDataItem("ActualValue", measure18)
			card5.AddDataItem("TargetValue", measure19)
			measure20.DataMember = "MarketShare"
			measure20.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Percent
			measure20.NumericFormat.Precision = 0
			card6.DeltaOptions.ValueType = DevExpress.DashboardCommon.DeltaValueType.ActualValue
			card6.Name = "Market Share"
			card6.AddDataItem("ActualValue", measure20)
			Me.cardKeyMetrics.Cards.AddRange(New DevExpress.DashboardCommon.Card() { card1, card2, card3, card4, card5, card6})
			Me.cardKeyMetrics.ComponentName = "cardKeyMetrics"
			Me.cardKeyMetrics.ContentLineCount = 2
			Me.cardKeyMetrics.DataItemRepository.Clear()
			Me.cardKeyMetrics.DataItemRepository.Add(measure10, "DataItem0")
			Me.cardKeyMetrics.DataItemRepository.Add(measure11, "DataItem1")
			Me.cardKeyMetrics.DataItemRepository.Add(measure12, "DataItem2")
			Me.cardKeyMetrics.DataItemRepository.Add(measure13, "DataItem3")
			Me.cardKeyMetrics.DataItemRepository.Add(measure14, "DataItem4")
			Me.cardKeyMetrics.DataItemRepository.Add(measure15, "DataItem5")
			Me.cardKeyMetrics.DataItemRepository.Add(measure16, "DataItem6")
			Me.cardKeyMetrics.DataItemRepository.Add(measure18, "DataItem7")
			Me.cardKeyMetrics.DataItemRepository.Add(measure20, "DataItem8")
			Me.cardKeyMetrics.DataItemRepository.Add(measure17, "DataItem9")
			Me.cardKeyMetrics.DataItemRepository.Add(measure19, "DataItem10")
			Me.cardKeyMetrics.DataSource = Me.dsKeyMetrics
			Me.cardKeyMetrics.InteractivityOptions.IgnoreMasterFilters = True
			Me.cardKeyMetrics.Name = "Key Metrics YTD"
			Me.cardKeyMetrics.ShowCaption = False
			' 
			' dsKeyMetrics
			' 
			Me.dsKeyMetrics.ComponentName = "dsKeyMetrics"
			Me.dsKeyMetrics.DataMember = "KeyMetricsItem"
			Me.dsKeyMetrics.DataSchema = resources.GetString("dsKeyMetrics.DataSchema")
			Me.dsKeyMetrics.Name = "Key Metrics"
			' 
			' chartProductMonthlySales
			' 
			dimension3.DataMember = "CurrentDate"
			dimension3.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.Month
			Me.chartProductMonthlySales.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension3})
			Me.chartProductMonthlySales.AxisX.TitleVisible = False
			Me.chartProductMonthlySales.ColoringOptions.UseGlobalColors = False
			Me.chartProductMonthlySales.ComponentName = "chartProductMonthlySales"
			measure21.DataMember = "Revenue"
			dimension4.DataMember = "Product"
			dimension4.TopNOptions.Enabled = True
			dimension4.TopNOptions.Measure = measure21
			Me.chartProductMonthlySales.DataItemRepository.Clear()
			Me.chartProductMonthlySales.DataItemRepository.Add(measure21, "DataItem0")
			Me.chartProductMonthlySales.DataItemRepository.Add(dimension3, "DataItem1")
			Me.chartProductMonthlySales.DataItemRepository.Add(dimension4, "DataItem2")
			Me.chartProductMonthlySales.DataSource = Me.dsMonthlySales
			Me.chartProductMonthlySales.InteractivityOptions.IgnoreMasterFilters = False
			Me.chartProductMonthlySales.Legend.OutsidePosition = DevExpress.DashboardCommon.ChartLegendOutsidePosition.BottomCenterHorizontal
			Me.chartProductMonthlySales.Name = "Top 5 Products - Monthly Sales"
			chartPane1.Name = "Pane 1"
			chartPane1.PrimaryAxisY.AlwaysShowZeroLevel = True
			chartPane1.PrimaryAxisY.ShowGridLines = True
			chartPane1.PrimaryAxisY.Title = "Revenue"
			chartPane1.PrimaryAxisY.TitleVisible = True
			chartPane1.SecondaryAxisY.AlwaysShowZeroLevel = True
			chartPane1.SecondaryAxisY.ShowGridLines = False
			chartPane1.SecondaryAxisY.TitleVisible = True
			simpleSeries1.Name = "Revenue (Sum)"
			simpleSeries1.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.Line
			simpleSeries1.AddDataItem("Value", measure21)
			chartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() { simpleSeries1})
			Me.chartProductMonthlySales.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() { chartPane1})
			Me.chartProductMonthlySales.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension4})
			Me.chartProductMonthlySales.ShowCaption = True
			' 
			' dsMonthlySales
			' 
			Me.dsMonthlySales.ComponentName = "dsMonthlySales"
			Me.dsMonthlySales.DataMember = "MonthlySalesItem"
			Me.dsMonthlySales.DataSchema = resources.GetString("dsMonthlySales.DataSchema")
			Me.dsMonthlySales.Name = "Monthly Sales"
			' 
			' SalesPerformanceDashboard
			' 
			Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() { Me.dsMonthlySales, Me.dsTotalSales, Me.dsKeyMetrics})
			Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() { Me.gridProductSales, Me.cardKeyMetrics, Me.chartProductMonthlySales, Me.choroplethMapDashboardItem1})
			dashboardLayoutItem1.DashboardItem = Me.choroplethMapDashboardItem1
			dashboardLayoutItem1.Weight = 42.0940170940171R
			dashboardLayoutItem2.DashboardItem = Me.gridProductSales
			dashboardLayoutItem2.Weight = 57.9059829059829R
			dashboardLayoutGroup2.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem1, dashboardLayoutItem2})
			dashboardLayoutGroup2.DashboardItem = Nothing
			dashboardLayoutGroup2.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
			dashboardLayoutGroup2.Weight = 54.037267080745345R
			dashboardLayoutItem3.DashboardItem = Me.cardKeyMetrics
			dashboardLayoutItem3.Weight = 42.0940170940171R
			dashboardLayoutItem4.DashboardItem = Me.chartProductMonthlySales
			dashboardLayoutItem4.Weight = 57.9059829059829R
			dashboardLayoutGroup3.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem3, dashboardLayoutItem4})
			dashboardLayoutGroup3.DashboardItem = Nothing
			dashboardLayoutGroup3.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
			dashboardLayoutGroup3.Weight = 45.962732919254655R
			dashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutGroup2, dashboardLayoutGroup3})
			dashboardLayoutGroup1.DashboardItem = Nothing
			Me.LayoutRoot = dashboardLayoutGroup1
			Me.Title.Text = "Sales Performance"
'			Me.DataLoading += New DevExpress.DashboardCommon.DashboardDataLoadingEventHandler(Me.SalesPerformanceDashboard_DataLoading);
			CType(dimension1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.choroplethMapDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dsTotalSales, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure8, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure9, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridProductSales, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure10, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure12, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure13, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure14, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure15, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure16, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure17, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure18, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure19, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure20, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cardKeyMetrics, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dsKeyMetrics, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure21, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartProductMonthlySales, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dsMonthlySales, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub

	#End Region

	Private Sub SalesPerformanceDashboard_DataLoading(ByVal sender As Object, ByVal e As DashboardDataLoadingEventArgs) Handles MyBase.DataLoading
		If e.DataSource Is dsMonthlySales Then
			e.Data = DataLoader.SalesPerformanceData.MonthlySales
		ElseIf e.DataSource Is dsTotalSales Then
			e.Data = DataLoader.SalesPerformanceData.TotalSales
		ElseIf e.DataSource Is dsKeyMetrics Then
			e.Data = DataLoader.SalesPerformanceData.KeyMetrics
		End If
	End Sub
End Class

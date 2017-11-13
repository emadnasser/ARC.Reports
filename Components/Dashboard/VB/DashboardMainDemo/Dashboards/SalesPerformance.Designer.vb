Imports Microsoft.VisualBasic
Imports System
Namespace DashboardMainDemo.Dashboards
	Partial Public Class SalesPerformance
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim dimension1 As New DevExpress.DashboardCommon.Dimension()
			Dim measure1 As New DevExpress.DashboardCommon.Measure()
			Dim measure2 As New DevExpress.DashboardCommon.Measure()
			Dim measure3 As New DevExpress.DashboardCommon.Measure()
			Dim measure4 As New DevExpress.DashboardCommon.Measure()
			Dim measure5 As New DevExpress.DashboardCommon.Measure()
			Dim measure6 As New DevExpress.DashboardCommon.Measure()
			Dim valueMap1 As New DevExpress.DashboardCommon.ValueMap()
			Dim gradientPalette1 As New DevExpress.DashboardCommon.GradientPalette()
			Dim customScale1 As New DevExpress.DashboardCommon.CustomScale()
			Dim deltaMap1 As New DevExpress.DashboardCommon.DeltaMap()
			Dim valueMap2 As New DevExpress.DashboardCommon.ValueMap()
			Dim gradientPalette2 As New DevExpress.DashboardCommon.GradientPalette()
			Dim customScale2 As New DevExpress.DashboardCommon.CustomScale()
			Dim deltaMap2 As New DevExpress.DashboardCommon.DeltaMap()
			Dim dimension2 As New DevExpress.DashboardCommon.Dimension()
			Dim gridDimensionColumn1 As New DevExpress.DashboardCommon.GridDimensionColumn()
			Dim dimension3 As New DevExpress.DashboardCommon.Dimension()
			Dim gridDimensionColumn2 As New DevExpress.DashboardCommon.GridDimensionColumn()
			Dim measure7 As New DevExpress.DashboardCommon.Measure()
			Dim gridMeasureColumn1 As New DevExpress.DashboardCommon.GridMeasureColumn()
			Dim gridColumnTotal1 As New DevExpress.DashboardCommon.GridColumnTotal()
			Dim measure8 As New DevExpress.DashboardCommon.Measure()
			Dim measure9 As New DevExpress.DashboardCommon.Measure()
			Dim gridDeltaColumn1 As New DevExpress.DashboardCommon.GridDeltaColumn()
			Dim measure10 As New DevExpress.DashboardCommon.Measure()
			Dim gridMeasureColumn2 As New DevExpress.DashboardCommon.GridMeasureColumn()
			Dim gridColumnTotal2 As New DevExpress.DashboardCommon.GridColumnTotal()
			Dim measure11 As New DevExpress.DashboardCommon.Measure()
			Dim measure12 As New DevExpress.DashboardCommon.Measure()
			Dim gridDeltaColumn2 As New DevExpress.DashboardCommon.GridDeltaColumn()
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
			Dim measure13 As New DevExpress.DashboardCommon.Measure()
			Dim measure14 As New DevExpress.DashboardCommon.Measure()
			Dim card1 As New DevExpress.DashboardCommon.Card()
			Dim measure15 As New DevExpress.DashboardCommon.Measure()
			Dim measure16 As New DevExpress.DashboardCommon.Measure()
			Dim card2 As New DevExpress.DashboardCommon.Card()
			Dim measure17 As New DevExpress.DashboardCommon.Measure()
			Dim measure18 As New DevExpress.DashboardCommon.Measure()
			Dim card3 As New DevExpress.DashboardCommon.Card()
			Dim measure19 As New DevExpress.DashboardCommon.Measure()
			Dim measure20 As New DevExpress.DashboardCommon.Measure()
			Dim card4 As New DevExpress.DashboardCommon.Card()
			Dim measure21 As New DevExpress.DashboardCommon.Measure()
			Dim measure22 As New DevExpress.DashboardCommon.Measure()
			Dim card5 As New DevExpress.DashboardCommon.Card()
			Dim measure23 As New DevExpress.DashboardCommon.Measure()
			Dim card6 As New DevExpress.DashboardCommon.Card()
			Dim dimension4 As New DevExpress.DashboardCommon.Dimension()
			Dim measure24 As New DevExpress.DashboardCommon.Measure()
			Dim dimension5 As New DevExpress.DashboardCommon.Dimension()
			Dim chartPane1 As New DevExpress.DashboardCommon.ChartPane()
			Dim simpleSeries1 As New DevExpress.DashboardCommon.SimpleSeries()
			Dim dimension6 As New DevExpress.DashboardCommon.Dimension()
			Dim measure25 As New DevExpress.DashboardCommon.Measure()
			Dim dashboardLayoutGroup1 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutGroup2 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutItem1 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem2 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutGroup3 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutItem3 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem4 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem5 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Me.choroplethMapDashboardItem1 = New DevExpress.DashboardCommon.ChoroplethMapDashboardItem()
			Me.dsTotalSales = New DevExpress.DashboardCommon.DashboardObjectDataSource()
			Me.gridProductSales = New DevExpress.DashboardCommon.GridDashboardItem()
			Me.cardKeyMetrics = New DevExpress.DashboardCommon.CardDashboardItem()
			Me.dsKeyMetrics = New DevExpress.DashboardCommon.DashboardObjectDataSource()
			Me.chartProductMonthlySales = New DevExpress.DashboardCommon.ChartDashboardItem()
			Me.dsMonthlySales = New DevExpress.DashboardCommon.DashboardObjectDataSource()
			Me.pieCategorySales = New DevExpress.DashboardCommon.PieDashboardItem()
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
			CType(dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure8, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure9, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure10, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure12, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cardKeyMetrics, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure13, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure14, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure15, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure16, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure17, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure18, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure19, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure20, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure21, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure22, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure23, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dsKeyMetrics, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chartProductMonthlySales, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure24, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dsMonthlySales, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pieCategorySales, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure25, System.ComponentModel.ISupportInitialize).BeginInit()
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
			Me.choroplethMapDashboardItem1.DataItemRepository.Add(measure1, "DataItem1")
			Me.choroplethMapDashboardItem1.DataItemRepository.Add(measure2, "DataItem2")
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
			gradientPalette1.EndColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(93))))), (CInt(Fix((CByte(106))))))
			gradientPalette1.StartColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(54))))), (CInt(Fix((CByte(170))))), (CInt(Fix((CByte(206))))))
			valueMap1.Palette = gradientPalette1
			customScale1.RangeStops.Add(1R)
			customScale1.RangeStops.Add(2R)
			customScale1.RangeStops.Add(3R)
			customScale1.RangeStops.Add(4R)
			customScale1.RangeStops.Add(6R)
			customScale1.RangeStops.Add(8R)
			customScale1.RangeStops.Add(10R)
			customScale1.RangeStops.Add(12R)
			customScale1.RangeStops.Add(14R)
			customScale1.RangeStops.Add(16R)
			customScale1.RangeStops.Add(20R)
			customScale1.RangeStops.Add(30R)
			customScale1.RangeStops.Add(50R)
			customScale1.RangeStops.Add(90R)
			valueMap1.Scale = customScale1
			valueMap1.ValueName = "Revenue"
			valueMap1.AddDataItem("Value", measure1)
			deltaMap1.ActualValueName = "Revenue"
			deltaMap1.DeltaName = "vs Target"
			deltaMap1.Name = "Revenue YTD vs Target"
			deltaMap1.AddDataItem("ActualValue", measure2)
			deltaMap1.AddDataItem("TargetValue", measure3)
			valueMap2.Name = "Revenue QTD"
			gradientPalette2.EndColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(93))))), (CInt(Fix((CByte(106))))))
			gradientPalette2.StartColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(54))))), (CInt(Fix((CByte(170))))), (CInt(Fix((CByte(206))))))
			valueMap2.Palette = gradientPalette2
			customScale2.RangeStops.Add(1R)
			customScale2.RangeStops.Add(2R)
			customScale2.RangeStops.Add(3R)
			customScale2.RangeStops.Add(4R)
			customScale2.RangeStops.Add(6R)
			customScale2.RangeStops.Add(8R)
			customScale2.RangeStops.Add(10R)
			customScale2.RangeStops.Add(12R)
			customScale2.RangeStops.Add(14R)
			customScale2.RangeStops.Add(16R)
			customScale2.RangeStops.Add(20R)
			customScale2.RangeStops.Add(30R)
			customScale2.RangeStops.Add(50R)
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
			Me.dsTotalSales.DataSource = GetType(DashboardMainDemo.SalesPerformanceDataGenerator.TotalSalesItem)
			Me.dsTotalSales.Name = "Total Sales"
			' 
			' gridProductSales
			' 
			dimension2.DataMember = "Category"
			gridDimensionColumn1.Name = "Category"
			gridDimensionColumn1.Weight = 52.027027027027025R
			gridDimensionColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
			gridDimensionColumn1.AddDataItem("Dimension", dimension2)
			dimension3.DataMember = "Product"
			gridDimensionColumn2.Name = "Product"
			gridDimensionColumn2.Weight = 46.621621621621621R
			gridDimensionColumn2.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
			gridDimensionColumn2.AddDataItem("Dimension", dimension3)
			measure7.DataMember = "RevenueYTD"
			gridMeasureColumn1.Name = "Revenue YTD"
			gridColumnTotal1.TotalType = DevExpress.DashboardCommon.GridColumnTotalType.Sum
			gridMeasureColumn1.Totals.AddRange(New DevExpress.DashboardCommon.GridColumnTotal() { gridColumnTotal1})
			gridMeasureColumn1.Weight = 68.243243243243242R
			gridMeasureColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
			gridMeasureColumn1.AddDataItem("Measure", measure7)
			measure8.DataMember = "RevenueYTD"
			measure9.DataMember = "RevenueYTDTarget"
			gridDeltaColumn1.DeltaOptions.ResultIndicationThreshold = New Decimal(New Integer() { 1, 0, 0, 0})
			gridDeltaColumn1.DeltaOptions.ValueType = DevExpress.DashboardCommon.DeltaValueType.PercentVariation
			gridDeltaColumn1.Name = "Revenue YTD vs Target"
			gridDeltaColumn1.Weight = 107.43243243243244R
			gridDeltaColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
			gridDeltaColumn1.AddDataItem("ActualValue", measure8)
			gridDeltaColumn1.AddDataItem("TargetValue", measure9)
			measure10.DataMember = "UnitsSoldYTD"
			gridMeasureColumn2.Name = "Units Sold YTD"
			gridColumnTotal2.TotalType = DevExpress.DashboardCommon.GridColumnTotalType.Sum
			gridMeasureColumn2.Totals.AddRange(New DevExpress.DashboardCommon.GridColumnTotal() { gridColumnTotal2})
			gridMeasureColumn2.Weight = 71.621621621621628R
			gridMeasureColumn2.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
			gridMeasureColumn2.AddDataItem("Measure", measure10)
			measure11.DataMember = "UnitsSoldYTD"
			measure12.DataMember = "UnitsSoldYTDTarget"
			gridDeltaColumn2.DeltaOptions.ResultIndicationThreshold = New Decimal(New Integer() { 1, 0, 0, 0})
			gridDeltaColumn2.Name = "Units Sold YTD vs Target"
			gridDeltaColumn2.Weight = 110.81081081081081R
			gridDeltaColumn2.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
			gridDeltaColumn2.AddDataItem("ActualValue", measure11)
			gridDeltaColumn2.AddDataItem("TargetValue", measure12)
			Me.gridProductSales.Columns.AddRange(New DevExpress.DashboardCommon.GridColumnBase() { gridDimensionColumn1, gridDimensionColumn2, gridMeasureColumn1, gridDeltaColumn1, gridMeasureColumn2, gridDeltaColumn2})
			Me.gridProductSales.ComponentName = "gridProductSales"
			Me.gridProductSales.DataItemRepository.Clear()
			Me.gridProductSales.DataItemRepository.Add(dimension2, "DataItem0")
			Me.gridProductSales.DataItemRepository.Add(dimension3, "DataItem1")
			Me.gridProductSales.DataItemRepository.Add(measure9, "DataItem5")
			Me.gridProductSales.DataItemRepository.Add(measure7, "DataItem3")
			Me.gridProductSales.DataItemRepository.Add(measure8, "DataItem4")
			Me.gridProductSales.DataItemRepository.Add(measure10, "DataItem6")
			Me.gridProductSales.DataItemRepository.Add(measure12, "DataItem8")
			Me.gridProductSales.DataItemRepository.Add(measure11, "DataItem7")
			Me.gridProductSales.DataSource = Me.dsTotalSales
			formatConditionTopBottom1.Rank = New Decimal(New Integer() { 10, 0, 0, 0})
			iconSettings1.IconType = DevExpress.DashboardCommon.FormatConditionIconType.ShapeGreenCircle
			formatConditionTopBottom1.StyleSettings = iconSettings1
			gridItemFormatRule1.Condition = formatConditionTopBottom1
			gridItemFormatRule1.DataItem = measure7
			gridItemFormatRule1.DataItemApplyTo = dimension3
			gridItemFormatRule1.Name = "FormatRule 1"
			formatConditionTopBottom2.Rank = New Decimal(New Integer() { 10, 0, 0, 0})
			iconSettings2.IconType = DevExpress.DashboardCommon.FormatConditionIconType.ShapeRedCircle
			formatConditionTopBottom2.StyleSettings = iconSettings2
			formatConditionTopBottom2.TopBottom = DevExpress.DashboardCommon.DashboardFormatConditionTopBottomType.Bottom
			gridItemFormatRule2.Condition = formatConditionTopBottom2
			gridItemFormatRule2.DataItem = measure7
			gridItemFormatRule2.DataItemApplyTo = dimension3
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
			Me.gridProductSales.InteractivityOptions.IgnoreMasterFilters = False
			Me.gridProductSales.Name = "Product Sales YTD"
			Me.gridProductSales.ShowCaption = True
			' 
			' cardKeyMetrics
			' 
			measure13.DataMember = "RevenueYTD"
			measure14.DataMember = "RevenueYTDTarget"
			card1.Name = "Revenue YTD"
			card1.AddDataItem("ActualValue", measure13)
			card1.AddDataItem("TargetValue", measure14)
			measure15.DataMember = "ExpencesYTD"
			measure16.DataMember = "ExpencesYTDTarget"
			card2.DeltaOptions.ResultIndicationMode = DevExpress.DashboardCommon.DeltaIndicationMode.LessIsGood
			card2.Name = "Expenses YTD"
			card2.AddDataItem("ActualValue", measure15)
			card2.AddDataItem("TargetValue", measure16)
			measure17.DataMember = "ProfitYTD"
			measure18.DataMember = "ProfitYTDTarget"
			card3.Name = "Profit YTD"
			card3.AddDataItem("ActualValue", measure17)
			card3.AddDataItem("TargetValue", measure18)
			measure19.DataMember = "AvgOrderSizeYTD"
			measure20.DataMember = "AvgOrderSizeYTDTarget"
			card4.Name = "Avg Order Size"
			card4.AddDataItem("ActualValue", measure19)
			card4.AddDataItem("TargetValue", measure20)
			measure21.DataMember = "NewCustomersYTD"
			measure22.DataMember = "NewCustomersYTDTarget"
			card5.Name = "New Customers"
			card5.AddDataItem("ActualValue", measure21)
			card5.AddDataItem("TargetValue", measure22)
			measure23.DataMember = "MarketShare"
			measure23.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Percent
			measure23.NumericFormat.Precision = 0
			card6.DeltaOptions.ValueType = DevExpress.DashboardCommon.DeltaValueType.ActualValue
			card6.Name = "Market Share"
			card6.AddDataItem("ActualValue", measure23)
			Me.cardKeyMetrics.Cards.AddRange(New DevExpress.DashboardCommon.Card() { card1, card2, card3, card4, card5, card6})
			Me.cardKeyMetrics.ComponentName = "cardKeyMetrics"
			Me.cardKeyMetrics.ContentLineCount = 2
			Me.cardKeyMetrics.DataItemRepository.Clear()
			Me.cardKeyMetrics.DataItemRepository.Add(measure23, "DataItem10")
			Me.cardKeyMetrics.DataItemRepository.Add(measure22, "DataItem9")
			Me.cardKeyMetrics.DataItemRepository.Add(measure21, "DataItem8")
			Me.cardKeyMetrics.DataItemRepository.Add(measure20, "DataItem7")
			Me.cardKeyMetrics.DataItemRepository.Add(measure19, "DataItem6")
			Me.cardKeyMetrics.DataItemRepository.Add(measure18, "DataItem5")
			Me.cardKeyMetrics.DataItemRepository.Add(measure17, "DataItem4")
			Me.cardKeyMetrics.DataItemRepository.Add(measure15, "DataItem2")
			Me.cardKeyMetrics.DataItemRepository.Add(measure13, "DataItem0")
			Me.cardKeyMetrics.DataItemRepository.Add(measure16, "DataItem3")
			Me.cardKeyMetrics.DataItemRepository.Add(measure14, "DataItem1")
			Me.cardKeyMetrics.DataSource = Me.dsKeyMetrics
			Me.cardKeyMetrics.InteractivityOptions.IgnoreMasterFilters = True
			Me.cardKeyMetrics.Name = "Key Metrics YTD"
			Me.cardKeyMetrics.ShowCaption = False
			' 
			' dsKeyMetrics
			' 
			Me.dsKeyMetrics.ComponentName = "dsKeyMetrics"
			Me.dsKeyMetrics.DataSource = GetType(DashboardMainDemo.SalesPerformanceDataGenerator.KeyMetricsItem)
			Me.dsKeyMetrics.Name = "Key Metrics"
			' 
			' chartProductMonthlySales
			' 
			dimension4.DataMember = "CurrentDate"
			dimension4.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.Month
			Me.chartProductMonthlySales.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension4})
			Me.chartProductMonthlySales.AxisX.TitleVisible = False
			Me.chartProductMonthlySales.ColoringOptions.UseGlobalColors = False
			Me.chartProductMonthlySales.ComponentName = "chartProductMonthlySales"
			measure24.DataMember = "Revenue"
			dimension5.DataMember = "Product"
			dimension5.TopNOptions.Enabled = True
			dimension5.TopNOptions.Measure = measure24
			Me.chartProductMonthlySales.DataItemRepository.Clear()
			Me.chartProductMonthlySales.DataItemRepository.Add(measure24, "DataItem0")
			Me.chartProductMonthlySales.DataItemRepository.Add(dimension4, "DataItem1")
			Me.chartProductMonthlySales.DataItemRepository.Add(dimension5, "DataItem2")
			Me.chartProductMonthlySales.DataSource = Me.dsMonthlySales
			Me.chartProductMonthlySales.InteractivityOptions.IgnoreMasterFilters = False
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
			simpleSeries1.AddDataItem("Value", measure24)
			chartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() { simpleSeries1})
			Me.chartProductMonthlySales.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() { chartPane1})
			Me.chartProductMonthlySales.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension5})
			Me.chartProductMonthlySales.ShowCaption = True
			' 
			' dsMonthlySales
			' 
			Me.dsMonthlySales.ComponentName = "dsMonthlySales"
			Me.dsMonthlySales.DataSource = GetType(DashboardMainDemo.SalesPerformanceDataGenerator.MonthlySalesItem)
			Me.dsMonthlySales.Name = "Monthly Sales"
			' 
			' pieCategorySales
			' 
			dimension6.DataMember = "Category"
			Me.pieCategorySales.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension6})
			Me.pieCategorySales.ColoringOptions.UseGlobalColors = False
			Me.pieCategorySales.ComponentName = "pieCategorySales"
			measure25.DataMember = "RevenueYTD"
			measure25.Name = "Revenue"
			Me.pieCategorySales.DataItemRepository.Clear()
			Me.pieCategorySales.DataItemRepository.Add(measure25, "DataItem0")
			Me.pieCategorySales.DataItemRepository.Add(dimension6, "DataItem2")
			Me.pieCategorySales.DataSource = Me.dsTotalSales
			Me.pieCategorySales.InteractivityOptions.IgnoreMasterFilters = False
			Me.pieCategorySales.LabelContentType = DevExpress.DashboardCommon.PieValueType.Argument
			Me.pieCategorySales.Name = "Product Categories - YTD Sales"
			Me.pieCategorySales.ShowCaption = True
			Me.pieCategorySales.Values.AddRange(New DevExpress.DashboardCommon.Measure() { measure25})
			' 
			' SalesPerformance
			' 
			Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() { Me.dsMonthlySales, Me.dsTotalSales, Me.dsKeyMetrics})
			Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() { Me.gridProductSales, Me.cardKeyMetrics, Me.pieCategorySales, Me.chartProductMonthlySales, Me.choroplethMapDashboardItem1})
			dashboardLayoutItem1.DashboardItem = Me.choroplethMapDashboardItem1
			dashboardLayoutItem1.Weight = 33.796791443850267R
			dashboardLayoutItem2.DashboardItem = Me.gridProductSales
			dashboardLayoutItem2.Weight = 66.203208556149733R
			dashboardLayoutGroup2.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem1, dashboardLayoutItem2})
			dashboardLayoutGroup2.DashboardItem = Nothing
			dashboardLayoutGroup2.Weight = 50.085470085470085R
			dashboardLayoutItem3.DashboardItem = Me.cardKeyMetrics
			dashboardLayoutItem3.Weight = 33.796791443850267R
			dashboardLayoutItem4.DashboardItem = Me.chartProductMonthlySales
			dashboardLayoutItem4.Weight = 41.1764705882353R
			dashboardLayoutItem5.DashboardItem = Me.pieCategorySales
			dashboardLayoutItem5.Weight = 25.026737967914439R
			dashboardLayoutGroup3.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem3, dashboardLayoutItem4, dashboardLayoutItem5})
			dashboardLayoutGroup3.DashboardItem = Nothing
			dashboardLayoutGroup3.Weight = 49.914529914529915R
			dashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutGroup2, dashboardLayoutGroup3})
			dashboardLayoutGroup1.DashboardItem = Nothing
			dashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
			Me.LayoutRoot = dashboardLayoutGroup1
			Me.Title.Text = "Sales Performance"
'			Me.DataLoading += New DevExpress.DashboardCommon.DashboardDataLoadingEventHandler(Me.SalesPerformance_DataLoading);
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
			CType(dimension3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure8, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure9, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure10, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure12, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridProductSales, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure13, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure14, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure15, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure16, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure17, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure18, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure19, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure20, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure21, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure22, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure23, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cardKeyMetrics, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dsKeyMetrics, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure24, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartProductMonthlySales, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dsMonthlySales, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure25, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pieCategorySales, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private gridProductSales As DevExpress.DashboardCommon.GridDashboardItem
		Private cardKeyMetrics As DevExpress.DashboardCommon.CardDashboardItem
		Private chartProductMonthlySales As DevExpress.DashboardCommon.ChartDashboardItem
		Private pieCategorySales As DevExpress.DashboardCommon.PieDashboardItem
		Private choroplethMapDashboardItem1 As DevExpress.DashboardCommon.ChoroplethMapDashboardItem
		Private dsTotalSales As DevExpress.DashboardCommon.DashboardObjectDataSource
		Private dsKeyMetrics As DevExpress.DashboardCommon.DashboardObjectDataSource
		Private dsMonthlySales As DevExpress.DashboardCommon.DashboardObjectDataSource
	End Class
End Namespace

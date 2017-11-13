Imports Microsoft.VisualBasic
Imports System
Namespace DashboardMainDemo.Dashboards
	Partial Public Class RevenueAnalysis
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
			Dim chartPane1 As New DevExpress.DashboardCommon.ChartPane()
			Dim simpleSeries1 As New DevExpress.DashboardCommon.SimpleSeries()
			Dim dimension2 As New DevExpress.DashboardCommon.Dimension()
			Dim measure2 As New DevExpress.DashboardCommon.Measure()
			Dim measure3 As New DevExpress.DashboardCommon.Measure()
			Dim dimension3 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension4 As New DevExpress.DashboardCommon.Dimension()
			Dim measure4 As New DevExpress.DashboardCommon.Measure()
			Dim dimension5 As New DevExpress.DashboardCommon.Dimension()
			Dim measure5 As New DevExpress.DashboardCommon.Measure()
			Dim pivotItemFormatRule1 As New DevExpress.DashboardCommon.PivotItemFormatRule()
			Dim formatConditionTopBottom1 As New DevExpress.DashboardCommon.FormatConditionTopBottom()
			Dim iconSettings1 As New DevExpress.DashboardCommon.IconSettings()
			Dim pivotItemFormatRule2 As New DevExpress.DashboardCommon.PivotItemFormatRule()
			Dim formatConditionTopBottom2 As New DevExpress.DashboardCommon.FormatConditionTopBottom()
			Dim appearanceSettings1 As New DevExpress.DashboardCommon.AppearanceSettings()
			Dim pivotItemFormatRule3 As New DevExpress.DashboardCommon.PivotItemFormatRule()
			Dim formatConditionTopBottom3 As New DevExpress.DashboardCommon.FormatConditionTopBottom()
			Dim iconSettings2 As New DevExpress.DashboardCommon.IconSettings()
			Dim pivotItemFormatRule4 As New DevExpress.DashboardCommon.PivotItemFormatRule()
			Dim formatConditionTopBottom4 As New DevExpress.DashboardCommon.FormatConditionTopBottom()
			Dim appearanceSettings2 As New DevExpress.DashboardCommon.AppearanceSettings()
			Dim pivotItemFormatRule5 As New DevExpress.DashboardCommon.PivotItemFormatRule()
			Dim formatConditionRangeGradient1 As New DevExpress.DashboardCommon.FormatConditionRangeGradient()
			Dim rangeInfo1 As New DevExpress.DashboardCommon.RangeInfo()
			Dim appearanceSettings3 As New DevExpress.DashboardCommon.AppearanceSettings()
			Dim rangeInfo2 As New DevExpress.DashboardCommon.RangeInfo()
			Dim rangeInfo3 As New DevExpress.DashboardCommon.RangeInfo()
			Dim rangeInfo4 As New DevExpress.DashboardCommon.RangeInfo()
			Dim rangeInfo5 As New DevExpress.DashboardCommon.RangeInfo()
			Dim rangeInfo6 As New DevExpress.DashboardCommon.RangeInfo()
			Dim rangeInfo7 As New DevExpress.DashboardCommon.RangeInfo()
			Dim rangeInfo8 As New DevExpress.DashboardCommon.RangeInfo()
			Dim rangeInfo9 As New DevExpress.DashboardCommon.RangeInfo()
			Dim rangeInfo10 As New DevExpress.DashboardCommon.RangeInfo()
			Dim appearanceSettings4 As New DevExpress.DashboardCommon.AppearanceSettings()
			Dim pivotItemFormatRule6 As New DevExpress.DashboardCommon.PivotItemFormatRule()
			Dim formatConditionRangeGradient2 As New DevExpress.DashboardCommon.FormatConditionRangeGradient()
			Dim rangeInfo11 As New DevExpress.DashboardCommon.RangeInfo()
			Dim appearanceSettings5 As New DevExpress.DashboardCommon.AppearanceSettings()
			Dim rangeInfo12 As New DevExpress.DashboardCommon.RangeInfo()
			Dim rangeInfo13 As New DevExpress.DashboardCommon.RangeInfo()
			Dim rangeInfo14 As New DevExpress.DashboardCommon.RangeInfo()
			Dim rangeInfo15 As New DevExpress.DashboardCommon.RangeInfo()
			Dim rangeInfo16 As New DevExpress.DashboardCommon.RangeInfo()
			Dim rangeInfo17 As New DevExpress.DashboardCommon.RangeInfo()
			Dim rangeInfo18 As New DevExpress.DashboardCommon.RangeInfo()
			Dim rangeInfo19 As New DevExpress.DashboardCommon.RangeInfo()
			Dim rangeInfo20 As New DevExpress.DashboardCommon.RangeInfo()
			Dim appearanceSettings6 As New DevExpress.DashboardCommon.AppearanceSettings()
			Dim pivotItemFormatRule7 As New DevExpress.DashboardCommon.PivotItemFormatRule()
			Dim formatConditionRangeGradient3 As New DevExpress.DashboardCommon.FormatConditionRangeGradient()
			Dim rangeInfo21 As New DevExpress.DashboardCommon.RangeInfo()
			Dim appearanceSettings7 As New DevExpress.DashboardCommon.AppearanceSettings()
			Dim rangeInfo22 As New DevExpress.DashboardCommon.RangeInfo()
			Dim rangeInfo23 As New DevExpress.DashboardCommon.RangeInfo()
			Dim rangeInfo24 As New DevExpress.DashboardCommon.RangeInfo()
			Dim rangeInfo25 As New DevExpress.DashboardCommon.RangeInfo()
			Dim rangeInfo26 As New DevExpress.DashboardCommon.RangeInfo()
			Dim rangeInfo27 As New DevExpress.DashboardCommon.RangeInfo()
			Dim rangeInfo28 As New DevExpress.DashboardCommon.RangeInfo()
			Dim rangeInfo29 As New DevExpress.DashboardCommon.RangeInfo()
			Dim rangeInfo30 As New DevExpress.DashboardCommon.RangeInfo()
			Dim appearanceSettings8 As New DevExpress.DashboardCommon.AppearanceSettings()
			Dim dashboardLayoutGroup1 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutGroup2 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutItem1 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem2 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem3 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Me.chartSalesbyYear = New DevExpress.DashboardCommon.ChartDashboardItem()
			Me.dsSales = New DevExpress.DashboardCommon.DashboardObjectDataSource()
			Me.pieSalesbyCategory = New DevExpress.DashboardCommon.PieDashboardItem()
			Me.pivotSalesByState = New DevExpress.DashboardCommon.PivotDashboardItem()
			CType(Me.chartSalesbyYear, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dsSales, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pieSalesbyCategory, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pivotSalesByState, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' chartSalesbyYear
			' 
			dimension1.DataMember = "Year"
			dimension1.IsDiscreteNumericScale = True
			dimension1.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.General
			Me.chartSalesbyYear.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension1})
			Me.chartSalesbyYear.AxisX.TitleVisible = False
			Me.chartSalesbyYear.ComponentName = "chartSalesbyYear"
			measure1.DataMember = "Revenue"
			Me.chartSalesbyYear.DataItemRepository.Clear()
			Me.chartSalesbyYear.DataItemRepository.Add(measure1, "DataItem0")
			Me.chartSalesbyYear.DataItemRepository.Add(dimension1, "DataItem1")
			Me.chartSalesbyYear.DataSource = Me.dsSales
			Me.chartSalesbyYear.InteractivityOptions.IgnoreMasterFilters = True
			Me.chartSalesbyYear.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Multiple
			Me.chartSalesbyYear.Legend.Visible = False
			Me.chartSalesbyYear.Name = "Sales by Year"
			chartPane1.Name = "Pane 1"
			chartPane1.PrimaryAxisY.AlwaysShowZeroLevel = False
			chartPane1.PrimaryAxisY.ShowGridLines = True
			chartPane1.PrimaryAxisY.Title = "Revenue "
			chartPane1.PrimaryAxisY.TitleVisible = True
			chartPane1.SecondaryAxisY.ShowGridLines = False
			chartPane1.SecondaryAxisY.TitleVisible = True
			simpleSeries1.Name = "Revenue (Sum)"
			simpleSeries1.AddDataItem("Value", measure1)
			chartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() { simpleSeries1})
			Me.chartSalesbyYear.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() { chartPane1})
			Me.chartSalesbyYear.ShowCaption = False
			' 
			' dsSales
			' 
			Me.dsSales.ComponentName = "dsSales"
			Me.dsSales.DataSource = GetType(DashboardMainDemo.RevenueAnalysisDataGenerator.DataItem)
			Me.dsSales.Name = "Sales"
			' 
			' pieSalesbyCategory
			' 
			dimension2.DataMember = "Category"
			Me.pieSalesbyCategory.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension2})
			Me.pieSalesbyCategory.ComponentName = "pieSalesbyCategory"
			measure2.DataMember = "Revenue"
			measure2.Name = "Revenue"
			measure3.DataMember = "UnitsSold"
			measure3.Name = "Units Sold"
			Me.pieSalesbyCategory.DataItemRepository.Clear()
			Me.pieSalesbyCategory.DataItemRepository.Add(measure2, "DataItem0")
			Me.pieSalesbyCategory.DataItemRepository.Add(dimension2, "DataItem1")
			Me.pieSalesbyCategory.DataItemRepository.Add(measure3, "DataItem2")
			Me.pieSalesbyCategory.DataSource = Me.dsSales
			Me.pieSalesbyCategory.InteractivityOptions.IgnoreMasterFilters = False
			Me.pieSalesbyCategory.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Multiple
			Me.pieSalesbyCategory.LabelContentType = DevExpress.DashboardCommon.PieValueType.Argument
			Me.pieSalesbyCategory.Name = "Sales by Category"
			Me.pieSalesbyCategory.ShowCaption = False
			Me.pieSalesbyCategory.Values.AddRange(New DevExpress.DashboardCommon.Measure() { measure2, measure3})
			' 
			' pivotSalesByState
			' 
			dimension3.DataMember = "Category"
			dimension4.DataMember = "Product"
			dimension4.TopNOptions.ShowOthers = True
			Me.pivotSalesByState.Columns.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension3, dimension4})
			Me.pivotSalesByState.ComponentName = "pivotSalesByState"
			measure4.DataMember = "UnitsSold"
			measure4.Name = "Units Sold"
			dimension5.DataMember = "State"
			measure5.DataMember = "Revenue"
			measure5.Name = "Revenue"
			Me.pivotSalesByState.DataItemRepository.Clear()
			Me.pivotSalesByState.DataItemRepository.Add(measure4, "DataItem1")
			Me.pivotSalesByState.DataItemRepository.Add(dimension4, "DataItem0")
			Me.pivotSalesByState.DataItemRepository.Add(dimension5, "DataItem4")
			Me.pivotSalesByState.DataItemRepository.Add(dimension3, "DataItem3")
			Me.pivotSalesByState.DataItemRepository.Add(measure5, "DataItem2")
			Me.pivotSalesByState.DataSource = Me.dsSales
			formatConditionTopBottom1.Rank = New Decimal(New Integer() { 20, 0, 0, 0})
			formatConditionTopBottom1.RankType = DevExpress.DashboardCommon.DashboardFormatConditionValueType.Percent
			iconSettings1.IconType = DevExpress.DashboardCommon.FormatConditionIconType.RatingFullGrayStar
			formatConditionTopBottom1.StyleSettings = iconSettings1
			pivotItemFormatRule1.Condition = formatConditionTopBottom1
			pivotItemFormatRule1.DataItem = measure5
			pivotItemFormatRule1.DataItemApplyTo = dimension5
			pivotItemFormatRule1.IntersectionLevelMode = DevExpress.DashboardCommon.FormatConditionIntersectionLevelMode.SpecificLevel
			pivotItemFormatRule1.Level.Row = dimension5
			formatConditionTopBottom2.Rank = New Decimal(New Integer() { 20, 0, 0, 0})
			formatConditionTopBottom2.RankType = DevExpress.DashboardCommon.DashboardFormatConditionValueType.Percent
			appearanceSettings1.AppearanceType = DevExpress.DashboardCommon.FormatConditionAppearanceType.FontBold
			formatConditionTopBottom2.StyleSettings = appearanceSettings1
			pivotItemFormatRule2.Condition = formatConditionTopBottom2
			pivotItemFormatRule2.DataItem = measure5
			pivotItemFormatRule2.DataItemApplyTo = dimension5
			pivotItemFormatRule2.IntersectionLevelMode = DevExpress.DashboardCommon.FormatConditionIntersectionLevelMode.SpecificLevel
			pivotItemFormatRule2.Level.Row = dimension5
			formatConditionTopBottom3.Rank = New Decimal(New Integer() { 1, 0, 0, 0})
			iconSettings2.IconType = DevExpress.DashboardCommon.FormatConditionIconType.RatingFullGrayStar
			formatConditionTopBottom3.StyleSettings = iconSettings2
			pivotItemFormatRule3.Condition = formatConditionTopBottom3
			pivotItemFormatRule3.DataItem = measure5
			pivotItemFormatRule3.DataItemApplyTo = dimension3
			pivotItemFormatRule3.IntersectionLevelMode = DevExpress.DashboardCommon.FormatConditionIntersectionLevelMode.SpecificLevel
			pivotItemFormatRule3.Level.Column = dimension3
			formatConditionTopBottom4.Rank = New Decimal(New Integer() { 1, 0, 0, 0})
			appearanceSettings2.AppearanceType = DevExpress.DashboardCommon.FormatConditionAppearanceType.FontBold
			formatConditionTopBottom4.StyleSettings = appearanceSettings2
			pivotItemFormatRule4.Condition = formatConditionTopBottom4
			pivotItemFormatRule4.DataItem = measure5
			pivotItemFormatRule4.DataItemApplyTo = dimension3
			pivotItemFormatRule4.IntersectionLevelMode = DevExpress.DashboardCommon.FormatConditionIntersectionLevelMode.SpecificLevel
			pivotItemFormatRule4.Level.Column = dimension3
			appearanceSettings3.AppearanceType = DevExpress.DashboardCommon.FormatConditionAppearanceType.GradientTransparent
			rangeInfo1.StyleSettings = appearanceSettings3
			rangeInfo1.Value = 0
			rangeInfo2.Value = 100000
			rangeInfo3.Value = 120000
			rangeInfo4.Value = 150000
			rangeInfo5.Value = 200000
			rangeInfo6.Value = 1000000
			rangeInfo7.Value = 3000000
			rangeInfo8.Value = 5000000
			rangeInfo9.Value = 6000000
			appearanceSettings4.AppearanceType = DevExpress.DashboardCommon.FormatConditionAppearanceType.GradientBlue
			rangeInfo10.StyleSettings = appearanceSettings4
			rangeInfo10.Value = 9000000
			formatConditionRangeGradient1.RangeSet.AddRange(New DevExpress.DashboardCommon.RangeInfo() { rangeInfo1, rangeInfo2, rangeInfo3, rangeInfo4, rangeInfo5, rangeInfo6, rangeInfo7, rangeInfo8, rangeInfo9, rangeInfo10})
			formatConditionRangeGradient1.ValueType = DevExpress.DashboardCommon.DashboardFormatConditionValueType.Number
			pivotItemFormatRule5.Condition = formatConditionRangeGradient1
			pivotItemFormatRule5.DataItem = measure5
			pivotItemFormatRule5.IntersectionLevelMode = DevExpress.DashboardCommon.FormatConditionIntersectionLevelMode.FirstLevel
			pivotItemFormatRule5.Level.Column = dimension3
			pivotItemFormatRule5.Level.Row = dimension5
			appearanceSettings5.AppearanceType = DevExpress.DashboardCommon.FormatConditionAppearanceType.GradientTransparent
			rangeInfo11.StyleSettings = appearanceSettings5
			rangeInfo11.Value = 0
			rangeInfo12.Value = 1000
			rangeInfo13.Value = 2000
			rangeInfo14.Value = 3000
			rangeInfo15.Value = 5000
			rangeInfo16.Value = 10000
			rangeInfo17.Value = 30000
			rangeInfo18.Value = 50000
			rangeInfo19.Value = 100000
			appearanceSettings6.AppearanceType = DevExpress.DashboardCommon.FormatConditionAppearanceType.GradientGreen
			rangeInfo20.StyleSettings = appearanceSettings6
			rangeInfo20.Value = 200000
			formatConditionRangeGradient2.RangeSet.AddRange(New DevExpress.DashboardCommon.RangeInfo() { rangeInfo11, rangeInfo12, rangeInfo13, rangeInfo14, rangeInfo15, rangeInfo16, rangeInfo17, rangeInfo18, rangeInfo19, rangeInfo20})
			formatConditionRangeGradient2.ValueType = DevExpress.DashboardCommon.DashboardFormatConditionValueType.Number
			pivotItemFormatRule6.Condition = formatConditionRangeGradient2
			pivotItemFormatRule6.DataItem = measure5
			pivotItemFormatRule6.IntersectionLevelMode = DevExpress.DashboardCommon.FormatConditionIntersectionLevelMode.LastLevel
			pivotItemFormatRule6.Level.Column = dimension4
			pivotItemFormatRule6.Level.Row = dimension5
			appearanceSettings7.AppearanceType = DevExpress.DashboardCommon.FormatConditionAppearanceType.GradientTransparent
			rangeInfo21.StyleSettings = appearanceSettings7
			rangeInfo21.Value = 0
			rangeInfo22.Value = 9000000
			rangeInfo23.Value = 9400000
			rangeInfo24.Value = 9500000
			rangeInfo25.Value = 9600000
			rangeInfo26.Value = 9700000
			rangeInfo27.Value = 9800000
			rangeInfo28.Value = 9900000
			rangeInfo29.Value = 10000000
			appearanceSettings8.AppearanceType = DevExpress.DashboardCommon.FormatConditionAppearanceType.GradientOrange
			rangeInfo30.StyleSettings = appearanceSettings8
			rangeInfo30.Value = 15000000
			formatConditionRangeGradient3.RangeSet.AddRange(New DevExpress.DashboardCommon.RangeInfo() { rangeInfo21, rangeInfo22, rangeInfo23, rangeInfo24, rangeInfo25, rangeInfo26, rangeInfo27, rangeInfo28, rangeInfo29, rangeInfo30})
			formatConditionRangeGradient3.ValueType = DevExpress.DashboardCommon.DashboardFormatConditionValueType.Number
			pivotItemFormatRule7.Condition = formatConditionRangeGradient3
			pivotItemFormatRule7.DataItem = measure5
			pivotItemFormatRule7.IntersectionLevelMode = DevExpress.DashboardCommon.FormatConditionIntersectionLevelMode.SpecificLevel
			pivotItemFormatRule7.Level.Row = dimension5
			Me.pivotSalesByState.FormatRules.AddRange(New DevExpress.DashboardCommon.PivotItemFormatRule() { pivotItemFormatRule1, pivotItemFormatRule2, pivotItemFormatRule3, pivotItemFormatRule4, pivotItemFormatRule5, pivotItemFormatRule6, pivotItemFormatRule7})
			Me.pivotSalesByState.InteractivityOptions.IgnoreMasterFilters = False
			Me.pivotSalesByState.Name = "Sales by State"
			Me.pivotSalesByState.Rows.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension5})
			Me.pivotSalesByState.ShowCaption = True
			Me.pivotSalesByState.Values.AddRange(New DevExpress.DashboardCommon.Measure() { measure5, measure4})
			' 
			' RevenueAnalysis
			' 
			Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() { Me.dsSales})
			Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() { Me.pivotSalesByState, Me.pieSalesbyCategory, Me.chartSalesbyYear})
			dashboardLayoutItem1.DashboardItem = Me.chartSalesbyYear
			dashboardLayoutItem1.Weight = 44.077669902912625R
			dashboardLayoutItem2.DashboardItem = Me.pieSalesbyCategory
			dashboardLayoutItem2.Weight = 55.922330097087375R
			dashboardLayoutGroup2.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem1, dashboardLayoutItem2})
			dashboardLayoutGroup2.DashboardItem = Nothing
			dashboardLayoutGroup2.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
			dashboardLayoutGroup2.Weight = 23.957409050576754R
			dashboardLayoutItem3.DashboardItem = Me.pivotSalesByState
			dashboardLayoutItem3.Weight = 76.042590949423243R
			dashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutGroup2, dashboardLayoutItem3})
			dashboardLayoutGroup1.DashboardItem = Nothing
			Me.LayoutRoot = dashboardLayoutGroup1
			Me.Title.Text = "Revenue Analysis"
'			Me.DataLoading += New DevExpress.DashboardCommon.DashboardDataLoadingEventHandler(Me.RevenueAnalysis_DataLoading);
			CType(dimension1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartSalesbyYear, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dsSales, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pieSalesbyCategory, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pivotSalesByState, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private pivotSalesByState As DevExpress.DashboardCommon.PivotDashboardItem
		Private pieSalesbyCategory As DevExpress.DashboardCommon.PieDashboardItem
		Private chartSalesbyYear As DevExpress.DashboardCommon.ChartDashboardItem
		Private dsSales As DevExpress.DashboardCommon.DashboardObjectDataSource
	End Class
End Namespace

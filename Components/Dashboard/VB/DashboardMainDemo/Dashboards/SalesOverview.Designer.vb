Imports Microsoft.VisualBasic
Imports System
Namespace DashboardMainDemo.Dashboards
	Partial Public Class SalesOverview
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
			Dim measure1 As New DevExpress.DashboardCommon.Measure()
			Dim gridSparklineColumn1 As New DevExpress.DashboardCommon.GridSparklineColumn()
			Dim dimension1 As New DevExpress.DashboardCommon.Dimension()
			Dim measure2 As New DevExpress.DashboardCommon.Measure()
			Dim gridDimensionColumn1 As New DevExpress.DashboardCommon.GridDimensionColumn()
			Dim measure3 As New DevExpress.DashboardCommon.Measure()
			Dim gridMeasureColumn1 As New DevExpress.DashboardCommon.GridMeasureColumn()
			Dim gridColumnTotal1 As New DevExpress.DashboardCommon.GridColumnTotal()
			Dim measure4 As New DevExpress.DashboardCommon.Measure()
			Dim gridDeltaColumn1 As New DevExpress.DashboardCommon.GridDeltaColumn()
			Dim dimension2 As New DevExpress.DashboardCommon.Dimension()
			Dim gridItemFormatRule1 As New DevExpress.DashboardCommon.GridItemFormatRule()
			Dim formatConditionBar1 As New DevExpress.DashboardCommon.FormatConditionBar()
			Dim dimension3 As New DevExpress.DashboardCommon.Dimension()
			Dim measure5 As New DevExpress.DashboardCommon.Measure()
			Dim dimension4 As New DevExpress.DashboardCommon.Dimension()
			Dim chartPane1 As New DevExpress.DashboardCommon.ChartPane()
			Dim simpleSeries1 As New DevExpress.DashboardCommon.SimpleSeries()
			Dim measure6 As New DevExpress.DashboardCommon.Measure()
			Dim measure7 As New DevExpress.DashboardCommon.Measure()
			Dim dimension5 As New DevExpress.DashboardCommon.Dimension()
			Dim gauge1 As New DevExpress.DashboardCommon.Gauge()
			Dim dimension6 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension7 As New DevExpress.DashboardCommon.Dimension()
			Dim measure8 As New DevExpress.DashboardCommon.Measure()
			Dim dateTimePeriod1 As New DevExpress.DashboardCommon.DateTimePeriod()
			Dim flowDateTimePeriodLimit1 As New DevExpress.DashboardCommon.FlowDateTimePeriodLimit()
			Dim dateTimePeriod2 As New DevExpress.DashboardCommon.DateTimePeriod()
			Dim flowDateTimePeriodLimit2 As New DevExpress.DashboardCommon.FlowDateTimePeriodLimit()
			Dim dateTimePeriod3 As New DevExpress.DashboardCommon.DateTimePeriod()
			Dim flowDateTimePeriodLimit3 As New DevExpress.DashboardCommon.FlowDateTimePeriodLimit()
			Dim flowDateTimePeriodLimit4 As New DevExpress.DashboardCommon.FlowDateTimePeriodLimit()
			Dim dateTimePeriod4 As New DevExpress.DashboardCommon.DateTimePeriod()
			Dim flowDateTimePeriodLimit5 As New DevExpress.DashboardCommon.FlowDateTimePeriodLimit()
			Dim flowDateTimePeriodLimit6 As New DevExpress.DashboardCommon.FlowDateTimePeriodLimit()
			Dim simpleSeries2 As New DevExpress.DashboardCommon.SimpleSeries()
			Dim dashboardLayoutGroup1 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutGroup2 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutItem1 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem2 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem3 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem4 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Me.gridSalesByState = New DevExpress.DashboardCommon.GridDashboardItem()
			Me.dsSales = New DevExpress.DashboardCommon.DashboardObjectDataSource()
			Me.chartSalesByCategory = New DevExpress.DashboardCommon.ChartDashboardItem()
			Me.gaugeSalesVsTargetByCategory = New DevExpress.DashboardCommon.GaugeDashboardItem()
			Me.range = New DevExpress.DashboardCommon.RangeFilterDashboardItem()
			CType(Me.gridSalesByState, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dsSales, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chartSalesByCategory, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gaugeSalesVsTargetByCategory, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.range, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure8, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' gridSalesByState
			' 
			measure1.DataMember = "Sales"
			gridSparklineColumn1.FixedWidth = 14.32R
			gridSparklineColumn1.Name = "Trend"
			gridSparklineColumn1.SparklineOptions.HighlightStartEndPoints = False
			gridSparklineColumn1.Weight = 150.68493150684932R
			gridSparklineColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.FixedWidth
			gridSparklineColumn1.AddDataItem("SparklineValue", measure1)
			dimension1.DataMember = "State"
			measure2.DataMember = "Sales"
			dimension1.SortByMeasure = measure2
			dimension1.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending
			gridDimensionColumn1.FixedWidth = 14.16R
			gridDimensionColumn1.Name = "State"
			gridDimensionColumn1.Weight = 44.520547945205479R
			gridDimensionColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.FixedWidth
			gridDimensionColumn1.AddDataItem("Dimension", dimension1)
			measure3.DataMember = "Sales"
			gridMeasureColumn1.FixedWidth = 20.98R
			gridMeasureColumn1.Name = "Sales"
			gridColumnTotal1.TotalType = DevExpress.DashboardCommon.GridColumnTotalType.Sum
			gridMeasureColumn1.Totals.AddRange(New DevExpress.DashboardCommon.GridColumnTotal() { gridColumnTotal1})
			gridMeasureColumn1.Weight = 43.664383561643838R
			gridMeasureColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.FixedWidth
			gridMeasureColumn1.AddDataItem("Measure", measure3)
			measure4.DataMember = "SalesTarget"
			gridDeltaColumn1.DeltaOptions.ResultIndicationThreshold = New Decimal(New Integer() { 3, 0, 0, 65536})
			gridDeltaColumn1.DeltaOptions.ValueType = DevExpress.DashboardCommon.DeltaValueType.PercentVariation
			gridDeltaColumn1.FixedWidth = 15.15R
			gridDeltaColumn1.Name = "Sales vs Target"
			gridDeltaColumn1.Weight = 92.465753424657535R
			gridDeltaColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.FixedWidth
			gridDeltaColumn1.AddDataItem("ActualValue", measure2)
			gridDeltaColumn1.AddDataItem("TargetValue", measure4)
			Me.gridSalesByState.Columns.AddRange(New DevExpress.DashboardCommon.GridColumnBase() { gridSparklineColumn1, gridDimensionColumn1, gridMeasureColumn1, gridDeltaColumn1})
			Me.gridSalesByState.ComponentName = "gridSalesByState"
			dimension2.DataMember = "CurrentDate"
			dimension2.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear
			Me.gridSalesByState.DataItemRepository.Clear()
			Me.gridSalesByState.DataItemRepository.Add(measure4, "DataItem5")
			Me.gridSalesByState.DataItemRepository.Add(measure2, "DataItem4")
			Me.gridSalesByState.DataItemRepository.Add(measure3, "DataItem3")
			Me.gridSalesByState.DataItemRepository.Add(dimension1, "DataItem1")
			Me.gridSalesByState.DataItemRepository.Add(measure1, "DataItem0")
			Me.gridSalesByState.DataItemRepository.Add(dimension2, "DataItem6")
			Me.gridSalesByState.DataSource = Me.dsSales
			formatConditionBar1.NegativeStyleSettings.PredefinedColor = DevExpress.DashboardCommon.FormatConditionAppearanceType.PaleRed
			formatConditionBar1.StyleSettings.PredefinedColor = DevExpress.DashboardCommon.FormatConditionAppearanceType.PaleGreen
			gridItemFormatRule1.Condition = formatConditionBar1
			gridItemFormatRule1.DataItem = measure3
			gridItemFormatRule1.Name = "FormatRule 1"
			Me.gridSalesByState.FormatRules.AddRange(New DevExpress.DashboardCommon.GridItemFormatRule() { gridItemFormatRule1})
			Me.gridSalesByState.GridOptions.ColumnWidthMode = DevExpress.DashboardCommon.GridColumnWidthMode.Manual
			Me.gridSalesByState.GridOptions.ShowVerticalLines = False
			Me.gridSalesByState.InteractivityOptions.IgnoreMasterFilters = False
			Me.gridSalesByState.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Multiple
			Me.gridSalesByState.Name = "Sales by State"
			Me.gridSalesByState.ShowCaption = True
			Me.gridSalesByState.SparklineArgument = dimension2
			' 
			' dsSales
			' 
			Me.dsSales.ComponentName = "dsSales"
			Me.dsSales.DataSource = GetType(DashboardMainDemo.SalesOverviewDataGenerator.DataItem)
			Me.dsSales.Name = "Sales"
			' 
			' chartSalesByCategory
			' 
			dimension3.DataMember = "CurrentDate"
			dimension3.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.DayMonthYear
			Me.chartSalesByCategory.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension3})
			Me.chartSalesByCategory.AxisX.TitleVisible = False
			Me.chartSalesByCategory.ComponentName = "chartSalesByCategory"
			measure5.DataMember = "Sales"
			dimension4.DataMember = "Category"
			Me.chartSalesByCategory.DataItemRepository.Clear()
			Me.chartSalesByCategory.DataItemRepository.Add(measure5, "DataItem1")
			Me.chartSalesByCategory.DataItemRepository.Add(dimension3, "DataItem2")
			Me.chartSalesByCategory.DataItemRepository.Add(dimension4, "DataItem3")
			Me.chartSalesByCategory.DataSource = Me.dsSales
			Me.chartSalesByCategory.InteractivityOptions.IgnoreMasterFilters = False
			Me.chartSalesByCategory.Name = "Sales by Product Category"
			chartPane1.Name = "Pane 1"
			chartPane1.PrimaryAxisY.AlwaysShowZeroLevel = False
			chartPane1.PrimaryAxisY.Logarithmic = True
			chartPane1.PrimaryAxisY.ShowGridLines = True
			chartPane1.PrimaryAxisY.Title = "Sales"
			chartPane1.PrimaryAxisY.TitleVisible = False
			chartPane1.SecondaryAxisY.AlwaysShowZeroLevel = True
			chartPane1.SecondaryAxisY.ShowGridLines = False
			chartPane1.SecondaryAxisY.TitleVisible = True
			simpleSeries1.Name = "Sales (Sum)"
			simpleSeries1.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.Line
			simpleSeries1.AddDataItem("Value", measure5)
			chartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() { simpleSeries1})
			Me.chartSalesByCategory.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() { chartPane1})
			Me.chartSalesByCategory.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension4})
			Me.chartSalesByCategory.ShowCaption = True
			' 
			' gaugeSalesVsTargetByCategory
			' 
			Me.gaugeSalesVsTargetByCategory.ComponentName = "gaugeSalesVsTargetByCategory"
			Me.gaugeSalesVsTargetByCategory.ContentLineCount = 4
			measure6.DataMember = "Sales"
			measure7.DataMember = "SalesTarget"
			dimension5.DataMember = "Category"
			Me.gaugeSalesVsTargetByCategory.DataItemRepository.Clear()
			Me.gaugeSalesVsTargetByCategory.DataItemRepository.Add(measure6, "DataItem1")
			Me.gaugeSalesVsTargetByCategory.DataItemRepository.Add(measure7, "DataItem2")
			Me.gaugeSalesVsTargetByCategory.DataItemRepository.Add(dimension5, "DataItem3")
			Me.gaugeSalesVsTargetByCategory.DataSource = Me.dsSales
			gauge1.DeltaOptions.ResultIndicationThreshold = New Decimal(New Integer() { 3, 0, 0, 65536})
			gauge1.DeltaOptions.ValueType = DevExpress.DashboardCommon.DeltaValueType.PercentVariation
			gauge1.Name = "Sales (Sum) vs SalesTarget (Sum)"
			gauge1.AddDataItem("ActualValue", measure6)
			gauge1.AddDataItem("TargetValue", measure7)
			Me.gaugeSalesVsTargetByCategory.Gauges.AddRange(New DevExpress.DashboardCommon.Gauge() { gauge1})
			Me.gaugeSalesVsTargetByCategory.InteractivityOptions.IgnoreMasterFilters = False
			Me.gaugeSalesVsTargetByCategory.Name = "Sales vs Target by Product Category"
			Me.gaugeSalesVsTargetByCategory.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension5})
			Me.gaugeSalesVsTargetByCategory.ShowCaption = True
			Me.gaugeSalesVsTargetByCategory.ViewType = DevExpress.DashboardCommon.GaugeViewType.CircularHalf
			' 
			' range
			' 
			dimension6.DataMember = "CurrentDate"
			dimension6.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear
			dimension6.Name = "Date"
			Me.range.Argument = dimension6
			Me.range.ComponentName = "range"
			dimension7.DataMember = "Category"
			measure8.DataMember = "Sales"
			Me.range.DataItemRepository.Clear()
			Me.range.DataItemRepository.Add(dimension6, "DataItem1")
			Me.range.DataItemRepository.Add(dimension7, "DataItem2")
			Me.range.DataItemRepository.Add(measure8, "DataItem0")
			Me.range.DataSource = Me.dsSales
			dateTimePeriod1.Name = "6 Months"
			flowDateTimePeriodLimit1.Interval = DevExpress.DashboardCommon.DateTimeInterval.Month
			flowDateTimePeriodLimit1.Offset = -5
			dateTimePeriod1.Start = flowDateTimePeriodLimit1
			dateTimePeriod2.Name = "12 Months"
			flowDateTimePeriodLimit2.Interval = DevExpress.DashboardCommon.DateTimeInterval.Month
			flowDateTimePeriodLimit2.Offset = -11
			dateTimePeriod2.Start = flowDateTimePeriodLimit2
			dateTimePeriod3.Name = "Quarter to date"
			flowDateTimePeriodLimit3.Interval = DevExpress.DashboardCommon.DateTimeInterval.Day
			dateTimePeriod3.End = flowDateTimePeriodLimit3
			flowDateTimePeriodLimit4.Interval = DevExpress.DashboardCommon.DateTimeInterval.Quarter
			dateTimePeriod3.Start = flowDateTimePeriodLimit4
			dateTimePeriod4.Name = "Year to date"
			flowDateTimePeriodLimit5.Interval = DevExpress.DashboardCommon.DateTimeInterval.Day
			dateTimePeriod4.End = flowDateTimePeriodLimit5
			dateTimePeriod4.Start = flowDateTimePeriodLimit6
			Me.range.DateTimePeriods.AddRange(New DevExpress.DashboardCommon.DateTimePeriod() { dateTimePeriod1, dateTimePeriod2, dateTimePeriod3, dateTimePeriod4})
			Me.range.InteractivityOptions.IgnoreMasterFilters = True
			Me.range.Name = "Sales Period"
			simpleSeries2.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.StackedBar
			simpleSeries2.AddDataItem("Value", measure8)
			Me.range.Series.AddRange(New DevExpress.DashboardCommon.SimpleSeries() { simpleSeries2})
			Me.range.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension7})
			Me.range.ShowCaption = False
			' 
			' SalesOverview
			' 
			Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() { Me.dsSales})
			Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() { Me.range, Me.gridSalesByState, Me.chartSalesByCategory, Me.gaugeSalesVsTargetByCategory})
			dashboardLayoutItem1.DashboardItem = Me.gridSalesByState
			dashboardLayoutItem1.Weight = 37.589784517158819R
			dashboardLayoutItem2.DashboardItem = Me.chartSalesByCategory
			dashboardLayoutItem2.Weight = 40.542697525937747R
			dashboardLayoutItem3.DashboardItem = Me.gaugeSalesVsTargetByCategory
			dashboardLayoutItem3.Weight = 21.867517956903431R
			dashboardLayoutGroup2.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem1, dashboardLayoutItem2, dashboardLayoutItem3})
			dashboardLayoutGroup2.DashboardItem = Nothing
			dashboardLayoutGroup2.Weight = 79.591836734693871R
			dashboardLayoutItem4.DashboardItem = Me.range
			dashboardLayoutItem4.Weight = 20.408163265306122R
			dashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutGroup2, dashboardLayoutItem4})
			dashboardLayoutGroup1.DashboardItem = Nothing
			dashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
			Me.LayoutRoot = dashboardLayoutGroup1
			Me.Title.Text = "Sales Overview"
'			Me.DataLoading += New DevExpress.DashboardCommon.DashboardDataLoadingEventHandler(Me.SalesOverview_DataLoading);
			CType(measure1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridSalesByState, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dsSales, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartSalesByCategory, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gaugeSalesVsTargetByCategory, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure8, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.range, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private range As DevExpress.DashboardCommon.RangeFilterDashboardItem
		Private gridSalesByState As DevExpress.DashboardCommon.GridDashboardItem
		Private chartSalesByCategory As DevExpress.DashboardCommon.ChartDashboardItem
		Private gaugeSalesVsTargetByCategory As DevExpress.DashboardCommon.GaugeDashboardItem
		Private dsSales As DevExpress.DashboardCommon.DashboardObjectDataSource
	End Class
End Namespace

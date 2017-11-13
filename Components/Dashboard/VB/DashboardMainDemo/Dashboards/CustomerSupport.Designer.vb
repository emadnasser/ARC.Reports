Imports Microsoft.VisualBasic
Imports System
Namespace DashboardMainDemo.Dashboards
	Partial Public Class CustomerSupport
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
			Dim dimension2 As New DevExpress.DashboardCommon.Dimension()
			Dim measure1 As New DevExpress.DashboardCommon.Measure()
			Dim chartPane1 As New DevExpress.DashboardCommon.ChartPane()
			Dim simpleSeries1 As New DevExpress.DashboardCommon.SimpleSeries()
			Dim dimension3 As New DevExpress.DashboardCommon.Dimension()
			Dim measure2 As New DevExpress.DashboardCommon.Measure()
			Dim dimension4 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension5 As New DevExpress.DashboardCommon.Dimension()
			Dim measure3 As New DevExpress.DashboardCommon.Measure()
			Dim chartPane2 As New DevExpress.DashboardCommon.ChartPane()
			Dim simpleSeries2 As New DevExpress.DashboardCommon.SimpleSeries()
			Dim dimension6 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension7 As New DevExpress.DashboardCommon.Dimension()
			Dim measure4 As New DevExpress.DashboardCommon.Measure()
			Dim chartPane3 As New DevExpress.DashboardCommon.ChartPane()
			Dim simpleSeries3 As New DevExpress.DashboardCommon.SimpleSeries()
			Dim dimension8 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension9 As New DevExpress.DashboardCommon.Dimension()
			Dim measure5 As New DevExpress.DashboardCommon.Measure()
			Dim dimension10 As New DevExpress.DashboardCommon.Dimension()
			Dim measure6 As New DevExpress.DashboardCommon.Measure()
			Dim chartPane4 As New DevExpress.DashboardCommon.ChartPane()
			Dim simpleSeries4 As New DevExpress.DashboardCommon.SimpleSeries()
			Dim dimension11 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension12 As New DevExpress.DashboardCommon.Dimension()
			Dim measure7 As New DevExpress.DashboardCommon.Measure()
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
			Dim simpleSeries5 As New DevExpress.DashboardCommon.SimpleSeries()
			Dim colorSchemeEntry1 As New DevExpress.DashboardCommon.ColorSchemeEntry()
			Dim dimensionDefinition1 As New DevExpress.DashboardCommon.DimensionDefinition("IssueType")
			Dim colorSchemeDimensionKey1 As New DevExpress.DashboardCommon.ColorSchemeDimensionKey(dimensionDefinition1, "Critical")
			Dim colorSchemeEntry2 As New DevExpress.DashboardCommon.ColorSchemeEntry()
			Dim colorSchemeDimensionKey2 As New DevExpress.DashboardCommon.ColorSchemeDimensionKey(dimensionDefinition1, "Urgent")
			Dim colorSchemeEntry3 As New DevExpress.DashboardCommon.ColorSchemeEntry()
			Dim colorSchemeDimensionKey3 As New DevExpress.DashboardCommon.ColorSchemeDimensionKey(dimensionDefinition1, "Normal")
			Dim colorSchemeEntry4 As New DevExpress.DashboardCommon.ColorSchemeEntry()
			Dim dimensionDefinition2 As New DevExpress.DashboardCommon.DimensionDefinition("Opened")
			Dim colorSchemeDimensionKey4 As New DevExpress.DashboardCommon.ColorSchemeDimensionKey(dimensionDefinition2, 2015)
			Dim colorSchemeEntry5 As New DevExpress.DashboardCommon.ColorSchemeEntry()
			Dim colorSchemeDimensionKey5 As New DevExpress.DashboardCommon.ColorSchemeDimensionKey(dimensionDefinition2, 2016)
			Dim dashboardLayoutGroup1 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutGroup2 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutGroup3 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutItem1 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem2 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutGroup4 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutItem3 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem4 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem5 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Me.dsCustomerSupport = New DevExpress.DashboardCommon.DashboardObjectDataSource()
			Me.chartOpenedIssuesByMonth = New DevExpress.DashboardCommon.ChartDashboardItem()
			Me.chartProcessedIssuesByPlatform = New DevExpress.DashboardCommon.ChartDashboardItem()
			Me.chartAvgResponseTimeByMonth = New DevExpress.DashboardCommon.ChartDashboardItem()
			Me.chartAvgResponseTimeByPlatform = New DevExpress.DashboardCommon.ChartDashboardItem()
			Me.range = New DevExpress.DashboardCommon.RangeFilterDashboardItem()
			CType(Me.dsCustomerSupport, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chartOpenedIssuesByMonth, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chartProcessedIssuesByPlatform, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chartAvgResponseTimeByMonth, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chartAvgResponseTimeByPlatform, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension8, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension9, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension10, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.range, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension12, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' dsCustomerSupport
			' 
			Me.dsCustomerSupport.ComponentName = "dsCustomerSupport"
			Me.dsCustomerSupport.DataSource = GetType(DashboardMainDemo.CustomerSupportData.CustomerSupportItem)
			Me.dsCustomerSupport.Name = "Customer Support"
			' 
			' chartOpenedIssuesByMonth
			' 
			dimension1.DataMember = "Opened"
			dimension1.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.Month
			Me.chartOpenedIssuesByMonth.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension1})
			Me.chartOpenedIssuesByMonth.AxisX.TitleVisible = False
			Me.chartOpenedIssuesByMonth.ComponentName = "chartOpenedIssuesByMonth"
			dimension2.DataMember = "Opened"
			measure1.DataMember = "Opened"
			measure1.SummaryType = DevExpress.DashboardCommon.SummaryType.Count
			Me.chartOpenedIssuesByMonth.DataItemRepository.Clear()
			Me.chartOpenedIssuesByMonth.DataItemRepository.Add(dimension2, "DataItem1")
			Me.chartOpenedIssuesByMonth.DataItemRepository.Add(dimension1, "DataItem2")
			Me.chartOpenedIssuesByMonth.DataItemRepository.Add(measure1, "DataItem3")
			Me.chartOpenedIssuesByMonth.DataSource = Me.dsCustomerSupport
			Me.chartOpenedIssuesByMonth.InteractivityOptions.IgnoreMasterFilters = True
			Me.chartOpenedIssuesByMonth.Name = "Opened Issues by Month"
			chartPane1.Name = "Pane 1"
			chartPane1.PrimaryAxisY.AlwaysShowZeroLevel = True
			chartPane1.PrimaryAxisY.ShowGridLines = True
			chartPane1.PrimaryAxisY.Title = "Opened (Count)"
			chartPane1.PrimaryAxisY.TitleVisible = False
			chartPane1.SecondaryAxisY.AlwaysShowZeroLevel = True
			chartPane1.SecondaryAxisY.ShowGridLines = False
			chartPane1.SecondaryAxisY.TitleVisible = True
			simpleSeries1.Name = "Opened (Count)"
			simpleSeries1.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.Line
			simpleSeries1.AddDataItem("Value", measure1)
			chartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() { simpleSeries1})
			Me.chartOpenedIssuesByMonth.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() { chartPane1})
			Me.chartOpenedIssuesByMonth.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension2})
			Me.chartOpenedIssuesByMonth.ShowCaption = True
			' 
			' chartProcessedIssuesByPlatform
			' 
			dimension3.DataMember = "ProductName"
			measure2.DataMember = "Opened"
			measure2.SummaryType = DevExpress.DashboardCommon.SummaryType.Count
			dimension3.SortByMeasure = measure2
			dimension3.TopNOptions.Count = 3
			dimension3.TopNOptions.Measure = measure2
			dimension4.DataMember = "Employee"
			dimension4.SortByMeasure = measure2
			Me.chartProcessedIssuesByPlatform.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension3, dimension4})
			Me.chartProcessedIssuesByPlatform.AxisX.TitleVisible = False
			Me.chartProcessedIssuesByPlatform.ComponentName = "chartProcessedIssuesByPlatform"
			dimension5.DataMember = "IssueType"
			measure3.DataMember = "IssueTypeIndex"
			dimension5.SortByMeasure = measure3
			Me.chartProcessedIssuesByPlatform.DataItemRepository.Clear()
			Me.chartProcessedIssuesByPlatform.DataItemRepository.Add(dimension5, "DataItem0")
			Me.chartProcessedIssuesByPlatform.DataItemRepository.Add(measure2, "DataItem1")
			Me.chartProcessedIssuesByPlatform.DataItemRepository.Add(dimension3, "DataItem2")
			Me.chartProcessedIssuesByPlatform.DataItemRepository.Add(dimension4, "DataItem4")
			Me.chartProcessedIssuesByPlatform.DataItemRepository.Add(measure3, "DataItem5")
			Me.chartProcessedIssuesByPlatform.DataSource = Me.dsCustomerSupport
			Me.chartProcessedIssuesByPlatform.HiddenMeasures.AddRange(New DevExpress.DashboardCommon.Measure() { measure3})
			Me.chartProcessedIssuesByPlatform.InteractivityOptions.IgnoreMasterFilters = False
			Me.chartProcessedIssuesByPlatform.InteractivityOptions.IsDrillDownEnabled = True
			Me.chartProcessedIssuesByPlatform.Name = "Processed Issues by Platform / Employee"
			chartPane2.Name = "Pane 1"
			chartPane2.PrimaryAxisY.AlwaysShowZeroLevel = True
			chartPane2.PrimaryAxisY.ShowGridLines = True
			chartPane2.PrimaryAxisY.Title = "Issue Count"
			chartPane2.PrimaryAxisY.TitleVisible = True
			chartPane2.SecondaryAxisY.AlwaysShowZeroLevel = True
			chartPane2.SecondaryAxisY.ShowGridLines = False
			chartPane2.SecondaryAxisY.TitleVisible = True
			simpleSeries2.Name = "Opened (Count)"
			simpleSeries2.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.StackedBar
			simpleSeries2.AddDataItem("Value", measure2)
			chartPane2.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() { simpleSeries2})
			Me.chartProcessedIssuesByPlatform.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() { chartPane2})
			Me.chartProcessedIssuesByPlatform.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension5})
			Me.chartProcessedIssuesByPlatform.ShowCaption = True
			' 
			' chartAvgResponseTimeByMonth
			' 
			dimension6.DataMember = "Opened"
			dimension6.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.Month
			Me.chartAvgResponseTimeByMonth.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension6})
			Me.chartAvgResponseTimeByMonth.AxisX.TitleVisible = False
			Me.chartAvgResponseTimeByMonth.ComponentName = "chartAvgResponseTimeByMonth"
			dimension7.DataMember = "Opened"
			measure4.DataMember = "ResolvedTime"
			measure4.SummaryType = DevExpress.DashboardCommon.SummaryType.Average
			Me.chartAvgResponseTimeByMonth.DataItemRepository.Clear()
			Me.chartAvgResponseTimeByMonth.DataItemRepository.Add(dimension7, "DataItem1")
			Me.chartAvgResponseTimeByMonth.DataItemRepository.Add(dimension6, "DataItem2")
			Me.chartAvgResponseTimeByMonth.DataItemRepository.Add(measure4, "DataItem0")
			Me.chartAvgResponseTimeByMonth.DataSource = Me.dsCustomerSupport
			Me.chartAvgResponseTimeByMonth.InteractivityOptions.IgnoreMasterFilters = True
			Me.chartAvgResponseTimeByMonth.Name = "Average Response Time (h) by Month"
			chartPane3.Name = "Pane 1"
			chartPane3.PrimaryAxisY.AlwaysShowZeroLevel = True
			chartPane3.PrimaryAxisY.ShowGridLines = True
			chartPane3.PrimaryAxisY.Title = "ResolvedTime (Average)"
			chartPane3.PrimaryAxisY.TitleVisible = False
			chartPane3.SecondaryAxisY.AlwaysShowZeroLevel = True
			chartPane3.SecondaryAxisY.ShowGridLines = False
			chartPane3.SecondaryAxisY.TitleVisible = True
			simpleSeries3.Name = "ResolvedTime (Average)"
			simpleSeries3.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.Line
			simpleSeries3.AddDataItem("Value", measure4)
			chartPane3.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() { simpleSeries3})
			Me.chartAvgResponseTimeByMonth.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() { chartPane3})
			Me.chartAvgResponseTimeByMonth.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension7})
			Me.chartAvgResponseTimeByMonth.ShowCaption = True
			' 
			' chartAvgResponseTimeByPlatform
			' 
			dimension8.DataMember = "ProductName"
			dimension8.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending
			dimension9.DataMember = "Employee"
			measure5.DataMember = "ResolvedTime"
			measure5.SummaryType = DevExpress.DashboardCommon.SummaryType.Average
			dimension9.SortByMeasure = measure5
			Me.chartAvgResponseTimeByPlatform.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension8, dimension9})
			Me.chartAvgResponseTimeByPlatform.AxisX.TitleVisible = False
			Me.chartAvgResponseTimeByPlatform.ComponentName = "chartAvgResponseTimeByPlatform"
			dimension10.DataMember = "IssueType"
			measure6.DataMember = "IssueTypeIndex"
			measure6.SummaryType = DevExpress.DashboardCommon.SummaryType.Min
			dimension10.SortByMeasure = measure6
			Me.chartAvgResponseTimeByPlatform.DataItemRepository.Clear()
			Me.chartAvgResponseTimeByPlatform.DataItemRepository.Add(measure5, "DataItem1")
			Me.chartAvgResponseTimeByPlatform.DataItemRepository.Add(dimension10, "DataItem3")
			Me.chartAvgResponseTimeByPlatform.DataItemRepository.Add(dimension8, "DataItem2")
			Me.chartAvgResponseTimeByPlatform.DataItemRepository.Add(measure6, "DataItem0")
			Me.chartAvgResponseTimeByPlatform.DataItemRepository.Add(dimension9, "DataItem5")
			Me.chartAvgResponseTimeByPlatform.DataSource = Me.dsCustomerSupport
			Me.chartAvgResponseTimeByPlatform.HiddenMeasures.AddRange(New DevExpress.DashboardCommon.Measure() { measure6})
			Me.chartAvgResponseTimeByPlatform.InteractivityOptions.IgnoreMasterFilters = False
			Me.chartAvgResponseTimeByPlatform.InteractivityOptions.IsDrillDownEnabled = True
			Me.chartAvgResponseTimeByPlatform.Name = "Average Response Time by Platform / Employee"
			chartPane4.Name = "Pane 1"
			chartPane4.PrimaryAxisY.AlwaysShowZeroLevel = True
			chartPane4.PrimaryAxisY.ShowGridLines = True
			chartPane4.PrimaryAxisY.Title = "Response Time, Hours"
			chartPane4.PrimaryAxisY.TitleVisible = True
			chartPane4.SecondaryAxisY.AlwaysShowZeroLevel = True
			chartPane4.SecondaryAxisY.ShowGridLines = False
			chartPane4.SecondaryAxisY.TitleVisible = True
			simpleSeries4.Name = "ResolvedTime (Average)"
			simpleSeries4.AddDataItem("Value", measure5)
			chartPane4.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() { simpleSeries4})
			Me.chartAvgResponseTimeByPlatform.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() { chartPane4})
			Me.chartAvgResponseTimeByPlatform.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension10})
			Me.chartAvgResponseTimeByPlatform.ShowCaption = True
			' 
			' range
			' 
			dimension11.DataMember = "Opened"
			dimension11.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear
			dimension11.Name = "Date"
			Me.range.Argument = dimension11
			Me.range.ComponentName = "range"
			dimension12.DataMember = "IssueType"
			measure7.DataMember = "Opened"
			measure7.SummaryType = DevExpress.DashboardCommon.SummaryType.Count
			Me.range.DataItemRepository.Clear()
			Me.range.DataItemRepository.Add(dimension11, "DataItem1")
			Me.range.DataItemRepository.Add(dimension12, "DataItem2")
			Me.range.DataItemRepository.Add(measure7, "DataItem0")
			Me.range.DataSource = Me.dsCustomerSupport
			dateTimePeriod1.Name = "3 Months"
			flowDateTimePeriodLimit1.Interval = DevExpress.DashboardCommon.DateTimeInterval.Month
			flowDateTimePeriodLimit1.Offset = -2
			dateTimePeriod1.Start = flowDateTimePeriodLimit1
			dateTimePeriod2.Name = "6 Months"
			flowDateTimePeriodLimit2.Interval = DevExpress.DashboardCommon.DateTimeInterval.Month
			flowDateTimePeriodLimit2.Offset = -5
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
			Me.range.Name = "Date Range"
			simpleSeries5.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.Line
			simpleSeries5.AddDataItem("Value", measure7)
			Me.range.Series.AddRange(New DevExpress.DashboardCommon.SimpleSeries() { simpleSeries5})
			Me.range.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension12})
			Me.range.ShowCaption = False
			' 
			' CustomerSupport
			' 
			colorSchemeEntry1.ColorDefinition = New DevExpress.DashboardCommon.ColorDefinition(1)
			colorSchemeEntry1.DataSource = Me.dsCustomerSupport
			colorSchemeEntry1.DimensionKeys.AddRange(New DevExpress.DashboardCommon.ColorSchemeDimensionKey() { colorSchemeDimensionKey1})
			colorSchemeEntry2.ColorDefinition = New DevExpress.DashboardCommon.ColorDefinition(System.Drawing.Color.FromArgb(-5273005))
			colorSchemeEntry2.DataSource = Me.dsCustomerSupport
			colorSchemeEntry2.DimensionKeys.AddRange(New DevExpress.DashboardCommon.ColorSchemeDimensionKey() { colorSchemeDimensionKey2})
			colorSchemeEntry3.ColorDefinition = New DevExpress.DashboardCommon.ColorDefinition(System.Drawing.Color.FromArgb(-10515563))
			colorSchemeEntry3.DataSource = Me.dsCustomerSupport
			colorSchemeEntry3.DimensionKeys.AddRange(New DevExpress.DashboardCommon.ColorSchemeDimensionKey() { colorSchemeDimensionKey3})
			colorSchemeEntry4.ColorDefinition = New DevExpress.DashboardCommon.ColorDefinition(System.Drawing.Color.FromArgb(-6987919))
			colorSchemeEntry4.DataSource = Me.dsCustomerSupport
			colorSchemeEntry4.DimensionKeys.AddRange(New DevExpress.DashboardCommon.ColorSchemeDimensionKey() { colorSchemeDimensionKey4})
			colorSchemeEntry5.ColorDefinition = New DevExpress.DashboardCommon.ColorDefinition(System.Drawing.Color.FromArgb(-8022426))
			colorSchemeEntry5.DataSource = Me.dsCustomerSupport
			colorSchemeEntry5.DimensionKeys.AddRange(New DevExpress.DashboardCommon.ColorSchemeDimensionKey() { colorSchemeDimensionKey5})
			Me.ColorScheme.AddRange(New DevExpress.DashboardCommon.ColorSchemeEntry() { colorSchemeEntry1, colorSchemeEntry2, colorSchemeEntry3, colorSchemeEntry4, colorSchemeEntry5})
			Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() { Me.dsCustomerSupport})
			Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() { Me.chartProcessedIssuesByPlatform, Me.range, Me.chartAvgResponseTimeByPlatform, Me.chartOpenedIssuesByMonth, Me.chartAvgResponseTimeByMonth})
			dashboardLayoutItem1.DashboardItem = Me.chartOpenedIssuesByMonth
			dashboardLayoutItem1.Weight = 42.544731610337969R
			dashboardLayoutItem2.DashboardItem = Me.chartProcessedIssuesByPlatform
			dashboardLayoutItem2.Weight = 57.455268389662031R
			dashboardLayoutGroup3.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem1, dashboardLayoutItem2})
			dashboardLayoutGroup3.DashboardItem = Nothing
			dashboardLayoutGroup3.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
			dashboardLayoutGroup3.Weight = 49.006622516556291R
			dashboardLayoutItem3.DashboardItem = Me.chartAvgResponseTimeByMonth
			dashboardLayoutItem3.Weight = 42.544731610337969R
			dashboardLayoutItem4.DashboardItem = Me.chartAvgResponseTimeByPlatform
			dashboardLayoutItem4.Weight = 57.455268389662031R
			dashboardLayoutGroup4.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem3, dashboardLayoutItem4})
			dashboardLayoutGroup4.DashboardItem = Nothing
			dashboardLayoutGroup4.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
			dashboardLayoutGroup4.Weight = 50.993377483443709R
			dashboardLayoutGroup2.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutGroup3, dashboardLayoutGroup4})
			dashboardLayoutGroup2.DashboardItem = Nothing
			dashboardLayoutGroup2.Weight = 85.544217687074834R
			dashboardLayoutItem5.DashboardItem = Me.range
			dashboardLayoutItem5.Weight = 14.45578231292517R
			dashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutGroup2, dashboardLayoutItem5})
			dashboardLayoutGroup1.DashboardItem = Nothing
			dashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
			Me.LayoutRoot = dashboardLayoutGroup1
			Me.Title.Text = "Customer Support"
'			Me.DataLoading += New DevExpress.DashboardCommon.DashboardDataLoadingEventHandler(Me.CustomerSupport_DataLoading);
			CType(Me.dsCustomerSupport, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartOpenedIssuesByMonth, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartProcessedIssuesByPlatform, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartAvgResponseTimeByMonth, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension8, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension9, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension10, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartAvgResponseTimeByPlatform, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension12, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.range, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private chartProcessedIssuesByPlatform As DevExpress.DashboardCommon.ChartDashboardItem
		Private range As DevExpress.DashboardCommon.RangeFilterDashboardItem
		Private chartAvgResponseTimeByPlatform As DevExpress.DashboardCommon.ChartDashboardItem
		Private chartOpenedIssuesByMonth As DevExpress.DashboardCommon.ChartDashboardItem
		Private chartAvgResponseTimeByMonth As DevExpress.DashboardCommon.ChartDashboardItem
		Private dsCustomerSupport As DevExpress.DashboardCommon.DashboardObjectDataSource
	End Class
End Namespace

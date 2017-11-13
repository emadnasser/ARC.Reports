Imports Microsoft.VisualBasic
Imports System
Namespace DashboardMainDemo.Dashboards
	Partial Public Class WebsiteStatistics
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
			Dim calculatedField1 As New DevExpress.DashboardCommon.CalculatedField()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(WebsiteStatistics))
			Dim dimension1 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension2 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension3 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension4 As New DevExpress.DashboardCommon.Dimension()
			Dim measure1 As New DevExpress.DashboardCommon.Measure()
			Dim chartPane1 As New DevExpress.DashboardCommon.ChartPane()
			Dim simpleSeries1 As New DevExpress.DashboardCommon.SimpleSeries()
			Dim dimension5 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension6 As New DevExpress.DashboardCommon.Dimension()
			Dim measure2 As New DevExpress.DashboardCommon.Measure()
			Dim chartPane2 As New DevExpress.DashboardCommon.ChartPane()
			Dim simpleSeries2 As New DevExpress.DashboardCommon.SimpleSeries()
			Dim colorSchemeEntry1 As New DevExpress.DashboardCommon.ColorSchemeEntry()
			Dim dimensionDefinition1 As New DevExpress.DashboardCommon.DimensionDefinition("BrowserName")
			Dim colorSchemeDimensionKey1 As New DevExpress.DashboardCommon.ColorSchemeDimensionKey(dimensionDefinition1, "Chrome Latest")
			Dim colorSchemeEntry2 As New DevExpress.DashboardCommon.ColorSchemeEntry()
			Dim colorSchemeDimensionKey2 As New DevExpress.DashboardCommon.ColorSchemeDimensionKey(dimensionDefinition1, "Chrome Others")
			Dim colorSchemeEntry3 As New DevExpress.DashboardCommon.ColorSchemeEntry()
			Dim colorSchemeDimensionKey3 As New DevExpress.DashboardCommon.ColorSchemeDimensionKey(dimensionDefinition1, "Firefox Latest")
			Dim colorSchemeEntry4 As New DevExpress.DashboardCommon.ColorSchemeEntry()
			Dim colorSchemeDimensionKey4 As New DevExpress.DashboardCommon.ColorSchemeDimensionKey(dimensionDefinition1, "Firefox Others")
			Dim colorSchemeEntry5 As New DevExpress.DashboardCommon.ColorSchemeEntry()
			Dim colorSchemeDimensionKey5 As New DevExpress.DashboardCommon.ColorSchemeDimensionKey(dimensionDefinition1, "IE 11")
			Dim colorSchemeEntry6 As New DevExpress.DashboardCommon.ColorSchemeEntry()
			Dim colorSchemeDimensionKey6 As New DevExpress.DashboardCommon.ColorSchemeDimensionKey(dimensionDefinition1, "IE 8")
			Dim colorSchemeEntry7 As New DevExpress.DashboardCommon.ColorSchemeEntry()
			Dim colorSchemeDimensionKey7 As New DevExpress.DashboardCommon.ColorSchemeDimensionKey(dimensionDefinition1, "IE 9")
			Dim colorSchemeEntry8 As New DevExpress.DashboardCommon.ColorSchemeEntry()
			Dim colorSchemeDimensionKey8 As New DevExpress.DashboardCommon.ColorSchemeDimensionKey(dimensionDefinition1, "IE Others")
			Dim colorSchemeEntry9 As New DevExpress.DashboardCommon.ColorSchemeEntry()
			Dim colorSchemeDimensionKey9 As New DevExpress.DashboardCommon.ColorSchemeDimensionKey(dimensionDefinition1, "Opera O Mini")
			Dim colorSchemeEntry10 As New DevExpress.DashboardCommon.ColorSchemeEntry()
			Dim colorSchemeDimensionKey10 As New DevExpress.DashboardCommon.ColorSchemeDimensionKey(dimensionDefinition1, "Opera Others")
			Dim colorSchemeEntry11 As New DevExpress.DashboardCommon.ColorSchemeEntry()
			Dim colorSchemeDimensionKey11 As New DevExpress.DashboardCommon.ColorSchemeDimensionKey(dimensionDefinition1, "Safari Others")
			Dim dashboardLayoutGroup1 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutGroup2 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutItem1 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem2 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutGroup3 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutItem3 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem4 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Me.siteVisitosDataSource = New DevExpress.DashboardCommon.DashboardObjectDataSource()
			Me.trafficSourceFilter = New DevExpress.DashboardCommon.TreeViewDashboardItem()
			Me.trafficSourceGroup = New DevExpress.DashboardCommon.DashboardItemGroup()
			Me.trafficSourceChart = New DevExpress.DashboardCommon.ChartDashboardItem()
			Me.browsersFilter = New DevExpress.DashboardCommon.TreeViewDashboardItem()
			Me.browsersGroup = New DevExpress.DashboardCommon.DashboardItemGroup()
			Me.browsersChart = New DevExpress.DashboardCommon.ChartDashboardItem()
			CType(Me.siteVisitosDataSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.trafficSourceFilter, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.trafficSourceGroup, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.trafficSourceChart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.browsersFilter, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.browsersGroup, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.browsersChart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' siteVisitosDataSource
			' 
			calculatedField1.Expression = "[Browser] + ' ' + [BrowserDetails]"
			calculatedField1.Name = "BrowserName"
			Me.siteVisitosDataSource.CalculatedFields.AddRange(New DevExpress.DashboardCommon.CalculatedField() { calculatedField1})
			Me.siteVisitosDataSource.ComponentName = "siteVisitosDataSource"
			Me.siteVisitosDataSource.DataMember = "Data"
			Me.siteVisitosDataSource.DataSchema = resources.GetString("siteVisitosDataSource.DataSchema")
			Me.siteVisitosDataSource.Name = "Site Visitors"
			' 
			' trafficSourceFilter
			' 
			Me.trafficSourceFilter.ComponentName = "trafficSourceFilter"
			dimension1.DataMember = "TrafficSource"
			dimension2.DataMember = "TrafficSourceDetails"
			Me.trafficSourceFilter.DataItemRepository.Clear()
			Me.trafficSourceFilter.DataItemRepository.Add(dimension1, "DataItem0")
			Me.trafficSourceFilter.DataItemRepository.Add(dimension2, "DataItem1")
			Me.trafficSourceFilter.DataSource = Me.siteVisitosDataSource
			Me.trafficSourceFilter.FilterDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension1, dimension2})
			Me.trafficSourceFilter.Group = Me.trafficSourceGroup
			Me.trafficSourceFilter.InteractivityOptions.IgnoreMasterFilters = True
			Me.trafficSourceFilter.Name = "Traffic Source"
			Me.trafficSourceFilter.ShowCaption = True
			' 
			' trafficSourceGroup
			' 
			Me.trafficSourceGroup.ComponentName = "trafficSourceGroup"
			Me.trafficSourceGroup.InteractivityOptions.IgnoreMasterFilters = False
			Me.trafficSourceGroup.Name = " Traffic Sources Overview"
			Me.trafficSourceGroup.ShowCaption = False
			' 
			' trafficSourceChart
			' 
			dimension3.DataMember = "Date"
			dimension3.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear
			Me.trafficSourceChart.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension3})
			Me.trafficSourceChart.AxisX.TitleVisible = False
			Me.trafficSourceChart.ComponentName = "trafficSourceChart"
			dimension4.DataMember = "TrafficSource"
			measure1.DataMember = "Count"
			measure1.Name = "Users Count"
			Me.trafficSourceChart.DataItemRepository.Clear()
			Me.trafficSourceChart.DataItemRepository.Add(dimension4, "DataItem1")
			Me.trafficSourceChart.DataItemRepository.Add(dimension3, "DataItem0")
			Me.trafficSourceChart.DataItemRepository.Add(measure1, "DataItem2")
			Me.trafficSourceChart.DataSource = Me.siteVisitosDataSource
			Me.trafficSourceChart.Group = Me.trafficSourceGroup
			Me.trafficSourceChart.InteractivityOptions.IgnoreMasterFilters = False
			Me.trafficSourceChart.Name = "Visitors"
			chartPane1.Name = "Pane 1"
			chartPane1.PrimaryAxisY.AlwaysShowZeroLevel = True
			chartPane1.PrimaryAxisY.ShowGridLines = True
			chartPane1.PrimaryAxisY.TitleVisible = False
			chartPane1.SecondaryAxisY.AlwaysShowZeroLevel = True
			chartPane1.SecondaryAxisY.ShowGridLines = False
			chartPane1.SecondaryAxisY.TitleVisible = True
			simpleSeries1.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.StackedSplineArea
			simpleSeries1.AddDataItem("Value", measure1)
			chartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() { simpleSeries1})
			Me.trafficSourceChart.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() { chartPane1})
			Me.trafficSourceChart.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension4})
			Me.trafficSourceChart.ShowCaption = True
			' 
			' browsersFilter
			' 
			Me.browsersFilter.ComponentName = "browsersFilter"
			dimension5.DataMember = "Browser"
			Me.browsersFilter.DataItemRepository.Clear()
			Me.browsersFilter.DataItemRepository.Add(dimension5, "DataItem0")
			Me.browsersFilter.DataSource = Me.siteVisitosDataSource
			Me.browsersFilter.FilterDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension5})
			Me.browsersFilter.Group = Me.browsersGroup
			Me.browsersFilter.InteractivityOptions.IgnoreMasterFilters = True
			Me.browsersFilter.Name = "Browser"
			Me.browsersFilter.ShowCaption = True
			' 
			' browsersGroup
			' 
			Me.browsersGroup.ComponentName = "browsersGroup"
			Me.browsersGroup.InteractivityOptions.IgnoreMasterFilters = True
			Me.browsersGroup.Name = "Browser statistics"
			Me.browsersGroup.ShowCaption = False
			' 
			' browsersChart
			' 
			dimension6.ColoringMode = DevExpress.DashboardCommon.ColoringMode.Hue
			dimension6.DataMember = "BrowserName"
			dimension6.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending
			Me.browsersChart.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension6})
			Me.browsersChart.AxisX.TitleVisible = False
			Me.browsersChart.ComponentName = "browsersChart"
			measure2.DataMember = "Count"
			measure2.Name = "Users Count"
			Me.browsersChart.DataItemRepository.Clear()
			Me.browsersChart.DataItemRepository.Add(measure2, "DataItem2")
			Me.browsersChart.DataItemRepository.Add(dimension6, "DataItem0")
			Me.browsersChart.DataSource = Me.siteVisitosDataSource
			Me.browsersChart.Group = Me.browsersGroup
			Me.browsersChart.InteractivityOptions.IgnoreMasterFilters = False
			Me.browsersChart.Legend.Visible = False
			Me.browsersChart.Name = "Browser Usage"
			chartPane2.Name = "Pane 1"
			chartPane2.PrimaryAxisY.AlwaysShowZeroLevel = True
			chartPane2.PrimaryAxisY.ShowGridLines = True
			chartPane2.PrimaryAxisY.TitleVisible = False
			chartPane2.SecondaryAxisY.AlwaysShowZeroLevel = True
			chartPane2.SecondaryAxisY.ShowGridLines = False
			chartPane2.SecondaryAxisY.TitleVisible = True
			simpleSeries2.AddDataItem("Value", measure2)
			chartPane2.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() { simpleSeries2})
			Me.browsersChart.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() { chartPane2})
			Me.browsersChart.Rotated = True
			Me.browsersChart.ShowCaption = True
			' 
			' WebsiteStatistics
			' 
			colorSchemeEntry1.ColorDefinition = New DevExpress.DashboardCommon.ColorDefinition(System.Drawing.Color.FromArgb(-6987919))
			colorSchemeEntry1.DataSource = Me.siteVisitosDataSource
			colorSchemeEntry1.DimensionKeys.AddRange(New DevExpress.DashboardCommon.ColorSchemeDimensionKey() { colorSchemeDimensionKey1})
			colorSchemeEntry2.ColorDefinition = New DevExpress.DashboardCommon.ColorDefinition(System.Drawing.Color.FromArgb(-6987919))
			colorSchemeEntry2.DataSource = Me.siteVisitosDataSource
			colorSchemeEntry2.DimensionKeys.AddRange(New DevExpress.DashboardCommon.ColorSchemeDimensionKey() { colorSchemeDimensionKey2})
			colorSchemeEntry3.ColorDefinition = New DevExpress.DashboardCommon.ColorDefinition(System.Drawing.Color.FromArgb(-8022426))
			colorSchemeEntry3.DataSource = Me.siteVisitosDataSource
			colorSchemeEntry3.DimensionKeys.AddRange(New DevExpress.DashboardCommon.ColorSchemeDimensionKey() { colorSchemeDimensionKey3})
			colorSchemeEntry4.ColorDefinition = New DevExpress.DashboardCommon.ColorDefinition(System.Drawing.Color.FromArgb(-8022426))
			colorSchemeEntry4.DataSource = Me.siteVisitosDataSource
			colorSchemeEntry4.DimensionKeys.AddRange(New DevExpress.DashboardCommon.ColorSchemeDimensionKey() { colorSchemeDimensionKey4})
			colorSchemeEntry5.ColorDefinition = New DevExpress.DashboardCommon.ColorDefinition(System.Drawing.Color.FromArgb(-8492916))
			colorSchemeEntry5.DataSource = Me.siteVisitosDataSource
			colorSchemeEntry5.DimensionKeys.AddRange(New DevExpress.DashboardCommon.ColorSchemeDimensionKey() { colorSchemeDimensionKey5})
			colorSchemeEntry6.ColorDefinition = New DevExpress.DashboardCommon.ColorDefinition(System.Drawing.Color.FromArgb(-8492916))
			colorSchemeEntry6.DataSource = Me.siteVisitosDataSource
			colorSchemeEntry6.DimensionKeys.AddRange(New DevExpress.DashboardCommon.ColorSchemeDimensionKey() { colorSchemeDimensionKey6})
			colorSchemeEntry7.ColorDefinition = New DevExpress.DashboardCommon.ColorDefinition(System.Drawing.Color.FromArgb(-8492916))
			colorSchemeEntry7.DataSource = Me.siteVisitosDataSource
			colorSchemeEntry7.DimensionKeys.AddRange(New DevExpress.DashboardCommon.ColorSchemeDimensionKey() { colorSchemeDimensionKey7})
			colorSchemeEntry8.ColorDefinition = New DevExpress.DashboardCommon.ColorDefinition(System.Drawing.Color.FromArgb(-8492916))
			colorSchemeEntry8.DataSource = Me.siteVisitosDataSource
			colorSchemeEntry8.DimensionKeys.AddRange(New DevExpress.DashboardCommon.ColorSchemeDimensionKey() { colorSchemeDimensionKey8})
			colorSchemeEntry9.ColorDefinition = New DevExpress.DashboardCommon.ColorDefinition(System.Drawing.Color.FromArgb(-10523243))
			colorSchemeEntry9.DataSource = Me.siteVisitosDataSource
			colorSchemeEntry9.DimensionKeys.AddRange(New DevExpress.DashboardCommon.ColorSchemeDimensionKey() { colorSchemeDimensionKey9})
			colorSchemeEntry10.ColorDefinition = New DevExpress.DashboardCommon.ColorDefinition(System.Drawing.Color.FromArgb(-10523243))
			colorSchemeEntry10.DataSource = Me.siteVisitosDataSource
			colorSchemeEntry10.DimensionKeys.AddRange(New DevExpress.DashboardCommon.ColorSchemeDimensionKey() { colorSchemeDimensionKey10})
			colorSchemeEntry11.ColorDefinition = New DevExpress.DashboardCommon.ColorDefinition(System.Drawing.Color.FromArgb(-5482852))
			colorSchemeEntry11.DataSource = Me.siteVisitosDataSource
			colorSchemeEntry11.DimensionKeys.AddRange(New DevExpress.DashboardCommon.ColorSchemeDimensionKey() { colorSchemeDimensionKey11})
			Me.ColorScheme.AddRange(New DevExpress.DashboardCommon.ColorSchemeEntry() { colorSchemeEntry1, colorSchemeEntry2, colorSchemeEntry3, colorSchemeEntry4, colorSchemeEntry5, colorSchemeEntry6, colorSchemeEntry7, colorSchemeEntry8, colorSchemeEntry9, colorSchemeEntry10, colorSchemeEntry11})
			Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() { Me.siteVisitosDataSource})
			Me.Groups.AddRange(New DevExpress.DashboardCommon.DashboardItemGroup() { Me.browsersGroup, Me.trafficSourceGroup})
			Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() { Me.trafficSourceChart, Me.trafficSourceFilter, Me.browsersFilter, Me.browsersChart})
			dashboardLayoutItem1.DashboardItem = Me.trafficSourceFilter
			dashboardLayoutItem1.Weight = 18.97018970189702R
			dashboardLayoutItem2.DashboardItem = Me.trafficSourceChart
			dashboardLayoutItem2.Weight = 81.029810298102987R
			dashboardLayoutGroup2.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem1, dashboardLayoutItem2})
			dashboardLayoutGroup2.DashboardItem = Me.trafficSourceGroup
			dashboardLayoutGroup2.Weight = 46.990291262135919R
			dashboardLayoutItem3.DashboardItem = Me.browsersFilter
			dashboardLayoutItem3.Weight = 18.97018970189702R
			dashboardLayoutItem4.DashboardItem = Me.browsersChart
			dashboardLayoutItem4.Weight = 81.029810298102987R
			dashboardLayoutGroup3.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem3, dashboardLayoutItem4})
			dashboardLayoutGroup3.DashboardItem = Me.browsersGroup
			dashboardLayoutGroup3.Weight = 53.027522935779814R
			dashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutGroup2, dashboardLayoutGroup3})
			dashboardLayoutGroup1.DashboardItem = Nothing
			dashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
			Me.LayoutRoot = dashboardLayoutGroup1
			Me.Title.Text = "Website Statistics"
'			Me.DataLoading += New DevExpress.DashboardCommon.DashboardDataLoadingEventHandler(Me.WebsiteStatistics_DataLoading);
			CType(Me.siteVisitosDataSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.trafficSourceFilter, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.trafficSourceGroup, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.trafficSourceChart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.browsersFilter, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.browsersGroup, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.browsersChart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private trafficSourceChart As DevExpress.DashboardCommon.ChartDashboardItem
		Private trafficSourceGroup As DevExpress.DashboardCommon.DashboardItemGroup
		Private trafficSourceFilter As DevExpress.DashboardCommon.TreeViewDashboardItem
		Private browsersFilter As DevExpress.DashboardCommon.TreeViewDashboardItem
		Private browsersGroup As DevExpress.DashboardCommon.DashboardItemGroup
		Private browsersChart As DevExpress.DashboardCommon.ChartDashboardItem
		Private siteVisitosDataSource As DevExpress.DashboardCommon.DashboardObjectDataSource
	End Class
End Namespace

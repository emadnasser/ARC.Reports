Imports Microsoft.VisualBasic
Imports System
Imports DashboardMainDemo
Imports DevExpress.DashboardCommon

''' <summary>
''' Summary description
''' </summary>
Public Class OverviewDashboard
	Inherits Dashboard
	Private range As RangeFilterDashboardItem
	Private dsSales As DashboardObjectDataSource
	Private gridSalesByState As GridDashboardItem
	Private chartSalesByCategory As ChartDashboardItem
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
			Dim dimension1 As New DevExpress.DashboardCommon.Dimension()
			Dim measure1 As New DevExpress.DashboardCommon.Measure()
			Dim gridDimensionColumn1 As New DevExpress.DashboardCommon.GridDimensionColumn()
			Dim dimension2 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension3 As New DevExpress.DashboardCommon.Dimension()
			Dim measure2 As New DevExpress.DashboardCommon.Measure()
			Dim dimension4 As New DevExpress.DashboardCommon.Dimension()
			Dim chartPane1 As New DevExpress.DashboardCommon.ChartPane()
			Dim simpleSeries1 As New DevExpress.DashboardCommon.SimpleSeries()
			Dim dimension5 As New DevExpress.DashboardCommon.Dimension()
			Dim measure3 As New DevExpress.DashboardCommon.Measure()
			Dim simpleSeries2 As New DevExpress.DashboardCommon.SimpleSeries()
			Dim dashboardLayoutGroup1 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutGroup2 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutItem1 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem2 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem3 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Me.gridSalesByState = New DevExpress.DashboardCommon.GridDashboardItem()
			Me.chartSalesByCategory = New DevExpress.DashboardCommon.ChartDashboardItem()
			Me.range = New DevExpress.DashboardCommon.RangeFilterDashboardItem()
			Me.dsSales = New DevExpress.DashboardCommon.DashboardObjectDataSource()
			CType(Me.gridSalesByState, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chartSalesByCategory, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.range, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dsSales, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' gridSalesByState
			' 
			dimension1.DataMember = "State"
			measure1.DataMember = "Sales"
			dimension1.SortByMeasure = measure1
			dimension1.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending
			gridDimensionColumn1.Name = "State"
			gridDimensionColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
			gridDimensionColumn1.AddDataItem("Dimension", dimension1)
			Me.gridSalesByState.Columns.AddRange(New DevExpress.DashboardCommon.GridColumnBase() { gridDimensionColumn1})
			Me.gridSalesByState.ComponentName = "gridSalesByState"
			dimension2.DataMember = "CurrentDate"
			dimension2.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear
			Me.gridSalesByState.DataItemRepository.Clear()
			Me.gridSalesByState.DataItemRepository.Add(dimension1, "DataItem1")
			Me.gridSalesByState.DataItemRepository.Add(dimension2, "DataItem6")
			Me.gridSalesByState.DataMember = Nothing
			Me.gridSalesByState.DataSource = Me.dsSales
			Me.gridSalesByState.GridOptions.ShowColumnHeaders = False
			Me.gridSalesByState.GridOptions.ShowHorizontalLines = False
			Me.gridSalesByState.InteractivityOptions.IgnoreMasterFilters = False
			Me.gridSalesByState.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Single
			Me.gridSalesByState.Name = "State"
			Me.gridSalesByState.ShowCaption = True
			Me.gridSalesByState.SparklineArgument = dimension2
			' 
			' chartSalesByCategory
			' 
			dimension3.DataMember = "CurrentDate"
			dimension3.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.DayMonthYear
			Me.chartSalesByCategory.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension3})
			Me.chartSalesByCategory.AxisX.TitleVisible = False
			Me.chartSalesByCategory.ComponentName = "chartSalesByCategory"
			measure2.DataMember = "Sales"
			dimension4.DataMember = "Category"
			dimension4.TopNOptions.Count = 2
			dimension4.TopNOptions.Enabled = True
			dimension4.TopNOptions.Measure = measure2
			Me.chartSalesByCategory.DataItemRepository.Clear()
			Me.chartSalesByCategory.DataItemRepository.Add(measure2, "DataItem1")
			Me.chartSalesByCategory.DataItemRepository.Add(dimension3, "DataItem2")
			Me.chartSalesByCategory.DataItemRepository.Add(dimension4, "DataItem3")
			Me.chartSalesByCategory.DataMember = Nothing
			Me.chartSalesByCategory.DataSource = Me.dsSales
			Me.chartSalesByCategory.InteractivityOptions.IgnoreMasterFilters = False
			Me.chartSalesByCategory.Legend.OutsidePosition = DevExpress.DashboardCommon.ChartLegendOutsidePosition.BottomCenterHorizontal
			Me.chartSalesByCategory.Legend.Visible = False
			Me.chartSalesByCategory.Name = "Sales by Product Category"
			chartPane1.Name = "Pane 1"
			chartPane1.PrimaryAxisY.ShowGridLines = True
			chartPane1.PrimaryAxisY.Title = "Sales"
			chartPane1.PrimaryAxisY.TitleVisible = False
			chartPane1.SecondaryAxisY.ShowGridLines = False
			chartPane1.SecondaryAxisY.TitleVisible = True
			simpleSeries1.Name = "Sales (Sum)"
			simpleSeries1.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.Line
			simpleSeries1.AddDataItem("Value", measure2)
			chartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() { simpleSeries1})
			Me.chartSalesByCategory.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() { chartPane1})
			Me.chartSalesByCategory.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension4})
			Me.chartSalesByCategory.ShowCaption = True
			' 
			' range
			' 
			dimension5.DataMember = "CurrentDate"
			dimension5.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear
			dimension5.Name = "Date"
			Me.range.Argument = dimension5
			Me.range.ComponentName = "range"
			measure3.DataMember = "Sales"
			Me.range.DataItemRepository.Clear()
			Me.range.DataItemRepository.Add(measure3, "DataItem0")
			Me.range.DataItemRepository.Add(dimension5, "DataItem1")
			Me.range.DataMember = Nothing
			Me.range.DataSource = Me.dsSales
			Me.range.InteractivityOptions.IgnoreMasterFilters = True
			Me.range.Name = "Range Filter 1"
			simpleSeries2.Name = "Sales (Sum)"
			simpleSeries2.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.Line
			simpleSeries2.AddDataItem("Value", measure3)
			Me.range.Series.AddRange(New DevExpress.DashboardCommon.SimpleSeries() { simpleSeries2})
			Me.range.ShowCaption = False
			' 
			' dsSales
			' 
			Me.dsSales.ComponentName = "dsSales"
			Me.dsSales.DataMember = "DataItem"
			Me.dsSales.Name = "Sales"
			' 
			' OverviewDashboard
			' 
			Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() { Me.dsSales})
			Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() { Me.range, Me.gridSalesByState, Me.chartSalesByCategory})
			dashboardLayoutItem1.DashboardItem = Me.gridSalesByState
			dashboardLayoutItem1.Weight = 29.989969909729187R
			dashboardLayoutItem2.DashboardItem = Me.chartSalesByCategory
			dashboardLayoutItem2.Weight = 70.010030090270817R
			dashboardLayoutGroup2.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem1, dashboardLayoutItem2})
			dashboardLayoutGroup2.DashboardItem = Nothing
			dashboardLayoutGroup2.Weight = 76.061120543293711R
			dashboardLayoutItem3.DashboardItem = Me.range
			dashboardLayoutItem3.Weight = 23.938879456706282R
			dashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutGroup2, dashboardLayoutItem3})
			dashboardLayoutGroup1.DashboardItem = Nothing
			dashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
			Me.LayoutRoot = dashboardLayoutGroup1
			Me.Title.ShowMasterFilterState = False
			Me.Title.Text = "Overview Dashboard"
'			Me.DataLoading += New DevExpress.DashboardCommon.DashboardDataLoadingEventHandler(Me.OverviewDashboard_DataLoading);
			CType(measure1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridSalesByState, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartSalesByCategory, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.range, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dsSales, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub

	#End Region

	Private Sub OverviewDashboard_DataLoading(ByVal sender As Object, ByVal e As DashboardDataLoadingEventArgs) Handles MyBase.DataLoading
		e.Data = DataLoader.SalesOverviewData
	End Sub
End Class

Imports Microsoft.VisualBasic
Imports System
Imports DashboardMainDemo
Imports DevExpress.DashboardCommon

''' <summary>
''' Summary description
''' </summary>
Public Class RevenueByIndustryDashboard
	Inherits Dashboard
	Private mapRevenueByCity As GeoPointMapDashboardItem
	Private dsStatistics As DashboardObjectDataSource
	Private listBoxIndustry As ListBoxDashboardItem
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
			Dim resources As System.Resources.ResourceManager = Global.Resources.RevenueByIndustry.ResourceManager
			Dim dimension1 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension2 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension3 As New DevExpress.DashboardCommon.Dimension()
			Dim measure1 As New DevExpress.DashboardCommon.Measure()
			Dim dimension4 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension5 As New DevExpress.DashboardCommon.Dimension()
			Dim dashboardLayoutGroup1 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutItem1 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem2 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Me.listBoxIndustry = New DevExpress.DashboardCommon.ListBoxDashboardItem()
			Me.mapRevenueByCity = New DevExpress.DashboardCommon.GeoPointMapDashboardItem()
			Me.dsStatistics = New DevExpress.DashboardCommon.DashboardObjectDataSource()
			CType(Me.listBoxIndustry, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.mapRevenueByCity, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dsStatistics, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' listBoxIndustry
			' 
			Me.listBoxIndustry.ComponentName = "listBoxIndustry"
			dimension1.DataMember = "Industry"
			Me.listBoxIndustry.DataItemRepository.Clear()
			Me.listBoxIndustry.DataItemRepository.Add(dimension1, "DataItem0")
			Me.listBoxIndustry.DataMember = Nothing
			Me.listBoxIndustry.DataSource = Me.dsStatistics
			Me.listBoxIndustry.FilterDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension1})
			Me.listBoxIndustry.InteractivityOptions.IgnoreMasterFilters = False
			Me.listBoxIndustry.Name = "Industry"
			Me.listBoxIndustry.ShowCaption = True
			' 
			' mapRevenueByCity
			' 
			Me.mapRevenueByCity.Area = DevExpress.DashboardCommon.ShapefileArea.USA
			Me.mapRevenueByCity.ComponentName = "mapRevenueByCity"
			dimension2.DataMember = "Latitude"
			dimension3.DataMember = "Longitude"
			measure1.DataMember = "Revenue"
			measure1.Name = "Revenue"
			dimension4.DataMember = "City"
			dimension5.DataMember = "Industry"
			Me.mapRevenueByCity.DataItemRepository.Clear()
			Me.mapRevenueByCity.DataItemRepository.Add(dimension2, "DataItem0")
			Me.mapRevenueByCity.DataItemRepository.Add(dimension3, "DataItem1")
			Me.mapRevenueByCity.DataItemRepository.Add(measure1, "DataItem2")
			Me.mapRevenueByCity.DataItemRepository.Add(dimension4, "DataItem3")
			Me.mapRevenueByCity.DataItemRepository.Add(dimension5, "DataItem4")
			Me.mapRevenueByCity.DataMember = Nothing
			Me.mapRevenueByCity.DataSource = Me.dsStatistics
			Me.mapRevenueByCity.EnableClustering = True
			Me.mapRevenueByCity.InteractivityOptions.IgnoreMasterFilters = False
			Me.mapRevenueByCity.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Multiple
			Me.mapRevenueByCity.Latitude = dimension2
			Me.mapRevenueByCity.Longitude = dimension3
			Me.mapRevenueByCity.Name = "Revenue by City"
			Me.mapRevenueByCity.ShapeTitleAttributeName = "NAME"
			Me.mapRevenueByCity.ShowCaption = True
			Me.mapRevenueByCity.TooltipDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension4, dimension5})
			Me.mapRevenueByCity.Value = measure1
			Me.mapRevenueByCity.Viewport.BottomLatitude = 24.542349340056283R
			Me.mapRevenueByCity.Viewport.CenterPointLatitude = 37.995066405185554R
			Me.mapRevenueByCity.Viewport.CenterPointLongitude = -95.848499902568008R
			Me.mapRevenueByCity.Viewport.LeftLongitude = -124.70997774915153R
			Me.mapRevenueByCity.Viewport.RightLongitude = -66.987022055984482R
			Me.mapRevenueByCity.Viewport.TopLatitude = 49.369672064487254R
			' 
			' dsStatistics
			' 
			Me.dsStatistics.ComponentName = "dsStatistics"
			Me.dsStatistics.DataMember = "Statistics"
			Me.dsStatistics.DataSchema = resources.GetString("dsStatistics.DataSchema")
			Me.dsStatistics.Name = "Statistics"
			' 
			' RevenueByIndustryDashboard
			' 
			Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() { Me.dsStatistics})
			Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() { Me.mapRevenueByCity, Me.listBoxIndustry})
			dashboardLayoutItem1.DashboardItem = Me.listBoxIndustry
			dashboardLayoutItem1.Weight = 26.97426796805679R
			dashboardLayoutItem2.DashboardItem = Me.mapRevenueByCity
			dashboardLayoutItem2.Weight = 73.0257320319432R
			dashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem1, dashboardLayoutItem2})
			dashboardLayoutGroup1.DashboardItem = Nothing
			Me.LayoutRoot = dashboardLayoutGroup1
			Me.Title.Text = "Revenue by Industry"
'			Me.DataLoading += New DevExpress.DashboardCommon.DashboardDataLoadingEventHandler(Me.WorldwideEnergyUseDashboard_DataLoading);
			CType(dimension1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.listBoxIndustry, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.mapRevenueByCity, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dsStatistics, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub

	#End Region

	Private Sub WorldwideEnergyUseDashboard_DataLoading(ByVal sender As Object, ByVal e As DashboardDataLoadingEventArgs) Handles MyBase.DataLoading
		e.Data = DataLoader.RevenueByIndustry.Tables("Statistics")
	End Sub
End Class

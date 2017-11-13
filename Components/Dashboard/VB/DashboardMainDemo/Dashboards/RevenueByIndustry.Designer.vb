Imports Microsoft.VisualBasic
Imports System
Namespace DashboardMainDemo.Dashboards
	Partial Public Class RevenueByIndustry
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
			Dim dimension3 As New DevExpress.DashboardCommon.Dimension()
			Dim measure1 As New DevExpress.DashboardCommon.Measure()
			Dim dimension4 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension5 As New DevExpress.DashboardCommon.Dimension()
			Dim dashboardLayoutGroup1 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutItem1 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem2 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Me.listBoxDashboardItem1 = New DevExpress.DashboardCommon.ListBoxDashboardItem()
			Me.dsStatistics = New DevExpress.DashboardCommon.DashboardObjectDataSource()
			Me.mapRevenueByCity = New DevExpress.DashboardCommon.GeoPointMapDashboardItem()
			CType(Me.listBoxDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dsStatistics, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.mapRevenueByCity, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' listBoxDashboardItem1
			' 
			Me.listBoxDashboardItem1.ComponentName = "listBoxDashboardItem1"
			dimension1.DataMember = "Industry"
			Me.listBoxDashboardItem1.DataItemRepository.Clear()
			Me.listBoxDashboardItem1.DataItemRepository.Add(dimension1, "DataItem0")
			Me.listBoxDashboardItem1.DataSource = Me.dsStatistics
			Me.listBoxDashboardItem1.FilterDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension1})
			Me.listBoxDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
			Me.listBoxDashboardItem1.Name = "Industry"
			Me.listBoxDashboardItem1.ShowCaption = True
			' 
			' dsStatistics
			' 
			Me.dsStatistics.ComponentName = "dsStatistics"
			Me.dsStatistics.DataSchema = ""
			Me.dsStatistics.DataSource = GetType(DashboardMainDemo.RevenueByIndustryDataRow)
			Me.dsStatistics.Name = "Statistics"
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
			' RevenueByIndustry
			' 
			Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() { Me.dsStatistics})
			Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() { Me.mapRevenueByCity, Me.listBoxDashboardItem1})
			dashboardLayoutItem1.DashboardItem = Me.listBoxDashboardItem1
			dashboardLayoutItem1.Weight = 17.036379769299025R
			dashboardLayoutItem2.DashboardItem = Me.mapRevenueByCity
			dashboardLayoutItem2.Weight = 82.963620230700982R
			dashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem1, dashboardLayoutItem2})
			dashboardLayoutGroup1.DashboardItem = Nothing
			Me.LayoutRoot = dashboardLayoutGroup1
			Me.Title.Text = "Revenue by Industry"
'			Me.DataLoading += New DevExpress.DashboardCommon.DashboardDataLoadingEventHandler(Me.RevenueByIndustry_DataLoading);
			CType(dimension1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.listBoxDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dsStatistics, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.mapRevenueByCity, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private mapRevenueByCity As DevExpress.DashboardCommon.GeoPointMapDashboardItem
		Private listBoxDashboardItem1 As DevExpress.DashboardCommon.ListBoxDashboardItem
		Private dsStatistics As DevExpress.DashboardCommon.DashboardObjectDataSource
	End Class
End Namespace

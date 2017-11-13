Imports Microsoft.VisualBasic
Imports System
Namespace DashboardMainDemo.Dashboards
	Partial Public Class EUTradeOverview
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
			Dim calculatedField1 As New DevExpress.DashboardCommon.CalculatedField()
			Dim calculatedField2 As New DevExpress.DashboardCommon.CalculatedField()
			Dim dimension2 As New DevExpress.DashboardCommon.Dimension()
			Dim measure1 As New DevExpress.DashboardCommon.Measure()
			Dim measure2 As New DevExpress.DashboardCommon.Measure()
			Dim dimension3 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension4 As New DevExpress.DashboardCommon.Dimension()
			Dim measure3 As New DevExpress.DashboardCommon.Measure()
			Dim measure4 As New DevExpress.DashboardCommon.Measure()
			Dim dashboardLayoutGroup1 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutGroup2 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutGroup3 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutItem1 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem2 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem3 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutGroup4 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutItem4 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Me.listBoxFilterPartner = New DevExpress.DashboardCommon.ListBoxDashboardItem()
			Me.dashboardExtractDataSource1 = New DevExpress.DashboardCommon.DashboardExtractDataSource()
			Me.filtersGroup = New DevExpress.DashboardCommon.DashboardItemGroup()
			Me.listBoxFilterProductGroup = New DevExpress.DashboardCommon.ListBoxDashboardItem()
			Me.pieImportVsExport = New DevExpress.DashboardCommon.PieDashboardItem()
			Me.treeMapTradeOverviewDetails = New DevExpress.DashboardCommon.TreemapDashboardItem()
			Me.tradeOverviewGroup = New DevExpress.DashboardCommon.DashboardItemGroup()
			CType(Me.listBoxFilterPartner, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dashboardExtractDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.filtersGroup, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.listBoxFilterProductGroup, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pieImportVsExport, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.treeMapTradeOverviewDetails, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tradeOverviewGroup, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' listBoxFilterPartner
			' 
			Me.listBoxFilterPartner.ComponentName = "listBoxFilterPartner"
			dimension1.DataMember = "Partner"
			Me.listBoxFilterPartner.DataItemRepository.Clear()
			Me.listBoxFilterPartner.DataItemRepository.Add(dimension1, "DataItem0")
			Me.listBoxFilterPartner.DataSource = Me.dashboardExtractDataSource1
			Me.listBoxFilterPartner.FilterDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension1})
			Me.listBoxFilterPartner.Group = Me.filtersGroup
			Me.listBoxFilterPartner.InteractivityOptions.IgnoreMasterFilters = True
			Me.listBoxFilterPartner.ListBoxType = DevExpress.DashboardCommon.ListBoxDashboardItemType.Radio
			Me.listBoxFilterPartner.Name = "Partner"
			Me.listBoxFilterPartner.ShowCaption = True
			' 
			' dashboardExtractDataSource1
			' 
			calculatedField1.Expression = "Iif([FLOW] = 'EXPORT', [VALUE], 0)"
			calculatedField1.Name = "Export_Value"
			calculatedField2.Expression = "Iif([FLOW] = 'IMPORT', [VALUE], 0)"
			calculatedField2.Name = "Import_Value"
			Me.dashboardExtractDataSource1.CalculatedFields.AddRange(New DevExpress.DashboardCommon.CalculatedField() { calculatedField1, calculatedField2})
			Me.dashboardExtractDataSource1.ComponentName = "dashboardExtractDataSource1"
			Me.dashboardExtractDataSource1.FileName = "|DataDirectory|\Data\EUTradeOverview.dat"
			Me.dashboardExtractDataSource1.Filter = ""
			Me.dashboardExtractDataSource1.Name = "Extract Data Source 1"
			' 
			' filtersGroup
			' 
			Me.filtersGroup.ComponentName = "filtersGroup"
			Me.filtersGroup.InteractivityOptions.IgnoreMasterFilters = True
			Me.filtersGroup.InteractivityOptions.IsMasterFilter = True
			Me.filtersGroup.Name = "Group 1"
			Me.filtersGroup.ShowCaption = False
			' 
			' listBoxFilterProductGroup
			' 
			Me.listBoxFilterProductGroup.ComponentName = "listBoxFilterProductGroup"
			dimension2.DataMember = "Product_Group"
			dimension2.Name = "Product Group"
			Me.listBoxFilterProductGroup.DataItemRepository.Clear()
			Me.listBoxFilterProductGroup.DataItemRepository.Add(dimension2, "DataItem0")
			Me.listBoxFilterProductGroup.DataSource = Me.dashboardExtractDataSource1
			Me.listBoxFilterProductGroup.FilterDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension2})
			Me.listBoxFilterProductGroup.Group = Me.filtersGroup
			Me.listBoxFilterProductGroup.InteractivityOptions.IgnoreMasterFilters = True
			Me.listBoxFilterProductGroup.Name = "Product Group"
			Me.listBoxFilterProductGroup.ShowCaption = True
			' 
			' pieImportVsExport
			' 
			Me.pieImportVsExport.ComponentName = "pieImportVsExport"
			measure1.DataMember = "Import_Value"
			measure1.Name = "Import"
			measure1.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Currency
			measure2.DataMember = "Export_Value"
			measure2.Name = "Export"
			measure2.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Currency
			Me.pieImportVsExport.DataItemRepository.Clear()
			Me.pieImportVsExport.DataItemRepository.Add(measure1, "DataItem0")
			Me.pieImportVsExport.DataItemRepository.Add(measure2, "DataItem1")
			Me.pieImportVsExport.DataSource = Me.dashboardExtractDataSource1
			Me.pieImportVsExport.InteractivityOptions.IgnoreMasterFilters = False
			Me.pieImportVsExport.LabelContentType = DevExpress.DashboardCommon.PieValueType.Argument
			Me.pieImportVsExport.Name = "Import vs Export"
			Me.pieImportVsExport.ShowCaption = False
			Me.pieImportVsExport.ShowPieCaptions = False
			Me.pieImportVsExport.Values.AddRange(New DevExpress.DashboardCommon.Measure() { measure1, measure2})
			' 
			' treeMapTradeOverviewDetails
			' 
			dimension3.DataMember = "Product_Group"
			dimension3.GroupChildValues = True
			dimension3.Name = "Product Group"
			dimension4.DataMember = "Product"
			Me.treeMapTradeOverviewDetails.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension3, dimension4})
			Me.treeMapTradeOverviewDetails.ColoringOptions.MeasuresColoringMode = DevExpress.DashboardCommon.ColoringMode.None
			Me.treeMapTradeOverviewDetails.ComponentName = "treeMapTradeOverviewDetails"
			measure3.DataMember = "Export_Value"
			measure3.Name = "Export"
			measure3.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Currency
			measure4.DataMember = "Import_Value"
			measure4.Name = "Import"
			measure4.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Currency
			Me.treeMapTradeOverviewDetails.DataItemRepository.Clear()
			Me.treeMapTradeOverviewDetails.DataItemRepository.Add(measure3, "DataItem3")
			Me.treeMapTradeOverviewDetails.DataItemRepository.Add(measure4, "DataItem0")
			Me.treeMapTradeOverviewDetails.DataItemRepository.Add(dimension3, "DataItem1")
			Me.treeMapTradeOverviewDetails.DataItemRepository.Add(dimension4, "DataItem2")
			Me.treeMapTradeOverviewDetails.DataSource = Me.dashboardExtractDataSource1
			Me.treeMapTradeOverviewDetails.Group = Me.tradeOverviewGroup
			Me.treeMapTradeOverviewDetails.InteractivityOptions.IgnoreMasterFilters = False
			Me.treeMapTradeOverviewDetails.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Multiple
			Me.treeMapTradeOverviewDetails.Name = "Product"
			Me.treeMapTradeOverviewDetails.ShowCaption = True
			Me.treeMapTradeOverviewDetails.Values.AddRange(New DevExpress.DashboardCommon.Measure() { measure3, measure4})
			' 
			' tradeOverviewGroup
			' 
			Me.tradeOverviewGroup.ComponentName = "tradeOverviewGroup"
			Me.tradeOverviewGroup.InteractivityOptions.IgnoreMasterFilters = False
			Me.tradeOverviewGroup.InteractivityOptions.IsMasterFilter = True
			Me.tradeOverviewGroup.Name = "Group 2"
			Me.tradeOverviewGroup.ShowCaption = False
			' 
			' EUTradeOverview
			' 
			Me.CurrencyCultureName = "gsw-FR"
			Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() { Me.dashboardExtractDataSource1})
			Me.Groups.AddRange(New DevExpress.DashboardCommon.DashboardItemGroup() { Me.filtersGroup, Me.tradeOverviewGroup})
			Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() { Me.treeMapTradeOverviewDetails, Me.listBoxFilterPartner, Me.listBoxFilterProductGroup, Me.pieImportVsExport})
			dashboardLayoutItem1.DashboardItem = Me.listBoxFilterPartner
			dashboardLayoutItem1.Weight = 54.601226993865033R
			dashboardLayoutItem2.DashboardItem = Me.listBoxFilterProductGroup
			dashboardLayoutItem2.Weight = 45.398773006134967R
			dashboardLayoutGroup3.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem1, dashboardLayoutItem2})
			dashboardLayoutGroup3.DashboardItem = Me.filtersGroup
			dashboardLayoutGroup3.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
			dashboardLayoutGroup3.Weight = 69.957081545064383R
			dashboardLayoutItem3.DashboardItem = Me.pieImportVsExport
			dashboardLayoutItem3.Weight = 30.042918454935624R
			dashboardLayoutGroup2.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutGroup3, dashboardLayoutItem3})
			dashboardLayoutGroup2.DashboardItem = Nothing
			dashboardLayoutGroup2.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
			dashboardLayoutGroup2.Weight = 20.692974013474494R
			dashboardLayoutItem4.DashboardItem = Me.treeMapTradeOverviewDetails
			dashboardLayoutItem4.Weight = 100R
			dashboardLayoutGroup4.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem4})
			dashboardLayoutGroup4.DashboardItem = Me.tradeOverviewGroup
			dashboardLayoutGroup4.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
			dashboardLayoutGroup4.Weight = 79.3070259865255R
			dashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutGroup2, dashboardLayoutGroup4})
			dashboardLayoutGroup1.DashboardItem = Nothing
			Me.LayoutRoot = dashboardLayoutGroup1
			Me.Title.Text = "EU Trade Overview 2015"
			CType(dimension1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.listBoxFilterPartner, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dashboardExtractDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.filtersGroup, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.listBoxFilterProductGroup, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pieImportVsExport, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.treeMapTradeOverviewDetails, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tradeOverviewGroup, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub







		#End Region

		Private treeMapTradeOverviewDetails As DevExpress.DashboardCommon.TreemapDashboardItem
		Private dashboardExtractDataSource1 As DevExpress.DashboardCommon.DashboardExtractDataSource
		Private tradeOverviewGroup As DevExpress.DashboardCommon.DashboardItemGroup
		Private listBoxFilterPartner As DevExpress.DashboardCommon.ListBoxDashboardItem
		Private filtersGroup As DevExpress.DashboardCommon.DashboardItemGroup
		Private listBoxFilterProductGroup As DevExpress.DashboardCommon.ListBoxDashboardItem
		Private pieImportVsExport As DevExpress.DashboardCommon.PieDashboardItem

	End Class
End Namespace

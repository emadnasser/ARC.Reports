Imports Microsoft.VisualBasic
Imports System
Imports DashboardMainDemo
Imports DevExpress.DashboardCommon

''' <summary>
''' Summary description
''' </summary>
Public Class SalesDetailsDashboard
	Inherits Dashboard
	Private dsSales As DashboardObjectDataSource
	Private cardSalesByProduct As CardDashboardItem
	Private listBoxCategory As ListBoxDashboardItem
	Private listBoxDashboardItem1 As ListBoxDashboardItem
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
			Dim resources As System.Resources.ResourceManager = Global.Resources.SalesDetailsDashboard.ResourceManager
			Dim dimension1 As New DevExpress.DashboardCommon.Dimension()
			Dim calculatedField1 As New DevExpress.DashboardCommon.CalculatedField()
			Dim dimension2 As New DevExpress.DashboardCommon.Dimension()
			Dim measure1 As New DevExpress.DashboardCommon.Measure()
			Dim measure2 As New DevExpress.DashboardCommon.Measure()
			Dim card1 As New DevExpress.DashboardCommon.Card()
			Dim measure3 As New DevExpress.DashboardCommon.Measure()
			Dim measure4 As New DevExpress.DashboardCommon.Measure()
			Dim card2 As New DevExpress.DashboardCommon.Card()
			Dim measure5 As New DevExpress.DashboardCommon.Measure()
			Dim measure6 As New DevExpress.DashboardCommon.Measure()
			Dim card3 As New DevExpress.DashboardCommon.Card()
			Dim dimension3 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension4 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension5 As New DevExpress.DashboardCommon.Dimension()
			Dim measure7 As New DevExpress.DashboardCommon.Measure()
			Dim dashboardLayoutGroup1 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutGroup2 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutItem1 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem2 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem3 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Me.listBoxCategory = New DevExpress.DashboardCommon.ListBoxDashboardItem()
			Me.dsSales = New DevExpress.DashboardCommon.DashboardObjectDataSource()
			Me.listBoxDashboardItem1 = New DevExpress.DashboardCommon.ListBoxDashboardItem()
			Me.cardSalesByProduct = New DevExpress.DashboardCommon.CardDashboardItem()
			CType(Me.listBoxCategory, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dsSales, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.listBoxDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cardSalesByProduct, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' listBoxCategory
			' 
			Me.listBoxCategory.ComponentName = "listBoxCategory"
			dimension1.DataMember = "Category"
			Me.listBoxCategory.DataItemRepository.Clear()
			Me.listBoxCategory.DataItemRepository.Add(dimension1, "DataItem0")
			Me.listBoxCategory.DataSource = Me.dsSales
			Me.listBoxCategory.FilterDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension1})
			Me.listBoxCategory.InteractivityOptions.IgnoreMasterFilters = True
			Me.listBoxCategory.ListBoxType = DevExpress.DashboardCommon.ListBoxDashboardItemType.Radio
			Me.listBoxCategory.Name = "Category"
			Me.listBoxCategory.ShowCaption = True
			' 
			' dsSales
			' 
			calculatedField1.Expression = "ToInt([UnitsReceived] - [UnitsSold] + [Returns])"
			calculatedField1.Name = "UnitsInStock"
			Me.dsSales.CalculatedFields.AddRange(New DevExpress.DashboardCommon.CalculatedField() { calculatedField1})
			Me.dsSales.ComponentName = "dsSales"
			Me.dsSales.DataMember = "DataItem"
			Me.dsSales.DataSchema = resources.GetString("dsSales.DataSchema")
			Me.dsSales.Name = "Sales"
			' 
			' listBoxDashboardItem1
			' 
			Me.listBoxDashboardItem1.ComponentName = "listBoxDashboardItem1"
			dimension2.DataMember = "State"
			Me.listBoxDashboardItem1.DataItemRepository.Clear()
			Me.listBoxDashboardItem1.DataItemRepository.Add(dimension2, "DataItem0")
			Me.listBoxDashboardItem1.DataSource = Me.dsSales
			Me.listBoxDashboardItem1.FilterDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension2})
			Me.listBoxDashboardItem1.InteractivityOptions.IgnoreMasterFilters = True
			Me.listBoxDashboardItem1.Name = "State"
			Me.listBoxDashboardItem1.ShowCaption = True
			' 
			' cardSalesByProduct
			' 
			measure1.DataMember = "Revenue"
			measure1.Name = "Revenue"
			measure2.DataMember = "RevenueTarget"
			measure2.Name = "Revenue Target"
			card1.Name = "Revenue vs Target"
			card1.AddDataItem("ActualValue", measure1)
			card1.AddDataItem("TargetValue", measure2)
			measure3.DataMember = "UnitsSold"
			measure3.Name = "Units Sold"
			measure4.DataMember = "UnitsSoldTarget"
			measure4.Name = "Units Sold Target"
			card2.Name = "Units Sold vs Target"
			card2.AddDataItem("ActualValue", measure3)
			card2.AddDataItem("TargetValue", measure4)
			measure5.DataMember = "Returns"
			measure5.Name = "Returns"
			measure6.DataMember = "ReturnsTarget"
			measure6.Name = "Returns Target"
			card3.DeltaOptions.ResultIndicationMode = DevExpress.DashboardCommon.DeltaIndicationMode.LessIsGood
			card3.Name = "Returns vs Target"
			card3.AddDataItem("ActualValue", measure5)
			card3.AddDataItem("TargetValue", measure6)
			Me.cardSalesByProduct.Cards.AddRange(New DevExpress.DashboardCommon.Card() { card1, card2, card3})
			Me.cardSalesByProduct.ComponentName = "cardSalesByProduct"
			Me.cardSalesByProduct.ContentArrangementMode = DevExpress.DashboardCommon.ContentArrangementMode.FixedColumnCount
			Me.cardSalesByProduct.ContentLineCount = 4
			dimension3.DataMember = "Category"
			dimension4.DataMember = "Product"
			dimension5.DataMember = "CurrentDate"
			dimension5.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.Month
			measure7.DataMember = "UnitsInStock"
			measure7.Name = "Units In Stock"
			Me.cardSalesByProduct.DataItemRepository.Clear()
			Me.cardSalesByProduct.DataItemRepository.Add(measure2, "DataItem1")
			Me.cardSalesByProduct.DataItemRepository.Add(measure3, "DataItem2")
			Me.cardSalesByProduct.DataItemRepository.Add(measure4, "DataItem3")
			Me.cardSalesByProduct.DataItemRepository.Add(measure5, "DataItem4")
			Me.cardSalesByProduct.DataItemRepository.Add(measure1, "DataItem0")
			Me.cardSalesByProduct.DataItemRepository.Add(measure6, "DataItem5")
			Me.cardSalesByProduct.DataItemRepository.Add(dimension3, "DataItem6")
			Me.cardSalesByProduct.DataItemRepository.Add(dimension4, "DataItem7")
			Me.cardSalesByProduct.DataItemRepository.Add(dimension5, "DataItem8")
			Me.cardSalesByProduct.DataItemRepository.Add(measure7, "DataItem9")
			Me.cardSalesByProduct.DataSource = Me.dsSales
			Me.cardSalesByProduct.HiddenMeasures.AddRange(New DevExpress.DashboardCommon.Measure() { measure7})
			Me.cardSalesByProduct.InteractivityOptions.IgnoreMasterFilters = False
			Me.cardSalesByProduct.Name = "Sales by Product"
			Me.cardSalesByProduct.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension3, dimension4})
			Me.cardSalesByProduct.ShowCaption = True
			Me.cardSalesByProduct.SparklineArgument = dimension5
			' 
			' SalesDetailsDashboard
			' 
			Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() { Me.dsSales})
			Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() { Me.cardSalesByProduct, Me.listBoxCategory, Me.listBoxDashboardItem1})
			dashboardLayoutItem1.DashboardItem = Me.listBoxCategory
			dashboardLayoutItem1.Weight = 22.92490118577075R
			dashboardLayoutItem2.DashboardItem = Me.listBoxDashboardItem1
			dashboardLayoutItem2.Weight = 77.07509881422925R
			dashboardLayoutGroup2.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem1, dashboardLayoutItem2})
			dashboardLayoutGroup2.DashboardItem = Nothing
			dashboardLayoutGroup2.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
			dashboardLayoutGroup2.Weight = 21.042281219272368R
			dashboardLayoutItem3.DashboardItem = Me.cardSalesByProduct
			dashboardLayoutItem3.Weight = 78.957718780727632R
			dashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutGroup2, dashboardLayoutItem3})
			dashboardLayoutGroup1.DashboardItem = Nothing
			Me.LayoutRoot = dashboardLayoutGroup1
			Me.Title.Text = "Sales Details"
'			Me.DataLoading += New DevExpress.DashboardCommon.DashboardDataLoadingEventHandler(Me.SalesDetailsDashboard_DataLoading);
			CType(dimension1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.listBoxCategory, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dsSales, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.listBoxDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cardSalesByProduct, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub

	#End Region

	Private Sub SalesDetailsDashboard_DataLoading(ByVal sender As Object, ByVal e As DashboardDataLoadingEventArgs) Handles MyBase.DataLoading
		e.Data = DataLoader.SalesDetailsData
	End Sub
End Class

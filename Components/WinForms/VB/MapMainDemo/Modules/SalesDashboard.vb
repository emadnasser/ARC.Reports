Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Collections.Generic
Imports System.Xml.Linq
Imports System.Globalization
Imports DevExpress.Utils
Imports DevExpress.XtraMap.Native
Imports DevExpress.XtraCharts
Imports DevExpress.XtraGauges.Win.Gauges.Circular
Imports DevExpress.XtraGauges.Win
Imports DevExpress.XtraLayout

Namespace DevExpress.XtraMap.Demos

	Partial Public Class SalesDashboard
		Inherits MapTutorialControl
		Private dataGenerator As SalesDataGenerator
		Private superToolTip_Renamed As SuperToolTip
		Private titleItem_Renamed As ToolTipTitleItem
		Private contentItem_Renamed As ToolTipItem

		Protected Overrides ReadOnly Property Overlays() As MapOverlay()
			Get
				Return OverlayUtils.GetBingOverlays()
			End Get
		End Property
		Protected ReadOnly Property SuperToolTip() As SuperToolTip
			Get
				If superToolTip_Renamed Is Nothing Then
					CreateSuperToolTip()
				End If
				Return superToolTip_Renamed
			End Get
		End Property
		Protected ReadOnly Property TitleItem() As ToolTipTitleItem
			Get
				If titleItem_Renamed Is Nothing Then
					CreateSuperToolTip()
				End If
				Return titleItem_Renamed
			End Get
		End Property
		Protected ReadOnly Property ContentItem() As ToolTipItem
			Get
				If contentItem_Renamed Is Nothing Then
					CreateSuperToolTip()
				End If
				Return contentItem_Renamed
			End Get
		End Property
		Protected Overrides ReadOnly Property MiniMapBingKind() As BingMapKind
			Get
				Return BingMapKind.Road
			End Get
		End Property
		Protected Overrides ReadOnly Property MiniMapAlignment() As MiniMapAlignment
			Get
				Return MiniMapAlignment.TopLeft
			End Get
		End Property
		Public Overrides ReadOnly Property MapControl() As MapControl
			Get
				Return mapControl1
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			InitializeData()
		End Sub
		Private Sub InitializeData()
			DemoUtils.SetBingMapDataProviderKey(BingMapDataProvider)
			Me.dataGenerator = New SalesDataGenerator(chartControl1, layoutControlItem3, arcScaleNeedleComponent1)

			ListSourceDataAdapter.DataSource = dataGenerator.Shops

			chartControl1.DataSource = dataGenerator.ActualStatistics
			circularGauge1.Scales(0).MinValue = dataGenerator.MinSalesLevel - 10000
			circularGauge1.Scales(0).MaxValue = dataGenerator.MaxSalesLevel + 10000
			arcScaleMarkerComponent1.Value = dataGenerator.MinSalesLevel
			arcScaleMarkerComponent2.Value = dataGenerator.MaxSalesLevel
		End Sub

		Private Sub CreateSuperToolTip()
			Me.superToolTip_Renamed = New SuperToolTip() With {.MaxWidth = 350}
			Me.titleItem_Renamed = New ToolTipTitleItem()
			Me.contentItem_Renamed = New ToolTipItem()
			superToolTip_Renamed.Items.Add(titleItem_Renamed)
			superToolTip_Renamed.Items.Add(contentItem_Renamed)
		End Sub
		Private Sub UpdateSuperToolTip(ByVal content As String, ByVal item As MapItem)
			ContentItem.Text = content
			If item IsNot Nothing Then
				Dim shopName As String = item.Attributes("ShopName").Value.ToString()
				ContentItem.Image = CType(item.Attributes("ShopImage").Value, Image)
				TitleItem.Text = shopName
			End If
		End Sub
		Private Sub toolTipController1_BeforeShow(ByVal sender As Object, ByVal e As ToolTipControllerShowEventArgs) Handles toolTipController1.BeforeShow
			Dim item As MapItem = TryCast(e.SelectedObject, MapItem)
			If item IsNot Nothing Then
				UpdateSuperToolTip(e.ToolTip, item)
				e.AutoHide = False
				e.SuperTip = SuperToolTip
			End If
		End Sub
		Private Sub mapControl1_SelectionChanged(ByVal sender As Object, ByVal e As MapSelectionChangedEventArgs) Handles mapControl1.SelectionChanged
			Dim selectedShop As ShopInfo = If(e.Selection.Count > 0, TryCast(e.Selection(0), ShopInfo), Nothing)
			dataGenerator.SelectedShop = selectedShop
		End Sub
		Protected Overrides Sub RestoreInitialView()
			MapControl.CenterPoint = New GeoPoint(37.68R, -122.419R)
			MapControl.ZoomLevel = 11
		End Sub
	End Class

	Public Class ProductGroupInfo
		Private ReadOnly name_Renamed As String

		Public ReadOnly Property Name() As String
			Get
				Return name_Renamed
			End Get
		End Property
		Public Property Value() As Single

		Public Sub New(ByVal value As Single, ByVal name As String)
			Me.Value = value
			Me.name_Renamed = name
		End Sub
	End Class

	Public Class ShopInfo
		Private Function ConvertShopNameToFilePath(ByVal shopName As String) As String
			Dim result As String = shopName.Replace(" ", "")
			result = "Images\Shops\" & result.Replace("-", "") & ".png"
			Return DemoUtils.GetRelativePath(result)
		End Function

		Private ReadOnly name_Renamed As String
		Private ReadOnly phone_Renamed As String
		Private ReadOnly fax_Renamed As String
		Private ReadOnly address_Renamed As String
		Private ReadOnly image_Renamed As Image
		Private sales_Renamed As Single
		Private statistics As New Dictionary(Of String, Single)()

		Public ReadOnly Property Name() As String
			Get
				Return name_Renamed
			End Get
		End Property
		Public ReadOnly Property Phone() As String
			Get
				Return phone_Renamed
			End Get
		End Property
		Public ReadOnly Property Fax() As String
			Get
				Return fax_Renamed
			End Get
		End Property
		Public ReadOnly Property Address() As String
			Get
				Return address_Renamed
			End Get
		End Property
		Public ReadOnly Property Sales() As Single
			Get
				Return sales_Renamed
			End Get
		End Property
		Public Property LocationLatitude() As Double
		Public Property LocationLongitude() As Double
		Public ReadOnly Property Image() As Image
			Get
				Return image_Renamed
			End Get
		End Property

		Public Sub New(ByVal name As String, ByVal address As String, ByVal phone As String, ByVal fax As String)
			Me.name_Renamed = name
			Me.address_Renamed = address
			Me.phone_Renamed = phone
			Me.fax_Renamed = fax
			Me.image_Renamed = New Bitmap(ConvertShopNameToFilePath(name))
		End Sub
		Public Sub AddProductGroup(ByVal groupName As String, ByVal sales As Single)
			If statistics.ContainsKey(groupName) Then
				statistics(groupName) = sales
			Else
				statistics.Add(groupName, sales)
			End If
			Me.sales_Renamed += sales
		End Sub
		Public Function GetSalesByProductGroup(ByVal groupName As String) As Single
			Return If(statistics.ContainsKey(groupName), statistics(groupName), 0.0f)
		End Function
	End Class

	Public Class SalesDataGenerator
		Private ReadOnly chart As ChartControl
		Private ReadOnly gaugeContainer As LayoutControlItem
		Private ReadOnly needle As ArcScaleNeedleComponent
		Private shops_Renamed As New List(Of ShopInfo)()
		Private actualStatistics_Renamed As New List(Of ProductGroupInfo)()
		Private salesDescription As String = String.Empty
		Private selectedShop_Renamed As ShopInfo

		Public ReadOnly Property ActualStatistics() As List(Of ProductGroupInfo)
			Get
				Return actualStatistics_Renamed
			End Get
		End Property
		Public ReadOnly Property Shops() As List(Of ShopInfo)
			Get
				Return shops_Renamed
			End Get
		End Property
		Private privateMaxSalesLevel As Single
		Public Property MaxSalesLevel() As Single
			Get
				Return privateMaxSalesLevel
			End Get
			Private Set(ByVal value As Single)
				privateMaxSalesLevel = value
			End Set
		End Property
		Private privateMinSalesLevel As Single
		Public Property MinSalesLevel() As Single
			Get
				Return privateMinSalesLevel
			End Get
			Private Set(ByVal value As Single)
				privateMinSalesLevel = value
			End Set
		End Property
		Public Property SelectedShop() As ShopInfo
			Get
				Return selectedShop_Renamed
			End Get
			Set(ByVal value As ShopInfo)
				If selectedShop_Renamed Is value Then
					Return
				End If
				selectedShop_Renamed = value
				SelectedShopChanged()
			End Set
		End Property

		Public Sub New(ByVal chart As ChartControl, ByVal gaugeContainer As LayoutControlItem, ByVal needle As ArcScaleNeedleComponent)
			Me.chart = chart
			Me.gaugeContainer = gaugeContainer
			Me.needle = needle
			LoadDataFromXML()
			UpdateMinMaxSales()
			UpdateTotalStatistics()
		End Sub
		Private Sub SelectedShopChanged()
			If selectedShop_Renamed IsNot Nothing Then
				UpdateStatistics(selectedShop_Renamed)
			Else
				UpdateTotalStatistics()
			End If
		End Sub
		Private Sub LoadDataFromXML()
			Dim productGroupNames As New List(Of String)()
			Dim document As XDocument = DemoUtils.LoadXml("Sales.xml")
			If document IsNot Nothing Then
				For Each element As XElement In document.Element("Sales").Elements()
					Dim shopName As String = element.Element("ShopName").Value
					Dim shopAddress As String = element.Element("ShopAddr").Value
					Dim shopPhone As String = element.Element("ShopPhone").Value
					Dim shopFax As String = element.Element("ShopFax").Value
					Dim info As New ShopInfo(shopName, shopAddress, shopPhone, shopFax)
					For Each statElement As XElement In element.Element("ShopStatistics").Elements()
						Dim groupName As String = statElement.Element("ProductsGroupName").Value
						If (Not productGroupNames.Contains(groupName)) Then
							productGroupNames.Add(groupName)
						End If
						Dim sales As Single = Convert.ToSingle(statElement.Element("ProductGroupSales").Value, CultureInfo.InvariantCulture)
						info.AddProductGroup(groupName, sales)
					Next statElement
					info.LocationLatitude = Convert.ToDouble(element.Element("Latitude").Value, CultureInfo.InvariantCulture)
					info.LocationLongitude = Convert.ToDouble(element.Element("Longitude").Value, CultureInfo.InvariantCulture)
					Shops.Add(info)
				Next element
			End If
			For Each groupName As String In productGroupNames
				ActualStatistics.Add(New ProductGroupInfo(0.0f, groupName))
			Next groupName
			UpdateTotalStatistics()
		End Sub
		Private Sub UpdateStatistics(ByVal info As ShopInfo)
			For Each productGroupInfo As ProductGroupInfo In ActualStatistics
				productGroupInfo.Value = info.GetSalesByProductGroup(productGroupInfo.Name)
			Next productGroupInfo
			chart.Titles(0).Text = "Sales: " & info.Name
			chart.RefreshData()
			needle.Value = selectedShop_Renamed.Sales
			gaugeContainer.ContentVisible = True
		End Sub
		Private Sub UpdateMinMaxSales()
			Dim minSales As Single = Shops(0).Sales
			Dim maxSales As Single = Shops(0).Sales
			For Each info As ShopInfo In Shops
				If info.Sales > maxSales Then
					maxSales = info.Sales
				End If
				If info.Sales < minSales Then
					minSales = info.Sales
				End If
			Next info
			MaxSalesLevel = maxSales
			MinSalesLevel = minSales
		End Sub

		Public Sub UpdateTotalStatistics()
			For Each info As ProductGroupInfo In ActualStatistics
				info.Value = 0.0f
				For Each shopInfo As ShopInfo In Shops
					info.Value += shopInfo.GetSalesByProductGroup(info.Name)
				Next shopInfo
			Next info
			gaugeContainer.ContentVisible = False
			chart.Titles(0).Text = "Sales: All Shops"
			chart.RefreshData()
		End Sub
	End Class
End Namespace

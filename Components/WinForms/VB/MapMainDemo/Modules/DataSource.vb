Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Collections.Generic
Imports DevExpress.Utils
Imports System.Xml.Linq
Imports System.Globalization
Imports DevExpress.XtraBars

Namespace DevExpress.XtraMap.Demos

	Partial Public Class DataSource
		Inherits MapTutorialControl
		Private ships As List(Of ShipInfo)
		Private toolTipFont_Renamed As Font

		Private ReadOnly Property ToolTipFont() As Font
			Get
				If toolTipFont_Renamed Is Nothing Then
					toolTipFont_Renamed = New Font(AppearanceObject.DefaultFont.FontFamily, 12, FontStyle.Bold)
				End If
				Return toolTipFont_Renamed
			End Get
		End Property

		Protected Overrides ReadOnly Property Overlays() As MapOverlay()
			Get
				Return OverlayUtils.GetBingOverlays()
			End Get
		End Property
		Public Overrides ReadOnly Property MapControl() As MapControl
			Get
				Return mapControl1
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			Me.ships = LoadShipsFromXML()
			DemoUtils.SetBingMapDataProviderKey(BingMapDataProvider)
			DemoUtils.SetBingMapDataProviderKey(MiniMapDataProvider)
			ListSourceDataAdapter.DataSource = ships
			MiniMapDataAdapter.DataSource = ships
			AutoMergeRibbon = True
		End Sub

		Private Function LoadShipsFromXML() As List(Of ShipInfo)
			Dim ships As New List(Of ShipInfo)()
			Dim document As XDocument = DemoUtils.LoadXml("Ships.xml")
			If document IsNot Nothing Then
				For Each element As XElement In document.Element("Ships").Elements()
					Dim latitude As Double = Convert.ToDouble(element.Element("Latitude").Value, CultureInfo.InvariantCulture)
					Dim longitude As Double = Convert.ToDouble(element.Element("Longitude").Value, CultureInfo.InvariantCulture)
					Dim name As String = element.Element("Name").Value
					Dim description As String = element.Element("Description").Value
					Dim year As String = element.Element("Year").Value
					ships.Add(New ShipInfo() With {.Latitude = latitude, .Longitude = longitude, .Description = description, .Name = name, .Year = year})
				Next element
			End If
			Return ships
		End Function
		Private Sub toolTipController1_BeforeShow(ByVal sender As Object, ByVal e As ToolTipControllerShowEventArgs) Handles toolTipController1.BeforeShow
			Dim customElement As MapCustomElement = CType(e.SelectedObject, MapCustomElement)
			Dim shipInfo As ShipInfo = CType(ItemsLayer.GetItemSourceObject(customElement), ShipInfo)

			Dim titleItem1 As New ToolTipTitleItem() With {.Text = shipInfo.Header}
			titleItem1.Appearance.ForeColor = SystemColors.GrayText
			titleItem1.Appearance.Font = ToolTipFont

			Dim superToolTip As New SuperToolTip()
			superToolTip.Items.Add(titleItem1)

			Dim sepItem As New ToolTipSeparatorItem()
			superToolTip.Items.Add(sepItem)

			Dim textItem As New ToolTipItem() With {.Text = e.ToolTip}
			superToolTip.Items.Add(textItem)
			e.SuperTip = superToolTip
		End Sub
		Private Sub OnDispose(ByVal disposing As Boolean)
			If Me.toolTipFont_Renamed IsNot Nothing Then
				Me.toolTipFont_Renamed.Dispose()
				Me.toolTipFont_Renamed = Nothing
			End If
		End Sub
		Protected Overrides Sub InitRibbon()
			MyBase.InitRibbon()
			ChkLockNavigation.Checked = True
			DisableZoomOptions()
		End Sub
		Protected Overrides Sub ChangeEnableNavigation(ByVal enable As Boolean)
			MapControl.EnableScrolling = enable
		End Sub
		Protected Overrides Sub RestoreInitialView()
			MapControl.CenterPoint = New GeoPoint(-36, 145)
			MapControl.ZoomLevel = 6
		End Sub
	End Class

	Public Class ShipInfo
		Public Property Latitude() As Double
		Public Property Longitude() As Double
		Public Property Name() As String
		Public Property Year() As String
		Public Property Description() As String
		Public ReadOnly Property Header() As String
			Get
				Return Name & " (" & Year & ")"
			End Get
		End Property
	End Class
End Namespace

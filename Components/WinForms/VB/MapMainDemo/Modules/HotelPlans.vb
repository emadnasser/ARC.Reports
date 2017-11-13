Imports Microsoft.VisualBasic
Imports DevExpress.XtraBars
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms

Namespace DevExpress.XtraMap.Demos
	Partial Public Class HotelPlans
		Inherits MapTutorialControl
		Private Const HotelsCount As Integer = 3

		Private overlayManager_Renamed As HotelPlansOverlayManager
		Private tooltipHelper As New HotelRoomTooltipHelper()
		Private geoMapActivated As Boolean = True

		Private ReadOnly Property OverlayManager() As HotelPlansOverlayManager
			Get
				If overlayManager_Renamed Is Nothing Then
					overlayManager_Renamed = New HotelPlansOverlayManager()
				End If
				Return overlayManager_Renamed
			End Get
		End Property
		Protected Overrides ReadOnly Property Overlays() As MapOverlay()
			Get
				Return If(geoMapActivated, OverlayUtils.GetBingOverlays(), OverlayManager.GetOverlays())
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
			AutoMergeRibbon = True
			InitializeComponent()
			PrepareMap()
		End Sub
		Private Sub PrepareMap()
			DemoUtils.SetBingMapDataProviderKey(BingMapDataProvider)
			PopulateItemStorage()
		End Sub
		Private Sub PopulateItemStorage()
			HotelsItemStorage.Items.Clear()
			HotelsItemStorage.Items.Add(CreateHotel(New GeoPoint(-21.1434, -175.154), "Geek Island Resort", "Hotel1", 0))
			HotelsItemStorage.Items.Add(CreateHotel(New GeoPoint(-21.1936528, -175.1552), "Nerd Hotel Tonga", "Hotel2", 1))
			HotelsItemStorage.Items.Add(CreateHotel(New GeoPoint(-21.1658, -175.1134), "The IT Paradise Hotel", "Hotel3", 2))
		End Sub
		Private Function CreateHotel(ByVal location As GeoPoint, ByVal name As String, ByVal path As String, ByVal index As Integer) As MapItem
			Dim hotel As New MapCustomElement() With {.Location = location, .Text = name, .ImageIndex = index, .TextAlignment = TextAlignment.TopCenter}
			hotel.Attributes.Add(New MapItemAttribute() With {.Name = "path", .Value = path, .Type = GetType(String)})
			hotel.Attributes.Add(New MapItemAttribute() With {.Name = "index", .Value = index, .Type = GetType(Integer)})
			Return hotel
		End Function
		Private Sub ResetOverlays()
			MapControl.Overlays.Clear()
			MapControl.Overlays.AddRange(Overlays)
		End Sub
		Private Sub ActivateCartesianMap(ByVal item As MapItem)
			Me.geoMapActivated = False
			'ChkShowMinimap
			ChangeMiniState(False)
			mapControl1.CoordinateSystem = New CartesianMapCoordinateSystem()
			Dim data As New ShapefileDataAdapter() With {.SourceCoordinateSystem = New CartesianSourceCoordinateSystem(), .FileUri = GetFileUri(item)}
			tooltipHelper.UpdateHotelIndex(CInt(Fix(item.Attributes("index").Value)))
			HotelPlanLayer.Data = data
			OverlayManager.HotelName.Text = (CType(item, MapCustomElement)).Text
			SetElementsVisibility(False)
			RemoveHandler mapControl1.MapItemClick, AddressOf mapControl1_MapItemClick
			RemoveHandler mapControl1.DrawMapItem, AddressOf mapControl1_DrawMapItem
			AddHandler mapControl1.MouseUp, AddressOf mapControl1_MouseUp
			ResetOverlays()
		End Sub
		Private Sub ActivateGeoMap()
			Me.geoMapActivated = True
			ChangeMiniState(True)
			mapControl1.CoordinateSystem = New GeoMapCoordinateSystem()
			HotelsLayer.SelectedItems.Clear()
			SetElementsVisibility(True)
			ResetMinMaxZoomLevel()
			mapControl1.ZoomToFitLayerItems(0.5)
			SetMinMaxZoomLevel()
			AddHandler mapControl1.MapItemClick, AddressOf mapControl1_MapItemClick
			AddHandler mapControl1.DrawMapItem, AddressOf mapControl1_DrawMapItem
			RemoveHandler mapControl1.MouseUp, AddressOf mapControl1_MouseUp
			ResetOverlays()
		End Sub
		Private Sub ChangeMiniState(ByVal isEnable As Boolean)
			ChkShowMinimap.Enabled = isEnable
			If MapControl.MiniMap IsNot Nothing Then
				MapControl.MiniMap.Visible = isEnable
			End If
		End Sub
		Private Sub ResetMinMaxZoomLevel()
			MapControl.MinZoomLevel = 1
			MapControl.MaxZoomLevel = 20
		End Sub
		Private Sub SetMinMaxZoomLevel()
			MapControl.MinZoomLevel = MapControl.ZoomLevel
			MapControl.MaxZoomLevel = MapControl.MinZoomLevel + 2
		End Sub
		Private Sub SetElementsVisibility(ByVal isGeoMap As Boolean)
			HotelPlanLayer.Visible = Not isGeoMap
			HotelsLayer.Visible = isGeoMap
			TilesLayer.Visible = isGeoMap
		End Sub
		Private Function GetFileUri(ByVal item As MapItem) As Uri
			Return New Uri("file:\\" & DemoUtils.GetRelativePath(String.Format("Hotels\{0}.shp", item.Attributes("path").Value)), UriKind.RelativeOrAbsolute)
		End Function
		Private Sub HotelPlanLayer_DataLoaded(ByVal sender As Object, ByVal e As DataLoadedEventArgs) Handles HotelPlanLayer.DataLoaded
			ResetMinMaxZoomLevel()
			mapControl1.ZoomToFitLayerItems(0.3)
			SetMinMaxZoomLevel()
		End Sub
		Private Sub SetCoordPattern(ByVal digits As Integer)
			MapControl.NavigationPanelOptions.XCoordinatePattern = "{F:" & digits.ToString() & "}{MU}"
			MapControl.NavigationPanelOptions.YCoordinatePattern = "{F:" & digits.ToString() & "}{MU}"
		End Sub
		Private Sub mapControl1_MapItemClick(ByVal sender As Object, ByVal e As MapItemClickEventArgs) Handles mapControl1.MapItemClick
			ActivateCartesianMap(e.Item)
		End Sub
		Private Sub mapControl1_DrawMapItem(ByVal sender As Object, ByVal e As DrawMapItemEventArgs) Handles mapControl1.DrawMapItem
			Dim el As MapCustomElement = CType(e.Item, MapCustomElement)
			If e.IsHighlighted AndAlso (el.ImageIndex < HotelsCount) Then
				el.ImageIndex += HotelsCount
			End If
			If (Not e.IsHighlighted) AndAlso (el.ImageIndex >= HotelsCount) Then
				el.ImageIndex -= HotelsCount
			End If
		End Sub
		Private Sub mapControl1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
			If e.Button <> MouseButtons.Left Then
				Return
			End If
			Dim hitInfo As MapHitInfo = MapControl.CalcHitInfo(e.Location)
			Dim clickedItem As MapOverlayItemBase = OverlayUtils.GetClickedOverlayItem(hitInfo)
			If clickedItem Is Nothing Then
				Return
			End If
			If clickedItem Is OverlayManager.BackImage Then
				ActivateGeoMap()
			End If
		End Sub
		Private Sub toolTipController1_BeforeShow(ByVal sender As Object, ByVal e As Utils.ToolTipControllerShowEventArgs) Handles toolTipController1.BeforeShow
			e.SuperTip = tooltipHelper.CalculateSuperTooltip(TryCast(e.SelectedObject, MapItem), e.ToolTip)
		End Sub
		Private Sub OnDispose(ByVal disposing As Boolean)
			If Me.overlayManager_Renamed IsNot Nothing Then
				Me.overlayManager_Renamed.Dispose()
				Me.overlayManager_Renamed = Nothing
			End If
		End Sub
		Protected Overrides Sub RestoreInitialView()
			ActivateGeoMap()
			MapControl.CenterPoint = New GeoPoint(-21.1685, -175.1343)
			MapControl.ZoomLevel = 13
		End Sub
	End Class
End Namespace

Imports Microsoft.VisualBasic
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Globalization
Imports System.Windows.Forms
Imports System.Xml.Linq

Namespace DevExpress.XtraMap.Demos
	Partial Public Class PhotoGallery
		Inherits MapTutorialControl
		Private currentViewType As ViewType
		Private dataLoaded As Boolean
		Private citiesInfo_Renamed As WorldCitiesInfo
		Private uiControls_Renamed As UIControls
		Private overlayManager_Renamed As PhotoGalleryOverlayManager

		Protected Overrides ReadOnly Property Overlays() As MapOverlay()
			Get
				Return OverlayManager.GetOverlays()
			End Get
		End Property
		Protected ReadOnly Property OverlayManager() As PhotoGalleryOverlayManager
			Get
				If overlayManager_Renamed Is Nothing Then
					overlayManager_Renamed = New PhotoGalleryOverlayManager()
				End If
				Return overlayManager_Renamed
			End Get
		End Property
		Protected ReadOnly Property UIControls() As UIControls
			Get
				If uiControls_Renamed Is Nothing Then
					uiControls_Renamed = New UIControls() With {.Gallery = galleryControl1, .Map = mapControl1, .Preview = mapControl1.MiniMap}
				End If
				Return uiControls_Renamed
			End Get
		End Property
		Protected ReadOnly Property CitiesInfo() As WorldCitiesInfo
			Get
				If citiesInfo_Renamed Is Nothing Then
					citiesInfo_Renamed = New WorldCitiesInfo()
				End If
				Return citiesInfo_Renamed
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
			ViewMap()

			DemoUtils.SetBingMapDataProviderKey(BingMapDataProvider)
			DemoUtils.SetBingMapDataProviderKey(MiniMapDataProvider)
		End Sub

		Private Sub TilesLayer_DataLoaded(ByVal sender As Object, ByVal e As DataLoadedEventArgs) Handles TilesLayer.DataLoaded
			RemoveHandler TilesLayer.DataLoaded, AddressOf TilesLayer_DataLoaded
			ListSourceDataAdapter.DataSource = CitiesInfo.Cities
			FillMiniMapData()
		End Sub

		Private Sub FillMiniMapData()
			For Each city As CityInfo In CitiesInfo.Cities
				MiniMapData.Items.Add(New MapDot() With {.Location = New GeoPoint(city.Latitude, city.Longitude), .Size = 8})
			Next city
		End Sub
		Private Sub ItemsLayer_DataLoaded(ByVal sender As Object, ByVal e As DataLoadedEventArgs) Handles ItemsLayer.DataLoaded
			RemoveHandler ItemsLayer.DataLoaded, AddressOf ItemsLayer_DataLoaded
			StartImagesChanging()
			dataLoaded = True
		End Sub
		Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer1.Tick
			ChangeImages()
		End Sub
		Private Sub SetChkShowMinimapState(ByVal enable As Boolean)
			ChkShowMinimap.Enabled = enable
			ChkShowMinimap.Checked = enable
		End Sub
		Private Sub MapControl_Click(ByVal sender As Object, ByVal e As EventArgs)
			ResetCityGallery()
			ViewMap()
		End Sub
		Private Sub StartImagesChanging()
			MapControl.ImageList = CitiesInfo.GetImages()
			ChangeImages()
			Me.timer1.Start()
		End Sub
		Private Sub ChangeImages()
			Dim imageListTotalIndex As Integer = 0
			For Each city As CityInfo In CitiesInfo.Cities
				Dim mapElement As MapCustomElement = CType(ItemsLayer.GetMapItemBySourceObject(city), MapCustomElement)
				If mapElement IsNot Nothing Then
					mapElement.ImageIndex = imageListTotalIndex + city.CurrentImageIndex
				End If
				city.CurrentImageIndex += 1
				imageListTotalIndex += city.Places.Count
			Next city
		End Sub
		Private Sub mapControl1_SelectionChanged(ByVal sender As Object, ByVal e As MapSelectionChangedEventArgs)
			If e.Selection.Count = 0 Then
				Return
			End If
			Dim city As CityInfo = TryCast(e.Selection(0), CityInfo)
			If city Is Nothing Then
				Return
			End If
			ViewCityGallery(city)
		End Sub
		Private Sub ViewMap()
			SetChkShowMinimapState(True)
			ItemsLayer.SelectedItems.Clear()
			currentViewType = New MapViewType(UIControls, OverlayManager)
			AddHandler mapControl1.SelectionChanged, AddressOf mapControl1_SelectionChanged
		End Sub
		Private Sub ViewCityGallery(ByVal city As CityInfo)
			SetChkShowMinimapState(False)
			RemoveHandler mapControl1.SelectionChanged, AddressOf mapControl1_SelectionChanged
			AddHandler MapControl.Click, AddressOf MapControl_Click
			currentViewType = New GalleryViewType(UIControls, city, OverlayManager)
			CType(currentViewType, GalleryViewType).ApplyGalleryOptions()
		End Sub
		Private Sub ViewPlace(ByVal place As PlaceInfo)
			currentViewType = New DetailViewType(UIControls, place, OverlayManager)
		End Sub
		Private Sub galleryControlGallery1_ItemClick(ByVal sender As Object, ByVal e As GalleryItemClickEventArgs) Handles galleryControl1.Gallery.ItemClick
			ResetCityGallery()
			Dim place As PlaceInfo = CType(e.Item.Value, PlaceInfo)
			ViewPlace(place)
		End Sub
		Private Sub ResetCityGallery()
			RemoveHandler MapControl.Click, AddressOf MapControl_Click
			galleryControl1.Gallery.Groups.Clear()
		End Sub
		Private Sub PerviousPlace()
			Dim activePlace As PlaceInfo = (CType(currentViewType, DetailViewType)).Place
			Dim activeCity As CityInfo = CType(ItemsLayer.SelectedItem, CityInfo)
			ViewPlace(activeCity.GetPreviousPlace(activePlace))
		End Sub
		Private Sub NextPlace()
			Dim activePlace As PlaceInfo = (CType(currentViewType, DetailViewType)).Place
			Dim activeCity As CityInfo = CType(ItemsLayer.SelectedItem, CityInfo)
			ViewPlace(activeCity.GetNextPlace(activePlace))
		End Sub
		Private Sub lblMapView_Click(ByVal sender As Object, ByVal e As EventArgs)
			ViewMap()
		End Sub
		Private Sub mapControl1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles mapControl1.MouseUp
			If e.Button <> MouseButtons.Left Then
				Return
			End If
			Dim hitInfo As MapHitInfo = MapControl.CalcHitInfo(e.Location)
			Dim clickedItem As MapOverlayItemBase = OverlayUtils.GetClickedOverlayItem(hitInfo)
			If clickedItem Is Nothing Then
				Return
			End If
			If OverlayManager.BackIconOverlay.Items.Contains(clickedItem) Then
				ViewMap()
			ElseIf clickedItem Is OverlayManager.PlacePrevImage Then
				PerviousPlace()
			ElseIf clickedItem Is OverlayManager.PlaceNextImage Then
				NextPlace()
			End If
		End Sub
		Private Sub OnDispose(ByVal disposing As Boolean)
			If uiControls_Renamed IsNot Nothing Then
				uiControls_Renamed.Dispose()
				uiControls_Renamed = Nothing
			End If
			If overlayManager_Renamed IsNot Nothing Then
				overlayManager_Renamed.Dispose()
				overlayManager_Renamed = Nothing
			End If
		End Sub
		Private Sub PhotoGallery_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			OnStyleChanged()
		End Sub
		Protected Overrides Sub DoHide()
			MyBase.DoHide()
			Me.timer1.Stop()
		End Sub
		Protected Overrides Sub DoShow()
			MyBase.DoShow()
			If Me.dataLoaded Then
				Me.timer1.Start()
			End If
		End Sub
		Protected Overrides Sub OnStyleChanged()
			MyBase.OnStyleChanged()
			OverlayManager.RepaintImages(MapControl.LookAndFeel)
		End Sub
		Protected Overrides Sub RestoreInitialView()
			ViewMap()
			MapControl.CenterPoint = New GeoPoint(47.5, 2)
			MapControl.ZoomLevel = 0.5
		End Sub
	End Class
	Public Class WorldCitiesInfo
		Private ReadOnly cities_Renamed As List(Of CityInfo)
		Private imagesPath As String = DemoUtils.GetRelativeDirectoryPath("Images\PhotoGallery")

		Public ReadOnly Property Cities() As List(Of CityInfo)
			Get
				Return cities_Renamed
			End Get
		End Property

		Public Sub New()
			Me.cities_Renamed = LoadDataFromXML()
		End Sub
		Private Function LoadDataFromXML() As List(Of CityInfo)
			Dim cities As New List(Of CityInfo)()

			Dim path As String = DemoUtils.GetRelativePath("CitiesPlacesData.xml")
			Dim document As XDocument = XDocument.Load(path)
			If document IsNot Nothing Then
				For Each cityElement As XElement In document.Element("Cities").Elements()
					Dim cityName As String = cityElement.Element("CityName").Value
					Dim latitude As Double = Convert.ToDouble(cityElement.Element("Latitude").Value, CultureInfo.InvariantCulture)
					Dim longitude As Double = Convert.ToDouble(cityElement.Element("Longitude").Value, CultureInfo.InvariantCulture)
					Dim places As New List(Of PlaceInfo)()
					For Each placeElement As XElement In cityElement.Element("Places").Elements()
						Dim name As String = placeElement.Element("Name").Value
						Dim placeLat As Double = Convert.ToDouble(placeElement.Element("Latitude").Value, CultureInfo.InvariantCulture)
						Dim placeLon As Double = Convert.ToDouble(placeElement.Element("Longitude").Value, CultureInfo.InvariantCulture)
						Dim description As String = placeElement.Element("Description").Value
						Dim imageUri As String = placeElement.Element("ImageUri").Value
						places.Add(New PlaceInfo() With {.Name = name, .Latitude = placeLat, .Longitude = placeLon, .Description = description, .ImageUri = imagesPath & imageUri, .City = cityName})
					Next placeElement
					cities.Add(New CityInfo(places) With {.CityName = cityName, .Latitude = latitude, .Longitude = longitude})
				Next cityElement
			End If
			Return cities
		End Function

		Public Function GetImages() As ImageList
			Dim images As New ImageList() With {.ImageSize = New Size(110, 82), .ColorDepth = ColorDepth.Depth32Bit}
			For Each city As CityInfo In cities_Renamed
				For Each place As PlaceInfo In city.Places
					images.Images.Add(DemoUtils.GetInflatedImage(place.ImageUri, 14, 12))
				Next place
			Next city
			Return images
		End Function
	End Class
	Public Class CityInfo
		Private ReadOnly places_Renamed As List(Of PlaceInfo)

		Private currentImageIndex_Renamed As Integer = 0

		Public Property CityName() As String
		Public Property Latitude() As Double
		Public Property Longitude() As Double
		Public ReadOnly Property Places() As List(Of PlaceInfo)
			Get
				Return places_Renamed
			End Get
		End Property
		Public Property CurrentImageIndex() As Integer
			Get
				Return currentImageIndex_Renamed
			End Get
			Set(ByVal value As Integer)
				If value < 0 OrElse value >= Places.Count Then
					value = 0
				End If
				currentImageIndex_Renamed = value
			End Set
		End Property

		Public Sub New(ByVal places As List(Of PlaceInfo))
			Me.places_Renamed = places
		End Sub
		Public Function GetNextPlace(ByVal place As PlaceInfo) As PlaceInfo
			Dim index As Integer = Places.FindIndex(Function(p) place.Name = p.Name)
			index = If(index <> Places.Count - 1, index + 1, 0)
			Return Places(index)
		End Function
		Public Function GetPreviousPlace(ByVal place As PlaceInfo) As PlaceInfo
			Dim index As Integer = Places.FindIndex(Function(p) place.Name = p.Name)
			index = If(index <> 0, index - 1, Places.Count - 1)
			Return Places(index)
		End Function
	End Class
	Public Class PlaceInfo
		Public Property Name() As String
		Public Property Latitude() As Double
		Public Property Longitude() As Double
		Public Property Description() As String
		Public Property ImageUri() As String
		Public Property City() As String
	End Class
	Public Class UIControls
		Implements IDisposable
		Public Property Map() As MapControl
		Public Property Preview() As MiniMap
		Public Property Gallery() As GalleryControl
		Public Property InfoPanel() As PanelControl
		Public Property City() As LabelControl
		Public Property Place() As LabelControl
		Public Property Description() As LabelControl
		Public Property ImageBox() As PictureEdit

		#Region "IDisposable implementation"
		Protected Overridable Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If Map IsNot Nothing Then
					Map.Dispose()
					Map = Nothing
				End If
				If Preview IsNot Nothing Then
					Preview.Dispose()
					Preview = Nothing
				End If
				If Gallery IsNot Nothing Then
					Gallery.Dispose()
					Gallery = Nothing
				End If
				If InfoPanel IsNot Nothing Then
					InfoPanel.Dispose()
					InfoPanel = Nothing
				End If
				If City IsNot Nothing Then
					City.Dispose()
					City = Nothing
				End If
				If Place IsNot Nothing Then
					Place.Dispose()
					Place = Nothing
				End If
				If Description IsNot Nothing Then
					Description.Dispose()
					Description = Nothing
				End If
				If ImageBox IsNot Nothing Then
					ImageBox.Dispose()
					ImageBox = Nothing
				End If
			End If
		End Sub
		Public Sub Dispose() Implements IDisposable.Dispose
			Dispose(True)
			GC.SuppressFinalize(Me)
		End Sub
		Protected Overrides Sub Finalize()
			Dispose(False)
		End Sub
		#End Region
	End Class
	Public MustInherit Class ViewType
		Private overlayManager_Renamed As PhotoGalleryOverlayManager
		Private uiControls_Renamed As UIControls

		Protected ReadOnly Property OverlayManager() As PhotoGalleryOverlayManager
			Get
				Return overlayManager_Renamed
			End Get
		End Property
		Protected ReadOnly Property UIControls() As UIControls
			Get
				Return uiControls_Renamed
			End Get
		End Property
		Protected ReadOnly Property Map() As MapControl
			Get
				Return UIControls.Map
			End Get
		End Property
		Protected ReadOnly Property Gallery() As GalleryControl
			Get
				Return UIControls.Gallery
			End Get
		End Property
		Protected ReadOnly Property ItemsLayer() As VectorItemsLayer
			Get
				Return CType(Map.Layers("ItemsLayer"), VectorItemsLayer)
			End Get
		End Property
		Protected ReadOnly Property PushpinLayer() As VectorItemsLayer
			Get
				Return CType(Map.Layers("PushpinLayer"), VectorItemsLayer)
			End Get
		End Property
		Protected MustOverride ReadOnly Property MaxZoomLevel() As Double
		Protected MustOverride ReadOnly Property MinZoomLevel() As Double
		Protected MustOverride ReadOnly Property MapViewItemsVisible() As Boolean
		Protected MustOverride ReadOnly Property GalleryViewItemsVisible() As Boolean
		Protected MustOverride ReadOnly Property DetailViewItemsVisible() As Boolean

		Protected Sub New(ByVal controls As UIControls, ByVal overlayManager As PhotoGalleryOverlayManager)
			Me.overlayManager_Renamed = overlayManager
			Me.uiControls_Renamed = controls
			ApplyOptions()
		End Sub
		Private Sub Gallery_Paint(ByVal sender As Object, ByVal e As PaintEventArgs)
			RemoveHandler Gallery.Paint, AddressOf Gallery_Paint
			DevExpress.XtraMap.Native.OverlapFlickeringSolver.Refresh(Map.FindForm())
		End Sub
		Protected Overridable Sub ApplyOptions()
			SetMinMaxZoomLevel()
			Map.EnableScrolling = Not GalleryViewItemsVisible
			Map.EnableZooming = Not GalleryViewItemsVisible
			ItemsLayer.Visible = MapViewItemsVisible
			PushpinLayer.Visible = DetailViewItemsVisible
			If GalleryViewItemsVisible Then
				AddHandler Gallery.Paint, AddressOf Gallery_Paint
			End If
			Gallery.Visible = GalleryViewItemsVisible
			uiControls_Renamed.Preview.Visible = MapViewItemsVisible
			overlayManager_Renamed.BackIconOverlay.Visible = DetailViewItemsVisible
			overlayManager_Renamed.PlaceOverlay.Visible = DetailViewItemsVisible
			overlayManager_Renamed.NavigationOverlay.Visible = DetailViewItemsVisible
			overlayManager_Renamed.DescriptionOverlay.Visible = DetailViewItemsVisible
		End Sub
		Private Sub SetMinMaxZoomLevel()
			If Map.MaxZoomLevel < MinZoomLevel Then
				Map.MaxZoomLevel = MaxZoomLevel
				Map.MinZoomLevel = MinZoomLevel
			Else
				Map.MinZoomLevel = MinZoomLevel
				Map.MaxZoomLevel = MaxZoomLevel
			End If
		End Sub
	End Class
	Public Class MapViewType
		Inherits ViewType
		Private Const MaxZoom As Integer = 7
		Private Const MinZoom As Integer = 5

		Protected Overrides ReadOnly Property MaxZoomLevel() As Double
			Get
				Return MaxZoom
			End Get
		End Property
		Protected Overrides ReadOnly Property MinZoomLevel() As Double
			Get
				Return MinZoom
			End Get
		End Property
		Protected Overrides ReadOnly Property MapViewItemsVisible() As Boolean
			Get
				Return True
			End Get
		End Property
		Protected Overrides ReadOnly Property GalleryViewItemsVisible() As Boolean
			Get
				Return False
			End Get
		End Property
		Protected Overrides ReadOnly Property DetailViewItemsVisible() As Boolean
			Get
				Return False
			End Get
		End Property

		Public Sub New(ByVal controls As UIControls, ByVal overlayManager As PhotoGalleryOverlayManager)
			MyBase.New(controls, overlayManager)
		End Sub
		Protected Overrides Sub ApplyOptions()
			MyBase.ApplyOptions()
			Map.ZoomLevel = MinZoomLevel
		End Sub
	End Class
	Public Class GalleryViewType
		Inherits ViewType
		Private Const MaxZoom As Integer = 7
		Private Const MinZoom As Integer = 5

		Private city_Renamed As CityInfo

		Protected Overrides ReadOnly Property MaxZoomLevel() As Double
			Get
				Return MaxZoom
			End Get
		End Property
		Protected Overrides ReadOnly Property MinZoomLevel() As Double
			Get
				Return MinZoom
			End Get
		End Property
		Protected Overrides ReadOnly Property MapViewItemsVisible() As Boolean
			Get
				Return False
			End Get
		End Property
		Protected Overrides ReadOnly Property GalleryViewItemsVisible() As Boolean
			Get
				Return True
			End Get
		End Property
		Protected Overrides ReadOnly Property DetailViewItemsVisible() As Boolean
			Get
				Return False
			End Get
		End Property
		Public ReadOnly Property City() As CityInfo
			Get
				Return city_Renamed
			End Get
		End Property

		Public Sub New(ByVal controls As UIControls, ByVal city As CityInfo, ByVal overlayManager As PhotoGalleryOverlayManager)
			MyBase.New(controls, overlayManager)
			Me.city_Renamed = city
		End Sub
		Public Sub ApplyGalleryOptions()
			Dim galleryGroup As New GalleryItemGroup() With {.Caption = city_Renamed.CityName, .CaptionAlignment = GalleryItemGroupCaptionAlignment.Center}
			For Each place As PlaceInfo In city_Renamed.Places
				Dim item As New GalleryItem(Image.FromFile(place.ImageUri), place.Name, "")
				item.Value = place
				galleryGroup.Items.Add(item)
			Next place
			Gallery.Gallery.Groups.Add(galleryGroup)
			Dim img As Image = DemoUtils.GetBackGroundImage(Map, New Rectangle(Gallery.Location, Gallery.Size), 0.5f)
			If img IsNot Nothing Then
				Gallery.Gallery.BackgroundImage = img
			End If
		End Sub
	End Class
	Public Class DetailViewType
		Inherits ViewType
		Private Const MaxZoom As Integer = 18
		Private Const MinZoom As Integer = 15

		Private place_Renamed As PlaceInfo

		Private ReadOnly Property Pushpin() As MapPushpin
			Get
				Return CType((CType((PushpinLayer).Data, MapItemStorage)).Items(0), MapPushpin)
			End Get
		End Property
		Private ReadOnly Property LabelCity() As LabelControl
			Get
				Return UIControls.City
			End Get
		End Property
		Private ReadOnly Property LabelPlace() As LabelControl
			Get
				Return UIControls.Place
			End Get
		End Property
		Private ReadOnly Property LabelDescription() As LabelControl
			Get
				Return UIControls.Description
			End Get
		End Property
		Private ReadOnly Property ImageBox() As PictureEdit
			Get
				Return UIControls.ImageBox
			End Get
		End Property
		Protected Overrides ReadOnly Property MaxZoomLevel() As Double
			Get
				Return MaxZoom
			End Get
		End Property
		Protected Overrides ReadOnly Property MinZoomLevel() As Double
			Get
				Return MinZoom
			End Get
		End Property
		Protected Overrides ReadOnly Property MapViewItemsVisible() As Boolean
			Get
				Return False
			End Get
		End Property
		Protected Overrides ReadOnly Property GalleryViewItemsVisible() As Boolean
			Get
				Return False
			End Get
		End Property
		Protected Overrides ReadOnly Property DetailViewItemsVisible() As Boolean
			Get
				Return True
			End Get
		End Property
		Public ReadOnly Property Place() As PlaceInfo
			Get
				Return place_Renamed
			End Get
		End Property

		Public Sub New(ByVal controls As UIControls, ByVal place As PlaceInfo, ByVal overlayManager As PhotoGalleryOverlayManager)
			MyBase.New(controls, overlayManager)
			Me.place_Renamed = place
			ApplyPlaceOptions()
		End Sub
		Private Sub ApplyPlaceOptions()
			Map.CenterPoint = New GeoPoint(place_Renamed.Latitude, place_Renamed.Longitude)
			Pushpin.Location = Map.CenterPoint
			OverlayManager.PlaceImage.Image = Image.FromFile(place_Renamed.ImageUri)
			OverlayManager.CityName.Text = place_Renamed.City
			OverlayManager.PlaceName.Text = place_Renamed.Name
			OverlayManager.PlaceDescription.Text = place_Renamed.Description
		End Sub
	End Class
End Namespace

Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Map
Imports DevExpress.Utils
Imports DevExpress.XtraMap.Native
Imports DevExpress.XtraBars

Namespace DevExpress.XtraMap.Demos
	Partial Public Class BingServices
		Inherits MapTutorialControl
		Private ReadOnly defaultRouteColor As Color = Color.FromArgb(&HFF, &H8A, &HFB, &HFF)
		Public Const DefaultStrokeWidth As Integer = 4

		Private overlayManager_Renamed As BingServicesOverlayManager
		Private routeHelper_Renamed As RouteHelper
		Private activeItem As MapItem
		Private state_Renamed As RouteState = RouteState.Normal

		Protected Overrides ReadOnly Property Overlays() As MapOverlay()
			Get
				Return OverlayManager.GetOverlays()
			End Get
		End Property
		Protected Overrides ReadOnly Property MiniMapBingKind() As BingMapKind
			Get
				Return BingMapKind.Hybrid
			End Get
		End Property
		Public Overrides ReadOnly Property MapControl() As MapControl
			Get
				Return mapControl1
			End Get
		End Property

		Private ReadOnly Property OverlayManager() As BingServicesOverlayManager
			Get
				If overlayManager_Renamed Is Nothing Then
					overlayManager_Renamed = New BingServicesOverlayManager()
				End If
				Return overlayManager_Renamed
			End Get
		End Property
		Protected ReadOnly Property RouteHelper() As RouteHelper
			Get
				If routeHelper_Renamed Is Nothing Then
					routeHelper_Renamed = New RouteHelper()
					AddHandler routeHelper_Renamed.WaypointsChanged, AddressOf OnWaypointsChanged
				End If
				Return routeHelper_Renamed
			End Get
		End Property

		Protected ReadOnly Property RouteLayerItems() As MapItemCollection
			Get
				Return CType(RouteLayer.Data.Items, MapItemCollection)
			End Get
		End Property

		Public Property State() As RouteState
			Get
				Return state_Renamed
			End Get
			Set(ByVal value As RouteState)
				If state_Renamed = value Then
					Return
				End If
				state_Renamed = value
				OnRouteStateChanged()
			End Set
		End Property

		Public Sub New()
			InitializeComponent()
			PrepareLayerProviders()
		End Sub
		Private Sub UpdateInformationText()
			OverlayManager.MessageItem.Text = GetActionText()
		End Sub
		Private Sub SetRouteLayerStyles(ByVal routeLayer As InformationLayer)
			routeLayer.SelectedItemStyle.Stroke = defaultRouteColor
			routeLayer.ItemStyle.Stroke = routeLayer.SelectedItemStyle.Stroke
			routeLayer.SelectedItemStyle.StrokeWidth = DefaultStrokeWidth
			routeLayer.ItemStyle.StrokeWidth = routeLayer.SelectedItemStyle.StrokeWidth
		End Sub
		Private Sub PrepareLayerProviders()
			DemoUtils.SetBingMapDataProviderKey(BingMapDataProvider)
			DemoUtils.SetBingMapDataProviderKey(SearchProvider)
			DemoUtils.SetBingMapDataProviderKey(GeoCodeProvider)
			DemoUtils.SetBingMapDataProviderKey(RouteProvider)
			SetRouteLayerStyles(RouteLayer)
		End Sub
		Private Sub OnRouteStateChanged()
			Dim isDriving As Boolean = State = RouteState.Drive
			mapControl1.ShowSearchPanel = Not isDriving
			GeoCodeProvider.ProcessMouseEvents = Not isDriving

			Select Case State
				Case RouteState.Drive
					RouteHelper.BeginDrive(MapControl, RouteLayer)
					AddHandler RouteHelper.DriveModel.ActionTextChanged, Function(s, e) OverlayManager.MessageItem.Text = RouteHelper.DriveModel.ActionText
					AddHandler RouteHelper.DriveModel.CurrentLocationChanged, Function(s, e) mapControl1.CenterPoint = RouteHelper.DriveModel.CurrentLocation
					Me.driveButton.Enabled = False
					Me.stopButton.Enabled = True
					Me.clearButton.Enabled = False
				Case RouteState.Normal
					RouteHelper.StopDrive()
					Me.driveButton.Enabled = True
					Me.stopButton.Enabled = False
					Me.clearButton.Enabled = True
			End Select
			UpdateInformationText()
		End Sub
		Private Sub OnWaypointsChanged(ByVal sender As Object, ByVal e As EventArgs)
			DataAdapter.DataSource = New List(Of WayPointInfo)(RouteHelper.WaypointInfoList)
			If RouteHelper.Waypoints.Count > 1 Then
				RouteProvider.CalculateRoute(RouteHelper.Waypoints)
			Else
				driveButton.Enabled = False
			End If
		End Sub
		Private Sub OnRouteLayerItemsGenerating(ByVal sender As Object, ByVal args As LayerItemsGeneratingEventArgs) Handles RouteProvider.LayerItemsGenerating
			If args.Error Is Nothing AndAlso (Not args.Cancelled) Then
				RouteHelper.ProcessRouteItems(args.Items)
			End If
		End Sub
		Private Sub OnRouteCalculated(ByVal sender As Object, ByVal e As BingRouteCalculatedEventArgs) Handles RouteProvider.RouteCalculated
			Dim results As List(Of BingRouteResult) = e.CalculationResult.RouteResults
			Dim routeResult As BingRouteResult = If(results.Count > 0, results(0), Nothing)
			If RouteHelper.ProcessRouteResult(routeResult) Then
				DataAdapter.DataSource = Nothing
				driveButton.Enabled = True
			End If
		End Sub
		Private Sub OnGeoCodeAndSearchLayerItemsGenerating(ByVal sender As Object, ByVal args As LayerItemsGeneratingEventArgs) Handles GeoCodeProvider.LayerItemsGenerating, SearchProvider.LayerItemsGenerating
			If state_Renamed = RouteState.Drive Then
				Return
			End If
			For Each item As MapItem In args.Items
				RouteHelper.AddGeneratedPushpin(TryCast(item, MapPushpin))
			Next item

			UpdateInformationText()
		End Sub
		Private Sub clearButton_ItemClick(ByVal sender As Object, ByVal e As EventArgs) Handles clearButton.ItemClick
			RouteHelper.Clear()
			ClearLayerResults()
			RouteLayer.ClearResults()
			SearchProvider.ClearSearchPanel()
			DataAdapter.DataSource = Nothing
			driveButton.Enabled = False
			stopButton.Enabled = False
			UpdateInformationText()
		End Sub
		Private Sub ClearLayerResults()
			SearchLayer.ClearResults()
			GeocodeLayer.ClearResults()
		End Sub
		Private Function CanRemovePin(ByVal pin As MapPushpin, ByVal e As MapItemClickEventArgs) As Boolean
			Return pin IsNot Nothing AndAlso Object.Equals(RouteLayer, pin.Layer) AndAlso e.MouseArgs.Button = MouseButtons.Right AndAlso Me.State <> RouteState.Drive
		End Function
		Private Sub mapControl1_MapItemClick(ByVal sender As Object, ByVal e As MapItemClickEventArgs) Handles mapControl1.MapItemClick
			Dim pin As MapPushpin = TryCast(e.Item, MapPushpin)
			If CanRemovePin(pin, e) Then
				Me.activeItem = pin
				popupMenu1.ShowPopup(Cursor.Position)
			End If
			If e.MouseArgs.Button = MouseButtons.Left Then
				If RouteHelper.GeneratedPushpins.Contains(pin) Then
					AddPointToRoute(pin)
					e.Handled = True
				End If
			End If
			UpdateInformationText()
		End Sub
		Private Sub AddPointToRoute(ByVal pushpin As MapPushpin)
			RouteHelper.AddWaypoint(pushpin)
			ClearLayerResults()
		End Sub
		Private Sub DeleteWaypoint()
			Dim index As Integer = CalculatePushpinIndex()
			RouteLayerItems.Remove(Me.activeItem)
			RouteHelper.DeleteWaypoint(index)
			ClearRoute()
		End Sub
		Private Sub ClearRoute()
			Dim itemsToRemove As New List(Of MapItem)()
			For Each item As MapItem In RouteLayerItems
				If TypeOf item Is MapPolyline Then
					itemsToRemove.Add(item)
				End If
			Next item
			For Each item As MapItem In itemsToRemove
				RouteLayerItems.Remove(item)
			Next item
		End Sub
		Private Function CalculatePushpinIndex() As Integer
			Dim items As MapItemCollection = RouteLayerItems
			Dim index As Integer = -1
			For i As Integer = 0 To items.Count - 1
				If TypeOf items(i) Is MapPushpin Then
					index += 1
					If items(i).Equals(Me.activeItem) Then
						Return index
					End If
				End If
			Next i
			Return -1
		End Function
		Private Sub barDeleteButton_ItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles barDeleteButton.ItemClick
			DeleteWaypoint()
		End Sub
		Private Sub barCloseButton_ItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles barCloseButton.ItemClick
			popupMenu1.HidePopup()
		End Sub
		Private Sub driveButton_ItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles driveButton.ItemClick
			State = RouteState.Drive
		End Sub
		Private Sub stopButton_ItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles stopButton.ItemClick
			State = RouteState.Normal
		End Sub
		Private Sub OnDispose(ByVal disposing As Boolean)
			If Me.routeHelper_Renamed IsNot Nothing Then
				Me.routeHelper_Renamed.Dispose()
				Me.routeHelper_Renamed = Nothing
			End If
			If Me.overlayManager_Renamed IsNot Nothing Then
				Me.overlayManager_Renamed.Dispose()
				Me.overlayManager_Renamed = Nothing
			End If
		End Sub
		Private Function GetActionText() As String
			If Me.RouteHelper.Waypoints.Count = 0 Then
				If Me.RouteHelper.GeneratedPushpins.Count > 0 Then
					Return "Click the pushpin to set a start point."
				Else
					Return "Click the map or use Search to find a location."
				End If
			End If

			If Me.RouteHelper.Waypoints.Count = 1 Then
				Return "Set a finish point to calculate a route."
			End If


			Return "Set another finish point or click Drive."
		End Function
		Protected Overrides Sub InitRibbon()
			MyBase.InitRibbon()
			OptionsPage.Groups.Add(actionPageGroup)
			OptionsPage.Ribbon.Items.Add(clearButton)
			OptionsPage.Ribbon.Items.Add(driveButton)
			OptionsPage.Ribbon.Items.Add(stopButton)
		End Sub
		Protected Overrides Sub RestoreInitialView()
			MapControl.CenterPoint = New GeoPoint(34.158506, -118.255629)
			MapControl.ZoomLevel = 14
		End Sub
		Protected Overrides Sub DoHide()
			If State = RouteState.Drive Then
				State = RouteState.Normal
			End If
			MyBase.DoHide()
		End Sub
	End Class
	Public Enum RouteState
		Normal
		Drive
	End Enum
	Public Class WayPointInfo
		Public Property Latitude() As Double
		Public Property Longitude() As Double
		Public Property Text() As String
		Public Property ToolTipPattern() As String
		Public Property Type() As Integer
	End Class
	Public Class RouteHelper
		Implements IDisposable
		Private disposed As Boolean = False
		Private generatedPushpins_Renamed As New List(Of MapPushpin)()
		Private waypoints_Renamed As New List(Of RouteWaypoint)()
		Private waypointsInfoList As New List(Of WayPointInfo)()
		Private routePath As New List(Of GeoPoint)()
		Private itineraryItems As New List(Of BingItineraryItem)()

		Private waypointIndex As Integer = 0

		Public ReadOnly Property GeneratedPushpins() As List(Of MapPushpin)
			Get
				Return generatedPushpins_Renamed
			End Get
		End Property
		Public ReadOnly Property Waypoints() As List(Of RouteWaypoint)
			Get
				Return waypoints_Renamed
			End Get
		End Property
		Public ReadOnly Property WaypointInfoList() As List(Of WayPointInfo)
			Get
				Return waypointsInfoList
			End Get
		End Property
		Public Property DriveModel() As DriveHelper

		Public Event WaypointsChanged As EventHandler

		Public Sub AddGeneratedPushpin(ByVal pushpin As MapPushpin)
			If pushpin IsNot Nothing AndAlso (Not GeneratedPushpins.Contains(pushpin)) Then
				GeneratedPushpins.Add(pushpin)
			End If
		End Sub
		Public Sub Clear()
			waypointIndex = 0
			Waypoints.Clear()
			GeneratedPushpins.Clear()
			WaypointInfoList.Clear()
		End Sub
		Public Sub AddWaypoint(ByVal generatedPushpin As MapPushpin)
			Dim pushpinLocation As GeoPoint = CType(generatedPushpin.Location, GeoPoint)
			Dim info As LocationInformation = TryCast(generatedPushpin.Information, LocationInformation)
			Dim description As String = If(info IsNot Nothing, info.DisplayName, String.Empty)
			Dim location As GeoPoint = pushpinLocation
			Dim waypoint As New RouteWaypoint(description, location)
			If waypoints_Renamed.Contains(waypoint) Then
				Return
			End If

			waypoints_Renamed.Add(waypoint)
			Dim pointInfo As WayPointInfo = CreateWayPointInfo(pushpinLocation, Convert.ToString(info))
			WaypointInfoList.Add(pointInfo)
			GeneratedPushpins.Clear()
			RaiseWayPointChanged()
		End Sub
		Private Function CreateWayPointInfo(ByVal location As GeoPoint, ByVal info As String) As WayPointInfo
			Dim pointInfo As New WayPointInfo()
			pointInfo.Type = CInt(Fix(MapItemType.Pushpin))
			pointInfo.ToolTipPattern = info
			pointInfo.Text = NextWaypointLetter()
			pointInfo.Latitude = location.Latitude
			pointInfo.Longitude = location.Longitude
			Return pointInfo
		End Function
		Private Sub RaiseWayPointChanged()
			RaiseEvent WaypointsChanged(Me, EventArgs.Empty)
		End Sub
		Protected Function NextWaypointLetter() As String
			Dim letter As String = "" & ChrW(CByte(AscW("A"c)) + waypointIndex Mod 26)
			waypointIndex += 1
			Return letter
		End Function
		Protected Overridable Sub Dispose(ByVal disposing As Boolean)
			If disposed Then
				Return
			End If
			If disposing Then
				If DriveModel IsNot Nothing Then
					DriveModel.Dispose()
				End If
			End If
			disposed = True
		End Sub

		Public Sub ProcessRouteItems(ByVal items() As MapItem)
			GeneratedPushpins.Clear()
			WaypointInfoList.Clear()
			waypointIndex = 0

			For Each item As MapItem In items
				Dim pushpin As MapPushpin = TryCast(item, MapPushpin)
				If pushpin IsNot Nothing Then
					pushpin.Text = NextWaypointLetter()
				End If
			Next item
		End Sub
		Public Function ProcessRouteResult(ByVal result As BingRouteResult) As Boolean
			If result Is Nothing Then
				Return False
			End If
			routePath = result.RoutePath
			itineraryItems.Clear()
			For Each leg As BingRouteLeg In result.Legs
				For Each item As BingItineraryItem In leg.Itinerary
					itineraryItems.Add(item)
				Next item
			Next leg
			Return True
		End Function

		Public Sub DeleteWaypoint(ByVal index As Integer)
			If index < 0 OrElse index >= Waypoints.Count Then
				Return
			End If
			Waypoints.RemoveAt(index)
			RaiseWayPointChanged()
		End Sub
		Public Sub StopDrive()
			If DriveModel IsNot Nothing Then
				DriveModel.Cleanup()
				DriveModel.Dispose()
				DriveModel = Nothing
			End If
		End Sub
		Public Sub BeginDrive(ByVal map As MapControl, ByVal routeLayer As InformationLayer)
			If (routePath IsNot Nothing) AndAlso (routePath.Count > 1) Then
				StopDrive()
				DriveModel = New DriveHelper(map, routeLayer, routePath, itineraryItems)
			End If
		End Sub
		Public Sub Dispose() Implements IDisposable.Dispose
			Dispose(True)
			GC.SuppressFinalize(Me)
		End Sub

	End Class

	Public Class DriveHelper
		Implements IDisposable
		Private Shared ReadOnly driveMarker_Renamed As New Bitmap(DemoUtils.GetRelativePath("\Images\Pin.png"))

		Private Const DriveSpeed As Double = 100.0
		Private Const ScaleFactor As Double = 5.0
		Private Const DriveTimeQuant As Integer = 10
		Private Const DriveTimeQuantInSeconds As Double = CDbl(DriveTimeQuant) / 1000
		Private ReadOnly DefaultDriveColor As Color = Color.FromArgb(&HFF, &HFE, &H72, &HFF)
		Private Const DefaultStrokeWidth As Integer = BingServices.DefaultStrokeWidth

		Private routeLayer As InformationLayer
		Private routeLayerItems As MapItemCollection
		Private routePath As List(Of GeoPoint)
		Private drivePath As MapPolyline
		Private driveItems As ObservableCollection(Of MapItem)
		Private driveCustomElement As MapCustomElement
		Private animationTimer As Timer
		Private baseLocation As New GeoPoint()
		Private targetLocation As New GeoPoint()
		Private basePoint As MapUnit
		Private targetPoint As MapUnit
		Private currentDistance As Double
		Private distance As Double
		Private currentPoint As MapUnit
		Private itineraryItems As List(Of BingItineraryItem)
		Private routeNodeIndex As Integer
		Private actionText_Renamed As String
		Private map As MapControl
		Private disposed As Boolean = False

		Public ReadOnly Property CurrentLocation() As GeoPoint
			Get
				Return CType(map.MapUnitToCoordPoint(currentPoint), GeoPoint)
			End Get
		End Property
		Public Property ActionText() As String
			Get
				Return actionText_Renamed
			End Get
			Set(ByVal value As String)
				actionText_Renamed = value
				RaiseEvent ActionTextChanged(Me, New PropertyChangedEventArgs("ActionText"))
			End Set
		End Property
		Public ReadOnly Property DriveMarker() As Image
			Get
				Return driveMarker_Renamed
			End Get
		End Property

		Public Event CurrentLocationChanged As PropertyChangedEventHandler
		Public Event ActionTextChanged As PropertyChangedEventHandler

		Public Shared Function KilometerPerHourToMapUnitsPerSecond(ByVal kmh As Double) As Double
			Return kmh / 40000.0 / 360.0
		End Function
		Public Shared Function DistanceBetweenPoints(ByVal a As MapUnit, ByVal b As MapUnit) As Double
			Dim vector As New MapUnit(b.X - a.X, b.Y - a.Y)
			Return Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y)
		End Function

		Public Sub New(ByVal map As MapControl, ByVal routeLayer As InformationLayer, ByVal routePath As List(Of GeoPoint), ByVal itineraryItems As List(Of BingItineraryItem))
			Me.map = map
			Me.routeLayer = routeLayer
			Me.routeLayerItems = CType(routeLayer.Data.Items, MapItemCollection)
			Me.routePath = routePath
			Me.itineraryItems = CreateItineraryItems(itineraryItems)
			Me.drivePath = New MapPolyline() With {.Stroke = DefaultDriveColor, .StrokeWidth = DefaultStrokeWidth}
			Me.drivePath.Points.Add(targetLocation)
			Me.driveCustomElement = New MapCustomElement() With {.Location = routePath(0), .Visible = True, .Image = DriveMarker, .UseAnimation = False, .BackgroundDrawingMode = ElementState.None}
			Me.animationTimer = New Timer()
			Me.animationTimer.Interval = DriveTimeQuant
			AddHandler animationTimer.Tick, AddressOf OnTimerTick
			targetLocation = routePath(0)
			baseLocation = targetLocation
			basePoint = map.CoordPointToMapUnit(baseLocation)
			currentPoint = basePoint
			targetPoint = map.CoordPointToMapUnit(targetLocation)
			currentDistance = 0
			distance = 0
			routeNodeIndex = 0
			driveItems = New ObservableCollection(Of MapItem)()
			driveItems.Add(drivePath)
			driveItems.Add(driveCustomElement)
			Me.routeLayerItems.AddRange(driveItems)
			Advance()
		End Sub
		Private Function CreateItineraryItems(ByVal itineraryItems As List(Of BingItineraryItem)) As List(Of BingItineraryItem)
			Dim items As New List(Of BingItineraryItem)(itineraryItems.Count)
			For i As Integer = 0 To itineraryItems.Count - 1
				items.Add(itineraryItems(i))
			Next i
			Return items
		End Function

		Private Function Advance() As Boolean
			If routeNodeIndex < (routePath.Count - 1) Then
				routeNodeIndex += 1
				baseLocation = targetLocation
				currentPoint = map.CoordPointToMapUnit(baseLocation)
				targetLocation = routePath(routeNodeIndex)
				basePoint = map.CoordPointToMapUnit(baseLocation)
				targetPoint = map.CoordPointToMapUnit(targetLocation)
				distance = DriveHelper.DistanceBetweenPoints(targetPoint, basePoint)
				currentDistance = 0

				drivePath.Points(drivePath.Points.Count - 1) = baseLocation
				drivePath.Points.Add(baseLocation)

				CheckItinerary()

				If (Not animationTimer.Enabled) Then
					animationTimer.Start()
				End If
				Return True
			Else
				If animationTimer.Enabled Then
					animationTimer.Stop()
				End If
				driveCustomElement.Visible = False
				Return False
			End If
		End Function
		Private Sub CheckItinerary()
			Dim location As GeoPoint = CType(map.MapUnitToCoordPoint(currentPoint), GeoPoint)
			Dim currentItem As BingItineraryItem = itineraryItems(0)
			Dim geoSize As New MapSize(Math.Abs(location.Latitude - currentItem.Location.Latitude), Math.Abs(location.Longitude - currentItem.Location.Longitude))
			Dim metricSize As MapSize = map.CoordToMeasureUnitSize(location, geoSize)
			Dim distance As Double = Math.Sqrt(metricSize.Width * metricSize.Width + metricSize.Height * metricSize.Height)
			If distance < 0.005 Then
				If itineraryItems.Count > 1 Then
					itineraryItems.Remove(currentItem)
				Else
					distance = 0.0
				End If
			End If
			If distance > 0.0 Then
				ActionText = itineraryItems(0).Maneuver.ToString() & " after " & (If((distance > 0.9), String.Format("{0:0} km", Math.Ceiling(distance)), String.Format("{0:0} m", Math.Ceiling(distance * 10) * 100)))
			Else
				ActionText = "Finish! Click Stop and Clear to set a new route."
			End If
		End Sub
		Private Sub OnTimerTick(ByVal sender As Object, ByVal e As EventArgs)
			Dim scaledTime As Double = DriveTimeQuantInSeconds * ScaleFactor
			Do While scaledTime > 0.0
				Dim quant As Double = Math.Min(scaledTime, DriveTimeQuantInSeconds)
				Dim excess As Double = Update(quant * DriveHelper.KilometerPerHourToMapUnitsPerSecond(DriveSpeed))
				If excess > 0.0 Then
					If (Not Advance()) Then
						CheckItinerary()
						PlaceItems(CType(map.MapUnitToCoordPoint(currentPoint), GeoPoint))
						Return
					End If
					excess = Update(excess)
				End If
				PlaceItems(CType(map.MapUnitToCoordPoint(currentPoint), GeoPoint))
				CheckItinerary()
				scaledTime -= quant
			Loop
		End Sub
		Private Function Update(ByVal distanceToGo As Double) As Double
			currentDistance += distanceToGo
			If currentDistance > distance Then
				currentPoint = targetPoint
				Return currentDistance - distance
			End If
			Dim offset As MapUnit = GetDirection()
			offset.X *= currentDistance
			offset.Y *= currentDistance
			currentPoint = New MapUnit(basePoint.X + offset.X, basePoint.Y + offset.Y)
			Return 0.0
		End Function
		Private Function GetDirection() As MapUnit
			Dim direction As New MapUnit(targetPoint.X - basePoint.X, targetPoint.Y - basePoint.Y)
			Dim length As Double = Math.Sqrt(direction.X * direction.X + direction.Y * direction.Y)
			If length > 0.0 Then
				Dim oneByLenght As Double = 1 / length
				direction.X *= oneByLenght
				direction.Y *= oneByLenght
			End If
			Return direction
		End Function
		Private Sub PlaceItems(ByVal location As GeoPoint)
			drivePath.Points(drivePath.Points.Count - 1) = location
			driveCustomElement.Location = location
			RaiseEvent CurrentLocationChanged(Me, New PropertyChangedEventArgs("CurrentLocation"))
		End Sub

		Protected Overridable Sub Dispose(ByVal disposing As Boolean)
			If disposed Then
				Return
			End If
			If disposing Then
				If animationTimer IsNot Nothing Then
					animationTimer.Stop()
					RemoveHandler animationTimer.Tick, AddressOf OnTimerTick
					animationTimer.Dispose()
				End If
			End If
			disposed = True
		End Sub

		Public Sub Cleanup()
			If animationTimer.Enabled Then
				animationTimer.Stop()
			End If
			drivePath.Points.Clear()
			driveCustomElement.Visible = False
			For Each item As MapItem In driveItems
				Me.routeLayerItems.Remove(item)
			Next item
			driveItems.Clear()
		End Sub
		Public Sub Dispose() Implements IDisposable.Dispose
			Dispose(True)
			GC.SuppressFinalize(Me)
		End Sub
	End Class
End Namespace

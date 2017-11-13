Imports DevExpress.XtraMap.Services
Imports DevExpress.XtraMap
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.DevAV
Imports System.Text.RegularExpressions
Imports System.Collections.Generic
Imports System

Namespace DevExpress.DevAV.Presenters

    Public MustInherit Class RouteMapPresenter(Of TEntity As Class, TViewModel As {Class, IRouteMapViewModel})
        Inherits BasePresenter(Of TViewModel)

        Private mapControlCore As MapControl
        Private updateUIActionCore As Action(Of TEntity)
        Private updateRouteListActionCore As Action(Of List(Of RoutePoint))
        Public Sub New(ByVal mapControl As MapControl, ByVal viewModel As TViewModel, ByVal updateUIAction As Action(Of TEntity), ByVal updateRouteList As Action(Of List(Of RoutePoint)))
            MyBase.New(viewModel)
            Me.mapControlCore = mapControl
            Me.updateUIActionCore = updateUIAction
            Me.updateRouteListActionCore = updateRouteList
            If Me.MapControl IsNot Nothing Then
                BindMap()
                SubscribeRouteProviderEvents()
            End If
            SubscribeViewModelEvents()
        End Sub
        Protected Overrides Sub OnDisposing()
            If MapControl IsNot Nothing Then
                UnsubscribeRouteProviderEvents()
            End If
            UnsubscribeViewModelEvents()
            Me.updateUIActionCore = Nothing
            Me.updateRouteListActionCore = Nothing
            Me.mapControlCore = Nothing
            MyBase.OnDisposing()
        End Sub
        Public ReadOnly Property MapControl() As MapControl
            Get
                Return mapControlCore
            End Get
        End Property
        Protected ReadOnly Property TilesLayer() As ImageLayer
            Get
                Return CType(MapControl.Layers(0), ImageLayer)
            End Get
        End Property
        Protected ReadOnly Property GeoCodeLayer() As InformationLayer
            Get
                Return CType(MapControl.Layers(1), InformationLayer)
            End Get
        End Property
        Protected ReadOnly Property RouteLayer() As InformationLayer
            Get
                Return CType(MapControl.Layers(3), InformationLayer)
            End Get
        End Property
        Protected ReadOnly Property TilesProvider() As BingMapDataProvider
            Get
                Return CType(TilesLayer.DataProvider, BingMapDataProvider)
            End Get
        End Property
        Protected ReadOnly Property GeoCodeProvider() As BingGeocodeDataProvider
            Get
                Return CType(GeoCodeLayer.DataProvider, BingGeocodeDataProvider)
            End Get
        End Property
        Protected ReadOnly Property RouteProvider() As BingRouteDataProvider
            Get
                Return CType(RouteLayer.DataProvider, BingRouteDataProvider)
            End Get
        End Property
        Private zoomService As IZoomToRegionService
        Private Sub BindMap()
            TilesProvider.BingKey = MapViewModelBase.WinBingKey
            RouteProvider.BingKey = MapViewModelBase.WinBingKey
            GeoCodeProvider.BingKey = MapViewModelBase.WinBingKey
            Me.zoomService = TryCast(DirectCast(MapControl, IServiceProvider).GetService(GetType(IZoomToRegionService)), IZoomToRegionService)
        End Sub
        Protected Overridable Sub SubscribeRouteProviderEvents()
            AddHandler GeoCodeProvider.LocationInformationReceived, AddressOf GeoCodeProvider_LocationInformationReceived
            AddHandler RouteProvider.RouteCalculated, AddressOf RouteProvider_RouteCalculated
            AddHandler RouteProvider.LayerItemsGenerating, AddressOf RouteProvider_LayerItemsGenerating
        End Sub
        Protected Overridable Sub SubscribeViewModelEvents()
            AddHandler ViewModel.UpdateRoute, AddressOf ViewModel_UpdateRoute
            AddHandler ViewModel.PointAChanged, AddressOf ViewModel_PointAChanged
            AddHandler ViewModel.PointBChanged, AddressOf ViewModel_PointBChanged
            AddHandler ViewModel.TravelModeChanged, AddressOf ViewModel_TravelModeChanged
        End Sub
        Protected Overridable Sub UnsubscribeRouteProviderEvents()
            RemoveHandler GeoCodeProvider.LocationInformationReceived, AddressOf GeoCodeProvider_LocationInformationReceived
            RemoveHandler RouteProvider.RouteCalculated, AddressOf RouteProvider_RouteCalculated
            RemoveHandler RouteProvider.LayerItemsGenerating, AddressOf RouteProvider_LayerItemsGenerating
        End Sub
        Protected Overridable Sub UnsubscribeViewModelEvents()
            RemoveHandler ViewModel.UpdateRoute, AddressOf ViewModel_UpdateRoute
            RemoveHandler ViewModel.PointAChanged, AddressOf ViewModel_PointAChanged
            RemoveHandler ViewModel.PointBChanged, AddressOf ViewModel_PointBChanged
            RemoveHandler ViewModel.TravelModeChanged, AddressOf ViewModel_TravelModeChanged
        End Sub
        Private Sub ViewModel_UpdateRoute(ByVal sender As Object, ByVal e As EventArgs)
            UpdateUI(GetViewModelEntity())
        End Sub
        Protected Sub ViewModel_EntityChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            UpdateUI(GetViewModelEntity())
        End Sub
        Protected MustOverride Function GetViewModelEntity() As TEntity
        Private Sub ViewModel_TravelModeChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            RouteProvider.RouteOptions.Mode = ViewModel.TravelMode
            UpdateRoute()
        End Sub
        Private Property PointAPin() As MapPushpin
        Private Sub ViewModel_PointAChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            If PointAPin Is Nothing Then
                PointAPin = New MapPushpin() With {.Text = "A"}
            End If
            PointAPin.Location = ViewModel.PointA.ToGeoPoint()
        End Sub
        Private Property PointBPin() As MapPushpin
        Private Sub ViewModel_PointBChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            If PointBPin Is Nothing Then
                PointBPin = New MapPushpin() With {.Text = "B"}
            End If
            PointBPin.Location = ViewModel.PointB.ToGeoPoint()
        End Sub
        Private Sub RouteProvider_RouteCalculated(ByVal sender As Object, ByVal e As BingRouteCalculatedEventArgs)
            If e.Error IsNot Nothing OrElse e.Cancelled OrElse e.CalculationResult Is Nothing OrElse e.CalculationResult.ResultCode <> RequestResultCode.Success Then
                Return
            End If
            ProcessRouteResult(e.CalculationResult.RouteResults(0))
        End Sub
        Private Sub GeoCodeProvider_LocationInformationReceived(ByVal sender As Object, ByVal e As LocationInformationReceivedEventArgs)
            If e.Error IsNot Nothing OrElse e.Cancelled OrElse e.Result Is Nothing OrElse e.Result.ResultCode <> RequestResultCode.Success Then
                Return
            End If
            Dim locations() As LocationInformation = e.Result.Locations
            If locations.Length > 0 Then
                Dim loc As LocationInformation = locations(0)
                ViewModel.PointB = New Address() With {.Line = loc.Address.FormattedAddress, .Latitude = loc.Location.Latitude, .Longitude = loc.Location.Longitude}
            End If
        End Sub
        Private Sub RouteProvider_LayerItemsGenerating(ByVal sender As Object, ByVal args As LayerItemsGeneratingEventArgs)
            Dim items = args.Items
            For i As Integer = 0 To items.Length - 1
                Dim pushpin As MapPushpin = TryCast(items(i), MapPushpin)
                If pushpin IsNot Nothing Then
                    pushpin.Visible = False
                End If
            Next i
            AddRoutePoints()
        End Sub
        Private Sub AddRoutePoints()
            RouteLayer.Data.Items.Clear()
            RouteLayer.Data.Items.Add(PointAPin)
            RouteLayer.Data.Items.Add(PointBPin)
        End Sub
        Private Sub ProcessRouteResult(ByVal routeResult As BingRouteResult)
            ViewModel.RouteDistance = routeResult.Distance
            ViewModel.RouteTime = routeResult.Time
            Dim routePoints As New List(Of RoutePoint)()
            For Each leg As BingRouteLeg In routeResult.Legs
                For Each item As BingItineraryItem In leg.Itinerary
                    routePoints.Add(New RoutePoint(item))
                Next item
            Next leg
            UpdateRouteList(routePoints)
            zoomService.ZoomTo(ViewModel.PointA, ViewModel.PointB)
        End Sub
        Private Sub UpdateRouteList(ByVal routePoints As List(Of RoutePoint))
            If updateRouteListActionCore IsNot Nothing Then
                updateRouteListActionCore(routePoints)
            End If
        End Sub
        Private Sub UpdateRoute()
            Dim points As New List(Of RouteWaypoint)()
            points.Add(New RouteWaypoint("Point A", ViewModel.PointA.ToGeoPoint()))
            points.Add(New RouteWaypoint("Point B", ViewModel.PointB.ToGeoPoint()))
            RouteProvider.CalculateRoute(points)
        End Sub
        Private Sub UpdateUI(ByVal entity As TEntity)
            If entity Is Nothing Then
                Return
            End If
            If updateUIActionCore IsNot Nothing Then
                updateUIActionCore(entity)
            End If
            MapControl.CenterPoint = ViewModel.PointA.ToGeoPoint()
            AddRoutePoints()
            UpdateRoute()
        End Sub
    End Class
    Public NotInheritable Class RoutePoint
        Private Shared removeTagRegex As New Regex("<[^>]*>", RegexOptions.Compiled)
        Private item As BingItineraryItem
        Public Sub New(ByVal item As BingItineraryItem)
            Me.item = item
            ManeuverInstruction = removeTagRegex.Replace(item.ManeuverInstruction, String.Empty)
            Dim itemDistance As Double = item.Distance
            Distance = If(itemDistance > 0.9, String.Format("{0:0} mi", Math.Ceiling(itemDistance)), String.Format("{0:0} ft", Math.Ceiling(itemDistance * 52.8) * 100))
        End Sub
        Public ReadOnly Property Maneuver() As BingManeuverType
            Get
                Return item.Maneuver
            End Get
        End Property
        Private privateManeuverInstruction As String
        Public Property ManeuverInstruction() As String
            Get
                Return privateManeuverInstruction
            End Get
            Private Set(ByVal value As String)
                privateManeuverInstruction = value
            End Set
        End Property
        Private privateDistance As String
        Public Property Distance() As String
            Get
                Return privateDistance
            End Get
            Private Set(ByVal value As String)
                privateDistance = value
            End Set
        End Property
    End Class
End Namespace

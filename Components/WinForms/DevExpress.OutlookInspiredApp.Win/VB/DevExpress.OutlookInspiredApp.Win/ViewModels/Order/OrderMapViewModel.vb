Imports DevExpress.XtraMap
Imports DevExpress.Mvvm.POCO
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.DevAV
Imports System.Drawing
Imports System

Namespace DevExpress.DevAV.ViewModels

    Public Class OrderMapViewModel
        Inherits OrderViewModel
        Implements IRouteMapViewModel

        Public Overridable Property TravelMode() As BingTravelMode Implements IRouteMapViewModel.TravelMode
        <Command>
        Public Sub SetDrivingTravelMode()
            TravelMode = BingTravelMode.Driving
        End Sub
        Public Function CanSetDrivingTravelMode() As Boolean
            Return TravelMode <> BingTravelMode.Driving
        End Function
        <Command>
        Public Sub SetWalkingTravelMode()
            TravelMode = BingTravelMode.Walking
        End Sub
        Public Function CanSetWalkingTravelMode() As Boolean
            Return TravelMode <> BingTravelMode.Walking
        End Function
        Protected Overridable Sub OnTravelModeChanged()
            Me.RaiseCanExecuteChanged(Sub(x) x.SetDrivingTravelMode())
            Me.RaiseCanExecuteChanged(Sub(x) x.SetWalkingTravelMode())
            RaiseTravelModeChanged()
        End Sub
        Public Event TravelModeChanged As EventHandler Implements IRouteMapViewModel.TravelModeChanged
        Private Sub RaiseTravelModeChanged()
            Dim handler As EventHandler = TravelModeChangedEvent
            If handler IsNot Nothing Then
                handler(Me, EventArgs.Empty)
            End If
        End Sub
        <Command>
        Public Sub SwapRoutePoints()
            Dim a As Address = PointA
            PointA = PointB
            PointB = a
            RaiseUpdateRoute()
        End Sub
        Public ReadOnly Property Name() As String
            Get
                Return If(Entity IsNot Nothing, Entity.Customer.Name, Nothing)
            End Get
        End Property
        Public ReadOnly Property AddressLine1() As String
            Get
                Return If(Entity IsNot Nothing, Entity.Customer.HomeOffice.Line, Nothing)
            End Get
        End Property
        Public ReadOnly Property AddressLine2() As String
            Get
                Return If(Entity IsNot Nothing, Entity.Customer.HomeOffice.CityLine, Nothing)
            End Get
        End Property
        Public ReadOnly Property Logo() As Image
            Get
                Return If(Entity IsNot Nothing, Entity.Customer.Image, Nothing)
            End Get
        End Property
        Public ReadOnly Property PointAAddress() As String
            Get
                Return If(PointA IsNot Nothing, PointA.ToString(), Nothing)
            End Get
        End Property
        Public ReadOnly Property PointBAddress() As String
            Get
                Return If(PointB IsNot Nothing, PointB.ToString(), Nothing)
            End Get
        End Property
        Public Overridable ReadOnly Property RouteResult() As String
            Get
                Return String.Format("{0:F1} mi, {1:hh\:mm} min ", RouteDistance, RouteTime) + (If(TravelMode = BingTravelMode.Walking, "walking", "driving"))
            End Get
        End Property
        Public Overridable Property RouteDistance() As Double Implements IRouteMapViewModel.RouteDistance
        Protected Overridable Sub OnRouteDistanceChanged()
            Me.RaisePropertyChanged(Function(x) x.RouteResult)
        End Sub
        Public Overridable Property RouteTime() As TimeSpan Implements IRouteMapViewModel.RouteTime
        Protected Overridable Sub OnRouteTimeChanged()
            Me.RaisePropertyChanged(Function(x) x.RouteResult)
        End Sub
        Protected Overrides Sub OnEntityChanged()
            PointB = MapViewModelBase.DevAVHomeOffice
            PointA = Entity.Store.Address
            Me.RaisePropertyChanged(Function(x) x.Name)
            Me.RaisePropertyChanged(Function(x) x.Title)
            Me.RaisePropertyChanged(Function(x) x.PointA)
            Me.RaisePropertyChanged(Function(x) x.PointB)
            Me.RaisePropertyChanged(Function(x) x.AddressLine1)
            Me.RaisePropertyChanged(Function(x) x.AddressLine2)
            MyBase.OnEntityChanged()
        End Sub
        Public Overridable Property PointA() As Address Implements IRouteMapViewModel.PointA
        Protected Overridable Sub OnPointAChanged()
            Me.RaisePropertyChanged(Function(x) x.PointAAddress)
            RaisePointAChanged()
        End Sub
        Public Overridable Property PointB() As Address Implements IRouteMapViewModel.PointB
        Protected Overridable Sub OnPointBChanged()
            Me.RaisePropertyChanged(Function(x) x.PointBAddress)
            RaisePointBChanged()
        End Sub
        Public Event PointAChanged As EventHandler Implements IRouteMapViewModel.PointAChanged
        Private Sub RaisePointAChanged()
            Dim handler As EventHandler = PointAChangedEvent
            If handler IsNot Nothing Then
                handler(Me, EventArgs.Empty)
            End If
        End Sub
        Public Event PointBChanged As EventHandler Implements IRouteMapViewModel.PointBChanged
        Private Sub RaisePointBChanged()
            Dim handler As EventHandler = PointBChangedEvent
            If handler IsNot Nothing Then
                handler(Me, EventArgs.Empty)
            End If
        End Sub
        Public Event UpdateRoute As EventHandler Implements IRouteMapViewModel.UpdateRoute
        Private Sub RaiseUpdateRoute()
            Dim handler As EventHandler = UpdateRouteEvent
            If handler IsNot Nothing Then
                handler(Me, EventArgs.Empty)
            End If
        End Sub
    End Class
End Namespace

Imports DevExpress.XtraMap
Imports DevExpress.DevAV.Modules
Imports DevExpress.Mvvm
Imports DevExpress.Map
Imports DevExpress.DevAV
Imports System.Collections.Generic
Imports System

Namespace DevExpress.DevAV

    Public NotInheritable Class ViewModelHelper

        Private Sub New()
        End Sub

        Public Shared Function GetParentViewModel(Of TViewModel)(ByVal viewModel As Object) As TViewModel
            Dim parentViewModelSupport As ISupportParentViewModel = TryCast(viewModel, ISupportParentViewModel)
            If parentViewModelSupport IsNot Nothing Then
                Return CType(parentViewModelSupport.ParentViewModel, TViewModel)
            End If
            Return Nothing
        End Function
        Public Shared Sub EnsureModuleViewModel(ByVal [module] As Object, ByVal parentViewModel As Object, Optional ByVal parameter As Object = Nothing)
            Dim vm As ISupportViewModel = TryCast([module], ISupportViewModel)
            If vm IsNot Nothing Then
                Dim oldParentViewModel As Object = Nothing
                Dim parentViewModelSupport As ISupportParentViewModel = TryCast(vm.ViewModel, ISupportParentViewModel)
                If parentViewModelSupport IsNot Nothing Then
                    oldParentViewModel = parentViewModelSupport.ParentViewModel
                End If
                EnsureViewModel(vm.ViewModel, parentViewModel, parameter)
                If oldParentViewModel IsNot parentViewModel Then
                    vm.ParentViewModelAttached()
                End If
            End If
        End Sub
        Public Shared Sub EnsureViewModel(ByVal viewModel As Object, ByVal parentViewModel As Object, Optional ByVal parameter As Object = Nothing)
            Dim parentViewModelSupport As ISupportParentViewModel = TryCast(viewModel, ISupportParentViewModel)
            If parentViewModelSupport IsNot Nothing Then
                parentViewModelSupport.ParentViewModel = parentViewModel
            End If
            Dim parameterSupport As ISupportParameter = TryCast(viewModel, ISupportParameter)
            If parameterSupport IsNot Nothing AndAlso parameter IsNot Nothing Then
                parameterSupport.Parameter = parameter
            End If
        End Sub
    End Class
    Public Module AddressExtension
        <System.Runtime.CompilerServices.Extension> _
        Public Function ToGeoPoint(ByVal address As Address) As GeoPoint
            Return If(address IsNot Nothing, New GeoPoint(address.Latitude, address.Longitude), Nothing)
        End Function
        <System.Runtime.CompilerServices.Extension> _
        Public Sub ZoomTo(ByVal zoomService As DevExpress.XtraMap.Services.IZoomToRegionService, ByVal addresses As IEnumerable(Of Address), Optional ByVal margin As Double = 0.25)
            Dim ptA As GeoPoint = Nothing
            Dim ptB As GeoPoint = Nothing
            For Each address In addresses
                If ptA Is Nothing Then
                    ptA = address.ToGeoPoint()
                    ptB = address.ToGeoPoint()
                    Continue For
                End If
                Dim pt As GeoPoint = address.ToGeoPoint()
                If pt Is Nothing OrElse Object.Equals(pt, New GeoPoint(0,0)) Then
                    Continue For
                End If
                ptA.Latitude = Math.Min(ptA.Latitude, pt.Latitude)
                ptA.Longitude = Math.Min(ptA.Longitude, pt.Longitude)
                ptB.Latitude = Math.Max(ptB.Latitude, pt.Latitude)
                ptB.Longitude = Math.Max(ptB.Longitude, pt.Longitude)
            Next address
            ZoomCore(zoomService, ptA, ptB, margin)
        End Sub
        <System.Runtime.CompilerServices.Extension> _
        Public Sub ZoomTo(ByVal zoomService As DevExpress.XtraMap.Services.IZoomToRegionService, ByVal pointA As Address, ByVal pointB As Address, Optional ByVal margin As Double = 0.2)
            ZoomCore(zoomService, pointA.ToGeoPoint(), pointB.ToGeoPoint(), margin)
        End Sub
        Private Sub ZoomCore(ByVal zoomService As DevExpress.XtraMap.Services.IZoomToRegionService, ByVal ptA As GeoPoint, ByVal ptB As GeoPoint, ByVal margin As Double)
            If ptA Is Nothing OrElse ptB Is Nothing OrElse zoomService Is Nothing Then
                Return
            End If
            Dim latPadding As Double = Math.Max(0.1, (ptB.Latitude - ptA.Latitude) * margin)
            Dim longPadding As Double = Math.Max(0.1, (ptB.Longitude - ptA.Longitude) * margin)
            zoomService.ZoomToRegion(New GeoPoint(ptA.Latitude - latPadding, ptA.Longitude - longPadding), New GeoPoint(ptB.Latitude + latPadding, ptB.Longitude + longPadding), New GeoPoint(0.5 * (ptA.Latitude + ptB.Latitude), 0.5 * (ptA.Longitude + ptB.Longitude)))
        End Sub
    End Module
    Public Module MapControlExtension
        <System.Runtime.CompilerServices.Extension> _
        Public Sub Export(ByVal mapControl As MapControl, ByVal path As String)
            mapControl.ExportToImage(path, System.Drawing.Imaging.ImageFormat.Png)
            AppHelper.ProcessStart(path)
        End Sub
    End Module
End Namespace

Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Globalization
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Imaging
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Core.Native
Imports DevExpress.Xpf.LayoutControl

Namespace DevExpress.Xpf.LayoutControlDemo
    Public MustInherit Class BrandOrCar
        Public ReadOnly Property Image() As BitmapImage
            Get
                Return New BitmapImage(ImageFullName)
            End Get
        End Property
        Public ReadOnly Property ImageFullName() As Uri
            Get
                Return New Uri(LayoutControlDemoModule.UriPrefix & "/Images/Cars/" & ImageName, UriKind.Relative)
            End Get
        End Property
        Public Property ImageName() As String
    End Class

    Public Class Brand
        Inherits BrandOrCar

        Public Property Cars() As List(Of Car)
        Public Property Color() As Color
    End Class

    Public Class Car
        Inherits BrandOrCar

        Public Property Engine() As String
        Public Property Name() As String
        Public Property Power() As String
        Public Property Torque() As String
    End Class

    Partial Public Class pageCars
        Inherits LayoutControlDemoModule

        Private Shared carA3 As Car = New Car With {.Name = "A3", .ImageName = "a3.jpg", .Engine = "2.0L I4 turbo", .Power = "200 hp @ 5,100-6,000 rpm", .Torque = "207 lb-ft @ 1,800-5,000 rpm"}
        Private Shared carA4 As Car = New Car With {.Name = "A4", .ImageName = "a4.jpg", .Engine = "3.2L V6", .Power = "255 hp @ 6,500 rpm", .Torque = "243 lb-ft @ 3,250 rpm"}
        Private Shared carA5 As Car = New Car With {.Name = "A5", .ImageName = "a5.jpg", .Engine = "3.2L V6", .Power = "265 hp", .Torque = "243 lb-ft"}
        Private Shared carA6 As Car = New Car With {.Name = "A6", .ImageName = "a6.jpg", .Engine = "4.2L V8", .Power = "350 hp @ 6,800 rpm", .Torque = "325 lb-ft @ 3,500 rpm"}
        Private Shared carA8 As Car = New Car With {.Name = "A8", .ImageName = "a8.jpg", .Engine = "4.2L V8", .Power = "350 hp @ 6,800 rpm", .Torque = "325 lb-ft @ 3,500 rpm"}
        Private Shared carTT As Car = New Car With {.Name = "TT", .ImageName = "tt.jpg", .Engine = "3.2L V6", .Power = "250 hp @ 6,300 rpm", .Torque = "236 lb-ft @ 2,500-3,000 rpm"}
        Private Shared carS4 As Car = New Car With {.Name = "S4", .ImageName = "s4.jpg", .Engine = "4.2L V8", .Power = "340 hp @ 7,000 rpm", .Torque = "302 lb-ft @ 3,500 rpm"}
        Private Shared carS5 As Car = New Car With {.Name = "S5", .ImageName = "s5.jpg", .Engine = "4.2L V8", .Power = "354 hp @ 6,800 rpm", .Torque = "325 lb-ft @ 3,500 rpm"}
        Private Shared carS6 As Car = New Car With {.Name = "S6", .ImageName = "s6.jpg", .Engine = "5.2L V10", .Power = "435 hp @ 6,800 rpm", .Torque = "398 lb-ft @ 3,000-4,000 rpm"}
        Private Shared carS8 As Car = New Car With {.Name = "S8", .ImageName = "s8.jpg", .Engine = "5.2L V10", .Power = "450 hp @ 7,000 rpm", .Torque = "398 lb-ft @ 3,500 rpm"}
        Private Shared carRS4 As Car = New Car With {.Name = "RS4", .ImageName = "rs4.jpg", .Engine = "4.2L V8", .Power = "420 hp @ 7,800 rpm", .Torque = "317 lb-ft @ 5,500 rpm"}
        Private Shared carR8 As Car = New Car With {.Name = "R8", .ImageName = "r8.jpg", .Engine = "4.2L V8", .Power = "420 hp @ 7,800 rpm", .Torque = "317 lb-ft @ 4,500-6,000 rpm"}

        Private Shared car3S As Car = New Car With {.Name = "3 Series", .ImageName = "3.jpg", .Engine = "3.0L I6", .Power = "230 hp @ 6,500 rpm", .Torque = "200 lb-ft @ 2,750 rpm"}
        Private Shared car5S As Car = New Car With {.Name = "5 Series", .ImageName = "5.jpg", .Engine = "4.8L V8", .Power = "360 hp @ 6,300 rpm", .Torque = "360 lb-ft @ 3,400 rpm"}
        Private Shared car6S As Car = New Car With {.Name = "6 Series", .ImageName = "6.jpg", .Engine = "4.8L V8", .Power = "360 hp @ 6,300 rpm", .Torque = "360 lb-ft @ 3,400 rpm"}
        Private Shared car7S As Car = New Car With {.Name = "7 Series", .ImageName = "7.jpg", .Engine = "6.0L V12", .Power = "438 hp @ 6,000 rpm", .Torque = "444 lb-ft @ 3,950 rpm"}
        Private Shared carZ4 As Car = New Car With {.Name = "Z4", .ImageName = "z4.jpg", .Engine = "3.0L I6", .Power = "215 hp @ 6,250 rpm", .Torque = "185 lb-ft @ 2,750 rpm"}
        Private Shared carM3 As Car = New Car With {.Name = "M3", .ImageName = "m3.jpg", .Engine = "4.0L V8", .Power = "414 hp", .Torque = "295 lb-ft"}
        Private Shared carM5 As Car = New Car With {.Name = "M5", .ImageName = "m5.jpg", .Engine = "5.0L V10", .Power = "500 hp @ 7,750 rpm", .Torque = "383 lb-ft @ 6,100 rpm"}
        Private Shared carM6 As Car = New Car With {.Name = "M6", .ImageName = "m6.jpg", .Engine = "5.0L V10", .Power = "500 hp @ 7,750 rpm", .Torque = "383 lb-ft @ 6,100 rpm"}
        Private Shared carZ4M As Car = New Car With {.Name = "Z4 M", .ImageName = "z4m.jpg", .Engine = "3.2L I6", .Power = "330 hp @ 7,900 rpm", .Torque = "262 lb-ft @ 4,900 rpm"}

        Private Shared carCC As Car = New Car With {.Name = "C-Class", .ImageName = "c.jpg", .Engine = "3.0L V6", .Power = "228 hp @ 6,000 rpm", .Torque = "221 lb-ft @ 2,700 – 5,000 rpm"}
        Private Shared carEC As Car = New Car With {.Name = "E-Class", .ImageName = "e.jpg", .Engine = "3.5L V6", .Power = "268 hp @ 6,000 rpm", .Torque = "258 lb-ft @ 2,400 - 5,000 rpm"}
        Private Shared carSC As Car = New Car With {.Name = "S-Class", .ImageName = "s.jpg", .Engine = "5.5L V12 biturbo", .Power = "510 hp @ 5,000 rpm", .Torque = "612 lb-ft @ 1,800 - 3,500 rpm"}
        Private Shared carCLK As Car = New Car With {.Name = "CLK-Class", .ImageName = "clk.jpg", .Engine = "5.5L V8", .Power = "382 hp @ 6,000 rpm", .Torque = "391 lb-ft @ 2,800 - 4,800 rpm"}
        Private Shared carCLS As Car = New Car With {.Name = "CLS-Class", .ImageName = "cls.jpg", .Engine = "5.5L V8", .Power = "382 hp @ 6,000 rpm", .Torque = "391 lb-ft @ 2,800 - 4,800 rpm"}
        Private Shared carCLC As Car = New Car With {.Name = "CL-Class", .ImageName = "cl.jpg", .Engine = "5.5L V12 biturbo", .Power = "510 hp @ 5,000 rpm", .Torque = "612 lb-ft @ 1,800 - 3,500 rpm"}
        Private Shared carSLKC As Car = New Car With {.Name = "SLK-Class", .ImageName = "slk.jpg", .Engine = "3.5L V6", .Power = "268 hp @ 6,000 rpm", .Torque = "258 lb-ft @ 2,400 - 5,000 rpm"}
        Private Shared carSLC As Car = New Car With {.Name = "SL-Class", .ImageName = "sl.jpg", .Engine = "5.5L V12", .Power = "510 hp @ 5,000 rpm", .Torque = "612 lb-ft @ 1,800 - 3,500 rpm"}
        Private Shared carSLR As Car = New Car With {.Name = "SLR", .ImageName = "slr.jpg", .Engine = "5.5L V8 supercharged", .Power = "617 hp @ 6,500 rpm", .Torque = "575 lb-ft @ 3,250 – 5,000 rpm"}

        Public Shared ReadOnly Brands As New List(Of Brand)() From {
            New Brand With {
                .ImageName = "audi.png", .Color = Colors.Red, .Cars = New List(Of Car) From {carA3, carA4, carA5, carA6, carA8, carTT, carS4, carS5, carS6, carS8, carRS4, carR8}
            },
            New Brand With {
                .ImageName = "bmw.png", .Color = Colors.Blue, .Cars = New List(Of Car) From {car3S, car5S, car6S, car7S, carZ4, carM3, carM5, carM6, carZ4M}
            },
            New Brand With {
                .ImageName = "mercedes.png", .Color = Colors.Gray, .Cars = New List(Of Car) From {carCC, carEC, carSC, carCLK, carCLS, carCLC, carSLKC, carSLC, carSLR}
            }
        }

        Public Sub New()
            InitializeComponent()
            AddHandler LayoutUpdated, AddressOf OnLayoutUpdated
            AddHandler Loaded, AddressOf OnLoaded
            AddHandler Unloaded, AddressOf OnUnloaded
        End Sub

        Public ReadOnly Property Cars() As IEnumerable
            Get
                Dim result = New List(Of BrandOrCar)()
                For Each brand As Brand In Brands
                    result.Add(brand)
                    result.AddRange(brand.Cars)
                Next brand
                Return result
            End Get
        End Property

        Private Sub CarElementMouseEnter(ByVal sender As Object, ByVal e As MouseEventArgs)
            CarElement = DirectCast(sender, controlCarInfo)
            CarElementPosition = CarElement.GetPosition(layoutCars)

            Dim carDetailsElement = New controlCarInfo(True, True, True)
            carDetailsElement.DataContext = CarElement.DataContext
            carDetailsElement.FlowDirection = CarElement.FlowDirection
            carDetailsElement.FontFamily = CarElement.FontFamily
            carDetailsElement.Owner = CarElement

            CarDetailsPopup = New TransparentPopup()
            CarDetailsPopup.Child = carDetailsElement
            CarDetailsPopup.PlacementTarget = layoutCars
            CarDetailsPopup.IsOpen = True
            carDetailsElement.UpdateLayout()
            If CarDetailsPopup Is Nothing Then
                Return
            End If
            Dim carDetailsPopupPosition As Point = PointHelper.Subtract(PointHelper.Add(CarElementPosition, CarElement.ContentOffset), carDetailsElement.ContentOffset)
            CarDetailsPopup.HorizontalOffset = carDetailsPopupPosition.X
            CarDetailsPopup.VerticalOffset = carDetailsPopupPosition.Y
            CarDetailsPopup.MakeVisible()

            Storyboard.SetTarget(CarDetailsShowingAnimation, carDetailsElement)
            CarDetailsShowingAnimation.Begin()
        End Sub
        Private Sub CarElementMouseLeave(ByVal sender As Object, ByVal e As MouseEventArgs)
            If CarDetailsPopup Is Nothing Then
                Return
            End If
            CarDetailsShowingAnimation.Stop()

            CarDetailsPopup.IsOpen = False
            CarDetailsPopup.Child = Nothing
            CarDetailsPopup = Nothing

            CarElement = Nothing
        End Sub
        Private Sub OnLayoutUpdated(ByVal sender As Object, ByVal e As EventArgs)
            If CarDetailsPopup Is Nothing Then
                Return
            End If
            Dim newPosition As Point = CarElement.GetPosition(layoutCars)
            Dim offset As Point = PointHelper.Subtract(newPosition, CarElementPosition)
            If offset.X = 0 AndAlso offset.Y = 0 Then
                Return
            End If
            CarElementPosition = newPosition
            CarDetailsPopup.HorizontalOffset += offset.X
            CarDetailsPopup.VerticalOffset += offset.Y
        End Sub
        Private Sub OnApplicationDeactivated(ByVal sender As Object, ByVal e As EventArgs)
            CarElementMouseLeave(Nothing, Nothing)
        End Sub
        Private Sub OnLoaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            AddHandler Application.Current.Deactivated, AddressOf OnApplicationDeactivated
        End Sub
        Private Sub OnUnloaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            RemoveHandler Application.Current.Deactivated, AddressOf OnApplicationDeactivated
        End Sub

        Private Property CarDetailsPopup() As TransparentPopup
        Private Property CarElement() As controlCarInfo
        Private Property CarElementPosition() As Point
        Private ReadOnly Property CarDetailsShowingAnimation() As Storyboard
            Get
                Return CType(Resources("animationCarDetailsShowing"), Storyboard)
            End Get
        End Property
    End Class

    Public Class IsFirstCarConverter
        Implements IValueConverter

        Private Function IValueConverter_Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
            For Each brand As Brand In pageCars.Brands
                If brand.Cars(0) Is value Then
                    Return True
                End If
            Next brand
            Return False
        End Function
        Private Function IValueConverter_ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
            Throw New NotImplementedException()
        End Function
    End Class

    Public Class CarDataTemplateSelector
        Inherits DataTemplateSelector

        Public Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As DataTemplate
            Dim control = CType(container, FlowLayoutControl)
            Return CType(control.Resources(item.GetType().Name & "DataTemplate"), DataTemplate)
        End Function
    End Class
End Namespace

Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Windows.Media.Imaging
Imports System.Windows.Media.Media3D
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.Editors

Namespace ChartsDemo
    <CodeFile("Modules/XyzChart/MathematicalFunctions(.SL).xaml"), CodeFile("Modules/XyzChart/MathematicalFunctions.xaml.(cs)")>
    Partial Public Class MathematicalFunctions
        Inherits ChartsDemoModule

        Private model As MathematicalFunctionsViewModel

        Public Sub New()
            InitializeComponent()
            Me.model = New MathematicalFunctionsViewModel()
            Me.DataContext = model
        End Sub
        Private Sub RatioChanged(ByVal sender As Object, ByVal e As EditValueChangedEventArgs)
            model.AspectRatio = New Size3D(slRatioX.Value, slRatioY.Value, slRatioZ.Value)
        End Sub
        Private Sub UseRatioChanged(ByVal sender As Object, ByVal e As EditValueChangedEventArgs)
            If cbUseAspectRatio.IsChecked.Value Then
                RatioChanged(sender, e)
            Else
                model.AspectRatio = New Size3D(0, 0, 0)
            End If
        End Sub
        Public Overrides Function SupportSidebarContent() As Boolean
            Return False
        End Function
    End Class

    Public Class MathematicalFunctionsViewModel
        Implements INotifyPropertyChanged

        Private Const UnitFactor As Double = 15

        Private functionToCalculator As Dictionary(Of FunctionsType, Func(Of Double, Double, Point3D))

        Private points_Renamed As List(Of Point3D)

        Private aspectRatio_Renamed As Size3D

        Private function_Renamed As Function3DItemData
        Private onPropertyChanged As PropertyChangedEventHandler
        Private ReadOnly functions As ObservableCollection(Of Function3DItemData) = Chart3DUtils.CreateFunctionItemsData()

        Public ReadOnly Property FunctionItemsData() As ObservableCollection(Of Function3DItemData)
            Get
                Return functions
            End Get
        End Property
        Public Property [Function]() As Function3DItemData
            Get
                Return function_Renamed
            End Get
            Set(ByVal value As Function3DItemData)
                function_Renamed = value
                If function_Renamed IsNot Nothing Then
                    UpdateFunction(function_Renamed.Type)
                End If
                NotifyPropertyChanged("Function")
            End Set
        End Property

        Public Property Points() As List(Of Point3D)
            Get
                Return points_Renamed
            End Get
            Set(ByVal value As List(Of Point3D))
                points_Renamed = value
                NotifyPropertyChanged("Points")
            End Set
        End Property
        Public Property AspectRatio() As Size3D
            Get
                Return aspectRatio_Renamed
            End Get
            Set(ByVal value As Size3D)
                aspectRatio_Renamed = value
                NotifyPropertyChanged("AspectRatio")
            End Set
        End Property
        Public Custom Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
            AddHandler(ByVal value As PropertyChangedEventHandler)
                onPropertyChanged = DirectCast(System.Delegate.Combine(onPropertyChanged, value), PropertyChangedEventHandler)
            End AddHandler
            RemoveHandler(ByVal value As PropertyChangedEventHandler)
                onPropertyChanged = DirectCast(System.Delegate.Remove(onPropertyChanged, value), PropertyChangedEventHandler)
            End RemoveHandler
            RaiseEvent(ByVal sender As System.Object, ByVal e As System.ComponentModel.PropertyChangedEventArgs)
                If onPropertyChanged IsNot Nothing Then
                    For Each d As PropertyChangedEventHandler In onPropertyChanged.GetInvocationList()
                        d.Invoke(sender, e)
                    Next d
                End If
            End RaiseEvent
        End Event

        Public Sub New()
            Me.functionToCalculator = CreateCalculators()
            [Function] = FunctionItemsData(3)
        End Sub

        Private Function CreateCalculators() As Dictionary(Of FunctionsType, Func(Of Double, Double, Point3D))
            Dim calculators As New Dictionary(Of FunctionsType, Func(Of Double, Double, Point3D))()
            calculators.Add(FunctionsType.First, AddressOf CalculateFirstValue)
            calculators.Add(FunctionsType.Second, AddressOf CalculateSecondValue)
            calculators.Add(FunctionsType.Third, AddressOf CalculateThirdValue)
            calculators.Add(FunctionsType.Four, AddressOf CalculateFourValue)
            calculators.Add(FunctionsType.Five, AddressOf CalculateFiveValue)
            Return calculators
        End Function
        Private Sub NotifyPropertyChanged(ByVal propertyName As String)
            If Me.onPropertyChanged IsNot Nothing Then
                Me.onPropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
            End If
        End Sub

        Private Function Sinc(ByVal x As Double) As Double
            Return If(x <> 0, Math.Sin(x), 1)
        End Function
        Private Function CalculateFirstValue(ByVal x As Double, ByVal y As Double) As Point3D
            x *= UnitFactor
            y *= UnitFactor
            Dim value As Double = Sinc(Math.Sin(Math.Pow(Math.Pow(x, 6) + Math.Pow(y, 6), 1.0 \ 6.0))) * 5
            Return New Point3D(x, y, value)
        End Function
        Private Function CalculateSecondValue(ByVal x As Double, ByVal y As Double) As Point3D
            x *= UnitFactor
            y *= UnitFactor
            Dim square As Double = Math.Sqrt(x * x + y * y)
            Dim value As Double = square * Sinc(square) * 0.2
            Return New Point3D(x, y, value)
        End Function
        Private Function CalculateThirdValue(ByVal x As Double, ByVal y As Double) As Point3D
            x *= UnitFactor / 2
            y *= UnitFactor / 2
            Dim value As Double = Math.Sin(x) * Math.Cos(y) * 2
            Return New Point3D(x, y, value)
        End Function
        Private Function CalculateFourValue(ByVal x As Double, ByVal y As Double) As Point3D
            Dim theta As Double = Math.Atan2(y, x)
            Dim r As Double = x * x + y * y
            Dim z As Double = Math.Exp(-r) * Math.Sin(2 * Math.PI * Math.Sqrt(r)) * Math.Cos(3 * theta)
            Return New Point3D(x, y, z)
        End Function
        Private Function CalculateFiveValue(ByVal x As Double, ByVal y As Double) As Point3D
            x *= 3
            y *= 3
            Dim z As Double = Math.Sin(x * y)
            Return New Point3D(x, y, z)
        End Function
        Private Function CreatePoints(ByVal valueCalculator As Func(Of Double, Double, Point3D)) As List(Of Point3D)

            Dim points_Renamed As New List(Of Point3D)()
            For x As Double = -1 To 0 Step 0.017
                For y As Double = -1 To 0 Step 0.017
                    points_Renamed.Add(valueCalculator(x, y))
                Next y
            Next x
            Return points_Renamed
        End Function
        Private Function CreateFunctionPoints(ByVal [function] As FunctionsType) As List(Of Point3D)
            Return CreatePoints(functionToCalculator([function]))
        End Function
        Public Sub UpdateFunction(ByVal [function] As FunctionsType)
            Points = CreateFunctionPoints([function])
        End Sub
    End Class
    Public Enum FunctionsType
        First
        Second
        Third
        Four
        Five
    End Enum
    Public Class Function3DItemData
        Implements INotifyPropertyChanged


        Private type_Renamed As FunctionsType

        Private image_Renamed As BitmapImage
        Public Property Type() As FunctionsType
            Get
                Return type_Renamed
            End Get
            Set(ByVal value As FunctionsType)
                type_Renamed = value
                NotifyPropertyChanged("Type")
            End Set
        End Property
        Public Property Image() As BitmapImage
            Get
                Return image_Renamed
            End Get
            Set(ByVal value As BitmapImage)
                image_Renamed = value
                NotifyPropertyChanged("Image")
            End Set
        End Property

        #Region "INotifyPropertyChanged"
        Private onPropertyChanged As PropertyChangedEventHandler

        Public Custom Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
            AddHandler(ByVal value As PropertyChangedEventHandler)
                onPropertyChanged = DirectCast(System.Delegate.Combine(onPropertyChanged, value), PropertyChangedEventHandler)
            End AddHandler
            RemoveHandler(ByVal value As PropertyChangedEventHandler)
                onPropertyChanged = DirectCast(System.Delegate.Remove(onPropertyChanged, value), PropertyChangedEventHandler)
            End RemoveHandler
            RaiseEvent(ByVal sender As System.Object, ByVal e As System.ComponentModel.PropertyChangedEventArgs)
                If onPropertyChanged IsNot Nothing Then
                    For Each d As PropertyChangedEventHandler In onPropertyChanged.GetInvocationList()
                        d.Invoke(sender, e)
                    Next d
                End If
            End RaiseEvent
        End Event
        Private Sub NotifyPropertyChanged(ByVal propertyName As String)
            If Me.onPropertyChanged IsNot Nothing Then
                Me.onPropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
            End If
        End Sub
        #End Region
    End Class
End Namespace

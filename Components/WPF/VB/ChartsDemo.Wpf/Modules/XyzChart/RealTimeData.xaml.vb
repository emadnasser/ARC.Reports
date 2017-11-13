Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Windows
Imports System.Windows.Threading
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.Editors

Namespace ChartsDemo
    <CodeFile("Modules/XyzChart/RealTimeData(.SL).xaml"), CodeFile("Modules/XyzChart/RealTimeData.xaml.(cs)")>
    Partial Public Class RealTimeData
        Inherits ChartsDemoModule

        Private ReadOnly model As RealTimeSurfaceViewModel
        Private lastEnabledState As Boolean

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            Me.model = New RealTimeSurfaceViewModel(CInt((slDimension.Value)) + 1)
            DataContext = Me.model
        End Sub

        Private Sub DemoModuleLoaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.model.IsEnabled = True
        End Sub
        Private Sub DemoModuleUnloaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.model.IsEnabled = False
        End Sub
        Private Sub ButtonPauseClick(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.model.IsEnabled = Not Me.model.IsEnabled
            btnPause.Content = If(Me.model.IsEnabled, "Pause", "Resume")
        End Sub
        Private Sub DataSizeChanged(ByVal sender As Object, ByVal e As EditValueChangedEventArgs)
            Dim size As Integer = Convert.ToInt32(e.NewValue)
            Me.model.Size = size + 1
            Me.model.IsEnabled = lastEnabledState
        End Sub
        Private Sub DataSizeChanging(ByVal sender As Object, ByVal e As EditValueChangingEventArgs)
            Me.lastEnabledState = Me.model.IsEnabled
            Me.model.IsEnabled = False
        End Sub
    End Class

    Public Class RealTimeSurfaceViewModel
        Implements INotifyPropertyChanged

        Private Const ValueFactor As Double = 0.5
        Private Const Interval As Integer = 40

        Private ReadOnly dataGenerator As DataGenerator
        Private ReadOnly timer As DispatcherTimer

        Private argumentsX_Renamed As IEnumerable(Of Object)

        Private argumentsY_Renamed As IEnumerable(Of Object)

        Private values_Renamed As IEnumerable(Of Double)

        Private fillStyle_Renamed As FillStyleBase
        Private onPropertyChanged As PropertyChangedEventHandler

        Public Property ArgumentsX() As IEnumerable(Of Object)
            Get
                Return argumentsX_Renamed
            End Get
            Set(ByVal value As IEnumerable(Of Object))
                argumentsX_Renamed = value
                NotifyPropertyChanged("ArgumentsX")
            End Set
        End Property
        Public Property ArgumentsY() As IEnumerable(Of Object)
            Get
                Return argumentsY_Renamed
            End Get
            Set(ByVal value As IEnumerable(Of Object))
                argumentsY_Renamed = value
                NotifyPropertyChanged("ArgumentsY")
            End Set
        End Property
        Public Property Values() As IEnumerable(Of Double)
            Get
                Return values_Renamed
            End Get
            Set(ByVal value As IEnumerable(Of Double))
                values_Renamed = value
                NotifyPropertyChanged("Values")
            End Set
        End Property
        Public Property FillStyle() As FillStyleBase
            Get
                Return fillStyle_Renamed
            End Get
            Set(ByVal value As FillStyleBase)
                fillStyle_Renamed = value
                NotifyPropertyChanged("FillStyle")
            End Set
        End Property
        Public Property Size() As Integer
            Get
                Return dataGenerator.Size
            End Get
            Set(ByVal value As Integer)
                dataGenerator.Size = value
                NotifyPropertyChanged("MinValue")
                NotifyPropertyChanged("MaxValue")
                UpdateDataSource()
                UpdateValues()
            End Set
        End Property
        Public Property IsEnabled() As Boolean
            Get
                Return timer.IsEnabled
            End Get
            Set(ByVal value As Boolean)
                timer.IsEnabled = value
            End Set
        End Property
        Public ReadOnly Property MinValue() As Double
            Get
                Return -Size \ 3 - 1.5
            End Get
        End Property
        Public ReadOnly Property MaxValue() As Double
            Get
                Return Size \ 3 + 1.5
            End Get
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

        Public Sub New(ByVal initialSize As Integer)
            Me.dataGenerator = New DataGenerator()
            Me.timer = CreateTimer()
            Size = initialSize
        End Sub

        Private Function CreateTimer() As DispatcherTimer
            Dim timer As New DispatcherTimer()
            timer.Interval = TimeSpan.FromMilliseconds(Interval)
            AddHandler timer.Tick, AddressOf timerTick
            Return timer
        End Function
        Private Sub timerTick(ByVal sender As Object, ByVal e As EventArgs)
            UpdateValues()
        End Sub
        Private Sub NotifyPropertyChanged(ByVal propertyName As String)
            If Me.onPropertyChanged IsNot Nothing Then
                Me.onPropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
            End If
        End Sub
        Private Function CreateGradientFillStyle() As FillStyleBase
            Dim style As New GradientFillStyle()
            style.ColorStops.Add(New ColorStop() With {.Offset = New Unit(MaxValue)})
            style.ColorStops.Add(New ColorStop() With {.Offset = New Unit(0)})
            style.ColorStops.Add(New ColorStop() With {.Offset = New Unit(MinValue)})
            Return style
        End Function
        Private Sub UpdateDataSource()
            Dim arguments As IEnumerable(Of Object) = dataGenerator.GenerateArguments()
            ArgumentsX = arguments
            ArgumentsY = arguments
            dataGenerator.RecreateElevations()
            FillStyle = CreateGradientFillStyle()
        End Sub
        Private Sub UpdateValues()
            Values = dataGenerator.GenerateValues()
        End Sub
    End Class
End Namespace

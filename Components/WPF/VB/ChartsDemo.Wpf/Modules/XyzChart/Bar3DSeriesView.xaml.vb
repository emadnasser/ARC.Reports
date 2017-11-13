Imports System
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Windows.Media.Media3D
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase

Namespace ChartsDemo
    <CodeFile("Modules/XyzChart/Bar3DSeriesView(.SL).xaml"), CodeFile("Modules/XyzChart/Bar3DSeriesView.xaml.(cs)")>
    Partial Public Class Bar3DSeriesView
        Inherits ChartsDemoModule

        Private ReadOnly viewModel As Bar3DViewModel

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            Me.viewModel = New Bar3DViewModel(300)
            DataContext = viewModel
        End Sub

        Private Sub ButtonGenerateClick(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            viewModel.GenerateData()
        End Sub
    End Class

    Public Class Bar3DViewModel
        Implements INotifyPropertyChanged

        Private ReadOnly pointsCount As Integer

        Private source_Renamed As ObservableCollection(Of Point3D)
        Public Property Source() As ObservableCollection(Of Point3D)
            Get
                Return source_Renamed
            End Get
            Set(ByVal value As ObservableCollection(Of Point3D))
                source_Renamed = value
                NotifyPropertyChanged("Source")
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

        Public Sub New(ByVal pointsCount As Integer)
            Me.pointsCount = pointsCount
            GenerateData()
        End Sub

        Public Sub GenerateData()
            Source = DataPointHelper.GenerateRandomData(pointsCount)
        End Sub
    End Class
End Namespace

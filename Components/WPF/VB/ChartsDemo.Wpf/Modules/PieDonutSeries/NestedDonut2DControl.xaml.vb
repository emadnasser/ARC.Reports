Imports System.ComponentModel
Imports System.Windows
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase

Namespace ChartsDemo
    <CodeFile("Modules/PieDonutSeries/NestedDonut2DControl(.SL).xaml"), CodeFile("Modules/PieDonutSeries/NestedDonut2DControl.xaml.(cs)")>
    Partial Public Class NestedDonut2DControl
        Inherits ChartsDemoModule

        Private ReadOnly viewModel As New NestedDonutDemoViewModel()

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            DataContext = viewModel
        End Sub
        Private Sub ChartControlBoundDataChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim chartControl As ChartControl = TryCast(sender, ChartControl)
            If chartControl IsNot Nothing Then
                viewModel.UpdateSeries(chartControl.Diagram.Series)
            End If
        End Sub
    End Class

    Public Class NestedDonutDemoViewModel
        Implements INotifyPropertyChanged

        Private Const defaultArgumentDataMember As String = "Age"


        Private argumentDataMember_Renamed As String = defaultArgumentDataMember

        Private dataSource_Renamed As Object = Nothing

        Private ReadOnly Property IsDefaultDataMember() As Boolean
            Get
                Return argumentDataMember_Renamed = defaultArgumentDataMember
            End Get
        End Property
        Public Property ArgumentDataMember() As String
            Get
                Return argumentDataMember_Renamed
            End Get
            Set(ByVal value As String)
                If argumentDataMember_Renamed <> value Then
                    argumentDataMember_Renamed = value
                    OnPropertyChanged("DemoTitle")
                    OnPropertyChanged("SeriesDataMember")
                    OnPropertyChanged("ArgumentDataMember")
                    OnPropertyChanged("HintDataMember")
                End If
            End Set
        End Property
        Public ReadOnly Property SeriesDataMember() As String
            Get
                Return "Country" & HintDataMember & "Key"
            End Get
        End Property
        Public ReadOnly Property DemoTitle() As String
            Get
                Return "Population: " & argumentDataMember_Renamed & " Structure"
            End Get
        End Property
        Public ReadOnly Property HintDataMember() As String
            Get
                Return If(IsDefaultDataMember, "Sex", "Age")
            End Get
        End Property
        Public ReadOnly Property DataSource() As Object
            Get
                If dataSource_Renamed Is Nothing Then
                    dataSource_Renamed = AgeStructure.GetPopulationAgeStructure()
                End If
                Return dataSource_Renamed
            End Get
        End Property

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Private Sub OnPropertyChanged(ByVal propertyName As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub
        Public Sub UpdateSeries(ByVal seriesCollection As SeriesCollection)
            If seriesCollection.Count > 0 Then
                For Each series As Series In seriesCollection
                    series.ShowInLegend = False
                    Dim nestedSeries As NestedDonutSeries2D = TryCast(series, NestedDonutSeries2D)
                    Dim population As AgePopulation = TryCast(series.Points(0).Tag, AgePopulation)
                    If population IsNot Nothing AndAlso nestedSeries IsNot Nothing Then
                        Dim name As String = population.Name
                        nestedSeries.Group = name
                        nestedSeries.Titles.Clear()
                        nestedSeries.Titles.Add(New Title() With {.Content = name, .HorizontalAlignment = HorizontalAlignment.Center, .Visible = True})
                    End If
                Next series
                seriesCollection(0).ShowInLegend = True
            End If
        End Sub
    End Class
End Namespace

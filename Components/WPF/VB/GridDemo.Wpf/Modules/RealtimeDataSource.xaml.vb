Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows
Imports System.Windows.Data
Imports System.Threading
Imports System.Windows.Threading
Imports DevExpress.Data
Imports System.Collections.ObjectModel
Imports System.Diagnostics
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase.Helpers
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.XtraExport.Helpers
Imports DevExpress.Xpf.Grid.Printing

Namespace GridDemo
    <CodeFile("ModuleResources/RealtimeDataSourceViewModel.(cs)"), CodeFile("ModuleResources/RealtimeDataSourceClasses.(cs)")>
    Partial Public Class RealtimeDataSource
        Inherits GridDemoModule

        Private ReadOnly viewModel As RealtimeDataSourceViewModel
        Private realTimeSource As RealTimeSource
        Private updateGraphOperation As DispatcherOperation
        Public Sub New()
            viewModel = New RealtimeDataSourceViewModel()
            DataContext = viewModel
            InitializeComponent()
            AddHandler viewModel.TimerShowTick, AddressOf model_TimerShowTick
            PatchInterval()
            realTimeSource = CreateRealTimeSource(viewModel.List)
            grid.ItemsSource = realTimeSource
            viewModel.WithRealTimeSource = True
            AddHandler Unloaded, AddressOf RealtimeDataSource_Unloaded
        End Sub

        Private Sub RealtimeDataSource_Unloaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            viewModel.Dispose()
        End Sub
        Protected Overrides ReadOnly Property IsGridBorderVisible() As Boolean
            Get
                Return True
            End Get
        End Property

        Private Delegate Sub UpdateGraphDelegate(ByVal points As SeriesPointCollection, ByVal value As Double)

        Private updateGraph_Renamed As UpdateGraphDelegate = CType(System.Delegate.CreateDelegate(GetType(UpdateGraphDelegate), GetType(RealtimeDataSource), "UpdateGraph"), UpdateGraphDelegate)
        Private Sub model_TimerShowTick(ByVal sender As Object, ByVal e As EventArgs)
            If updateGraphOperation IsNot Nothing AndAlso updateGraphOperation.Status <> DispatcherOperationStatus.Completed Then
                Return
            End If
            Dim changePerSecond As Double = viewModel.ChangePerSecond
            updateGraphOperation = Dispatcher.BeginInvoke(DispatcherPriority.Send, updateGraph_Renamed, UPSDiagram.Points, changePerSecond)
        End Sub
        Private Shared Sub UpdateGraph(ByVal points As SeriesPointCollection, ByVal value As Double)
            Do While points.Count > 20
                points.RemoveAt(0)
            Loop
            points.Add(New SeriesPoint(Date.Now.TimeOfDay.TotalSeconds, value))
        End Sub
        Private Shared Function CreateRealTimeSource(ByVal dataSource As IList) As RealTimeSource
            Dim rts As RealTimeSource = New RealTimeSource With {.DataSource = dataSource}
            Return rts
        End Function
        Private Sub DisposeRealTimeSource()
            If realTimeSource IsNot Nothing Then
                realTimeSource.DataSource = Nothing
                realTimeSource.Dispose()
            End If
            realTimeSource = Nothing
        End Sub
        Private Sub slider_ValueChanged(ByVal sender As Object, ByVal e As RoutedPropertyChangedEventArgs(Of Double))
            PatchInterval()
        End Sub
        Private Sub PatchInterval()
            Dim pow As Double = (Me.slider.Maximum - Me.slider.Value + 3) / 2.0
            viewModel.InterEventDelay = CInt((Math.Pow(2.0, pow)))
        End Sub

        Private Sub CheckBox_Unchecked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            viewModel.Update()
            DisposeRealTimeSource()
            grid.ItemsSource = Nothing
            grid.ItemsSource = viewModel.List
            PatchInterval()
        End Sub
        Private Sub CheckBox_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If grid Is Nothing Then
                Return
            End If
            grid.ItemsSource = Nothing
            realTimeSource = CreateRealTimeSource(viewModel.List)
            grid.ItemsSource = realTimeSource
            viewModel.Update()
            PatchInterval()
        End Sub
        Protected Overrides Function GetExportView() As DevExpress.Xpf.Grid.DataViewBase
            Return Nothing
        End Function
        Protected Overrides Function GetReportView() As IGridViewFactory(Of ColumnWrapper, RowBaseWrapper)
            Return Nothing
        End Function
    End Class
End Namespace

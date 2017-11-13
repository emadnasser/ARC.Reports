Imports System
Imports System.Windows
Imports System.Windows.Threading
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase

Namespace ChartsDemo
    <CodeFile("Modules/Performance/RealtimeChartControl(.SL).xaml"), CodeFile("Modules/Performance/RealtimeChartControl.xaml.(cs)")>
    Partial Public Class RealtimeChartControl
        Inherits ChartsDemoModule

        Private Const Interval As Integer = 40

        Private timer As New DispatcherTimer()
        Private random As New Random()
        Private value1 As Double = 10.0
        Private value2 As Double = -10.0
        Private inProcess? As Boolean = Nothing

        Private ReadOnly Property TimeInterval() As Integer
            Get
                Return Convert.ToInt32(seInterval.Value)
            End Get
        End Property
        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            timer.Interval = TimeSpan.FromMilliseconds(Interval)
            AddHandler timer.Tick, AddressOf timer_Tick
            timer.Start()
        End Sub
        Private Sub timer_Tick(ByVal sender As Object, ByVal e As EventArgs)
            Dim argument As Date = Date.Now
            series1.Points.BeginInit()
            series2.Points.BeginInit()
            Dim pointsToUpdate1(Interval - 1) As SeriesPoint
            Dim pointsToUpdate2(Interval - 1) As SeriesPoint
            For i As Integer = 0 To Interval - 1
                pointsToUpdate1(i) = New SeriesPoint(argument, value1)
                pointsToUpdate2(i) = New SeriesPoint(argument, value2)
                argument = argument.AddMilliseconds(1)
                UpdateValues()
            Next i
            Dim minDate As Date = argument.AddSeconds(-TimeInterval)
            Dim pointsToRemoveCount As Integer = 0
            For Each point As SeriesPoint In series1.Points
                If point.DateTimeArgument < minDate Then
                    pointsToRemoveCount += 1
                End If
            Next point
            If pointsToRemoveCount < series1.Points.Count Then
                pointsToRemoveCount -= 1
            End If
            series1.Points.AddRange(pointsToUpdate1)
            series2.Points.AddRange(pointsToUpdate2)
            If pointsToRemoveCount > 0 Then
                RemovePointsRange(series1, pointsToRemoveCount)
                RemovePointsRange(series2, pointsToRemoveCount)
            End If
            series2.Points.EndInit()
            series1.Points.EndInit()
            axisX.WholeRange.SetMinMaxValues(minDate, argument)
        End Sub
        Private Sub RemovePointsRange(ByVal series As Series, ByVal pointsToRemoveCount As Integer)
            For i As Integer = 0 To pointsToRemoveCount - 1
                series.Points.RemoveAt(0)
            Next i
        End Sub
        Private Sub UpdateValues()
            value1 = CalculateNextValue(value1)
            value2 = CalculateNextValue(value2)
        End Sub
        Private Function CalculateNextValue(ByVal value As Double) As Double
            Return value + (random.NextDouble() * 10.0 - 5.0)
        End Function
        Private Sub DisableProcess()
            inProcess = timer.IsEnabled
            timer.Stop()
        End Sub
        Private Sub RestoreProcess()
            If inProcess IsNot Nothing Then
                timer.IsEnabled = CBool(inProcess)
                inProcess = Nothing
            End If
        End Sub
        Private Sub ChartsDemoModule_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            RestoreProcess()
        End Sub
        Private Sub ChartsDemoModule_Unloaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            DisableProcess()
        End Sub
        Private Sub ButtonPauseClick(ByVal sender As Object, ByVal e As RoutedEventArgs)
            timer.IsEnabled = Not timer.IsEnabled
            btnPause.Content = If(timer.IsEnabled, "Pause", "Resume")
        End Sub
    End Class
End Namespace

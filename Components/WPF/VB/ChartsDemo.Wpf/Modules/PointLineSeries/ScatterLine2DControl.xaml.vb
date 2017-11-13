Imports System
Imports System.Windows
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.Editors

Namespace ChartsDemo
    <CodeFile("Modules/PointLineSeries/ScatterLine2DControl(.SL).xaml"), CodeFile("Modules/PointLineSeries/ScatterLine2DControl.xaml.(cs)")>
    Partial Public Class ScatterLine2DControl
        Inherits ChartsDemoModule

        Private Const a As Integer = 10

        Private loading As Boolean = True

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            CreateArchimedianSpiralPoints()
            CreateCardioidPoints()
            CreateCartesianFoliumPoints()
            lbMarker.SelectedItem = Marker2DModelKindHelper.FindActualMarker2DModelKind(GetType(CircleMarker2DModel))
            lbFunctionKind.SelectedIndex = 0
            For Each series As XYSeries2D In chart.Diagram.Series
                series.CrosshairLabelPattern = "{A:F2} : {V:F2}"
            Next series
        End Sub

        Private Sub CreateArchimedianSpiralPoints()
            For i As Integer = 0 To 719 Step 15
                Dim t As Double = CDbl(i) / 180 * Math.PI
                Dim x As Double = t * Math.Cos(t)
                Dim y As Double = t * Math.Sin(t)
                ArchimedianSpiral.Points.Add(New SeriesPoint(x, y))
            Next i
        End Sub
        Private Sub CreateCardioidPoints()
            For i As Integer = 0 To 359 Step 10
                Dim t As Double = CDbl(i) / 180 * Math.PI
                Dim x As Double = a * (2 * Math.Cos(t) - Math.Cos(2 * t))
                Dim y As Double = a * (2 * Math.Sin(t) - Math.Sin(2 * t))
                Cardioid.Points.Add(New SeriesPoint(x, y))
            Next i
        End Sub
        Private Sub CreateCartesianFoliumPoints()
            For i As Integer = -30 To 124 Step 5
                Dim t As Double = Math.Tan(CDbl(i) / 180 * Math.PI)
                Dim x As Double = 3 * CDbl(a) * t / (t * t * t + 1)
                Dim y As Double = x * t
                CartesianFolium.Points.Add(New SeriesPoint(x, y))
            Next i
        End Sub
        Private Sub ShowSeries(ByVal visibleSeries As Series)
            For Each series As Series In chart.Diagram.Series
                series.Visible = series Is visibleSeries
            Next series
            If Not loading Then
                chart.Animate()
            End If
        End Sub
        Private Sub ChartsDemoModule_ModuleAppear(ByVal sender As Object, ByVal e As RoutedEventArgs)
            loading = False
            chart.Animate()
        End Sub
        Private Sub lbFunctionKind_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If lbFunctionKind.SelectedIndex = 0 Then
                ShowSeries(ArchimedianSpiral)
            ElseIf lbFunctionKind.SelectedIndex = 1 Then
                ShowSeries(Cardioid)
            ElseIf DirectCast(sender, ListBoxEdit).SelectedIndex = 2 Then
                ShowSeries(CartesianFolium)
            End If
        End Sub
    End Class
End Namespace

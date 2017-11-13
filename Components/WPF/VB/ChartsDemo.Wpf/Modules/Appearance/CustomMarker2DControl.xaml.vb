Imports System
Imports System.Windows
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase

Namespace ChartsDemo
    <CodeFile("Modules/Appearance/CustomMarker2DControl(.SL).xaml"), CodeFile("Modules/Appearance/CustomMarker2DControl.xaml.(cs)")>
    Partial Public Class CustomMarker2DControl
        Inherits ChartsDemoModule

        Private loading As Boolean

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            loading = True
            Try
                lbSeriesType.Items.Add(New SeriesTypeItem(GetType(XYDiagram2D), GetType(PointSeries2D), "2D Points", 1))
                lbSeriesType.Items.Add(New SeriesTypeItem(GetType(XYDiagram2D), GetType(LineSeries2D), "2D Lines", 1))
                lbSeriesType.Items.Add(New SeriesTypeItem(GetType(XYDiagram2D), GetType(AreaSeries2D), "2D Areas", 1))
                lbSeriesType.Items.Add(New SeriesTypeItem(GetType(XYDiagram2D), GetType(BubbleSeries2D), "2D Bubbles", 1))
                lbSeriesType.SelectedIndex = 0
            Finally
                loading = False
            End Try
        End Sub
        Private Sub AddPoint(ByVal series As MarkerSeries2D, ByVal point As SeriesPoint, ByVal weight As Double)
            Dim bubbleSeries As BubbleSeries2D = TryCast(series, BubbleSeries2D)
            If bubbleSeries IsNot Nothing Then
                BubbleSeries2D.SetWeight(point, weight)
            End If
            series.Points.Add(point)
        End Sub
        Private Sub FillSeries(ByVal series As MarkerSeries2D)
            If series Is Nothing Then
                Return
            End If
            Dim areaSeries As AreaSeries2D = TryCast(series, AreaSeries2D)
            If areaSeries IsNot Nothing Then
                areaSeries.Transparency = 0.8
                areaSeries.MarkerVisible = True
            End If
            Dim lineSeries As LineSeries2D = TryCast(series, LineSeries2D)
            If lineSeries IsNot Nothing Then
                lineSeries.MarkerVisible = True
            End If
            series.ColorEach = True
            series.AnimationAutoStartMode = AnimationAutoStartMode.SetStartState
            AddPoint(series, New SeriesPoint(1.0, 2.1), 1.0)
            AddPoint(series, New SeriesPoint(2.0, 1.4), 2.0)
            AddPoint(series, New SeriesPoint(3.0, 1.1), 4.0)
            AddPoint(series, New SeriesPoint(4.0, 1.9), 3.0)
            AddPoint(series, New SeriesPoint(5.0, 3.1), 2.5)
            AddPoint(series, New SeriesPoint(6.0, 2.4), 1.7)
            AddPoint(series, New SeriesPoint(7.0, 2.6), 3.9)
            AddPoint(series, New SeriesPoint(8.0, 1.9), 2.8)
            AddPoint(series, New SeriesPoint(9.0, 3.2), 2.1)
            AddPoint(series, New SeriesPoint(10.0, 3.5), 1.3)
            DirectCast(series, ISupportMarker2D).MarkerModel = TryCast(chart.Resources("CustomMarker2DModel"), CustomMarker2DModel)
            series.Label = New SeriesLabel()
            series.Label.ConnectorVisible = False
            series.Label.ResolveOverlappingMode = ResolveOverlappingMode.Default
            Dim labelTemplate As DataTemplate = TryCast(chart.Resources("labelTemplate"), DataTemplate)
            If labelTemplate IsNot Nothing Then
                series.Label.ElementTemplate = labelTemplate
                series.Label.RenderMode = LabelRenderMode.CustomShape
            End If
            If Not(TypeOf series Is BubbleSeries2D) Then
                DirectCast(series, ISupportMarker2D).MarkerSize = 19
                series.Label.Indent = 15
            Else
                series.Label.Indent = 5
                MarkerSeries2D.SetAngle(series.Label, 90)
                BubbleSeries2D.SetLabelPosition(series.Label, Bubble2DLabelPosition.Outside)
            End If
            chart.Diagram.Series.Clear()
            chart.Diagram.Series.Add(series)
            If Not loading Then
                chart.Animate()
            End If
        End Sub
        Private Sub ChartsDemoModule_ModuleAppear(ByVal sender As Object, ByVal e As RoutedEventArgs)
            chart.Animate()
        End Sub
        Private Sub lbSeriesType_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim item As SeriesTypeItem = TryCast(lbSeriesType.SelectedItem, SeriesTypeItem)
            If item IsNot Nothing Then
                FillSeries(TryCast(Activator.CreateInstance(item.SeriesType), MarkerSeries2D))
            End If
        End Sub
    End Class
End Namespace

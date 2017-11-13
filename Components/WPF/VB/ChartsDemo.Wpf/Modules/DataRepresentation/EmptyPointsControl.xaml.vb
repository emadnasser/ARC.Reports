Imports System
Imports System.Collections.Generic
Imports System.Windows
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase

Namespace ChartsDemo
    <CodeFile("Modules/DataRepresentation/EmptyPointsControl(.SL).xaml"), CodeFile("Modules/DataRepresentation/EmptyPointsControl.xaml.(cs)")>
    Partial Public Class EmptyPointsControl
        Inherits ChartsDemoModule

        Private loading As Boolean = False
        Private dataSource As IList(Of WebSitePopularity)

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            dataSource = CreateDataSource()
            InitSeriesListBox()
            loading = True
            Try
                lbSeriesType.SelectedIndex = 0
            Finally
                loading = False
            End Try
        End Sub
        Private Sub ChartsDemoModule_ModuleAppear(ByVal sender As Object, ByVal e As RoutedEventArgs)
            chart.Animate()
        End Sub
        Private Sub InitSeriesListBox()
            lbSeriesType.Items.Add(New SeriesTypeItem(GetType(XYDiagram2D), GetType(LineSeries2D), "2D Lines"))
            lbSeriesType.Items.Add(New SeriesTypeItem(GetType(XYDiagram2D), GetType(SplineSeries2D), "2D Splines"))
            lbSeriesType.Items.Add(New SeriesTypeItem(GetType(XYDiagram2D), GetType(AreaSeries2D), "2D Areas"))
            lbSeriesType.Items.Add(New SeriesTypeItem(GetType(XYDiagram2D), GetType(SplineAreaSeries2D), "2D Spline Areas"))
            lbSeriesType.Items.Add(New SeriesTypeItem(GetType(XYDiagram2D), GetType(AreaStackedSeries2D), "2D Stacked Areas"))
            lbSeriesType.Items.Add(New SeriesTypeItem(GetType(XYDiagram2D), GetType(SplineAreaStackedSeries2D), "2D Stacked Spline Areas"))
            lbSeriesType.Items.Add(New SeriesTypeItem(GetType(XYDiagram2D), GetType(AreaFullStackedSeries2D), "2D Full-Stacked Areas"))
            lbSeriesType.Items.Add(New SeriesTypeItem(GetType(XYDiagram2D), GetType(SplineAreaFullStackedSeries2D), "2D Spline Full-Stacked Areas"))
            lbSeriesType.Items.Add(New SeriesTypeItem(GetType(XYDiagram3D), GetType(AreaSeries3D), "3D Areas"))
            lbSeriesType.Items.Add(New SeriesTypeItem(GetType(XYDiagram3D), GetType(AreaStackedSeries3D), "3D Stacked Areas"))
            lbSeriesType.Items.Add(New SeriesTypeItem(GetType(XYDiagram3D), GetType(AreaFullStackedSeries3D), "3D Full-Stacked Areas"))
        End Sub
        Private Sub PrepareSeriesAnimation(ByVal series As Series, ByVal seriesIndex As Integer)
            If loading Then
                series.AnimationAutoStartMode = AnimationAutoStartMode.SetStartState
            End If
            Dim beginTime As TimeSpan = TimeSpan.FromMilliseconds(200 * seriesIndex)
            If TypeOf series Is LineSeries2D Then
                CType(series, LineSeries2D).PointAnimation = New Marker2DFadeInAnimation() With {.BeginTime = beginTime}
                CType(series, LineSeries2D).SeriesAnimation = New Line2DBlowUpAnimation() With {.BeginTime = beginTime}
            ElseIf TypeOf series Is AreaSeries2D Then
                CType(series, AreaSeries2D).PointAnimation = New Marker2DFadeInAnimation() With {.BeginTime = beginTime}
                CType(series, AreaSeries2D).SeriesAnimation = New Area2DStretchOutAnimation() With {.BeginTime = beginTime}
            ElseIf TypeOf series Is AreaStackedSeries2D Then
                CType(series, AreaStackedSeries2D).PointAnimation = New AreaStacked2DFadeInAnimation() With {.BeginTime = beginTime}
                CType(series, AreaStackedSeries2D).SeriesAnimation = New Area2DStretchOutAnimation() With {.BeginTime = beginTime}
            End If
        End Sub
        Private Sub ChangeDiagram(ByVal item As SeriesTypeItem)
            If item Is Nothing Then
                Return
            End If
            chart.Diagram = DirectCast(Activator.CreateInstance(item.DiagramType), Diagram)
            Dim isAreaFullStackedSeries As Boolean = False
            Dim axisX As Axis = Nothing, axisY As Axis = Nothing
            Dim diagram2D As XYDiagram2D = TryCast(chart.Diagram, XYDiagram2D)
            If diagram2D IsNot Nothing Then
                chart.Legend.HorizontalPosition = HorizontalPosition.RightOutside
                diagram2D.AxisX = New AxisX2D()
                diagram2D.AxisY = New AxisY2D()
                axisX = diagram2D.AxisX
                axisY = diagram2D.AxisY
                isAreaFullStackedSeries = item.SeriesType Is GetType(AreaFullStackedSeries2D)
            Else
                chart.Legend.HorizontalPosition = HorizontalPosition.Right
                Dim diagram3D As XYDiagram3D = TryCast(chart.Diagram, XYDiagram3D)
                If diagram3D IsNot Nothing Then
                    diagram3D.AxisX = New AxisX3D()
                    diagram3D.AxisY = New AxisY3D()
                    axisX = diagram3D.AxisX
                    axisY = diagram3D.AxisY
                    diagram3D.SeriesPadding = 0.5
                    diagram3D.SeriesDistance = 1.5
                    isAreaFullStackedSeries = item.SeriesType Is GetType(AreaFullStackedSeries3D)
                End If
            End If
            If axisX IsNot Nothing Then
                axisX.Label = New AxisLabel() With {.TextPattern = "{A:m}"}
            End If
            If axisY IsNot Nothing Then
                If isAreaFullStackedSeries Then
                    axisY.Label = New AxisLabel() With {.TextPattern = "{VP:P0}"}
                Else
                    axisY.Title = New AxisTitle()
                    axisY.Title.Content = "Number of visitors"
                End If
            End If
            Dim politicsSeries As Series = DirectCast(Activator.CreateInstance(item.SeriesType), Series)
            politicsSeries.DisplayName = "Politics"
            politicsSeries.ValueDataMember = "Politics"
            PrepareSeriesAnimation(politicsSeries, 0)
            Dim entertainmentSeries As Series = DirectCast(Activator.CreateInstance(item.SeriesType), Series)
            entertainmentSeries.DisplayName = "Entertainment"
            entertainmentSeries.ValueDataMember = "Entertainment"
            PrepareSeriesAnimation(entertainmentSeries, 1)
            Dim travelSeries As Series = DirectCast(Activator.CreateInstance(item.SeriesType), Series)
            travelSeries.DisplayName = "Travel"
            travelSeries.ValueDataMember = "Travel"
            PrepareSeriesAnimation(travelSeries, 2)
            chart.Diagram.Series.AddRange(New Series() { politicsSeries, entertainmentSeries, travelSeries })
            For Each series As Series In chart.Diagram.Series
                Dim supportTransparency As ISupportTransparency = TryCast(series, ISupportTransparency)
                If supportTransparency IsNot Nothing Then
                    supportTransparency.Transparency = 0.5
                End If
                series.Label = New SeriesLabel()
                If isAreaFullStackedSeries Then
                    series.Label.TextPattern = "{VP:P0}"
                End If
                series.LabelsVisibility = cheLabelsVisible.IsChecked.Value
                series.Label.ResolveOverlappingMode = ResolveOverlappingMode.Default
                series.ArgumentScaleType = ScaleType.DateTime
                series.ArgumentDataMember = "Date"
                series.DataSource = dataSource
            Next series
        End Sub
        Private Sub lbSeriesType_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If chart IsNot Nothing Then
                chart.BeginInit()
                Try
                    ChangeDiagram(TryCast(lbSeriesType.SelectedItem, SeriesTypeItem))
                Finally
                    chart.EndInit()
                End Try
            End If
        End Sub
        Private Sub cheLabelsVisible_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If chart IsNot Nothing AndAlso chart.Diagram IsNot Nothing Then
                For Each series As Series In chart.Diagram.Series
                    series.LabelsVisibility = True
                Next series
            End If
        End Sub
        Private Sub cheLabelsVisible_Unchecked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If chart IsNot Nothing AndAlso chart.Diagram IsNot Nothing Then
                For Each series As Series In chart.Diagram.Series
                    series.LabelsVisibility = False
                Next series
            End If
        End Sub
        Private Function CreateDataSource() As IList(Of WebSitePopularity)
            Dim dataSource As New List(Of WebSitePopularity)()
            Dim year As Integer = Date.Now.Year
            dataSource.Add(New WebSitePopularity(New Date(year, 1, 1), 65, 56, 45))
            dataSource.Add(New WebSitePopularity(New Date(year, 1, 2), 78, 45, 40))
            dataSource.Add(New WebSitePopularity(New Date(year, 1, 3), 95, 70, 56))
            dataSource.Add(New WebSitePopularity(New Date(year, 1, 4), 110, 82, 47))
            dataSource.Add(New WebSitePopularity(New Date(year, 1, 5), 108, 80, 38))
            dataSource.Add(New WebSitePopularity(New Date(year, 1, 6), 52, 20, 31))
            dataSource.Add(New WebSitePopularity(New Date(year, 1, 7), 46, 10, 27))
            dataSource.Add(New WebSitePopularity(New Date(year, 1, 8), 70, Nothing, 37))
            dataSource.Add(New WebSitePopularity(New Date(year, 1, 9), 86, Nothing, 42))
            dataSource.Add(New WebSitePopularity(New Date(year, 1, 10), 92, 65, Nothing))
            dataSource.Add(New WebSitePopularity(New Date(year, 1, 11), 108, 45, 37))
            dataSource.Add(New WebSitePopularity(New Date(year, 1, 12), 115, 56, 21))
            dataSource.Add(New WebSitePopularity(New Date(year, 1, 13), 75, 10, 10))
            dataSource.Add(New WebSitePopularity(New Date(year, 1, 14), 65, 0, 5))
            Return dataSource
        End Function
    End Class

    Public Class WebSitePopularity

        Private ReadOnly date_Renamed As Date

        Private ReadOnly politics_Renamed? As Double

        Private ReadOnly entertainment_Renamed? As Double

        Private ReadOnly travel_Renamed? As Double

        Public ReadOnly Property [Date]() As Date
            Get
                Return date_Renamed
            End Get
        End Property
        Public ReadOnly Property Politics() As Double?
            Get
                Return politics_Renamed
            End Get
        End Property
        Public ReadOnly Property Entertainment() As Double?
            Get
                Return entertainment_Renamed
            End Get
        End Property
        Public ReadOnly Property Travel() As Double?
            Get
                Return travel_Renamed
            End Get
        End Property

        Public Sub New(ByVal [date] As Date, ByVal politics? As Double, ByVal entertainment? As Double, ByVal travel? As Double)
            Me.date_Renamed = [date]
            Me.politics_Renamed = politics
            Me.entertainment_Renamed = entertainment
            Me.travel_Renamed = travel
        End Sub
    End Class
End Namespace

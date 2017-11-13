Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Windows
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.Editors

Namespace ChartsDemo
    <CodeFile("Modules/Interactivity/AnimationControl(.SL).xaml"), CodeFile("Modules/Interactivity/AnimationControl.xaml.(cs)")>
    Partial Public Class AnimationControl
        Inherits ChartsDemoModule

        Private Shared Function CreateDataSource() As List(Of DataPoint)
            Dim dataSource As New List(Of DataPoint)()
            dataSource.Add(DataPoint.CreateDataPoint("A", 15, 8, 3))
            dataSource.Add(DataPoint.CreateDataPoint("B", 13, 12, 10))
            dataSource.Add(DataPoint.CreateDataPoint("C", 7, 4, 6))
            dataSource.Add(DataPoint.CreateDataPoint("D", 5, 9, 6))
            dataSource.Add(DataPoint.CreateDataPoint("E", 23, 15, 8))
            dataSource.Add(DataPoint.CreateDataPoint("F", 21, 19, 10))
            Return dataSource
        End Function
        Private Shared Function CreatePieDataSource() As List(Of DataPoint)
            Dim dataSource As New List(Of DataPoint)()
            Dim random As New Random(0)
            For i As Integer = 0 To 15
                dataSource.Add(DataPoint.CreatePieDataPoint("1", random.NextDouble() * 3 + 1))
            Next i
            Return dataSource
        End Function
        Private Shared Function CreateFunnelDataSource() As List(Of DataPoint)
            Dim dataSource As New List(Of DataPoint)()
            dataSource.Add(DataPoint.CreatePieDataPoint("Visited a Website", 9152))
            dataSource.Add(DataPoint.CreatePieDataPoint("Downloaded a Trial", 6870))
            dataSource.Add(DataPoint.CreatePieDataPoint("Contacted to Support", 5121))
            dataSource.Add(DataPoint.CreatePieDataPoint("Subscribed", 2224))
            dataSource.Add(DataPoint.CreatePieDataPoint("Renewed", 1670))
            Return dataSource
        End Function
        Private Shared Function CreatePolarDataSource() As List(Of DataPoint)
            Dim dataSource As New List(Of DataPoint)()
            Dim random As New Random()
            For i As Integer = 0 To 6
                dataSource.Add(DataPoint.CreateDataPoint(Math.Floor(random.NextDouble() * 360), Math.Floor(random.NextDouble() * 25)))
            Next i
            Return dataSource
        End Function
        Private Shared Function CreatePolarRangeDataSource() As List(Of DataPoint)
            Dim dataSource As New List(Of DataPoint)()
            Dim random As New Random()
            Dim pointsCount As Integer = 6
            For i As Integer = 0 To pointsCount - 1
                dataSource.Add(DataPoint.CreatePolarRangeDataPoint(Math.Floor(i / CDbl(pointsCount) * 360), Math.Floor(random.NextDouble() * 10 + 30), Math.Floor(random.NextDouble() * 10 + 10)))
            Next i
            Return dataSource
        End Function
        Private Shared Function CreateBarDataSource() As List(Of DataPoint)
            Dim dataSource As New List(Of DataPoint)()
            dataSource.Add(DataPoint.CreateBarDataPoint("A", 1, 3, 8, 15))
            dataSource.Add(DataPoint.CreateBarDataPoint("B", 2, 10, 12, 13))
            dataSource.Add(DataPoint.CreateBarDataPoint("C", 5, 6, 7, 4))
            dataSource.Add(DataPoint.CreateBarDataPoint("D", -2, -3, -1.5, -1.3))
            dataSource.Add(DataPoint.CreateBarDataPoint("E", -2.1, -3.2, -1, -0.6))
            dataSource.Add(DataPoint.CreateBarDataPoint("F", -2.4, -3.8, -0.7, -4))
            Return dataSource
        End Function
        Private Shared Function CreateScatterDataSource() As List(Of DataPoint)
            Dim dataSource As New List(Of DataPoint)()
            dataSource.Add(DataPoint.CreateScatterDataPoint("A", 15))
            dataSource.Add(DataPoint.CreateScatterDataPoint("B", 11))
            dataSource.Add(DataPoint.CreateScatterDataPoint("C", 7))
            dataSource.Add(DataPoint.CreateScatterDataPoint("D", 9))
            dataSource.Add(DataPoint.CreateScatterDataPoint("C", 23))
            dataSource.Add(DataPoint.CreateScatterDataPoint("B", 21))
            Return dataSource
        End Function
        Private Shared Function CreateBubbleDataSource() As List(Of DataPoint)
            Dim dataSource As New List(Of DataPoint)()
            dataSource.Add(DataPoint.CreateBubbleDataPoint("A", 10, 5.9))
            dataSource.Add(DataPoint.CreateBubbleDataPoint("B", 5, 4.9))
            dataSource.Add(DataPoint.CreateBubbleDataPoint("C", 2, 4.6))
            dataSource.Add(DataPoint.CreateBubbleDataPoint("D", 5, 3))
            dataSource.Add(DataPoint.CreateBubbleDataPoint("E", 2, 2.9))
            dataSource.Add(DataPoint.CreateBubbleDataPoint("F", 4, 2.8))
            dataSource.Add(DataPoint.CreateBubbleDataPoint("G", 2, 2.6))
            dataSource.Add(DataPoint.CreateBubbleDataPoint("H", 3, 2.5))
            dataSource.Add(DataPoint.CreateBubbleDataPoint("I", 4, 2.4))
            Return dataSource
        End Function
        Private Shared Function CreateRangeDataSource() As List(Of DataPoint)
            Dim dataSource As New List(Of DataPoint)()
            dataSource.Add(DataPoint.CreateBarDataPoint("A", 3, 13, 5, 15))
            dataSource.Add(DataPoint.CreateBarDataPoint("B", 5, 8, 3, 11))
            dataSource.Add(DataPoint.CreateBarDataPoint("C", 2, 9, 6, 11))
            dataSource.Add(DataPoint.CreateBarDataPoint("D", -2, -8, -1, -9))
            dataSource.Add(DataPoint.CreateBarDataPoint("E", -1, -6, -3, -9))
            dataSource.Add(DataPoint.CreateBarDataPoint("F", -3, -7, -2, -6))
            Return dataSource
        End Function
        Private Shared Function CreateFinancialDataSource() As DataTable
            Return (New GoogleStockData()).ShortData
        End Function
        Private Shared Function GetDefaultAnimationIndex(ByVal animationKinds As IEnumerable(Of AnimationKind), ByVal defaultAnimationType As Type) As Integer
            Dim index As Integer = 0
            For Each animationKind As AnimationKind In animationKinds
                If animationKind.Type IsNot Nothing AndAlso animationKind.Type.Equals(defaultAnimationType) AndAlso animationKind.Name <> "None" Then
                    Return index
                End If
                index += 1
            Next animationKind
            Return 0
        End Function
        Private Shared Function GetNoneAnimation(ByVal animationKinds As IEnumerable(Of AnimationKind)) As AnimationKind
            If animationKinds Is Nothing Then
                Return New AnimationKind(Nothing, "None")
            End If
            Dim enumerator As IEnumerator(Of AnimationKind) = animationKinds.GetEnumerator()
            enumerator.MoveNext()
            Dim current As AnimationKind = enumerator.Current
            If current Is Nothing Then
                Return New AnimationKind(Nothing, "None")
            Else
                Return New AnimationKind(current.Type, "None")
            End If
        End Function
        Private Shared Sub InitializeAnimationListBoxEdit(ByVal listBoxEdit As ListBoxEdit, ByVal animationKinds As IEnumerable(Of AnimationKind), ByVal defaultAnimationType As Type)
            Dim allAnimationKinds As New List(Of AnimationKind)()
            listBoxEdit.ClearValue(ListBoxEdit.SelectedIndexProperty)
            Dim noneAnimation As AnimationKind = GetNoneAnimation(animationKinds)
            allAnimationKinds.Add(noneAnimation)
            allAnimationKinds.AddRange(animationKinds)
            listBoxEdit.ItemsSource = allAnimationKinds
            listBoxEdit.SelectedIndex = GetDefaultAnimationIndex(allAnimationKinds, defaultAnimationType)
        End Sub

        Private loading As Boolean = False
        Private dataSource As List(Of DataPoint)
        Private pieDataSource As List(Of DataPoint)
        Private funnelDataSource As List(Of DataPoint)
        Private polarDataSource As List(Of DataPoint)
        Private polarRangeDataSource As List(Of DataPoint)
        Private barDataSource As List(Of DataPoint)
        Private bubbleDataSource As List(Of DataPoint)
        Private scatterDataSource As List(Of DataPoint)
        Private rangeDataSource As List(Of DataPoint)
        Private financialDataSource As DataTable

        Private ReadOnly Property FirstSeries() As Series
            Get
                Return If(chart.Diagram IsNot Nothing AndAlso chart.Diagram.Series.Count > 0, chart.Diagram.Series(0), Nothing)
            End Get
        End Property
        Private ReadOnly Property UnwindAnimationSupported() As Boolean
            Get
                Return FirstSeries IsNot Nothing AndAlso (TypeOf FirstSeries Is AreaSeries2D OrElse TypeOf FirstSeries Is AreaStackedSeries2D OrElse TypeOf FirstSeries Is LineSeries2D)
            End Get
        End Property
        Private ReadOnly Property DefaultPointAnimationType() As Type
            Get
                If FirstSeries IsNot Nothing Then
                    If TypeOf FirstSeries Is BarSideBySideSeries2D OrElse TypeOf FirstSeries Is RangeBarSeries2D Then
                        Return GetType(Bar2DGrowUpAnimation)
                    End If
                    If TypeOf FirstSeries Is BarStackedSeries2D Then
                        Return GetType(Bar2DDropInAnimation)
                    End If
                    If TypeOf FirstSeries Is PointSeries2D Then
                        Return GetType(Marker2DSlideFromLeftAnimation)
                    End If
                    If TypeOf FirstSeries Is BubbleSeries2D Then
                        Return GetType(Marker2DWidenAnimation)
                    End If
                    If TypeOf FirstSeries Is LineSeries2D OrElse TypeOf FirstSeries Is AreaSeries2D OrElse TypeOf FirstSeries Is RangeAreaSeries2D Then
                        Return GetType(Marker2DFadeInAnimation)
                    End If
                    If TypeOf FirstSeries Is AreaStackedSeries2D Then
                        Return GetType(AreaStacked2DFadeInAnimation)
                    End If
                    If TypeOf FirstSeries Is FinancialSeries2D Then
                        Return GetType(Stock2DSlideFromTopAnimation)
                    End If
                    If TypeOf FirstSeries Is PieSeries2D Then
                        Return GetType(Pie2DGrowUpAnimation)
                    End If
                    If TypeOf FirstSeries Is FunnelSeries2D Then
                        Return GetType(Funnel2DWidenAnimation)
                    End If
                    If TypeOf FirstSeries Is CircularSeriesBase2D Then
                        Return GetType(CircularMarkerSlideToCenterAnimation)
                    End If
                End If
                Return Nothing
            End Get
        End Property
        Private ReadOnly Property DefaultSeriesAnimationType() As Type
            Get
                If FirstSeries IsNot Nothing Then
                    If TypeOf FirstSeries Is LineSeries2D Then
                        Return GetType(Line2DStretchFromNearAnimation)
                    End If
                    If TypeOf FirstSeries Is AreaSeries2D OrElse TypeOf FirstSeries Is RangeAreaSeries2D Then
                        Return GetType(Area2DStretchFromNearAnimation)
                    End If
                    If TypeOf FirstSeries Is AreaStackedSeries2D Then
                        Return GetType(Area2DDropFromFarAnimation)
                    End If
                    If TypeOf FirstSeries Is CircularAreaSeries2D Then
                        Return GetType(CircularAreaZoomInAnimation)
                    End If
                    If TypeOf FirstSeries Is CircularLineSeries2D Then
                        Return GetType(CircularLineZoomInAnimation)
                    End If
                    If TypeOf FirstSeries Is CircularRangeAreaSeries2D Then
                        Return GetType(CircularAreaZoomInAnimation)
                    End If
                End If
                Return Nothing
            End Get
        End Property
        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            loading = True
            Try
                dataSource = CreateDataSource()
                pieDataSource = CreatePieDataSource()
                funnelDataSource = CreateFunnelDataSource()
                polarDataSource = CreatePolarDataSource()
                polarRangeDataSource = CreatePolarRangeDataSource()
                barDataSource = CreateBarDataSource()
                bubbleDataSource = CreateBubbleDataSource()
                scatterDataSource = CreateScatterDataSource()
                rangeDataSource = CreateRangeDataSource()
                financialDataSource = CreateFinancialDataSource()
                InitializeSeriesComboBox()
                cbSeriesTypes.SelectedIndex = 0
            Finally
                loading = False
            End Try
        End Sub
        Private Sub InitializeSeriesComboBox()
            cbSeriesTypes.Items.Add(New SeriesTypeItem(GetType(XYDiagram2D), GetType(BarSideBySideSeries2D), "2D Side-By-Side Bars", 3))
            cbSeriesTypes.Items.Add(New SeriesTypeItem(GetType(XYDiagram2D), GetType(BarStackedSeries2D), "2D Stacked Bars", 3))
            cbSeriesTypes.Items.Add(New SeriesTypeItem(GetType(XYDiagram2D), GetType(BarFullStackedSeries2D), "2D Full-Stacked Bars", 3))
            cbSeriesTypes.Items.Add(New SeriesTypeItem(GetType(XYDiagram2D), GetType(BarSideBySideStackedSeries2D), "2D Side-By-Side Stacked Bars", 4))
            cbSeriesTypes.Items.Add(New SeriesTypeItem(GetType(XYDiagram2D), GetType(BarSideBySideFullStackedSeries2D), "2D Side-By-Side Full-Stacked Bars", 4))
            cbSeriesTypes.Items.Add(New SeriesTypeItem(GetType(XYDiagram2D), GetType(RangeBarOverlappedSeries2D), "2D Overlapped Range Bars", 2))
            cbSeriesTypes.Items.Add(New SeriesTypeItem(GetType(XYDiagram2D), GetType(RangeBarSideBySideSeries2D), "2D Side-By-Side Range Bars", 2))
            cbSeriesTypes.Items.Add(New SeriesTypeItem(GetType(XYDiagram2D), GetType(PointSeries2D), "2D Points", 3))
            cbSeriesTypes.Items.Add(New SeriesTypeItem(GetType(XYDiagram2D), GetType(BubbleSeries2D), "2D Bubbles", 1))
            cbSeriesTypes.Items.Add(New SeriesTypeItem(GetType(XYDiagram2D), GetType(LineSeries2D), "2D Lines", 3))
            cbSeriesTypes.Items.Add(New SeriesTypeItem(GetType(XYDiagram2D), GetType(LineStackedSeries2D), "2D Stacked Lines", 3))
            cbSeriesTypes.Items.Add(New SeriesTypeItem(GetType(XYDiagram2D), GetType(LineFullStackedSeries2D), "2D Full-Stacked Lines", 3))
            cbSeriesTypes.Items.Add(New SeriesTypeItem(GetType(XYDiagram2D), GetType(LineStepSeries2D), "2D Step Lines", 1))
            cbSeriesTypes.Items.Add(New SeriesTypeItem(GetType(XYDiagram2D), GetType(LineScatterSeries2D), "2D Scatter Lines", 1))
            cbSeriesTypes.Items.Add(New SeriesTypeItem(GetType(XYDiagram2D), GetType(AreaSeries2D), "2D Areas", 3))
            cbSeriesTypes.Items.Add(New SeriesTypeItem(GetType(XYDiagram2D), GetType(AreaStackedSeries2D), "2D Stacked Areas", 3))
            cbSeriesTypes.Items.Add(New SeriesTypeItem(GetType(XYDiagram2D), GetType(AreaFullStackedSeries2D), "2D Full-Stacked Areas", 3))
            cbSeriesTypes.Items.Add(New SeriesTypeItem(GetType(XYDiagram2D), GetType(AreaStepSeries2D), "2D Step Areas", 1))
            cbSeriesTypes.Items.Add(New SeriesTypeItem(GetType(XYDiagram2D), GetType(AreaStepStackedSeries2D), "2D Stacked Step Areas", 3))
            cbSeriesTypes.Items.Add(New SeriesTypeItem(GetType(XYDiagram2D), GetType(AreaStepFullStackedSeries2D), "2D Full-Stacked Step Areas", 3))
            cbSeriesTypes.Items.Add(New SeriesTypeItem(GetType(XYDiagram2D), GetType(RangeAreaSeries2D), "2D Range Areas", 1))
            cbSeriesTypes.Items.Add(New SeriesTypeItem(GetType(XYDiagram2D), GetType(StockSeries2D), "2D Stocks", 1))
            cbSeriesTypes.Items.Add(New SeriesTypeItem(GetType(XYDiagram2D), GetType(CandleStickSeries2D), "2D Candle-Sticks", 1))
            cbSeriesTypes.Items.Add(New SeriesTypeItem(GetType(SimpleDiagram2D), GetType(PieSeries2D), "2D Pie", 1))
            cbSeriesTypes.Items.Add(New SeriesTypeItem(GetType(SimpleDiagram2D), GetType(NestedDonutSeries2D), "2D Nested Donut", 2))
            cbSeriesTypes.Items.Add(New SeriesTypeItem(GetType(SimpleDiagram2D), GetType(FunnelSeries2D), "2D Funnel", 1))
            cbSeriesTypes.Items.Add(New SeriesTypeItem(GetType(RadarDiagram2D), GetType(RadarRangeAreaSeries2D), "2D Radar Range Area", 1))
            cbSeriesTypes.Items.Add(New SeriesTypeItem(GetType(RadarDiagram2D), GetType(RadarAreaSeries2D), "2D Radar Area", 1))
            cbSeriesTypes.Items.Add(New SeriesTypeItem(GetType(RadarDiagram2D), GetType(RadarLineSeries2D), "2D Radar Line", 1))
            cbSeriesTypes.Items.Add(New SeriesTypeItem(GetType(RadarDiagram2D), GetType(RadarPointSeries2D), "2D Radar Point", 1))
            cbSeriesTypes.Items.Add(New SeriesTypeItem(GetType(PolarDiagram2D), GetType(PolarRangeAreaSeries2D), "2D Polar Range Area", 1))
            cbSeriesTypes.Items.Add(New SeriesTypeItem(GetType(PolarDiagram2D), GetType(PolarAreaSeries2D), "2D Polar Area", 1))
            cbSeriesTypes.Items.Add(New SeriesTypeItem(GetType(PolarDiagram2D), GetType(PolarLineSeries2D), "2D Polar Line", 1))
            cbSeriesTypes.Items.Add(New SeriesTypeItem(GetType(PolarDiagram2D), GetType(PolarPointSeries2D), "2D Polar Point", 1))
        End Sub
        Private Sub InitializeSeries(ByVal series As Series, ByVal seriesNumber As Integer)
            If TypeOf series Is BarSideBySideSeries2D Then
                BarSideBySideSeries2D.SetLabelPosition(series.Label, Bar2DLabelPosition.Outside)
            End If
            If TypeOf series Is BarSeries2D Then
                series.DataSource = barDataSource
            ElseIf TypeOf series Is LineScatterSeries2D Then
                series.DataSource = scatterDataSource
            Else
                series.DataSource = dataSource
            End If
            If TypeOf series Is LineSeries2D Then
                CType(series, LineSeries2D).MarkerVisible = True
            End If
            If TypeOf series Is AreaSeries2D Then
                CType(series, AreaSeries2D).MarkerVisible = True
            End If
            series.ArgumentDataMember = "Argument"
            series.ValueDataMember = "Value" & seriesNumber.ToString()
        End Sub
        Private Sub InitializePieSeries(ByVal pieSeries As PieSeries2D)
            pieSeries.DataSource = pieDataSource
            pieSeries.ArgumentDataMember = "Argument"
            pieSeries.ValueDataMember = "Value"
        End Sub
        Private Sub InitializeFunnelSeries(ByVal funnelSeries As FunnelSeries2D)
            funnelSeries.DataSource = funnelDataSource
            funnelSeries.ArgumentDataMember = "Argument"
            funnelSeries.ValueDataMember = "Value"
            funnelSeries.Label.TextPattern = "{A}: {V}"
        End Sub
        Private Sub InitializePolarSeries(ByVal circularSeries As CircularSeries2D)
            circularSeries.DataSource = polarDataSource
            circularSeries.ArgumentDataMember = "NumericalArgument"
            circularSeries.ValueDataMember = "Value"
        End Sub
        Private Sub InitializePolarRangeSeries(ByVal circularRangeSeries As CircularRangeAreaSeries2D)
            circularRangeSeries.DataSource = polarRangeDataSource
            circularRangeSeries.ArgumentDataMember = "NumericalArgument"
            circularRangeSeries.ValueDataMember = "Value1"
            circularRangeSeries.Value2DataMember = "Value2"
        End Sub
        Private Sub InitializeBubbleSeries(ByVal series As BubbleSeries2D)
            series.ColorEach = True
            series.MinSize = 1
            series.MaxSize = 2
            series.DataSource = bubbleDataSource
            series.ArgumentDataMember = "Argument"
            series.ValueDataMember = "Value"
            series.WeightDataMember = "Weight"
        End Sub
        Private Sub InitializeRangeBarSeries(ByVal series As RangeBarSeries2D, ByVal seriesNumber As Integer)
            series.DataSource = rangeDataSource
            series.ArgumentDataMember = "Argument"
            If seriesNumber = 1 Then
                series.ValueDataMember = "Value1"
                series.Value2DataMember = "Value2"
            ElseIf seriesNumber = 2 Then
                series.ValueDataMember = "Value3"
                series.Value2DataMember = "Value4"
            End If
        End Sub
        Private Sub InitializeRangeAreaSeries(ByVal series As RangeAreaSeries2D)
            series.DataSource = rangeDataSource
            series.ArgumentDataMember = "Argument"
            series.ValueDataMember = "Value1"
            series.Value2DataMember = "Value2"
        End Sub
        Private Sub InitializeFinancialSeries(ByVal series As FinancialSeries2D)
            series.ArgumentScaleType = ScaleType.DateTime
            series.DataSource = financialDataSource
            series.ArgumentDataMember = "Date"
            series.LowValueDataMember = "Low"
            series.HighValueDataMember = "High"
            series.OpenValueDataMember = "Open"
            series.CloseValueDataMember = "Close"
        End Sub
        Private Sub UpdateSeries(ByVal series As Series, ByVal index As Integer)
            If TypeOf series Is BubbleSeries2D Then
                InitializeBubbleSeries(TryCast(series, BubbleSeries2D))
                Return
            End If
            If TypeOf series Is FinancialSeries2D Then
                InitializeFinancialSeries(TryCast(series, FinancialSeries2D))
                Dim diagram As XYDiagram2D = TryCast(chart.Diagram, XYDiagram2D)
                If diagram IsNot Nothing Then
                    AxisY2D.SetAlwaysShowZeroLevel(diagram.ActualAxisY.ActualWholeRange, False)
                End If
                Return
            End If
            If TypeOf series Is PieSeries2D Then
                Dim pieSeries As PieSeries2D = TryCast(series, PieSeries2D)
                If Not(TypeOf pieSeries Is NestedDonutSeries2D) Then
                    pieSeries.HoleRadiusPercent = 0
                End If
                InitializePieSeries(pieSeries)
                Return
            End If
            If TypeOf series Is FunnelSeries2D Then
                InitializeFunnelSeries(TryCast(series, FunnelSeries2D))
                Return
            End If
            If TypeOf series Is RangeBarSeries2D Then
                Dim rangeBar As RangeBarSeries2D = TryCast(series, RangeBarSeries2D)
                InitializeRangeBarSeries(TryCast(series, RangeBarSeries2D), index + 1)
                series.LabelsVisibility = False
                If TypeOf rangeBar Is RangeBarOverlappedSeries2D AndAlso index = 1 Then
                    rangeBar.BarWidth = 0.2
                End If
                Return
            End If
            If TypeOf series Is RangeAreaSeries2D Then
                InitializeRangeAreaSeries(TryCast(series, RangeAreaSeries2D))
                Return
            End If
            If TypeOf series Is CircularSeries2D Then
                InitializePolarSeries(TryCast(series, CircularSeries2D))
                Return
            End If
            If TypeOf series Is CircularRangeAreaSeries2D Then
                InitializePolarRangeSeries(TryCast(series, CircularRangeAreaSeries2D))
                Return
            End If

            InitializeSeries(series, index + 1)
        End Sub
        Private Sub UpdateSeries()
            Dim seriesTypeItem As SeriesTypeItem = TryCast(cbSeriesTypes.SelectedItem, SeriesTypeItem)
            If seriesTypeItem IsNot Nothing Then
                chart.BeginInit()
                Try
                    chart.Diagram = DirectCast(Activator.CreateInstance(seriesTypeItem.DiagramType), Diagram)
                    For i As Integer = 0 To seriesTypeItem.SeriesCount - 1
                        Dim series As Series = DirectCast(Activator.CreateInstance(seriesTypeItem.SeriesType), Series)
                        If loading Then
                            series.AnimationAutoStartMode = AnimationAutoStartMode.SetStartState
                        End If
                        series.Label = New SeriesLabel()

                        UpdateSeries(series, i)

                        Dim supportStackedGroup As ISupportStackedGroup = TryCast(series, ISupportStackedGroup)
                        If supportStackedGroup IsNot Nothing Then
                            supportStackedGroup.StackedGroup = i Mod 2
                        End If
                        Dim supportTransparency As ISupportTransparency = TryCast(series, ISupportTransparency)
                        If supportTransparency IsNot Nothing Then
                            supportTransparency.Transparency = 0.3
                        End If
                        series.LabelsVisibility = True
                        series.Label.ResolveOverlappingMode = ResolveOverlappingMode.Default
                        chart.Diagram.Series.Add(series)
                    Next i
                Finally
                    chart.EndInit()
                End Try
            End If
        End Sub
        Private Sub PrepareAnimation()
            If FirstSeries IsNot Nothing Then
                If FirstSeries.GetSeriesAnimation() IsNot Nothing Then
                    For i As Integer = 0 To chart.Diagram.Series.Count - 1
                        Dim series As Series = chart.Diagram.Series(i)
                        Dim beginTime As TimeSpan = TimeSpan.FromMilliseconds(Math.Round(CDbl(series.GetSeriesAnimation().Duration.TotalMilliseconds) / 4.0) * i)
                        series.GetSeriesAnimation().BeginTime = beginTime
                        If series.GetPointAnimation() IsNot Nothing Then
                            series.GetPointAnimation().BeginTime = beginTime
                        End If
                    Next i
                ElseIf FirstSeries.GetPointAnimation() IsNot Nothing Then
                    For i As Integer = 0 To chart.Diagram.Series.Count - 1
                        Dim series As Series = chart.Diagram.Series(i)
                        series.GetPointAnimation().BeginTime = TimeSpan.FromMilliseconds(series.GetPointAnimation().PointDelay.TotalMilliseconds * i)
                        series.GetPointAnimation().PointDelay = TimeSpan.FromMilliseconds(series.GetPointAnimation().PointDelay.TotalMilliseconds * chart.Diagram.Series.Count)
                    Next i
                End If
            End If
        End Sub
        Private Sub ChangeAnimation()
            If chart.Diagram IsNot Nothing Then
                If lbPointAnimation.SelectedItem IsNot Nothing Then
                    For Each series As Series In chart.Diagram.Series
                        Dim animationKind = CType(lbPointAnimation.SelectedItem, AnimationKind)
                        If animationKind.Name = "None" AndAlso animationKind.Type IsNot Nothing Then
                            Dim pointAnimation = DirectCast(Activator.CreateInstance(animationKind.Type), SeriesPointAnimationBase)
                            pointAnimation.Duration = New TimeSpan(0)
                            pointAnimation.PointDelay = New TimeSpan(0)
                            pointAnimation.BeginTime = New TimeSpan(0)
                            series.SetPointAnimation(pointAnimation)
                        Else
                            series.SetPointAnimation(If(animationKind.Type IsNot Nothing, DirectCast(Activator.CreateInstance(animationKind.Type), SeriesPointAnimationBase), Nothing))
                        End If
                    Next series
                End If
                If lbSeriesAnimation.SelectedItem IsNot Nothing Then
                    For Each series As Series In chart.Diagram.Series
                        Dim animationKind = CType(lbSeriesAnimation.SelectedItem, AnimationKind)
                        If animationKind.Name = "None" AndAlso animationKind.Type IsNot Nothing Then
                            Dim seriesAnimation = DirectCast(Activator.CreateInstance(animationKind.Type), SeriesAnimationBase)
                            seriesAnimation.Duration = New TimeSpan(0)
                            seriesAnimation.BeginTime = New TimeSpan(0)
                            series.SetSeriesAnimation(seriesAnimation)
                        Else
                            series.SetSeriesAnimation(If(animationKind.Type IsNot Nothing, DirectCast(Activator.CreateInstance(animationKind.Type), SeriesAnimationBase), Nothing))
                        End If
                    Next series
                End If
            End If
            PrepareAnimation()
        End Sub

        Private Sub cbSeriesTypes_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            UpdateSeries()
            If FirstSeries IsNot Nothing Then
                InitializeAnimationListBoxEdit(lbPointAnimation, FirstSeries.GetPredefinedPointAnimationKinds(), DefaultPointAnimationType)
                InitializeAnimationListBoxEdit(lbSeriesAnimation, FirstSeries.GetPredefinedSeriesAnimationKinds(), DefaultSeriesAnimationType)
                If Not loading Then
                    chart.Animate()
                End If
            End If
        End Sub
        Private Sub lbPointAnimation_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            ChangeAnimation()
            If Not loading Then
                chart.Animate()
            End If
        End Sub
        Private Sub lbSeriesAnimation_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            ChangeAnimation()
            If Not loading Then
                chart.Animate()
            End If
        End Sub
        Private Sub ChartsDemoModule_ModuleAppear(ByVal sender As Object, ByVal e As RoutedEventArgs)
            chart.Animate()
        End Sub
    End Class

    Public Class DataPoint
        Public Shared Function CreateDataPoint(ByVal argument As String, ByVal value1 As Double, ByVal value2 As Double, ByVal value3 As Double) As DataPoint
            Return New DataPoint(argument, Double.NaN, value1, value2, value3, Double.NaN, Double.NaN)
        End Function
        Public Shared Function CreateBarDataPoint(ByVal argument As String, ByVal value1 As Double, ByVal value2 As Double, ByVal value3 As Double, ByVal value4 As Double) As DataPoint
            Return New DataPoint(argument, Double.NaN, value1, value2, value3, value4, Double.NaN)
        End Function
        Public Shared Function CreateScatterDataPoint(ByVal argument As String, ByVal value1 As Double) As DataPoint
            Return New DataPoint(argument, Double.NaN, value1, Double.NaN, Double.NaN, Double.NaN, Double.NaN)
        End Function
        Public Shared Function CreateBubbleDataPoint(ByVal argument As String, ByVal value As Double, ByVal weight As Double) As DataPoint
            Return New DataPoint(argument, value, Double.NaN, Double.NaN, Double.NaN, Double.NaN, weight)
        End Function
        Public Shared Function CreateFinancialDataPoint(ByVal argument As String, ByVal lowValue As Double, ByVal highValue As Double, ByVal openValue As Double, ByVal closeValue As Double) As DataPoint
            Return New DataPoint(argument, Double.NaN, lowValue, highValue, openValue, closeValue, Double.NaN)
        End Function
        Public Shared Function CreatePieDataPoint(ByVal argument As String, ByVal value As Double) As DataPoint
            Return New DataPoint(argument, value, Double.NaN, Double.NaN, Double.NaN, Double.NaN, Double.NaN)
        End Function
        Public Shared Function CreatePolarRangeDataPoint(ByVal argument As Double, ByVal value1 As Double, ByVal value2 As Double) As DataPoint
            Return New DataPoint(argument, value1, value2)
        End Function
        Public Shared Function CreateDataPoint(ByVal argument As Double, ByVal value As Double) As DataPoint
            Return New DataPoint(argument, value)
        End Function

        Private privateArgument As Object
        Public Property Argument() As Object
            Get
                Return privateArgument
            End Get
            Private Set(ByVal value As Object)
                privateArgument = value
            End Set
        End Property
        Private privateNumericalArgument As Double
        Public Property NumericalArgument() As Double
            Get
                Return privateNumericalArgument
            End Get
            Private Set(ByVal value As Double)
                privateNumericalArgument = value
            End Set
        End Property
        Private privateValue As Double
        Public Property Value() As Double
            Get
                Return privateValue
            End Get
            Private Set(ByVal value As Double)
                privateValue = value
            End Set
        End Property
        Private privateValue1 As Double
        Public Property Value1() As Double
            Get
                Return privateValue1
            End Get
            Private Set(ByVal value As Double)
                privateValue1 = value
            End Set
        End Property
        Private privateValue2 As Double
        Public Property Value2() As Double
            Get
                Return privateValue2
            End Get
            Private Set(ByVal value As Double)
                privateValue2 = value
            End Set
        End Property
        Private privateValue3 As Double
        Public Property Value3() As Double
            Get
                Return privateValue3
            End Get
            Private Set(ByVal value As Double)
                privateValue3 = value
            End Set
        End Property
        Private privateValue4 As Double
        Public Property Value4() As Double
            Get
                Return privateValue4
            End Get
            Private Set(ByVal value As Double)
                privateValue4 = value
            End Set
        End Property
        Private privateWeight As Double
        Public Property Weight() As Double
            Get
                Return privateWeight
            End Get
            Private Set(ByVal value As Double)
                privateWeight = value
            End Set
        End Property
        Private privateLowValue As Double
        Public Property LowValue() As Double
            Get
                Return privateLowValue
            End Get
            Private Set(ByVal value As Double)
                privateLowValue = value
            End Set
        End Property
        Private privateHighValue As Double
        Public Property HighValue() As Double
            Get
                Return privateHighValue
            End Get
            Private Set(ByVal value As Double)
                privateHighValue = value
            End Set
        End Property
        Private privateOpenValue As Double
        Public Property OpenValue() As Double
            Get
                Return privateOpenValue
            End Get
            Private Set(ByVal value As Double)
                privateOpenValue = value
            End Set
        End Property
        Private privateCloseValue As Double
        Public Property CloseValue() As Double
            Get
                Return privateCloseValue
            End Get
            Private Set(ByVal value As Double)
                privateCloseValue = value
            End Set
        End Property

        Private Sub New(ByVal argument As String, ByVal value As Double, ByVal value1 As Double, ByVal value2 As Double, ByVal value3 As Double, ByVal value4 As Double, ByVal weight As Double)
            Me.Argument = argument
            Me.Value = value
            Me.Value1 = value1
            Me.Value2 = value2
            Me.Value3 = value3
            Me.Value4 = value4
            Me.Weight = weight
            LowValue = value1
            HighValue = value2
            OpenValue = value3
            CloseValue = value4
        End Sub
        Private Sub New(ByVal argument As Double, ByVal value As Double)
            Me.NumericalArgument = argument
            Me.Value = value
        End Sub
        Private Sub New(ByVal argument As Double, ByVal value1 As Double, ByVal value2 As Double)
            Me.NumericalArgument = argument
            Me.Value1 = value1
            Me.Value2 = value2
        End Sub
    End Class
End Namespace

Imports System
Imports System.Windows
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase

Namespace ChartsDemo
    <CodeFile("Modules/Appearance/CustomFinancial2DControl(.SL).xaml"), CodeFile("Modules/Appearance/CustomFinancial2DControl.xaml.(cs)")>
    Partial Public Class CustomFinancial2DControl
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
                lbSeriesType.Items.Add(New SeriesTypeItem(GetType(XYDiagram2D), GetType(StockSeries2D), "Stock", 1))
                lbSeriesType.Items.Add(New SeriesTypeItem(GetType(XYDiagram2D), GetType(CandleStickSeries2D), "Candle Stick", 1))
                lbSeriesType.SelectedIndex = 0
            Finally
                loading = False
            End Try
        End Sub
        Private Sub ChartsDemoModule_ModuleAppear(ByVal sender As Object, ByVal e As RoutedEventArgs)
            chart.Animate()
        End Sub
        Private Sub AddPoint(ByVal series As FinancialSeries2D, ByVal argument As Integer, ByVal low As Double, ByVal high As Double, ByVal open As Double, ByVal close As Double)
            Dim point As New SeriesPoint(argument)
            FinancialSeries2D.SetLowValue(point, low)
            FinancialSeries2D.SetHighValue(point, high)
            FinancialSeries2D.SetOpenValue(point, open)
            FinancialSeries2D.SetCloseValue(point, close)
            series.Points.Add(point)
        End Sub
        Private Sub lbSeriesType_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim item As SeriesTypeItem = TryCast(lbSeriesType.SelectedItem, SeriesTypeItem)
            If item IsNot Nothing Then
                Dim series As FinancialSeries2D = TryCast(Activator.CreateInstance(item.SeriesType), FinancialSeries2D)
                If series IsNot Nothing Then
                    series.Label = New SeriesLabel()
                    Dim labelTemplate As DataTemplate = TryCast(chart.Resources("labelTemplate"), DataTemplate)
                    If labelTemplate IsNot Nothing Then
                        series.Label.ElementTemplate = labelTemplate
                    End If
                    series.AnimationAutoStartMode = AnimationAutoStartMode.SetStartState
                    AddPoint(series, 1, 1.1, 2.9, 2.7, 1.6)
                    AddPoint(series, 2, 1.9, 2.6, 2.4, 2.1)
                    AddPoint(series, 3, 0.7, 2.4, 1.3, 2.1)
                    AddPoint(series, 4, 1.8, 2.8, 2.4, 1.9)
                    AddPoint(series, 5, 2.1, 3.4, 2.3, 3.1)
                    AddPoint(series, 6, 2.2, 3.2, 3.0, 2.6)
                    AddPoint(series, 7, 1.4, 2.7, 2.3, 2.5)
                    AddPoint(series, 8, 2.1, 3.6, 3.2, 2.7)
                    AddPoint(series, 9, 1.2, 3.1, 1.6, 2.6)
                    AddPoint(series, 10, 2.7, 4.1, 3.4, 4.0)
                    chart.Diagram.Series.Clear()
                    chart.Diagram.Series.Add(series)
                    If Not loading Then
                        chart.Animate()
                    End If
                End If
            End If
        End Sub
        Public Overrides Function SupportSidebarContent() As Boolean
            Return False
        End Function
    End Class
End Namespace

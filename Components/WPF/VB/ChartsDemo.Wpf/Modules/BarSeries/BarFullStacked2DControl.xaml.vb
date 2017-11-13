Imports System.Windows
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase

Namespace ChartsDemo
    <CodeFile("Modules/BarSeries/BarFullStacked2DControl(.SL).xaml"), CodeFile("Modules/BarSeries/BarFullStacked2DControl.xaml.(cs)")>
    Partial Public Class BarFullStacked2DControl
        Inherits ChartsDemoModule

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            lbModel.SelectedItem = Bar2DModelKindHelper.FindActualBar2DModelKind(GetType(FlatGlassBar2DModel))
        End Sub

        Private Sub ChartsDemoModule_ModuleAppear(ByVal sender As Object, ByVal e As RoutedEventArgs)
            chart.Animate()
        End Sub
        Private Sub chbPercent_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            For Each series As BarFullStackedSeries2D In chart.Diagram.Series
                series.Label.TextPattern = "{VP:P0}"
            Next series
        End Sub
        Private Sub chbPercent_Unchecked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            For Each series As BarFullStackedSeries2D In chart.Diagram.Series
                series.Label.TextPattern = "${V}K"
            Next series
        End Sub
    End Class
End Namespace

Imports System.Windows
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase

Namespace ChartsDemo
    <CodeFile("Modules/DataRepresentation/LogarithmicScaleControl(.SL).xaml"), CodeFile("Modules/DataRepresentation/LogarithmicScaleControl.xaml.(cs)")>
    Partial Public Class LogarithmicScaleControl
        Inherits ChartsDemoModule

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            For Each series As XYSeries2D In chart.Diagram.Series
                series.CrosshairLabelPattern = "Region: {S}" & ControlChars.Lf & "Population: {V}"
            Next series
        End Sub
        Private Sub ChartsDemoModule_ModuleAppear(ByVal sender As Object, ByVal e As RoutedEventArgs)
            chart.Animate()
        End Sub
        Private Sub AnimateLogarithmic(ByVal sender As Object, ByVal e As RoutedEventArgs)
            chart.Animate()
        End Sub
    End Class
End Namespace

Imports System.Windows
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase

Namespace ChartsDemo
    <CodeFile("Modules/RadarPolarSeries/RadarLineScatterSeriesControl(.SL).xaml"), CodeFile("Modules/RadarPolarSeries/RadarLineScatterSeriesControl.xaml.(cs)")>
    Partial Public Class RadarLineScatterSeriesControl
        Inherits ChartsDemoModule

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            chart.DataSource = FunctionsPointGenerator.GenerateRadianScatterPoints(ScatterCircularFunction.ArchimedeanSpiral)
        End Sub
        Private Sub lbFunction_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim [function] As ScatterCircularFunction
            Select Case lbFunction.SelectedIndex
                Case 0
                    [function] = ScatterCircularFunction.ArchimedeanSpiral
                Case 1
                    [function] = ScatterCircularFunction.Rose
                Case Else
                    [function] = ScatterCircularFunction.Folium
            End Select
            chart.DataSource = FunctionsPointGenerator.GenerateRadianScatterPoints([function])
            chart.Animate()
        End Sub
    End Class
End Namespace

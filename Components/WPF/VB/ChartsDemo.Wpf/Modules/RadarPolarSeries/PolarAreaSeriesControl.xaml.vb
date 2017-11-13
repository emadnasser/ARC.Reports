Imports System.Windows
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase

Namespace ChartsDemo
    <CodeFile("Modules/RadarPolarSeries/PolarAreaSeriesControl(.SL).xaml"), CodeFile("Modules/RadarPolarSeries/PolarAreaSeriesControl.xaml.(cs)")>
    Partial Public Class PolarAreaSeriesControl
        Inherits ChartsDemoModule

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            chart.DataSource = FunctionsPointGenerator.GeneratePoints(CircularFunction.Lemniskate)
        End Sub

        Private Sub lbFunction_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim f As CircularFunction
            If CStr(lbFunction.SelectedItem) = "Taubin's Heart" Then
                f = CircularFunction.TaubinsHeart
            ElseIf CStr(lbFunction.SelectedItem) = "Cardioid" Then
                f = CircularFunction.Cardioid
            Else
                f = CircularFunction.Lemniskate
            End If
            chart.DataSource = FunctionsPointGenerator.GeneratePoints(f)
            chart.Animate()
        End Sub
    End Class
End Namespace

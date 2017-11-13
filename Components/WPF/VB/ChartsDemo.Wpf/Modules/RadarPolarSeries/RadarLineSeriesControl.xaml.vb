Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase

Namespace ChartsDemo
    <CodeFile("Modules/RadarPolarSeries/RadarLineSeriesControl(.SL).xaml"), CodeFile("Modules/RadarPolarSeries/RadarLineSeriesControl.xaml.(cs)")>
    Partial Public Class RadarLineSeriesControl
        Inherits ChartsDemoModule

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            series.ToolTipPointPattern = "Direction: {A}" & ControlChars.Lf & "Speed: {V}"
        End Sub
    End Class
End Namespace

Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase

Namespace ChartsDemo
    <CodeFile("Modules/RadarPolarSeries/RadarAreaSeriesControl(.SL).xaml"), CodeFile("Modules/RadarPolarSeries/RadarAreaSeriesControl.xaml.(cs)")>
    Partial Public Class RadarAreaSeriesControl
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

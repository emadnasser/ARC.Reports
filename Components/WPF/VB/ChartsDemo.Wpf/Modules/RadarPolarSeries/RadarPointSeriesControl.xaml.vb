Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase

Namespace ChartsDemo
    <CodeFile("Modules/RadarPolarSeries/RadarPointSeriesControl(.SL).xaml"), CodeFile("Modules/RadarPolarSeries/RadarPointSeriesControl.xaml.(cs)")>
    Partial Public Class RadarPointSeriesControl
        Inherits ChartsDemoModule

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            seriesDayTemperature.ToolTipPointPattern = "Date: {A:MMMM}" & ControlChars.Lf & "Temperature: {V}"
            seriesNightTempertaure.ToolTipPointPattern = "Date: {A:MMMM}" & ControlChars.Lf & "Temperature: {V}"
        End Sub
    End Class
End Namespace

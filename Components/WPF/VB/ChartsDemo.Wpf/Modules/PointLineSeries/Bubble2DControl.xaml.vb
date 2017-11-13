Imports System.Data
Imports System.Windows
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase

Namespace ChartsDemo
    <CodeFile("Modules/PointLineSeries/Bubble2DControl(.SL).xaml"), CodeFile("Modules/PointLineSeries/Bubble2DControl.xaml.(cs)")>
    Partial Public Class Bubble2DControl
        Inherits ChartsDemoModule

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            lbMarker.SelectedItem = Marker2DModelKindHelper.FindActualMarker2DModelKind(GetType(RingMarker2DModel))
        End Sub
        Private Sub ChartsDemoModule_ModuleAppear(ByVal sender As Object, ByVal e As RoutedEventArgs)
            chart.Animate()
        End Sub
        Private Sub chart_CustomDrawSeriesPoint(ByVal sender As Object, ByVal e As CustomDrawSeriesPointEventArgs)
            e.LegendText = (DirectCast(CType(e.SeriesPoint.Tag, DataRowView).Row("Title"), String)).Replace(ControlChars.Lf, " ")
        End Sub
    End Class
End Namespace

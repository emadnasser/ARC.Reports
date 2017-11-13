Imports System.Windows
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase

Namespace ChartsDemo
    <CodeFile("Modules/AreaSeries/SplineArea2DControl(.SL).xaml"), CodeFile("Modules/AreaSeries/SplineArea2DControl.xaml.(cs)")>
    Partial Public Class SplineArea2DControl
        Inherits ChartsDemoModule

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            lbMarker.SelectedItem = Marker2DModelKindHelper.FindActualMarker2DModelKind(GetType(RingMarker2DModel))
            For Each series As AreaSeries2D In chart.Diagram.Series
                series.CrosshairLabelPattern = "Year: {S}" & ControlChars.Lf & "Market Value: {V:0.00}"
            Next series
        End Sub
        Private Sub ChartsDemoModule_ModuleAppear(ByVal sender As Object, ByVal e As RoutedEventArgs)
            chart.Animate()
        End Sub
    End Class
End Namespace

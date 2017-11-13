Imports System.Windows
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase

Namespace ChartsDemo
    <CodeFile("Modules/PointLineSeries/Spline2DControl(.SL).xaml"), CodeFile("Modules/PointLineSeries/Spline2DControl.xaml.(cs)")>
    Partial Public Class Spline2DControl
        Inherits ChartsDemoModule

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            lbMarker.SelectedItem = Marker2DModelKindHelper.FindActualMarker2DModelKind(GetType(CrossMarker2DModel))
            For Each series As SplineSeries2D In chart.Diagram.Series
                series.CrosshairLabelPattern = "Date: {A:d}" & ControlChars.Lf & "Cents per Gallon: {V:0.0}"
            Next series
        End Sub
        Private Sub ChartsDemoModule_ModuleAppear(ByVal sender As Object, ByVal e As RoutedEventArgs)
            chart.Animate()
        End Sub
    End Class
End Namespace

Imports System.Windows
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase

Namespace ChartsDemo
    <CodeFile("Modules/PointLineSeries/FullStackedLine2DControl(.SL).xaml"), CodeFile("Modules/PointLineSeries/FullStackedLine2DControl.xaml.(cs)")>
    Partial Public Class FullStackedLine2DControl
        Inherits ChartsDemoModule

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            lbMarker.SelectedItem = Marker2DModelKindHelper.FindActualMarker2DModelKind(GetType(CrossMarker2DModel))
        End Sub
        Private Sub ChartsDemoModule_ModuleAppear(ByVal sender As Object, ByVal e As RoutedEventArgs)
            chart.Animate()
        End Sub
        Private Sub chbPercent_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If chart IsNot Nothing Then
                For Each series As LineFullStackedSeries2D In CType(chart.Diagram, XYDiagram2D).Series
                    series.Label.TextPattern = "{VP:P2}"
                Next series
            End If
        End Sub
        Private Sub chbPercent_UnChecked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If chart IsNot Nothing Then
                For Each series As LineFullStackedSeries2D In CType(chart.Diagram, XYDiagram2D).Series
                    series.Label.TextPattern = "${V}M"
                Next series
            End If
        End Sub
    End Class
End Namespace

Imports System.Windows
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase

Namespace ChartsDemo
    <CodeFile("Modules/AreaSeries/FullStackedStepArea2DControl(.SL).xaml"), CodeFile("Modules/AreaSeries/FullStackedStepArea2DControl.xaml.(cs)")>
    Partial Public Class FullStackedStepArea2DControl
        Inherits ChartsDemoModule

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            For Each series As AreaStackedSeries2D In chart.Diagram.Series
                series.CrosshairLabelPattern = "{S}" & ControlChars.Lf & "{V:0.00}"
            Next series
        End Sub
        Private Sub ChartsDemoModule_ModuleAppear(ByVal sender As Object, ByVal e As RoutedEventArgs)
            chart.Animate()
        End Sub
        Private Sub chbPercent_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If chart IsNot Nothing Then
                For Each series As AreaStepFullStackedSeries2D In CType(chart.Diagram, XYDiagram2D).Series
                    series.Label.TextPattern = "{VP:P0}"
                Next series
            End If
        End Sub
        Private Sub chbPercent_UnChecked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If chart IsNot Nothing Then
                For Each series As AreaStepFullStackedSeries2D In CType(chart.Diagram, XYDiagram2D).Series
                    series.Label.TextPattern = "{V:N0}"
                Next series
            End If
        End Sub
    End Class
End Namespace

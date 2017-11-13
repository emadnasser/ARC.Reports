Imports System.Windows
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase

Namespace ChartsDemo
    <CodeFile("Modules/ResolveLabelsOverlapping/ResolveLabelsOverlappingForXYSeries(.SL).xaml"), CodeFile("Modules/ResolveLabelsOverlapping/ResolveLabelsOverlappingForXYSeries.xaml.(cs)")>
    Partial Public Class ResolveLabelsOverlappingForXYSeries
        Inherits ChartsDemoModule

        Private ReadOnly Property Label() As SeriesLabel
            Get
                Return If(chart IsNot Nothing, chart.Diagram.Series(0).Label, Nothing)
            End Get
        End Property
        Private ReadOnly Property Diagram() As XYDiagram2D
            Get
                Return If(chart IsNot Nothing, TryCast(chart.Diagram, XYDiagram2D), Nothing)
            End Get
        End Property
        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            ResolveOverlappingModeHelper.PrepareListBox(lbMode, 4)
            UpdateControls()
        End Sub
        Private Sub ChartsDemoModule_ModuleAppear(ByVal sender As Object, ByVal e As RoutedEventArgs)
            chart.Animate()
        End Sub
        Private Sub UpdateControls()
            If Label IsNot Nothing Then
                gfIndent.IsEnabled = Label.ResolveOverlappingMode <> ResolveOverlappingMode.None
                gfAngle.IsEnabled = Label.ResolveOverlappingMode <> ResolveOverlappingMode.JustifyAllAroundPoint
            End If
        End Sub
        Private Sub lbMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If Label IsNot Nothing Then
                Label.ResolveOverlappingMode = ResolveOverlappingModeHelper.GetMode(lbMode)
            End If
            UpdateControls()
        End Sub
    End Class
End Namespace

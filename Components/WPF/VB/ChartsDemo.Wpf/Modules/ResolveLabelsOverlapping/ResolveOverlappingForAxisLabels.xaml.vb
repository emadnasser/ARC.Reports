Imports System.Windows
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase

Namespace ChartsDemo
    <CodeFile("Modules/ResolveLabelsOverlapping/ResolveOverlappingForAxisLabels(.SL).xaml"), CodeFile("Modules/ResolveLabelsOverlapping/ResolveOverlappingForAxisLabels.xaml.(cs)")>
    Partial Public Class ResolveOverlappingForAxisLabels
        Inherits ChartsDemoModule

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub ChartsDemoModule_ModuleAppear(ByVal sender As Object, ByVal e As RoutedEventArgs)
            chart.Animate()
        End Sub
    End Class
End Namespace

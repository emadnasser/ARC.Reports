Imports System.Windows.Media.Media3D
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase

Namespace ChartsDemo
    <CodeFile("Modules/ResolveLabelsOverlapping/ResolveLabelsOverlappingfor3DPieSeries(.SL).xaml"), CodeFile("Modules/ResolveLabelsOverlapping/ResolveLabelsOverlappingfor3DPieSeries.xaml.(cs)")>
    Partial Public Class ResolveLabelsOverlappingfor3DPieSeries
        Inherits ChartsDemoModule

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            simpleDiagram3D.ContentTransform = New MatrixTransform3D(New Matrix3D(-0.719, -0.414, 0.558, 0, 0.693, -0.389, 0.605, 0, -0.032, 0.822, 0.567, 0, 0.000, 0.000, 0.000, 1))
        End Sub
    End Class
End Namespace

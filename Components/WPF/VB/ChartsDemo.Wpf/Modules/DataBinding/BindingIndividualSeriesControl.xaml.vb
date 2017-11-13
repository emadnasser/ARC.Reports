Imports System.Collections.ObjectModel
Imports System.Windows
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase

Namespace ChartsDemo
    <CodeFile("Modules/DataBinding/BindingIndividualSeriesControl(.SL).xaml"), CodeFile("Modules/DataBinding/BindingIndividualSeriesControl.xaml.(cs)")>
    Partial Public Class BindingIndividualSeriesControl
        Inherits ChartsDemoModule

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            series.ToolTipPointPattern = "X = {A}" & ControlChars.Lf & "Y = {V}"
        End Sub
        Private Sub ChartsDemoModule_ModuleAppear(ByVal sender As Object, ByVal e As RoutedEventArgs)
            chart.Animate()
        End Sub

    End Class
    Public Class PointCollection
        Inherits ObservableCollection(Of Point)

    End Class
End Namespace

Imports System.Windows
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase

Namespace ChartsDemo
    <CodeFile("Modules/BarSeries/OverlappedRangeBar2DControl(.SL).xaml"), CodeFile("Modules/BarSeries/OverlappedRangeBar2DControl.xaml.(cs)")>
    Partial Public Class OverlappedRangeBar2DControl
        Inherits ChartsDemoModule

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            lbModel.SelectedItem = RangeBar2DModelKindHelper.FindActualRangeBar2DModelKind(GetType(OutsetRangeBar2DModel))
            For Each series As Series In chart.Diagram.Series
                series.ToolTipPointPattern = "{S}" & ControlChars.Lf & "Month: {A:MMMM}" & ControlChars.Lf & "Min Price: ${V1:0.00}" & ControlChars.Lf & "Max Price: ${V2:0.00}"
            Next series
        End Sub
        Private Sub ChartsDemoModule_ModuleAppear(ByVal sender As Object, ByVal e As RoutedEventArgs)
            chart.Animate()
        End Sub
    End Class
End Namespace

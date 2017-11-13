Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase
Imports System.Windows

Namespace ChartsDemo
    <CodeFile("Modules/ChartElements/SeriesTitlesControl(.SL).xaml"), CodeFile("Modules/ChartElements/SeriesTitlesControl.xaml.(cs)")>
    Partial Public Class SeriesTitlesControl
        Inherits ChartsDemoModule

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Chart_CustomDrawSeriesPoint(ByVal sender As Object, ByVal e As CustomDrawSeriesPointEventArgs)
            Dim chart As ChartControl = TryCast(sender, ChartControl)
            If chart Is Nothing Then
                Return
            End If
            If chart.Diagram.Series.Count > 0 AndAlso (Not chart.Diagram.Series(0).Equals(e.Series)) Then
                e.LegendText = String.Empty
            End If
        End Sub
        Private Sub ChartsDemoModule_ModuleAppear(ByVal sender As Object, ByVal e As RoutedEventArgs)
            chart.Animate()
        End Sub
    End Class
End Namespace

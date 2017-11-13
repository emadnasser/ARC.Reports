Imports System.Globalization
Imports System.Windows
Imports System.Windows.Markup
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase

Namespace ChartsDemo
    <CodeFile("Modules/FinancialSeries/CandleStick2DControl(.SL).xaml"), CodeFile("Modules/FinancialSeries/CandleStick2DControl.xaml.(cs)")>
    Partial Public Class CandleStick2DControl
        Inherits ChartsDemoModule

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            lbModel.SelectedItem = CandleStick2DModelKindHelper.FindActualCandleStick2DModelKind(GetType(SimpleCandleStick2DModel))
            chart.Diagram.Series(0).DataSource = FinancialDataLoader.GetGoogleStockData()
            Me.Language = XmlLanguage.GetLanguage(CultureInfo.CurrentCulture.Name)
        End Sub
        Public Overrides Function SupportSidebarContent() As Boolean
            Return False
        End Function
        Private Sub ChartsDemoModule_ModuleAppear(ByVal sender As Object, ByVal e As RoutedEventArgs)
            chart.Animate()
        End Sub

        Private Sub cbReductionLevel_SelectionChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If chart IsNot Nothing Then
                Dim series As CandleStickSeries2D = CType(chart.Diagram.Series(0), CandleStickSeries2D)
                series.ReductionOptions.Level = CType(cbReductionLevel.SelectedIndex, StockLevel)
            End If
        End Sub
    End Class
End Namespace

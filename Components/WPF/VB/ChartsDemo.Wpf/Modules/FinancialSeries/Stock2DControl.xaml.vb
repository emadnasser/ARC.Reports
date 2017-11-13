Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase
Imports System.Windows

Namespace ChartsDemo
    <CodeFile("Modules/FinancialSeries/Stock2DControl(.SL).xaml"), CodeFile("Modules/FinancialSeries/Stock2DControl.xaml.(cs)")>
    Partial Public Class Stock2DControl
        Inherits ChartsDemoModule

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            lbModel.SelectedItem = Stock2DModelKindHelper.FindActualStock2DModelKind(GetType(ThinStock2DModel))
            chart.Diagram.Series(0).DataSource = FinancialDataLoader.GetGoogleStockData()
        End Sub
        Private Sub ChartsDemoModule_ModuleAppear(ByVal sender As Object, ByVal e As RoutedEventArgs)
            chart.Animate()
        End Sub
        Public Overrides Function SupportSidebarContent() As Boolean
            Return False
        End Function
    End Class

    Public Class ComboBoxItem
        Public Property Text() As String
        Public Property Value() As String
    End Class
End Namespace

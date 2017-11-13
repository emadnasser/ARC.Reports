Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase

Namespace ChartsDemo
    <CodeFile("Modules/DataAnalysis/TrendIndicatorsControl(.SL).xaml"), CodeFile("Modules/DataAnalysis/TrendIndicatorsControl.xaml.(cs)")>
    Partial Public Class TrendIndicatorsControl
        Inherits ChartsDemoModule

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            chart.Diagram.Series(0).DataSource = CsvReader.ReadFinancialData("USDJPYDaily.csv")
        End Sub

        Public Overrides Function SupportSidebarContent() As Boolean
            Return False
        End Function
    End Class
End Namespace

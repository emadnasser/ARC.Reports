Imports DevExpress.XtraReports

Namespace ReportWpfDemo

    Partial Public Class PivotGridAndChart
        Inherits ReportModuleBase

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class

    Public Class PivotGridAndChartViewModel
        Inherits ReportModuleViewModelBase

        Protected Overrides Function CreateReport() As IReport
            Return New XtraReportsDemos.PivotGridAndChart.Report()
        End Function
    End Class
End Namespace

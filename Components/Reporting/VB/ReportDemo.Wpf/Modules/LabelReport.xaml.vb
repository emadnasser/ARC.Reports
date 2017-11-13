Imports DevExpress.XtraReports

Namespace ReportWpfDemo
    Partial Public Class LabelReport
        Inherits ReportModuleBase

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class

    Public Class LabelReportViewModel
        Inherits ReportModuleViewModelBase

        Protected Overrides Function CreateReport() As IReport
            Return New XtraReportsDemos.BarCodes.ProductLabelsReport()
        End Function
    End Class
End Namespace

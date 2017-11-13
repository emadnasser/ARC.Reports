Imports DevExpress.XtraReports

Namespace ReportWpfDemo
    Partial Public Class CalculatedFields
        Inherits ReportModuleBase

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class

    Public Class CalculatedFieldsViewModel
        Inherits ReportModuleViewModelBase

        Protected Overrides Function CreateReport() As IReport
            Return New XtraReportsDemos.CalculatedFieldsReport.Report()
        End Function
    End Class
End Namespace

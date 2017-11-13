Imports DevExpress.XtraReports

Namespace ReportWpfDemo
    Partial Public Class RichText
        Inherits ReportModuleBase

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class

    Public Class RichTextViewModel
        Inherits ReportModuleViewModelBase

        Protected Overrides Function CreateReport() As IReport
            Return New XtraReportsDemos.RichText.Report()
        End Function
    End Class
End Namespace

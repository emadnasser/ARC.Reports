Imports DevExpress.XtraReports

Namespace ReportWpfDemo
    Partial Public Class ConditionalFormatting
        Inherits ReportModuleBase

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class

    Public Class ConditionalFormattingViewModel
        Inherits ReportModuleViewModelBase

        Protected Overrides Function CreateReport() As IReport
            Return New XtraReportsDemos.FormattingRules.Report()
        End Function
    End Class
End Namespace

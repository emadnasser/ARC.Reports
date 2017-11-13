Imports DevExpress.XtraReports

Namespace ReportWpfDemo
    Partial Public Class CustomControl
        Inherits ReportModuleBase

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class

    Public Class CustomControlViewModel
        Inherits ReportModuleViewModelBase

        Protected Overrides Function CreateReport() As IReport
            Return New XtraReportsDemos.CustomDraw.Report()
        End Function
    End Class
End Namespace

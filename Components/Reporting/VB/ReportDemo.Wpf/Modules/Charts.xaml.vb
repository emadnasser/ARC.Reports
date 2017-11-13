Imports DevExpress.XtraReports

Namespace ReportWpfDemo
    Partial Public Class Charts
        Inherits ReportModuleBase

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class

    Public Class ChartsViewModel
        Inherits ReportModuleViewModelBase

        Protected Overrides Function CreateReport() As IReport
            Return New XtraReportsDemos.Charts.Report()
        End Function
    End Class
End Namespace


Imports DevExpress.XtraReports

Namespace ReportWpfDemo
    Partial Public Class Sparkline
        Inherits ReportModuleBase

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class
    Public Class SparklineViewModel
        Inherits ReportModuleViewModelBase

        Public Sub New()
        End Sub

        Protected Overrides Function CreateReport() As IReport
            Return New XtraReportsDemos.Sparkline.Report()
        End Function
    End Class
End Namespace

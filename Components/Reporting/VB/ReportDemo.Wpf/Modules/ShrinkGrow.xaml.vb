Imports DevExpress.XtraReports

Namespace ReportWpfDemo
    Partial Public Class ShrinkGrow
        Inherits ReportModuleBase

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class

    Public Class ShrinkGrowViewModel
        Inherits ReportModuleViewModelBase

        Protected Overrides Function CreateReport() As IReport
            Return New XtraReportsDemos.ShrinkGrow.Report()
        End Function
    End Class
End Namespace

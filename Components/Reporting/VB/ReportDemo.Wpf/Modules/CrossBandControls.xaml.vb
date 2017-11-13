Imports DevExpress.XtraReports

Namespace ReportWpfDemo
    Partial Public Class CrossBandControls
        Inherits ReportModuleBase

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class

    Public Class CrossBandControlsViewModel
        Inherits ReportModuleViewModelBase

        Protected Overrides Function CreateReport() As IReport
            Return New XtraReportsDemos.CrossBandControls.Report()
        End Function
    End Class
End Namespace

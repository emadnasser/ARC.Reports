Imports DevExpress.XtraReports

Namespace ReportWpfDemo
    Partial Public Class BarCodes
        Inherits ReportModuleBase

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class
    Public Class BarCodesViewModel
        Inherits ReportModuleViewModelBase

        Protected Overrides Function CreateReport() As IReport
            Return New XtraReportsDemos.BarCodes.BarCodeTypesReport()
        End Function
    End Class
End Namespace

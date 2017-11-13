Imports DevExpress.XtraReports

Namespace ReportWpfDemo
    Partial Public Class FallCatalog
        Inherits ReportModuleBase

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class

    Public Class FallCatalogViewModel
        Inherits ReportModuleViewModelBase

        Protected Overrides Function CreateReport() As IReport
            Return New XtraReportsDemos.NorthwindTraders.CatalogReport()
        End Function
    End Class
End Namespace

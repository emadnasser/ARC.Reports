Imports System

Namespace XtraReportsDemos.NorthwindTraders
    Public Class CatalogPreviewControl
        Inherits XtraReportsDemos.PreviewControl

        Protected Overrides Function CreateReport() As DevExpress.XtraReports.UI.XtraReport
            Return New CatalogReport()
        End Function
    End Class
End Namespace

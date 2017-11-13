Imports System

Namespace XtraReportsDemos.NorthwindTraders
    Public Class InvoicePreviewControl
        Inherits XtraReportsDemos.PreviewControl

        Protected Overrides Function CreateReport() As DevExpress.XtraReports.UI.XtraReport
            Return New InvoiceReport()
        End Function
    End Class
End Namespace

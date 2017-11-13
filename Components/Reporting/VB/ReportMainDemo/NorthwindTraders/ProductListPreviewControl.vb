Imports System


Namespace XtraReportsDemos.NorthwindTraders
    Public Class ProductListPreviewControl
        Inherits XtraReportsDemos.PreviewControl

        Protected Overrides Function CreateReport() As DevExpress.XtraReports.UI.XtraReport
            Return New ProductListReport()
        End Function
    End Class
End Namespace


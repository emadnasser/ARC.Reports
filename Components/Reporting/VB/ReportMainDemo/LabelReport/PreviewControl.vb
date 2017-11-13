Imports System

Namespace XtraReportsDemos.LabelReport
    Public Class PreviewControl
        Inherits XtraReportsDemos.PreviewControl

        Protected Overrides Function CreateReport() As DevExpress.XtraReports.UI.XtraReport
            Return New XtraReportsDemos.BarCodes.ProductLabelsReport()
        End Function
    End Class
End Namespace

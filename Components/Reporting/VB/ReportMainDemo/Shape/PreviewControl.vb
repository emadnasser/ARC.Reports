Imports System

Namespace XtraReportsDemos.Shape
    Public Class PreviewControl
        Inherits XtraReportsDemos.PreviewControl

        Protected Overrides Function CreateReport() As DevExpress.XtraReports.UI.XtraReport
            Return New Report()
        End Function
    End Class

End Namespace

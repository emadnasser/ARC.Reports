Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace XtraReportsDemos.Sparkline
    Friend Class PreviewControl
        Inherits XtraReportsDemos.PreviewControl

        Protected Overrides Function CreateReport() As DevExpress.XtraReports.UI.XtraReport
            Return New Report()
        End Function
    End Class
End Namespace

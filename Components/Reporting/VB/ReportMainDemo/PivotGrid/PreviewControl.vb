Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraReports.UI
Imports System.Windows.Forms


Namespace XtraReportsDemos.PivotGrid
    Public Class PreviewControl
        Inherits XtraReportsDemos.PreviewControl

        Protected Overrides Function CreateReport() As XtraReport
            Return New Report()
        End Function
    End Class
End Namespace


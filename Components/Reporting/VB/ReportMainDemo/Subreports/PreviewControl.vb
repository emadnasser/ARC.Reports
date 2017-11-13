Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraReports.UI
Imports System.Windows.Forms

Namespace XtraReportsDemos.Subreports
    Public Class PreviewControl
        Inherits XtraReportsDemos.PreviewControl

        Protected Overrides Function CreateReport() As XtraReport
            Return New MasterReport()
        End Function
    End Class
End Namespace


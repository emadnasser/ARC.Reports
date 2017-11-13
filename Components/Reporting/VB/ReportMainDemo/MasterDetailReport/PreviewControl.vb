Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting.Native

Namespace XtraReportsDemos.MasterDetailReport
    Public Class PreviewControl
        Inherits XtraReportsDemos.PreviewControl

        Protected Overrides Function CreateReport() As XtraReport
            Dim report As New MasterDetailReport.Report()
            Return report
        End Function
    End Class
End Namespace


Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraReports.UI
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraReports.Parameters
Imports DevExpress.XtraReports.Extensions

Namespace XtraReportsDemos.DrillDownReport
    Public Class PreviewControl
        Inherits XtraReportsDemos.PreviewControl

        Protected Overrides Function CreateReport() As XtraReport
             Return New XtraReportsDemos.DrillDownReport.DrillDownReport()
        End Function
    End Class
End Namespace


Imports System
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraReports.Parameters
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Extensions

Namespace XtraReportsDemos.SideBySideReports
    Public Class PreviewControl
        Inherits XtraReportsDemos.PreviewControl

        Protected Overrides Function CreateReport() As DevExpress.XtraReports.UI.XtraReport
            Return New EmployeeComparisonReport()
        End Function
    End Class
End Namespace

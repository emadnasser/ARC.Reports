Imports System
Imports System.ComponentModel
Imports System.Collections
Imports System.Diagnostics
Imports DevExpress.XtraReports.UI
Imports DevExpress.DataAccess.ConnectionParameters

Namespace XtraReportsDemos.TableReport
    Partial Public Class Report
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()
            Name = ReportNames.TableReport
            DisplayName = ReportNames.TableReport
        End Sub
    End Class
End Namespace

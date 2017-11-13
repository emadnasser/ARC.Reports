Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports System.Data

Namespace XtraReportsDemos.SideBySideReports
    Partial Public Class EmployeeOrdersReport
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()
            Name = ReportNames.SideBySideReports
            DisplayName = ReportNames.SideBySideReports
        End Sub
    End Class
End Namespace

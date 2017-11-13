Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Parameters
Imports DevExpress.XtraEditors

Namespace XtraReportsDemos.SideBySideReports
    Partial Public Class EmployeeComparisonReport
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()
            Name = ReportNames.SideBySideReports
            DisplayName = ReportNames.SideBySideReports
        End Sub
        Private Sub DisposeReportSource(ByVal subreport As XRSubreport)
            Dim report As XtraReport = subreport.ReportSource
            If report IsNot Nothing AndAlso (Not report.IsDisposed) Then
                report.Dispose()
            End If
        End Sub
        Protected Overrides Sub OnDisposing()
            DisposeReportSource(xrSubreport1)
            DisposeReportSource(xrSubreport2)
            MyBase.OnDisposing()
        End Sub
    End Class
End Namespace

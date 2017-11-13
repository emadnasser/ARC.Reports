Imports System

Partial Public Class DocumentViewer
    Inherits System.Web.UI.Page

    Private Const LoadReportArgsKey As String = "ReportArgs"
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        Dim report = DemoUtils.CreateReport(Request.QueryString(LoadReportArgsKey))
        If report IsNot Nothing Then
            DocumentViewerControl.Report = report
        End If
    End Sub
End Class

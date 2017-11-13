Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Web
Imports System.Web.UI
Imports DevExpress.Web
Imports DevExpress.Web.Demos
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Web
Imports DevExpress.XtraReports.Web.Extensions

Partial Public Class Designer
	Inherits Page
	Private reportName As String

	Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)

		Header.Title = Utils.GetCurrentDemoPageTitle()

		reportName = Request.QueryString("reportName")
		redirectValue.Value = Request.QueryString("redirectUrl")
		If (Not IsRelativeUrl(redirectValue.Value)) OrElse String.IsNullOrEmpty(reportName) Then
			Response.Redirect("~/")
		End If

		If (Not IsPostBack) Then
			reportDesigner.OpenReport(reportName)
		End If
	End Sub

	Private Shared Function IsRelativeUrl(ByVal url As String) As Boolean
		Dim ignore As Uri = Nothing
		Return Uri.TryCreate(url, UriKind.Relative, ignore)
	End Function
End Class


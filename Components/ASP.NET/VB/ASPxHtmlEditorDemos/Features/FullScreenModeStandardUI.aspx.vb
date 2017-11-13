Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web

Partial Public Class Features_FullScreenModeStandardUI
	Inherits System.Web.UI.Page

	Protected Sub Page_PreInit(ByVal sender As Object, ByVal e As EventArgs)
		ASPxWebControl.GlobalTheme = "Mulberry"
		DevExpress.Web.Demos.Utils.ResetThemeParameters()
	End Sub

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			HtmlEditorUtils.SetHtml(Me, DemoHtmlEditor, "Features/FullScreenModeContent.html")
		End If
	End Sub
End Class

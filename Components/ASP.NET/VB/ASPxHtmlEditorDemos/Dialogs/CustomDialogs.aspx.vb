Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Partial Public Class Dialogs_CustomDialogs
	Inherits Page

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			HtmlEditorUtils.SetHtml(Me, DemoHtmlEditor, "Dialogs/CustomDialogs.html")
		End If
	End Sub

End Class

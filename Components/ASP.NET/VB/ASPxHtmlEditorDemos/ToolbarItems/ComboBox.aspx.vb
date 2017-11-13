Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Partial Public Class ToolbarItems_ComboBox
	Inherits Page

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			HtmlEditorUtils.SetHtml(Me, DemoHtmlEditor, "ToolbarItems/ComboBox.html")
		End If
	End Sub

End Class

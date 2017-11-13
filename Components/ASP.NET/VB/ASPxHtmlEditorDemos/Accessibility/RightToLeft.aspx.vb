Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class Accessibility_RightToLeft
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			HtmlEditorUtils.SetHtml(Me, DemoHtmlEditor, "Accessibility/RightToLeft.html")
		End If
	End Sub
End Class

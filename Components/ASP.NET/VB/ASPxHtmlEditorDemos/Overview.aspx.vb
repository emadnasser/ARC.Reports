Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web
Imports DevExpress.Web.ASPxHtmlEditor

Partial Public Class Overview
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			HtmlEditorUtils.SetHtml(Me, DemoHtmlEditor, "Overview/Blueberry.html")
			DemoHtmlEditor.Toolbars.Add(HtmlEditorToolbar.CreateStandardToolbar1())
			DemoHtmlEditor.Toolbars.Add(HtmlEditorToolbar.CreateStandardToolbar2())
			DemoHtmlEditor.Toolbars(1).Items.RemoveAll(Function(item) item.GetType() Is GetType(ToolbarParagraphFormattingEdit))
		End If
	End Sub
End Class

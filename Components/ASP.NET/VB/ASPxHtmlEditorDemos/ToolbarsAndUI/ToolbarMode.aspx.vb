Imports Microsoft.VisualBasic
Imports System
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web.ASPxHtmlEditor

Partial Public Class Features_ToolbarMode
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			HtmlEditorUtils.SetHtml(Me, DemoHtmlEditor, "ToolbarItems/ComboBox.html")
		Else
			DemoHtmlEditor.ToolbarMode = CType(CInt(Fix(cbToolbarMode.Value)), HtmlEditorToolbarMode)
		End If
	End Sub
End Class

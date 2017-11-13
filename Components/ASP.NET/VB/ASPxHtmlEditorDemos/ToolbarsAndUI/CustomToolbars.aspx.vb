Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web.ASPxHtmlEditor

Partial Public Class Features_CustomToolbars
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			HtmlEditorUtils.SetHtml(Me, DemoHtmlEditor, "Features/CustomToolbar.html")

			DemoHtmlEditor.Toolbars.Add(CreateDemoCustomToolbar("CustomToolbar"))
			DemoHtmlEditor.Toolbars.Add(HtmlEditorToolbar.CreateStandardToolbar1())
			DemoHtmlEditor.Toolbars("StandardToolbar1").Visible = False
			DemoHtmlEditor.Toolbars.Add(HtmlEditorToolbar.CreateStandardToolbar2())
			DemoHtmlEditor.Toolbars("StandardToolbar2").Visible = False
		End If
	End Sub

	Protected Function CreateDemoCustomToolbar(ByVal name As String) As HtmlEditorToolbar
		Return New HtmlEditorToolbar(name, New ToolbarFontNameEdit(), New ToolbarFontSizeEdit(), New ToolbarJustifyLeftButton(True), New ToolbarJustifyCenterButton(), New ToolbarJustifyRightButton(), New ToolbarJustifyFullButton(), New ToolbarInsertLinkDialogButton(True), New ToolbarInsertImageDialogButton()).CreateDefaultItems()
	End Function

	Protected Sub cbToolbar_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
		Dim showStandardToolbars As Boolean = String.Equals(cbToolbar.Value, "Standard")
		DemoHtmlEditor.Toolbars("CustomToolbar").Visible = Not showStandardToolbars
		DemoHtmlEditor.Toolbars("StandardToolbar1").Visible = showStandardToolbars
		DemoHtmlEditor.Toolbars("StandardToolbar2").Visible = showStandardToolbars
	End Sub
End Class

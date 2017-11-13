Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web.ASPxHtmlEditor

Partial Public Class Features_SpellChecking
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			HtmlEditorUtils.SetHtml(Me, DemoHtmlEditor, "Features/Tables.html")

			DemoHtmlEditor.Toolbars.Add(HtmlEditorToolbar.CreateStandardToolbar1())
			DemoHtmlEditor.Toolbars.Add(HtmlEditorToolbar.CreateStandardToolbar2())
			DemoHtmlEditor.Toolbars.Add(HtmlEditorToolbar.CreateTableToolbar())

			UpdateVisibility()
		End If
	End Sub

	Protected Sub rbTable_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
		UpdateVisibility()
	End Sub

	Protected Sub UpdateVisibility()
		Dim showTableToolbar As Boolean = rbTableToolbar.Checked
		DemoHtmlEditor.Toolbars("TableToolbar").Visible = showTableToolbar
		DemoHtmlEditor.Toolbars("StandardToolbar1").Items.FindByText("Insert Table").Visible = Not showTableToolbar
	End Sub
End Class

Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Partial Public Class ToolbarItems_DropdownItemPicker
	Inherits Page

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			HtmlEditorUtils.SetHtml(Me, DemoHtmlEditor, "ToolbarItems/DropdownItemPicker.html")

			DemoHtmlEditor.Toolbars(0).Items(7).Image.Url = If(HtmlEditorUtils.IsDarkTheme(Theme), "../Content/Demo/Toolbar/symbol-dark.png", "../Content/Demo/Toolbar/symbol.png")
		End If
	End Sub

End Class

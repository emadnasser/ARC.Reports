Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class Features_Resizing
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			HtmlEditorUtils.SetHtml(Me, DemoHtmlEditor, "Features/Resizing.html")

			cbAllowResize.Checked = DemoHtmlEditor.SettingsResize.AllowResize
			seMinWidth.Number = DemoHtmlEditor.SettingsResize.MinWidth
			seMaxWidth.Number = DemoHtmlEditor.SettingsResize.MaxWidth
			seMinHeight.Number = DemoHtmlEditor.SettingsResize.MinHeight
			seMaxHeight.Number = DemoHtmlEditor.SettingsResize.MaxHeight
		Else
			DemoHtmlEditor.SettingsResize.AllowResize = cbAllowResize.Checked
			DemoHtmlEditor.SettingsResize.MinWidth = Decimal.ToInt32(seMinWidth.Number)
			DemoHtmlEditor.SettingsResize.MaxWidth = Decimal.ToInt32(seMaxWidth.Number)
			DemoHtmlEditor.SettingsResize.MinHeight = Decimal.ToInt32(seMinHeight.Number)
			DemoHtmlEditor.SettingsResize.MaxHeight = Decimal.ToInt32(seMaxHeight.Number)
		End If
	End Sub
End Class

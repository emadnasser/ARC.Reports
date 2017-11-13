Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web.ASPxHtmlEditor

Partial Public Class Features_HtmlHighlighting
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			HtmlEditorUtils.SetHtml(Me, DemoHtmlEditor, "Features/General.html")
			DemoHtmlEditor.Toolbars.Add(HtmlEditorToolbar.CreateStandardToolbar1())
			DemoHtmlEditor.Toolbars.Add(HtmlEditorToolbar.CreateStandardToolbar2())
			DemoHtmlEditor.Toolbars(1).Items.RemoveAll(Function(item) item.GetType() Is GetType(ToolbarBackColorButton))
		End If
		DemoHtmlEditor.Settings.SettingsHtmlView.EnableTagAutoClosing = cbEnableTagAutoClosing.Checked
		DemoHtmlEditor.Settings.SettingsHtmlView.EnableAutoCompletion = cbEnableAutoCompletion.Checked
		DemoHtmlEditor.Settings.SettingsHtmlView.HighlightActiveLine = cbHighlightActiveLine.Checked
		DemoHtmlEditor.Settings.SettingsHtmlView.HighlightMatchingTags = cbHighlightMatchingTags.Checked
		DemoHtmlEditor.Settings.SettingsHtmlView.ShowLineNumbers = cbShowLineNumbers.Checked
		DemoHtmlEditor.Settings.SettingsHtmlView.ShowCollapseTagButtons = cbShowCollapseTagButtons.Checked
		DemoHtmlEditor.Settings.SettingsHtmlView.Mode = CType(CInt(Fix(cbHtmlEditingMode.Value)), HtmlEditorHtmlEditingMode)
	End Sub
End Class

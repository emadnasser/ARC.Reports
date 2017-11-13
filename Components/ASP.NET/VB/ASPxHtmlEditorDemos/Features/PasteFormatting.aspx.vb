Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web.ASPxHtmlEditor

Partial Public Class Features_PasteFormatting
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			HtmlEditorUtils.SetHtml(Me, DemoHtmlEditor, "Features/PasteFormatting.html")
			cbEnablePasteOptions.Checked = DemoHtmlEditor.SettingsHtmlEditing.EnablePasteOptions
			cbPasteMode.Value = CInt(Fix(DemoHtmlEditor.SettingsHtmlEditing.PasteMode))
		Else
			DemoHtmlEditor.SettingsHtmlEditing.EnablePasteOptions = cbEnablePasteOptions.Checked
			DemoHtmlEditor.SettingsHtmlEditing.PasteMode = CType(CInt(Fix(cbPasteMode.Value)), HtmlEditorPasteMode)
		End If
	End Sub
End Class

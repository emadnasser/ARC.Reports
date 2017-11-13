Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class Features_MediaSelector
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			HtmlEditorUtils.SetHtml(Me, DemoHtmlEditor, "Dialogs/MediaSelector.html")
			SetEditorsState()
		End If
	End Sub
	Protected Sub SetEditorsState()
		cbAllowHTML5MediaElements.Checked = DemoHtmlEditor.SettingsHtmlEditing.AllowHTML5MediaElements
		cbAllowObjectAndEmbedElements.Checked = DemoHtmlEditor.SettingsHtmlEditing.AllowObjectAndEmbedElements
		cbAllowYouTubeVideoIFrames.Checked = DemoHtmlEditor.SettingsHtmlEditing.AllowYouTubeVideoIFrames
	End Sub
	Protected Sub cbAllowHTML5MediaElements_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
		DemoHtmlEditor.SettingsHtmlEditing.AllowHTML5MediaElements = (CType(sender, ASPxCheckBox)).Checked
	End Sub
	Protected Sub cbAllowObjectAndEmbedElements_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
		DemoHtmlEditor.SettingsHtmlEditing.AllowObjectAndEmbedElements = (CType(sender, ASPxCheckBox)).Checked
	End Sub
	Protected Sub cbAllowYouTubeVideoIFrames_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
		DemoHtmlEditor.SettingsHtmlEditing.AllowYouTubeVideoIFrames = (CType(sender, ASPxCheckBox)).Checked
	End Sub
End Class

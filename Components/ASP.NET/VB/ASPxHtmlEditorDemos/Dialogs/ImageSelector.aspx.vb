Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web

Partial Public Class Dialogs_ImageSelector
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			HtmlEditorUtils.SetHtml(Me, DemoHtmlEditor, "Dialogs/ImageSelector.html")
			SetEditorsState()
		End If
	End Sub

	Protected Sub cbEnableEditing_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
		Dim editingEnabled As Boolean = (CType(sender, ASPxCheckBox)).Checked
		DemoHtmlEditor.SettingsDialogs.InsertImageDialog.SettingsImageSelector.EditingSettings.AllowMove = editingEnabled
		DemoHtmlEditor.SettingsDialogs.InsertImageDialog.SettingsImageSelector.EditingSettings.AllowDelete = editingEnabled
		DemoHtmlEditor.SettingsDialogs.InsertImageDialog.SettingsImageSelector.EditingSettings.AllowRename = editingEnabled
		DemoHtmlEditor.SettingsDialogs.InsertImageDialog.SettingsImageSelector.EditingSettings.AllowCreate = editingEnabled
	End Sub
	Protected Sub cbEnableUpload_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
		Dim uploadEnabled As Boolean = (CType(sender, ASPxCheckBox)).Checked
		DemoHtmlEditor.SettingsDialogs.InsertImageDialog.SettingsImageSelector.UploadSettings.Enabled = uploadEnabled
		DemoHtmlEditor.SettingsDialogs.InsertImageDialog.SettingsImageSelector.FoldersSettings.ShowLockedFolderIcons = uploadEnabled
	End Sub
	Protected Sub cbMoreOptions_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
		DemoHtmlEditor.SettingsDialogs.InsertImageDialog.ShowMoreOptionsButton = (CType(sender, ASPxCheckBox)).Checked
	End Sub
	Protected Sub cbShowToolbar_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
		DemoHtmlEditor.SettingsDialogs.InsertImageDialog.SettingsImageSelector.ToolbarSettings.Visible = (CType(sender, ASPxCheckBox)).Checked
	End Sub
	Protected Sub cbShowFoldersArea_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
		DemoHtmlEditor.SettingsDialogs.InsertImageDialog.SettingsImageSelector.FoldersSettings.Visible = (CType(sender, ASPxCheckBox)).Checked
	End Sub
	Protected Sub cbFileListView_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
		Dim value As Object = (CType(sender, ASPxComboBox)).Value
		DemoHtmlEditor.SettingsDialogs.InsertImageDialog.SettingsImageSelector.FileListSettings.View = CType(CInt(Fix(value)), FileListView)
	End Sub
	Protected Sub cbShowBreadcrumbs_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
		DemoHtmlEditor.SettingsDialogs.InsertImageDialog.SettingsImageSelector.BreadcrumbsSettings.Visible = (CType(sender, ASPxCheckBox)).Checked
	End Sub

	Protected Sub SetEditorsState()
		cbEnableEditing.Checked = DemoHtmlEditor.SettingsDialogs.InsertImageDialog.SettingsImageSelector.EditingSettings.AllowMove
		cbEnableUpload.Checked = DemoHtmlEditor.SettingsDialogs.InsertImageDialog.SettingsImageSelector.UploadSettings.Enabled
		cbMoreOptions.Checked = DemoHtmlEditor.SettingsDialogs.InsertImageDialog.ShowMoreOptionsButton
		cbShowToolbar.Checked = DemoHtmlEditor.SettingsDialogs.InsertImageDialog.SettingsImageSelector.ToolbarSettings.Visible
		cbShowFoldersArea.Checked = DemoHtmlEditor.SettingsDialogs.InsertImageDialog.SettingsImageSelector.FoldersSettings.Visible
		cbFileListView.Value = CInt(Fix(DemoHtmlEditor.SettingsDialogs.InsertImageDialog.SettingsImageSelector.FileListSettings.View))
		cbShowBreadcrumbs.Checked = DemoHtmlEditor.SettingsDialogs.InsertImageDialog.SettingsImageSelector.BreadcrumbsSettings.Visible
	End Sub

	Protected Sub DemoHtmlEditor_ImageSelectorFileUploading(ByVal source As Object, ByVal e As FileManagerFileUploadEventArgs)
		ValidateSiteEdit(e)
	End Sub
	Protected Sub DemoHtmlEditor_ImageSelectorItemRenaming(ByVal source As Object, ByVal e As FileManagerItemRenameEventArgs)
		ValidateSiteEdit(e)
	End Sub
	Protected Sub DemoHtmlEditor_ImageSelectorItemMoving(ByVal source As Object, ByVal e As FileManagerItemMoveEventArgs)
		ValidateSiteEdit(e)
	End Sub
	Protected Sub DemoHtmlEditor_ImageSelectorItemDeleting(ByVal source As Object, ByVal e As FileManagerItemDeleteEventArgs)
		ValidateSiteEdit(e)
	End Sub
	Protected Sub DemoHtmlEditor_ImageSelectorFolderCreating(ByVal source As Object, ByVal e As FileManagerFolderCreateEventArgs)
		ValidateSiteEdit(e)
	End Sub
	Protected Sub ValidateSiteEdit(ByVal e As FileManagerActionEventArgsBase)
		e.Cancel = DevExpress.Web.Demos.Utils.IsSiteMode
		e.ErrorText = DevExpress.Web.Demos.Utils.GetReadOnlyMessageText()
	End Sub
End Class

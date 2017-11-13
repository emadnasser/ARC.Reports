Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web

Partial Public Class Dialogs_DocumentSelector
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			HtmlEditorUtils.SetHtml(Me, DemoHtmlEditor, "Dialogs/DocumentSelector.html")
			SetEditorsState()
		End If
	End Sub

	Protected Sub cbEnableEditing_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
		Dim editingEnabled As Boolean = (CType(sender, ASPxCheckBox)).Checked
		DemoHtmlEditor.SettingsDialogs.InsertLinkDialog.SettingsDocumentSelector.EditingSettings.AllowMove = editingEnabled
		DemoHtmlEditor.SettingsDialogs.InsertLinkDialog.SettingsDocumentSelector.EditingSettings.AllowDelete = editingEnabled
		DemoHtmlEditor.SettingsDialogs.InsertLinkDialog.SettingsDocumentSelector.EditingSettings.AllowRename = editingEnabled
		DemoHtmlEditor.SettingsDialogs.InsertLinkDialog.SettingsDocumentSelector.EditingSettings.AllowCreate = editingEnabled
	End Sub
	Protected Sub cbEnableUpload_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
		Dim uploadEnabled As Boolean = (CType(sender, ASPxCheckBox)).Checked
		DemoHtmlEditor.SettingsDialogs.InsertLinkDialog.SettingsDocumentSelector.UploadSettings.Enabled = uploadEnabled
		DemoHtmlEditor.SettingsDialogs.InsertLinkDialog.SettingsDocumentSelector.FoldersSettings.ShowLockedFolderIcons = uploadEnabled
	End Sub
	Protected Sub cbFileListView_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
		Dim value As Object = (CType(sender, ASPxComboBox)).Value
		DemoHtmlEditor.SettingsDialogs.InsertLinkDialog.SettingsDocumentSelector.FileListSettings.View = CType(CInt(Fix(value)), FileListView)
	End Sub
	Protected Sub cbShowToolbar_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
		DemoHtmlEditor.SettingsDialogs.InsertLinkDialog.SettingsDocumentSelector.ToolbarSettings.Visible = (CType(sender, ASPxCheckBox)).Checked
	End Sub
	Protected Sub cbShowBreadcrumbs_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
		DemoHtmlEditor.SettingsDialogs.InsertLinkDialog.SettingsDocumentSelector.BreadcrumbsSettings.Visible = (CType(sender, ASPxCheckBox)).Checked
	End Sub

	Protected Sub cbShowOpenInNewWindowButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
		DemoHtmlEditor.SettingsDialogs.InsertLinkDialog.ShowOpenInNewWindowButton = (CType(sender, ASPxCheckBox)).Checked
	End Sub
	Protected Sub cbShowEmailAddressSection_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
		DemoHtmlEditor.SettingsDialogs.InsertLinkDialog.ShowEmailAddressSection = (CType(sender, ASPxCheckBox)).Checked
	End Sub

	Protected Sub SetEditorsState()
		cbEnableEditing.Checked = DemoHtmlEditor.SettingsDialogs.InsertLinkDialog.SettingsDocumentSelector.EditingSettings.AllowMove
		cbEnableUpload.Checked = DemoHtmlEditor.SettingsDialogs.InsertLinkDialog.SettingsDocumentSelector.UploadSettings.Enabled
		cbShowToolbar.Checked = DemoHtmlEditor.SettingsDialogs.InsertLinkDialog.SettingsDocumentSelector.ToolbarSettings.Visible
		cbShowBreadcrumbs.Checked = DemoHtmlEditor.SettingsDialogs.InsertLinkDialog.SettingsDocumentSelector.BreadcrumbsSettings.Visible
		cbFileListView.Value = CInt(Fix(DemoHtmlEditor.SettingsDialogs.InsertLinkDialog.SettingsDocumentSelector.FileListSettings.View))
		cbShowOpenInNewWindowButton.Checked = DemoHtmlEditor.SettingsDialogs.InsertLinkDialog.ShowOpenInNewWindowButton
		cbShowEmailAddressSection.Checked = DemoHtmlEditor.SettingsDialogs.InsertLinkDialog.ShowEmailAddressSection
	End Sub

	Protected Sub DemoHtmlEditor_DocumentSelectorFileUploading(ByVal source As Object, ByVal e As FileManagerFileUploadEventArgs)
		ValidateSiteEdit(e)
	End Sub
	Protected Sub DemoHtmlEditor_DocumentSelectorItemRenaming(ByVal source As Object, ByVal e As FileManagerItemRenameEventArgs)
		ValidateSiteEdit(e)
	End Sub
	Protected Sub DemoHtmlEditor_DocumentSelectorItemMoving(ByVal source As Object, ByVal e As FileManagerItemMoveEventArgs)
		ValidateSiteEdit(e)
	End Sub
	Protected Sub DemoHtmlEditor_DocumentSelectorItemDeleting(ByVal source As Object, ByVal e As FileManagerItemDeleteEventArgs)
		ValidateSiteEdit(e)
	End Sub
	Protected Sub DemoHtmlEditor_DocumentSelectorFolderCreating(ByVal source As Object, ByVal e As FileManagerFolderCreateEventArgs)
		ValidateSiteEdit(e)
	End Sub
	Protected Sub ValidateSiteEdit(ByVal e As FileManagerActionEventArgsBase)
		e.Cancel = DevExpress.Web.Demos.Utils.IsSiteMode
		e.ErrorText = DevExpress.Web.Demos.Utils.GetReadOnlyMessageText()
	End Sub
End Class

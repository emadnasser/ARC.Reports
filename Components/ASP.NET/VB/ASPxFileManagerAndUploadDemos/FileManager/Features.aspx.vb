Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web
Imports DevExpress.Web.Demos

Partial Public Class FileManager_Features
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			SetEditorsInitialState()
			UpdateLinkedProperties()
		Else
			ApplyFileManagerSettings()
			UpdateLinkedProperties()
		End If
	End Sub

	Protected Sub fileManager_FileUploading(ByVal sender As Object, ByVal e As FileManagerFileUploadEventArgs)
		ValidateSiteEdit(e)
	End Sub

	Protected Sub fileManager_ItemRenaming(ByVal sender As Object, ByVal e As FileManagerItemRenameEventArgs)
		ValidateSiteEdit(e)
	End Sub

	Protected Sub fileManager_ItemMoving(ByVal sender As Object, ByVal e As FileManagerItemMoveEventArgs)
		ValidateSiteEdit(e)
	End Sub

	Protected Sub fileManager_ItemDeleting(ByVal sender As Object, ByVal e As FileManagerItemDeleteEventArgs)
		ValidateSiteEdit(e)
	End Sub

	Protected Sub fileManager_FolderCreating(ByVal sender As Object, ByVal e As FileManagerFolderCreateEventArgs)
		ValidateSiteEdit(e)
	End Sub

	Protected Sub fileManager_ItemCopying(ByVal sender As Object, ByVal e As FileManagerItemCopyEventArgs)
		ValidateSiteEdit(e)
	End Sub

	Private Sub ApplyFileManagerSettings()
		fileManager.SettingsEditing.AllowMove = cbAllowMove.Checked
		fileManager.SettingsEditing.AllowDelete = cbAllowDelete.Checked
		fileManager.SettingsEditing.AllowRename = cbAllowRename.Checked
		fileManager.SettingsEditing.AllowCreate = cbAllowCreate.Checked
		fileManager.SettingsEditing.AllowCopy = cbAllowCopy.Checked
		fileManager.SettingsEditing.AllowDownload = cbAllowDownload.Checked
		fileManager.SettingsToolbar.ShowPath = cbShowPath.Checked
		fileManager.SettingsToolbar.ShowFilterBox = cbShowFilterBox.Checked
		fileManager.SettingsFolders.ShowLockedFolderIcons = cbShowLockedFolderIcons.Checked
		fileManager.SettingsFolders.ShowFolderIcons = cbShowFolderIcons.Checked
		fileManager.SettingsFolders.EnableCallBacks = cbFoldersEnableCallBacks.Checked
		fileManager.SettingsFolders.Visible = cbFoldersVisible.Checked
		fileManager.SettingsUpload.Enabled = cbUploadEnabled.Checked
		fileManager.SettingsFileList.ShowFolders = cbFileListShowFolders.Checked
		fileManager.SettingsFileList.ShowParentFolder = cbFileListShowParentFolder.Checked
		fileManager.SettingsBreadcrumbs.Visible = cbBreadcrumbsVisible.Checked
		fileManager.SettingsBreadcrumbs.ShowParentFolderButton = cbBreadcrumbsShowParentFolderButton.Checked
		fileManager.SettingsBreadcrumbs.Position = CType(System.Enum.Parse(GetType(BreadcrumbsPosition), cmbBreadcrumbsPosition.SelectedItem.Value.ToString()), BreadcrumbsPosition)

		fileManager.SettingsUpload.UseAdvancedUploadMode = cbUploadMultiSelect.Checked
		fileManager.SettingsUpload.AdvancedModeSettings.EnableMultiSelect = cbUploadMultiSelect.Checked
	End Sub

	Private Sub UpdateLinkedProperties()
		cbAllowCreate.Enabled = fileManager.SettingsFolders.Visible OrElse fileManager.SettingsFileList.ShowFolders
		cbAllowMove.Enabled = fileManager.SettingsFolders.Visible OrElse fileManager.SettingsFileList.ShowFolders
	End Sub

	Private Sub SetEditorsInitialState()
		cbAllowCreate.Checked = fileManager.SettingsEditing.AllowCreate
		cbAllowDelete.Checked = fileManager.SettingsEditing.AllowDelete
		cbAllowMove.Checked = fileManager.SettingsEditing.AllowMove
		cbAllowRename.Checked = fileManager.SettingsEditing.AllowRename
		cbAllowCopy.Checked = fileManager.SettingsEditing.AllowCopy
		cbAllowDownload.Checked = fileManager.SettingsEditing.AllowDownload

		cbShowPath.Checked = fileManager.SettingsToolbar.ShowPath
		cbShowFilterBox.Checked = fileManager.SettingsToolbar.ShowFilterBox
		cbShowLockedFolderIcons.Checked = fileManager.SettingsFolders.ShowLockedFolderIcons
		cbShowFolderIcons.Checked = fileManager.SettingsFolders.ShowFolderIcons
		cbFoldersEnableCallBacks.Checked = fileManager.SettingsFolders.EnableCallBacks
		cbFoldersVisible.Checked = fileManager.SettingsFolders.Visible
		cbUploadEnabled.Checked = fileManager.SettingsUpload.Enabled
		cbUploadMultiSelect.Checked = fileManager.SettingsUpload.UseAdvancedUploadMode AndAlso fileManager.SettingsUpload.AdvancedModeSettings.EnableMultiSelect
		cbBreadcrumbsVisible.Checked = fileManager.SettingsBreadcrumbs.Visible
		cbBreadcrumbsShowParentFolderButton.Checked = fileManager.SettingsBreadcrumbs.ShowParentFolderButton
		cbFileListShowFolders.Checked = fileManager.SettingsFileList.ShowFolders
		cbFileListShowParentFolder.Checked = fileManager.SettingsFileList.ShowParentFolder
	End Sub

	Private Sub ValidateSiteEdit(ByVal e As FileManagerActionEventArgsBase)
		e.Cancel = Utils.IsSiteMode
		e.ErrorText = Utils.GetReadOnlyMessageText()
	End Sub

End Class

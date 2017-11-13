Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web
Imports DevExpress.Web.Demos

Partial Public Class FileManager_VirtualScrolling
	Inherits System.Web.UI.Page
	Protected Sub Page_PreInit(ByVal sender As Object, ByVal e As EventArgs)
		FileManagmentUtils.EnsureDemoFilesCreated()
	End Sub

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If IsPostBack Then
			ApplyFileManagerSettings()
		End If
	End Sub

	Protected Sub FileManager_FileUploading(ByVal sender As Object, ByVal e As FileManagerFileUploadEventArgs)
		ValidateSiteEdit(e)
	End Sub

	Protected Sub FileManager_ItemRenaming(ByVal sender As Object, ByVal e As FileManagerItemRenameEventArgs)
		ValidateSiteEdit(e)
	End Sub

	Protected Sub FileManager_ItemMoving(ByVal sender As Object, ByVal e As FileManagerItemMoveEventArgs)
		ValidateSiteEdit(e)
	End Sub

	Protected Sub FileManager_ItemDeleting(ByVal sender As Object, ByVal e As FileManagerItemDeleteEventArgs)
		ValidateSiteEdit(e)
	End Sub

	Protected Sub FileManager_FolderCreating(ByVal sender As Object, ByVal e As FileManagerFolderCreateEventArgs)
		ValidateSiteEdit(e)
	End Sub

	Protected Sub FileManager_ItemCopying(ByVal sender As Object, ByVal e As FileManagerItemCopyEventArgs)
		ValidateSiteEdit(e)
	End Sub

	Private Sub ValidateSiteEdit(ByVal e As FileManagerActionEventArgsBase)
		e.Cancel = Utils.IsSiteMode
		e.ErrorText = Utils.GetReadOnlyMessageText()
	End Sub

	Private Sub ApplyFileManagerSettings()
		FileManager.SettingsFileList.PageSize = Integer.Parse(PageSizeComboBox.SelectedItem.Value.ToString())
		FileManager.SettingsFileList.View = CType(System.Enum.Parse(GetType(FileListView), ViewModeComboBox.SelectedItem.Value.ToString()), FileListView)
	End Sub
End Class

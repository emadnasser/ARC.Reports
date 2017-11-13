Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web
Imports DevExpress.Web.Demos

Partial Public Class FileManager_AccessControl
	Inherits Page
	Public Sub fileManager_CustomThumbnail(ByVal sender As Object, ByVal e As FileManagerThumbnailCreateEventArgs)
		If (CType(e.Item, FileManagerFile)).Extension = ".xml" Then
			e.ThumbnailImage.Url = "Images/code.png"
		End If
	End Sub
	Protected Sub rblRole_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
		FileManager.SettingsPermissions.Role = CStr(rblRole.Value)
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
	Private Sub ValidateSiteEdit(ByVal e As FileManagerActionEventArgsBase)
		e.Cancel = Utils.IsSiteMode
		e.ErrorText = Utils.GetReadOnlyMessageText()
	End Sub
End Class

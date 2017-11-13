Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.Linq
Imports System.Web
Imports System.Web.Configuration
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web
Imports DevExpress.Web.Demos

Partial Public Class FileManager_DropboxProvider
	Inherits System.Web.UI.Page
	Private ReadOnly Property IsDropboxAccessTokenValueDefined() As Boolean
		Get
			Return Not String.IsNullOrEmpty(FileManagmentUtils.GetDropboxAccessTokenValue())
		End Get
	End Property

	Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsDropboxAccessTokenValueDefined) Then
			MainContent.InnerHtml = String.Format("To run the demo locally, register your Dropbox account using the AccountManager.RegisterDropbox() method in the global.asax file. " & "Or you can see this demo online at <a href='{0}'>{0}</a>.", "https://demos.devexpress.com/ASPxFileManagerAndUploadDemos/FileManager/DropboxProvider.aspx")
		End If
	End Sub

	Protected Sub FileManager_OnCloudProviderRequest(ByVal sender As Object, ByVal e As FileManagerCloudProviderRequestEventArgs)
		EventMonitor.TraceEvent(sender, e, FileManager.ProviderType)
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

	Private Sub ValidateSiteEdit(ByVal e As FileManagerActionEventArgsBase)
		e.Cancel = Utils.IsSiteMode
		e.ErrorText = Utils.GetReadOnlyMessageText()
	End Sub
End Class


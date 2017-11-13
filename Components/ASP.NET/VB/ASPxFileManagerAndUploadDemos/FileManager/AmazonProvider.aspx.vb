Imports Microsoft.VisualBasic
Imports System
Imports System.Web.Configuration
Imports System.Web.UI
Imports DevExpress.Web
Imports DevExpress.Web.Demos

Partial Public Class FileManager_AmazonProvider
	Inherits Page
	Private ReadOnly Property IsAmazonAccessKeyIDDefined() As Boolean
		Get
			Return Not String.IsNullOrEmpty(FileManagmentUtils.GetAmazonAccessKeyID())
		End Get
	End Property
	Private ReadOnly Property IsAmazonSecretAccessKeyDefined() As Boolean
		Get
			Return Not String.IsNullOrEmpty(FileManagmentUtils.GetAmazonSecretAccessKey())
		End Get
	End Property

	Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsAmazonAccessKeyIDDefined) OrElse (Not IsAmazonSecretAccessKeyDefined) Then
			MainContent.InnerHtml = String.Format("To run the demo locally, register your Amazon account using the AccountManager.RegisterAmazon() method in the global.asax file " & "and set the SettingsAmazon.BucketName property to your bucket name value. Or you can see this demo online at <a href='{0}'>{0}</a>.", "https://demos.devexpress.com/ASPxFileManagerAndUploadDemos/FileManager/AmazonProvider.aspx")
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



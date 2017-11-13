Imports Microsoft.VisualBasic
Imports System
Imports System.Web.Configuration
Imports System.Web.UI
Imports DevExpress.Web
Imports DevExpress.Web.Demos

Partial Public Class UploadControl_UploadToDropbox
	Inherits System.Web.UI.Page
	Private ReadOnly Property IsDropboxAccessTokenValueDefined() As Boolean
		Get
			Return Not String.IsNullOrEmpty(UploadingUtils.GetDropboxAccessTokenValue())
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsDropboxAccessTokenValueDefined) Then
			MainContainer.InnerHtml = String.Format("To run the demo locally, register your Dropbox account using the AccountManager.RegisterDropbox() method in the global.asax file. " & "Or you can see this demo online at <a href='{0}'>{0}</a>.", "https://demos.devexpress.com/ASPxFileManagerAndUploadDemos/UploadControl/UploadToDropbox.aspx")
		End If
	End Sub

	Protected Sub UploadControl_FileUploadComplete(ByVal sender As Object, ByVal e As FileUploadCompleteEventArgs)
		RemoveFileWithDelay(e.UploadedFile.FileNameInStorage, 5)

		Dim name As String = e.UploadedFile.FileName
		Dim url As String = GetImageUrl(e.UploadedFile.FileNameInStorage)
		Dim sizeInKilobytes As Long = e.UploadedFile.ContentLength / 1024
		Dim sizeText As String = sizeInKilobytes.ToString() & " KB"
		e.CallbackData = name & "|" & url & "|" & sizeText
	End Sub

	Private Function GetImageUrl(ByVal fileName As String) As String
		Dim provider As New DropboxFileSystemProvider("")
		provider.AccountName = UploadControl.DropboxSettings.AccountName
		Dim file As New FileManagerFile(provider, fileName)
		Dim files() As FileManagerFile = { file }
		Return provider.GetDownloadUrl(files)
	End Function

	Private Sub RemoveFileWithDelay(ByVal keyFileName As String, ByVal delay As Integer)
		UploadingUtils.RemoveFileFromDropboxWithDelay(keyFileName, UploadControl.DropboxSettings.AccountName, delay)
	End Sub
End Class

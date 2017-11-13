Imports Microsoft.VisualBasic
Imports System
Imports System.Web.Configuration
Imports System.Web.UI
Imports DevExpress.Web
Imports DevExpress.Web.Demos

Partial Public Class UploadControl_UploadToAmazon
	Inherits Page
	Private ReadOnly Property IsAmazonAccessKeyIDDefined() As Boolean
		Get
			Return Not String.IsNullOrEmpty(UploadingUtils.GetAmazonAccessKeyID())
		End Get
	End Property
	Private ReadOnly Property IsAmazonSecretAccessKeyDefined() As Boolean
		Get
			Return Not String.IsNullOrEmpty(UploadingUtils.GetAmazonSecretAccessKey())
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsAmazonAccessKeyIDDefined) OrElse (Not IsAmazonSecretAccessKeyDefined) Then
			MainContainer.InnerHtml = String.Format("To run the demo locally, register your Amazon account using the AccountManager.RegisterAmazon() method in the global.asax file " & "and set the AmazonSettings.BucketName property to your bucket name value. Or you can see this demo online at <a href='{0}'>{0}</a>.", "https://demos.devexpress.com/ASPxFileManagerAndUploadDemos/UploadControl/UploadToAmazon.aspx")
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
		Dim provider As New AmazonFileSystemProvider("")
		provider.AccountName = UploadControl.AmazonSettings.AccountName
		provider.BucketName = UploadControl.AmazonSettings.BucketName
		provider.Region = UploadControl.AmazonSettings.Region
		Dim file As New FileManagerFile(provider, fileName)
		Dim files() As FileManagerFile = { file }
		Return provider.GetDownloadUrl(files)
	End Function

	Private Sub RemoveFileWithDelay(ByVal keyFileName As String, ByVal delay As Integer)
		Dim settings As UploadControlAmazonSettings = UploadControl.AmazonSettings
		UploadingUtils.RemoveFileFromAmazonWithDelay(keyFileName, settings.AccountName, settings.BucketName, settings.Region, delay)
	End Sub
End Class

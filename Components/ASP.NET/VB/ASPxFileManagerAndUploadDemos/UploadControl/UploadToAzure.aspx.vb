Imports Microsoft.VisualBasic
Imports System
Imports System.Web.Configuration
Imports System.Web.UI
Imports DevExpress.Web
Imports DevExpress.Web.Demos

Partial Public Class UploadControl_UploadToAzure
	Inherits Page
	Private ReadOnly Property IsAzureAccessKeyDefined() As Boolean
		Get
			Return Not String.IsNullOrEmpty(UploadingUtils.GetAzureAccessKey())
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsAzureAccessKeyDefined) Then
			MainContainer.InnerHtml = String.Format("To run the demo locally, register your Azure account using the AccountManager.RegisterAzure() method in the global.asax file " & "and set the AzureSettings.ContainerName property to your container name value. Or you can see this demo online at <a href='{0}'>{0}</a>.", "https://demos.devexpress.com/ASPxFileManagerAndUploadDemos/UploadControl/UploadToAzure.aspx")
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
		Dim provider As New AzureFileSystemProvider("")
		provider.AccountName = UploadControl.AzureSettings.AccountName
		provider.ContainerName = UploadControl.AzureSettings.ContainerName
		Dim file As New FileManagerFile(provider, fileName)
		Dim files() As FileManagerFile = { file }
		Return provider.GetDownloadUrl(files)
	End Function

	Private Sub RemoveFileWithDelay(ByVal keyFileName As String, ByVal delay As Integer)
		UploadingUtils.RemoveFileFromAzureWithDelay(keyFileName, UploadControl.AzureSettings.AccountName, UploadControl.AzureSettings.ContainerName, delay)
	End Sub
End Class

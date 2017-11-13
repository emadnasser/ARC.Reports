Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Threading
Imports DevExpress.Web
Imports DevExpress.Web.ASPxHtmlEditor
Imports DevExpress.Web.Demos

Partial Public Class Features_BinaryImageAutoUpload
	Inherits System.Web.UI.Page

	Public ReadOnly Property IsAzureAccessKeyNotDefined() As Boolean
		Get
			Return String.IsNullOrEmpty(UploadingUtils.GetAzureAccessKey())
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		DemoFormLayout.Visible = Not IsAzureAccessKeyNotDefined
		WarningDiv.Visible = IsAzureAccessKeyNotDefined

		DemoHtmlEditor.Settings.AllowSaveBinaryImageToServer = AllowSaveBinaryImageToServerCb.Checked
		If (Not IsPostBack) Then
			HtmlEditorUtils.SetHtml(Me, DemoHtmlEditor, "Features/BinaryImageAutoUploadContent.html")
		End If
	End Sub
	Protected Sub DemoHtmlEditor_ImageFileSaving(ByVal source As Object, ByVal e As FileSavingEventArgs)
		Using fileContent As Stream = e.UploadedFile.FileContent
			Dim imageFormat As ImageFormat = Nothing
			Using image As Image = GetImageToSave(fileContent, imageFormat)
				Dim memoryStream As New MemoryStream()
				image.Save(memoryStream, imageFormat)
				e.OutputStream = memoryStream
				e.FileName = String.Format("{0}_{1}{2}", Path.GetFileNameWithoutExtension(e.FileName), Guid.NewGuid(), Path.GetExtension(e.FileName))
				RemoveFileWithDelay(e.FileName, 5)
			End Using
		End Using
		Thread.Sleep(2000)
	End Sub

	Private Sub RemoveFileWithDelay(ByVal fileName As String, ByVal delayInMinutes As Integer)
		Dim azureSettings As UploadControlAzureSettings = DemoHtmlEditor.SettingsDialogs.InsertImageDialog.SettingsImageUpload.AzureSettings
		UploadingUtils.RemoveFileFromAzureWithDelay(fileName, azureSettings.AccountName, azureSettings.ContainerName, 1)
	End Sub
	Private Function GetImageToSave(ByVal stream As Stream, <System.Runtime.InteropServices.Out()> ByRef originalFormat As ImageFormat) As Image
		Dim uploadedImage As Image = Image.FromStream(stream)
		originalFormat = uploadedImage.RawFormat
		If uploadedImage.Height < CInt(Fix(MaxHeightSpinEdit.Number)) AndAlso uploadedImage.Width < CInt(Fix(MaxWidthSpinEdit.Number)) Then
			Return uploadedImage
		End If
		Using uploadedImage
			Return PhotoUtils.GetReducedImage(uploadedImage, CInt(Fix(MaxWidthSpinEdit.Number)), CInt(Fix(MaxHeightSpinEdit.Number)))
		End Using
	End Function
End Class

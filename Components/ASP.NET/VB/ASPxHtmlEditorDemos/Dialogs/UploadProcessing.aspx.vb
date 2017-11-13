Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Web.UI
Imports DevExpress.Web
Imports DevExpress.Web.Demos

Partial Public Class Dialogs_UploadProcessing
	Inherits Page

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			HtmlEditorUtils.SetHtml(Me, DemoHtmlEditor, "Dialogs/UploadProcessing.html")
		End If
	End Sub

	Protected Sub DemoHtmlEditor_ImageFileSaving(ByVal source As Object, ByVal e As FileSavingEventArgs)
		Using fileContent As Stream = e.UploadedFile.FileContent
			Dim imageFormat As ImageFormat = Nothing
			Using image As Image = GetImageToSave(fileContent, imageFormat)
				If (Not String.IsNullOrEmpty(WatermarkTextBox.Text)) Then
					PhotoUtils.DrawWatermarkText(image, WatermarkTextBox.Text)
				End If
				Dim memoryStream As New MemoryStream()
				image.Save(memoryStream, imageFormat)

				e.OutputStream = memoryStream
				If (Not String.IsNullOrEmpty(FileNamePrefixTextBox.Text)) Then
					e.FileName = String.Format("{0}_{1}", FileNamePrefixTextBox.Text, e.FileName)
				End If
			End Using
		End Using
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

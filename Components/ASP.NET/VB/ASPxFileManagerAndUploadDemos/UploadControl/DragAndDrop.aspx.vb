Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.IO
Imports DevExpress.Web
Imports DevExpress.Web.Demos
Imports DevExpress.Web.Internal

Partial Public Class UploadControl_DragAndDrop
	Inherits System.Web.UI.Page
	Private Const UploadDirectory As String = "~/UploadControl/UploadImages/"

	Protected Sub UploadControl_FileUploadComplete(ByVal sender As Object, ByVal e As FileUploadCompleteEventArgs)
		e.CallbackData = SavePostedFile(e.UploadedFile)
	End Sub
	Protected Function SavePostedFile(ByVal uploadedFile As UploadedFile) As String
		If (Not uploadedFile.IsValid) Then
			Return String.Empty
		End If
		Dim fileName As String = Path.ChangeExtension(Path.GetRandomFileName(), ".jpg")
		Dim fullFileName As String = CombinePath(fileName)
		Using original As Image = Image.FromStream(uploadedFile.FileContent)
		Using thumbnail As Image = New ImageThumbnailCreator(original).CreateImageThumbnail(New Size(350, 350))
			ImageUtils.SaveToJpeg(CType(thumbnail, Bitmap), fullFileName)
		End Using
		End Using
		UploadingUtils.RemoveFileWithDelay(fileName, fullFileName, 5)
		Return fileName
	End Function
	Protected Function CombinePath(ByVal fileName As String) As String
		Return Path.Combine(Server.MapPath(UploadDirectory), fileName)
	End Function
End Class

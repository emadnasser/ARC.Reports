Imports Microsoft.VisualBasic
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class UploadControl_CustomProgressPanel
	Inherits Page
	Protected Sub UploadControl_FilesUploadComplete(ByVal sender As Object, ByVal e As FilesUploadCompleteEventArgs)
		For Each file As UploadedFile In UploadControl.UploadedFiles
			If (Not String.IsNullOrEmpty(file.FileName)) AndAlso file.IsValid Then
				e.CallbackData = "success"
			End If
		Next file
	End Sub
End Class

Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web
Imports DevExpress.Web.Demos
Imports DevExpress.Compression
Imports System.IO
Imports System.Net

Partial Public Class Compression_Compress
	Inherits System.Web.UI.Page
	Private Const UploadDirectory As String = "~/UploadData/"
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
	End Sub
	Protected Sub UploadControl_FileUploadComplete(ByVal sender As Object, ByVal e As FileUploadCompleteEventArgs)
		Dim resultFilePath As String = GetResultFilePath(e.UploadedFile.FileName)
		e.UploadedFile.SaveAs(MapPath(resultFilePath))
		UploadingUtils.RemoveFileWithDelay(e.UploadedFile.FileName, MapPath(resultFilePath), 5)
		Dim file As String = String.Format("{0} ({1}KB)", e.UploadedFile.FileName, e.UploadedFile.ContentLength / 1024)
		Dim url As String = ResolveClientUrl(resultFilePath)
		e.CallbackData = file & "|" & url
	End Sub
	Protected Sub UploadControl_FilesUploadComplete(ByVal sender As Object, ByVal e As DevExpress.Web.FilesUploadCompleteEventArgs)
		Dim filesToCompress As New List(Of UploadFileInfo)()
		Dim uploadControl As ASPxUploadControl = TryCast(sender, ASPxUploadControl)
		If uploadControl.UploadedFiles IsNot Nothing AndAlso uploadControl.UploadedFiles.Length > 0 Then
			For i As Integer = 0 To uploadControl.UploadedFiles.Length - 1
				Dim file As UploadedFile = uploadControl.UploadedFiles(i)
				If file.FileName <> "" Then
					Dim resultFilePath As String = GetResultFilePath(file.FileName)
					filesToCompress.Add(New UploadFileInfo(file.FileName, MapPath(resultFilePath)))
				End If
			Next i
		End If
		If filesToCompress.Count <= 0 Then
			Return
		End If
		Session("FilesToCompress") = filesToCompress
	End Sub
	Private Function GetResultFilePath(ByVal fileName As String) As String
		Return UploadDirectory & fileName
	End Function
	Protected Sub OnBtnCompressClick(ByVal sender As Object, ByVal e As EventArgs)
		If Session("FilesToCompress") Is Nothing Then
			Return
		End If
		Dim files As List(Of UploadFileInfo) = TryCast(Session("FilesToCompress"), List(Of UploadFileInfo))
		If files Is Nothing Then
			Return
		End If
		Dim archive As New ZipArchive()
		For Each uploadFile As UploadFileInfo In files
			archive.AddFile(uploadFile.Path, "/")
		Next uploadFile
		Using stream As Stream = New MemoryStream()
			archive.Save(stream)
			stream.Seek(0, SeekOrigin.Begin)
			Dim outputStream As Stream = Response.OutputStream
			stream.CopyTo(outputStream)
		End Using
		Response.StatusCode = CInt(Fix(HttpStatusCode.OK))
		Response.ContentType = "application/x-compress"
		Response.AddHeader("Content-Disposition", "attachment; filename=DocumentServerCompressionDemo.zip")
		Response.End()
	End Sub
End Class
Friend Class UploadFileInfo
	Public Sub New(ByVal name As String, ByVal path As String)
		Name = name
		Path = path
	End Sub
	Public Property Name() As String
	Public Property Path() As String
End Class

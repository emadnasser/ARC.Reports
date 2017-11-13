Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Collections.Generic
Imports System.Web.SessionState
Imports System.Web.UI
Imports DevExpress.Pdf
Imports DevExpress.Web
Imports DevExpress.Web.Demos

Partial Public Class PdfPageMerging
	Inherits Page
	Private Class UploadFileInfo
		Private ReadOnly fName As String
		Private ReadOnly fPath As String

		Public ReadOnly Property Name() As String
			Get
				Return fName
			End Get
		End Property
		Public ReadOnly Property Path() As String
			Get
				Return fPath
			End Get
		End Property

		Public Sub New(ByVal name As String, ByVal path As String)
			fName = name
			fPath = path
		End Sub
	End Class

	Private Const uploadDirectory As String = "~/UploadData/"
	Private Const filesToMergeKey As String = "FilesToMerge"
	Private Const mergedFileKey As String = "MergedFile"
	Private Const errorKey As String = "cpError"

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim filesList As New List(Of String)()
		Dim fileInfo As List(Of UploadFileInfo) = TryCast(Session(filesToMergeKey), List(Of UploadFileInfo))
		If fileInfo IsNot Nothing Then
			For Each file As UploadFileInfo In fileInfo
				filesList.Add(file.Name & "|" & ResolveClientUrl(file.Path))
			Next file
		End If
		ASPxUploadControl.JSProperties("cpFilesList") = filesList
	End Sub
	Protected Sub UploadControl_FileUploadComplete(ByVal sender As Object, ByVal e As FileUploadCompleteEventArgs)
		Dim uploadedFile As UploadedFile = e.UploadedFile
		Dim uploadedFileName As String = uploadedFile.FileName
		Dim uploadedFilePath As String = uploadDirectory & uploadedFileName
		Dim actualUploadedFilePath As String = MapPath(uploadedFilePath)
		uploadedFile.SaveAs(actualUploadedFilePath)
		UploadingUtils.RemoveFileWithDelay(uploadedFileName, actualUploadedFilePath, 5)
		e.CallbackData = String.Format("{0} ({1}KB)", uploadedFileName, uploadedFile.ContentLength / 1024) & "|" & ResolveClientUrl(uploadedFilePath)
	End Sub
	Protected Sub UploadControl_FilesUploadComplete(ByVal sender As Object, ByVal e As FilesUploadCompleteEventArgs)
		Dim uploadControl As ASPxUploadControl = ASPxUploadControl
		Try
			Dim fileInfo As New List(Of UploadFileInfo)()
			Dim uploadedFiles() As UploadedFile = uploadControl.UploadedFiles
			If uploadedFiles IsNot Nothing Then
				For Each file As UploadedFile In uploadedFiles
					Dim fileName As String = file.FileName
					If (Not String.IsNullOrEmpty(fileName)) Then
						fileInfo.Add(New UploadFileInfo(fileName, MapPath(uploadDirectory & fileName)))
					End If
				Next file
			End If
			Dim session As HttpSessionState = Me.Session
			session(filesToMergeKey) = fileInfo
			If fileInfo.Count > 0 Then
				Dim stream As New MemoryStream()
				Using documentProcessor As New PdfDocumentProcessor()
					documentProcessor.CreateEmptyDocument(stream)
					For Each uploadFile As UploadFileInfo In fileInfo
						documentProcessor.AppendDocument(uploadFile.Path)
					Next uploadFile
				End Using
				stream.Position = 0
				session(mergedFileKey) = stream
			Else
				session(mergedFileKey) = Nothing
			End If
			uploadControl.JSProperties(errorKey) = False
		Catch
			uploadControl.JSProperties(errorKey) = True
		End Try
	End Sub
	Protected Sub OnMergeButtonClick(ByVal sender As Object, ByVal e As EventArgs)
		Dim stream As Stream = CType(Session(mergedFileKey), Stream)
		If stream IsNot Nothing Then
			Using documentProcessor As New PdfDocumentProcessor()
				documentProcessor.LoadDocument(stream)
				PdfDocumentReponse.SendDocument(Response, documentProcessor, "PDF Document Processor - Page Mering", "PDF Page Merging")
			End Using
		End If
	End Sub
End Class

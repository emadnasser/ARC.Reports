Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web
Imports System.IO
Imports DevExpress.XtraRichEdit
Imports System.Net
Imports DevExpress.Office.Services
Imports DevExpress.Web.Office

Partial Public Class RichEdit_Export
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		lblCurrentDocument.Text = GetFileName()
		UpdateDocumentPreview()
	End Sub
	Private Function UpdateDocumentPreview() As Boolean
		Return True
	End Function

	Private Function CreateDocumentServer() As RichEditDocumentServer
		Dim documentServer As New RichEditDocumentServer()
		documentServer.ReplaceService(Of IUriStreamService)(New ASPxOfficeUriStreamService())
		Using documentStream As Stream = GetDocumentStream()
			documentServer.LoadDocument(documentStream, GetDocumentType())
		End Using
		documentServer.Options.Export.Html.EmbedImages = True
		Return documentServer
	End Function
	Protected Sub OnBtnExportClick(ByVal sender As Object, ByVal e As EventArgs)
		Dim documentServer As RichEditDocumentServer = CreateDocumentServer()
		Using stream As New MemoryStream()
			Dim value As Integer = CInt(Fix(cbDownloadType.Value))
			If value = 4 Then
				documentServer.ExportToPdf(stream)
			Else
				Dim format As DocumentFormat = ConvertIndexToFormat(value)
				documentServer.SaveDocument(stream, format)
			End If
			stream.Seek(0, SeekOrigin.Begin)
			stream.CopyTo(Response.OutputStream)
			Response.StatusCode = CInt(Fix(HttpStatusCode.OK))
			Response.ContentType = ConvertIndexToContentType(value)
			Response.AddHeader("Content-Disposition", String.Format("attachment; filename=Export.{0}", ConvertIndexToFileExtension(value)))
			Response.End()
		End Using
	End Sub
	Private Function ConvertIndexToFormat(ByVal value As Integer) As DocumentFormat
		Select Case value
			Case 1
				Return DocumentFormat.Rtf
			Case 2
				Return DocumentFormat.Doc
			Case 3
				Return DocumentFormat.OpenXml
			Case 5
				Return DocumentFormat.PlainText
			Case 6
				Return DocumentFormat.Mht
			Case 7
				Return DocumentFormat.OpenDocument
			Case 8
				Return DocumentFormat.WordML
			Case 9
				Return DocumentFormat.ePub
			Case 10
				Return DocumentFormat.Html
		End Select
		Return DocumentFormat.Undefined
	End Function
	Private Function ConvertIndexToContentType(ByVal value As Integer) As String
		Select Case value
			Case 1
				Return "application/msword"
			Case 2
				Return "application/msword"
			Case 3
				Return "application/msword"
			Case 4
				Return "application/msword"
			Case 5
				Return "text/plain"
			Case 6
				Return "message/rfc822"
			Case 7
				Return "application/msword"
			Case 8
				Return "text/xml"
			Case 9
				Return "application/msword"
			Case 10
				Return "text/html"
		End Select
		Return String.Empty
	End Function
	Private Function ConvertIndexToFileExtension(ByVal value As Integer) As String
		Select Case value
			Case 1
				Return "rtf"
			Case 2
				Return "doc"
			Case 3
				Return "docx"
			Case 4
				Return "pdf"
			Case 5
				Return "txt"
			Case 6
				Return "mht"
			Case 7
				Return "odt"
			Case 8
				Return "xml"
			Case 9
				Return "epub"
			Case 10
				Return "html"
		End Select
		Return String.Empty
	End Function
	Protected Sub ASPxUploadControl1_FileUploadComplete(ByVal sender As Object, ByVal e As FileUploadCompleteEventArgs)
		Dim uploadControl As ASPxUploadControl = CType(sender, ASPxUploadControl)
		Dim uploadedFile As UploadedFile = uploadControl.UploadedFiles(0)
		If (Not IsFileNameCorrect(uploadedFile.FileName)) Then
			e.IsValid = False
			e.ErrorText = "Incorrect file type"
			Return
		End If
		If uploadedFile.IsValid Then
			Session("UploadedFile") = GetBytesFromStream(uploadedFile.FileContent)
			Session("FileName") = uploadedFile.FileName
			e.CallbackData = uploadedFile.FileName
		End If
	End Sub
	Private Function IsFileNameCorrect(ByVal fileName As String) As Boolean
		Dim correctNames() As String = { ".rtf", ".doc", ".docx", ".txt", ".mht", ".odt", ".xml", ".epub", ".html" }
		Dim fileNameLength As Integer = fileName.Length
		For Each ext As String In correctNames
			Dim extLength As Integer = ext.Length
			If fileName.Substring(fileNameLength - extLength, extLength) = ext Then
				Return True
			End If
		Next ext
		Return False
	End Function
	Private Function GetBytesFromStream(ByVal stream As Stream) As Byte()
		stream.Position = 0
		Dim buf(stream.Length - 1) As Byte
		stream.Read(buf, 0, CInt(Fix(stream.Length)))
		Return buf
	End Function
	Private Function GetDocumentStream() As Stream
		If Session("UploadedFile") IsNot Nothing Then
			Dim resultBytes() As Byte = CType(Session("UploadedFile"), Byte())
			Return New MemoryStream(resultBytes)
		End If
		Return Nothing
	End Function
	Private Function GetFileName() As String
		If Session("FileName") IsNot Nothing Then
			Return TryCast(Session("FileName"), String)
		End If
		Return String.Empty
	End Function
	Private Function GetFileExtension() As String
		Dim fileName As String = GetFileName()
		Dim indx As Integer = fileName.IndexOf(".")
		If indx < 0 Then
			Return fileName
		End If
		indx += 1
		Return fileName.Substring(indx, fileName.Length - indx)
	End Function
	Private Function GetDocumentType() As DocumentFormat
		Dim extension As String = GetFileExtension()
		Select Case extension
			Case "rtf"
				Return DocumentFormat.Rtf
			Case "doc"
				Return DocumentFormat.Doc
			Case "docx"
				Return DocumentFormat.OpenXml
			Case "txt"
				Return DocumentFormat.PlainText
			Case "mht"
				Return DocumentFormat.Mht
			Case "odt"
				Return DocumentFormat.OpenDocument
			Case "xml"
				Return DocumentFormat.WordML
			Case "epub"
				Return DocumentFormat.ePub
			Case "html"
				Return DocumentFormat.Html
		End Select
		Return DocumentFormat.OpenXml
	End Function
End Class

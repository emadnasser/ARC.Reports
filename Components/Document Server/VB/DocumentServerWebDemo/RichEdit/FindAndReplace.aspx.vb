Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Net
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Native

Partial Public Class RichEdit_FindAndReplace
	Inherits System.Web.UI.Page
	#Region "Fields"
	Private Const ServerFilePath As String = "~/App_Data/Search.rtf"
	Private docServer As RichEditDocumentServer = Nothing
	#End Region

	Public Sub New()
		MyBase.New()
	End Sub

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If Request.QueryString.Count > 0 AndAlso Request.QueryString(0).StartsWith("preview") Then
			Dim strFind As String = Request.Params("find")
			If String.IsNullOrEmpty(strFind) Then
				strFind = String.Empty
			End If
			Dim strReplace As String = Request.Params("replace")
			If String.IsNullOrEmpty(strReplace) Then
				strReplace = String.Empty
			End If
			Dim strAction As String = Request.Params("action")
			If String.IsNullOrEmpty(strAction) Then
				strAction = String.Empty
			End If
			RefreshPreview(strFind, strReplace, strAction)
		End If
	End Sub
	Protected Sub OnBtnExportClick(ByVal sender As Object, ByVal e As EventArgs)
		Using stream As New MemoryStream()
			docServer = CType(Session("UploadedFile"), RichEditDocumentServer)
			Dim value As Integer = CInt(Fix(cbDownloadType.Value))
			If EnforceDocServer() Then
				If value = 4 Then
					docServer.ExportToPdf(stream)
				Else
					Dim format As DocumentFormat = ConvertIndexToFormat(value)
					docServer.SaveDocument(stream, format)
				End If
				stream.Seek(0, SeekOrigin.Begin)
				stream.CopyTo(Response.OutputStream)
			End If
			Response.StatusCode = CInt(Fix(HttpStatusCode.OK))
			Response.ContentType = ConvertIndexToContentType(value)
			Response.AddHeader("Content-Disposition", String.Format("attachment; filename=Search.{0}", ConvertIndexToFileExtension(value)))
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
		End Select
		Return String.Empty
	End Function
	Private Sub RefreshPreview(ByVal strFind As String, ByVal strReplace As String, ByVal strAction As String)
		Response.StatusCode = CInt(Fix(HttpStatusCode.OK))
		Response.ContentType = "text/html"
		If EnforceDocServer() Then
			Using outputStream As Stream = CreateOutputStream(strFind, strReplace, strAction)
				If outputStream IsNot Nothing Then
					outputStream.Seek(0, SeekOrigin.Begin)
					outputStream.CopyTo(Response.OutputStream)
				End If
			End Using
		End If
		Response.End()
	End Sub
	Private Function CreateOutputStream(ByVal strFind As String, ByVal strReplace As String, ByVal strAction As String) As Stream
		Dim result As Stream = Nothing
		If tbFind Is Nothing Then
			Return Nothing
		End If

		docServer.LoadDocument(Page.MapPath(ServerFilePath))
		Session("UploadedFile") = docServer
		docServer.Options.Export.Html.EmbedImages = True
		result = New MemoryStream()
		Select Case strAction
			Case "replace"
				ReplaceAll(strFind, strReplace)
			Case "find"
				FindAll(strFind)
		End Select
		docServer.SaveDocument(result, DocumentFormat.Html)
		Return result
	End Function
	Private Function EnforceDocServer() As Boolean
		If docServer Is Nothing Then
			docServer = New RichEditDocumentServer()
		End If
		If docServer Is Nothing Then
			Return False
		End If
		Return True
	End Function
	Private Sub ReplaceAll(ByVal strFind As String, ByVal strReplace As String)
		If (Not String.IsNullOrEmpty(strFind)) Then
			Dim ranges() As DocumentRange = docServer.Document.FindAll(strFind, SearchOptions.None, docServer.Document.Range)
			For i As Integer = 0 To ranges.Length - 1
				If strReplace = "null" Then
					strReplace = String.Empty
				End If
				docServer.Document.Replace(ranges(i), strReplace)
				Dim cp As CharacterProperties = docServer.Document.BeginUpdateCharacters(ranges(i))
				cp.BackColor = System.Drawing.Color.FromArgb(180, 201, 233)
				docServer.Document.EndUpdateCharacters(cp)
			Next i
		End If
	End Sub
	Private Sub FindAll(ByVal strFind As String)
		If (Not String.IsNullOrEmpty(strFind)) Then
			Dim ranges() As DocumentRange = docServer.Document.FindAll(strFind, SearchOptions.None, docServer.Document.Range)
			For i As Integer = 0 To ranges.Length - 1
				Dim cp As CharacterProperties = docServer.Document.BeginUpdateCharacters(ranges(i))
				cp.BackColor = System.Drawing.Color.FromArgb(180, 201, 233)
				docServer.Document.EndUpdateCharacters(cp)
			Next i
		End If
	End Sub

End Class

Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web
Imports System.IO
Imports System.Net
Imports DevExpress.Spreadsheet
Imports System.Drawing
Imports DevExpress.Docs.Demos

Partial Public Class SpreadSheet_SpreadsheetCellArt
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If Request.QueryString.Count < 1 Then
			Return
		End If
		If Request.QueryString(0).StartsWith("previewImage") Then
			LoadPreviewImage()
		End If
	End Sub
	Protected Sub OnBtnExportClick(ByVal sender As Object, ByVal e As EventArgs)
		Using stream As New MemoryStream(GetPreviewImageBytes())
			Dim img As System.Drawing.Image = Bitmap.FromStream(stream)
			Dim bmp As Bitmap = TryCast(img, Bitmap)
			If bmp Is Nothing Then
				Return
			End If
			Dim documentGenerator As New CellArtDocumentGenerator(bmp)
			Dim book As IWorkbook = documentGenerator.Generate()
			Dim outputStream As Stream = New MemoryStream()
			book.SaveDocument(outputStream, DocumentFormat.OpenXml)
			outputStream.Seek(0, SeekOrigin.Begin)
			outputStream.CopyTo(Response.OutputStream)
		End Using
		Response.StatusCode = CInt(Fix(HttpStatusCode.OK))
		Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
		Response.AddHeader("Content-Disposition", "attachment; filename=DevExpressCellArt.xlsx")
		Response.End()
	End Sub
	Protected Sub ASPxUploadControl1_FileUploadComplete(ByVal sender As Object, ByVal e As DevExpress.Web.FileUploadCompleteEventArgs)
		Dim uploadControl As ASPxUploadControl = CType(sender, ASPxUploadControl)
		Dim uploadedFile As UploadedFile = uploadControl.UploadedFiles(0)
		If (Not IsFileNameCorrect(uploadedFile.FileName)) Then
			e.IsValid = False
			e.ErrorText = "Incorrect file type"
			Return
		End If
		If uploadedFile.IsValid Then
			Session("UploadedFile") = GetBytesFromStream(uploadedFile.FileContent)
		End If
		e.CallbackData = Request.Url.AbsolutePath & "?previewImage" & DateTime.Now.Millisecond & "&previewSheet" & DateTime.Now.Millisecond
	End Sub
	Private Function IsFileNameCorrect(ByVal fileName As String) As Boolean
		Dim correctNames() As String = { ".png", ".jpg", ".jpeg", ".jpe", ".gif" }
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
	Private Sub LoadPreviewImage()
		Response.StatusCode = CInt(Fix(HttpStatusCode.OK))
		Dim imageData() As Byte = GetPreviewImageBytes()
		Response.ContentType = "image/png"
		Response.BinaryWrite(imageData)
		Response.End()
	End Sub
	Private Function GetPreviewImageBytes() As Byte()
		If Session("UploadedFile") IsNot Nothing Then
			Return CType(Session("UploadedFile"), Byte())
		End If
		Dim path As String = Page.MapPath("~/App_Data/DevExpress.png")
		Dim info As New FileInfo(path)
		Using stream As FileStream = info.OpenRead()
			Return GetBytesFromStream(stream)
		End Using
	End Function
End Class

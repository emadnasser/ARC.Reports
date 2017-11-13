Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web
Imports DevExpress.Compression
Imports System.IO
Imports System.Net
Imports System.Text

Partial Public Class Compression_Decompress
	Inherits System.Web.UI.Page
	Private Const UploadDirectory As String = "~/UploadData/"
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If Request.QueryString.Count = 0 Then
			Return
		End If
		Dim itemName As String = Request.QueryString("itemName")
		Dim fileName As String = Request.QueryString("decompress")
		If String.IsNullOrEmpty(itemName) OrElse String.IsNullOrEmpty(fileName) Then
			Return
		End If
		Dim fullZipFilePath As String = Path.Combine(MapPath(UploadDirectory), fileName)
		Dim zipArchive As ZipArchive = ZipArchive.Read(fullZipFilePath)
		Dim unzipItem As UnzipItem = TryCast(zipArchive(itemName), UnzipItem)
		If unzipItem Is Nothing Then
			Return
		End If
		If unzipItem.UncompressedSize > 10 * 1024 * 1024 Then
			Response.BinaryWrite(Encoding.ASCII.GetBytes("Uncompressed file size exceeds the limit (10 MB)"))
		Else
			Try
				unzipItem.Extract(Response.OutputStream)
			Catch ex As Exception
				Dim [error] As String = String.Format("Can't decompress file." & Constants.vbLf & "{0}", ex.Message)
				Response.BinaryWrite(Encoding.ASCII.GetBytes([error]))
			End Try
		End If
		Response.StatusCode = CInt(Fix(HttpStatusCode.OK))
		Response.ContentType = "application/octet-stream"
		Response.AddHeader("Content-Disposition", String.Format("attachment; filename={0}", GetFileName(itemName)))
		Response.End()
	End Sub
	Protected Sub UploadControl_FileUploadComplete(ByVal sender As Object, ByVal e As FileUploadCompleteEventArgs)
		Dim zipArchive As New ZipArchive()
		zipArchive = ZipArchive.Read(e.UploadedFile.FileContent)
		Dim fileName As String = Path.Combine(MapPath(UploadDirectory), e.UploadedFile.FileName)
		e.UploadedFile.SaveAs(fileName)
		Dim urlPath As String = ResolveClientUrl(UploadDirectory)
		For Each item As ZipItem In zipArchive
			If (item.Attributes And FileAttributes.Directory) = FileAttributes.Directory Then
				Continue For
			End If
			If item.EncryptionType <> EncryptionType.None Then
				e.ErrorText = "Encrypted archives are not processed."
				e.IsValid = False
				Return
			End If
			Dim file As String = String.Format("{0} ({1}KB)", item.Name, item.UncompressedSize / 1024)
			Dim fileUri As String = String.Format("Decompress.aspx?decompress={0}&itemName={1}", Uri.EscapeDataString(e.UploadedFile.FileName), Uri.EscapeDataString(item.Name))
			e.CallbackData &= "#" & file & "|" & fileUri
		Next item
	End Sub
	Private Function GetFileName(ByVal itemName As String) As String
		Dim indx As Integer = itemName.LastIndexOf("/"c)
		If indx < 0 Then
			Return itemName
		End If
		Return itemName.Substring(indx + 1)
	End Function
End Class

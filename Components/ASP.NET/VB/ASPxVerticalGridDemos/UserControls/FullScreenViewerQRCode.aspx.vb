Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing.Imaging
Imports System.IO
Imports DevExpress.Web.Demos

Partial Public Class FullScreenViewerQRCode
	Inherits System.Web.UI.Page
	Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
		Dim url As String = Request.QueryString("url")
		If String.IsNullOrEmpty(url) Then
			Return
		End If
		Using image = FullScreenModeUtils.GetQRCodeImage(url)
			Using stream As New MemoryStream()
				image.Save(stream, ImageFormat.Png)
				stream.WriteTo(Response.OutputStream)
				Response.End()
			End Using
		End Using
	End Sub
End Class

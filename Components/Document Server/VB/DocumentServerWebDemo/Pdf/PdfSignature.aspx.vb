Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Web.Hosting
Imports System.Web.UI
Imports System.Security.Cryptography.X509Certificates
Imports DevExpress.Pdf
Imports DevExpress.Web
Imports DevExpress.Web.Demos

Partial Public Class PdfSignature
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Utils.RegisterCssLink(Me, "~/Content/PdfDemos.css")
		ASPxWebControl.SetIECompatibilityModeEdge()
		Using documentProcessor As New PdfDocumentProcessor()
			documentProcessor.LoadDocument(HostingEnvironment.MapPath("~/App_Data/SignatureDemo.pdf"))
			Using bitmap As Bitmap = documentProcessor.CreateBitmap(1, 900)
				Using stream As New MemoryStream()
					bitmap.Save(stream, ImageFormat.Png)
					pageImage.Src = "data:image/png;base64," & Convert.ToBase64String(stream.GetBuffer())
				End Using
			End Using
		End Using
	End Sub
	Protected Sub OnSignButtonClick(ByVal source As Object, ByVal e As EventArgs)
		Using documentProcessor As New PdfDocumentProcessor()
			documentProcessor.LoadDocument(HostingEnvironment.MapPath("~/App_Data/SignatureDemo.pdf"))
			Using stream As Stream = New MemoryStream()
				Dim document As PdfDocument = documentProcessor.Document
				document.Creator = "PDF Document Processor Demo"
				document.Producer = "Developer Express Inc., " & AssemblyInfo.Version
				document.Author = "DevExpress Inc."
				document.Keywords = "PDF, document, server, code, generation, file atatchment"
				document.Subject = "PDF Document Processor - Signature"
				document.Title = "PDF Signature"
				Dim signature As New DevExpress.Pdf.PdfSignature(New X509Certificate2(HostingEnvironment.MapPath("~/App_Data/SignDemo.pfx"), "dxdemo")) With {.Location = tbLocation.Text, .ContactInfo = tbContactInfo.Text, .Reason = tbReason.Text}
				documentProcessor.SaveDocument(stream, New PdfSaveOptions() With {.Signature = signature})
				PdfDocumentReponse.SendStream(Response, stream)
			End Using
		End Using
	End Sub
End Class

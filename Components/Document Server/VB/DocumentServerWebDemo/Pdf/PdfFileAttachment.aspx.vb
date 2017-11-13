Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Web.Hosting
Imports System.Web.UI
Imports DevExpress.Pdf
Imports DevExpress.Web
Imports DevExpress.Web.Demos

Partial Public Class PdfFileAttachment
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Utils.RegisterCssLink(Me, "~/Content/PdfDemos.css")
		ASPxWebControl.SetIECompatibilityModeEdge()
	End Sub
	Protected Sub OnDownloadButtonClick(ByVal source As Object, ByVal e As EventArgs)
		Using documentProcessor As New PdfDocumentProcessor()
			documentProcessor.LoadDocument(HostingEnvironment.MapPath("~/App_Data/FileAttachment.pdf"))
			Dim attachment As New DevExpress.Pdf.PdfFileAttachment() With {.FileName = "DevExpress.png", .Data = File.ReadAllBytes(HostingEnvironment.MapPath("~/App_Data/DevExpress.png")), .Description = "To open the attachment in the Attachments tab, you can either click the 'Open file in its native application' icon or double - click the attachment.", .CreationDate = DateTime.Now}
			documentProcessor.AttachFile(attachment)
			PdfDocumentReponse.SendDocument(Response, documentProcessor, "PDF Document Processor - File Attachment", "PDF File Attachment")
		End Using
	End Sub
End Class

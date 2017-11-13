Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Web.UI
Imports DevExpress.Pdf
Imports DevExpress.Web
Imports DevExpress.Web.Demos

Partial Public Class PdfFormFlattening
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Utils.RegisterCssLink(Me, "~/Content/PdfDemos.css")
		ASPxWebControl.SetIECompatibilityModeEdge()
		If pdfPageViewer.DocumentData Is Nothing Then
			pdfPageViewer.LoadDocument("~/App_Data/FormDemo.pdf")
		End If
	End Sub
	Protected Sub OnFileUploadComplete(ByVal sender As Object, ByVal e As FileUploadCompleteEventArgs)
		pdfPageViewer.LoadDocument(uploadControl)
	End Sub

	Protected Sub OnDownloadButtonClick(ByVal sender As Object, ByVal e As EventArgs)
		Try
			Dim documentData() As Byte = pdfPageViewer.DocumentData
			If documentData IsNot Nothing Then
				Using documentStream As New MemoryStream(documentData)
					Using documentProcessor As New PdfDocumentProcessor()
						documentProcessor.LoadDocument(documentStream, True)
						documentProcessor.FlattenForm()
						PdfDocumentReponse.SendDocument(Response, documentProcessor, "PDF Document Processor - Form Flattening", "PDF Form Flattening")
					End Using
				End Using
			End If
		Catch
		End Try
	End Sub
End Class

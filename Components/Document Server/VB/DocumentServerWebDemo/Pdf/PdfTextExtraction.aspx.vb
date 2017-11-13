Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Web.UI
Imports DevExpress.Pdf
Imports DevExpress.Web
Imports DevExpress.Web.Demos

Partial Public Class PdfTextExtraction
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Utils.RegisterCssLink(Me, "~/Content/PdfDemos.css")
		ASPxWebControl.SetIECompatibilityModeEdge()
		If pdfPageViewer.DocumentData Is Nothing Then
			pdfPageViewer.LoadDocument("~/App_Data/TextExtraction.pdf")
		End If
	End Sub
	Protected Sub OnFileUploadComplete(ByVal sender As Object, ByVal e As FileUploadCompleteEventArgs)
		Dim fileName As String = pdfPageViewer.LoadDocument(uploadControl)
		If fileName IsNot Nothing Then
			e.CallbackData = fileName
		End If
	End Sub

	Protected Sub OnCallback(ByVal source As Object, ByVal e As DevExpress.Web.PopupWindowCallbackArgs)
		Try
			Dim documentData() As Byte = pdfPageViewer.DocumentData
			Dim viewer As UserControls_PdfResultsViewer = TryCast(Page.LoadControl("~/UserControls/PdfResultsViewer.ascx"), UserControls_PdfResultsViewer)
			If documentData IsNot Nothing AndAlso viewer IsNot Nothing Then
				Using documentStream As New MemoryStream(documentData)
					Using documentProcessor As New PdfDocumentProcessor()
						documentProcessor.LoadDocument(documentStream, True)
						viewer.SetText(documentProcessor.Text)
						txtPopup.Controls.Add(viewer)
						Return
					End Using
				End Using
			End If
		Catch
		End Try
	End Sub
End Class

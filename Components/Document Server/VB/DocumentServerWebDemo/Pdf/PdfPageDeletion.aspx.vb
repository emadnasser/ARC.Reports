Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Collections.Generic
Imports System.Web.UI
Imports DevExpress.Pdf
Imports DevExpress.Web
Imports DevExpress.Web.Demos

Partial Public Class PdfPageDeletion
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Utils.RegisterCssLink(Me, "~/Content/PdfDemos.css")
		ASPxWebControl.SetIECompatibilityModeEdge()
		If pdfPageViewer.DocumentData Is Nothing Then
			pdfPageViewer.LoadDocument("~/App_Data/PageDeletion.pdf")
		End If
	End Sub
	Protected Sub OnCallback(ByVal source As Object, ByVal e As CallbackEventArgsBase)
		Using documentProcessor As New PdfDocumentProcessor()
			Using dataStream As New MemoryStream(pdfPageViewer.DocumentData)
				documentProcessor.LoadDocument(dataStream)
				Dim pages As IList(Of PdfPage) = documentProcessor.Document.Pages
				Dim pageNumber As Integer = CInt(Fix(pdfPageViewer.PageIndex)) + 1
				If pages.Count > 0 Then
					documentProcessor.DeletePage(pageNumber)
				End If
				Using stream As New MemoryStream()
					documentProcessor.SaveDocument(stream)
					stream.Position = 0
					pdfPageViewer.UpdateDocument(stream, "PN" & (Math.Max(0, Math.Min(pageNumber, pages.Count) - 1)).ToString())
				End Using
			End Using
		End Using
	End Sub
End Class

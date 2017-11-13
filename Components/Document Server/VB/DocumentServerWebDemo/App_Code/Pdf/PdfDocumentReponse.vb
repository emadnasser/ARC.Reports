Imports Microsoft.VisualBasic
Imports System.IO
Imports System.Net
Imports System.Web
Imports DevExpress.Pdf

Namespace DevExpress.Web.Demos
	Public NotInheritable Class PdfDocumentReponse
		Private Sub New()
		End Sub
		Public Shared Sub SendStream(ByVal response As HttpResponse, ByVal stream As Stream)
			stream.Position = 0
			stream.CopyTo(response.OutputStream)
			response.StatusCode = CInt(Fix(HttpStatusCode.OK))
			response.ContentType = "application/pdf"
			response.AddHeader("Content-Disposition", "attachment; filename=Result.pdf")
			response.End()
		End Sub
		Public Shared Sub SendDocument(ByVal response As HttpResponse, ByVal documentProcessor As PdfDocumentProcessor, ByVal subject As String, ByVal title As String)
			Dim document As PdfDocument = documentProcessor.Document
			document.Creator = "PDF Document Processor Demo"
			document.Author = "DevExpress Inc."
			document.Keywords = "PDF, document, server, code"
			document.Producer = "Developer Express Inc."
			document.Subject = subject
			document.Title = title
			Using stream As New MemoryStream()
				documentProcessor.SaveDocument(stream)
				SendStream(response, stream)
			End Using
		End Sub
	End Class
End Namespace

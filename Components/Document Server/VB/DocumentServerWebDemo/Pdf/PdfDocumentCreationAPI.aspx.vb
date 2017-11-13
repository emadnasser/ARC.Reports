Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections.Generic
Imports System.Web.Hosting
Imports System.Web.UI
Imports DevExpress.Pdf
Imports DevExpress.Web
Imports DevExpress.Web.Demos

Partial Public Class PdfDocumentCreationAPI
	Inherits Page
	Private Const photoLocationX As Single = 100
	Private Const photoLocationY As Single = 100
	Private Const fontName As String = "Segoe UI"

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Utils.RegisterCssLink(Me, "~/Content/PdfDemos.css")
		ASPxWebControl.SetIECompatibilityModeEdge()
	End Sub
	Protected Sub OnDownloadButtonClick(ByVal source As Object, ByVal e As EventArgs)
		Using documentProcessor As New PdfDocumentProcessor()
			documentProcessor.CreateEmptyDocument()
			Dim bookmarks As IList(Of PdfBookmark) = documentProcessor.Document.Bookmarks
			Dim black As SolidBrush = CType(Brushes.Black, SolidBrush)
			Dim employees As New List(Of Employee)()
			Employee.FillWithData(employees)
			Dim photoNumber As Integer = 1
			For Each employee As Employee In employees
				Using graphics As PdfGraphics = documentProcessor.CreateGraphics()
					graphics.UseKerning = True
					Using photo As New Bitmap(HostingEnvironment.MapPath("~/App_Data/Photo" & photoNumber & ".jpeg"))
						graphics.DrawImage(photo, New RectangleF(photoLocationX, photoLocationY, photo.Width, photo.Height))
					End Using
					photoNumber += 1
					Using font As New Font(fontName, 32, FontStyle.Bold Or FontStyle.Underline)
						graphics.DrawString(employee.FirstName & " " & employee.LastName, font, black, 300, 90)
					End Using
					Using font As New Font(fontName, 20)
						graphics.DrawString(employee.Title, font, black, 300, 145)
					End Using
					Using font As New Font(fontName, 14)
						graphics.DrawString(employee.FirstName.ToLower() & "." & employee.LastName.ToLower()(0) & "@example.com", font, black, 300, 230)
					End Using
					Dim bookmark As New PdfBookmark() With {.Title = employee.FirstName & " " & employee.LastName, .Destination = documentProcessor.CreateDestination(documentProcessor.RenderNewPage(PdfPaperSize.Letter, graphics), photoLocationX, photoLocationY)}
					bookmarks.Add(bookmark)
				End Using
			Next employee
			PdfDocumentReponse.SendDocument(Response, documentProcessor, "PDF Document Processor - Document Creation API Demo", "PDF Document Creation API")
		End Using
	End Sub
End Class

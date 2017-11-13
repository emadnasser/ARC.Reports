Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Text
Imports System.Web.UI
Imports DevExpress.Pdf
Imports DevExpress.Web
Imports DevExpress.Web.Demos

Partial Public Class PdfTextSearch
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Utils.RegisterCssLink(Me, "~/Content/PdfDemos.css")
		ASPxWebControl.SetIECompatibilityModeEdge()
		If pdfPageViewer.DocumentData Is Nothing Then
			pdfPageViewer.LoadDocument("~/App_Data/TextSearch.pdf")
		End If
	End Sub
	Protected Sub OnFileUploadComplete(ByVal sender As Object, ByVal e As FileUploadCompleteEventArgs)
		Dim fileName As String = pdfPageViewer.LoadDocument(uploadControl)
		If fileName IsNot Nothing Then
			e.CallbackData = fileName
		End If
	End Sub
	Protected Sub OnCallback(ByVal source As Object, ByVal e As PopupWindowCallbackArgs)
		Try
			Dim documentData() As Byte = pdfPageViewer.DocumentData
			Dim viewer As UserControls_PdfResultsViewer = TryCast(Page.LoadControl("~/UserControls/PdfResultsViewer.ascx"), UserControls_PdfResultsViewer)
			If documentData IsNot Nothing AndAlso viewer IsNot Nothing Then
				Using documentStream As New MemoryStream(documentData)
					Using documentProcessor As New PdfDocumentProcessor()
						documentProcessor.LoadDocument(documentStream, True)
						Dim wordCount As Integer = Convert.ToInt32(spinEditWordCount.Value)
						Dim text As New StringBuilder()
						Do While documentProcessor.FindText(textBoxTextToFind.Text).Status = PdfTextSearchStatus.Found
							For i As Integer = 0 To wordCount - 1
								Dim nextWord As PdfWord = documentProcessor.NextWord()
								If nextWord Is Nothing Then
									Exit For
								End If
								text.Append(nextWord.Text)
								text.Append(" ")
							Next i
							text.Append(Environment.NewLine)
						Loop
						viewer.SetText(text.ToString())
						txtPopup.Controls.Add(viewer)
						Return
					End Using
				End Using
			End If
		Catch
		End Try
	End Sub
End Class

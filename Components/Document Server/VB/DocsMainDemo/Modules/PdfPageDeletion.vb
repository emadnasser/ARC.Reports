Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports DevExpress.DXperience.Demos
Imports DevExpress.Pdf
Imports DevExpress.XtraPdfViewer

Namespace DevExpress.Docs.Demos
	Partial Public Class PdfPageDeletion
		Inherits TutorialControlBase
		Private ReadOnly documentProcessor As New PdfDocumentProcessor()
		Private ReadOnly fileHelper As PdfFileHelper

		Public Overrides ReadOnly Property NoGap() As Boolean
			Get
				Return True
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			fileHelper = New PdfFileHelper(documentProcessor, pdfViewer)
		End Sub
		Protected Overrides Sub DoShow()
			MyBase.DoShow()
			Enabled = fileHelper.LoadDocument(DemoUtils.GetRelativePath("PageDeletion.pdf"), True)
			UpdateButtons()
		End Sub
		Private Sub PdfViewerCurrentPageChanged(ByVal sender As Object, ByVal e As PdfCurrentPageChangedEventArgs) Handles pdfViewer.CurrentPageChanged
			spinEditPageNumber.Value = e.PageNumber
		End Sub
		Private Sub OnButtonDeletePageClick(ByVal sender As Object, ByVal e As EventArgs) Handles buttonDeletePage.Click
			Try
				Dim page As Integer = CInt(Fix(spinEditPageNumber.Value))
				documentProcessor.DeletePage(page)
				Using stream As Stream = New MemoryStream()
					documentProcessor.SaveDocument(stream, True)
					stream.Position = 0
					pdfViewer.LoadDocument(stream)
					pdfViewer.CurrentPageNumber = page
				End Using
				UpdateButtons()
			Catch
			End Try
		End Sub
		Private Sub OnButtonOpenClick(ByVal sender As Object, ByVal e As EventArgs) Handles buttonOpen.Click
			fileHelper.OpenFile()
			UpdateButtons()
		End Sub
		Private Sub OnButtonSaveClick(ByVal sender As Object, ByVal e As EventArgs) Handles buttonSave.Click
			PdfFileHelper.Save(documentProcessor)
		End Sub
		Private Sub UpdateButtons()
			Dim count As Integer = documentProcessor.Document.Pages.Count
			If count > 0 Then
				spinEditPageNumber.Properties.MaxValue = count
				spinEditPageNumber.Enabled = True
				buttonDeletePage.Enabled = True
			Else
				spinEditPageNumber.Enabled = False
				buttonDeletePage.Enabled = False
			End If
		End Sub
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
				documentProcessor.Dispose()
				fileHelper.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub
	End Class
End Namespace

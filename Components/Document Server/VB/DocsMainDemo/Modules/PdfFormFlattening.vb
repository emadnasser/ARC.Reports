Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports DevExpress.DXperience.Demos
Imports DevExpress.Pdf
Imports DevExpress.XtraPdfViewer

Namespace DevExpress.Docs.Demos
	Partial Public Class PdfFormFlattening
		Inherits TutorialControlBase
		Private Shared ReadOnly path As String = DemoUtils.GetRelativePath("FormDemo.pdf")

		Private documentProcessor As PdfDocumentProcessor
		Private fileHelper As PdfFileHelper

		Public Overrides ReadOnly Property NoGap() As Boolean
			Get
				Return True
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			documentProcessor = New PdfDocumentProcessor()
			fileHelper = New PdfFileHelper(documentProcessor, pdfViewer)
			Enabled = fileHelper.LoadDocument(path, True)
		End Sub
		Private Sub FlattenFormFieldsClick(ByVal sender As Object, ByVal e As EventArgs) Handles buttonFlattenFormFields.Click
			Using sourceStream As Stream = New MemoryStream()
				pdfViewer.SaveDocument(sourceStream)
				documentProcessor.LoadDocument(sourceStream)
				documentProcessor.FlattenForm()
				Using stream As Stream = New MemoryStream()
					documentProcessor.SaveDocument(stream, True)
					stream.Position = 0
					pdfViewer.LoadDocument(stream)
				End Using
			End Using
		End Sub
		Private Sub DocumentClosing(ByVal sender As Object, ByVal e As PdfDocumentClosingEventArgs) Handles pdfViewer.DocumentClosing
		End Sub
		Private Sub OpenClick(ByVal sender As Object, ByVal e As EventArgs) Handles buttonOpen.Click
			fileHelper.OpenFile()
		End Sub
		Private Sub SaveClick(ByVal sender As Object, ByVal e As EventArgs) Handles buttonSave.Click
			PdfFileHelper.Save(documentProcessor)
		End Sub
		Private Sub LoadDemoDocumentClick(ByVal sender As Object, ByVal e As EventArgs) Handles buttonLoadDemoDocument.Click
			Enabled = PdfFileHelper.LoadDocument(pdfViewer, path)
		End Sub
	End Class
End Namespace

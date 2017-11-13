Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.Pdf
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraEditors

Namespace DevExpress.Docs.Demos
	Partial Public Class PdfPageMerging
		Inherits TutorialControlBase
		Private Const largeFileMessage As String = "Not enough memory to append a file."

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
			Enabled = PdfFileHelper.LoadDocument(pdfViewer, DemoUtils.GetRelativePath("PageMerging.pdf"))
		End Sub
		Private Sub OnButtonAppendClick(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAppend.Click
			Try
				Using stream As New MemoryStream()
					Using saveStream As New MemoryStream()
						pdfViewer.SaveDocument(saveStream)
						documentProcessor.LoadDocument(saveStream, True)
						fileHelper.MergeFile()
						documentProcessor.SaveDocument(stream)
						stream.Position = 0
						pdfViewer.LoadDocument(stream)
					End Using
					pdfViewer.ScrollVertical(Int32.MaxValue)
					saveButton.Enabled = True
				End Using
			Catch e1 As OutOfMemoryException
				XtraMessageBox.Show("Not enough memory to append a document.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
				Return
			Catch
			End Try
		End Sub
		Private Sub OnButtonOpenClick(ByVal sender As Object, ByVal e As EventArgs) Handles buttonOpen.Click
			fileHelper.OpenFile()
			saveButton.Enabled = True
		End Sub
		Private Sub OnSaveButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles saveButton.Click
			PdfFileHelper.Save(documentProcessor)
		End Sub
		Private Sub OnNewButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles newButton.Click
			Using stream As New MemoryStream()
				documentProcessor.CreateEmptyDocument(stream)
				documentProcessor.CloseDocument()
				stream.Position = 0
				pdfViewer.LoadDocument(stream)
				saveButton.Enabled = False
			End Using
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

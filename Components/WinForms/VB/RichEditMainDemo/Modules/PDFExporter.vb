Imports System
Imports System.IO
Imports DevExpress.XtraRichEdit.Internal

Namespace DevExpress.XtraRichEdit.Demos
	Partial Public Class PDFExporterModule
		Inherits DevExpress.XtraRichEdit.Demos.TutorialControl

		Public Sub New()
			InitializeComponent()

			pdfViewer.DetachStreamAfterLoadComplete = True
			OpenXmlLoadHelper.Load("pdfExample.docx", richEditControl)
			CType(New RichEditDemoExceptionsHandler(richEditControl), RichEditDemoExceptionsHandler).Install()
		End Sub

		Public Overrides ReadOnly Property PrintingRichEditControl() As RichEditControl
			Get
				Return richEditControl
			End Get
		End Property

		Protected Overrides Sub DoShow()
			MyBase.DoShow()
			richEditControl.Focus()
		End Sub

		Private Sub richEditControl_DocumentLoaded(ByVal sender As Object, ByVal e As EventArgs) Handles richEditControl.DocumentLoaded
			ExportToPdf()
		End Sub

		Private Sub richEditControl_EmptyDocumentCreated(ByVal sender As Object, ByVal e As EventArgs) Handles richEditControl.EmptyDocumentCreated
			pdfViewer.DocumentFilePath = String.Empty
		End Sub

		Private Sub exportToPdfBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles exportToPdfBarButtonItem.ItemClick, barButtonItem1.ItemClick
			ExportToPdf()
		End Sub

        Protected Overrides Sub ExportToPdf()
            Using pdfStream As New MemoryStream()
                richEditControl.ExportToPdf(pdfStream)
                pdfStream.Position = 0
                pdfViewer.LoadDocument(pdfStream)
            End Using
        End Sub
	End Class
End Namespace

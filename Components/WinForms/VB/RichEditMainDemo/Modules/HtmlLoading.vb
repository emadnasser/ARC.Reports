Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports System.IO
Imports DevExpress.XtraRichEdit.Internal

Namespace DevExpress.XtraRichEdit.Demos
	Partial Public Class HtmlLoadingModule
		Inherits DevExpress.XtraRichEdit.Demos.TutorialControl
		Public Sub New()
			InitializeComponent()

			Dim service As IDocumentImportManagerService = richEditControl.GetService(Of IDocumentImportManagerService)()
			If service IsNot Nothing Then
				service.UnregisterImporter(service.GetImporter(DocumentFormat.PlainText))
				service.UnregisterImporter(service.GetImporter(DocumentFormat.Rtf))
				service.UnregisterImporter(service.GetImporter(DocumentFormat.Mht))
				service.UnregisterImporter(service.GetImporter(DocumentFormat.OpenXml))
			End If

            HtmlLoadHelper.Load("html_sample.htm", richEditControl)
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
			Try
				Dim fileName As String = richEditControl.Options.DocumentSaveOptions.CurrentFileName
				If (Not String.IsNullOrEmpty(fileName)) Then
					webBrowser.Url = New Uri("file://" & fileName)
					Using reader As New StreamReader(fileName)
						edtPlainHtml.Text = reader.ReadToEnd()
					End Using
				End If
			Catch
			End Try
		End Sub

		Private Sub richEditControl_EmptyDocumentCreated(ByVal sender As Object, ByVal e As EventArgs) Handles richEditControl.EmptyDocumentCreated
			webBrowser.Url = Nothing
			edtPlainHtml.Text = String.Empty
		End Sub
	End Class
End Namespace

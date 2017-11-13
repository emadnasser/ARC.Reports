Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.XtraRichEdit
Imports System.Collections.Generic
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraPrintingLinks
Imports System.Runtime.InteropServices

Namespace DevExpress.Docs.Demos
	Partial Public Class RichEditExport
		Inherits TutorialControlBase
		Private link As PrintableComponentLinkBase
		Private documentServer As RichEditDocumentServer

		Public Sub New()
			InitializeComponent()

			Me.printPreviewControl.PrintingSystem = New DevExpress.XtraPrinting.PrintingSystem()
			Me.link = New DevExpress.XtraPrintingLinks.PrintableComponentLinkBase(Me.printPreviewControl.PrintingSystem)

			Me.edtFilePath.Text = DemoUtils.GetRelativePath("MovieRentals.docx")
			Me.edtSaveTo.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
			LoadDocument()
		End Sub
		Private Sub btnExport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRtf.Click, btnEpub.Click, btnXml.Click, btnOdt.Click, btnDocx.Click, btnMht.Click, btnHtml.Click, btnTxt.Click, btnDoc.Click, btnPdf.Click
			Dim format As String = (CType(sender, DevExpress.XtraEditors.SimpleButton)).Text.ToLower()
			Dim filePath As String = edtFilePath.Text
			Dim fileName As String = Path.GetFileNameWithoutExtension(filePath)
			Dim pathString As String = edtSaveTo.Text & fileName
			Dim resultFilePath As String = String.Empty
			If format = "rtf" Then
				resultFilePath = pathString & ".rtf"
				Me.documentServer.SaveDocument(resultFilePath, DocumentFormat.Rtf)
			ElseIf format = "txt" Then
				resultFilePath = pathString & ".txt"
				Me.documentServer.SaveDocument(resultFilePath, DocumentFormat.PlainText)
			ElseIf format = "html" Then
				resultFilePath = pathString & ".html"
				Me.documentServer.SaveDocument(resultFilePath, DocumentFormat.Html)
			ElseIf format = "mht" Then
				resultFilePath = pathString & ".mht"
				Me.documentServer.SaveDocument(resultFilePath, DocumentFormat.Mht)
			ElseIf format = "docx" Then
				resultFilePath = pathString & ".docx"
				Me.documentServer.SaveDocument(resultFilePath, DocumentFormat.OpenXml)
			ElseIf format = "odt" Then
				resultFilePath = pathString & ".odt"
				Me.documentServer.SaveDocument(resultFilePath, DocumentFormat.OpenDocument)
			ElseIf format = "xml" Then
				resultFilePath = pathString & ".xml"
				Me.documentServer.SaveDocument(resultFilePath, DocumentFormat.WordML)
			ElseIf format = "epub" Then
				resultFilePath = pathString & ".epub"
				Me.documentServer.SaveDocument(resultFilePath, DocumentFormat.ePub)
			ElseIf format = "doc" Then
				resultFilePath = pathString & ".doc"
				Me.documentServer.SaveDocument(resultFilePath, DocumentFormat.Doc)
			ElseIf format = "pdf" Then
				resultFilePath = pathString & ".pdf"
				Using stream As New FileStream(resultFilePath, FileMode.Create, FileAccess.Write, FileShare.Read)
					Me.documentServer.ExportToPdf(stream)
				End Using
			End If
			If (Not String.IsNullOrEmpty(resultFilePath)) Then
				DemoUtils.PreviewDocument(resultFilePath)
			End If
		End Sub
		Private Sub LoadDocument()
			If Me.documentServer Is Nothing Then
				Me.documentServer = New RichEditDocumentServer()
				CType(New RichEditDemoExceptionsHandler(Me.documentServer), RichEditDemoExceptionsHandler).Install()
			End If
			Dim path As String = Me.edtFilePath.Text
			Me.documentServer.LoadDocument(path)
			Me.link.Component = Me.documentServer
			Me.link.CreateDocument()
		End Sub
		Private Sub edtFilePath_ButtonClick(ByVal sender As Object, ByVal e As XtraEditors.Controls.ButtonPressedEventArgs) Handles edtFilePath.ButtonClick
			ChooseFileToOpen(String.Empty)
		End Sub
		Private Sub ChooseFileToOpen(ByVal initialPath As String)
			Using openFileDialog As New OpenFileDialog()
				If (Not String.IsNullOrEmpty(initialPath)) Then
					openFileDialog.InitialDirectory = initialPath
				End If
				If openFileDialog.ShowDialog() <> DialogResult.OK Then
					Return
				End If
				Me.edtFilePath.Text = openFileDialog.FileName
				LoadDocument()
			End Using
		End Sub
		Private Sub edtFilePath_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles edtFilePath.KeyUp, edtSaveTo.KeyUp
			If e.KeyCode <> Keys.Enter Then
				Return
			End If
			Dim fileInfo As New FileInfo(Me.edtFilePath.Text)
			If fileInfo.Exists Then
				LoadDocument()
				Return
			End If
			ChooseFileToOpen(Me.edtFilePath.Text)
		End Sub
		Private Sub ChooseFolderToSave()
			Using openFileDialog As New FolderBrowserDialog()
				If openFileDialog.ShowDialog() <> DialogResult.OK Then
					Return
				End If
				Me.edtSaveTo.Text = openFileDialog.SelectedPath
			End Using
		End Sub
		Private Sub edtSaveTo_ButtonClick(ByVal sender As Object, ByVal e As XtraEditors.Controls.ButtonPressedEventArgs) Handles edtSaveTo.ButtonClick
			ChooseFolderToSave()
		End Sub
	End Class

	Friend Class RichEditDemoExceptionsHandler
		Private ReadOnly documentServer As RichEditDocumentServer
		Public Sub New(ByVal documentServer As RichEditDocumentServer)
			Me.documentServer = documentServer
		End Sub
		Public Sub Install()
			If documentServer IsNot Nothing Then
				AddHandler documentServer.UnhandledException, AddressOf OnRichEditControlUnhandledException
			End If
		End Sub

		Protected Overridable Sub OnRichEditControlUnhandledException(ByVal sender As Object, ByVal e As RichEditUnhandledExceptionEventArgs)
			Try
				If e.Exception IsNot Nothing Then
					Throw e.Exception
				End If
			Catch ex As RichEditUnsupportedFormatException
				DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
				e.Handled = True
			Catch ex As ExternalException
				DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
				e.Handled = True
			Catch ex As System.IO.IOException
				DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
				e.Handled = True
			End Try
		End Sub
	End Class
End Namespace

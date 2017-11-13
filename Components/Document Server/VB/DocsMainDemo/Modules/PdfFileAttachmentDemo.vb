Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.Pdf
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPdfViewer
Imports DevExpress.DXperience.Demos

Namespace DevExpress.Docs.Demos
	Partial Public Class PdfFileAttachmentDemo
		Inherits TutorialControlBase
		Private Const errorMessage As String = "The operation can't be completed. Please check if the file attachment is available."
		Private Const largeAttachmentMessage As String = "Not enough memory to attach a file."

		Private ReadOnly documentProcessor As New PdfDocumentProcessor()
		Private tempFileName As String

		Public Overrides ReadOnly Property NoGap() As Boolean
			Get
				Return True
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			Try
				tempFileName = Path.GetTempFileName()
				File.Copy(DemoUtils.GetRelativePath("FileAttachmentDemo.pdf"), tempFileName, True)
				CType(New FileInfo(tempFileName), FileInfo).IsReadOnly = False
				ReloadDocument()
			Catch
				XtraMessageBox.Show(PdfFileHelper.DemoOpeningErrorMessage, "Error")
				Enabled = False
			End Try
		End Sub
		Private Sub ReloadDocument()
			Dim navigationPaneVisible As Boolean = pdfViewer.NavigationPaneVisibility = PdfNavigationPaneVisibility.Visible
			If documentProcessor.Document IsNot Nothing Then
				pdfViewer.CloseDocument()
				Try
					documentProcessor.SaveDocument(tempFileName)
				Catch e1 As OutOfMemoryException
					XtraMessageBox.Show(largeAttachmentMessage, "Error")
				End Try
			End If
			pdfViewer.LoadDocument(tempFileName)
			documentProcessor.LoadDocument(tempFileName)
			lbFileAttachments.DataSource = documentProcessor.Document.FileAttachments
			lbFileAttachments.SelectedIndex = 0
			If navigationPaneVisible Then
				pdfViewer.NavigationPaneVisibility = PdfNavigationPaneVisibility.Visible
			End If
		End Sub

		Private Sub ReloadDocument(ByVal action As Func(Of Boolean))
			Cursor.Current = Cursors.WaitCursor
			Try
				If action() Then
					ReloadDocument()
				End If
			Catch
				XtraMessageBox.Show(errorMessage)
			Finally
				Cursor.Current = Cursors.Arrow
			End Try
		End Sub
		Private Sub OnAttachFile(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAttachFile.Click
			ReloadDocument(AddressOf AttachFile)
		End Sub
		Private Function AttachFile() As Boolean
			Using openDialog As New OpenFileDialog()
				If openDialog.ShowDialog() = DialogResult.OK Then
					Cursor.Current = Cursors.WaitCursor
					Dim fileName As String = openDialog.FileName
					Dim data() As Byte
					Try
						data = File.ReadAllBytes(fileName)
					Catch e1 As OutOfMemoryException
						XtraMessageBox.Show(largeAttachmentMessage, "Error")
						Return False
					End Try
					Dim fileAttachment As New PdfFileAttachment() With {.FileName = Path.GetFileName(fileName), .Data = data, .CreationDate = DateTime.Now, .Description = "To open the attachment in the Attachments tab, you can either click the 'Open file in its native application' icon or double-click the attachment."}
					documentProcessor.AttachFile(fileAttachment)
					Return True
				End If
			End Using
			Return False
		End Function
		Private Sub OnDeleteFile(ByVal sender As Object, ByVal e As EventArgs) Handles deleteButton.Click
			ReloadDocument(AddressOf DeleteAttachment)
		End Sub
		Private Function DeleteAttachment() As Boolean
			documentProcessor.DeleteAttachment(CType(lbFileAttachments.SelectedItem, PdfFileAttachment))
			Return True
		End Function
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
				documentProcessor.Dispose()
				pdfViewer.CloseDocument()
				Try
					File.Delete(tempFileName)
				Catch
				End Try
			End If
			MyBase.Dispose(disposing)
		End Sub

	End Class
End Namespace

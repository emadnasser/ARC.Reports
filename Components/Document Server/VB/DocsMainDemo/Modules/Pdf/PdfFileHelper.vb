Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Security
Imports System.Windows.Forms
Imports DevExpress.Pdf
Imports DevExpress.XtraPdfViewer
Imports DevExpress.XtraEditors
Imports System.Security.Cryptography

Namespace DevExpress.Docs.Demos
	Public Class PdfFileHelper
		Implements IDisposable
		Public Const SaveErrorMessage As String = "Unable to save the PDF document." & Constants.vbCrLf & "{0}"
		Public Const DemoOpeningErrorMessage As String = "The demo data has been corrupted."

		Private Shared Function ShowFileDialog(Of T As {FileDialog, New})() As String
			Using fileDialog As New T()
				fileDialog.Filter = "PDF Files (*.pdf)|*.pdf"
				fileDialog.RestoreDirectory = True
				If fileDialog.ShowDialog() = DialogResult.OK Then
					Return fileDialog.FileName
				End If
				Return Nothing
			End Using
		End Function
		Public Shared Function LoadDocument(ByVal viewer As PdfViewer, ByVal path As String) As Boolean
			Try
				viewer.LoadDocument(path)
			Catch
				XtraMessageBox.Show(DemoOpeningErrorMessage, "Error")
				Return False
			End Try
			Return True
		End Function
		Public Shared Function LoadDocument(ByVal viewer As PdfViewer, ByVal stream As Stream) As Boolean
			Try
				viewer.LoadDocument(stream)
			Catch
				XtraMessageBox.Show(DemoOpeningErrorMessage, "Error")
				Return False
			End Try
			Return True
		End Function
		Public Shared Function SaveFileDialog() As String
			Return ShowFileDialog(Of SaveFileDialog)()
		End Function
		Public Shared Function OpenFileDialog() As String
			Return ShowFileDialog(Of OpenFileDialog)()
		End Function
		Public Shared Sub Save(ByVal documentProcessor As PdfDocumentProcessor)
			Save(documentProcessor, New PdfSaveOptions())
		End Sub
		Public Shared Sub Save(ByVal documentProcessor As PdfDocumentProcessor, ByVal saveOptions As PdfSaveOptions)
			Dim fileName As String = SaveFileDialog()
			If (Not String.IsNullOrEmpty(fileName)) Then
				Try
					Dim document As PdfDocument = documentProcessor.Document
					document.Creator = "PDF Document Processor Demo"
					document.Producer = "Developer Express Inc., " & AssemblyInfo.Version
					documentProcessor.SaveDocument(fileName, saveOptions)
				Catch exception As CryptographicException
					XtraMessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Catch
					XtraMessageBox.Show(String.Format(SaveErrorMessage, fileName), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
				End Try
			End If
		End Sub

		Private ReadOnly documentProcessor As PdfDocumentProcessor
		Private ReadOnly viewer As PdfViewer
		Private password As SecureString

		Public Sub New(ByVal documentProcessor As PdfDocumentProcessor, ByVal viewer As PdfViewer)
			Me.documentProcessor = documentProcessor
			Me.viewer = viewer
			AddHandler documentProcessor.PasswordRequested, AddressOf OnDocumentServerPasswordRequested
			AddHandler viewer.PasswordRequested, AddressOf OnViewerPasswordRequested
		End Sub
		Private Sub OpenFile(ByVal fileAction As Action(Of String))
			Dim fileName As String = ShowFileDialog(Of OpenFileDialog)()
			If (Not String.IsNullOrEmpty(fileName)) Then
				Do
					Try
						fileAction(fileName)
						Return
					Catch e1 As PdfIncorrectPasswordException
						If password Is Nothing Then
							Return
						End If
						XtraMessageBox.Show("The password is incorrect. Please make sure that Caps Lock is not enabled.", fileName, MessageBoxButtons.OK, MessageBoxIcon.Information)
					Catch e2 As OutOfMemoryException
						XtraMessageBox.Show(String.Format("Not enough memory to load the file." & Constants.vbCrLf & "{0}", fileName), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
						Return
					Catch
						Dim message As String = "Unable to load the PDF document because the following file is not available or it is not a valid PDF document." & Constants.vbCrLf & "{0}" & Constants.vbCrLf & "Please ensure that the application can access this file and that it is valid, or specify a different file."
						XtraMessageBox.Show(String.Format(message, fileName), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
						Return
					End Try
				Loop
			End If
		End Sub
		Private Sub MergeFileAction(ByVal fileName As String)
			documentProcessor.AppendDocument(fileName)
		End Sub
		Private Sub OpenFileAction(ByVal fileName As String)
			documentProcessor.LoadDocument(fileName)
			viewer.LoadDocument(fileName)
		End Sub

		Public Sub MergeFile()
			OpenFile(AddressOf MergeFileAction)
		End Sub
		Public Sub OpenFile()
			OpenFile(AddressOf OpenFileAction)
		End Sub
		Public Function LoadDocument(ByVal path As String) As Boolean
			Return LoadDocument(path, False)
		End Function
		Public Function LoadDocument(ByVal path As String, ByVal detach As Boolean) As Boolean
			viewer.DetachStreamAfterLoadComplete = detach
			If LoadDocument(viewer, path) Then
				documentProcessor.LoadDocument(path, detach)
				Return True
			End If
			Return False
		End Function
		Private Sub OnDocumentServerPasswordRequested(ByVal sender As Object, ByVal e As PdfPasswordRequestedEventArgs)
			Using form As New PasswordForm(Path.GetFileName(e.FileName))
				form.StartPosition = FormStartPosition.CenterParent
				If form.ShowDialog() = DialogResult.OK Then
					password = New SecureString()
					For Each c As Char In form.Password
						password.AppendChar(c)
					Next c
					e.Password = password
				Else
					password = Nothing
				End If
			End Using
		End Sub
		Private Sub OnViewerPasswordRequested(ByVal sender As Object, ByVal e As PdfPasswordRequestedEventArgs)
			e.Password = password
		End Sub
		Public Sub Dispose() Implements IDisposable.Dispose
			RemoveHandler documentProcessor.PasswordRequested, AddressOf OnDocumentServerPasswordRequested
			RemoveHandler viewer.PasswordRequested, AddressOf OnViewerPasswordRequested
			If password IsNot Nothing Then
				password.Dispose()
			End If
		End Sub
	End Class
End Namespace

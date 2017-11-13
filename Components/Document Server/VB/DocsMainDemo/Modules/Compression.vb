Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading
Imports System.Windows.Forms
Imports DevExpress.Compression
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.Docs.Demos
	Partial Public Class Compression
		Inherits TutorialControlBase
'INSTANT VB TODO TASK: There is no VB.NET equivalent to 'volatile':
		Private isOperationCanceled As Boolean = False
		Private archiveMakerThread As Thread
		Private activeArchivePath As String = String.Empty

		Public Sub New()
			InitializeComponent()
			PrepareContent()
		End Sub
		Private Sub MakeArchive(ByVal parameters As Object)
			Dim info As ArchiveParametersInfo = TryCast(parameters, ArchiveParametersInfo)
			If info Is Nothing Then
				Return
			End If
			Dim zipFileName As String = info.ZipFileName
			Dim sourceFiles As List(Of FileCollectionItem) = info.SourceFiles
			Dim password As String = info.Password
			Dim encryptionType As EncryptionType = info.EncryptionType
			Dim isSaved As Boolean = False
			Using archive As New ZipArchive()
				AddHandler archive.Error, AddressOf OnArchiveError
				AddHandler archive.Progress, AddressOf OnArchiveProgress
				AddHandler archive.ItemAdding, AddressOf archive_ItemAdding
				If (Not String.IsNullOrEmpty(password)) Then
					archive.Password = password
					archive.EncryptionType = encryptionType
				End If
				For Each file As FileCollectionItem In sourceFiles
					If file.ItemType = FileCollectionItemType.File Then
						archive.AddFile(file.FullName, "/")
					ElseIf file.ItemType = FileCollectionItemType.Directory Then
						archive.AddDirectory(file.FullName, file.Name)
					End If
				Next file
				If (Not Me.isOperationCanceled) Then
					archive.Save(zipFileName)
					isSaved = True
				End If
			End Using
			NotifyEndArchivingOperation(isSaved)
		End Sub

		Private Sub archive_ItemAdding(ByVal sender As Object, ByVal args As ZipItemAddingEventArgs)
			If Me.isOperationCanceled Then
				args.Action = ZipItemAddingAction.Stop
			End If
			lblTotalFilesCount.BeginInvoke(CType(Function() AnonymousMethod1(sender), Action))
		End Sub
		
		Private Function AnonymousMethod1(ByVal sender As Object) As Boolean
			Dim archive As ZipArchive = CType(sender, ZipArchive)
			Me.lblTotalFilesCount.Text = String.Format("Total files found: {0}", archive.Count + 1)
			Return True
		End Function
		Private Sub OnArchiveProgress(ByVal sender As Object, ByVal args As ProgressEventArgs)
			If (Not progressBarControl1.IsHandleCreated) Then
				Return
			End If
			progressBarControl1.BeginInvoke(CType(Function() AnonymousMethod2(args), Action))
			args.CanContinue = Not Me.isOperationCanceled
		End Sub
		
		Private Function AnonymousMethod2(ByVal args As ProgressEventArgs) As Boolean
			progressBarControl1.EditValue = 1000 * args.Progress
			Return True
		End Function

		Private Sub OnArchiveError(ByVal sender As Object, ByVal args As ErrorEventArgs)
			If TypeOf args.GetException() Is ThreadAbortException Then
				args.CanContinue = False
				Return
			End If
			Me.Invoke(New ErrorEventHandler(AddressOf OnArchiveErrorCore), Me, args)
		End Sub
		Private Sub OnArchiveErrorCore(ByVal sender As Object, ByVal args As ErrorEventArgs)
			Dim e As Exception = args.GetException()
			Dim errorMessage As String = If(String.IsNullOrEmpty(args.ItemName), e.Message, String.Format("Item: {0}" & Constants.vbLf + Constants.vbLf & "Description:" & Constants.vbLf & "{1}", args.ItemName, e.Message))
			Dim descriptionMessage As String = "Click Cancel to abort operation. Click OK to skip the item and continue."
			Dim message As String = String.Format("{0}" & Constants.vbLf & "{1}", errorMessage, descriptionMessage)
			If XtraMessageBox.Show(message, "Error", MessageBoxButtons.OKCancel) = DialogResult.Cancel Then
				args.CanContinue = False
				Me.isOperationCanceled = True
			End If
		End Sub
		Private Sub PrepareContent()
			Me.progressBarControl1.Properties.Minimum = 0
			Me.progressBarControl1.Properties.Maximum = 1000
			Me.cbEncryption.Properties.Items.Add(New ImageComboBoxItem(EncryptionType.PkZip.ToString(), EncryptionType.PkZip))
			Me.cbEncryption.Properties.Items.Add(New ImageComboBoxItem(EncryptionType.Aes128.ToString(), EncryptionType.Aes128))
			Me.cbEncryption.Properties.Items.Add(New ImageComboBoxItem(EncryptionType.Aes256.ToString(), EncryptionType.Aes256))
			Me.cbEncryption.SelectedIndex = 0
			Me.pnlProgress.Visible = False
			AddHandler Me.HandleDestroyed, AddressOf Compression_HandleDestroyed
		End Sub
		Private Sub Compression_HandleDestroyed(ByVal sender As Object, ByVal e As EventArgs)
			Me.isOperationCanceled = True
			If Me.archiveMakerThread IsNot Nothing Then
				archiveMakerThread.Abort()
			End If
			Me.archiveMakerThread = Nothing
		End Sub
		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			Me.activeArchivePath = AskFileName()
			If String.IsNullOrEmpty(Me.activeArchivePath) Then
				Return
			End If
			Dim fileNames As List(Of FileCollectionItem) = Me.fileSystemViewer1.GetSelectedFiles()
			Dim info As New ArchiveParametersInfo(Me.activeArchivePath, fileNames, Me.edtPassword.Text, CType(Me.cbEncryption.EditValue, EncryptionType))
			Me.archiveMakerThread = New Thread(AddressOf MakeArchive)
			NotifyBeginArchivingOperation()
			archiveMakerThread.Start(info)
		End Sub
		Private Sub NotifyBeginArchivingOperation()
			Me.Invoke(CType(Function() AnonymousMethod3(), Action))
		End Sub
		
		Private Function AnonymousMethod3() As Boolean
			Me.pnlProgress.Visible = True
			DisableUserInteraction()
			Return True
		End Function
		Private Sub NotifyEndArchivingOperation(ByVal isSaved As Boolean)
			Me.Invoke(CType(Function() AnonymousMethod4(isSaved), Action))
		End Sub
		
		Private Function AnonymousMethod4(ByVal isSaved As Boolean) As Boolean
			Me.pnlProgress.Visible = False
			Me.progressBarControl1.EditValue = 0
			EnableUserInteraction()
			Me.isOperationCanceled = False
			Me.archiveMakerThread = Nothing
			If isSaved Then
				System.Diagnostics.Process.Start("explorer.exe", String.Format("/select, {0}", Me.activeArchivePath))
			End If
			Return True
		End Function
		Private Sub DisableUserInteraction()
			Me.fileSystemViewer1.Enabled = False
			Me.simpleButton1.Enabled = False
			Me.groupControl2.Enabled = False
		End Sub
		Private Sub EnableUserInteraction()
			Me.fileSystemViewer1.Enabled = True
			Me.simpleButton1.Enabled = True
			Me.groupControl2.Enabled = True
		End Sub
		Private Function AskFileName() As String
			Dim result As String = String.Empty
			Using saveFileDialog As New SaveFileDialog()
				saveFileDialog.Filter = "Zip files (*.zip)|*.zip"
				If saveFileDialog.ShowDialog() = DialogResult.OK Then
					result = saveFileDialog.FileName
				End If
			End Using
			Return result
		End Function
		Private Sub OnCancelArchivingOperation(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton2.Click
			Me.isOperationCanceled = True
		End Sub

	End Class
	Public Class ArchiveParametersInfo
		Public Sub New(ByVal zipFileName As String, ByVal toZipFileNames As List(Of FileCollectionItem), ByVal password As String, ByVal encryptionType As EncryptionType)
			ZipFileName = zipFileName
			SourceFiles = toZipFileNames
			Password = password
			EncryptionType = encryptionType
		End Sub
		Private privateZipFileName As String
		Public Property ZipFileName() As String
			Get
				Return privateZipFileName
			End Get
			Private Set(ByVal value As String)
				privateZipFileName = value
			End Set
		End Property
		Private privateSourceFiles As List(Of FileCollectionItem)
		Public Property SourceFiles() As List(Of FileCollectionItem)
			Get
				Return privateSourceFiles
			End Get
			Private Set(ByVal value As List(Of FileCollectionItem))
				privateSourceFiles = value
			End Set
		End Property
		Private privatePassword As String
		Public Property Password() As String
			Get
				Return privatePassword
			End Get
			Private Set(ByVal value As String)
				privatePassword = value
			End Set
		End Property
		Private privateEncryptionType As EncryptionType
		Public Property EncryptionType() As EncryptionType
			Get
				Return privateEncryptionType
			End Get
			Private Set(ByVal value As EncryptionType)
				privateEncryptionType = value
			End Set
		End Property
	End Class
End Namespace

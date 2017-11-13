Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Docs.Text
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraEditors

Namespace DevExpress.Docs.Demos
	Partial Public Class EncodingDetection
		Inherits TutorialControlBase
		Private Const SRChooseFile As String = "Choose file..."
		Private encodingFiles() As String = { "english.txt", "german.txt", "spanish.txt", "russian.txt", "greek.txt", "chinese.txt", "japanese.txt"}

		Public Sub New()
			InitializeComponent()
			cbLanguage.Properties.Items.AddRange(encodingFiles)
			cbLanguage.Properties.Items.Add(SRChooseFile)
			cbLanguage.SelectedIndex = 0
		End Sub
		Private Sub LoadFile(ByVal fileName As String)
			LoadFileNoDetection(fileName, txtNoDetection)
			LoadFileWithDetection(fileName, txtDetection)
		End Sub
		Private Sub LoadFileNoDetection(ByVal path As String, ByVal where As MemoEdit)
			where.Text = File.ReadAllText(path)
		End Sub
		Private Sub LoadFileWithDetection(ByVal path As String, ByVal where As MemoEdit)
			Dim detector As New EncodingDetector()
			Dim bytes() As Byte = File.ReadAllBytes(path)
			Dim encoding As Encoding = detector.Detect(bytes)
			If encoding Is Nothing Then
				encoding = Encoding.Default
			End If
			lblEncoding.Text = encoding.EncodingName & " [" & encoding.BodyName & "]"
			where.Text = encoding.GetString(bytes)
		End Sub
		Private userDefinedFileName As String = String.Empty
		Private Sub comboBoxEdit1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbLanguage.SelectedIndexChanged
			Dim selectedIndex As Integer = cbLanguage.SelectedIndex
			If selectedIndex = -1 Then
				Return
			End If
			Dim fileName As String = cbLanguage.Properties.Items(selectedIndex).ToString()
			Dim fullFileName As String = String.Empty
			If (Not String.IsNullOrEmpty(userDefinedFileName)) Then
				fullFileName = userDefinedFileName
				Me.cbLanguage.Text = Path.GetFileName(userDefinedFileName)
			Else
				fullFileName = DemoUtils.GetRelativePath("EncodingFiles\" & fileName)
			End If
			If (Not String.IsNullOrEmpty(fullFileName)) Then
				LoadFile(fullFileName)
			End If
			Me.userDefinedFileName = String.Empty
		End Sub

		Private Sub btnLoadFile_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim ofDialog As New OpenFileDialog()
			ofDialog.Filter = "Text files (*.txt)|*.txt"
			If ofDialog.ShowDialog() <> DialogResult.OK Then
				Return
			End If
			Dim fileName As String = ofDialog.FileName
			LoadFile(fileName)
			cbLanguage.SelectedIndex = -1
		End Sub
		Private Sub cbLanguage_EditValueChanging(ByVal sender As Object, ByVal e As XtraEditors.Controls.ChangingEventArgs) Handles cbLanguage.EditValueChanging
			Me.userDefinedFileName = String.Empty
			If Convert.ToString(e.NewValue) = SRChooseFile Then
				Dim dialog As New OpenFileDialog()
				dialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
				If dialog.ShowDialog() <> DialogResult.OK Then
					e.Cancel = True
					Return
				End If
				Me.userDefinedFileName = dialog.FileName
			End If
		End Sub
	End Class
End Namespace

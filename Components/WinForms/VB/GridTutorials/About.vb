Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


Namespace DevExpress.XtraGrid.Demos.Tutorials
	Public Partial Class About
		Inherits TutorialControl
		Public Sub New()
			' This call is required by the Windows Form Designer.
			InitializeComponent()

			' TODO: Add any initialization after the InitializeComponent call
		End Sub

		Private Sub LoadAbout(ByVal fileName As String, ByVal rtb As RichTextBox)
			Dim aboutFile As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "\Data\" & fileName)
			Try
				If aboutFile <> "" Then
				rtb.LoadFile(aboutFile)
				End If
			Catch ex As Exception
				DevExpress.XtraEditors.XtraMessageBox.Show(Me, ex.Message, ex.Source)
			End Try
		End Sub

		Private Sub About_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			LoadAbout("XtraGridNewFeatures.rtf", rtbAboutNew)
			LoadAbout("XtraGridAbout.rtf", rtbAbout)
		End Sub
	End Class
End Namespace


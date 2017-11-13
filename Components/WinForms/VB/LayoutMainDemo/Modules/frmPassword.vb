Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace DevExpress.XtraLayout.Demos
	''' <summary>
	''' Summary description for frmPassword.
	''' </summary>
	Public Partial Class frmPassword
		Inherits DevExpress.XtraEditors.XtraForm
		Public Sub New(ByVal r As Rectangle, ByVal restoreLayout As Boolean)
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
            Me.Left = r.Left + (r.Width - Me.Width) \ 2
            Me.Top = r.Top + (r.Height - Me.Height) \ 2
			If restoreLayout Then
			Me.RestoreLayout()
			End If
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub
		Public Shared LayoutFileName As String = "frmPasswordLayout.xml"
		Private Sub sbCustomization_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbCustomization.Click
			layoutControl1.ShowCustomizationForm()
		End Sub

		Private Sub RestoreLayout()
			If System.IO.File.Exists(LayoutFileName) Then
				layoutControl1.RestoreLayoutFromXml(LayoutFileName)
			End If
		End Sub

		Public Sub SaveLayout()
			layoutControl1.SaveLayoutToXml(LayoutFileName)
		End Sub
	End Class
End Namespace

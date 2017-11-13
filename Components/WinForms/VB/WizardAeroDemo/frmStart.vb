Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.Utils.Drawing.Helpers

Namespace DevExpress.XtraWizard.Demos
	Partial Public Class frmStart
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
			For Each cnt As SkinContainer In SkinManager.Default.Skins
				listBoxControl1.Items.Add(cnt.SkinName)
			Next cnt
			listBoxControl1.SelectedItem = DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveSkinName
			If NativeVista.IsVista Then
				checkEdit1.Checked = True
			Else
				checkEdit1.Enabled = False
			End If
		End Sub

		Public ReadOnly Property SelectedSkinName() As String
			Get
				Return listBoxControl1.SelectedItem.ToString()
			End Get
		End Property
		Public ReadOnly Property AllowNativeVista() As Boolean
			Get
				Return checkEdit1.Checked
			End Get
		End Property

		Private Sub listBoxControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles listBoxControl1.SelectedIndexChanged
			DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(SelectedSkinName)
		End Sub

		Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEdit1.CheckedChanged
			StylesAdjust(checkEdit1.Checked)
		End Sub

		Private Sub StylesAdjust(ByVal isAero As Boolean)
			listBoxControl1.Enabled = Not isAero
			If isAero Then
				DevExpress.LookAndFeel.UserLookAndFeel.Default.SetWindowsXPStyle()
			Else
				DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(SelectedSkinName)
			End If
		End Sub
	End Class
End Namespace

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

Namespace DevExpress.XtraWizard.Demos
	Partial Public Class frmStart
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
			For Each cnt As SkinContainer In SkinManager.Default.Skins
				listBoxControl1.Items.Add(cnt.SkinName)
			Next cnt
			listBoxControl1.SelectedItem = DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveSkinName
		End Sub

		Public ReadOnly Property SelectedSkinName() As String
			Get
				Return listBoxControl1.SelectedItem.ToString()
			End Get
		End Property
		Public ReadOnly Property AllowAnimation() As Boolean
			Get
				Return checkEdit1.Checked
			End Get
		End Property
		Public ReadOnly Property AllowSkin4Form() As Boolean
			Get
				Return checkEdit2.Checked
			End Get
		End Property
		Public ReadOnly Property WizardStyle() As WizardStyle
			Get
				Return WizardStyle.Wizard97
			End Get
		End Property

		Private Sub listBoxControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles listBoxControl1.SelectedIndexChanged
			DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(SelectedSkinName)
		End Sub
	End Class
End Namespace

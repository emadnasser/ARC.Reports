Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraSpellChecker.Demos
	''' <summary>
	''' Summary description for Employees.
	''' </summary>
	Partial Public Class CheckMemoEdit
		Inherits BaseTutorialControl
		Public Sub New()
			' This call is required by the Windows.Forms Form Designer.
			InitializeComponent()
			' TODO: Add any initialization after the InitForm call

		End Sub

		Protected Overrides Function GetActiveControl() As Control
			Return memoEdit1
		End Function
		Protected Sub OnEditControlKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles memoEdit1.KeyDown
			OnEditorKeyDown(sender, e)
		End Sub

		Private Sub CheckMemoEdit_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			spellChecker1.SpellingFormType = SpellingFormType.Word
		End Sub

		Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			spellChecker1.SpellCheckMode = If((TryCast(sender, CheckEdit)).Checked, SpellCheckMode.AsYouType, SpellCheckMode.OnDemand)
			If spellChecker1.SpellCheckMode = SpellCheckMode.AsYouType Then
				DoCheck()
			End If
		End Sub
	End Class
End Namespace

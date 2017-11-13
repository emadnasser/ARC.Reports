Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraSpellChecker
Imports DevExpress.XtraEditors
Imports DevExpress.Utils


Namespace DevExpress.XtraSpellChecker.Demos
	Partial Public Class MultipleEditors
		Inherits DevExpress.XtraSpellChecker.Demos.BaseTutorialControl
		Public Sub New()
			' This call is required by the Windows Form Designer.
			InitializeComponent()

			' TODO: Add any initialization after the InitializeComponent call
		End Sub

		Private Sub MultipleEditors_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			picPhoto.Image = ResourceImageHelper.CreateImageFromResources("nancy.png", System.Reflection.Assembly.GetExecutingAssembly())
		End Sub

		Protected Overrides Function ProcessDialogKey(ByVal keyData As Keys) As Boolean
			If keyData = Keys.F7 AndAlso Control.ModifierKeys = Keys.None Then
				DoCheck()
			End If
			Return MyBase.ProcessDialogKey(keyData)
		End Function
		Protected Overrides Sub DoCheck()
			spellChecker1.CheckContainer()
		End Sub
		Protected Overrides Sub OnCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim isChecked As Boolean = (TryCast(sender, CheckEdit)).Checked
			spellChecker1.SpellCheckMode = If(isChecked, SpellCheckMode.AsYouType, SpellCheckMode.OnDemand)
			btnCheckSpelling.Enabled = Not isChecked
		End Sub
	End Class
End Namespace

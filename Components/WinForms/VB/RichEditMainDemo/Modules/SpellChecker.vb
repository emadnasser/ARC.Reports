Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports System.Globalization
Imports DevExpress.XtraSpellChecker
Imports DevExpress.XtraSpellChecker.Native
Imports DevExpress.XtraSpellChecker.Parser
Imports DevExpress.XtraRichEdit.SpellChecker

Namespace DevExpress.XtraRichEdit.Demos
	Partial Public Class SpellCheckerModule
		Inherits DevExpress.XtraRichEdit.Demos.TutorialControl
		Public Sub New()
			InitializeComponent()
            RtfLoadHelper.Load("SpellChecker.rtf", richEditControl)
            CType(New RichEditDemoExceptionsHandler(richEditControl), RichEditDemoExceptionsHandler).Install()
		End Sub

		Public Overrides ReadOnly Property PrintingRichEditControl() As RichEditControl
			Get
				Return richEditControl
			End Get
		End Property

		Private Sub SpellCheckerModule_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			If DesignMode Then
				Return
			End If

			SpellCheckerHelper.AddDictionaries(sharedDictionaryStorage1)

			If checkEdit1.Checked Then
				spellChecker1.SpellCheckMode = SpellCheckMode.AsYouType
			Else
				spellChecker1.SpellCheckMode = SpellCheckMode.OnDemand
			End If
		End Sub
		Protected Overrides Sub DoShow()
			MyBase.DoShow()
			richEditControl.Focus()
		End Sub
		Private Sub checkSpellingItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles checkSpellingItem.ItemClick
			spellChecker1.Check(richEditControl)
		End Sub
		Private Sub richEditControl_ReadOnlyChanged(ByVal sender As Object, ByVal e As EventArgs) Handles richEditControl.ReadOnlyChanged
			Me.checkSpellingItem.Enabled = Not richEditControl.ReadOnly
		End Sub
		Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEdit1.CheckedChanged
			If checkEdit1.Checked Then
				spellChecker1.SpellCheckMode = SpellCheckMode.AsYouType
			Else
				spellChecker1.SpellCheckMode = SpellCheckMode.OnDemand
			End If
		End Sub
	End Class
End Namespace

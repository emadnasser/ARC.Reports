Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraSpellChecker.Rules
Imports System.Collections.Generic
Imports DevExpress.XtraBars

Namespace DevExpress.XtraSpellChecker.Demos
	''' <summary>
	''' Summary description for Employees.
	''' </summary>
	Partial Public Class CheckRichTextBox
		Inherits BaseTutorialControl
		Public Sub New()
			' This call is required by the Windows.Forms Form Designer.
			InitializeComponent()
			' TODO: Add any initialization after the InitForm call

		End Sub

		Protected Overrides Function GetActiveControl() As Control
			Return richTextBox1
		End Function
		Protected Sub OnEditControlKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles richTextBox1.KeyDown
			OnEditorKeyDown(sender, e)
		End Sub

		Private Sub barManager1_QueryShowPopupMenu(ByVal sender As Object, ByVal e As DevExpress.XtraBars.QueryShowPopupMenuEventArgs) Handles barManager1.QueryShowPopupMenu
			Dim position As Point = e.Control.PointToClient(e.Position)
			Dim [error] As SpellCheckErrorBase = spellChecker1.CalcError(position)
			e.Cancel = [error] Is Nothing
			Dim commands As List(Of SpellCheckerCommand) = spellChecker1.GetCommandsByError([error])
			If commands IsNot Nothing Then
				popupMenu1.ItemLinks.Clear()
				For Each command As SpellCheckerCommand In commands
					Dim item As New BarButtonItem(barManager1, command.Caption)
					item.Enabled = command.Enabled
					item.Tag = command
					AddHandler item.ItemClick, AddressOf OnPopupMenuItemClick
					popupMenu1.ItemLinks.Add(item)
				Next command
			End If
		End Sub
		Protected Overrides Sub OnCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			MyBase.OnCheckedChanged(sender, e)
			If spellChecker1.SpellCheckMode = SpellCheckMode.AsYouType Then
				barManager1.SetPopupContextMenu(richTextBox1, popupMenu1)
			Else
				barManager1.SetPopupContextMenu(richTextBox1, Nothing)
			End If
		End Sub


		Private Sub OnPopupMenuItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			TryCast(e.Item.Tag, SpellCheckerCommand).DoCommand()
		End Sub
	End Class
End Namespace

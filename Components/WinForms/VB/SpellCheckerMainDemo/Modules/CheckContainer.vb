Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Data.OleDb
Imports System.Windows.Forms
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Text
Imports System.Collections.Generic


Namespace DevExpress.XtraSpellChecker.Demos
	''' <summary>
	''' Summary description for Employees.
	''' </summary>
	Partial Public Class CheckContainer
		Inherits BaseTutorialControl
		Private inplaceEditor As BaseEdit
		Public Sub New()
			' This call is required by the Windows.Forms Form Designer.
			InitializeComponent()

			Dim path As String = DemoUtils.GetRelativePath("nwind.mdb")
			If path.Length > 0 Then
				DemoUtils.SetConnectionString(oleDbEmployeesConnection, path)
			End If
			' TODO: Add any initialization after the InitForm call

		End Sub

		Protected Sub OnEditControlKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gridControl1.EditorKeyDown
			OnEditorKeyDown(sender, e)
		End Sub
		Private Sub CheckContainer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			daEmployees.Fill(dsEmployees1)
			DoMistakes(dsEmployees1.Employees)
		End Sub
		Protected Overrides Function GetActiveControl() As Control
			Return If(gridControl1.FocusedView.IsEditing, gridControl1.FocusedView.ActiveEditor, ActiveControl)
		End Function
		Private Sub gridView1_ShownEditor(ByVal sender As Object, ByVal e As EventArgs) Handles gridView1.ShownEditor
			Dim activeEditor As BaseEdit = (CType(sender, GridView)).ActiveEditor
			If (Not spellChecker1.CanCheck(activeEditor)) Then
				Return
			End If
			spellChecker1.SetShowSpellCheckMenu(activeEditor, True)
			If spellChecker1.SpellCheckMode = SpellCheckMode.AsYouType AndAlso (Not Object.ReferenceEquals(activeEditor, Me.inplaceEditor)) Then
				DoCheck()
			End If
			Me.inplaceEditor = activeEditor
		End Sub

		Private Sub gridView1_HiddenEditor(ByVal sender As Object, ByVal e As EventArgs) Handles gridView1.HiddenEditor
			'
		End Sub
		Private Sub DoMistakes(ByVal dataTable As DataTable)
			For Each row As DataRow In dataTable.Rows
				Dim text As New StringBuilder(row("Notes").ToString())
				Dim charSet As List(Of Char) = CreateCharSet(text)
				For i As Integer = text.Length - 1 To 0 Step -30
					If (Not Char.IsLetter(text(i))) Then
						Continue For
					End If
					Dim ch As Char = GetRandomChar(charSet)
					If Char.IsUpper(text(i)) Then
						ch = Char.ToUpper(ch)
					End If
					If text(i) = ch Then
						text.Remove(i, 1)
					Else
						text(i) = ch
					End If
				Next i
				row("Notes") = text.ToString()
			Next row
		End Sub
		Private Function CreateCharSet(ByVal text As StringBuilder) As List(Of Char)
			Dim result As New List(Of Char)()
			Dim length As Integer = text.Length
			For i As Integer = 0 To length - 1
				Dim ch As Char = text(i)
				If (Not Char.IsLetter(ch)) Then
					Continue For
				End If
				ch = Char.ToLower(ch)
				Dim index As Integer = result.BinarySearch(ch)
				If index < 0 Then
					result.Insert((Not index), ch)
				End If
			Next i
			Return result
		End Function
		Private Function GetRandomChar(ByVal charSet As List(Of Char)) As Char
			Dim random As New Random(Environment.TickCount)
			Dim index As Integer = random.Next(0, charSet.Count - 1)
			Return charSet(index)
		End Function
	End Class
End Namespace

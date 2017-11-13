Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.Utils

Namespace DevExpress.XtraRichEdit.Demos.Forms
	Public Partial Class SelectProductForm
		Inherits PopupFormBase
		Public Sub New(ByVal list As List(Of String))
			Me.New()
			PopulateListBox(list)
		End Sub
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub PopulateListBox(ByVal list As List(Of String))
			Me.listBoxControl.Items.AddRange(list.ToArray())
			If list.Count > 0 Then
				Me.listBoxControl.SelectedIndex = 0
			End If
		End Sub
		Private Sub listBoxControl_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles listBoxControl.MouseClick
			If e.Button <> MouseButtons.Left OrElse Me.listBoxControl.SelectedIndex < 0 Then
				Return
			End If
			Dim rect As Rectangle = Me.listBoxControl.GetItemRectangle(Me.listBoxControl.SelectedIndex)
			If (Not rect.Contains(e.X, e.Y)) Then
				Return
			End If
			OnCommit()
		End Sub
		Protected Overrides Sub SetEditValue()
			SetEditValueCore(CStr(Me.listBoxControl.SelectedItem))
		End Sub
		Private Sub listBoxControl_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles listBoxControl.MouseMove
			Dim i As Integer = 0
			Do While i < Me.listBoxControl.ItemCount
				Dim rect As Rectangle = Me.listBoxControl.GetItemRectangle(i)
				If rect.Contains(e.X, e.Y) Then
					Me.listBoxControl.SelectedIndex = i
					Exit Do
				End If
				i += 1
			Loop
		End Sub
	End Class
End Namespace

Imports System.Collections
Imports System.ComponentModel

Namespace DevExpress.XtraNavBar.Demos
	''' <summary>
	''' Summary description for AddGroups.
	''' </summary>
	Partial Public Class AddGroups
		Inherits TutorialControl
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			For i As Integer = 0 To 2
				OnAddGroup()
			Next i
		End Sub

		'<button2>
		Private ReadOnly Property LastGroup() As NavBarGroup
			Get
				If navBarControl1.Groups.Count > 0 Then
					Return navBarControl1.Groups(navBarControl1.Groups.Count - 1)
				End If
				Return Nothing
			End Get
		End Property
		'</button2>


		'<button1>
		Private i As Integer = 0
		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			OnAddGroup()
		End Sub
		'</button1>

		'<button2>
		Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
			OnRemoveGroup()
		End Sub
		'</button2>

		Private Sub ChangeGroups()
			button2.Enabled = LastGroup IsNot Nothing
		End Sub
		Private Sub OnAddGroup()
			Dim group As DevExpress.XtraNavBar.NavBarGroup = navBarControl1.Groups.Add()
			group.Caption = "Group " & (i).ToString()
			i += 1
			ChangeGroups()
		End Sub
		Private Sub OnRemoveGroup()
			If LastGroup IsNot Nothing Then
				LastGroup.Dispose()
			End If
			ChangeGroups()
		End Sub
	End Class
End Namespace

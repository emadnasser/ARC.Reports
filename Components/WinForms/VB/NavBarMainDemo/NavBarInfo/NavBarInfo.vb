Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraNavBar.Demos
	''' <summary>
	''' Summary description for NavBarInfo.
	''' </summary>
	Partial Public Class NavBarInfo
		Inherits TutorialControl
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim btn As SimpleButton = TryCast(sender, SimpleButton)
			Dim frm As New XtraForm()
			Dim mEdit As New MemoEdit()
			mEdit.Dock = DockStyle.Fill
			mEdit.Text = GetNavBarInfo(navBarControl1)
			mEdit.Select(0, 0)
			frm.Controls.Add(mEdit)
			frm.Location = btn.PointToScreen(New Point(btn.Width \ 2, btn.Height \ 2))
			frm.StartPosition = FormStartPosition.Manual
			frm.FormBorderStyle = FormBorderStyle.SizableToolWindow
			frm.Text = "NavBar Control"
			frm.ShowDialog()
		End Sub

		'<button1>
		Private Function GetNavBarInfo(ByVal nbc As DevExpress.XtraNavBar.NavBarControl) As String
			Dim s As String = "Items:" & vbCrLf
			For i As Integer = 0 To nbc.Items.Count - 1
				s &= " Item" & i.ToString() & ": " & nbc.Items(i).Caption & vbCrLf
			Next i
			s &= vbCrLf & "Groups:" & vbCrLf
			For i As Integer = 0 To nbc.Groups.Count - 1
				s &= "  Group" & i.ToString() & ": " & nbc.Groups(i).Caption & vbCrLf
				s &= "    ItemLinks:" & vbCrLf
				For j As Integer = 0 To nbc.Groups(i).ItemLinks.Count - 1
					s &= "      Link" & j.ToString() & ": " & nbc.Groups(i).ItemLinks(j).Caption & vbCrLf
				Next j
			Next i
			Return s
		End Function
		'</button1>
	End Class
End Namespace

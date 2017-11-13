Imports System.Collections
Imports System.ComponentModel

Namespace DevExpress.XtraNavBar.Demos
	''' <summary>
	''' Summary description for HitInfo.
	''' </summary>
	Partial Public Class HitInfo
		Inherits TutorialControl
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			ShowHitInfo(Nothing, Point.Empty)
			lbClick.Text = "None"
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		Private Sub ShowHitInfo(ByVal hi As DevExpress.XtraNavBar.NavBarHitInfo, ByVal p As Point)
			Dim s As String = "None"
			If hi Is Nothing Then
				lbLink.Text = s
				lbGroup.Text = lbLink.Text
				lbHitTest.Text = lbGroup.Text
			Else
				lbHitTest.Text = hi.HitTest.ToString()
				lbGroup.Text = If(hi.Group IsNot Nothing, hi.Group.Caption, s)
				lbLink.Text = If(hi.Link IsNot Nothing, hi.Link.Caption, s)
			End If
			If Not p.Equals(Point.Empty) Then
				lbPoint.Text = "X = " & p.X.ToString() & "; Y = " & p.Y.ToString()
			Else
				lbPoint.Text = ""
			End If
		End Sub

		Private Sub navBarControl1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles navBarControl1.MouseMove
			Dim p As New Point(e.X, e.Y)
			ShowHitInfo(navBarControl1.CalcHitInfo(p), p)
		End Sub

		Private Sub navBarControl1_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles navBarControl1.MouseLeave
			ShowHitInfo(Nothing, Point.Empty)
		End Sub

		Private Sub navBarControl1_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles navBarControl1.LinkClicked
			lbClick.Text = "Group (" & e.Link.Group.Caption & ")" & vbCrLf & "Item (" & e.Link.Caption & ")"
		End Sub
	End Class
End Namespace

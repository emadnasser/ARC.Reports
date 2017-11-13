Imports System.Collections
Imports System.ComponentModel

Namespace DevExpress.XtraNavBar.Demos
	''' <summary>
	''' Summary description for CustomDraw.
	''' </summary>
	Partial Public Class CustomDraw
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

		Private fontHeader As New Font("Verdana", 8, FontStyle.Bold)
		Private fontRow As New Font("Verdana", 8)

		'<checkBox6>
		Private Sub navBarGroup3_CalcGroupClientHeight(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarCalcGroupClientHeightEventArgs) Handles navBarGroup3.CalcGroupClientHeight
			If Not checkBox6.Checked Then
				Return
			End If
			e.Height = fontHeader.Height * 4
		End Sub
		'</checkBox6>

		'<checkBox4>
		Private Sub navBarControl1_CustomDrawGroupClientForeground(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.ViewInfo.CustomDrawObjectEventArgs) Handles navBarControl1.CustomDrawGroupClientForeground
			If Not checkBox4.Checked Then
				Return
			End If
			Dim info As DevExpress.XtraNavBar.ViewInfo.NavGroupClientInfoArgs = TryCast(e.ObjectInfo, DevExpress.XtraNavBar.ViewInfo.NavGroupClientInfoArgs)
			If info.Group.Equals(navBarGroup3) Then
				Dim r As Rectangle = e.RealBounds
				r.Inflate(-10, -10)
				e.ObjectInfo.Graphics.DrawString("My Documents", fontHeader, SystemBrushes.WindowText, r)
				r.Y += fontHeader.Height
				r.Height -= fontHeader.Height
				e.ObjectInfo.Graphics.DrawString("System Folder", fontRow, SystemBrushes.WindowText, r)
				e.Handled = True
			End If
		End Sub
		'</checkBox4>
		'<checkBox2>
		Private Sub navBarControl1_CustomDrawGroupCaption(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.ViewInfo.CustomDrawNavBarElementEventArgs) Handles navBarControl1.CustomDrawGroupCaption
			If Not checkBox2.Checked Then
				Return
			End If
			If e.ObjectInfo.State <> DevExpress.Utils.Drawing.ObjectState.Normal Then
				e.Image = imageList1.Images(5)
				e.Caption = "<" & e.Caption & ">"
			End If
			If e.ObjectInfo.State = DevExpress.Utils.Drawing.ObjectState.Pressed Then
				e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Bold)
			End If
		End Sub
		'</checkBox2>

		'<checkBox5>
		Private Sub navBarControl1_CustomDrawLink(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.ViewInfo.CustomDrawNavBarElementEventArgs) Handles navBarControl1.CustomDrawLink
			If Not checkBox5.Checked Then
				Return
			End If
			If e.ObjectInfo.State <> DevExpress.Utils.Drawing.ObjectState.Normal Then
				e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Bold)
				Dim r As Rectangle = (CType((CType(e, DevExpress.XtraNavBar.ViewInfo.CustomDrawObjectEventArgs)).ObjectInfo, DevExpress.XtraNavBar.ViewInfo.NavLinkInfoArgs)).CaptionRectangle
				r.Width += 20
				CType((CType(e, DevExpress.XtraNavBar.ViewInfo.CustomDrawObjectEventArgs)).ObjectInfo, DevExpress.XtraNavBar.ViewInfo.NavLinkInfoArgs).CaptionRectangle = r
			End If
		End Sub
		'</checkBox5>
		'<checkBox3>
		Private Sub navBarControl1_CustomDrawGroupClientBackground(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.ViewInfo.CustomDrawObjectEventArgs) Handles navBarControl1.CustomDrawGroupClientBackground
			If Not checkBox3.Checked Then
				Return
			End If
			Dim info As DevExpress.XtraNavBar.ViewInfo.NavGroupClientInfoArgs = TryCast(e.ObjectInfo, DevExpress.XtraNavBar.ViewInfo.NavGroupClientInfoArgs)
			If info.Group.Equals(navBarGroup3) Then
				e.Appearance.ForeColor = Color.Black
				e.Appearance.BackColor = Color.FromArgb(192, 255, 192)
				e.Appearance.BackColor2 = Color.FromArgb(0, 192, 0)
			End If
		End Sub
		'</checkBox3>
		'<checkBox1>
		Private Sub navBarControl1_CustomDrawBackground(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.ViewInfo.CustomDrawObjectEventArgs) Handles navBarControl1.CustomDrawBackground
			If checkBox1.Checked Then
				e.Appearance.ForeColor = Color.Black
				e.Appearance.BackColor = Color.Navy
				e.Appearance.BackColor2 = Color.FromArgb(192, 192, 255)
			Else
				e.Appearance.Reset()
			End If
		End Sub
		'</checkBox1>

		Private Sub checkBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged, checkBox2.CheckedChanged, checkBox3.CheckedChanged, checkBox4.CheckedChanged, checkBox5.CheckedChanged, checkBox6.CheckedChanged
			navBarControl1.LayoutChanged()
		End Sub
	End Class
End Namespace

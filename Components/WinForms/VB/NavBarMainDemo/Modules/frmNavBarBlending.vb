Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.Utils

Namespace DevExpress.XtraNavBar.Demos
	Partial Public Class frmNavBarBlending
		Inherits TutorialControl
		Public Sub New()
			InitializeComponent()
			ctrlAlphaBlending1.StyleInit(navBarControl1.Appearance.Background, "NavBar Background", navBarControl1)
			ctrlAlphaBlending2.StyleInit(navBarGroup1.AppearanceBackground, "'My Documents' Group Background", navBarGroup1)
			ctrlAlphaBlending3.StyleInit(navBarGroup2.AppearanceBackground, "'Other Places' Group Background", navBarGroup2)
			ctrlAlphaBlending4.StyleInit(navBarControl1.Appearance.GroupBackground, "'Details' Group Background", navBarGroup3)
		End Sub

		Private fontHeader As New Font("Verdana", 8, FontStyle.Bold)
		Private fontRow As New Font("Verdana", 8)
		Private Sub navBarGroup3_CalcGroupClientHeight(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarCalcGroupClientHeightEventArgs) Handles navBarGroup3.CalcGroupClientHeight
			e.Height = fontHeader.Height * 4
		End Sub

		Private Sub navBarControl1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles navBarControl1.MouseMove
			Dim hi As NavBarHitInfo = navBarControl1.CalcHitInfo(New Point(e.X, e.Y))
			If hi.InGroupCaption AndAlso hi.Group.Caption = "Details" Then
				navBarGroup3.LargeImageIndex = 3
			Else
				navBarGroup3.LargeImageIndex = 2
			End If
		End Sub

		Private Sub navBarControl1_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles navBarControl1.MouseLeave
			navBarGroup3.LargeImageIndex = 2
		End Sub



		Private Sub navBarControl1_CustomDrawGroupClientForeground(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.ViewInfo.CustomDrawObjectEventArgs) Handles navBarControl1.CustomDrawGroupClientForeground
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
	End Class
End Namespace

Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms

Namespace DevExpress.XtraRichEdit.Demos
	Partial Public Class HyperlinksModule
		Inherits DevExpress.XtraRichEdit.Demos.TutorialControl
		Public Sub New()
			InitializeComponent()

            RtfLoadHelper.Load("Hyperlinks.rtf", richEditControl)
            CType(New RichEditDemoExceptionsHandler(richEditControl), RichEditDemoExceptionsHandler).Install()
			UpdateBookmarkVisibility()
			UpdateBookmarkColor()
		End Sub

		Private Sub chkShowBookmarks_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkShowBookmarks.CheckedChanged
			UpdateBookmarkVisibility()
		End Sub
		Private Sub colorEdit1_ColorChanged(ByVal sender As Object, ByVal e As EventArgs) Handles colorEdit1.ColorChanged
			UpdateBookmarkColor()
		End Sub
		Private Sub UpdateBookmarkVisibility()
			If chkShowBookmarks.Checked Then
				Me.richEditControl.Options.Bookmarks.Visibility = RichEditBookmarkVisibility.Visible
			Else
				Me.richEditControl.Options.Bookmarks.Visibility = RichEditBookmarkVisibility.Hidden
			End If
		End Sub
		Private Sub UpdateBookmarkColor()
			Me.richEditControl.Options.Bookmarks.Color = colorEdit1.Color
		End Sub
		Private Sub chkShowToolTip_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkShowToolTip.CheckedChanged
			Me.richEditControl.Options.Hyperlinks.ShowToolTip = chkShowToolTip.Checked
		End Sub
		Private Sub chkCtrl_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkCtrl.CheckedChanged
			If chkCtrl.Checked Then
				Me.richEditControl.Options.Hyperlinks.ModifierKeys = Me.richEditControl.Options.Hyperlinks.ModifierKeys Or Keys.Control
			Else
				Me.richEditControl.Options.Hyperlinks.ModifierKeys = Me.richEditControl.Options.Hyperlinks.ModifierKeys And Not Keys.Control
			End If
		End Sub
		Private Sub chkAlt_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAlt.CheckedChanged
			If chkAlt.Checked Then
				Me.richEditControl.Options.Hyperlinks.ModifierKeys = Me.richEditControl.Options.Hyperlinks.ModifierKeys Or Keys.Alt
			Else
				Me.richEditControl.Options.Hyperlinks.ModifierKeys = Me.richEditControl.Options.Hyperlinks.ModifierKeys And Not Keys.Alt
			End If
		End Sub
		Private Sub chkShift_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkShift.CheckedChanged
			If chkShift.Checked Then
				Me.richEditControl.Options.Hyperlinks.ModifierKeys = Me.richEditControl.Options.Hyperlinks.ModifierKeys Or Keys.Shift
			Else
				Me.richEditControl.Options.Hyperlinks.ModifierKeys = Me.richEditControl.Options.Hyperlinks.ModifierKeys And Not Keys.Shift
			End If
		End Sub
	End Class
End Namespace

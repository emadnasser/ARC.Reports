Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports DevExpress.Web.Demos
Imports DevExpress.XtraRichEdit

Partial Public Class EditingFeatures_HyperlinksAndBookmarks
	Inherits OfficeDemoPage
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			RichEditDemoUtils.HideFileTab(DemoRichEdit)
			DemoRichEdit.Open(Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, "Hyperlinks.rtf"))
		End If

		DemoRichEdit.Settings.Bookmarks.Visibility = If(chShowBookmarks.Checked, RichEditBookmarkVisibility.Visible, RichEditBookmarkVisibility.Hidden)
		DemoRichEdit.Settings.Bookmarks.Color = ColorEdit.Color
	End Sub
	Protected Sub DemoRichEdit_PreRender(ByVal sender As Object, ByVal e As EventArgs)
		DemoRichEdit.Focus()
	End Sub
End Class

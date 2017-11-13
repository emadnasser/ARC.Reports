Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports DevExpress.Web.Demos

Partial Public Class RichEditDemoFindAndReplace
	Inherits OfficeDemoPage
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			RichEditDemoUtils.HideFileTab(DemoRichEdit)
			DemoRichEdit.Open(Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, "TextWithImages.rtf"))
		End If
	End Sub
End Class

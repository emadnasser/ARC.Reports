Imports Microsoft.VisualBasic
Imports System
Imports System.IO

Partial Public Class RichEditDemoLoadAndSave
	Inherits OfficeDemoPage
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			DemoRichEdit.WorkDirectory = DirectoryManagmentUtils.DocumentBrowsingFolderPath
		End If
		If DemoRichEdit.WorkDirectory <> DirectoryManagmentUtils.DocumentBrowsingFolderPath Then
			DirectoryManagmentUtils.AssertTimeout()
		End If
	End Sub
	Protected Sub DemoRichEdit_PreRender(ByVal sender As Object, ByVal e As EventArgs)
		DemoRichEdit.Focus()
	End Sub
End Class

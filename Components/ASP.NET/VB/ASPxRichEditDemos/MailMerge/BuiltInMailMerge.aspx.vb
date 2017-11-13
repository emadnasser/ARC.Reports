Imports Microsoft.VisualBasic
Imports System
Imports System.IO

Partial Public Class RichEditDemoBuiltInMailMerge
	Inherits OfficeDemoPage
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			DemoRichEdit.WorkDirectory = Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, "MailMergeResults")
			DemoRichEdit.Open(Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, "MailMergeTemplate.docx"))
			DemoRichEdit.ViewMergedData = True
		End If
	End Sub
	Protected Sub DemoRichEdit_PreRender(ByVal sender As Object, ByVal e As EventArgs)
		DemoRichEdit.Focus()
	End Sub
End Class

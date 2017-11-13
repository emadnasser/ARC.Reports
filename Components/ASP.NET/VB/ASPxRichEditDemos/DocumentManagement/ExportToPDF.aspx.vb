Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports DevExpress.Web.Internal
Imports DevExpress.Web.Demos

Partial Public Class RichEditDemoExportToPDF
	Inherits OfficeDemoPage
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			RichEditDemoUtils.HideFileTab(DemoRichEdit)
			DemoRichEdit.Open(Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, "pdfExample.docx"))
		End If
	End Sub
	Protected Sub ExportButton_Click(ByVal sender As Object, ByVal e As EventArgs)
		Using stream As New MemoryStream()
			DemoRichEdit.ExportToPdf(stream)
			HttpUtils.WriteFileToResponse(Me.Page, stream, "ExportedDocument", True, "pdf")
		End Using
	End Sub
	Protected Sub DemoRichEdit_PreRender(ByVal sender As Object, ByVal e As EventArgs)
		DemoRichEdit.Focus()
	End Sub
End Class

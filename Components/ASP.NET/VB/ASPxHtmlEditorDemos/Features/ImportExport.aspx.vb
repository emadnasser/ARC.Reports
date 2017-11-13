Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Partial Public Class Features_ImportExport
	Inherits Page
	Private Const DocumentUrl As String = "~/Content/Demo/SampleImportDocument.rtf"
	Private Const ContentFolder As String = "~/UploadFiles/Imported"

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			HtmlEditorUtils.SetHtml(Me, DemoHtmlEditor, "Features/ImportExport.html")
			DocumentHyperLink.NavigateUrl = DocumentUrl
			DocumentHyperLink.Text = DocumentUrl
			ContentFolderLabel.Text = ContentFolder
		End If
	End Sub
	Protected Sub ImportButton_Click(ByVal sender As Object, ByVal e As EventArgs)
		DemoHtmlEditor.Import(DocumentUrl, ImportStylesComboBox.Value.ToString() = "inline", ContentFolder)
	End Sub
End Class

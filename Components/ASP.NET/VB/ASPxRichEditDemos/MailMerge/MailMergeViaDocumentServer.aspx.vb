Imports Microsoft.VisualBasic
Imports DevExpress.Web.Office
Imports DevExpress.XtraRichEdit
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.IO
Imports System.Linq

Partial Public Class RichEditDemoMailMergeViaDocumentServer
	Inherits OfficeDemoPage
	Private Const documentId As String = "mailMergeDocId"

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsCallback) Then
			Dim documentServer As New RichEditDocumentServer()
			documentServer.LoadDocument(Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, "MailMergeTemplate.docx"))
			documentServer.Options.MailMerge.DataSource = GetData()

			Using stream As New MemoryStream()
				documentServer.MailMerge(stream, DocumentFormat.OpenXml)
				stream.Position = 0
				DocumentManager.CloseDocument(documentId)
				DemoRichEdit.Open(documentId, DocumentFormat.OpenXml, Function() stream)
			End Using
		End If
	End Sub
	Private Function GetData() As IEnumerable(Of Employees)
		Dim context = New NorthwindDataContextExt()
		Return context.Employees.Where(Function(employee) employee.City = cmbCity.Value.ToString())
	End Function
End Class

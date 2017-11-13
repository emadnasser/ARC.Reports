Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports DevExpress.Spreadsheet
Imports DevExpress.Web.Demos

Partial Public Class ServerSideFunctionality_CellValueChanged
	Inherits OfficeDemoPage
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not Page.IsPostBack) Then
			Dim templatePath = Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, "CellValueChanged.xlsx")
			Dim documentId = DocumentIdGenerator.GenerateDocumentId()
			Spreadsheet.Open(documentId, DocumentFormat.Xlsx, Function() File.ReadAllBytes(templatePath))
		End If
	End Sub
End Class

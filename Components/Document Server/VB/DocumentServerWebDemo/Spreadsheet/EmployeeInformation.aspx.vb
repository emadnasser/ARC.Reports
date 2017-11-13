Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Spreadsheet
Imports System.Net
Imports DevExpress.Web
Imports System.Web.UI.HtmlControls
Imports DevExpress.Spreadsheet.Demos
Imports System.Globalization

Partial Public Class Spreadsheet_EmployeeInformation
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim book As IWorkbook = GenerateBook()
		previewControl.Workbook = book
		If previewControl.RenderSpreadsheetPreview() Then
			Return
		End If
	End Sub
	Private Function GenerateBook() As IWorkbook
		Dim generator As New EmployeeInformationDocumentGenerator(New CultureInfo("en-US"))
		Dim path As String = Page.MapPath("~/App_Data/EmployeeInformation_template.xlsx")
		Return generator.Generate(path)
	End Function
	Protected Sub OnDocumentDownloaderRequestWorkbook(ByVal sender As Object, ByVal args As RequestWorkbookEventArgs)
		args.Workbook = GenerateBook()
	End Sub
End Class

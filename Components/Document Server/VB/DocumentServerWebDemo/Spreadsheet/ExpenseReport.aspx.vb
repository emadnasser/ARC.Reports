Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Net
Imports DevExpress.Spreadsheet
Imports DevExpress.Docs.Demos
Imports System.IO

Partial Public Class Spreadsheet_ExpenseReport
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Me.previewControl.Workbook = CreateWorkbook()
		If Me.previewControl.CanShowPreview() Then
			Me.previewControl.RenderSpreadsheetPreview()
		End If
	End Sub
	Private Function CreateWorkbook() As IWorkbook
		Dim example As New ExpenseReportDocumentGenerator()
		Return example.Generate()
	End Function
	Protected Sub OnDocumentDownloaderRequestWorkbook(ByVal sender As Object, ByVal args As RequestWorkbookEventArgs)
		args.Workbook = CreateWorkbook()
	End Sub
End Class

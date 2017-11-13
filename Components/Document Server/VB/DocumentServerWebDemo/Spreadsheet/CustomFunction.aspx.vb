Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Docs.Demos
Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Demos
Imports DevExpress.XtraReports.UI
Imports System.Globalization

Partial Public Class Spreadsheet_CustomFunction
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If Me.previewControl.CanShowPreview() Then
			RefreshPreview()
			Return
		End If
		Me.previewControl.Workbook = CreateWorkbook()
	End Sub
	Private Function CreateWorkbook() As IWorkbook
		Dim example As New CustomFunctionDocumentGenerator(New CultureInfo("en-US"))
		Return example.Generate()
	End Function
	Private Sub RefreshPreview()
		Dim book As IWorkbook = CreateWorkbook()
		Me.previewControl.Workbook = book
		Me.previewControl.RenderSpreadsheetPreview()
	End Sub
	Protected Sub OnDocumentDownloaderRequestWorkbook(ByVal sender As Object, ByVal args As RequestWorkbookEventArgs)
		args.Workbook = CreateWorkbook()
	End Sub
End Class

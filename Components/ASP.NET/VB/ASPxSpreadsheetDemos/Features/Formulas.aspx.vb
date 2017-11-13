Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Web.UI
Imports DevExpress.Spreadsheet
Imports DevExpress.Web.Demos

Partial Public Class Features_Formulas
	Inherits OfficeDemoPage
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		SpreadsheetDemoUtils.HideFileTab(Spreadsheet)
		If (Not Page.IsPostBack) Then
			Dim filePath = Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, "SampleDocuments\\OrderAccounting.xlsx")
			Spreadsheet.Open(filePath)
			Spreadsheet.Document.Worksheets(0).Cells("G3").Select()

			If Spreadsheet.Document.Worksheets.Count = 1 Then
				Spreadsheet.Document.Worksheets.Add()
			End If
			Spreadsheet.Document.Worksheets.ActiveWorksheet = Spreadsheet.Document.Worksheets(0)
			SpreadsheetInvoiceHelper.PrepareSpreadsheet(Spreadsheet, 1)
			Spreadsheet.Document.History.Clear()
		End If
	End Sub
End Class

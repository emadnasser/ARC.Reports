Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraSpreadsheet.Services
Imports DevExpress.XtraSpreadsheet.Services.Implementation

Partial Public Class Spreadsheet_BreakevenAnalysis
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Me.previewControl.Workbook = CreateWorkbook()
		If Me.previewControl.CanShowPreview() Then
			Me.previewControl.RenderSpreadsheetPreview()
		End If
	End Sub
	Private Function CreateWorkbook() As IWorkbook
		Dim workbook As IWorkbook = New Workbook()
		workbook.AddService(GetType(IChartControllerFactoryService), New ChartControllerFactoryService())
		workbook.AddService(GetType(IChartImageService), New ChartImageService())
		workbook.LoadDocument(MapPath("~/App_Data/BreakevenAnalysis.xlsx"))
		Return workbook
	End Function
	Protected Sub OnDocumentDownloaderRequestWorkbook(ByVal sender As Object, ByVal args As RequestWorkbookEventArgs)
		args.Workbook = CreateWorkbook()
	End Sub
End Class

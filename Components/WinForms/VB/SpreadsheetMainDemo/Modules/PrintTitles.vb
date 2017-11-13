Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports DevExpress.XtraSpreadsheet.Demos
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraSpreadsheet.Services
Imports DevExpress.XtraSpreadsheet.Commands

Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class PrintTitlesModule
		Inherits SpreadSheetTutorialControlBase
		Public Sub New()
			InitializeComponent()

			spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("PrintTitles_template.xlsx"), DocumentFormat.Xlsx)
			Me.spreadsheetPreview1.PreviewZoom = SpreadhsheetPreviewZoom.WholePage
			RefreshPreview()
		End Sub

		Private Sub spreadsheetControl1_ContentChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spreadsheetControl1.ContentChanged
			RefreshPreview()
			xtraTabControl1.SelectedTabPageIndex = 1
		End Sub

		Private Sub btnPageSetup_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPageSetup.Click
			xtraTabControl1.SelectedTabPageIndex = 0

			Dim service As ISpreadsheetCommandFactoryService = CType(spreadsheetControl1.GetService(GetType(ISpreadsheetCommandFactoryService)), ISpreadsheetCommandFactoryService)
			Dim command As SpreadsheetCommand = service.CreateCommand(SpreadsheetCommandId.PageSetupSheet)
			command.ForceExecute(command.CreateDefaultCommandUIState())
		End Sub

		Private Sub RefreshPreview()
			Using ms As New MemoryStream()
				spreadsheetControl1.SaveDocument(ms, DocumentFormat.Xlsx)
				ms.Position = 0
				Dim workbook As New Workbook()
				workbook.LoadDocument(ms, DocumentFormat.Xlsx)
				Me.spreadsheetPreview1.Workbook = workbook
				Me.spreadsheetPreview1.UpdatePreview()
			End Using
		End Sub

		Private Sub btnWholePage_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnWholePage.Click
			Me.spreadsheetPreview1.PreviewZoom = SpreadhsheetPreviewZoom.WholePage
		End Sub

		Private Sub btnManyPages_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnManyPages.Click
			Me.spreadsheetPreview1.PreviewZoom = SpreadhsheetPreviewZoom.TwoPages
		End Sub
	End Class
End Namespace

Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports DevExpress.XtraSpreadsheet.Demos
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraSpreadsheet.Services
Imports DevExpress.XtraSpreadsheet.Commands

Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class HeaderFooterModule
		Inherits SpreadSheetTutorialControlBase
		Public Sub New()
			InitializeComponent()

			spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("HeaderFooter_template.xlsx"), DocumentFormat.Xlsx)
			RefreshPreview()
		End Sub

		Private Sub btnPageSetup_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPageSetup.Click
			Dim service As ISpreadsheetCommandFactoryService = CType(spreadsheetControl1.GetService(GetType(ISpreadsheetCommandFactoryService)), ISpreadsheetCommandFactoryService)
			Dim command As SpreadsheetCommand = service.CreateCommand(SpreadsheetCommandId.PageSetupHeaderFooter)
			command.ForceExecute(command.CreateDefaultCommandUIState())
			RefreshPreview()
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
	End Class
End Namespace

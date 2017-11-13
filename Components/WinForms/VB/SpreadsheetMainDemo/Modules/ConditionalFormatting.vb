Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Spreadsheet
Imports System.Globalization

Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class TopTradingPartnersModule
		Inherits SpreadsheetRibbonTutorialControlBase
		Public Sub New()
			InitializeComponent()
			InitializeWorkbook()
			Me.spreadsheetControl1.Options.Culture = DefaultCulture
			UpdateConditionalFormatting()
		End Sub

		Private Sub InitializeWorkbook()
			Dim workbook As IWorkbook = spreadsheetControl1.Document
			workbook.LoadDocument(DemoUtils.GetRelativePath("TopTradingPartners.xlsx"))
		End Sub

		Private Sub OnCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkExports.CheckedChanged, chkAsiaRegion.CheckedChanged, chkBalance.CheckedChanged, chkImports.CheckedChanged
			UpdateConditionalFormatting()

		End Sub

		Private Sub UpdateConditionalFormatting()
			spreadsheetControl1.BeginUpdate()
			Try
				Dim sheet As Worksheet = spreadsheetControl1.ActiveWorksheet
				sheet.ConditionalFormattings.Clear()
				If chkImports.Checked Then
					TopTradingPartners.ApplyTopImportsConditionalFormatting(sheet)
					TopTradingPartners.ApplyImportsYearlyChangeConditionalFormatting(sheet)
				End If
				If chkExports.Checked Then
					TopTradingPartners.ApplyTopExportsConditionalFormatting(sheet)
					TopTradingPartners.ApplyExportsYearlyChangeConditionalFormatting(sheet)
				End If
				If chkBalance.Checked Then
					TopTradingPartners.ApplyBalanceTrendConditionalFormatting(sheet)
					TopTradingPartners.ApplyBalanceChangeConditionalFormatting(sheet)
				End If
				If chkAsiaRegion.Checked Then
					TopTradingPartners.ApplyAsiaCountriesConditionalFormatting(sheet)
				End If
			Finally
				spreadsheetControl1.EndUpdate()
			End Try
		End Sub
	End Class
End Namespace

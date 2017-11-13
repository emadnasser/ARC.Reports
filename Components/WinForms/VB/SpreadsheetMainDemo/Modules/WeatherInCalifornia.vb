Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Spreadsheet
Imports System.Globalization

Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class WeatherInCaliforniaModule
		Inherits SpreadsheetRibbonTutorialControlBase
		Public Sub New()
			InitializeComponent()
			InitializeWorkbook()
			Me.spreadsheetControl1.Options.Culture = DefaultCulture
			UpdateConditionalFormatting()
		End Sub

		Private Sub InitializeWorkbook()
			Dim workbook As IWorkbook = spreadsheetControl1.Document
			workbook.LoadDocument(DemoUtils.GetRelativePath("WeatherInCalifornia.xlsx"))
		End Sub

		Private Sub OnCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkHumidity.CheckedChanged, chkPressure.CheckedChanged, chkTemperature.CheckedChanged
			UpdateConditionalFormatting()

		End Sub

		Private Sub UpdateConditionalFormatting()
			spreadsheetControl1.BeginUpdate()
			Try
				Dim sheet As Worksheet = spreadsheetControl1.ActiveWorksheet
				sheet.ConditionalFormattings.Clear()
				If chkTemperature.Checked Then
					WeatherInCalifornia.ApplyTemperatureConditionalFormatting(sheet)
				End If
				If chkHumidity.Checked Then
					WeatherInCalifornia.ApplyHumidityConditionalFormatting(sheet)
				End If
				If chkPressure.Checked Then
					WeatherInCalifornia.ApplyPressureConditionalFormatting(sheet)
				End If
			Finally
				spreadsheetControl1.EndUpdate()
			End Try
		End Sub
	End Class
End Namespace

Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Globalization
Imports DevExpress.DXperience.Demos
Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Demos

Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class EmployeeInformationModule
		Inherits SpreadsheetRibbonTutorialControlBase

		Public Sub New()
			InitializeComponent()
			spreadsheetControl1.Options.Culture = DefaultCulture
			Dim generator As New EmployeeInformationDocumentGenerator(Me.spreadsheetControl1.Document)
			generator.Generate(DemoUtils.GetRelativePath("EmployeeInformation_template.xlsx"))
			spreadsheetControl1.Document.History.Clear()
		End Sub
		Private Sub btnCalculate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCalculate.Click
			Dim book As IWorkbook = Me.spreadsheetControl1.Document
			If book.Worksheets.Count > 2 Then
				book.Worksheets.ActiveWorksheet = book.Worksheets(2)
			End If
		End Sub
		Protected Overrides Sub DoShow()
			MyBase.DoShow()
			spreadsheetControl1.Focus()
		End Sub
	End Class
End Namespace

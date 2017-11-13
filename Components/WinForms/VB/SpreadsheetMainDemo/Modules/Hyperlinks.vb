Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.Spreadsheet
Imports System.Globalization

Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class HyperlinksModule
		Inherits SpreadsheetRibbonTutorialControlBase
		Public Sub New()
			InitializeComponent()
			InitializeWorkbook()
			Me.spreadsheetControl1.Options.Culture = DefaultCulture
			Me.spreadsheetControl1.Options.View.ShowPrintArea = False
		End Sub
		Private Sub InitializeWorkbook()
			Dim workbook As IWorkbook = spreadsheetControl1.Document
			workbook.Unit = DevExpress.Office.DocumentUnit.Point
			workbook.LoadDocument(DemoUtils.GetRelativePath("Hyperlinks_template.xlsx"))
		End Sub
	End Class
End Namespace

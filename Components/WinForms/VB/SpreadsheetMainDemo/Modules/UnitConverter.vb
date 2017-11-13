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

Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class UnitConverterModule
		Inherits SpreadSheetTutorialControlBase
		Public Sub New()
			InitializeComponent()
			Me.spreadsheetControl1.Options.Culture = DefaultCulture
			Me.spreadsheetControl1.Options.Behavior.Selection.MoveActiveCellMode = MoveActiveCellModeOnEnterPress.None
			InitializeWorkbook()
		End Sub

		Private Sub InitializeWorkbook()
			Dim workbook As IWorkbook = spreadsheetControl1.Document
			workbook.LoadDocument(DemoUtils.GetRelativePath("UnitConverter_template.xlsx"))
		End Sub

		Protected Overrides Sub DoShow()
			MyBase.DoShow()
			spreadsheetControl1.Focus()
		End Sub
	End Class
End Namespace

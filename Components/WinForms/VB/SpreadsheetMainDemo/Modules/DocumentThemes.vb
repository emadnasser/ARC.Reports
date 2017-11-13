Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Globalization
Imports DevExpress.DXperience.Demos
Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Demos

Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class DocumentThemesModule
		Inherits SpreadSheetTutorialControlBase
		Private spreadsheetControl1 As SpreadsheetControl
		Private generator As DocumentThemesDocumentGenerator

		Public Sub New()
			InitializeComponent()
			Me.generator = New DocumentThemesDocumentGenerator()
			InitializeBook()
			Me.spreadsheetControl1.Options.Culture = DefaultCulture
			Me.spreadsheetControl1.Document.History.Clear()
		End Sub
		Private Sub InitializeBook()
			generator.Generate(spreadsheetControl1.Document)
			comboBoxEdit1.SelectedIndex = 0
		End Sub
		Private Sub comboBoxEdit1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxEdit1.SelectedIndexChanged
			If (Not Me.generator.IsValidDocument()) Then
				Return
			End If

			spreadsheetControl1.BeginUpdate()

			Select Case comboBoxEdit1.SelectedIndex
				Case 0
					Me.generator.ApplyThemeGreen()
				Case 1
					Me.generator.ApplyThemeOrange()
				Case 2
					Me.generator.ApplyThemeRed()
				Case 3
					Me.generator.ApplyThemeViolet()
				Case Else
					Me.generator.ApplyThemeBlue()
			End Select

			Me.generator.FormatCells()
			spreadsheetControl1.EndUpdate()
			spreadsheetControl1.Document.History.Clear()
		End Sub
		Protected Overrides Sub DoShow()
			MyBase.DoShow()
			spreadsheetControl1.Focus()
		End Sub
	End Class
End Namespace

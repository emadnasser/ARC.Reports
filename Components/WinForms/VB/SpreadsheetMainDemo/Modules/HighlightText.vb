Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Globalization
Imports DevExpress.BarCodes
Imports DevExpress.Docs.Demos
Imports DevExpress.Docs.Text
Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Demos
Imports DevExpress.Spreadsheet.Functions
Imports DevExpress.Utils
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class HighlightTextModule
		Inherits SpreadsheetRibbonTutorialControlBase
		Public Sub New()
			InitializeComponent()
			spreadsheetControl1.Options.Culture = DefaultCulture
			spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("HighlightText_template.xlsx"))
			AddHandler spreadsheetControl1.CustomDrawCell, AddressOf HighlightCellText
		End Sub
		Private Sub HighlightCellText(ByVal sender As Object, ByVal e As CustomDrawCellEventArgs)
			If String.IsNullOrEmpty(teHighlightText.Text) Then
				Return
			End If

			Dim cellText As String = e.Cell.DisplayText
			Dim index As Integer = cellText.IndexOf(teHighlightText.Text, StringComparison.InvariantCultureIgnoreCase)
			If index >= 0 Then
				Dim format As StringFormat = CType(StringFormat.GenericTypographic.Clone(), StringFormat)
				format.Alignment = CalculateStringAlignment(e.Cell.Alignment.Horizontal)
				format.SetMeasurableCharacterRanges(New CharacterRange() { New CharacterRange(index, teHighlightText.Text.Length) })
				Dim regions() As Region = e.Graphics.MeasureCharacterRanges(cellText, e.Font, e.Bounds, format)
				Dim firstChar As RectangleF = regions(0).GetBounds(e.Graphics)
				Dim lastChar As RectangleF = regions(regions.Length - 1).GetBounds(e.Graphics)
				Dim highlightBounds As RectangleF = RectangleF.FromLTRB(Math.Min(firstChar.Left, lastChar.Left), e.Bounds.Top + 2, Math.Max(firstChar.Right, lastChar.Right), e.Bounds.Bottom - 2)
				e.Cache.FillRectangle(e.Cache.GetSolidBrush(Color.Yellow), highlightBounds)
			End If
		End Sub
		Private Function CalculateStringAlignment(ByVal cellHorizontalAlignment As SpreadsheetHorizontalAlignment) As StringAlignment
			Select Case cellHorizontalAlignment
				Case SpreadsheetHorizontalAlignment.Center
					Return StringAlignment.Center
				Case SpreadsheetHorizontalAlignment.CenterContinuous
					Return StringAlignment.Center

				Case SpreadsheetHorizontalAlignment.Right
					Return StringAlignment.Far
				Case Else
					Return StringAlignment.Near
			End Select
		End Function
		Private Sub teHighlightText_EditValueChanging(ByVal sender As Object, ByVal e As XtraEditors.Controls.ChangingEventArgs) Handles teHighlightText.EditValueChanging
			spreadsheetControl1.Refresh()
			teHighlightText.Focus()
		End Sub
	End Class
End Namespace

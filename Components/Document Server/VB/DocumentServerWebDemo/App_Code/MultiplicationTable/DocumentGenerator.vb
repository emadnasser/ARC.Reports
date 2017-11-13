Imports Microsoft.VisualBasic
Imports System.Drawing
Imports System.Globalization
Imports DevExpress.Spreadsheet

Namespace DevExpress.Docs.Demos
	Public Class MultiplicationTableDocumentGenerator
		Private culture As CultureInfo
		Public Sub New(ByVal culture As CultureInfo)
			Me.culture = culture
		End Sub

		#Region "Properties"
		Public Property Width() As Integer
		Public Property Height() As Integer
		Public Property FitToPage() As Boolean
		Public Property CreateInfoCells() As Boolean
		Public Property UseSharedFormula() As Boolean
		#End Region

		Public Function Generate() As IWorkbook
			Dim book As New Workbook()
			book.Options.Culture = culture
			Dim worksheet As Worksheet = book.Worksheets(0)
			PutData(worksheet)
			worksheet.PrintOptions.FitToPage = FitToPage
			Return book
		End Function

		Private Function PutData(ByVal worksheet As Worksheet) As Worksheet
			Dim offset As Integer = 0
			Dim formula As String = "=ROW()*COLUMN()"
			If CreateInfoCells Then
				offset = 1
				formula = If(UseSharedFormula, "=B$1*$A2", "=(ROW()-1)*(COLUMN()-1)")
				PutInfoCells(worksheet)
			End If
			Dim formulaRange As Range = worksheet.Range.FromLTRB(offset, offset, Width + offset - 1, Height + offset - 1)
			formulaRange.Formula = formula
			Return worksheet
		End Function

		Private Sub PutColumnsInfo(ByVal range As Range)
			range.Formula = "=COLUMN() - 1"
			Dim formatting As Formatting = range.BeginUpdateFormatting()
			Try
				formatting.Borders.BottomBorder.LineStyle = BorderLineStyle.Thin
				formatting.Borders.BottomBorder.Color = Color.Black
			Finally
				range.EndUpdateFormatting(formatting)
			End Try
		End Sub

		Private Sub PutRowsInfo(ByVal range As Range)
			range.Formula = "=ROW() - 1"
			Dim formatting As Formatting = range.BeginUpdateFormatting()
			Try
				formatting.Borders.RightBorder.LineStyle = BorderLineStyle.Thin
				formatting.Borders.RightBorder.Color = Color.Black
			Finally
				range.EndUpdateFormatting(formatting)
			End Try
		End Sub

		Private Sub PutInfoCells(ByVal worksheet As Worksheet)
			PutColumnsInfo(worksheet.Range.FromLTRB(0, 0, Width, 0))
			PutRowsInfo(worksheet.Range.FromLTRB(0, 0, 0, Height))
			worksheet.ClearContents(worksheet.Cells(0, 0))
		End Sub
	End Class
End Namespace

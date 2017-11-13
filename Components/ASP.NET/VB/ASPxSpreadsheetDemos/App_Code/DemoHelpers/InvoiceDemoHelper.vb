Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.Spreadsheet

Namespace DevExpress.Web.Demos

	Public Class Ship
		Public Property Description() As String
		Public Property Quantity() As UInteger
		Public Property Discount() As Double?
		Public Property Price() As Double
	End Class

	Public Class SpreadsheetInvoiceHelper
		Private Const DefaultFontName As String = "Segoe UI"
		Private Const DefaultFontSize As Single = 10.5f

		Private Shared Invoices As IList = New List(Of Ship)() From {New Ship() With {.Description = "Chai", .Quantity = 12, .Discount = 0.1, .Price = 18}, New Ship With {.Description = "Konbu", .Quantity = 4, .Price = 6}, New Ship With {.Description = "Sir Rodney's Scones", .Quantity = 19, .Price = 10}, New Ship With {.Description = "Guaraná Fantástica", .Quantity = 16, .Discount = 0.15, .Price = 4.5}, New Ship With {.Description = "Gnocchi di nonna Alice", .Quantity = 12, .Price = 38}, New Ship With {.Description = "Röd Kaviar", .Quantity = 19, .Price = 34.80}, New Ship With {.Description = "Konbu", .Quantity = 8, .Discount = 0.2, .Price = 15}, New Ship With {.Description = "Original Frankfurter grüne Soße", .Quantity = 2, .Price = 13}}

		Public Shared Sub PrepareSpreadsheet(ByVal Spreadsheet As ASPxSpreadsheet.ASPxSpreadsheet, ByVal invoiceSheetIndex As Integer)
			Dim book As IWorkbook = Spreadsheet.Document
			book.Unit = DevExpress.Office.DocumentUnit.Point
			book.Styles.DefaultStyle.Font.Name = DefaultFontName
			book.Styles.DefaultStyle.Font.Size = DefaultFontSize
			book.Styles.DefaultStyle.Alignment.Vertical = SpreadsheetVerticalAlignment.Center

			Dim sheet As Worksheet = book.Worksheets(invoiceSheetIndex)
			sheet.ActiveView.ShowGridlines = False
			sheet.Name = "Invoice"

			PrepareColumns(sheet)
			PrepareWatermarkStyleCell(sheet.Cells(1, 1))
			FillInvoice(sheet)
		End Sub
		Private Shared Sub PrepareColumns(ByVal sheet As Worksheet)
			sheet.Columns(0).WidthInCharacters = 3
			sheet.Columns(1).WidthInCharacters = 47.86
			sheet.Columns(2).WidthInCharacters = 12
			sheet.Columns(3).WidthInCharacters = 18
			sheet.Columns(4).WidthInCharacters = 16
			sheet.Columns(5).WidthInCharacters = 21
		End Sub
		Private Shared Sub PrepareWatermarkStyleCell(ByVal cell As Cell)
			cell.Font.Size = 36
			cell.Font.FontStyle = SpreadsheetFontStyle.BoldItalic
			cell.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left
			cell.Alignment.Vertical = SpreadsheetVerticalAlignment.Bottom
			cell.Font.Color = DevExpress.Utils.DXColor.FromArgb(&Hff, &HE0, &HE0, &HE0)
			cell.Value = "INVOICE"
		End Sub

		Private Shared Sub FillInvoice(ByVal sheet As Worksheet)
			CreateTableColumns(sheet)
			FillInvoiceTable(sheet)
			PrepareTotalValue(sheet)
		End Sub
		Private Const InitialColumnOffset As Integer = 1, InitialRowOffset As Integer = 6
		Private Shared Sub CreateTableColumns(ByVal sheet As Worksheet)
			Dim columnTitles() As String = { "Description", "QTY", "Price", "Discount", "Amount" }
			For columnOffset As Integer = InitialColumnOffset To InitialColumnOffset + columnTitles.Length - 1
				Dim cell As Cell = sheet.Cells(InitialRowOffset, columnOffset)
				cell.Font.FontStyle = SpreadsheetFontStyle.Bold
				cell.Font.Color = DevExpress.Utils.DXColor.FromArgb(&Hff, &H33, &H33, &H33)
				cell.Borders.BottomBorder.LineStyle = BorderLineStyle.Medium
				cell.Alignment.Vertical = SpreadsheetVerticalAlignment.Center
				cell.Alignment.Horizontal = If(columnOffset = InitialColumnOffset, SpreadsheetHorizontalAlignment.Left, SpreadsheetHorizontalAlignment.Center)
				cell.Value = columnTitles(columnOffset - InitialColumnOffset)
			Next columnOffset
		End Sub
		Private Shared Sub FillInvoiceTable(ByVal sheet As Worksheet)
			Dim currentRowOffset As Integer = InitialRowOffset + 1
			For Each ship As Ship In Invoices
				sheet(currentRowOffset, InitialColumnOffset).Value = ship.Description

				Dim cell As Cell = sheet(currentRowOffset, InitialColumnOffset + 1)
				cell.Value = ship.Quantity
				cell.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center

				cell = sheet(currentRowOffset, InitialColumnOffset + 2)
				sheet(currentRowOffset, InitialColumnOffset + 2).Value = ship.Price
				cell.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center

				cell = sheet(currentRowOffset, InitialColumnOffset + 3)
				cell.NumberFormat = "0.00%;[Red]-0.00%;;@"
				cell.Value = CellValue.TryCreateFromObject(ship.Discount)
				cell.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center

				cell = sheet(currentRowOffset, InitialColumnOffset + 4)
				cell.Formula = String.Format("C{0}*D{0}*(1-E{0})", currentRowOffset + 1)
				cell.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center

				If currentRowOffset Mod 2 = 0 Then
					sheet.Range.FromLTRB(1, currentRowOffset, 5, currentRowOffset).FillColor = System.Drawing.Color.FromArgb(&Hff, &HF1, &HF1, &HF1)
				End If
				currentRowOffset += 1
			Next ship
		End Sub
		Private Shared Sub PrepareTotalValue(ByVal sheet As Worksheet)
			Dim currentRowOffset As Integer = InitialRowOffset + Invoices.Count + 2
			Dim cell As Cell = sheet(currentRowOffset, 4)
			cell.Value = "Total"
			cell.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
			cell.Font.Bold = True
			cell.Font.Size = 13.5

			cell = sheet(currentRowOffset, 5)
			cell.Formula = String.Format("SUM(F{0}:F{1})", InitialRowOffset + 2, currentRowOffset - 1)
			cell.NumberFormat = "_($* #,##0.00_);_($* (#,##0.00);_($* "" - ""??_);_(@_)"
			cell.Font.Color = System.Drawing.Color.Black
			cell.Fill.BackgroundColor = System.Drawing.Color.FromArgb(&Hff, &Hea, &Hea, &Hea)
			cell.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
			cell.Font.Size = 13.5
			cell.Select()
		End Sub
	End Class
End Namespace

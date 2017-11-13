Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing

Namespace DevExpress.Spreadsheet.Demos
	Public Class DocumentThemesDocumentGenerator
		Private book As IWorkbook
		Private sheet As Worksheet
		Private columns As ColumnCollection
		Private rows As RowCollection
		Private cells As CellCollection
		Private styles As StyleCollection

		Public Sub Generate(ByVal book As IWorkbook)
			Me.book = book

			book.BeginUpdate()
			Try
				book.Unit = Office.DocumentUnit.Point

				book.Styles.DefaultStyle.Font.Name = "Calibri"
				book.Styles.DefaultStyle.Font.Size = 11

				sheet = book.Worksheets(0)
				columns = sheet.Columns
				rows = sheet.Rows
				cells = sheet.Cells

				sheet.ActiveView.Zoom = 100
				sheet.ActiveView.ShowGridlines = False

				sheet.DefaultRowHeight = 12.75
				sheet.Name = "The Beatles discography"
				sheet.ActiveView.Orientation = PageOrientation.Landscape
				sheet.PrintOptions.FitToPage = True

				styles = book.Styles

				SetRowsHeight()
				SetColumnsWidth()
				FillData()
				CreateStyles()
				FormatCells()
				MergeCells()
			Finally
				book.EndUpdate()
			End Try
		End Sub

		Public Function IsValidDocument() As Boolean
			Return book.Worksheets.Contains(sheet.Name)
		End Function
		Private Sub SetRowsHeight()
			sheet.Rows(0).Height = 15
			sheet.Rows(1).Height = 41.25
			sheet.Rows(2).Height = 18
			sheet.Rows(3).Height = 30
			sheet.Rows(4).Height = 24.75
			sheet.Rows(5).Height = 27
			sheet.Rows(6).Height = 20.25
			sheet.Rows(7).Height = 32.25
			sheet.Rows(8).Height = 27
			sheet.Rows(17).Height = 32.25
			sheet.Rows(18).Height = 27
			sheet.Rows(22).Height = 32.25
			sheet.Rows(23).Height = 27
			sheet.Rows(24).Height = 20.25
			sheet.Rows(25).Height = 32.25
			sheet.Rows(26).Height = 27
			sheet.Rows(27).Height = 32.25
			sheet.Rows(28).Height = 45
			sheet.Rows(29).Height = 27
			sheet.Rows(30).Height = 32.25
			sheet.Rows(31).Height = 45

			sheet("A10:A17").RowHeight = 20.25
			sheet("A20:A22").RowHeight = 20.25
		End Sub
		Private Sub SetColumnsWidth()
			sheet.Columns(0).WidthInCharacters = 4
			sheet.Columns(1).WidthInCharacters = 11.3
			sheet.Columns(2).WidthInCharacters = 40.09
			sheet.Columns(3).WidthInCharacters = 27.71
			sheet.Columns(4).WidthInCharacters = 21.39
			sheet.Columns(5).WidthInCharacters = 41.43
		End Sub
		Private Sub FillData()
			sheet.Cells("B2").Value = "THE BEATLES DISCOGRAPHY"
			sheet.Cells("B3").Value = "The following table includes studio albums released in multiple countries"

			FillTableHeader()
			FillTable()
		End Sub
		Private Sub FillTableHeader()
			sheet.Cells("B5").Value = "YEAR"
			sheet.Cells("C5").Value = "ALBUM"
			sheet.Cells("D5").Value = "LABEL"
			sheet.Cells("E5").Value = "REALISED"
			sheet.Cells("F5").Value = "SERTIFICATIONS"
		End Sub
		Private Sub FillTable()
			FillTableRow(6, 1963, "Please Please Me", "Parlophone (UK)", "=DATE(1963,3,22)", "US: Platinum, CAN: Gold")
			FillTableRow(7, Int32.MinValue, "With the Beatles", "Parlophone (UK)", "=DATE(1963,11,22)", "US: Gold, CAN: Gold, GER: Gold")
			FillTableRow(8, Int32.MinValue, "Beatlemania! With the Beatles", "Capitol Canada", "=DATE(1963,11,25)", "CAN: Gold")
			FillTableRow(9, 1964, "Introducing... The Beatles", "Vee-Jay (US)", "=DATE(1964,1,10)", String.Empty)
			FillTableRow(10, Int32.MinValue, "Meet the Beatles!", "Capitol (US)", "=DATE(1964,1,20)", "US: 5x Platinum, CAN: Platinum")
			FillTableRow(11, Int32.MinValue, "Twist and Shout", "Capitol Canada", "=DATE(1964,2,3)", "US: 2x Platinum, CAN: Platinum")
			FillTableRow(12, Int32.MinValue, "The Beatles' Second Album", "Capitol (US)", "=DATE(1964,4,10)", "US: 2x Platinum, CAN: Platinum")
			FillTableRow(13, Int32.MinValue, "The Beatles' Long Tall Sally", "Capitol Canada", "=DATE(1964,5,11)", "CAN: Gold")
			FillTableRow(14, Int32.MinValue, "A Hard Day's Night", "United Artists (US)", "=DATE(1964,6,26)", "US: 4x Platinum, CAN: Platinum")
			FillTableRow(15, Int32.MinValue, "A Hard Day's Night", "Parlophone (UK)", "=DATE(1964,7,10)", String.Empty)
			FillTableRow(16, Int32.MinValue, "Something New", "Capitol (US)", "=DATE(1964,7,20)", "US: 2x Platinum, CAN: Gold")
			FillTableRow(17, Int32.MinValue, "Beatles for Sale", "Parlophone (UK)", "=DATE(1964,12,4)", "US: Platinum, CAN: Gold")
			FillTableRow(18, Int32.MinValue, "Beatles '65", "Capitol (US)", "=DATE(1964,12,15)", "US: 3x Platinum, CAN: Platinum")
			FillTableRow(19, 1965, "Beatles VI", "Capitol (US), Parlophone (NZ)", "=DATE(1965,6,14)", "US: Platinum, CAN: Gold")
			FillTableRow(20, Int32.MinValue, "Help!", "Parlophone (UK)", "=DATE(1965,8,6)", String.Empty)
			FillTableRow(21, Int32.MinValue, "Help!", "Capitol (US)", "=DATE(1965,8,13)", "US: 3xPlatinum, CAN: 2x Platinum")
			FillTableRow(22, Int32.MinValue, "Rubber Soul", "Parlophone (UK)", "=DATE(1965,12,3)", "GER: Gold")
			FillTableRow(23, Int32.MinValue, "Rubber Soul", "Capitol (US)", "=DATE(1965,12,6)", "US: 6x Platinum, CAN: 2x Platinum")
			FillTableRow(24, 1966, "Yesterday and Today", "Capitol (US)", "=DATE(1966,6,15)", "US: 2x Platinum, CAN: Platinum")
			FillTableRow(25, Int32.MinValue, "Revolver", "Parlophone (UK)", "=DATE(1966,8,5)", String.Empty)
			FillTableRow(26, Int32.MinValue, "Revolver", "Capitol (US)", "=DATE(1966,8,8)", "US: 5x Platinum, CAN: 2x Platinum")
			FillTableRow(27, 1967, "Sgt. Pepper's Lonely Hearts Club Band", "Parlophone (UK), Capitol (US)", "=DATE(1967,6,1)", "US: 11x Platinum, CAN: 8x Platinum, GER: Platinum")
			FillTableRow(28, Int32.MinValue, "Magical Mystery Tour", "Capitol (US), Parlophone (UK)", "=DATE(1967,11,27)", "UK: Gold, US: 6x Platinum, CAN: 4x Platinum")
			FillTableRow(29, 1968, "The Beatles", "Apple (UK), Capitol (US)", "=DATE(1968,11,22)", "US: 19x Platinum, CAN: 8x Platinum")
			FillTableRow(30, 1969, "Yellow Submarine", "Capitol (US), Apple (UK)", "=DATE(1969,1,13)", "US: Platinum, CAN: Gold")
			FillTableRow(31, Int32.MinValue, "Abbey Road", "Apple (UK), Capitol (US)", "=DATE(1969,9,26)", "US: 12x Platinum, CAN: Diamond, GER: Platinum")
			FillTableRow(32, 1970, "Let It Be", "Apple (UK), United Artists (US)", "=DATE(1970,5,8)", "US: 4x Platinum, CAN: 3x Platinum")
		End Sub
		Private Sub FillTableRow(ByVal row As Integer, ByVal year As Integer, ByVal album As String, ByVal label As String, ByVal released As String, ByVal certifications As String)
			If year <> Int32.MinValue Then
				sheet.Cells("B" & row).Value = year
			End If

			sheet.Cells("C" & row).Value = album
			sheet.Cells("D" & row).Value = label
			sheet.Cells("E" & row).FormulaInvariant = released

			If (Not String.IsNullOrEmpty(certifications)) Then
				sheet.Cells("F" & row).Value = certifications
			End If
		End Sub
		Private Sub CreateStyles()
			CreateThemeGreenStyles()
			CreateThemeOrangeStyles()
			CreateThemeRedStyles()
			CreateThemeVioletStyles()
			CreateThemeBlueStyles()
		End Sub
		Private Sub CreateThemeBlueStyles()
			Dim style1 As Style = styles.Add("Style 5.1")
			style1.Font.Color = Color.FromArgb(255, 44, 150, 210)
			style1.Font.Size = 36
			style1.Font.Name = "Segoe UI"

			Dim style2 As Style = styles.Add("Style 5.2")
			style2.Font.Color = Color.FromArgb(255, 0, 0, 0)
			style2.Font.Size = 10
			style2.Font.Name = "Segoe UI"

			Dim style3 As Style = styles.Add("Style 5.3")
			style3.Font.FontStyle = DevExpress.Spreadsheet.SpreadsheetFontStyle.Bold
			style3.Font.Color = Color.FromArgb(255, 49, 118, 177)
			style3.Font.Size = 10
			style3.Font.Name = "Segoe UI"
			style3.Borders.BottomBorder.Color = Color.FromArgb(255, 167, 200, 229)
			style3.Borders.BottomBorder.LineStyle = BorderLineStyle.Medium
			style3.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
			style3.Alignment.Vertical = SpreadsheetVerticalAlignment.Center

			Dim style4 As Style = styles.Add("Style 5.4")
			style4.Font.FontStyle = DevExpress.Spreadsheet.SpreadsheetFontStyle.Bold
			style4.Font.Color = Color.FromArgb(255, 49, 118, 177)
			style4.Font.Size = 10
			style4.Font.Name = "Segoe UI"
			style4.Borders.BottomBorder.Color = Color.FromArgb(255, 137, 182, 220)
			style4.Borders.BottomBorder.LineStyle = BorderLineStyle.Medium

			Dim style5 As Style = styles.Add("Style 5.5")
			style5.Font.FontStyle = DevExpress.Spreadsheet.SpreadsheetFontStyle.Bold
			style5.Font.Color = Color.FromArgb(255, 49, 118, 177)
			style5.Font.Size = 10
			style5.Font.Name = "Segoe UI"
			style5.Borders.BottomBorder.Color = Color.FromArgb(255, 167, 200, 229)
			style5.Borders.BottomBorder.LineStyle = BorderLineStyle.Medium

			Dim style6 As Style = styles.Add("Style 5.6")
			style6.Fill.PatternType = PatternType.Solid
			style6.Fill.BackgroundColor = Color.FromArgb(255, 245, 250, 255)
			style6.Font.Color = Color.FromArgb(255, 49, 118, 177)
			style6.Font.Size = 18
			style6.Font.Name = "Segoe UI"

			Dim style7 As Style = styles.Add("Style 5.7")
			style7.Fill.PatternType = PatternType.Solid
			style7.Fill.BackgroundColor = Color.FromArgb(255, 241, 248, 255)
			style7.Font.Color = Color.FromArgb(255, 0, 0, 0)
			style7.Font.Size = 9
			style7.Font.Name = "Segoe UI Semibold"

			Dim style8 As Style = styles.Add("Style 5.8")
			style8.Fill.PatternType = PatternType.Solid
			style8.Fill.BackgroundColor = Color.FromArgb(255, 245, 250, 255)
			style8.Font.Color = Color.FromArgb(255, 0, 0, 0)
			style8.Font.Size = 9
			style8.Font.Name = "Segoe UI"

			Dim style9 As Style = styles.Add("Style 5.9")
			style9.Fill.PatternType = PatternType.Solid
			style9.Fill.BackgroundColor = Color.FromArgb(255, 241, 248, 255)
			style9.Font.Color = Color.FromArgb(255, 0, 0, 0)
			style9.Font.Size = 9
			style9.Font.Name = "Segoe UI"

			Dim style10 As Style = styles.Add("Style 5.10")
			style10.Fill.PatternType = PatternType.Solid
			style10.Fill.BackgroundColor = Color.FromArgb(255, 231, 244, 255)
			style10.Font.Color = Color.FromArgb(255, 49, 118, 177)
			style10.Font.Size = 18
			style10.Font.Name = "Segoe UI"

			Dim style11 As Style = styles.Add("Style 5.11")
			style11.Fill.PatternType = PatternType.Solid
			style11.Fill.BackgroundColor = Color.FromArgb(255, 223, 240, 255)
			style11.Font.Color = Color.FromArgb(255, 0, 0, 0)
			style11.Font.Size = 9
			style11.Font.Name = "Segoe UI Semibold"

			Dim style12 As Style = styles.Add("Style 5.12")
			style12.Fill.PatternType = PatternType.Solid
			style12.Fill.BackgroundColor = Color.FromArgb(255, 231, 244, 255)
			style12.Font.Color = Color.FromArgb(255, 0, 0, 0)
			style12.Font.Size = 9
			style12.Font.Name = "Segoe UI"

			Dim style13 As Style = styles.Add("Style 5.13")
			style13.Fill.PatternType = PatternType.Solid
			style13.Fill.BackgroundColor = Color.FromArgb(255, 223, 240, 255)
			style13.Font.Color = Color.FromArgb(255, 0, 0, 0)
			style13.Font.Size = 9
			style13.Font.Name = "Segoe UI"
		End Sub
		Private Sub CreateThemeVioletStyles()
			Dim style1 As Style = styles.Add("Style 4.1")
			style1.Font.FontStyle = DevExpress.Spreadsheet.SpreadsheetFontStyle.Bold
			style1.Font.Color = Color.FromArgb(255, 81, 40, 131)
			style1.Font.Size = 28
			style1.Font.Name = "Segoe UI"

			Dim style2 As Style = styles.Add("Style 4.2")
			style2.Font.FontStyle = DevExpress.Spreadsheet.SpreadsheetFontStyle.Italic
			style2.Font.Color = Color.FromArgb(255, 81, 40, 131)
			style2.Font.Size = 14
			style2.Font.Name = "Segoe UI"

			Dim style3 As Style = styles.Add("Style 4.3")
			style3.Fill.PatternType = PatternType.Solid
			style3.Fill.BackgroundColor = Color.FromArgb(255, 224, 176, 235)
			style3.Font.FontStyle = DevExpress.Spreadsheet.SpreadsheetFontStyle.Bold
			style3.Font.Color = Color.FromArgb(255, 81, 40, 131)
			style3.Font.Size = 10
			style3.Font.Name = "Segoe UI"
			style3.Borders.BottomBorder.Color = Color.FromArgb(255, 125, 94, 162)
			style3.Borders.BottomBorder.LineStyle = BorderLineStyle.Medium
			style3.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
			style3.Alignment.Vertical = SpreadsheetVerticalAlignment.Center

			Dim style4 As Style = styles.Add("Style 4.4")
			style4.Fill.PatternType = PatternType.Solid
			style4.Fill.BackgroundColor = Color.FromArgb(255, 218, 162, 231)
			style4.Font.FontStyle = DevExpress.Spreadsheet.SpreadsheetFontStyle.Bold
			style4.Font.Color = Color.FromArgb(255, 81, 40, 131)
			style4.Font.Size = 10
			style4.Font.Name = "Segoe UI"
			style4.Borders.BottomBorder.Color = Color.FromArgb(255, 81, 40, 131)
			style4.Borders.BottomBorder.LineStyle = BorderLineStyle.Medium

			Dim style5 As Style = styles.Add("Style 4.5")
			style5.Fill.PatternType = PatternType.Solid
			style5.Fill.BackgroundColor = Color.FromArgb(255, 224, 176, 235)
			style5.Font.FontStyle = DevExpress.Spreadsheet.SpreadsheetFontStyle.Bold
			style5.Font.Color = Color.FromArgb(255, 81, 40, 131)
			style5.Font.Size = 10
			style5.Font.Name = "Segoe UI"
			style5.Borders.BottomBorder.Color = Color.FromArgb(255, 125, 94, 162)
			style5.Borders.BottomBorder.LineStyle = BorderLineStyle.Medium

			Dim style6 As Style = styles.Add("Style 4.6")
			style6.Fill.PatternType = PatternType.Solid
			style6.Fill.BackgroundColor = Color.FromArgb(255, 234, 226, 242)
			style6.Font.FontStyle = DevExpress.Spreadsheet.SpreadsheetFontStyle.Bold
			style6.Font.Color = Color.FromArgb(255, 81, 40, 131)
			style6.Font.Size = 10
			style6.Font.Name = "Segoe UI"

			Dim style7 As Style = styles.Add("Style 4.7")
			style7.Fill.PatternType = PatternType.Solid
			style7.Fill.BackgroundColor = Color.FromArgb(255, 230, 221, 240)
			style7.Font.Color = Color.FromArgb(255, 0, 0, 0)
			style7.Font.Size = 9
			style7.Font.Name = "Segoe UI Semibold"

			Dim style8 As Style = styles.Add("Style 4.8")
			style8.Fill.PatternType = PatternType.Solid
			style8.Fill.BackgroundColor = Color.FromArgb(255, 234, 226, 242)
			style8.Font.Color = Color.FromArgb(255, 0, 0, 0)
			style8.Font.Size = 9
			style8.Font.Name = "Segoe UI"

			Dim style9 As Style = styles.Add("Style 4.9")
			style9.Fill.PatternType = PatternType.Solid
			style9.Fill.BackgroundColor = Color.FromArgb(255, 230, 221, 240)
			style9.Font.Color = Color.FromArgb(255, 0, 0, 0)
			style9.Font.Size = 9
			style9.Font.Name = "Segoe UI"

			Dim style10 As Style = styles.Add("Style 4.10")
			style10.Fill.PatternType = PatternType.Solid
			style10.Fill.BackgroundColor = Color.FromArgb(255, 218, 204, 233)
			style10.Font.FontStyle = DevExpress.Spreadsheet.SpreadsheetFontStyle.Bold
			style10.Font.Color = Color.FromArgb(255, 81, 40, 131)
			style10.Font.Size = 10
			style10.Font.Name = "Segoe UI"

			Dim style11 As Style = styles.Add("Style 4.11")
			style11.Fill.PatternType = PatternType.Solid
			style11.Fill.BackgroundColor = Color.FromArgb(255, 211, 195, 229)
			style11.Font.Color = Color.FromArgb(255, 0, 0, 0)
			style11.Font.Size = 9
			style11.Font.Name = "Segoe UI Semibold"

			Dim style12 As Style = styles.Add("Style 4.12")
			style12.Fill.PatternType = PatternType.Solid
			style12.Fill.BackgroundColor = Color.FromArgb(255, 218, 204, 233)
			style12.Font.Color = Color.FromArgb(255, 0, 0, 0)
			style12.Font.Size = 9
			style12.Font.Name = "Segoe UI"

			Dim style13 As Style = styles.Add("Style 4.13")
			style13.Fill.PatternType = PatternType.Solid
			style13.Fill.BackgroundColor = Color.FromArgb(255, 211, 195, 229)
			style13.Font.Color = Color.FromArgb(255, 0, 0, 0)
			style13.Font.Size = 9
			style13.Font.Name = "Segoe UI"
		End Sub
		Private Sub CreateThemeRedStyles()
			Dim style1 As Style = styles.Add("Style 3.1")
			style1.Font.Color = Color.FromArgb(255, 120, 120, 120)
			style1.Font.Size = 28
			style1.Font.Name = "Segoe UI"

			Dim style2 As Style = styles.Add("Style 3.2")
			style2.Font.FontStyle = DevExpress.Spreadsheet.SpreadsheetFontStyle.BoldItalic
			style2.Font.Color = Color.FromArgb(255, 255, 81, 76)
			style2.Font.Size = 10
			style2.Font.Name = "Segoe UI"

			Dim style3 As Style = styles.Add("Style 3.3")
			style3.Fill.PatternType = PatternType.Solid
			style3.Fill.BackgroundColor = Color.FromArgb(255, 255, 81, 76)
			style3.Font.FontStyle = DevExpress.Spreadsheet.SpreadsheetFontStyle.Bold
			style3.Font.Color = Color.FromArgb(255, 255, 255, 255)
			style3.Font.Size = 10
			style3.Font.Name = "Segoe UI"
			style3.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
			style3.Alignment.Vertical = SpreadsheetVerticalAlignment.Center

			Dim style4 As Style = styles.Add("Style 3.4")
			style4.Fill.PatternType = PatternType.Solid
			style4.Fill.BackgroundColor = Color.FromArgb(255, 255, 81, 76)
			style4.Font.FontStyle = DevExpress.Spreadsheet.SpreadsheetFontStyle.Bold
			style4.Font.Color = Color.FromArgb(255, 255, 255, 255)
			style4.Font.Size = 10
			style4.Font.Name = "Segoe UI"

			Dim style5 As Style = styles.Add("Style 3.6")
			style5.Fill.PatternType = PatternType.Solid
			style5.Fill.BackgroundColor = Color.FromArgb(255, 255, 237, 237)
			style5.Font.Color = Color.FromArgb(255, 255, 81, 76)
			style5.Font.Size = 22
			style5.Font.Name = "Segoe UI"

			Dim style6 As Style = styles.Add("Style 3.7")
			style6.Fill.PatternType = PatternType.Solid
			style6.Fill.BackgroundColor = Color.FromArgb(255, 255, 237, 237)
			style6.Font.Color = Color.FromArgb(255, 184, 9, 4)
			style6.Font.Size = 10
			style6.Font.Name = "Segoe UI Semibold"

			Dim style7 As Style = styles.Add("Style 3.8")
			style7.Fill.PatternType = PatternType.Solid
			style7.Fill.BackgroundColor = Color.FromArgb(255, 255, 237, 237)
			style7.Font.FontStyle = DevExpress.Spreadsheet.SpreadsheetFontStyle.Italic
			style7.Font.Color = Color.FromArgb(255, 0, 0, 0)
			style7.Font.Size = 9
			style7.Font.Name = "Segoe UI"

			Dim style8 As Style = styles.Add("Style 3.10")
			style8.Fill.PatternType = PatternType.Solid
			style8.Fill.BackgroundColor = Color.FromArgb(255, 255, 217, 216)
			style8.Font.Color = Color.FromArgb(255, 255, 81, 76)
			style8.Font.Size = 22
			style8.Font.Name = "Segoe UI"

			Dim style9 As Style = styles.Add("Style 3.11")
			style9.Fill.PatternType = PatternType.Solid
			style9.Fill.BackgroundColor = Color.FromArgb(255, 255, 217, 216)
			style9.Font.Color = Color.FromArgb(255, 184, 9, 4)
			style9.Font.Size = 10
			style9.Font.Name = "Segoe UI Semibold"

			Dim style10 As Style = styles.Add("Style 3.12")
			style10.Fill.PatternType = PatternType.Solid
			style10.Fill.BackgroundColor = Color.FromArgb(255, 255, 217, 216)
			style10.Font.FontStyle = DevExpress.Spreadsheet.SpreadsheetFontStyle.Italic
			style10.Font.Color = Color.FromArgb(255, 0, 0, 0)
			style10.Font.Size = 9
			style10.Font.Name = "Segoe UI"
		End Sub
		Private Sub CreateThemeOrangeStyles()
			Dim style1 As Style = styles.Add("Style 2.1")
			style1.Font.FontStyle = DevExpress.Spreadsheet.SpreadsheetFontStyle.Bold
			style1.Font.Color = Color.FromArgb(255, 220, 64, 0)
			style1.Font.Size = 36
			style1.Font.Name = "Segoe UI"

			Dim style2 As Style = styles.Add("Style 2.2")
			style2.Font.Color = Color.FromArgb(255, 0, 0, 0)
			style2.Font.Size = 10
			style2.Font.Name = "Segoe UI"

			Dim style3 As Style = styles.Add("Style 2.3")
			style3.Fill.PatternType = PatternType.Solid
			style3.Fill.BackgroundColor = Color.FromArgb(255, 230, 121, 76)
			style3.Font.FontStyle = DevExpress.Spreadsheet.SpreadsheetFontStyle.Bold
			style3.Font.Color = Color.FromArgb(255, 255, 255, 255)
			style3.Font.Name = "Segoe UI"
			style3.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
			style3.Alignment.Vertical = SpreadsheetVerticalAlignment.Center

			Dim style4 As Style = styles.Add("Style 2.4")
			style4.Fill.PatternType = PatternType.Solid
			style4.Fill.BackgroundColor = Color.FromArgb(255, 230, 121, 76)
			style4.Font.FontStyle = DevExpress.Spreadsheet.SpreadsheetFontStyle.Bold
			style4.Font.Color = Color.FromArgb(255, 255, 255, 255)
			style4.Font.Name = "Segoe UI"

			Dim style5 As Style = styles.Add("Style 2.6")
			style5.Fill.PatternType = PatternType.Solid
			style5.Fill.BackgroundColor = Color.FromArgb(255, 255, 238, 226)
			style5.Font.FontStyle = DevExpress.Spreadsheet.SpreadsheetFontStyle.Bold
			style5.Font.Color = Color.FromArgb(255, 247, 173, 142)
			style5.Font.Size = 22
			style5.Font.Name = "Segoe UI"

			Dim style6 As Style = styles.Add("Style 2.7")
			style6.Fill.PatternType = PatternType.Solid
			style6.Fill.BackgroundColor = Color.FromArgb(255, 255, 238, 226)
			style6.Font.Color = Color.FromArgb(255, 220, 65, 1)
			style6.Font.Size = 10
			style6.Font.Name = "Segoe UI Semibold"

			Dim style7 As Style = styles.Add("Style 2.8")
			style7.Fill.PatternType = PatternType.Solid
			style7.Fill.BackgroundColor = Color.FromArgb(255, 255, 238, 226)
			style7.Font.Color = Color.FromArgb(255, 0, 0, 0)
			style7.Font.Size = 9
			style7.Font.Name = "Segoe UI"

			Dim style8 As Style = styles.Add("Style 2.9")
			style8.Fill.PatternType = PatternType.Solid
			style8.Fill.BackgroundColor = Color.FromArgb(255, 255, 225, 205)
			style8.Font.Color = Color.FromArgb(255, 220, 65, 1)
			style8.Font.Size = 10
			style8.Font.Name = "Segoe UI Semibold"

			Dim style9 As Style = styles.Add("Style 2.10")
			style9.Fill.PatternType = PatternType.Solid
			style9.Fill.BackgroundColor = Color.FromArgb(255, 255, 225, 205)
			style9.Font.FontStyle = DevExpress.Spreadsheet.SpreadsheetFontStyle.Bold
			style9.Font.Color = Color.FromArgb(255, 247, 173, 142)
			style9.Font.Size = 22
			style9.Font.Name = "Segoe UI"

			Dim style10 As Style = styles.Add("Style 2.11")
			style10.Fill.PatternType = PatternType.Solid
			style10.Fill.BackgroundColor = Color.FromArgb(255, 255, 225, 205)
			style10.Font.Color = Color.FromArgb(255, 220, 65, 1)
			style10.Font.Size = 10
			style10.Font.Name = "Segoe UI Semibold"

			Dim style11 As Style = styles.Add("Style 2.12")
			style11.Fill.PatternType = PatternType.Solid
			style11.Fill.BackgroundColor = Color.FromArgb(255, 255, 225, 205)
			style11.Font.Color = Color.FromArgb(255, 0, 0, 0)
			style11.Font.Size = 9
			style11.Font.Name = "Segoe UI"
		End Sub
		Private Sub CreateThemeGreenStyles()
			Dim style1 As Style = styles.Add("Style 1.1")
			style1.Font.Color = Color.FromArgb(255, 0, 0, 0)
			style1.Font.Size = 36
			style1.Font.Name = "Segoe UI Light"
			style1.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left
			style1.Alignment.Vertical = SpreadsheetVerticalAlignment.Top

			Dim style2 As Style = styles.Add("Style 1.2")
			style2.Font.Color = Color.FromArgb(255, 0, 0, 0)
			style2.Font.Size = 10
			style2.Font.Name = "Segoe UI"

			Dim style3 As Style = styles.Add("Style 1.3")
			style3.Fill.PatternType = PatternType.Solid
			style3.Fill.BackgroundColor = Color.FromArgb(255, 142, 189, 112)
			style3.Font.FontStyle = DevExpress.Spreadsheet.SpreadsheetFontStyle.Bold
			style3.Font.Color = Color.FromArgb(255, 255, 255, 255)
			style3.Font.Size = 9
			style3.Font.Name = "Segoe UI"
			style3.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
			style3.Alignment.Vertical = SpreadsheetVerticalAlignment.Center

			Dim style4 As Style = styles.Add("Style 1.4")
			style4.Fill.PatternType = PatternType.Solid
			style4.Fill.BackgroundColor = Color.FromArgb(255, 122, 178, 87)
			style4.Font.FontStyle = DevExpress.Spreadsheet.SpreadsheetFontStyle.Bold
			style4.Font.Color = Color.FromArgb(255, 255, 255, 255)
			style4.Font.Size = 9
			style4.Font.Name = "Segoe UI"

			Dim style5 As Style = styles.Add("Style 1.5")
			style5.Fill.PatternType = PatternType.Solid
			style5.Fill.BackgroundColor = Color.FromArgb(255, 142, 189, 112)
			style5.Font.FontStyle = DevExpress.Spreadsheet.SpreadsheetFontStyle.Bold
			style5.Font.Color = Color.FromArgb(255, 255, 255, 255)
			style5.Font.Size = 9
			style5.Font.Name = "Segoe UI"

			Dim style6 As Style = styles.Add("Style 1.6")
			style6.Fill.PatternType = PatternType.Solid
			style6.Fill.BackgroundColor = Color.FromArgb(255, 237, 249, 229)
			style6.Font.Color = Color.FromArgb(255, 66, 145, 16)
			style6.Font.Size = 22
			style6.Font.Name = "Segoe UI Light"

			Dim style7 As Style = styles.Add("Style 1.7")
			style7.Fill.PatternType = PatternType.Solid
			style7.Fill.BackgroundColor = Color.FromArgb(255, 234, 248, 225)
			style7.Font.Color = Color.FromArgb(255, 0, 0, 0)
			style7.Font.Size = 10
			style7.Font.Name = "Segoe UI Semibold"

			Dim style8 As Style = styles.Add("Style 1.8")
			style8.Fill.PatternType = PatternType.Solid
			style8.Fill.BackgroundColor = Color.FromArgb(255, 237, 249, 229)
			style8.Font.Color = Color.FromArgb(255, 0, 0, 0)
			style8.Font.Size = 9
			style8.Font.Name = "Segoe UI"

			Dim style9 As Style = styles.Add("Style 1.9")
			style9.Fill.PatternType = PatternType.Solid
			style9.Fill.BackgroundColor = Color.FromArgb(255, 234, 248, 225)
			style9.Font.Color = Color.FromArgb(255, 0, 0, 0)
			style9.Font.Size = 9
			style9.Font.Name = "Segoe UI"

			Dim style10 As Style = styles.Add("Style 1.10")
			style10.Fill.PatternType = PatternType.Solid
			style10.Fill.BackgroundColor = Color.FromArgb(255, 216, 237, 202)
			style10.Font.Color = Color.FromArgb(255, 66, 145, 16)
			style10.Font.Size = 22
			style10.Font.Name = "Segoe UI Light"

			Dim style11 As Style = styles.Add("Style 1.11")
			style11.Fill.PatternType = PatternType.Solid
			style11.Fill.BackgroundColor = Color.FromArgb(255, 209, 234, 193)
			style11.Font.Color = Color.FromArgb(255, 0, 0, 0)
			style11.Font.Size = 10
			style11.Font.Name = "Segoe UI Semibold"

			Dim style12 As Style = styles.Add("Style 1.12")
			style12.Fill.PatternType = PatternType.Solid
			style12.Fill.BackgroundColor = Color.FromArgb(255, 216, 237, 202)
			style12.Font.Color = Color.FromArgb(255, 0, 0, 0)
			style12.Font.Size = 9
			style12.Font.Name = "Segoe UI"

			Dim style13 As Style = styles.Add("Style 1.13")
			style13.Fill.PatternType = PatternType.Solid
			style13.Fill.BackgroundColor = Color.FromArgb(255, 209, 234, 193)
			style13.Font.Color = Color.FromArgb(255, 0, 0, 0)
			style13.Font.Size = 9
			style13.Font.Name = "Segoe UI"
		End Sub
		Public Sub FormatCells()
			Dim range1 As Range = sheet("E5:E32")
			Dim rangeFormatting1 As Formatting = range1.BeginUpdateFormatting()
			rangeFormatting1.NumberFormat = "[$-409]mmmm\ d\,\ yyyy;"
			range1.EndUpdateFormatting(rangeFormatting1)

			Dim range2 As Range = sheet("C5:F32")
			Dim rangeFormatting2 As Formatting = range2.BeginUpdateFormatting()
			rangeFormatting2.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left
			rangeFormatting2.Alignment.Indent = 1
			range2.EndUpdateFormatting(rangeFormatting2)

			Dim range3 As Range = sheet("B6:B32")
			Dim rangeFormatting3 As Formatting = range3.BeginUpdateFormatting()
			rangeFormatting3.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
			rangeFormatting3.Alignment.Vertical = SpreadsheetVerticalAlignment.Center
			range3.EndUpdateFormatting(rangeFormatting3)

			Dim range4 As Range = sheet("C5:F5")
			Dim rangeFormatting4 As Formatting = range4.BeginUpdateFormatting()
			rangeFormatting4.Alignment.Vertical = SpreadsheetVerticalAlignment.Center
			range4.EndUpdateFormatting(rangeFormatting4)

			Dim range5 As Range = sheet("C7:F7")
			Dim rangeFormatting5 As Formatting = range5.BeginUpdateFormatting()
			rangeFormatting5.Alignment.Vertical = SpreadsheetVerticalAlignment.Center
			range5.EndUpdateFormatting(rangeFormatting5)

			Dim range6 As Range = sheet("C10:F17")
			Dim rangeFormatting6 As Formatting = range6.BeginUpdateFormatting()
			rangeFormatting6.Alignment.Vertical = SpreadsheetVerticalAlignment.Center
			range6.EndUpdateFormatting(rangeFormatting6)

			Dim range7 As Range = sheet("C20:F22")
			Dim rangeFormatting7 As Formatting = range7.BeginUpdateFormatting()
			rangeFormatting7.Alignment.Vertical = SpreadsheetVerticalAlignment.Center
			range7.EndUpdateFormatting(rangeFormatting7)

			Dim range8 As Range = sheet("C25:F25")
			Dim rangeFormatting8 As Formatting = range8.BeginUpdateFormatting()
			rangeFormatting8.Alignment.Vertical = SpreadsheetVerticalAlignment.Center
			range8.EndUpdateFormatting(rangeFormatting8)

			Dim range14 As Range = sheet("C29:F29")
			Dim rangeFormatting14 As Formatting = range14.BeginUpdateFormatting()
			rangeFormatting14.Alignment.Vertical = SpreadsheetVerticalAlignment.Center
			range14.EndUpdateFormatting(rangeFormatting14)

			Dim range15 As Range = sheet("C32:F32")
			Dim rangeFormatting15 As Formatting = range15.BeginUpdateFormatting()
			rangeFormatting15.Alignment.Vertical = SpreadsheetVerticalAlignment.Center
			range15.EndUpdateFormatting(rangeFormatting15)

			Dim range9 As Range = sheet("C8:F8")
			Dim rangeFormatting9 As Formatting = range9.BeginUpdateFormatting()
			rangeFormatting9.Alignment.Vertical = SpreadsheetVerticalAlignment.Top
			range9.EndUpdateFormatting(rangeFormatting9)

			Dim range10 As Range = sheet("C18:F18")
			Dim rangeFormatting10 As Formatting = range10.BeginUpdateFormatting()
			rangeFormatting10.Alignment.Vertical = SpreadsheetVerticalAlignment.Top
			range10.EndUpdateFormatting(rangeFormatting10)

			Dim range11 As Range = sheet("C23:F23")
			Dim rangeFormatting11 As Formatting = range11.BeginUpdateFormatting()
			rangeFormatting11.Alignment.Vertical = SpreadsheetVerticalAlignment.Top
			range11.EndUpdateFormatting(rangeFormatting11)

			Dim range16 As Range = sheet("C26:F26")
			Dim rangeFormatting16 As Formatting = range16.BeginUpdateFormatting()
			rangeFormatting16.Alignment.Vertical = SpreadsheetVerticalAlignment.Top
			range16.EndUpdateFormatting(rangeFormatting16)

			Dim range12 As Range = sheet("C28:F28")
			Dim rangeFormatting12 As Formatting = range12.BeginUpdateFormatting()
			rangeFormatting12.Alignment.Vertical = SpreadsheetVerticalAlignment.Top
			range12.EndUpdateFormatting(rangeFormatting12)

			Dim range13 As Range = sheet("C31:F31")
			Dim rangeFormatting13 As Formatting = range13.BeginUpdateFormatting()
			rangeFormatting13.Alignment.Vertical = SpreadsheetVerticalAlignment.Top
			range13.EndUpdateFormatting(rangeFormatting13)
		End Sub
		Private Sub MergeCells()
			sheet("B27:B28").Merge()
			sheet("B30:B31").Merge()
			sheet("B6:B7").Merge()
			sheet("B19:B20").Merge()
			sheet("B9:B10").Merge()
			sheet("B24:B25").Merge()
		End Sub
		Public Sub ApplyThemeGreen()
			ApplyThemeInHeader("Style 1.1", "Style 1.2")
			ApplyThemeInTableHeader("Style 1.3", "Style 1.4", "Style 1.5")
			ApplyStyleInUnevenTableRow("Style 1.6", "Style 1.7", "Style 1.8", "Style 1.9")
			ApplyStyleInEvenTableRow("Style 1.10", "Style 1.11", "Style 1.12", "Style 1.13")
		End Sub
		Public Sub ApplyThemeOrange()
			ApplyThemeInHeader("Style 2.1", "Style 2.2")
			ApplyThemeInTableHeader("Style 2.3", "Style 2.4", "Style 2.4")
			ApplyStyleInUnevenTableRow("Style 2.6", "Style 2.7", "Style 2.8", "Style 2.8")
			ApplyStyleInEvenTableRow("Style 2.10", "Style 2.11", "Style 2.12", "Style 2.12")
		End Sub
		Public Sub ApplyThemeRed()
			ApplyThemeInHeader("Style 3.1", "Style 3.2")
			ApplyThemeInTableHeader("Style 3.3", "Style 3.4", "Style 3.4")
			ApplyStyleInUnevenTableRow("Style 3.6", "Style 3.7", "Style 3.8", "Style 3.8")
			ApplyStyleInEvenTableRow("Style 3.10", "Style 3.11", "Style 3.12", "Style 3.12")
		End Sub
		Public Sub ApplyThemeViolet()
			ApplyThemeInHeader("Style 4.1", "Style 4.2")
			ApplyThemeInTableHeader("Style 4.3", "Style 4.4", "Style 4.5")
			ApplyStyleInUnevenTableRow("Style 4.6", "Style 4.7", "Style 4.8", "Style 4.9")
			ApplyStyleInEvenTableRow("Style 4.10", "Style 4.11", "Style 4.12", "Style 4.13")
		End Sub
		Public Sub ApplyThemeBlue()
			ApplyThemeInHeader("Style 5.1", "Style 5.2")
			ApplyThemeInTableHeader("Style 5.3", "Style 5.4", "Style 5.5")
			ApplyStyleInUnevenTableRow("Style 5.6", "Style 5.7", "Style 5.8", "Style 5.9")
			ApplyStyleInEvenTableRow("Style 5.10", "Style 5.11", "Style 5.12", "Style 5.13")
		End Sub
		Private Sub ApplyStyleInEvenTableRow(ByVal style1 As String, ByVal style2 As String, ByVal style3 As String, ByVal style4 As String)
			If book.Styles.Contains(style1) Then
				sheet("B9:B18").Style = book.Styles(style1)
				sheet("B24:B26").Style = book.Styles(style1)
				sheet("B29").Style = book.Styles(style1)
				sheet("B32").Style = book.Styles(style1)
			End If

			If book.Styles.Contains(style2) Then
				sheet("C9:C18").Style = book.Styles(style2)
				sheet("C24:C26").Style = book.Styles(style2)
				sheet("C29").Style = book.Styles(style2)
				sheet("C32").Style = book.Styles(style2)
			End If

			If book.Styles.Contains(style3) Then
				sheet("D9:D18").Style = book.Styles(style3)
				sheet("F9:F18").Style = book.Styles(style3)
				sheet("D24:D26").Style = book.Styles(style3)
				sheet("F24:F26").Style = book.Styles(style3)
				sheet("D29").Style = book.Styles(style3)
				sheet("F29").Style = book.Styles(style3)
				sheet("D32").Style = book.Styles(style3)
				sheet("F32").Style = book.Styles(style3)
			End If

			If book.Styles.Contains(style4) Then
				sheet("E9:E18").Style = book.Styles(style4)
				sheet("E24:E26").Style = book.Styles(style4)
				sheet("E29").Style = book.Styles(style4)
				sheet("E32").Style = book.Styles(style4)
			End If
		End Sub
		Private Sub ApplyStyleInUnevenTableRow(ByVal style1 As String, ByVal style2 As String, ByVal style3 As String, ByVal style4 As String)
			If book.Styles.Contains(style1) Then
				sheet("B6:B8").Style = book.Styles(style1)
				sheet("B19:B23").Style = book.Styles(style1)
				sheet("B27:B28").Style = book.Styles(style1)
				sheet("B30:B31").Style = book.Styles(style1)
			End If

			If book.Styles.Contains(style2) Then
				sheet("C6:C8").Style = book.Styles(style2)
				sheet("C19:C23").Style = book.Styles(style2)
				sheet("C27:C28").Style = book.Styles(style2)
				sheet("C30:C31").Style = book.Styles(style2)
			End If

			If book.Styles.Contains(style3) Then
				sheet("D6:D8").Style = book.Styles(style3)
				sheet("F6:F8").Style = book.Styles(style3)
				sheet("D19:D23").Style = book.Styles(style3)
				sheet("F19:F23").Style = book.Styles(style3)
				sheet("D27:D28").Style = book.Styles(style3)
				sheet("F27:F28").Style = book.Styles(style3)
				sheet("D30:D31").Style = book.Styles(style3)
				sheet("F30:F31").Style = book.Styles(style3)
			End If

			If book.Styles.Contains(style4) Then
				sheet("E6:E8").Style = book.Styles(style4)
				sheet("E19:E23").Style = book.Styles(style4)
				sheet("E27:E28").Style = book.Styles(style4)
				sheet("E30:E31").Style = book.Styles(style4)
			End If
		End Sub
		Private Sub ApplyThemeInTableHeader(ByVal style1 As String, ByVal style2 As String, ByVal style3 As String)
			If book.Styles.Contains(style1) Then
				sheet("B5").Style = book.Styles(style1)
			End If

			If book.Styles.Contains(style2) Then
				sheet("C5").Style = book.Styles(style2)
				sheet("E5").Style = book.Styles(style2)
			End If

			If book.Styles.Contains(style3) Then
				sheet("D5").Style = book.Styles(style3)
				sheet("F5").Style = book.Styles(style3)
			End If
		End Sub
		Private Sub ApplyThemeInHeader(ByVal style1 As String, ByVal style2 As String)
			If book.Styles.Contains(style1) Then
				sheet("B2").Style = book.Styles(style1)
			End If

			If book.Styles.Contains(style2) Then
				sheet("B3").Style = book.Styles(style2)
			End If
		End Sub
	End Class
End Namespace

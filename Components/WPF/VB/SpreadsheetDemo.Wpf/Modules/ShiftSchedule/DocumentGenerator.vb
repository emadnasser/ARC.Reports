Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Globalization
Imports DevExpress.Spreadsheet

Namespace DevExpress.Docs.Demos
    Public Class ShiftScheduleGenerator
        Private sheet As Worksheet
        Private columns As ColumnCollection
        Private rows As RowCollection
        Private cells As CellCollection
        Private book As IWorkbook
        Private separator As Char

        Private Const shiftScheduleRowCount As Integer = 7
        Private Shared weekDays As List(Of String) = CreateWeekDays()

        Public Sub New(ByVal culture As CultureInfo)
            Me.book = New Workbook()
            Me.book.Options.Culture = culture
            InitCultureParams(culture)
        End Sub

        Public Sub New(ByVal book As IWorkbook)
            Me.book = book
            InitCultureParams(book.Options.Culture)
        End Sub
        Private Sub InitCultureParams(ByVal culture As CultureInfo)
            Me.separator = culture.TextInfo.ListSeparator.Chars(0)
        End Sub
        Public Function Generate() As IWorkbook
            Return CreateBook()
        End Function

        Private Shared Function CreateWeekDays() As List(Of String)
            Dim result As New List(Of String)()
            result.Add("Sunday")
            result.Add("Monday")
            result.Add("Tuesday")
            result.Add("Wednesday")
            result.Add("Thursday")
            result.Add("Friday")
            result.Add("Saturday")
            Return result
        End Function

        Private Function CreateBook() As IWorkbook
            InitWorkbook()

            sheet = book.Worksheets(0)
            columns = sheet.Columns
            rows = sheet.Rows
            cells = sheet.Cells

            AddStyles(book)
            SetColumnsWidth()
            MergeCells()
            CreateHeader()
            CreateShiftSchedules()
            Return book
        End Function

        Private Sub InitWorkbook()
            book.Unit = DevExpress.Office.DocumentUnit.Point
            book.Styles.DefaultStyle.Font.Name = "Calibri"
            book.Styles.DefaultStyle.Font.Size = 11

            Dim sheet As Worksheet = book.Worksheets(0)
            sheet.Name = "Shift Schedule"
            sheet.DefaultRowHeight = 15
            sheet.ActiveView.Orientation = PageOrientation.Portrait
            sheet.PrintOptions.FitToPage = True
            sheet.ActiveView.ShowGridlines = False
        End Sub

        Private Sub CreateShiftSchedules()
            Dim startRow As Integer = 7
            For Each weekDay As String In weekDays
                ApplyStylesInShiftSchedule(startRow)
                FormatCellsInShiftSchedule(startRow)
                SetBordersInShiftSchedule(startRow)
                FillShiftSchedule(startRow, weekDay)
                SetRowsHeightInShiftSchedules(startRow)

                startRow += shiftScheduleRowCount + 1
            Next weekDay
        End Sub
        Private Sub SetRowsHeightInShiftSchedules(ByVal startRow As Integer)
            sheet.Rows(startRow - 1).Height = 21
            sheet.Rows(startRow).Height = 17.45
            sheet.Rows(startRow + 1).Height = 17.45
            sheet.Rows(startRow + 2).Height = 17.45
            sheet.Rows(startRow + 3).Height = 17.45
            sheet.Rows(startRow + 4).Height = 17.45
            sheet.Rows(startRow + 5).Height = 17.45
            sheet.Rows(startRow + 6).Height = 42.75
            sheet.Rows(startRow + 7).Height = 15
        End Sub
        Private Sub CreateHeader()
            SetRowsHeightInHeader()
            FormatCellsInHeader()
            FillHeader()
        End Sub
        Private Sub FillHeader()
            cells("B2").Value = "SHIFT SCHEDULE"
            cells("K2").Value = "For the Week of:"
            cells("M2").Formula = "=NOW()"
            cells("K3").Value = "Department Name:"
        End Sub
        Private Sub FillShiftSchedule(ByVal startRow As Integer, ByVal weekDay As String)
            FillTableHeader(startRow, weekDay)
            SetArrayFormulasInShiftSchedule(startRow)
            FillTableData(startRow)
        End Sub
        Private Sub FillTableData(ByVal startRow As Integer)
            FillTableRow1(startRow)
            FillTableRow2(startRow)
            FillTableRow3(startRow)
            FillTableRow4(startRow)
            FillTableRow5(startRow)
            FillTableRow6(startRow)
        End Sub
        Private Sub FillTableRow6(ByVal startRow As Integer)
            cells("B" & (startRow + 6)).Value = "Teresa A"
            cells("H" & (startRow + 6)).Value = "cashier"
            cells("I" & (startRow + 6)).Value = "cashier"
            cells("J" & (startRow + 6)).Value = "cashier"
            cells("K" & (startRow + 6)).Value = "cashier"
        End Sub
        Private Sub FillTableRow5(ByVal startRow As Integer)
            cells("B" & (startRow + 5)).Value = "Sean P"
            cells("L" & (startRow + 5)).Value = "Sick"
        End Sub
        Private Sub FillTableRow4(ByVal startRow As Integer)
            cells("B" & (startRow + 4)).Value = "Jon M"
            cells("D" & (startRow + 4)).Value = "front desk"
            cells("E" & (startRow + 4)).Value = "front desk"
            cells("F" & (startRow + 4)).Value = "front desk"
            cells("G" & (startRow + 4)).Value = "front desk "
            cells("H" & (startRow + 4)).Value = "front desk"
            cells("I" & (startRow + 4)).Value = "front desk"
            cells("J" & (startRow + 4)).Value = "front desk"
        End Sub
        Private Sub FillTableRow3(ByVal startRow As Integer)
            cells("B" & (startRow + 3)).Value = "James S"
            cells("D" & (startRow + 3)).Value = "front desk"
            cells("E" & (startRow + 3)).Value = "front desk"
            cells("F" & (startRow + 3)).Value = "front desk"
            cells("G" & (startRow + 3)).Value = "front desk "
            cells("H" & (startRow + 3)).Value = "front desk"
            cells("I" & (startRow + 3)).Value = "front desk"
            cells("J" & (startRow + 3)).Value = "front desk"
        End Sub
        Private Sub FillTableRow2(ByVal startRow As Integer)
            cells("B" & (startRow + 2)).Value = "Tom Y"
            cells("D" & (startRow + 2)).Value = "cashier"
            cells("E" & (startRow + 2)).Value = "cashier"
            cells("F" & (startRow + 2)).Value = "cashier"
            cells("G" & (startRow + 2)).Value = "cashier"
        End Sub
        Private Sub FillTableRow1(ByVal startRow As Integer)
            cells("B" & (startRow + 1)).Value = "Kelly F"
            cells("C" & (startRow + 1)).Value = "manager"
            cells("D" & (startRow + 1)).Value = "manager"
            cells("E" & (startRow + 1)).Value = "manager"
            cells("F" & (startRow + 1)).Value = "manager"
            cells("G" & (startRow + 1)).Value = "manager"
            cells("H" & (startRow + 1)).Value = "manager"
            cells("I" & (startRow + 1)).Value = "manager"
            cells("J" & (startRow + 1)).Value = "manager"
            cells("K" & (startRow + 1)).Value = "manager"
        End Sub
        Private Sub FillTableHeader(ByVal startRow As Integer, ByVal weekDay As String)
            cells(startRow - 1, 1).Value = weekDay

            cells("C" & startRow).Formula = String.Format("=TIME(7{0}0{0}0)", separator)
            cells("D" & startRow).Formula = String.Format("=TIME(8{0}0{0}0)", separator)
            cells("E" & startRow).Formula = String.Format("=TIME(9{0}0{0}0)", separator)
            cells("F" & startRow).Formula = String.Format("=TIME(10{0}0{0}0)", separator)
            cells("G" & startRow).Formula = String.Format("=TIME(11{0}0{0}0)", separator)
            cells("H" & startRow).Formula = String.Format("=TIME(12{0}0{0}0)", separator)
            cells("I" & startRow).Formula = String.Format("=TIME(13{0}0{0}0)", separator)
            cells("J" & startRow).Formula = String.Format("=TIME(14{0}0{0}0)", separator)
            cells("K" & startRow).Formula = String.Format("=TIME(15{0}0{0}0)", separator)
            cells("L" & startRow).Value = "SICK?"
            cells("M" & startRow).Value = "TOTAL"
        End Sub
        Private Sub SetArrayFormulasInShiftSchedule(ByVal startRow As Integer)
            sheet("M" & (startRow + 1)).ArrayFormula = String.Format("=SUM(IF(ISTEXT(C" & (startRow + 1) & ":K" & (startRow + 1) & "){0}1{0}0))", separator)
            sheet("M" & (startRow + 2)).ArrayFormula = String.Format("=SUM(IF(ISTEXT(C" & (startRow + 2) & ":K" & (startRow + 2) & "){0}1{0}0))", separator)
            sheet("M" & (startRow + 3)).ArrayFormula = String.Format("=SUM(IF(ISTEXT(C" & (startRow + 3) & ":K" & (startRow + 3) & "){0}1{0}0))", separator)
            sheet("M" & (startRow + 4)).ArrayFormula = String.Format("=SUM(IF(ISTEXT(C" & (startRow + 4) & ":K" & (startRow + 4) & "){0}1{0}0))", separator)
            sheet("M" & (startRow + 5)).ArrayFormula = String.Format("=SUM(IF(ISTEXT(C" & (startRow + 5) & ":K" & (startRow + 5) & "){0}1{0}0))", separator)
            sheet("M" & (startRow + 6)).ArrayFormula = String.Format("=SUM(IF(ISTEXT(C" & (startRow + 6) & ":K" & (startRow + 6) & "){0}1{0}0))", separator)
        End Sub
        Private Sub SetRowsHeightInHeader()
            sheet("A1:A3").RowHeight = 18.75
        End Sub
        Private Sub SetColumnsWidth()
            columns(0).WidthInCharacters = 3.77
            columns(1).WidthInCharacters = 16.01
            columns(2).WidthInCharacters = 10.09
            columns(3).WidthInCharacters = 10.09
            columns(4).WidthInCharacters = 10.09
            columns(5).WidthInCharacters = 10.09
            columns(6).WidthInCharacters = 10.09
            columns(7).WidthInCharacters = 10.09
            columns(8).WidthInCharacters = 10.09
            columns(9).WidthInCharacters = 10.09
            columns(10).WidthInCharacters = 10.09
            columns(11).WidthInCharacters = 7.8
            columns(12).WidthInCharacters = 11
        End Sub
        Private Sub AddStyles(ByVal book As IWorkbook)
            Dim styles As StyleCollection = book.Styles
            Dim style1 As Style = styles.Add("Style 1")
            style1.Fill.PatternType = PatternType.Solid
            style1.Fill.BackgroundColor = Color.FromArgb(255, 246, 246, 246)

            Dim style2 As Style = styles.Add("Style 10")
            style2.Fill.PatternType = PatternType.Solid
            style2.Fill.BackgroundColor = Color.FromArgb(255, 226, 239, 251)

            Dim style3 As Style = styles.Add("Style 11")
            style3.Fill.PatternType = PatternType.Solid
            style3.Fill.BackgroundColor = Color.FromArgb(255, 232, 232, 232)

            Dim style4 As Style = styles.Add("Style 12")
            style4.Fill.PatternType = PatternType.Solid
            style4.Fill.BackgroundColor = Color.FromArgb(255, 222, 222, 222)

            Dim style5 As Style = styles.Add("Style 2")
            style5.Fill.PatternType = PatternType.Solid
            style5.Fill.BackgroundColor = Color.FromArgb(255, 249, 249, 249)

            Dim style6 As Style = styles.Add("Style 3")
            style6.Fill.PatternType = PatternType.Solid
            style6.Fill.BackgroundColor = Color.FromArgb(255, 255, 243, 196)

            Dim style7 As Style = styles.Add("Style 4")
            style7.Fill.PatternType = PatternType.Solid
            style7.Fill.BackgroundColor = Color.FromArgb(255, 255, 238, 170)

            Dim style8 As Style = styles.Add("Style 5")
            style8.Fill.PatternType = PatternType.Solid
            style8.Fill.BackgroundColor = Color.FromArgb(255, 203, 243, 175)

            Dim style9 As Style = styles.Add("Style 6")
            style9.Fill.PatternType = PatternType.Solid
            style9.Fill.BackgroundColor = Color.FromArgb(255, 219, 247, 199)

            Dim style10 As Style = styles.Add("Style 7")
            style10.Fill.PatternType = PatternType.Solid
            style10.Fill.BackgroundColor = Color.FromArgb(255, 219, 239, 255)

            Dim style11 As Style = styles.Add("Style 8")
            style11.Fill.PatternType = PatternType.Solid
            style11.Fill.BackgroundColor = Color.FromArgb(255, 230, 244, 255)

            Dim style12 As Style = styles.Add("Style 9")
            style12.Fill.PatternType = PatternType.Solid
            style12.Fill.BackgroundColor = Color.FromArgb(255, 230, 244, 255)

        End Sub
        Private Sub ApplyStylesInShiftSchedule(ByVal startRow As Integer)
            ApplyStylesInTableRow1(startRow)
            ApplyStylesInTableRow2(startRow)
            ApplyStylesInTableRow3(startRow)
            ApplyStylesInTableRow4(startRow)
            ApplyStylesInTableRow5(startRow)
            ApplyStylesInTableRow6(startRow)
        End Sub
        Private Sub ApplyStylesInTableRow6(ByVal startRow As Integer)
            sheet("B" & (startRow + 6)).Style = book.Styles("Style 1")
            sheet("C" & (startRow + 6)).Style = book.Styles("Style 2")
            sheet("D" & (startRow + 6)).Style = book.Styles("Style 1")
            sheet("E" & (startRow + 6)).Style = book.Styles("Style 2")
            sheet("F" & (startRow + 6)).Style = book.Styles("Style 1")
            sheet("G" & (startRow + 6)).Style = book.Styles("Style 2")
            sheet("H" & (startRow + 6)).Style = book.Styles("Style 5")
            sheet("I" & (startRow + 6)).Style = book.Styles("Style 6")
            sheet("J" & (startRow + 6)).Style = book.Styles("Style 5")
            sheet("K" & (startRow + 6)).Style = book.Styles("Style 6")
            sheet("L" & (startRow + 6)).Style = book.Styles("Style 1")
            sheet("M" & (startRow + 6)).Style = book.Styles("Style 2")
        End Sub
        Private Sub ApplyStylesInTableRow5(ByVal startRow As Integer)
            sheet("C" & (startRow + 5)).Style = book.Styles("Style 11")
            sheet("D" & (startRow + 5)).Style = book.Styles("Style 12")
            sheet("E" & (startRow + 5)).Style = book.Styles("Style 11")
            sheet("F" & (startRow + 5)).Style = book.Styles("Style 12")
            sheet("G" & (startRow + 5)).Style = book.Styles("Style 11")
            sheet("H" & (startRow + 5)).Style = book.Styles("Style 12")
            sheet("I" & (startRow + 5)).Style = book.Styles("Style 11")
            sheet("J" & (startRow + 5)).Style = book.Styles("Style 12")
            sheet("K" & (startRow + 5)).Style = book.Styles("Style 11")
            sheet("L" & (startRow + 5)).Style = book.Styles("Style 12")
        End Sub
        Private Sub ApplyStylesInTableRow4(ByVal startRow As Integer)
            sheet("B" & (startRow + 4)).Style = book.Styles("Style 1")
            sheet("C" & (startRow + 4)).Style = book.Styles("Style 2")
            sheet("D" & (startRow + 4)).Style = book.Styles("Style 9")
            sheet("E" & (startRow + 4)).Style = book.Styles("Style 10")
            sheet("F" & (startRow + 4)).Style = book.Styles("Style 9")
            sheet("G" & (startRow + 4)).Style = book.Styles("Style 10")
            sheet("H" & (startRow + 4)).Style = book.Styles("Style 9")
            sheet("I" & (startRow + 4)).Style = book.Styles("Style 10")
            sheet("J" & (startRow + 4)).Style = book.Styles("Style 9")
            sheet("K" & (startRow + 4)).Style = book.Styles("Style 2")
            sheet("L" & (startRow + 4)).Style = book.Styles("Style 1")
            sheet("M" & (startRow + 4)).Style = book.Styles("Style 2")
        End Sub
        Private Sub ApplyStylesInTableRow3(ByVal startRow As Integer)
            sheet("D" & (startRow + 3)).Style = book.Styles("Style 7")
            sheet("E" & (startRow + 3)).Style = book.Styles("Style 8")
            sheet("F" & (startRow + 3)).Style = book.Styles("Style 7")
            sheet("G" & (startRow + 3)).Style = book.Styles("Style 8")
            sheet("H" & (startRow + 3)).Style = book.Styles("Style 7")
            sheet("I" & (startRow + 3)).Style = book.Styles("Style 8")
            sheet("J" & (startRow + 3)).Style = book.Styles("Style 7")
        End Sub
        Private Sub ApplyStylesInTableRow2(ByVal startRow As Integer)
            sheet("B" & (startRow + 2)).Style = book.Styles("Style 1")
            sheet("C" & (startRow + 2)).Style = book.Styles("Style 2")
            sheet("D" & (startRow + 2)).Style = book.Styles("Style 5")
            sheet("E" & (startRow + 2)).Style = book.Styles("Style 6")
            sheet("F" & (startRow + 2)).Style = book.Styles("Style 5")
            sheet("G" & (startRow + 2)).Style = book.Styles("Style 6")
            sheet("H" & (startRow + 2)).Style = book.Styles("Style 1")
            sheet("I" & (startRow + 2)).Style = book.Styles("Style 2")
            sheet("J" & (startRow + 2)).Style = book.Styles("Style 1")
            sheet("K" & (startRow + 2)).Style = book.Styles("Style 2")
            sheet("L" & (startRow + 2)).Style = book.Styles("Style 1")
            sheet("M" & (startRow + 2)).Style = book.Styles("Style 2")
        End Sub
        Private Sub ApplyStylesInTableRow1(ByVal startRow As Integer)
            sheet("C" & (startRow + 1)).Style = book.Styles("Style 3")
            sheet("D" & (startRow + 1)).Style = book.Styles("Style 4")
            sheet("E" & (startRow + 1)).Style = book.Styles("Style 3")
            sheet("F" & (startRow + 1)).Style = book.Styles("Style 4")
            sheet("G" & (startRow + 1)).Style = book.Styles("Style 3")
            sheet("H" & (startRow + 1)).Style = book.Styles("Style 4")
            sheet("I" & (startRow + 1)).Style = book.Styles("Style 3")
            sheet("J" & (startRow + 1)).Style = book.Styles("Style 4")
            sheet("K" & (startRow + 1)).Style = book.Styles("Style 3")
        End Sub
        Private Sub FormatCellsInHeader()
            Dim range1 As Range = sheet("B2:G2")
            Dim rangeFormatting1 As Formatting = range1.BeginUpdateFormatting()
            rangeFormatting1.Font.Color = Color.FromArgb(255, 95, 95, 95)
            rangeFormatting1.Font.Size = 28
            rangeFormatting1.Font.Name = "Segoe UI"
            rangeFormatting1.Alignment.Vertical = SpreadsheetVerticalAlignment.Center
            range1.EndUpdateFormatting(rangeFormatting1)

            Dim range2 As Range = sheet("K2:M3")
            Dim rangeFormatting2 As Formatting = range2.BeginUpdateFormatting()
            rangeFormatting2.Font.Color = Color.FromArgb(255, 95, 95, 95)
            rangeFormatting2.Font.Size = 10
            rangeFormatting2.Font.Name = "Segoe UI"
            rangeFormatting2.NumberFormat = "m/d/yy"
            rangeFormatting2.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left
            range2.EndUpdateFormatting(rangeFormatting2)
        End Sub
        Private Sub FormatCellsInShiftSchedule(ByVal startRow As Integer)
            Dim range1 As Range = sheet("B" & startRow)
            Dim rangeFormatting1 As Formatting = range1.BeginUpdateFormatting()
            rangeFormatting1.Font.FontStyle = DevExpress.Spreadsheet.SpreadsheetFontStyle.Bold
            rangeFormatting1.Font.Color = Color.FromArgb(255, 95, 95, 95)
            rangeFormatting1.Font.Size = 14
            rangeFormatting1.Font.Name = "Segoe UI"
            rangeFormatting1.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left
            rangeFormatting1.Alignment.Indent = 1
            range1.EndUpdateFormatting(rangeFormatting1)

            Dim range2 As Range = sheet("C" & startRow & ":M" & startRow)
            Dim rangeFormatting2 As Formatting = range2.BeginUpdateFormatting()
            rangeFormatting2.Font.FontStyle = DevExpress.Spreadsheet.SpreadsheetFontStyle.Bold
            rangeFormatting2.Font.Color = Color.FromArgb(255, 183, 183, 183)
            rangeFormatting2.Font.Size = 9
            rangeFormatting2.Font.Name = "Segoe UI"
            rangeFormatting2.NumberFormat = "hh:mm AM/PM"
            range2.EndUpdateFormatting(rangeFormatting2)

            Dim range3 As Range = sheet("B" & (startRow + 1) & ":B" & (startRow + 6))
            Dim rangeFormatting3 As Formatting = range3.BeginUpdateFormatting()
            rangeFormatting3.Font.Name = "Segoe UI Semibold"
            rangeFormatting3.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left
            rangeFormatting3.Alignment.Indent = 1
            range3.EndUpdateFormatting(rangeFormatting3)

            Dim range4 As Range = sheet("C" & startRow & ":M" & (startRow + 6))
            Dim rangeFormatting4 As Formatting = range4.BeginUpdateFormatting()
            rangeFormatting4.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
            range4.EndUpdateFormatting(rangeFormatting4)

            Dim range5 As Range = sheet("C" & (startRow + 1) & ":L" & (startRow + 6))
            Dim rangeFormatting5 As Formatting = range5.BeginUpdateFormatting()
            rangeFormatting5.Font.Size = 10
            rangeFormatting5.Font.Name = "Segoe UI"
            range5.EndUpdateFormatting(rangeFormatting5)

            Dim range6 As Range = sheet("M" & (startRow + 1) & ":M" & (startRow + 6))
            Dim rangeFormatting6 As Formatting = range6.BeginUpdateFormatting()
            rangeFormatting6.Font.Name = "Segoe UI Semibold"
            rangeFormatting6.Font.Size = 11
            range6.EndUpdateFormatting(rangeFormatting6)

            Dim range7 As Range = sheet("B" & startRow & ":M" & (startRow + 6))
            Dim rangeFormatting7 As Formatting = range7.BeginUpdateFormatting()
            rangeFormatting7.Alignment.Vertical = SpreadsheetVerticalAlignment.Center
            range7.EndUpdateFormatting(rangeFormatting7)
        End Sub
        Private Sub SetBordersInShiftSchedule(ByVal startRow As Integer)
            sheet.Cells("B" & startRow).Borders.BottomBorder.Color = Color.FromArgb(255, 95, 95, 95)
            sheet.Cells("B" & startRow).Borders.BottomBorder.LineStyle = BorderLineStyle.Medium
            sheet.Cells("C" & startRow).Borders.BottomBorder.Color = Color.FromArgb(255, 143, 143, 143)
            sheet.Cells("C" & startRow).Borders.BottomBorder.LineStyle = BorderLineStyle.Medium
            sheet.Cells("D" & startRow).Borders.BottomBorder.Color = Color.FromArgb(255, 95, 95, 95)
            sheet.Cells("D" & startRow).Borders.BottomBorder.LineStyle = BorderLineStyle.Medium
            sheet.Cells("E" & startRow).Borders.BottomBorder.Color = Color.FromArgb(255, 143, 143, 143)
            sheet.Cells("E" & startRow).Borders.BottomBorder.LineStyle = BorderLineStyle.Medium
            sheet.Cells("F" & startRow).Borders.BottomBorder.Color = Color.FromArgb(255, 95, 95, 95)
            sheet.Cells("F" & startRow).Borders.BottomBorder.LineStyle = BorderLineStyle.Medium
            sheet.Cells("G" & startRow).Borders.BottomBorder.Color = Color.FromArgb(255, 143, 143, 143)
            sheet.Cells("G" & startRow).Borders.BottomBorder.LineStyle = BorderLineStyle.Medium
            sheet.Cells("H" & startRow).Borders.BottomBorder.Color = Color.FromArgb(255, 95, 95, 95)
            sheet.Cells("H" & startRow).Borders.BottomBorder.LineStyle = BorderLineStyle.Medium
            sheet.Cells("I" & startRow).Borders.BottomBorder.Color = Color.FromArgb(255, 143, 143, 143)
            sheet.Cells("I" & startRow).Borders.BottomBorder.LineStyle = BorderLineStyle.Medium
            sheet.Cells("J" & startRow).Borders.BottomBorder.Color = Color.FromArgb(255, 95, 95, 95)
            sheet.Cells("J" & startRow).Borders.BottomBorder.LineStyle = BorderLineStyle.Medium
            sheet.Cells("K" & startRow).Borders.BottomBorder.Color = Color.FromArgb(255, 143, 143, 143)
            sheet.Cells("K" & startRow).Borders.BottomBorder.LineStyle = BorderLineStyle.Medium
            sheet.Cells("L" & startRow).Borders.BottomBorder.Color = Color.FromArgb(255, 95, 95, 95)
            sheet.Cells("L" & startRow).Borders.BottomBorder.LineStyle = BorderLineStyle.Medium
            sheet.Cells("M" & startRow).Borders.BottomBorder.Color = Color.FromArgb(255, 143, 143, 143)
            sheet.Cells("M" & startRow).Borders.BottomBorder.LineStyle = BorderLineStyle.Medium
        End Sub
        Private Sub MergeCells()
            sheet("B2:G3").Merge()
        End Sub
    End Class
End Namespace

Imports System.Drawing
Imports System.Globalization
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraSpreadsheet

Namespace DevExpress.Docs.Demos
    Public Class ExpenseReportDocumentGenerator
        Private book As IWorkbook
        Private sheet As Worksheet
        Private columns As ColumnCollection
        Private rows As RowCollection
        Private cells As CellCollection
        Private shortDatePattern As String
        Private separator As Char

        Public Sub New()
            Me.book = New Workbook()
            InitCultureParams()
        End Sub
        Public Sub New(ByVal book As IWorkbook)
            Me.book = book
            InitCultureParams()
        End Sub
        Private Sub InitCultureParams()
            Dim culture As CultureInfo = Me.book.Options.Culture
            Me.shortDatePattern = culture.DateTimeFormat.ShortDatePattern
            Me.separator = culture.TextInfo.ListSeparator.Chars(0)
        End Sub
        Public Function Generate() As IWorkbook
            InitializeBook()
            Return book
        End Function

        Private Sub InitWorkbook()
            book.Unit = Office.DocumentUnit.Point

            book.Styles.DefaultStyle.Font.Name = "Segoe UI"
            book.Styles.DefaultStyle.Font.Size = 8

            sheet = book.Worksheets(0)
            columns = sheet.Columns
            rows = sheet.Rows
            cells = sheet.Cells

            sheet.DefaultRowHeight = 9.5
            sheet.Name = "Expense report"

            sheet.ActiveView.ShowGridlines = False
            sheet.ActiveView.Orientation = PageOrientation.Portrait
            sheet.PrintOptions.FitToPage = True

            sheet.DefinedNames.Add("_xlnm.Print_Area", "'Expense report'!B2:O30")
        End Sub
        Private Sub InitializeBook()
            InitWorkbook()
            SetRowHeight()
            SetColumnWidth()
            SetFont()
            CreateStyles()
            ApplyStyles()
            FormatCells()
            SetBorders()
            FillData()
            MergeCells()
        End Sub
        Private Sub SetFont()
            Dim range1 As Range = sheet("B2:O29")
            Dim rangeFormatting1 As Formatting = range1.BeginUpdateFormatting()
            rangeFormatting1.Font.Color = Color.FromArgb(255, 0, 0, 0)
            rangeFormatting1.Font.Name = "Segoe UI"
            rangeFormatting1.Font.Size = 9
            range1.EndUpdateFormatting(rangeFormatting1)
        End Sub
        Private Sub FillData()
            FillHeader()
            FillTable()
            FillFooter()
        End Sub
        Private Sub CreateStyles()
            Dim styles As StyleCollection = book.Styles

            Dim style1 As Style = styles.Add("Style 1")
            style1.Font.FontStyle = DevExpress.Spreadsheet.SpreadsheetFontStyle.Bold
            style1.Font.Color = Color.FromArgb(255, 180, 180, 180)
            style1.Font.Size = 9
            style1.Font.Name = "Segoe UI"

            Dim style2 As Style = styles.Add("Style 2")
            style2.Font.FontStyle = DevExpress.Spreadsheet.SpreadsheetFontStyle.Bold
            style2.Font.Color = Color.FromArgb(255, 52, 150, 151)
            style2.Font.Size = 9
            style2.Font.Name = "Segoe UI"

            Dim style3 As Style = styles.Add("Style 3")
            style3.Fill.PatternType = PatternType.Solid
            style3.Fill.BackgroundColor = Color.FromArgb(255, 251, 251, 251)
            style3.Font.Color = Color.FromArgb(255, 0, 0, 0)
            style3.Flags.Font = False

            Dim style4 As Style = styles.Add("Style 4")
            style4.Fill.PatternType = PatternType.Solid
            style4.Fill.BackgroundColor = Color.FromArgb(255, 237, 237, 237)
            style4.Font.Color = Color.FromArgb(255, 0, 0, 0)
            style4.Flags.Font = False

            Dim style5 As Style = styles.Add("Style 5")
            style5.Fill.PatternType = PatternType.Solid
            style5.Fill.BackgroundColor = Color.FromArgb(255, 241, 241, 241)
            style5.Font.Color = Color.FromArgb(255, 0, 0, 0)
            style5.Flags.Font = False

            Dim style6 As Style = styles.Add("Style 6")
            style6.Fill.PatternType = PatternType.Solid
            style6.Fill.BackgroundColor = Color.FromArgb(255, 242, 252, 252)
            style6.Font.Color = Color.FromArgb(255, 0, 0, 0)
            style6.Flags.Font = False

            Dim style7 As Style = styles.Add("Style 7")
            style7.Fill.PatternType = PatternType.Solid
            style7.Fill.BackgroundColor = Color.FromArgb(255, 229, 238, 238)
            style7.Font.Color = Color.FromArgb(255, 0, 0, 0)
            style7.Flags.Font = False
        End Sub
        Private Sub ApplyStyles()
            ApplyStylesInHeader()
            ApplyStylesInTable()
            ApplyStylesInFooter()
        End Sub
        Private Sub ApplyStylesInFooter()
            sheet("B28").Style = book.Styles("Style 1")
            sheet("H28").Style = book.Styles("Style 1")
        End Sub
        Private Sub ApplyStylesInTable()
            sheet("B10:O10").Style = book.Styles("Style 2")
            sheet("F26:N26").Style = book.Styles("Style 2")
            sheet("O27:O29").Style = book.Styles("Style 6")

            ApplyStylesInTableRows()
        End Sub
        Private Sub ApplyStylesInTableRows()
            For rowIndex As Integer = 11 To 25
                If rowIndex Mod 2 <> 0 Then
                    ApplyStyleInUnevenTableRow(rowIndex)
                Else
                    ApplyStyleInEvenTableRow(rowIndex)
                End If
            Next rowIndex
        End Sub
        Private Sub ApplyStyleInEvenTableRow(ByVal row As Integer)
            sheet.Cells("B" & row).Style = book.Styles("Style 4")
            sheet.Cells("D" & row).Style = book.Styles("Style 4")
            sheet.Cells("H" & row).Style = book.Styles("Style 4")
            sheet.Cells("J" & row).Style = book.Styles("Style 4")
            sheet.Cells("M" & row).Style = book.Styles("Style 4")

            sheet.Cells("C" & row).Style = book.Styles("Style 5")
            sheet.Cells("F" & row).Style = book.Styles("Style 5")
            sheet.Cells("I" & row).Style = book.Styles("Style 5")
            sheet.Cells("L" & row).Style = book.Styles("Style 5")
            sheet.Cells("N" & row).Style = book.Styles("Style 5")

            sheet.Cells("O" & row).Style = book.Styles("Style 7")
        End Sub
        Private Sub ApplyStyleInUnevenTableRow(ByVal row As Integer)
            sheet.Cells("B" & row).Style = book.Styles("Style 3")
            sheet.Cells("D" & row).Style = book.Styles("Style 3")
            sheet.Cells("H" & row).Style = book.Styles("Style 3")
            sheet.Cells("J" & row).Style = book.Styles("Style 3")
            sheet.Cells("M" & row).Style = book.Styles("Style 3")

            sheet.Cells("O" & row).Style = book.Styles("Style 6")
        End Sub
        Private Sub ApplyStylesInHeader()
            sheet("B2:B4").Style = book.Styles("Style 1")
            sheet("B7:B8").Style = book.Styles("Style 1")
            sheet("E7:E8").Style = book.Styles("Style 1")
            sheet("I7:I8").Style = book.Styles("Style 1")
        End Sub
        Private Sub FillTable()
            FillTableHeader()
            FillTableRows()

            sheet("O11:O25").Formula = "=SUM(F11:N11)"
            sheet("H26:I26").Formula = "=SUM(H10:H25)"
            sheet("L26:N26").Formula = "=SUM(L11:L25)"
            cells("J26").Formula = "=SUM(J11:K25)"
            cells("F26").Formula = "=SUM(F11:G25)"
            cells("O27").Formula = "=SUM(O11:O25)"
            cells("O29").Formula = "=(O27-O28)"

            cells("N27").Value = "Subtotal:"
            cells("N28").Value = "Advances:"
            cells("N29").Value = "TOTAL:"
        End Sub
        Private Sub FillTableRows()
            FillTableRow(11, "=Now()-14", 212340, "Business trip", 250, 130, 12.42, 50, 8, 0, 19.3)
            FillTableRow(12, "=Now()-13", 289043, "Business trip", 250, 0, 26.6, 45, 7.8, 0, 29.3)
            FillTableRow(13, "=Now()-12", 212340, "Holiday", 0, 10, 0, 58, 2.79, 90, 12.3)
            FillTableRow(14, "=Now()-11", 216049, "Holiday", 0, 30, 0, 60, 9.79, 120, 122.3)
            FillTableRow(15, "=Now()-10", 292352, "Business trip", 295.5, 150, 10.48, 45, 9.32, 0, 59.0)
            FillTableRow(16, "=Now()-9", 567384, "Business trip", 295.5, 30, 20.37, 50, 9.12, 0, 30.07)
            FillTableRow(17, "=Now()-8", 890733, "Business trip", 349, 70, 15.07, 45, 14.05, 0, 100.93)
            FillTableRow(18, "=Now()-7", 578292, "Business trip", 349, 0, 6.8, 60, 3.7, 0, 302.8)
            FillTableRow(19, "=Now()-6", 199123, "Business trip", 349, 90, 13.6, 50, 2.6, 0, 23)
            FillTableRow(20, "=Now()-5", 423509, "Holiday", 0, 0, 37.5, 60, 2.04, 104.04, 20)
            FillTableRow(21, "=Now()-4", 543288, "Holiday", 0, 90, 14.2, 70, 0.2, 60.2, 12)
            FillTableRow(22, "=Now()-3", 457382, "Business trip", 205, 125, 16, 45, 14, 0, 35.39)
            FillTableRow(23, "=Now()-2", 584839, "Business trip", 205, 0, 10.03, 40, 12.01, 0, 30)
            FillTableRow(24, "=Now()-1", 483922, "Business trip", 205, 0, 26, 55, 9.2, 0, 60)
            FillTableRow(25, "=Now()", 890763, "Business trip", 205, 125, 9.5, 45, 1.03, 0, 143)
        End Sub
        Private Sub FillTableHeader()
            cells("B10").Value = "Date"
            cells("C10").Value = "Account"
            cells("D10").Value = "Description"
            cells("F10").Value = "Hotel"
            cells("H10").Value = "Transport"
            cells("I10").Value = "Fuel"
            cells("J10").Value = "Meals"
            cells("L10").Value = "Phone"
            cells("M10").Value = "Entertainment"
            cells("N10").Value = "Misc."
            cells("O10").Value = "Total"
        End Sub
        Private Sub FillTableRow(ByVal rowIndex As Integer, ByVal [date] As String, ByVal account As Double, ByVal description As String, ByVal hotel As Double, ByVal transport As Double, ByVal fuel As Double, ByVal meals As Double, ByVal phone As Double, ByVal entertainment As Double, ByVal misc As Double)
            cells("B" & rowIndex).Formula = [date]
            cells("C" & rowIndex).Value = account
            cells("D" & rowIndex).Value = description
            cells("F" & rowIndex).Value = hotel
            cells("H" & rowIndex).Value = transport
            cells("I" & rowIndex).Value = fuel
            cells("J" & rowIndex).Value = meals
            cells("L" & rowIndex).Value = phone
            cells("M" & rowIndex).Value = entertainment
            cells("N" & rowIndex).Value = misc
        End Sub
        Private Sub SetRowHeight()
            SetRowHeightInHeader()
            SetRowHeightInTableRow()
            SetRowHeightInFooter()
        End Sub
        Private Sub SetRowHeightInFooter()
            sheet.Rows(25).Height = 31.5
            sheet.Rows(26).Height = 31.5
            sheet.Rows(27).Height = 31.5
            sheet.Rows(28).Height = 31.5
        End Sub
        Private Sub SetRowHeightInHeader()
            sheet.Rows(0).Height = 24
            sheet.Rows(1).Height = 18.75
            sheet.Rows(2).Height = 18.75
            sheet.Rows(3).Height = 18.75
            sheet.Rows(4).Height = 34.5
            sheet.Rows(5).Height = 18.75
            sheet.Rows(6).Height = 24.75
            sheet.Rows(7).Height = 17.25
            sheet.Rows(8).Height = 24.75
            sheet.Rows(9).Height = 31.5
        End Sub
        Private Sub SetRowHeightInTableRow()
            For i As Integer = 10 To 24
                sheet.Rows(i).Height = 21
            Next i
        End Sub
        Private Sub SetColumnWidth()
            sheet.Columns(0).WidthInCharacters = 2.5
            sheet.Columns(1).WidthInCharacters = 13
            sheet.Columns(2).WidthInCharacters = 11.14063
            sheet.Columns(3).WidthInCharacters = 8.140625
            sheet.Columns(4).WidthInCharacters = 4.555469
            sheet.Columns(5).WidthInCharacters = 6.570313
            sheet.Columns(6).WidthInCharacters = 6
            sheet.Columns(7).WidthInCharacters = 12
            sheet.Columns(8).WidthInCharacters = 11.85547
            sheet.Columns(9).WidthInCharacters = 3.425781
            sheet.Columns(10).WidthInCharacters = 7.710938
            sheet.Columns(11).WidthInCharacters = 11.5
            sheet.Columns(12).WidthInCharacters = 15.42578
            sheet.Columns(13).WidthInCharacters = 13
            sheet.Columns(14).WidthInCharacters = 15
        End Sub
        Private Sub FillHeader()
            cells("B2").Value = "PURPOSE:"
            cells("D2").Value = "HR-Conference"
            cells("J2").Value = "EXPENSE REPORT"
            cells("B3").Value = "STATEMENT NUMBER:"
            cells("D3").Value = 534084310
            cells("B4").Value = "PAY PERIOD:"
            Dim separator As New String(Me.separator, 1)
            cells("D4").Formula = "=CONCATENATE(""from """ & separator & "TEXT(MIN(B11:B25)" & separator & " """ & shortDatePattern & """)" & separator & " "" to """ & separator & " TEXT(MAX(B11:B25)" & separator & " """ & shortDatePattern & """))"
            cells("B6").Value = "EMPLOYEE INFORMATION:"
            cells("B7").Value = "NAME:"
            cells("C7").Value = "Tom Nilson"
            cells("E7").Value = "POSITION:"
            cells("G7").Value = "HR-manager"
            cells("I7").Value = "SSN:"
            cells("K7").Value = "078-05-1120"
            cells("B8").Value = "DEPARTMENT:"
            cells("C8").Value = "HR"
            cells("E8").Value = "MANAGER:"
            cells("G8").Value = "Nick Ellison"
            cells("I8").Value = "EMPLOYEE ID:"
            cells("K8").Value = 9547320

            sheet("O12:O25").Formula = "=SUM(F12:N12)"
            sheet("M26:N26").Formula = "=SUM(M11:M25)"
        End Sub
        Private Sub FillFooter()
            cells("B28").Value = "APPROVED:"
            cells("H28").Value = "NOTES: "
        End Sub
        Private Sub FormatCells()
            FormatCellsInHeader()
            FormatCellsInTable()
            FormatCellsInFooter()
        End Sub
        Private Sub FormatCellsInHeader()
            Dim range1 As Range = sheet("J2:O3")
            Dim rangeFormatting1 As Formatting = range1.BeginUpdateFormatting()
            rangeFormatting1.Font.Color = Color.FromArgb(255, 52, 150, 151)
            rangeFormatting1.Font.Size = 31.5
            rangeFormatting1.Font.Name = "Segoe UI Light"
            rangeFormatting1.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
            rangeFormatting1.Alignment.Vertical = SpreadsheetVerticalAlignment.Center
            range1.EndUpdateFormatting(rangeFormatting1)

            Dim range2 As Range = sheet("D2:H4")
            Dim rangeFormatting2 As Formatting = range2.BeginUpdateFormatting()
            rangeFormatting2.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left
            range2.EndUpdateFormatting(rangeFormatting2)

            Dim range3 As Range = sheet("E4:H4")
            Dim rangeFormatting3 As Formatting = range3.BeginUpdateFormatting()
            rangeFormatting3.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left
            rangeFormatting3.NumberFormat = shortDatePattern
            range3.EndUpdateFormatting(rangeFormatting3)

            Dim range4 As Range = sheet("B6")
            Dim rangeFormatting4 As Formatting = range4.BeginUpdateFormatting()
            rangeFormatting4.Font.FontStyle = DevExpress.Spreadsheet.SpreadsheetFontStyle.Bold
            rangeFormatting4.Font.Color = Color.FromArgb(255, 52, 150, 151)
            rangeFormatting4.Font.Size = 12
            range4.EndUpdateFormatting(rangeFormatting4)

            Dim range5 As Range = sheet("C6:O6")
            Dim rangeFormatting5 As Formatting = range5.BeginUpdateFormatting()
            rangeFormatting5.Font.Color = Color.FromArgb(255, 0, 0, 0)
            rangeFormatting5.Font.Name = "Segoe UI"
            range5.EndUpdateFormatting(rangeFormatting5)

            Dim range6 As Range = sheet("K7:K8")
            Dim rangeFormatting6 As Formatting = range6.BeginUpdateFormatting()
            rangeFormatting6.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left
            range6.EndUpdateFormatting(rangeFormatting6)

            Dim range7 As Range = sheet("C7:C8")
            Dim rangeFormatting7 As Formatting = range7.BeginUpdateFormatting()
            rangeFormatting7.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left
            rangeFormatting7.Alignment.Indent = 2
            range7.EndUpdateFormatting(rangeFormatting7)

            Dim range8 As Range = sheet("G7:G8")
            Dim rangeFormatting8 As Formatting = range8.BeginUpdateFormatting()
            rangeFormatting8.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left
            rangeFormatting8.Alignment.Indent = 1
            range8.EndUpdateFormatting(rangeFormatting8)
        End Sub
        Private Sub FormatCellsInTable()
            Dim range1 As Range = sheet("B10")
            Dim rangeFormatting1 As Formatting = range1.BeginUpdateFormatting()
            rangeFormatting1.Fill.PatternType = PatternType.Solid
            rangeFormatting1.Fill.BackgroundColor = Color.FromArgb(255, 251, 251, 251)
            rangeFormatting1.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
            rangeFormatting1.Alignment.Vertical = SpreadsheetVerticalAlignment.Center
            range1.EndUpdateFormatting(rangeFormatting1)

            Dim range2 As Range = sheet("C10")
            Dim rangeFormatting2 As Formatting = range2.BeginUpdateFormatting()
            rangeFormatting2.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
            rangeFormatting2.Alignment.Vertical = SpreadsheetVerticalAlignment.Center
            range2.EndUpdateFormatting(rangeFormatting2)

            Dim range3 As Range = sheet("D10:E10")
            Dim rangeFormatting3 As Formatting = range3.BeginUpdateFormatting()
            rangeFormatting3.Fill.PatternType = PatternType.Solid
            rangeFormatting3.Fill.BackgroundColor = Color.FromArgb(255, 251, 251, 251)
            rangeFormatting3.Alignment.Vertical = SpreadsheetVerticalAlignment.Center
            range3.EndUpdateFormatting(rangeFormatting3)

            Dim range4 As Range = sheet("F10:O26")
            Dim rangeFormatting4 As Formatting = range4.BeginUpdateFormatting()
            rangeFormatting4.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left
            rangeFormatting4.Alignment.Vertical = SpreadsheetVerticalAlignment.Center
            rangeFormatting4.Alignment.Indent = 1
            range4.EndUpdateFormatting(rangeFormatting4)

            Dim range5 As Range = sheet("H10")
            Dim rangeFormatting5 As Formatting = range5.BeginUpdateFormatting()
            rangeFormatting5.Fill.PatternType = PatternType.Solid
            rangeFormatting5.Fill.BackgroundColor = Color.FromArgb(255, 251, 251, 251)
            range5.EndUpdateFormatting(rangeFormatting5)

            Dim range6 As Range = sheet("J10:K10")
            Dim rangeFormatting6 As Formatting = range6.BeginUpdateFormatting()
            rangeFormatting6.Fill.PatternType = PatternType.Solid
            rangeFormatting6.Fill.BackgroundColor = Color.FromArgb(255, 251, 251, 251)
            range6.EndUpdateFormatting(rangeFormatting6)

            Dim range7 As Range = sheet("M10")
            Dim rangeFormatting7 As Formatting = range7.BeginUpdateFormatting()
            rangeFormatting7.Fill.PatternType = PatternType.Solid
            rangeFormatting7.Fill.BackgroundColor = Color.FromArgb(255, 251, 251, 251)
            range7.EndUpdateFormatting(rangeFormatting7)

            Dim range8 As Range = sheet("O10")
            Dim rangeFormatting8 As Formatting = range8.BeginUpdateFormatting()
            rangeFormatting8.Fill.PatternType = PatternType.Solid
            rangeFormatting8.Fill.BackgroundColor = Color.FromArgb(255, 242, 252, 252)
            range8.EndUpdateFormatting(rangeFormatting8)

            Dim range9 As Range = sheet("B11:B25")
            Dim rangeFormatting9 As Formatting = range9.BeginUpdateFormatting()
            rangeFormatting9.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
            rangeFormatting9.Alignment.Vertical = SpreadsheetVerticalAlignment.Center
            rangeFormatting9.NumberFormat = shortDatePattern
            range9.EndUpdateFormatting(rangeFormatting9)

            Dim range10 As Range = sheet("C11:C25")
            Dim rangeFormatting10 As Formatting = range10.BeginUpdateFormatting()
            rangeFormatting10.Font.Color = Color.FromArgb(255, 0, 0, 0)
            rangeFormatting10.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
            rangeFormatting10.Alignment.Vertical = SpreadsheetVerticalAlignment.Center
            range10.EndUpdateFormatting(rangeFormatting10)

            Dim range11 As Range = sheet("D10:E25")
            Dim rangeFormatting11 As Formatting = range11.BeginUpdateFormatting()
            rangeFormatting11.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left
            rangeFormatting11.Alignment.Vertical = SpreadsheetVerticalAlignment.Center
            rangeFormatting11.Alignment.Indent = 1
            range11.EndUpdateFormatting(rangeFormatting11)

            Dim range12 As Range = sheet("F11:O25")
            Dim rangeFormatting12 As Formatting = range12.BeginUpdateFormatting()
            rangeFormatting12.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left
            rangeFormatting12.Alignment.Vertical = SpreadsheetVerticalAlignment.Center
            rangeFormatting12.Alignment.Indent = 1
            rangeFormatting12.NumberFormat = "_(""$""* #,##0.00_);_(""$""* \(#,##0.00\);_(""$""* ""-""??_);_(_)"
            range12.EndUpdateFormatting(rangeFormatting12)

            Dim range13 As Range = sheet("O11:O29")
            Dim rangeFormatting13 As Formatting = range13.BeginUpdateFormatting()
            rangeFormatting13.Font.Color = Color.FromArgb(255, 52, 150, 151)
            range13.EndUpdateFormatting(rangeFormatting13)
        End Sub
        Private Sub FormatCellsInFooter()
            Dim range1 As Range = sheet("F26:N26")
            Dim rangeFormatting1 As Formatting = range1.BeginUpdateFormatting()
            rangeFormatting1.Fill.PatternType = PatternType.Solid
            rangeFormatting1.Fill.BackgroundColor = Color.FromArgb(255, 242, 252, 252)
            rangeFormatting1.NumberFormat = "_(""$""* #,##0.00_);_(""$""* \(#,##0.00\);_(""$""* ""-""??_);_(_)"
            range1.EndUpdateFormatting(rangeFormatting1)

            Dim range2 As Range = sheet("O27:O29")
            Dim rangeFormatting2 As Formatting = range2.BeginUpdateFormatting()
            rangeFormatting2.Font.Color = Color.FromArgb(255, 52, 150, 151)
            rangeFormatting2.Font.Size = 9
            rangeFormatting2.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left
            rangeFormatting2.Alignment.Vertical = SpreadsheetVerticalAlignment.Center
            rangeFormatting2.Alignment.Indent = 1
            rangeFormatting2.NumberFormat = "_(""$""* #,##0.00_);_(""$""* \(#,##0.00\);_(""$""* ""-""??_);_(_)"
            range2.EndUpdateFormatting(rangeFormatting2)

            Dim range3 As Range = sheet("N27:N28")
            Dim rangeFormatting3 As Formatting = range3.BeginUpdateFormatting()
            rangeFormatting3.Font.FontStyle = DevExpress.Spreadsheet.SpreadsheetFontStyle.Bold
            rangeFormatting3.Font.Color = Color.FromArgb(255, 52, 150, 151)
            rangeFormatting3.Font.Size = 9
            rangeFormatting3.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Right
            rangeFormatting3.Alignment.Vertical = SpreadsheetVerticalAlignment.Center
            rangeFormatting3.Alignment.Indent = 1
            range3.EndUpdateFormatting(rangeFormatting3)

            Dim range4 As Range = sheet("O26")
            Dim rangeFormatting4 As Formatting = range4.BeginUpdateFormatting()
            rangeFormatting4.Fill.PatternType = PatternType.Solid
            rangeFormatting4.Fill.BackgroundColor = Color.FromArgb(255, 230, 249, 249)
            range4.EndUpdateFormatting(rangeFormatting4)

            Dim range5 As Range = sheet("O26:O28")
            Dim rangeFormatting5 As Formatting = range5.BeginUpdateFormatting()
            rangeFormatting5.Font.Size = 9
            rangeFormatting5.Font.FontStyle = SpreadsheetFontStyle.Bold
            range5.EndUpdateFormatting(rangeFormatting5)

            Dim range6 As Range = sheet("N29")
            Dim rangeFormatting6 As Formatting = range6.BeginUpdateFormatting()
            rangeFormatting6.Font.FontStyle = DevExpress.Spreadsheet.SpreadsheetFontStyle.Bold
            rangeFormatting6.Font.Color = Color.FromArgb(255, 52, 150, 151)
            rangeFormatting6.Font.Size = 10.5
            rangeFormatting6.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Right
            rangeFormatting6.Alignment.Vertical = SpreadsheetVerticalAlignment.Center
            rangeFormatting6.Alignment.Indent = 1
            range6.EndUpdateFormatting(rangeFormatting6)

            Dim range7 As Range = sheet("O29")
            Dim rangeFormatting7 As Formatting = range7.BeginUpdateFormatting()
            rangeFormatting7.Font.Size = 10.5
            rangeFormatting7.Font.FontStyle = SpreadsheetFontStyle.Bold
            range7.EndUpdateFormatting(rangeFormatting7)
        End Sub
        Private Sub SetBorders()
            sheet("B10:O10").Borders.BottomBorder.Color = Color.FromArgb(255, 52, 150, 151)
            sheet("B10:O10").Borders.BottomBorder.LineStyle = BorderLineStyle.Medium

            sheet("C28:F28").Borders.BottomBorder.Color = Color.FromArgb(255, 180, 180, 180)
            sheet("C28:F28").Borders.BottomBorder.LineStyle = BorderLineStyle.Thin

            sheet("C29:F29").Borders.BottomBorder.Color = Color.FromArgb(255, 180, 180, 180)
            sheet("C29:F29").Borders.BottomBorder.LineStyle = BorderLineStyle.Thin

            sheet("I28:L28").Borders.BottomBorder.Color = Color.FromArgb(255, 180, 180, 180)
            sheet("I28:L28").Borders.BottomBorder.LineStyle = BorderLineStyle.Thin

            sheet("I29:L29").Borders.BottomBorder.Color = Color.FromArgb(255, 180, 180, 180)
            sheet("I29:L29").Borders.BottomBorder.LineStyle = BorderLineStyle.Thin
        End Sub
        Private Sub MergeCells()
            For i As Integer = 10 To 26
                sheet("D" & i & ":E" & i).Merge()
                sheet("F" & i & ":G" & i).Merge()
                sheet("J" & i & ":K" & i).Merge()
            Next i
            sheet("K8:L8").Merge()
            sheet("J2:O3").Merge()
            sheet("D4:H4").Merge()
            sheet("D3:E3").Merge()
            sheet("C28:F28").Merge()
            sheet("C29:F29").Merge()
            sheet("I28:L28").Merge()
            sheet("I29:L29").Merge()
        End Sub
    End Class
End Namespace

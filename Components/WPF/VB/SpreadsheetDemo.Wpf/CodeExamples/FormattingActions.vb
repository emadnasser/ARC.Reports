Imports System
Imports System.Drawing
Imports DevExpress.Spreadsheet
Imports System.Collections.Generic
Imports Formatting = DevExpress.Spreadsheet.Formatting

Namespace SpreadsheetExamples
    Public NotInheritable Class FormattingActions

        Private Sub New()
        End Sub


        Private Shared Sub ApplyStyle(ByVal workbook As IWorkbook)
'            #Region "#ApplyCellStyle"
            Dim worksheet As Worksheet = workbook.Worksheets(0)
            worksheet.Range("A1:O15").ColumnWidthInCharacters = 2.5
            Dim neutralGood As Style = workbook.Styles(BuiltInStyleId.Neutral)
            Dim customStyle As Style = workbook.Styles("Custom Style")
            worksheet.Rows(16).Style = neutralGood
            worksheet.Columns("R").Style = customStyle

            Dim faceCells() As String = { "G2:J2", "K3:L3", "M4", "N5:N6", "O7:O10", "N11:N12", "M13", "K14:L14", "G15:J15", "E14:F14", "D13", "C11:C12", "B7:B10", "C5:C6", "D4", "E3:F3" }
            For Each range As String In faceCells
                worksheet.Range(range).Style = neutralGood
            Next range

            Dim smileCells() As String = { "F6:G7", "J6:K7", "E11", "F12:G12", "H13:I13", "J12:K12", "L11" }
            For Each range As String In smileCells
                worksheet.Range(range).Style = customStyle
            Next range
'            #End Region ' #ApplyCellStyle
        End Sub


        Private Shared Sub CreateModifyStyle(ByVal workbook As IWorkbook)
'            #Region "CreateNewStyle"
            Dim myStyle As Style = workbook.Styles.Add("My Style")
            myStyle.BeginUpdate()
            Try
                myStyle.Font.Color = Color.Blue
                myStyle.Font.Size = 12
                myStyle.Alignment.Horizontal = DevExpress.Spreadsheet.SpreadsheetHorizontalAlignment.Center
                myStyle.Fill.BackgroundColor = Color.LightBlue
                myStyle.Fill.PatternType = PatternType.LightGray
                myStyle.Fill.PatternColor = Color.Yellow
            Finally
                myStyle.EndUpdate()
            End Try
'            #End Region ' CreateNewStyle

'            #Region "DuplicateExistingStyle"
            Dim myGoodStyle As Style = workbook.Styles.Add("My Good Style")
            myGoodStyle.CopyFrom(BuiltInStyleId.Good)
'            #End Region ' DuplicateExistingStyle

'            #Region "ModifyExistingStyle"
            Dim customStyle As Style = workbook.Styles("Custom Style")
            customStyle.BeginUpdate()
            Try
                customStyle.Fill.BackgroundColor = Color.Gold
            Finally
                customStyle.EndUpdate()
            End Try
'            #End Region ' ModifyExistingStyle
        End Sub

        Private Shared Sub FormatCell(ByVal workbook As IWorkbook)
'            #Region "#CellFormatting"
            Dim firstSheet As Worksheet = workbook.Worksheets(0)
            firstSheet.Cells("B2").Value = "Test"
            Dim cell As Cell = firstSheet.Cells("B2")
            cell.Font.Name = "MV Boli"
            cell.Font.Color = Color.Blue
            cell.Font.Size = 14
            cell.Font.FontStyle = DevExpress.Spreadsheet.SpreadsheetFontStyle.Bold
            cell.Fill.BackgroundColor = Color.LightSkyBlue
            cell.Alignment.Vertical = SpreadsheetVerticalAlignment.Center
            cell.Alignment.Horizontal = DevExpress.Spreadsheet.SpreadsheetHorizontalAlignment.Center
'            #End Region ' #CellFormatting

'            #Region "#RangeFormatting"
            Dim worksheet As Worksheet = workbook.Worksheets(0)
            worksheet.Range("C3:E6").Value = "Test"
            Dim rangeC3E6 As Range = worksheet.Range("C3:E6")
            Dim rangeC3E6Formatting As Formatting = rangeC3E6.BeginUpdateFormatting()
            rangeC3E6Formatting.Font.Name = "MV Boli"
            rangeC3E6Formatting.Font.Color = Color.Blue
            rangeC3E6Formatting.Font.Size = 14
            rangeC3E6Formatting.Font.FontStyle = DevExpress.Spreadsheet.SpreadsheetFontStyle.Bold
            rangeC3E6Formatting.Fill.BackgroundColor = Color.LightSkyBlue
            rangeC3E6Formatting.Alignment.Vertical = SpreadsheetVerticalAlignment.Center
            rangeC3E6Formatting.Alignment.Horizontal = DevExpress.Spreadsheet.SpreadsheetHorizontalAlignment.Center
            rangeC3E6.EndUpdateFormatting(rangeC3E6Formatting)
'            #End Region ' #RangeFormatting
        End Sub

        Private Shared Sub CopyFormatting(ByVal workbook As IWorkbook)
        End Sub

        Private Shared Sub SetDateFormats(ByVal workbook As IWorkbook)
'            #Region "#DateTimeFormats"
            Dim worksheet As Worksheet = workbook.Worksheets(0)
            worksheet("A2:A7").Formula = "= Now()"
            worksheet("A2:A7").NumberFormat = "mmm/dd/yyyy"
            worksheet("C2:C7").Formula = "=A2"
            worksheet("A:C").ColumnWidthInCharacters = 17
            worksheet("B2").Value = "m/d/yy"
            worksheet("C2").NumberFormat = "m/d/yy"

            worksheet("B3").Value = "d-mmm-yy"
            worksheet("C3").NumberFormat = "d-mmm-yy"

            worksheet("B4").Value = "dddd"
            worksheet("C4").NumberFormat = "dddd"
            worksheet("B5").Value = "m/d/yy h:mm"
            worksheet("C5").NumberFormat = "m/d/yy h:mm"

            worksheet("B6").Value = "h:mm AM/PM"
            worksheet("C6").NumberFormat = "h:mm AM/PM"

            worksheet("B7").Value = "h:mm:ss"
            worksheet("C7").NumberFormat = "h:mm:ss"

            Dim header As Range = worksheet.Range("A1:C1")
            header(0).Value = "Date"
            header(1).Value = "Format"
            header(2).Value = "Formatted Date"
            header.Style = workbook.Styles("Header")

            worksheet("B:B").Alignment.Indent = 2
'            #End Region ' #DateTimeFormats
        End Sub

        Private Shared Sub SetNumberFormats(ByVal workbook As IWorkbook)
'            #Region "#NumberFormats"
            Dim worksheet As Worksheet = workbook.Worksheets(0)
            worksheet.Range("C2:C9").Formula = "=A2"
            worksheet.Cells("A2").Value = 111
            worksheet.Cells("B2").Value = "#####"
            worksheet.Cells("C2").NumberFormat = "#####"
            worksheet("A3").Value = 222
            worksheet("B3").Value = "00000"
            worksheet("C3").NumberFormat = "00000"
            worksheet("A4").Value = 12345678
            worksheet("B4").Value = "#,#"
            worksheet("C4").NumberFormat = "#,#"
            worksheet("A5").Value =.126
            worksheet("B5").Value = "0.##"
            worksheet("C5").NumberFormat = "0.##"
            worksheet("A6").Value = 74.4
            worksheet("B6").Value = "##.000"
            worksheet("C6").NumberFormat = "##.000"
            worksheet("A7").Value = 1.6
            worksheet("B7").Value = "0.0%"
            worksheet("C7").NumberFormat = "0.0%"
            worksheet("A8").Value = 4321
            worksheet("B8").Value = "$#,##0.00"
            worksheet("C8").NumberFormat = "$#,##0.00"
            worksheet("A9").Value = 8.75
            worksheet("B9").Value = "# ?/?"
            worksheet("C9").NumberFormat = "# ?/?"

            Dim header As Range = worksheet.Range("A1:C1")
            header(0).Value = "Value"
            header(1).Value = "Format"
            header(2).Value = "Formatted Value"
            header.Style = workbook.Styles("Header")

            worksheet("A:C").ColumnWidthInCharacters = 17
            worksheet("B:B").Alignment.Indent = 2
'            #End Region ' #NumberFormats
        End Sub

        Private Shared Sub ChangeCellColors(ByVal workbook As IWorkbook)
'            #Region "#ColorCells"
            Dim worksheet As Worksheet = workbook.Worksheets(0)
            worksheet("A1:I13").FillColor = Color.FromArgb(255, &HF2, &HF2, &HF2)
            worksheet("B2:H12").FillColor = Color.FromArgb(255, &HD9, &HD9, &HD9)
            worksheet("C3:G11").FillColor = Color.FromArgb(255, &HBF, &HBF, &HBF)
            worksheet("D4:F10").FillColor = Color.FromArgb(255, &HA6, &HA6, &HA6)
            Dim cell As Cell = worksheet.Cells("E7")
            cell.FillColor = Color.FromArgb(255, &H80, &H80, &H80)
            cell.Value = "Text"
            cell.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
            cell.Font.Color = Color.White
'            #End Region ' #ColorCells
        End Sub

        Private Shared Sub SpecifyCellFont(ByVal workbook As IWorkbook)
'            #Region "#FontSettings"
            Dim worksheet As Worksheet = workbook.Worksheets(0)
            worksheet.Cells("A2").Value = "Times New Roman"
            worksheet.Cells("B2").Value = 14
            worksheet.Cells("C2").Value = "Blue"
            worksheet.Cells("D2").Value = "Yes"
            worksheet.Cells("E2").Value = "No"
            worksheet("A2:E2").Font.Name = "Times New Roman"
            worksheet("A2:E2").Font.Size = 14
            worksheet.Cells("C2").Font.Color = Color.Blue
            worksheet.Cells("D2").Font.FontStyle = DevExpress.Spreadsheet.SpreadsheetFontStyle.Bold
            worksheet.Cells("A3").Value = "Arial"
            worksheet.Cells("B3").Value = 12
            worksheet.Cells("C3").Value = "Chocolate"
            worksheet.Cells("D3").Value = "Yes"
            worksheet.Cells("E3").Value = "Yes"
            worksheet("A3:E3").Font.Name = "Arial"
            worksheet("A3:E3").Font.Size = 12
            worksheet.Cells("C3").Font.Color = Color.Chocolate
            worksheet.Cells("D3").Font.Bold = True
            worksheet.Cells("E3").Font.Italic = True
            worksheet.Cells("A4").Value = "Tahoma"
            worksheet.Cells("B4").Value = 16
            worksheet.Cells("C4").Value = "Red"
            worksheet.Cells("D4").Value = "No"
            worksheet.Cells("E4").Value = "Yes"
            worksheet.Range("A4:E4").Font.Name = "Tahoma"
            worksheet.Range("A4:E4").Font.Size = 16
            worksheet.Cells("C4").Font.Color = Color.Red
            worksheet.Cells("D4").Font.Bold = False
            worksheet.Cells("E4").Font.Italic = True

            Dim header As Range = worksheet.Range("A1:E1")
            header(0).Value = "Name"
            header(1).Value = "Size"
            header(2).Value = "Color"
            header(3).Value = "Bold"
            header(4).Value = "Italic"
            header.Style = workbook.Styles("Header")

            worksheet.Cells("A1").ColumnWidthInCharacters = 22
            worksheet.Cells("C3").ColumnWidthInCharacters = 12
'            #End Region ' #FontSettings
        End Sub

        Private Shared Sub AlignCellContents(ByVal workbook As IWorkbook)
'            #Region "#AlignCellContents"
            Dim worksheet As Worksheet = workbook.Worksheets(0)

            Dim range As Range = worksheet.Range("A1:A4")
            range.ColumnWidthInCharacters = 30
            workbook.Unit = DevExpress.Office.DocumentUnit.Millimeter
            range.RowHeight = 18
            Dim cellA1 As Cell = worksheet.Cells("A1")
            cellA1.Value = "Right and top"
            cellA1.Alignment.Horizontal = DevExpress.Spreadsheet.SpreadsheetHorizontalAlignment.Right
            cellA1.Alignment.Vertical = SpreadsheetVerticalAlignment.Top

            Dim cellA2 As Cell = worksheet.Cells("A2")
            cellA2.Value = "Center"
            cellA2.Alignment.Horizontal = DevExpress.Spreadsheet.SpreadsheetHorizontalAlignment.Center
            cellA2.Alignment.Vertical = SpreadsheetVerticalAlignment.Center

            Dim cellA3 As Cell = worksheet.Cells("A3")
            cellA3.Value = "Left and bottom, indent"
            cellA3.Alignment.Indent = 2

            Dim cellB3 As Cell = worksheet.Cells("A4")
            cellB3.Value = "The Alignment.WrapText property is applied to wrap the text within a cell"
            cellB3.Alignment.WrapText = True

            range(0).FillColor = Color.FromArgb(255, &HAA, &H91, &HD0)
            range(1).FillColor = Color.FromArgb(255, &HE1, &H95, &HC2)
            range(2).FillColor = Color.FromArgb(255, &HDB, &HF6, &HA3)
            range(3).FillColor = Color.FromArgb(255, &HFF, &HF6, &HA9)
'            #End Region ' #AlignCellContents
        End Sub

        Private Shared Sub AddCellBorders(ByVal workbook As IWorkbook)
'            #Region "#CellRangeBorders"
            Dim firstSheet As Worksheet = workbook.Worksheets(0)
            Dim rangeB8F13 As Range = firstSheet.Range("B8:F13")
            rangeB8F13.Borders.SetAllBorders(Color.Green, BorderLineStyle.Double)
            Dim rangeC15F18 As Range = firstSheet.Range("C15:F18")
            rangeC15F18.SetInsideBorders(Color.SkyBlue, BorderLineStyle.MediumDashed)
            rangeC15F18.Borders.SetOutsideBorders(Color.DeepSkyBlue, BorderLineStyle.Medium)
            Dim rangeD21F23 As Range = firstSheet.Range("B2:D4")
            Dim rangeD21F23Formatting As Formatting = rangeD21F23.BeginUpdateFormatting()
            Dim rangeD21F23Borders As Borders = rangeD21F23Formatting.Borders
            rangeD21F23Borders.InsideHorizontalBorders.LineStyle = BorderLineStyle.MediumDashDot
            rangeD21F23Borders.InsideHorizontalBorders.Color = Color.DarkBlue
            rangeD21F23Borders.InsideVerticalBorders.LineStyle = BorderLineStyle.MediumDashDotDot
            rangeD21F23Borders.InsideVerticalBorders.Color = Color.Blue
            rangeD21F23.EndUpdateFormatting(rangeD21F23Formatting)
            Dim rangeE25F26 As Range = firstSheet.Range("E2:F6")
            Dim rangeE25F26Formatting As Formatting = rangeE25F26.BeginUpdateFormatting()
            Dim rangeE25F26Borders As Borders = rangeE25F26Formatting.Borders
            rangeE25F26Borders.SetOutsideBorders(Color.Black, BorderLineStyle.Thick)
            rangeE25F26Borders.LeftBorder.Color = Color.Violet
            rangeE25F26Borders.TopBorder.Color = Color.Violet
            rangeE25F26Borders.RightBorder.Color = Color.DarkViolet
            rangeE25F26Borders.BottomBorder.Color = Color.DarkViolet
            rangeE25F26Borders.DiagonalBorderType = DiagonalBorderType.UpAndDown
            rangeE25F26Borders.DiagonalBorderLineStyle = BorderLineStyle.MediumDashed
            rangeE25F26Borders.DiagonalBorderColor = Color.BlueViolet
            rangeE25F26.EndUpdateFormatting(rangeE25F26Formatting)
'            #End Region ' #CellRangeBorders
        End Sub

        Private Shared Sub CustomNumberFormat(ByVal workbook As IWorkbook)
'            #Region "#CustomNumberFormat"
            Dim worksheet As Worksheet = workbook.Worksheets(0)
            worksheet("A4").Value = 555
            worksheet("A5").Value = -15.50
            worksheet("A6").Value = 0
            worksheet("A7").Value = "Name"
            worksheet("B4:B7").Formula = "=A4"
            worksheet("B4:B7").NumberFormat = "[Green]#.00;[Red]#.00;[Blue]0.00;[Magenta]""product: ""@"

            worksheet("A1").Value = "Format"
            worksheet("A3").Value = "Value"
            worksheet("B3").Value = "Formatted Value"
            worksheet("A3:G3").FillColor = Color.LightGray

            worksheet("A3:B3").Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
            worksheet("A4:B7").Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left

            Dim numberFormatDescriptionRange As Range = worksheet("C4:F7")
            worksheet("C4:C7").Value = "[Green]#.00"
            worksheet("D4:D7").Value = "[Red]#.00"
            worksheet("E4:E7").Value = "[Blue]#.00"
            worksheet("F4:F7").Value = "[Magenta]""product:""@"
            numberFormatDescriptionRange.Font.Color = Color.DimGray
            worksheet("C4").Font.Color = Color.Black
            worksheet("D5").Font.Color = Color.Black
            worksheet("E6").Font.Color = Color.Black
            worksheet("F7").Font.Color = Color.Black

            worksheet("A:C").AutoFitColumns()
            worksheet("C1").Value = worksheet.Cells("b4").NumberFormat
'            #End Region ' #CustomNumberFormat
        End Sub
    End Class
End Namespace

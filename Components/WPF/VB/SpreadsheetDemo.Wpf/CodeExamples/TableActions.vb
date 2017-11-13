Imports System
Imports System.Drawing
Imports DevExpress.Spreadsheet
Imports System.Collections.Generic
Imports Formatting = DevExpress.Spreadsheet.Formatting

Namespace SpreadsheetExamples
    Public NotInheritable Class TableActions

        Private Sub New()
        End Sub


        Private Shared Sub CreateListObject(ByVal workbook As IWorkbook)
'            #Region "#CreateTable"
            Dim worksheet As Worksheet = workbook.Worksheets(0)
            Dim table As Table = worksheet.Tables.Add(worksheet("A1:F12"), False)
            table.Style = workbook.TableStyles(BuiltInTableStyleId.TableStyleMedium20)
'            #End Region ' #CreateTable
        End Sub

        Private Shared Sub TableRanges(ByVal workbook As IWorkbook)
'            #Region "#TableRanges"
            Dim worksheet As Worksheet = workbook.Worksheets("TableRanges")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim table As Table = worksheet.Tables(0)
            Dim productColumn As TableColumn = table.Columns(0)
            Dim priceColumn As TableColumn = table.Columns(1)
            Dim quantityColumn As TableColumn = table.Columns(2)
            Dim discountColumn As TableColumn = table.Columns(3)
            Dim amountColumn As TableColumn = table.Columns.Add()
            amountColumn.Name = "Amount"
            amountColumn.Formula = "=[Price]*[Quantity]*(1-[Discount])"
            table.ShowTotals = True
            discountColumn.TotalRowLabel = "Total:"
            amountColumn.TotalRowFunction = TotalRowFunction.Sum
            priceColumn.DataRange.NumberFormat = "$#,##0.00"
            discountColumn.DataRange.NumberFormat = "0.0%"
            amountColumn.Range.NumberFormat = "$#,##0.00;$#,##0.00;"""";@"
            table.HeaderRowRange.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
            table.TotalRowRange.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
            For i As Integer = 1 To table.Columns.Count - 1
                table.Columns(i).DataRange.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
            Next i
            table.Range.ColumnWidthInCharacters = 10
            worksheet.Visible = True
'            #End Region ' #TableRanges
        End Sub
        Private Shared Sub FormatTable(ByVal workbook As IWorkbook)
'            #Region "#FormatTable"
            Dim worksheet As Worksheet = workbook.Worksheets("FormatTable")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim table As Table = worksheet.Tables(0)
            Dim tableStyles As TableStyleCollection = workbook.TableStyles
            Dim tableStyle As TableStyle = tableStyles(BuiltInTableStyleId.TableStyleMedium21)
            table.Style = tableStyle
            table.ShowHeaders = True
            table.ShowTotals = True
            table.ShowTableStyleRowStripes = False
            table.ShowTableStyleColumnStripes = True
            table.ShowTableStyleFirstColumn = True
            worksheet.Visible = True
'            #End Region ' #FormatTable
        End Sub


        Private Shared Sub CustomTableStyle(ByVal workbook As IWorkbook)
'            #Region "#CustomTableStyle"
            Dim worksheet As Worksheet = workbook.Worksheets("Custom Table Style")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim table As Table = worksheet.Tables(0)

            Dim styleName As String = "testTableStyle"
            If workbook.TableStyles.Contains(styleName) Then
                table.Style = workbook.TableStyles(styleName)
            Else

                Dim customTableStyle_Renamed As TableStyle = workbook.TableStyles.Add("testTableStyle")
                customTableStyle_Renamed.BeginUpdate()
                Try
                    customTableStyle_Renamed.TableStyleElements(TableStyleElementType.WholeTable).Font.Color = Color.FromArgb(107, 107, 107)
                    Dim headerRowStyle As TableStyleElement = customTableStyle_Renamed.TableStyleElements(TableStyleElementType.HeaderRow)
                    headerRowStyle.Fill.BackgroundColor = Color.FromArgb(64, 66, 166)
                    headerRowStyle.Font.Color = Color.White
                    headerRowStyle.Font.Bold = True
                    Dim totalRowStyle As TableStyleElement = customTableStyle_Renamed.TableStyleElements(TableStyleElementType.TotalRow)
                    totalRowStyle.Fill.BackgroundColor = Color.FromArgb(115, 193, 211)
                    totalRowStyle.Font.Color = Color.White
                    totalRowStyle.Font.Bold = True
                    Dim secondRowStripeStyle As TableStyleElement = customTableStyle_Renamed.TableStyleElements(TableStyleElementType.SecondRowStripe)
                    secondRowStripeStyle.Fill.BackgroundColor = Color.FromArgb(234, 234, 234)
                    secondRowStripeStyle.StripeSize = 1
                Finally
                    customTableStyle_Renamed.EndUpdate()
                End Try
                table.Style = customTableStyle_Renamed
            End If

            worksheet.Visible = True
'            #End Region ' #CustomTableStyle
        End Sub

        Private Shared Sub DuplicateTableStyle(ByVal workbook As IWorkbook)
'            #Region "#DuplicateTableStyle"
            Dim worksheet As Worksheet = workbook.Worksheets("Duplicate Table Style")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim table1 As Table = worksheet.Tables(0)
            Dim table2 As Table = worksheet.Tables(1)
            Dim sourceTableStyle As TableStyle = workbook.TableStyles(BuiltInTableStyleId.TableStyleMedium19)
            Dim newTableStyle As TableStyle = sourceTableStyle.Duplicate()
            newTableStyle.TableStyleElements(TableStyleElementType.HeaderRow).Clear()

            table1.Style = sourceTableStyle
            table2.Style = newTableStyle

            worksheet.Visible = True
'            #End Region ' #DuplicateTableStyle
        End Sub
    End Class
End Namespace

Imports System
Imports System.Drawing
Imports System.Globalization
Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Charts
Imports DevExpress.Spreadsheet.Drawings
Imports DevExpress.Utils

Namespace SpreadsheetExamples
    Public NotInheritable Class CreationAndDataActions

        Private Sub New()
        End Sub

        Private Shared Sub CreateChartFromRange(ByVal workbook As IWorkbook)
'            #Region "#CreateChartFromRange"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask1")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim chart As Chart = worksheet.Charts.Add(ChartType.Pie, worksheet("B2:C7"))
            chart.TopLeftCell = worksheet.Cells("E2")
            chart.BottomRightCell = worksheet.Cells("K15")
            chart.Style = ChartStyle.ColorGradient

'            #End Region ' #CreateChartFromRange
        End Sub

        Private Shared Sub CreateChartAndSelectData(ByVal workbook As IWorkbook)
'            #Region "#CreateChartAndSelectData"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask2")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim chart As Chart = worksheet.Charts.Add(ChartType.BarFullStacked)
            chart.TopLeftCell = worksheet.Cells("E3")
            chart.BottomRightCell = worksheet.Cells("K14")
            chart.SelectData(worksheet("B4:C8"), ChartDataDirection.Row)

'            #End Region ' #CreateChartAndSelectData
        End Sub

        Private Shared Sub CreateChartWithComplexRange(ByVal workbook As IWorkbook)
'            #Region "#CreateChartWithComplexRange"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask3")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim chart As Chart = worksheet.Charts.Add(ChartType.ColumnClustered)
            chart.TopLeftCell = worksheet.Cells("H2")
            chart.BottomRightCell = worksheet.Cells("N14")
            chart.Series.Add(worksheet("D2"), worksheet("B3:B6"), worksheet("D3:D6"))
            chart.Series.Add(worksheet("F2"), worksheet("B3:B6"), worksheet("F3:F6"))

'            #End Region ' #CreateChartWithComplexRange
        End Sub

        Private Shared Sub CreateChartWithLiteralData(ByVal workbook As IWorkbook)
'            #Region "#CreateChartWithLiteralData"
            Dim worksheet As Worksheet = workbook.Worksheets(0)
            worksheet.Columns(0).WidthInCharacters = 2.0
            Dim chart As Chart = worksheet.Charts.Add(ChartType.ColumnClustered)
            chart.TopLeftCell = worksheet.Cells("B2")
            chart.BottomRightCell = worksheet.Cells("H15")
            Dim serie As Series = chart.Series.Add(New CellValue() { "Jan", "Feb", "Mar", "Apr", "May", "Jun" }, New CellValue() { 50, 100, 30, 104, 87, 150 })

'            #End Region ' #CreateChartWithLiteralData
        End Sub

        Private Shared Sub ChangeDataReference(ByVal workbook As IWorkbook)
'            #Region "#ChangeDataReference"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask3")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim chart As Chart = worksheet.Charts.Add(ChartType.ColumnClustered)
            chart.TopLeftCell = worksheet.Cells("H2")
            chart.BottomRightCell = worksheet.Cells("N14")
            chart.Series.Add(worksheet("D2"), worksheet("B3:B6"), worksheet("D3:D6"))
            chart.Series.Add(worksheet("F2"), worksheet("B3:B6"), worksheet("F3:F6"))
            chart.Series(1).Values = ChartData.FromRange(worksheet("E3:E6"))
            chart.Series(1).SeriesName.SetReference(worksheet("E2"))

'            #End Region ' #ChangeDataReference
        End Sub
    End Class
End Namespace

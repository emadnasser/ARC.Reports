Imports System
Imports System.Drawing
Imports System.Globalization
Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Charts
Imports DevExpress.Spreadsheet.Drawings
Imports DevExpress.Utils

Namespace SpreadsheetExamples
    Public NotInheritable Class TitlesActions

        Private Sub New()
        End Sub

        Private Shared Sub ShowChartTitle(ByVal workbook As IWorkbook)
'            #Region "#ShowChartTitle"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask2")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim chart As Chart = worksheet.Charts.Add(ChartType.BarClustered, worksheet("B4:C7"))
            chart.TopLeftCell = worksheet.Cells("E3")
            chart.BottomRightCell = worksheet.Cells("K14")
            chart.Title.Visible = True
            chart.Legend.Visible = False
            chart.Views(0).VaryColors = True

'            #End Region ' #ShowChartTitle
        End Sub

        Private Shared Sub SetChartTitleText(ByVal workbook As IWorkbook)
'            #Region "#SetChartTitleText"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask2")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim chart As Chart = worksheet.Charts.Add(ChartType.BarClustered, worksheet("B4:C7"))
            chart.TopLeftCell = worksheet.Cells("E3")
            chart.BottomRightCell = worksheet.Cells("K14")
            chart.Title.Visible = True
            chart.Title.SetValue("Market share Q2'16")
            chart.Legend.Visible = False
            chart.Views(0).VaryColors = True

'            #End Region ' #SetChartTitleText
        End Sub

        Private Shared Sub LinkChartTitleToCellRange(ByVal workbook As IWorkbook)
'            #Region "#LinkChartTitleToCellRange"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask2")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim chart As Chart = worksheet.Charts.Add(ChartType.BarClustered, worksheet("B4:C7"))
            chart.TopLeftCell = worksheet.Cells("E3")
            chart.BottomRightCell = worksheet.Cells("K14")
            chart.Title.Visible = True
            chart.Title.SetReference(worksheet("B1"))
            chart.Legend.Visible = False
            chart.Views(0).VaryColors = True

'            #End Region ' #LinkChartTitleToCellRange
        End Sub


        Private Shared Sub ShowAxisTitle(ByVal workbook As IWorkbook)
'            #Region "#ShowAxisTitle"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask2")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim chart As Chart = worksheet.Charts.Add(ChartType.BarClustered, worksheet("B4:C7"))
            chart.TopLeftCell = worksheet.Cells("E3")
            chart.BottomRightCell = worksheet.Cells("K14")
            chart.PrimaryAxes(1).Title.Visible = True
            chart.Legend.Visible = False
            chart.Views(0).VaryColors = True

'            #End Region ' #ShowAxisTitle
        End Sub

        Private Shared Sub SetAxisTitleText(ByVal workbook As IWorkbook)
'            #Region "#SetAxisTitleText"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask2")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim chart As Chart = worksheet.Charts.Add(ChartType.BarClustered, worksheet("B4:C7"))
            chart.TopLeftCell = worksheet.Cells("E3")
            chart.BottomRightCell = worksheet.Cells("K14")
            chart.PrimaryAxes(1).Title.Visible = True
            chart.PrimaryAxes(1).Title.SetValue("Shipment in millions of units")
            chart.Legend.Visible = False
            chart.Views(0).VaryColors = True

'            #End Region ' #SetAxisTitleText
        End Sub

        Private Shared Sub LinkAxisTitleToCellRange(ByVal workbook As IWorkbook)
'            #Region "#LinkAxisTitleToCellRange"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask2")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim chart As Chart = worksheet.Charts.Add(ChartType.BarClustered, worksheet("B4:C7"))
            chart.TopLeftCell = worksheet.Cells("E3")
            chart.BottomRightCell = worksheet.Cells("K14")
            chart.PrimaryAxes(1).Title.Visible = True
            chart.PrimaryAxes(1).Title.SetReference(worksheet("C3"))
            chart.Legend.Visible = False
            chart.Views(0).VaryColors = True

'            #End Region ' #LinkAxisTitleToCellRange
        End Sub
    End Class
End Namespace

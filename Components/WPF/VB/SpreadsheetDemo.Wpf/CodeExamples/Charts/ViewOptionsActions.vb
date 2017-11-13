Imports System
Imports System.Drawing
Imports System.Globalization
Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Charts
Imports DevExpress.Spreadsheet.Drawings
Imports DevExpress.Utils

Namespace SpreadsheetExamples
    Public NotInheritable Class ViewOptionsActions

        Private Sub New()
        End Sub

        Private Shared Sub ShowAutomaticMarkers(ByVal workbook As IWorkbook)
'            #Region "#ShowAutomaticMarkers"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask5")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim chart As Chart = worksheet.Charts.Add(ChartType.Line, worksheet("B2:C8"))
            chart.TopLeftCell = worksheet.Cells("F2")
            chart.BottomRightCell = worksheet.Cells("L15")
            chart.Series(0).Marker.Symbol = MarkerStyle.Auto
            chart.Legend.Visible = False

'            #End Region ' #ShowAutomaticMarkers
        End Sub

        Private Shared Sub ShowCustomMarkers(ByVal workbook As IWorkbook)
'            #Region "#ShowCustomMarkers"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask5")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim chart As Chart = worksheet.Charts.Add(ChartType.Line, worksheet("B2:C8"))
            chart.TopLeftCell = worksheet.Cells("F2")
            chart.BottomRightCell = worksheet.Cells("L15")
            chart.Series(0).Marker.Symbol = MarkerStyle.Circle
            chart.Legend.Visible = False

'            #End Region ' #ShowCustomMarkers
        End Sub

        Private Shared Sub SetMarkerSize(ByVal workbook As IWorkbook)
'            #Region "#SetMarkerSize"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask5")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim chart As Chart = worksheet.Charts.Add(ChartType.Line, worksheet("B2:C8"))
            chart.TopLeftCell = worksheet.Cells("F2")
            chart.BottomRightCell = worksheet.Cells("L15")
            chart.Series(0).Marker.Symbol = MarkerStyle.Circle
            chart.Series(0).Marker.Size = 15
            chart.Legend.Visible = False

'            #End Region ' #SetMarkerSize
        End Sub

        Private Shared Sub SmoothLines(ByVal workbook As IWorkbook)
'            #Region "#SmoothLines"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask5")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim chart As Chart = worksheet.Charts.Add(ChartType.LineMarker, worksheet("B2:C8"))
            chart.TopLeftCell = worksheet.Cells("F2")
            chart.BottomRightCell = worksheet.Cells("L15")
            chart.Series(0).Smooth = True
            chart.Legend.Visible = False

'            #End Region ' #SmoothLines
        End Sub

        Private Shared Sub GapWidth(ByVal workbook As IWorkbook)
'            #Region "#GapWidth"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask5")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim chart As Chart = worksheet.Charts.Add(ChartType.ColumnClustered, worksheet("B2:C8"))
            chart.TopLeftCell = worksheet.Cells("F2")
            chart.BottomRightCell = worksheet.Cells("L15")
            chart.Views(0).GapWidth = 33
            chart.Legend.Visible = False

'            #End Region ' #GapWidth
        End Sub

        Private Shared Sub VaryColorsByPoint(ByVal workbook As IWorkbook)
'            #Region "#VaryColorsByPoint"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask5")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim chart As Chart = worksheet.Charts.Add(ChartType.ColumnClustered, worksheet("B2:C8"))
            chart.TopLeftCell = worksheet.Cells("F2")
            chart.BottomRightCell = worksheet.Cells("L15")
            chart.Views(0).VaryColors = True
            chart.Legend.Visible = False

'            #End Region ' #VaryColorsByPoint
        End Sub
    End Class
End Namespace

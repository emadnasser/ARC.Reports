Imports System
Imports System.Drawing
Imports System.Globalization
Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Charts
Imports DevExpress.Spreadsheet.Drawings
Imports DevExpress.Utils

Namespace SpreadsheetExamples
    Public NotInheritable Class Charts

        Private Sub New()
        End Sub

        Private Shared Sub PieChart(ByVal workbook As IWorkbook)
'            #Region "#PieChart"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask1")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim chart As Chart = worksheet.Charts.Add(ChartType.PieExploded, worksheet("B2:C7"))
            chart.TopLeftCell = worksheet.Cells("E2")
            chart.BottomRightCell = worksheet.Cells("K15")
            chart.Style = ChartStyle.ColorGradient
            chart.Legend.Visible = False
            chart.Views(0).FirstSliceAngle = 100
            Dim dataLabels As DataLabelOptions = chart.Views(0).DataLabels
            dataLabels.ShowCategoryName = True
            dataLabels.ShowPercent = True
            dataLabels.Separator = ControlChars.Lf

'            #End Region ' #PieChart
        End Sub

        Private Shared Sub BarChart(ByVal workbook As IWorkbook)
'            #Region "#BarChart"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask2")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim chart As Chart = worksheet.Charts.Add(ChartType.BarFullStacked)
            chart.TopLeftCell = worksheet.Cells("E3")
            chart.BottomRightCell = worksheet.Cells("K14")
            chart.SelectData(worksheet("B3:C8"), ChartDataDirection.Row)
            chart.Title.Visible = True
            chart.Title.SetReference(worksheet("B1"))
            chart.Legend.Position = LegendPosition.Bottom
            chart.PrimaryAxes(0).Visible = False
            chart.PrimaryAxes(1).MajorUnit = 0.2

'            #End Region ' #BarChart
        End Sub

        Private Shared Sub ColumnChart(ByVal workbook As IWorkbook)
'            #Region "#ColumnChart"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask3")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim chart As Chart = worksheet.Charts.Add(ChartType.ColumnClustered)
            chart.TopLeftCell = worksheet.Cells("H2")
            chart.BottomRightCell = worksheet.Cells("N14")
            chart.Series.Add(worksheet("D2"), worksheet("B3:B6"), worksheet("D3:D6"))
            chart.Series.Add(worksheet("F2"), worksheet("B3:B6"), worksheet("F3:F6"))
            chart.Title.Visible = True
            chart.Title.SetValue("Mobile OS market share")
            Dim axis As Axis = chart.PrimaryAxes(0)
            axis.MajorTickMarks = AxisTickMarks.None
            axis = chart.PrimaryAxes(1)
            axis.Outline.SetNoFill()
            axis.MajorTickMarks = AxisTickMarks.None
            axis.NumberFormat.FormatCode = "0%"
            axis.NumberFormat.IsSourceLinked = False
            axis.Scaling.AutoMax = False
            axis.Scaling.Max = 1
            axis.Scaling.AutoMin = False
            axis.Scaling.Min = 0
            Dim view As ChartView = chart.Views(0)
            view.GapWidth = 75
            view.DataLabels.ShowValue = True
            view.DataLabels.NumberFormat.FormatCode = "0%"
            view.DataLabels.NumberFormat.IsSourceLinked = False
            chart.Style = ChartStyle.ColorGradient

'            #End Region ' #ColumnChart
        End Sub

        Private Shared Sub ComplexChart(ByVal workbook As IWorkbook)
'            #Region "#ComplexChart"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask5")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim chart As Chart = worksheet.Charts.Add(ChartType.ColumnClustered, worksheet("B2:D8"))
            chart.TopLeftCell = worksheet.Cells("F2")
            chart.BottomRightCell = worksheet.Cells("L15")
            chart.Series(1).ChangeType(ChartType.Line)
            chart.Series(1).AxisGroup = AxisGroup.Secondary
            chart.Style = ChartStyle.ColorGradient
            chart.Legend.Position = LegendPosition.Bottom

'            #End Region ' #ComplexChart
        End Sub

        Private Shared Sub DoughnutChart(ByVal workbook As IWorkbook)
'            #Region "#DoughnutChart"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask3")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim chart As Chart = worksheet.Charts.Add(ChartType.Doughnut)
            chart.TopLeftCell = worksheet.Cells("H2")
            chart.BottomRightCell = worksheet.Cells("N14")
            chart.Series.Add(worksheet("E2"), worksheet("B3:B6"), worksheet("E3:E6"))
            chart.Title.Visible = True
            chart.Title.SetValue("Mobile OS market share Q4'15")
            chart.Views(0).HoleSize = 60
            chart.Views(0).DataLabels.ShowPercent = True

'            #End Region ' #DoughnutChart
        End Sub

        Private Shared Sub Pie3dChart(ByVal workbook As IWorkbook)
'            #Region "#Pie3dChart"
            Dim worksheet As Worksheet = workbook.Worksheets("chartTask3")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim chart As Chart = worksheet.Charts.Add(ChartType.Pie3D)
            chart.TopLeftCell = worksheet.Cells("H2")
            chart.BottomRightCell = worksheet.Cells("N14")
            chart.Series.Add(worksheet("E2"), worksheet("B3:B6"), worksheet("E3:E6"))
            chart.Series(0).CustomDataPoints.Add(2).Explosion = 25
            chart.View3D.YRotation = 255
            chart.Style = ChartStyle.ColorGradient

'            #End Region ' #Pie3dChart
        End Sub

        Private Shared Sub ScatterChart(ByVal workbook As IWorkbook)
'            #Region "#ScatterChart"
            Dim worksheet As Worksheet = workbook.Worksheets("chartScatter")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim chart As Chart = worksheet.Charts.Add(ChartType.ScatterLineMarkers, worksheet("C2:D52"))
            chart.TopLeftCell = worksheet.Cells("F2")
            chart.BottomRightCell = worksheet.Cells("L15")
            chart.Series(0).Marker.Symbol = MarkerStyle.Circle
            Dim axis As Axis = chart.PrimaryAxes(0)
            axis.Scaling.AutoMax = False
            axis.Scaling.AutoMin = False
            axis.Scaling.Max = 60.0
            axis.Scaling.Min = -60.0
            axis.MajorGridlines.Visible = True
            axis = chart.PrimaryAxes(1)
            axis.Scaling.AutoMax = False
            axis.Scaling.AutoMin = False
            axis.Scaling.Max = 50.0
            axis.Scaling.Min = -50.0
            axis.MajorUnit = 10.0

'            #End Region ' #ScatterChart
        End Sub

        Private Shared Sub StockChart(ByVal workbook As IWorkbook)
'            #Region "#StockChart"
            Dim worksheet As Worksheet = workbook.Worksheets("chartStock")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim chart As Chart = worksheet.Charts.Add(ChartType.StockOpenHighLowClose, worksheet("B2:F7"))
            chart.TopLeftCell = worksheet.Cells("H2")
            chart.BottomRightCell = worksheet.Cells("N15")
            chart.Title.Visible = True
            chart.Title.SetValue("NASDAQ:MSFT")
            chart.Legend.Visible = False
            Dim axis As Axis = chart.PrimaryAxes(1)
            axis.Scaling.AutoMax = False
            axis.Scaling.Max = 40.5
            axis.Scaling.AutoMin = False
            axis.Scaling.Min = 38.5
            axis.MajorUnit = 0.25
            axis.NumberFormat.FormatCode = "#0.00"
            axis.NumberFormat.IsSourceLinked = False
            axis.Title.Visible = True
            axis.Title.SetValue("Price in USD")

'            #End Region ' #StockChart
        End Sub
    End Class
End Namespace

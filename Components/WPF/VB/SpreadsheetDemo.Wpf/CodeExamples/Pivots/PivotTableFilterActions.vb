Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports DevExpress.Spreadsheet

Namespace SpreadsheetExamples
    Public NotInheritable Class PivotTableFilterActions

        Private Sub New()
        End Sub

        Private Shared Sub SetItemFilter(ByVal workbook As IWorkbook)
'            #Region "#Item Filter"
            Dim worksheet As Worksheet = workbook.Worksheets("Report4")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim pivotTable As PivotTable = worksheet.PivotTables("PivotTable1")
            pivotTable.Fields(1).ShowSingleItem(0)

'            #End Region ' #Item Filter
        End Sub

        Private Shared Sub SetItemVisibilityFilter(ByVal workbook As IWorkbook)
'            #Region "#Item Visibility"
            Dim worksheet As Worksheet = workbook.Worksheets("Report4")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim pivotTable As PivotTable = worksheet.PivotTables("PivotTable1")
            Dim pivotFieldItems As PivotItemCollection = pivotTable.Fields(1).Items
            pivotFieldItems(0).Visible = False

'            #End Region ' #Item Visibility
        End Sub

        Private Shared Sub SetLabelFilter(ByVal workbook As IWorkbook)
'            #Region "#Label Filter"
            Dim worksheet As Worksheet = workbook.Worksheets("Report4")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim pivotTable As PivotTable = worksheet.PivotTables("PivotTable1")
            Dim field As PivotField = pivotTable.Fields(0)
            pivotTable.Filters.Add(field, PivotFilterType.CaptionEqual, "South")

'            #End Region ' #Label Filter
        End Sub

        Private Shared Sub SetValueFilter(ByVal workbook As IWorkbook)
'            #Region "#Value Filter"
            Dim worksheet As Worksheet = workbook.Worksheets("Report4")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim pivotTable As PivotTable = worksheet.PivotTables("PivotTable1")
            Dim field As PivotField = pivotTable.Fields(1)
            pivotTable.Filters.Add(field, pivotTable.DataFields(0), PivotFilterType.ValueBetween, 6000, 13000)

'            #End Region ' #Value Filter
        End Sub

        Private Shared Sub SetTop10Filter(ByVal workbook As IWorkbook)
'            #Region "#Top10 Filter"
            Dim worksheet As Worksheet = workbook.Worksheets("Report4")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim pivotTable As PivotTable = worksheet.PivotTables("PivotTable1")
            Dim field As PivotField = pivotTable.Fields(1)
            Dim filter As PivotFilter = pivotTable.Filters.Add(field, pivotTable.DataFields(0), PivotFilterType.Count, 2)
            filter.Top10Type = PivotFilterTop10Type.Bottom

'            #End Region ' #Top10 Filter
        End Sub

        Private Shared Sub SetDateFilter(ByVal workbook As IWorkbook)
'            #Region "#Date Filter"
            Dim worksheet As Worksheet = workbook.Worksheets("Report6")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim pivotTable As PivotTable = worksheet.PivotTables("PivotTable1")
            Dim field As PivotField = pivotTable.Fields(0)
            pivotTable.Filters.Add(field, PivotFilterType.SecondQuarter)
'            #End Region ' #Date Filter
        End Sub

        Private Shared Sub SetMultipleFilter(ByVal workbook As IWorkbook)
'            #Region "#Multiple Filters"
            Dim worksheet As Worksheet = workbook.Worksheets("Report6")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim pivotTable As PivotTable = worksheet.PivotTables("PivotTable1")
            pivotTable.Behavior.AllowMultipleFieldFilters = True
            Dim field1 As PivotField = pivotTable.Fields(0)
            pivotTable.Filters.Add(field1, PivotFilterType.SecondQuarter)
            Dim filter As PivotFilter = pivotTable.Filters.Add(field1, pivotTable.DataFields(0), PivotFilterType.Count, 2)
            filter.Top10Type = PivotFilterTop10Type.Bottom

'            #End Region ' #Multiple Filters
        End Sub
    End Class
End Namespace

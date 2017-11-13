Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports DevExpress.Spreadsheet

Namespace SpreadsheetExamples
    Public NotInheritable Class PivotTableActions

        Private Sub New()
        End Sub


        Private Shared Sub CreatePivotTableFromRange(ByVal workbook As IWorkbook)
'            #Region "#Create from Range"
            Dim sourceWorksheet As Worksheet = workbook.Worksheets("Data1")
            Dim worksheet As Worksheet = workbook.Worksheets.Add()
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim pivotTable As PivotTable = worksheet.PivotTables.Add(sourceWorksheet("A1:D41"), worksheet("B2"))
            pivotTable.RowFields.Add(pivotTable.Fields("Category"))
            pivotTable.RowFields.Add(pivotTable.Fields("Product"))
            pivotTable.DataFields.Add(pivotTable.Fields("Sales"))
            pivotTable.Style = workbook.TableStyles.DefaultPivotStyle

'            #End Region ' #Create from Range
        End Sub

        Private Shared Sub CreatePivotTableFromCache(ByVal workbook As IWorkbook)
'            #Region "#Create from PivotCache"
            Dim worksheet As Worksheet = workbook.Worksheets.Add()
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim cache As PivotCache = workbook.Worksheets("Report1").PivotTables("PivotTable1").Cache
            Dim pivotTable As PivotTable = worksheet.PivotTables.Add(cache, worksheet("B2"))
            pivotTable.RowFields.Add(pivotTable.Fields("Category"))
            pivotTable.RowFields.Add(pivotTable.Fields("Product"))
            pivotTable.DataFields.Add(pivotTable.Fields("Sales"))
            pivotTable.Style = workbook.TableStyles.DefaultPivotStyle

'            #End Region ' #Create from PivotCache
        End Sub

        Private Shared Sub RemovePivotTable(ByVal workbook As IWorkbook)
'            #Region "#Remove Table"
            Dim worksheet As Worksheet = workbook.Worksheets("Report1")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim pivotTable As PivotTable = worksheet.PivotTables("PivotTable1")
            worksheet.PivotTables.Remove(pivotTable)

'            #End Region ' #Remove Table
        End Sub
        Private Shared Sub ChangePivotTableLocation(ByVal workbook As IWorkbook)
'            #Region "#Change Location"
            Dim worksheet As Worksheet = workbook.Worksheets("Report1")
            workbook.Worksheets.ActiveWorksheet = worksheet
            worksheet.PivotTables("PivotTable1").MoveTo(worksheet("A7"))

'            #End Region ' #Change Location
        End Sub
        Private Shared Sub MovePivotTableToWorksheet(ByVal workbook As IWorkbook)
'            #Region "#Move to Worksheet"
            Dim worksheet As Worksheet = workbook.Worksheets("Report1")
            Dim targetWorksheet As Worksheet = workbook.Worksheets.Add()
            worksheet.PivotTables("PivotTable1").MoveTo(targetWorksheet("B2"))
            targetWorksheet.PivotTables("PivotTable1").Cache.Refresh()
            workbook.Worksheets.ActiveWorksheet = targetWorksheet
'            #End Region ' #Move to Worksheet
        End Sub

        Private Shared Sub ChangePivotTableDataSource(ByVal workbook As IWorkbook)
'            #Region "#Change DataSource"
            Dim worksheet As Worksheet = workbook.Worksheets("Report1")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim pivotTable As PivotTable = worksheet.PivotTables("PivotTable1")
            Dim sourceWorksheet As Worksheet = workbook.Worksheets("Data2")
            pivotTable.ChangeDataSource(sourceWorksheet("A1:H6367"))
            pivotTable.RowFields.Add(pivotTable.Fields("State"))
            Dim dataField As PivotDataField = pivotTable.DataFields.Add(pivotTable.Fields("Yearly Earnings"))
            dataField.SummarizeValuesBy = PivotDataConsolidationFunction.Average

'            #End Region ' #Change DataSource
        End Sub

        Private Shared Sub ClearPivotTable(ByVal workbook As IWorkbook)
'            #Region "#Clear Table"
            Dim worksheet As Worksheet = workbook.Worksheets("Report1")
            workbook.Worksheets.ActiveWorksheet = worksheet
            worksheet.PivotTables("PivotTable1").Clear()

'            #End Region ' #Clear Table
        End Sub

        Private Shared Sub ChangeBehaviorOptions(ByVal workbook As IWorkbook)
'            #Region "#Change Behavior Options"
            Dim worksheet As Worksheet = workbook.Worksheets("Report1")
            workbook.Worksheets.ActiveWorksheet = worksheet
            worksheet.Columns("B").WidthInCharacters = 40
            Dim pivotTable As PivotTable = worksheet.PivotTables("PivotTable1")
            Dim behaviorOptions As PivotBehaviorOptions = pivotTable.Behavior
            behaviorOptions.AutoFitColumns = False
            behaviorOptions.EnableFieldList = False
            pivotTable.Cache.Refresh()

'            #End Region ' #Change Behavior Options
        End Sub
    End Class
End Namespace

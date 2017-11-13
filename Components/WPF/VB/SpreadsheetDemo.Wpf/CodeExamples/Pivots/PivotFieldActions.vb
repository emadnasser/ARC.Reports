Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports DevExpress.Spreadsheet

Namespace SpreadsheetExamples
    Public NotInheritable Class PivotFieldActions

        Private Sub New()
        End Sub


        Private Shared Sub AddFieldToAxis(ByVal workbook As IWorkbook)
'            #Region "#Add to Axis"
            Dim sourceWorksheet As Worksheet = workbook.Worksheets("Data1")
            Dim worksheet As Worksheet = workbook.Worksheets.Add()
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim pivotTable As PivotTable = worksheet.PivotTables.Add(sourceWorksheet("A1:D41"), worksheet("B2"))
            pivotTable.RowFields.Add(pivotTable.Fields("Product"))
            pivotTable.ColumnFields.Add(pivotTable.Fields("Category"))
            Dim dataField As PivotDataField = pivotTable.DataFields.Add(pivotTable.Fields("Sales"), "Sales(Sum)")
            dataField.NumberFormat = "_([$$-409]* #,##0.00_);_([$$-409]* (#,##0.00);_([$$-409]* "" - ""??_);_(@_)"
            pivotTable.PageFields.Add(pivotTable.Fields("Region"))

'            #End Region ' #Add to Axis
        End Sub

        Private Shared Sub InsertFieldToAxis(ByVal workbook As IWorkbook)
'            #Region "#Insert into Axis"
            Dim worksheet As Worksheet = workbook.Worksheets("Report1")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim pivotTable As PivotTable = worksheet.PivotTables("PivotTable1")
            pivotTable.RowFields.Insert(0, pivotTable.Fields("Region"))

'            #End Region ' #Insert into Axis
        End Sub

        Private Shared Sub MoveFieldToAxis(ByVal workbook As IWorkbook)
'            #Region "#Move to Axis"
            Dim worksheet As Worksheet = workbook.Worksheets("Report1")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim pivotTable As PivotTable = worksheet.PivotTables("PivotTable1")
            pivotTable.ColumnFields.Add(pivotTable.Fields("Region"))

'            #End Region ' #Move to Axis
        End Sub

        Private Shared Sub MoveFieldUp(ByVal workbook As IWorkbook)
'            #Region "#Move Up"
            Dim worksheet As Worksheet = workbook.Worksheets("Report3")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim pivotTable As PivotTable = worksheet.PivotTables("PivotTable1")
            pivotTable.RowFields("Category").MoveUp()

'            #End Region ' #Move Up
        End Sub

        Private Shared Sub MoveFieldDown(ByVal workbook As IWorkbook)
'            #Region "#Move Down"
            Dim worksheet As Worksheet = workbook.Worksheets("Report3")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim pivotTable As PivotTable = worksheet.PivotTables("PivotTable1")
            pivotTable.RowFields("Region").MoveDown()

'            #End Region ' #Move Down
        End Sub

        Private Shared Sub RemoveFieldFromAxis(ByVal workbook As IWorkbook)
'            #Region "#Remove from Axis"
            Dim worksheet As Worksheet = workbook.Worksheets("Report1")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim pivotTable As PivotTable = worksheet.PivotTables("PivotTable1")
            pivotTable.RowFields.Remove(pivotTable.RowFields("Product"))

'            #End Region ' #Remove from Axis
        End Sub

        Private Shared Sub SortFieldItems(ByVal workbook As IWorkbook)
'            #Region "#Sort Field Items"
            Dim worksheet As Worksheet = workbook.Worksheets("Report1")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim pivotTable As PivotTable = worksheet.PivotTables("PivotTable1")
            Dim field As PivotField = pivotTable.Fields("Product")
            field.SortType = PivotFieldSortType.Ascending
'            #End Region ' #Sort Field Items
        End Sub

        Private Shared Sub SortFieldItemsByDataField(ByVal workbook As IWorkbook)
'            #Region "#Sort Field Items by Data Field"
            Dim worksheet As Worksheet = workbook.Worksheets("Report1")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim pivotTable As PivotTable = worksheet.PivotTables("PivotTable1")
            Dim field As PivotField = pivotTable.Fields("Product")
            field.SortItems(PivotFieldSortType.Ascending, 0)
'            #End Region ' #Sort Field Items by Data Field
        End Sub

    End Class
End Namespace

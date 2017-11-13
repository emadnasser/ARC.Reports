Imports System
Imports System.Collections.Generic
Imports DevExpress.Spreadsheet

Namespace SpreadsheetExamples
    Public NotInheritable Class PivotFormattingActions

        Private Sub New()
        End Sub


        Private Shared Sub ChangeStylePivotTable(ByVal workbook As IWorkbook)
'            #Region "#Set Style"
            Dim worksheet As Worksheet = workbook.Worksheets("Report1")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim pivotTable As PivotTable = worksheet.PivotTables("PivotTable1")
            pivotTable.Style = workbook.TableStyles(BuiltInPivotStyleId.PivotStyleDark7)

'            #End Region ' #Set Style
        End Sub


        Private Shared Sub BandedColumns(ByVal workbook As IWorkbook)
'            #Region "#Banded Columns"
            Dim worksheet As Worksheet = workbook.Worksheets("Report4")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim pivotTable As PivotTable = worksheet.PivotTables("PivotTable1")
            pivotTable.BandedColumns = True

'            #End Region ' #Banded Columns
        End Sub

        Private Shared Sub BandedRows(ByVal workbook As IWorkbook)
'            #Region "#Banded Rows"
            Dim worksheet As Worksheet = workbook.Worksheets("Report4")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim pivotTable As PivotTable = worksheet.PivotTables("PivotTable1")
            pivotTable.BandedRows = True

'            #End Region ' #Banded Rows
        End Sub

        Private Shared Sub ShowColumnHeaders(ByVal workbook As IWorkbook)
'            #Region "#Column Headers"
            Dim worksheet As Worksheet = workbook.Worksheets("Report1")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim pivotTable As PivotTable = worksheet.PivotTables("PivotTable1")
            pivotTable.ShowColumnHeaders = False

'            #End Region ' #Column Headers
        End Sub

        Private Shared Sub ShowRowHeaders(ByVal workbook As IWorkbook)
'            #Region "#Row Headers"
            Dim worksheet As Worksheet = workbook.Worksheets("Report1")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim pivotTable As PivotTable = worksheet.PivotTables("PivotTable1")
            pivotTable.ColumnFields.Add(pivotTable.Fields("Region"))
            pivotTable.ShowRowHeaders = False

'            #End Region ' #Row Headers
        End Sub
    End Class
End Namespace

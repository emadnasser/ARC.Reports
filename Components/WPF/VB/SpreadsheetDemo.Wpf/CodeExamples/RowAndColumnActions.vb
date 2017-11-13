﻿Imports System
Imports DevExpress.Spreadsheet
Imports System.Drawing

Namespace SpreadsheetExamples
    Public NotInheritable Class RowAndColumnActions

        Private Sub New()
        End Sub

        Private Shared Sub InsertRows(ByVal workbook As IWorkbook)
'            #Region "#InsertRows"
            Dim worksheet As Worksheet = workbook.Worksheets(0)
            For i As Integer = 0 To 9
                worksheet.Cells(i, 0).Value = i + 1
                worksheet.Cells(0, i).Value = i + 1
            Next i
            worksheet.Rows.Insert(2)
            worksheet.Rows.Insert(7, 5)
'            #End Region ' #InsertRows
        End Sub
        Private Shared Sub InsertColumns(ByVal workbook As IWorkbook)
'            #Region "#InsertColumns"
            Dim worksheet As Worksheet = workbook.Worksheets(0)
            For i As Integer = 0 To 9
                worksheet.Cells(i, 0).Value = i + 1
                worksheet.Cells(0, i).Value = i + 1
            Next i
            worksheet.Columns.Insert(4)
            worksheet.Columns.Insert(6, 3)
'            #End Region ' #InsertColumns
        End Sub

        Private Shared Sub DeleteRowsColumns(ByVal workbook As IWorkbook)
'            #Region "#DeleteRows"
            Dim worksheet As Worksheet = workbook.Worksheets("Sheet1")
            For i As Integer = 0 To 14
                worksheet.Cells(i, 0).Value = i + 1
                worksheet.Cells(0, i).Value = i + 1
            Next i
            worksheet.Rows.Remove(1)
            worksheet.Rows(2).Delete()
            workbook.Worksheets(0).Rows.Remove(9, 3)
'            #End Region ' #DeleteRows

'            #Region "#DeleteRowsBasedOnCondition"

            Dim worksheet1 As Worksheet = workbook.Worksheets("Sheet1")
            Dim rowRemovalCondition As Func(Of Integer, Boolean) = Function(x) worksheet1.Cells(x, 0).Value.NumericValue > 3.0 AndAlso worksheet1.Cells(x, 0).Value.NumericValue < 14.0
            For i As Integer = 0 To 14
                worksheet1.Cells(i, 0).Value = i + 1
                worksheet1.Cells(0, i).Value = i + 1
            Next i
            worksheet1.Rows.Remove(7, rowRemovalCondition)


'            #End Region ' #DeleteRowsBasedOnCondition

'            #Region "#DeleteColumns"
            Dim worksheet2 As Worksheet = workbook.Worksheets("Sheet1")
            For i As Integer = 0 To 14
                worksheet2.Cells(i, 0).Value = i + 1
                worksheet2.Cells(0, i).Value = i + 1
            Next i
            worksheet2.Columns.Remove(1)
            worksheet2.Columns(2).Delete()
            workbook.Worksheets(0).Columns.Remove(9, 3)
'            #End Region ' #DeleteColumns

'            #Region "#DeleteColumnsBasedOnCondition"

            Dim sheet As Worksheet = workbook.Worksheets("Sheet1")
            Dim columnRemovalCondition As Func(Of Integer, Boolean) = Function(x) sheet.Cells(0, x).Value.NumericValue > 3.0 AndAlso sheet.Cells(0, x).Value.NumericValue < 14.0
            For i As Integer = 0 To 14
                sheet.Cells(i, 0).Value = i + 1
                sheet.Cells(0, i).Value = i + 1
            Next i
            sheet.Columns.Remove(7, columnRemovalCondition)


'            #End Region ' #DeleteColumnsBasedOnCondition
        End Sub

        Private Shared Sub CopyRowsColumns(ByVal workbook As IWorkbook)
'            #Region "CopyRows"

'            #End Region ' CopyRows

'            #Region "CopyColumns"

'            #End Region ' CopyColumns
        End Sub

        Private Shared Sub ShowHideRowsColumns(ByVal workbook As IWorkbook)
'            #Region "ShowHideRowsColumns"
            Dim worksheet As Worksheet = workbook.Worksheets(0)
            worksheet.Rows(7).Visible = False
            worksheet.Columns(3).Visible = False
            For i As Integer = 0 To 9
                worksheet.Cells(i, 0).Value = i + 1
                worksheet.Cells(0, i).Value = i + 1
            Next i
'            #End Region ' ShowHideRowsColumns
        End Sub

        Private Shared Sub SpecifyRowsHeightColumnsWidth(ByVal workbook As IWorkbook)
'            #Region "#RowHeightAndColumnWidth"
            Dim worksheet As Worksheet = workbook.Worksheets(0)
            workbook.Unit = DevExpress.Office.DocumentUnit.Point
            worksheet.Rows(1).Height = 50
            workbook.Unit = DevExpress.Office.DocumentUnit.Inch
            worksheet.Cells("C3").RowHeight = 1
            worksheet.Rows("4").Height = worksheet.Rows("2").Height
            workbook.Unit = DevExpress.Office.DocumentUnit.Point
            worksheet.DefaultRowHeight = 30
            worksheet.Columns("B").WidthInCharacters = 15
            workbook.Unit = DevExpress.Office.DocumentUnit.Millimeter
            worksheet.Columns("C").Width = 15
            workbook.Unit = DevExpress.Office.DocumentUnit.Point
            worksheet.Cells("E15").ColumnWidth = 100
            worksheet.Range("F4:H7").ColumnWidth = 70
            worksheet.Columns("J").Width = worksheet.Columns("B").Width
            worksheet.DefaultColumnWidthInPixels = 40
            worksheet.Range("B1:J1").Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
            worksheet.Cells("B1").Value = "15 characters"
            worksheet.Cells("C1").Value = "15 mm"
            worksheet.Cells("E1").Value = "100 pt"
            worksheet.Cells("F1").Value = "70 pt"
            worksheet.Cells("G1").Value = "70 pt"
            worksheet.Cells("H1").Value = "70 pt"
            worksheet.Cells("J1").Value = "15 characters"

            worksheet.Cells("A2").Value = "50 pt"
            worksheet.Cells("A3").Value = "1"""
            worksheet.Cells("A4").Value = "50 pt"
            Dim range As Range = worksheet.Range("A2:A5")
            Dim rowHeightValues As Formatting = range.BeginUpdateFormatting()
            rowHeightValues.Alignment.RotationAngle = 90
            rowHeightValues.Alignment.Vertical = SpreadsheetVerticalAlignment.Center
            rowHeightValues.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
            range.EndUpdateFormatting(rowHeightValues)

'            #End Region ' RowHeightAndColumnWidth
        End Sub
    End Class
End Namespace
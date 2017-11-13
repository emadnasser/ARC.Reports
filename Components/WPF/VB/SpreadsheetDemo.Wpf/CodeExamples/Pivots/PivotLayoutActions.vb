Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports DevExpress.Spreadsheet

Namespace SpreadsheetExamples
    Public NotInheritable Class PivotLayoutActions

        Private Sub New()
        End Sub


        Private Shared Sub ColumnGrandTotals(ByVal workbook As IWorkbook)
'            #Region "#Column Grand Totals"
            Dim worksheet As Worksheet = workbook.Worksheets("Report1")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim pivotTable As PivotTable = worksheet.PivotTables("PivotTable1")
            pivotTable.ColumnFields.Add(pivotTable.Fields("Region"))
            pivotTable.Layout.ShowColumnGrandTotals = False

'            #End Region ' #Column Grand Totals
        End Sub

        Private Shared Sub RowGrandTotals(ByVal workbook As IWorkbook)
'            #Region "#Row Grand Totals"
            Dim worksheet As Worksheet = workbook.Worksheets("Report1")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim pivotTable As PivotTable = worksheet.PivotTables("PivotTable1")
            pivotTable.ColumnFields.Add(pivotTable.Fields("Region"))
            pivotTable.Layout.ShowRowGrandTotals = False

'            #End Region ' #Row Grand Totals
        End Sub

        Private Shared Sub DataOnRows(ByVal workbook As IWorkbook)
'            #Region "#Multiple data fields"
            Dim worksheet As Worksheet = workbook.Worksheets("Report2")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim pivotTable As PivotTable = worksheet.PivotTables("PivotTable1")
            pivotTable.Layout.DataOnRows = False

'            #End Region ' #Multiple data fields
        End Sub
        Private Shared Sub MergeTitles(ByVal workbook As IWorkbook)
'   #Region "#Merge Titles"
            Dim worksheet As Worksheet = workbook.Worksheets("Report4")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim pivotTable As PivotTable = worksheet.PivotTables("PivotTable1")
            pivotTable.Layout.SetReportLayout(PivotReportLayout.Tabular)
            pivotTable.Layout.MergeTitles = True

'            #End Region ' #Merge Titles
        End Sub

  Private Shared Sub ShowAllSubtotals(ByVal workbook As IWorkbook)
'   #Region "#Show All Subtotals"
            Dim worksheet As Worksheet = workbook.Worksheets("Report1")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim pivotTable As PivotTable = worksheet.PivotTables("PivotTable1")
            pivotTable.Layout.ShowAllSubtotals(True)

'            #End Region ' #Show All Subtotals
  End Sub

  Private Shared Sub HideAllSubtotals(ByVal workbook As IWorkbook)
'   #Region "#Hide All Subtotals"
            Dim worksheet As Worksheet = workbook.Worksheets("Report1")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim pivotTable As PivotTable = worksheet.PivotTables("PivotTable1")
            pivotTable.Layout.HideAllSubtotals()

'            #End Region ' #Hide All Subtotals
  End Sub

        Private Shared Sub SetCompactReportLayout(ByVal workbook As IWorkbook)
'            #Region "#Compact Report Layout"
            Dim worksheet As Worksheet = workbook.Worksheets("Report1")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim pivotTable As PivotTable = worksheet.PivotTables("PivotTable1")
            pivotTable.Layout.SetReportLayout(PivotReportLayout.Compact)

'            #End Region ' #Compact Report Layout
        End Sub

        Private Shared Sub SetOutlineReportLayout(ByVal workbook As IWorkbook)
'            #Region "#Outline Report Layout"
            Dim worksheet As Worksheet = workbook.Worksheets("Report1")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim pivotTable As PivotTable = worksheet.PivotTables("PivotTable1")
            pivotTable.Layout.SetReportLayout(PivotReportLayout.Outline)

'            #End Region ' #Outline Report Layout
        End Sub

        Private Shared Sub SetTabularReportLayout(ByVal workbook As IWorkbook)
'            #Region "#Tabular Report Layout"
            Dim worksheet As Worksheet = workbook.Worksheets("Report1")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim pivotTable As PivotTable = worksheet.PivotTables("PivotTable1")
            pivotTable.Layout.SetReportLayout(PivotReportLayout.Tabular)

'            #End Region ' #Tabular Report Layout
        End Sub

  Private Shared Sub RepeatAllItemLabels(ByVal workbook As IWorkbook)
'   #Region "#Repeat All Item Labels"
            Dim worksheet As Worksheet = workbook.Worksheets("Report5")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim pivotTable As PivotTable = worksheet.PivotTables("PivotTable1")
            pivotTable.Layout.RepeatAllItemLabels(True)

'            #End Region ' #Repeat All Item Labels
  End Sub

  Private Shared Sub InsertBlankRows(ByVal workbook As IWorkbook)
'   #Region "#Insert Blank Rows"
            Dim worksheet As Worksheet = workbook.Worksheets("Report1")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim pivotTable As PivotTable = worksheet.PivotTables("PivotTable1")
            pivotTable.Layout.InsertBlankRows()

'            #End Region ' #Insert Blank Rows
  End Sub

  Private Shared Sub RemoveBlankRows(ByVal workbook As IWorkbook)
'   #Region "#Remove Blank Rows"
            Dim worksheet As Worksheet = workbook.Worksheets("Report1")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim pivotTable As PivotTable = worksheet.PivotTables("PivotTable1")
            pivotTable.Layout.InsertBlankRows()
            pivotTable.Layout.RemoveBlankRows()

'            #End Region ' #Remove Blank Rows
  End Sub
    End Class
End Namespace

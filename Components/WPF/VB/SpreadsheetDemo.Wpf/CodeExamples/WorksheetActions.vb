Imports System
Imports DevExpress.Spreadsheet

Namespace SpreadsheetExamples

    Public NotInheritable Class WorksheetActions

        Private Sub New()
        End Sub

        Private Shared Sub AssignActiveWorksheet(ByVal workbook As IWorkbook)
'            #Region "ActiveWorksheet"
            workbook.Worksheets.ActiveWorksheet = workbook.Worksheets("Sheet2")
'            #End Region ' ActiveWorksheet
        End Sub

        Private Shared Sub AddWorksheet(ByVal workbook As IWorkbook)
'            #Region "AddWorksheet"
            workbook.Worksheets.Add()
            workbook.Worksheets.Add().Name = "TestSheet1"

            workbook.Worksheets.Add("TestSheet2")
            workbook.Worksheets.Insert(1, "TestSheet3")

            workbook.Worksheets.Insert(3)

'            #End Region ' AddWorksheet
        End Sub

        Private Shared Sub RemoveWorksheet(ByVal workbook As IWorkbook)
'            #Region "DeleteWorksheet"
            workbook.Worksheets.Remove(workbook.Worksheets("Sheet2"))
            workbook.Worksheets.RemoveAt(0)

            Dim lastWorksheet As Worksheet = workbook.Worksheets.ActiveWorksheet
            Dim range As Range = lastWorksheet.Range("A1:B3")
            range(0).Value = "Sheets: "
            range(1).Value = workbook.Worksheets.Count
            range(2).Value = "Name:"
            range(3).Value = lastWorksheet.Name

'            #End Region ' DeleteWorksheet
        End Sub

        Private Shared Sub RenameWorksheet(ByVal workbook As IWorkbook)
'            #Region "RenameWorksheet"
            Dim sheet2 As Worksheet = workbook.Worksheets(1)
            sheet2.Name = "Renamed Sheet"
'            #End Region ' RenameWorksheet
        End Sub

        Private Shared Sub CopyWorksheetWithinWorkbook(ByVal workbook As IWorkbook)
        End Sub

        Private Shared Sub CopyWorksheetBetweenWorkbooks(ByVal workbook As IWorkbook)
        End Sub

        Private Shared Sub MoveWorksheet(ByVal workbook As IWorkbook)
'            #Region "MoveWorksheet"
            workbook.Worksheets(0).Move(workbook.Worksheets.Count - 1)
'            #End Region ' MoveWorksheet
        End Sub

        Private Shared Sub ShowHideWorksheet(ByVal workbook As IWorkbook)
'            #Region "ShowHideWorksheet"
            workbook.Worksheets("Sheet2").VisibilityType = WorksheetVisibilityType.VeryHidden
            workbook.Worksheets("Sheet3").Visible = False
'            #End Region ' ShowHideWorksheet
        End Sub

        Private Shared Sub ShowHideGridlines(ByVal workbook As IWorkbook)
'            #Region "ShowHideGridlines"
            workbook.Worksheets(0).ActiveView.ShowGridlines = False
'            #End Region ' ShowHideGridlines
        End Sub

        Private Shared Sub ShowHideHeadings(ByVal workbook As IWorkbook)
'            #Region "ShowHideHeadings"
            workbook.Worksheets(0).ActiveView.ShowHeadings = False
'            #End Region ' ShowHideHeadings
        End Sub

        Private Shared Sub SetPageOrientation(ByVal workbook As IWorkbook)
'            #Region "PageOrientation"
            workbook.Worksheets(0).ActiveView.Orientation = PageOrientation.Landscape

'            #End Region ' PageOrientation
        End Sub

        Private Shared Sub SetPageMargins(ByVal workbook As IWorkbook)
'            #Region "PageMargins"
            workbook.Unit = DevExpress.Office.DocumentUnit.Centimeter
            Dim pageMargins As Margins = workbook.Worksheets(0).ActiveView.Margins
            pageMargins.Left = 2
            pageMargins.Top = 3
            pageMargins.Right = 1
            pageMargins.Bottom = 2
            pageMargins.Header = 2
            pageMargins.Footer = 1
'            #End Region ' PageMargins
        End Sub

        Private Shared Sub SetPaperSize(ByVal workbook As IWorkbook)
'            #Region "PaperSize"
            workbook.Worksheets(0).ActiveView.PaperKind = System.Drawing.Printing.PaperKind.A4
'            #End Region ' PaperSize
        End Sub

        Private Shared Sub ZoomWorksheet(ByVal workbook As IWorkbook)
'            #Region "WorksheetZoom"
            workbook.Worksheets(0).ActiveView.Zoom = 50

'            #End Region ' WorksheetZoom
        End Sub

    End Class
End Namespace

Imports System
Imports System.IO
Imports DevExpress.Spreadsheet
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing

Namespace SpreadsheetExamples
    Public NotInheritable Class ImportExportActions

        Private Sub New()
        End Sub

        Private Shared Sub ImportArrays(ByVal workbook As IWorkbook)
'            #Region "#ImportData"
            Dim worksheet As Worksheet = workbook.Worksheets(0)

            worksheet.Cells("A1").Value = "Import an array horizontally:"
            Dim array() As String = { "AAA", "BBB", "CCC", "DDD" }
            worksheet.Import(array, 0, 1, False)

            worksheet.Cells("A3").Value = "Import a two-dimensional array:"
            Dim names(,) As String = {
                {"Ann", "Edward", "Angela", "Alex"},
                {"Rachel", "Bruce", "Barbara", "George"}
            }
            worksheet.Import(names, 2, 1)

            worksheet.Cells("A6").Value = "Import data from ArrayList vertically:"
            Dim cities As New List(Of String)()
            cities.Add("New York")
            cities.Add("Rome")
            cities.Add("Beijing")
            cities.Add("Delhi")
            worksheet.Import(cities, 5, 1, True)

            Dim sheet As Worksheet = workbook.Worksheets(0)
            sheet.Cells("A11").Value = "Import data from a DataTable:"
            Dim table As New DataTable("Employees")
            table.Columns.Add("FirstN", GetType(String))
            table.Columns.Add("LastN", GetType(String))
            table.Columns.Add("JobTitle", GetType(String))
            table.Columns.Add("Age", GetType(Int32))

            table.Rows.Add("Nancy", "Davolio", "recruiter", 32)
            table.Rows.Add("Andrew", "Fuller", "engineer", 28)
            sheet.Import(table, True, 10, 1)
            For i As Integer = 1 To 4
                worksheet.Cells(10, i).FillColor = Color.LightGray
            Next i
            sheet("A:D").AutoFitColumns()
'            #End Region ' #ImportData
        End Sub

        Private Shared Sub ExportToPdf(ByVal workbook As IWorkbook)
'            #Region "#ExportToPdf"
            Dim firstSheet As Worksheet = workbook.Worksheets(0)
            firstSheet.Cells("B2").Value = "This document is exported to the PDF format"
            Dim table As Table = firstSheet.Tables.Add(firstSheet("A1:H30"), False)
            table.Style = workbook.TableStyles(BuiltInTableStyleId.TableStyleMedium14)
            table.ShowTotals = True
            table.Columns(0).TotalRowLabel = "Total"

            Using pdfFileStream As New FileStream("Document_PDF.pdf", FileMode.Create)
                workbook.ExportToPdf(pdfFileStream)
            End Using
            System.Diagnostics.Process.Start("Document_PDF.pdf")
'            #End Region ' #ExportToPdf
        End Sub

    End Class
End Namespace

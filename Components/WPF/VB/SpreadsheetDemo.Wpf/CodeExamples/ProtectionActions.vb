﻿Imports System
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Control
Imports System.Drawing

Namespace SpreadsheetExamples
    Public NotInheritable Class ProtectionActions

        Private Sub New()
        End Sub

        Private Shared Sub ProtectWorkbook(ByVal workbook As IWorkbook)
'            #Region "#ProtectWorkbook"
            Dim worksheet As Worksheet = workbook.Worksheets("ProtectionSample")
            workbook.Worksheets.ActiveWorksheet = worksheet
            If Not workbook.IsProtected Then
                workbook.Protect("password", True, False)
            End If
            worksheet("B2").Value = "Workbook structure is now protected by password. " & ControlChars.Lf & " You cannot add, move or delete sheets until protection is removed."
            worksheet.Visible = True
'            #End Region ' #ProtectWorkbook
        End Sub
        Private Shared Sub UnprotectWorkbook(ByVal workbook As IWorkbook)
'            #Region "#UnprotectWorkbook"
            Dim worksheet As Worksheet = workbook.Worksheets("ProtectionSample")
            workbook.Worksheets.ActiveWorksheet = worksheet
            If workbook.IsProtected Then
                workbook.Unprotect("password")
            End If
            worksheet("B2").Value = "Workbook is unprotected. Sheets can be added, moved or deleted now."
            worksheet.Visible = True
'            #End Region ' #UnprotectWorkbook
        End Sub
        Private Shared Sub ProtectWorksheet(ByVal workbook As IWorkbook)
'            #Region "#ProtectWorksheet"
            Dim worksheet As Worksheet = workbook.Worksheets("ProtectionSample")
            workbook.Worksheets.ActiveWorksheet = worksheet
            If Not worksheet.IsProtected Then
                worksheet.Protect("password", WorksheetProtectionPermissions.Default)
            End If
            worksheet("B2").Value = "Worksheet is now protected by password. " & ControlChars.Lf & " You cannot edit or format cells until protection is removed." & ControlChars.Lf & "To remove protection, right click currently open sheet name in sheet tab," & ControlChars.Lf & "select ""Unprotect Sheet"" and enter ""password""."
            worksheet.Visible = True
'            #End Region ' #ProtectWorksheet
        End Sub
        Private Shared Sub UnprotectWorksheet(ByVal workbook As IWorkbook)
'            #Region "#UnprotectWorksheet"
            Dim worksheet As Worksheet = workbook.Worksheets("ProtectionSample")
            workbook.Worksheets.ActiveWorksheet = worksheet
            If worksheet.IsProtected Then
                worksheet.Unprotect("password")
            End If
            worksheet("B2").Value = "Worksheet is unprotected. You can edit and format cells now."
            worksheet.Visible = True
'            #End Region
        End Sub
        Private Shared Sub ProtectRange(ByVal workbook As IWorkbook)
'            #Region "#ProtectRange"
            Dim worksheet As Worksheet = workbook.Worksheets("ProtectionSample")
            workbook.Worksheets.ActiveWorksheet = worksheet
            worksheet("B2:J5").Borders.SetOutsideBorders(Color.Red, BorderLineStyle.Thin)
            Dim protectedRange As ProtectedRange = worksheet.ProtectedRanges.Add("My Range", worksheet("B2:J5"))
            Dim permission As New EditRangePermission()
            permission.UserName = "John"
            permission.DomainName = "MyDomain"
            permission.Deny = False
            protectedRange.SecurityDescriptor = protectedRange.CreateSecurityDescriptor(New EditRangePermission() { permission })
            protectedRange.SetPassword("letmeedit")
            If Not worksheet.IsProtected Then
                worksheet.Protect("password", WorksheetProtectionPermissions.Default)
            End If
            worksheet("B2").Value = "This cell range is now protected by password. " & ControlChars.Lf & " You cannot edit or format it until protection is removed." & ControlChars.Lf & "To remove protection, double click the range and enter ""letmeedit""."
            worksheet.Visible = True
'            #End Region ' #ProtectRange
        End Sub
    End Class
End Namespace
Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports DevExpress.Spreadsheet
Imports DevExpress.Web
Imports DevExpress.Web.Demos

Partial Public Class Features_WorksheetProtection
	Inherits OfficeDemoPage
	Private Const Password As String = "123"

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			SpreadsheetDemoUtils.HideFileTab(Spreadsheet)
			Dim filePath = Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, "Protection.xlsx")
			Spreadsheet.Open(filePath)
		End If
	End Sub

	Protected Sub CallbackPanel_Callback(ByVal sender As Object, ByVal e As EventArgs)
		Dim selectedItems As SelectedItemCollection = ProtectionOptionsList.SelectedItems
		Dim selectedPermissions As WorksheetProtectionPermissions = WorksheetProtectionPermissions.SelectLockedCells Or WorksheetProtectionPermissions.SelectUnlockedCells
		For Each item As ListEditItem In selectedItems
			selectedPermissions = selectedPermissions Or CType(System.Enum.Parse(GetType(WorksheetProtectionPermissions), item.Value.ToString()), WorksheetProtectionPermissions)
		Next item
		UnprotectAllWorksheets(Password)
		ProtectAllWorksheets(Password, selectedPermissions)
	End Sub

	Protected Sub ProtectAllWorksheets(ByVal password As String, ByVal permissions As WorksheetProtectionPermissions)
		For Each worksheet As Worksheet In Spreadsheet.Document.Worksheets
			worksheet.Protect(password, permissions)
		Next worksheet
	End Sub

	Protected Sub UnprotectAllWorksheets(ByVal password As String)
		For Each worksheet As Worksheet In Spreadsheet.Document.Worksheets
			If worksheet.IsProtected Then
				worksheet.Unprotect(password)
			End If
		Next worksheet
	End Sub
End Class

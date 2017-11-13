Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports DevExpress.Web.Demos

Partial Public Class Features_DocumentManagement
	Inherits OfficeDemoPage
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			Spreadsheet.WorkDirectory = DirectoryManagmentUtils.DocumentBrowsingFolderPath
			Spreadsheet.SettingsDocumentSelector.UploadSettings.Enabled = Not Utils.IsSiteMode
			Dim filePath = Path.Combine(Spreadsheet.WorkDirectory, "BreakevenAnalysis.xlsx")
			Spreadsheet.Open(filePath)
		End If
		If Spreadsheet.WorkDirectory <> DirectoryManagmentUtils.DocumentBrowsingFolderPath Then
			DirectoryManagmentUtils.AssertTimeout()
		End If
	End Sub
End Class

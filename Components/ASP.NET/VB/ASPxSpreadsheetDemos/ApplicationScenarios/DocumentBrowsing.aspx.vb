Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Linq
Imports DevExpress.Web
Imports DevExpress.Web.Demos

Partial Public Class ApplicationScenarios_DocumentBrowsing
	Inherits OfficeDemoPage
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		SpreadsheetDemoUtils.HideFileTab(Spreadsheet)

		If (Not IsPostBack) Then
			Spreadsheet.WorkDirectory = DirectoryManagmentUtils.DocumentBrowsingFolderPath
			FileManager.Settings.RootFolder = DirectoryManagmentUtils.DocumentBrowsingFolderPath
			Dim file As FileManagerFile = FileManager.SelectedFolder.GetFiles().FirstOrDefault()
			If file IsNot Nothing Then
				FileManager.SelectedFile = file
				Spreadsheet.Open(file.FullName)
			End If
		End If
		If Spreadsheet.WorkDirectory <> DirectoryManagmentUtils.DocumentBrowsingFolderPath Then
			DirectoryManagmentUtils.AssertTimeout()
		End If
	End Sub
	Protected Sub Spreadsheet_Callback(ByVal source As Object, ByVal e As CallbackEventArgsBase)
		If FileManager.SelectedFile IsNot Nothing Then
			Spreadsheet.Open(FileManager.SelectedFile.FullName)
		End If
	End Sub
	Protected Sub FileManager_FileUploading(ByVal sender As Object, ByVal e As FileManagerFileUploadEventArgs)
		e.Cancel = Utils.IsSiteMode
		e.ErrorText = Utils.GetReadOnlyMessageText()
	End Sub
End Class

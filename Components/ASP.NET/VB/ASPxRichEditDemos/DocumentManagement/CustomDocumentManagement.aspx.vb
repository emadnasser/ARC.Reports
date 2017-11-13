Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Linq
Imports System.Web
Imports DevExpress.Web
Imports DevExpress.Web.Demos

Partial Public Class RichEditDemoCustomDocumentManagement
	Inherits OfficeDemoPage
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			FileManager.Settings.RootFolder = DirectoryManagmentUtils.DocumentBrowsingFolderPath
			Dim file As FileManagerFile = FileManager.SelectedFolder.GetFiles().FirstOrDefault()
			If file IsNot Nothing Then
				FileManager.SelectedFile = file
				DemoRichEdit.Open(file.FullName)
			End If
		End If
	End Sub
	Protected Sub DemoRichEdit_Callback(ByVal sender As Object, ByVal e As CallbackEventArgsBase)
		If FileManager.SelectedFile IsNot Nothing Then
			DemoRichEdit.Open(FileManager.SelectedFile.FullName)
		End If
	End Sub
	Protected Sub FileManager_FileUploading(ByVal sender As Object, ByVal e As FileManagerFileUploadEventArgs)
		e.Cancel = Utils.IsSiteMode
		e.ErrorText = Utils.GetReadOnlyMessageText()
	End Sub
	Protected Sub DemoRichEdit_PreRender(ByVal sender As Object, ByVal e As EventArgs)
		DemoRichEdit.Focus()
	End Sub
	Protected Sub FileManager_Load(ByVal sender As Object, ByVal e As EventArgs)
		If FileManager.Settings.RootFolder <> DirectoryManagmentUtils.DocumentBrowsingFolderPath Then
			DirectoryManagmentUtils.AssertTimeout()
		End If
	End Sub
End Class

Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class FileManager_MultipleFileSelection
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If IsPostBack Then
			Dim selectedViewMode As FileListView = CType(System.Enum.Parse(GetType(FileListView), ddlViewMode.SelectedItem.Value.ToString()), FileListView)
			If (Not ASPxFileManager1.SettingsFileList.View.Equals(selectedViewMode)) Then
				ASPxFileManager1.SettingsFileList.View = selectedViewMode
			End If
		End If
	End Sub
End Class

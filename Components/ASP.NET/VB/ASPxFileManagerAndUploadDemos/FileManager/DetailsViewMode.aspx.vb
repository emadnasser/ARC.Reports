Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Partial Public Class FileManager_GridViewMode
	Inherits Page
	Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)

	End Sub
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If IsPostBack Then
			fileManager.SettingsFileList.DetailsViewSettings.AllowColumnResize = allowColumnResize.Checked
			fileManager.SettingsFileList.DetailsViewSettings.AllowColumnDragDrop = allowColumnDragDrop.Checked
			fileManager.SettingsFileList.DetailsViewSettings.AllowColumnSort = allowColumnSort.Checked
			fileManager.SettingsFileList.DetailsViewSettings.ShowHeaderFilterButton = showHeaderFilterButton.Checked
		End If
	End Sub
End Class

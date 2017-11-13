Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports DevExpress.Web
Imports DevExpress.Web.Demos


Partial Public Class Editing_BatchEditing
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		VerticalGrid.Settings.HeaderAreaWidth = If(Utils.IsLargeTheme, 170, 150)
		VerticalGrid.SettingsEditing.BatchEditSettings.StartEditAction = CType(System.Enum.Parse(GetType(GridViewBatchStartEditAction), StartEditActionCombo.Text, True), GridViewBatchStartEditAction)
		VerticalGrid.SettingsEditing.BatchEditSettings.HighlightDeletedRecords = cbHighlightDeletedItems.Checked
	End Sub
End Class

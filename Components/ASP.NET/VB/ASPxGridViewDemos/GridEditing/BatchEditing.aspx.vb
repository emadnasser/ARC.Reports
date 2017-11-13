Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web

Partial Public Class GridEditing_BatchEditing
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Grid.SettingsEditing.BatchEditSettings.EditMode = CType(System.Enum.Parse(GetType(GridViewBatchEditMode), EditModeCombo.Text, True), GridViewBatchEditMode)
		Grid.SettingsEditing.BatchEditSettings.StartEditAction = CType(System.Enum.Parse(GetType(GridViewBatchStartEditAction), StartEditActionCombo.Text, True), GridViewBatchStartEditAction)
		Grid.SettingsEditing.BatchEditSettings.HighlightDeletedRows = cbHighlightDeletedRows.Checked
	End Sub
End Class

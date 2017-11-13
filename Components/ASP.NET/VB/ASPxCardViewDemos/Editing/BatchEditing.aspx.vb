Imports Microsoft.VisualBasic
Imports DevExpress.Web
Imports System
Imports System.Web.UI

Partial Public Class Editing_BatchEditing
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		CardView.SettingsEditing.BatchEditSettings.EditMode = CType(System.Enum.Parse(GetType(CardViewBatchEditMode), EditModeCombo.Text, True), CardViewBatchEditMode)
		CardView.SettingsEditing.BatchEditSettings.StartEditAction = CType(System.Enum.Parse(GetType(GridViewBatchStartEditAction), StartEditActionCombo.Text, True), GridViewBatchStartEditAction)
		CardView.SettingsEditing.BatchEditSettings.HighlightDeletedCards = cbHighlightDeletedCards.Checked
	End Sub
End Class


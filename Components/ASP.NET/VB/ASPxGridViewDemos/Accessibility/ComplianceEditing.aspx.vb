Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class Accessibility_ComplianceEditing
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
	End Sub

	Protected Sub rblEditMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		grid.SettingsEditing.Mode = CType(System.Enum.Parse(GetType(GridViewEditingMode), rblEditMode.SelectedItem.Text), GridViewEditingMode)
	End Sub

	Protected Overrides Sub OnPreRender(ByVal e As EventArgs)
		MyBase.OnPreRender(e)
		Dim commandColumn = TryCast(grid.Columns(0), GridViewCommandColumn)
		commandColumn.Visible = Not Object.Equals(grid.SettingsEditing.Mode, GridViewEditingMode.Batch)
		grid.StartEdit(1)
	End Sub
End Class

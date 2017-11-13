Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web
Imports System.Web.UI

Partial Public Class GridEditing_EditModes
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			Dim names() As String = System.Enum.GetNames(GetType(GridViewEditingMode))
			For Each name As String In names
				ddlEditMode.Items.Add(name)
			Next name
			ddlEditMode.Text = grid.SettingsEditing.Mode.ToString()
			grid.StartEdit(1)
		End If
	End Sub
	Protected Sub ddlEditMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		Dim mode As GridViewEditingMode = CType(System.Enum.Parse(GetType(GridViewEditingMode), ddlEditMode.Text), GridViewEditingMode)
		grid.SettingsEditing.Mode = mode
		Dim commandColumn = TryCast(grid.Columns(0), GridViewCommandColumn)
		commandColumn.Visible = Not Object.Equals(mode, GridViewEditingMode.Batch)
	End Sub
	Protected Sub grid_CustomCallback(ByVal sender As Object, ByVal e As ASPxGridViewCustomCallbackEventArgs)
		Dim index As Integer = -1
		If Integer.TryParse(e.Parameters, index) Then
			grid.SettingsEditing.Mode = CType(index, GridViewEditingMode)
		End If
	End Sub
End Class

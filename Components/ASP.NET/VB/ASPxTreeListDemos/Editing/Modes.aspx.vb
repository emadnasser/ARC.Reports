Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web.ASPxTreeList
Imports System.Web.UI

Partial Public Class Editing_Modes
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			Dim values As Array = System.Enum.GetValues(GetType(TreeListEditMode))
			For Each value As Object In values
				cmbMode.Items.Add(System.Enum.GetName(GetType(TreeListEditMode), value), CInt(Fix(value)))
			Next value
			cmbMode.Value = treeList.SettingsEditing.Mode.ToString()
			NewsGroupDataProvider.Restore()
			treeList.DataBind()
			treeList.ExpandToLevel(3)
			treeList.StartEdit("2")
		End If
		treeList.SettingsEditing.AllowNodeDragDrop = chkDragging.Checked
	End Sub
	Protected Sub cmbMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		treeList.SettingsEditing.Mode = CType(cmbMode.SelectedItem.Value, TreeListEditMode)
	End Sub
End Class

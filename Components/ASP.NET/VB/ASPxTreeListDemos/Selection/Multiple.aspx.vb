Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web.ASPxTreeList
Imports System.Web.UI

Partial Public Class Selection_Multiple
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			treeList.DataBind()
			treeList.ExpandToLevel(2)
		End If
		If treeList.SettingsSelection.Recursive <> chkRecursive.Checked Then
			treeList.SettingsSelection.Recursive = chkRecursive.Checked
			treeList.UnselectAll()
		End If
		treeList.SettingsSelection.Recursive = chkRecursive.Checked
		treeList.SettingsSelection.AllowSelectAll = chkAllowAll.Checked
		countLiteral.Text = treeList.SelectionCount.ToString()
	End Sub

	Protected Sub treeList_CustomDataCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxTreeList.TreeListCustomDataCallbackEventArgs)
		e.Result = treeList.SelectionCount.ToString()
	End Sub
	Protected Sub cmbMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		If cmbMode.SelectedIndex > 0 Then
			treeList.UnselectAll()
		End If
		SetNodeSelectionSettings()
	End Sub
	Protected Sub treeList_DataBound(ByVal sender As Object, ByVal e As EventArgs)
		SetNodeSelectionSettings()
	End Sub

	Private Sub SetNodeSelectionSettings()
		Dim iterator As TreeListNodeIterator = treeList.CreateNodeIterator()
		Dim node As TreeListNode
		Do
			node = iterator.GetNext()
			If node Is Nothing Then
				Exit Do
			End If
			Select Case cmbMode.SelectedIndex
				Case 1
					node.AllowSelect = Not node.HasChildren
				Case 2
					node.AllowSelect = node.HasChildren
				Case 3
					node.AllowSelect = node.Level > 2
			End Select
		Loop
	End Sub
End Class

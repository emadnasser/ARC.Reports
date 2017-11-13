Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web
Imports DevExpress.Web.ASPxTreeList
Imports DevExpress.Web.Data

Partial Public Class Editing_EditFormTemplate
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			NewsGroupDataProvider.Restore()
			treeList.DataBind()
			treeList.ExpandToLevel(3)
			treeList.StartEdit("1")
		End If
		treeList.SettingsEditing.Mode = If(chkPopEditForm.Checked, TreeListEditMode.PopupEditForm, TreeListEditMode.EditFormAndDisplayNode)
	End Sub
	Protected Sub treeList_NodeUpdating(ByVal sender As Object, ByVal e As ASPxDataUpdatingEventArgs)
		e.NewValues("Text") = ExtractMemoValue()
	End Sub
	Protected Sub treeList_NodeInserting(ByVal sender As Object, ByVal e As ASPxDataInsertingEventArgs)
		e.NewValues("Text") = ExtractMemoValue()
	End Sub
	Private Function ExtractMemoValue() As String
		Dim pageControl As ASPxPageControl = TryCast(treeList.FindEditFormTemplateControl("tabs"), ASPxPageControl)
		Dim memo As ASPxMemo = TryCast(pageControl.TabPages(1).FindControl("message"), ASPxMemo)
		Return memo.Text
	End Function
End Class

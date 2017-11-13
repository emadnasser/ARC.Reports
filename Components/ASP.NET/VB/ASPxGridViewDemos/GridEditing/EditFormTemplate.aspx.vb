Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web.Data
Imports DevExpress.Web

Partial Public Class GridEditing_EditFormTemplate
	Inherits Page

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			grid.StartEdit(2)
		End If
		grid.SettingsEditing.Mode = If(chkPopup.Checked, GridViewEditingMode.PopupEditForm, GridViewEditingMode.EditFormAndDisplayRow)
	End Sub

	Protected Sub grid_RowUpdating(ByVal sender As Object, ByVal e As ASPxDataUpdatingEventArgs)
		e.NewValues("Notes") = GetMemoText()
	End Sub
	Protected Sub grid_RowInserting(ByVal sender As Object, ByVal e As ASPxDataInsertingEventArgs)
		e.NewValues("Notes") = GetMemoText()
	End Sub
	Protected Function GetMemoText() As String
		Dim pageControl As ASPxPageControl = TryCast(grid.FindEditFormTemplateControl("pageControl"), ASPxPageControl)
		Dim memo As ASPxMemo = TryCast(pageControl.FindControl("notesEditor"), ASPxMemo)
		Return memo.Text
	End Function
End Class

Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class GridEditing_PopupEditForm
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			grid.StartEdit(2)
		End If
	End Sub
	Protected Sub chkMemoLocation_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
		Dim column As GridViewDataColumn = TryCast(grid.Columns("Notes"), GridViewDataColumn)
		If column Is Nothing Then
			Return
		End If
		If chkMemoLocation.Checked Then
			column.EditFormSettings.VisibleIndex = 100
			column.EditFormSettings.ColumnSpan = 3
			column.EditFormSettings.RowSpan = 1
		Else
			column.EditFormSettings.VisibleIndex = 2
			column.EditFormSettings.RowSpan = 4
			column.EditFormSettings.ColumnSpan = 1
		End If
		If grid.IsEditing Then
			Dim prevIndex As Integer = grid.EditingRowVisibleIndex
			grid.CancelEdit()
			grid.StartEdit(If(prevIndex < 0, 0, prevIndex))
		End If
	End Sub
	Protected Sub chkShowAsModal_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
		grid.SettingsPopup.EditForm.Modal = chkShowAsModal.Checked
	End Sub
End Class

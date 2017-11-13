Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Data
Imports DevExpress.Web.Demos
Imports DevExpress.Web

Partial Public Class PopupMenu
	Inherits Page
	Private ReadOnly Property CurrentPopupAction() As PopupAction
		Get
			Return CType(System.Enum.Parse(GetType(PopupAction), ddlPopupAction.SelectedItem.Value.ToString()), PopupAction)
		End Get
	End Property

	Private ReadOnly Property CurrentPopupHorizontalAlign() As PopupHorizontalAlign
		Get
			Return CType(System.Enum.Parse(GetType(PopupHorizontalAlign), ddlHorizontalAlign.SelectedItem.Value.ToString()), PopupHorizontalAlign)
		End Get
	End Property

	Private ReadOnly Property CurrentPopupVerticalAlign() As PopupVerticalAlign
		Get
			Return CType(System.Enum.Parse(GetType(PopupVerticalAlign), ddlVerticalAlign.SelectedItem.Value.ToString()), PopupVerticalAlign)
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Utils.RegisterCssLink(Me, "~/Menu/CSS/PopupMenu.css")
		If (Not IsPostBack) Then
			ddlPopupAction.Value = ASPxPopupMenu1.PopupAction.ToString()
		End If
		ASPxWebControl.RegisterBaseScript(Page)
	End Sub

	Protected Sub ASPxPopupMenu1_ItemClick(ByVal sender As Object, ByVal e As MenuItemEventArgs)
		If e.Item Is Nothing Then
			Return
		End If
		GridView1.ClearSort()
		Dim clickedColumn As GridViewDataColumn = CType(GridView1.Columns(e.Item.Name), GridViewDataColumn)
		GridView1.SortBy(clickedColumn, ColumnSortOrder.Ascending)
	End Sub

	Protected Sub GridView1_PreRender(ByVal sender As Object, ByVal e As EventArgs)
		For Each column As GridViewColumn In GridView1.Columns
			Dim dataColumn As GridViewDataColumn = TryCast(column, GridViewDataColumn)
			column.CellStyle.Font.Bold = dataColumn.SortOrder <> ColumnSortOrder.None
		Next column
	End Sub

	Protected Sub ddlPopupAction_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		ASPxPopupMenu1.PopupAction = CurrentPopupAction
	End Sub

	Protected Sub ddlHorizontalAlign_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		ASPxPopupMenu1.PopupHorizontalAlign = CurrentPopupHorizontalAlign
	End Sub

	Protected Sub ddlVerticalAlign_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		ASPxPopupMenu1.PopupVerticalAlign = CurrentPopupVerticalAlign
	End Sub
End Class

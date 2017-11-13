Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class Selection_AdvancedSelection
	Inherits Page
	Private ReadOnly Property ComandColumn() As GridViewCommandColumn
		Get
			Return CType(grid.Columns(0), GridViewCommandColumn)
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			selectAllMode.DataSource = System.Enum.GetValues(GetType(GridViewSelectAllCheckBoxMode))
			selectAllMode.DataBind()
			selectAllMode.SelectedIndex = 1
		End If
	End Sub
	Protected Sub GridView_CustomJSProperties(ByVal sender As Object, ByVal e As ASPxGridViewClientJSPropertiesEventArgs)
		e.Properties("cpVisibleRowCount") = grid.VisibleRowCount
		e.Properties("cpFilteredRowCountWithoutPage") = GetFilteredRowCountWithoutPage()
	End Sub
	Protected Sub SelectAllMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		grid.Selection.UnselectAll()
		ComandColumn.SelectAllCheckboxMode = CType(System.Enum.Parse(GetType(GridViewSelectAllCheckBoxMode), selectAllMode.Text), GridViewSelectAllCheckBoxMode)
	End Sub
	Protected Sub lnkSelectAllRows_Load(ByVal sender As Object, ByVal e As EventArgs)
		CType(sender, ASPxHyperLink).Visible = ComandColumn.SelectAllCheckboxMode <> GridViewSelectAllCheckBoxMode.AllPages
	End Sub
	Protected Sub lnkClearSelection_Load(ByVal sender As Object, ByVal e As EventArgs)
		CType(sender, ASPxHyperLink).Visible = ComandColumn.SelectAllCheckboxMode <> GridViewSelectAllCheckBoxMode.AllPages
	End Sub

	Protected Function GetFilteredRowCountWithoutPage() As Integer
		Dim selectedRowsOnPage As Integer = 0
		For Each key In grid.GetCurrentPageRowValues("CustomerID")
			If grid.Selection.IsRowSelectedByKey(key) Then
				selectedRowsOnPage += 1
			End If
		Next key
		Return grid.Selection.FilteredCount - selectedRowsOnPage
	End Function
End Class

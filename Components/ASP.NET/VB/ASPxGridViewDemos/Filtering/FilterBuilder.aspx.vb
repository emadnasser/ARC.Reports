Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web
Imports System.Web.UI
Imports System.Collections.Generic

Partial Public Class Filtering_FilterBuilder
	Inherits Page

	Private columnsToRemove As New List(Of String)() From {"CategoryID", "ProductID", "SupplierID", "Supplier.SupplierID", "Supplier.HomePage", "Category.CategoryID", "EAN13"}

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		grid.SettingsFilterControl.ViewMode = If(cbEnableTextTab.Checked, FilterControlViewMode.VisualAndText, FilterControlViewMode.Visual)
		grid.SettingsFilterControl.AllowHierarchicalColumns = cbAllowHierarchicalColumns.Checked
		grid.SettingsFilterControl.ShowAllDataSourceColumns = cbShowAddDataSourceColumns.Checked

		If (Not IsPostBack) Then
			grid.FilterExpression = "Category.CategoryName = 'Beverages'"
		End If
	End Sub

	Protected Sub grid_FilterControlColumnsCreated(ByVal source As Object, ByVal e As FilterControlColumnsCreatedEventArgs)
		For Each col As String In columnsToRemove
			e.Columns.Remove(col)
		Next col
	End Sub
End Class

Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class ASPxFilterControl_FilterBuilder
	Inherits Page

	Private columnsToRemove As New List(Of String)() From {"CategoryID", "ProductID", "SupplierID", "Supplier.SupplierID", "Supplier.HomePage", "Category.CategoryID", "Category.CategoryName", "EAN13"}

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		filter.ViewMode = If(cbEnableTextTab.Checked, FilterControlViewMode.VisualAndText, FilterControlViewMode.Visual)
		If (Not IsPostBack) Then
			CreateFilterColumns()
			grid.FilterExpression = "[Category.CategoryName] = 'Beverages'"
			filter.FilterExpression = grid.FilterExpression
		End If
	End Sub

	Private Sub CreateFilterColumns()
		Dim maxHierarchyDepth As Integer = 1
		filter.BindToSource(GetType(Product), cbAllowHierarchicalColumns.Checked, maxHierarchyDepth)

		For Each col As String In columnsToRemove
			filter.Columns.Remove(col)
		Next col

		If cbAllowHierarchicalColumns.Checked Then
			Dim categoryColumn = CType(filter.Columns("Category"), FilterControlComplexTypeColumn)
			categoryColumn.Columns.Insert(0, CreateComboBoxColumn())
		End If
	End Sub

	Private Function CreateComboBoxColumn() As FilterControlColumn
		Dim column = New FilterControlComboBoxColumn()
		column.PropertyName = "CategoryName"
		Dim comboBoxProperties = TryCast(column.PropertiesEdit, ComboBoxProperties)
		comboBoxProperties.DataSourceID = "CategoriesDataSource"
		comboBoxProperties.TextField = "CategoryName"
		comboBoxProperties.ValueField = "CategoryName"
		comboBoxProperties.ValueType = GetType(String)
		Return column
	End Function
	Protected Sub cbAllowHierarchycalColumns_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
		CreateFilterColumns()
	End Sub
End Class

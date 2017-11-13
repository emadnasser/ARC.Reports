Imports System.Collections
Imports System.ComponentModel
Imports System.Data.OleDb
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Layout

Namespace DevExpress.XtraGrid.Demos
	Public Class BaseLayoutModule
		Inherits TutorialControl

		Protected Overrides Sub InitMDBData(ByVal connectionString As String, ByVal ds As DataSet)
			Dim data(,) As String = { { "CategoryID", "Products", "CategoryID", "Categories", "CategoriesProducts"}, { "CustomerID", "Orders", "CustomerID", "Customers", "CustomersOrders"}, { "EmployeeID", "Orders", "EmployeeID", "Employees", "EmployeesOrders"}, { "OrderID", "[Order Details]", "OrderID", "Orders", "OrdersOrderDetails"}, { "ProductID", "[Order Details]", "ProductID", "Products", "ProductsOrderDetails"}, { "ShipVia", "Orders", "ShipperID", "Shippers", "ShippersOrders"}, { "SupplierID", "Products", "SupplierID", "Suppliers", "SuppliersProducts"}}
			Dim tables() As String = { "Categories", "Customers", "Employees", "Orders", "Products", "Shippers", "Suppliers", "[Order Details]"}

			Dim oleDbDataAdapter As OleDbDataAdapter
			'fill tables
			For Each tbl As String In tables
				oleDbDataAdapter = New OleDbDataAdapter("SELECT * FROM " & tbl, connectionString)
				SetWaitDialogCaption(String.Format(My.Resources.LoadingCaption, tbl))
				oleDbDataAdapter.Fill(ds, tbl)
			Next tbl
			'custom views
			oleDbDataAdapter = New OleDbDataAdapter("SELECT * FROM Orders WHERE Freight > 500", connectionString)
			SetWaitDialogCaption(My.Resources.LoadingCustomOrders)
			oleDbDataAdapter.Fill(ds, "Orders500")
			'add relations
			For i As Integer = 0 To data.GetUpperBound(0)
				ds.Relations.Add(data(i, 4), ds.Tables(data(i, 3)).Columns(data(i, 2)), ds.Tables(data(i, 1)).Columns(data(i, 0)))
			Next i
			'custom relation
			ds.Relations.Add("CustomRelation", ds.Tables("Orders500").Columns("OrderID"), ds.Tables("[Order Details]").Columns("OrderID"), False)
		End Sub
	End Class
End Namespace

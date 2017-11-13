Imports System.Collections
Imports System.ComponentModel
Imports System.Data.OleDb
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Layout

Namespace DevExpress.XtraGrid.Demos
	Partial Public Class MDLayout
		Inherits BaseLayoutModule

		Private connection As OleDbConnection
		Private AdapterSuppliers As OleDbDataAdapter
		Private AdapterCategories As OleDbDataAdapter

		Public Sub New()
			CreateWaitDialog()
			InitializeComponent()
		End Sub
		Protected Overrides Sub InitMDBData(ByVal connectionString As String, ByVal ds As DataSet)
			connection = New OleDbConnection(connectionString)
			AdapterSuppliers = New OleDbDataAdapter("SELECT  SupplierID, CompanyName, Country, Address, Phone FROM Suppliers", connection)
			AdapterCategories = New OleDbDataAdapter("SELECT     Products.SupplierID, Products.ProductName, Categories.CategoryName, Categories.Description, Categories.Picture, " & "Products.UnitsInStock, Products.UnitPrice " & "FROM         (Products INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID) " & "ORDER BY Products.SupplierID", connection)
			AdapterSuppliers.Fill(ds, "Suppliers")
			AdapterCategories.Fill(ds, "ProductCategories")

			'custom relation
			ds.Relations.Add("SupplierProducts", ds.Tables("Suppliers").Columns("SupplierID"), ds.Tables("ProductCategories").Columns("SupplierID"), False)
		End Sub
	End Class
End Namespace

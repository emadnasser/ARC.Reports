Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Data.OleDb
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraLayout.Demos.Modules

Namespace DevExpress.XtraLayout.Demos
    Partial Public Class LayoutWaybill
        Inherits UserControl

        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub InitData()
            Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\nwind.mdb")
            If DBFileName <> "" Then
                Dim con As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBFileName
                Dim oleDBAdapter1 As New OleDbDataAdapter("SELECT * FROM Customers", con)
                Dim oleDBAdapter2 As New OleDbDataAdapter("SELECT * FROM Employees", con)
                Dim oleDBAdapter3 As New OleDbDataAdapter("SELECT * FROM Orders", con)
                Dim oleDBAdapter5 As New OleDbDataAdapter("SELECT * FROM Products", con)
                Dim oleDBAdapter4 As New OleDbDataAdapter("SELECT [Order Details].OrderID, [Order Details].ProductID, [Order Details].UnitPrice, [Order Details].Quantity, [Order Details].Discount, Products.ProductName" & ControlChars.CrLf &
"                         FROM            ([Order Details] INNER JOIN" & ControlChars.CrLf &
"                         Products ON [Order Details].ProductID = Products.ProductID)", con)
                Dim oleDBAdapter6 As New OleDbDataAdapter("SELECT * FROM EmployeeCustomers", con)

                oleDBAdapter1.Fill(dsOrder.Customers)
                oleDBAdapter2.Fill(dsOrder.Employees)
                oleDBAdapter5.Fill(dsOrder.Products)
                oleDBAdapter3.Fill(dsOrder.Orders)
                oleDBAdapter4.Fill(dsOrder.Order_Details)
                oleDBAdapter6.Fill(dsOrder.EmployeeCustomers)
            End If
        End Sub

        Private Sub ChangeData()
            dnNavigationCustomer.Position = DirectCast(dsOrder.Orders(dnNavigationOrders.Position)(dsOrder.Orders.Columns(2)), Integer)
            Dim str As String = CStr(dsOrder.Orders(dnNavigationOrders.Position)(dsOrder.Orders.Columns(1)))
            dnNavigationEmployee.Position = dsOrder.Customers.FindByCustomerID(str).Table.Rows.IndexOf(dsOrder.Customers.FindByCustomerID(str))
            ChangeFilter()
        End Sub
        Private Sub ChangeFilter()
            gridViewOrders.ActiveFilter.Clear()
            gridViewOrders.ActiveFilter.Add(gridViewOrders.Columns("OrderID"), New ColumnFilterInfo(String.Format("OrderID == '{0}'", dsOrder.Orders(dnNavigationOrders.Position).OrderID)))
        End Sub
        Private Sub dataNavigator1_PositionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dnNavigationOrders.PositionChanged
            ChangeData()
        End Sub

        Private Sub LayoutWaybill_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            If Not DesignMode Then
                InitData()
                ChangeData()
            End If
        End Sub


    End Class
End Namespace

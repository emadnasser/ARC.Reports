Imports System.Collections
Imports System.ComponentModel
Imports System.Data.OleDb
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils

Namespace DevExpress.XtraGrid.Demos
    ''' <summary>
    ''' Summary description for NWindNavigator.
    ''' </summary>
    Partial Public Class NWindNavigator
        Inherits TutorialControl

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            CreateWaitDialog()
            InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\GridMainDemo\Modules\NWindNavigator.vb"
            TutorialInfo.WhatsThisXMLFile = "NWindNavigator.xml"
            InitData()
            gridControl1.ForceInitialize()
            InitAppearance()
            OnStyleChanged()
            '
            ' TODO: Add any constructor code after InitializeComponent call
            '
        End Sub
#Region "Init"
        Private Sub InitData()
            gridControl1.DataSource = New NWTables(NWindDataSet())
            gridControl1.MainView.PopulateColumns()
            '<controlNavigator1>
            '~Note: the following code is set at design-time and listed here for educational purposes.
            '~controlNavigator1.NavigatableControl = gridControl1;
            '</controlNavigator1>
        End Sub
        Private Sub InitAppearance()
            gridView1.SetMasterRowExpanded(gridView1.FocusedRowHandle, True)
        End Sub

#End Region
#Region "Create"
        Protected Overrides Sub InitMDBData(ByVal connectionString As String, ByVal ds As DataSet)
            Dim data(,) As String = {{"CategoryID", "Products", "CategoryID", "Categories", "CategoriesProducts"}, {"CustomerID", "Orders", "CustomerID", "Customers", "CustomersOrders"}, {"EmployeeID", "Orders", "EmployeeID", "Employees", "EmployeesOrders"}, {"OrderID", "[Order Details]", "OrderID", "Orders", "OrdersOrderDetails"}, {"ProductID", "[Order Details]", "ProductID", "Products", "ProductsOrderDetails"}, {"ShipVia", "Orders", "ShipperID", "Shippers", "ShippersOrders"}, {"SupplierID", "Products", "SupplierID", "Suppliers", "SuppliersProducts"}}
            Dim tables() As String = {"Categories", "Customers", "Employees", "Orders", "Products", "Shippers", "Suppliers", "[Order Details]"}

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
        Protected Overrides Sub InitXMLData(ByVal dataFileName As String, ByVal ds As DataSet)
            ds.ReadXml(dataFileName)
        End Sub
#End Region
#Region "Grid events"
        Private Sub gridControl1_ViewRegistered(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.ViewOperationEventArgs) Handles gridControl1.ViewRegistered
            Dim gv As GridView = TryCast(e.View, GridView)
            gv.BestFitColumns()
            gv.OptionsView.ColumnAutoWidth = False
            gv.OptionsView.ShowColumnHeaders = True
            If gv.Columns.Count > 0 Then
                gv.Columns(0).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            End If
        End Sub
#End Region
#Region "Editing"
        '<sbCollapse>
        Private Sub sbCollapse_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbCollapse.Click
            gridView1.CollapseAllDetails()
        End Sub
        '</sbCollapse>
        '<sbPreview>
        Private Sub sbPreview_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbPreview.Click
            Dim currentCursor As Cursor = Cursor.Current
            Cursor.Current = Cursors.WaitCursor
            gridControl1.ShowRibbonPrintPreview()
            Cursor.Current = currentCursor
        End Sub
        '</sbPreview>
#End Region
        Protected Overrides Sub OnStyleChanged()
            MyBase.OnStyleChanged()
            controlNavigator1.Width = 100
        End Sub
    End Class
End Namespace

Imports System.Collections
Imports System.ComponentModel
Imports System.Data.OleDb
Imports DevExpress.XtraGrid.Views.Grid

Namespace DevExpress.XtraGrid.Demos
    ''' <summary>
    ''' Summary description for GridLookUpEdit.
    ''' </summary>
    Partial Public Class GridLookUpEditDemo
        Inherits TutorialControl

        Public Sub New()
            ' This call is required by the Windows.Forms Form Designer.
            CreateWaitDialog()
            InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\GridMainDemo\Modules\GridLookUpEditDemo.vb;VB\GridMainDemo\Modules\LookUpProperties.vb"
            TutorialInfo.WhatsThisXMLFile = "GridLookUpEditDemo.xml"
            InitNWindData()
            ' TODO: Add any initialization after the InitForm call

            '<gridLookUpEdit1>
            '            
            '~Note: the following properties are set at design time and listed here only for demonstration purposes.
            '~            
            '~Assign a data source containing data to be displayed in the GridLookUpEdit's dropdown window:
            '~gridLookUpEdit1.Properties.DataSource = dsNWindProducts1.Products
            '~            
            '~Specify the field whose values are displayed in the edit box:
            '~gridLookUpEdit1.Properties.DisplayMember = "ProductName"
            '~            
            '~Specify the key field whose values identify dropdown rows:
            '~gridLookUpEdit1.Properties.ValueMember = "ProductID"
            '~            
            '~Specify a GridView that will render data in the dropdown window:
            '~gridLookUpEdit1.Properties.View = gridLookUpEdit1View
            '            
            '</gridLookUpEdit1>

            '<dataNavigator1>
            '            
            '~Note: the following property is set at design time and listed here only for demonstration purposes.
            '~            
            '~The DataNavigator will navigate through the Order_Details data source:
            '~dataNavigator1.DataSource = dsNWindProducts1.Order_Details
            '            
            '</dataNavigator1>


            '<gridControl1>
            '            
            '~Note: the following properties are set at design time and listed here only for demonstration purposes.
            '~
            '~Settings of the Customer column's GridLookUpEdit in-place editor:
            '~
            '~Assign a data source containing data to be displayed in the GridLookUpEdit's dropdown window:
            '~repositoryItemGridLookUpEdit1.DataSource = dsNWindCustomers1.Customers
            '~
            '~Specify the field whose values are displayed in the edit box:
            '~repositoryItemGridLookUpEdit1.DisplayMember = "CompanyName"
            '~
            '~Specify the key field whose values identify dropdown rows:
            '~repositoryItemGridLookUpEdit1.ValueMember = "CustomerID"
            '~
            '~Specify a GridView that will render data in the dropdown window:
            '~repositoryItemGridLookUpEdit1.View = this.repositoryItemGridLookUpEdit1View
            '~
            '~
            '~Settings of the Employee column's GridLookUpEdit in-place editor:
            '~
            '~Assign a data source containing data to be displayed in the GridLookUpEdit's dropdown window:
            '~repositoryItemGridLookUpEdit2.DataSource = dsNWindCustomers1.Employees
            '~
            '~Specify the field whose values are displayed in the edit box:
            '~repositoryItemGridLookUpEdit2.DisplayMember = "Name"
            '~
            '~Specify the key field whose values identify dropdown rows:
            '~repositoryItemGridLookUpEdit2.ValueMember = "EmployeeID"
            '~
            '~Specify an AdvBandedGridView that will render data in the dropdown window:
            '~repositoryItemGridLookUpEdit2.View = this.repositoryItemGridLookUpEdit2View
            '            
            '</gridControl1>
        End Sub

        Private Sub GridLookUpEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Dim lp As New LookUpProperties(gridLookUpEdit1)
            lp.Dock = DockStyle.Right
            lp.Parent = xtraScrollableControl1
            '<dataNavigator1>
            '            
            '~Bind the GridLookUpEdit's EditValue to the ProductID field in the Order_Details table:
            '~             
            Me.gridLookUpEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.dsNWindProducts1.Order_Details, "ProductID"))
            '</dataNavigator1>

            CreateTimer()
        End Sub

        Protected Overrides Sub OnTick()
            If DemosInfo.CurrentModule Is Me Then
                gridLookUpEdit1.ShowPopup()
            End If
        End Sub

        Protected Overrides Sub InitMDBData(ByVal connectionString As String)
            Dim oleDBAdapter1 As New OleDbDataAdapter("SELECT * FROM Products", connectionString)
            Dim oleDBAdapter2 As New OleDbDataAdapter("SELECT * FROM [Order Details]", connectionString)
            Dim oleDBAdapter3 As New OleDbDataAdapter("SELECT * FROM Orders", connectionString)
            Dim oleDBAdapter4 As New OleDbDataAdapter("SELECT * FROM Customers", connectionString)
            Dim oleDBAdapter5 As New OleDbDataAdapter("SELECT * FROM Employees", connectionString)

            SetWaitDialogCaption(My.Resources.LoadingProducts)
            oleDBAdapter1.Fill(dsNWindProducts1.Products)

            SetWaitDialogCaption(My.Resources.LoadingOrderDetails)
            oleDBAdapter2.Fill(dsNWindProducts1.Order_Details)

            SetWaitDialogCaption(My.Resources.LoadingOrders)
            oleDBAdapter3.Fill(dsNWindCustomers1.Orders)

            SetWaitDialogCaption(My.Resources.LoadingCustomers)
            oleDBAdapter4.Fill(dsNWindCustomers1.Customers)

            SetWaitDialogCaption(My.Resources.LoadingEmployees)
            oleDBAdapter5.Fill(dsNWindCustomers1.Employees)
            DemoHelper.AddCategoryImagesToEdit(connectionString, repositoryItemImageComboBox1)
        End Sub
        Protected Overrides Sub InitXMLData(ByVal dataFileName As String)
            Dim ds As New DataSet()
            SetWaitDialogCaption(My.Resources.LoadingTables)
            ds.ReadXml(dataFileName)
            Me.dataNavigator1.Visible = False
            Me.gridLookUpEdit1.Properties.DataSource = ds.Tables("Products")
            Me.gridControl1.DataSource = ds.Tables("Orders")
            Me.repositoryItemGridLookUpEdit1.DataSource = ds.Tables("Customers")
            Me.repositoryItemGridLookUpEdit2.DisplayMember = "FirstName"
            Me.repositoryItemGridLookUpEdit2.DataSource = ds.Tables("Employees")
        End Sub

        Private Sub repositoryItemGridLookUpEdit1View_CalcPreviewText(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CalcPreviewTextEventArgs) Handles repositoryItemGridLookUpEdit1View.CalcPreviewText
            Dim view As GridView = TryCast(sender, GridView)
            If view Is Nothing Then
                Return
            End If
            Dim row_Renamed As DataRow = view.GetDataRow(e.RowHandle)
            If row_Renamed Is Nothing Then
                Return
            End If
            Dim region As String = If(row_Renamed("Region") IsNot DBNull.Value, String.Format("{0}, ", row_Renamed("Region")), "")
            e.PreviewText = String.Format("{0}{1}, {2}, {3}" & vbCrLf & "{4}, {5}", region, row_Renamed("Country"), row_Renamed("City"), row_Renamed("PostalCode"), row_Renamed("Address"), row_Renamed("Phone"))
        End Sub

        Private Sub gridLookUpEdit1_ProcessNewValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs) Handles gridLookUpEdit1.ProcessNewValue
            dsNWindProducts1.Products.Rows.Add(New Object() {0, False, System.Environment.TickCount, e.DisplayValue})
            e.Handled = True
        End Sub
    End Class
End Namespace

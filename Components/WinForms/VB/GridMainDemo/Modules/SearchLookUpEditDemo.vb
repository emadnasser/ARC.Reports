Imports System.Collections
Imports System.ComponentModel
Imports System.Data.OleDb
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraGrid.Demos
    ''' <summary>
    ''' Summary description for GridLookUpEdit.
    ''' </summary>
    Partial Public Class SearchLookUpEditDemo
        Inherits TutorialControl

        Public Sub New()
            ' This call is required by the Windows.Forms Form Designer.
            CreateWaitDialog()
            InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\GridMainDemo\Modules\SearchLookUpEditDemo.vb;VB\GridMainDemo\Modules\SearchLookUpProperties.vb"
            TutorialInfo.WhatsThisXMLFile = "SearchLookUpEditDemo.xml"
            InitNWindData()
            ' TODO: Add any initialization after the InitForm call
            searchLookUpEdit1.Properties.ShowClearButton = False
            AddHandler repositoryItemSearchLookUpEdit2.GetImageByValue, AddressOf repositoryItemSearchLookUpEdit2_GetImageByValue

            '<searchLookUpEdit1>
            '
            '~Note: the following properties are set at design time and listed here only for demonstration purposes.
            '
            '~Assign a data source containing data to be displayed in the SearchLookUpEdit's dropdown window:
            '~searchLookUpEdit1.Properties.DataSource = dsNWindProducts1.Products
            '~
            '~Specify the field whose values are displayed in the edit box:
            '~searchLookUpEdit1.Properties.DisplayMember = "ProductName"
            '~
            '~Specify the key field whose values identify dropdown rows:
            '~searchLookUpEdit1.Properties.ValueMember = "ProductID"
            '~
            '~Specify a GridView that will render data in the dropdown window:
            '~searchLookUpEdit1.Properties.View = gridLookUpEdit1View
            '
            '</searchLookUpEdit1>

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
            '~Settings of the Customer column's SearchLookUpEdit in-place editor:
            '~
            '~Assign a data source containing data to be displayed in the SearchLookUpEdit's dropdown window:
            '~repositoryItemSearchLookUpEdit1.DataSource = dsNWindCustomers1.Customers
            '~
            '~Specify the field whose values are displayed in the edit box:
            '~repositoryItemSearchLookUpEdit1.DisplayMember = "CompanyName"
            '~
            '~Specify the key field whose values identify dropdown rows:
            '~repositoryItemSearchLookUpEdit1.ValueMember = "CustomerID"
            '~
            '~Specify a GridView that will render data in the dropdown window:
            '~repositoryItemSearchLookUpEdit1.View = repositoryItemSearchLookUpEdit1View
            '~
            '~
            '~Settings of the Employee column's SearchLookUpEdit in-place editor:
            '~
            '~Assign a data source containing data to be displayed in the SearchLookUpEdit's dropdown window:
            '~repositoryItemSearchLookUpEdit2.DataSource = dsNWindCustomers1.Employees
            '~
            '~Specify the field whose values are displayed in the edit box:
            '~repositoryItemSearchLookUpEdit2.DisplayMember = "Name"
            '~
            '~Specify the key field whose values identify dropdown rows:
            '~repositoryItemSearchLookUpEdit2.ValueMember = "EmployeeID"
            '~
            '~Specify an AdvBandedGridView that will render data in the dropdown window:
            '~repositoryItemSearchLookUpEdit2.View = repositoryItemSearchLookUpEdit2View
            '
            '</gridControl1>
        End Sub

        Private Sub repositoryItemSearchLookUpEdit2_GetImageByValue(ByVal sender As Object, ByVal e As ImageByValueEventArgs)
            Dim repository As RepositoryItemSearchLookUpEditWithGlyph = TryCast(sender, RepositoryItemSearchLookUpEditWithGlyph)
            Dim dt As DataTable = TryCast(repository.DataSource, DataTable)
            Dim row_Renamed As DataRow = Nothing
            Try
                row_Renamed = dt.Rows.Find(e.Value)
            Catch
            End Try
            If row_Renamed IsNot Nothing Then
                e.Image = CType(row_Renamed("Photo"), Byte())
            End If
        End Sub

        Private Sub GridLookUpEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Dim lp As New SearchLookUpProperties(searchLookUpEdit1)
            lp.Dock = DockStyle.Right
            lp.Parent = xtraScrollableControl1
            '<dataNavigator1>
            '
            '~Bind the SearchLookUpEdit's EditValue to the ProductID field in the Order_Details table:
            '
            Me.searchLookUpEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.dsNWindProducts1.Order_Details, "ProductID"))
            '</dataNavigator1>
            CreateTimer()
        End Sub

        Protected Overrides Sub OnTick()
            If DemosInfo.CurrentModule Is Me Then
                searchLookUpEdit1.ShowPopup()
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
            Me.searchLookUpEdit1.Properties.DataSource = ds.Tables("Products")
            Me.gridControl1.DataSource = ds.Tables("Orders")
            Me.repositoryItemSearchLookUpEdit1.DataSource = ds.Tables("Customers")
            Me.repositoryItemSearchLookUpEdit2.DisplayMember = "FirstName"
            Me.repositoryItemSearchLookUpEdit2.DataSource = ds.Tables("Employees")
        End Sub

        Private Sub repositoryItemGridLookUpEdit1View_CalcPreviewText(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CalcPreviewTextEventArgs) Handles repositoryItemSearchLookUpEdit1View.CalcPreviewText
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

        Private Sub gridLookUpEdit1_ProcessNewValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs) Handles searchLookUpEdit1.ProcessNewValue
            dsNWindProducts1.Products.Rows.Add(New Object() {0, False, System.Environment.TickCount, e.DisplayValue})
            e.Handled = True
        End Sub

        Private Sub searchLookUpEdit1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles searchLookUpEdit1.EditValueChanged
            Dim edit As SearchLookUpEditWithGlyph = TryCast(sender, SearchLookUpEditWithGlyph)
            If edit Is Nothing Then
                Return
            End If
            If edit.EditValue Is Nothing Then
                edit.Image = Nothing
            Else
                Dim dt As DataTable = TryCast(edit.Properties.DataSource, DataTable)
                If dt Is Nothing Then Return
                Dim row_Renamed As DataRow = dt.Rows.Find(edit.EditValue)
                edit.Image = DemoHelper.CategorySmallImages.Images(Convert.ToInt32(row_Renamed("CategoryID")) - 1)
            End If
        End Sub

        Private Sub searchLookUpEdit1_AddNewValue(ByVal sender As Object, ByVal e As AddNewValueEventArgs) Handles searchLookUpEdit1.AddNewValue
            Dim edit As SearchLookUpEditWithGlyph = TryCast(sender, SearchLookUpEditWithGlyph)
            Dim dt As DataTable = TryCast(edit.Properties.DataSource, DataTable)

            Using frm As New frmProduct()
                If frm.ShowDialog(Me.FindForm()) = DialogResult.OK Then
                    Dim dr As DataRow = dt.Rows.Add(frm.CategoryID, frm.Discontinued, Nothing, frm.NewProductName, frm.QuantityPerUnit, 0, 0, frm.UnitPrice, 1, 1)
                    dr.AcceptChanges()
                    e.NewValue = dr("ProductID")
                Else
                    e.Cancel = True
                End If
            End Using
        End Sub
    End Class
End Namespace

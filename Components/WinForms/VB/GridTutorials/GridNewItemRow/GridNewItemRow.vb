Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraGrid.Demos.Tutorials
    ''' <summary>
    ''' Summary description for GridNewItemRow.
    ''' </summary>
    Partial Public Class GridNewItemRow
        Inherits TutorialControl
        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()

            '
            ' TODO: Add any constructor code after InitializeComponent call
            '
        End Sub

        Private Sub GridNewItemRow_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitData()
            InitGrid()
        End Sub

        Private Sub InitData()
            Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\nwind.mdb")
            If DBFileName <> "" Then
                Dim ds As DataSet = New DataSet()
                Dim con As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBFileName
                Dim tblGrid As String = "[Order Details]"
                Dim tblLookUp As String = "Products"
                Dim oleDbDataAdapter As System.Data.OleDb.OleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " & tblGrid, con)
                oleDbDataAdapter.Fill(ds, tblGrid)
                oleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " & tblLookUp, con)
                oleDbDataAdapter.Fill(ds, tblLookUp)

                Dim dvManager As DataViewManager = New DataViewManager(ds)
                Dim dv As DataView = dvManager.CreateDataView(ds.Tables(tblGrid))

                gridControl1.DataSource = dv
                repositoryItemLookUpEdit1.DataSource = ds.Tables(tblLookUp)
            End If
        End Sub

        Private Sub InitGrid()
            imageComboBoxEdit1.Properties.Items.Add(New ImageComboBoxItem("None", NewItemRowPosition.None, -1))
            imageComboBoxEdit1.Properties.Items.Add(New ImageComboBoxItem("Top", NewItemRowPosition.Top, -1))
            imageComboBoxEdit1.Properties.Items.Add(New ImageComboBoxItem("Bottom", NewItemRowPosition.Bottom, -1))
            imageComboBoxEdit1.SelectedIndex = 1
            gridView1.FocusedRowHandle = gridView1.RowCount - 1
        End Sub

        '<gridControl1>
        Private Sub gridView1_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gridView1.InitNewRow
            Dim row As DataRow = gridView1.GetDataRow(e.RowHandle)
            row("Quantity") = 1
            row("UnitPrice") = 0
            row("Discount") = 0
            row("OrderID") = 99999
        End Sub
        '</gridControl1>

        '<imageComboBoxEdit1>
        Private Sub imageComboBoxEdit1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles imageComboBoxEdit1.SelectedIndexChanged
            gridView1.OptionsView.NewItemRowPosition = CType(imageComboBoxEdit1.EditValue, NewItemRowPosition)
        End Sub
        '</imageComboBoxEdit1>
        Public Overrides ReadOnly Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace

Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraGrid.Views.Base

Namespace DevExpress.XtraGrid.Demos.Tutorials
    ''' <summary>
    ''' Summary description for GridValidatingControl.
    ''' </summary>
    Partial Public Class GridValidatingControl
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

#Region "InitData"
        Private Sub InitData()
            Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\nwind.mdb")
            If DBFileName <> "" Then
                Dim ds As DataSet = New DataSet()
                Dim con As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBFileName
                Dim tblGrid As String = "Products"
                Dim tblLookUp As String = "Categories"
                Dim oleDbDataAdapter As System.Data.OleDb.OleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " & tblGrid, con)
                oleDbDataAdapter.Fill(ds, tblGrid)
                oleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " & tblLookUp, con)
                oleDbDataAdapter.Fill(ds, tblLookUp)

                Dim dvManager As DataViewManager = New DataViewManager(ds)
                Dim dv As DataView = dvManager.CreateDataView(ds.Tables(tblGrid))

                gridControl1.DataSource = dv
                repositoryItemLookUpEdit1.DataSource = ds.Tables(tblLookUp)
                textEdit1.DataBindings.Add("EditValue", dv, "ProductName")
                spinEdit1.DataBindings.Add("EditValue", dv, "UnitPrice")
            End If
        End Sub
#End Region
        Private Sub GridValidatingControl_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitData()
        End Sub

        Private Sub editors_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles spinEdit1.Validating, textEdit1.Validating
            gridView1.UpdateCurrentRow()
        End Sub

        Private Sub gridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView1.FocusedRowChanged
            Dim view As ColumnView = TryCast(sender, ColumnView)
            Dim o As Object = view.GetRowCellValue(e.FocusedRowHandle, view.Columns("Discontinued"))
            If Not o Is Nothing AndAlso Not o Is DBNull.Value Then
                Dim val As Boolean = Convert.ToBoolean(o)
                textEdit1.Properties.ReadOnly = val
                spinEdit1.Properties.ReadOnly = val
            End If
        End Sub

        '<gridControl1>
        Private Sub gridView1_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gridView1.ValidateRow
            Dim view As ColumnView = TryCast(sender, ColumnView)
            Dim val As Boolean = Convert.ToBoolean(view.GetRowCellValue(e.RowHandle, view.Columns("Discontinued")))
            If val Then
                e.Valid = False
                e.ErrorText = "Item should not be discontinued. "
            End If
            If (Not val) Then
                view.SetColumnError(Nothing, Nothing)
            Else
                view.SetColumnError(Nothing, "Item should not be discontinued.")
            End If
        End Sub
        '</gridControl1>

        Private Sub gridControl1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles gridControl1.Validating
            Dim view As ColumnView = TryCast(gridControl1.MainView, ColumnView)
            view.UpdateCurrentRow()
            If view.GetColumnError(Nothing) <> String.Empty Then
                e.Cancel = True
            End If
        End Sub
        Public Overrides ReadOnly Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace

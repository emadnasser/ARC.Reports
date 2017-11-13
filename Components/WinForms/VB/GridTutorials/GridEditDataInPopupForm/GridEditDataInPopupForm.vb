Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraGrid.Demos.Tutorials
    ''' <summary>
    ''' Summary description for GridEditDataInPopupForm.
    ''' </summary>
    Partial Public Class GridEditDataInPopupForm
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

        Private Sub GridEditDataInPopupForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitData()
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

        '<gridControl1>
        Private Function EditRecord() As Boolean
            Dim frm As PopupFormGridEditDataInPopupForm = New PopupFormGridEditDataInPopupForm()
            Dim row As DataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle)
            frm.InitData(Me.FindForm(), gridControl1, gridView1, row)
            Dim ret As Boolean = frm.ShowDialog() = System.Windows.Forms.DialogResult.OK
            If ret Then
                row.ItemArray = frm.Row.ItemArray
                row.EndEdit()
            End If
            Return ret
        End Function

        Private Sub gridControl1_EmbeddedNavigator_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles gridControl1.EmbeddedNavigator.ButtonClick
            If e.Button.ButtonType = DevExpress.XtraEditors.NavigatorButtonType.Edit Then
                EditRecord()
                e.Handled = True
            End If
            If e.Button.ButtonType = DevExpress.XtraEditors.NavigatorButtonType.Append Then
                gridView1.AddNewRow()
                If EditRecord() Then
                    gridView1.UpdateCurrentRow()
                Else
                    gridView1.CancelUpdateCurrentRow()
                End If
                e.Handled = True
            End If
        End Sub
        '</gridControl1>
        Public Overrides ReadOnly Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace

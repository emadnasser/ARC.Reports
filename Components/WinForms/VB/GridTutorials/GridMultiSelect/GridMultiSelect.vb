Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraGrid.Demos.Tutorials
    ''' <summary>
    ''' Summary description for GridMultiSelect.
    ''' </summary>
    Partial Public Class GridMultiSelect
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

        Private Sub GridMultiSelect_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            checkEdit1.Checked = True
            gridView1.SelectRange(1, 4)
        End Sub

        '<checkEdit1>
        Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEdit1.CheckedChanged
            If checkEdit1.Checked Then
                gridView1.OptionsSelection.MultiSelect = True
                ShowSelection()
            Else
                gridView1.OptionsSelection.MultiSelect = False
                lbSelectedRowsCount.Text = "-1"
                lbSelectedRows.Text = "MultiSelect is Disabled."
            End If
        End Sub
        '</checkEdit1>

        '<gridControl1>
        Private Sub gridView1_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles gridView1.SelectionChanged
            ShowSelection()
        End Sub
        '</gridControl1>

        Public Shared Function ArrayToString(ByVal arr As Integer()) As String
            Dim s As String = ""
            If arr Is Nothing Then
                s = "Empty..."
            Else
                For Each i As Integer In arr
                    If s = "" Then
                        s &= ("") + i.ToString()
                    Else
                        s &= (";") + i.ToString()
                    End If
                Next i
                s &= "."
            End If
            Return s
        End Function

        '<gridControl1>
        Private Sub ShowSelection()
            lbSelectedRowsCount.Text = gridView1.SelectedRowsCount.ToString()
            lbSelectedRows.Text = ArrayToString(gridView1.GetSelectedRows())
        End Sub
        '</gridControl1>
        Public Overrides ReadOnly Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace

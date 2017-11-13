Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraGrid.Demos.Tutorials
    ''' <summary>
    ''' Summary description for GridFilteredView.
    ''' </summary>
    Partial Public Class GridFilteredView
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

        Private Sub GridFilteredView_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitData()
            SetFilterString()
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

                '<gridControl1>
                gridControl1.DataSource = CreateFilteredView(ds.Tables(tblGrid), "Discount <> 0")
                '</gridControl1>
                repositoryItemLookUpEdit1.DataSource = ds.Tables(tblLookUp)
            End If
        End Sub

        '<gridControl1>
        Private Function CreateFilteredView(ByVal tbl As DataTable, ByVal filterString As String) As FilteredDataView
            Dim ret As FilteredDataView = New FilteredDataView(tbl)
            Me.filterString = filterString
            lbFilter.Text = filterString
            Return ret
        End Function
        '</gridControl1>

        '<checkEdit1>
        Private filterString As String = ""
        Private Sub SetFilterString()
            Dim fdv As FilteredDataView = TryCast(gridControl1.DataSource, FilteredDataView)
            If fdv Is Nothing Then
                Return
            End If
            If checkEdit1.Checked Then
                fdv.AdditionalRowFilter = Me.filterString
            Else
                fdv.AdditionalRowFilter = ""
            End If
        End Sub

        Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEdit1.CheckedChanged
            SetFilterString()
        End Sub
        '</checkEdit1>
        Public Overrides ReadOnly Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace

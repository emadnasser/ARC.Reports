Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraGrid.Demos.Tutorials
    ''' <summary>
    ''' Summary description for GridSummaries.
    ''' </summary>
    Partial Public Class GridSummaries
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

        Private Sub GridSummaries_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitData()
            gridView1.ExpandAllGroups()
        End Sub

        Private Sub InitData()
            Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\nwind.mdb")
            If DBFileName <> "" Then
                Dim ds As DataSet = New DataSet()
                Dim con As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBFileName
                Dim tblGrid As String = "Products"
                Dim tblLookUp As String = "Suppliers"
                Dim oleDbDataAdapter As System.Data.OleDb.OleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " & tblGrid, con)
                oleDbDataAdapter.Fill(ds, tblGrid)
                oleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " & tblLookUp, con)
                oleDbDataAdapter.Fill(ds, tblLookUp)

                repositoryItemLookUpEdit1.DataSource = ds.Tables(tblLookUp)
                gridControl1.DataSource = ds.Tables(tblGrid)
            End If
        End Sub
        Public Overrides ReadOnly Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace

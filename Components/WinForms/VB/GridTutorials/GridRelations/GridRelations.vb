Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraGrid.Demos.Tutorials
    ''' <summary>
    ''' Summary description for GridRelations.
    ''' </summary>
    Partial Public Class GridRelations
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

        '<gridControl1>
        Private Sub GridRelations_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitData()
            gridView1.SetMasterRowExpanded(0, True)
        End Sub

        Private Sub InitData()
            Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\nwind.mdb")
            If DBFileName <> "" Then
                Dim ds As DataSet = New DataSet()
                Dim con As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBFileName
                Dim tblMaster As String = "Products"
                Dim tblDetail As String = "[Order Details]"

                Dim oleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " & tblMaster, con)
                Dim oleDbDataAdapter2 As System.Data.OleDb.OleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " & tblDetail, con)
                oleDbDataAdapter1.Fill(ds, tblMaster)
                oleDbDataAdapter2.Fill(ds, tblDetail)

                'Add master detail relation ship for the dataset.
                ds.Relations.Add("OrderDetails", ds.Tables(tblMaster).Columns("ProductID"), ds.Tables(tblDetail).Columns("ProductID"))

                Dim dvManager As DataViewManager = New DataViewManager(ds)
                Dim dv As DataView = dvManager.CreateDataView(ds.Tables(tblMaster))

                gridControl1.DataSource = dv
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

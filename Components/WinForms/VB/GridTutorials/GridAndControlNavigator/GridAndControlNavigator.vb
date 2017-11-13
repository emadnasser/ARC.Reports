Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraGrid.Demos.Tutorials
    ''' <summary>
    ''' Summary description for GridAndControlNavigator.
    ''' </summary>
    Partial Public Class GridAndControlNavigator
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

        Private Sub GridAndControlNavigator_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitNWindData()
            checkEdit1.Checked = True
        End Sub

        Private tblGrid As String = "[Order Details]"
        Private tblLookUp As String = "Products"
        Protected Overrides Sub InitMDBData(ByVal connectionString As String)
            Dim ds As DataSet = New DataSet()
            Dim oleDbDataAdapter As System.Data.OleDb.OleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " & tblGrid, connectionString)
            oleDbDataAdapter.Fill(ds, tblGrid)
            oleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " & tblLookUp, connectionString)
            oleDbDataAdapter.Fill(ds, tblLookUp)

            gridControl1.DataSource = ds.Tables(tblGrid)
            repositoryItemLookUpEdit1.DataSource = ds.Tables(tblLookUp)
        End Sub
        Protected Overrides Sub InitXMLData(ByVal dataFileName As String)
            Dim ds As DataSet = New DataSet()
            ds.ReadXml(dataFileName)
            gridControl1.ShowOnlyPredefinedDetails = True
            gridControl1.DataSource = ds.Tables(tblGrid)
            repositoryItemLookUpEdit1.DataSource = ds.Tables(tblLookUp)
        End Sub

        Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEdit1.CheckedChanged
            '<checkEdit1>
            gridControl1.UseEmbeddedNavigator = checkEdit1.Checked
            '</checkEdit1>
            panel2.Visible = Not gridControl1.UseEmbeddedNavigator
            panelControl1.Visible = gridControl1.UseEmbeddedNavigator
        End Sub

    End Class
End Namespace

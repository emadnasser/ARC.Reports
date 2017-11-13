Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraGrid.Demos.Tutorials
    ''' <summary>
    ''' Summary description for GridRowFilterEvent.
    ''' </summary>
    Partial Public Class GridRowFilterEvent
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
        Private dv As DataView = Nothing
        Private Sub GridRowFilterEvent_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitData()
            gridView1.Columns(0).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            gridView1.BestFitColumns()
        End Sub


        Private Sub InitData()
            Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\nwind.mdb")
            If DBFileName <> "" Then
                Dim ds As DataSet = New DataSet()
                Dim con As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBFileName
                Dim tbl As String = "Customers"
                Dim oleDbDataAdapter As System.Data.OleDb.OleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " & tbl, con)
                oleDbDataAdapter.Fill(ds, tbl)

                Dim dvManager As DataViewManager = New DataViewManager(ds)
                dv = dvManager.CreateDataView(ds.Tables(tbl))

                gridControl1.DataSource = dv
                gridControl1.MainView.PopulateColumns()
            End If
        End Sub

        '<ceHideOddRows>
        '<ceHideEvenRows>
        '<ceRegion>
        '<gridControl1>
        Private Sub gridView1_CustomRowFilter(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowFilterEventArgs) Handles gridView1.CustomRowFilter
            Dim handled As Boolean = ceHideOddRows.Checked OrElse ceHideEvenRows.Checked OrElse ceRegion.Checked
            If ceHideOddRows.Checked AndAlso e.ListSourceRow Mod 2 = 1 Then
                e.Visible = False
            End If
            If ceHideEvenRows.Checked AndAlso e.ListSourceRow Mod 2 = 0 Then
                e.Visible = False
            End If
            If ceRegion.Checked Then
                Dim row As DataRow = dv(e.ListSourceRow).Row
                If row("Region") Is DBNull.Value Then
                    e.Visible = False
                End If
            End If
            e.Handled = handled
        End Sub
        '</gridControl1>

        Private Sub ceEditors__CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceRegion.CheckedChanged, ceHideEvenRows.CheckedChanged, ceHideOddRows.CheckedChanged
            gridView1.RefreshData()
        End Sub
        '</ceHideOddRows>
        '</ceHideEvenRows>
        '</ceRegion>
        Public Overrides ReadOnly Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace

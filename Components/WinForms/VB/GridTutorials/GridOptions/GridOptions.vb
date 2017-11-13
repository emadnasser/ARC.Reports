Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraEditors.Repository

Namespace DevExpress.XtraGrid.Demos.Tutorials
    ''' <summary>
    ''' Summary description for GridOptions.
    ''' </summary>
    Partial Public Class GridOptions
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

#Region "Init"
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
#End Region
        Private Sub GridOptions_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitData()
            InitOptions(gridView1.OptionsView, checkedListBoxControl1)
            InitOptions(gridView1.OptionsBehavior, checkedListBoxControl2)
        End Sub

        Private Sub InitOptions(ByVal options As Object, ByVal checkedListBox As DevExpress.XtraEditors.CheckedListBoxControl)
            Dim arr As ArrayList = DevExpress.Utils.SetOptions.GetOptionNames(options)
            Dim i As Integer = 0
            Do While i < arr.Count
                checkedListBox.Items.Add(New DevExpress.XtraEditors.Controls.CheckedListBoxItem(arr(i), DevExpress.Utils.SetOptions.OptionValueByString(arr(i).ToString(), options)))
                i += 1
            Loop
        End Sub

        '<checkedListBoxControl1>
        Private Sub checkedListBoxControl1_ItemCheck(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ItemCheckEventArgs) Handles checkedListBoxControl1.ItemCheck
            Dim optionSet As Boolean
            If e.State = CheckState.Checked Then
                optionSet = True
            Else
                optionSet = False
            End If
            Dim [option] As String = checkedListBoxControl1.GetDisplayItemValue(e.Index).ToString()
            DevExpress.Utils.SetOptions.SetOptionValueByString([option], gridView1.OptionsView, optionSet)
        End Sub
        '</checkedListBoxControl1>

        '<checkedListBoxControl2>
        Private Sub checkedListBoxControl2_ItemCheck(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ItemCheckEventArgs) Handles checkedListBoxControl2.ItemCheck
            Dim optionSet As Boolean
            If e.State = CheckState.Checked Then
                optionSet = True
            Else
                optionSet = False
            End If
            Dim [option] As String = checkedListBoxControl2.GetDisplayItemValue(e.Index).ToString()
            DevExpress.Utils.SetOptions.SetOptionValueByString([option], gridView1.OptionsBehavior, optionSet)
        End Sub
        '</checkedListBoxControl2>

        Private Sub gridView1_CalcPreviewText(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CalcPreviewTextEventArgs) Handles gridView1.CalcPreviewText
            e.PreviewText = String.Format("{0}" & Constants.vbCrLf & "{1}", gridView1.GetRowCellDisplayText(e.RowHandle, gridColumn2), gridView1.GetRowCellDisplayText(e.RowHandle, gridColumn3))
        End Sub
        Public Overrides ReadOnly Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace

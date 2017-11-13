Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraGrid.Demos.Tutorials
    ''' <summary>
    ''' Summary description for GridIncrementalSearch.
    ''' </summary>
    Partial Public Class GridIncrementalSearch
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
        Private searshString As String() = New String() {"c", "a", "{BS}", "h", "a", "n", "{BS}", "{BS}", "e", "f", " ", "a", "n", "t", "o", "n", "'", "s", " ", "c", "^{DOWN}", "^{DOWN}", "^{DOWN}", "^{DOWN}", "^{DOWN}", "^{DOWN}", "^{HOME}", "{RIGHT}"}
        Private searchKeyIndex As Integer = 0

        Private Sub GridIncrementalSearch_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            lbEvent.Text = "Press ESC key to stop auto-incremental search."
            InitData()
            gridView1.FocusedColumn = gridColumn2
            timer1.Start()
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

        Private Sub gridControl1_ProcessGridKey(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gridControl1.ProcessGridKey
            If e.KeyCode = Keys.Escape Then
                StopSearch()
            End If
        End Sub
        Private Sub gridControl1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gridControl1.MouseDown
            StopSearch()
        End Sub
        Private Sub StopSearch()
            timer1.Stop()
            lbEvent.Text = "Auto-Incremental Searching is available against any XtraGrid column WITHOUT writing any source code! With its blinding fast speed, your users can find information quickly when large amounts of data are displayed within the XtraGrid. Use Ctrl+Down to find the next match and Ctrl+Up to find the previous match."
        End Sub

        Private Sub timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timer1.Tick
            If Form.ActiveForm Is Nothing OrElse (Not Me.Visible) Then
                Return
            End If
            gridControl1.Focus()
            If searchKeyIndex > searshString.Length - 1 Then
                searchKeyIndex = 0
            Else
                SendKeys.Send(searshString(searchKeyIndex))
                searchKeyIndex += 1
            End If
        End Sub
        Public Overrides ReadOnly Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace

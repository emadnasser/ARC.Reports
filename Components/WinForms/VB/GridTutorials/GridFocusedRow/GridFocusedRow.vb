Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid

Namespace DevExpress.XtraGrid.Demos.Tutorials
    ''' <summary>
    ''' Summary description for GridFocusedRow.
    ''' </summary>
    Partial Public Class GridFocusedRow
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

        Private Sub GridFocusedRow_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitData()
            InitGrid()
        End Sub

        Private Sub InitData()
            Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\nwind.mdb")
            If DBFileName <> "" Then
                Dim ds As DataSet = New DataSet()
                Dim con As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBFileName
                Dim tbl As String = "Products"
                Dim oleDbDataAdapter As System.Data.OleDb.OleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " & tbl, con)
                oleDbDataAdapter.Fill(ds, tbl)

                Dim dvManager As DataViewManager = New DataViewManager(ds)
                Dim dv As DataView = dvManager.CreateDataView(ds.Tables(tbl))

                gridControl1.DataSource = dv
            End If
        End Sub

        Private Sub InitGrid()
            gridView1.FocusedColumn = gridView1.Columns("UnitPrice")
            gridView1.FocusedRowHandle = 1
            radioGroup1.SelectedIndex = 2
        End Sub

        '<radioGroup1>
        Private Sub radioGroup1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioGroup1.SelectedIndexChanged
            Dim style As Integer = CInt(Fix(radioGroup1.EditValue))
            gridView1.FocusRectStyle = DrawFocusRectStyle.CellFocus
            gridView1.OptionsSelection.EnableAppearanceFocusedCell = True
            gridView1.OptionsSelection.EnableAppearanceFocusedRow = True
            gridView1.OptionsSelection.InvertSelection = False
            Select Case style
                Case 1 'Row
                    gridView1.OptionsSelection.EnableAppearanceFocusedCell = False
                    gridView1.FocusRectStyle = DrawFocusRectStyle.RowFocus
                Case 2 'Cell
                    gridView1.OptionsSelection.InvertSelection = True
                Case 4 'Cell Rect Only
                    gridView1.OptionsSelection.EnableAppearanceFocusedCell = False
                    gridView1.OptionsSelection.EnableAppearanceFocusedRow = False
                Case 5 'None
                    gridView1.FocusRectStyle = DrawFocusRectStyle.None
                    gridView1.OptionsSelection.EnableAppearanceFocusedCell = False
                    gridView1.OptionsSelection.EnableAppearanceFocusedRow = False

            End Select
            SetFocusedColumnAppearance(Nothing, gridView1.FocusedColumn)
            gridControl1.Focus()
        End Sub

        '<gridControl1>
        Private Sub SetFocusedColumnAppearance(ByVal col1 As DevExpress.XtraGrid.Columns.GridColumn, ByVal col2 As DevExpress.XtraGrid.Columns.GridColumn)
            If radioGroup1.EditValue Is Nothing Then
                Return
            End If
            If Not col1 Is Nothing Then
                col1.AppearanceCell.Reset()
            End If
            If Not col2 Is Nothing Then
                If 3.Equals(radioGroup1.EditValue) Then
                    col2.AppearanceCell.BackColor = SystemColors.Highlight
                    col2.AppearanceCell.ForeColor = SystemColors.HighlightText
                Else
                    col2.AppearanceCell.Reset()
                End If
            End If
        End Sub
        '</radioGroup1>

        Private Sub gridView1_FocusedColumnChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs) Handles gridView1.FocusedColumnChanged
            SetFocusedColumnAppearance(e.PrevFocusedColumn, e.FocusedColumn)
        End Sub
        '</gridControl1>
        Public Overrides ReadOnly Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace

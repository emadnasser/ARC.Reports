Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraGrid.Demos
    ''' <summary>
    ''' Summary description for CellSelection.
    ''' </summary>
    Partial Public Class CellSelection
        Inherits TutorialControl

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            CreateWaitDialog()
            InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\GridMainDemo\Modules\CellSelection.vb"
            TutorialInfo.WhatsThisXMLFile = "CellSelection.xml"
            InitNWindData()
            InitEditors()
            InitSelection()
            '
            ' TODO: Add any constructor code after InitializeComponent call
            '
        End Sub
        Private updateValues As Boolean = False
        #Region "Init"
        Private ReadOnly Property CurrentGridView() As GridView
            Get
                Return gridView1
            End Get
        End Property
        Protected Overrides Sub InitMDBData(ByVal connectionString As String)
            Dim dataSet As New DataSet()
            Dim oleDBAdapter As New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM Customers", connectionString)

            SetWaitDialogCaption(My.Resources.LoadingCustomers)
            oleDBAdapter.Fill(dataSet, "Customers")
            gridControl1.DataSource = dataSet.Tables("Customers")
        End Sub
        Protected Overrides Sub InitXMLData(ByVal dataFileName As String)
            Dim dataSet As New DataSet()
            SetWaitDialogCaption(My.Resources.LoadingTables)
            dataSet.ReadXml(dataFileName)
            gridControl1.DataSource = dataSet.Tables("Customers")
        End Sub
        Private Sub InitEditors()
            For Each mode As GridMultiSelectMode In System.Enum.GetValues(GetType(GridMultiSelectMode))
                icbSelectMode.Properties.Items.Add(New ImageComboBoxItem(EnumTitlesKeeper(Of GridMultiSelectMode).GetTitle(mode), mode, -1))
            Next mode
            updateValues = True
            icbSelectMode.EditValue = gridView1.OptionsSelection.MultiSelectMode
            ceMultiSelect.Checked = gridView1.OptionsSelection.MultiSelect
            updateValues = False
        End Sub
        Private Sub InitSelection()
            gridControl1.ForceInitialize()
            gridView1.SelectCellAnchorRange(3, colCompanyName, 12, colPostalCode)
        End Sub
        #End Region
        '<ceMultiSelect>
        Private Sub ceMultiSelect_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceMultiSelect.CheckedChanged
            If updateValues Then
                Return
            End If
            gridView1.OptionsSelection.MultiSelect = ceMultiSelect.Checked
            SetButtonEnabled()
        End Sub
        '</ceMultiSelect>
        '<icbSelectMode>
        Private Sub icbSelectMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles icbSelectMode.SelectedIndexChanged
            If updateValues Then
                Return
            End If
            gridView1.OptionsSelection.MultiSelectMode = CType(icbSelectMode.EditValue, GridMultiSelectMode)
            sbRecords.Text = If(gridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CellSelect, My.Resources.ShowSelectedValues, My.Resources.ShowSelectedRecords)
        End Sub
        '</icbSelectMode>
        Private Sub SetButtonEnabled()
            sbRecords.Enabled = gridView1.SelectedRowsCount > 0 AndAlso ceMultiSelect.Checked
            icbSelectMode.Enabled = ceMultiSelect.Checked
        End Sub
        '<icbTranslucentColors>
        Private Sub icbTranslucentColors_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles icbTranslucentColors.CheckedChanged
            If icbTranslucentColors.Checked Then
                gridView1.Appearance.SelectedRow.BackColor = Color.FromArgb(30, 0, 0, 240)
                gridView1.Appearance.FocusedRow.BackColor = Color.FromArgb(60, 0, 0, 240)
            Else
                gridView1.Appearance.SelectedRow.Reset()
                gridView1.Appearance.FocusedRow.Reset()
            End If
        End Sub
        '</icbTranslucentColors>
        '<sbRecords>
        Private Sub sbRecords_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbRecords.Click
            DemosHelper.ShowDescriptionForm(Control.MousePosition, GetSelectedRows(gridView1),If(gridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CellSelect, My.Resources.SelectedCells, My.Resources.SelectedRows))
        End Sub
        '</sbRecords>
        Private Sub gridView1_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles gridView1.SelectionChanged
            SetButtonEnabled()
        End Sub
        '<sbRecords>
        Private Function GetSelectedRows(ByVal view As GridView) As String
            Dim ret As String = ""
            Dim rowIndex As Integer = -1
            If view.OptionsSelection.MultiSelectMode <> GridMultiSelectMode.CellSelect Then
                For Each i As Integer In gridView1.GetSelectedRows()
                    Dim row_Renamed As DataRow = gridView1.GetDataRow(i)
                    If ret <> "" Then
                        ret &= ControlChars.CrLf
                    End If
                    ret &= String.Format("{2}: {0} (#{1})", row_Renamed("CompanyName"), i, My.Resources.CompanyName)
                Next i
            Else
                For Each cell As GridCell In view.GetSelectedCells()
                    If rowIndex <> cell.RowHandle Then
                        If ret <> "" Then
                            ret &= ControlChars.CrLf
                        End If
                        ret &= String.Format("{1}: #{0}", cell.RowHandle, My.Resources.Row)
                    End If
                    ret &= ControlChars.CrLf & "    " & view.GetRowCellDisplayText(cell.RowHandle, cell.Column)
                    rowIndex = cell.RowHandle
                Next cell
            End If
            Return ret
        End Function
        '</sbRecords>
    End Class
End Namespace

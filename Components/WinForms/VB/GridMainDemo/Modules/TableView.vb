Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraGrid.Views.Base
'<icbNewItemRow>
Imports DevExpress.XtraGrid.Views.Grid
'</icbNewItemRow>
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraBars.Navigation

Namespace DevExpress.XtraGrid.Demos
    ''' <summary>
    ''' Summary description for TableView.
    ''' </summary>
    Partial Public Class TableView
        Inherits TutorialControl

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            CreateWaitDialog()
            InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\GridMainDemo\Modules\TableView.vb"
            TutorialInfo.WhatsThisXMLFile = "TableView.xml"
            '
            ' TODO: Add any constructor code after InitializeComponent call
            '
        End Sub
        Private updateLayout As Boolean = False
        Private firstSearch As Boolean = True
        '<sbStart>
        Private searshString() As String = { "c", "a", "{BS}", "h", "a", "n", "{BS}", "{BS}", "e", "f", " ", "a", "n", "t", "o", "n", "'", "s", " ", "c", "^{DOWN}", "^{DOWN}", "^{DOWN}", "^{DOWN}", "^{DOWN}", "^{DOWN}", "^{HOME}", "{RIGHT}" }
        Private searchKeyIndex As Integer = 0
        '</sbStart>
        #Region "Init"
        Public Overrides ReadOnly Property ExportView() As BaseView
            Get
                Return gridView1
            End Get
        End Property
        Private Sub TableView_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitNWindData()
            InitEditing()
            gridView1_Layout(gridView1, EventArgs.Empty)
        End Sub

        Public Overrides ReadOnly Property ShowViewOptions() As Boolean
            Get
                Return True
            End Get
        End Property

        Private tblGrid As String = "[Order Details]"
        Private tblLookUp As String = "Products"
        Protected Overrides Sub InitMDBData(ByVal connectionString As String)
            Dim ds As New DataSet()
            Dim oleDbDataAdapter As New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " & tblGrid, connectionString)
            SetWaitDialogCaption(My.Resources.LoadingOrderDetails)
            oleDbDataAdapter.Fill(ds, tblGrid)
            oleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " & tblLookUp, connectionString)
            SetWaitDialogCaption(My.Resources.LoadingProducts)
            oleDbDataAdapter.Fill(ds, tblLookUp)

            Dim dvManager As New DataViewManager(ds)
            Dim dv As DataView = dvManager.CreateDataView(ds.Tables(tblGrid))

            gridControl1.DataSource = dv
            repositoryItemLookUpEdit1.DataSource = ds.Tables(tblLookUp)
        End Sub
        Protected Overrides Sub InitXMLData(ByVal dataFileName As String)
            Dim ds As New DataSet()
            SetWaitDialogCaption(My.Resources.LoadingTables)
            ds.ReadXml(dataFileName)

            gridControl1.DataSource = ds.Tables(tblGrid)
            repositoryItemLookUpEdit1.DataSource = ds.Tables(tblLookUp)
        End Sub

        Private Sub InitEditing()
            icbNewItemRow.Properties.Items.Add(New ImageComboBoxItem(My.Resources.None, NewItemRowPosition.None, -1))
            icbNewItemRow.Properties.Items.Add(New ImageComboBoxItem(My.Resources.Top, NewItemRowPosition.Top, -1))
            icbNewItemRow.Properties.Items.Add(New ImageComboBoxItem(My.Resources.Bottom, NewItemRowPosition.Bottom, -1))
            icbButtons.Properties.Items.Add(New ImageComboBoxItem(My.Resources.DefaultString, ShowButtonModeEnum.Default, -1))
            icbButtons.Properties.Items.Add(New ImageComboBoxItem(My.Resources.ShowAlways, ShowButtonModeEnum.ShowAlways, -1))
            icbButtons.Properties.Items.Add(New ImageComboBoxItem(My.Resources.ShowForFocusedCell, ShowButtonModeEnum.ShowForFocusedCell, -1))
            icbButtons.Properties.Items.Add(New ImageComboBoxItem(My.Resources.ShowForFocusedRow, ShowButtonModeEnum.ShowForFocusedRow, -1))
            icbButtons.Properties.Items.Add(New ImageComboBoxItem(My.Resources.ShowOnlyInEditor, ShowButtonModeEnum.ShowOnlyInEditor, -1))
            icbButtons.EditValue = gridView1.OptionsView.ShowButtonMode
            icbSelectMode.Properties.Items.Add(New ImageComboBoxItem(My.Resources.RowSelect, GridMultiSelectMode.RowSelect, -1))
            icbSelectMode.Properties.Items.Add(New ImageComboBoxItem(My.Resources.CellSelect, GridMultiSelectMode.CellSelect, -1))
            icbSelectMode.Properties.Items.Add(New ImageComboBoxItem(My.Resources.CheckBoxRowSelect, GridMultiSelectMode.CheckBoxRowSelect, -1))
            icbSelectMode.EditValue = gridView1.OptionsSelection.MultiSelectMode
            chEdit.Checked = gridView1.OptionsBehavior.Editable
        End Sub
        #End Region
        #Region "Editing"

        Private Sub gridView1_Layout(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridView1.Layout
            updateLayout = True
            icbNewItemRow.EditValue = gridView1.OptionsView.NewItemRowPosition
            ceMultiSelect.Checked = gridView1.OptionsSelection.MultiSelect
            SetPosition()
            updateLayout = False
        End Sub
        Private Sub navigationPane1_SelectedPageChanged(ByVal sender As Object, ByVal e As XtraBars.Navigation.SelectedPageChangedEventArgs) Handles navigationPane1.SelectedPageChanged
            If e.Page Is navigationPage2 Then
                gridView1.OptionsBehavior.AllowIncrementalSearch = True
                If firstSearch Then
                    StartSearch()
                End If
                firstSearch = False
            Else
                gridView1.OptionsBehavior.AllowIncrementalSearch = False
                If Not firstSearch Then
                    StopSearch()
                End If
            End If
            gridControl1.UseEmbeddedNavigator = e.Page Is navigationPage3
            ceMultiSelect.Checked = e.Page Is navigationPage4
        End Sub
        #End Region
        #Region "NewItemRow"
        '<icbNewItemRow>
        Private Sub icbNewItemRow_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles icbNewItemRow.SelectedIndexChanged
            '<skip>
            If updateLayout Then
                Return
            End If
            '</skip>
            gridView1.OptionsView.NewItemRowPosition = CType(icbNewItemRow.EditValue, NewItemRowPosition)
            SetPosition()
            '<skip>
            GridRibbonMenuManager.RefreshOptionsMenu(gridView1)
            '</skip>
        End Sub
        Private Sub SetPosition()
            If gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom AndAlso gridView1.SortInfo.GroupCount = 0 Then
                gridView1.FocusedRowHandle = gridView1.RowCount - 2
                gridView1.MakeRowVisible(gridView1.FocusedRowHandle, False)
            End If
        End Sub
        '</icbNewItemRow>
        Private Sub gridView1_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gridView1.InitNewRow
            Dim row_Renamed As DataRow = gridView1.GetDataRow(e.RowHandle)
            row_Renamed("Quantity") = 1
            row_Renamed("UnitPrice") = 0
            row_Renamed("Discount") = 0
            row_Renamed("OrderID") = 99999
        End Sub
        #End Region
        #Region "Incremental Search"
        '<sbStart>
        Private Sub StartSearch()
            sbStart.Enabled = False
            searchKeyIndex = 0
            lbEvent.Text = My.Resources.TableView_AutoSearch
            gridView1.FocusedColumn = gridColumn2
            timer1.Start()
        End Sub

        Private Sub StopSearch()
            sbStart.Enabled = True
            timer1.Stop()
            lbEvent.Text = My.Resources.TableView_IncrementalSearch
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

        Private Sub gridControl1_ProcessGridKey(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gridControl1.ProcessGridKey
            If e.KeyCode = Keys.Escape Then
                StopSearch()
            End If
        End Sub

        Private Sub gridControl1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gridControl1.MouseDown
            StopSearch()
        End Sub

        Private Sub sbStart_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbStart.Click
            StartSearch()
        End Sub
        '</sbStart>
        #End Region
        #Region "Editing And Navigation"
        '<icbButtons>
        Private Sub icbButtons_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles icbButtons.SelectedIndexChanged
            gridView1.OptionsView.ShowButtonMode = CType(icbButtons.EditValue, ShowButtonModeEnum)
        End Sub
        '</icbButtons>
        '<chEdit>
        Private Sub chEdit_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chEdit.CheckedChanged
            gridView1.OptionsBehavior.Editable = chEdit.Checked
        End Sub
        '</chEdit>
        Private Function EditRecord() As Boolean
            Dim row_Renamed As DataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle)
            If row_Renamed Is Nothing Then
                Return False
            End If
            Dim frm As New PopupForm()
            frm.InitData(Me.FindForm(), gridControl1, gridView1, row_Renamed)
            Dim ret As Boolean = frm.ShowDialog() = DialogResult.OK
            If ret Then
                row_Renamed.ItemArray = frm.Row.ItemArray
                row_Renamed.EndEdit()
            End If
            Return ret
        End Function

        Private Sub gridControl1_EmbeddedNavigator_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles gridControl1.EmbeddedNavigator.ButtonClick
            If e.Button.ButtonType = DevExpress.XtraEditors.NavigatorButtonType.Edit Then
                EditRecord()
                e.Handled = True
            End If
            If e.Button.ButtonType = DevExpress.XtraEditors.NavigatorButtonType.Append Then
                gridView1.AddNewRow()
                If EditRecord() Then
                    gridView1.UpdateCurrentRow()
                Else
                    gridView1.CancelUpdateCurrentRow()
                End If
                e.Handled = True
            End If
        End Sub
        #End Region
        #Region "MultiSelect"
        Private Sub UpdateSelection()
            Dim updateCells As Boolean = gridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CellSelect
            If ceMultiSelect.Checked Then
                If Not updateCells Then
                    gridView1.SelectRange(4, 20)
                    sbRecords.Text = My.Resources.ShowSelectedRecords
                Else
                    gridView1.ClearSelection()
                    gridView1.SelectCells(5, gridView1.Columns("ProductID"), 15, gridView1.Columns("Quantity"))
                    sbRecords.Text = My.Resources.ShowSelectedValues
                End If
            End If
        End Sub
        '<ceMultiSelect>
        Private Sub ceMultiSelect_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceMultiSelect.CheckedChanged
            '<skip>
            SetButtonEnabled()
            If updateLayout Then
                Return
            End If
            '</skip>
            gridView1.OptionsSelection.MultiSelect = ceMultiSelect.Checked
            UpdateSelection()
            '<skip>
            GridRibbonMenuManager.RefreshOptionsMenu(gridView1)
            '</skip>
        End Sub
        '</ceMultiSelect>
        Private Sub SetButtonEnabled()
            sbRecords.Enabled = gridView1.SelectedRowsCount > 0 AndAlso ceMultiSelect.Checked
            icbSelectMode.Enabled = ceMultiSelect.Checked
        End Sub

        Private Sub gridView1_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles gridView1.SelectionChanged
            SetButtonEnabled()
        End Sub
        '<sbRecords>
        Private Sub sbRecords_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbRecords.Click
            DemosHelper.ShowDescriptionForm(Control.MousePosition, GetSelectedRows(gridView1),If(gridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CellSelect, My.Resources.SelectedCells, My.Resources.SelectedRows))
        End Sub

        Private Function GetSelectedRows(ByVal view As GridView) As String
            Dim ret As String = ""
            Dim rowIndex As Integer = -1
            If view.OptionsSelection.MultiSelectMode <> GridMultiSelectMode.CellSelect Then
                For Each i As Integer In gridView1.GetSelectedRows()
                    Dim row_Renamed As DataRow = gridView1.GetDataRow(i)
                    If ret <> "" Then
                        ret &= ControlChars.CrLf
                    End If
                    ret &= String.Format("{2}: #{0} {1}", row_Renamed("OrderID"), gridView1.GetRowCellDisplayText(i, gridColumn2), My.Resources.Order)
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
        '<icbSelectMode>
        Private Sub icbSelectMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles icbSelectMode.SelectedIndexChanged
            gridView1.OptionsSelection.MultiSelectMode = CType(icbSelectMode.EditValue, GridMultiSelectMode)
            UpdateSelection()
        End Sub
        '</icbSelectMode>
        #End Region
    End Class

End Namespace

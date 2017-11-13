Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Layout.ViewInfo
Imports DevExpress.XtraLayout.Customization
Imports DevExpress.XtraGrid.Views.Layout
Imports DevExpress.XtraLayout.Utils
Imports System.Data.OleDb
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraGrid.Demos
    Partial Public Class AdvancedGridEditing
        Inherits BaseLayoutModule

        '<allowEditOnDoubleClick>
        Private allowEditOnDoubleClickCore As Boolean
        '</allowEditOnDoubleClick>
        Public Sub New()
            CreateWaitDialog()
            InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\GridMainDemo\ModulesLayoutView\AdvancedGridEditing.vb"
            TutorialInfo.WhatsThisXMLFile = "AdvancedGridEditing.xml"
            InitData()
            InitControls()
        End Sub
        Protected Sub InitControls()
            AddHandler layoutControl1.SizeChanged, AddressOf layoutControl1_SizeChanged
            '<cbMasterTablePosition>
            AddHandler cbMasterTablePosition.SelectedIndexChanged, AddressOf cbMasterTablePosition_SelectedIndexChanged
            '</cbMasterTablePosition>
            For Each mode As MasterTablePosition In System.Enum.GetValues(GetType(MasterTablePosition))
                cbMasterTablePosition.Properties.Items.Add(New ImageComboBoxItem(EnumTitlesKeeper(Of MasterTablePosition).GetTitle(mode), mode, -1))
            Next mode
            cbMasterTablePosition.EditValue = MasterTablePosition.Left
            '<masterGrid>
            AddHandler employesLayoutView.CustomUnboundColumnData, AddressOf employesLayoutView_CustomUnboundColumnData
            '</masterGrid>

            viewOrderGridView.ForceDoubleClick = True
            '<allowEditOnDoubleClick>
            AddHandler viewOrderGridView.DoubleClick, AddressOf viewOrderGridView_DoubleClick
            '</allowEditOnDoubleClick>
            AddHandler editOrderlayoutView.MouseDown, AddressOf editOrderlayoutView_MouseDown
            '<detailShowHideBtn>
            AddHandler detailShowHideBtn.Click, AddressOf detailShowHideBtn_Click
            '</detailShowHideBtn>
            allowEditOnDoubleClickCore = allowEditOnDoubleClick.Checked
            editOrderlayoutView.OptionsBehavior.AutoFocusCardOnScrolling = True
            editOrderlayoutView.OptionsBehavior.AllowSwitchViewModes = False
            Me.BorderStyle = BorderStyle.None
            Me.layoutControl1.Root.GroupBordersVisible = False
        End Sub
        '<masterGrid>
        Protected Sub employesLayoutView_CustomUnboundColumnData(ByVal sender As Object, ByVal e As CustomColumnDataEventArgs)
            If e.Column Is colFullName Then
                Dim row_Renamed As DataRow = CType(e.Row, DataRowView).Row
                e.Value = String.Format("{0} {1}", row_Renamed("FirstName"), row_Renamed("LastName"))
            End If
        End Sub
        '</masterGrid>
        Protected Overridable Sub InitData()
            Dim ds As DataSet = NWindDataSet()
            Dim masterBindingSource As New BindingSource(ds, "Employees")
            masterGrid.DataSource = masterBindingSource
            Dim detailBindingSource As New BindingSource(masterBindingSource, "EmployeesOrders")
            detailGrid.DataSource = detailBindingSource
            '<masterGrid>
            '            
            '~Note: the following code is set at desing-time and shown here for educational purposes only.
            '~masterGrid.MainView = employesLayoutView
            '             
            '</masterGrid>
        End Sub
        Public Enum MasterTablePosition
            Left
            Top
            Right
            Bottom
        End Enum
        '<cbMasterTablePosition>
        Protected Sub cbMasterTablePosition_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim position As MasterTablePosition = CType(cbMasterTablePosition.EditValue, MasterTablePosition)
            Select Case position
                Case MasterTablePosition.Left
                    SetMasterTableLeftPlacement()
                Case MasterTablePosition.Top
                    SetMasterTableTopPlacement()
                Case MasterTablePosition.Right
                    SetMasterTableRightPlacement()
                Case MasterTablePosition.Bottom
                    SetMasterTableBottomPlacement()
            End Select
        End Sub

        Protected Sub SetMasterTableLeftPlacement()
            Dim dc As New LayoutItemDragController(masterTableItem, detailTableItem, InsertLocation.Before, LayoutType.Horizontal)
            DoDragItem(dc)
            SetMasterViewColumnLayout()
        End Sub
        Protected Sub SetMasterTableRightPlacement()
            Dim dc As New LayoutItemDragController(masterTableItem, detailTableItem, InsertLocation.After, LayoutType.Horizontal)
            DoDragItem(dc)
            SetMasterViewColumnLayout()
        End Sub
        Private Sub SetMasterTableTopPlacement()
            Dim dc As New LayoutItemDragController(masterTableItem, detailTableItem, InsertLocation.Before, LayoutType.Vertical)
            DoDragItem(dc)
            SetMasterViewRowLayout()
        End Sub
        Protected Sub SetMasterTableBottomPlacement()
            Dim dc As New LayoutItemDragController(masterTableItem, detailTableItem, InsertLocation.After, LayoutType.Vertical)
            DoDragItem(dc)
            SetMasterViewRowLayout()
        End Sub
        Protected Sub DoDragItem(ByVal dc As LayoutItemDragController)
            masterTableItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Default
            masterTableItem.Move(dc)
        End Sub
        Protected Sub SetMasterViewColumnLayout()
            SetMasterItemVerticalSize()
            editOrderlayoutView.BeginUpdate()
            employesLayoutView.OptionsBehavior.AllowSwitchViewModes = True
            employesLayoutView.OptionsView.ViewMode = LayoutViewMode.Column
            employesLayoutView.OptionsMultiRecordMode.StretchCardToViewWidth = True
            employesLayoutView.OptionsBehavior.AllowSwitchViewModes = False
            editOrderlayoutView.EndUpdate()
        End Sub
        Protected Sub SetMasterViewRowLayout()
            SetMasterItemHorizontalSize()
            editOrderlayoutView.BeginUpdate()
            employesLayoutView.OptionsBehavior.AllowSwitchViewModes = True
            employesLayoutView.OptionsMultiRecordMode.StretchCardToViewWidth = False
            employesLayoutView.OptionsView.ViewMode = LayoutViewMode.Row
            employesLayoutView.OptionsBehavior.AllowSwitchViewModes = False
            employesLayoutView.TemplateCard.Update()
            editOrderlayoutView.EndUpdate()
        End Sub
        '</cbMasterTablePosition>
        Private isVertical As Boolean = False
        Protected Sub SetMasterItemVerticalSize()
            isVertical = True
            masterTableItem.MinSize = New Size(150, 0)
            masterTableItem.MaxSize = New Size(150, 0)
            masterTableItem.Size = New Size(150, 0)
            masterTableItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        End Sub
        Protected Sub SetMasterItemHorizontalSize()
            isVertical = False
            masterTableItem.MinSize = New Size(0, 160)
            masterTableItem.MaxSize = New Size(0, 160)
            masterTableItem.Size = New Size(0, 160)
            masterTableItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        End Sub
        Protected Sub layoutControl1_SizeChanged(ByVal sender As Object, ByVal e As EventArgs)
            If isVertical Then
                SetMasterItemVerticalSize()
            Else
                SetMasterItemHorizontalSize()
            End If
        End Sub

        Private fExtendedEditMode As Boolean = False
        Private strHideExtendedMode As String = My.Resources.Back
        Private strShowExtendedMode As String = My.Resources.EditOrder
        Protected Sub HideDetail(ByVal rowHandle As Integer)
            detailGrid.MainView.PostEditor()
            Dim datasourceRowIndex As Integer = editOrderlayoutView.GetDataSourceRowIndex(rowHandle)
            '<detailGrid>
            detailGrid.MainView = viewOrderGridView
            '</detailGrid>
            SynchronizeOrdersView(datasourceRowIndex)
            detailGrid.UseEmbeddedNavigator = False
            detailShowHideBtn.Text = strShowExtendedMode
            fExtendedEditMode = (detailGrid.MainView Is editOrderlayoutView)
        End Sub
        '<detailShowHideBtn>
        '<allowEditOnDoubleClick>
        '<detailGrid>
        Protected Sub ShowDetail(ByVal rowHandle As Integer)
            Dim datasourceRowIndex As Integer = viewOrderGridView.GetDataSourceRowIndex(rowHandle)
            detailGrid.MainView = editOrderlayoutView
            SynchronizeOrdersDetailView(datasourceRowIndex)
            detailGrid.UseEmbeddedNavigator = True
            detailShowHideBtn.Text = strHideExtendedMode
            fExtendedEditMode = (detailGrid.MainView Is editOrderlayoutView)
        End Sub
        '</detailGrid>

        Protected Sub SynchronizeOrdersView(ByVal dataSourceRowIndex As Integer)
            Dim rowHandle As Integer = viewOrderGridView.GetRowHandle(dataSourceRowIndex)
            viewOrderGridView.FocusedRowHandle = rowHandle
        End Sub
        '<detailGrid>
        Protected Sub SynchronizeOrdersDetailView(ByVal dataSourceRowIndex As Integer)
            Dim rowHandle As Integer = editOrderlayoutView.GetRowHandle(dataSourceRowIndex)
            editOrderlayoutView.VisibleRecordIndex = editOrderlayoutView.GetVisibleIndex(rowHandle)
            editOrderlayoutView.FocusedRowHandle = dataSourceRowIndex
        End Sub
        '</detailGrid>
        '</detailShowHideBtn>
        Protected Sub viewOrderGridView_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
            Dim ea As MouseEventArgs = TryCast(e, MouseEventArgs)
            If ea Is Nothing OrElse (Not allowEditOnDoubleClickCore) Then
                Return
            End If
            Dim hi As GridHitInfo = viewOrderGridView.CalcHitInfo(ea.Location)
            If hi.InRow Then
                ShowDetail(hi.RowHandle)
            End If
        End Sub
        '</allowEditOnDoubleClick>
        Protected Sub editOrderlayoutView_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            If e.Button = MouseButtons.Right Then
                Dim hi As LayoutViewHitInfo = editOrderlayoutView.CalcHitInfo(e.Location)
                If hi.InCard Then
                    HideDetail(hi.RowHandle)
                End If
            End If
        End Sub
        '<detailShowHideBtn>
        Protected Sub detailShowHideBtn_Click(ByVal sender As Object, ByVal e As EventArgs)
            If fExtendedEditMode Then
                HideDetail((TryCast(detailGrid.MainView, ColumnView)).FocusedRowHandle)
            Else
                ShowDetail((TryCast(detailGrid.MainView, ColumnView)).FocusedRowHandle)
            End If
        End Sub
        '</detailShowHideBtn>
        '<allowEditOnDoubleClick>
        Protected Sub allowEditOnDoubleClick_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles allowEditOnDoubleClick.CheckedChanged
            allowEditOnDoubleClickCore = allowEditOnDoubleClick.Checked
        End Sub
        '</allowEditOnDoubleClick>
    End Class
End Namespace

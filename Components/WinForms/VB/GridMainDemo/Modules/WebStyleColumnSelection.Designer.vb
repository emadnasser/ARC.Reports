Namespace DevExpress.XtraGrid.Demos
    Partial Public Class WebStyleColumnSelection
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WebStyleColumnSelection))
            Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
            Me.gridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.gridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.cePrintSelectedRowsOnly = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControl2 = New DevExpress.XtraLayout.LayoutControl()
            Me.icbShowCheckBoxSelectorInGroupRow = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.icbShowCheckBoxSelectorInPrintExport = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.icbShowCheckBoxSelectorInHeader = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.navigationPane1 = New DevExpress.XtraBars.Navigation.NavigationPane()
            Me.navigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cePrintSelectedRowsOnly.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl2.SuspendLayout()
            CType(Me.icbShowCheckBoxSelectorInGroupRow.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.icbShowCheckBoxSelectorInPrintExport.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.icbShowCheckBoxSelectorInHeader.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPane1.SuspendLayout()
            Me.navigationPage1.SuspendLayout()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            Me.SuspendLayout()
            '
            'repositoryItemTextEdit1
            '
            Me.repositoryItemTextEdit1.AutoHeight = False
            Me.repositoryItemTextEdit1.Mask.EditMask = "p"
            Me.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
            '
            'gridControl1
            '
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
            Me.gridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = False
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemLookUpEdit1, Me.repositoryItemCalcEdit1, Me.repositoryItemSpinEdit1, Me.repositoryItemTextEdit1})
            Me.gridControl1.Size = New System.Drawing.Size(706, 540)
            Me.gridControl1.TabIndex = 8
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            '
            'gridView1
            '
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gridColumn1, Me.gridColumn2, Me.gridColumn3, Me.gridColumn4, Me.gridColumn5, Me.gridColumn6})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.GroupCount = 1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.[True]
            Me.gridView1.OptionsBehavior.AutoExpandAllGroups = True
            Me.gridView1.OptionsBehavior.Editable = False
            Me.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.gridView1.OptionsDetail.EnableMasterViewMode = False
            Me.gridView1.OptionsFind.AlwaysVisible = True
            Me.gridView1.OptionsMenu.ShowGroupSummaryEditorItem = True
            Me.gridView1.OptionsSelection.MultiSelect = True
            Me.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
            Me.gridView1.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.[True]
            Me.gridView1.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.[True]
            Me.gridView1.OptionsSelection.ShowCheckBoxSelectorInPrintExport = DevExpress.Utils.DefaultBoolean.[True]
            Me.gridView1.OptionsView.AllowHtmlDrawHeaders = True
            Me.gridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.gridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)})
            '
            'gridColumn1
            '
            Me.gridColumn1.Caption = "Order #"
            Me.gridColumn1.FieldName = "OrderID"
            Me.gridColumn1.Name = "gridColumn1"
            Me.gridColumn1.Width = 86
            '
            'gridColumn2
            '
            Me.gridColumn2.Caption = "Product"
            Me.gridColumn2.ColumnEdit = Me.repositoryItemLookUpEdit1
            Me.gridColumn2.FieldName = "ProductID"
            Me.gridColumn2.Name = "gridColumn2"
            Me.gridColumn2.Visible = True
            Me.gridColumn2.VisibleIndex = 1
            Me.gridColumn2.Width = 146
            '
            'repositoryItemLookUpEdit1
            '
            Me.repositoryItemLookUpEdit1.AutoHeight = False
            Me.repositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductName", "Product Name")})
            Me.repositoryItemLookUpEdit1.DisplayMember = "ProductName"
            Me.repositoryItemLookUpEdit1.DropDownRows = 10
            Me.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1"
            Me.repositoryItemLookUpEdit1.PopupWidth = 220
            Me.repositoryItemLookUpEdit1.ShowHeader = False
            Me.repositoryItemLookUpEdit1.ValueMember = "ProductID"
            '
            'gridColumn3
            '
            Me.gridColumn3.Caption = "Unit Price"
            Me.gridColumn3.ColumnEdit = Me.repositoryItemCalcEdit1
            Me.gridColumn3.DisplayFormat.FormatString = "c"
            Me.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.gridColumn3.FieldName = "UnitPrice"
            Me.gridColumn3.Name = "gridColumn3"
            Me.gridColumn3.Visible = True
            Me.gridColumn3.VisibleIndex = 2
            Me.gridColumn3.Width = 85
            '
            'repositoryItemCalcEdit1
            '
            Me.repositoryItemCalcEdit1.AutoHeight = False
            Me.repositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemCalcEdit1.Mask.EditMask = "c"
            Me.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1"
            '
            'gridColumn4
            '
            Me.gridColumn4.Caption = "Quantity"
            Me.gridColumn4.ColumnEdit = Me.repositoryItemSpinEdit1
            Me.gridColumn4.FieldName = "Quantity"
            Me.gridColumn4.Name = "gridColumn4"
            Me.gridColumn4.Visible = True
            Me.gridColumn4.VisibleIndex = 3
            Me.gridColumn4.Width = 82
            '
            'repositoryItemSpinEdit1
            '
            Me.repositoryItemSpinEdit1.AutoHeight = False
            Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemSpinEdit1.IsFloatValue = False
            Me.repositoryItemSpinEdit1.Mask.EditMask = "N00"
            Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
            '
            'gridColumn5
            '
            Me.gridColumn5.Caption = "Discount"
            Me.gridColumn5.ColumnEdit = Me.repositoryItemTextEdit1
            Me.gridColumn5.DisplayFormat.FormatString = "p"
            Me.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.gridColumn5.FieldName = "Discount"
            Me.gridColumn5.Name = "gridColumn5"
            Me.gridColumn5.Visible = True
            Me.gridColumn5.VisibleIndex = 4
            Me.gridColumn5.Width = 80
            '
            'gridColumn6
            '
            Me.gridColumn6.Caption = "<b><u>Total"
            Me.gridColumn6.DisplayFormat.FormatString = "c"
            Me.gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.gridColumn6.FieldName = "Total"
            Me.gridColumn6.Image = CType(resources.GetObject("gridColumn6.Image"), System.Drawing.Image)
            Me.gridColumn6.ImageIndex = 0
            Me.gridColumn6.Name = "gridColumn6"
            Me.gridColumn6.OptionsColumn.AllowEdit = False
            Me.gridColumn6.ShowUnboundExpressionMenu = True
            Me.gridColumn6.UnboundExpression = "[UnitPrice] * [Quantity] * (1 - [Discount])"
            Me.gridColumn6.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
            Me.gridColumn6.Visible = True
            Me.gridColumn6.VisibleIndex = 5
            Me.gridColumn6.Width = 109
            '
            'cePrintSelectedRowsOnly
            '
            Me.cePrintSelectedRowsOnly.Location = New System.Drawing.Point(12, 143)
            Me.cePrintSelectedRowsOnly.Name = "cePrintSelectedRowsOnly"
            Me.cePrintSelectedRowsOnly.Properties.Caption = "Print Selected Rows Only"
            Me.cePrintSelectedRowsOnly.Size = New System.Drawing.Size(223, 19)
            Me.cePrintSelectedRowsOnly.StyleController = Me.layoutControl2
            Me.cePrintSelectedRowsOnly.TabIndex = 12
            '
            'layoutControl2
            '
            Me.layoutControl2.AllowCustomization = False
            Me.layoutControl2.Controls.Add(Me.cePrintSelectedRowsOnly)
            Me.layoutControl2.Controls.Add(Me.icbShowCheckBoxSelectorInGroupRow)
            Me.layoutControl2.Controls.Add(Me.icbShowCheckBoxSelectorInPrintExport)
            Me.layoutControl2.Controls.Add(Me.icbShowCheckBoxSelectorInHeader)
            Me.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl2.Name = "layoutControl2"
            Me.layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1032, 180, 450, 350)
            Me.layoutControl2.Root = Me.layoutControlGroup3
            Me.layoutControl2.Size = New System.Drawing.Size(247, 480)
            Me.layoutControl2.TabIndex = 0
            Me.layoutControl2.Text = "layoutControl2"
            '
            'icbShowCheckBoxSelectorInGroupRow
            '
            Me.icbShowCheckBoxSelectorInGroupRow.Location = New System.Drawing.Point(12, 28)
            Me.icbShowCheckBoxSelectorInGroupRow.Name = "icbShowCheckBoxSelectorInGroupRow"
            Me.icbShowCheckBoxSelectorInGroupRow.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbShowCheckBoxSelectorInGroupRow.Size = New System.Drawing.Size(223, 20)
            Me.icbShowCheckBoxSelectorInGroupRow.StyleController = Me.layoutControl2
            Me.icbShowCheckBoxSelectorInGroupRow.TabIndex = 9
            '
            'icbShowCheckBoxSelectorInPrintExport
            '
            Me.icbShowCheckBoxSelectorInPrintExport.Location = New System.Drawing.Point(12, 108)
            Me.icbShowCheckBoxSelectorInPrintExport.Name = "icbShowCheckBoxSelectorInPrintExport"
            Me.icbShowCheckBoxSelectorInPrintExport.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbShowCheckBoxSelectorInPrintExport.Size = New System.Drawing.Size(223, 20)
            Me.icbShowCheckBoxSelectorInPrintExport.StyleController = Me.layoutControl2
            Me.icbShowCheckBoxSelectorInPrintExport.TabIndex = 11
            '
            'icbShowCheckBoxSelectorInHeader
            '
            Me.icbShowCheckBoxSelectorInHeader.Location = New System.Drawing.Point(12, 68)
            Me.icbShowCheckBoxSelectorInHeader.Name = "icbShowCheckBoxSelectorInHeader"
            Me.icbShowCheckBoxSelectorInHeader.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbShowCheckBoxSelectorInHeader.Size = New System.Drawing.Size(223, 20)
            Me.icbShowCheckBoxSelectorInHeader.StyleController = Me.layoutControl2
            Me.icbShowCheckBoxSelectorInHeader.TabIndex = 10
            '
            'layoutControlGroup3
            '
            Me.layoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup3.GroupBordersVisible = False
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.emptySpaceItem4, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5, Me.emptySpaceItem5})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup3.Name = "Root"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(247, 480)
            Me.layoutControlGroup3.TextVisible = False
            '
            'layoutControlItem2
            '
            Me.layoutControlItem2.Control = Me.icbShowCheckBoxSelectorInGroupRow
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(227, 40)
            Me.layoutControlItem2.Text = "Show Check Box Selector In Group Row:"
            Me.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(214, 13)
            '
            'emptySpaceItem4
            '
            Me.emptySpaceItem4.AllowHotTrack = False
            Me.emptySpaceItem4.Location = New System.Drawing.Point(0, 154)
            Me.emptySpaceItem4.Name = "emptySpaceItem4"
            Me.emptySpaceItem4.Size = New System.Drawing.Size(227, 306)
            Me.emptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
            '
            'layoutControlItem3
            '
            Me.layoutControlItem3.Control = Me.icbShowCheckBoxSelectorInHeader
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 40)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(227, 40)
            Me.layoutControlItem3.Text = "Show Check Box Selector In Column Header:"
            Me.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(214, 13)
            '
            'layoutControlItem4
            '
            Me.layoutControlItem4.Control = Me.icbShowCheckBoxSelectorInPrintExport
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 80)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(227, 40)
            Me.layoutControlItem4.Text = "Show Check Box Selector In Print && Export:"
            Me.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(214, 13)
            '
            'layoutControlItem5
            '
            Me.layoutControlItem5.Control = Me.cePrintSelectedRowsOnly
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 131)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(227, 23)
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem5.TextVisible = False
            '
            'emptySpaceItem5
            '
            Me.emptySpaceItem5.AllowHotTrack = False
            Me.emptySpaceItem5.Location = New System.Drawing.Point(0, 120)
            Me.emptySpaceItem5.Name = "emptySpaceItem5"
            Me.emptySpaceItem5.Size = New System.Drawing.Size(227, 11)
            Me.emptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
            '
            'navigationPane1
            '
            Me.navigationPane1.Controls.Add(Me.navigationPage1)
            Me.navigationPane1.Dock = System.Windows.Forms.DockStyle.Right
            Me.navigationPane1.Location = New System.Drawing.Point(716, 0)
            Me.navigationPane1.Name = "navigationPane1"
            Me.navigationPane1.PageProperties.AppearanceCaption.Options.UseTextOptions = True
            Me.navigationPane1.PageProperties.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
            Me.navigationPane1.PageProperties.ShowExpandButton = False
            Me.navigationPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.navigationPage1})
            Me.navigationPane1.RegularSize = New System.Drawing.Size(297, 540)
            Me.navigationPane1.SelectedPage = Me.navigationPage1
            Me.navigationPane1.SelectedPageIndex = 0
            Me.navigationPane1.Size = New System.Drawing.Size(297, 540)
            Me.navigationPane1.TabIndex = 10
            '
            'navigationPage1
            '
            Me.navigationPage1.Caption = "Options"
            Me.navigationPage1.Controls.Add(Me.layoutControl2)
            Me.navigationPage1.Image = CType(resources.GetObject("navigationPage1.Image"), System.Drawing.Image)
            Me.navigationPage1.Name = "navigationPage1"
            Me.navigationPage1.Size = New System.Drawing.Size(247, 480)
            '
            'panelControl1
            '
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Controls.Add(Me.gridControl1)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
            Me.panelControl1.Size = New System.Drawing.Size(716, 540)
            Me.panelControl1.TabIndex = 11
            '
            'WebStyleColumnSelection
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.navigationPane1)
            Me.Name = "WebStyleColumnSelection"
            Me.Size = New System.Drawing.Size(1013, 540)
            CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cePrintSelectedRowsOnly.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl2.ResumeLayout(False)
            CType(Me.icbShowCheckBoxSelectorInGroupRow.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.icbShowCheckBoxSelectorInPrintExport.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.icbShowCheckBoxSelectorInHeader.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPane1.ResumeLayout(False)
            Me.navigationPage1.ResumeLayout(False)
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private repositoryItemTextEdit1 As XtraEditors.Repository.RepositoryItemTextEdit
        Private gridControl1 As GridControl
        Private gridView1 As Views.Grid.GridView
        Private gridColumn1 As Columns.GridColumn
        Private gridColumn2 As Columns.GridColumn
        Private repositoryItemLookUpEdit1 As XtraEditors.Repository.RepositoryItemLookUpEdit
        Private gridColumn3 As Columns.GridColumn
        Private repositoryItemCalcEdit1 As XtraEditors.Repository.RepositoryItemCalcEdit
        Private gridColumn4 As Columns.GridColumn
        Private repositoryItemSpinEdit1 As XtraEditors.Repository.RepositoryItemSpinEdit
        Private gridColumn5 As Columns.GridColumn
        Private gridColumn6 As Columns.GridColumn
        Private WithEvents icbShowCheckBoxSelectorInPrintExport As XtraEditors.ImageComboBoxEdit
        Private WithEvents icbShowCheckBoxSelectorInHeader As XtraEditors.ImageComboBoxEdit
        Private WithEvents icbShowCheckBoxSelectorInGroupRow As XtraEditors.ImageComboBoxEdit
        Private WithEvents cePrintSelectedRowsOnly As XtraEditors.CheckEdit
        Private layoutControl2 As XtraLayout.LayoutControl
        Private layoutControlGroup3 As XtraLayout.LayoutControlGroup
        Private layoutControlItem2 As XtraLayout.LayoutControlItem
        Private emptySpaceItem4 As XtraLayout.EmptySpaceItem
        Private layoutControlItem3 As XtraLayout.LayoutControlItem
        Private layoutControlItem4 As XtraLayout.LayoutControlItem
        Private layoutControlItem5 As XtraLayout.LayoutControlItem
        Private emptySpaceItem5 As XtraLayout.EmptySpaceItem
        Private navigationPane1 As XtraBars.Navigation.NavigationPane
        Private navigationPage1 As XtraBars.Navigation.NavigationPage
        Private panelControl1 As XtraEditors.PanelControl
    End Class
End Namespace

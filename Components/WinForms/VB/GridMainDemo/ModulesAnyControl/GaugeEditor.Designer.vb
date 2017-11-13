Namespace DevExpress.XtraGrid.Demos
    Partial Public Class GaugeEditor
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
            Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
            Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GaugeEditor))
            Dim ScaleLabel1 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
            Me.colTask = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.repositoryItemMemoEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
            Me.layoutViewField_colTask = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.cpHighPriority = New DevExpress.XtraEditors.ColorPickEdit()
            Me.cpMediumPriority = New DevExpress.XtraEditors.ColorPickEdit()
            Me.cpOverDue = New DevExpress.XtraEditors.ColorPickEdit()
            Me.cpActive = New DevExpress.XtraEditors.ColorPickEdit()
            Me.cpLowPriority = New DevExpress.XtraEditors.ColorPickEdit()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.layoutView1 = New DevExpress.XtraGrid.Views.Layout.LayoutView()
            Me.colCategory = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_colCategory = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colPercentComplete = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_colPercentComplete = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colDueDate = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_colDueDate = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.gaugeColumn = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_layoutViewColumn1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colPriority = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_layoutViewColumn1_1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.layoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
            Me.item1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.repositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
            Me.gaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge1 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.imageIndicatorComponent1 = New DevExpress.XtraGauges.Win.Base.ImageIndicatorComponent()
            Me.arcScaleRangeBarComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent()
            Me.arcScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
            CType(Me.repositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutViewField_colTask, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType(Me.cpHighPriority.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cpMediumPriority.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cpOverDue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cpActive.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cpLowPriority.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutViewField_colCategory, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutViewField_colPercentComplete, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutViewField_colDueDate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutViewField_layoutViewColumn1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutViewField_layoutViewColumn1_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.item1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.imageIndicatorComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleRangeBarComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'colTask
            '
            Me.colTask.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 14.0!)
            Me.colTask.AppearanceCell.Options.UseFont = True
            Me.colTask.AppearanceCell.Options.UseTextOptions = True
            Me.colTask.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.None
            Me.colTask.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.colTask.Caption = "Task"
            Me.colTask.ColumnEdit = Me.repositoryItemMemoEdit2
            Me.colTask.FieldName = "TaskName"
            Me.colTask.LayoutViewField = Me.layoutViewField_colTask
            Me.colTask.Name = "colTask"
            Me.colTask.OptionsColumn.AllowEdit = False
            Me.colTask.OptionsColumn.AllowFocus = False
            Me.colTask.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
            Me.colTask.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
            Me.colTask.OptionsFilter.AllowAutoFilter = False
            Me.colTask.OptionsFilter.AllowFilter = False
            '
            'repositoryItemMemoEdit2
            '
            Me.repositoryItemMemoEdit2.Name = "repositoryItemMemoEdit2"
            '
            'layoutViewField_colTask
            '
            Me.layoutViewField_colTask.EditorPreferredWidth = 158
            Me.layoutViewField_colTask.Location = New System.Drawing.Point(0, 0)
            Me.layoutViewField_colTask.MaxSize = New System.Drawing.Size(0, 104)
            Me.layoutViewField_colTask.MinSize = New System.Drawing.Size(41, 104)
            Me.layoutViewField_colTask.Name = "layoutViewField_colTask"
            Me.layoutViewField_colTask.OptionsCustomization.AllowDrag = DevExpress.XtraLayout.ItemDragDropMode.Allow
            Me.layoutViewField_colTask.OptionsCustomization.AllowDrop = DevExpress.XtraLayout.ItemDragDropMode.Allow
            Me.layoutViewField_colTask.Padding = New DevExpress.XtraLayout.Utils.Padding(17, 2, 12, 2)
            Me.layoutViewField_colTask.Size = New System.Drawing.Size(179, 104)
            Me.layoutViewField_colTask.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutViewField_colTask.Spacing = New DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1)
            Me.layoutViewField_colTask.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutViewField_colTask.TextVisible = False
            '
            'layoutControl1
            '
            Me.layoutControl1.Controls.Add(Me.cpHighPriority)
            Me.layoutControl1.Controls.Add(Me.cpMediumPriority)
            Me.layoutControl1.Controls.Add(Me.cpOverDue)
            Me.layoutControl1.Controls.Add(Me.cpActive)
            Me.layoutControl1.Controls.Add(Me.cpLowPriority)
            Me.layoutControl1.Controls.Add(Me.gridControl1)
            Me.layoutControl1.Controls.Add(Me.gaugeControl1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(382, 0, 1476, 1040)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(1204, 622)
            Me.layoutControl1.TabIndex = 1
            Me.layoutControl1.Text = "layoutControl1"
            '
            'cpHighPriority
            '
            Me.cpHighPriority.EditValue = System.Drawing.Color.Empty
            Me.cpHighPriority.Location = New System.Drawing.Point(1019, 192)
            Me.cpHighPriority.Name = "cpHighPriority"
            Me.cpHighPriority.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cpHighPriority.Size = New System.Drawing.Size(161, 20)
            Me.cpHighPriority.StyleController = Me.layoutControl1
            Me.cpHighPriority.TabIndex = 14
            '
            'cpMediumPriority
            '
            Me.cpMediumPriority.EditValue = System.Drawing.Color.Empty
            Me.cpMediumPriority.Location = New System.Drawing.Point(1019, 168)
            Me.cpMediumPriority.Name = "cpMediumPriority"
            Me.cpMediumPriority.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cpMediumPriority.Size = New System.Drawing.Size(161, 20)
            Me.cpMediumPriority.StyleController = Me.layoutControl1
            Me.cpMediumPriority.TabIndex = 13
            '
            'cpOverDue
            '
            Me.cpOverDue.EditValue = System.Drawing.Color.Empty
            Me.cpOverDue.Location = New System.Drawing.Point(1019, 67)
            Me.cpOverDue.Name = "cpOverDue"
            Me.cpOverDue.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cpOverDue.Size = New System.Drawing.Size(161, 20)
            Me.cpOverDue.StyleController = Me.layoutControl1
            Me.cpOverDue.TabIndex = 12
            '
            'cpActive
            '
            Me.cpActive.EditValue = System.Drawing.Color.Empty
            Me.cpActive.Location = New System.Drawing.Point(1019, 43)
            Me.cpActive.Name = "cpActive"
            Me.cpActive.Properties.AutomaticColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(137, Byte), Integer))
            Me.cpActive.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cpActive.Size = New System.Drawing.Size(161, 20)
            Me.cpActive.StyleController = Me.layoutControl1
            Me.cpActive.TabIndex = 6
            '
            'cpLowPriority
            '
            Me.cpLowPriority.EditValue = System.Drawing.Color.Empty
            Me.cpLowPriority.Location = New System.Drawing.Point(1019, 144)
            Me.cpLowPriority.Name = "cpLowPriority"
            Me.cpLowPriority.Properties.AutomaticColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.cpLowPriority.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cpLowPriority.Size = New System.Drawing.Size(161, 20)
            Me.cpLowPriority.StyleController = Me.layoutControl1
            Me.cpLowPriority.TabIndex = 5
            '
            'gridControl1
            '
            Me.gridControl1.Cursor = System.Windows.Forms.Cursors.Default
            Me.gridControl1.Location = New System.Drawing.Point(12, 12)
            Me.gridControl1.MainView = Me.layoutView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemMemoEdit1, Me.repositoryItemMemoEdit2})
            Me.gridControl1.Size = New System.Drawing.Size(852, 359)
            Me.gridControl1.TabIndex = 4
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.layoutView1})
            '
            'layoutView1
            '
            Me.layoutView1.Appearance.FieldCaption.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
            Me.layoutView1.Appearance.FieldCaption.Options.UseFont = True
            Me.layoutView1.Appearance.FieldCaption.Options.UseTextOptions = True
            Me.layoutView1.Appearance.FieldCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom
            Me.layoutView1.CardMinSize = New System.Drawing.Size(342, 167)
            Me.layoutView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() {Me.colTask, Me.colCategory, Me.colPercentComplete, Me.colDueDate, Me.gaugeColumn, Me.colPriority})
            GridFormatRule1.ApplyToRow = True
            GridFormatRule1.Column = Me.colTask
            GridFormatRule1.Name = "Format0"
            FormatConditionRuleValue1.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold)
            FormatConditionRuleValue1.Appearance.Options.UseFont = True
            FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.NotEqual
            FormatConditionRuleValue1.Expression = "Len([TaskName]) != 0"
            GridFormatRule1.Rule = FormatConditionRuleValue1
            Me.layoutView1.FormatRules.Add(GridFormatRule1)
            Me.layoutView1.GridControl = Me.gridControl1
            Me.layoutView1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_colPercentComplete, Me.layoutViewField_layoutViewColumn1_1})
            Me.layoutView1.Name = "layoutView1"
            Me.layoutView1.OptionsBehavior.AllowExpandCollapse = False
            Me.layoutView1.OptionsCustomization.ShowGroupCardCaptions = False
            Me.layoutView1.OptionsCustomization.ShowGroupLayout = False
            Me.layoutView1.OptionsCustomization.ShowGroupLayoutTreeView = False
            Me.layoutView1.OptionsItemText.AlignMode = DevExpress.XtraGrid.Views.Layout.FieldTextAlignMode.AlignGlobal
            Me.layoutView1.OptionsItemText.TextToControlDistance = 10
            Me.layoutView1.OptionsView.AllowHotTrackFields = False
            Me.layoutView1.OptionsView.CardsAlignment = DevExpress.XtraGrid.Views.Layout.CardsAlignment.Far
            Me.layoutView1.OptionsView.ShowHeaderPanel = False
            Me.layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiRow
            Me.layoutView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colCategory, DevExpress.Data.ColumnSortOrder.Ascending)})
            Me.layoutView1.TemplateCard = Me.layoutViewCard1
            '
            'colCategory
            '
            Me.colCategory.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.colCategory.AppearanceHeader.ForeColor = System.Drawing.Color.DarkGray
            Me.colCategory.AppearanceHeader.Options.UseFont = True
            Me.colCategory.AppearanceHeader.Options.UseForeColor = True
            Me.colCategory.AppearanceHeader.Options.UseTextOptions = True
            Me.colCategory.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.colCategory.Caption = "CATEGORY"
            Me.colCategory.FieldName = "CategoryName"
            Me.colCategory.LayoutViewField = Me.layoutViewField_colCategory
            Me.colCategory.Name = "colCategory"
            Me.colCategory.OptionsColumn.AllowEdit = False
            Me.colCategory.OptionsColumn.AllowFocus = False
            Me.colCategory.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
            Me.colCategory.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
            Me.colCategory.OptionsFilter.AllowAutoFilter = False
            Me.colCategory.OptionsFilter.AllowFilter = False
            '
            'layoutViewField_colCategory
            '
            Me.layoutViewField_colCategory.EditorPreferredWidth = 92
            Me.layoutViewField_colCategory.Location = New System.Drawing.Point(0, 104)
            Me.layoutViewField_colCategory.MaxSize = New System.Drawing.Size(0, 22)
            Me.layoutViewField_colCategory.MinSize = New System.Drawing.Size(107, 22)
            Me.layoutViewField_colCategory.Name = "layoutViewField_colCategory"
            Me.layoutViewField_colCategory.OptionsCustomization.AllowDrag = DevExpress.XtraLayout.ItemDragDropMode.Allow
            Me.layoutViewField_colCategory.OptionsCustomization.AllowDrop = DevExpress.XtraLayout.ItemDragDropMode.Allow
            Me.layoutViewField_colCategory.Padding = New DevExpress.XtraLayout.Utils.Padding(20, 2, 0, 0)
            Me.layoutViewField_colCategory.Size = New System.Drawing.Size(179, 22)
            Me.layoutViewField_colCategory.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutViewField_colCategory.Spacing = New DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1)
            Me.layoutViewField_colCategory.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
            Me.layoutViewField_colCategory.TextLocation = DevExpress.Utils.Locations.[Default]
            Me.layoutViewField_colCategory.TextSize = New System.Drawing.Size(58, 13)
            Me.layoutViewField_colCategory.TextToControlDistance = 5
            '
            'colPercentComplete
            '
            Me.colPercentComplete.Caption = "% Complete"
            Me.colPercentComplete.FieldName = "PercentComplete"
            Me.colPercentComplete.LayoutViewField = Me.layoutViewField_colPercentComplete
            Me.colPercentComplete.Name = "colPercentComplete"
            Me.colPercentComplete.OptionsColumn.AllowEdit = False
            Me.colPercentComplete.OptionsColumn.AllowFocus = False
            Me.colPercentComplete.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
            Me.colPercentComplete.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
            Me.colPercentComplete.OptionsFilter.AllowAutoFilter = False
            Me.colPercentComplete.OptionsFilter.AllowFilter = False
            '
            'layoutViewField_colPercentComplete
            '
            Me.layoutViewField_colPercentComplete.EditorPreferredWidth = 136
            Me.layoutViewField_colPercentComplete.Location = New System.Drawing.Point(0, 0)
            Me.layoutViewField_colPercentComplete.Name = "layoutViewField_colPercentComplete"
            Me.layoutViewField_colPercentComplete.OptionsCustomization.AllowDrag = DevExpress.XtraLayout.ItemDragDropMode.Allow
            Me.layoutViewField_colPercentComplete.OptionsCustomization.AllowDrop = DevExpress.XtraLayout.ItemDragDropMode.Allow
            Me.layoutViewField_colPercentComplete.Size = New System.Drawing.Size(363, 161)
            Me.layoutViewField_colPercentComplete.Spacing = New DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1)
            Me.layoutViewField_colPercentComplete.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutViewField_colPercentComplete.TextVisible = False
            '
            'colDueDate
            '
            Me.colDueDate.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.colDueDate.AppearanceHeader.ForeColor = System.Drawing.Color.DarkGray
            Me.colDueDate.AppearanceHeader.Options.UseFont = True
            Me.colDueDate.AppearanceHeader.Options.UseForeColor = True
            Me.colDueDate.AppearanceHeader.Options.UseTextOptions = True
            Me.colDueDate.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.colDueDate.Caption = "DUE DATE"
            Me.colDueDate.FieldName = "DueDate"
            Me.colDueDate.LayoutViewField = Me.layoutViewField_colDueDate
            Me.colDueDate.Name = "colDueDate"
            Me.colDueDate.OptionsColumn.AllowEdit = False
            Me.colDueDate.OptionsColumn.AllowFocus = False
            Me.colDueDate.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
            Me.colDueDate.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
            Me.colDueDate.OptionsFilter.AllowAutoFilter = False
            Me.colDueDate.OptionsFilter.AllowFilter = False
            '
            'layoutViewField_colDueDate
            '
            Me.layoutViewField_colDueDate.EditorPreferredWidth = 92
            Me.layoutViewField_colDueDate.Location = New System.Drawing.Point(0, 126)
            Me.layoutViewField_colDueDate.MaxSize = New System.Drawing.Size(0, 35)
            Me.layoutViewField_colDueDate.MinSize = New System.Drawing.Size(107, 35)
            Me.layoutViewField_colDueDate.Name = "layoutViewField_colDueDate"
            Me.layoutViewField_colDueDate.OptionsCustomization.AllowDrag = DevExpress.XtraLayout.ItemDragDropMode.Allow
            Me.layoutViewField_colDueDate.OptionsCustomization.AllowDrop = DevExpress.XtraLayout.ItemDragDropMode.Allow
            Me.layoutViewField_colDueDate.Padding = New DevExpress.XtraLayout.Utils.Padding(20, 2, 0, 13)
            Me.layoutViewField_colDueDate.Size = New System.Drawing.Size(179, 35)
            Me.layoutViewField_colDueDate.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutViewField_colDueDate.Spacing = New DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1)
            Me.layoutViewField_colDueDate.TextLocation = DevExpress.Utils.Locations.[Default]
            Me.layoutViewField_colDueDate.TextSize = New System.Drawing.Size(53, 13)
            '
            'gaugeColumn
            '
            Me.gaugeColumn.Caption = "layoutViewColumn1"
            Me.gaugeColumn.FieldName = "gaugeColumn"
            Me.gaugeColumn.LayoutViewField = Me.layoutViewField_layoutViewColumn1
            Me.gaugeColumn.Name = "gaugeColumn"
            Me.gaugeColumn.OptionsColumn.AllowEdit = False
            Me.gaugeColumn.OptionsColumn.AllowFocus = False
            Me.gaugeColumn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
            Me.gaugeColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
            Me.gaugeColumn.OptionsFilter.AllowAutoFilter = False
            Me.gaugeColumn.OptionsFilter.AllowFilter = False
            Me.gaugeColumn.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
            '
            'layoutViewField_layoutViewColumn1
            '
            Me.layoutViewField_layoutViewColumn1.EditorPreferredWidth = 153
            Me.layoutViewField_layoutViewColumn1.Location = New System.Drawing.Point(179, 8)
            Me.layoutViewField_layoutViewColumn1.MaxSize = New System.Drawing.Size(157, 153)
            Me.layoutViewField_layoutViewColumn1.MinSize = New System.Drawing.Size(157, 153)
            Me.layoutViewField_layoutViewColumn1.Name = "layoutViewField_layoutViewColumn1"
            Me.layoutViewField_layoutViewColumn1.OptionsCustomization.AllowDrag = DevExpress.XtraLayout.ItemDragDropMode.Allow
            Me.layoutViewField_layoutViewColumn1.OptionsCustomization.AllowDrop = DevExpress.XtraLayout.ItemDragDropMode.Allow
            Me.layoutViewField_layoutViewColumn1.Size = New System.Drawing.Size(157, 153)
            Me.layoutViewField_layoutViewColumn1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutViewField_layoutViewColumn1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutViewField_layoutViewColumn1.TextVisible = False
            '
            'colPriority
            '
            Me.colPriority.Caption = "Priority"
            Me.colPriority.FieldName = "Priority"
            Me.colPriority.LayoutViewField = Me.layoutViewField_layoutViewColumn1_1
            Me.colPriority.Name = "colPriority"
            '
            'layoutViewField_layoutViewColumn1_1
            '
            Me.layoutViewField_layoutViewColumn1_1.EditorPreferredWidth = 10
            Me.layoutViewField_layoutViewColumn1_1.Location = New System.Drawing.Point(0, 0)
            Me.layoutViewField_layoutViewColumn1_1.Name = "layoutViewField_layoutViewColumn1_1"
            Me.layoutViewField_layoutViewColumn1_1.Size = New System.Drawing.Size(363, 161)
            Me.layoutViewField_layoutViewColumn1_1.TextSize = New System.Drawing.Size(109, 20)
            '
            'layoutViewCard1
            '
            Me.layoutViewCard1.CustomizationFormText = "TemplateCard"
            Me.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
            Me.layoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_colCategory, Me.layoutViewField_colDueDate, Me.layoutViewField_layoutViewColumn1, Me.layoutViewField_colTask, Me.item1})
            Me.layoutViewCard1.Name = "layoutViewCard1"
            Me.layoutViewCard1.OptionsCustomization.AllowDrag = DevExpress.XtraLayout.ItemDragDropMode.Disable
            Me.layoutViewCard1.OptionsCustomization.AllowDrop = DevExpress.XtraLayout.ItemDragDropMode.Disable
            Me.layoutViewCard1.OptionsItemText.TextToControlDistance = 10
            Me.layoutViewCard1.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
            Me.layoutViewCard1.Text = "TemplateCard"
            Me.layoutViewCard1.TextVisible = False
            '
            'item1
            '
            Me.item1.AllowHotTrack = False
            Me.item1.CustomizationFormText = "item1"
            Me.item1.Location = New System.Drawing.Point(179, 0)
            Me.item1.MaxSize = New System.Drawing.Size(0, 8)
            Me.item1.MinSize = New System.Drawing.Size(104, 8)
            Me.item1.Name = "item1"
            Me.item1.Size = New System.Drawing.Size(157, 8)
            Me.item1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.item1.Text = "item1"
            Me.item1.TextSize = New System.Drawing.Size(0, 0)
            '
            'repositoryItemMemoEdit1
            '
            Me.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1"
            '
            'embeddedGaugeControl1
            '
            Me.gaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gaugeControl1.ColorScheme.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.gaugeControl1.ColorScheme.TargetElements = CType((DevExpress.XtraGauges.Core.Base.TargetElement.RangeBar Or DevExpress.XtraGauges.Core.Base.TargetElement.Label), DevExpress.XtraGauges.Core.Base.TargetElement)
            Me.gaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge1})
            Me.gaugeControl1.Location = New System.Drawing.Point(602, 375)
            Me.gaugeControl1.Name = "embeddedGaugeControl1"
            Me.gaugeControl1.Size = New System.Drawing.Size(262, 235)
            Me.gaugeControl1.TabIndex = 1
            '
            'circularGauge1
            '
            Me.circularGauge1.Bounds = New System.Drawing.Rectangle(608, 381, 250, 223)
            Me.circularGauge1.Images.AddRange(New DevExpress.XtraGauges.Win.Base.ImageIndicatorComponent() {Me.imageIndicatorComponent1})
            Me.circularGauge1.Name = "circularGauge1"
            Me.circularGauge1.RangeBars.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent() {Me.arcScaleRangeBarComponent1})
            Me.circularGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent1})
            '
            'imageIndicatorComponent1
            '
            Me.imageIndicatorComponent1.AllowImageSkinning = True
            Me.imageIndicatorComponent1.Image = CType(resources.GetObject("imageIndicatorComponent1.Image"), System.Drawing.Image)
            Me.imageIndicatorComponent1.ImageLayoutMode = DevExpress.XtraGauges.Core.Drawing.ImageLayoutMode.Stretch
            Me.imageIndicatorComponent1.Name = "circularGauge1_ImageIndicator1"
            Me.imageIndicatorComponent1.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(135.0!, 125.0!)
            Me.imageIndicatorComponent1.Size = New System.Drawing.SizeF(74.0!, 74.0!)
            Me.imageIndicatorComponent1.ZOrder = -1001
            '
            'arcScaleRangeBarComponent1
            '
            Me.arcScaleRangeBarComponent1.AppearanceRangeBar.BackgroundBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#CBCBCB")
            Me.arcScaleRangeBarComponent1.ArcScale = Me.arcScaleComponent1
            Me.arcScaleRangeBarComponent1.EndOffset = 1.0!
            Me.arcScaleRangeBarComponent1.Name = "circularGauge3_RangeBar2"
            Me.arcScaleRangeBarComponent1.RoundedCaps = True
            Me.arcScaleRangeBarComponent1.ShowBackground = True
            Me.arcScaleRangeBarComponent1.StartOffset = 84.0!
            Me.arcScaleRangeBarComponent1.ZOrder = -10
            '
            'arcScaleComponent1
            '
            Me.arcScaleComponent1.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 125.0!)
            Me.arcScaleComponent1.EndAngle = -45.0!
            ScaleLabel1.AppearanceText.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold)
            ScaleLabel1.FormatString = "{1}%"
            ScaleLabel1.Name = "Label0"
            ScaleLabel1.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(183.0!, 217.0!)
            ScaleLabel1.Size = New System.Drawing.SizeF(100.0!, 40.0!)
            ScaleLabel1.Text = "%"
            Me.arcScaleComponent1.Labels.AddRange(New DevExpress.XtraGauges.Core.Model.ILabel() {ScaleLabel1})
            Me.arcScaleComponent1.MajorTickCount = 0
            Me.arcScaleComponent1.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent1.MajorTickmark.ShapeOffset = -14.0!
            Me.arcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_1
            Me.arcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent1.MaxValue = 100.0!
            Me.arcScaleComponent1.MinorTickCount = 0
            Me.arcScaleComponent1.MinorTickmark.ShapeOffset = -7.0!
            Me.arcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_2
            Me.arcScaleComponent1.Name = "scale1"
            Me.arcScaleComponent1.StartAngle = -270.0!
            Me.arcScaleComponent1.Value = 1.0!
            '
            'layoutControlGroup1
            '
            Me.layoutControlGroup1.CustomizationFormText = "Root"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.emptySpaceItem2, Me.layoutControlGroup2, Me.layoutControlGroup3, Me.layoutControlGroup4, Me.emptySpaceItem4, Me.emptySpaceItem3})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(1204, 622)
            Me.layoutControlGroup1.Text = "Root"
            Me.layoutControlGroup1.TextVisible = False
            '
            'layoutControlItem2
            '
            Me.layoutControlItem2.Control = Me.gridControl1
            Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(856, 363)
            Me.layoutControlItem2.Text = "layoutControlItem2"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            '
            'emptySpaceItem2
            '
            Me.emptySpaceItem2.AllowHotTrack = False
            Me.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2"
            Me.emptySpaceItem2.Location = New System.Drawing.Point(876, 216)
            Me.emptySpaceItem2.MinSize = New System.Drawing.Size(104, 24)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(308, 386)
            Me.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.emptySpaceItem2.Text = "emptySpaceItem2"
            Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            '
            'layoutControlGroup2
            '
            Me.layoutControlGroup2.CustomizationFormText = "layoutControlGroup2"
            Me.layoutControlGroup2.GroupBordersVisible = False
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem1, Me.layoutControlItem1})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 363)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(856, 239)
            Me.layoutControlGroup2.Text = "layoutControlGroup2"
            Me.layoutControlGroup2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            '
            'emptySpaceItem1
            '
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 0)
            Me.emptySpaceItem1.MinSize = New System.Drawing.Size(104, 24)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(471, 239)
            Me.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.emptySpaceItem1.Text = "emptySpaceItem1"
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            '
            'layoutControlItem1
            '
            Me.layoutControlItem1.Control = Me.gaugeControl1
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(471, 0)
            Me.layoutControlItem1.MinSize = New System.Drawing.Size(223, 24)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(385, 239)
            Me.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem1.Text = "EmbeddedGaugeControl"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(116, 13)
            '
            'layoutControlGroup3
            '
            Me.layoutControlGroup3.CustomizationFormText = "Task status"
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem4, Me.layoutControlItem5})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(876, 0)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.OptionsCustomization.AllowDrag = DevExpress.XtraLayout.ItemDragDropMode.Allow
            Me.layoutControlGroup3.OptionsCustomization.AllowDrop = DevExpress.XtraLayout.ItemDragDropMode.Allow
            Me.layoutControlGroup3.Size = New System.Drawing.Size(308, 91)
            Me.layoutControlGroup3.Text = "Task status"
            '
            'layoutControlItem4
            '
            Me.layoutControlItem4.Control = Me.cpActive
            Me.layoutControlItem4.CustomizationFormText = "layoutControlItem4"
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem4.MinSize = New System.Drawing.Size(173, 24)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(284, 24)
            Me.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem4.Text = "Active:"
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(116, 13)
            '
            'layoutControlItem5
            '
            Me.layoutControlItem5.Control = Me.cpOverDue
            Me.layoutControlItem5.CustomizationFormText = "Over due:"
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem5.MinSize = New System.Drawing.Size(173, 24)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(284, 24)
            Me.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem5.Text = "Over due:"
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(116, 13)
            '
            'layoutControlGroup4
            '
            Me.layoutControlGroup4.CustomizationFormText = "Task priority"
            Me.layoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem3, Me.layoutControlItem7, Me.layoutControlItem8})
            Me.layoutControlGroup4.Location = New System.Drawing.Point(876, 101)
            Me.layoutControlGroup4.Name = "layoutControlGroup4"
            Me.layoutControlGroup4.Size = New System.Drawing.Size(308, 115)
            Me.layoutControlGroup4.Text = "Task priority"
            '
            'layoutControlItem3
            '
            Me.layoutControlItem3.Control = Me.cpLowPriority
            Me.layoutControlItem3.CustomizationFormText = "Low priority:"
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem3.MinSize = New System.Drawing.Size(173, 24)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(284, 24)
            Me.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem3.Text = "Low priority:"
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(116, 13)
            '
            'layoutControlItem7
            '
            Me.layoutControlItem7.Control = Me.cpMediumPriority
            Me.layoutControlItem7.CustomizationFormText = "Medium priority:"
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem7.MinSize = New System.Drawing.Size(173, 24)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Size = New System.Drawing.Size(284, 24)
            Me.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem7.Text = "Medium priority:"
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(116, 13)
            '
            'layoutControlItem8
            '
            Me.layoutControlItem8.Control = Me.cpHighPriority
            Me.layoutControlItem8.CustomizationFormText = "High priotity:"
            Me.layoutControlItem8.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem8.MinSize = New System.Drawing.Size(173, 24)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.Size = New System.Drawing.Size(284, 24)
            Me.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem8.Text = "High priotity:"
            Me.layoutControlItem8.TextSize = New System.Drawing.Size(116, 13)
            '
            'emptySpaceItem4
            '
            Me.emptySpaceItem4.AllowHotTrack = False
            Me.emptySpaceItem4.CustomizationFormText = "emptySpaceItem4"
            Me.emptySpaceItem4.Location = New System.Drawing.Point(876, 91)
            Me.emptySpaceItem4.MinSize = New System.Drawing.Size(104, 10)
            Me.emptySpaceItem4.Name = "emptySpaceItem4"
            Me.emptySpaceItem4.Size = New System.Drawing.Size(308, 10)
            Me.emptySpaceItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.emptySpaceItem4.Text = "emptySpaceItem4"
            Me.emptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
            '
            'emptySpaceItem3
            '
            Me.emptySpaceItem3.AllowHotTrack = False
            Me.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3"
            Me.emptySpaceItem3.Location = New System.Drawing.Point(856, 0)
            Me.emptySpaceItem3.MinSize = New System.Drawing.Size(20, 24)
            Me.emptySpaceItem3.Name = "emptySpaceItem3"
            Me.emptySpaceItem3.Size = New System.Drawing.Size(20, 602)
            Me.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.emptySpaceItem3.Text = "emptySpaceItem3"
            Me.emptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
            '
            'GaugeEditor
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "GaugeEditor"
            Me.Size = New System.Drawing.Size(1204, 622)
            CType(Me.repositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutViewField_colTask, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType(Me.cpHighPriority.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cpMediumPriority.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cpOverDue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cpActive.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cpLowPriority.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutViewField_colCategory, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutViewField_colPercentComplete, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutViewField_colDueDate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutViewField_layoutViewColumn1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutViewField_layoutViewColumn1_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.item1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.imageIndicatorComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleRangeBarComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub


#End Region

        Private layoutControl1 As XtraLayout.LayoutControl
        Private gaugeControl1 As XtraGauges.Win.GaugeControl
        Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
        Private gridControl1 As GridControl
        Private WithEvents layoutView1 As Views.Layout.LayoutView
        Private colTask As Columns.LayoutViewColumn
        Private colCategory As Columns.LayoutViewColumn
        Private colPercentComplete As Columns.LayoutViewColumn
        Private colDueDate As Columns.LayoutViewColumn
        Private repositoryItemMemoEdit1 As XtraEditors.Repository.RepositoryItemMemoEdit
        Private repositoryItemMemoEdit2 As XtraEditors.Repository.RepositoryItemMemoEdit
        Private gaugeColumn As Columns.LayoutViewColumn
        Private colPriority As Columns.LayoutViewColumn
        Private circularGauge1 As XtraGauges.Win.Gauges.Circular.CircularGauge
        Private imageIndicatorComponent1 As XtraGauges.Win.Base.ImageIndicatorComponent
        Private arcScaleRangeBarComponent1 As XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent
        Private arcScaleComponent1 As XtraGauges.Win.Gauges.Circular.ArcScaleComponent
        Private cpActive As XtraEditors.ColorPickEdit
        Private cpLowPriority As XtraEditors.ColorPickEdit
        Private layoutControlItem2 As XtraLayout.LayoutControlItem
        Private layoutControlItem1 As XtraLayout.LayoutControlItem
        Private emptySpaceItem1 As XtraLayout.EmptySpaceItem
        Private layoutControlItem4 As XtraLayout.LayoutControlItem
        Private layoutControlItem3 As XtraLayout.LayoutControlItem
        Private emptySpaceItem2 As XtraLayout.EmptySpaceItem
        Private layoutControlGroup2 As XtraLayout.LayoutControlGroup
        Private layoutControlGroup3 As XtraLayout.LayoutControlGroup
        Private layoutControlGroup4 As XtraLayout.LayoutControlGroup
        Private emptySpaceItem4 As XtraLayout.EmptySpaceItem
        Private cpHighPriority As XtraEditors.ColorPickEdit
        Private cpMediumPriority As XtraEditors.ColorPickEdit
        Private cpOverDue As XtraEditors.ColorPickEdit
        Private layoutControlItem5 As XtraLayout.LayoutControlItem
        Private layoutControlItem7 As XtraLayout.LayoutControlItem
        Private layoutControlItem8 As XtraLayout.LayoutControlItem
        Private emptySpaceItem3 As XtraLayout.EmptySpaceItem
        Private layoutViewField_colTask As Views.Layout.LayoutViewField
        Private layoutViewField_colCategory As Views.Layout.LayoutViewField
        Private layoutViewField_colPercentComplete As Views.Layout.LayoutViewField
        Private layoutViewField_colDueDate As Views.Layout.LayoutViewField
        Private layoutViewField_layoutViewColumn1 As Views.Layout.LayoutViewField
        Private layoutViewField_layoutViewColumn1_1 As Views.Layout.LayoutViewField
        Private layoutViewCard1 As Views.Layout.LayoutViewCard
        Private item1 As XtraLayout.EmptySpaceItem


    End Class
End Namespace

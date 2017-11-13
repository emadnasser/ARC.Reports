Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class FilterPopup
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
			Dim pivotGridStyleFormatCondition1 As New DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition()
			Dim pivotGridGroup1 As New DevExpress.XtraPivotGrid.PivotGridGroup()
			Dim pivotGridGroup2 As New DevExpress.XtraPivotGrid.PivotGridGroup()
			Me.fieldGroupCategoryName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldGroupProductName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldGroupYear = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldGroupQuarter = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldGroupMonth = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.chkShowToolbar = New DevExpress.XtraEditors.CheckEdit()
			Me.chkAllowTree = New DevExpress.XtraEditors.CheckEdit()
			Me.chkAllowContextMenu = New DevExpress.XtraEditors.CheckEdit()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.tcFilter = New DevExpress.XtraTab.XtraTabControl()
			Me.tabPageFieldFilter = New DevExpress.XtraTab.XtraTabPage()
			Me.pivotFilter = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.fieldExtendedPrice = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldYear = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldCategoryName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldQuantity = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.tabPageGroupFilter = New DevExpress.XtraTab.XtraTabPage()
			Me.pivotGroupFilter = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.fieldGroupOrderAmount = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
			Me.chkInvertFilter = New DevExpress.XtraEditors.CheckEdit()
			Me.chkRadioMode = New DevExpress.XtraEditors.CheckEdit()
			Me.chkShowOnlyAvailableItems = New DevExpress.XtraEditors.CheckEdit()
			Me.chkMultiSelection = New DevExpress.XtraEditors.CheckEdit()
			Me.chkIncrementalSearch = New DevExpress.XtraEditors.CheckEdit()
			Me.chkShowNewValues = New DevExpress.XtraEditors.CheckEdit()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.tableLayoutPanel1.SuspendLayout()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.chkShowToolbar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkAllowTree.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkAllowContextMenu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tcFilter, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tcFilter.SuspendLayout()
			Me.tabPageFieldFilter.SuspendLayout()
			CType(Me.pivotFilter, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tabPageGroupFilter.SuspendLayout()
			CType(Me.pivotGroupFilter, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl2.SuspendLayout()
			CType(Me.chkInvertFilter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkRadioMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkShowOnlyAvailableItems.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkMultiSelection.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkIncrementalSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkShowNewValues.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' fieldGroupCategoryName
			' 
			Me.fieldGroupCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldGroupCategoryName.AreaIndex = 0
			Me.fieldGroupCategoryName.Caption = "Category Name"
			Me.fieldGroupCategoryName.FieldName = "CategoryName"
			Me.fieldGroupCategoryName.Name = "fieldGroupCategoryName"
			Me.fieldGroupCategoryName.Width = 150
			' 
			' fieldGroupProductName
			' 
			Me.fieldGroupProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldGroupProductName.AreaIndex = 1
			Me.fieldGroupProductName.Caption = "Product Name"
			Me.fieldGroupProductName.FieldName = "ProductName"
			Me.fieldGroupProductName.Name = "fieldGroupProductName"
			Me.fieldGroupProductName.Width = 170
			' 
			' fieldGroupYear
			' 
			Me.fieldGroupYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldGroupYear.AreaIndex = 0
			Me.fieldGroupYear.Caption = "Year"
			Me.fieldGroupYear.FieldName = "OrderDate"
			Me.fieldGroupYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
			Me.fieldGroupYear.Name = "fieldGroupYear"
			Me.fieldGroupYear.UnboundFieldName = "fieldGroupYear"
			' 
			' fieldGroupQuarter
			' 
			Me.fieldGroupQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldGroupQuarter.AreaIndex = 1
			Me.fieldGroupQuarter.Caption = "Quarter"
			Me.fieldGroupQuarter.FieldName = "OrderDate"
			Me.fieldGroupQuarter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter
			Me.fieldGroupQuarter.Name = "fieldGroupQuarter"
			Me.fieldGroupQuarter.UnboundFieldName = "fieldGroupQuarter"
			Me.fieldGroupQuarter.ValueFormat.FormatString = "Quarter {0}"
			Me.fieldGroupQuarter.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			' 
			' fieldGroupMonth
			' 
			Me.fieldGroupMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldGroupMonth.AreaIndex = 2
			Me.fieldGroupMonth.Caption = "Month"
			Me.fieldGroupMonth.FieldName = "OrderDate"
			Me.fieldGroupMonth.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth
			Me.fieldGroupMonth.Name = "fieldGroupMonth"
			Me.fieldGroupMonth.UnboundFieldName = "fieldGroupMonth"
			' 
			' tableLayoutPanel1
			' 
			Me.tableLayoutPanel1.ColumnCount = 1
			Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F))
			Me.tableLayoutPanel1.Controls.Add(Me.panelControl1, 0, 0)
			Me.tableLayoutPanel1.Controls.Add(Me.tcFilter, 0, 2)
			Me.tableLayoutPanel1.Controls.Add(Me.panelControl2, 0, 1)
			Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
			Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
			Me.tableLayoutPanel1.RowCount = 3
			Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F))
			Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F))
			Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
			Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F))
			Me.tableLayoutPanel1.Size = New System.Drawing.Size(705, 345)
			Me.tableLayoutPanel1.TabIndex = 3
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.chkShowToolbar)
			Me.panelControl1.Controls.Add(Me.chkAllowTree)
			Me.panelControl1.Controls.Add(Me.chkAllowContextMenu)
			Me.panelControl1.Controls.Add(Me.labelControl1)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Margin = New System.Windows.Forms.Padding(0, 0, 0, 8)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(705, 29)
			Me.panelControl1.TabIndex = 3
			' 
			' chkShowToolbar
			' 
			Me.chkShowToolbar.EditValue = True
			Me.chkShowToolbar.Location = New System.Drawing.Point(113, 5)
			Me.chkShowToolbar.Name = "chkShowToolbar"
			Me.chkShowToolbar.Properties.Caption = "Show Toolbar"
			Me.chkShowToolbar.Size = New System.Drawing.Size(91, 19)
			Me.chkShowToolbar.TabIndex = 7
'			Me.chkShowToolbar.CheckedChanged += New System.EventHandler(Me.chkShowToolbar_CheckedChanged);
			' 
			' chkAllowTree
			' 
			Me.chkAllowTree.EditValue = True
			Me.chkAllowTree.Location = New System.Drawing.Point(401, 5)
			Me.chkAllowTree.Name = "chkAllowTree"
			Me.chkAllowTree.Properties.Caption = "Allow Tree"
			Me.chkAllowTree.Size = New System.Drawing.Size(85, 19)
			Me.chkAllowTree.TabIndex = 2
'			Me.chkAllowTree.CheckedChanged += New System.EventHandler(Me.chkAllowTree_CheckedChanged);
			' 
			' chkAllowContextMenu
			' 
			Me.chkAllowContextMenu.EditValue = True
			Me.chkAllowContextMenu.Location = New System.Drawing.Point(272, 5)
			Me.chkAllowContextMenu.Name = "chkAllowContextMenu"
			Me.chkAllowContextMenu.Properties.Caption = "Allow Context Menu"
			Me.chkAllowContextMenu.Size = New System.Drawing.Size(123, 19)
			Me.chkAllowContextMenu.TabIndex = 0
'			Me.chkAllowContextMenu.CheckedChanged += New System.EventHandler(Me.allowContextMenu_CheckedChanged);
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(6, 8)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(101, 13)
			Me.labelControl1.TabIndex = 2
			Me.labelControl1.Text = "Filter Popup Options:"
			' 
			' tcFilter
			' 
			Me.tcFilter.Dock = System.Windows.Forms.DockStyle.Fill
			Me.tcFilter.Location = New System.Drawing.Point(3, 100)
			Me.tcFilter.Name = "tcFilter"
			Me.tcFilter.SelectedTabPage = Me.tabPageFieldFilter
			Me.tcFilter.Size = New System.Drawing.Size(699, 242)
			Me.tcFilter.TabIndex = 6
			Me.tcFilter.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.tabPageFieldFilter, Me.tabPageGroupFilter})
'			Me.tcFilter.SelectedPageChanged += New DevExpress.XtraTab.TabPageChangedEventHandler(Me.tcFilter_SelectedPageChanged);
			' 
			' tabPageFieldFilter
			' 
			Me.tabPageFieldFilter.Controls.Add(Me.pivotFilter)
			Me.tabPageFieldFilter.Name = "tabPageFieldFilter"
			Me.tabPageFieldFilter.Size = New System.Drawing.Size(693, 214)
			Me.tabPageFieldFilter.Text = "Field Filter"
			' 
			' pivotFilter
			' 
			Me.pivotFilter.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pivotFilter.Cursor = System.Windows.Forms.Cursors.Default
			Me.pivotFilter.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotFilter.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldExtendedPrice, Me.fieldProductName, Me.fieldYear, Me.fieldCategoryName, Me.fieldQuantity})
			pivotGridStyleFormatCondition1.Expression = "[Extended Price] > 0"
			pivotGridStyleFormatCondition1.FieldName = ""
			Me.pivotFilter.FormatConditions.AddRange(New DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition() { pivotGridStyleFormatCondition1})
			Me.pivotFilter.Location = New System.Drawing.Point(0, 0)
			Me.pivotFilter.Name = "pivotFilter"
			Me.pivotFilter.OptionsCustomization.AllowHideFields = DevExpress.XtraPivotGrid.AllowHideFieldsType.Never
			Me.pivotFilter.Size = New System.Drawing.Size(693, 214)
			Me.pivotFilter.TabIndex = 7
			' 
			' fieldExtendedPrice
			' 
			Me.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldExtendedPrice.AreaIndex = 0
			Me.fieldExtendedPrice.CellFormat.FormatString = "c"
			Me.fieldExtendedPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.fieldExtendedPrice.FieldName = "Extended Price"
			Me.fieldExtendedPrice.Name = "fieldExtendedPrice"
			Me.fieldExtendedPrice.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.False
			' 
			' fieldProductName
			' 
			Me.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldProductName.AreaIndex = 0
			Me.fieldProductName.Caption = "Product Name"
			Me.fieldProductName.FieldName = "ProductName"
			Me.fieldProductName.Name = "fieldProductName"
			Me.fieldProductName.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.False
			' 
			' fieldYear
			' 
			Me.fieldYear.AreaIndex = 0
			Me.fieldYear.Caption = "Year"
			Me.fieldYear.FieldName = "OrderDate"
			Me.fieldYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
			Me.fieldYear.Name = "fieldYear"
			Me.fieldYear.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.False
			Me.fieldYear.UnboundFieldName = "fieldYear"
			' 
			' fieldCategoryName
			' 
			Me.fieldCategoryName.AreaIndex = 1
			Me.fieldCategoryName.Caption = "Category Name"
			Me.fieldCategoryName.FieldName = "CategoryName"
			Me.fieldCategoryName.Name = "fieldCategoryName"
			Me.fieldCategoryName.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.False
			' 
			' fieldQuantity
			' 
			Me.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldQuantity.AreaIndex = 1
			Me.fieldQuantity.Caption = "Quantity"
			Me.fieldQuantity.FieldName = "Quantity"
			Me.fieldQuantity.Name = "fieldQuantity"
			Me.fieldQuantity.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.False
			' 
			' tabPageGroupFilter
			' 
			Me.tabPageGroupFilter.Controls.Add(Me.pivotGroupFilter)
			Me.tabPageGroupFilter.Name = "tabPageGroupFilter"
			Me.tabPageGroupFilter.Size = New System.Drawing.Size(693, 214)
			Me.tabPageGroupFilter.Text = "Group Filter"
			' 
			' pivotGroupFilter
			' 
			Me.pivotGroupFilter.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pivotGroupFilter.Cursor = System.Windows.Forms.Cursors.Default
			Me.pivotGroupFilter.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGroupFilter.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldGroupCategoryName, Me.fieldGroupProductName, Me.fieldGroupOrderAmount, Me.fieldGroupYear, Me.fieldGroupQuarter, Me.fieldGroupMonth})
			pivotGridGroup1.Fields.Add(Me.fieldGroupCategoryName)
			pivotGridGroup1.Fields.Add(Me.fieldGroupProductName)
			pivotGridGroup1.Hierarchy = Nothing
			pivotGridGroup1.ShowNewValues = True
			pivotGridGroup2.Fields.Add(Me.fieldGroupYear)
			pivotGridGroup2.Fields.Add(Me.fieldGroupQuarter)
			pivotGridGroup2.Fields.Add(Me.fieldGroupMonth)
			pivotGridGroup2.Hierarchy = Nothing
			pivotGridGroup2.ShowNewValues = True
			Me.pivotGroupFilter.Groups.AddRange(New DevExpress.XtraPivotGrid.PivotGridGroup() { pivotGridGroup1, pivotGridGroup2})
			Me.pivotGroupFilter.Location = New System.Drawing.Point(0, 0)
			Me.pivotGroupFilter.Name = "pivotGroupFilter"
			Me.pivotGroupFilter.OptionsView.ShowFilterHeaders = False
			Me.pivotGroupFilter.Size = New System.Drawing.Size(693, 214)
			Me.pivotGroupFilter.TabIndex = 14
			' 
			' fieldGroupOrderAmount
			' 
			Me.fieldGroupOrderAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldGroupOrderAmount.AreaIndex = 0
			Me.fieldGroupOrderAmount.Caption = "Order Amount"
			Me.fieldGroupOrderAmount.FieldName = "Extended Price"
			Me.fieldGroupOrderAmount.Name = "fieldGroupOrderAmount"
			' 
			' panelControl2
			' 
			Me.panelControl2.Controls.Add(Me.chkInvertFilter)
			Me.panelControl2.Controls.Add(Me.chkRadioMode)
			Me.panelControl2.Controls.Add(Me.chkShowOnlyAvailableItems)
			Me.panelControl2.Controls.Add(Me.chkMultiSelection)
			Me.panelControl2.Controls.Add(Me.chkIncrementalSearch)
			Me.panelControl2.Controls.Add(Me.chkShowNewValues)
			Me.panelControl2.Controls.Add(Me.labelControl2)
			Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panelControl2.Location = New System.Drawing.Point(0, 37)
			Me.panelControl2.Margin = New System.Windows.Forms.Padding(0, 0, 0, 8)
			Me.panelControl2.Name = "panelControl2"
			Me.panelControl2.Size = New System.Drawing.Size(705, 52)
			Me.panelControl2.TabIndex = 7
			' 
			' chkInvertFilter
			' 
			Me.chkInvertFilter.EditValue = True
			Me.chkInvertFilter.Location = New System.Drawing.Point(399, 28)
			Me.chkInvertFilter.Name = "chkInvertFilter"
			Me.chkInvertFilter.Properties.Caption = "Invert Filter"
			Me.chkInvertFilter.Size = New System.Drawing.Size(82, 19)
			Me.chkInvertFilter.TabIndex = 14
'			Me.chkInvertFilter.CheckedChanged += New System.EventHandler(Me.chkInvertFilter_CheckedChanged);
			' 
			' chkRadioMode
			' 
			Me.chkRadioMode.EditValue = True
			Me.chkRadioMode.Location = New System.Drawing.Point(399, 4)
			Me.chkRadioMode.Name = "chkRadioMode"
			Me.chkRadioMode.Properties.Caption = "Radio Mode"
			Me.chkRadioMode.Size = New System.Drawing.Size(83, 19)
			Me.chkRadioMode.TabIndex = 13
'			Me.chkRadioMode.CheckedChanged += New System.EventHandler(Me.chkRadioMode_CheckedChanged);
			' 
			' chkShowOnlyAvailableItems
			' 
			Me.chkShowOnlyAvailableItems.EditValue = True
			Me.chkShowOnlyAvailableItems.Location = New System.Drawing.Point(113, 4)
			Me.chkShowOnlyAvailableItems.Name = "chkShowOnlyAvailableItems"
			Me.chkShowOnlyAvailableItems.Properties.Caption = "Show Only Available Items"
			Me.chkShowOnlyAvailableItems.Size = New System.Drawing.Size(153, 19)
			Me.chkShowOnlyAvailableItems.TabIndex = 12
'			Me.chkShowOnlyAvailableItems.CheckedChanged += New System.EventHandler(Me.chkShowOnlyAvailableItems_CheckedChanged);
			' 
			' chkMultiSelection
			' 
			Me.chkMultiSelection.Location = New System.Drawing.Point(272, 28)
			Me.chkMultiSelection.Name = "chkMultiSelection"
			Me.chkMultiSelection.Properties.Caption = "Multi-Selection"
			Me.chkMultiSelection.Size = New System.Drawing.Size(91, 19)
			Me.chkMultiSelection.TabIndex = 10
'			Me.chkMultiSelection.CheckedChanged += New System.EventHandler(Me.chkMultiSelection_CheckedChanged);
			' 
			' chkIncrementalSearch
			' 
			Me.chkIncrementalSearch.Location = New System.Drawing.Point(272, 4)
			Me.chkIncrementalSearch.Name = "chkIncrementalSearch"
			Me.chkIncrementalSearch.Properties.Caption = "Incremental Search"
			Me.chkIncrementalSearch.Size = New System.Drawing.Size(121, 19)
			Me.chkIncrementalSearch.TabIndex = 11
'			Me.chkIncrementalSearch.CheckedChanged += New System.EventHandler(Me.chkIncrementalSearch_CheckedChanged);
			' 
			' chkShowNewValues
			' 
			Me.chkShowNewValues.Location = New System.Drawing.Point(113, 28)
			Me.chkShowNewValues.Name = "chkShowNewValues"
			Me.chkShowNewValues.Properties.Caption = "Show New Field Values"
			Me.chkShowNewValues.Size = New System.Drawing.Size(136, 19)
			Me.chkShowNewValues.TabIndex = 8
'			Me.chkShowNewValues.CheckedChanged += New System.EventHandler(Me.chkFilterTypeExcluded_CheckedChanged);
			' 
			' labelControl2
			' 
			Me.labelControl2.Location = New System.Drawing.Point(6, 7)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(80, 13)
			Me.labelControl2.TabIndex = 9
			Me.labelControl2.Text = "Toolbar Buttons:"
			' 
			' FilterPopup
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.tableLayoutPanel1)
			Me.Name = "FilterPopup"
			Me.Size = New System.Drawing.Size(705, 345)
'			Me.Load += New System.EventHandler(Me.FilterPopup_Load);
'			Me.VisibleChanged += New System.EventHandler(Me.FilterPopup_VisibleChanged);
			Me.tableLayoutPanel1.ResumeLayout(False)
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.panelControl1.PerformLayout()
			CType(Me.chkShowToolbar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkAllowTree.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkAllowContextMenu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tcFilter, System.ComponentModel.ISupportInitialize).EndInit()
			Me.tcFilter.ResumeLayout(False)
			Me.tabPageFieldFilter.ResumeLayout(False)
			CType(Me.pivotFilter, System.ComponentModel.ISupportInitialize).EndInit()
			Me.tabPageGroupFilter.ResumeLayout(False)
			CType(Me.pivotGroupFilter, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl2.ResumeLayout(False)
			Me.panelControl2.PerformLayout()
			CType(Me.chkInvertFilter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkRadioMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkShowOnlyAvailableItems.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkMultiSelection.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkIncrementalSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkShowNewValues.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private WithEvents chkAllowContextMenu As DevExpress.XtraEditors.CheckEdit
		Private WithEvents chkAllowTree As DevExpress.XtraEditors.CheckEdit
		Private WithEvents tcFilter As DevExpress.XtraTab.XtraTabControl
		Private tabPageFieldFilter As DevExpress.XtraTab.XtraTabPage
		Private tabPageGroupFilter As DevExpress.XtraTab.XtraTabPage
		Private pivotFilter As PivotGridControl
		Private fieldExtendedPrice As PivotGridField
		Private fieldProductName As PivotGridField
		Private pivotGroupFilter As PivotGridControl
		Private fieldGroupCategoryName As PivotGridField
		Private fieldGroupProductName As PivotGridField
		Private fieldGroupOrderAmount As PivotGridField
		Private fieldGroupYear As PivotGridField
		Private fieldGroupQuarter As PivotGridField
		Private fieldGroupMonth As PivotGridField
		Private fieldYear As PivotGridField
		Private fieldCategoryName As PivotGridField
		Private fieldQuantity As PivotGridField
		Private WithEvents chkShowToolbar As DevExpress.XtraEditors.CheckEdit
		Private panelControl2 As DevExpress.XtraEditors.PanelControl
		Private WithEvents chkShowOnlyAvailableItems As DevExpress.XtraEditors.CheckEdit
		Private WithEvents chkMultiSelection As DevExpress.XtraEditors.CheckEdit
		Private WithEvents chkIncrementalSearch As DevExpress.XtraEditors.CheckEdit
		Private WithEvents chkShowNewValues As DevExpress.XtraEditors.CheckEdit
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private WithEvents chkInvertFilter As DevExpress.XtraEditors.CheckEdit
		Private WithEvents chkRadioMode As DevExpress.XtraEditors.CheckEdit

	End Class
End Namespace

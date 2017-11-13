Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class SpreadsheetEventViewerModule
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(SpreadsheetEventViewerModule))
			Me.eventsCheckedListBox = New DevExpress.XtraEditors.CheckedListBoxControl()
			Me.spreadsheetControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.bar2 = New DevExpress.XtraBars.Bar()
			Me.clearButtonItem = New DevExpress.XtraBars.BarButtonItem()
			Me.expandButtonItem = New DevExpress.XtraBars.BarButtonItem()
			Me.collapseButtonItem = New DevExpress.XtraBars.BarButtonItem()
			Me.barStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
			Me.barStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
			Me.customDrawCellBarEdit = New DevExpress.XtraBars.BarEditItem()
			Me.repositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
			Me.appendExpandedBox = New DevExpress.XtraBars.BarCheckItem()
			Me.standaloneBarDockControl1 = New DevExpress.XtraBars.StandaloneBarDockControl()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.barEditItem1 = New DevExpress.XtraBars.BarEditItem()
			Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
			Me.loggerControl = New DevExpress.XtraTreeList.TreeList()
			Me.eventNameColumn = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.argsTypeColumn = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.valueColumn = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.checkAllEdit = New DevExpress.XtraEditors.CheckEdit()
			CType(Me.eventsCheckedListBox, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.loggerControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainerControl1.SuspendLayout()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.checkAllEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' eventsCheckedListBox
			' 
			Me.eventsCheckedListBox.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.eventsCheckedListBox.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.eventsCheckedListBox.CheckOnClick = True
			Me.eventsCheckedListBox.Location = New System.Drawing.Point(2, 22)
			Me.eventsCheckedListBox.Name = "eventsCheckedListBox"
			Me.eventsCheckedListBox.Size = New System.Drawing.Size(245, 267)
			Me.eventsCheckedListBox.SortOrder = System.Windows.Forms.SortOrder.Ascending
			Me.eventsCheckedListBox.TabIndex = 7
'			Me.eventsCheckedListBox.ItemCheck += New DevExpress.XtraEditors.Controls.ItemCheckEventHandler(Me.eventsCheckedListBox_ItemCheck);
			' 
			' spreadsheetControl1
			' 
			Me.spreadsheetControl1.AllowDrop = True
			Me.spreadsheetControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.spreadsheetControl1.Location = New System.Drawing.Point(3, 3)
			Me.spreadsheetControl1.MenuManager = Me.barManager1
			Me.spreadsheetControl1.Name = "spreadsheetControl1"
			Me.spreadsheetControl1.Size = New System.Drawing.Size(710, 291)
			Me.spreadsheetControl1.TabIndex = 6
			Me.spreadsheetControl1.Text = "spreadsheetControl1"
			' 
			' barManager1
			' 
			Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.bar2})
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.DockControls.Add(Me.standaloneBarDockControl1)
			Me.barManager1.Form = Me
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.clearButtonItem, Me.expandButtonItem, Me.collapseButtonItem, Me.appendExpandedBox, Me.barEditItem1, Me.barStaticItem1, Me.customDrawCellBarEdit, Me.barStaticItem2})
			Me.barManager1.MainMenu = Me.bar2
			Me.barManager1.MaxItemId = 13
			Me.barManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemTextEdit1, Me.repositoryItemTextEdit2})
			' 
			' bar2
			' 
			Me.bar2.BarName = "Custom 2"
			Me.bar2.CanDockStyle = (CType(((((DevExpress.XtraBars.BarCanDockStyle.Left Or DevExpress.XtraBars.BarCanDockStyle.Top) Or DevExpress.XtraBars.BarCanDockStyle.Right) Or DevExpress.XtraBars.BarCanDockStyle.Bottom) Or DevExpress.XtraBars.BarCanDockStyle.Standalone), DevExpress.XtraBars.BarCanDockStyle))
			Me.bar2.DockCol = 0
			Me.bar2.DockRow = 0
			Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
			Me.bar2.FloatLocation = New System.Drawing.Point(580, 457)
			Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.clearButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.expandButtonItem, True), New DevExpress.XtraBars.LinkPersistInfo(Me.collapseButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.barStaticItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barStaticItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.customDrawCellBarEdit), New DevExpress.XtraBars.LinkPersistInfo(Me.appendExpandedBox, True)})
			Me.bar2.OptionsBar.AllowQuickCustomization = False
			Me.bar2.OptionsBar.UseWholeRow = True
			Me.bar2.StandaloneBarDockControl = Me.standaloneBarDockControl1
			Me.bar2.Text = "Custom 2"
			' 
			' clearButtonItem
			' 
			Me.clearButtonItem.Caption = "Clear Log"
			Me.clearButtonItem.Glyph = (CType(resources.GetObject("clearButtonItem.Glyph"), System.Drawing.Image))
			Me.clearButtonItem.Id = 0
			Me.clearButtonItem.Name = "clearButtonItem"
'			Me.clearButtonItem.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.clearButtonItem_ItemClick);
			' 
			' expandButtonItem
			' 
			Me.expandButtonItem.Caption = "Expand All Log Records"
			Me.expandButtonItem.Glyph = (CType(resources.GetObject("expandButtonItem.Glyph"), System.Drawing.Image))
			Me.expandButtonItem.Id = 2
			Me.expandButtonItem.Name = "expandButtonItem"
'			Me.expandButtonItem.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.expandButtonItem_ItemClick);
			' 
			' collapseButtonItem
			' 
			Me.collapseButtonItem.Caption = "Collapse All Log Records"
			Me.collapseButtonItem.Glyph = (CType(resources.GetObject("collapseButtonItem.Glyph"), System.Drawing.Image))
			Me.collapseButtonItem.Id = 3
			Me.collapseButtonItem.Name = "collapseButtonItem"
'			Me.collapseButtonItem.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.collapseButtonItem_ItemClick);
			' 
			' barStaticItem2
			' 
			Me.barStaticItem2.Caption = " "
			Me.barStaticItem2.Id = 12
			Me.barStaticItem2.Name = "barStaticItem2"
			Me.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near
			' 
			' barStaticItem1
			' 
			Me.barStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
			Me.barStaticItem1.Caption = " Log CustomDraw For Cell:"
			Me.barStaticItem1.Id = 10
			Me.barStaticItem1.Name = "barStaticItem1"
			Me.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
			' 
			' customDrawCellBarEdit
			' 
			Me.customDrawCellBarEdit.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
			Me.customDrawCellBarEdit.Caption = "Enter cell reference to log CustomDrawCell and CustomDrawCellBackground events fo" & "r that cell."
			Me.customDrawCellBarEdit.Edit = Me.repositoryItemTextEdit2
			Me.customDrawCellBarEdit.Id = 11
			Me.customDrawCellBarEdit.Name = "customDrawCellBarEdit"
'			Me.customDrawCellBarEdit.EditValueChanged += New System.EventHandler(Me.customDrawCellBarEdit_EditValueChanged);
			' 
			' repositoryItemTextEdit2
			' 
			Me.repositoryItemTextEdit2.AllowNullInput = DevExpress.Utils.DefaultBoolean.True
			Me.repositoryItemTextEdit2.AutoHeight = False
			Me.repositoryItemTextEdit2.Mask.EditMask = "[A-Za-z]{1,3}[1-9]\d{0,2}"
			Me.repositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
			Me.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2"
			' 
			' appendExpandedBox
			' 
			Me.appendExpandedBox.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
			Me.appendExpandedBox.Caption = "Append Expanded"
			Me.appendExpandedBox.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
			Me.appendExpandedBox.Id = 6
			Me.appendExpandedBox.Name = "appendExpandedBox"
			' 
			' standaloneBarDockControl1
			' 
			Me.standaloneBarDockControl1.CausesValidation = False
			Me.standaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.standaloneBarDockControl1.Location = New System.Drawing.Point(0, 0)
			Me.standaloneBarDockControl1.Name = "standaloneBarDockControl1"
			Me.standaloneBarDockControl1.Size = New System.Drawing.Size(969, 23)
			Me.standaloneBarDockControl1.Text = "standaloneBarDockControl1"
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.CausesValidation = False
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlTop.Size = New System.Drawing.Size(973, 0)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.CausesValidation = False
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(0, 513)
			Me.barDockControlBottom.Size = New System.Drawing.Size(973, 0)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.CausesValidation = False
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlLeft.Size = New System.Drawing.Size(0, 513)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.CausesValidation = False
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(973, 0)
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 513)
			' 
			' barEditItem1
			' 
			Me.barEditItem1.Caption = "Log CustomDraw For Cell:"
			Me.barEditItem1.Edit = Me.repositoryItemTextEdit1
			Me.barEditItem1.Id = 8
			Me.barEditItem1.Name = "barEditItem1"
			Me.barEditItem1.Width = 54
			' 
			' repositoryItemTextEdit1
			' 
			Me.repositoryItemTextEdit1.AutoHeight = False
			Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
			' 
			' loggerControl
			' 
			Me.loggerControl.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.loggerControl.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.eventNameColumn, Me.argsTypeColumn, Me.valueColumn})
			Me.loggerControl.Location = New System.Drawing.Point(3, 26)
			Me.loggerControl.Name = "loggerControl"
			Me.loggerControl.OptionsBehavior.Editable = False
			Me.loggerControl.OptionsLayout.AddNewColumns = False
			Me.loggerControl.OptionsView.ShowHorzLines = False
			Me.loggerControl.OptionsView.ShowIndicator = False
			Me.loggerControl.OptionsView.ShowVertLines = False
			Me.loggerControl.Size = New System.Drawing.Size(963, 167)
			Me.loggerControl.TabIndex = 13
			' 
			' eventNameColumn
			' 
			Me.eventNameColumn.Caption = "Event Name"
			Me.eventNameColumn.FieldName = "Name"
			Me.eventNameColumn.Name = "eventNameColumn"
			Me.eventNameColumn.OptionsColumn.ReadOnly = True
			Me.eventNameColumn.Visible = True
			Me.eventNameColumn.VisibleIndex = 0
			Me.eventNameColumn.Width = 205
			' 
			' argsTypeColumn
			' 
			Me.argsTypeColumn.Caption = "Event Data Type"
			Me.argsTypeColumn.FieldName = "ArgsType"
			Me.argsTypeColumn.Name = "argsTypeColumn"
			Me.argsTypeColumn.OptionsColumn.ReadOnly = True
			Me.argsTypeColumn.Visible = True
			Me.argsTypeColumn.VisibleIndex = 1
			Me.argsTypeColumn.Width = 240
			' 
			' valueColumn
			' 
			Me.valueColumn.Caption = "Event Data Values"
			Me.valueColumn.FieldName = "Value"
			Me.valueColumn.Name = "valueColumn"
			Me.valueColumn.OptionsColumn.ReadOnly = True
			Me.valueColumn.Visible = True
			Me.valueColumn.VisibleIndex = 2
			Me.valueColumn.Width = 396
			' 
			' splitContainerControl1
			' 
			Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.splitContainerControl1.Horizontal = False
			Me.splitContainerControl1.Location = New System.Drawing.Point(0, 0)
			Me.splitContainerControl1.Name = "splitContainerControl1"
			Me.splitContainerControl1.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default
			Me.splitContainerControl1.Panel1.Controls.Add(Me.panelControl1)
			Me.splitContainerControl1.Panel1.Controls.Add(Me.spreadsheetControl1)
			Me.splitContainerControl1.Panel1.MinSize = 200
			Me.splitContainerControl1.Panel1.Text = "Panel1"
			Me.splitContainerControl1.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default
			Me.splitContainerControl1.Panel2.Controls.Add(Me.standaloneBarDockControl1)
			Me.splitContainerControl1.Panel2.Controls.Add(Me.loggerControl)
			Me.splitContainerControl1.Panel2.MinSize = 200
			Me.splitContainerControl1.Panel2.Text = "Panel2"
			Me.splitContainerControl1.Size = New System.Drawing.Size(973, 513)
			Me.splitContainerControl1.SplitterPosition = 308
			Me.splitContainerControl1.TabIndex = 13
			Me.splitContainerControl1.Text = "splitContainerControl1"
			' 
			' panelControl1
			' 
			Me.panelControl1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.panelControl1.Controls.Add(Me.checkAllEdit)
			Me.panelControl1.Controls.Add(Me.eventsCheckedListBox)
			Me.panelControl1.Location = New System.Drawing.Point(717, 3)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(249, 291)
			Me.panelControl1.TabIndex = 12
			' 
			' checkAllEdit
			' 
			Me.checkAllEdit.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.checkAllEdit.Location = New System.Drawing.Point(2, 2)
			Me.checkAllEdit.Name = "checkAllEdit"
			Me.checkAllEdit.Properties.Caption = "All"
			Me.checkAllEdit.Size = New System.Drawing.Size(239, 19)
			Me.checkAllEdit.TabIndex = 8
'			Me.checkAllEdit.CheckStateChanged += New System.EventHandler(Me.checkAllEdit_CheckStateChanged);
			' 
			' SpreadsheetEventViewerModule
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.splitContainerControl1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "SpreadsheetEventViewerModule"
			Me.Size = New System.Drawing.Size(973, 513)
			CType(Me.eventsCheckedListBox, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.loggerControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainerControl1.ResumeLayout(False)
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.checkAllEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents eventsCheckedListBox As XtraEditors.CheckedListBoxControl
		Private spreadsheetControl1 As SpreadsheetControl
		Private loggerControl As XtraTreeList.TreeList
		Private eventNameColumn As XtraTreeList.Columns.TreeListColumn
		Private argsTypeColumn As XtraTreeList.Columns.TreeListColumn
		Private valueColumn As XtraTreeList.Columns.TreeListColumn
		Private splitContainerControl1 As XtraEditors.SplitContainerControl
		Private panelControl1 As XtraEditors.PanelControl
		Private WithEvents checkAllEdit As XtraEditors.CheckEdit
		Private barManager1 As XtraBars.BarManager
		Private bar2 As XtraBars.Bar
		Private WithEvents clearButtonItem As XtraBars.BarButtonItem
		Private WithEvents expandButtonItem As XtraBars.BarButtonItem
		Private WithEvents collapseButtonItem As XtraBars.BarButtonItem
		Private standaloneBarDockControl1 As XtraBars.StandaloneBarDockControl
		Private barDockControlTop As XtraBars.BarDockControl
		Private barDockControlBottom As XtraBars.BarDockControl
		Private barDockControlLeft As XtraBars.BarDockControl
		Private barDockControlRight As XtraBars.BarDockControl
		Private appendExpandedBox As XtraBars.BarCheckItem
		Private barEditItem1 As XtraBars.BarEditItem
		Private repositoryItemTextEdit1 As XtraEditors.Repository.RepositoryItemTextEdit
		Private barStaticItem1 As XtraBars.BarStaticItem
		Private WithEvents customDrawCellBarEdit As XtraBars.BarEditItem
		Private repositoryItemTextEdit2 As XtraEditors.Repository.RepositoryItemTextEdit
		Private barStaticItem2 As XtraBars.BarStaticItem

	End Class
End Namespace

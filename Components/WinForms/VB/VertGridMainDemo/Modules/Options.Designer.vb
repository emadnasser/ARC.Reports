Namespace DevExpress.XtraVerticalGrid.Demos
	Partial Public Class Options
		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Options))
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.propertyGridControl1 = New DevExpress.XtraVerticalGrid.PropertyGridControl()
			Me.repositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
			Me.categoryAppearance = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
			Me.rowAppearance = New DevExpress.XtraVerticalGrid.Rows.PGridEditorRow()
			Me.rowBandsInterval = New DevExpress.XtraVerticalGrid.Rows.PGridEditorRow()
			Me.rowLookAndFeel = New DevExpress.XtraVerticalGrid.Rows.PGridEditorRow()
			Me.rowRecordsInterval = New DevExpress.XtraVerticalGrid.Rows.PGridEditorRow()
			Me.rowRecordWidth = New DevExpress.XtraVerticalGrid.Rows.PGridEditorRow()
			Me.rowRowHeaderWidth = New DevExpress.XtraVerticalGrid.Rows.PGridEditorRow()
			Me.rowShowButtonMode = New DevExpress.XtraVerticalGrid.Rows.PGridEditorRow()
			Me.rowTreeButtonStyle = New DevExpress.XtraVerticalGrid.Rows.PGridEditorRow()
			Me.categoryBehavior = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
			Me.rowEnabled = New DevExpress.XtraVerticalGrid.Rows.PGridEditorRow()
			Me.rowRowHeaderWidthChangeStep = New DevExpress.XtraVerticalGrid.Rows.PGridEditorRow()
			Me.rowTabIndex = New DevExpress.XtraVerticalGrid.Rows.PGridEditorRow()
			Me.rowTabStop = New DevExpress.XtraVerticalGrid.Rows.PGridEditorRow()
			Me.rowVisible = New DevExpress.XtraVerticalGrid.Rows.PGridEditorRow()
			Me.categoryLayout = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
			Me.rowAnchor = New DevExpress.XtraVerticalGrid.Rows.PGridEditorRow()
			Me.rowDock = New DevExpress.XtraVerticalGrid.Rows.PGridEditorRow()
			Me.rowLayoutStyle = New DevExpress.XtraVerticalGrid.Rows.PGridEditorRow()
			Me.rowLocation = New DevExpress.XtraVerticalGrid.Rows.PGridEditorRow()
			Me.rowMaximumSize = New DevExpress.XtraVerticalGrid.Rows.PGridEditorRow()
			Me.rowMinimumSize = New DevExpress.XtraVerticalGrid.Rows.PGridEditorRow()
			Me.rowScrollVisibility = New DevExpress.XtraVerticalGrid.Rows.PGridEditorRow()
			Me.rowSize = New DevExpress.XtraVerticalGrid.Rows.PGridEditorRow()
			Me.categoryOptions = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
			Me.rowOptionsBehavior = New DevExpress.XtraVerticalGrid.Rows.PGridEditorRow()
			Me.rowOptionsHint = New DevExpress.XtraVerticalGrid.Rows.PGridEditorRow()
			Me.rowOptionsMenu = New DevExpress.XtraVerticalGrid.Rows.PGridEditorRow()
			Me.rowOptionsView = New DevExpress.XtraVerticalGrid.Rows.PGridEditorRow()
			CType(Me.repositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pnlLeft, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlLeft.SuspendLayout()
			CType(Me.repositoryItemRadioGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			CType(Me.propertyGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' imageList2
			' 
			Me.imageList2.ImageStream = (CType(resources.GetObject("imageList2.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList2.Images.SetKeyName(0, "")
			Me.imageList2.Images.SetKeyName(1, "")
			Me.imageList2.Images.SetKeyName(2, "")
			' 
			' pnlLeft
			' 
			Me.pnlLeft.Controls.Add(Me.panel1)
			Me.pnlLeft.Size = New System.Drawing.Size(300, 488)
			Me.pnlLeft.Controls.SetChildIndex(Me.panel1, 0)
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.propertyGridControl1)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panel1.Location = New System.Drawing.Point(2, 2)
			Me.panel1.Name = "panel1"
			Me.panel1.Padding = New System.Windows.Forms.Padding(8, 4, 8, 8)
			Me.panel1.Size = New System.Drawing.Size(296, 396)
			Me.panel1.TabIndex = 3
			' 
			' propertyGridControl1
			' 
			Me.propertyGridControl1.DefaultEditors.AddRange(New DevExpress.XtraVerticalGrid.Rows.DefaultEditor() { New DevExpress.XtraVerticalGrid.Rows.DefaultEditor(GetType(Boolean), Me.repositoryItemCheckEdit1)})
			Me.propertyGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.propertyGridControl1.Location = New System.Drawing.Point(8, 4)
			Me.propertyGridControl1.Name = "propertyGridControl1"
			Me.propertyGridControl1.OptionsMenu.EnableContextMenu = True
			Me.propertyGridControl1.RecordWidth = 72
			Me.propertyGridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemCheckEdit1})
			Me.propertyGridControl1.RowHeaderWidth = 128
			Me.propertyGridControl1.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.categoryAppearance, Me.categoryBehavior, Me.categoryLayout, Me.categoryOptions})
			Me.propertyGridControl1.Size = New System.Drawing.Size(280, 384)
			Me.propertyGridControl1.TabIndex = 0
			' 
			' repositoryItemCheckEdit1
			' 
			Me.repositoryItemCheckEdit1.AutoHeight = False
			Me.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1"
			' 
			' categoryAppearance
			' 
			Me.categoryAppearance.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.rowAppearance, Me.rowBandsInterval, Me.rowLookAndFeel, Me.rowRecordsInterval, Me.rowRecordWidth, Me.rowRowHeaderWidth, Me.rowShowButtonMode, Me.rowTreeButtonStyle})
			Me.categoryAppearance.Expanded = False
			Me.categoryAppearance.Name = "categoryAppearance"
			Me.categoryAppearance.Properties.Caption = "Appearance"
			' 
			' rowAppearance
			' 
			Me.rowAppearance.Expanded = False
			Me.rowAppearance.IsChildRowsLoaded = False
			Me.rowAppearance.Name = "rowAppearance"
			Me.rowAppearance.Properties.Caption = "Appearance"
			Me.rowAppearance.Properties.FieldName = "Appearance"
			' 
			' rowBandsInterval
			' 
			Me.rowBandsInterval.Name = "rowBandsInterval"
			Me.rowBandsInterval.Properties.Caption = "BandsInterval"
			Me.rowBandsInterval.Properties.FieldName = "BandsInterval"
			' 
			' rowLookAndFeel
			' 
			Me.rowLookAndFeel.Expanded = False
			Me.rowLookAndFeel.IsChildRowsLoaded = False
			Me.rowLookAndFeel.Name = "rowLookAndFeel"
			Me.rowLookAndFeel.Properties.Caption = "LookAndFeel"
			Me.rowLookAndFeel.Properties.FieldName = "LookAndFeel"
			' 
			' rowRecordsInterval
			' 
			Me.rowRecordsInterval.Name = "rowRecordsInterval"
			Me.rowRecordsInterval.Properties.Caption = "RecordsInterval"
			Me.rowRecordsInterval.Properties.FieldName = "RecordsInterval"
			' 
			' rowRecordWidth
			' 
			Me.rowRecordWidth.Name = "rowRecordWidth"
			Me.rowRecordWidth.Properties.Caption = "RecordWidth"
			Me.rowRecordWidth.Properties.FieldName = "RecordWidth"
			' 
			' rowRowHeaderWidth
			' 
			Me.rowRowHeaderWidth.Name = "rowRowHeaderWidth"
			Me.rowRowHeaderWidth.Properties.Caption = "RowHeaderWidth"
			Me.rowRowHeaderWidth.Properties.FieldName = "RowHeaderWidth"
			' 
			' rowShowButtonMode
			' 
			Me.rowShowButtonMode.Name = "rowShowButtonMode"
			Me.rowShowButtonMode.Properties.Caption = "ShowButtonMode"
			Me.rowShowButtonMode.Properties.FieldName = "ShowButtonMode"
			' 
			' rowTreeButtonStyle
			' 
			Me.rowTreeButtonStyle.Name = "rowTreeButtonStyle"
			Me.rowTreeButtonStyle.Properties.Caption = "TreeButtonStyle"
			Me.rowTreeButtonStyle.Properties.FieldName = "TreeButtonStyle"
			' 
			' categoryBehavior
			' 
			Me.categoryBehavior.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.rowEnabled, Me.rowRowHeaderWidthChangeStep, Me.rowTabIndex, Me.rowTabStop, Me.rowVisible})
			Me.categoryBehavior.Expanded = False
			Me.categoryBehavior.Name = "categoryBehavior"
			Me.categoryBehavior.Properties.Caption = "Behavior"
			' 
			' rowEnabled
			' 
			Me.rowEnabled.Name = "rowEnabled"
			Me.rowEnabled.Properties.Caption = "Enabled"
			Me.rowEnabled.Properties.FieldName = "Enabled"
			' 
			' rowRowHeaderWidthChangeStep
			' 
			Me.rowRowHeaderWidthChangeStep.Name = "rowRowHeaderWidthChangeStep"
			Me.rowRowHeaderWidthChangeStep.Properties.Caption = "RowHeaderWidthChangeStep"
			Me.rowRowHeaderWidthChangeStep.Properties.FieldName = "RowHeaderWidthChangeStep"
			' 
			' rowTabIndex
			' 
			Me.rowTabIndex.Name = "rowTabIndex"
			Me.rowTabIndex.Properties.Caption = "TabIndex"
			Me.rowTabIndex.Properties.FieldName = "TabIndex"
			' 
			' rowTabStop
			' 
			Me.rowTabStop.Name = "rowTabStop"
			Me.rowTabStop.Properties.Caption = "TabStop"
			Me.rowTabStop.Properties.FieldName = "TabStop"
			' 
			' rowVisible
			' 
			Me.rowVisible.Name = "rowVisible"
			Me.rowVisible.Properties.Caption = "Visible"
			Me.rowVisible.Properties.FieldName = "Visible"
			' 
			' categoryLayout
			' 
			Me.categoryLayout.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.rowAnchor, Me.rowDock, Me.rowLayoutStyle, Me.rowLocation, Me.rowMaximumSize, Me.rowMinimumSize, Me.rowScrollVisibility, Me.rowSize})
			Me.categoryLayout.Expanded = False
			Me.categoryLayout.Name = "categoryLayout"
			Me.categoryLayout.Properties.Caption = "Layout"
			' 
			' rowAnchor
			' 
			Me.rowAnchor.Name = "rowAnchor"
			Me.rowAnchor.Properties.Caption = "Anchor"
			Me.rowAnchor.Properties.FieldName = "Anchor"
			' 
			' rowDock
			' 
			Me.rowDock.Name = "rowDock"
			Me.rowDock.Properties.Caption = "Dock"
			Me.rowDock.Properties.FieldName = "Dock"
			' 
			' rowLayoutStyle
			' 
			Me.rowLayoutStyle.Name = "rowLayoutStyle"
			Me.rowLayoutStyle.Properties.Caption = "LayoutStyle"
			Me.rowLayoutStyle.Properties.FieldName = "LayoutStyle"
			' 
			' rowLocation
			' 
			Me.rowLocation.Expanded = False
			Me.rowLocation.IsChildRowsLoaded = False
			Me.rowLocation.Name = "rowLocation"
			Me.rowLocation.Properties.Caption = "Location"
			Me.rowLocation.Properties.FieldName = "Location"
			' 
			' rowMaximumSize
			' 
			Me.rowMaximumSize.Expanded = False
			Me.rowMaximumSize.IsChildRowsLoaded = False
			Me.rowMaximumSize.Name = "rowMaximumSize"
			Me.rowMaximumSize.Properties.Caption = "MaximumSize"
			Me.rowMaximumSize.Properties.FieldName = "MaximumSize"
			' 
			' rowMinimumSize
			' 
			Me.rowMinimumSize.Expanded = False
			Me.rowMinimumSize.IsChildRowsLoaded = False
			Me.rowMinimumSize.Name = "rowMinimumSize"
			Me.rowMinimumSize.Properties.Caption = "MinimumSize"
			Me.rowMinimumSize.Properties.FieldName = "MinimumSize"
			' 
			' rowScrollVisibility
			' 
			Me.rowScrollVisibility.Name = "rowScrollVisibility"
			Me.rowScrollVisibility.Properties.Caption = "ScrollVisibility"
			Me.rowScrollVisibility.Properties.FieldName = "ScrollVisibility"
			' 
			' rowSize
			' 
			Me.rowSize.Expanded = False
			Me.rowSize.IsChildRowsLoaded = False
			Me.rowSize.Name = "rowSize"
			Me.rowSize.Properties.Caption = "Size"
			Me.rowSize.Properties.FieldName = "Size"
			' 
			' categoryOptions
			' 
			Me.categoryOptions.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.rowOptionsBehavior, Me.rowOptionsHint, Me.rowOptionsMenu, Me.rowOptionsView})
			Me.categoryOptions.Name = "categoryOptions"
			Me.categoryOptions.Properties.Caption = "Options"
			' 
			' rowOptionsBehavior
			' 
			Me.rowOptionsBehavior.Expanded = False
			Me.rowOptionsBehavior.IsChildRowsLoaded = False
			Me.rowOptionsBehavior.Name = "rowOptionsBehavior"
			Me.rowOptionsBehavior.Properties.Caption = "OptionsBehavior"
			Me.rowOptionsBehavior.Properties.FieldName = "OptionsBehavior"
			' 
			' rowOptionsHint
			' 
			Me.rowOptionsHint.Expanded = False
			Me.rowOptionsHint.IsChildRowsLoaded = False
			Me.rowOptionsHint.Name = "rowOptionsHint"
			Me.rowOptionsHint.Properties.Caption = "OptionsHint"
			Me.rowOptionsHint.Properties.FieldName = "OptionsHint"
			' 
			' rowOptionsMenu
			' 
			Me.rowOptionsMenu.Expanded = False
			Me.rowOptionsMenu.IsChildRowsLoaded = False
			Me.rowOptionsMenu.Name = "rowOptionsMenu"
			Me.rowOptionsMenu.Properties.Caption = "OptionsMenu"
			Me.rowOptionsMenu.Properties.FieldName = "OptionsMenu"
			' 
			' rowOptionsView
			' 
			Me.rowOptionsView.Expanded = False
			Me.rowOptionsView.IsChildRowsLoaded = False
			Me.rowOptionsView.Name = "rowOptionsView"
			Me.rowOptionsView.Properties.Caption = "OptionsView"
			Me.rowOptionsView.Properties.FieldName = "OptionsView"
			' 
			' Options
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Name = "Options"
			Me.Size = New System.Drawing.Size(812, 488)
			CType(Me.repositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pnlLeft, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlLeft.ResumeLayout(False)
			CType(Me.repositoryItemRadioGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			CType(Me.propertyGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private panel1 As System.Windows.Forms.Panel
		Private components As System.ComponentModel.IContainer = Nothing
		Private propertyGridControl1 As PropertyGridControl
		Private categoryAppearance As DevExpress.XtraVerticalGrid.Rows.CategoryRow
		Private rowAppearance As DevExpress.XtraVerticalGrid.Rows.PGridEditorRow
		Private rowBandsInterval As DevExpress.XtraVerticalGrid.Rows.PGridEditorRow
		Private rowLookAndFeel As DevExpress.XtraVerticalGrid.Rows.PGridEditorRow
		Private rowRecordsInterval As DevExpress.XtraVerticalGrid.Rows.PGridEditorRow
		Private rowRecordWidth As DevExpress.XtraVerticalGrid.Rows.PGridEditorRow
		Private rowRowHeaderWidth As DevExpress.XtraVerticalGrid.Rows.PGridEditorRow
		Private rowShowButtonMode As DevExpress.XtraVerticalGrid.Rows.PGridEditorRow
		Private rowTreeButtonStyle As DevExpress.XtraVerticalGrid.Rows.PGridEditorRow
		Private categoryBehavior As DevExpress.XtraVerticalGrid.Rows.CategoryRow
		Private rowEnabled As DevExpress.XtraVerticalGrid.Rows.PGridEditorRow
		Private rowRowHeaderWidthChangeStep As DevExpress.XtraVerticalGrid.Rows.PGridEditorRow
		Private rowTabIndex As DevExpress.XtraVerticalGrid.Rows.PGridEditorRow
		Private rowTabStop As DevExpress.XtraVerticalGrid.Rows.PGridEditorRow
		Private rowVisible As DevExpress.XtraVerticalGrid.Rows.PGridEditorRow
		Private categoryLayout As DevExpress.XtraVerticalGrid.Rows.CategoryRow
		Private rowAnchor As DevExpress.XtraVerticalGrid.Rows.PGridEditorRow
		Private rowDock As DevExpress.XtraVerticalGrid.Rows.PGridEditorRow
		Private rowLayoutStyle As DevExpress.XtraVerticalGrid.Rows.PGridEditorRow
		Private rowLocation As DevExpress.XtraVerticalGrid.Rows.PGridEditorRow
		Private rowMaximumSize As DevExpress.XtraVerticalGrid.Rows.PGridEditorRow
		Private rowMinimumSize As DevExpress.XtraVerticalGrid.Rows.PGridEditorRow
		Private rowScrollVisibility As DevExpress.XtraVerticalGrid.Rows.PGridEditorRow
		Private rowSize As DevExpress.XtraVerticalGrid.Rows.PGridEditorRow
		Private categoryOptions As DevExpress.XtraVerticalGrid.Rows.CategoryRow
		Private rowOptionsBehavior As DevExpress.XtraVerticalGrid.Rows.PGridEditorRow
		Private rowOptionsHint As DevExpress.XtraVerticalGrid.Rows.PGridEditorRow
		Private rowOptionsMenu As DevExpress.XtraVerticalGrid.Rows.PGridEditorRow
		Private rowOptionsView As DevExpress.XtraVerticalGrid.Rows.PGridEditorRow
		Private repositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit

	End Class
End Namespace

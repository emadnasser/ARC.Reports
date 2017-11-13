Namespace DevExpress.XtraTreeList.Demos
	Partial Public Class NodesFiltering
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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NodesFiltering))
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.btnFindPanelOptions = New DevExpress.XtraEditors.SimpleButton()
            Me.ceAllowFindPanel = New DevExpress.XtraEditors.CheckEdit()
            Me.labelControl = New DevExpress.XtraEditors.LabelControl()
            Me.ceAllowFilter = New DevExpress.XtraEditors.CheckEdit()
            Me.ceAutoFilterRow = New DevExpress.XtraEditors.CheckEdit()
            Me.ceColumnFilterList = New DevExpress.XtraEditors.CheckEdit()
            Me.ceFilterList = New DevExpress.XtraEditors.CheckEdit()
            Me.ceFilterEditor = New DevExpress.XtraEditors.CheckEdit()
            Me.cbFilterMode = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
            Me.treeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeListColumn2 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeListColumn3 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeListColumn4 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.repositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
            Me.treeListColumn5 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeListColumn6 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeListColumn7 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
            Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.ceAllowFindPanel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceAllowFilter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceAutoFilterRow.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceColumnFilterList.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceFilterList.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceFilterEditor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbFilterMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'panelControl1
            '
            Me.panelControl1.Controls.Add(Me.btnFindPanelOptions)
            Me.panelControl1.Controls.Add(Me.ceAllowFindPanel)
            Me.panelControl1.Controls.Add(Me.labelControl)
            Me.panelControl1.Controls.Add(Me.ceAllowFilter)
            Me.panelControl1.Controls.Add(Me.ceAutoFilterRow)
            Me.panelControl1.Controls.Add(Me.ceColumnFilterList)
            Me.panelControl1.Controls.Add(Me.ceFilterList)
            Me.panelControl1.Controls.Add(Me.ceFilterEditor)
            Me.panelControl1.Controls.Add(Me.cbFilterMode)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(798, 79)
            Me.panelControl1.TabIndex = 1
            '
            'btnFindPanelOptions
            '
            Me.btnFindPanelOptions.ImageIndex = 3
            Me.btnFindPanelOptions.Location = New System.Drawing.Point(624, 39)
            Me.btnFindPanelOptions.Name = "btnFindPanelOptions"
            Me.btnFindPanelOptions.Size = New System.Drawing.Size(142, 24)
            Me.btnFindPanelOptions.TabIndex = 8
            Me.btnFindPanelOptions.Text = "Find Panel Options..."
            '
            'ceAllowFindPanel
            '
            Me.ceAllowFindPanel.Location = New System.Drawing.Point(622, 17)
            Me.ceAllowFindPanel.Name = "ceAllowFindPanel"
            Me.ceAllowFindPanel.Properties.Caption = "Allow Find Panel"
            Me.ceAllowFindPanel.Size = New System.Drawing.Size(112, 19)
            Me.ceAllowFindPanel.TabIndex = 7
            '
            'labelControl
            '
            Me.labelControl.Location = New System.Drawing.Point(112, 23)
            Me.labelControl.Name = "labelControl"
            Me.labelControl.Size = New System.Drawing.Size(57, 13)
            Me.labelControl.TabIndex = 12
            Me.labelControl.Text = "Filter Mode:"
            '
            'ceAllowFilter
            '
            Me.ceAllowFilter.Location = New System.Drawing.Point(16, 20)
            Me.ceAllowFilter.Name = "ceAllowFilter"
            Me.ceAllowFilter.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.ceAllowFilter.Properties.Appearance.Options.UseFont = True
            Me.ceAllowFilter.Properties.Caption = "Allow Filter"
            Me.ceAllowFilter.Size = New System.Drawing.Size(88, 19)
            Me.ceAllowFilter.TabIndex = 0
            '
            'ceAutoFilterRow
            '
            Me.ceAutoFilterRow.Location = New System.Drawing.Point(312, 37)
            Me.ceAutoFilterRow.Name = "ceAutoFilterRow"
            Me.ceAutoFilterRow.Properties.Caption = "Show Auto Filter Row"
            Me.ceAutoFilterRow.Size = New System.Drawing.Size(133, 19)
            Me.ceAutoFilterRow.TabIndex = 4
            '
            'ceColumnFilterList
            '
            Me.ceColumnFilterList.Location = New System.Drawing.Point(455, 37)
            Me.ceColumnFilterList.Name = "ceColumnFilterList"
            Me.ceColumnFilterList.Properties.Caption = "Allow column MRU filter list"
            Me.ceColumnFilterList.Size = New System.Drawing.Size(155, 19)
            Me.ceColumnFilterList.TabIndex = 6
            '
            'ceFilterList
            '
            Me.ceFilterList.Location = New System.Drawing.Point(455, 17)
            Me.ceFilterList.Name = "ceFilterList"
            Me.ceFilterList.Properties.Caption = "Allow MRU filter list"
            Me.ceFilterList.Size = New System.Drawing.Size(147, 19)
            Me.ceFilterList.TabIndex = 5
            '
            'ceFilterEditor
            '
            Me.ceFilterEditor.Location = New System.Drawing.Point(312, 17)
            Me.ceFilterEditor.Name = "ceFilterEditor"
            Me.ceFilterEditor.Properties.Caption = "Allow Filter Editor"
            Me.ceFilterEditor.Size = New System.Drawing.Size(133, 19)
            Me.ceFilterEditor.TabIndex = 3
            '
            'cbFilterMode
            '
            Me.cbFilterMode.Location = New System.Drawing.Point(175, 20)
            Me.cbFilterMode.Name = "cbFilterMode"
            Me.cbFilterMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbFilterMode.Properties.DropDownRows = 25
            Me.cbFilterMode.Size = New System.Drawing.Size(124, 20)
            Me.cbFilterMode.TabIndex = 2
            '
            'treeList1
            '
            Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.treeListColumn1, Me.treeListColumn2, Me.treeListColumn3, Me.treeListColumn4, Me.treeListColumn5, Me.treeListColumn6, Me.treeListColumn7})
            Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeList1.Location = New System.Drawing.Point(0, 87)
            Me.treeList1.Name = "treeList1"
            Me.treeList1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.[True]
            Me.treeList1.OptionsBehavior.EnableFiltering = True
            Me.treeList1.OptionsBehavior.ExpandNodesOnFiltering = True
            Me.treeList1.OptionsFilter.FilterMode = DevExpress.XtraTreeList.FilterMode.Smart
            Me.treeList1.OptionsFind.AllowFindPanel = True
            Me.treeList1.OptionsView.ShowAutoFilterRow = True
            Me.treeList1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemDateEdit1})
            Me.treeList1.Size = New System.Drawing.Size(798, 369)
            Me.treeList1.StateImageList = Me.imageCollection1
            Me.treeList1.TabIndex = 10
            '
            'treeListColumn1
            '
            Me.treeListColumn1.Caption = "Job Title"
            Me.treeListColumn1.FieldName = "JobTitle"
            Me.treeListColumn1.MinWidth = 33
            Me.treeListColumn1.Name = "treeListColumn1"
            Me.treeListColumn1.Visible = True
            Me.treeListColumn1.VisibleIndex = 0
            Me.treeListColumn1.Width = 105
            '
            'treeListColumn2
            '
            Me.treeListColumn2.Caption = "First Name"
            Me.treeListColumn2.FieldName = "FirstName"
            Me.treeListColumn2.Name = "treeListColumn2"
            Me.treeListColumn2.Visible = True
            Me.treeListColumn2.VisibleIndex = 1
            Me.treeListColumn2.Width = 106
            '
            'treeListColumn3
            '
            Me.treeListColumn3.Caption = "Last Name"
            Me.treeListColumn3.FieldName = "LastName"
            Me.treeListColumn3.Name = "treeListColumn3"
            Me.treeListColumn3.Visible = True
            Me.treeListColumn3.VisibleIndex = 2
            Me.treeListColumn3.Width = 106
            '
            'treeListColumn4
            '
            Me.treeListColumn4.Caption = "Birth Date"
            Me.treeListColumn4.ColumnEdit = Me.repositoryItemDateEdit1
            Me.treeListColumn4.FieldName = "BirthDate"
            Me.treeListColumn4.Name = "treeListColumn4"
            Me.treeListColumn4.Visible = True
            Me.treeListColumn4.VisibleIndex = 3
            Me.treeListColumn4.Width = 105
            '
            'repositoryItemDateEdit1
            '
            Me.repositoryItemDateEdit1.AutoHeight = False
            Me.repositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1"
            '
            'treeListColumn5
            '
            Me.treeListColumn5.Caption = "Origin State"
            Me.treeListColumn5.FieldName = "StateProvinceName"
            Me.treeListColumn5.Name = "treeListColumn5"
            Me.treeListColumn5.Visible = True
            Me.treeListColumn5.VisibleIndex = 5
            '
            'treeListColumn6
            '
            Me.treeListColumn6.Caption = "Origin City"
            Me.treeListColumn6.FieldName = "City"
            Me.treeListColumn6.Name = "treeListColumn6"
            Me.treeListColumn6.Visible = True
            Me.treeListColumn6.VisibleIndex = 4
            '
            'treeListColumn7
            '
            Me.treeListColumn7.Caption = "Phone"
            Me.treeListColumn7.FieldName = "Phone"
            Me.treeListColumn7.Name = "treeListColumn7"
            Me.treeListColumn7.Visible = True
            Me.treeListColumn7.VisibleIndex = 6
            Me.treeListColumn7.Width = 105
            '
            'imageCollection1
            '
            Me.imageCollection1.ImageStream = CType(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
            Me.imageCollection1.Images.SetKeyName(0, "Administration.png")
            Me.imageCollection1.Images.SetKeyName(1, "Inventory.png")
            Me.imageCollection1.Images.SetKeyName(2, "Manufacturing.png")
            Me.imageCollection1.Images.SetKeyName(3, "Quality.png")
            Me.imageCollection1.Images.SetKeyName(4, "Research.png")
            Me.imageCollection1.Images.SetKeyName(5, "Sales.png")
            '
            'panelControl2
            '
            Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl2.Location = New System.Drawing.Point(0, 79)
            Me.panelControl2.Name = "panelControl2"
            Me.panelControl2.Size = New System.Drawing.Size(798, 8)
            Me.panelControl2.TabIndex = 3
            '
            'NodesFiltering
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.treeList1)
            Me.Controls.Add(Me.panelControl2)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "NodesFiltering"
            Me.Size = New System.Drawing.Size(798, 456)
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.panelControl1.PerformLayout()
            CType(Me.ceAllowFindPanel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceAllowFilter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceAutoFilterRow.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceColumnFilterList.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceFilterList.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceFilterEditor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbFilterMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private WithEvents treeList1 As DevExpress.XtraTreeList.TreeList
		Private components As System.ComponentModel.IContainer = Nothing
		Private panelControl2 As DevExpress.XtraEditors.PanelControl
		Private WithEvents ceAutoFilterRow As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceColumnFilterList As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceFilterList As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceFilterEditor As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceAllowFilter As DevExpress.XtraEditors.CheckEdit
		Private treeListColumn2 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn3 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn4 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn7 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private repositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
		Private imageCollection1 As DevExpress.Utils.ImageCollection
		Private treeListColumn6 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn5 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private labelControl As DevExpress.XtraEditors.LabelControl
		Private WithEvents cbFilterMode As DevExpress.XtraEditors.ImageComboBoxEdit
		Private WithEvents ceAllowFindPanel As DevExpress.XtraEditors.CheckEdit
		Private WithEvents btnFindPanelOptions As DevExpress.XtraEditors.SimpleButton

	End Class
End Namespace

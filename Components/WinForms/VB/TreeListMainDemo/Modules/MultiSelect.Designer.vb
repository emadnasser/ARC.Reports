Namespace DevExpress.XtraTreeList.Demos
    Partial Public Class MultiSelect
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MultiSelect))
            Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
            Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
            Me.treeListColumn7 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeListColumn6 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeListColumn5 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.repositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
            Me.treeListColumn4 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeListColumn3 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeListColumn2 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
            Me.treeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.labelControl = New DevExpress.XtraEditors.LabelControl()
            Me.ceAllowMultiSelect = New DevExpress.XtraEditors.CheckEdit()
            Me.cbMultiSelectMode = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.btnShowSelectedValues = New DevExpress.XtraEditors.SimpleButton()
            Me.panel2 = New System.Windows.Forms.Panel()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceAllowMultiSelect.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbMultiSelectMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel2.SuspendLayout()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            Me.SuspendLayout()
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
            Me.panelControl2.Location = New System.Drawing.Point(0, 57)
            Me.panelControl2.Name = "panelControl2"
            Me.panelControl2.Size = New System.Drawing.Size(798, 8)
            Me.panelControl2.TabIndex = 12
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
            'treeListColumn6
            '
            Me.treeListColumn6.Caption = "Origin City"
            Me.treeListColumn6.FieldName = "City"
            Me.treeListColumn6.Name = "treeListColumn6"
            Me.treeListColumn6.Visible = True
            Me.treeListColumn6.VisibleIndex = 4
            '
            'treeListColumn5
            '
            Me.treeListColumn5.Caption = "Origin State"
            Me.treeListColumn5.FieldName = "StateProvinceName"
            Me.treeListColumn5.Name = "treeListColumn5"
            Me.treeListColumn5.Visible = True
            Me.treeListColumn5.VisibleIndex = 5
            '
            'repositoryItemDateEdit1
            '
            Me.repositoryItemDateEdit1.AutoHeight = False
            Me.repositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1"
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
            'treeListColumn3
            '
            Me.treeListColumn3.Caption = "Last Name"
            Me.treeListColumn3.FieldName = "LastName"
            Me.treeListColumn3.Name = "treeListColumn3"
            Me.treeListColumn3.Visible = True
            Me.treeListColumn3.VisibleIndex = 2
            Me.treeListColumn3.Width = 106
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
            'treeList1
            '
            Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.treeListColumn1, Me.treeListColumn2, Me.treeListColumn3, Me.treeListColumn4, Me.treeListColumn5, Me.treeListColumn6, Me.treeListColumn7})
            Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeList1.Location = New System.Drawing.Point(0, 65)
            Me.treeList1.Name = "treeList1"
            Me.treeList1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.[True]
            Me.treeList1.OptionsDragAndDrop.DragNodesMode = DevExpress.XtraTreeList.DragNodesMode.None
            Me.treeList1.OptionsBehavior.EnableFiltering = True
            Me.treeList1.OptionsBehavior.KeepSelectedOnClick = False
            Me.treeList1.OptionsSelection.MultiSelect = True
            Me.treeList1.OptionsSelection.MultiSelectMode = DevExpress.XtraTreeList.TreeListMultiSelectMode.CellSelect
            Me.treeList1.OptionsSelection.UseIndicatorForSelection = True
            Me.treeList1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemDateEdit1})
            Me.treeList1.Size = New System.Drawing.Size(798, 391)
            Me.treeList1.StateImageList = Me.imageCollection1
            Me.treeList1.TabIndex = 13
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
            'labelControl
            '
            Me.labelControl.Location = New System.Drawing.Point(128, 23)
            Me.labelControl.Name = "labelControl"
            Me.labelControl.Size = New System.Drawing.Size(87, 13)
            Me.labelControl.TabIndex = 12
            Me.labelControl.Text = "Multi Select Mode:"
            '
            'ceAllowMultiSelect
            '
            Me.ceAllowMultiSelect.Location = New System.Drawing.Point(16, 20)
            Me.ceAllowMultiSelect.Name = "ceAllowMultiSelect"
            Me.ceAllowMultiSelect.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.ceAllowMultiSelect.Properties.Appearance.Options.UseFont = True
            Me.ceAllowMultiSelect.Properties.Caption = "Multi Select"
            Me.ceAllowMultiSelect.Size = New System.Drawing.Size(88, 19)
            Me.ceAllowMultiSelect.TabIndex = 0
            '
            'cbMultiSelectMode
            '
            Me.cbMultiSelectMode.Location = New System.Drawing.Point(221, 20)
            Me.cbMultiSelectMode.Name = "cbMultiSelectMode"
            Me.cbMultiSelectMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbMultiSelectMode.Properties.DropDownRows = 25
            Me.cbMultiSelectMode.Size = New System.Drawing.Size(124, 20)
            Me.cbMultiSelectMode.TabIndex = 2
            '
            'btnShowSelectedValues
            '
            Me.btnShowSelectedValues.ImageIndex = 3
            Me.btnShowSelectedValues.Location = New System.Drawing.Point(13, 16)
            Me.btnShowSelectedValues.Name = "btnShowSelectedValues"
            Me.btnShowSelectedValues.Size = New System.Drawing.Size(142, 24)
            Me.btnShowSelectedValues.TabIndex = 8
            Me.btnShowSelectedValues.Text = "Show Selected Values"
            '
            'panel2
            '
            Me.panel2.BackColor = System.Drawing.Color.Transparent
            Me.panel2.Controls.Add(Me.btnShowSelectedValues)
            Me.panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.panel2.Location = New System.Drawing.Point(628, 2)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(168, 53)
            Me.panel2.TabIndex = 13
            '
            'panelControl1
            '
            Me.panelControl1.Controls.Add(Me.panel2)
            Me.panelControl1.Controls.Add(Me.labelControl)
            Me.panelControl1.Controls.Add(Me.ceAllowMultiSelect)
            Me.panelControl1.Controls.Add(Me.cbMultiSelectMode)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(798, 57)
            Me.panelControl1.TabIndex = 11
            '
            'MultiSelect
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.treeList1)
            Me.Controls.Add(Me.panelControl2)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "MultiSelect"
            Me.Size = New System.Drawing.Size(798, 456)
            CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceAllowMultiSelect.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbMultiSelectMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel2.ResumeLayout(False)
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.panelControl1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

#End Region
        Private components As System.ComponentModel.IContainer = Nothing
        Private imageCollection1 As DevExpress.Utils.ImageCollection
        Private WithEvents panelControl2 As DevExpress.XtraEditors.PanelControl
        Private WithEvents treeListColumn7 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Private WithEvents treeListColumn6 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Private WithEvents treeListColumn5 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Private WithEvents repositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Private WithEvents treeListColumn4 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Private WithEvents treeListColumn3 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Private WithEvents treeListColumn2 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Private WithEvents treeList1 As DevExpress.XtraTreeList.TreeList
        Private WithEvents treeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Private WithEvents labelControl As DevExpress.XtraEditors.LabelControl
        Private WithEvents ceAllowMultiSelect As DevExpress.XtraEditors.CheckEdit
        Private WithEvents cbMultiSelectMode As DevExpress.XtraEditors.ImageComboBoxEdit
        Private WithEvents btnShowSelectedValues As DevExpress.XtraEditors.SimpleButton
        Private WithEvents panel2 As System.Windows.Forms.Panel
        Private WithEvents panelControl1 As DevExpress.XtraEditors.PanelControl

    End Class
End Namespace

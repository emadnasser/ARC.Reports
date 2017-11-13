Namespace DevExpress.XtraTreeList.Demos
	Partial Public Class FixedColumns
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FixedColumns))
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.spinEdit1 = New DevExpress.XtraEditors.SpinEdit()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
            Me.treeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeListColumn2 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeListColumn3 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeListColumn4 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeListColumn5 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.repositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
            Me.treeListColumn6 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
            Me.ceAllowPixelScrolling = New DevExpress.XtraEditors.CheckEdit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceAllowPixelScrolling.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'panelControl1
            '
            Me.panelControl1.Controls.Add(Me.ceAllowPixelScrolling)
            Me.panelControl1.Controls.Add(Me.spinEdit1)
            Me.panelControl1.Controls.Add(Me.labelControl1)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(668, 42)
            Me.panelControl1.TabIndex = 0
            '
            'spinEdit1
            '
            Me.spinEdit1.EditValue = New Decimal(New Integer() {2, 0, 0, 0})
            Me.spinEdit1.Location = New System.Drawing.Point(115, 11)
            Me.spinEdit1.Name = "spinEdit1"
            Me.spinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.spinEdit1.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
            Me.spinEdit1.Properties.Mask.EditMask = "N00"
            Me.spinEdit1.Properties.MaxValue = New Decimal(New Integer() {12, 0, 0, 0})
            Me.spinEdit1.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinEdit1.Size = New System.Drawing.Size(72, 20)
            Me.spinEdit1.TabIndex = 1
            '
            'labelControl1
            '
            Me.labelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.labelControl1.Location = New System.Drawing.Point(14, 14)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(95, 13)
            Me.labelControl1.TabIndex = 0
            Me.labelControl1.Text = "Fixed Line Width:"
            '
            'treeList1
            '
            Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.treeListColumn1, Me.treeListColumn2, Me.treeListColumn3, Me.treeListColumn4, Me.treeListColumn5, Me.treeListColumn6})
            Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeList1.Location = New System.Drawing.Point(0, 50)
            Me.treeList1.Name = "treeList1"
            Me.treeList1.OptionsBehavior.AllowPixelScrolling = Utils.DefaultBoolean.True
            Me.treeList1.OptionsBehavior.Editable = False
            Me.treeList1.OptionsView.AutoWidth = False
            Me.treeList1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemMemoEdit1, Me.repositoryItemPictureEdit1})
            Me.treeList1.Size = New System.Drawing.Size(668, 382)
            Me.treeList1.TabIndex = 1
            '
            'treeListColumn1
            '
            Me.treeListColumn1.Caption = "Common Name"
            Me.treeListColumn1.FieldName = "Common Name"
            Me.treeListColumn1.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left
            Me.treeListColumn1.Name = "treeListColumn1"
            Me.treeListColumn1.Visible = True
            Me.treeListColumn1.VisibleIndex = 0
            Me.treeListColumn1.Width = 180
            '
            'treeListColumn2
            '
            Me.treeListColumn2.Caption = "Species Name"
            Me.treeListColumn2.FieldName = "Species Name"
            Me.treeListColumn2.Name = "treeListColumn2"
            Me.treeListColumn2.Visible = True
            Me.treeListColumn2.VisibleIndex = 1
            Me.treeListColumn2.Width = 160
            '
            'treeListColumn3
            '
            Me.treeListColumn3.Caption = "Category"
            Me.treeListColumn3.FieldName = "Category"
            Me.treeListColumn3.Name = "treeListColumn3"
            Me.treeListColumn3.Visible = True
            Me.treeListColumn3.VisibleIndex = 2
            Me.treeListColumn3.Width = 120
            '
            'treeListColumn4
            '
            Me.treeListColumn4.Caption = "Length (cm)"
            Me.treeListColumn4.FieldName = "Length(cm)"
            Me.treeListColumn4.Name = "treeListColumn4"
            Me.treeListColumn4.Visible = True
            Me.treeListColumn4.VisibleIndex = 3
            Me.treeListColumn4.Width = 110
            '
            'treeListColumn5
            '
            Me.treeListColumn5.Caption = "Notes"
            Me.treeListColumn5.ColumnEdit = Me.repositoryItemMemoEdit1
            Me.treeListColumn5.FieldName = "Notes"
            Me.treeListColumn5.Name = "treeListColumn5"
            Me.treeListColumn5.Visible = True
            Me.treeListColumn5.VisibleIndex = 4
            Me.treeListColumn5.Width = 380
            '
            'repositoryItemMemoEdit1
            '
            Me.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1"
            '
            'treeListColumn6
            '
            Me.treeListColumn6.Caption = "Picture"
            Me.treeListColumn6.ColumnEdit = Me.repositoryItemPictureEdit1
            Me.treeListColumn6.FieldName = "Picture"
            Me.treeListColumn6.Name = "treeListColumn6"
            Me.treeListColumn6.Visible = True
            Me.treeListColumn6.VisibleIndex = 5
            Me.treeListColumn6.Width = 240
            '
            'repositoryItemPictureEdit1
            '
            Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
            '
            'imageList1
            '
            Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Magenta
            Me.imageList1.Images.SetKeyName(0, "")
            Me.imageList1.Images.SetKeyName(1, "")
            Me.imageList1.Images.SetKeyName(2, "")
            '
            'panelControl2
            '
            Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl2.Location = New System.Drawing.Point(0, 42)
            Me.panelControl2.Name = "panelControl2"
            Me.panelControl2.Size = New System.Drawing.Size(668, 8)
            Me.panelControl2.TabIndex = 2
            '
            'ceAllowPixelScrolling
            '
            Me.ceAllowPixelScrolling.Location = New System.Drawing.Point(207, 11)
            Me.ceAllowPixelScrolling.Name = "ceAllowPixelScrolling"
            Me.ceAllowPixelScrolling.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.ceAllowPixelScrolling.Properties.Appearance.Options.UseFont = True
            Me.ceAllowPixelScrolling.Properties.Caption = "Allow Pixel Scrolling"
            Me.ceAllowPixelScrolling.Size = New System.Drawing.Size(139, 19)
            Me.ceAllowPixelScrolling.TabIndex = 3
            '
            'FixedColumns
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.treeList1)
            Me.Controls.Add(Me.panelControl2)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "FixedColumns"
            Me.Size = New System.Drawing.Size(668, 432)
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.panelControl1.PerformLayout()
            CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceAllowPixelScrolling.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private labelControl1 As DevExpress.XtraEditors.LabelControl
        Private WithEvents spinEdit1 As DevExpress.XtraEditors.SpinEdit
        Private WithEvents treeList1 As DevExpress.XtraTreeList.TreeList
        Private treeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Private treeListColumn2 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Private treeListColumn3 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Private treeListColumn4 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Private repositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Private treeListColumn5 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
        Private treeListColumn6 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Private imageList1 As System.Windows.Forms.ImageList
        Private components As System.ComponentModel.IContainer
        Private panelControl2 As DevExpress.XtraEditors.PanelControl
        Private WithEvents ceAllowPixelScrolling As DevExpress.XtraEditors.CheckEdit

	End Class
End Namespace

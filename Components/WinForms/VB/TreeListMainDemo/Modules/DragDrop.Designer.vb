Imports DevExpress.XtraEditors
Namespace DevExpress.XtraTreeList.Demos
	Partial Public Class TreeListDragDrop
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(TreeListDragDrop))
			Me.panel1 = New DevExpress.XtraEditors.PanelControl()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.imageListBoxControl1 = New DevExpress.XtraEditors.ImageListBoxControl()
			Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
			Me.label1 = New DevExpress.XtraEditors.LabelControl()
			Me.imageCollection3 = New DevExpress.Utils.ImageCollection(Me.components)
			Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
			Me.treeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.treeListColumn2 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.repositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
			Me.treeListColumn4 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.repositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
			Me.treeListColumn3 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.repositoryImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.imageCollection2 = New DevExpress.Utils.ImageCollection(Me.components)
			Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
			CType(Me.panel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.imageListBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imageCollection3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemDateEdit2.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imageCollection2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.panelControl1)
			Me.panel1.Controls.Add(Me.label1)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Padding = New System.Windows.Forms.Padding(8)
			Me.panel1.Size = New System.Drawing.Size(613, 48)
			Me.panel1.TabIndex = 0
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.imageListBoxControl1)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Left
			Me.panelControl1.Location = New System.Drawing.Point(10, 10)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(310, 28)
			Me.panelControl1.TabIndex = 2
			' 
			' imageListBoxControl1
			' 
			Me.imageListBoxControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.imageListBoxControl1.ColumnWidth = 100
			Me.imageListBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.imageListBoxControl1.ImageList = Me.imageCollection1
			Me.imageListBoxControl1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageListBoxItem() { New DevExpress.XtraEditors.Controls.ImageListBoxItem("Project", 0), New DevExpress.XtraEditors.Controls.ImageListBoxItem("Task", 2), New DevExpress.XtraEditors.Controls.ImageListBoxItem("Subtask", 1)})
			Me.imageListBoxControl1.Location = New System.Drawing.Point(2, 2)
			Me.imageListBoxControl1.MultiColumn = True
			Me.imageListBoxControl1.Name = "imageListBoxControl1"
			Me.imageListBoxControl1.Size = New System.Drawing.Size(306, 24)
			Me.imageListBoxControl1.TabIndex = 0
'			Me.imageListBoxControl1.GiveFeedback += New System.Windows.Forms.GiveFeedbackEventHandler(Me.imageListBoxControl1_GiveFeedback)
'			Me.imageListBoxControl1.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.imageListBoxControl1_MouseDown)
'			Me.imageListBoxControl1.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.imageListBoxControl1_MouseMove)
			' 
			' imageCollection1
			' 
			Me.imageCollection1.ImageStream = (CType(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.imageCollection1.Images.SetKeyName(0, "Object_Project.png")
			Me.imageCollection1.Images.SetKeyName(1, "Object_Stage.png")
			Me.imageCollection1.Images.SetKeyName(2, "Object_Task.png")
			' 
			' label1
			' 
			Me.label1.AllowDrop = True
			Me.label1.Appearance.ImageIndex = 0
			Me.label1.Appearance.ImageList = Me.imageCollection3
			Me.label1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.label1.Dock = System.Windows.Forms.DockStyle.Right
			Me.label1.Location = New System.Drawing.Point(572, 10)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(31, 28)
			Me.label1.TabIndex = 1
			Me.label1.Text = " "
'			Me.label1.DragDrop += New System.Windows.Forms.DragEventHandler(Me.label1_DragDrop)
'			Me.label1.DragEnter += New System.Windows.Forms.DragEventHandler(Me.label1_DragEnter)
'			Me.label1.DragLeave += New System.EventHandler(Me.label1_DragLeave)
			' 
			' imageCollection3
			' 
			Me.imageCollection3.ImageSize = New System.Drawing.Size(32, 32)
			Me.imageCollection3.ImageStream = (CType(resources.GetObject("imageCollection3.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.imageCollection3.Images.SetKeyName(0, "BinClosed_32x32.png")
			Me.imageCollection3.Images.SetKeyName(1, "BinOpened_32x32.png")
			' 
			' treeList1
			' 
			Me.treeList1.AllowDrop = True
			Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.treeListColumn1, Me.treeListColumn2, Me.treeListColumn4, Me.treeListColumn3})
			Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeList1.Location = New System.Drawing.Point(0, 56)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.OptionsBehavior.AutoChangeParent = False
			Me.treeList1.OptionsBehavior.AutoNodeHeight = False
            Me.treeList1.OptionsDragAndDrop.CanCloneNodesOnDrop = True
			Me.treeList1.OptionsBehavior.CloseEditorOnLostFocus = False
            Me.treeList1.OptionsDragAndDrop.DragNodesMode = DragNodesMode.Single
			Me.treeList1.OptionsBehavior.KeepSelectedOnClick = False
			Me.treeList1.OptionsBehavior.ShowEditorOnMouseUp = True
			Me.treeList1.OptionsBehavior.SmartMouseHover = False
			Me.treeList1.OptionsView.EnableAppearanceEvenRow = True
			Me.treeList1.OptionsView.ShowHorzLines = False
			Me.treeList1.OptionsView.ShowVertLines = False
			Me.treeList1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemDateEdit1, Me.repositoryImageComboBox1, Me.repositoryItemDateEdit2})
			Me.treeList1.Size = New System.Drawing.Size(613, 385)
			Me.treeList1.StateImageList = Me.imageCollection1
			Me.treeList1.TabIndex = 1
'			Me.treeList1.DragDrop += New System.Windows.Forms.DragEventHandler(Me.treeList1_DragDrop)
'			Me.treeList1.DragOver += New System.Windows.Forms.DragEventHandler(Me.treeList1_DragOver)
'			Me.treeList1.DragLeave += New System.EventHandler(Me.treeList1_DragLeave)
'			Me.treeList1.GiveFeedback += New System.Windows.Forms.GiveFeedbackEventHandler(Me.treeList1_GiveFeedback)
			' 
			' treeListColumn1
			' 
			Me.treeListColumn1.Caption = "Name"
			Me.treeListColumn1.FieldName = "Name"
			Me.treeListColumn1.MinWidth = 33
			Me.treeListColumn1.Name = "treeListColumn1"
			Me.treeListColumn1.Visible = True
			Me.treeListColumn1.VisibleIndex = 0
			' 
			' treeListColumn2
			' 
			Me.treeListColumn2.Caption = "Start Date"
			Me.treeListColumn2.ColumnEdit = Me.repositoryItemDateEdit1
			Me.treeListColumn2.FieldName = "StartDate"
			Me.treeListColumn2.Format.FormatString = "d"
			Me.treeListColumn2.Format.FormatType = DevExpress.Utils.FormatType.DateTime
			Me.treeListColumn2.Name = "treeListColumn2"
			Me.treeListColumn2.Visible = True
			Me.treeListColumn2.VisibleIndex = 1
			' 
			' repositoryItemDateEdit1
			' 
			Me.repositoryItemDateEdit1.AllowFocused = False
			Me.repositoryItemDateEdit1.AutoHeight = False
			Me.repositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1"
			Me.repositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			' 
			' treeListColumn4
			' 
			Me.treeListColumn4.Caption = "End Date"
			Me.treeListColumn4.ColumnEdit = Me.repositoryItemDateEdit2
			Me.treeListColumn4.FieldName = "End Date"
			Me.treeListColumn4.Name = "treeListColumn4"
			Me.treeListColumn4.Visible = True
			Me.treeListColumn4.VisibleIndex = 2
			' 
			' repositoryItemDateEdit2
			' 
			Me.repositoryItemDateEdit2.AutoHeight = False
			Me.repositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2"
			Me.repositoryItemDateEdit2.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			' 
			' treeListColumn3
			' 
			Me.treeListColumn3.Caption = "Priority"
			Me.treeListColumn3.ColumnEdit = Me.repositoryImageComboBox1
			Me.treeListColumn3.FieldName = "Priotiry"
			Me.treeListColumn3.Name = "treeListColumn3"
			Me.treeListColumn3.Visible = True
			Me.treeListColumn3.VisibleIndex = 3
			' 
			' repositoryImageComboBox1
			' 
			Me.repositoryImageComboBox1.AllowFocused = False
			Me.repositoryImageComboBox1.AutoHeight = False
			Me.repositoryImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Normal", 0, 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("High", 1, 2), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Low", 2, 1)})
			Me.repositoryImageComboBox1.Name = "repositoryImageComboBox1"
			Me.repositoryImageComboBox1.SmallImages = Me.imageCollection2
			' 
			' imageCollection2
			' 
			Me.imageCollection2.ImageStream = (CType(resources.GetObject("imageCollection2.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.imageCollection2.Images.SetKeyName(0, "Normal1.png")
			Me.imageCollection2.Images.SetKeyName(1, "Low1.png")
			Me.imageCollection2.Images.SetKeyName(2, "High1.png")
			' 
			' panelControl2
			' 
			Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl2.Location = New System.Drawing.Point(0, 48)
			Me.panelControl2.Name = "panelControl2"
			Me.panelControl2.Size = New System.Drawing.Size(613, 8)
			Me.panelControl2.TabIndex = 3
			' 
			' TreeListDragDrop
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.treeList1)
			Me.Controls.Add(Me.panelControl2)
			Me.Controls.Add(Me.panel1)
			Me.Name = "TreeListDragDrop"
			Me.Size = New System.Drawing.Size(613, 441)
			CType(Me.panel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.imageListBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imageCollection3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemDateEdit2.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imageCollection2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private panel1 As PanelControl
		Private WithEvents treeList1 As DevExpress.XtraTreeList.TreeList
		Private WithEvents imageListBoxControl1 As DevExpress.XtraEditors.ImageListBoxControl
		Private imageCollection1 As DevExpress.Utils.ImageCollection
		Private treeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn2 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn3 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private repositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
		Private repositoryImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private imageCollection2 As DevExpress.Utils.ImageCollection
		Private WithEvents label1 As DevExpress.XtraEditors.LabelControl
		Private imageCollection3 As DevExpress.Utils.ImageCollection
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private components As System.ComponentModel.IContainer
		Private panelControl2 As DevExpress.XtraEditors.PanelControl
		Private treeListColumn4 As Columns.TreeListColumn
		Private repositoryItemDateEdit2 As XtraEditors.Repository.RepositoryItemDateEdit
	End Class
End Namespace

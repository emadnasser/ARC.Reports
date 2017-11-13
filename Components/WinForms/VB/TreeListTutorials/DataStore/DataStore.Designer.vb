Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraTreeList.Demos.Tutorials
	Public Partial Class DataStore
		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If Not components Is Nothing Then
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
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DataStore))
			Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
			Me.treeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.treeListColumn2 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.repositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
			Me.treeListColumn3 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.repositoryImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.imageList2 = New System.Windows.Forms.ImageList(Me.components)
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' treeList1
			' 
			Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.treeListColumn1, Me.treeListColumn2, Me.treeListColumn3})
			Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeList1.Location = New System.Drawing.Point(4, 4)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.BeginUnboundLoad()
			Me.treeList1.AppendNode(New Object() { "Project A", New System.DateTime(2003, 5, 28, 0, 0, 0), 2}, -1)
			Me.treeList1.AppendNode(New Object() { "Deliverable 1", New System.DateTime(2003, 5, 30, 0, 0, 0), 0}, 0, 1, 1, -1)
			Me.treeList1.AppendNode(New Object() { "This task is mine A", New System.DateTime(2003, 6, 12, 0, 0, 0), 2}, 1, 2, 2, -1)
			Me.treeList1.AppendNode(New Object() { "This task is not mine A", New System.DateTime(2003, 6, 19, 0, 0, 0), 1}, 1, 2, 2, -1)
			Me.treeList1.AppendNode(New Object() { "Project B", New System.DateTime(2003, 6, 20, 0, 0, 0), 0}, -1)
			Me.treeList1.AppendNode(New Object() { "This task is mine B", New System.DateTime(2003, 7, 24, 0, 0, 0), 2}, 4, 2, 2, -1)
			Me.treeList1.AppendNode(New Object() { "This task is not mine B", New System.DateTime(2003, 6, 29, 0, 0, 0), 1}, 4, 2, 2, -1)
			Me.treeList1.AppendNode(New Object() { "Project C", New System.DateTime(2003, 6, 12, 0, 0, 0), 1}, -1)
			Me.treeList1.AppendNode(New Object() { "Deliverable 2", New System.DateTime(2003, 6, 26, 0, 0, 0), 0}, 7, 1, 1, -1)
			Me.treeList1.AppendNode(New Object() { "Deliverable 3", New System.DateTime(2003, 6, 19, 0, 0, 0), 2}, 7, 1, 1, -1)
			Me.treeList1.EndUnboundLoad()
			Me.treeList1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemDateEdit1, Me.repositoryImageComboBox1})
			Me.treeList1.SelectImageList = Me.imageList1
			Me.treeList1.Size = New System.Drawing.Size(555, 292)
			Me.treeList1.TabIndex = 6
			' 
			' treeListColumn1
			' 
			Me.treeListColumn1.Caption = "Name"
			Me.treeListColumn1.FieldName = "Name"
			Me.treeListColumn1.MinWidth = 81
			Me.treeListColumn1.Name = "treeListColumn1"
			Me.treeListColumn1.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.String
			Me.treeListColumn1.VisibleIndex = 0
			Me.treeListColumn1.Width = 240
			' 
			' treeListColumn2
			' 
			Me.treeListColumn2.Caption = "Start Date"
			Me.treeListColumn2.ColumnEdit = Me.repositoryItemDateEdit1
			Me.treeListColumn2.FieldName = "StartDate"
			Me.treeListColumn2.Format.FormatString = "d"
			Me.treeListColumn2.Format.FormatType = DevExpress.Utils.FormatType.DateTime
			Me.treeListColumn2.Name = "treeListColumn2"
			Me.treeListColumn2.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.DateTime
			Me.treeListColumn2.VisibleIndex = 1
			Me.treeListColumn2.Width = 140
			' 
			' repositoryItemDateEdit1
			' 
			Me.repositoryItemDateEdit1.AllowFocused = False
			Me.repositoryItemDateEdit1.AutoHeight = False
			Me.repositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1"
			' 
			' treeListColumn3
			' 
			Me.treeListColumn3.Caption = "Priority"
			Me.treeListColumn3.ColumnEdit = Me.repositoryImageComboBox1
			Me.treeListColumn3.FieldName = "Priority"
			Me.treeListColumn3.Name = "treeListColumn3"
			Me.treeListColumn3.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Integer
			Me.treeListColumn3.VisibleIndex = 2
			Me.treeListColumn3.Width = 140
			' 
			' repositoryImageComboBox1
			' 
			Me.repositoryImageComboBox1.AllowFocused = False
			Me.repositoryImageComboBox1.AutoHeight = False
			Me.repositoryImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Normal", 0, 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("High", 2, 2), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Low", 1, 1)})
			Me.repositoryImageComboBox1.Name = "repositoryImageComboBox1"
			Me.repositoryImageComboBox1.SmallImages = Me.imageList2
			' 
			' imageList2
			' 
			Me.imageList2.ImageStream = (CType(resources.GetObject("imageList2.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList2.TransparentColor = System.Drawing.Color.Magenta
			Me.imageList2.Images.SetKeyName(0, "")
			Me.imageList2.Images.SetKeyName(1, "")
			Me.imageList2.Images.SetKeyName(2, "")
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Magenta
			Me.imageList1.Images.SetKeyName(0, "")
			Me.imageList1.Images.SetKeyName(1, "")
			Me.imageList1.Images.SetKeyName(2, "")
			' 
			' DataStore
			' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.treeList1)
			Me.Name = "DataStore"
			Me.Size = New System.Drawing.Size(563, 300)
			Me.TutorialInfo.AboutFile = Nothing
			Me.TutorialInfo.Description = Nothing
			Me.TutorialInfo.TutorialName = Nothing
			Me.TutorialInfo.WhatsThisCodeFile = Nothing
			Me.TutorialInfo.WhatsThisXMLFile = Nothing
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private treeList1 As DevExpress.XtraTreeList.TreeList
		Private imageList1 As System.Windows.Forms.ImageList
		Private imageList2 As System.Windows.Forms.ImageList
		Private repositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
		Private repositoryImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private treeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn2 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn3 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private components As System.ComponentModel.IContainer

	End Class
End Namespace

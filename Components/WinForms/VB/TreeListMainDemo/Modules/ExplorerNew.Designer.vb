Namespace DevExpress.XtraTreeList.Demos
	Partial Public Class ExplorerNew
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ExplorerNew))
			Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
			Me.colName = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colType = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colSize = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' treeList1
			' 
			Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.colName, Me.colType, Me.colSize})
			Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeList1.Location = New System.Drawing.Point(0, 0)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.OptionsBehavior.Editable = False
			Me.treeList1.OptionsView.EnableAppearanceEvenRow = True
			Me.treeList1.Size = New System.Drawing.Size(623, 400)
			Me.treeList1.StateImageList = Me.imageCollection1
			Me.treeList1.TabIndex = 0
'			Me.treeList1.CustomDrawNodeCell += New DevExpress.XtraTreeList.CustomDrawNodeCellEventHandler(Me.treeList1_CustomDrawNodeCell)
'			Me.treeList1.GetStateImage += New DevExpress.XtraTreeList.GetStateImageEventHandler(Me.treeList1_GetStateImage)
'			Me.treeList1.VirtualTreeGetChildNodes += New DevExpress.XtraTreeList.VirtualTreeGetChildNodesEventHandler(Me.treeList1_VirtualTreeGetChildNodes)
'			Me.treeList1.VirtualTreeGetCellValue += New DevExpress.XtraTreeList.VirtualTreeGetCellValueEventHandler(Me.treeList1_VirtualTreeGetCellValue)
			' 
			' colName
			' 
			Me.colName.Caption = "Name"
			Me.colName.FieldName = "Name"
			Me.colName.MinWidth = 33
			Me.colName.Name = "colName"
			Me.colName.Visible = True
			Me.colName.VisibleIndex = 0
			Me.colName.Width = 369
			' 
			' colType
			' 
			Me.colType.Caption = "Type"
			Me.colType.FieldName = "Type"
			Me.colType.Name = "colType"
			Me.colType.Visible = True
			Me.colType.VisibleIndex = 1
			Me.colType.Width = 117
			' 
			' colSize
			' 
			Me.colSize.Caption = "Size(Bytes)"
			Me.colSize.FieldName = "Size"
			Me.colSize.Name = "colSize"
			Me.colSize.Visible = True
			Me.colSize.VisibleIndex = 2
			Me.colSize.Width = 117
			' 
			' imageCollection1
			' 
			Me.imageCollection1.ImageStream = (CType(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.imageCollection1.Images.SetKeyName(0, "Folder_Closed.png")
			Me.imageCollection1.Images.SetKeyName(1, "Folder_Opened.png")
			Me.imageCollection1.Images.SetKeyName(2, "File.png")
			Me.imageCollection1.Images.SetKeyName(3, "Local_Disk.png")
			' 
			' ExplorerNew
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.treeList1)
			Me.Name = "ExplorerNew"
			Me.Size = New System.Drawing.Size(623, 400)
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private WithEvents treeList1 As DevExpress.XtraTreeList.TreeList
		Private colName As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private colType As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private colSize As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private imageCollection1 As DevExpress.Utils.ImageCollection
		Private components As System.ComponentModel.IContainer = Nothing
	End Class
End Namespace

Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraTreeList.Demos.Tutorials
	Public Partial Class UnboundMode
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
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UnboundMode))
			Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
			Me.treeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.treeListColumn2 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.treeListColumn3 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.treeListColumn4 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' treeList1
			' 
			Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.treeListColumn1, Me.treeListColumn2, Me.treeListColumn3, Me.treeListColumn4})
			Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeList1.Location = New System.Drawing.Point(4, 4)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.OptionsBehavior.AutoChangeParent = False
			Me.treeList1.OptionsBehavior.AutoNodeHeight = False
			Me.treeList1.OptionsBehavior.CloseEditorOnLostFocus = False
			Me.treeList1.OptionsBehavior.Editable = False
			Me.treeList1.OptionsBehavior.KeepSelectedOnClick = False
			Me.treeList1.OptionsBehavior.ShowToolTips = False
			Me.treeList1.OptionsBehavior.SmartMouseHover = False
			Me.treeList1.Size = New System.Drawing.Size(543, 292)
			Me.treeList1.StateImageList = Me.imageList1
			Me.treeList1.TabIndex = 6
'			Me.treeList1.AfterCollapse += New DevExpress.XtraTreeList.NodeEventHandler(Me.treeList1_AfterCollapse);
'			Me.treeList1.AfterExpand += New DevExpress.XtraTreeList.NodeEventHandler(Me.treeList1_AfterExpand);
'			Me.treeList1.BeforeExpand += New DevExpress.XtraTreeList.BeforeExpandEventHandler(Me.treeList1_BeforeExpand);
			' 
			' treeListColumn1
			' 
			Me.treeListColumn1.Caption = "FullName"
			Me.treeListColumn1.FieldName = "FullName"
			Me.treeListColumn1.Name = "treeListColumn1"
			' 
			' treeListColumn2
			' 
			Me.treeListColumn2.Caption = "Name"
			Me.treeListColumn2.FieldName = "Name"
			Me.treeListColumn2.MinWidth = 27
			Me.treeListColumn2.Name = "treeListColumn2"
			Me.treeListColumn2.VisibleIndex = 0
			Me.treeListColumn2.Width = 274
			' 
			' treeListColumn3
			' 
			Me.treeListColumn3.Caption = "Type"
			Me.treeListColumn3.FieldName = "Type"
			Me.treeListColumn3.Name = "treeListColumn3"
			Me.treeListColumn3.VisibleIndex = 1
			Me.treeListColumn3.Width = 112
			' 
			' treeListColumn4
			' 
			Me.treeListColumn4.AppearanceCell.Options.UseTextOptions = True
			Me.treeListColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
			Me.treeListColumn4.Caption = "Size(Bytes)"
			Me.treeListColumn4.FieldName = "Size"
			Me.treeListColumn4.Name = "treeListColumn4"
			Me.treeListColumn4.VisibleIndex = 2
			Me.treeListColumn4.Width = 123
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Magenta
			Me.imageList1.Images.SetKeyName(0, "")
			Me.imageList1.Images.SetKeyName(1, "")
			Me.imageList1.Images.SetKeyName(2, "")
			' 
			' UnboundMode
			' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.treeList1)
			Me.Name = "UnboundMode"
			Me.Size = New System.Drawing.Size(551, 300)
			Me.TutorialInfo.AboutFile = Nothing
			Me.TutorialInfo.Description = Nothing
			Me.TutorialInfo.TutorialName = Nothing
			Me.TutorialInfo.WhatsThisCodeFile = Nothing
			Me.TutorialInfo.WhatsThisXMLFile = Nothing
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private WithEvents treeList1 As DevExpress.XtraTreeList.TreeList
		Private treeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn2 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn3 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn4 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private imageList1 As System.Windows.Forms.ImageList
		Private components As System.ComponentModel.IContainer

	End Class
End Namespace

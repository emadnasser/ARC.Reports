Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraVerticalGrid.Demos.Tutorials
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
			Dim treeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Build", 3, 3)
			Dim treeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Debugging")
			Dim treeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Advanced")
			Dim treeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Configuration Properties", 1, 1, New System.Windows.Forms.TreeNode() { treeNode1, treeNode2, treeNode3})
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.splitter2 = New DevExpress.XtraEditors.SplitterControl()
			Me.treeView1 = New System.Windows.Forms.TreeView()
			Me.vGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Magenta
			Me.imageList1.Images.SetKeyName(0, "")
			Me.imageList1.Images.SetKeyName(1, "")
			Me.imageList1.Images.SetKeyName(2, "")
			Me.imageList1.Images.SetKeyName(3, "")
			' 
			' splitter2
			' 
			Me.splitter2.Location = New System.Drawing.Point(156, 0)
			Me.splitter2.Name = "splitter2"
			Me.splitter2.Size = New System.Drawing.Size(6, 358)
			Me.splitter2.TabIndex = 3
			Me.splitter2.TabStop = False
			' 
			' treeView1
			' 
			Me.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.treeView1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeView1.ImageIndex = 0
			Me.treeView1.ImageList = Me.imageList1
			Me.treeView1.Location = New System.Drawing.Point(2, 2)
			Me.treeView1.Name = "treeView1"
			treeNode1.ImageIndex = 3
			treeNode1.Name = ""
			treeNode1.SelectedImageIndex = 3
			treeNode1.Text = "Build"
			treeNode2.Name = ""
			treeNode2.Text = "Debugging"
			treeNode3.Name = ""
			treeNode3.Text = "Advanced"
			treeNode4.ImageIndex = 1
			treeNode4.Name = ""
			treeNode4.SelectedImageIndex = 1
			treeNode4.Text = "Configuration Properties"
			Me.treeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() { treeNode4})
			Me.treeView1.SelectedImageIndex = 0
			Me.treeView1.ShowLines = False
			Me.treeView1.ShowPlusMinus = False
			Me.treeView1.Size = New System.Drawing.Size(152, 354)
			Me.treeView1.TabIndex = 4
'			Me.treeView1.AfterCollapse += New System.Windows.Forms.TreeViewEventHandler(Me.treeView1_AfterCollapse);
'			Me.treeView1.AfterSelect += New System.Windows.Forms.TreeViewEventHandler(Me.treeView1_AfterSelect);
'			Me.treeView1.AfterExpand += New System.Windows.Forms.TreeViewEventHandler(Me.treeView1_AfterExpand);
			' 
			' vGridControl1
			' 
			Me.vGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.vGridControl1.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView
			Me.vGridControl1.Location = New System.Drawing.Point(162, 0)
			Me.vGridControl1.Name = "vGridControl1"
			Me.vGridControl1.ShowButtonMode = DevExpress.XtraVerticalGrid.ShowButtonModeEnum.ShowAlways
			Me.vGridControl1.Size = New System.Drawing.Size(374, 358)
			Me.vGridControl1.TabIndex = 5
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.treeView1)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Left
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(156, 358)
			Me.panelControl1.TabIndex = 6
			' 
			' UnboundMode
			' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.vGridControl1)
			Me.Controls.Add(Me.splitter2)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "UnboundMode"
			Me.Size = New System.Drawing.Size(536, 358)
			Me.TutorialInfo.AboutFile = Nothing
			Me.TutorialInfo.Description = Nothing
			Me.TutorialInfo.TutorialName = Nothing
			Me.TutorialInfo.WhatsThisCodeFile = Nothing
			Me.TutorialInfo.WhatsThisXMLFile = Nothing
'			Me.Load += New System.EventHandler(Me.UnboundMode_Load);
			CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private splitter2 As DevExpress.XtraEditors.SplitterControl
		Private WithEvents treeView1 As System.Windows.Forms.TreeView
		Private vGridControl1 As DevExpress.XtraVerticalGrid.VGridControl
		Private imageList1 As System.Windows.Forms.ImageList
		Private components As System.ComponentModel.IContainer
		Private panelControl1 As DevExpress.XtraEditors.PanelControl

	End Class
End Namespace

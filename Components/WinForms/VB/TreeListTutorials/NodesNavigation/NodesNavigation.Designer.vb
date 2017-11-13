Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors
Namespace DevExpress.XtraTreeList.Demos.Tutorials
	Public Partial Class NodesNavigation
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
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NodesNavigation))
			Me.treeListColumn5 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.repositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
			Me.treeListColumn2 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.treeListColumn3 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.treeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
			Me.treeListColumn4 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.panel2 = New DevExpress.XtraEditors.PanelControl()
			Me.button7 = New DevExpress.XtraEditors.SimpleButton()
			Me.button6 = New DevExpress.XtraEditors.SimpleButton()
			Me.button5 = New DevExpress.XtraEditors.SimpleButton()
			Me.button4 = New DevExpress.XtraEditors.SimpleButton()
			Me.button3 = New DevExpress.XtraEditors.SimpleButton()
			Me.button2 = New DevExpress.XtraEditors.SimpleButton()
			Me.button1 = New DevExpress.XtraEditors.SimpleButton()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			CType(Me.repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panel2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel2.SuspendLayout()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' treeListColumn5
			' 
			Me.treeListColumn5.Caption = "Mark"
			Me.treeListColumn5.ColumnEdit = Me.repositoryItemCheckEdit1
			Me.treeListColumn5.FieldName = "Mark"
			Me.treeListColumn5.Name = "treeListColumn5"
			Me.treeListColumn5.Visible = True
			Me.treeListColumn5.VisibleIndex = 4
			Me.treeListColumn5.Width = 52
			' 
			' repositoryItemCheckEdit1
			' 
			Me.repositoryItemCheckEdit1.AllowFocused = False
			Me.repositoryItemCheckEdit1.AutoHeight = False
			Me.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1"
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Magenta
			Me.imageList1.Images.SetKeyName(0, "")
			Me.imageList1.Images.SetKeyName(1, "")
			' 
			' repositoryItemSpinEdit1
			' 
			Me.repositoryItemSpinEdit1.AllowFocused = False
			Me.repositoryItemSpinEdit1.AutoHeight = False
			Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
			' 
			' treeListColumn2
			' 
			Me.treeListColumn2.Caption = "Category"
			Me.treeListColumn2.FieldName = "Category"
			Me.treeListColumn2.Name = "treeListColumn2"
			Me.treeListColumn2.Visible = True
			Me.treeListColumn2.VisibleIndex = 2
			Me.treeListColumn2.Width = 72
			' 
			' treeListColumn3
			' 
			Me.treeListColumn3.Caption = "Common Name"
			Me.treeListColumn3.FieldName = "Common Name"
			Me.treeListColumn3.MinWidth = 65
			Me.treeListColumn3.Name = "treeListColumn3"
			Me.treeListColumn3.Visible = True
			Me.treeListColumn3.VisibleIndex = 0
			Me.treeListColumn3.Width = 166
			' 
			' treeListColumn1
			' 
			Me.treeListColumn1.Caption = "Length(cm)"
			Me.treeListColumn1.ColumnEdit = Me.repositoryItemSpinEdit1
			Me.treeListColumn1.FieldName = "Length(cm)"
			Me.treeListColumn1.Name = "treeListColumn1"
			Me.treeListColumn1.Visible = True
			Me.treeListColumn1.VisibleIndex = 3
			Me.treeListColumn1.Width = 71
			' 
			' treeList1
			' 
			Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.treeListColumn1, Me.treeListColumn2, Me.treeListColumn3, Me.treeListColumn4, Me.treeListColumn5})
			Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeList1.Location = New System.Drawing.Point(0, 46)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.BeginUnboundLoad()
			Me.treeList1.AppendNode(New Object() { 15F, "Wrasse", "Bluehead Wrasse", "Thalassoma bifasciatum", False}, -1, 0, 1, -1)
			Me.treeList1.AppendNode(New Object() { 25F, "Wrasse", "Senorita", "Oxyjulis californica", False}, 0, 0, 1, -1)
			Me.treeList1.AppendNode(New Object() { 229F, "Wrasse", "Giant Maori Wrasse", "Cheilinus undulatus", False}, 0, 0, 1, -1)
			Me.treeList1.AppendNode(New Object() { 19F, "Butterflyfish", "Ornate Butterflyfish", "Chaetodon Ornatissimus", True}, -1, 0, 1, -1)
			Me.treeList1.AppendNode(New Object() { 25F, "Smelt", "Surf Smelt", "Hypomesus pretiosus", True}, -1, 0, 1, -1)
			Me.treeList1.AppendNode(New Object() { 28F, "Parrotfish", "Redband Parrotfish", "Sparisoma Aurofrenatum", True}, -1, 0, 1, -1)
			Me.treeList1.AppendNode(New Object() { 30F, "Angelfish", "Blue Angelfish", "Pomacanthus nauarchus", True}, -1, 0, 1, -1)
			Me.treeList1.AppendNode(New Object() { 30F, "Grunt", "French Grunt", "Haemulon flavolineatum", False}, -1, 0, 1, -1)
			Me.treeList1.AppendNode(New Object() { 38F, "Scorpionfish", "Firefish", "Pterois volitans", True}, -1, 0, 1, -1)
			Me.treeList1.AppendNode(New Object() { 40F, "Surfperch", "Redtail Surfperch", "Amphistichus rhodoterus", False}, -1, 0, 1, -1)
			Me.treeList1.AppendNode(New Object() { 50F, "Triggerfish", "Clown Triggerfish", "Ballistoides conspicillum", False}, -1, 0, 1, -1)
			Me.treeList1.AppendNode(New Object() { 55F, "Ray", "Bat Ray", "Myliobatis californica", True}, -1, 0, 1, -1)
			Me.treeList1.AppendNode(New Object() { 200F, "Ray", "Spotted Eagle Ray", "Aetobatus narinari", True}, 11, 0, 1, -1)
			Me.treeList1.AppendNode(New Object() { 60F, "Greenling", "Rock Greenling", "Hexagrammos lagocephalus", True}, -1, 0, 1, -1)
			Me.treeList1.AppendNode(New Object() { 80F, "Cod", "Lunartail Rockcod", "Variola louti", True}, -1, 0, 1, -1)
			Me.treeList1.AppendNode(New Object() { 150F, "Cod", "Lingcod", "Ophiodon elongatus", True}, 14, 0, 1, -1)
			Me.treeList1.AppendNode(New Object() { 90F, "Spadefish", "Atlantic Spadefish", "Chaetodiperus faber", False}, -1, 0, 1, -1)
			Me.treeList1.AppendNode(New Object() { 90F, "Snapper", "Dog Snapper", "Lutjanus jocu", True}, -1, 0, 1, -1)
			Me.treeList1.AppendNode(New Object() { 75F, "Snapper", "Yellowtail Snapper", "Ocyurus chrysurus", False}, 17, 0, 1, -1)
			Me.treeList1.AppendNode(New Object() { 60F, "Snapper", "Red Emperor", "Lutjanus sebae", True}, 17, 0, 1, -1)
			Me.treeList1.AppendNode(New Object() { 90F, "Jack", "Yellow Jack", "Gnathanodon speciousus", True}, -1, 0, 1, -1)
			Me.treeList1.AppendNode(New Object() { 91F, "Grouper", "Nassau Grouper", "Epinephelus striatus", True}, -1, 0, 1, -1)
			Me.treeList1.AppendNode(New Object() { 99F, "Sculpin", "Cabezon", "Scorpaenichthys marmoratus", True}, -1, 0, 1, -1)
			Me.treeList1.AppendNode(New Object() { 150F, "Eel", "California Moray", "Gymnothorax mordax", True}, -1, 0, 1, -1)
			Me.treeList1.AppendNode(New Object() { 150F, "Barracuda", "Great Barracuda", "Sphyraena barracuda", False}, -1, 0, 1, -1)
			Me.treeList1.AppendNode(New Object() { 150F, "Croaker", "White Sea Bass", "Atractoscion nobilis", True}, -1, 0, 1, -1)
			Me.treeList1.AppendNode(New Object() { 400F, "Shark", "Nurse Shark", "Ginglymostoma cirratum", False}, -1, 0, 1, -1)
			Me.treeList1.AppendNode(New Object() { 102F, "Shark", "Swell Shark", "Cephaloscyllium ventriosum", False}, 26, 0, 1, -1)
			Me.treeList1.EndUnboundLoad()
			Me.treeList1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemCheckEdit1, Me.repositoryItemSpinEdit1})
			Me.treeList1.SelectImageList = Me.imageList1
			Me.treeList1.Size = New System.Drawing.Size(708, 254)
			Me.treeList1.TabIndex = 8
			' 
			' treeListColumn4
			' 
			Me.treeListColumn4.Caption = "Species Name"
			Me.treeListColumn4.FieldName = "Species Name"
			Me.treeListColumn4.Name = "treeListColumn4"
			Me.treeListColumn4.Visible = True
			Me.treeListColumn4.VisibleIndex = 1
			Me.treeListColumn4.Width = 143
			' 
			' panel2
			' 
			Me.panel2.Controls.Add(Me.button7)
			Me.panel2.Controls.Add(Me.button6)
			Me.panel2.Controls.Add(Me.button5)
			Me.panel2.Controls.Add(Me.button4)
			Me.panel2.Controls.Add(Me.button3)
			Me.panel2.Controls.Add(Me.button2)
			Me.panel2.Controls.Add(Me.button1)
			Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel2.Location = New System.Drawing.Point(0, 0)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New System.Drawing.Size(708, 38)
			Me.panel2.TabIndex = 9
			' 
			' button7
			' 
			Me.button7.Location = New System.Drawing.Point(500, 8)
			Me.button7.Name = "button7"
			Me.button7.Size = New System.Drawing.Size(100, 22)
			Me.button7.TabIndex = 6
			Me.button7.Text = "MoveLastVisible"
'			Me.button7.Click += New System.EventHandler(Me.button7_Click);
			' 
			' button6
			' 
			Me.button6.Location = New System.Drawing.Point(430, 8)
			Me.button6.Name = "button6"
			Me.button6.Size = New System.Drawing.Size(64, 22)
			Me.button6.TabIndex = 5
			Me.button6.Text = "MoveLast"
'			Me.button6.Click += New System.EventHandler(Me.button6_Click);
			' 
			' button5
			' 
			Me.button5.Location = New System.Drawing.Point(324, 8)
			Me.button5.Name = "button5"
			Me.button5.Size = New System.Drawing.Size(100, 22)
			Me.button5.TabIndex = 4
			Me.button5.Text = "MoveNextVisible"
'			Me.button5.Click += New System.EventHandler(Me.button5_Click);
			' 
			' button4
			' 
			Me.button4.Location = New System.Drawing.Point(254, 8)
			Me.button4.Name = "button4"
			Me.button4.Size = New System.Drawing.Size(64, 22)
			Me.button4.TabIndex = 3
			Me.button4.Text = "MoveNext"
'			Me.button4.Click += New System.EventHandler(Me.button4_Click);
			' 
			' button3
			' 
			Me.button3.Location = New System.Drawing.Point(148, 8)
			Me.button3.Name = "button3"
			Me.button3.Size = New System.Drawing.Size(100, 22)
			Me.button3.TabIndex = 2
			Me.button3.Text = "MovePrevVisible"
'			Me.button3.Click += New System.EventHandler(Me.button3_Click);
			' 
			' button2
			' 
			Me.button2.Location = New System.Drawing.Point(78, 8)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(64, 22)
			Me.button2.TabIndex = 1
			Me.button2.Text = "MovePrev"
'			Me.button2.Click += New System.EventHandler(Me.button2_Click);
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(8, 8)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(64, 22)
			Me.button1.TabIndex = 0
			Me.button1.Text = "MoveFirst"
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' panelControl1
			' 
			Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 38)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(708, 8)
			Me.panelControl1.TabIndex = 10
			' 
			' NodesNavigation
			' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.treeList1)
			Me.Controls.Add(Me.panelControl1)
			Me.Controls.Add(Me.panel2)
			Me.Name = "NodesNavigation"
			Me.Size = New System.Drawing.Size(708, 300)
			Me.TutorialInfo.AboutFile = Nothing
			Me.TutorialInfo.Description = Nothing
			Me.TutorialInfo.TutorialName = Nothing
			Me.TutorialInfo.WhatsThisCodeFile = Nothing
			Me.TutorialInfo.WhatsThisXMLFile = Nothing
			CType(Me.repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panel2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel2.ResumeLayout(False)
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private treeListColumn5 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private repositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
		Private imageList1 As System.Windows.Forms.ImageList
		Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
		Private treeListColumn2 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn3 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeList1 As DevExpress.XtraTreeList.TreeList
		Private treeListColumn4 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private panel2 As PanelControl
		Private WithEvents button1 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents button2 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents button3 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents button4 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents button5 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents button6 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents button7 As DevExpress.XtraEditors.SimpleButton
		Private components As System.ComponentModel.IContainer
		Private panelControl1 As DevExpress.XtraEditors.PanelControl

	End Class
End Namespace

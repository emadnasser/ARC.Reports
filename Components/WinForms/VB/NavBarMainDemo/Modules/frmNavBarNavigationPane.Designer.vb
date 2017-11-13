Namespace DevExpress.XtraNavBar.Demos
	Partial Public Class frmNavBarNavigationPane
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNavBarNavigationPane))
            Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Contacts", 1, 1)
            Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Deleted Items", 8, 8)
            Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Drafts", 9, 9)
            Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Inbox", 10, 10)
            Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Journal", 3, 3)
            Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Notes", 5, 5)
            Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Outbox", 12, 12)
            Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sent Items", 15, 15)
            Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tasks", 7, 7)
            Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Personal Folders", 13, 13, New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6, TreeNode7, TreeNode8, TreeNode9})
            Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
            Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.navBarItem5 = New DevExpress.XtraNavBar.NavBarItem()
            Me.imageList2 = New System.Windows.Forms.ImageList(Me.components)
            Me.navBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
            Me.navBarGroup6 = New DevExpress.XtraNavBar.NavBarGroup()
            Me.navBarItem7 = New DevExpress.XtraNavBar.NavBarItem()
            Me.navBarGroupControlContainer1 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
            Me.panel2 = New DevExpress.XtraEditors.PanelControl()
            Me.monthCalendar1 = New DevExpress.XtraEditors.DateControl()
            Me.navBarGroupControlContainer2 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
            Me.listBox1 = New DevExpress.XtraEditors.ListBoxControl()
            Me.navBarGroupControlContainer3 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
            Me.treeView1 = New DevExpress.Utils.Design.DXDemoTreeView()
            Me.navBarGroup2 = New DevExpress.XtraNavBar.NavBarGroup()
            Me.navBarItem1 = New DevExpress.XtraNavBar.NavBarItem()
            Me.navBarItem2 = New DevExpress.XtraNavBar.NavBarItem()
            Me.navBarItem3 = New DevExpress.XtraNavBar.NavBarItem()
            Me.navBarItem4 = New DevExpress.XtraNavBar.NavBarItem()
            Me.navBarGroup3 = New DevExpress.XtraNavBar.NavBarGroup()
            Me.navBarGroup4 = New DevExpress.XtraNavBar.NavBarGroup()
            Me.navBarGroup5 = New DevExpress.XtraNavBar.NavBarGroup()
            Me.navBarItem6 = New DevExpress.XtraNavBar.NavBarItem()
            Me.navBarGroup7 = New DevExpress.XtraNavBar.NavBarGroup()
            Me.navBarGroup8 = New DevExpress.XtraNavBar.NavBarGroup()
            Me.navBarItem8 = New DevExpress.XtraNavBar.NavBarItem()
            Me.navBarGroup9 = New DevExpress.XtraNavBar.NavBarGroup()
            Me.navBarItem9 = New DevExpress.XtraNavBar.NavBarItem()
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.pnlJournal = New DevExpress.XtraEditors.PanelControl()
            Me.gridControl3 = New DevExpress.XtraGrid.GridControl()
            Me.gridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.gridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemTimeEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit()
            Me.gridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.imageList3 = New System.Windows.Forms.ImageList(Me.components)
            Me.pnlShortcuts = New DevExpress.XtraEditors.PanelControl()
            Me.linkLabel1 = New System.Windows.Forms.LinkLabel()
            Me.pnlContacts = New DevExpress.XtraEditors.PanelControl()
            Me.button1 = New DevExpress.XtraEditors.SimpleButton()
            Me.textBox3 = New DevExpress.XtraEditors.TextEdit()
            Me.label6 = New DevExpress.XtraEditors.LabelControl()
            Me.textBox2 = New DevExpress.XtraEditors.TextEdit()
            Me.label5 = New DevExpress.XtraEditors.LabelControl()
            Me.textBox1 = New DevExpress.XtraEditors.TextEdit()
            Me.label4 = New DevExpress.XtraEditors.LabelControl()
            Me.label3 = New DevExpress.XtraEditors.LabelControl()
            Me.pnlMail = New DevExpress.XtraEditors.PanelControl()
            Me.panel5 = New DevExpress.XtraEditors.PanelControl()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.outlookStyle1 = New DevExpress.XtraNavBar.Demos.OutlookStyle()
            Me.panel4 = New DevExpress.XtraEditors.PanelControl()
            Me.pictureBox2 = New System.Windows.Forms.PictureBox()
            Me.label2 = New DevExpress.XtraEditors.LabelControl()
            Me.splitter2 = New DevExpress.XtraEditors.SplitterControl()
            Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
            Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
            Me.pnlNotes = New DevExpress.XtraEditors.PanelControl()
            Me.gridControl2 = New DevExpress.XtraGrid.GridControl()
            Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.gridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.pnlTasks = New DevExpress.XtraEditors.PanelControl()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.panel3 = New DevExpress.XtraEditors.PanelControl()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.label1 = New DevExpress.XtraEditors.LabelControl()
            Me.pnlMain = New DevExpress.XtraEditors.PanelControl()
            Me.pnlFolderList = New DevExpress.XtraEditors.PanelControl()
            Me.label10 = New DevExpress.XtraEditors.LabelControl()
            Me.panelControl3 = New DevExpress.XtraEditors.PanelControl()
            Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
            CType(Me.contentPanel_Renamed, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.contentPanel_Renamed.SuspendLayout()
            CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navBarControl1.SuspendLayout()
            Me.navBarGroupControlContainer1.SuspendLayout()
            CType(Me.panel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel2.SuspendLayout()
            CType(Me.monthCalendar1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navBarGroupControlContainer2.SuspendLayout()
            CType(Me.listBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navBarGroupControlContainer3.SuspendLayout()
            CType(Me.pnlJournal, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlJournal.SuspendLayout()
            CType(Me.gridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pnlShortcuts, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlShortcuts.SuspendLayout()
            CType(Me.pnlContacts, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlContacts.SuspendLayout()
            CType(Me.textBox3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.textBox2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.textBox1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pnlMail, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlMail.SuspendLayout()
            CType(Me.panel5, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel5.SuspendLayout()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.panel4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel4.SuspendLayout()
            CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl2.SuspendLayout()
            CType(Me.pnlNotes, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlNotes.SuspendLayout()
            CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pnlTasks, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlTasks.SuspendLayout()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panel3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel3.SuspendLayout()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pnlMain, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlMain.SuspendLayout()
            CType(Me.pnlFolderList, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlFolderList.SuspendLayout()
            CType(Me.panelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl3.SuspendLayout()
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.SuspendLayout()
            Me.SuspendLayout()
            '
            'contentPanel_Renamed
            '
            Me.contentPanel_Renamed.Controls.Add(Me.panelControl3)
            Me.contentPanel_Renamed.Size = New System.Drawing.Size(789, 516)
            '
            'gridColumn2
            '
            Me.gridColumn2.FieldName = "Check"
            Me.gridColumn2.ImageIndex = 1
            Me.gridColumn2.Name = "gridColumn2"
            Me.gridColumn2.OptionsColumn.AllowMove = False
            Me.gridColumn2.OptionsColumn.ShowInCustomizationForm = False
            Me.gridColumn2.Visible = True
            Me.gridColumn2.VisibleIndex = 1
            Me.gridColumn2.Width = 27
            '
            'navBarItem5
            '
            Me.navBarItem5.Caption = "Drafts"
            Me.navBarItem5.Name = "navBarItem5"
            Me.navBarItem5.SmallImageIndex = 9
            '
            'imageList2
            '
            Me.imageList2.ImageStream = CType(resources.GetObject("imageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList2.TransparentColor = System.Drawing.Color.Magenta
            Me.imageList2.Images.SetKeyName(0, "")
            Me.imageList2.Images.SetKeyName(1, "")
            Me.imageList2.Images.SetKeyName(2, "")
            Me.imageList2.Images.SetKeyName(3, "")
            Me.imageList2.Images.SetKeyName(4, "")
            Me.imageList2.Images.SetKeyName(5, "")
            Me.imageList2.Images.SetKeyName(6, "")
            Me.imageList2.Images.SetKeyName(7, "")
            Me.imageList2.Images.SetKeyName(8, "")
            Me.imageList2.Images.SetKeyName(9, "")
            Me.imageList2.Images.SetKeyName(10, "")
            Me.imageList2.Images.SetKeyName(11, "")
            Me.imageList2.Images.SetKeyName(12, "")
            Me.imageList2.Images.SetKeyName(13, "")
            Me.imageList2.Images.SetKeyName(14, "")
            Me.imageList2.Images.SetKeyName(15, "")
            '
            'navBarControl1
            '
            Me.navBarControl1.ActiveGroup = Me.navBarGroup6
            Me.navBarControl1.Controls.Add(Me.navBarGroupControlContainer1)
            Me.navBarControl1.Controls.Add(Me.navBarGroupControlContainer2)
            Me.navBarControl1.Controls.Add(Me.navBarGroupControlContainer3)
            Me.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.navBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.navBarGroup2, Me.navBarGroup3, Me.navBarGroup4, Me.navBarGroup5, Me.navBarGroup6, Me.navBarGroup7, Me.navBarGroup8, Me.navBarGroup9})
            Me.navBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.navBarItem1, Me.navBarItem2, Me.navBarItem3, Me.navBarItem4, Me.navBarItem5, Me.navBarItem6, Me.navBarItem7, Me.navBarItem8, Me.navBarItem9})
            Me.navBarControl1.LargeImages = Me.imageList1
            Me.navBarControl1.LinkSelectionMode = DevExpress.XtraNavBar.LinkSelectionModeType.OneInGroup
            Me.navBarControl1.Location = New System.Drawing.Point(0, 0)
            Me.navBarControl1.Name = "navBarControl1"
            Me.navBarControl1.NavigationPaneGroupClientHeight = 160
            Me.navBarControl1.NavigationPaneMaxVisibleGroups = 5
            Me.navBarControl1.OptionsNavPane.ExpandedWidth = 241
            Me.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane
            Me.navBarControl1.Size = New System.Drawing.Size(241, 517)
            Me.navBarControl1.SmallImages = Me.imageList2
            Me.navBarControl1.StoreDefaultPaintStyleName = True
            Me.navBarControl1.TabIndex = 5
            Me.navBarControl1.Text = "navBarControl1"
            '
            'navBarGroup6
            '
            Me.navBarGroup6.Caption = "Notes"
            Me.navBarGroup6.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None
            Me.navBarGroup6.Expanded = True
            Me.navBarGroup6.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
            Me.navBarGroup6.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem7)})
            Me.navBarGroup6.LargeImageIndex = 5
            Me.navBarGroup6.Name = "navBarGroup6"
            Me.navBarGroup6.SelectedLinkIndex = 0
            Me.navBarGroup6.SmallImageIndex = 5
            '
            'navBarItem7
            '
            Me.navBarItem7.Caption = "Notes"
            Me.navBarItem7.Name = "navBarItem7"
            Me.navBarItem7.SmallImageIndex = 5
            '
            'navBarGroupControlContainer1
            '
            Me.navBarGroupControlContainer1.Controls.Add(Me.panel2)
            Me.navBarGroupControlContainer1.Name = "navBarGroupControlContainer1"
            Me.navBarGroupControlContainer1.Size = New System.Drawing.Size(241, 232)
            Me.navBarGroupControlContainer1.TabIndex = 0
            '
            'panel2
            '
            Me.panel2.Appearance.BackColor = System.Drawing.Color.White
            Me.panel2.Appearance.Options.UseBackColor = True
            Me.panel2.Controls.Add(Me.monthCalendar1)
            Me.panel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel2.Location = New System.Drawing.Point(0, 0)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(241, 232)
            Me.panel2.TabIndex = 1
            '
            'monthCalendar1
            '
            Me.monthCalendar1.AllowAnimatedContentChange = True
            Me.monthCalendar1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.monthCalendar1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.monthCalendar1.Dock = System.Windows.Forms.DockStyle.Top
            Me.monthCalendar1.Location = New System.Drawing.Point(2, 2)
            Me.monthCalendar1.Name = "monthCalendar1"
            Me.monthCalendar1.Size = New System.Drawing.Size(237, 227)
            Me.monthCalendar1.TabIndex = 0
            '
            'navBarGroupControlContainer2
            '
            Me.navBarGroupControlContainer2.Controls.Add(Me.listBox1)
            Me.navBarGroupControlContainer2.Name = "navBarGroupControlContainer2"
            Me.navBarGroupControlContainer2.Size = New System.Drawing.Size(241, 232)
            Me.navBarGroupControlContainer2.TabIndex = 1
            '
            'listBox1
            '
            Me.listBox1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.listBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.listBox1.Items.AddRange(New Object() {"John Doe", "Sam Hill", "Karen Holmes", "Jennie Valentine", "Michael Jeffers", "Roger Michelson"})
            Me.listBox1.Location = New System.Drawing.Point(0, 0)
            Me.listBox1.Name = "listBox1"
            Me.listBox1.Size = New System.Drawing.Size(241, 232)
            Me.listBox1.TabIndex = 0
            '
            'navBarGroupControlContainer3
            '
            Me.navBarGroupControlContainer3.Controls.Add(Me.treeView1)
            Me.navBarGroupControlContainer3.Name = "navBarGroupControlContainer3"
            Me.navBarGroupControlContainer3.Size = New System.Drawing.Size(198, 160)
            Me.navBarGroupControlContainer3.TabIndex = 2
            '
            'treeView1
            '
            Me.treeView1.AllowSkinning = True
            Me.treeView1.DefaultExpandCollapseButtonOffset = 5
            Me.treeView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeView1.ImageIndex = 0
            Me.treeView1.ImageList = Me.imageList2
            Me.treeView1.Location = New System.Drawing.Point(0, 0)
            Me.treeView1.Name = "treeView1"
            TreeNode1.ImageIndex = 1
            TreeNode1.Name = ""
            TreeNode1.SelectedImageIndex = 1
            TreeNode1.Text = "Contacts"
            TreeNode2.ImageIndex = 8
            TreeNode2.Name = ""
            TreeNode2.SelectedImageIndex = 8
            TreeNode2.Text = "Deleted Items"
            TreeNode3.ImageIndex = 9
            TreeNode3.Name = ""
            TreeNode3.SelectedImageIndex = 9
            TreeNode3.Text = "Drafts"
            TreeNode4.ImageIndex = 10
            TreeNode4.Name = ""
            TreeNode4.SelectedImageIndex = 10
            TreeNode4.Text = "Inbox"
            TreeNode5.ImageIndex = 3
            TreeNode5.Name = ""
            TreeNode5.SelectedImageIndex = 3
            TreeNode5.Text = "Journal"
            TreeNode6.ImageIndex = 5
            TreeNode6.Name = ""
            TreeNode6.SelectedImageIndex = 5
            TreeNode6.Text = "Notes"
            TreeNode7.ImageIndex = 12
            TreeNode7.Name = ""
            TreeNode7.SelectedImageIndex = 12
            TreeNode7.Text = "Outbox"
            TreeNode8.ImageIndex = 15
            TreeNode8.Name = ""
            TreeNode8.SelectedImageIndex = 15
            TreeNode8.Text = "Sent Items"
            TreeNode9.ImageIndex = 7
            TreeNode9.Name = ""
            TreeNode9.SelectedImageIndex = 7
            TreeNode9.Text = "Tasks"
            TreeNode10.ImageIndex = 13
            TreeNode10.Name = ""
            TreeNode10.SelectedImageIndex = 13
            TreeNode10.Text = "Personal Folders"
            Me.treeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode10})
            Me.treeView1.SelectedImageIndex = 0
            Me.treeView1.SelectionMode = DevExpress.Utils.Design.DXTreeSelectionMode.MultiSelectChildrenSameBranch
            Me.treeView1.Size = New System.Drawing.Size(198, 160)
            Me.treeView1.TabIndex = 0
            '
            'navBarGroup2
            '
            Me.navBarGroup2.Caption = "Mail"
            Me.navBarGroup2.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
            Me.navBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText
            Me.navBarGroup2.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem1), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem2), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem3), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem4), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem5)})
            Me.navBarGroup2.LargeImageIndex = 4
            Me.navBarGroup2.Name = "navBarGroup2"
            Me.navBarGroup2.SmallImageIndex = 4
            '
            'navBarItem1
            '
            Me.navBarItem1.Caption = "Inbox"
            Me.navBarItem1.Name = "navBarItem1"
            Me.navBarItem1.SmallImageIndex = 10
            '
            'navBarItem2
            '
            Me.navBarItem2.Caption = "Outbox"
            Me.navBarItem2.Name = "navBarItem2"
            Me.navBarItem2.SmallImageIndex = 12
            '
            'navBarItem3
            '
            Me.navBarItem3.Caption = "Sent Items"
            Me.navBarItem3.Name = "navBarItem3"
            Me.navBarItem3.SmallImageIndex = 15
            '
            'navBarItem4
            '
            Me.navBarItem4.Caption = "Deleted Items"
            Me.navBarItem4.Name = "navBarItem4"
            Me.navBarItem4.SmallImageIndex = 8
            '
            'navBarGroup3
            '
            Me.navBarGroup3.Caption = "Calendar"
            Me.navBarGroup3.ControlContainer = Me.navBarGroupControlContainer1
            Me.navBarGroup3.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None
            Me.navBarGroup3.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
            Me.navBarGroup3.GroupClientHeight = 160
            Me.navBarGroup3.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
            Me.navBarGroup3.LargeImageIndex = 0
            Me.navBarGroup3.Name = "navBarGroup3"
            Me.navBarGroup3.SmallImageIndex = 0
            '
            'navBarGroup4
            '
            Me.navBarGroup4.Caption = "Contacts"
            Me.navBarGroup4.ControlContainer = Me.navBarGroupControlContainer2
            Me.navBarGroup4.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None
            Me.navBarGroup4.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
            Me.navBarGroup4.GroupClientHeight = 160
            Me.navBarGroup4.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
            Me.navBarGroup4.LargeImageIndex = 1
            Me.navBarGroup4.Name = "navBarGroup4"
            Me.navBarGroup4.SmallImageIndex = 1
            '
            'navBarGroup5
            '
            Me.navBarGroup5.Caption = "Tasks"
            Me.navBarGroup5.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None
            Me.navBarGroup5.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
            Me.navBarGroup5.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem6)})
            Me.navBarGroup5.LargeImageIndex = 7
            Me.navBarGroup5.Name = "navBarGroup5"
            Me.navBarGroup5.SelectedLinkIndex = 0
            Me.navBarGroup5.SmallImageIndex = 7
            '
            'navBarItem6
            '
            Me.navBarItem6.Caption = "Tasks"
            Me.navBarItem6.Name = "navBarItem6"
            Me.navBarItem6.SmallImageIndex = 7
            '
            'navBarGroup7
            '
            Me.navBarGroup7.Caption = "Folder List"
            Me.navBarGroup7.ControlContainer = Me.navBarGroupControlContainer3
            Me.navBarGroup7.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None
            Me.navBarGroup7.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
            Me.navBarGroup7.GroupClientHeight = 160
            Me.navBarGroup7.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
            Me.navBarGroup7.LargeImageIndex = 2
            Me.navBarGroup7.Name = "navBarGroup7"
            Me.navBarGroup7.SmallImageIndex = 2
            '
            'navBarGroup8
            '
            Me.navBarGroup8.Caption = "Shortcuts"
            Me.navBarGroup8.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None
            Me.navBarGroup8.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
            Me.navBarGroup8.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem8)})
            Me.navBarGroup8.LargeImageIndex = 6
            Me.navBarGroup8.Name = "navBarGroup8"
            Me.navBarGroup8.SelectedLinkIndex = 0
            Me.navBarGroup8.SmallImageIndex = 6
            '
            'navBarItem8
            '
            Me.navBarItem8.Caption = "Shortcuts"
            Me.navBarItem8.Name = "navBarItem8"
            Me.navBarItem8.SmallImageIndex = 6
            '
            'navBarGroup9
            '
            Me.navBarGroup9.Caption = "Journal"
            Me.navBarGroup9.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None
            Me.navBarGroup9.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
            Me.navBarGroup9.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem9)})
            Me.navBarGroup9.LargeImageIndex = 3
            Me.navBarGroup9.Name = "navBarGroup9"
            Me.navBarGroup9.SelectedLinkIndex = 0
            Me.navBarGroup9.SmallImageIndex = 3
            Me.navBarGroup9.Visible = False
            '
            'navBarItem9
            '
            Me.navBarItem9.Caption = "Journal"
            Me.navBarItem9.Name = "navBarItem9"
            Me.navBarItem9.SmallImageIndex = 3
            '
            'imageList1
            '
            Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Magenta
            Me.imageList1.Images.SetKeyName(0, "")
            Me.imageList1.Images.SetKeyName(1, "")
            Me.imageList1.Images.SetKeyName(2, "")
            Me.imageList1.Images.SetKeyName(3, "")
            Me.imageList1.Images.SetKeyName(4, "")
            Me.imageList1.Images.SetKeyName(5, "")
            Me.imageList1.Images.SetKeyName(6, "")
            Me.imageList1.Images.SetKeyName(7, "")
            '
            'pnlJournal
            '
            Me.pnlJournal.Controls.Add(Me.gridControl3)
            Me.pnlJournal.Location = New System.Drawing.Point(296, 232)
            Me.pnlJournal.Name = "pnlJournal"
            Me.pnlJournal.Size = New System.Drawing.Size(260, 168)
            Me.pnlJournal.TabIndex = 6
            Me.pnlJournal.Tag = "Journal"
            '
            'gridControl3
            '
            Me.gridControl3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl3.Location = New System.Drawing.Point(2, 2)
            Me.gridControl3.MainView = Me.gridView3
            Me.gridControl3.Name = "gridControl3"
            Me.gridControl3.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemTimeEdit1})
            Me.gridControl3.Size = New System.Drawing.Size(256, 164)
            Me.gridControl3.TabIndex = 2
            Me.gridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView3})
            '
            'gridView3
            '
            Me.gridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gridColumn7, Me.gridColumn8, Me.gridColumn9})
            Me.gridView3.GridControl = Me.gridControl3
            Me.gridView3.Images = Me.imageList3
            Me.gridView3.Name = "gridView3"
            Me.gridView3.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
            Me.gridView3.OptionsView.ShowGroupPanel = False
            Me.gridView3.OptionsView.ShowIndicator = False
            '
            'gridColumn7
            '
            Me.gridColumn7.Caption = "Date"
            Me.gridColumn7.FieldName = "Date"
            Me.gridColumn7.Name = "gridColumn7"
            Me.gridColumn7.Visible = True
            Me.gridColumn7.VisibleIndex = 0
            Me.gridColumn7.Width = 175
            '
            'gridColumn8
            '
            Me.gridColumn8.Caption = "Time"
            Me.gridColumn8.ColumnEdit = Me.repositoryItemTimeEdit1
            Me.gridColumn8.FieldName = "Time"
            Me.gridColumn8.Name = "gridColumn8"
            Me.gridColumn8.Visible = True
            Me.gridColumn8.VisibleIndex = 1
            Me.gridColumn8.Width = 168
            '
            'repositoryItemTimeEdit1
            '
            Me.repositoryItemTimeEdit1.AutoHeight = False
            Me.repositoryItemTimeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemTimeEdit1.Name = "repositoryItemTimeEdit1"
            '
            'gridColumn9
            '
            Me.gridColumn9.Caption = "Description"
            Me.gridColumn9.FieldName = "Description"
            Me.gridColumn9.Name = "gridColumn9"
            Me.gridColumn9.Visible = True
            Me.gridColumn9.VisibleIndex = 2
            Me.gridColumn9.Width = 781
            '
            'imageList3
            '
            Me.imageList3.ImageStream = CType(resources.GetObject("imageList3.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList3.TransparentColor = System.Drawing.Color.Magenta
            Me.imageList3.Images.SetKeyName(0, "")
            Me.imageList3.Images.SetKeyName(1, "")
            '
            'pnlShortcuts
            '
            Me.pnlShortcuts.Appearance.BackColor = System.Drawing.SystemColors.Window
            Me.pnlShortcuts.Appearance.Options.UseBackColor = True
            Me.pnlShortcuts.Controls.Add(Me.linkLabel1)
            Me.pnlShortcuts.Location = New System.Drawing.Point(240, 204)
            Me.pnlShortcuts.Name = "pnlShortcuts"
            Me.pnlShortcuts.Size = New System.Drawing.Size(260, 168)
            Me.pnlShortcuts.TabIndex = 5
            Me.pnlShortcuts.Tag = "Shortcuts"
            '
            'linkLabel1
            '
            Me.linkLabel1.Location = New System.Drawing.Point(16, 16)
            Me.linkLabel1.Name = "linkLabel1"
            Me.linkLabel1.Size = New System.Drawing.Size(164, 16)
            Me.linkLabel1.TabIndex = 0
            Me.linkLabel1.TabStop = True
            Me.linkLabel1.Text = "DevExpress on the Web"
            '
            'pnlContacts
            '
            Me.pnlContacts.Controls.Add(Me.button1)
            Me.pnlContacts.Controls.Add(Me.textBox3)
            Me.pnlContacts.Controls.Add(Me.label6)
            Me.pnlContacts.Controls.Add(Me.textBox2)
            Me.pnlContacts.Controls.Add(Me.label5)
            Me.pnlContacts.Controls.Add(Me.textBox1)
            Me.pnlContacts.Controls.Add(Me.label4)
            Me.pnlContacts.Controls.Add(Me.label3)
            Me.pnlContacts.Location = New System.Drawing.Point(296, 72)
            Me.pnlContacts.Name = "pnlContacts"
            Me.pnlContacts.Size = New System.Drawing.Size(260, 168)
            Me.pnlContacts.TabIndex = 2
            Me.pnlContacts.Tag = "Contacts"
            '
            'button1
            '
            Me.button1.Location = New System.Drawing.Point(20, 124)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(112, 24)
            Me.button1.TabIndex = 7
            Me.button1.Text = "Add"
            '
            'textBox3
            '
            Me.textBox3.EditValue = ""
            Me.textBox3.Location = New System.Drawing.Point(92, 88)
            Me.textBox3.Name = "textBox3"
            Me.textBox3.Size = New System.Drawing.Size(124, 20)
            Me.textBox3.TabIndex = 5
            '
            'label6
            '
            Me.label6.Location = New System.Drawing.Point(16, 92)
            Me.label6.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(32, 13)
            Me.label6.TabIndex = 6
            Me.label6.Text = "E-mail:"
            '
            'textBox2
            '
            Me.textBox2.EditValue = ""
            Me.textBox2.Location = New System.Drawing.Point(92, 60)
            Me.textBox2.Name = "textBox2"
            Me.textBox2.Size = New System.Drawing.Size(124, 20)
            Me.textBox2.TabIndex = 3
            '
            'label5
            '
            Me.label5.Location = New System.Drawing.Point(16, 64)
            Me.label5.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(54, 13)
            Me.label5.TabIndex = 4
            Me.label5.Text = "Last Name:"
            '
            'textBox1
            '
            Me.textBox1.EditValue = ""
            Me.textBox1.Location = New System.Drawing.Point(92, 32)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(124, 20)
            Me.textBox1.TabIndex = 1
            '
            'label4
            '
            Me.label4.Location = New System.Drawing.Point(16, 36)
            Me.label4.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(55, 13)
            Me.label4.TabIndex = 2
            Me.label4.Text = "First Name:"
            '
            'label3
            '
            Me.label3.Appearance.BackColor = System.Drawing.SystemColors.ControlDark
            Me.label3.Appearance.ForeColor = System.Drawing.SystemColors.HighlightText
            Me.label3.Location = New System.Drawing.Point(12, 8)
            Me.label3.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(93, 13)
            Me.label3.TabIndex = 0
            Me.label3.Text = "Add new contact..."
            '
            'pnlMail
            '
            Me.pnlMail.Controls.Add(Me.panel5)
            Me.pnlMail.Controls.Add(Me.splitter2)
            Me.pnlMail.Controls.Add(Me.panelControl2)
            Me.pnlMail.Location = New System.Drawing.Point(60, 44)
            Me.pnlMail.Name = "pnlMail"
            Me.pnlMail.Size = New System.Drawing.Size(432, 324)
            Me.pnlMail.TabIndex = 1
            Me.pnlMail.Tag = "Mail"
            '
            'panel5
            '
            Me.panel5.Controls.Add(Me.panelControl1)
            Me.panel5.Controls.Add(Me.panel4)
            Me.panel5.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel5.Location = New System.Drawing.Point(2, 2)
            Me.panel5.Name = "panel5"
            Me.panel5.Size = New System.Drawing.Size(428, 123)
            Me.panel5.TabIndex = 2
            '
            'panelControl1
            '
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Controls.Add(Me.outlookStyle1)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl1.Location = New System.Drawing.Point(2, 22)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(424, 99)
            Me.panelControl1.TabIndex = 3
            '
            'outlookStyle1
            '
            Me.outlookStyle1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.outlookStyle1.Location = New System.Drawing.Point(0, 0)
            Me.outlookStyle1.MailFilter = DevExpress.XtraNavBar.Demos.MailFilter.Draft
            Me.outlookStyle1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.outlookStyle1.Name = "outlookStyle1"
            Me.outlookStyle1.Size = New System.Drawing.Size(424, 99)
            Me.outlookStyle1.TabIndex = 0
            '
            'panel4
            '
            Me.panel4.Appearance.BackColor = System.Drawing.SystemColors.ControlDark
            Me.panel4.Appearance.Options.UseBackColor = True
            Me.panel4.Controls.Add(Me.pictureBox2)
            Me.panel4.Controls.Add(Me.label2)
            Me.panel4.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel4.Location = New System.Drawing.Point(2, 2)
            Me.panel4.Name = "panel4"
            Me.panel4.Size = New System.Drawing.Size(424, 20)
            Me.panel4.TabIndex = 1
            '
            'pictureBox2
            '
            Me.pictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pictureBox2.Location = New System.Drawing.Point(400, 3)
            Me.pictureBox2.Name = "pictureBox2"
            Me.pictureBox2.Size = New System.Drawing.Size(24, 20)
            Me.pictureBox2.TabIndex = 1
            Me.pictureBox2.TabStop = False
            '
            'label2
            '
            Me.label2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
            Me.label2.Appearance.ForeColor = System.Drawing.SystemColors.HighlightText
            Me.label2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.label2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.label2.Dock = System.Windows.Forms.DockStyle.Left
            Me.label2.Location = New System.Drawing.Point(2, 2)
            Me.label2.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(0, 15)
            Me.label2.TabIndex = 0
            '
            'splitter2
            '
            Me.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.splitter2.Location = New System.Drawing.Point(2, 125)
            Me.splitter2.Name = "splitter2"
            Me.splitter2.Size = New System.Drawing.Size(428, 5)
            Me.splitter2.TabIndex = 3
            Me.splitter2.TabStop = False
            '
            'panelControl2
            '
            Me.panelControl2.Controls.Add(Me.richTextBox1)
            Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panelControl2.Location = New System.Drawing.Point(2, 130)
            Me.panelControl2.Name = "panelControl2"
            Me.panelControl2.Size = New System.Drawing.Size(428, 192)
            Me.panelControl2.TabIndex = 5
            '
            'richTextBox1
            '
            Me.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richTextBox1.Location = New System.Drawing.Point(2, 2)
            Me.richTextBox1.Name = "richTextBox1"
            Me.richTextBox1.Size = New System.Drawing.Size(424, 188)
            Me.richTextBox1.TabIndex = 4
            Me.richTextBox1.Text = ""
            '
            'pnlNotes
            '
            Me.pnlNotes.Controls.Add(Me.gridControl2)
            Me.pnlNotes.Location = New System.Drawing.Point(296, 40)
            Me.pnlNotes.Name = "pnlNotes"
            Me.pnlNotes.Size = New System.Drawing.Size(260, 168)
            Me.pnlNotes.TabIndex = 4
            Me.pnlNotes.Tag = "Notes"
            '
            'gridControl2
            '
            Me.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl2.Location = New System.Drawing.Point(2, 2)
            Me.gridControl2.MainView = Me.gridView2
            Me.gridControl2.Name = "gridControl2"
            Me.gridControl2.Size = New System.Drawing.Size(256, 164)
            Me.gridControl2.TabIndex = 1
            Me.gridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView2})
            '
            'gridView2
            '
            Me.gridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gridColumn5, Me.gridColumn6})
            Me.gridView2.GridControl = Me.gridControl2
            Me.gridView2.Images = Me.imageList3
            Me.gridView2.Name = "gridView2"
            Me.gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
            Me.gridView2.OptionsView.ShowGroupPanel = False
            Me.gridView2.OptionsView.ShowIndicator = False
            '
            'gridColumn5
            '
            Me.gridColumn5.Caption = "Name"
            Me.gridColumn5.FieldName = "Name"
            Me.gridColumn5.Name = "gridColumn5"
            Me.gridColumn5.Visible = True
            Me.gridColumn5.VisibleIndex = 0
            Me.gridColumn5.Width = 287
            '
            'gridColumn6
            '
            Me.gridColumn6.Caption = "Description"
            Me.gridColumn6.FieldName = "Description"
            Me.gridColumn6.Name = "gridColumn6"
            Me.gridColumn6.Visible = True
            Me.gridColumn6.VisibleIndex = 1
            Me.gridColumn6.Width = 837
            '
            'pnlTasks
            '
            Me.pnlTasks.Controls.Add(Me.gridControl1)
            Me.pnlTasks.Location = New System.Drawing.Point(16, 204)
            Me.pnlTasks.Name = "pnlTasks"
            Me.pnlTasks.Size = New System.Drawing.Size(260, 168)
            Me.pnlTasks.TabIndex = 3
            Me.pnlTasks.Tag = "Tasks"
            '
            'gridControl1
            '
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(2, 2)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemImageComboBox1})
            Me.gridControl1.Size = New System.Drawing.Size(256, 164)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            '
            'gridView1
            '
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gridColumn1, Me.gridColumn2, Me.gridColumn3, Me.gridColumn4})
            StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point)
            StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Gray
            StyleFormatCondition1.Appearance.Options.UseFont = True
            StyleFormatCondition1.Appearance.Options.UseForeColor = True
            StyleFormatCondition1.ApplyToRow = True
            StyleFormatCondition1.Column = Me.gridColumn2
            StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition1.Value1 = True
            Me.gridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Images = Me.imageList3
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
            Me.gridView1.OptionsView.ShowGroupPanel = False
            Me.gridView1.OptionsView.ShowIndicator = False
            '
            'gridColumn1
            '
            Me.gridColumn1.ColumnEdit = Me.repositoryItemImageComboBox1
            Me.gridColumn1.FieldName = "Image"
            Me.gridColumn1.ImageIndex = 0
            Me.gridColumn1.Name = "gridColumn1"
            Me.gridColumn1.OptionsColumn.AllowEdit = False
            Me.gridColumn1.OptionsColumn.AllowFocus = False
            Me.gridColumn1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridColumn1.OptionsColumn.AllowIncrementalSearch = False
            Me.gridColumn1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridColumn1.OptionsColumn.AllowMove = False
            Me.gridColumn1.OptionsColumn.AllowSize = False
            Me.gridColumn1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridColumn1.OptionsColumn.FixedWidth = True
            Me.gridColumn1.OptionsColumn.ShowInCustomizationForm = False
            Me.gridColumn1.Visible = True
            Me.gridColumn1.VisibleIndex = 0
            Me.gridColumn1.Width = 27
            '
            'repositoryItemImageComboBox1
            '
            Me.repositoryItemImageComboBox1.AutoHeight = False
            Me.repositoryItemImageComboBox1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.repositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 0, 7)})
            Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
            Me.repositoryItemImageComboBox1.SmallImages = Me.imageList2
            '
            'gridColumn3
            '
            Me.gridColumn3.Caption = "Subject"
            Me.gridColumn3.FieldName = "Subject"
            Me.gridColumn3.Name = "gridColumn3"
            Me.gridColumn3.Visible = True
            Me.gridColumn3.VisibleIndex = 2
            Me.gridColumn3.Width = 297
            '
            'gridColumn4
            '
            Me.gridColumn4.Caption = "Due Date"
            Me.gridColumn4.FieldName = "Date"
            Me.gridColumn4.Name = "gridColumn4"
            Me.gridColumn4.Visible = True
            Me.gridColumn4.VisibleIndex = 3
            Me.gridColumn4.Width = 94
            '
            'panel3
            '
            Me.panel3.Appearance.BackColor = System.Drawing.SystemColors.Highlight
            Me.panel3.Appearance.Options.UseBackColor = True
            Me.panel3.Controls.Add(Me.pictureBox1)
            Me.panel3.Controls.Add(Me.label1)
            Me.panel3.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel3.Location = New System.Drawing.Point(2, 2)
            Me.panel3.Name = "panel3"
            Me.panel3.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
            Me.panel3.Size = New System.Drawing.Size(520, 25)
            Me.panel3.TabIndex = 0
            '
            'pictureBox1
            '
            Me.pictureBox1.BackColor = System.Drawing.Color.Transparent
            Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right
            Me.pictureBox1.Location = New System.Drawing.Point(486, 2)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(32, 21)
            Me.pictureBox1.TabIndex = 1
            Me.pictureBox1.TabStop = False
            '
            'label1
            '
            Me.label1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
            Me.label1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.label1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.label1.Dock = System.Windows.Forms.DockStyle.Left
            Me.label1.Location = New System.Drawing.Point(6, 2)
            Me.label1.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(18, 18)
            Me.label1.TabIndex = 0
            Me.label1.Text = "12"
            '
            'pnlMain
            '
            Me.pnlMain.Controls.Add(Me.pnlShortcuts)
            Me.pnlMain.Controls.Add(Me.pnlContacts)
            Me.pnlMain.Controls.Add(Me.pnlFolderList)
            Me.pnlMain.Controls.Add(Me.panel3)
            Me.pnlMain.Controls.Add(Me.pnlNotes)
            Me.pnlMain.Controls.Add(Me.pnlJournal)
            Me.pnlMain.Controls.Add(Me.pnlTasks)
            Me.pnlMain.Controls.Add(Me.pnlMail)
            Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlMain.Location = New System.Drawing.Point(0, 0)
            Me.pnlMain.Name = "pnlMain"
            Me.pnlMain.Size = New System.Drawing.Size(524, 517)
            Me.pnlMain.TabIndex = 6
            '
            'pnlFolderList
            '
            Me.pnlFolderList.Controls.Add(Me.label10)
            Me.pnlFolderList.Location = New System.Drawing.Point(176, 228)
            Me.pnlFolderList.Name = "pnlFolderList"
            Me.pnlFolderList.Size = New System.Drawing.Size(260, 168)
            Me.pnlFolderList.TabIndex = 7
            Me.pnlFolderList.Tag = "Folder List"
            '
            'label10
            '
            Me.label10.Appearance.BackColor = System.Drawing.SystemColors.ControlDark
            Me.label10.Appearance.ForeColor = System.Drawing.SystemColors.HighlightText
            Me.label10.Location = New System.Drawing.Point(12, 8)
            Me.label10.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(221, 13)
            Me.label10.TabIndex = 0
            Me.label10.Text = "Select an item from the treeview on the left..."
            '
            'panelControl3
            '
            Me.panelControl3.Controls.Add(Me.splitContainerControl1)
            Me.panelControl3.Location = New System.Drawing.Point(8, 8)
            Me.panelControl3.Margin = New System.Windows.Forms.Padding(2)
            Me.panelControl3.Name = "panelControl3"
            Me.panelControl3.Size = New System.Drawing.Size(774, 521)
            Me.panelControl3.TabIndex = 7
            '
            'splitContainerControl1
            '
            Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainerControl1.Location = New System.Drawing.Point(2, 2)
            Me.splitContainerControl1.Margin = New System.Windows.Forms.Padding(2)
            Me.splitContainerControl1.Name = "splitContainerControl1"
            Me.splitContainerControl1.Panel1.Controls.Add(Me.navBarControl1)
            Me.splitContainerControl1.Panel1.Text = "Panel1"
            Me.splitContainerControl1.Panel2.Controls.Add(Me.pnlMain)
            Me.splitContainerControl1.Panel2.Text = "Panel2"
            Me.splitContainerControl1.Size = New System.Drawing.Size(770, 517)
            Me.splitContainerControl1.SplitterPosition = 241
            Me.splitContainerControl1.TabIndex = 0
            Me.splitContainerControl1.Text = "splitContainerControl1"
            '
            'frmNavBarNavigationPane
            '
            Me.Appearance.Options.UseFont = True
            Me.Name = "frmNavBarNavigationPane"
            Me.Size = New System.Drawing.Size(789, 516)
            CType(Me.contentPanel_Renamed, System.ComponentModel.ISupportInitialize).EndInit()
            Me.contentPanel_Renamed.ResumeLayout(False)
            CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.navBarControl1.ResumeLayout(False)
            Me.navBarGroupControlContainer1.ResumeLayout(False)
            CType(Me.panel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel2.ResumeLayout(False)
            Me.panel2.PerformLayout()
            CType(Me.monthCalendar1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.navBarGroupControlContainer2.ResumeLayout(False)
            CType(Me.listBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.navBarGroupControlContainer3.ResumeLayout(False)
            CType(Me.pnlJournal, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlJournal.ResumeLayout(False)
            CType(Me.gridControl3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pnlShortcuts, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlShortcuts.ResumeLayout(False)
            CType(Me.pnlContacts, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlContacts.ResumeLayout(False)
            Me.pnlContacts.PerformLayout()
            CType(Me.textBox3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.textBox2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.textBox1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pnlMail, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlMail.ResumeLayout(False)
            CType(Me.panel5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel5.ResumeLayout(False)
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType(Me.panel4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel4.ResumeLayout(False)
            Me.panel4.PerformLayout()
            CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl2.ResumeLayout(False)
            CType(Me.pnlNotes, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlNotes.ResumeLayout(False)
            CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pnlTasks, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlTasks.ResumeLayout(False)
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panel3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel3.ResumeLayout(False)
            Me.panel3.PerformLayout()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pnlMain, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlMain.ResumeLayout(False)
            CType(Me.pnlFolderList, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlFolderList.ResumeLayout(False)
            Me.pnlFolderList.PerformLayout()
            CType(Me.panelControl3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl3.ResumeLayout(False)
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private WithEvents navBarItem5 As DevExpress.XtraNavBar.NavBarItem
		Private imageList2 As ImageList
		Private WithEvents navBarControl1 As DevExpress.XtraNavBar.NavBarControl
		Private navBarGroupControlContainer1 As DevExpress.XtraNavBar.NavBarGroupControlContainer
		Private panel2 As DevExpress.XtraEditors.PanelControl
		Private monthCalendar1 As DevExpress.XtraEditors.DateControl
		Private navBarGroupControlContainer2 As DevExpress.XtraNavBar.NavBarGroupControlContainer
		Private navBarGroup2 As DevExpress.XtraNavBar.NavBarGroup
		Private WithEvents navBarItem1 As DevExpress.XtraNavBar.NavBarItem
		Private WithEvents navBarItem2 As DevExpress.XtraNavBar.NavBarItem
		Private WithEvents navBarItem3 As DevExpress.XtraNavBar.NavBarItem
		Private WithEvents navBarItem4 As DevExpress.XtraNavBar.NavBarItem
		Private navBarGroup3 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarGroup4 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarGroup5 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarGroup6 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarGroup7 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarGroup8 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarGroup9 As DevExpress.XtraNavBar.NavBarGroup
		Private imageList1 As ImageList
		Private listBox1 As DevExpress.XtraEditors.ListBoxControl
		Private navBarGroupControlContainer3 As DevExpress.XtraNavBar.NavBarGroupControlContainer
        Private WithEvents treeView1 As DevExpress.Utils.Design.DXDemoTreeView
		Private navBarItem6 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem7 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem8 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem9 As DevExpress.XtraNavBar.NavBarItem
		Private pnlJournal As DevExpress.XtraEditors.PanelControl
		Private pnlShortcuts As DevExpress.XtraEditors.PanelControl
		Private WithEvents linkLabel1 As LinkLabel
		Private pnlContacts As DevExpress.XtraEditors.PanelControl
		Private WithEvents button1 As DevExpress.XtraEditors.SimpleButton
		Private textBox3 As DevExpress.XtraEditors.TextEdit
		Private label6 As DevExpress.XtraEditors.LabelControl
		Private textBox2 As DevExpress.XtraEditors.TextEdit
		Private label5 As DevExpress.XtraEditors.LabelControl
		Private textBox1 As DevExpress.XtraEditors.TextEdit
		Private label4 As DevExpress.XtraEditors.LabelControl
		Private label3 As DevExpress.XtraEditors.LabelControl
		Private pnlMail As DevExpress.XtraEditors.PanelControl
		Private richTextBox1 As RichTextBox
		Private splitter2 As DevExpress.XtraEditors.SplitterControl
		Private panel5 As DevExpress.XtraEditors.PanelControl
		Private panel4 As DevExpress.XtraEditors.PanelControl
		Private pictureBox2 As PictureBox
		Private label2 As DevExpress.XtraEditors.LabelControl
		Private pnlNotes As DevExpress.XtraEditors.PanelControl
		Private pnlTasks As DevExpress.XtraEditors.PanelControl
		Private panel3 As DevExpress.XtraEditors.PanelControl
		Private pictureBox1 As PictureBox
		Private label1 As DevExpress.XtraEditors.LabelControl
		Private pnlMain As DevExpress.XtraEditors.PanelControl
		Private pnlFolderList As DevExpress.XtraEditors.PanelControl
		Private label10 As DevExpress.XtraEditors.LabelControl
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private panelControl2 As DevExpress.XtraEditors.PanelControl
		Private outlookStyle1 As DevExpress.XtraNavBar.Demos.OutlookStyle
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
		Private imageList3 As ImageList
		Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private gridControl2 As DevExpress.XtraGrid.GridControl
		Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridControl3 As DevExpress.XtraGrid.GridControl
		Private gridView3 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemTimeEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
		Private components As System.ComponentModel.IContainer
		Private panelControl3 As XtraEditors.PanelControl
		Private splitContainerControl1 As XtraEditors.SplitContainerControl

	End Class
End Namespace

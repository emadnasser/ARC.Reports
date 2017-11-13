Namespace DevExpress.XtraNavBar.Demos
	Partial Public Class frmNavBarProperties
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(frmNavBarProperties))
			Me.pnlProperties = New DevExpress.XtraEditors.PanelControl()
			Me.xtcMain = New DevExpress.XtraTab.XtraTabControl()
			Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
			Me.cbScrollStyle = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.cbStyles = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
			Me.chbAllowDrag = New DevExpress.XtraEditors.CheckEdit()
			Me.chbAllowSelectedLink = New DevExpress.XtraEditors.CheckEdit()
			Me.chbAllowOuterDrop = New DevExpress.XtraEditors.CheckEdit()
			Me.chbAllowDrop = New DevExpress.XtraEditors.CheckEdit()
			Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
			Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
			Me.Groups = New DevExpress.XtraEditors.ListBoxControl()
			Me.propertyGridControl1 = New DevExpress.XtraVerticalGrid.PropertyGridControl()
			Me.repositoryItemColorEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemColorEdit()
			Me.repositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
			Me.persistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository(Me.components)
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.btnAddGroup = New DevExpress.XtraEditors.SimpleButton()
			Me.btnRemoveGroup = New DevExpress.XtraEditors.SimpleButton()
			Me.xtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
			Me.splitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl()
			Me.Items = New DevExpress.XtraEditors.ListBoxControl()
			Me.propertyGridControl2 = New DevExpress.XtraVerticalGrid.PropertyGridControl()
			Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
			Me.btnAddItem = New DevExpress.XtraEditors.SimpleButton()
			Me.btnRemoveItem = New DevExpress.XtraEditors.SimpleButton()
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.lbClick = New DevExpress.XtraEditors.LabelControl()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.navBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
			Me.navBarGroup4 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarItem4 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem3 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarItem1 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem2 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarGroup2 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarItem6 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem5 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem7 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarGroup3 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.imageList1 = New ImageList(Me.components)
			Me.imageList2 = New ImageList(Me.components)
			Me.timer1 = New Timer(Me.components)
			Me.pmGroup = New DevExpress.XtraBars.PopupMenu(Me.components)
			Me.biRemoveGroup = New DevExpress.XtraBars.BarButtonItem()
			Me.biAddNewGroup = New DevExpress.XtraBars.BarButtonItem()
			Me.bsiItems = New DevExpress.XtraBars.BarSubItem()
			Me.lcItems = New DevExpress.XtraBars.BarLinkContainerItem()
			Me.biGroupProperties = New DevExpress.XtraBars.BarButtonItem()
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.biDeleteLink = New DevExpress.XtraBars.BarButtonItem()
			Me.biLinkProperties = New DevExpress.XtraBars.BarButtonItem()
			Me.pmItem = New DevExpress.XtraBars.PopupMenu(Me.components)
			CType(Me.contentPanel_Renamed, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.contentPanel_Renamed.SuspendLayout()
			CType(Me.pnlProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlProperties.SuspendLayout()
			CType(Me.xtcMain, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtcMain.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			CType(Me.cbScrollStyle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbStyles.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chbAllowDrag.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chbAllowSelectedLink.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chbAllowOuterDrop.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chbAllowDrop.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabPage2.SuspendLayout()
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainerControl1.SuspendLayout()
			CType(Me.Groups, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.propertyGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemColorEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			Me.xtraTabPage3.SuspendLayout()
			CType(Me.splitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainerControl2.SuspendLayout()
			CType(Me.Items, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.propertyGridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl2.SuspendLayout()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pmGroup, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pmItem, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' contentPanel
			' 
			Me.contentPanel_Renamed.Controls.Add(Me.navBarControl1)
			Me.contentPanel_Renamed.Controls.Add(Me.pnlProperties)
			Me.contentPanel_Renamed.Controls.Add(Me.barDockControlLeft)
			Me.contentPanel_Renamed.Controls.Add(Me.barDockControlRight)
			Me.contentPanel_Renamed.Controls.Add(Me.barDockControlBottom)
			Me.contentPanel_Renamed.Controls.Add(Me.barDockControlTop)
			Me.contentPanel_Renamed.Margin = New Padding(2)
			Me.contentPanel_Renamed.Padding = New Padding(3)
			Me.contentPanel_Renamed.Size = New Size(724, 480)
			' 
			' pnlProperties
			' 
			Me.pnlProperties.Controls.Add(Me.xtcMain)
			Me.pnlProperties.Controls.Add(Me.groupControl1)
			Me.pnlProperties.Location = New Point(170, 9)
			Me.pnlProperties.Name = "pnlProperties"
			Me.pnlProperties.Padding = New Padding(8)
			Me.pnlProperties.Size = New Size(548, 460)
			Me.pnlProperties.TabIndex = 1
			' 
			' xtcMain
			' 
			Me.xtcMain.Location = New Point(8, 86)
			Me.xtcMain.Name = "xtcMain"
			Me.xtcMain.SelectedTabPage = Me.xtraTabPage1
			Me.xtcMain.Size = New Size(536, 370)
			Me.xtcMain.TabIndex = 9
			Me.xtcMain.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1, Me.xtraTabPage2, Me.xtraTabPage3})
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Controls.Add(Me.cbScrollStyle)
			Me.xtraTabPage1.Controls.Add(Me.labelControl4)
			Me.xtraTabPage1.Controls.Add(Me.labelControl3)
			Me.xtraTabPage1.Controls.Add(Me.labelControl2)
			Me.xtraTabPage1.Controls.Add(Me.labelControl1)
			Me.xtraTabPage1.Controls.Add(Me.cbStyles)
			Me.xtraTabPage1.Controls.Add(Me.chbAllowDrag)
			Me.xtraTabPage1.Controls.Add(Me.chbAllowSelectedLink)
			Me.xtraTabPage1.Controls.Add(Me.chbAllowOuterDrop)
			Me.xtraTabPage1.Controls.Add(Me.chbAllowDrop)
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Size = New Size(530, 342)
			Me.xtraTabPage1.Text = "General"
			' 
			' cbScrollStyle
			' 
			Me.cbScrollStyle.Location = New Point(216, 70)
			Me.cbScrollStyle.Name = "cbScrollStyle"
			Me.cbScrollStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbScrollStyle.Size = New Size(112, 20)
			Me.cbScrollStyle.TabIndex = 1
'			Me.cbScrollStyle.SelectedIndexChanged += New System.EventHandler(Me.cbScrollStyle_SelectedIndexChanged)
			' 
			' labelControl4
			' 
			Me.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
			Me.labelControl4.Location = New Point(16, 72)
			Me.labelControl4.Name = "labelControl4"
			Me.labelControl4.Size = New Size(165, 13)
			Me.labelControl4.TabIndex = 9
			Me.labelControl4.Text = "Skin Explorer Bar View Scroll Style:"
			' 
			' labelControl3
			' 
			Me.labelControl3.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.labelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
			Me.labelControl3.LineLocation = DevExpress.XtraEditors.LineLocation.Center
			Me.labelControl3.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal
			Me.labelControl3.LineVisible = True
			Me.labelControl3.Location = New Point(16, 216)
			Me.labelControl3.Name = "labelControl3"
			Me.labelControl3.Size = New Size(27, 13)
			Me.labelControl3.TabIndex = 8
			Me.labelControl3.Text = "Views"
			' 
			' labelControl2
			' 
			Me.labelControl2.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.labelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
			Me.labelControl2.LineLocation = DevExpress.XtraEditors.LineLocation.Center
			Me.labelControl2.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal
			Me.labelControl2.LineVisible = True
			Me.labelControl2.Location = New Point(16, 112)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New Size(81, 13)
			Me.labelControl2.TabIndex = 7
			Me.labelControl2.Text = "Drag&&Drop Flags"
			' 
			' labelControl1
			' 
			Me.labelControl1.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
			Me.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Center
			Me.labelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal
			Me.labelControl1.LineVisible = True
			Me.labelControl1.Location = New Point(16, 8)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New Size(89, 13)
			Me.labelControl1.TabIndex = 6
			Me.labelControl1.Text = "General Properties"
			' 
			' cbStyles
			' 
			Me.cbStyles.Location = New Point(24, 248)
			Me.cbStyles.Name = "cbStyles"
			Me.cbStyles.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbStyles.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbStyles.Size = New Size(208, 20)
			Me.cbStyles.TabIndex = 5
			Me.cbStyles.ToolTip = "Select a style - the result can be viewed via the NavBar Control."
			Me.cbStyles.ToolTipController = Me.toolTipController1
'			Me.cbStyles.SelectedIndexChanged += New System.EventHandler(Me.cbStyles_SelectedIndexChanged)
			' 
			' toolTipController1
			' 
			Me.toolTipController1.Rounded = True
			Me.toolTipController1.ShowBeak = True
			' 
			' chbAllowDrag
			' 
			Me.chbAllowDrag.Location = New Point(16, 144)
			Me.chbAllowDrag.Name = "chbAllowDrag"
			Me.chbAllowDrag.Properties.Caption = "Allow Drag"
			Me.chbAllowDrag.Size = New Size(164, 19)
			Me.chbAllowDrag.TabIndex = 2
'			Me.chbAllowDrag.CheckedChanged += New System.EventHandler(Me.chbAllowDrag_CheckedChanged)
			' 
			' chbAllowSelectedLink
			' 
			Me.chbAllowSelectedLink.Location = New Point(16, 40)
			Me.chbAllowSelectedLink.Name = "chbAllowSelectedLink"
			Me.chbAllowSelectedLink.Properties.Caption = "Allow Selected Link"
			Me.chbAllowSelectedLink.Size = New Size(164, 19)
			Me.chbAllowSelectedLink.TabIndex = 0
'			Me.chbAllowSelectedLink.CheckedChanged += New System.EventHandler(Me.chbAllowSelectedLink_CheckedChanged)
			' 
			' chbAllowOuterDrop
			' 
			Me.chbAllowOuterDrop.Location = New Point(16, 192)
			Me.chbAllowOuterDrop.Name = "chbAllowOuterDrop"
			Me.chbAllowOuterDrop.Properties.Caption = "Allow Outer Drop"
			Me.chbAllowOuterDrop.Size = New Size(164, 19)
			Me.chbAllowOuterDrop.TabIndex = 4
'			Me.chbAllowOuterDrop.CheckedChanged += New System.EventHandler(Me.chbAllowOuterDrop_CheckedChanged)
			' 
			' chbAllowDrop
			' 
			Me.chbAllowDrop.Location = New Point(16, 168)
			Me.chbAllowDrop.Name = "chbAllowDrop"
			Me.chbAllowDrop.Properties.Caption = "Allow Drop"
			Me.chbAllowDrop.Size = New Size(164, 19)
			Me.chbAllowDrop.TabIndex = 3
'			Me.chbAllowDrop.CheckedChanged += New System.EventHandler(Me.chbAllowDrop_CheckedChanged)
			' 
			' xtraTabPage2
			' 
			Me.xtraTabPage2.Controls.Add(Me.splitContainerControl1)
			Me.xtraTabPage2.Controls.Add(Me.panelControl1)
			Me.xtraTabPage2.Name = "xtraTabPage2"
			Me.xtraTabPage2.Size = New Size(530, 342)
			Me.xtraTabPage2.Text = "Groups"
			' 
			' splitContainerControl1
			' 
			Me.splitContainerControl1.Location = New Point(0, 40)
			Me.splitContainerControl1.Name = "splitContainerControl1"
			Me.splitContainerControl1.Panel1.Controls.Add(Me.Groups)
			Me.splitContainerControl1.Panel1.Padding = New Padding(5)
			Me.splitContainerControl1.Panel1.Text = "splitContainerControl1_Panel1"
			Me.splitContainerControl1.Panel2.Controls.Add(Me.propertyGridControl1)
			Me.splitContainerControl1.Panel2.Padding = New Padding(5)
			Me.splitContainerControl1.Panel2.Text = "splitContainerControl1_Panel2"
			Me.splitContainerControl1.Size = New Size(532, 302)
			Me.splitContainerControl1.SplitterPosition = 170
			Me.splitContainerControl1.TabIndex = 1
			Me.splitContainerControl1.Text = "splitContainerControl1"
			' 
			' Groups
			' 
			Me.Groups.Location = New Point(5, 5)
			Me.Groups.Name = "Groups"
			Me.Groups.Size = New Size(117, 291)
			Me.Groups.TabIndex = 2
'			Me.Groups.SelectedIndexChanged += New System.EventHandler(Me.Groups_SelectedIndexChanged)
			' 
			' propertyGridControl1
			' 
			Me.propertyGridControl1.DefaultEditors.AddRange(New DevExpress.XtraVerticalGrid.Rows.DefaultEditor() { New DevExpress.XtraVerticalGrid.Rows.DefaultEditor(GetType(Color), Me.repositoryItemColorEdit1), New DevExpress.XtraVerticalGrid.Rows.DefaultEditor(GetType(Boolean), Me.repositoryItemCheckEdit1)})
			Me.propertyGridControl1.ExternalRepository = Me.persistentRepository1
			Me.propertyGridControl1.Location = New Point(5, 5)
			Me.propertyGridControl1.Name = "propertyGridControl1"
			Me.propertyGridControl1.OptionsView.ShowRootCategories = False
			Me.propertyGridControl1.Size = New Size(390, 291)
			Me.propertyGridControl1.TabIndex = 3
			' 
			' repositoryItemColorEdit1
			' 
			Me.repositoryItemColorEdit1.AutoHeight = False
			Me.repositoryItemColorEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemColorEdit1.Name = "repositoryItemColorEdit1"
			Me.repositoryItemColorEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
			' 
			' repositoryItemCheckEdit1
			' 
			Me.repositoryItemCheckEdit1.AutoHeight = False
			Me.repositoryItemCheckEdit1.Caption = "Check"
			Me.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1"
			' 
			' persistentRepository1
			' 
			Me.persistentRepository1.Items.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemCheckEdit1, Me.repositoryItemColorEdit1})
			' 
			' panelControl1
			' 
			Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl1.Controls.Add(Me.btnAddGroup)
			Me.panelControl1.Controls.Add(Me.btnRemoveGroup)
			Me.panelControl1.Location = New Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New Size(532, 40)
			Me.panelControl1.TabIndex = 0
			' 
			' btnAddGroup
			' 
			Me.btnAddGroup.Location = New Point(8, 8)
			Me.btnAddGroup.Name = "btnAddGroup"
			Me.btnAddGroup.Size = New Size(112, 24)
			Me.btnAddGroup.TabIndex = 0
			Me.btnAddGroup.Text = "Add Group"
'			Me.btnAddGroup.Click += New System.EventHandler(Me.btnAddGroup_Click)
			' 
			' btnRemoveGroup
			' 
			Me.btnRemoveGroup.Location = New Point(128, 8)
			Me.btnRemoveGroup.Name = "btnRemoveGroup"
			Me.btnRemoveGroup.Size = New Size(112, 24)
			Me.btnRemoveGroup.TabIndex = 1
			Me.btnRemoveGroup.Text = "Remove Group"
'			Me.btnRemoveGroup.Click += New System.EventHandler(Me.btnRemoveGroup_Click)
			' 
			' xtraTabPage3
			' 
			Me.xtraTabPage3.Controls.Add(Me.splitContainerControl2)
			Me.xtraTabPage3.Controls.Add(Me.panelControl2)
			Me.xtraTabPage3.Name = "xtraTabPage3"
			Me.xtraTabPage3.Size = New Size(530, 342)
			Me.xtraTabPage3.Text = "Items"
			' 
			' splitContainerControl2
			' 
			Me.splitContainerControl2.Location = New Point(0, 40)
			Me.splitContainerControl2.Name = "splitContainerControl2"
			Me.splitContainerControl2.Panel1.Controls.Add(Me.Items)
			Me.splitContainerControl2.Panel1.Padding = New Padding(5)
			Me.splitContainerControl2.Panel1.Text = "splitContainerControl2_Panel1"
			Me.splitContainerControl2.Panel2.Controls.Add(Me.propertyGridControl2)
			Me.splitContainerControl2.Panel2.Padding = New Padding(5)
			Me.splitContainerControl2.Panel2.Text = "splitContainerControl2_Panel2"
			Me.splitContainerControl2.Size = New Size(532, 302)
			Me.splitContainerControl2.SplitterPosition = 162
			Me.splitContainerControl2.TabIndex = 2
			Me.splitContainerControl2.Text = "splitContainerControl2"
			' 
			' Items
			' 
			Me.Items.Location = New Point(5, 5)
			Me.Items.Name = "Items"
			Me.Items.Size = New Size(111, 291)
			Me.Items.TabIndex = 4
'			Me.Items.SelectedIndexChanged += New System.EventHandler(Me.Items_SelectedIndexChanged)
			' 
			' propertyGridControl2
			' 
			Me.propertyGridControl2.DefaultEditors.AddRange(New DevExpress.XtraVerticalGrid.Rows.DefaultEditor() { New DevExpress.XtraVerticalGrid.Rows.DefaultEditor(GetType(Color), Me.repositoryItemColorEdit1), New DevExpress.XtraVerticalGrid.Rows.DefaultEditor(GetType(Boolean), Me.repositoryItemCheckEdit1)})
			Me.propertyGridControl2.ExternalRepository = Me.persistentRepository1
			Me.propertyGridControl2.Location = New Point(5, 5)
			Me.propertyGridControl2.Name = "propertyGridControl2"
			Me.propertyGridControl2.OptionsView.ShowRootCategories = False
			Me.propertyGridControl2.Size = New Size(396, 291)
			Me.propertyGridControl2.TabIndex = 4
			' 
			' panelControl2
			' 
			Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl2.Controls.Add(Me.btnAddItem)
			Me.panelControl2.Controls.Add(Me.btnRemoveItem)
			Me.panelControl2.Location = New Point(0, 0)
			Me.panelControl2.Name = "panelControl2"
			Me.panelControl2.Size = New Size(532, 40)
			Me.panelControl2.TabIndex = 1
			' 
			' btnAddItem
			' 
			Me.btnAddItem.Location = New Point(8, 8)
			Me.btnAddItem.Name = "btnAddItem"
			Me.btnAddItem.Size = New Size(112, 24)
			Me.btnAddItem.TabIndex = 0
			Me.btnAddItem.Text = "Add Item"
'			Me.btnAddItem.Click += New System.EventHandler(Me.btnAddItem_Click)
			' 
			' btnRemoveItem
			' 
			Me.btnRemoveItem.Location = New Point(128, 8)
			Me.btnRemoveItem.Name = "btnRemoveItem"
			Me.btnRemoveItem.Size = New Size(112, 24)
			Me.btnRemoveItem.TabIndex = 1
			Me.btnRemoveItem.Text = "Remove Item"
'			Me.btnRemoveItem.Click += New System.EventHandler(Me.btnRemoveItem_Click)
			' 
			' groupControl1
			' 
			Me.groupControl1.Controls.Add(Me.lbClick)
			Me.groupControl1.Location = New Point(8, 8)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Padding = New Padding(10)
			Me.groupControl1.Size = New Size(536, 64)
			Me.groupControl1.TabIndex = 10
			Me.groupControl1.Text = "Hit Test && Link Clicked Info"
			' 
			' lbClick
			' 
			Me.lbClick.Appearance.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
			Me.lbClick.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.lbClick.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
			Me.lbClick.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.lbClick.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
			Me.lbClick.Location = New Point(11, 28)
			Me.lbClick.Name = "lbClick"
			Me.lbClick.Size = New Size(514, 24)
			Me.lbClick.TabIndex = 0
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.CausesValidation = False
			Me.barDockControlTop.Dock = DockStyle.Top
			Me.barDockControlTop.Location = New Point(5, 5)
			Me.barDockControlTop.Size = New Size(714, 0)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.CausesValidation = False
			Me.barDockControlBottom.Dock = DockStyle.Bottom
			Me.barDockControlBottom.Location = New Point(5, 475)
			Me.barDockControlBottom.Size = New Size(714, 0)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.CausesValidation = False
			Me.barDockControlLeft.Dock = DockStyle.Left
			Me.barDockControlLeft.Location = New Point(5, 5)
			Me.barDockControlLeft.Size = New Size(0, 470)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.CausesValidation = False
			Me.barDockControlRight.Dock = DockStyle.Right
			Me.barDockControlRight.Location = New Point(719, 5)
			Me.barDockControlRight.Size = New Size(0, 470)
			' 
			' navBarControl1
			' 
			Me.navBarControl1.ActiveGroup = Me.navBarGroup4
			Me.navBarControl1.ContentButtonHint = Nothing
			Me.navBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() { Me.navBarGroup1, Me.navBarGroup2, Me.navBarGroup3, Me.navBarGroup4})
			Me.navBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() { Me.navBarItem1, Me.navBarItem2, Me.navBarItem3, Me.navBarItem4, Me.navBarItem5, Me.navBarItem6, Me.navBarItem7})
			Me.navBarControl1.LargeImages = Me.imageList1
			Me.navBarControl1.Location = New Point(8, 0)
			Me.navBarControl1.Name = "navBarControl1"
			Me.navBarControl1.OptionsNavPane.ExpandedWidth = 134
			Me.navBarControl1.Size = New Size(134, 481)
			Me.navBarControl1.SmallImages = Me.imageList2
			Me.navBarControl1.StoreDefaultPaintStyleName = True
			Me.navBarControl1.TabIndex = 30
'			Me.navBarControl1.LinkClicked += New DevExpress.XtraNavBar.NavBarLinkEventHandler(Me.navBarControl1_LinkClicked)
'			Me.navBarControl1.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.navBarControl1_MouseDown)
'			Me.navBarControl1.MouseLeave += New System.EventHandler(Me.navBarControl1_MouseLeave)
'			Me.navBarControl1.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.navBarControl1_MouseMove)
			' 
			' navBarGroup4
			' 
			Me.navBarGroup4.Caption = "Temp"
			Me.navBarGroup4.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem4), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem3)})
			Me.navBarGroup4.Name = "navBarGroup4"
			' 
			' navBarItem4
			' 
			Me.navBarItem4.Appearance.Font = New Font("Tahoma", 8.25F, FontStyle.Strikeout, GraphicsUnit.Point, (CByte(204)))
			Me.navBarItem4.Appearance.Options.UseFont = True
			Me.navBarItem4.Caption = "Deleted Items"
			Me.navBarItem4.Enabled = False
			Me.navBarItem4.LargeImageIndex = 3
			Me.navBarItem4.Name = "navBarItem4"
			Me.navBarItem4.SmallImageIndex = 3
			' 
			' navBarItem3
			' 
			Me.navBarItem3.Caption = "Sent Items"
			Me.navBarItem3.Enabled = False
			Me.navBarItem3.LargeImageIndex = 2
			Me.navBarItem3.Name = "navBarItem3"
			Me.navBarItem3.SmallImageIndex = 2
			' 
			' navBarGroup1
			' 
			Me.navBarGroup1.Caption = "Local"
			Me.navBarGroup1.Expanded = True
			Me.navBarGroup1.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
			Me.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText
			Me.navBarGroup1.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem1), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem2), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem3)})
			Me.navBarGroup1.LargeImageIndex = 5
			Me.navBarGroup1.Name = "navBarGroup1"
			Me.navBarGroup1.SmallImageIndex = 5
			' 
			' navBarItem1
			' 
			Me.navBarItem1.Appearance.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
			Me.navBarItem1.Appearance.Options.UseFont = True
			Me.navBarItem1.AppearanceDisabled.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
			Me.navBarItem1.AppearanceDisabled.Options.UseFont = True
			Me.navBarItem1.AppearanceHotTracked.Font = New Font("Tahoma", 8.25F, (CType((FontStyle.Bold Or FontStyle.Underline), FontStyle)), GraphicsUnit.Point, (CByte(204)))
			Me.navBarItem1.AppearanceHotTracked.Options.UseFont = True
			Me.navBarItem1.AppearancePressed.Font = New Font("Tahoma", 8.25F, (CType((FontStyle.Bold Or FontStyle.Underline), FontStyle)), GraphicsUnit.Point, (CByte(204)))
			Me.navBarItem1.AppearancePressed.Options.UseFont = True
			Me.navBarItem1.Caption = "Inbox"
			Me.navBarItem1.LargeImageIndex = 0
			Me.navBarItem1.Name = "navBarItem1"
			Me.navBarItem1.SmallImageIndex = 0
			' 
			' navBarItem2
			' 
			Me.navBarItem2.Caption = "Outbox"
			Me.navBarItem2.LargeImageIndex = 1
			Me.navBarItem2.Name = "navBarItem2"
			Me.navBarItem2.SmallImageIndex = 1
			' 
			' navBarGroup2
			' 
			Me.navBarGroup2.Caption = "Contacts"
			Me.navBarGroup2.Expanded = True
			Me.navBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText
			Me.navBarGroup2.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem6), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem5), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem7)})
			Me.navBarGroup2.LargeImageIndex = 6
			Me.navBarGroup2.Name = "navBarGroup2"
			Me.navBarGroup2.SmallImageIndex = 6
			' 
			' navBarItem6
			' 
			Me.navBarItem6.Caption = "Calendar"
			Me.navBarItem6.LargeImageIndex = 7
			Me.navBarItem6.Name = "navBarItem6"
			Me.navBarItem6.SmallImageIndex = 7
			' 
			' navBarItem5
			' 
			Me.navBarItem5.Caption = "Report"
			Me.navBarItem5.LargeImageIndex = 4
			Me.navBarItem5.Name = "navBarItem5"
			Me.navBarItem5.SmallImageIndex = 4
			' 
			' navBarItem7
			' 
			Me.navBarItem7.Appearance.Font = New Font("Tahoma", 8.25F, FontStyle.Italic, GraphicsUnit.Point, (CByte(204)))
			Me.navBarItem7.Appearance.ForeColor = Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(192)))))
			Me.navBarItem7.Appearance.Options.UseFont = True
			Me.navBarItem7.Appearance.Options.UseForeColor = True
			Me.navBarItem7.AppearanceDisabled.Font = New Font("Tahoma", 8.25F, FontStyle.Italic, GraphicsUnit.Point, (CByte(204)))
			Me.navBarItem7.AppearanceDisabled.Options.UseFont = True
			Me.navBarItem7.AppearanceHotTracked.Font = New Font("Tahoma", 8.25F, (CType((FontStyle.Italic Or FontStyle.Underline), FontStyle)), GraphicsUnit.Point, (CByte(204)))
			Me.navBarItem7.AppearanceHotTracked.Options.UseFont = True
			Me.navBarItem7.AppearancePressed.Font = New Font("Tahoma", 8.25F, (CType((FontStyle.Italic Or FontStyle.Underline), FontStyle)), GraphicsUnit.Point, (CByte(204)))
			Me.navBarItem7.AppearancePressed.Options.UseFont = True
			Me.navBarItem7.Caption = "Task"
			Me.navBarItem7.LargeImageIndex = 8
			Me.navBarItem7.Name = "navBarItem7"
			Me.navBarItem7.SmallImageIndex = 8
			' 
			' navBarGroup3
			' 
			Me.navBarGroup3.Caption = "Deleted"
			Me.navBarGroup3.Expanded = True
			Me.navBarGroup3.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
			Me.navBarGroup3.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem5), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem4)})
			Me.navBarGroup3.LargeImageIndex = 3
			Me.navBarGroup3.Name = "navBarGroup3"
			Me.navBarGroup3.SmallImageIndex = 3
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), ImageListStreamer))
			Me.imageList1.TransparentColor = Color.Magenta
			Me.imageList1.Images.SetKeyName(0, "")
			Me.imageList1.Images.SetKeyName(1, "")
			Me.imageList1.Images.SetKeyName(2, "")
			Me.imageList1.Images.SetKeyName(3, "")
			Me.imageList1.Images.SetKeyName(4, "")
			Me.imageList1.Images.SetKeyName(5, "")
			Me.imageList1.Images.SetKeyName(6, "")
			Me.imageList1.Images.SetKeyName(7, "")
			Me.imageList1.Images.SetKeyName(8, "")
			' 
			' imageList2
			' 
			Me.imageList2.ImageStream = (CType(resources.GetObject("imageList2.ImageStream"), ImageListStreamer))
			Me.imageList2.TransparentColor = Color.Magenta
			Me.imageList2.Images.SetKeyName(0, "")
			Me.imageList2.Images.SetKeyName(1, "")
			Me.imageList2.Images.SetKeyName(2, "")
			Me.imageList2.Images.SetKeyName(3, "")
			Me.imageList2.Images.SetKeyName(4, "")
			Me.imageList2.Images.SetKeyName(5, "")
			Me.imageList2.Images.SetKeyName(6, "")
			Me.imageList2.Images.SetKeyName(7, "")
			Me.imageList2.Images.SetKeyName(8, "")
			' 
			' timer1
			' 
			Me.timer1.Interval = 1000
'			Me.timer1.Tick += New System.EventHandler(Me.timer1_Tick)
			' 
			' pmGroup
			' 
			Me.pmGroup.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.biRemoveGroup), New DevExpress.XtraBars.LinkPersistInfo(Me.biAddNewGroup), New DevExpress.XtraBars.LinkPersistInfo(Me.bsiItems), New DevExpress.XtraBars.LinkPersistInfo(Me.biGroupProperties, True)})
			Me.pmGroup.Manager = Me.barManager1
			Me.pmGroup.Name = "pmGroup"
'			Me.pmGroup.BeforePopup += New System.ComponentModel.CancelEventHandler(Me.pmGroup_BeforePopup)
			' 
			' biRemoveGroup
			' 
			Me.biRemoveGroup.Caption = "Remove Group"
			Me.biRemoveGroup.Id = 3
			Me.biRemoveGroup.Name = "biRemoveGroup"
'			Me.biRemoveGroup.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.biRemoveGroup_ItemClick)
			' 
			' biAddNewGroup
			' 
			Me.biAddNewGroup.Caption = "Add New Group"
			Me.biAddNewGroup.Id = 2
			Me.biAddNewGroup.Name = "biAddNewGroup"
'			Me.biAddNewGroup.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.biAddNewGroup_ItemClick)
			' 
			' bsiItems
			' 
			Me.bsiItems.Caption = "Add New Link"
			Me.bsiItems.Id = 6
			Me.bsiItems.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.lcItems)})
			Me.bsiItems.Name = "bsiItems"
			' 
			' lcItems
			' 
			Me.lcItems.Caption = "Add New Link"
			Me.lcItems.Id = 5
			Me.lcItems.Name = "lcItems"
			' 
			' biGroupProperties
			' 
			Me.biGroupProperties.Caption = "Properties"
			Me.biGroupProperties.Id = 4
			Me.biGroupProperties.Name = "biGroupProperties"
'			Me.biGroupProperties.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.biGroupProperties_ItemClick)
			' 
			' barManager1
			' 
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.biDeleteLink, Me.biLinkProperties, Me.biAddNewGroup, Me.biRemoveGroup, Me.biGroupProperties, Me.lcItems, Me.bsiItems})
			Me.barManager1.MaxItemId = 7
			' 
			' biDeleteLink
			' 
			Me.biDeleteLink.Caption = "Delete Link"
			Me.biDeleteLink.Id = 0
			Me.biDeleteLink.Name = "biDeleteLink"
'			Me.biDeleteLink.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.biDeleteLink_ItemClick)
			' 
			' biLinkProperties
			' 
			Me.biLinkProperties.Caption = "Properties"
			Me.biLinkProperties.Id = 1
			Me.biLinkProperties.Name = "biLinkProperties"
'			Me.biLinkProperties.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.biLinkProperties_ItemClick)
			' 
			' pmItem
			' 
			Me.pmItem.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.biDeleteLink), New DevExpress.XtraBars.LinkPersistInfo(Me.biLinkProperties, True)})
			Me.pmItem.Manager = Me.barManager1
			Me.pmItem.Name = "pmItem"
			' 
			' frmNavBarProperties
			' 
			Me.Appearance.Options.UseFont = True
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Name = "frmNavBarProperties"
			Me.Size = New Size(724, 480)
			CType(Me.contentPanel_Renamed, System.ComponentModel.ISupportInitialize).EndInit()
			Me.contentPanel_Renamed.ResumeLayout(False)
			CType(Me.pnlProperties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlProperties.ResumeLayout(False)
			CType(Me.xtcMain, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtcMain.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			Me.xtraTabPage1.PerformLayout()
			CType(Me.cbScrollStyle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbStyles.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chbAllowDrag.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chbAllowSelectedLink.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chbAllowOuterDrop.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chbAllowDrop.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabPage2.ResumeLayout(False)
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainerControl1.ResumeLayout(False)
			CType(Me.Groups, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.propertyGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemColorEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.xtraTabPage3.ResumeLayout(False)
			CType(Me.splitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainerControl2.ResumeLayout(False)
			CType(Me.Items, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.propertyGridControl2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl2.ResumeLayout(False)
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pmGroup, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pmItem, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private pnlProperties As DevExpress.XtraEditors.PanelControl
		Private WithEvents cbStyles As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents Groups As DevExpress.XtraEditors.ListBoxControl
		Private WithEvents Items As DevExpress.XtraEditors.ListBoxControl
		Private WithEvents btnAddGroup As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnRemoveGroup As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnRemoveItem As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnAddItem As DevExpress.XtraEditors.SimpleButton
		Private WithEvents timer1 As Timer
		Private WithEvents chbAllowDrag As DevExpress.XtraEditors.CheckEdit
		Private WithEvents chbAllowDrop As DevExpress.XtraEditors.CheckEdit
		Private WithEvents chbAllowOuterDrop As DevExpress.XtraEditors.CheckEdit
		Private WithEvents chbAllowSelectedLink As DevExpress.XtraEditors.CheckEdit
		Private WithEvents navBarControl1 As DevExpress.XtraNavBar.NavBarControl
		Private navBarGroup3 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarItem5 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem4 As DevExpress.XtraNavBar.NavBarItem
		Private navBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarItem1 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem2 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem3 As DevExpress.XtraNavBar.NavBarItem
		Private navBarGroup2 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarItem6 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem7 As DevExpress.XtraNavBar.NavBarItem
		Private imageList1 As ImageList
		Private imageList2 As ImageList
		Private propertyGridControl1 As DevExpress.XtraVerticalGrid.PropertyGridControl
		Private xtcMain As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private xtraTabPage2 As DevExpress.XtraTab.XtraTabPage
		Private xtraTabPage3 As DevExpress.XtraTab.XtraTabPage
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private panelControl2 As DevExpress.XtraEditors.PanelControl
		Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
		Private splitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
		Private propertyGridControl2 As DevExpress.XtraVerticalGrid.PropertyGridControl
		Private toolTipController1 As DevExpress.Utils.ToolTipController
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private lbClick As DevExpress.XtraEditors.LabelControl
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private labelControl3 As DevExpress.XtraEditors.LabelControl
		Private labelControl4 As DevExpress.XtraEditors.LabelControl
		Private WithEvents cbScrollStyle As DevExpress.XtraEditors.ImageComboBoxEdit
		Private navBarGroup4 As DevExpress.XtraNavBar.NavBarGroup
		Private WithEvents pmGroup As DevExpress.XtraBars.PopupMenu
		Private pmItem As DevExpress.XtraBars.PopupMenu
		Private barManager1 As DevExpress.XtraBars.BarManager
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private WithEvents biDeleteLink As DevExpress.XtraBars.BarButtonItem
		Private WithEvents biLinkProperties As DevExpress.XtraBars.BarButtonItem
		Private WithEvents biAddNewGroup As DevExpress.XtraBars.BarButtonItem
		Private WithEvents biRemoveGroup As DevExpress.XtraBars.BarButtonItem
		Private WithEvents biGroupProperties As DevExpress.XtraBars.BarButtonItem
		Private persistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
		Private repositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
		Private repositoryItemColorEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemColorEdit
		Private lcItems As DevExpress.XtraBars.BarLinkContainerItem
		Private bsiItems As DevExpress.XtraBars.BarSubItem
		Private components As System.ComponentModel.IContainer

	End Class
End Namespace

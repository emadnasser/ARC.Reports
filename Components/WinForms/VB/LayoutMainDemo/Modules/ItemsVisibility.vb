Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.XtraLayout.Utils
Imports DevExpress.Utils

Namespace DevExpress.XtraLayout.Demos
    Partial Public Class ItemsVisibility
        Inherits TutorialControl

        Private WithEvents layoutControl1 As LayoutControl
        Private WithEvents showDesc As DevExpress.XtraEditors.CheckEdit
        Private WithEvents showP1 As DevExpress.XtraEditors.CheckEdit
        Private pictureEdit2 As DevExpress.XtraEditors.PictureEdit
        Private pictureEdit1 As DevExpress.XtraEditors.PictureEdit
        Private memoEdit1 As DevExpress.XtraEditors.MemoEdit
        Private layoutControlGroup1 As LayoutControlGroup
        Private WithEvents showP2 As DevExpress.XtraEditors.CheckEdit
        Private splitterItem2 As SplitterItem
        Private descriptionItem As LayoutControlItem
        Private picture2Item As LayoutControlItem
        Private splitterItem1 As SplitterItem
        Private picture1Item As LayoutControlItem
        Private lcTitle As LayoutControl
        Private lcMainGroup As LayoutControlGroup
        Private layoutControlItem1 As LayoutControlItem
        Private layoutControlItem2 As LayoutControlItem
        Private layoutControlItem3 As LayoutControlItem
        Private layoutControlItem4 As LayoutControlItem
        Private panelControl1 As XtraEditors.PanelControl
        Private navigationPane1 As XtraBars.Navigation.NavigationPane
        Private navigationPage1 As XtraBars.Navigation.NavigationPage
        Private WithEvents ceVerticalIsCollapsible As XtraEditors.CheckEdit
        Private WithEvents ceVerticalIsCollapsed As XtraEditors.CheckEdit
        Private WithEvents ceVerticalInverted As XtraEditors.CheckEdit
        Private layoutControlGroupSplitterItem1 As LayoutControlGroup
        Private layoutControlItem5 As LayoutControlItem
        Private layoutControlItem6 As LayoutControlItem
        Private layoutControlItem7 As LayoutControlItem
        Private WithEvents ceHorizontalInverted As XtraEditors.CheckEdit
        Private WithEvents ceHorizontalIsCollapsed As XtraEditors.CheckEdit
        Private WithEvents ceHorizontalIsCollapsible As XtraEditors.CheckEdit
        Private layoutControlGroupSplitterItem2 As LayoutControlGroup
        Private layoutControlItem8 As LayoutControlItem
        Private layoutControlItem9 As LayoutControlItem
        Private layoutControlItem10 As LayoutControlItem
        Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
        Public Sub New()
            InitializeComponent()
            UpdateSplitterOptions()
        End Sub

        Private Sub UpdateSplitterOptions()
            ceVerticalInverted.Checked = splitterItem1.Inverted
            ceVerticalIsCollapsed.Checked = splitterItem1.IsCollapsed
            ceVerticalIsCollapsible.Checked = splitterItem1.IsCollapsible = DefaultBoolean.True
            ceHorizontalInverted.Checked = splitterItem2.Inverted
            ceHorizontalIsCollapsed.Checked = splitterItem2.IsCollapsed
            ceHorizontalIsCollapsible.Checked = splitterItem2.IsCollapsible = DefaultBoolean.True
        End Sub

        Private Sub InitializeComponent()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ItemsVisibility))
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.pictureEdit2 = New DevExpress.XtraEditors.PictureEdit()
            Me.pictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
            Me.memoEdit1 = New DevExpress.XtraEditors.MemoEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.splitterItem2 = New DevExpress.XtraLayout.SplitterItem()
            Me.descriptionItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.picture2Item = New DevExpress.XtraLayout.LayoutControlItem()
            Me.splitterItem1 = New DevExpress.XtraLayout.SplitterItem()
            Me.picture1Item = New DevExpress.XtraLayout.LayoutControlItem()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.lcTitle = New DevExpress.XtraLayout.LayoutControl()
            Me.ceVerticalIsCollapsible = New DevExpress.XtraEditors.CheckEdit()
            Me.ceVerticalIsCollapsed = New DevExpress.XtraEditors.CheckEdit()
            Me.ceVerticalInverted = New DevExpress.XtraEditors.CheckEdit()
            Me.showDesc = New DevExpress.XtraEditors.CheckEdit()
            Me.showP2 = New DevExpress.XtraEditors.CheckEdit()
            Me.showP1 = New DevExpress.XtraEditors.CheckEdit()
            Me.ceHorizontalInverted = New DevExpress.XtraEditors.CheckEdit()
            Me.ceHorizontalIsCollapsed = New DevExpress.XtraEditors.CheckEdit()
            Me.ceHorizontalIsCollapsible = New DevExpress.XtraEditors.CheckEdit()
            Me.lcMainGroup = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroupSplitterItem1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroupSplitterItem2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.navigationPane1 = New DevExpress.XtraBars.Navigation.NavigationPane()
            Me.navigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage()
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            DirectCast(Me.pictureEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.splitterItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.descriptionItem, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.picture2Item, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.splitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.picture1Item, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lcTitle, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.lcTitle.SuspendLayout()
            DirectCast(Me.ceVerticalIsCollapsible.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ceVerticalIsCollapsed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ceVerticalInverted.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.showDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.showP2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.showP1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ceHorizontalInverted.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ceHorizontalIsCollapsed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ceHorizontalIsCollapsible.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lcMainGroup, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroupSplitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroupSplitterItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.navigationPane1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPane1.SuspendLayout()
            Me.navigationPage1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.pictureEdit2)
            Me.layoutControl1.Controls.Add(Me.pictureEdit1)
            Me.layoutControl1.Controls.Add(Me.memoEdit1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(522, 505)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            '			Me.layoutControl1.Changed += New System.EventHandler(Me.layoutControl1_Changed)
            ' 
            ' pictureEdit2
            ' 
            Me.pictureEdit2.Cursor = System.Windows.Forms.Cursors.Default
            Me.pictureEdit2.EditValue = My.Resources.bc11
            Me.pictureEdit2.Location = New System.Drawing.Point(12, 12)
            Me.pictureEdit2.Name = "pictureEdit2"
            Me.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
            Me.pictureEdit2.Properties.ZoomAccelerationFactor = 1.0R
            Me.pictureEdit2.Size = New System.Drawing.Size(244, 275)
            Me.pictureEdit2.StyleController = Me.layoutControl1
            Me.pictureEdit2.TabIndex = 6
            ' 
            ' pictureEdit1
            ' 
            Me.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default
            Me.pictureEdit1.EditValue = My.Resources.bc12
            Me.pictureEdit1.Location = New System.Drawing.Point(265, 12)
            Me.pictureEdit1.Name = "pictureEdit1"
            Me.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
            Me.pictureEdit1.Properties.ZoomAccelerationFactor = 1.0R
            Me.pictureEdit1.Size = New System.Drawing.Size(245, 275)
            Me.pictureEdit1.StyleController = Me.layoutControl1
            Me.pictureEdit1.TabIndex = 5
            ' 
            ' memoEdit1
            ' 
            Me.memoEdit1.EditValue = resources.GetString("memoEdit1.EditValue")
            Me.memoEdit1.Location = New System.Drawing.Point(12, 312)
            Me.memoEdit1.Name = "memoEdit1"
            Me.memoEdit1.Size = New System.Drawing.Size(498, 181)
            Me.memoEdit1.StyleController = Me.layoutControl1
            Me.memoEdit1.TabIndex = 4
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.splitterItem2, Me.descriptionItem, Me.picture2Item, Me.splitterItem1, Me.picture1Item})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(522, 505)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' splitterItem2
            ' 
            Me.splitterItem2.AllowHotTrack = True
            Me.splitterItem2.CustomizationFormText = "splitterItem2"
            Me.splitterItem2.IsCollapsible = DevExpress.Utils.DefaultBoolean.True
            Me.splitterItem2.Location = New System.Drawing.Point(0, 279)
            Me.splitterItem2.Name = "splitterItem2"
            Me.splitterItem2.Size = New System.Drawing.Size(502, 5)
            ' 
            ' descriptionItem
            ' 
            Me.descriptionItem.Control = Me.memoEdit1
            Me.descriptionItem.CustomizationFormText = "layoutControlItem1"
            Me.descriptionItem.Location = New System.Drawing.Point(0, 284)
            Me.descriptionItem.Name = "descriptionItem"
            Me.descriptionItem.Size = New System.Drawing.Size(502, 201)
            Me.descriptionItem.Text = "Description"
            Me.descriptionItem.TextLocation = DevExpress.Utils.Locations.Top
            Me.descriptionItem.TextSize = New System.Drawing.Size(53, 13)
            ' 
            ' picture2Item
            ' 
            Me.picture2Item.Control = Me.pictureEdit1
            Me.picture2Item.CustomizationFormText = "layoutControlItem2"
            Me.picture2Item.Location = New System.Drawing.Point(253, 0)
            Me.picture2Item.Name = "picture2Item"
            Me.picture2Item.Size = New System.Drawing.Size(249, 279)
            Me.picture2Item.TextLocation = DevExpress.Utils.Locations.Left
            Me.picture2Item.TextSize = New System.Drawing.Size(0, 0)
            Me.picture2Item.TextVisible = False
            ' 
            ' splitterItem1
            ' 
            Me.splitterItem1.AllowHotTrack = True
            Me.splitterItem1.CustomizationFormText = "splitterItem1"
            Me.splitterItem1.IsCollapsible = DevExpress.Utils.DefaultBoolean.True
            Me.splitterItem1.Location = New System.Drawing.Point(248, 0)
            Me.splitterItem1.Name = "splitterItem1"
            Me.splitterItem1.Size = New System.Drawing.Size(5, 279)
            ' 
            ' picture1Item
            ' 
            Me.picture1Item.Control = Me.pictureEdit2
            Me.picture1Item.CustomizationFormText = "layoutControlItem3"
            Me.picture1Item.Location = New System.Drawing.Point(0, 0)
            Me.picture1Item.Name = "picture1Item"
            Me.picture1Item.Size = New System.Drawing.Size(248, 279)
            Me.picture1Item.TextLocation = DevExpress.Utils.Locations.Left
            Me.picture1Item.TextSize = New System.Drawing.Size(0, 0)
            Me.picture1Item.TextVisible = False
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.Location = New System.Drawing.Point(5, 314)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(176, 22)
            Me.simpleButton1.StyleController = Me.lcTitle
            Me.simpleButton1.TabIndex = 10
            Me.simpleButton1.Text = "Rotate Layout 90 Degrees"
            '			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click)
            ' 
            ' lcTitle
            ' 
            Me.lcTitle.AllowCustomization = False
            Me.lcTitle.Controls.Add(Me.ceVerticalIsCollapsible)
            Me.lcTitle.Controls.Add(Me.ceVerticalIsCollapsed)
            Me.lcTitle.Controls.Add(Me.ceVerticalInverted)
            Me.lcTitle.Controls.Add(Me.showDesc)
            Me.lcTitle.Controls.Add(Me.showP2)
            Me.lcTitle.Controls.Add(Me.showP1)
            Me.lcTitle.Controls.Add(Me.simpleButton1)
            Me.lcTitle.Controls.Add(Me.ceHorizontalInverted)
            Me.lcTitle.Controls.Add(Me.ceHorizontalIsCollapsed)
            Me.lcTitle.Controls.Add(Me.ceHorizontalIsCollapsible)
            Me.lcTitle.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lcTitle.Location = New System.Drawing.Point(0, 0)
            Me.lcTitle.Name = "lcTitle"
            Me.lcTitle.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(-931, 343, 715, 579)
            Me.lcTitle.OptionsView.AllowExpandAnimation = DevExpress.Utils.DefaultBoolean.True
            Me.lcTitle.OptionsView.AllowItemSkinning = False
            Me.lcTitle.OptionsView.UseParentAutoScaleFactor = True
            Me.lcTitle.OptionsView.UseSkinIndents = False
            Me.lcTitle.Root = Me.lcMainGroup
            Me.lcTitle.Size = New System.Drawing.Size(186, 445)
            Me.lcTitle.TabIndex = 1
            ' 
            ' ceVerticalIsCollapsible
            ' 
            Me.ceVerticalIsCollapsible.Location = New System.Drawing.Point(8, 171)
            Me.ceVerticalIsCollapsible.Name = "ceVerticalIsCollapsible"
            Me.ceVerticalIsCollapsible.Properties.Caption = "IsCollapsible"
            Me.ceVerticalIsCollapsible.Size = New System.Drawing.Size(170, 19)
            Me.ceVerticalIsCollapsible.StyleController = Me.lcTitle
            Me.ceVerticalIsCollapsible.TabIndex = 13
            '			Me.ceVerticalIsCollapsible.CheckedChanged += New System.EventHandler(Me.ceVerticalIsCollapsible_CheckedChanged)
            ' 
            ' ceVerticalIsCollapsed
            ' 
            Me.ceVerticalIsCollapsed.Location = New System.Drawing.Point(8, 142)
            Me.ceVerticalIsCollapsed.Name = "ceVerticalIsCollapsed"
            Me.ceVerticalIsCollapsed.Properties.Caption = "IsCollapsed"
            Me.ceVerticalIsCollapsed.Size = New System.Drawing.Size(170, 19)
            Me.ceVerticalIsCollapsed.StyleController = Me.lcTitle
            Me.ceVerticalIsCollapsed.TabIndex = 12
            '			Me.ceVerticalIsCollapsed.CheckedChanged += New System.EventHandler(Me.ceVerticalIsCollapsed_CheckedChanged)
            ' 
            ' ceVerticalInverted
            ' 
            Me.ceVerticalInverted.Location = New System.Drawing.Point(8, 113)
            Me.ceVerticalInverted.Name = "ceVerticalInverted"
            Me.ceVerticalInverted.Properties.Caption = "Inverted"
            Me.ceVerticalInverted.Size = New System.Drawing.Size(170, 19)
            Me.ceVerticalInverted.StyleController = Me.lcTitle
            Me.ceVerticalInverted.TabIndex = 11
            '			Me.ceVerticalInverted.CheckedChanged += New System.EventHandler(Me.ceVerticalInverted_CheckedChanged)
            ' 
            ' showDesc
            ' 
            Me.showDesc.AutoSizeInLayoutControl = True
            Me.showDesc.EditValue = True
            Me.showDesc.Location = New System.Drawing.Point(5, 5)
            Me.showDesc.Name = "showDesc"
            Me.showDesc.Properties.Caption = "Show Description"
            Me.showDesc.Size = New System.Drawing.Size(104, 19)
            Me.showDesc.StyleController = Me.lcTitle
            Me.showDesc.TabIndex = 8
            '			Me.showDesc.CheckedChanged += New System.EventHandler(Me.checkEdit2_CheckedChanged)
            ' 
            ' showP2
            ' 
            Me.showP2.AutoSizeInLayoutControl = True
            Me.showP2.EditValue = True
            Me.showP2.Location = New System.Drawing.Point(5, 63)
            Me.showP2.Name = "showP2"
            Me.showP2.Properties.Caption = "Show Picture2"
            Me.showP2.Size = New System.Drawing.Size(90, 19)
            Me.showP2.StyleController = Me.lcTitle
            Me.showP2.TabIndex = 9
            '			Me.showP2.CheckedChanged += New System.EventHandler(Me.checkEdit3_CheckedChanged)
            ' 
            ' showP1
            ' 
            Me.showP1.AutoSizeInLayoutControl = True
            Me.showP1.EditValue = True
            Me.showP1.Location = New System.Drawing.Point(5, 34)
            Me.showP1.Name = "showP1"
            Me.showP1.Properties.Caption = "Show Picture1"
            Me.showP1.Size = New System.Drawing.Size(90, 19)
            Me.showP1.StyleController = Me.lcTitle
            Me.showP1.TabIndex = 7
            '			Me.showP1.CheckedChanged += New System.EventHandler(Me.checkEdit1_CheckedChanged)
            ' 
            ' ceHorizontalInverted
            ' 
            Me.ceHorizontalInverted.Location = New System.Drawing.Point(8, 224)
            Me.ceHorizontalInverted.Name = "ceHorizontalInverted"
            Me.ceHorizontalInverted.Properties.Caption = "Inverted"
            Me.ceHorizontalInverted.Size = New System.Drawing.Size(170, 19)
            Me.ceHorizontalInverted.StyleController = Me.lcTitle
            Me.ceHorizontalInverted.TabIndex = 11
            '			Me.ceHorizontalInverted.CheckedChanged += New System.EventHandler(Me.ceHorizontalInverted_CheckedChanged)
            ' 
            ' ceHorizontalIsCollapsed
            ' 
            Me.ceHorizontalIsCollapsed.Location = New System.Drawing.Point(8, 253)
            Me.ceHorizontalIsCollapsed.Name = "ceHorizontalIsCollapsed"
            Me.ceHorizontalIsCollapsed.Properties.Caption = "IsCollapsed"
            Me.ceHorizontalIsCollapsed.Size = New System.Drawing.Size(170, 19)
            Me.ceHorizontalIsCollapsed.StyleController = Me.lcTitle
            Me.ceHorizontalIsCollapsed.TabIndex = 12
            '			Me.ceHorizontalIsCollapsed.CheckedChanged += New System.EventHandler(Me.ceHorizontalIsCollapsed_CheckedChanged)
            ' 
            ' ceHorizontalIsCollapsible
            ' 
            Me.ceHorizontalIsCollapsible.Location = New System.Drawing.Point(8, 282)
            Me.ceHorizontalIsCollapsible.Name = "ceHorizontalIsCollapsible"
            Me.ceHorizontalIsCollapsible.Properties.Caption = "IsCollapsible"
            Me.ceHorizontalIsCollapsible.Size = New System.Drawing.Size(170, 19)
            Me.ceHorizontalIsCollapsible.StyleController = Me.lcTitle
            Me.ceHorizontalIsCollapsible.TabIndex = 13
            '			Me.ceHorizontalIsCollapsible.CheckedChanged += New System.EventHandler(Me.ceHorizontalIsCollapsible_CheckedChanged)
            ' 
            ' lcMainGroup
            ' 
            Me.lcMainGroup.CustomizationFormText = "Root"
            Me.lcMainGroup.GroupBordersVisible = False
            Me.lcMainGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlGroupSplitterItem1, Me.layoutControlGroupSplitterItem2})
            Me.lcMainGroup.Location = New System.Drawing.Point(0, 0)
            Me.lcMainGroup.Name = "Root"
            Me.lcMainGroup.OptionsItemText.TextToControlDistance = 5
            Me.lcMainGroup.Size = New System.Drawing.Size(186, 445)
            Me.lcMainGroup.Text = "Select xml file and restore layout"
            Me.lcMainGroup.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.simpleButton1
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 309)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(186, 136)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.showP2
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 58)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(186, 29)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.showP1
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 29)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(186, 29)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.showDesc
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(186, 29)
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlGroupSplitterItem1
            ' 
            Me.layoutControlGroupSplitterItem1.ExpandButtonVisible = True
            Me.layoutControlGroupSplitterItem1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem5, Me.layoutControlItem6, Me.layoutControlItem7})
            Me.layoutControlGroupSplitterItem1.Location = New System.Drawing.Point(0, 87)
            Me.layoutControlGroupSplitterItem1.Name = "layoutControlGroup2"
            Me.layoutControlGroupSplitterItem1.OptionsItemText.TextToControlDistance = 5
            Me.layoutControlGroupSplitterItem1.Size = New System.Drawing.Size(186, 111)
            Me.layoutControlGroupSplitterItem1.Text = "Vertical SplitterItem"
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.ceVerticalInverted
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(180, 29)
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.ceVerticalIsCollapsed
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 29)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(180, 29)
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem6.TextVisible = False
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.ceVerticalIsCollapsible
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 58)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Size = New System.Drawing.Size(180, 29)
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem7.TextVisible = False
            ' 
            ' layoutControlGroupSplitterItem2
            ' 
            Me.layoutControlGroupSplitterItem2.ExpandButtonVisible = True
            Me.layoutControlGroupSplitterItem2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem8, Me.layoutControlItem9, Me.layoutControlItem10})
            Me.layoutControlGroupSplitterItem2.Location = New System.Drawing.Point(0, 198)
            Me.layoutControlGroupSplitterItem2.Name = "layoutControlGroup4"
            Me.layoutControlGroupSplitterItem2.OptionsItemText.TextToControlDistance = 5
            Me.layoutControlGroupSplitterItem2.Size = New System.Drawing.Size(186, 111)
            Me.layoutControlGroupSplitterItem2.Text = "Horizontal SplitterItem"
            ' 
            ' layoutControlItem8
            ' 
            Me.layoutControlItem8.Control = Me.ceHorizontalInverted
            Me.layoutControlItem8.CustomizationFormText = "layoutControlItem5"
            Me.layoutControlItem8.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.Size = New System.Drawing.Size(180, 29)
            Me.layoutControlItem8.Text = "layoutControlItem5"
            Me.layoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem8.TextVisible = False
            ' 
            ' layoutControlItem9
            ' 
            Me.layoutControlItem9.Control = Me.ceHorizontalIsCollapsed
            Me.layoutControlItem9.CustomizationFormText = "layoutControlItem6"
            Me.layoutControlItem9.Location = New System.Drawing.Point(0, 29)
            Me.layoutControlItem9.Name = "layoutControlItem9"
            Me.layoutControlItem9.Size = New System.Drawing.Size(180, 29)
            Me.layoutControlItem9.Text = "layoutControlItem6"
            Me.layoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem9.TextVisible = False
            ' 
            ' layoutControlItem10
            ' 
            Me.layoutControlItem10.Control = Me.ceHorizontalIsCollapsible
            Me.layoutControlItem10.CustomizationFormText = "layoutControlItem7"
            Me.layoutControlItem10.Location = New System.Drawing.Point(0, 58)
            Me.layoutControlItem10.Name = "layoutControlItem10"
            Me.layoutControlItem10.Size = New System.Drawing.Size(180, 29)
            Me.layoutControlItem10.Text = "layoutControlItem7"
            Me.layoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem10.TextVisible = False
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Right
            Me.panelControl1.Location = New System.Drawing.Point(522, 0)
            Me.panelControl1.MaximumSize = New System.Drawing.Size(10, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(10, 505)
            Me.panelControl1.TabIndex = 5
            ' 
            ' navigationPane1
            ' 
            Me.navigationPane1.AllowResize = False
            Me.navigationPane1.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False
            Me.navigationPane1.Controls.Add(Me.navigationPage1)
            Me.navigationPane1.Dock = System.Windows.Forms.DockStyle.Right
            Me.navigationPane1.Location = New System.Drawing.Point(532, 0)
            Me.navigationPane1.Name = "navigationPane1"
            Me.navigationPane1.PageProperties.ShowExpandButton = False
            Me.navigationPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Image
            Me.navigationPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.navigationPage1})
            Me.navigationPane1.RegularSize = New System.Drawing.Size(236, 505)
            Me.navigationPane1.SelectedPage = Me.navigationPage1
            Me.navigationPane1.Size = New System.Drawing.Size(236, 505)
            Me.navigationPane1.TabIndex = 4
            Me.navigationPane1.Text = "navigationPane1"
            ' 
            ' navigationPage1
            ' 
            Me.navigationPage1.Caption = "Options"
            Me.navigationPage1.Controls.Add(Me.lcTitle)
            Me.navigationPage1.ImageUri.Uri = "Properties;Size16x16;Office2013"
            Me.navigationPage1.Name = "navigationPage1"
            Me.navigationPage1.Size = New System.Drawing.Size(186, 445)
            ' 
            ' ItemsVisibility
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.navigationPane1)
            Me.Name = "ItemsVisibility"
            Me.Size = New System.Drawing.Size(768, 505)
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            DirectCast(Me.pictureEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.splitterItem2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.descriptionItem, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.picture2Item, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.splitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.picture1Item, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lcTitle, System.ComponentModel.ISupportInitialize).EndInit()
            Me.lcTitle.ResumeLayout(False)
            DirectCast(Me.ceVerticalIsCollapsible.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ceVerticalIsCollapsed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ceVerticalInverted.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.showDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.showP2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.showP1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ceHorizontalInverted.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ceHorizontalIsCollapsed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ceHorizontalIsCollapsible.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lcMainGroup, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroupSplitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroupSplitterItem2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.navigationPane1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPane1.ResumeLayout(False)
            Me.navigationPage1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Private Sub checkEdit2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles showDesc.CheckedChanged
            UpdateVisibility()
        End Sub
        Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles showP1.CheckedChanged
            UpdateVisibility()
        End Sub
        Private Sub checkEdit3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles showP2.CheckedChanged
            UpdateVisibility()
        End Sub
        Protected Sub UpdateVisibility()
            UpdateVisibility(showDesc.Checked, showP1.Checked, showP2.Checked)
        End Sub
        Protected Sub SetVisibility(ByVal picture1ItemVisibility As LayoutVisibility, ByVal picture2ItemVisibility As LayoutVisibility, ByVal descriptionItemVisibility As LayoutVisibility)
            picture1Item.Visibility = picture1ItemVisibility
            picture2Item.Visibility = picture2ItemVisibility
            descriptionItem.Visibility = descriptionItemVisibility
            If picture1ItemVisibility = LayoutVisibility.Always AndAlso picture2ItemVisibility = LayoutVisibility.Always Then
                splitterItem1.Visibility = LayoutVisibility.Always
            Else
                splitterItem1.Visibility = LayoutVisibility.Never
            End If
            If (picture1ItemVisibility = LayoutVisibility.Always OrElse picture2ItemVisibility = LayoutVisibility.Always) AndAlso descriptionItemVisibility = LayoutVisibility.Always Then
                splitterItem2.Visibility = LayoutVisibility.Always
            Else
                splitterItem2.Visibility = LayoutVisibility.Never
            End If
        End Sub
        Protected Sub UpdateVisibility(ByVal showDescription As Boolean, ByVal showPicure1 As Boolean, ByVal showPicture2 As Boolean)
            SetVisibility(LayoutVisibilityConvertor.FromBoolean(showPicure1), LayoutVisibilityConvertor.FromBoolean(showPicture2), LayoutVisibilityConvertor.FromBoolean(showDescription))
        End Sub
        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
            layoutControl1.Root.RotateLayout()
            layoutControlGroupSplitterItem1.Text = If(splitterItem1.IsHorizontal, "Horizontal SplitterItem", "Vertical SplitterItem")
            layoutControlGroupSplitterItem2.Text = If(splitterItem2.IsHorizontal, "Horizontal SplitterItem", "Vertical SplitterItem")
        End Sub

        Private Sub ceVerticalInverted_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceVerticalInverted.CheckedChanged
            splitterItem1.Inverted = ceVerticalInverted.Checked
        End Sub
        Private Sub ceVerticalIsCollapsed_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceVerticalIsCollapsed.CheckedChanged
            splitterItem1.IsCollapsed = ceVerticalIsCollapsed.Checked
        End Sub
        Private Sub ceVerticalIsCollapsible_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceVerticalIsCollapsible.CheckedChanged
            splitterItem1.IsCollapsible = If(ceVerticalIsCollapsible.Checked, DefaultBoolean.True, DefaultBoolean.False)
        End Sub
        Private Sub ceHorizontalInverted_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceHorizontalInverted.CheckedChanged
            splitterItem2.Inverted = ceHorizontalInverted.Checked
        End Sub
        Private Sub ceHorizontalIsCollapsed_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceHorizontalIsCollapsed.CheckedChanged
            splitterItem2.IsCollapsed = ceHorizontalIsCollapsed.Checked

        End Sub
        Private Sub ceHorizontalIsCollapsible_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceHorizontalIsCollapsible.CheckedChanged
            splitterItem2.IsCollapsible = If(ceHorizontalIsCollapsible.Checked, DefaultBoolean.True, DefaultBoolean.False)
        End Sub

        Private Sub layoutControl1_Changed(ByVal sender As Object, ByVal e As EventArgs) Handles layoutControl1.Changed
            UpdateSplitterOptions()
        End Sub
    End Class
End Namespace

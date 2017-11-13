Namespace DevExpress.XtraDiagram.Demos
    Partial Public Class ToolboxModule
        Private components As System.ComponentModel.IContainer = Nothing
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ToolboxModule))
            Me.xtraToolboxControl = New DevExpress.XtraToolbox.ToolboxControl()
            Me.gcOptionsView = New DevExpress.XtraEditors.GroupControl()
            Me.ceGroupsContentAutoSize = New DevExpress.XtraEditors.CheckEdit()
            Me.ceShowSearchPanel = New DevExpress.XtraEditors.CheckEdit()
            Me.labelItemViewMode = New DevExpress.XtraEditors.LabelControl()
            Me.cbItemViewMode = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.labelColumnCount = New DevExpress.XtraEditors.LabelControl()
            Me.seColumnCount = New DevExpress.XtraEditors.SpinEdit()
            Me.cbImageSize = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.labelImageSize = New DevExpress.XtraEditors.LabelControl()
            Me.ceAllowSmoothScrolling = New DevExpress.XtraEditors.CheckEdit()
            Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
            Me.gcContent = New DevExpress.XtraDiagram.Demos.SimpleContentPanel()
            Me.icActionsSmall = New DevExpress.Utils.ImageCollection(Me.components)
            Me.icActionsLarge = New DevExpress.Utils.ImageCollection(Me.components)
            Me.icArrowsSmall = New DevExpress.Utils.ImageCollection(Me.components)
            Me.icArrowsLarge = New DevExpress.Utils.ImageCollection(Me.components)
            Me.icExportSmall = New DevExpress.Utils.ImageCollection(Me.components)
            Me.icExportLarge = New DevExpress.Utils.ImageCollection(Me.components)
            Me.panelOptions = New DevExpress.XtraEditors.PanelControl()
            Me.gcOptionsBehavior = New DevExpress.XtraEditors.GroupControl()
            Me.lblItemSelectMode = New DevExpress.XtraEditors.LabelControl()
            Me.cbeItemSelectMode = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.gcOptionsMinimizing = New DevExpress.XtraEditors.GroupControl()
            Me.lblScrollMode = New DevExpress.XtraEditors.LabelControl()
            Me.cbMinimizingScrollMode = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.labelColumnCountMinimizing = New DevExpress.XtraEditors.LabelControl()
            Me.seColumnCountMinimizing = New DevExpress.XtraEditors.SpinEdit()
            Me.imagesSmall = New DevExpress.Utils.ImageCollection(Me.components)
            Me.imagesLarge = New DevExpress.Utils.ImageCollection(Me.components)
            CType(Me.gcOptionsView, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gcOptionsView.SuspendLayout()
            CType(Me.ceGroupsContentAutoSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceShowSearchPanel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbItemViewMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.seColumnCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbImageSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceAllowSmoothScrolling.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.SuspendLayout()
            CType(Me.gcContent, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.icActionsSmall, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.icActionsLarge, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.icArrowsSmall, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.icArrowsLarge, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.icExportSmall, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.icExportLarge, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelOptions, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelOptions.SuspendLayout()
            CType(Me.gcOptionsBehavior, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gcOptionsBehavior.SuspendLayout()
            CType(Me.cbeItemSelectMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gcOptionsMinimizing, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gcOptionsMinimizing.SuspendLayout()
            CType(Me.cbMinimizingScrollMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.seColumnCountMinimizing.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.imagesSmall, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.imagesLarge, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' xtraToolboxControl
            ' 
            Me.xtraToolboxControl.Appearance.Toolbox.Font = New System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.xtraToolboxControl.Appearance.Toolbox.Options.UseFont = True
            Me.xtraToolboxControl.Caption = ""
            Me.xtraToolboxControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xtraToolboxControl.Location = New System.Drawing.Point(0, 0)
            Me.xtraToolboxControl.Name = "xtraToolboxControl"
            Me.xtraToolboxControl.OptionsBehavior.AllowSmoothScrolling = True
            Me.xtraToolboxControl.OptionsBehavior.ItemSelectMode = DevExpress.XtraToolbox.ToolboxItemSelectMode.Multiple
            Me.xtraToolboxControl.OptionsView.ItemImageSize = New System.Drawing.Size(32, 32)
            Me.xtraToolboxControl.OptionsView.MenuButtonImage = (CType(resources.GetObject("toolboxControl.OptionsView.MenuButtonImage"), System.Drawing.Image))
            Me.xtraToolboxControl.OptionsView.ShowMenuButton = False
            Me.xtraToolboxControl.OptionsView.ShowToolboxCaption = True
            Me.xtraToolboxControl.Size = New System.Drawing.Size(273, 676)
            Me.xtraToolboxControl.TabIndex = 0
            ' 
            ' gcOptionsView
            ' 
            Me.gcOptionsView.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.gcOptionsView.Controls.Add(Me.ceGroupsContentAutoSize)
            Me.gcOptionsView.Controls.Add(Me.ceShowSearchPanel)
            Me.gcOptionsView.Controls.Add(Me.labelItemViewMode)
            Me.gcOptionsView.Controls.Add(Me.cbItemViewMode)
            Me.gcOptionsView.Controls.Add(Me.labelColumnCount)
            Me.gcOptionsView.Controls.Add(Me.seColumnCount)
            Me.gcOptionsView.Controls.Add(Me.cbImageSize)
            Me.gcOptionsView.Controls.Add(Me.labelImageSize)
            Me.gcOptionsView.Location = New System.Drawing.Point(15, 0)
            Me.gcOptionsView.Name = "gcOptionsView"
            Me.gcOptionsView.Size = New System.Drawing.Size(296, 200)
            Me.gcOptionsView.TabIndex = 2
            Me.gcOptionsView.Text = "Options View"
            ' 
            ' ceGroupsContentAutoSize
            ' 
            Me.ceGroupsContentAutoSize.Location = New System.Drawing.Point(15, 165)
            Me.ceGroupsContentAutoSize.Name = "ceGroupsContentAutoSize"
            Me.ceGroupsContentAutoSize.Properties.Caption = "Groups Content Auto Size"
            Me.ceGroupsContentAutoSize.Size = New System.Drawing.Size(269, 19)
            Me.ceGroupsContentAutoSize.TabIndex = 9
            ' 
            ' ceShowSearchPanel
            ' 
            Me.ceShowSearchPanel.Location = New System.Drawing.Point(15, 136)
            Me.ceShowSearchPanel.Name = "ceShowSearchPanel"
            Me.ceShowSearchPanel.Properties.Caption = "Show Search Panel"
            Me.ceShowSearchPanel.Size = New System.Drawing.Size(269, 19)
            Me.ceShowSearchPanel.TabIndex = 8
            ' 
            ' labelItemViewMode
            ' 
            Me.labelItemViewMode.Location = New System.Drawing.Point(15, 104)
            Me.labelItemViewMode.Name = "labelItemViewMode"
            Me.labelItemViewMode.Size = New System.Drawing.Size(80, 13)
            Me.labelItemViewMode.TabIndex = 6
            Me.labelItemViewMode.Text = "Item View Mode:"
            ' 
            ' cbItemViewMode
            ' 
            Me.cbItemViewMode.Location = New System.Drawing.Point(147, 101)
            Me.cbItemViewMode.Name = "cbItemViewMode"
            Me.cbItemViewMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbItemViewMode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cbItemViewMode.Size = New System.Drawing.Size(135, 20)
            Me.cbItemViewMode.TabIndex = 5
            ' 
            ' labelColumnCount
            ' 
            Me.labelColumnCount.Location = New System.Drawing.Point(15, 70)
            Me.labelColumnCount.Name = "labelColumnCount"
            Me.labelColumnCount.Size = New System.Drawing.Size(71, 13)
            Me.labelColumnCount.TabIndex = 4
            Me.labelColumnCount.Text = "Column Count:"
            ' 
            ' seColumnCount
            ' 
            Me.seColumnCount.EditValue = New Decimal(New Integer() { 2, 0, 0, 0})
            Me.seColumnCount.Location = New System.Drawing.Point(147, 67)
            Me.seColumnCount.Name = "seColumnCount"
            Me.seColumnCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.seColumnCount.Properties.IsFloatValue = False
            Me.seColumnCount.Properties.Mask.EditMask = "N00"
            Me.seColumnCount.Properties.MaxValue = New Decimal(New Integer() { 5, 0, 0, 0})
            Me.seColumnCount.Properties.MinValue = New Decimal(New Integer() { 1, 0, 0, 0})
            Me.seColumnCount.Size = New System.Drawing.Size(135, 20)
            Me.seColumnCount.TabIndex = 3
            ' 
            ' cbImageSize
            ' 
            Me.cbImageSize.EditValue = "32x32"
            Me.cbImageSize.Location = New System.Drawing.Point(147, 33)
            Me.cbImageSize.Name = "cbImageSize"
            Me.cbImageSize.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbImageSize.Properties.Items.AddRange(New Object() { "16x16", "32x32"})
            Me.cbImageSize.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cbImageSize.Size = New System.Drawing.Size(135, 20)
            Me.cbImageSize.TabIndex = 2
            ' 
            ' labelImageSize
            ' 
            Me.labelImageSize.Location = New System.Drawing.Point(15, 36)
            Me.labelImageSize.Name = "labelImageSize"
            Me.labelImageSize.Size = New System.Drawing.Size(56, 13)
            Me.labelImageSize.TabIndex = 1
            Me.labelImageSize.Text = "Image Size:"
            ' 
            ' ceAllowSmoothScrolling
            ' 
            Me.ceAllowSmoothScrolling.Location = New System.Drawing.Point(15, 68)
            Me.ceAllowSmoothScrolling.Name = "ceAllowSmoothScrolling"
            Me.ceAllowSmoothScrolling.Properties.Caption = "Allow Smooth Scrolling"
            Me.ceAllowSmoothScrolling.Size = New System.Drawing.Size(269, 19)
            Me.ceAllowSmoothScrolling.TabIndex = 10
            ' 
            ' splitContainerControl1
            ' 
            Me.splitContainerControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.splitContainerControl1.Location = New System.Drawing.Point(5, 5)
            Me.splitContainerControl1.Name = "splitContainerControl1"
            Me.splitContainerControl1.Panel1.Controls.Add(Me.xtraToolboxControl)
            Me.splitContainerControl1.Panel1.Text = "Panel1"
            Me.splitContainerControl1.Panel2.Controls.Add(Me.gcContent)
            Me.splitContainerControl1.Panel2.Text = "Panel2"
            Me.splitContainerControl1.Size = New System.Drawing.Size(866, 676)
            Me.splitContainerControl1.SplitterPosition = 273
            Me.splitContainerControl1.TabIndex = 5
            Me.splitContainerControl1.Text = "splitContainerControl1"
            ' 
            ' gcContent
            ' 
            Me.gcContent.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gcContent.Location = New System.Drawing.Point(0, 0)
            Me.gcContent.Name = "gcContent"
            Me.gcContent.Size = New System.Drawing.Size(588, 676)
            Me.gcContent.TabIndex = 1
            Me.gcContent.Text = "Content"
            ' 
            ' icActionsSmall
            ' 
            Me.icActionsSmall.ImageStream = (CType(resources.GetObject("icActionsSmall.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
            Me.icActionsSmall.InsertGalleryImage("add_16x16.png", "images/actions/add_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/add_16x16.png"), 0)
            Me.icActionsSmall.Images.SetKeyName(0, "add_16x16.png")
            Me.icActionsSmall.InsertGalleryImage("addfile_16x16.png", "images/actions/addfile_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/addfile_16x16.png"), 1)
            Me.icActionsSmall.Images.SetKeyName(1, "addfile_16x16.png")
            Me.icActionsSmall.InsertGalleryImage("additem_16x16.png", "images/actions/additem_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/additem_16x16.png"), 2)
            Me.icActionsSmall.Images.SetKeyName(2, "additem_16x16.png")
            Me.icActionsSmall.InsertGalleryImage("apply_16x16.png", "images/actions/apply_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/apply_16x16.png"), 3)
            Me.icActionsSmall.Images.SetKeyName(3, "apply_16x16.png")
            Me.icActionsSmall.InsertGalleryImage("cancel_16x16.png", "images/actions/cancel_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cancel_16x16.png"), 4)
            Me.icActionsSmall.Images.SetKeyName(4, "cancel_16x16.png")
            Me.icActionsSmall.InsertGalleryImage("clear_16x16.png", "images/actions/clear_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/clear_16x16.png"), 5)
            Me.icActionsSmall.Images.SetKeyName(5, "clear_16x16.png")
            Me.icActionsSmall.InsertGalleryImage("clearformatting_16x16.png", "images/actions/clearformatting_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/clearformatting_16x16.png"), 6)
            Me.icActionsSmall.Images.SetKeyName(6, "clearformatting_16x16.png")
            Me.icActionsSmall.InsertGalleryImage("cleartablestyle_16x16.png", "images/actions/cleartablestyle_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cleartablestyle_16x16.png"), 7)
            Me.icActionsSmall.Images.SetKeyName(7, "cleartablestyle_16x16.png")
            Me.icActionsSmall.InsertGalleryImage("clip_16x16.png", "images/actions/clip_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/clip_16x16.png"), 8)
            Me.icActionsSmall.Images.SetKeyName(8, "clip_16x16.png")
            Me.icActionsSmall.InsertGalleryImage("close_16x16.png", "images/actions/close_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/close_16x16.png"), 9)
            Me.icActionsSmall.Images.SetKeyName(9, "close_16x16.png")
            Me.icActionsSmall.InsertGalleryImage("convert_16x16.png", "images/actions/convert_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/convert_16x16.png"), 10)
            Me.icActionsSmall.Images.SetKeyName(10, "convert_16x16.png")
            Me.icActionsSmall.InsertGalleryImage("converttorange_16x16.png", "images/actions/converttorange_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/converttorange_16x16.png"), 11)
            Me.icActionsSmall.Images.SetKeyName(11, "converttorange_16x16.png")
            Me.icActionsSmall.InsertGalleryImage("deletelist_16x16.png", "images/actions/deletelist_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/deletelist_16x16.png"), 12)
            Me.icActionsSmall.Images.SetKeyName(12, "deletelist_16x16.png")
            Me.icActionsSmall.InsertGalleryImage("deletelist2_16x16.png", "images/actions/deletelist2_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/deletelist2_16x16.png"), 13)
            Me.icActionsSmall.Images.SetKeyName(13, "deletelist2_16x16.png")
            Me.icActionsSmall.InsertGalleryImage("down_16x16.png", "images/actions/down_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/down_16x16.png"), 14)
            Me.icActionsSmall.Images.SetKeyName(14, "down_16x16.png")
            Me.icActionsSmall.InsertGalleryImage("download_16x16.png", "images/actions/download_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/download_16x16.png"), 15)
            Me.icActionsSmall.Images.SetKeyName(15, "download_16x16.png")
            Me.icActionsSmall.InsertGalleryImage("editname_16x16.png", "images/actions/editname_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/editname_16x16.png"), 16)
            Me.icActionsSmall.Images.SetKeyName(16, "editname_16x16.png")
            Me.icActionsSmall.InsertGalleryImage("fill_16x16.png", "images/actions/fill_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/fill_16x16.png"), 17)
            Me.icActionsSmall.Images.SetKeyName(17, "fill_16x16.png")
            Me.icActionsSmall.InsertGalleryImage("formatastable_16x16.png", "images/actions/formatastable_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/formatastable_16x16.png"), 18)
            Me.icActionsSmall.Images.SetKeyName(18, "formatastable_16x16.png")
            Me.icActionsSmall.InsertGalleryImage("group_16x16.png", "images/actions/group_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/group_16x16.png"), 19)
            Me.icActionsSmall.Images.SetKeyName(19, "group_16x16.png")
            Me.icActionsSmall.InsertGalleryImage("group2_16x16.png", "images/actions/group2_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/group2_16x16.png"), 20)
            Me.icActionsSmall.Images.SetKeyName(20, "group2_16x16.png")
            Me.icActionsSmall.InsertGalleryImage("hide_16x16.png", "images/actions/hide_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/hide_16x16.png"), 21)
            Me.icActionsSmall.Images.SetKeyName(21, "hide_16x16.png")
            Me.icActionsSmall.InsertGalleryImage("importimage_16x16.png", "images/actions/importimage_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/importimage_16x16.png"), 22)
            Me.icActionsSmall.Images.SetKeyName(22, "importimage_16x16.png")
            Me.icActionsSmall.InsertGalleryImage("insert_16x16.png", "images/actions/insert_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/insert_16x16.png"), 23)
            Me.icActionsSmall.Images.SetKeyName(23, "insert_16x16.png")
            Me.icActionsSmall.InsertGalleryImage("left_16x16.png", "images/actions/left_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/left_16x16.png"), 24)
            Me.icActionsSmall.Images.SetKeyName(24, "left_16x16.png")
            Me.icActionsSmall.InsertGalleryImage("loadfrom_16x16.png", "images/actions/loadfrom_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/loadfrom_16x16.png"), 25)
            Me.icActionsSmall.Images.SetKeyName(25, "loadfrom_16x16.png")
            Me.icActionsSmall.InsertGalleryImage("merge_16x16.png", "images/actions/merge_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/merge_16x16.png"), 26)
            Me.icActionsSmall.Images.SetKeyName(26, "merge_16x16.png")
            Me.icActionsSmall.InsertGalleryImage("new_16x16.png", "images/actions/new_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/new_16x16.png"), 27)
            Me.icActionsSmall.Images.SetKeyName(27, "new_16x16.png")
            Me.icActionsSmall.InsertGalleryImage("newtablestyle_16x16.png", "images/actions/newtablestyle_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/newtablestyle_16x16.png"), 28)
            Me.icActionsSmall.Images.SetKeyName(28, "newtablestyle_16x16.png")
            Me.icActionsSmall.InsertGalleryImage("open_16x16.png", "images/actions/open_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/open_16x16.png"), 29)
            Me.icActionsSmall.Images.SetKeyName(29, "open_16x16.png")
            Me.icActionsSmall.InsertGalleryImage("open2_16x16.png", "images/actions/open2_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/open2_16x16.png"), 30)
            Me.icActionsSmall.Images.SetKeyName(30, "open2_16x16.png")
            Me.icActionsSmall.InsertGalleryImage("openhyperlink_16x16.png", "images/actions/openhyperlink_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/openhyperlink_16x16.png"), 31)
            Me.icActionsSmall.Images.SetKeyName(31, "openhyperlink_16x16.png")
            Me.icActionsSmall.InsertGalleryImage("reading_16x16.png", "images/actions/reading_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/reading_16x16.png"), 32)
            Me.icActionsSmall.Images.SetKeyName(32, "reading_16x16.png")
            Me.icActionsSmall.InsertGalleryImage("refresh_16x16.png", "images/actions/refresh_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/refresh_16x16.png"), 33)
            Me.icActionsSmall.Images.SetKeyName(33, "refresh_16x16.png")
            Me.icActionsSmall.InsertGalleryImage("refresh2_16x16.png", "images/actions/refresh2_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/refresh2_16x16.png"), 34)
            Me.icActionsSmall.Images.SetKeyName(34, "refresh2_16x16.png")
            Me.icActionsSmall.InsertGalleryImage("remove_16x16.png", "images/actions/remove_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/remove_16x16.png"), 35)
            Me.icActionsSmall.Images.SetKeyName(35, "remove_16x16.png")
            Me.icActionsSmall.InsertGalleryImage("removeitem_16x16.png", "images/actions/removeitem_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/removeitem_16x16.png"), 36)
            Me.icActionsSmall.Images.SetKeyName(36, "removeitem_16x16.png")
            Me.icActionsSmall.InsertGalleryImage("reset_16x16.png", "images/actions/reset_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/reset_16x16.png"), 37)
            Me.icActionsSmall.Images.SetKeyName(37, "reset_16x16.png")
            Me.icActionsSmall.InsertGalleryImage("reset2_16x16.png", "images/actions/reset2_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/reset2_16x16.png"), 38)
            Me.icActionsSmall.Images.SetKeyName(38, "reset2_16x16.png")
            Me.icActionsSmall.InsertGalleryImage("right_16x16.png", "images/actions/right_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/right_16x16.png"), 39)
            Me.icActionsSmall.Images.SetKeyName(39, "right_16x16.png")
            Me.icActionsSmall.InsertGalleryImage("selectall_16x16.png", "images/actions/selectall_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/selectall_16x16.png"), 40)
            Me.icActionsSmall.Images.SetKeyName(40, "selectall_16x16.png")
            Me.icActionsSmall.InsertGalleryImage("selectall2_16x16.png", "images/actions/selectall2_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/selectall2_16x16.png"), 41)
            Me.icActionsSmall.Images.SetKeyName(41, "selectall2_16x16.png")
            Me.icActionsSmall.InsertGalleryImage("show_16x16.png", "images/actions/show_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/show_16x16.png"), 42)
            Me.icActionsSmall.Images.SetKeyName(42, "show_16x16.png")
            Me.icActionsSmall.InsertGalleryImage("squeeze_16x16.png", "images/actions/squeeze_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/squeeze_16x16.png"), 43)
            Me.icActionsSmall.Images.SetKeyName(43, "squeeze_16x16.png")
            Me.icActionsSmall.InsertGalleryImage("stretch_16x16.png", "images/actions/stretch_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/stretch_16x16.png"), 44)
            Me.icActionsSmall.Images.SetKeyName(44, "stretch_16x16.png")
            Me.icActionsSmall.InsertGalleryImage("switchrowcolumn_16x16.png", "images/actions/switchrowcolumn_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/switchrowcolumn_16x16.png"), 45)
            Me.icActionsSmall.Images.SetKeyName(45, "switchrowcolumn_16x16.png")
            Me.icActionsSmall.InsertGalleryImage("up2_16x16.png", "images/actions/up2_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/up2_16x16.png"), 46)
            Me.icActionsSmall.Images.SetKeyName(46, "up2_16x16.png")
            ' 
            ' icActionsLarge
            ' 
            Me.icActionsLarge.ImageSize = New System.Drawing.Size(32, 32)
            Me.icActionsLarge.ImageStream = (CType(resources.GetObject("icActionsLarge.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
            Me.icActionsLarge.InsertGalleryImage("add_32x32.png", "images/actions/add_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/add_32x32.png"), 0)
            Me.icActionsLarge.Images.SetKeyName(0, "add_32x32.png")
            Me.icActionsLarge.InsertGalleryImage("addfile_32x32.png", "images/actions/addfile_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/addfile_32x32.png"), 1)
            Me.icActionsLarge.Images.SetKeyName(1, "addfile_32x32.png")
            Me.icActionsLarge.InsertGalleryImage("additem_32x32.png", "images/actions/additem_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/additem_32x32.png"), 2)
            Me.icActionsLarge.Images.SetKeyName(2, "additem_32x32.png")
            Me.icActionsLarge.InsertGalleryImage("apply_32x32.png", "images/actions/apply_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/apply_32x32.png"), 3)
            Me.icActionsLarge.Images.SetKeyName(3, "apply_32x32.png")
            Me.icActionsLarge.InsertGalleryImage("cancel_32x32.png", "images/actions/cancel_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cancel_32x32.png"), 4)
            Me.icActionsLarge.Images.SetKeyName(4, "cancel_32x32.png")
            Me.icActionsLarge.InsertGalleryImage("clear_32x32.png", "images/actions/clear_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/clear_32x32.png"), 5)
            Me.icActionsLarge.Images.SetKeyName(5, "clear_32x32.png")
            Me.icActionsLarge.InsertGalleryImage("clearformatting_32x32.png", "images/actions/clearformatting_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/clearformatting_32x32.png"), 6)
            Me.icActionsLarge.Images.SetKeyName(6, "clearformatting_32x32.png")
            Me.icActionsLarge.InsertGalleryImage("cleartablestyle_32x32.png", "images/actions/cleartablestyle_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cleartablestyle_32x32.png"), 7)
            Me.icActionsLarge.Images.SetKeyName(7, "cleartablestyle_32x32.png")
            Me.icActionsLarge.InsertGalleryImage("clip_32x32.png", "images/actions/clip_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/clip_32x32.png"), 8)
            Me.icActionsLarge.Images.SetKeyName(8, "clip_32x32.png")
            Me.icActionsLarge.InsertGalleryImage("close_32x32.png", "images/actions/close_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/close_32x32.png"), 9)
            Me.icActionsLarge.Images.SetKeyName(9, "close_32x32.png")
            Me.icActionsLarge.InsertGalleryImage("convert_32x32.png", "images/actions/convert_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/convert_32x32.png"), 10)
            Me.icActionsLarge.Images.SetKeyName(10, "convert_32x32.png")
            Me.icActionsLarge.InsertGalleryImage("converttorange_32x32.png", "images/actions/converttorange_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/converttorange_32x32.png"), 11)
            Me.icActionsLarge.Images.SetKeyName(11, "converttorange_32x32.png")
            Me.icActionsLarge.InsertGalleryImage("deletelist_32x32.png", "images/actions/deletelist_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/deletelist_32x32.png"), 12)
            Me.icActionsLarge.Images.SetKeyName(12, "deletelist_32x32.png")
            Me.icActionsLarge.InsertGalleryImage("deletelist2_32x32.png", "images/actions/deletelist2_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/deletelist2_32x32.png"), 13)
            Me.icActionsLarge.Images.SetKeyName(13, "deletelist2_32x32.png")
            Me.icActionsLarge.InsertGalleryImage("down_32x32.png", "images/actions/down_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/down_32x32.png"), 14)
            Me.icActionsLarge.Images.SetKeyName(14, "down_32x32.png")
            Me.icActionsLarge.InsertGalleryImage("download_32x32.png", "images/actions/download_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/download_32x32.png"), 15)
            Me.icActionsLarge.Images.SetKeyName(15, "download_32x32.png")
            Me.icActionsLarge.InsertGalleryImage("editname_32x32.png", "images/actions/editname_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/editname_32x32.png"), 16)
            Me.icActionsLarge.Images.SetKeyName(16, "editname_32x32.png")
            Me.icActionsLarge.InsertGalleryImage("fill_32x32.png", "images/actions/fill_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/fill_32x32.png"), 17)
            Me.icActionsLarge.Images.SetKeyName(17, "fill_32x32.png")
            Me.icActionsLarge.InsertGalleryImage("formatastable_32x32.png", "images/actions/formatastable_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/formatastable_32x32.png"), 18)
            Me.icActionsLarge.Images.SetKeyName(18, "formatastable_32x32.png")
            Me.icActionsLarge.InsertGalleryImage("group_32x32.png", "images/actions/group_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/group_32x32.png"), 19)
            Me.icActionsLarge.Images.SetKeyName(19, "group_32x32.png")
            Me.icActionsLarge.InsertGalleryImage("group2_32x32.png", "images/actions/group2_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/group2_32x32.png"), 20)
            Me.icActionsLarge.Images.SetKeyName(20, "group2_32x32.png")
            Me.icActionsLarge.InsertGalleryImage("hide_32x32.png", "images/actions/hide_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/hide_32x32.png"), 21)
            Me.icActionsLarge.Images.SetKeyName(21, "hide_32x32.png")
            Me.icActionsLarge.InsertGalleryImage("importimage_32x32.png", "images/actions/importimage_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/importimage_32x32.png"), 22)
            Me.icActionsLarge.Images.SetKeyName(22, "importimage_32x32.png")
            Me.icActionsLarge.InsertGalleryImage("insert_32x32.png", "images/actions/insert_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/insert_32x32.png"), 23)
            Me.icActionsLarge.Images.SetKeyName(23, "insert_32x32.png")
            Me.icActionsLarge.InsertGalleryImage("left_32x32.png", "images/actions/left_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/left_32x32.png"), 24)
            Me.icActionsLarge.Images.SetKeyName(24, "left_32x32.png")
            Me.icActionsLarge.InsertGalleryImage("loadfrom_32x32.png", "images/actions/loadfrom_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/loadfrom_32x32.png"), 25)
            Me.icActionsLarge.Images.SetKeyName(25, "loadfrom_32x32.png")
            Me.icActionsLarge.InsertGalleryImage("merge_32x32.png", "images/actions/merge_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/merge_32x32.png"), 26)
            Me.icActionsLarge.Images.SetKeyName(26, "merge_32x32.png")
            Me.icActionsLarge.InsertGalleryImage("new_32x32.png", "images/actions/new_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/new_32x32.png"), 27)
            Me.icActionsLarge.Images.SetKeyName(27, "new_32x32.png")
            Me.icActionsLarge.InsertGalleryImage("newtablestyle_32x32.png", "images/actions/newtablestyle_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/newtablestyle_32x32.png"), 28)
            Me.icActionsLarge.Images.SetKeyName(28, "newtablestyle_32x32.png")
            Me.icActionsLarge.InsertGalleryImage("open_32x32.png", "images/actions/open_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/open_32x32.png"), 29)
            Me.icActionsLarge.Images.SetKeyName(29, "open_32x32.png")
            Me.icActionsLarge.InsertGalleryImage("open2_32x32.png", "images/actions/open2_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/open2_32x32.png"), 30)
            Me.icActionsLarge.Images.SetKeyName(30, "open2_32x32.png")
            Me.icActionsLarge.InsertGalleryImage("openhyperlink_32x32.png", "images/actions/openhyperlink_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/openhyperlink_32x32.png"), 31)
            Me.icActionsLarge.Images.SetKeyName(31, "openhyperlink_32x32.png")
            Me.icActionsLarge.InsertGalleryImage("reading_32x32.png", "images/actions/reading_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/reading_32x32.png"), 32)
            Me.icActionsLarge.Images.SetKeyName(32, "reading_32x32.png")
            Me.icActionsLarge.InsertGalleryImage("refresh_32x32.png", "images/actions/refresh_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/refresh_32x32.png"), 33)
            Me.icActionsLarge.Images.SetKeyName(33, "refresh_32x32.png")
            Me.icActionsLarge.InsertGalleryImage("refresh2_32x32.png", "images/actions/refresh2_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/refresh2_32x32.png"), 34)
            Me.icActionsLarge.Images.SetKeyName(34, "refresh2_32x32.png")
            Me.icActionsLarge.InsertGalleryImage("remove_32x32.png", "images/actions/remove_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/remove_32x32.png"), 35)
            Me.icActionsLarge.Images.SetKeyName(35, "remove_32x32.png")
            Me.icActionsLarge.InsertGalleryImage("removeitem_32x32.png", "images/actions/removeitem_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/removeitem_32x32.png"), 36)
            Me.icActionsLarge.Images.SetKeyName(36, "removeitem_32x32.png")
            Me.icActionsLarge.InsertGalleryImage("reset_32x32.png", "images/actions/reset_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/reset_32x32.png"), 37)
            Me.icActionsLarge.Images.SetKeyName(37, "reset_32x32.png")
            Me.icActionsLarge.InsertGalleryImage("reset2_32x32.png", "images/actions/reset2_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/reset2_32x32.png"), 38)
            Me.icActionsLarge.Images.SetKeyName(38, "reset2_32x32.png")
            Me.icActionsLarge.InsertGalleryImage("right_32x32.png", "images/actions/right_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/right_32x32.png"), 39)
            Me.icActionsLarge.Images.SetKeyName(39, "right_32x32.png")
            Me.icActionsLarge.InsertGalleryImage("selectall_32x32.png", "images/actions/selectall_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/selectall_32x32.png"), 40)
            Me.icActionsLarge.Images.SetKeyName(40, "selectall_32x32.png")
            Me.icActionsLarge.InsertGalleryImage("selectall2_32x32.png", "images/actions/selectall2_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/selectall2_32x32.png"), 41)
            Me.icActionsLarge.Images.SetKeyName(41, "selectall2_32x32.png")
            Me.icActionsLarge.InsertGalleryImage("show_32x32.png", "images/actions/show_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/show_32x32.png"), 42)
            Me.icActionsLarge.Images.SetKeyName(42, "show_32x32.png")
            Me.icActionsLarge.InsertGalleryImage("squeeze_32x32.png", "images/actions/squeeze_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/squeeze_32x32.png"), 43)
            Me.icActionsLarge.Images.SetKeyName(43, "squeeze_32x32.png")
            Me.icActionsLarge.InsertGalleryImage("stretch_32x32.png", "images/actions/stretch_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/stretch_32x32.png"), 44)
            Me.icActionsLarge.Images.SetKeyName(44, "stretch_32x32.png")
            Me.icActionsLarge.InsertGalleryImage("switchrowcolumn_32x32.png", "images/actions/switchrowcolumn_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/switchrowcolumn_32x32.png"), 45)
            Me.icActionsLarge.Images.SetKeyName(45, "switchrowcolumn_32x32.png")
            Me.icActionsLarge.InsertGalleryImage("up2_32x32.png", "images/actions/up2_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/up2_32x32.png"), 46)
            Me.icActionsLarge.Images.SetKeyName(46, "up2_32x32.png")
            ' 
            ' icArrowsSmall
            ' 
            Me.icArrowsSmall.ImageStream = (CType(resources.GetObject("icArrowsSmall.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
            Me.icArrowsSmall.InsertGalleryImage("doublefirst_16x16.png", "images/arrows/doublefirst_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/doublefirst_16x16.png"), 0)
            Me.icArrowsSmall.Images.SetKeyName(0, "doublefirst_16x16.png")
            Me.icArrowsSmall.InsertGalleryImage("doublelast_16x16.png", "images/arrows/doublelast_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/doublelast_16x16.png"), 1)
            Me.icArrowsSmall.Images.SetKeyName(1, "doublelast_16x16.png")
            Me.icArrowsSmall.InsertGalleryImage("doublenext_16x16.png", "images/arrows/doublenext_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/doublenext_16x16.png"), 2)
            Me.icArrowsSmall.Images.SetKeyName(2, "doublenext_16x16.png")
            Me.icArrowsSmall.InsertGalleryImage("doubleprev_16x16.png", "images/arrows/doubleprev_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/doubleprev_16x16.png"), 3)
            Me.icArrowsSmall.Images.SetKeyName(3, "doubleprev_16x16.png")
            Me.icArrowsSmall.InsertGalleryImage("first_16x16.png", "images/arrows/first_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/first_16x16.png"), 4)
            Me.icArrowsSmall.Images.SetKeyName(4, "first_16x16.png")
            Me.icArrowsSmall.InsertGalleryImage("last_16x16.png", "images/arrows/last_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/last_16x16.png"), 5)
            Me.icArrowsSmall.Images.SetKeyName(5, "last_16x16.png")
            Me.icArrowsSmall.InsertGalleryImage("movedown_16x16.png", "images/arrows/movedown_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/movedown_16x16.png"), 6)
            Me.icArrowsSmall.Images.SetKeyName(6, "movedown_16x16.png")
            Me.icArrowsSmall.InsertGalleryImage("moveup_16x16.png", "images/arrows/moveup_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/moveup_16x16.png"), 7)
            Me.icArrowsSmall.Images.SetKeyName(7, "moveup_16x16.png")
            Me.icArrowsSmall.InsertGalleryImage("next_16x16.png", "images/arrows/next_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/next_16x16.png"), 8)
            Me.icArrowsSmall.Images.SetKeyName(8, "next_16x16.png")
            Me.icArrowsSmall.InsertGalleryImage("prev_16x16.png", "images/arrows/prev_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/prev_16x16.png"), 9)
            Me.icArrowsSmall.Images.SetKeyName(9, "prev_16x16.png")
            ' 
            ' icArrowsLarge
            ' 
            Me.icArrowsLarge.ImageSize = New System.Drawing.Size(32, 32)
            Me.icArrowsLarge.ImageStream = (CType(resources.GetObject("icArrowsLarge.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
            Me.icArrowsLarge.InsertGalleryImage("doublefirst_32x32.png", "images/arrows/doublefirst_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/doublefirst_32x32.png"), 0)
            Me.icArrowsLarge.Images.SetKeyName(0, "doublefirst_32x32.png")
            Me.icArrowsLarge.InsertGalleryImage("doublelast_32x32.png", "images/arrows/doublelast_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/doublelast_32x32.png"), 1)
            Me.icArrowsLarge.Images.SetKeyName(1, "doublelast_32x32.png")
            Me.icArrowsLarge.InsertGalleryImage("doublenext_32x32.png", "images/arrows/doublenext_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/doublenext_32x32.png"), 2)
            Me.icArrowsLarge.Images.SetKeyName(2, "doublenext_32x32.png")
            Me.icArrowsLarge.InsertGalleryImage("doubleprev_32x32.png", "images/arrows/doubleprev_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/doubleprev_32x32.png"), 3)
            Me.icArrowsLarge.Images.SetKeyName(3, "doubleprev_32x32.png")
            Me.icArrowsLarge.InsertGalleryImage("first_32x32.png", "images/arrows/first_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/first_32x32.png"), 4)
            Me.icArrowsLarge.Images.SetKeyName(4, "first_32x32.png")
            Me.icArrowsLarge.InsertGalleryImage("last_32x32.png", "images/arrows/last_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/last_32x32.png"), 5)
            Me.icArrowsLarge.Images.SetKeyName(5, "last_32x32.png")
            Me.icArrowsLarge.InsertGalleryImage("movedown_32x32.png", "images/arrows/movedown_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/movedown_32x32.png"), 6)
            Me.icArrowsLarge.Images.SetKeyName(6, "movedown_32x32.png")
            Me.icArrowsLarge.InsertGalleryImage("moveup_32x32.png", "images/arrows/moveup_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/moveup_32x32.png"), 7)
            Me.icArrowsLarge.Images.SetKeyName(7, "moveup_32x32.png")
            Me.icArrowsLarge.InsertGalleryImage("next_32x32.png", "images/arrows/next_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/next_32x32.png"), 8)
            Me.icArrowsLarge.Images.SetKeyName(8, "next_32x32.png")
            Me.icArrowsLarge.InsertGalleryImage("prev_32x32.png", "images/arrows/prev_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/prev_32x32.png"), 9)
            Me.icArrowsLarge.Images.SetKeyName(9, "prev_32x32.png")
            ' 
            ' icExportSmall
            ' 
            Me.icExportSmall.ImageStream = (CType(resources.GetObject("icExportSmall.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
            Me.icExportSmall.InsertGalleryImage("export_16x16.png", "images/export/export_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/export_16x16.png"), 0)
            Me.icExportSmall.Images.SetKeyName(0, "export_16x16.png")
            Me.icExportSmall.InsertGalleryImage("exportfile_16x16.png", "images/export/exportfile_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exportfile_16x16.png"), 1)
            Me.icExportSmall.Images.SetKeyName(1, "exportfile_16x16.png")
            Me.icExportSmall.InsertGalleryImage("exporttocsv_16x16.png", "images/export/exporttocsv_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttocsv_16x16.png"), 2)
            Me.icExportSmall.Images.SetKeyName(2, "exporttocsv_16x16.png")
            Me.icExportSmall.InsertGalleryImage("exporttodoc_16x16.png", "images/export/exporttodoc_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttodoc_16x16.png"), 3)
            Me.icExportSmall.Images.SetKeyName(3, "exporttodoc_16x16.png")
            Me.icExportSmall.InsertGalleryImage("exporttodocx_16x16.png", "images/export/exporttodocx_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttodocx_16x16.png"), 4)
            Me.icExportSmall.Images.SetKeyName(4, "exporttodocx_16x16.png")
            Me.icExportSmall.InsertGalleryImage("exporttoepub_16x16.png", "images/export/exporttoepub_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttoepub_16x16.png"), 5)
            Me.icExportSmall.Images.SetKeyName(5, "exporttoepub_16x16.png")
            Me.icExportSmall.InsertGalleryImage("exporttohtml_16x16.png", "images/export/exporttohtml_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttohtml_16x16.png"), 6)
            Me.icExportSmall.Images.SetKeyName(6, "exporttohtml_16x16.png")
            Me.icExportSmall.InsertGalleryImage("exporttoimg_16x16.png", "images/export/exporttoimg_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttoimg_16x16.png"), 7)
            Me.icExportSmall.Images.SetKeyName(7, "exporttoimg_16x16.png")
            Me.icExportSmall.InsertGalleryImage("exporttomht_16x16.png", "images/export/exporttomht_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttomht_16x16.png"), 8)
            Me.icExportSmall.Images.SetKeyName(8, "exporttomht_16x16.png")
            Me.icExportSmall.InsertGalleryImage("exporttoodt_16x16.png", "images/export/exporttoodt_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttoodt_16x16.png"), 9)
            Me.icExportSmall.Images.SetKeyName(9, "exporttoodt_16x16.png")
            Me.icExportSmall.InsertGalleryImage("exporttopdf_16x16.png", "images/export/exporttopdf_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttopdf_16x16.png"), 10)
            Me.icExportSmall.Images.SetKeyName(10, "exporttopdf_16x16.png")
            Me.icExportSmall.InsertGalleryImage("exporttortf_16x16.png", "images/export/exporttortf_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttortf_16x16.png"), 11)
            Me.icExportSmall.Images.SetKeyName(11, "exporttortf_16x16.png")
            Me.icExportSmall.InsertGalleryImage("exporttotxt_16x16.png", "images/export/exporttotxt_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttotxt_16x16.png"), 12)
            Me.icExportSmall.Images.SetKeyName(12, "exporttotxt_16x16.png")
            Me.icExportSmall.InsertGalleryImage("exporttoxls_16x16.png", "images/export/exporttoxls_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttoxls_16x16.png"), 13)
            Me.icExportSmall.Images.SetKeyName(13, "exporttoxls_16x16.png")
            Me.icExportSmall.InsertGalleryImage("exporttoxlsx_16x16.png", "images/export/exporttoxlsx_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttoxlsx_16x16.png"), 14)
            Me.icExportSmall.Images.SetKeyName(14, "exporttoxlsx_16x16.png")
            Me.icExportSmall.InsertGalleryImage("exporttoxml_16x16.png", "images/export/exporttoxml_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttoxml_16x16.png"), 15)
            Me.icExportSmall.Images.SetKeyName(15, "exporttoxml_16x16.png")
            Me.icExportSmall.InsertGalleryImage("exporttoxps_16x16.png", "images/export/exporttoxps_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttoxps_16x16.png"), 16)
            Me.icExportSmall.Images.SetKeyName(16, "exporttoxps_16x16.png")
            ' 
            ' icExportLarge
            ' 
            Me.icExportLarge.ImageSize = New System.Drawing.Size(32, 32)
            Me.icExportLarge.ImageStream = (CType(resources.GetObject("icExportLarge.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
            Me.icExportLarge.InsertGalleryImage("export_32x32.png", "images/export/export_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/export_32x32.png"), 0)
            Me.icExportLarge.Images.SetKeyName(0, "export_32x32.png")
            Me.icExportLarge.InsertGalleryImage("exportfile_32x32.png", "images/export/exportfile_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exportfile_32x32.png"), 1)
            Me.icExportLarge.Images.SetKeyName(1, "exportfile_32x32.png")
            Me.icExportLarge.InsertGalleryImage("exporttocsv_32x32.png", "images/export/exporttocsv_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttocsv_32x32.png"), 2)
            Me.icExportLarge.Images.SetKeyName(2, "exporttocsv_32x32.png")
            Me.icExportLarge.InsertGalleryImage("exporttodoc_32x32.png", "images/export/exporttodoc_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttodoc_32x32.png"), 3)
            Me.icExportLarge.Images.SetKeyName(3, "exporttodoc_32x32.png")
            Me.icExportLarge.InsertGalleryImage("exporttodocx_32x32.png", "images/export/exporttodocx_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttodocx_32x32.png"), 4)
            Me.icExportLarge.Images.SetKeyName(4, "exporttodocx_32x32.png")
            Me.icExportLarge.InsertGalleryImage("exporttoepub_32x32.png", "images/export/exporttoepub_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttoepub_32x32.png"), 5)
            Me.icExportLarge.Images.SetKeyName(5, "exporttoepub_32x32.png")
            Me.icExportLarge.InsertGalleryImage("exporttohtml_32x32.png", "images/export/exporttohtml_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttohtml_32x32.png"), 6)
            Me.icExportLarge.Images.SetKeyName(6, "exporttohtml_32x32.png")
            Me.icExportLarge.InsertGalleryImage("exporttoimg_32x32.png", "images/export/exporttoimg_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttoimg_32x32.png"), 7)
            Me.icExportLarge.Images.SetKeyName(7, "exporttoimg_32x32.png")
            Me.icExportLarge.InsertGalleryImage("exporttomht_32x32.png", "images/export/exporttomht_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttomht_32x32.png"), 8)
            Me.icExportLarge.Images.SetKeyName(8, "exporttomht_32x32.png")
            Me.icExportLarge.InsertGalleryImage("exporttoodt_32x32.png", "images/export/exporttoodt_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttoodt_32x32.png"), 9)
            Me.icExportLarge.Images.SetKeyName(9, "exporttoodt_32x32.png")
            Me.icExportLarge.InsertGalleryImage("exporttopdf_32x32.png", "images/export/exporttopdf_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttopdf_32x32.png"), 10)
            Me.icExportLarge.Images.SetKeyName(10, "exporttopdf_32x32.png")
            Me.icExportLarge.InsertGalleryImage("exporttortf_32x32.png", "images/export/exporttortf_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttortf_32x32.png"), 11)
            Me.icExportLarge.Images.SetKeyName(11, "exporttortf_32x32.png")
            Me.icExportLarge.InsertGalleryImage("exporttotxt_32x32.png", "images/export/exporttotxt_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttotxt_32x32.png"), 12)
            Me.icExportLarge.Images.SetKeyName(12, "exporttotxt_32x32.png")
            Me.icExportLarge.InsertGalleryImage("exporttoxls_32x32.png", "images/export/exporttoxls_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttoxls_32x32.png"), 13)
            Me.icExportLarge.Images.SetKeyName(13, "exporttoxls_32x32.png")
            Me.icExportLarge.InsertGalleryImage("exporttoxlsx_32x32.png", "images/export/exporttoxlsx_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttoxlsx_32x32.png"), 14)
            Me.icExportLarge.Images.SetKeyName(14, "exporttoxlsx_32x32.png")
            Me.icExportLarge.InsertGalleryImage("exporttoxml_32x32.png", "images/export/exporttoxml_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttoxml_32x32.png"), 15)
            Me.icExportLarge.Images.SetKeyName(15, "exporttoxml_32x32.png")
            Me.icExportLarge.InsertGalleryImage("exporttoxps_32x32.png", "images/export/exporttoxps_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttoxps_32x32.png"), 16)
            Me.icExportLarge.Images.SetKeyName(16, "exporttoxps_32x32.png")
            ' 
            ' panelOptions
            ' 
            Me.panelOptions.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelOptions.Controls.Add(Me.gcOptionsBehavior)
            Me.panelOptions.Controls.Add(Me.gcOptionsMinimizing)
            Me.panelOptions.Controls.Add(Me.gcOptionsView)
            Me.panelOptions.Dock = System.Windows.Forms.DockStyle.Right
            Me.panelOptions.Location = New System.Drawing.Point(871, 5)
            Me.panelOptions.Name = "panelOptions"
            Me.panelOptions.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
            Me.panelOptions.Size = New System.Drawing.Size(311, 676)
            Me.panelOptions.TabIndex = 1
            ' 
            ' gcOptionsBehavior
            ' 
            Me.gcOptionsBehavior.Controls.Add(Me.ceAllowSmoothScrolling)
            Me.gcOptionsBehavior.Controls.Add(Me.lblItemSelectMode)
            Me.gcOptionsBehavior.Controls.Add(Me.cbeItemSelectMode)
            Me.gcOptionsBehavior.Location = New System.Drawing.Point(15, 345)
            Me.gcOptionsBehavior.Name = "gcOptionsBehavior"
            Me.gcOptionsBehavior.Size = New System.Drawing.Size(296, 103)
            Me.gcOptionsBehavior.TabIndex = 9
            Me.gcOptionsBehavior.Text = "Options Behavior"
            ' 
            ' lblItemSelectMode
            ' 
            Me.lblItemSelectMode.Location = New System.Drawing.Point(15, 36)
            Me.lblItemSelectMode.Name = "lblItemSelectMode"
            Me.lblItemSelectMode.Size = New System.Drawing.Size(87, 13)
            Me.lblItemSelectMode.TabIndex = 8
            Me.lblItemSelectMode.Text = "Item Select Mode:"
            ' 
            ' cbeItemSelectMode
            ' 
            Me.cbeItemSelectMode.Location = New System.Drawing.Point(147, 33)
            Me.cbeItemSelectMode.Name = "cbeItemSelectMode"
            Me.cbeItemSelectMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbeItemSelectMode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cbeItemSelectMode.Size = New System.Drawing.Size(135, 20)
            Me.cbeItemSelectMode.TabIndex = 7
            ' 
            ' gcOptionsMinimizing
            ' 
            Me.gcOptionsMinimizing.Controls.Add(Me.lblScrollMode)
            Me.gcOptionsMinimizing.Controls.Add(Me.cbMinimizingScrollMode)
            Me.gcOptionsMinimizing.Controls.Add(Me.labelColumnCountMinimizing)
            Me.gcOptionsMinimizing.Controls.Add(Me.seColumnCountMinimizing)
            Me.gcOptionsMinimizing.Location = New System.Drawing.Point(15, 215)
            Me.gcOptionsMinimizing.Name = "gcOptionsMinimizing"
            Me.gcOptionsMinimizing.Size = New System.Drawing.Size(296, 113)
            Me.gcOptionsMinimizing.TabIndex = 5
            Me.gcOptionsMinimizing.Text = "Options Minimizing"
            ' 
            ' lblScrollMode
            ' 
            Me.lblScrollMode.Location = New System.Drawing.Point(15, 74)
            Me.lblScrollMode.Name = "lblScrollMode"
            Me.lblScrollMode.Size = New System.Drawing.Size(58, 13)
            Me.lblScrollMode.TabIndex = 8
            Me.lblScrollMode.Text = "Scroll Mode:"
            ' 
            ' cbMinimizingScrollMode
            ' 
            Me.cbMinimizingScrollMode.Location = New System.Drawing.Point(147, 71)
            Me.cbMinimizingScrollMode.Name = "cbMinimizingScrollMode"
            Me.cbMinimizingScrollMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbMinimizingScrollMode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cbMinimizingScrollMode.Size = New System.Drawing.Size(135, 20)
            Me.cbMinimizingScrollMode.TabIndex = 7
            ' 
            ' labelColumnCountMinimizing
            ' 
            Me.labelColumnCountMinimizing.Location = New System.Drawing.Point(15, 37)
            Me.labelColumnCountMinimizing.Name = "labelColumnCountMinimizing"
            Me.labelColumnCountMinimizing.Size = New System.Drawing.Size(71, 13)
            Me.labelColumnCountMinimizing.TabIndex = 6
            Me.labelColumnCountMinimizing.Text = "Column Count:"
            ' 
            ' seColumnCountMinimizing
            ' 
            Me.seColumnCountMinimizing.EditValue = New Decimal(New Integer() { 2, 0, 0, 0})
            Me.seColumnCountMinimizing.Location = New System.Drawing.Point(147, 34)
            Me.seColumnCountMinimizing.Name = "seColumnCountMinimizing"
            Me.seColumnCountMinimizing.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.seColumnCountMinimizing.Properties.IsFloatValue = False
            Me.seColumnCountMinimizing.Properties.Mask.EditMask = "N00"
            Me.seColumnCountMinimizing.Properties.MaxValue = New Decimal(New Integer() { 5, 0, 0, 0})
            Me.seColumnCountMinimizing.Properties.MinValue = New Decimal(New Integer() { 1, 0, 0, 0})
            Me.seColumnCountMinimizing.Size = New System.Drawing.Size(135, 20)
            Me.seColumnCountMinimizing.TabIndex = 5
            ' 
            ' imagesSmall
            ' 
            Me.imagesSmall.ImageStream = (CType(resources.GetObject("imagesSmall.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
            Me.imagesSmall.InsertGalleryImage("contentarrangeinrows_16x16.png", "images/alignment/contentarrangeinrows_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/alignment/contentarrangeinrows_16x16.png"), 0)
            Me.imagesSmall.Images.SetKeyName(0, "contentarrangeinrows_16x16.png")
            Me.imagesSmall.InsertGalleryImage("gridlines_16x16.png", "images/grid/gridlines_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/grid/gridlines_16x16.png"), 1)
            Me.imagesSmall.Images.SetKeyName(1, "gridlines_16x16.png")
            ' 
            ' imagesLarge
            ' 
            Me.imagesLarge.ImageSize = New System.Drawing.Size(32, 32)
            Me.imagesLarge.ImageStream = (CType(resources.GetObject("imagesLarge.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
            Me.imagesLarge.InsertGalleryImage("contentarrangeinrows_32x32.png", "images/alignment/contentarrangeinrows_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/alignment/contentarrangeinrows_32x32.png"), 0)
            Me.imagesLarge.Images.SetKeyName(0, "contentarrangeinrows_32x32.png")
            Me.imagesLarge.InsertGalleryImage("cards_32x32.png", "images/grid/cards_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/grid/cards_32x32.png"), 1)
            Me.imagesLarge.Images.SetKeyName(1, "cards_32x32.png")
            ' 
            ' ToolboxModule
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.panelOptions)
            Me.Controls.Add(Me.splitContainerControl1)
            Me.Name = "ToolboxModule"
            Me.Padding = New System.Windows.Forms.Padding(5)
            Me.Size = New System.Drawing.Size(1187, 686)
            CType(Me.gcOptionsView, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gcOptionsView.ResumeLayout(False)
            Me.gcOptionsView.PerformLayout()
            CType(Me.ceGroupsContentAutoSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceShowSearchPanel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbItemViewMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.seColumnCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbImageSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceAllowSmoothScrolling.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.ResumeLayout(False)
            CType(Me.gcContent, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.icActionsSmall, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.icActionsLarge, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.icArrowsSmall, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.icArrowsLarge, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.icExportSmall, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.icExportLarge, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelOptions, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelOptions.ResumeLayout(False)
            CType(Me.gcOptionsBehavior, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gcOptionsBehavior.ResumeLayout(False)
            Me.gcOptionsBehavior.PerformLayout()
            CType(Me.cbeItemSelectMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gcOptionsMinimizing, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gcOptionsMinimizing.ResumeLayout(False)
            Me.gcOptionsMinimizing.PerformLayout()
            CType(Me.cbMinimizingScrollMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.seColumnCountMinimizing.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.imagesSmall, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.imagesLarge, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Private WithEvents xtraToolboxControl As DevExpress.XtraToolbox.ToolboxControl
        Private gcContent As SimpleContentPanel
        Private gcOptionsView As DevExpress.XtraEditors.GroupControl
        Private labelImageSize As DevExpress.XtraEditors.LabelControl
        Private WithEvents cbImageSize As DevExpress.XtraEditors.ComboBoxEdit
        Private labelItemViewMode As DevExpress.XtraEditors.LabelControl
        Private WithEvents cbItemViewMode As DevExpress.XtraEditors.ComboBoxEdit
        Private labelColumnCount As DevExpress.XtraEditors.LabelControl
        Private WithEvents seColumnCount As DevExpress.XtraEditors.SpinEdit
        Private WithEvents ceShowSearchPanel As DevExpress.XtraEditors.CheckEdit
        Private WithEvents ceGroupsContentAutoSize As DevExpress.XtraEditors.CheckEdit
        Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
        Private icActionsSmall As DevExpress.Utils.ImageCollection
        Private icActionsLarge As DevExpress.Utils.ImageCollection
        Private icArrowsSmall As DevExpress.Utils.ImageCollection
        Private icArrowsLarge As DevExpress.Utils.ImageCollection
        Private icExportSmall As DevExpress.Utils.ImageCollection
        Private icExportLarge As DevExpress.Utils.ImageCollection
        Private panelOptions As XtraEditors.PanelControl
        Private imagesSmall As DevExpress.Utils.ImageCollection
        Private imagesLarge As DevExpress.Utils.ImageCollection
        Private gcOptionsMinimizing As XtraEditors.GroupControl
        Private labelColumnCountMinimizing As XtraEditors.LabelControl
        Private WithEvents seColumnCountMinimizing As XtraEditors.SpinEdit
        Private lblScrollMode As XtraEditors.LabelControl
        Private cbMinimizingScrollMode As XtraEditors.ComboBoxEdit
        Private WithEvents ceAllowSmoothScrolling As XtraEditors.CheckEdit
        Private gcOptionsBehavior As XtraEditors.GroupControl
        Private lblItemSelectMode As XtraEditors.LabelControl
        Private WithEvents cbeItemSelectMode As XtraEditors.ComboBoxEdit
    End Class
End Namespace

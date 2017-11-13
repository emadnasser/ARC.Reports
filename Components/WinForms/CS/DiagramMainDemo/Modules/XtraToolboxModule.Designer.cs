namespace DevExpress.XtraDiagram.Demos {
    partial class ToolboxModule {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolboxModule));
            this.xtraToolboxControl = new DevExpress.XtraToolbox.ToolboxControl();
            this.gcOptionsView = new DevExpress.XtraEditors.GroupControl();
            this.ceGroupsContentAutoSize = new DevExpress.XtraEditors.CheckEdit();
            this.ceShowSearchPanel = new DevExpress.XtraEditors.CheckEdit();
            this.labelItemViewMode = new DevExpress.XtraEditors.LabelControl();
            this.cbItemViewMode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelColumnCount = new DevExpress.XtraEditors.LabelControl();
            this.seColumnCount = new DevExpress.XtraEditors.SpinEdit();
            this.cbImageSize = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelImageSize = new DevExpress.XtraEditors.LabelControl();
            this.ceAllowSmoothScrolling = new DevExpress.XtraEditors.CheckEdit();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gcContent = new DevExpress.XtraDiagram.Demos.SimpleContentPanel();
            this.icActionsSmall = new DevExpress.Utils.ImageCollection(this.components);
            this.icActionsLarge = new DevExpress.Utils.ImageCollection(this.components);
            this.icArrowsSmall = new DevExpress.Utils.ImageCollection(this.components);
            this.icArrowsLarge = new DevExpress.Utils.ImageCollection(this.components);
            this.icExportSmall = new DevExpress.Utils.ImageCollection(this.components);
            this.icExportLarge = new DevExpress.Utils.ImageCollection(this.components);
            this.panelOptions = new DevExpress.XtraEditors.PanelControl();
            this.gcOptionsBehavior = new DevExpress.XtraEditors.GroupControl();
            this.lblItemSelectMode = new DevExpress.XtraEditors.LabelControl();
            this.cbeItemSelectMode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gcOptionsMinimizing = new DevExpress.XtraEditors.GroupControl();
            this.lblScrollMode = new DevExpress.XtraEditors.LabelControl();
            this.cbMinimizingScrollMode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelColumnCountMinimizing = new DevExpress.XtraEditors.LabelControl();
            this.seColumnCountMinimizing = new DevExpress.XtraEditors.SpinEdit();
            this.imagesSmall = new DevExpress.Utils.ImageCollection(this.components);
            this.imagesLarge = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gcOptionsView)).BeginInit();
            this.gcOptionsView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceGroupsContentAutoSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowSearchPanel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbItemViewMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seColumnCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbImageSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowSmoothScrolling.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icActionsSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icActionsLarge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icArrowsSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icArrowsLarge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icExportSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icExportLarge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelOptions)).BeginInit();
            this.panelOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcOptionsBehavior)).BeginInit();
            this.gcOptionsBehavior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbeItemSelectMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcOptionsMinimizing)).BeginInit();
            this.gcOptionsMinimizing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbMinimizingScrollMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seColumnCountMinimizing.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagesSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagesLarge)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraToolboxControl
            // 
            this.xtraToolboxControl.Appearance.Toolbox.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraToolboxControl.Appearance.Toolbox.Options.UseFont = true;
            this.xtraToolboxControl.Caption = "";
            this.xtraToolboxControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraToolboxControl.Location = new System.Drawing.Point(0, 0);
            this.xtraToolboxControl.Name = "xtraToolboxControl";
            this.xtraToolboxControl.OptionsBehavior.AllowSmoothScrolling = true;
            this.xtraToolboxControl.OptionsBehavior.ItemSelectMode = DevExpress.XtraToolbox.ToolboxItemSelectMode.Multiple;
            this.xtraToolboxControl.OptionsView.ItemImageSize = new System.Drawing.Size(32, 32);
            this.xtraToolboxControl.OptionsView.MenuButtonImage = ((System.Drawing.Image)(resources.GetObject("toolboxControl.OptionsView.MenuButtonImage")));
            this.xtraToolboxControl.OptionsView.ShowMenuButton = false;
            this.xtraToolboxControl.OptionsView.ShowToolboxCaption = true;
            this.xtraToolboxControl.Size = new System.Drawing.Size(273, 676);
            this.xtraToolboxControl.TabIndex = 0;
            this.xtraToolboxControl.DragItemDrop += new DevExpress.XtraToolbox.ToolboxDragItemDropEventHandler(this.OnToolboxDragItemDrop);
            this.xtraToolboxControl.DragItemStart += new DevExpress.XtraToolbox.ToolboxDragItemStartEventHandler(this.OnToolboxDragItemStart);
            this.xtraToolboxControl.DragItemMove += new DevExpress.XtraToolbox.ToolboxDragItemMoveEventHandler(this.OnToolboxDragItemMove);
            this.xtraToolboxControl.StateChanged += new DevExpress.XtraToolbox.ToolboxStateChangedEventHandler(this.OnToolboxStateChanged);
            this.xtraToolboxControl.SizeChanged += new System.EventHandler(this.OnXtraToolboxSizeChanged);
            // 
            // gcOptionsView
            // 
            this.gcOptionsView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcOptionsView.Controls.Add(this.ceGroupsContentAutoSize);
            this.gcOptionsView.Controls.Add(this.ceShowSearchPanel);
            this.gcOptionsView.Controls.Add(this.labelItemViewMode);
            this.gcOptionsView.Controls.Add(this.cbItemViewMode);
            this.gcOptionsView.Controls.Add(this.labelColumnCount);
            this.gcOptionsView.Controls.Add(this.seColumnCount);
            this.gcOptionsView.Controls.Add(this.cbImageSize);
            this.gcOptionsView.Controls.Add(this.labelImageSize);
            this.gcOptionsView.Location = new System.Drawing.Point(15, 0);
            this.gcOptionsView.Name = "gcOptionsView";
            this.gcOptionsView.Size = new System.Drawing.Size(296, 200);
            this.gcOptionsView.TabIndex = 2;
            this.gcOptionsView.Text = "Options View";
            // 
            // ceGroupsContentAutoSize
            // 
            this.ceGroupsContentAutoSize.Location = new System.Drawing.Point(15, 165);
            this.ceGroupsContentAutoSize.Name = "ceGroupsContentAutoSize";
            this.ceGroupsContentAutoSize.Properties.Caption = "Groups Content Auto Size";
            this.ceGroupsContentAutoSize.Size = new System.Drawing.Size(269, 19);
            this.ceGroupsContentAutoSize.TabIndex = 9;
            this.ceGroupsContentAutoSize.CheckedChanged += new System.EventHandler(this.OnGroupsContentAutoSizeChanged);
            // 
            // ceShowSearchPanel
            // 
            this.ceShowSearchPanel.Location = new System.Drawing.Point(15, 136);
            this.ceShowSearchPanel.Name = "ceShowSearchPanel";
            this.ceShowSearchPanel.Properties.Caption = "Show Search Panel";
            this.ceShowSearchPanel.Size = new System.Drawing.Size(269, 19);
            this.ceShowSearchPanel.TabIndex = 8;
            this.ceShowSearchPanel.CheckedChanged += new System.EventHandler(this.OnShowSearchPanelChanged);
            // 
            // labelItemViewMode
            // 
            this.labelItemViewMode.Location = new System.Drawing.Point(15, 104);
            this.labelItemViewMode.Name = "labelItemViewMode";
            this.labelItemViewMode.Size = new System.Drawing.Size(80, 13);
            this.labelItemViewMode.TabIndex = 6;
            this.labelItemViewMode.Text = "Item View Mode:";
            // 
            // cbItemViewMode
            // 
            this.cbItemViewMode.Location = new System.Drawing.Point(147, 101);
            this.cbItemViewMode.Name = "cbItemViewMode";
            this.cbItemViewMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbItemViewMode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbItemViewMode.Size = new System.Drawing.Size(135, 20);
            this.cbItemViewMode.TabIndex = 5;
            this.cbItemViewMode.SelectedIndexChanged += new System.EventHandler(this.OnItemViewModeChanged);
            // 
            // labelColumnCount
            // 
            this.labelColumnCount.Location = new System.Drawing.Point(15, 70);
            this.labelColumnCount.Name = "labelColumnCount";
            this.labelColumnCount.Size = new System.Drawing.Size(71, 13);
            this.labelColumnCount.TabIndex = 4;
            this.labelColumnCount.Text = "Column Count:";
            // 
            // seColumnCount
            // 
            this.seColumnCount.EditValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.seColumnCount.Location = new System.Drawing.Point(147, 67);
            this.seColumnCount.Name = "seColumnCount";
            this.seColumnCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seColumnCount.Properties.IsFloatValue = false;
            this.seColumnCount.Properties.Mask.EditMask = "N00";
            this.seColumnCount.Properties.MaxValue = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.seColumnCount.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seColumnCount.Size = new System.Drawing.Size(135, 20);
            this.seColumnCount.TabIndex = 3;
            this.seColumnCount.EditValueChanged += new System.EventHandler(this.OnColumnCountChanged);
            // 
            // cbImageSize
            // 
            this.cbImageSize.EditValue = "32x32";
            this.cbImageSize.Location = new System.Drawing.Point(147, 33);
            this.cbImageSize.Name = "cbImageSize";
            this.cbImageSize.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbImageSize.Properties.Items.AddRange(new object[] {
            "16x16",
            "32x32"});
            this.cbImageSize.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbImageSize.Size = new System.Drawing.Size(135, 20);
            this.cbImageSize.TabIndex = 2;
            this.cbImageSize.SelectedIndexChanged += new System.EventHandler(this.OnImageSizeChanged);
            // 
            // labelImageSize
            // 
            this.labelImageSize.Location = new System.Drawing.Point(15, 36);
            this.labelImageSize.Name = "labelImageSize";
            this.labelImageSize.Size = new System.Drawing.Size(56, 13);
            this.labelImageSize.TabIndex = 1;
            this.labelImageSize.Text = "Image Size:";
            // 
            // ceAllowSmoothScrolling
            // 
            this.ceAllowSmoothScrolling.Location = new System.Drawing.Point(15, 68);
            this.ceAllowSmoothScrolling.Name = "ceAllowSmoothScrolling";
            this.ceAllowSmoothScrolling.Properties.Caption = "Allow Smooth Scrolling";
            this.ceAllowSmoothScrolling.Size = new System.Drawing.Size(269, 19);
            this.ceAllowSmoothScrolling.TabIndex = 10;
            this.ceAllowSmoothScrolling.CheckedChanged += new System.EventHandler(this.OnAllowSmoothScrollingChanged);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerControl1.Location = new System.Drawing.Point(5, 5);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.xtraToolboxControl);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gcContent);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(866, 676);
            this.splitContainerControl1.SplitterPosition = 273;
            this.splitContainerControl1.TabIndex = 5;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gcContent
            // 
            this.gcContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcContent.Location = new System.Drawing.Point(0, 0);
            this.gcContent.Name = "gcContent";
            this.gcContent.Size = new System.Drawing.Size(588, 676);
            this.gcContent.TabIndex = 1;
            this.gcContent.Text = "Content";
            // 
            // icActionsSmall
            // 
            this.icActionsSmall.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("icActionsSmall.ImageStream")));
            this.icActionsSmall.InsertGalleryImage("add_16x16.png", "images/actions/add_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/add_16x16.png"), 0);
            this.icActionsSmall.Images.SetKeyName(0, "add_16x16.png");
            this.icActionsSmall.InsertGalleryImage("addfile_16x16.png", "images/actions/addfile_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/addfile_16x16.png"), 1);
            this.icActionsSmall.Images.SetKeyName(1, "addfile_16x16.png");
            this.icActionsSmall.InsertGalleryImage("additem_16x16.png", "images/actions/additem_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/additem_16x16.png"), 2);
            this.icActionsSmall.Images.SetKeyName(2, "additem_16x16.png");
            this.icActionsSmall.InsertGalleryImage("apply_16x16.png", "images/actions/apply_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/apply_16x16.png"), 3);
            this.icActionsSmall.Images.SetKeyName(3, "apply_16x16.png");
            this.icActionsSmall.InsertGalleryImage("cancel_16x16.png", "images/actions/cancel_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cancel_16x16.png"), 4);
            this.icActionsSmall.Images.SetKeyName(4, "cancel_16x16.png");
            this.icActionsSmall.InsertGalleryImage("clear_16x16.png", "images/actions/clear_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/clear_16x16.png"), 5);
            this.icActionsSmall.Images.SetKeyName(5, "clear_16x16.png");
            this.icActionsSmall.InsertGalleryImage("clearformatting_16x16.png", "images/actions/clearformatting_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/clearformatting_16x16.png"), 6);
            this.icActionsSmall.Images.SetKeyName(6, "clearformatting_16x16.png");
            this.icActionsSmall.InsertGalleryImage("cleartablestyle_16x16.png", "images/actions/cleartablestyle_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cleartablestyle_16x16.png"), 7);
            this.icActionsSmall.Images.SetKeyName(7, "cleartablestyle_16x16.png");
            this.icActionsSmall.InsertGalleryImage("clip_16x16.png", "images/actions/clip_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/clip_16x16.png"), 8);
            this.icActionsSmall.Images.SetKeyName(8, "clip_16x16.png");
            this.icActionsSmall.InsertGalleryImage("close_16x16.png", "images/actions/close_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/close_16x16.png"), 9);
            this.icActionsSmall.Images.SetKeyName(9, "close_16x16.png");
            this.icActionsSmall.InsertGalleryImage("convert_16x16.png", "images/actions/convert_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/convert_16x16.png"), 10);
            this.icActionsSmall.Images.SetKeyName(10, "convert_16x16.png");
            this.icActionsSmall.InsertGalleryImage("converttorange_16x16.png", "images/actions/converttorange_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/converttorange_16x16.png"), 11);
            this.icActionsSmall.Images.SetKeyName(11, "converttorange_16x16.png");
            this.icActionsSmall.InsertGalleryImage("deletelist_16x16.png", "images/actions/deletelist_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/deletelist_16x16.png"), 12);
            this.icActionsSmall.Images.SetKeyName(12, "deletelist_16x16.png");
            this.icActionsSmall.InsertGalleryImage("deletelist2_16x16.png", "images/actions/deletelist2_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/deletelist2_16x16.png"), 13);
            this.icActionsSmall.Images.SetKeyName(13, "deletelist2_16x16.png");
            this.icActionsSmall.InsertGalleryImage("down_16x16.png", "images/actions/down_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/down_16x16.png"), 14);
            this.icActionsSmall.Images.SetKeyName(14, "down_16x16.png");
            this.icActionsSmall.InsertGalleryImage("download_16x16.png", "images/actions/download_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/download_16x16.png"), 15);
            this.icActionsSmall.Images.SetKeyName(15, "download_16x16.png");
            this.icActionsSmall.InsertGalleryImage("editname_16x16.png", "images/actions/editname_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/editname_16x16.png"), 16);
            this.icActionsSmall.Images.SetKeyName(16, "editname_16x16.png");
            this.icActionsSmall.InsertGalleryImage("fill_16x16.png", "images/actions/fill_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/fill_16x16.png"), 17);
            this.icActionsSmall.Images.SetKeyName(17, "fill_16x16.png");
            this.icActionsSmall.InsertGalleryImage("formatastable_16x16.png", "images/actions/formatastable_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/formatastable_16x16.png"), 18);
            this.icActionsSmall.Images.SetKeyName(18, "formatastable_16x16.png");
            this.icActionsSmall.InsertGalleryImage("group_16x16.png", "images/actions/group_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/group_16x16.png"), 19);
            this.icActionsSmall.Images.SetKeyName(19, "group_16x16.png");
            this.icActionsSmall.InsertGalleryImage("group2_16x16.png", "images/actions/group2_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/group2_16x16.png"), 20);
            this.icActionsSmall.Images.SetKeyName(20, "group2_16x16.png");
            this.icActionsSmall.InsertGalleryImage("hide_16x16.png", "images/actions/hide_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/hide_16x16.png"), 21);
            this.icActionsSmall.Images.SetKeyName(21, "hide_16x16.png");
            this.icActionsSmall.InsertGalleryImage("importimage_16x16.png", "images/actions/importimage_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/importimage_16x16.png"), 22);
            this.icActionsSmall.Images.SetKeyName(22, "importimage_16x16.png");
            this.icActionsSmall.InsertGalleryImage("insert_16x16.png", "images/actions/insert_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/insert_16x16.png"), 23);
            this.icActionsSmall.Images.SetKeyName(23, "insert_16x16.png");
            this.icActionsSmall.InsertGalleryImage("left_16x16.png", "images/actions/left_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/left_16x16.png"), 24);
            this.icActionsSmall.Images.SetKeyName(24, "left_16x16.png");
            this.icActionsSmall.InsertGalleryImage("loadfrom_16x16.png", "images/actions/loadfrom_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/loadfrom_16x16.png"), 25);
            this.icActionsSmall.Images.SetKeyName(25, "loadfrom_16x16.png");
            this.icActionsSmall.InsertGalleryImage("merge_16x16.png", "images/actions/merge_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/merge_16x16.png"), 26);
            this.icActionsSmall.Images.SetKeyName(26, "merge_16x16.png");
            this.icActionsSmall.InsertGalleryImage("new_16x16.png", "images/actions/new_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/new_16x16.png"), 27);
            this.icActionsSmall.Images.SetKeyName(27, "new_16x16.png");
            this.icActionsSmall.InsertGalleryImage("newtablestyle_16x16.png", "images/actions/newtablestyle_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/newtablestyle_16x16.png"), 28);
            this.icActionsSmall.Images.SetKeyName(28, "newtablestyle_16x16.png");
            this.icActionsSmall.InsertGalleryImage("open_16x16.png", "images/actions/open_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/open_16x16.png"), 29);
            this.icActionsSmall.Images.SetKeyName(29, "open_16x16.png");
            this.icActionsSmall.InsertGalleryImage("open2_16x16.png", "images/actions/open2_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/open2_16x16.png"), 30);
            this.icActionsSmall.Images.SetKeyName(30, "open2_16x16.png");
            this.icActionsSmall.InsertGalleryImage("openhyperlink_16x16.png", "images/actions/openhyperlink_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/openhyperlink_16x16.png"), 31);
            this.icActionsSmall.Images.SetKeyName(31, "openhyperlink_16x16.png");
            this.icActionsSmall.InsertGalleryImage("reading_16x16.png", "images/actions/reading_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/reading_16x16.png"), 32);
            this.icActionsSmall.Images.SetKeyName(32, "reading_16x16.png");
            this.icActionsSmall.InsertGalleryImage("refresh_16x16.png", "images/actions/refresh_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/refresh_16x16.png"), 33);
            this.icActionsSmall.Images.SetKeyName(33, "refresh_16x16.png");
            this.icActionsSmall.InsertGalleryImage("refresh2_16x16.png", "images/actions/refresh2_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/refresh2_16x16.png"), 34);
            this.icActionsSmall.Images.SetKeyName(34, "refresh2_16x16.png");
            this.icActionsSmall.InsertGalleryImage("remove_16x16.png", "images/actions/remove_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/remove_16x16.png"), 35);
            this.icActionsSmall.Images.SetKeyName(35, "remove_16x16.png");
            this.icActionsSmall.InsertGalleryImage("removeitem_16x16.png", "images/actions/removeitem_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/removeitem_16x16.png"), 36);
            this.icActionsSmall.Images.SetKeyName(36, "removeitem_16x16.png");
            this.icActionsSmall.InsertGalleryImage("reset_16x16.png", "images/actions/reset_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/reset_16x16.png"), 37);
            this.icActionsSmall.Images.SetKeyName(37, "reset_16x16.png");
            this.icActionsSmall.InsertGalleryImage("reset2_16x16.png", "images/actions/reset2_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/reset2_16x16.png"), 38);
            this.icActionsSmall.Images.SetKeyName(38, "reset2_16x16.png");
            this.icActionsSmall.InsertGalleryImage("right_16x16.png", "images/actions/right_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/right_16x16.png"), 39);
            this.icActionsSmall.Images.SetKeyName(39, "right_16x16.png");
            this.icActionsSmall.InsertGalleryImage("selectall_16x16.png", "images/actions/selectall_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/selectall_16x16.png"), 40);
            this.icActionsSmall.Images.SetKeyName(40, "selectall_16x16.png");
            this.icActionsSmall.InsertGalleryImage("selectall2_16x16.png", "images/actions/selectall2_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/selectall2_16x16.png"), 41);
            this.icActionsSmall.Images.SetKeyName(41, "selectall2_16x16.png");
            this.icActionsSmall.InsertGalleryImage("show_16x16.png", "images/actions/show_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/show_16x16.png"), 42);
            this.icActionsSmall.Images.SetKeyName(42, "show_16x16.png");
            this.icActionsSmall.InsertGalleryImage("squeeze_16x16.png", "images/actions/squeeze_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/squeeze_16x16.png"), 43);
            this.icActionsSmall.Images.SetKeyName(43, "squeeze_16x16.png");
            this.icActionsSmall.InsertGalleryImage("stretch_16x16.png", "images/actions/stretch_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/stretch_16x16.png"), 44);
            this.icActionsSmall.Images.SetKeyName(44, "stretch_16x16.png");
            this.icActionsSmall.InsertGalleryImage("switchrowcolumn_16x16.png", "images/actions/switchrowcolumn_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/switchrowcolumn_16x16.png"), 45);
            this.icActionsSmall.Images.SetKeyName(45, "switchrowcolumn_16x16.png");
            this.icActionsSmall.InsertGalleryImage("up2_16x16.png", "images/actions/up2_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/up2_16x16.png"), 46);
            this.icActionsSmall.Images.SetKeyName(46, "up2_16x16.png");
            // 
            // icActionsLarge
            // 
            this.icActionsLarge.ImageSize = new System.Drawing.Size(32, 32);
            this.icActionsLarge.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("icActionsLarge.ImageStream")));
            this.icActionsLarge.InsertGalleryImage("add_32x32.png", "images/actions/add_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/add_32x32.png"), 0);
            this.icActionsLarge.Images.SetKeyName(0, "add_32x32.png");
            this.icActionsLarge.InsertGalleryImage("addfile_32x32.png", "images/actions/addfile_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/addfile_32x32.png"), 1);
            this.icActionsLarge.Images.SetKeyName(1, "addfile_32x32.png");
            this.icActionsLarge.InsertGalleryImage("additem_32x32.png", "images/actions/additem_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/additem_32x32.png"), 2);
            this.icActionsLarge.Images.SetKeyName(2, "additem_32x32.png");
            this.icActionsLarge.InsertGalleryImage("apply_32x32.png", "images/actions/apply_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/apply_32x32.png"), 3);
            this.icActionsLarge.Images.SetKeyName(3, "apply_32x32.png");
            this.icActionsLarge.InsertGalleryImage("cancel_32x32.png", "images/actions/cancel_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cancel_32x32.png"), 4);
            this.icActionsLarge.Images.SetKeyName(4, "cancel_32x32.png");
            this.icActionsLarge.InsertGalleryImage("clear_32x32.png", "images/actions/clear_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/clear_32x32.png"), 5);
            this.icActionsLarge.Images.SetKeyName(5, "clear_32x32.png");
            this.icActionsLarge.InsertGalleryImage("clearformatting_32x32.png", "images/actions/clearformatting_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/clearformatting_32x32.png"), 6);
            this.icActionsLarge.Images.SetKeyName(6, "clearformatting_32x32.png");
            this.icActionsLarge.InsertGalleryImage("cleartablestyle_32x32.png", "images/actions/cleartablestyle_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cleartablestyle_32x32.png"), 7);
            this.icActionsLarge.Images.SetKeyName(7, "cleartablestyle_32x32.png");
            this.icActionsLarge.InsertGalleryImage("clip_32x32.png", "images/actions/clip_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/clip_32x32.png"), 8);
            this.icActionsLarge.Images.SetKeyName(8, "clip_32x32.png");
            this.icActionsLarge.InsertGalleryImage("close_32x32.png", "images/actions/close_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/close_32x32.png"), 9);
            this.icActionsLarge.Images.SetKeyName(9, "close_32x32.png");
            this.icActionsLarge.InsertGalleryImage("convert_32x32.png", "images/actions/convert_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/convert_32x32.png"), 10);
            this.icActionsLarge.Images.SetKeyName(10, "convert_32x32.png");
            this.icActionsLarge.InsertGalleryImage("converttorange_32x32.png", "images/actions/converttorange_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/converttorange_32x32.png"), 11);
            this.icActionsLarge.Images.SetKeyName(11, "converttorange_32x32.png");
            this.icActionsLarge.InsertGalleryImage("deletelist_32x32.png", "images/actions/deletelist_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/deletelist_32x32.png"), 12);
            this.icActionsLarge.Images.SetKeyName(12, "deletelist_32x32.png");
            this.icActionsLarge.InsertGalleryImage("deletelist2_32x32.png", "images/actions/deletelist2_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/deletelist2_32x32.png"), 13);
            this.icActionsLarge.Images.SetKeyName(13, "deletelist2_32x32.png");
            this.icActionsLarge.InsertGalleryImage("down_32x32.png", "images/actions/down_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/down_32x32.png"), 14);
            this.icActionsLarge.Images.SetKeyName(14, "down_32x32.png");
            this.icActionsLarge.InsertGalleryImage("download_32x32.png", "images/actions/download_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/download_32x32.png"), 15);
            this.icActionsLarge.Images.SetKeyName(15, "download_32x32.png");
            this.icActionsLarge.InsertGalleryImage("editname_32x32.png", "images/actions/editname_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/editname_32x32.png"), 16);
            this.icActionsLarge.Images.SetKeyName(16, "editname_32x32.png");
            this.icActionsLarge.InsertGalleryImage("fill_32x32.png", "images/actions/fill_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/fill_32x32.png"), 17);
            this.icActionsLarge.Images.SetKeyName(17, "fill_32x32.png");
            this.icActionsLarge.InsertGalleryImage("formatastable_32x32.png", "images/actions/formatastable_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/formatastable_32x32.png"), 18);
            this.icActionsLarge.Images.SetKeyName(18, "formatastable_32x32.png");
            this.icActionsLarge.InsertGalleryImage("group_32x32.png", "images/actions/group_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/group_32x32.png"), 19);
            this.icActionsLarge.Images.SetKeyName(19, "group_32x32.png");
            this.icActionsLarge.InsertGalleryImage("group2_32x32.png", "images/actions/group2_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/group2_32x32.png"), 20);
            this.icActionsLarge.Images.SetKeyName(20, "group2_32x32.png");
            this.icActionsLarge.InsertGalleryImage("hide_32x32.png", "images/actions/hide_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/hide_32x32.png"), 21);
            this.icActionsLarge.Images.SetKeyName(21, "hide_32x32.png");
            this.icActionsLarge.InsertGalleryImage("importimage_32x32.png", "images/actions/importimage_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/importimage_32x32.png"), 22);
            this.icActionsLarge.Images.SetKeyName(22, "importimage_32x32.png");
            this.icActionsLarge.InsertGalleryImage("insert_32x32.png", "images/actions/insert_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/insert_32x32.png"), 23);
            this.icActionsLarge.Images.SetKeyName(23, "insert_32x32.png");
            this.icActionsLarge.InsertGalleryImage("left_32x32.png", "images/actions/left_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/left_32x32.png"), 24);
            this.icActionsLarge.Images.SetKeyName(24, "left_32x32.png");
            this.icActionsLarge.InsertGalleryImage("loadfrom_32x32.png", "images/actions/loadfrom_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/loadfrom_32x32.png"), 25);
            this.icActionsLarge.Images.SetKeyName(25, "loadfrom_32x32.png");
            this.icActionsLarge.InsertGalleryImage("merge_32x32.png", "images/actions/merge_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/merge_32x32.png"), 26);
            this.icActionsLarge.Images.SetKeyName(26, "merge_32x32.png");
            this.icActionsLarge.InsertGalleryImage("new_32x32.png", "images/actions/new_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/new_32x32.png"), 27);
            this.icActionsLarge.Images.SetKeyName(27, "new_32x32.png");
            this.icActionsLarge.InsertGalleryImage("newtablestyle_32x32.png", "images/actions/newtablestyle_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/newtablestyle_32x32.png"), 28);
            this.icActionsLarge.Images.SetKeyName(28, "newtablestyle_32x32.png");
            this.icActionsLarge.InsertGalleryImage("open_32x32.png", "images/actions/open_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/open_32x32.png"), 29);
            this.icActionsLarge.Images.SetKeyName(29, "open_32x32.png");
            this.icActionsLarge.InsertGalleryImage("open2_32x32.png", "images/actions/open2_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/open2_32x32.png"), 30);
            this.icActionsLarge.Images.SetKeyName(30, "open2_32x32.png");
            this.icActionsLarge.InsertGalleryImage("openhyperlink_32x32.png", "images/actions/openhyperlink_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/openhyperlink_32x32.png"), 31);
            this.icActionsLarge.Images.SetKeyName(31, "openhyperlink_32x32.png");
            this.icActionsLarge.InsertGalleryImage("reading_32x32.png", "images/actions/reading_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/reading_32x32.png"), 32);
            this.icActionsLarge.Images.SetKeyName(32, "reading_32x32.png");
            this.icActionsLarge.InsertGalleryImage("refresh_32x32.png", "images/actions/refresh_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/refresh_32x32.png"), 33);
            this.icActionsLarge.Images.SetKeyName(33, "refresh_32x32.png");
            this.icActionsLarge.InsertGalleryImage("refresh2_32x32.png", "images/actions/refresh2_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/refresh2_32x32.png"), 34);
            this.icActionsLarge.Images.SetKeyName(34, "refresh2_32x32.png");
            this.icActionsLarge.InsertGalleryImage("remove_32x32.png", "images/actions/remove_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/remove_32x32.png"), 35);
            this.icActionsLarge.Images.SetKeyName(35, "remove_32x32.png");
            this.icActionsLarge.InsertGalleryImage("removeitem_32x32.png", "images/actions/removeitem_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/removeitem_32x32.png"), 36);
            this.icActionsLarge.Images.SetKeyName(36, "removeitem_32x32.png");
            this.icActionsLarge.InsertGalleryImage("reset_32x32.png", "images/actions/reset_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/reset_32x32.png"), 37);
            this.icActionsLarge.Images.SetKeyName(37, "reset_32x32.png");
            this.icActionsLarge.InsertGalleryImage("reset2_32x32.png", "images/actions/reset2_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/reset2_32x32.png"), 38);
            this.icActionsLarge.Images.SetKeyName(38, "reset2_32x32.png");
            this.icActionsLarge.InsertGalleryImage("right_32x32.png", "images/actions/right_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/right_32x32.png"), 39);
            this.icActionsLarge.Images.SetKeyName(39, "right_32x32.png");
            this.icActionsLarge.InsertGalleryImage("selectall_32x32.png", "images/actions/selectall_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/selectall_32x32.png"), 40);
            this.icActionsLarge.Images.SetKeyName(40, "selectall_32x32.png");
            this.icActionsLarge.InsertGalleryImage("selectall2_32x32.png", "images/actions/selectall2_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/selectall2_32x32.png"), 41);
            this.icActionsLarge.Images.SetKeyName(41, "selectall2_32x32.png");
            this.icActionsLarge.InsertGalleryImage("show_32x32.png", "images/actions/show_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/show_32x32.png"), 42);
            this.icActionsLarge.Images.SetKeyName(42, "show_32x32.png");
            this.icActionsLarge.InsertGalleryImage("squeeze_32x32.png", "images/actions/squeeze_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/squeeze_32x32.png"), 43);
            this.icActionsLarge.Images.SetKeyName(43, "squeeze_32x32.png");
            this.icActionsLarge.InsertGalleryImage("stretch_32x32.png", "images/actions/stretch_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/stretch_32x32.png"), 44);
            this.icActionsLarge.Images.SetKeyName(44, "stretch_32x32.png");
            this.icActionsLarge.InsertGalleryImage("switchrowcolumn_32x32.png", "images/actions/switchrowcolumn_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/switchrowcolumn_32x32.png"), 45);
            this.icActionsLarge.Images.SetKeyName(45, "switchrowcolumn_32x32.png");
            this.icActionsLarge.InsertGalleryImage("up2_32x32.png", "images/actions/up2_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/up2_32x32.png"), 46);
            this.icActionsLarge.Images.SetKeyName(46, "up2_32x32.png");
            // 
            // icArrowsSmall
            // 
            this.icArrowsSmall.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("icArrowsSmall.ImageStream")));
            this.icArrowsSmall.InsertGalleryImage("doublefirst_16x16.png", "images/arrows/doublefirst_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/doublefirst_16x16.png"), 0);
            this.icArrowsSmall.Images.SetKeyName(0, "doublefirst_16x16.png");
            this.icArrowsSmall.InsertGalleryImage("doublelast_16x16.png", "images/arrows/doublelast_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/doublelast_16x16.png"), 1);
            this.icArrowsSmall.Images.SetKeyName(1, "doublelast_16x16.png");
            this.icArrowsSmall.InsertGalleryImage("doublenext_16x16.png", "images/arrows/doublenext_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/doublenext_16x16.png"), 2);
            this.icArrowsSmall.Images.SetKeyName(2, "doublenext_16x16.png");
            this.icArrowsSmall.InsertGalleryImage("doubleprev_16x16.png", "images/arrows/doubleprev_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/doubleprev_16x16.png"), 3);
            this.icArrowsSmall.Images.SetKeyName(3, "doubleprev_16x16.png");
            this.icArrowsSmall.InsertGalleryImage("first_16x16.png", "images/arrows/first_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/first_16x16.png"), 4);
            this.icArrowsSmall.Images.SetKeyName(4, "first_16x16.png");
            this.icArrowsSmall.InsertGalleryImage("last_16x16.png", "images/arrows/last_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/last_16x16.png"), 5);
            this.icArrowsSmall.Images.SetKeyName(5, "last_16x16.png");
            this.icArrowsSmall.InsertGalleryImage("movedown_16x16.png", "images/arrows/movedown_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/movedown_16x16.png"), 6);
            this.icArrowsSmall.Images.SetKeyName(6, "movedown_16x16.png");
            this.icArrowsSmall.InsertGalleryImage("moveup_16x16.png", "images/arrows/moveup_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/moveup_16x16.png"), 7);
            this.icArrowsSmall.Images.SetKeyName(7, "moveup_16x16.png");
            this.icArrowsSmall.InsertGalleryImage("next_16x16.png", "images/arrows/next_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/next_16x16.png"), 8);
            this.icArrowsSmall.Images.SetKeyName(8, "next_16x16.png");
            this.icArrowsSmall.InsertGalleryImage("prev_16x16.png", "images/arrows/prev_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/prev_16x16.png"), 9);
            this.icArrowsSmall.Images.SetKeyName(9, "prev_16x16.png");
            // 
            // icArrowsLarge
            // 
            this.icArrowsLarge.ImageSize = new System.Drawing.Size(32, 32);
            this.icArrowsLarge.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("icArrowsLarge.ImageStream")));
            this.icArrowsLarge.InsertGalleryImage("doublefirst_32x32.png", "images/arrows/doublefirst_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/doublefirst_32x32.png"), 0);
            this.icArrowsLarge.Images.SetKeyName(0, "doublefirst_32x32.png");
            this.icArrowsLarge.InsertGalleryImage("doublelast_32x32.png", "images/arrows/doublelast_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/doublelast_32x32.png"), 1);
            this.icArrowsLarge.Images.SetKeyName(1, "doublelast_32x32.png");
            this.icArrowsLarge.InsertGalleryImage("doublenext_32x32.png", "images/arrows/doublenext_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/doublenext_32x32.png"), 2);
            this.icArrowsLarge.Images.SetKeyName(2, "doublenext_32x32.png");
            this.icArrowsLarge.InsertGalleryImage("doubleprev_32x32.png", "images/arrows/doubleprev_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/doubleprev_32x32.png"), 3);
            this.icArrowsLarge.Images.SetKeyName(3, "doubleprev_32x32.png");
            this.icArrowsLarge.InsertGalleryImage("first_32x32.png", "images/arrows/first_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/first_32x32.png"), 4);
            this.icArrowsLarge.Images.SetKeyName(4, "first_32x32.png");
            this.icArrowsLarge.InsertGalleryImage("last_32x32.png", "images/arrows/last_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/last_32x32.png"), 5);
            this.icArrowsLarge.Images.SetKeyName(5, "last_32x32.png");
            this.icArrowsLarge.InsertGalleryImage("movedown_32x32.png", "images/arrows/movedown_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/movedown_32x32.png"), 6);
            this.icArrowsLarge.Images.SetKeyName(6, "movedown_32x32.png");
            this.icArrowsLarge.InsertGalleryImage("moveup_32x32.png", "images/arrows/moveup_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/moveup_32x32.png"), 7);
            this.icArrowsLarge.Images.SetKeyName(7, "moveup_32x32.png");
            this.icArrowsLarge.InsertGalleryImage("next_32x32.png", "images/arrows/next_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/next_32x32.png"), 8);
            this.icArrowsLarge.Images.SetKeyName(8, "next_32x32.png");
            this.icArrowsLarge.InsertGalleryImage("prev_32x32.png", "images/arrows/prev_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/prev_32x32.png"), 9);
            this.icArrowsLarge.Images.SetKeyName(9, "prev_32x32.png");
            // 
            // icExportSmall
            // 
            this.icExportSmall.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("icExportSmall.ImageStream")));
            this.icExportSmall.InsertGalleryImage("export_16x16.png", "images/export/export_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/export_16x16.png"), 0);
            this.icExportSmall.Images.SetKeyName(0, "export_16x16.png");
            this.icExportSmall.InsertGalleryImage("exportfile_16x16.png", "images/export/exportfile_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exportfile_16x16.png"), 1);
            this.icExportSmall.Images.SetKeyName(1, "exportfile_16x16.png");
            this.icExportSmall.InsertGalleryImage("exporttocsv_16x16.png", "images/export/exporttocsv_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttocsv_16x16.png"), 2);
            this.icExportSmall.Images.SetKeyName(2, "exporttocsv_16x16.png");
            this.icExportSmall.InsertGalleryImage("exporttodoc_16x16.png", "images/export/exporttodoc_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttodoc_16x16.png"), 3);
            this.icExportSmall.Images.SetKeyName(3, "exporttodoc_16x16.png");
            this.icExportSmall.InsertGalleryImage("exporttodocx_16x16.png", "images/export/exporttodocx_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttodocx_16x16.png"), 4);
            this.icExportSmall.Images.SetKeyName(4, "exporttodocx_16x16.png");
            this.icExportSmall.InsertGalleryImage("exporttoepub_16x16.png", "images/export/exporttoepub_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttoepub_16x16.png"), 5);
            this.icExportSmall.Images.SetKeyName(5, "exporttoepub_16x16.png");
            this.icExportSmall.InsertGalleryImage("exporttohtml_16x16.png", "images/export/exporttohtml_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttohtml_16x16.png"), 6);
            this.icExportSmall.Images.SetKeyName(6, "exporttohtml_16x16.png");
            this.icExportSmall.InsertGalleryImage("exporttoimg_16x16.png", "images/export/exporttoimg_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttoimg_16x16.png"), 7);
            this.icExportSmall.Images.SetKeyName(7, "exporttoimg_16x16.png");
            this.icExportSmall.InsertGalleryImage("exporttomht_16x16.png", "images/export/exporttomht_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttomht_16x16.png"), 8);
            this.icExportSmall.Images.SetKeyName(8, "exporttomht_16x16.png");
            this.icExportSmall.InsertGalleryImage("exporttoodt_16x16.png", "images/export/exporttoodt_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttoodt_16x16.png"), 9);
            this.icExportSmall.Images.SetKeyName(9, "exporttoodt_16x16.png");
            this.icExportSmall.InsertGalleryImage("exporttopdf_16x16.png", "images/export/exporttopdf_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttopdf_16x16.png"), 10);
            this.icExportSmall.Images.SetKeyName(10, "exporttopdf_16x16.png");
            this.icExportSmall.InsertGalleryImage("exporttortf_16x16.png", "images/export/exporttortf_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttortf_16x16.png"), 11);
            this.icExportSmall.Images.SetKeyName(11, "exporttortf_16x16.png");
            this.icExportSmall.InsertGalleryImage("exporttotxt_16x16.png", "images/export/exporttotxt_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttotxt_16x16.png"), 12);
            this.icExportSmall.Images.SetKeyName(12, "exporttotxt_16x16.png");
            this.icExportSmall.InsertGalleryImage("exporttoxls_16x16.png", "images/export/exporttoxls_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttoxls_16x16.png"), 13);
            this.icExportSmall.Images.SetKeyName(13, "exporttoxls_16x16.png");
            this.icExportSmall.InsertGalleryImage("exporttoxlsx_16x16.png", "images/export/exporttoxlsx_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttoxlsx_16x16.png"), 14);
            this.icExportSmall.Images.SetKeyName(14, "exporttoxlsx_16x16.png");
            this.icExportSmall.InsertGalleryImage("exporttoxml_16x16.png", "images/export/exporttoxml_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttoxml_16x16.png"), 15);
            this.icExportSmall.Images.SetKeyName(15, "exporttoxml_16x16.png");
            this.icExportSmall.InsertGalleryImage("exporttoxps_16x16.png", "images/export/exporttoxps_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttoxps_16x16.png"), 16);
            this.icExportSmall.Images.SetKeyName(16, "exporttoxps_16x16.png");
            // 
            // icExportLarge
            // 
            this.icExportLarge.ImageSize = new System.Drawing.Size(32, 32);
            this.icExportLarge.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("icExportLarge.ImageStream")));
            this.icExportLarge.InsertGalleryImage("export_32x32.png", "images/export/export_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/export_32x32.png"), 0);
            this.icExportLarge.Images.SetKeyName(0, "export_32x32.png");
            this.icExportLarge.InsertGalleryImage("exportfile_32x32.png", "images/export/exportfile_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exportfile_32x32.png"), 1);
            this.icExportLarge.Images.SetKeyName(1, "exportfile_32x32.png");
            this.icExportLarge.InsertGalleryImage("exporttocsv_32x32.png", "images/export/exporttocsv_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttocsv_32x32.png"), 2);
            this.icExportLarge.Images.SetKeyName(2, "exporttocsv_32x32.png");
            this.icExportLarge.InsertGalleryImage("exporttodoc_32x32.png", "images/export/exporttodoc_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttodoc_32x32.png"), 3);
            this.icExportLarge.Images.SetKeyName(3, "exporttodoc_32x32.png");
            this.icExportLarge.InsertGalleryImage("exporttodocx_32x32.png", "images/export/exporttodocx_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttodocx_32x32.png"), 4);
            this.icExportLarge.Images.SetKeyName(4, "exporttodocx_32x32.png");
            this.icExportLarge.InsertGalleryImage("exporttoepub_32x32.png", "images/export/exporttoepub_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttoepub_32x32.png"), 5);
            this.icExportLarge.Images.SetKeyName(5, "exporttoepub_32x32.png");
            this.icExportLarge.InsertGalleryImage("exporttohtml_32x32.png", "images/export/exporttohtml_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttohtml_32x32.png"), 6);
            this.icExportLarge.Images.SetKeyName(6, "exporttohtml_32x32.png");
            this.icExportLarge.InsertGalleryImage("exporttoimg_32x32.png", "images/export/exporttoimg_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttoimg_32x32.png"), 7);
            this.icExportLarge.Images.SetKeyName(7, "exporttoimg_32x32.png");
            this.icExportLarge.InsertGalleryImage("exporttomht_32x32.png", "images/export/exporttomht_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttomht_32x32.png"), 8);
            this.icExportLarge.Images.SetKeyName(8, "exporttomht_32x32.png");
            this.icExportLarge.InsertGalleryImage("exporttoodt_32x32.png", "images/export/exporttoodt_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttoodt_32x32.png"), 9);
            this.icExportLarge.Images.SetKeyName(9, "exporttoodt_32x32.png");
            this.icExportLarge.InsertGalleryImage("exporttopdf_32x32.png", "images/export/exporttopdf_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttopdf_32x32.png"), 10);
            this.icExportLarge.Images.SetKeyName(10, "exporttopdf_32x32.png");
            this.icExportLarge.InsertGalleryImage("exporttortf_32x32.png", "images/export/exporttortf_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttortf_32x32.png"), 11);
            this.icExportLarge.Images.SetKeyName(11, "exporttortf_32x32.png");
            this.icExportLarge.InsertGalleryImage("exporttotxt_32x32.png", "images/export/exporttotxt_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttotxt_32x32.png"), 12);
            this.icExportLarge.Images.SetKeyName(12, "exporttotxt_32x32.png");
            this.icExportLarge.InsertGalleryImage("exporttoxls_32x32.png", "images/export/exporttoxls_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttoxls_32x32.png"), 13);
            this.icExportLarge.Images.SetKeyName(13, "exporttoxls_32x32.png");
            this.icExportLarge.InsertGalleryImage("exporttoxlsx_32x32.png", "images/export/exporttoxlsx_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttoxlsx_32x32.png"), 14);
            this.icExportLarge.Images.SetKeyName(14, "exporttoxlsx_32x32.png");
            this.icExportLarge.InsertGalleryImage("exporttoxml_32x32.png", "images/export/exporttoxml_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttoxml_32x32.png"), 15);
            this.icExportLarge.Images.SetKeyName(15, "exporttoxml_32x32.png");
            this.icExportLarge.InsertGalleryImage("exporttoxps_32x32.png", "images/export/exporttoxps_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttoxps_32x32.png"), 16);
            this.icExportLarge.Images.SetKeyName(16, "exporttoxps_32x32.png");
            // 
            // panelOptions
            // 
            this.panelOptions.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelOptions.Controls.Add(this.gcOptionsBehavior);
            this.panelOptions.Controls.Add(this.gcOptionsMinimizing);
            this.panelOptions.Controls.Add(this.gcOptionsView);
            this.panelOptions.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelOptions.Location = new System.Drawing.Point(871, 5);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.panelOptions.Size = new System.Drawing.Size(311, 676);
            this.panelOptions.TabIndex = 1;
            // 
            // gcOptionsBehavior
            // 
            this.gcOptionsBehavior.Controls.Add(this.ceAllowSmoothScrolling);
            this.gcOptionsBehavior.Controls.Add(this.lblItemSelectMode);
            this.gcOptionsBehavior.Controls.Add(this.cbeItemSelectMode);
            this.gcOptionsBehavior.Location = new System.Drawing.Point(15, 345);
            this.gcOptionsBehavior.Name = "gcOptionsBehavior";
            this.gcOptionsBehavior.Size = new System.Drawing.Size(296, 103);
            this.gcOptionsBehavior.TabIndex = 9;
            this.gcOptionsBehavior.Text = "Options Behavior";
            // 
            // lblItemSelectMode
            // 
            this.lblItemSelectMode.Location = new System.Drawing.Point(15, 36);
            this.lblItemSelectMode.Name = "lblItemSelectMode";
            this.lblItemSelectMode.Size = new System.Drawing.Size(87, 13);
            this.lblItemSelectMode.TabIndex = 8;
            this.lblItemSelectMode.Text = "Item Select Mode:";
            // 
            // cbeItemSelectMode
            // 
            this.cbeItemSelectMode.Location = new System.Drawing.Point(147, 33);
            this.cbeItemSelectMode.Name = "cbeItemSelectMode";
            this.cbeItemSelectMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeItemSelectMode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbeItemSelectMode.Size = new System.Drawing.Size(135, 20);
            this.cbeItemSelectMode.TabIndex = 7;
            this.cbeItemSelectMode.EditValueChanged += new System.EventHandler(this.OnItemSelectModeChanged);
            // 
            // gcOptionsMinimizing
            // 
            this.gcOptionsMinimizing.Controls.Add(this.lblScrollMode);
            this.gcOptionsMinimizing.Controls.Add(this.cbMinimizingScrollMode);
            this.gcOptionsMinimizing.Controls.Add(this.labelColumnCountMinimizing);
            this.gcOptionsMinimizing.Controls.Add(this.seColumnCountMinimizing);
            this.gcOptionsMinimizing.Location = new System.Drawing.Point(15, 215);
            this.gcOptionsMinimizing.Name = "gcOptionsMinimizing";
            this.gcOptionsMinimizing.Size = new System.Drawing.Size(296, 113);
            this.gcOptionsMinimizing.TabIndex = 5;
            this.gcOptionsMinimizing.Text = "Options Minimizing";
            // 
            // lblScrollMode
            // 
            this.lblScrollMode.Location = new System.Drawing.Point(15, 74);
            this.lblScrollMode.Name = "lblScrollMode";
            this.lblScrollMode.Size = new System.Drawing.Size(58, 13);
            this.lblScrollMode.TabIndex = 8;
            this.lblScrollMode.Text = "Scroll Mode:";
            // 
            // cbMinimizingScrollMode
            // 
            this.cbMinimizingScrollMode.Location = new System.Drawing.Point(147, 71);
            this.cbMinimizingScrollMode.Name = "cbMinimizingScrollMode";
            this.cbMinimizingScrollMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMinimizingScrollMode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbMinimizingScrollMode.Size = new System.Drawing.Size(135, 20);
            this.cbMinimizingScrollMode.TabIndex = 7;
            // 
            // labelColumnCountMinimizing
            // 
            this.labelColumnCountMinimizing.Location = new System.Drawing.Point(15, 37);
            this.labelColumnCountMinimizing.Name = "labelColumnCountMinimizing";
            this.labelColumnCountMinimizing.Size = new System.Drawing.Size(71, 13);
            this.labelColumnCountMinimizing.TabIndex = 6;
            this.labelColumnCountMinimizing.Text = "Column Count:";
            // 
            // seColumnCountMinimizing
            // 
            this.seColumnCountMinimizing.EditValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.seColumnCountMinimizing.Location = new System.Drawing.Point(147, 34);
            this.seColumnCountMinimizing.Name = "seColumnCountMinimizing";
            this.seColumnCountMinimizing.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seColumnCountMinimizing.Properties.IsFloatValue = false;
            this.seColumnCountMinimizing.Properties.Mask.EditMask = "N00";
            this.seColumnCountMinimizing.Properties.MaxValue = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.seColumnCountMinimizing.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seColumnCountMinimizing.Size = new System.Drawing.Size(135, 20);
            this.seColumnCountMinimizing.TabIndex = 5;
            this.seColumnCountMinimizing.EditValueChanged += new System.EventHandler(this.OnColumnCountMinimizingChanged);
            // 
            // imagesSmall
            // 
            this.imagesSmall.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imagesSmall.ImageStream")));
            this.imagesSmall.InsertGalleryImage("contentarrangeinrows_16x16.png", "images/alignment/contentarrangeinrows_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/alignment/contentarrangeinrows_16x16.png"), 0);
            this.imagesSmall.Images.SetKeyName(0, "contentarrangeinrows_16x16.png");
            this.imagesSmall.InsertGalleryImage("gridlines_16x16.png", "images/grid/gridlines_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/grid/gridlines_16x16.png"), 1);
            this.imagesSmall.Images.SetKeyName(1, "gridlines_16x16.png");
            // 
            // imagesLarge
            // 
            this.imagesLarge.ImageSize = new System.Drawing.Size(32, 32);
            this.imagesLarge.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imagesLarge.ImageStream")));
            this.imagesLarge.InsertGalleryImage("contentarrangeinrows_32x32.png", "images/alignment/contentarrangeinrows_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/alignment/contentarrangeinrows_32x32.png"), 0);
            this.imagesLarge.Images.SetKeyName(0, "contentarrangeinrows_32x32.png");
            this.imagesLarge.InsertGalleryImage("cards_32x32.png", "images/grid/cards_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/grid/cards_32x32.png"), 1);
            this.imagesLarge.Images.SetKeyName(1, "cards_32x32.png");
            // 
            // ToolboxModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelOptions);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "ToolboxModule";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1187, 686);
            ((System.ComponentModel.ISupportInitialize)(this.gcOptionsView)).EndInit();
            this.gcOptionsView.ResumeLayout(false);
            this.gcOptionsView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceGroupsContentAutoSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowSearchPanel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbItemViewMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seColumnCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbImageSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowSmoothScrolling.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icActionsSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icActionsLarge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icArrowsSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icArrowsLarge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icExportSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icExportLarge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelOptions)).EndInit();
            this.panelOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcOptionsBehavior)).EndInit();
            this.gcOptionsBehavior.ResumeLayout(false);
            this.gcOptionsBehavior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbeItemSelectMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcOptionsMinimizing)).EndInit();
            this.gcOptionsMinimizing.ResumeLayout(false);
            this.gcOptionsMinimizing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbMinimizingScrollMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seColumnCountMinimizing.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagesSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagesLarge)).EndInit();
            this.ResumeLayout(false);

        }
        private DevExpress.XtraToolbox.ToolboxControl xtraToolboxControl;
        private SimpleContentPanel gcContent;
        private DevExpress.XtraEditors.GroupControl gcOptionsView;
        private DevExpress.XtraEditors.LabelControl labelImageSize;
        private DevExpress.XtraEditors.ComboBoxEdit cbImageSize;
        private DevExpress.XtraEditors.LabelControl labelItemViewMode;
        private DevExpress.XtraEditors.ComboBoxEdit cbItemViewMode;
        private DevExpress.XtraEditors.LabelControl labelColumnCount;
        private DevExpress.XtraEditors.SpinEdit seColumnCount;
        private DevExpress.XtraEditors.CheckEdit ceShowSearchPanel;
        private DevExpress.XtraEditors.CheckEdit ceGroupsContentAutoSize;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.Utils.ImageCollection icActionsSmall;
        private DevExpress.Utils.ImageCollection icActionsLarge;
        private DevExpress.Utils.ImageCollection icArrowsSmall;
        private DevExpress.Utils.ImageCollection icArrowsLarge;
        private DevExpress.Utils.ImageCollection icExportSmall;
        private DevExpress.Utils.ImageCollection icExportLarge;
        private XtraEditors.PanelControl panelOptions;
        private DevExpress.Utils.ImageCollection imagesSmall;
        private DevExpress.Utils.ImageCollection imagesLarge;
        private XtraEditors.GroupControl gcOptionsMinimizing;
        private XtraEditors.LabelControl labelColumnCountMinimizing;
        private XtraEditors.SpinEdit seColumnCountMinimizing;
        private XtraEditors.LabelControl lblScrollMode;
        private XtraEditors.ComboBoxEdit cbMinimizingScrollMode;
        private XtraEditors.CheckEdit ceAllowSmoothScrolling;
        private XtraEditors.GroupControl gcOptionsBehavior;
        private XtraEditors.LabelControl lblItemSelectMode;
        private XtraEditors.ComboBoxEdit cbeItemSelectMode;
    }
}

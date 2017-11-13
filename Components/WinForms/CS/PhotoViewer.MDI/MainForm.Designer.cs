using DevExpress.XtraTab;
namespace PhotoViewer {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup2 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup3 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelContainer1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.controlContainer1 = new DevExpress.XtraBars.Docking.ControlContainer();
            this.selectedPictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.mainRibbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu();
            this.popupControlContainer1 = new DevExpress.XtraBars.PopupControlContainer();
            this.exitButton = new DevExpress.XtraEditors.SimpleButton();
            this.biNewAlbum = new DevExpress.XtraBars.BarButtonItem();
            this.biAddFolder = new DevExpress.XtraBars.BarButtonItem();
            this.biAddFile = new DevExpress.XtraBars.BarButtonItem();
            this.biGenerateData = new DevExpress.XtraBars.BarButtonItem();
            this.barAndDockingController = new DevExpress.XtraBars.BarAndDockingController();
            this.bsView = new DevExpress.XtraBars.BarSubItem();
            this.bsTools = new DevExpress.XtraBars.BarSubItem();
            this.bsSkins = new DevExpress.XtraBars.BarSubItem();
            this.bsHelp = new DevExpress.XtraBars.BarSubItem();
            this.biAbout = new DevExpress.XtraBars.BarButtonItem();
            this.biExit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.biRemoveAlbum = new DevExpress.XtraBars.BarButtonItem();
            this.biRemoveFolder = new DevExpress.XtraBars.BarButtonItem();
            this.biEditAlbum = new DevExpress.XtraBars.BarButtonItem();
            this.albumSubItem = new DevExpress.XtraBars.BarSubItem();
            this.skinGalleryBarItem = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.biAddToLibrary = new DevExpress.XtraBars.BarButtonItem();
            this.addToLibraryMenu = new DevExpress.XtraBars.PopupMenu();
            this.biSaveImage = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonGroup2 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonGroup3 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonGroup4 = new DevExpress.XtraBars.BarButtonGroup();
            this.bBColorMix = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonMiniToolbar1 = new DevExpress.XtraBars.Ribbon.RibbonMiniToolbar();
            this.viewPageCategory = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.imagePage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.imageGeneralPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.folderPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.folderPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.albumPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.albumPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.viewPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.skinsPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.navBar = new DevExpress.XtraNavBar.NavBarControl();
            this.albumGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.foldersGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.othersGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.albumPopupMenu = new DevExpress.XtraBars.PopupMenu();
            this.dockPanel2 = new DevExpress.XtraBars.Docking.DockPanel();
            this.controlContainer2 = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dateFilter = new PhotoViewer.DateFilter();
            this.defaultToolTipController1 = new DevExpress.Utils.DefaultToolTipController();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderPopupMenu = new DevExpress.XtraBars.PopupMenu();
            this.galleryItemMenu = new DevExpress.XtraBars.PopupMenu();
            this.imageDialog = new System.Windows.Forms.OpenFileDialog();
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager();
            this.documentManager = new DevExpress.XtraBars.Docking2010.DocumentManager();
            this.tabbedView = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView();
            this.panelContainer1.SuspendLayout();
            this.dockPanel1.SuspendLayout();
            this.controlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedPictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).BeginInit();
            this.popupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addToLibraryMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumPopupMenu)).BeginInit();
            this.dockPanel2.SuspendLayout();
            this.controlContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folderPopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryItemMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer1
            // 
            this.panelContainer1.Controls.Add(this.dockPanel1);
            this.panelContainer1.Controls.Add(this.dockPanel2);
            this.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.panelContainer1.ID = new System.Guid("8218d2c3-3acd-4418-8cf7-e1b6091107a3");
            this.panelContainer1.Location = new System.Drawing.Point(767, 147);
            this.panelContainer1.Name = "panelContainer1";
            this.panelContainer1.OriginalSize = new System.Drawing.Size(347, 200);
            this.panelContainer1.Size = new System.Drawing.Size(347, 599);
            this.panelContainer1.Text = "panelContainer1";
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.controlContainer1);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dockPanel1.ID = new System.Guid("1a5d040e-8d04-4f3d-bfd7-d81cb0934982");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Options.ShowCloseButton = false;
            this.dockPanel1.OriginalSize = new System.Drawing.Size(347, 250);
            this.dockPanel1.Size = new System.Drawing.Size(347, 252);
            this.dockPanel1.Text = "Preview";
            // 
            // controlContainer1
            // 
            this.defaultToolTipController1.SetAllowHtmlText(this.controlContainer1, DevExpress.Utils.DefaultBoolean.Default);
            this.controlContainer1.Controls.Add(this.selectedPictureEdit);
            this.controlContainer1.Location = new System.Drawing.Point(3, 29);
            this.controlContainer1.Name = "controlContainer1";
            this.controlContainer1.Size = new System.Drawing.Size(341, 220);
            this.controlContainer1.TabIndex = 0;
            // 
            // selectedPictureEdit
            // 
            this.selectedPictureEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedPictureEdit.Location = new System.Drawing.Point(0, 0);
            this.selectedPictureEdit.MenuManager = this.mainRibbon;
            this.selectedPictureEdit.Name = "selectedPictureEdit";
            this.selectedPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.selectedPictureEdit.Size = new System.Drawing.Size(341, 220);
            this.selectedPictureEdit.TabIndex = 0;
            // 
            // mainRibbon
            // 
            this.mainRibbon.ApplicationButtonDropDownControl = this.applicationMenu1;
            this.mainRibbon.ApplicationButtonText = null;
            this.mainRibbon.Controller = this.barAndDockingController;
            this.mainRibbon.ExpandCollapseItem.Id = 0;
            this.mainRibbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbon.ExpandCollapseItem,
            this.bsView,
            this.bsTools,
            this.bsHelp,
            this.biAbout,
            this.bsSkins,
            this.biNewAlbum,
            this.biAddFolder,
            this.biAddFile,
            this.biExit,
            this.barButtonItem2,
            this.biRemoveAlbum,
            this.biRemoveFolder,
            this.biEditAlbum,
            this.albumSubItem,
            this.skinGalleryBarItem,
            this.biAddToLibrary,
            this.biSaveImage,
            this.biGenerateData,
            this.barButtonGroup1,
            this.barButtonGroup2,
            this.barButtonGroup3,
            this.barButtonGroup4,
            this.bBColorMix});
            this.mainRibbon.Location = new System.Drawing.Point(0, 0);
            this.mainRibbon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainRibbon.MaxItemId = 29;
            this.mainRibbon.MiniToolbars.Add(this.ribbonMiniToolbar1);
            this.mainRibbon.Name = "mainRibbon";
            this.mainRibbon.OptionsTouch.ShowTouchUISelectorInQAT = true;
            this.mainRibbon.OptionsTouch.ShowTouchUISelectorVisibilityItemInQATMenu = true;
            this.mainRibbon.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.viewPageCategory});
            this.mainRibbon.PageCategoryAlignment = DevExpress.XtraBars.Ribbon.RibbonPageCategoryAlignment.Right;
            this.mainRibbon.PageHeaderItemLinks.Add(this.biAbout);
            this.mainRibbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.imagePage,
            this.folderPage,
            this.albumPage,
            this.viewPage});
            this.mainRibbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.mainRibbon.Size = new System.Drawing.Size(1114, 147);
            this.mainRibbon.StatusBar = this.ribbonStatusBar1;
            this.mainRibbon.TransparentEditors = true;
            this.mainRibbon.SelectedPageChanged += new System.EventHandler(this.OnRibbonControlSelectedPageChanged);
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.BottomPaneControlContainer = this.popupControlContainer1;
            this.applicationMenu1.ItemLinks.Add(this.biNewAlbum);
            this.applicationMenu1.ItemLinks.Add(this.biAddFolder, true);
            this.applicationMenu1.ItemLinks.Add(this.biAddFile);
            this.applicationMenu1.ItemLinks.Add(this.biGenerateData, true);
            this.applicationMenu1.Name = "applicationMenu1";
            this.applicationMenu1.Ribbon = this.mainRibbon;
            // 
            // popupControlContainer1
            // 
            this.defaultToolTipController1.SetAllowHtmlText(this.popupControlContainer1, DevExpress.Utils.DefaultBoolean.Default);
            this.popupControlContainer1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.popupControlContainer1.Appearance.Options.UseBackColor = true;
            this.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.popupControlContainer1.Controls.Add(this.exitButton);
            this.popupControlContainer1.Location = new System.Drawing.Point(989, 71);
            this.popupControlContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.popupControlContainer1.Name = "popupControlContainer1";
            this.popupControlContainer1.Ribbon = this.mainRibbon;
            this.popupControlContainer1.Size = new System.Drawing.Size(79, 36);
            this.popupControlContainer1.TabIndex = 1;
            this.popupControlContainer1.Visible = false;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(3, 4);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(71, 28);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.Click += new System.EventHandler(this.OnExitButtonClick);
            // 
            // biNewAlbum
            // 
            this.biNewAlbum.Caption = "&New Album...";
            this.biNewAlbum.Glyph = global::PhotoViewer.Properties.Resources.NewAlbum_16x16;
            this.biNewAlbum.Id = 8;
            this.biNewAlbum.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
            this.biNewAlbum.LargeGlyph = global::PhotoViewer.Properties.Resources.NewAlbum_32x32;
            this.biNewAlbum.Name = "biNewAlbum";
            this.biNewAlbum.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnNewAlbumItemClick);
            // 
            // biAddFolder
            // 
            this.biAddFolder.Caption = "Add Folder";
            this.biAddFolder.Glyph = global::PhotoViewer.Properties.Resources.AddFolder_16x16;
            this.biAddFolder.Id = 9;
            this.biAddFolder.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F));
            this.biAddFolder.LargeGlyph = global::PhotoViewer.Properties.Resources.AddFolder_32x32;
            this.biAddFolder.Name = "biAddFolder";
            this.biAddFolder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnAddFolderItemClick);
            // 
            // biAddFile
            // 
            this.biAddFile.Caption = "Add File";
            this.biAddFile.Glyph = global::PhotoViewer.Properties.Resources.AddFile_16x16;
            this.biAddFile.Id = 10;
            this.biAddFile.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O));
            this.biAddFile.LargeGlyph = global::PhotoViewer.Properties.Resources.AddFile_32x32;
            this.biAddFile.Name = "biAddFile";
            this.biAddFile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnAddFileClick);
            // 
            // biGenerateData
            // 
            this.biGenerateData.Caption = "Generate Data";
            this.biGenerateData.Glyph = global::PhotoViewer.Properties.Resources.GenerateData_16x16;
            this.biGenerateData.Hint = "This item allow you to generate default data for demo";
            this.biGenerateData.Id = 19;
            this.biGenerateData.LargeGlyph = global::PhotoViewer.Properties.Resources.GenerateData_32x32;
            this.biGenerateData.Name = "biGenerateData";
            this.biGenerateData.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnGenerateDataItemClick);
            // 
            // barAndDockingController
            // 
            this.barAndDockingController.PropertiesBar.AllowLinkLighting = false;
            this.barAndDockingController.PropertiesBar.DefaultGlyphSize = new System.Drawing.Size(16, 16);
            this.barAndDockingController.PropertiesBar.DefaultLargeGlyphSize = new System.Drawing.Size(32, 32);
            // 
            // bsView
            // 
            this.bsView.Caption = "&View";
            this.bsView.Id = 2;
            this.bsView.Name = "bsView";
            // 
            // bsTools
            // 
            this.bsTools.Caption = "&Tools";
            this.bsTools.Id = 3;
            this.bsTools.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bsSkins)});
            this.bsTools.Name = "bsTools";
            // 
            // bsSkins
            // 
            this.bsSkins.Caption = "&Skins";
            this.bsSkins.Id = 7;
            this.bsSkins.Name = "bsSkins";
            // 
            // bsHelp
            // 
            this.bsHelp.Caption = "&Help";
            this.bsHelp.Id = 5;
            this.bsHelp.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.biAbout)});
            this.bsHelp.Name = "bsHelp";
            // 
            // biAbout
            // 
            this.biAbout.Caption = "&About";
            this.biAbout.Glyph = global::PhotoViewer.Properties.Resources.Help_16x16;
            this.biAbout.Id = 6;
            this.biAbout.LargeGlyph = global::PhotoViewer.Properties.Resources.Help_32x32;
            this.biAbout.Name = "biAbout";
            this.biAbout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnAboutItemClick);
            // 
            // biExit
            // 
            this.biExit.Caption = "&Exit";
            this.biExit.Id = 12;
            this.biExit.Name = "biExit";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Delete Folder";
            this.barButtonItem2.Id = 13;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // biRemoveAlbum
            // 
            this.biRemoveAlbum.Caption = "Remove Album";
            this.biRemoveAlbum.Glyph = global::PhotoViewer.Properties.Resources.RemoveAlbum_16x16;
            this.biRemoveAlbum.Id = 14;
            this.biRemoveAlbum.LargeGlyph = global::PhotoViewer.Properties.Resources.RemoveAlbum_32x32;
            this.biRemoveAlbum.Name = "biRemoveAlbum";
            this.biRemoveAlbum.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnRemoveAlbumItemClick);
            // 
            // biRemoveFolder
            // 
            this.biRemoveFolder.Caption = "Remove Folder";
            this.biRemoveFolder.Glyph = global::PhotoViewer.Properties.Resources.RemoveFolder_16x16;
            this.biRemoveFolder.Id = 15;
            this.biRemoveFolder.LargeGlyph = global::PhotoViewer.Properties.Resources.RemoveFolder_32x32;
            this.biRemoveFolder.Name = "biRemoveFolder";
            this.biRemoveFolder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnRemoveFolderItemClick);
            // 
            // biEditAlbum
            // 
            this.biEditAlbum.Caption = "Edit Album";
            this.biEditAlbum.Glyph = global::PhotoViewer.Properties.Resources.Edit_16x16;
            this.biEditAlbum.Id = 17;
            this.biEditAlbum.LargeGlyph = global::PhotoViewer.Properties.Resources.Edit_32x32;
            this.biEditAlbum.Name = "biEditAlbum";
            this.biEditAlbum.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnEditAlbumItemClick);
            // 
            // albumSubItem
            // 
            this.albumSubItem.Caption = "&Album";
            this.albumSubItem.Id = 18;
            this.albumSubItem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.biNewAlbum),
            new DevExpress.XtraBars.LinkPersistInfo(this.biEditAlbum, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.biRemoveAlbum)});
            this.albumSubItem.Name = "albumSubItem";
            // 
            // skinGalleryBarItem
            // 
            // 
            // 
            // 
            this.skinGalleryBarItem.Gallery.AllowHoverImages = true;
            this.skinGalleryBarItem.Gallery.FixedHoverImageSize = false;
            galleryItemGroup1.Caption = "Standard";
            galleryItemGroup2.Caption = "Bonus";
            galleryItemGroup2.Visible = false;
            galleryItemGroup3.Caption = "Office";
            galleryItemGroup3.Visible = false;
            this.skinGalleryBarItem.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1,
            galleryItemGroup2,
            galleryItemGroup3});
            this.skinGalleryBarItem.Gallery.ImageSize = new System.Drawing.Size(58, 43);
            this.skinGalleryBarItem.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleRadio;
            this.skinGalleryBarItem.Id = 1;
            this.skinGalleryBarItem.Name = "skinGalleryBarItem";
            // 
            // biAddToLibrary
            // 
            this.biAddToLibrary.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.biAddToLibrary.Caption = "Add to Library";
            this.biAddToLibrary.DropDownControl = this.addToLibraryMenu;
            this.biAddToLibrary.Glyph = global::PhotoViewer.Properties.Resources.AddToLibrary_16x16;
            this.biAddToLibrary.Hint = "Add files or folder to library";
            this.biAddToLibrary.Id = 5;
            this.biAddToLibrary.LargeGlyph = global::PhotoViewer.Properties.Resources.AddToLibrary_32x32;
            this.biAddToLibrary.Name = "biAddToLibrary";
            this.biAddToLibrary.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnAddToLibraryItemClick);
            // 
            // addToLibraryMenu
            // 
            this.addToLibraryMenu.ItemLinks.Add(this.biAddFolder);
            this.addToLibraryMenu.ItemLinks.Add(this.biAddFile);
            this.addToLibraryMenu.Name = "addToLibraryMenu";
            this.addToLibraryMenu.Ribbon = this.mainRibbon;
            // 
            // biSaveImage
            // 
            this.biSaveImage.Caption = "Save";
            this.biSaveImage.Glyph = global::PhotoViewer.Properties.Resources.Save_16x16;
            this.biSaveImage.Id = 14;
            this.biSaveImage.LargeGlyph = global::PhotoViewer.Properties.Resources.Save_32x32;
            this.biSaveImage.Name = "biSaveImage";
            this.biSaveImage.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnSaveImageItemClick);
            // 
            // barButtonGroup1
            // 
            this.barButtonGroup1.Caption = "barButtonGroup1";
            this.barButtonGroup1.Id = 23;
            this.barButtonGroup1.Name = "barButtonGroup1";
            // 
            // barButtonGroup2
            // 
            this.barButtonGroup2.Caption = "barButtonGroup2";
            this.barButtonGroup2.Id = 24;
            this.barButtonGroup2.Name = "barButtonGroup2";
            // 
            // barButtonGroup3
            // 
            this.barButtonGroup3.Caption = "barButtonGroup3";
            this.barButtonGroup3.Id = 25;
            this.barButtonGroup3.Name = "barButtonGroup3";
            // 
            // barButtonGroup4
            // 
            this.barButtonGroup4.Caption = "barButtonGroup4";
            this.barButtonGroup4.Id = 26;
            this.barButtonGroup4.Name = "barButtonGroup4";
            // 
            // bBColorMix
            // 
            this.bBColorMix.Caption = "Color Mix";
            this.bBColorMix.Glyph = global::PhotoViewer.Properties.Resources.ColorMixer_16x16;
            this.bBColorMix.Id = 28;
            this.bBColorMix.LargeGlyph = global::PhotoViewer.Properties.Resources.ColorMixer_32x32;
            this.bBColorMix.Name = "bBColorMix";
            this.bBColorMix.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBColorMix_ItemClick);
            // 
            // ribbonMiniToolbar1
            // 
            this.ribbonMiniToolbar1.Alignment = System.Drawing.ContentAlignment.TopRight;
            this.ribbonMiniToolbar1.ItemLinks.Add(this.barButtonGroup1);
            this.ribbonMiniToolbar1.ItemLinks.Add(this.barButtonGroup2);
            this.ribbonMiniToolbar1.ItemLinks.Add(this.barButtonGroup3);
            this.ribbonMiniToolbar1.ItemLinks.Add(this.barButtonGroup4);
            this.ribbonMiniToolbar1.ParentControl = this;
            // 
            // viewPageCategory
            // 
            this.viewPageCategory.Name = "viewPageCategory";
            this.viewPageCategory.Text = "View";
            this.viewPageCategory.Visible = false;
            // 
            // imagePage
            // 
            this.imagePage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.imageGeneralPageGroup});
            this.imagePage.Name = "imagePage";
            this.imagePage.Text = "Image";
            // 
            // imageGeneralPageGroup
            // 
            this.imageGeneralPageGroup.ItemLinks.Add(this.biAddToLibrary);
            this.imageGeneralPageGroup.Name = "imageGeneralPageGroup";
            this.imageGeneralPageGroup.ShowCaptionButton = false;
            this.imageGeneralPageGroup.Text = "General";
            // 
            // folderPage
            // 
            this.folderPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.folderPageGroup});
            this.folderPage.Name = "folderPage";
            this.folderPage.Text = "Folder";
            // 
            // folderPageGroup
            // 
            this.folderPageGroup.ItemLinks.Add(this.biAddFolder);
            this.folderPageGroup.ItemLinks.Add(this.biAddFile);
            this.folderPageGroup.ItemLinks.Add(this.biRemoveFolder);
            this.folderPageGroup.Name = "folderPageGroup";
            this.folderPageGroup.ShowCaptionButton = false;
            this.folderPageGroup.Text = "General";
            // 
            // albumPage
            // 
            this.albumPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.albumPageGroup});
            this.albumPage.Name = "albumPage";
            this.albumPage.Text = "Album";
            // 
            // albumPageGroup
            // 
            this.albumPageGroup.ItemLinks.Add(this.biNewAlbum);
            this.albumPageGroup.ItemLinks.Add(this.biEditAlbum);
            this.albumPageGroup.ItemLinks.Add(this.biRemoveAlbum);
            this.albumPageGroup.Name = "albumPageGroup";
            this.albumPageGroup.ShowCaptionButton = false;
            this.albumPageGroup.Text = "General";
            // 
            // viewPage
            // 
            this.viewPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.skinsPageGroup});
            this.viewPage.Name = "viewPage";
            this.viewPage.Text = "View";
            // 
            // skinsPageGroup
            // 
            this.skinsPageGroup.ItemLinks.Add(this.skinGalleryBarItem);
            this.skinsPageGroup.ItemLinks.Add(this.bBColorMix);
            this.skinsPageGroup.Name = "skinsPageGroup";
            this.skinsPageGroup.ShowCaptionButton = false;
            this.skinsPageGroup.Text = "Skins";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 746);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.mainRibbon;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1114, 23);
            // 
            // navBar
            // 
            this.navBar.ActiveGroup = this.albumGroup;
            this.navBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBar.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None;
            this.navBar.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.albumGroup,
            this.foldersGroup,
            this.othersGroup});
            this.navBar.LinkSelectionMode = DevExpress.XtraNavBar.LinkSelectionModeType.OneInControl;
            this.navBar.Location = new System.Drawing.Point(0, 147);
            this.navBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.navBar.MenuManager = this.mainRibbon;
            this.navBar.Name = "navBar";
            this.navBar.OptionsNavPane.ExpandedWidth = 186;
            this.navBar.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.mainRibbon.SetPopupContextMenu(this.navBar, this.albumPopupMenu);
            this.navBar.Size = new System.Drawing.Size(186, 599);
            this.navBar.SkinExplorerBarViewScrollStyle = DevExpress.XtraNavBar.SkinExplorerBarViewScrollStyle.ScrollBar;
            this.navBar.TabIndex = 0;
            this.navBar.SelectedLinkChanged += new DevExpress.XtraNavBar.ViewInfo.NavBarSelectedLinkChangedEventHandler(this.OnNavBarControl1SelectedLinkChanged);
            this.navBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnNavBarControl1MouseDown);
            // 
            // albumGroup
            // 
            this.albumGroup.Caption = "Albums";
            this.albumGroup.Expanded = true;
            this.albumGroup.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.albumGroup.LargeImage = global::PhotoViewer.Properties.Resources.Album_32x32;
            this.albumGroup.Name = "albumGroup";
            this.albumGroup.SmallImage = global::PhotoViewer.Properties.Resources.Album_16x16;
            // 
            // foldersGroup
            // 
            this.foldersGroup.Caption = "Folders";
            this.foldersGroup.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.foldersGroup.LargeImage = global::PhotoViewer.Properties.Resources.Folder_32x32;
            this.foldersGroup.Name = "foldersGroup";
            this.foldersGroup.SmallImage = global::PhotoViewer.Properties.Resources.Folder_16x16;
            // 
            // othersGroup
            // 
            this.othersGroup.Caption = "Other";
            this.othersGroup.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.othersGroup.LargeImage = global::PhotoViewer.Properties.Resources.Other_32x32;
            this.othersGroup.Name = "othersGroup";
            this.othersGroup.SmallImage = global::PhotoViewer.Properties.Resources.Other_16x16;
            // 
            // albumPopupMenu
            // 
            this.albumPopupMenu.ItemLinks.Add(this.biRemoveAlbum);
            this.albumPopupMenu.ItemLinks.Add(this.biEditAlbum);
            this.albumPopupMenu.Name = "albumPopupMenu";
            this.albumPopupMenu.Ribbon = this.mainRibbon;
            this.albumPopupMenu.CloseUp += new System.EventHandler(this.OnAlbumPopupMenuCloseUp);
            // 
            // dockPanel2
            // 
            this.dockPanel2.Controls.Add(this.controlContainer2);
            this.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dockPanel2.ID = new System.Guid("b921466f-3e4f-4a20-8f62-f73e3660d5d9");
            this.dockPanel2.Location = new System.Drawing.Point(0, 252);
            this.dockPanel2.Name = "dockPanel2";
            this.dockPanel2.OriginalSize = new System.Drawing.Size(347, 344);
            this.dockPanel2.Size = new System.Drawing.Size(347, 347);
            this.dockPanel2.Text = "Date Filter";
            // 
            // controlContainer2
            // 
            this.defaultToolTipController1.SetAllowHtmlText(this.controlContainer2, DevExpress.Utils.DefaultBoolean.Default);
            this.controlContainer2.Controls.Add(this.dateFilter);
            this.controlContainer2.Location = new System.Drawing.Point(3, 29);
            this.controlContainer2.Name = "controlContainer2";
            this.controlContainer2.Size = new System.Drawing.Size(341, 315);
            this.controlContainer2.TabIndex = 0;
            // 
            // dateFilter
            // 
            this.defaultToolTipController1.SetAllowHtmlText(this.dateFilter, DevExpress.Utils.DefaultBoolean.Default);
            this.dateFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateFilter.Location = new System.Drawing.Point(0, 0);
            this.dateFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateFilter.Name = "dateFilter";
            this.dateFilter.Size = new System.Drawing.Size(341, 315);
            this.dateFilter.TabIndex = 0;
            this.dateFilter.SelectionChanged += new System.EventHandler(this.OnDateFilterSelectionChanged);
            // 
            // defaultToolTipController1
            // 
            // 
            // 
            // 
            this.defaultToolTipController1.DefaultController.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip;
            // 
            // folderPopupMenu
            // 
            this.folderPopupMenu.ItemLinks.Add(this.biRemoveFolder);
            this.folderPopupMenu.Name = "folderPopupMenu";
            this.folderPopupMenu.Ribbon = this.mainRibbon;
            // 
            // galleryItemMenu
            // 
            this.galleryItemMenu.Name = "galleryItemMenu";
            this.galleryItemMenu.Ribbon = this.mainRibbon;
            // 
            // imageDialog
            // 
            this.imageDialog.Filter = "Image files (BMP,JPG,PNG,GIF) |*.bmp;*.jpg;*.png;*.gif| All files|*.*";
            this.imageDialog.Multiselect = true;
            // 
            // dockManager
            // 
            this.dockManager.Controller = this.barAndDockingController;
            this.dockManager.Form = this;
            this.dockManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.panelContainer1});
            this.dockManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // documentManager
            // 
            this.documentManager.BarAndDockingController = this.barAndDockingController;
            this.documentManager.MdiParent = this;
            this.documentManager.MenuManager = this.mainRibbon;
            this.documentManager.View = this.tabbedView;
            this.documentManager.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView});
            // 
            // MainForm
            // 
            this.defaultToolTipController1.SetAllowHtmlText(this, DevExpress.Utils.DefaultBoolean.Default);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 769);
            this.Controls.Add(this.navBar);
            this.Controls.Add(this.popupControlContainer1);
            this.Controls.Add(this.panelContainer1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.mainRibbon);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Ribbon = this.mainRibbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "PhotoViewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.panelContainer1.ResumeLayout(false);
            this.dockPanel1.ResumeLayout(false);
            this.controlContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.selectedPictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).EndInit();
            this.popupControlContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addToLibraryMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumPopupMenu)).EndInit();
            this.dockPanel2.ResumeLayout(false);
            this.controlContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.folderPopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryItemMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarSubItem bsView;
        private DevExpress.XtraBars.BarSubItem bsTools;
        private DevExpress.XtraBars.BarSubItem bsHelp;
        private DevExpress.XtraBars.BarButtonItem biAbout;
        private DevExpress.XtraBars.BarSubItem bsSkins;
        private DevExpress.XtraBars.BarButtonItem biNewAlbum;
        private DevExpress.XtraBars.BarButtonItem biAddFolder;
        private DevExpress.XtraBars.BarButtonItem biAddFile;
        private DevExpress.XtraBars.BarButtonItem biExit;
        private DevExpress.Utils.DefaultToolTipController defaultToolTipController1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private DevExpress.XtraBars.PopupMenu albumPopupMenu;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem biRemoveAlbum;
        private DevExpress.XtraBars.PopupMenu folderPopupMenu;
        private DevExpress.XtraBars.BarButtonItem biRemoveFolder;
        private DevExpress.XtraBars.PopupMenu galleryItemMenu;
        private DevExpress.XtraBars.BarButtonItem biEditAlbum;
        private DevExpress.XtraBars.BarSubItem albumSubItem;
        private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage imagePage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup imageGeneralPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPage folderPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory viewPageCategory;
        private DevExpress.XtraBars.Ribbon.RibbonPage albumPage;
        private DevExpress.XtraBars.Ribbon.RibbonPage viewPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup folderPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup albumPageGroup;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
        private DevExpress.XtraBars.RibbonGalleryBarItem skinGalleryBarItem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup skinsPageGroup;
        private DevExpress.XtraBars.PopupControlContainer popupControlContainer1;
        private DevExpress.XtraEditors.SimpleButton exitButton;
        private DevExpress.XtraBars.BarButtonItem biAddToLibrary;
        private DevExpress.XtraBars.PopupMenu addToLibraryMenu;
        private DevExpress.XtraBars.BarButtonItem biSaveImage;
        private DevExpress.XtraBars.BarButtonItem biGenerateData;
        private System.Windows.Forms.OpenFileDialog imageDialog;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup2;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup3;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonMiniToolbar ribbonMiniToolbar1;
        private DevExpress.XtraNavBar.NavBarControl navBar;
        private DevExpress.XtraNavBar.NavBarGroup albumGroup;
        private DevExpress.XtraNavBar.NavBarGroup foldersGroup;
        private DevExpress.XtraNavBar.NavBarGroup othersGroup;

        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private DevExpress.XtraBars.Docking.DockPanel panelContainer1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer controlContainer1;
        private DevExpress.XtraEditors.PictureEdit selectedPictureEdit;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel2;
        private DevExpress.XtraBars.Docking.ControlContainer controlContainer2;
        private DateFilter dateFilter;

        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView;
        private DevExpress.XtraBars.BarAndDockingController barAndDockingController;
        private DevExpress.XtraBars.BarButtonItem bBColorMix;
    }
}

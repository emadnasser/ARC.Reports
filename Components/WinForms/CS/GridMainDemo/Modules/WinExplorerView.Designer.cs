using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
namespace DevExpress.XtraGrid.Demos {
    partial class ExplorerView {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExplorerView));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem1 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem2 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem3 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem4 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem5 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem6 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem7 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.Skins.SkinPaddingEdges skinPaddingEdges1 = new DevExpress.Skins.SkinPaddingEdges();
            DevExpress.Skins.SkinPaddingEdges skinPaddingEdges2 = new DevExpress.Skins.SkinPaddingEdges();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.BreadCrumbNode breadCrumbNode1 = new DevExpress.XtraEditors.BreadCrumbNode();
            DevExpress.XtraEditors.BreadCrumbNode breadCrumbNode2 = new DevExpress.XtraEditors.BreadCrumbNode();
            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.RibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.imgs = new DevExpress.Utils.ImageCollection(this.components);
            this.ButtonItemHelp = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemNavigationPane = new DevExpress.XtraBars.BarSubItem();
            this.ButtonCheckItemNavigationPane = new DevExpress.XtraBars.BarCheckItem();
            this.ButtonCheckItemShowFavorites = new DevExpress.XtraBars.BarCheckItem();
            this.ButtonCheckItemShowLibraries = new DevExpress.XtraBars.BarCheckItem();
            this.ButtonItemItemCheckBoxes = new DevExpress.XtraBars.BarCheckItem();
            this.ButtonItemFileNameExtensions = new DevExpress.XtraBars.BarCheckItem();
            this.ButtonItemHiddenItems = new DevExpress.XtraBars.BarCheckItem();
            this.btnHideSelectedItems = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemCopy = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemPaste = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemCut = new DevExpress.XtraBars.BarButtonItem();
            this.btnCopyItem = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemMoveTo = new DevExpress.XtraBars.BarSubItem();
            this.ButtonItemDocuments = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemMusic = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemVideos = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemPictures = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemChooseLocation = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemCopyTo = new DevExpress.XtraBars.BarSubItem();
            this.ButtonItemRename = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemNewFolder = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemNewItem = new DevExpress.XtraBars.BarSubItem();
            this.ButtonItemNewShortcut = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemNewBitmapImage = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemNewContact = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemNewJournalDocument = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemNewRichTextDocument = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemNewTextDocument = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemCompressedFolder = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemEdit = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemSelectAll = new DevExpress.XtraBars.BarButtonItem();
            this.btnSelectNone = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemInvertSelection = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemPropertiesFolder = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemRemoveProperties = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.PopupMenuDeleteButton = new DevExpress.XtraBars.PopupMenu(this.components);
            this.ButtonItemRecycle = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemPermanentlyDelete = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemShowRecycleConfirmation = new DevExpress.XtraBars.BarCheckItem();
            this.ButtonItemProperties = new DevExpress.XtraBars.BarButtonItem();
            this.PopupMenuPropertiesButton = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnOpen = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItemOptions = new DevExpress.XtraBars.BarButtonItem();
            this.PopupMenuOptionsButton = new DevExpress.XtraBars.PopupMenu(this.components);
            this.ButtonItemChangeFilderOptions = new DevExpress.XtraBars.BarButtonItem();
            this.rgbiViewStyle = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.ContextItemOpen = new DevExpress.XtraBars.BarButtonItem();
            this.ContextItemCut = new DevExpress.XtraBars.BarButtonItem();
            this.ContextItemCopy = new DevExpress.XtraBars.BarButtonItem();
            this.ContextItemPaste = new DevExpress.XtraBars.BarButtonItem();
            this.ContextItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.ContextItemRename = new DevExpress.XtraBars.BarButtonItem();
            this.ContextItemProperties = new DevExpress.XtraBars.BarButtonItem();
            this.PageHome = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.PageGroupClipboard = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.PageGroupOrganize = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.PageGroupNew = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.PageGroupOpen = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.PageGroupSelect = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.PageView = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.PageGroupViewPanes = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.PageGroupViewLayouts = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.PageGroupViewShowHide = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.PageGroupViewEmpty = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.navBar = new DevExpress.XtraNavBar.NavBarControl();
            this.groupFavorites = new DevExpress.XtraNavBar.NavBarGroup();
            this.navPanelItemDesktop = new DevExpress.XtraNavBar.NavBarItem();
            this.navPanelItemDownloads = new DevExpress.XtraNavBar.NavBarItem();
            this.navPanelItemRecent = new DevExpress.XtraNavBar.NavBarItem();
            this.groupLibraries = new DevExpress.XtraNavBar.NavBarGroup();
            this.navPanelItemDocuments = new DevExpress.XtraNavBar.NavBarItem();
            this.navPanelItemMusic = new DevExpress.XtraNavBar.NavBarItem();
            this.navPanelItemPictures = new DevExpress.XtraNavBar.NavBarItem();
            this.navPanelItemVideos = new DevExpress.XtraNavBar.NavBarItem();
            this.navigationPanel = new DevExpress.XtraEditors.PanelControl();
            this.btnNavigationHistory = new DevExpress.XtraEditors.LabelControl();
            this.btnUpTo = new DevExpress.XtraEditors.LabelControl();
            this.imgArrows = new DevExpress.Utils.ImageCollection(this.components);
            this.btnForward = new DevExpress.XtraEditors.LabelControl();
            this.btnBack = new DevExpress.XtraEditors.LabelControl();
            this.EditSearch = new DevExpress.XtraEditors.ButtonEdit();
            this.editBreadCrumb = new DevExpress.XtraEditors.BreadCrumbEdit();
            this.contentPanel = new DevExpress.XtraEditors.PanelControl();
            this.LayoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.winExplorerView = new DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView();
            this.columnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnPath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LayoutControlMainGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.LayoutControlItemExplorerView = new DevExpress.XtraLayout.LayoutControlItem();
            this.SplitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.liNavPaneRight = new DevExpress.XtraLayout.LayoutControlItem();
            this.itemPopupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.navigationMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenuDeleteButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenuPropertiesButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenuOptionsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPanel)).BeginInit();
            this.navigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgArrows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editBreadCrumb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentPanel)).BeginInit();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControl)).BeginInit();
            this.LayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winExplorerView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlMainGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItemExplorerView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liNavPaneRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemTextEdit3
            // 
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            // 
            // repositoryItemTextEdit4
            // 
            this.repositoryItemTextEdit4.Name = "repositoryItemTextEdit4";
            // 
            // RibbonControl
            // 
            this.RibbonControl.ApplicationButtonText = "File";
            this.RibbonControl.ExpandCollapseItem.Id = 0;
            this.RibbonControl.Images = this.imgs;
            this.RibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.RibbonControl.ExpandCollapseItem,
            this.ButtonItemHelp,
            this.ButtonItemNavigationPane,
            this.ButtonItemItemCheckBoxes,
            this.ButtonItemFileNameExtensions,
            this.ButtonItemHiddenItems,
            this.btnHideSelectedItems,
            this.ButtonCheckItemNavigationPane,
            this.ButtonItemCopy,
            this.ButtonItemPaste,
            this.ButtonItemCut,
            this.btnCopyItem,
            this.ButtonItemMoveTo,
            this.ButtonItemCopyTo,
            this.ButtonItemRename,
            this.ButtonItemNewFolder,
            this.ButtonItemNewItem,
            this.ButtonItemEdit,
            this.ButtonItemSelectAll,
            this.btnSelectNone,
            this.ButtonItemInvertSelection,
            this.ButtonItemPropertiesFolder,
            this.ButtonItemRemoveProperties,
            this.ButtonItemDelete,
            this.ButtonItemRecycle,
            this.ButtonItemPermanentlyDelete,
            this.ButtonItemShowRecycleConfirmation,
            this.ButtonItemProperties,
            this.ButtonItemDocuments,
            this.ButtonItemMusic,
            this.ButtonItemVideos,
            this.ButtonItemPictures,
            this.ButtonItemChooseLocation,
            this.ButtonCheckItemShowFavorites,
            this.ButtonCheckItemShowLibraries,
            this.ButtonItemNewShortcut,
            this.ButtonItemNewBitmapImage,
            this.ButtonItemNewContact,
            this.ButtonItemNewJournalDocument,
            this.ButtonItemNewRichTextDocument,
            this.ButtonItemNewTextDocument,
            this.ButtonItemCompressedFolder,
            this.btnOpen,
            this.ButtonItemOptions,
            this.ButtonItemChangeFilderOptions,
            this.rgbiViewStyle,
            this.ContextItemOpen,
            this.ContextItemCut,
            this.ContextItemCopy,
            this.ContextItemPaste,
            this.ContextItemDelete,
            this.ContextItemRename,
            this.ContextItemProperties});
            this.RibbonControl.Location = new System.Drawing.Point(0, 0);
            this.RibbonControl.MaxItemId = 175;
            this.RibbonControl.Name = "RibbonControl";
            this.RibbonControl.PageHeaderItemLinks.Add(this.ButtonItemHelp);
            this.RibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.PageHome,
            this.PageView});
            this.RibbonControl.QuickToolbarItemLinks.Add(this.ButtonItemPropertiesFolder);
            this.RibbonControl.QuickToolbarItemLinks.Add(this.ButtonItemNewFolder);
            this.RibbonControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemRadioGroup1,
            this.repositoryItemTextEdit2});
            this.RibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.RibbonControl.Size = new System.Drawing.Size(1216, 141);
            // 
            // imgs
            // 
            this.imgs.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgs.ImageStream")));
            this.imgs.Images.SetKeyName(0, "open_16x16.png");
            this.imgs.Images.SetKeyName(1, "hoverDown.png");
            this.imgs.Images.SetKeyName(2, "normalDown.png");
            this.imgs.Images.SetKeyName(3, "pressedDown.png");
            // 
            // ButtonItemHelp
            // 
            this.ButtonItemHelp.Caption = "Help";
            this.ButtonItemHelp.Id = 15;
            this.ButtonItemHelp.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonItemHelp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ButtonItemHelp.ImageOptions.Image")));
            this.ButtonItemHelp.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("ButtonItemHelp.ImageOptions.LargeImage")));
            this.ButtonItemHelp.Name = "ButtonItemHelp";
            this.ButtonItemHelp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnHelpButtonItemClick);
            // 
            // ButtonItemNavigationPane
            // 
            this.ButtonItemNavigationPane.Caption = "Navigation pane";
            this.ButtonItemNavigationPane.Id = 16;
            this.ButtonItemNavigationPane.ImageOptions.LargeImage = global::DevExpress.XtraGrid.Demos.Properties.Resources.NavigationPaneLarge;
            this.ButtonItemNavigationPane.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonCheckItemNavigationPane),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonCheckItemShowFavorites, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonCheckItemShowLibraries)});
            this.ButtonItemNavigationPane.Name = "ButtonItemNavigationPane";
            this.ButtonItemNavigationPane.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ButtonCheckItemNavigationPane
            // 
            this.ButtonCheckItemNavigationPane.BindableChecked = true;
            this.ButtonCheckItemNavigationPane.Caption = "Navigation pane";
            this.ButtonCheckItemNavigationPane.Checked = true;
            this.ButtonCheckItemNavigationPane.Id = 37;
            this.ButtonCheckItemNavigationPane.Name = "ButtonCheckItemNavigationPane";
            this.ButtonCheckItemNavigationPane.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnShowNavPaneItemClick);
            // 
            // ButtonCheckItemShowFavorites
            // 
            this.ButtonCheckItemShowFavorites.BindableChecked = true;
            this.ButtonCheckItemShowFavorites.Caption = "Show favorites";
            this.ButtonCheckItemShowFavorites.Checked = true;
            this.ButtonCheckItemShowFavorites.Id = 118;
            this.ButtonCheckItemShowFavorites.Name = "ButtonCheckItemShowFavorites";
            this.ButtonCheckItemShowFavorites.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnShowFavoritesItemClick);
            // 
            // ButtonCheckItemShowLibraries
            // 
            this.ButtonCheckItemShowLibraries.BindableChecked = true;
            this.ButtonCheckItemShowLibraries.Caption = "Show libraries";
            this.ButtonCheckItemShowLibraries.Checked = true;
            this.ButtonCheckItemShowLibraries.Id = 119;
            this.ButtonCheckItemShowLibraries.Name = "ButtonCheckItemShowLibraries";
            this.ButtonCheckItemShowLibraries.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnShowLibrariesItemClick);
            // 
            // ButtonItemItemCheckBoxes
            // 
            this.ButtonItemItemCheckBoxes.Caption = "Item check boxes";
            this.ButtonItemItemCheckBoxes.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.ButtonItemItemCheckBoxes.Id = 26;
            this.ButtonItemItemCheckBoxes.Name = "ButtonItemItemCheckBoxes";
            this.ButtonItemItemCheckBoxes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnShowCheckBoxesItemClick);
            // 
            // ButtonItemFileNameExtensions
            // 
            this.ButtonItemFileNameExtensions.Caption = "File name extensions";
            this.ButtonItemFileNameExtensions.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.ButtonItemFileNameExtensions.Id = 27;
            this.ButtonItemFileNameExtensions.Name = "ButtonItemFileNameExtensions";
            this.ButtonItemFileNameExtensions.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnShowFileNameExtensionsCheckItemClick);
            // 
            // ButtonItemHiddenItems
            // 
            this.ButtonItemHiddenItems.Caption = "Hidden items";
            this.ButtonItemHiddenItems.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.ButtonItemHiddenItems.Id = 28;
            this.ButtonItemHiddenItems.Name = "ButtonItemHiddenItems";
            this.ButtonItemHiddenItems.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnShowHiddenItemsCheckItemClick);
            // 
            // btnHideSelectedItems
            // 
            this.btnHideSelectedItems.Caption = "Hide selected items";
            this.btnHideSelectedItems.Id = 29;
            this.btnHideSelectedItems.ImageOptions.LargeImage = global::DevExpress.XtraGrid.Demos.Properties.Resources.HideSelectedItemsLarge;
            this.btnHideSelectedItems.Name = "btnHideSelectedItems";
            this.btnHideSelectedItems.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ButtonItemCopy
            // 
            this.ButtonItemCopy.Caption = "Copy";
            this.ButtonItemCopy.Id = 38;
            this.ButtonItemCopy.ImageOptions.LargeImage = global::DevExpress.XtraGrid.Demos.Properties.Resources.CopyLarge;
            this.ButtonItemCopy.Name = "ButtonItemCopy";
            this.ButtonItemCopy.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            toolTipItem1.Text = "The command is not implemented";
            superToolTip1.Items.Add(toolTipItem1);
            this.ButtonItemCopy.SuperTip = superToolTip1;
            // 
            // ButtonItemPaste
            // 
            this.ButtonItemPaste.Caption = "Paste";
            this.ButtonItemPaste.Id = 39;
            this.ButtonItemPaste.ImageOptions.LargeImage = global::DevExpress.XtraGrid.Demos.Properties.Resources.PasteLarge;
            this.ButtonItemPaste.Name = "ButtonItemPaste";
            this.ButtonItemPaste.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.ButtonItemPaste.SuperTip = superToolTip1;
            // 
            // ButtonItemCut
            // 
            this.ButtonItemCut.Caption = "Cut";
            this.ButtonItemCut.Id = 40;
            this.ButtonItemCut.ImageOptions.Image = global::DevExpress.XtraGrid.Demos.Properties.Resources.CutSmall;
            this.ButtonItemCut.Name = "ButtonItemCut";
            this.ButtonItemCut.SuperTip = superToolTip1;
            // 
            // btnCopyItem
            // 
            this.btnCopyItem.Caption = "Copy path";
            this.btnCopyItem.Enabled = false;
            this.btnCopyItem.Id = 41;
            this.btnCopyItem.ImageOptions.Image = global::DevExpress.XtraGrid.Demos.Properties.Resources.CopyPathSmall;
            this.btnCopyItem.Name = "btnCopyItem";
            this.btnCopyItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnCopyPathItemClick);
            // 
            // ButtonItemMoveTo
            // 
            this.ButtonItemMoveTo.Caption = "Move to";
            this.ButtonItemMoveTo.Enabled = false;
            this.ButtonItemMoveTo.Id = 43;
            this.ButtonItemMoveTo.ImageOptions.LargeImage = global::DevExpress.XtraGrid.Demos.Properties.Resources.MoveToLarge;
            this.ButtonItemMoveTo.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonItemDocuments),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonItemMusic),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonItemVideos),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonItemPictures),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonItemChooseLocation, true)});
            this.ButtonItemMoveTo.Name = "ButtonItemMoveTo";
            this.ButtonItemMoveTo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ButtonItemDocuments
            // 
            this.ButtonItemDocuments.Caption = "Documents";
            this.ButtonItemDocuments.Id = 106;
            this.ButtonItemDocuments.ImageOptions.Image = global::DevExpress.XtraGrid.Demos.Properties.Resources.DocumentsSmall;
            this.ButtonItemDocuments.Name = "ButtonItemDocuments";
            this.ButtonItemDocuments.SuperTip = superToolTip1;
            // 
            // ButtonItemMusic
            // 
            this.ButtonItemMusic.Caption = "Music";
            this.ButtonItemMusic.Id = 107;
            this.ButtonItemMusic.ImageOptions.Image = global::DevExpress.XtraGrid.Demos.Properties.Resources.MusicSmall;
            this.ButtonItemMusic.Name = "ButtonItemMusic";
            this.ButtonItemMusic.SuperTip = superToolTip1;
            // 
            // ButtonItemVideos
            // 
            this.ButtonItemVideos.Caption = "Videos";
            this.ButtonItemVideos.Id = 108;
            this.ButtonItemVideos.ImageOptions.Image = global::DevExpress.XtraGrid.Demos.Properties.Resources.VideosSmall;
            this.ButtonItemVideos.Name = "ButtonItemVideos";
            this.ButtonItemVideos.SuperTip = superToolTip1;
            // 
            // ButtonItemPictures
            // 
            this.ButtonItemPictures.Caption = "Pictures";
            this.ButtonItemPictures.Id = 109;
            this.ButtonItemPictures.ImageOptions.Image = global::DevExpress.XtraGrid.Demos.Properties.Resources.Large;
            this.ButtonItemPictures.Name = "ButtonItemPictures";
            this.ButtonItemPictures.SuperTip = superToolTip1;
            // 
            // ButtonItemChooseLocation
            // 
            this.ButtonItemChooseLocation.Caption = "Choose location...";
            this.ButtonItemChooseLocation.Id = 110;
            this.ButtonItemChooseLocation.Name = "ButtonItemChooseLocation";
            // 
            // ButtonItemCopyTo
            // 
            this.ButtonItemCopyTo.Caption = "Copy to";
            this.ButtonItemCopyTo.Enabled = false;
            this.ButtonItemCopyTo.Id = 44;
            this.ButtonItemCopyTo.ImageOptions.Image = global::DevExpress.XtraGrid.Demos.Properties.Resources.CopyToLarge;
            this.ButtonItemCopyTo.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonItemDocuments),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonItemMusic),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonItemVideos),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonItemPictures),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonItemChooseLocation, true)});
            this.ButtonItemCopyTo.Name = "ButtonItemCopyTo";
            this.ButtonItemCopyTo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ButtonItemRename
            // 
            this.ButtonItemRename.Caption = "Rename";
            this.ButtonItemRename.Id = 46;
            this.ButtonItemRename.ImageOptions.LargeImage = global::DevExpress.XtraGrid.Demos.Properties.Resources.RenameLarge;
            this.ButtonItemRename.Name = "ButtonItemRename";
            this.ButtonItemRename.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.ButtonItemRename.SuperTip = superToolTip1;
            // 
            // ButtonItemNewFolder
            // 
            this.ButtonItemNewFolder.Caption = "New folder";
            this.ButtonItemNewFolder.Id = 47;
            this.ButtonItemNewFolder.ImageOptions.Image = global::DevExpress.XtraGrid.Demos.Properties.Resources.NewFolderSmall;
            this.ButtonItemNewFolder.Name = "ButtonItemNewFolder";
            this.ButtonItemNewFolder.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.ButtonItemNewFolder.SuperTip = superToolTip1;
            // 
            // ButtonItemNewItem
            // 
            this.ButtonItemNewItem.Caption = "New item";
            this.ButtonItemNewItem.Id = 48;
            this.ButtonItemNewItem.ImageOptions.Image = global::DevExpress.XtraGrid.Demos.Properties.Resources.NewItemSmall;
            this.ButtonItemNewItem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonItemNewFolder),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonItemNewShortcut),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonItemNewBitmapImage),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonItemNewContact),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonItemNewJournalDocument),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonItemNewRichTextDocument),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonItemNewTextDocument),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonItemCompressedFolder)});
            this.ButtonItemNewItem.Name = "ButtonItemNewItem";
            // 
            // ButtonItemNewShortcut
            // 
            this.ButtonItemNewShortcut.Caption = "Shortcut";
            this.ButtonItemNewShortcut.Id = 120;
            this.ButtonItemNewShortcut.Name = "ButtonItemNewShortcut";
            this.ButtonItemNewShortcut.SuperTip = superToolTip1;
            // 
            // ButtonItemNewBitmapImage
            // 
            this.ButtonItemNewBitmapImage.Caption = "Bitmap image";
            this.ButtonItemNewBitmapImage.Id = 121;
            this.ButtonItemNewBitmapImage.Name = "ButtonItemNewBitmapImage";
            this.ButtonItemNewBitmapImage.SuperTip = superToolTip1;
            // 
            // ButtonItemNewContact
            // 
            this.ButtonItemNewContact.Caption = "Contact";
            this.ButtonItemNewContact.Id = 122;
            this.ButtonItemNewContact.Name = "ButtonItemNewContact";
            this.ButtonItemNewContact.SuperTip = superToolTip1;
            // 
            // ButtonItemNewJournalDocument
            // 
            this.ButtonItemNewJournalDocument.Caption = "Journal document";
            this.ButtonItemNewJournalDocument.Id = 123;
            this.ButtonItemNewJournalDocument.Name = "ButtonItemNewJournalDocument";
            this.ButtonItemNewJournalDocument.SuperTip = superToolTip1;
            // 
            // ButtonItemNewRichTextDocument
            // 
            this.ButtonItemNewRichTextDocument.Caption = "Rich text document";
            this.ButtonItemNewRichTextDocument.Id = 124;
            this.ButtonItemNewRichTextDocument.Name = "ButtonItemNewRichTextDocument";
            this.ButtonItemNewRichTextDocument.SuperTip = superToolTip1;
            // 
            // ButtonItemNewTextDocument
            // 
            this.ButtonItemNewTextDocument.Caption = "Text document";
            this.ButtonItemNewTextDocument.Id = 125;
            this.ButtonItemNewTextDocument.Name = "ButtonItemNewTextDocument";
            this.ButtonItemNewTextDocument.SuperTip = superToolTip1;
            // 
            // ButtonItemCompressedFolder
            // 
            this.ButtonItemCompressedFolder.Caption = "Compressed (zipped) folder";
            this.ButtonItemCompressedFolder.Id = 126;
            this.ButtonItemCompressedFolder.Name = "ButtonItemCompressedFolder";
            this.ButtonItemCompressedFolder.SuperTip = superToolTip1;
            // 
            // ButtonItemEdit
            // 
            this.ButtonItemEdit.Caption = "Edit";
            this.ButtonItemEdit.Id = 52;
            this.ButtonItemEdit.ImageOptions.Image = global::DevExpress.XtraGrid.Demos.Properties.Resources.EditSmall;
            this.ButtonItemEdit.Name = "ButtonItemEdit";
            this.ButtonItemEdit.SuperTip = superToolTip1;
            // 
            // ButtonItemSelectAll
            // 
            this.ButtonItemSelectAll.Caption = "Select all";
            this.ButtonItemSelectAll.Id = 54;
            this.ButtonItemSelectAll.ImageOptions.Image = global::DevExpress.XtraGrid.Demos.Properties.Resources.SelectedAllSmall;
            this.ButtonItemSelectAll.Name = "ButtonItemSelectAll";
            this.ButtonItemSelectAll.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnSelectAllItemClick);
            // 
            // btnSelectNone
            // 
            this.btnSelectNone.Caption = "Select none";
            this.btnSelectNone.Id = 55;
            this.btnSelectNone.ImageOptions.Image = global::DevExpress.XtraGrid.Demos.Properties.Resources.SelectedNoneSmall;
            this.btnSelectNone.Name = "btnSelectNone";
            this.btnSelectNone.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnSelectNoneItemClick);
            // 
            // ButtonItemInvertSelection
            // 
            this.ButtonItemInvertSelection.Caption = "Invert selection";
            this.ButtonItemInvertSelection.Id = 56;
            this.ButtonItemInvertSelection.ImageOptions.Image = global::DevExpress.XtraGrid.Demos.Properties.Resources.InvertSelectionSmall;
            this.ButtonItemInvertSelection.Name = "ButtonItemInvertSelection";
            this.ButtonItemInvertSelection.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnInvertSelectionItemClick);
            // 
            // ButtonItemPropertiesFolder
            // 
            this.ButtonItemPropertiesFolder.Caption = "Properties";
            this.ButtonItemPropertiesFolder.Id = 97;
            this.ButtonItemPropertiesFolder.Name = "ButtonItemPropertiesFolder";
            this.ButtonItemPropertiesFolder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnOptionsItemClick);
            // 
            // ButtonItemRemoveProperties
            // 
            this.ButtonItemRemoveProperties.Caption = "Remove properties";
            this.ButtonItemRemoveProperties.Enabled = false;
            this.ButtonItemRemoveProperties.Id = 98;
            this.ButtonItemRemoveProperties.Name = "ButtonItemRemoveProperties";
            // 
            // ButtonItemDelete
            // 
            this.ButtonItemDelete.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.ButtonItemDelete.Caption = "Delete";
            this.ButtonItemDelete.DropDownControl = this.PopupMenuDeleteButton;
            this.ButtonItemDelete.Id = 99;
            this.ButtonItemDelete.ImageOptions.LargeImage = global::DevExpress.XtraGrid.Demos.Properties.Resources.DeleteLarge;
            this.ButtonItemDelete.Name = "ButtonItemDelete";
            this.ButtonItemDelete.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.ButtonItemDelete.SuperTip = superToolTip1;
            // 
            // PopupMenuDeleteButton
            // 
            this.PopupMenuDeleteButton.ItemLinks.Add(this.ButtonItemRecycle);
            this.PopupMenuDeleteButton.ItemLinks.Add(this.ButtonItemPermanentlyDelete);
            this.PopupMenuDeleteButton.ItemLinks.Add(this.ButtonItemShowRecycleConfirmation, true);
            this.PopupMenuDeleteButton.Name = "PopupMenuDeleteButton";
            this.PopupMenuDeleteButton.Ribbon = this.RibbonControl;
            // 
            // ButtonItemRecycle
            // 
            this.ButtonItemRecycle.Caption = "Recycle";
            this.ButtonItemRecycle.Id = 100;
            this.ButtonItemRecycle.Name = "ButtonItemRecycle";
            // 
            // ButtonItemPermanentlyDelete
            // 
            this.ButtonItemPermanentlyDelete.Caption = "Peramnently delete";
            this.ButtonItemPermanentlyDelete.Id = 101;
            this.ButtonItemPermanentlyDelete.Name = "ButtonItemPermanentlyDelete";
            // 
            // ButtonItemShowRecycleConfirmation
            // 
            this.ButtonItemShowRecycleConfirmation.Caption = "Show recycle confirmation";
            this.ButtonItemShowRecycleConfirmation.Id = 103;
            this.ButtonItemShowRecycleConfirmation.Name = "ButtonItemShowRecycleConfirmation";
            // 
            // ButtonItemProperties
            // 
            this.ButtonItemProperties.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.ButtonItemProperties.Caption = "Properties";
            this.ButtonItemProperties.DropDownControl = this.PopupMenuPropertiesButton;
            this.ButtonItemProperties.Id = 104;
            this.ButtonItemProperties.ImageOptions.LargeImage = global::DevExpress.XtraGrid.Demos.Properties.Resources.PropertiesLarge;
            this.ButtonItemProperties.Name = "ButtonItemProperties";
            this.ButtonItemProperties.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.ButtonItemProperties.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnOptionsItemClick);
            // 
            // PopupMenuPropertiesButton
            // 
            this.PopupMenuPropertiesButton.ItemLinks.Add(this.ButtonItemPropertiesFolder);
            this.PopupMenuPropertiesButton.ItemLinks.Add(this.ButtonItemRemoveProperties, true);
            this.PopupMenuPropertiesButton.Name = "PopupMenuPropertiesButton";
            this.PopupMenuPropertiesButton.Ribbon = this.RibbonControl;
            // 
            // btnOpen
            // 
            this.btnOpen.Caption = "Open";
            this.btnOpen.Enabled = false;
            this.btnOpen.Id = 134;
            this.btnOpen.ImageOptions.Image = global::DevExpress.XtraGrid.Demos.Properties.Resources.OpenSmall;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnOpenItemClick);
            // 
            // ButtonItemOptions
            // 
            this.ButtonItemOptions.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.ButtonItemOptions.Caption = "Options";
            this.ButtonItemOptions.DropDownControl = this.PopupMenuOptionsButton;
            this.ButtonItemOptions.Id = 135;
            this.ButtonItemOptions.ImageOptions.Image = global::DevExpress.XtraGrid.Demos.Properties.Resources.OptionsLarge;
            this.ButtonItemOptions.Name = "ButtonItemOptions";
            this.ButtonItemOptions.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.ButtonItemOptions.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnOptionsItemClick);
            // 
            // PopupMenuOptionsButton
            // 
            this.PopupMenuOptionsButton.ItemLinks.Add(this.ButtonItemChangeFilderOptions);
            this.PopupMenuOptionsButton.Name = "PopupMenuOptionsButton";
            this.PopupMenuOptionsButton.Ribbon = this.RibbonControl;
            // 
            // ButtonItemChangeFilderOptions
            // 
            this.ButtonItemChangeFilderOptions.Caption = "Change folder and search options";
            this.ButtonItemChangeFilderOptions.Id = 136;
            this.ButtonItemChangeFilderOptions.Name = "ButtonItemChangeFilderOptions";
            this.ButtonItemChangeFilderOptions.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnOptionsItemClick);
            // 
            // rgbiViewStyle
            // 
            this.rgbiViewStyle.Caption = "View";
            // 
            // 
            // 
            this.rgbiViewStyle.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseFont = true;
            this.rgbiViewStyle.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = true;
            this.rgbiViewStyle.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.rgbiViewStyle.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.rgbiViewStyle.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = true;
            this.rgbiViewStyle.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = true;
            this.rgbiViewStyle.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.rgbiViewStyle.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.rgbiViewStyle.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseFont = true;
            this.rgbiViewStyle.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = true;
            this.rgbiViewStyle.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.rgbiViewStyle.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.rgbiViewStyle.Gallery.ColumnCount = 3;
            this.rgbiViewStyle.Gallery.DrawImageBackground = false;
            galleryItemGroup1.Caption = "ViewStyleGroup";
            galleryItem1.Caption = "Extra large view";
            galleryItem1.Image = global::DevExpress.XtraGrid.Demos.Properties.Resources.ExtraLarge;
            galleryItem1.Tag = 1;
            galleryItem2.Caption = "Large icons";
            galleryItem2.Checked = true;
            galleryItem2.Image = global::DevExpress.XtraGrid.Demos.Properties.Resources.Large;
            galleryItem2.Tag = 2;
            galleryItem3.Caption = "Medium icons";
            galleryItem3.Image = global::DevExpress.XtraGrid.Demos.Properties.Resources.Medium;
            galleryItem3.Tag = 3;
            galleryItem4.Caption = "Small icons";
            galleryItem4.Image = global::DevExpress.XtraGrid.Demos.Properties.Resources.Small;
            galleryItem4.Tag = 4;
            galleryItem5.Caption = "List";
            galleryItem5.Image = global::DevExpress.XtraGrid.Demos.Properties.Resources.List;
            galleryItem5.Tag = 6;
            galleryItem6.Caption = "Tiles";
            galleryItem6.Image = global::DevExpress.XtraGrid.Demos.Properties.Resources.Tiles;
            galleryItem6.Tag = 5;
            galleryItem7.Caption = "Content";
            galleryItem7.Image = global::DevExpress.XtraGrid.Demos.Properties.Resources.Content;
            galleryItem7.Tag = 7;
            galleryItemGroup1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            galleryItem1,
            galleryItem2,
            galleryItem3,
            galleryItem4,
            galleryItem5,
            galleryItem6,
            galleryItem7});
            this.rgbiViewStyle.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1});
            this.rgbiViewStyle.Gallery.ImageSize = new System.Drawing.Size(18, 18);
            this.rgbiViewStyle.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleRadio;
            this.rgbiViewStyle.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            skinPaddingEdges1.Bottom = -3;
            skinPaddingEdges1.Top = -3;
            this.rgbiViewStyle.Gallery.ItemImagePadding = skinPaddingEdges1;
            skinPaddingEdges2.Bottom = -1;
            skinPaddingEdges2.Top = -1;
            this.rgbiViewStyle.Gallery.ItemTextPadding = skinPaddingEdges2;
            this.rgbiViewStyle.Gallery.ShowItemText = true;
            this.rgbiViewStyle.Id = 141;
            this.rgbiViewStyle.Name = "rgbiViewStyle";
            this.rgbiViewStyle.GalleryItemCheckedChanged += new DevExpress.XtraBars.Ribbon.GalleryItemEventHandler(this.OnViewStyleGalleryItemCheckedChanged);
            this.rgbiViewStyle.GalleryInitDropDownGallery += new DevExpress.XtraBars.Ribbon.InplaceGalleryEventHandler(this.OnRgbiViewStyleInitDropDown);
            // 
            // ContextItemOpen
            // 
            this.ContextItemOpen.Caption = "Open";
            this.ContextItemOpen.Id = 151;
            this.ContextItemOpen.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ContextItemOpen.ItemAppearance.Disabled.Options.UseFont = true;
            this.ContextItemOpen.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ContextItemOpen.ItemAppearance.Hovered.Options.UseFont = true;
            this.ContextItemOpen.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ContextItemOpen.ItemAppearance.Normal.Options.UseFont = true;
            this.ContextItemOpen.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ContextItemOpen.ItemAppearance.Pressed.Options.UseFont = true;
            this.ContextItemOpen.Name = "ContextItemOpen";
            this.ContextItemOpen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnOpenItemClick);
            // 
            // ContextItemCut
            // 
            this.ContextItemCut.Caption = "Cut";
            this.ContextItemCut.Id = 158;
            this.ContextItemCut.Name = "ContextItemCut";
            this.ContextItemCut.SuperTip = superToolTip1;
            // 
            // ContextItemCopy
            // 
            this.ContextItemCopy.Caption = "Copy";
            this.ContextItemCopy.Id = 159;
            this.ContextItemCopy.Name = "ContextItemCopy";
            this.ContextItemCopy.SuperTip = superToolTip1;
            // 
            // ContextItemPaste
            // 
            this.ContextItemPaste.Caption = "Paste";
            this.ContextItemPaste.Id = 160;
            this.ContextItemPaste.Name = "ContextItemPaste";
            this.ContextItemPaste.SuperTip = superToolTip1;
            // 
            // ContextItemDelete
            // 
            this.ContextItemDelete.Caption = "Delete";
            this.ContextItemDelete.Id = 162;
            this.ContextItemDelete.Name = "ContextItemDelete";
            this.ContextItemDelete.SuperTip = superToolTip1;
            // 
            // ContextItemRename
            // 
            this.ContextItemRename.Caption = "Rename";
            this.ContextItemRename.Id = 163;
            this.ContextItemRename.Name = "ContextItemRename";
            // 
            // ContextItemProperties
            // 
            this.ContextItemProperties.Caption = "Properties";
            this.ContextItemProperties.Id = 164;
            this.ContextItemProperties.Name = "ContextItemProperties";
            this.ContextItemProperties.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnOptionsItemClick);
            // 
            // PageHome
            // 
            this.PageHome.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.PageGroupClipboard,
            this.PageGroupOrganize,
            this.PageGroupNew,
            this.PageGroupOpen,
            this.PageGroupSelect});
            this.PageHome.Name = "PageHome";
            this.PageHome.Text = "Home";
            // 
            // PageGroupClipboard
            // 
            this.PageGroupClipboard.ItemLinks.Add(this.ButtonItemCopy);
            this.PageGroupClipboard.ItemLinks.Add(this.ButtonItemPaste);
            this.PageGroupClipboard.ItemLinks.Add(this.ButtonItemCut);
            this.PageGroupClipboard.ItemLinks.Add(this.btnCopyItem);
            this.PageGroupClipboard.Name = "PageGroupClipboard";
            this.PageGroupClipboard.ShowCaptionButton = false;
            this.PageGroupClipboard.Text = "Clipboard";
            // 
            // PageGroupOrganize
            // 
            this.PageGroupOrganize.ItemLinks.Add(this.ButtonItemMoveTo);
            this.PageGroupOrganize.ItemLinks.Add(this.ButtonItemCopyTo);
            this.PageGroupOrganize.ItemLinks.Add(this.ButtonItemDelete, true);
            this.PageGroupOrganize.ItemLinks.Add(this.ButtonItemRename);
            this.PageGroupOrganize.Name = "PageGroupOrganize";
            this.PageGroupOrganize.ShowCaptionButton = false;
            this.PageGroupOrganize.Text = "Organize";
            // 
            // PageGroupNew
            // 
            this.PageGroupNew.ItemLinks.Add(this.ButtonItemNewFolder);
            this.PageGroupNew.ItemLinks.Add(this.ButtonItemNewItem);
            this.PageGroupNew.Name = "PageGroupNew";
            this.PageGroupNew.ShowCaptionButton = false;
            this.PageGroupNew.Text = "New";
            // 
            // PageGroupOpen
            // 
            this.PageGroupOpen.ItemLinks.Add(this.ButtonItemProperties);
            this.PageGroupOpen.ItemLinks.Add(this.btnOpen);
            this.PageGroupOpen.ItemLinks.Add(this.ButtonItemEdit);
            this.PageGroupOpen.Name = "PageGroupOpen";
            this.PageGroupOpen.ShowCaptionButton = false;
            this.PageGroupOpen.Text = "Open";
            // 
            // PageGroupSelect
            // 
            this.PageGroupSelect.ItemLinks.Add(this.ButtonItemSelectAll);
            this.PageGroupSelect.ItemLinks.Add(this.btnSelectNone);
            this.PageGroupSelect.ItemLinks.Add(this.ButtonItemInvertSelection);
            this.PageGroupSelect.Name = "PageGroupSelect";
            this.PageGroupSelect.ShowCaptionButton = false;
            this.PageGroupSelect.Text = "Select";
            // 
            // PageView
            // 
            this.PageView.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.PageGroupViewPanes,
            this.PageGroupViewLayouts,
            this.PageGroupViewShowHide,
            this.PageGroupViewEmpty});
            this.PageView.Name = "PageView";
            this.PageView.Text = "View";
            // 
            // PageGroupViewPanes
            // 
            this.PageGroupViewPanes.ItemLinks.Add(this.ButtonItemNavigationPane);
            this.PageGroupViewPanes.Name = "PageGroupViewPanes";
            this.PageGroupViewPanes.ShowCaptionButton = false;
            this.PageGroupViewPanes.Text = "Panes";
            // 
            // PageGroupViewLayouts
            // 
            this.PageGroupViewLayouts.ItemLinks.Add(this.rgbiViewStyle);
            this.PageGroupViewLayouts.Name = "PageGroupViewLayouts";
            this.PageGroupViewLayouts.ShowCaptionButton = false;
            this.PageGroupViewLayouts.Text = "Layouts";
            // 
            // PageGroupViewShowHide
            // 
            this.PageGroupViewShowHide.ItemLinks.Add(this.ButtonItemItemCheckBoxes);
            this.PageGroupViewShowHide.ItemLinks.Add(this.ButtonItemFileNameExtensions);
            this.PageGroupViewShowHide.ItemLinks.Add(this.ButtonItemHiddenItems);
            this.PageGroupViewShowHide.ItemLinks.Add(this.btnHideSelectedItems);
            this.PageGroupViewShowHide.Name = "PageGroupViewShowHide";
            this.PageGroupViewShowHide.ShowCaptionButton = false;
            this.PageGroupViewShowHide.Text = "Show/Hide";
            // 
            // PageGroupViewEmpty
            // 
            this.PageGroupViewEmpty.ItemLinks.Add(this.ButtonItemOptions);
            this.PageGroupViewEmpty.Name = "PageGroupViewEmpty";
            this.PageGroupViewEmpty.ShowCaptionButton = false;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemRadioGroup1
            // 
            this.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // navBar
            // 
            this.navBar.ActiveGroup = this.groupFavorites;
            this.navBar.Appearance.GroupHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBar.Appearance.GroupHeader.Options.UseFont = true;
            this.navBar.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.navBar.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None;
            this.navBar.ExplorerBarGroupOuterIndent = 10;
            this.navBar.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.groupFavorites,
            this.groupLibraries});
            this.navBar.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navPanelItemDesktop,
            this.navPanelItemDownloads,
            this.navPanelItemRecent,
            this.navPanelItemDocuments,
            this.navPanelItemMusic,
            this.navPanelItemPictures,
            this.navPanelItemVideos});
            this.navBar.LinkInterval = 0;
            this.navBar.LinkSelectionMode = DevExpress.XtraNavBar.LinkSelectionModeType.OneInControl;
            this.navBar.Location = new System.Drawing.Point(919, 2);
            this.navBar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.navBar.Name = "navBar";
            this.navBar.OptionsNavPane.ExpandedWidth = 291;
            this.navBar.Size = new System.Drawing.Size(291, 538);
            this.navBar.TabIndex = 1;
            this.navBar.Text = "navigationPanel";
            this.navBar.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.OnNavPanelLinkClicked);
            // 
            // groupFavorites
            // 
            this.groupFavorites.Caption = "Favorites";
            this.groupFavorites.Expanded = true;
            this.groupFavorites.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navPanelItemDesktop),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navPanelItemDownloads),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navPanelItemRecent)});
            this.groupFavorites.Name = "groupFavorites";
            this.groupFavorites.SmallImage = global::DevExpress.XtraGrid.Demos.Properties.Resources.FavoritesSmall;
            // 
            // navPanelItemDesktop
            // 
            this.navPanelItemDesktop.Caption = "Desktop";
            this.navPanelItemDesktop.Name = "navPanelItemDesktop";
            this.navPanelItemDesktop.SmallImage = global::DevExpress.XtraGrid.Demos.Properties.Resources.DesktopSmall;
            // 
            // navPanelItemDownloads
            // 
            this.navPanelItemDownloads.Caption = "Downloads";
            this.navPanelItemDownloads.Name = "navPanelItemDownloads";
            this.navPanelItemDownloads.SmallImage = global::DevExpress.XtraGrid.Demos.Properties.Resources.DownloadsSmall;
            // 
            // navPanelItemRecent
            // 
            this.navPanelItemRecent.Caption = "Recent places";
            this.navPanelItemRecent.Name = "navPanelItemRecent";
            this.navPanelItemRecent.SmallImage = global::DevExpress.XtraGrid.Demos.Properties.Resources.RecentPlacesSmall;
            // 
            // groupLibraries
            // 
            this.groupLibraries.Caption = "Libraries";
            this.groupLibraries.Expanded = true;
            this.groupLibraries.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navPanelItemDocuments),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navPanelItemMusic),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navPanelItemPictures),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navPanelItemVideos)});
            this.groupLibraries.Name = "groupLibraries";
            this.groupLibraries.SmallImage = global::DevExpress.XtraGrid.Demos.Properties.Resources.LibrarySmall;
            // 
            // navPanelItemDocuments
            // 
            this.navPanelItemDocuments.Caption = "Documents";
            this.navPanelItemDocuments.Name = "navPanelItemDocuments";
            this.navPanelItemDocuments.SmallImage = global::DevExpress.XtraGrid.Demos.Properties.Resources.DocumentsSmall;
            // 
            // navPanelItemMusic
            // 
            this.navPanelItemMusic.Caption = "Music";
            this.navPanelItemMusic.Name = "navPanelItemMusic";
            this.navPanelItemMusic.SmallImage = global::DevExpress.XtraGrid.Demos.Properties.Resources.MusicSmall;
            // 
            // navPanelItemPictures
            // 
            this.navPanelItemPictures.Caption = "Pictures";
            this.navPanelItemPictures.Name = "navPanelItemPictures";
            this.navPanelItemPictures.SmallImage = global::DevExpress.XtraGrid.Demos.Properties.Resources.Large;
            // 
            // navPanelItemVideos
            // 
            this.navPanelItemVideos.Caption = "Videos";
            this.navPanelItemVideos.Name = "navPanelItemVideos";
            this.navPanelItemVideos.SmallImage = global::DevExpress.XtraGrid.Demos.Properties.Resources.VideosSmall;
            // 
            // navigationPanel
            // 
            this.navigationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navigationPanel.Controls.Add(this.btnNavigationHistory);
            this.navigationPanel.Controls.Add(this.btnUpTo);
            this.navigationPanel.Controls.Add(this.btnForward);
            this.navigationPanel.Controls.Add(this.btnBack);
            this.navigationPanel.Controls.Add(this.EditSearch);
            this.navigationPanel.Controls.Add(this.editBreadCrumb);
            this.navigationPanel.Location = new System.Drawing.Point(0, 145);
            this.navigationPanel.Margin = new System.Windows.Forms.Padding(0);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(1216, 34);
            this.navigationPanel.TabIndex = 3;
            // 
            // btnNavigationHistory
            // 
            this.btnNavigationHistory.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnNavigationHistory.Appearance.ImageIndex = 2;
            this.btnNavigationHistory.Appearance.ImageList = this.imgs;
            this.btnNavigationHistory.Appearance.Options.UseImageIndex = true;
            this.btnNavigationHistory.Appearance.Options.UseImageList = true;
            this.btnNavigationHistory.AppearanceHovered.ImageIndex = 1;
            this.btnNavigationHistory.AppearanceHovered.Options.UseImageIndex = true;
            this.btnNavigationHistory.AppearancePressed.ImageIndex = 3;
            this.btnNavigationHistory.AppearancePressed.Options.UseImageIndex = true;
            this.btnNavigationHistory.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.btnNavigationHistory.Location = new System.Drawing.Point(60, 8);
            this.btnNavigationHistory.Name = "btnNavigationHistory";
            this.btnNavigationHistory.Size = new System.Drawing.Size(16, 18);
            this.btnNavigationHistory.TabIndex = 8;
            this.btnNavigationHistory.Click += new System.EventHandler(this.OnNavigationMenuButtonClick);
            // 
            // btnUpTo
            // 
            this.btnUpTo.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnUpTo.Appearance.ImageIndex = 5;
            this.btnUpTo.Appearance.ImageList = this.imgArrows;
            this.btnUpTo.Appearance.Options.UseImageIndex = true;
            this.btnUpTo.Appearance.Options.UseImageList = true;
            this.btnUpTo.AppearanceHovered.ImageIndex = 2;
            this.btnUpTo.AppearanceHovered.Options.UseImageIndex = true;
            this.btnUpTo.AppearancePressed.ImageIndex = 8;
            this.btnUpTo.AppearancePressed.Options.UseImageIndex = true;
            this.btnUpTo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.btnUpTo.Location = new System.Drawing.Point(76, 5);
            this.btnUpTo.Name = "btnUpTo";
            this.btnUpTo.Size = new System.Drawing.Size(24, 24);
            this.btnUpTo.TabIndex = 7;
            this.btnUpTo.Click += new System.EventHandler(this.OnUpButtonClick);
            // 
            // imgArrows
            // 
            this.imgArrows.ImageSize = new System.Drawing.Size(24, 24);
            this.imgArrows.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgArrows.ImageStream")));
            this.imgArrows.Images.SetKeyName(0, "hoverBack.png");
            this.imgArrows.Images.SetKeyName(1, "hoverNext.png");
            this.imgArrows.Images.SetKeyName(2, "hoverUp.png");
            this.imgArrows.Images.SetKeyName(3, "normalBack.png");
            this.imgArrows.Images.SetKeyName(4, "normalNext.png");
            this.imgArrows.Images.SetKeyName(5, "normalUp.png");
            this.imgArrows.Images.SetKeyName(6, "pressedBack.png");
            this.imgArrows.Images.SetKeyName(7, "pressedNext.png");
            this.imgArrows.Images.SetKeyName(8, "pressedUp.png");
            // 
            // btnForward
            // 
            this.btnForward.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnForward.Appearance.ImageIndex = 4;
            this.btnForward.Appearance.ImageList = this.imgArrows;
            this.btnForward.Appearance.Options.UseImageIndex = true;
            this.btnForward.Appearance.Options.UseImageList = true;
            this.btnForward.AppearanceHovered.ImageIndex = 1;
            this.btnForward.AppearanceHovered.Options.UseImageIndex = true;
            this.btnForward.AppearancePressed.ImageIndex = 7;
            this.btnForward.AppearancePressed.Options.UseImageIndex = true;
            this.btnForward.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.btnForward.Location = new System.Drawing.Point(36, 8);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(18, 18);
            this.btnForward.TabIndex = 6;
            this.btnForward.Click += new System.EventHandler(this.OnNextButtonClick);
            // 
            // btnBack
            // 
            this.btnBack.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnBack.Appearance.ImageIndex = 3;
            this.btnBack.Appearance.ImageList = this.imgArrows;
            this.btnBack.Appearance.Options.UseImageIndex = true;
            this.btnBack.Appearance.Options.UseImageList = true;
            this.btnBack.AppearanceHovered.ImageIndex = 0;
            this.btnBack.AppearanceHovered.Options.UseImageIndex = true;
            this.btnBack.AppearancePressed.ImageIndex = 6;
            this.btnBack.AppearancePressed.Options.UseImageIndex = true;
            this.btnBack.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.btnBack.Location = new System.Drawing.Point(7, 8);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(18, 18);
            this.btnBack.TabIndex = 5;
            this.btnBack.Click += new System.EventHandler(this.OnBackButtonClick);
            // 
            // EditSearch
            // 
            this.EditSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditSearch.Location = new System.Drawing.Point(941, 5);
            this.EditSearch.MenuManager = this.RibbonControl;
            this.EditSearch.Name = "EditSearch";
            this.EditSearch.Properties.AutoHeight = false;
            this.EditSearch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("EditSearch.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.EditSearch.Size = new System.Drawing.Size(263, 24);
            this.EditSearch.TabIndex = 4;
            this.EditSearch.TextChanged += new System.EventHandler(this.OnEditSearchTextChanged);
            // 
            // editBreadCrumb
            // 
            this.editBreadCrumb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editBreadCrumb.Location = new System.Drawing.Point(106, 5);
            this.editBreadCrumb.MenuManager = this.RibbonControl;
            this.editBreadCrumb.Name = "editBreadCrumb";
            this.editBreadCrumb.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.SpinDown, "", 18, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo, "", 15, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.editBreadCrumb.Properties.DropDownRows = 12;
            this.editBreadCrumb.Properties.ImageIndex = 0;
            this.editBreadCrumb.Properties.Images = this.imgs;
            breadCrumbNode1.Caption = "Root";
            breadCrumbNode1.Persistent = true;
            breadCrumbNode1.PopulateOnDemand = true;
            breadCrumbNode1.ShowCaption = false;
            breadCrumbNode1.Value = "Root";
            breadCrumbNode2.Caption = "Computer";
            breadCrumbNode2.Persistent = true;
            breadCrumbNode2.PopulateOnDemand = true;
            breadCrumbNode2.Value = "Computer";
            this.editBreadCrumb.Properties.Nodes.AddRange(new DevExpress.XtraEditors.BreadCrumbNode[] {
            breadCrumbNode1,
            breadCrumbNode2});
            this.editBreadCrumb.Properties.RootImageIndex = 0;
            this.editBreadCrumb.Properties.SortNodesByCaption = true;
            this.editBreadCrumb.Properties.RootGlyphClick += new System.EventHandler(this.OnBreadCrumbRootGlyphClick);
            this.editBreadCrumb.Properties.QueryChildNodes += new DevExpress.XtraEditors.BreadCrumbQueryChildNodesEventHandler(this.OnBreadCrumbQueryChildNodes);
            this.editBreadCrumb.Properties.ValidatePath += new DevExpress.XtraEditors.BreadCrumbValidatePathEventHandler(this.OnBreadCrumbValidatePath);
            this.editBreadCrumb.Properties.NewNodeAdding += new DevExpress.XtraEditors.BreadCrumbNewNodeAddingEventHandler(this.OnBreadCrumbNewNodeAdding);
            this.editBreadCrumb.Size = new System.Drawing.Size(828, 22);
            this.editBreadCrumb.TabIndex = 3;
            this.editBreadCrumb.PathChanged += new DevExpress.XtraEditors.BreadCrumbPathChangedEventHandler(this.OnBreadCrumbPathChanged);
            // 
            // contentPanel
            // 
            this.contentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentPanel.Controls.Add(this.LayoutControl);
            this.contentPanel.Location = new System.Drawing.Point(0, 179);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1216, 546);
            this.contentPanel.TabIndex = 5;
            // 
            // LayoutControl
            // 
            this.LayoutControl.Controls.Add(this.gridControl);
            this.LayoutControl.Controls.Add(this.navBar);
            this.LayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutControl.Location = new System.Drawing.Point(2, 2);
            this.LayoutControl.Name = "LayoutControl";
            this.LayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(318, 324, 836, 529);
            this.LayoutControl.Root = this.LayoutControlMainGroup;
            this.LayoutControl.Size = new System.Drawing.Size(1212, 542);
            this.LayoutControl.TabIndex = 3;
            this.LayoutControl.Text = "LayoutControl";
            // 
            // gridControl
            // 
            this.gridControl.Location = new System.Drawing.Point(2, 2);
            this.gridControl.MainView = this.winExplorerView;
            this.gridControl.MenuManager = this.RibbonControl;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(908, 538);
            this.gridControl.TabIndex = 2;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.winExplorerView});
            // 
            // winExplorerView
            // 
            this.winExplorerView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.winExplorerView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.columnName,
            this.columnPath,
            this.columnCheck,
            this.columnGroup,
            this.columnImage});
            this.winExplorerView.ColumnSet.CheckBoxColumn = this.columnCheck;
            this.winExplorerView.ColumnSet.DescriptionColumn = this.columnPath;
            this.winExplorerView.ColumnSet.ExtraLargeImageColumn = this.columnImage;
            this.winExplorerView.ColumnSet.GroupColumn = this.columnGroup;
            this.winExplorerView.ColumnSet.LargeImageColumn = this.columnImage;
            this.winExplorerView.ColumnSet.MediumImageColumn = this.columnImage;
            this.winExplorerView.ColumnSet.SmallImageColumn = this.columnImage;
            this.winExplorerView.ColumnSet.TextColumn = this.columnName;
            this.winExplorerView.GridControl = this.gridControl;
            this.winExplorerView.GroupCount = 1;
            this.winExplorerView.Name = "winExplorerView";
            this.winExplorerView.OptionsBehavior.Editable = false;
            this.winExplorerView.OptionsSelection.AllowMarqueeSelection = true;
            this.winExplorerView.OptionsSelection.ItemSelectionMode = DevExpress.XtraGrid.Views.WinExplorer.IconItemSelectionMode.Click;
            this.winExplorerView.OptionsSelection.MultiSelect = true;
            this.winExplorerView.OptionsView.ImageLayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.Stretch;
            this.winExplorerView.OptionsView.ShowViewCaption = true;
            this.winExplorerView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.columnGroup, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.winExplorerView.ItemClick += new DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewItemClickEventHandler(this.OnWinExplorerViewItemClick);
            this.winExplorerView.ItemDoubleClick += new DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewItemDoubleClickEventHandler(this.OnWinExplorerViewItemDoubleClick);
            this.winExplorerView.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.OnWinExplorerViewSelectionChanged);
            this.winExplorerView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnWinExplorerViewKeyDown);
            // 
            // columnName
            // 
            this.columnName.Caption = "columnName";
            this.columnName.FieldName = "Name";
            this.columnName.Name = "columnName";
            this.columnName.Visible = true;
            this.columnName.VisibleIndex = 0;
            // 
            // columnPath
            // 
            this.columnPath.Caption = "columnPath";
            this.columnPath.FieldName = "Path";
            this.columnPath.Name = "columnPath";
            this.columnPath.Visible = true;
            this.columnPath.VisibleIndex = 0;
            // 
            // columnCheck
            // 
            this.columnCheck.Caption = "columnCheck";
            this.columnCheck.FieldName = "IsCheck";
            this.columnCheck.Name = "columnCheck";
            this.columnCheck.Visible = true;
            this.columnCheck.VisibleIndex = 0;
            // 
            // columnGroup
            // 
            this.columnGroup.Caption = "columnGroup";
            this.columnGroup.FieldName = "Group";
            this.columnGroup.Name = "columnGroup";
            this.columnGroup.Visible = true;
            this.columnGroup.VisibleIndex = 0;
            // 
            // columnImage
            // 
            this.columnImage.Caption = "columnImage";
            this.columnImage.FieldName = "Image";
            this.columnImage.Name = "columnImage";
            this.columnImage.Visible = true;
            this.columnImage.VisibleIndex = 0;
            // 
            // LayoutControlMainGroup
            // 
            this.LayoutControlMainGroup.CustomizationFormText = "Root";
            this.LayoutControlMainGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.LayoutControlMainGroup.GroupBordersVisible = false;
            this.LayoutControlMainGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.LayoutControlItemExplorerView,
            this.SplitterItem1,
            this.liNavPaneRight});
            this.LayoutControlMainGroup.Location = new System.Drawing.Point(0, 0);
            this.LayoutControlMainGroup.Name = "Root";
            this.LayoutControlMainGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 10, 10, 10);
            this.LayoutControlMainGroup.Size = new System.Drawing.Size(1212, 542);
            this.LayoutControlMainGroup.TextVisible = false;
            // 
            // LayoutControlItemExplorerView
            // 
            this.LayoutControlItemExplorerView.Control = this.gridControl;
            this.LayoutControlItemExplorerView.CustomizationFormText = "LayoutControlItemExplorerView";
            this.LayoutControlItemExplorerView.Location = new System.Drawing.Point(0, 0);
            this.LayoutControlItemExplorerView.Name = "LayoutControlItemExplorerView";
            this.LayoutControlItemExplorerView.Size = new System.Drawing.Size(912, 542);
            this.LayoutControlItemExplorerView.TextSize = new System.Drawing.Size(0, 0);
            this.LayoutControlItemExplorerView.TextVisible = false;
            // 
            // SplitterItem1
            // 
            this.SplitterItem1.AllowHotTrack = true;
            this.SplitterItem1.CustomizationFormText = "SplitterItem1";
            this.SplitterItem1.Location = new System.Drawing.Point(912, 0);
            this.SplitterItem1.Name = "SplitterItem1";
            this.SplitterItem1.Size = new System.Drawing.Size(5, 542);
            // 
            // liNavPaneRight
            // 
            this.liNavPaneRight.Control = this.navBar;
            this.liNavPaneRight.CustomizationFormText = "LayoutControlItemNavigationPaneRight";
            this.liNavPaneRight.Location = new System.Drawing.Point(917, 0);
            this.liNavPaneRight.Name = "LayoutControlItemNavigationPaneRight";
            this.liNavPaneRight.Size = new System.Drawing.Size(295, 542);
            this.liNavPaneRight.TextSize = new System.Drawing.Size(0, 0);
            this.liNavPaneRight.TextVisible = false;
            // 
            // itemPopupMenu
            // 
            this.itemPopupMenu.ItemLinks.Add(this.ContextItemOpen);
            this.itemPopupMenu.ItemLinks.Add(this.ContextItemCut, true);
            this.itemPopupMenu.ItemLinks.Add(this.ContextItemCopy);
            this.itemPopupMenu.ItemLinks.Add(this.ContextItemPaste);
            this.itemPopupMenu.ItemLinks.Add(this.ContextItemDelete);
            this.itemPopupMenu.ItemLinks.Add(this.ContextItemRename);
            this.itemPopupMenu.ItemLinks.Add(this.ContextItemProperties, true);
            this.itemPopupMenu.Name = "itemPopupMenu";
            this.itemPopupMenu.Ribbon = this.RibbonControl;
            // 
            // navigationMenu
            // 
            this.navigationMenu.Name = "navigationMenu";
            this.navigationMenu.Ribbon = this.RibbonControl;
            // 
            // ExplorerView
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.navigationPanel);
            this.Controls.Add(this.RibbonControl);
            this.Name = "ExplorerView";
            this.Size = new System.Drawing.Size(1216, 725);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenuDeleteButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenuPropertiesButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenuOptionsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPanel)).EndInit();
            this.navigationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgArrows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editBreadCrumb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentPanel)).EndInit();
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControl)).EndInit();
            this.LayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winExplorerView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlMainGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItemExplorerView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liNavPaneRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl RibbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage PageHome;
        private DevExpress.XtraBars.Ribbon.RibbonPage PageView;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup PageGroupViewPanes;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup PageGroupViewLayouts;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup PageGroupViewShowHide;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup PageGroupViewEmpty;
        private DevExpress.XtraBars.BarButtonItem ButtonItemHelp;
        private DevExpress.XtraBars.BarSubItem ButtonItemNavigationPane;
        private DevExpress.XtraBars.BarCheckItem ButtonItemItemCheckBoxes;
        private DevExpress.XtraBars.BarCheckItem ButtonItemFileNameExtensions;
        private DevExpress.XtraBars.BarCheckItem ButtonItemHiddenItems;
        private DevExpress.XtraBars.BarButtonItem btnHideSelectedItems;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraNavBar.NavBarControl navBar;
        private DevExpress.XtraNavBar.NavBarGroup groupFavorites;
        private DevExpress.XtraNavBar.NavBarItem navPanelItemDesktop;
        private DevExpress.XtraNavBar.NavBarItem navPanelItemDownloads;
        private DevExpress.XtraNavBar.NavBarItem navPanelItemRecent;
        private DevExpress.XtraBars.BarCheckItem ButtonCheckItemNavigationPane;
        private DevExpress.XtraBars.BarButtonItem ButtonItemCopy;
        private DevExpress.XtraBars.BarButtonItem ButtonItemPaste;
        private DevExpress.XtraBars.BarButtonItem ButtonItemCut;
        private DevExpress.XtraBars.BarButtonItem btnCopyItem;
        private DevExpress.XtraBars.BarSubItem ButtonItemMoveTo;
        private DevExpress.XtraBars.BarSubItem ButtonItemCopyTo;
        private DevExpress.XtraBars.BarButtonItem ButtonItemRename;
        private DevExpress.XtraBars.BarButtonItem ButtonItemNewFolder;
        private DevExpress.XtraBars.BarSubItem ButtonItemNewItem;
        private DevExpress.XtraBars.BarButtonItem ButtonItemEdit;
        private DevExpress.XtraBars.BarButtonItem ButtonItemSelectAll;
        private DevExpress.XtraBars.BarButtonItem btnSelectNone;
        private DevExpress.XtraBars.BarButtonItem ButtonItemInvertSelection;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup PageGroupClipboard;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup PageGroupOrganize;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup PageGroupNew;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup PageGroupOpen;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup PageGroupSelect;
        private DevExpress.XtraEditors.PanelControl navigationPanel;
        private DevExpress.XtraEditors.PanelControl contentPanel;
        private DevExpress.XtraNavBar.NavBarGroup groupLibraries;
        private DevExpress.XtraNavBar.NavBarItem navPanelItemDocuments;
        private DevExpress.XtraNavBar.NavBarItem navPanelItemMusic;
        private DevExpress.XtraNavBar.NavBarItem navPanelItemPictures;
        private DevExpress.XtraNavBar.NavBarItem navPanelItemVideos;
        private DevExpress.XtraBars.BarButtonItem ButtonItemPropertiesFolder;
        private DevExpress.XtraBars.BarButtonItem ButtonItemRemoveProperties;
        private DevExpress.XtraBars.BarButtonItem ButtonItemDelete;
        private DevExpress.XtraBars.BarButtonItem ButtonItemPermanentlyDelete;
        private DevExpress.XtraBars.PopupMenu PopupMenuDeleteButton;
        private DevExpress.XtraBars.BarButtonItem ButtonItemRecycle;
        private DevExpress.XtraBars.BarCheckItem ButtonItemShowRecycleConfirmation;
        private DevExpress.XtraBars.BarButtonItem ButtonItemProperties;
        private DevExpress.XtraBars.PopupMenu PopupMenuPropertiesButton;
        private DevExpress.XtraBars.BarButtonItem ButtonItemDocuments;
        private DevExpress.XtraBars.BarButtonItem ButtonItemMusic;
        private DevExpress.XtraBars.BarButtonItem ButtonItemVideos;
        private DevExpress.XtraBars.BarButtonItem ButtonItemPictures;
        private DevExpress.XtraBars.BarButtonItem ButtonItemChooseLocation;
        private DevExpress.XtraBars.BarCheckItem ButtonCheckItemShowFavorites;
        private DevExpress.XtraBars.BarCheckItem ButtonCheckItemShowLibraries;
        private DevExpress.XtraBars.BarButtonItem ButtonItemNewShortcut;
        private DevExpress.XtraBars.BarButtonItem ButtonItemNewBitmapImage;
        private DevExpress.XtraBars.BarButtonItem ButtonItemNewContact;
        private DevExpress.XtraBars.BarButtonItem ButtonItemNewJournalDocument;
        private DevExpress.XtraBars.BarButtonItem ButtonItemNewRichTextDocument;
        private DevExpress.XtraBars.BarButtonItem ButtonItemNewTextDocument;
        private DevExpress.XtraBars.BarButtonItem ButtonItemCompressedFolder;
        private ButtonEdit EditSearch;
        private BreadCrumbEdit editBreadCrumb;
        private DevExpress.XtraBars.BarButtonItem btnOpen;
        private DevExpress.XtraBars.BarButtonItem ButtonItemOptions;
        private DevExpress.XtraBars.BarButtonItem ButtonItemChangeFilderOptions;
        private DevExpress.XtraBars.PopupMenu PopupMenuOptionsButton;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private DevExpress.XtraBars.RibbonGalleryBarItem rgbiViewStyle;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView winExplorerView;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit4;
        private LabelControl btnBack;
        private LabelControl btnForward;
        private LabelControl btnUpTo;
        private DevExpress.XtraLayout.LayoutControl LayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup LayoutControlMainGroup;
        private DevExpress.XtraLayout.LayoutControlItem LayoutControlItemExplorerView;
        private DevExpress.XtraLayout.LayoutControlItem liNavPaneRight;
        private DevExpress.XtraLayout.SplitterItem SplitterItem1;
        private DevExpress.XtraBars.BarButtonItem ContextItemOpen;
        private DevExpress.XtraBars.BarButtonItem ContextItemCut;
        private DevExpress.XtraBars.BarButtonItem ContextItemCopy;
        private DevExpress.XtraBars.BarButtonItem ContextItemPaste;
        private DevExpress.XtraBars.BarButtonItem ContextItemDelete;
        private DevExpress.XtraBars.BarButtonItem ContextItemRename;
        private DevExpress.XtraBars.BarButtonItem ContextItemProperties;
        private Utils.ImageCollection imgArrows;
        private Utils.ImageCollection imgs;
        private Columns.GridColumn columnName;
        private Columns.GridColumn columnPath;
        private Columns.GridColumn columnCheck;
        private Columns.GridColumn columnGroup;
        private Columns.GridColumn columnImage;
        private XtraBars.PopupMenu itemPopupMenu;
        private LabelControl btnNavigationHistory;
        private XtraBars.PopupMenu navigationMenu;
    }
}


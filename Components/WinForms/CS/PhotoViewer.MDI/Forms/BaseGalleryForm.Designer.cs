using DevExpress.XtraTab;
namespace PhotoViewer {
    partial class GalleryForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GalleryForm));
            this.biPrint = new DevExpress.XtraBars.BarButtonItem();
            this.albumSubItem = new DevExpress.XtraBars.BarSubItem();
            this.bsView = new DevExpress.XtraBars.BarSubItem();
            this.biView = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.childRibbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.biExportFolder = new DevExpress.XtraBars.BarButtonItem();
            this.biEmail = new DevExpress.XtraBars.BarButtonItem();
            this.biUpload = new DevExpress.XtraBars.BarButtonItem();
            this.biRemoveFilesFromLibrary = new DevExpress.XtraBars.BarButtonItem();
            this.biAddToAlbum = new DevExpress.XtraBars.BarButtonItem();
            this.albumsPopupMenu = new DevExpress.XtraBars.PopupMenu();
            this.biMark = new DevExpress.XtraBars.BarButtonItem();
            this.biUnmark = new DevExpress.XtraBars.BarButtonItem();
            this.biUnmarkAll = new DevExpress.XtraBars.BarButtonItem();
            this.biCollage = new DevExpress.XtraBars.BarButtonItem();
            this.biSlideShow = new DevExpress.XtraBars.BarButtonItem();
            this.biFilm = new DevExpress.XtraBars.BarButtonItem();
            this.biSaveImage = new DevExpress.XtraBars.BarButtonItem();
            this.biCancel = new DevExpress.XtraBars.BarButtonItem();
            this.biClose = new DevExpress.XtraBars.BarButtonItem();
            this.filtersGallery = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.biFilterByMarked = new DevExpress.XtraBars.BarCheckItem();
            this.biRemoveFromAlbum = new DevExpress.XtraBars.BarButtonItem();
            this.biSelectAllMarked = new DevExpress.XtraBars.BarButtonItem();
            this.beZoom = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemZoomTrackBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar();
            this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonGroup2 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonGroup3 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonGroup4 = new DevExpress.XtraBars.BarButtonGroup();
            this.viewPageCategory = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.collectionOriginalPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.filtersFilePageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.filtersPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.imagePage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.imageGeneralPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.imageMarkingPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.makePageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.outputPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.addToLibraryMenu = new DevExpress.XtraBars.PopupMenu();
            this.gallery = new DevExpress.XtraBars.Ribbon.GalleryControl();
            this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            this.defaultToolTipController1 = new DevExpress.Utils.DefaultToolTipController();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.libraryPanel = new System.Windows.Forms.UserControl();
            this.galleryContentPanel = new System.Windows.Forms.Panel();
            this.galleryPanel = new System.Windows.Forms.Panel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.controlPresenter = new DevExpress.Utils.Controls.ControlPresenter();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.galleryItemMenu = new DevExpress.XtraBars.PopupMenu();
            this.imageDialog = new System.Windows.Forms.OpenFileDialog();
            this.ribbonMiniToolbar1 = new DevExpress.XtraBars.Ribbon.RibbonMiniToolbar();
            ((System.ComponentModel.ISupportInitialize)(this.childRibbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsPopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemZoomTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addToLibraryMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gallery)).BeginInit();
            this.gallery.SuspendLayout();
            this.libraryPanel.SuspendLayout();
            this.galleryContentPanel.SuspendLayout();
            this.galleryPanel.SuspendLayout();
            this.controlPresenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.galleryItemMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // biPrint
            // 
            this.biPrint.Caption = "Print";
            this.biPrint.Glyph = global::PhotoViewer.Properties.Resources.Print_16x16;
            this.biPrint.Hint = "Print selected images";
            this.biPrint.Id = 11;
            this.biPrint.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P));
            this.biPrint.LargeGlyph = global::PhotoViewer.Properties.Resources.Print_32x32;
            this.biPrint.Name = "biPrint";
            this.biPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnPrintItemClick);
            // 
            // albumSubItem
            // 
            this.albumSubItem.Caption = "&Album";
            this.albumSubItem.Id = 18;
            this.albumSubItem.Name = "albumSubItem";
            // 
            // bsView
            // 
            this.bsView.Caption = "&View";
            this.bsView.Id = 2;
            this.bsView.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.biView)});
            this.bsView.Name = "bsView";
            // 
            // biView
            // 
            this.biView.Caption = "View";
            this.biView.Glyph = global::PhotoViewer.Properties.Resources.View_16x16;
            this.biView.Hint = "View selected images";
            this.biView.Id = 19;
            this.biView.LargeGlyph = global::PhotoViewer.Properties.Resources.View_32x32;
            this.biView.Name = "biView";
            this.biView.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnViewSelectedImagesItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Delete Folder";
            this.barButtonItem2.Id = 13;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // childRibbon
            // 
            this.childRibbon.ApplicationButtonText = null;
            this.childRibbon.ExpandCollapseItem.Id = 0;
            this.childRibbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.childRibbon.ExpandCollapseItem,
            this.bsView,
            this.biPrint,
            this.barButtonItem2,
            this.albumSubItem,
            this.biView,
            this.biExportFolder,
            this.biEmail,
            this.biUpload,
            this.biRemoveFilesFromLibrary,
            this.biAddToAlbum,
            this.biMark,
            this.biUnmark,
            this.biUnmarkAll,
            this.biCollage,
            this.biSlideShow,
            this.biFilm,
            this.biSaveImage,
            this.biCancel,
            this.biClose,
            this.filtersGallery,
            this.biFilterByMarked,
            this.biRemoveFromAlbum,
            this.biSelectAllMarked,
            this.beZoom,
            this.barButtonGroup1,
            this.barButtonGroup2,
            this.barButtonGroup3,
            this.barButtonGroup4});
            this.childRibbon.Location = new System.Drawing.Point(0, 0);
            this.childRibbon.MaxItemId = 27;
            this.childRibbon.Name = "childRibbon";
            this.childRibbon.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.viewPageCategory});
            this.childRibbon.PageCategoryAlignment = DevExpress.XtraBars.Ribbon.RibbonPageCategoryAlignment.Right;
            this.childRibbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.imagePage});
            this.childRibbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemZoomTrackBar1});
            this.childRibbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.childRibbon.Size = new System.Drawing.Size(1112, 144);
            this.childRibbon.StatusBar = this.ribbonStatusBar1;
            this.childRibbon.TransparentEditors = true;
            // 
            // biExportFolder
            // 
            this.biExportFolder.Caption = "Export";
            this.biExportFolder.Glyph = global::PhotoViewer.Properties.Resources.Export_16x16;
            this.biExportFolder.Hint = "Export folders content to hard drive";
            this.biExportFolder.Id = 2;
            this.biExportFolder.LargeGlyph = global::PhotoViewer.Properties.Resources.Export_32x32;
            this.biExportFolder.Name = "biExportFolder";
            this.biExportFolder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnExportItemClick);
            // 
            // biEmail
            // 
            this.biEmail.Caption = "E-mail";
            this.biEmail.Glyph = global::PhotoViewer.Properties.Resources.EMail_16x16;
            this.biEmail.Hint = "Send selected images via e-mail";
            this.biEmail.Id = 3;
            this.biEmail.LargeGlyph = global::PhotoViewer.Properties.Resources.EMail_32x32;
            this.biEmail.Name = "biEmail";
            this.biEmail.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnEmailItemClick);
            // 
            // biUpload
            // 
            this.biUpload.Caption = "Upload";
            this.biUpload.Glyph = global::PhotoViewer.Properties.Resources.Upload_16x16;
            this.biUpload.Hint = "Upload selected images to your web album";
            this.biUpload.Id = 4;
            this.biUpload.LargeGlyph = global::PhotoViewer.Properties.Resources.Upload_32x32;
            this.biUpload.Name = "biUpload";
            this.biUpload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnUploadItemClick);
            // 
            // biRemoveFilesFromLibrary
            // 
            this.biRemoveFilesFromLibrary.Caption = "Remove";
            this.biRemoveFilesFromLibrary.Glyph = global::PhotoViewer.Properties.Resources.Remove_16x16;
            this.biRemoveFilesFromLibrary.Id = 6;
            this.biRemoveFilesFromLibrary.LargeGlyph = global::PhotoViewer.Properties.Resources.Remove_32x32;
            this.biRemoveFilesFromLibrary.Name = "biRemoveFilesFromLibrary";
            // 
            // biAddToAlbum
            // 
            this.biAddToAlbum.ActAsDropDown = true;
            this.biAddToAlbum.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.biAddToAlbum.Caption = "Add to album";
            this.biAddToAlbum.DropDownControl = this.albumsPopupMenu;
            this.biAddToAlbum.Glyph = global::PhotoViewer.Properties.Resources.AddToAlbum_16x16;
            this.biAddToAlbum.Hint = "Add selected images to album";
            this.biAddToAlbum.Id = 7;
            this.biAddToAlbum.LargeGlyph = global::PhotoViewer.Properties.Resources.AddToAlbum_32x32;
            this.biAddToAlbum.Name = "biAddToAlbum";
            this.biAddToAlbum.ItemPress += new DevExpress.XtraBars.ItemClickEventHandler(this.OnAddToAlbumItemPress);
            // 
            // albumsPopupMenu
            // 
            this.albumsPopupMenu.Name = "albumsPopupMenu";
            this.albumsPopupMenu.Ribbon = this.childRibbon;
            // 
            // biMark
            // 
            this.biMark.Caption = "Mark";
            this.biMark.Glyph = global::PhotoViewer.Properties.Resources.Mark_16x16;
            this.biMark.Id = 8;
            this.biMark.LargeGlyph = global::PhotoViewer.Properties.Resources.Mark_32x32;
            this.biMark.Name = "biMark";
            this.biMark.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnMarkItemClick);
            // 
            // biUnmark
            // 
            this.biUnmark.Caption = "Unmark";
            this.biUnmark.Glyph = global::PhotoViewer.Properties.Resources.Unmark_16x16;
            this.biUnmark.Id = 9;
            this.biUnmark.LargeGlyph = global::PhotoViewer.Properties.Resources.Unmark_32x32;
            this.biUnmark.Name = "biUnmark";
            this.biUnmark.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnUnmarkItemClick);
            // 
            // biUnmarkAll
            // 
            this.biUnmarkAll.Caption = "Unmark All";
            this.biUnmarkAll.Glyph = global::PhotoViewer.Properties.Resources.UnmarkAll_16x16;
            this.biUnmarkAll.Id = 10;
            this.biUnmarkAll.LargeGlyph = global::PhotoViewer.Properties.Resources.UnmarkAll_32x32;
            this.biUnmarkAll.Name = "biUnmarkAll";
            this.biUnmarkAll.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnUnmarkAllItemClick);
            // 
            // biCollage
            // 
            this.biCollage.Caption = "Collage";
            this.biCollage.Glyph = global::PhotoViewer.Properties.Resources.Collage_16x16;
            this.biCollage.Hint = "Make collage from using selected images";
            this.biCollage.Id = 11;
            this.biCollage.LargeGlyph = global::PhotoViewer.Properties.Resources.Collage_32x32;
            this.biCollage.Name = "biCollage";
            this.biCollage.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnCollageItemClick);
            // 
            // biSlideShow
            // 
            this.biSlideShow.Caption = "Slide Show";
            this.biSlideShow.Glyph = global::PhotoViewer.Properties.Resources.Slideshow_16x16;
            this.biSlideShow.Hint = "Make slide show using selected images";
            this.biSlideShow.Id = 12;
            this.biSlideShow.LargeGlyph = global::PhotoViewer.Properties.Resources.Slideshow_32x32;
            this.biSlideShow.Name = "biSlideShow";
            this.biSlideShow.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnSlideShowItemClick);
            // 
            // biFilm
            // 
            this.biFilm.Caption = "Film";
            this.biFilm.Glyph = global::PhotoViewer.Properties.Resources.Film_16x16;
            this.biFilm.Hint = "Make film using selected images";
            this.biFilm.Id = 13;
            this.biFilm.LargeGlyph = global::PhotoViewer.Properties.Resources.Film_32x32;
            this.biFilm.Name = "biFilm";
            this.biFilm.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnFilmItemClick);
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
            // biCancel
            // 
            this.biCancel.Caption = "Cancel";
            this.biCancel.Glyph = global::PhotoViewer.Properties.Resources.Cancel_16x16;
            this.biCancel.Id = 15;
            this.biCancel.LargeGlyph = global::PhotoViewer.Properties.Resources.Cancel_32x32;
            this.biCancel.Name = "biCancel";
            this.biCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnCancelFilterItemClick);
            // 
            // biClose
            // 
            this.biClose.Caption = "Close";
            this.biClose.Glyph = global::PhotoViewer.Properties.Resources.Close_16x16;
            this.biClose.Id = 16;
            this.biClose.LargeGlyph = global::PhotoViewer.Properties.Resources.Close_32x32;
            this.biClose.Name = "biClose";
            this.biClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnCloseImageItemClick);
            // 
            // filtersGallery
            // 
            // 
            // 
            // 
            this.filtersGallery.Gallery.AllowHoverImages = true;
            galleryItemGroup1.Caption = "Group4";
            this.filtersGallery.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1});
            this.filtersGallery.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleRadio;
            this.filtersGallery.Gallery.InitDropDownGallery += new DevExpress.XtraBars.Ribbon.InplaceGalleryEventHandler(this.OnFiltersGalleryInitDropDown);
            this.filtersGallery.Gallery.PopupClose += new DevExpress.XtraBars.Ribbon.InplaceGalleryEventHandler(this.filtersGallery_Gallery_PopupClose);
            this.filtersGallery.Id = 17;
            this.filtersGallery.Name = "filtersGallery";
            this.filtersGallery.GalleryItemCheckedChanged += new DevExpress.XtraBars.Ribbon.GalleryItemEventHandler(this.OnFilterGalleryItemCheckedChanged);
            // 
            // biFilterByMarked
            // 
            this.biFilterByMarked.Caption = "Filter by Marked";
            this.biFilterByMarked.Glyph = global::PhotoViewer.Properties.Resources.Filter_16x16;
            this.biFilterByMarked.Id = 18;
            this.biFilterByMarked.LargeGlyph = global::PhotoViewer.Properties.Resources.Filter_32x32;
            this.biFilterByMarked.Name = "biFilterByMarked";
            this.biFilterByMarked.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnFilterByMarkedCheckedChanged);
            // 
            // biRemoveFromAlbum
            // 
            this.biRemoveFromAlbum.Caption = "Remove from album";
            this.biRemoveFromAlbum.Glyph = global::PhotoViewer.Properties.Resources.RemoveFromAlbum_16x16;
            this.biRemoveFromAlbum.Id = 20;
            this.biRemoveFromAlbum.LargeGlyph = global::PhotoViewer.Properties.Resources.RemoveFromAlbum_32x32;
            this.biRemoveFromAlbum.Name = "biRemoveFromAlbum";
            this.biRemoveFromAlbum.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnRemoveFromAlbumItemClick);
            // 
            // biSelectAllMarked
            // 
            this.biSelectAllMarked.Caption = "Select All Marked";
            this.biSelectAllMarked.Glyph = global::PhotoViewer.Properties.Resources.SelectAllMarked_16x16;
            this.biSelectAllMarked.Id = 21;
            this.biSelectAllMarked.LargeGlyph = global::PhotoViewer.Properties.Resources.SelectAllMarked_32x32;
            this.biSelectAllMarked.Name = "biSelectAllMarked";
            this.biSelectAllMarked.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnSelectAllMarkedItemClick);
            // 
            // beZoom
            // 
            this.beZoom.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.beZoom.Edit = this.repositoryItemZoomTrackBar1;
            this.beZoom.EditValue = 128;
            this.beZoom.Id = 22;
            this.beZoom.Name = "beZoom";
            this.beZoom.Width = 200;
            // 
            // repositoryItemZoomTrackBar1
            // 
            this.repositoryItemZoomTrackBar1.Alignment = DevExpress.Utils.VertAlignment.Center;
            this.repositoryItemZoomTrackBar1.AllowFocused = false;
            this.repositoryItemZoomTrackBar1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemZoomTrackBar1.Maximum = 208;
            this.repositoryItemZoomTrackBar1.Middle = 5;
            this.repositoryItemZoomTrackBar1.Minimum = 48;
            this.repositoryItemZoomTrackBar1.Name = "repositoryItemZoomTrackBar1";
            this.repositoryItemZoomTrackBar1.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight;
            this.repositoryItemZoomTrackBar1.ValueChanged += new System.EventHandler(this.repositoryItemZoomTrackBar1_ValueChanged);
            // 
            // barButtonGroup1
            // 
            this.barButtonGroup1.Caption = "barButtonGroup1";
            this.barButtonGroup1.Id = 23;
            this.barButtonGroup1.ItemLinks.Add(this.biView);
            this.barButtonGroup1.ItemLinks.Add(this.biRemoveFilesFromLibrary);
            this.barButtonGroup1.Name = "barButtonGroup1";
            // 
            // barButtonGroup2
            // 
            this.barButtonGroup2.Caption = "barButtonGroup2";
            this.barButtonGroup2.Id = 24;
            this.barButtonGroup2.ItemLinks.Add(this.biAddToAlbum);
            this.barButtonGroup2.ItemLinks.Add(this.biRemoveFromAlbum);
            this.barButtonGroup2.Name = "barButtonGroup2";
            // 
            // barButtonGroup3
            // 
            this.barButtonGroup3.Caption = "barButtonGroup3";
            this.barButtonGroup3.Id = 25;
            this.barButtonGroup3.ItemLinks.Add(this.biMark);
            this.barButtonGroup3.ItemLinks.Add(this.biUnmark);
            this.barButtonGroup3.ItemLinks.Add(this.biUnmarkAll);
            this.barButtonGroup3.Name = "barButtonGroup3";
            // 
            // barButtonGroup4
            // 
            this.barButtonGroup4.Caption = "barButtonGroup4";
            this.barButtonGroup4.Id = 26;
            this.barButtonGroup4.ItemLinks.Add(this.biCollage);
            this.barButtonGroup4.ItemLinks.Add(this.biSlideShow);
            this.barButtonGroup4.ItemLinks.Add(this.biFilm);
            this.barButtonGroup4.Name = "barButtonGroup4";
            // 
            // viewPageCategory
            // 
            this.viewPageCategory.Name = "viewPageCategory";
            this.viewPageCategory.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.collectionOriginalPage});
            this.viewPageCategory.Text = "View";
            this.viewPageCategory.Visible = false;
            // 
            // collectionOriginalPage
            // 
            this.collectionOriginalPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.filtersFilePageGroup,
            this.filtersPageGroup});
            this.collectionOriginalPage.Name = "collectionOriginalPage";
            this.collectionOriginalPage.Text = "Collection";
            this.collectionOriginalPage.Visible = false;
            // 
            // filtersFilePageGroup
            // 
            this.filtersFilePageGroup.ItemLinks.Add(this.biSaveImage);
            this.filtersFilePageGroup.ItemLinks.Add(this.biCancel);
            this.filtersFilePageGroup.ItemLinks.Add(this.biClose, true);
            this.filtersFilePageGroup.Name = "filtersFilePageGroup";
            this.filtersFilePageGroup.Text = "File";
            // 
            // filtersPageGroup
            // 
            this.filtersPageGroup.ItemLinks.Add(this.filtersGallery);
            this.filtersPageGroup.Name = "filtersPageGroup";
            this.filtersPageGroup.Text = "Filters";
            // 
            // imagePage
            // 
            this.imagePage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.imageGeneralPageGroup,
            this.imageMarkingPageGroup,
            this.makePageGroup,
            this.outputPageGroup});
            this.imagePage.Name = "imagePage";
            this.imagePage.Text = "Image";
            // 
            // imageGeneralPageGroup
            // 
            this.imageGeneralPageGroup.ItemLinks.Add(this.biView, true);
            this.imageGeneralPageGroup.ItemLinks.Add(this.biRemoveFilesFromLibrary);
            this.imageGeneralPageGroup.ItemLinks.Add(this.biAddToAlbum, true);
            this.imageGeneralPageGroup.ItemLinks.Add(this.biRemoveFromAlbum);
            this.imageGeneralPageGroup.Name = "imageGeneralPageGroup";
            this.imageGeneralPageGroup.ShowCaptionButton = false;
            this.imageGeneralPageGroup.Text = "General";
            // 
            // imageMarkingPageGroup
            // 
            this.imageMarkingPageGroup.ItemLinks.Add(this.biMark);
            this.imageMarkingPageGroup.ItemLinks.Add(this.biUnmark);
            this.imageMarkingPageGroup.ItemLinks.Add(this.biUnmarkAll);
            this.imageMarkingPageGroup.ItemLinks.Add(this.biFilterByMarked, true);
            this.imageMarkingPageGroup.ItemLinks.Add(this.biSelectAllMarked);
            this.imageMarkingPageGroup.Name = "imageMarkingPageGroup";
            this.imageMarkingPageGroup.ShowCaptionButton = false;
            this.imageMarkingPageGroup.Text = "Marking";
            // 
            // makePageGroup
            // 
            this.makePageGroup.ItemLinks.Add(this.biCollage);
            this.makePageGroup.ItemLinks.Add(this.biSlideShow);
            this.makePageGroup.ItemLinks.Add(this.biFilm);
            this.makePageGroup.Name = "makePageGroup";
            this.makePageGroup.ShowCaptionButton = false;
            this.makePageGroup.Text = "Make";
            // 
            // outputPageGroup
            // 
            this.outputPageGroup.ItemLinks.Add(this.biExportFolder);
            this.outputPageGroup.ItemLinks.Add(this.biEmail);
            this.outputPageGroup.ItemLinks.Add(this.biUpload);
            this.outputPageGroup.ItemLinks.Add(this.biPrint, true);
            this.outputPageGroup.Name = "outputPageGroup";
            this.outputPageGroup.ShowCaptionButton = false;
            this.outputPageGroup.Text = "Output";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.beZoom);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 738);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.childRibbon;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1112, 31);
            // 
            // addToLibraryMenu
            // 
            this.addToLibraryMenu.Name = "addToLibraryMenu";
            this.addToLibraryMenu.Ribbon = this.childRibbon;
            // 
            // gallery
            // 
            this.gallery.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gallery.Controls.Add(this.galleryControlClient1);
            this.gallery.DesignGalleryGroupIndex = 0;
            this.gallery.DesignGalleryItemIndex = 0;
            this.gallery.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // galleryControlGallery1
            // 
            this.gallery.Gallery.AllowMarqueeSelection = true;
            this.gallery.Gallery.ClearSelectionOnClickEmptySpace = true;
            this.gallery.Gallery.ImageSize = new System.Drawing.Size(128, 128);
            this.gallery.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.Multiple;
            this.gallery.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.ZoomInside;
            this.gallery.Gallery.ScrollMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryScrollMode.Smooth;
            this.gallery.Gallery.ScrollSpeed = 0.75F;
            this.gallery.Gallery.ItemDoubleClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.OnMainGalleryDoubleClick);
            this.gallery.Gallery.ItemCheckedChanged += new DevExpress.XtraBars.Ribbon.GalleryItemEventHandler(this.OnMainGalleryItemCheckedChanged);
            this.gallery.Gallery.CustomDrawItemImage += new DevExpress.XtraBars.Ribbon.GalleryItemCustomDrawEventHandler(this.OnMainGalleryCustomDrawItemImage);
            this.gallery.Gallery.MarqueeSelectionCompleted += new DevExpress.XtraBars.Ribbon.GallerySelectionEventHandler(this.galleryControlGallery1_MarqueeSelectionCompleted);
            this.gallery.Location = new System.Drawing.Point(0, 0);
            this.gallery.Margin = new System.Windows.Forms.Padding(0);
            this.gallery.Name = "gallery";
            this.gallery.Size = new System.Drawing.Size(1112, 594);
            this.gallery.TabIndex = 0;
            this.gallery.Text = "galleryControl1";
            this.gallery.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMainGalleryMouseDown);
            // 
            // galleryControlClient1
            // 
            this.defaultToolTipController1.SetAllowHtmlText(this.galleryControlClient1, DevExpress.Utils.DefaultBoolean.Default);
            this.galleryControlClient1.GalleryControl = this.gallery;
            this.galleryControlClient1.Location = new System.Drawing.Point(1, 1);
            this.galleryControlClient1.Size = new System.Drawing.Size(1093, 592);
            // 
            // defaultToolTipController1
            // 
            // 
            // 
            // 
            this.defaultToolTipController1.DefaultController.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip;
            // 
            // printPreviewDialog1
            // 
            this.defaultToolTipController1.SetAllowHtmlText(this.printPreviewDialog1, DevExpress.Utils.DefaultBoolean.Default);
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.UseAntiAlias = true;
            this.printPreviewDialog1.Visible = false;
            // 
            // libraryPanel
            // 
            this.defaultToolTipController1.SetAllowHtmlText(this.libraryPanel, DevExpress.Utils.DefaultBoolean.Default);
            this.libraryPanel.Controls.Add(this.galleryContentPanel);
            this.libraryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.libraryPanel.Location = new System.Drawing.Point(0, 0);
            this.libraryPanel.Margin = new System.Windows.Forms.Padding(0);
            this.libraryPanel.Name = "libraryPanel";
            this.libraryPanel.Size = new System.Drawing.Size(1112, 594);
            this.libraryPanel.TabIndex = 1;
            // 
            // galleryContentPanel
            // 
            this.defaultToolTipController1.SetAllowHtmlText(this.galleryContentPanel, DevExpress.Utils.DefaultBoolean.Default);
            this.galleryContentPanel.Controls.Add(this.galleryPanel);
            this.galleryContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.galleryContentPanel.Location = new System.Drawing.Point(0, 0);
            this.galleryContentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.galleryContentPanel.Name = "galleryContentPanel";
            this.galleryContentPanel.Size = new System.Drawing.Size(1112, 594);
            this.galleryContentPanel.TabIndex = 2;
            // 
            // galleryPanel
            // 
            this.defaultToolTipController1.SetAllowHtmlText(this.galleryPanel, DevExpress.Utils.DefaultBoolean.Default);
            this.galleryPanel.Controls.Add(this.gallery);
            this.galleryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.galleryPanel.Location = new System.Drawing.Point(0, 0);
            this.galleryPanel.Margin = new System.Windows.Forms.Padding(0);
            this.galleryPanel.Name = "galleryPanel";
            this.galleryPanel.Size = new System.Drawing.Size(1112, 594);
            this.galleryPanel.TabIndex = 1;
            // 
            // dockPanel1_Container
            // 
            this.defaultToolTipController1.SetAllowHtmlText(this.dockPanel1_Container, DevExpress.Utils.DefaultBoolean.Default);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 25);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(238, 401);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // controlPresenter
            // 
            this.defaultToolTipController1.SetAllowHtmlText(this.controlPresenter, DevExpress.Utils.DefaultBoolean.Default);
            this.controlPresenter.Controls.Add(this.libraryPanel);
            this.controlPresenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPresenter.Location = new System.Drawing.Point(0, 144);
            this.controlPresenter.Name = "controlPresenter";
            this.controlPresenter.SelectedControl = this.libraryPanel;
            this.controlPresenter.SelectedControlIndex = 0;
            this.controlPresenter.Size = new System.Drawing.Size(1112, 594);
            this.controlPresenter.TabIndex = 10;
            this.controlPresenter.SelectedControlChanged += new System.EventHandler(this.OnMainTabSelectedPageChanged);
            // 
            // galleryItemMenu
            // 
            this.galleryItemMenu.Name = "galleryItemMenu";
            this.galleryItemMenu.Ribbon = this.childRibbon;
            // 
            // imageDialog
            // 
            this.imageDialog.Filter = "Image files (BMP,JPG,PNG,GIF) |*.bmp;*.jpg;*.png;*.gif| All files|*.*";
            this.imageDialog.Multiselect = true;
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
            // GalleryForm
            // 
            this.defaultToolTipController1.SetAllowHtmlText(this, DevExpress.Utils.DefaultBoolean.Default);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 769);
            this.Controls.Add(this.controlPresenter);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.childRibbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GalleryForm";
            this.Ribbon = this.childRibbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "PhotoViewer";
            ((System.ComponentModel.ISupportInitialize)(this.childRibbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsPopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemZoomTrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addToLibraryMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gallery)).EndInit();
            this.gallery.ResumeLayout(false);
            this.libraryPanel.ResumeLayout(false);
            this.galleryContentPanel.ResumeLayout(false);
            this.galleryPanel.ResumeLayout(false);
            this.controlPresenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.galleryItemMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarSubItem bsView;
        protected internal DevExpress.XtraBars.Ribbon.GalleryControl gallery;
        private DevExpress.XtraBars.BarButtonItem biPrint;
        private DevExpress.Utils.DefaultToolTipController defaultToolTipController1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.Utils.Controls.ControlPresenter controlPresenter;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private DevExpress.XtraBars.PopupMenu galleryItemMenu;
        private DevExpress.XtraBars.BarSubItem albumSubItem;
        private DevExpress.XtraBars.BarButtonItem biView;
        private DevExpress.XtraBars.Ribbon.RibbonControl childRibbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage imagePage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup imageGeneralPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup imageMarkingPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup makePageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup outputPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory viewPageCategory;
        private DevExpress.XtraBars.Ribbon.RibbonPage collectionOriginalPage;
        private DevExpress.XtraBars.BarButtonItem biExportFolder;
        private DevExpress.XtraBars.BarButtonItem biEmail;
        private DevExpress.XtraBars.BarButtonItem biUpload;
        private DevExpress.XtraBars.PopupMenu addToLibraryMenu;
        private DevExpress.XtraBars.BarButtonItem biRemoveFilesFromLibrary;
        private DevExpress.XtraBars.BarButtonItem biAddToAlbum;
        private DevExpress.XtraBars.BarButtonItem biMark;
        private DevExpress.XtraBars.BarButtonItem biUnmark;
        private DevExpress.XtraBars.BarButtonItem biUnmarkAll;
        private DevExpress.XtraBars.BarButtonItem biCollage;
        private DevExpress.XtraBars.BarButtonItem biSlideShow;
        private DevExpress.XtraBars.BarButtonItem biFilm;
        private System.Windows.Forms.UserControl libraryPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup filtersFilePageGroup;
        private DevExpress.XtraBars.BarButtonItem biSaveImage;
        private DevExpress.XtraBars.BarButtonItem biCancel;
        private DevExpress.XtraBars.BarButtonItem biClose;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup filtersPageGroup;
        private DevExpress.XtraBars.RibbonGalleryBarItem filtersGallery;
        private DevExpress.XtraBars.BarCheckItem biFilterByMarked;
        private DevExpress.XtraBars.BarButtonItem biRemoveFromAlbum;
        private System.Windows.Forms.OpenFileDialog imageDialog;
        private DevExpress.XtraBars.BarButtonItem biSelectAllMarked;
        private DevExpress.XtraBars.BarEditItem beZoom;
        private DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar repositoryItemZoomTrackBar1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private System.Windows.Forms.Panel galleryContentPanel;
        private System.Windows.Forms.Panel galleryPanel;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup2;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup3;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup4;
        private DevExpress.XtraBars.PopupMenu albumsPopupMenu;
        private DevExpress.XtraBars.Ribbon.RibbonMiniToolbar ribbonMiniToolbar1;
    }
}


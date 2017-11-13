Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraTab
Namespace PhotoViewer
	Partial Public Class GalleryForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Dim GalleryItemGroup1 As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GalleryForm))
            Me.biPrint = New DevExpress.XtraBars.BarButtonItem()
            Me.albumSubItem = New DevExpress.XtraBars.BarSubItem()
            Me.bsView = New DevExpress.XtraBars.BarSubItem()
            Me.biView = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
            Me.childRibbon = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.biExportFolder = New DevExpress.XtraBars.BarButtonItem()
            Me.biEmail = New DevExpress.XtraBars.BarButtonItem()
            Me.biUpload = New DevExpress.XtraBars.BarButtonItem()
            Me.biRemoveFilesFromLibrary = New DevExpress.XtraBars.BarButtonItem()
            Me.biAddToAlbum = New DevExpress.XtraBars.BarButtonItem()
            Me.albumsPopupMenu = New DevExpress.XtraBars.PopupMenu()
            Me.biMark = New DevExpress.XtraBars.BarButtonItem()
            Me.biUnmark = New DevExpress.XtraBars.BarButtonItem()
            Me.biUnmarkAll = New DevExpress.XtraBars.BarButtonItem()
            Me.biCollage = New DevExpress.XtraBars.BarButtonItem()
            Me.biSlideShow = New DevExpress.XtraBars.BarButtonItem()
            Me.biFilm = New DevExpress.XtraBars.BarButtonItem()
            Me.biSaveImage = New DevExpress.XtraBars.BarButtonItem()
            Me.biCancel = New DevExpress.XtraBars.BarButtonItem()
            Me.biClose = New DevExpress.XtraBars.BarButtonItem()
            Me.filtersGallery = New DevExpress.XtraBars.RibbonGalleryBarItem()
            Me.biFilterByMarked = New DevExpress.XtraBars.BarCheckItem()
            Me.biRemoveFromAlbum = New DevExpress.XtraBars.BarButtonItem()
            Me.biSelectAllMarked = New DevExpress.XtraBars.BarButtonItem()
            Me.beZoom = New DevExpress.XtraBars.BarEditItem()
            Me.repositoryItemZoomTrackBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar()
            Me.barButtonGroup1 = New DevExpress.XtraBars.BarButtonGroup()
            Me.barButtonGroup2 = New DevExpress.XtraBars.BarButtonGroup()
            Me.barButtonGroup3 = New DevExpress.XtraBars.BarButtonGroup()
            Me.barButtonGroup4 = New DevExpress.XtraBars.BarButtonGroup()
            Me.viewPageCategory = New DevExpress.XtraBars.Ribbon.RibbonPageCategory()
            Me.collectionOriginalPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.filtersFilePageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.filtersPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.imagePage = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.imageGeneralPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.imageMarkingPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.makePageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.outputPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
            Me.addToLibraryMenu = New DevExpress.XtraBars.PopupMenu()
            Me.gallery = New DevExpress.XtraBars.Ribbon.GalleryControl()
            Me.galleryControlClient1 = New DevExpress.XtraBars.Ribbon.GalleryControlClient()
            Me.defaultToolTipController1 = New DevExpress.Utils.DefaultToolTipController()
            Me.printPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
            Me.libraryPanel = New System.Windows.Forms.UserControl()
            Me.galleryContentPanel = New System.Windows.Forms.Panel()
            Me.galleryPanel = New System.Windows.Forms.Panel()
            Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.controlPresenter = New DevExpress.Utils.Controls.ControlPresenter()
            Me.folderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
            Me.galleryItemMenu = New DevExpress.XtraBars.PopupMenu()
            Me.imageDialog = New System.Windows.Forms.OpenFileDialog()
            Me.ribbonMiniToolbar1 = New DevExpress.XtraBars.Ribbon.RibbonMiniToolbar()
            CType(Me.childRibbon, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.albumsPopupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemZoomTrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.addToLibraryMenu, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gallery, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gallery.SuspendLayout()
            Me.libraryPanel.SuspendLayout()
            Me.galleryContentPanel.SuspendLayout()
            Me.galleryPanel.SuspendLayout()
            Me.controlPresenter.SuspendLayout()
            CType(Me.galleryItemMenu, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'biPrint
            '
            Me.biPrint.Caption = "Print"
            Me.biPrint.Glyph = Global.My.Resources.Resources.Print_16x16
            Me.biPrint.Hint = "Print selected images"
            Me.biPrint.Id = 11
            Me.biPrint.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P))
            Me.biPrint.LargeGlyph = Global.My.Resources.Resources.Print_32x32
            Me.biPrint.Name = "biPrint"
            '
            'albumSubItem
            '
            Me.albumSubItem.Caption = "&Album"
            Me.albumSubItem.Id = 18
            Me.albumSubItem.Name = "albumSubItem"
            '
            'bsView
            '
            Me.bsView.Caption = "&View"
            Me.bsView.Id = 2
            Me.bsView.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.biView)})
            Me.bsView.Name = "bsView"
            '
            'biView
            '
            Me.biView.Caption = "View"
            Me.biView.Glyph = Global.My.Resources.Resources.View_16x16
            Me.biView.Hint = "View selected images"
            Me.biView.Id = 19
            Me.biView.LargeGlyph = Global.My.Resources.Resources.View_32x32
            Me.biView.Name = "biView"
            '
            'barButtonItem2
            '
            Me.barButtonItem2.Caption = "Delete Folder"
            Me.barButtonItem2.Id = 13
            Me.barButtonItem2.Name = "barButtonItem2"
            '
            'childRibbon
            '
            Me.childRibbon.ApplicationButtonText = Nothing
            Me.childRibbon.ExpandCollapseItem.Id = 0
            Me.childRibbon.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.childRibbon.ExpandCollapseItem, Me.bsView, Me.biPrint, Me.barButtonItem2, Me.albumSubItem, Me.biView, Me.biExportFolder, Me.biEmail, Me.biUpload, Me.biRemoveFilesFromLibrary, Me.biAddToAlbum, Me.biMark, Me.biUnmark, Me.biUnmarkAll, Me.biCollage, Me.biSlideShow, Me.biFilm, Me.biSaveImage, Me.biCancel, Me.biClose, Me.filtersGallery, Me.biFilterByMarked, Me.biRemoveFromAlbum, Me.biSelectAllMarked, Me.beZoom, Me.barButtonGroup1, Me.barButtonGroup2, Me.barButtonGroup3, Me.barButtonGroup4})
            Me.childRibbon.Location = New System.Drawing.Point(0, 0)
            Me.childRibbon.MaxItemId = 27
            Me.childRibbon.Name = "childRibbon"
            Me.childRibbon.PageCategories.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageCategory() {Me.viewPageCategory})
            Me.childRibbon.PageCategoryAlignment = DevExpress.XtraBars.Ribbon.RibbonPageCategoryAlignment.Right
            Me.childRibbon.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.imagePage})
            Me.childRibbon.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemZoomTrackBar1})
            Me.childRibbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
            Me.childRibbon.Size = New System.Drawing.Size(1112, 144)
            Me.childRibbon.StatusBar = Me.ribbonStatusBar1
            Me.childRibbon.TransparentEditors = True
            '
            'biExportFolder
            '
            Me.biExportFolder.Caption = "Export"
            Me.biExportFolder.Glyph = Global.My.Resources.Resources.Export_16x16
            Me.biExportFolder.Hint = "Export folders content to hard drive"
            Me.biExportFolder.Id = 2
            Me.biExportFolder.LargeGlyph = Global.My.Resources.Resources.Export_32x32
            Me.biExportFolder.Name = "biExportFolder"
            '
            'biEmail
            '
            Me.biEmail.Caption = "E-mail"
            Me.biEmail.Glyph = Global.My.Resources.Resources.EMail_16x16
            Me.biEmail.Hint = "Send selected images via e-mail"
            Me.biEmail.Id = 3
            Me.biEmail.LargeGlyph = Global.My.Resources.Resources.EMail_32x32
            Me.biEmail.Name = "biEmail"
            '
            'biUpload
            '
            Me.biUpload.Caption = "Upload"
            Me.biUpload.Glyph = Global.My.Resources.Resources.Upload_16x16
            Me.biUpload.Hint = "Upload selected images to your web album"
            Me.biUpload.Id = 4
            Me.biUpload.LargeGlyph = Global.My.Resources.Resources.Upload_32x32
            Me.biUpload.Name = "biUpload"
            '
            'biRemoveFilesFromLibrary
            '
            Me.biRemoveFilesFromLibrary.Caption = "Remove"
            Me.biRemoveFilesFromLibrary.Glyph = Global.My.Resources.Resources.Remove_16x16
            Me.biRemoveFilesFromLibrary.Id = 6
            Me.biRemoveFilesFromLibrary.LargeGlyph = Global.My.Resources.Resources.Remove_32x32
            Me.biRemoveFilesFromLibrary.Name = "biRemoveFilesFromLibrary"
            '
            'biAddToAlbum
            '
            Me.biAddToAlbum.ActAsDropDown = True
            Me.biAddToAlbum.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.biAddToAlbum.Caption = "Add to album"
            Me.biAddToAlbum.DropDownControl = Me.albumsPopupMenu
            Me.biAddToAlbum.Glyph = Global.My.Resources.Resources.AddToAlbum_16x16
            Me.biAddToAlbum.Hint = "Add selected images to album"
            Me.biAddToAlbum.Id = 7
            Me.biAddToAlbum.LargeGlyph = Global.My.Resources.Resources.AddToAlbum_32x32
            Me.biAddToAlbum.Name = "biAddToAlbum"
            '
            'albumsPopupMenu
            '
            Me.albumsPopupMenu.Name = "albumsPopupMenu"
            Me.albumsPopupMenu.Ribbon = Me.childRibbon
            '
            'biMark
            '
            Me.biMark.Caption = "Mark"
            Me.biMark.Glyph = Global.My.Resources.Resources.Mark_16x16
            Me.biMark.Id = 8
            Me.biMark.LargeGlyph = Global.My.Resources.Resources.Mark_32x32
            Me.biMark.Name = "biMark"
            '
            'biUnmark
            '
            Me.biUnmark.Caption = "Unmark"
            Me.biUnmark.Glyph = Global.My.Resources.Resources.Unmark_16x16
            Me.biUnmark.Id = 9
            Me.biUnmark.LargeGlyph = Global.My.Resources.Resources.Unmark_32x32
            Me.biUnmark.Name = "biUnmark"
            '
            'biUnmarkAll
            '
            Me.biUnmarkAll.Caption = "Unmark All"
            Me.biUnmarkAll.Glyph = Global.My.Resources.Resources.UnmarkAll_16x16
            Me.biUnmarkAll.Id = 10
            Me.biUnmarkAll.LargeGlyph = Global.My.Resources.Resources.UnmarkAll_32x32
            Me.biUnmarkAll.Name = "biUnmarkAll"
            '
            'biCollage
            '
            Me.biCollage.Caption = "Collage"
            Me.biCollage.Glyph = Global.My.Resources.Resources.Collage_16x16
            Me.biCollage.Hint = "Make collage from using selected images"
            Me.biCollage.Id = 11
            Me.biCollage.LargeGlyph = Global.My.Resources.Resources.Collage_32x32
            Me.biCollage.Name = "biCollage"
            '
            'biSlideShow
            '
            Me.biSlideShow.Caption = "Slide Show"
            Me.biSlideShow.Glyph = Global.My.Resources.Resources.Slideshow_16x16
            Me.biSlideShow.Hint = "Make slide show using selected images"
            Me.biSlideShow.Id = 12
            Me.biSlideShow.LargeGlyph = Global.My.Resources.Resources.Slideshow_32x32
            Me.biSlideShow.Name = "biSlideShow"
            '
            'biFilm
            '
            Me.biFilm.Caption = "Film"
            Me.biFilm.Glyph = Global.My.Resources.Resources.Film_16x16
            Me.biFilm.Hint = "Make film using selected images"
            Me.biFilm.Id = 13
            Me.biFilm.LargeGlyph = Global.My.Resources.Resources.Film_32x32
            Me.biFilm.Name = "biFilm"
            '
            'biSaveImage
            '
            Me.biSaveImage.Caption = "Save"
            Me.biSaveImage.Glyph = Global.My.Resources.Resources.Save_16x16
            Me.biSaveImage.Id = 14
            Me.biSaveImage.LargeGlyph = Global.My.Resources.Resources.Save_32x32
            Me.biSaveImage.Name = "biSaveImage"
            '
            'biCancel
            '
            Me.biCancel.Caption = "Cancel"
            Me.biCancel.Glyph = Global.My.Resources.Resources.Cancel_16x16
            Me.biCancel.Id = 15
            Me.biCancel.LargeGlyph = Global.My.Resources.Resources.Cancel_32x32
            Me.biCancel.Name = "biCancel"
            '
            'biClose
            '
            Me.biClose.Caption = "Close"
            Me.biClose.Glyph = Global.My.Resources.Resources.Close_16x16
            Me.biClose.Id = 16
            Me.biClose.LargeGlyph = Global.My.Resources.Resources.Close_32x32
            Me.biClose.Name = "biClose"
            '
            'filtersGallery
            '
            '
            '
            '
            Me.filtersGallery.Gallery.AllowHoverImages = True
            GalleryItemGroup1.Caption = "Group4"
            Me.filtersGallery.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {GalleryItemGroup1})
            Me.filtersGallery.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleRadio
            Me.filtersGallery.Id = 17
            Me.filtersGallery.Name = "filtersGallery"
            '
            'biFilterByMarked
            '
            Me.biFilterByMarked.Caption = "Filter by Marked"
            Me.biFilterByMarked.Glyph = Global.My.Resources.Resources.Filter_16x16
            Me.biFilterByMarked.Id = 18
            Me.biFilterByMarked.LargeGlyph = Global.My.Resources.Resources.Filter_32x32
            Me.biFilterByMarked.Name = "biFilterByMarked"
            '
            'biRemoveFromAlbum
            '
            Me.biRemoveFromAlbum.Caption = "Remove from album"
            Me.biRemoveFromAlbum.Glyph = Global.My.Resources.Resources.RemoveFromAlbum_16x16
            Me.biRemoveFromAlbum.Id = 20
            Me.biRemoveFromAlbum.LargeGlyph = Global.My.Resources.Resources.RemoveFromAlbum_32x32
            Me.biRemoveFromAlbum.Name = "biRemoveFromAlbum"
            '
            'biSelectAllMarked
            '
            Me.biSelectAllMarked.Caption = "Select All Marked"
            Me.biSelectAllMarked.Glyph = Global.My.Resources.Resources.SelectAllMarked_16x16
            Me.biSelectAllMarked.Id = 21
            Me.biSelectAllMarked.LargeGlyph = Global.My.Resources.Resources.SelectAllMarked_32x32
            Me.biSelectAllMarked.Name = "biSelectAllMarked"
            '
            'beZoom
            '
            Me.beZoom.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
            Me.beZoom.Edit = Me.repositoryItemZoomTrackBar1
            Me.beZoom.EditValue = 128
            Me.beZoom.Id = 22
            Me.beZoom.Name = "beZoom"
            Me.beZoom.Width = 200
            '
            'repositoryItemZoomTrackBar1
            '
            Me.repositoryItemZoomTrackBar1.Alignment = DevExpress.Utils.VertAlignment.Center
            Me.repositoryItemZoomTrackBar1.AllowFocused = False
            Me.repositoryItemZoomTrackBar1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.repositoryItemZoomTrackBar1.Maximum = 208
            Me.repositoryItemZoomTrackBar1.Middle = 5
            Me.repositoryItemZoomTrackBar1.Minimum = 48
            Me.repositoryItemZoomTrackBar1.Name = "repositoryItemZoomTrackBar1"
            Me.repositoryItemZoomTrackBar1.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight
            '
            'barButtonGroup1
            '
            Me.barButtonGroup1.Caption = "barButtonGroup1"
            Me.barButtonGroup1.Id = 23
            Me.barButtonGroup1.ItemLinks.Add(Me.biView)
            Me.barButtonGroup1.ItemLinks.Add(Me.biRemoveFilesFromLibrary)
            Me.barButtonGroup1.Name = "barButtonGroup1"
            '
            'barButtonGroup2
            '
            Me.barButtonGroup2.Caption = "barButtonGroup2"
            Me.barButtonGroup2.Id = 24
            Me.barButtonGroup2.ItemLinks.Add(Me.biAddToAlbum)
            Me.barButtonGroup2.ItemLinks.Add(Me.biRemoveFromAlbum)
            Me.barButtonGroup2.Name = "barButtonGroup2"
            '
            'barButtonGroup3
            '
            Me.barButtonGroup3.Caption = "barButtonGroup3"
            Me.barButtonGroup3.Id = 25
            Me.barButtonGroup3.ItemLinks.Add(Me.biMark)
            Me.barButtonGroup3.ItemLinks.Add(Me.biUnmark)
            Me.barButtonGroup3.ItemLinks.Add(Me.biUnmarkAll)
            Me.barButtonGroup3.Name = "barButtonGroup3"
            '
            'barButtonGroup4
            '
            Me.barButtonGroup4.Caption = "barButtonGroup4"
            Me.barButtonGroup4.Id = 26
            Me.barButtonGroup4.ItemLinks.Add(Me.biCollage)
            Me.barButtonGroup4.ItemLinks.Add(Me.biSlideShow)
            Me.barButtonGroup4.ItemLinks.Add(Me.biFilm)
            Me.barButtonGroup4.Name = "barButtonGroup4"
            '
            'viewPageCategory
            '
            Me.viewPageCategory.Name = "viewPageCategory"
            Me.viewPageCategory.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.collectionOriginalPage})
            Me.viewPageCategory.Text = "View"
            Me.viewPageCategory.Visible = False
            '
            'collectionOriginalPage
            '
            Me.collectionOriginalPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.filtersFilePageGroup, Me.filtersPageGroup})
            Me.collectionOriginalPage.Name = "collectionOriginalPage"
            Me.collectionOriginalPage.Text = "Collection"
            Me.collectionOriginalPage.Visible = False
            '
            'filtersFilePageGroup
            '
            Me.filtersFilePageGroup.ItemLinks.Add(Me.biSaveImage)
            Me.filtersFilePageGroup.ItemLinks.Add(Me.biCancel)
            Me.filtersFilePageGroup.ItemLinks.Add(Me.biClose, True)
            Me.filtersFilePageGroup.Name = "filtersFilePageGroup"
            Me.filtersFilePageGroup.Text = "File"
            '
            'filtersPageGroup
            '
            Me.filtersPageGroup.ItemLinks.Add(Me.filtersGallery)
            Me.filtersPageGroup.Name = "filtersPageGroup"
            Me.filtersPageGroup.Text = "Filters"
            '
            'imagePage
            '
            Me.imagePage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.imageGeneralPageGroup, Me.imageMarkingPageGroup, Me.makePageGroup, Me.outputPageGroup})
            Me.imagePage.Name = "imagePage"
            Me.imagePage.Text = "Image"
            '
            'imageGeneralPageGroup
            '
            Me.imageGeneralPageGroup.ItemLinks.Add(Me.biView, True)
            Me.imageGeneralPageGroup.ItemLinks.Add(Me.biRemoveFilesFromLibrary)
            Me.imageGeneralPageGroup.ItemLinks.Add(Me.biAddToAlbum, True)
            Me.imageGeneralPageGroup.ItemLinks.Add(Me.biRemoveFromAlbum)
            Me.imageGeneralPageGroup.Name = "imageGeneralPageGroup"
            Me.imageGeneralPageGroup.Text = "General"
            '
            'imageMarkingPageGroup
            '
            Me.imageMarkingPageGroup.ItemLinks.Add(Me.biMark)
            Me.imageMarkingPageGroup.ItemLinks.Add(Me.biUnmark)
            Me.imageMarkingPageGroup.ItemLinks.Add(Me.biUnmarkAll)
            Me.imageMarkingPageGroup.ItemLinks.Add(Me.biFilterByMarked, True)
            Me.imageMarkingPageGroup.ItemLinks.Add(Me.biSelectAllMarked)
            Me.imageMarkingPageGroup.Name = "imageMarkingPageGroup"
            Me.imageMarkingPageGroup.Text = "Marking"
            '
            'makePageGroup
            '
            Me.makePageGroup.ItemLinks.Add(Me.biCollage)
            Me.makePageGroup.ItemLinks.Add(Me.biSlideShow)
            Me.makePageGroup.ItemLinks.Add(Me.biFilm)
            Me.makePageGroup.Name = "makePageGroup"
            Me.makePageGroup.Text = "Make"
            '
            'outputPageGroup
            '
            Me.outputPageGroup.ItemLinks.Add(Me.biExportFolder)
            Me.outputPageGroup.ItemLinks.Add(Me.biEmail)
            Me.outputPageGroup.ItemLinks.Add(Me.biUpload)
            Me.outputPageGroup.ItemLinks.Add(Me.biPrint, True)
            Me.outputPageGroup.Name = "outputPageGroup"
            Me.outputPageGroup.Text = "Output"
            '
            'ribbonStatusBar1
            '
            Me.ribbonStatusBar1.ItemLinks.Add(Me.beZoom)
            Me.ribbonStatusBar1.Location = New System.Drawing.Point(0, 738)
            Me.ribbonStatusBar1.Name = "ribbonStatusBar1"
            Me.ribbonStatusBar1.Ribbon = Me.childRibbon
            Me.ribbonStatusBar1.Size = New System.Drawing.Size(1112, 31)
            '
            'addToLibraryMenu
            '
            Me.addToLibraryMenu.Name = "addToLibraryMenu"
            Me.addToLibraryMenu.Ribbon = Me.childRibbon
            '
            'gallery
            '
            Me.gallery.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gallery.Controls.Add(Me.galleryControlClient1)
            Me.gallery.DesignGalleryGroupIndex = 0
            Me.gallery.DesignGalleryItemIndex = 0
            Me.gallery.Dock = System.Windows.Forms.DockStyle.Fill
            '
            'GalleryControlGallery1
            '
            Me.gallery.Gallery.AllowMarqueeSelection = True
            Me.gallery.Gallery.ClearSelectionOnClickEmptySpace = True
            Me.gallery.Gallery.ImageSize = New System.Drawing.Size(128, 128)
            Me.gallery.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.Multiple
            Me.gallery.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.ZoomInside
            Me.gallery.Gallery.ScrollMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryScrollMode.Smooth
            Me.gallery.Gallery.ScrollSpeed = 0.75!
            Me.gallery.Location = New System.Drawing.Point(0, 0)
            Me.gallery.Margin = New System.Windows.Forms.Padding(0)
            Me.gallery.Name = "gallery"
            Me.gallery.Size = New System.Drawing.Size(1112, 594)
            Me.gallery.TabIndex = 0
            Me.gallery.Text = "galleryControl1"
            '
            'galleryControlClient1
            '
            Me.defaultToolTipController1.SetAllowHtmlText(Me.galleryControlClient1, DevExpress.Utils.DefaultBoolean.[Default])
            Me.galleryControlClient1.GalleryControl = Me.gallery
            Me.galleryControlClient1.Location = New System.Drawing.Point(1, 1)
            Me.galleryControlClient1.Size = New System.Drawing.Size(1093, 592)
            '
            'printPreviewDialog1
            '
            Me.defaultToolTipController1.SetAllowHtmlText(Me.printPreviewDialog1, DevExpress.Utils.DefaultBoolean.[Default])
            Me.printPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
            Me.printPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
            Me.printPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
            Me.printPreviewDialog1.Enabled = True
            Me.printPreviewDialog1.Icon = CType(resources.GetObject("printPreviewDialog1.Icon"), System.Drawing.Icon)
            Me.printPreviewDialog1.Name = "printPreviewDialog1"
            Me.printPreviewDialog1.UseAntiAlias = True
            Me.printPreviewDialog1.Visible = False
            '
            'libraryPanel
            '
            Me.defaultToolTipController1.SetAllowHtmlText(Me.libraryPanel, DevExpress.Utils.DefaultBoolean.[Default])
            Me.libraryPanel.Controls.Add(Me.galleryContentPanel)
            Me.libraryPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.libraryPanel.Location = New System.Drawing.Point(0, 0)
            Me.libraryPanel.Name = "libraryPanel"
            Me.libraryPanel.Size = New System.Drawing.Size(1112, 594)
            Me.libraryPanel.TabIndex = 1
            '
            'galleryContentPanel
            '
            Me.defaultToolTipController1.SetAllowHtmlText(Me.galleryContentPanel, DevExpress.Utils.DefaultBoolean.[Default])
            Me.galleryContentPanel.Controls.Add(Me.galleryPanel)
            Me.galleryContentPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.galleryContentPanel.Location = New System.Drawing.Point(0, 0)
            Me.galleryContentPanel.Margin = New System.Windows.Forms.Padding(0)
            Me.galleryContentPanel.Name = "galleryContentPanel"
            Me.galleryContentPanel.Size = New System.Drawing.Size(1112, 594)
            Me.galleryContentPanel.TabIndex = 2
            '
            'galleryPanel
            '
            Me.defaultToolTipController1.SetAllowHtmlText(Me.galleryPanel, DevExpress.Utils.DefaultBoolean.[Default])
            Me.galleryPanel.Controls.Add(Me.gallery)
            Me.galleryPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.galleryPanel.Location = New System.Drawing.Point(0, 0)
            Me.galleryPanel.Margin = New System.Windows.Forms.Padding(0)
            Me.galleryPanel.Name = "galleryPanel"
            Me.galleryPanel.Size = New System.Drawing.Size(1112, 594)
            Me.galleryPanel.TabIndex = 1
            '
            'dockPanel1_Container
            '
            Me.defaultToolTipController1.SetAllowHtmlText(Me.dockPanel1_Container, DevExpress.Utils.DefaultBoolean.[Default])
            Me.dockPanel1_Container.Location = New System.Drawing.Point(3, 25)
            Me.dockPanel1_Container.Name = "dockPanel1_Container"
            Me.dockPanel1_Container.Size = New System.Drawing.Size(238, 401)
            Me.dockPanel1_Container.TabIndex = 0
            '
            'controlPresenter
            '
            Me.defaultToolTipController1.SetAllowHtmlText(Me.controlPresenter, DevExpress.Utils.DefaultBoolean.[Default])
            Me.controlPresenter.Controls.Add(Me.libraryPanel)
            Me.controlPresenter.Dock = System.Windows.Forms.DockStyle.Fill
            Me.controlPresenter.Location = New System.Drawing.Point(0, 144)
            Me.controlPresenter.Name = "controlPresenter"
            Me.controlPresenter.SelectedControl = Me.libraryPanel
            Me.controlPresenter.SelectedControlIndex = 0
            Me.controlPresenter.Size = New System.Drawing.Size(1112, 594)
            Me.controlPresenter.TabIndex = 10
            '
            'galleryItemMenu
            '
            Me.galleryItemMenu.Name = "galleryItemMenu"
            Me.galleryItemMenu.Ribbon = Me.childRibbon
            '
            'imageDialog
            '
            Me.imageDialog.Filter = "Image files (BMP,JPG,PNG,GIF) |*.bmp;*.jpg;*.png;*.gif| All files|*.*"
            Me.imageDialog.Multiselect = True
            '
            'ribbonMiniToolbar1
            '
            Me.ribbonMiniToolbar1.Alignment = System.Drawing.ContentAlignment.TopRight
            Me.ribbonMiniToolbar1.ItemLinks.Add(Me.barButtonGroup1)
            Me.ribbonMiniToolbar1.ItemLinks.Add(Me.barButtonGroup2)
            Me.ribbonMiniToolbar1.ItemLinks.Add(Me.barButtonGroup3)
            Me.ribbonMiniToolbar1.ItemLinks.Add(Me.barButtonGroup4)
            Me.ribbonMiniToolbar1.ParentControl = Me
            '
            'GalleryForm
            '
            Me.defaultToolTipController1.SetAllowHtmlText(Me, DevExpress.Utils.DefaultBoolean.[Default])
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1112, 769)
            Me.Controls.Add(Me.controlPresenter)
            Me.Controls.Add(Me.ribbonStatusBar1)
            Me.Controls.Add(Me.childRibbon)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "GalleryForm"
            Me.Ribbon = Me.childRibbon
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StatusBar = Me.ribbonStatusBar1
            Me.Text = "PhotoViewer"
            CType(Me.childRibbon, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.albumsPopupMenu, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemZoomTrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.addToLibraryMenu, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gallery, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gallery.ResumeLayout(False)
            Me.libraryPanel.ResumeLayout(False)
            Me.galleryContentPanel.ResumeLayout(False)
            Me.galleryPanel.ResumeLayout(False)
            Me.controlPresenter.ResumeLayout(False)
            CType(Me.galleryItemMenu, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private bsView As DevExpress.XtraBars.BarSubItem
		Protected Friend WithEvents gallery As DevExpress.XtraBars.Ribbon.GalleryControl
		Private WithEvents biPrint As DevExpress.XtraBars.BarButtonItem
		Private defaultToolTipController1 As DevExpress.Utils.DefaultToolTipController
		Private folderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
		Private barButtonItem2 As DevExpress.XtraBars.BarButtonItem
		Private WithEvents controlPresenter As DevExpress.Utils.Controls.ControlPresenter
		Private printPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
		Private galleryItemMenu As DevExpress.XtraBars.PopupMenu
		Private albumSubItem As DevExpress.XtraBars.BarSubItem
		Private WithEvents biView As DevExpress.XtraBars.BarButtonItem
		Private WithEvents childRibbon As DevExpress.XtraBars.Ribbon.RibbonControl
		Private imagePage As DevExpress.XtraBars.Ribbon.RibbonPage
		Private imageGeneralPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private imageMarkingPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private makePageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private outputPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private viewPageCategory As DevExpress.XtraBars.Ribbon.RibbonPageCategory
		Private collectionOriginalPage As DevExpress.XtraBars.Ribbon.RibbonPage
		Private WithEvents biExportFolder As DevExpress.XtraBars.BarButtonItem
		Private WithEvents biEmail As DevExpress.XtraBars.BarButtonItem
		Private WithEvents biUpload As DevExpress.XtraBars.BarButtonItem
		Private addToLibraryMenu As DevExpress.XtraBars.PopupMenu
		Private biRemoveFilesFromLibrary As DevExpress.XtraBars.BarButtonItem
		Private WithEvents biAddToAlbum As DevExpress.XtraBars.BarButtonItem
		Private WithEvents biMark As DevExpress.XtraBars.BarButtonItem
		Private WithEvents biUnmark As DevExpress.XtraBars.BarButtonItem
		Private WithEvents biUnmarkAll As DevExpress.XtraBars.BarButtonItem
		Private WithEvents biCollage As DevExpress.XtraBars.BarButtonItem
		Private WithEvents biSlideShow As DevExpress.XtraBars.BarButtonItem
		Private WithEvents biFilm As DevExpress.XtraBars.BarButtonItem
		Private libraryPanel As System.Windows.Forms.UserControl
		Private dockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
		Private filtersFilePageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private WithEvents biSaveImage As DevExpress.XtraBars.BarButtonItem
		Private WithEvents biCancel As DevExpress.XtraBars.BarButtonItem
		Private WithEvents biClose As DevExpress.XtraBars.BarButtonItem
		Private filtersPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private WithEvents filtersGallery As DevExpress.XtraBars.RibbonGalleryBarItem
		Private WithEvents biFilterByMarked As DevExpress.XtraBars.BarCheckItem
		Private WithEvents biRemoveFromAlbum As DevExpress.XtraBars.BarButtonItem
		Private imageDialog As System.Windows.Forms.OpenFileDialog
		Private WithEvents biSelectAllMarked As DevExpress.XtraBars.BarButtonItem
		Private WithEvents beZoom As DevExpress.XtraBars.BarEditItem
        Private WithEvents repositoryItemZoomTrackBar1 As DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar
		Private ribbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
		Private galleryContentPanel As System.Windows.Forms.Panel
		Private galleryPanel As System.Windows.Forms.Panel
		Private galleryControlClient1 As DevExpress.XtraBars.Ribbon.GalleryControlClient
		Private barButtonGroup1 As DevExpress.XtraBars.BarButtonGroup
		Private barButtonGroup2 As DevExpress.XtraBars.BarButtonGroup
		Private barButtonGroup3 As DevExpress.XtraBars.BarButtonGroup
		Private barButtonGroup4 As DevExpress.XtraBars.BarButtonGroup
		Private albumsPopupMenu As DevExpress.XtraBars.PopupMenu
		Private ribbonMiniToolbar1 As DevExpress.XtraBars.Ribbon.RibbonMiniToolbar
	End Class
End Namespace


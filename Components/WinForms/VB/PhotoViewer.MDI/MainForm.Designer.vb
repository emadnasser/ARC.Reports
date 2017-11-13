Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraTab
Namespace PhotoViewer
	Partial Public Class MainForm
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
            Dim GalleryItemGroup2 As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Dim GalleryItemGroup3 As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
            Me.panelContainer1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.controlContainer1 = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.selectedPictureEdit = New DevExpress.XtraEditors.PictureEdit()
            Me.mainRibbon = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.applicationMenu1 = New DevExpress.XtraBars.Ribbon.ApplicationMenu()
            Me.popupControlContainer1 = New DevExpress.XtraBars.PopupControlContainer()
            Me.exitButton = New DevExpress.XtraEditors.SimpleButton()
            Me.biNewAlbum = New DevExpress.XtraBars.BarButtonItem()
            Me.biAddFolder = New DevExpress.XtraBars.BarButtonItem()
            Me.biAddFile = New DevExpress.XtraBars.BarButtonItem()
            Me.biGenerateData = New DevExpress.XtraBars.BarButtonItem()
            Me.barAndDockingController = New DevExpress.XtraBars.BarAndDockingController()
            Me.bsView = New DevExpress.XtraBars.BarSubItem()
            Me.bsTools = New DevExpress.XtraBars.BarSubItem()
            Me.bsSkins = New DevExpress.XtraBars.BarSubItem()
            Me.bsHelp = New DevExpress.XtraBars.BarSubItem()
            Me.biAbout = New DevExpress.XtraBars.BarButtonItem()
            Me.biExit = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
            Me.biRemoveAlbum = New DevExpress.XtraBars.BarButtonItem()
            Me.biRemoveFolder = New DevExpress.XtraBars.BarButtonItem()
            Me.biEditAlbum = New DevExpress.XtraBars.BarButtonItem()
            Me.albumSubItem = New DevExpress.XtraBars.BarSubItem()
            Me.skinGalleryBarItem = New DevExpress.XtraBars.RibbonGalleryBarItem()
            Me.biAddToLibrary = New DevExpress.XtraBars.BarButtonItem()
            Me.addToLibraryMenu = New DevExpress.XtraBars.PopupMenu()
            Me.biSaveImage = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonGroup1 = New DevExpress.XtraBars.BarButtonGroup()
            Me.barButtonGroup2 = New DevExpress.XtraBars.BarButtonGroup()
            Me.barButtonGroup3 = New DevExpress.XtraBars.BarButtonGroup()
            Me.barButtonGroup4 = New DevExpress.XtraBars.BarButtonGroup()
            Me.BBColorMix = New DevExpress.XtraBars.BarButtonItem()
            Me.ribbonMiniToolbar1 = New DevExpress.XtraBars.Ribbon.RibbonMiniToolbar()
            Me.viewPageCategory = New DevExpress.XtraBars.Ribbon.RibbonPageCategory()
            Me.imagePage = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.imageGeneralPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.folderPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.folderPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.albumPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.albumPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.viewPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.skinsPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
            Me.navBar = New DevExpress.XtraNavBar.NavBarControl()
            Me.albumGroup = New DevExpress.XtraNavBar.NavBarGroup()
            Me.foldersGroup = New DevExpress.XtraNavBar.NavBarGroup()
            Me.othersGroup = New DevExpress.XtraNavBar.NavBarGroup()
            Me.albumPopupMenu = New DevExpress.XtraBars.PopupMenu()
            Me.dockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.controlContainer2 = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.dateFilter = New PhotoViewer.DateFilter()
            Me.defaultToolTipController1 = New DevExpress.Utils.DefaultToolTipController()
            Me.folderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
            Me.folderPopupMenu = New DevExpress.XtraBars.PopupMenu()
            Me.galleryItemMenu = New DevExpress.XtraBars.PopupMenu()
            Me.imageDialog = New System.Windows.Forms.OpenFileDialog()
            Me.dockManager = New DevExpress.XtraBars.Docking.DockManager()
            Me.documentManager = New DevExpress.XtraBars.Docking2010.DocumentManager()
            Me.tabbedView = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView()
            Me.panelContainer1.SuspendLayout()
            Me.dockPanel1.SuspendLayout()
            Me.controlContainer1.SuspendLayout()
            CType(Me.selectedPictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.mainRibbon, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.applicationMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.popupControlContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.popupControlContainer1.SuspendLayout()
            CType(Me.barAndDockingController, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.addToLibraryMenu, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.navBar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.albumPopupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanel2.SuspendLayout()
            Me.controlContainer2.SuspendLayout()
            CType(Me.folderPopupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.galleryItemMenu, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dockManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.documentManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tabbedView, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'panelContainer1
            '
            Me.panelContainer1.Controls.Add(Me.dockPanel1)
            Me.panelContainer1.Controls.Add(Me.dockPanel2)
            Me.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.panelContainer1.ID = New System.Guid("8218d2c3-3acd-4418-8cf7-e1b6091107a3")
            Me.panelContainer1.Location = New System.Drawing.Point(765, 147)
            Me.panelContainer1.Name = "panelContainer1"
            Me.panelContainer1.OriginalSize = New System.Drawing.Size(347, 200)
            Me.panelContainer1.Size = New System.Drawing.Size(347, 599)
            Me.panelContainer1.Text = "panelContainer1"
            '
            'dockPanel1
            '
            Me.dockPanel1.Controls.Add(Me.controlContainer1)
            Me.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.dockPanel1.ID = New System.Guid("1a5d040e-8d04-4f3d-bfd7-d81cb0934982")
            Me.dockPanel1.Location = New System.Drawing.Point(0, 0)
            Me.dockPanel1.Name = "dockPanel1"
            Me.dockPanel1.Options.ShowCloseButton = False
            Me.dockPanel1.OriginalSize = New System.Drawing.Size(347, 252)
            Me.dockPanel1.Size = New System.Drawing.Size(347, 252)
            Me.dockPanel1.Text = "Preview"
            '
            'controlContainer1
            '
            Me.defaultToolTipController1.SetAllowHtmlText(Me.controlContainer1, DevExpress.Utils.DefaultBoolean.[Default])
            Me.controlContainer1.Controls.Add(Me.selectedPictureEdit)
            Me.controlContainer1.Location = New System.Drawing.Point(3, 29)
            Me.controlContainer1.Name = "controlContainer1"
            Me.controlContainer1.Size = New System.Drawing.Size(341, 220)
            Me.controlContainer1.TabIndex = 0
            '
            'selectedPictureEdit
            '
            Me.selectedPictureEdit.Dock = System.Windows.Forms.DockStyle.Fill
            Me.selectedPictureEdit.Location = New System.Drawing.Point(0, 0)
            Me.selectedPictureEdit.MenuManager = Me.mainRibbon
            Me.selectedPictureEdit.Name = "selectedPictureEdit"
            Me.selectedPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
            Me.selectedPictureEdit.Size = New System.Drawing.Size(341, 220)
            Me.selectedPictureEdit.TabIndex = 0
            '
            'mainRibbon
            '
            Me.mainRibbon.ApplicationButtonDropDownControl = Me.applicationMenu1
            Me.mainRibbon.ApplicationButtonText = Nothing
            Me.mainRibbon.Controller = Me.barAndDockingController
            Me.mainRibbon.ExpandCollapseItem.Id = 0
            Me.mainRibbon.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.mainRibbon.ExpandCollapseItem, Me.bsView, Me.bsTools, Me.bsHelp, Me.biAbout, Me.bsSkins, Me.biNewAlbum, Me.biAddFolder, Me.biAddFile, Me.biExit, Me.barButtonItem2, Me.biRemoveAlbum, Me.biRemoveFolder, Me.biEditAlbum, Me.albumSubItem, Me.skinGalleryBarItem, Me.biAddToLibrary, Me.biSaveImage, Me.biGenerateData, Me.barButtonGroup1, Me.barButtonGroup2, Me.barButtonGroup3, Me.barButtonGroup4, Me.BBColorMix})
            Me.mainRibbon.Location = New System.Drawing.Point(0, 0)
            Me.mainRibbon.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.mainRibbon.MaxItemId = 29
            Me.mainRibbon.MiniToolbars.Add(Me.ribbonMiniToolbar1)
            Me.mainRibbon.Name = "mainRibbon"
            Me.mainRibbon.OptionsTouch.ShowTouchUISelectorInQAT = True
            Me.mainRibbon.OptionsTouch.ShowTouchUISelectorVisibilityItemInQATMenu = True
            Me.mainRibbon.PageCategories.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageCategory() {Me.viewPageCategory})
            Me.mainRibbon.PageCategoryAlignment = DevExpress.XtraBars.Ribbon.RibbonPageCategoryAlignment.Right
            Me.mainRibbon.PageHeaderItemLinks.Add(Me.biAbout)
            Me.mainRibbon.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.imagePage, Me.folderPage, Me.albumPage, Me.viewPage})
            Me.mainRibbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
            Me.mainRibbon.Size = New System.Drawing.Size(1112, 147)
            Me.mainRibbon.StatusBar = Me.ribbonStatusBar1
            Me.mainRibbon.TransparentEditors = True
            '
            'applicationMenu1
            '
            Me.applicationMenu1.BottomPaneControlContainer = Me.popupControlContainer1
            Me.applicationMenu1.ItemLinks.Add(Me.biNewAlbum)
            Me.applicationMenu1.ItemLinks.Add(Me.biAddFolder, True)
            Me.applicationMenu1.ItemLinks.Add(Me.biAddFile)
            Me.applicationMenu1.ItemLinks.Add(Me.biGenerateData, True)
            Me.applicationMenu1.Name = "applicationMenu1"
            Me.applicationMenu1.Ribbon = Me.mainRibbon
            Me.applicationMenu1.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
            '
            'popupControlContainer1
            '
            Me.defaultToolTipController1.SetAllowHtmlText(Me.popupControlContainer1, DevExpress.Utils.DefaultBoolean.[Default])
            Me.popupControlContainer1.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.popupControlContainer1.Appearance.Options.UseBackColor = True
            Me.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.popupControlContainer1.Controls.Add(Me.exitButton)
            Me.popupControlContainer1.Location = New System.Drawing.Point(989, 71)
            Me.popupControlContainer1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.popupControlContainer1.Name = "popupControlContainer1"
            Me.popupControlContainer1.Ribbon = Me.mainRibbon
            Me.popupControlContainer1.Size = New System.Drawing.Size(79, 36)
            Me.popupControlContainer1.TabIndex = 1
            Me.popupControlContainer1.Visible = False
            '
            'exitButton
            '
            Me.exitButton.Location = New System.Drawing.Point(3, 4)
            Me.exitButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.exitButton.Name = "exitButton"
            Me.exitButton.Size = New System.Drawing.Size(71, 28)
            Me.exitButton.TabIndex = 0
            Me.exitButton.Text = "Exit"
            '
            'biNewAlbum
            '
            Me.biNewAlbum.Caption = "&New Album..."
            Me.biNewAlbum.Glyph = Global.My.Resources.Resources.NewAlbum_16x16
            Me.biNewAlbum.Id = 8
            Me.biNewAlbum.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N))
            Me.biNewAlbum.LargeGlyph = Global.My.Resources.Resources.NewAlbum_32x32
            Me.biNewAlbum.Name = "biNewAlbum"
            '
            'biAddFolder
            '
            Me.biAddFolder.Caption = "Add Folder"
            Me.biAddFolder.Glyph = Global.My.Resources.Resources.AddFolder_16x16
            Me.biAddFolder.Id = 9
            Me.biAddFolder.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F))
            Me.biAddFolder.LargeGlyph = Global.My.Resources.Resources.AddFolder_32x32
            Me.biAddFolder.Name = "biAddFolder"
            '
            'biAddFile
            '
            Me.biAddFile.Caption = "Add File"
            Me.biAddFile.Glyph = Global.My.Resources.Resources.AddFile_16x16
            Me.biAddFile.Id = 10
            Me.biAddFile.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O))
            Me.biAddFile.LargeGlyph = Global.My.Resources.Resources.AddFile_32x32
            Me.biAddFile.Name = "biAddFile"
            '
            'biGenerateData
            '
            Me.biGenerateData.Caption = "Generate Data"
            Me.biGenerateData.Glyph = Global.My.Resources.Resources.GenerateData_16x16
            Me.biGenerateData.Hint = "This item allow you to generate default data for demo"
            Me.biGenerateData.Id = 19
            Me.biGenerateData.LargeGlyph = Global.My.Resources.Resources.GenerateData_32x32
            Me.biGenerateData.Name = "biGenerateData"
            '
            'barAndDockingController
            '
            Me.barAndDockingController.PropertiesBar.AllowLinkLighting = False
            Me.barAndDockingController.PropertiesBar.DefaultGlyphSize = New System.Drawing.Size(16, 16)
            Me.barAndDockingController.PropertiesBar.DefaultLargeGlyphSize = New System.Drawing.Size(32, 32)
            '
            'bsView
            '
            Me.bsView.Caption = "&View"
            Me.bsView.Id = 2
            Me.bsView.Name = "bsView"
            Me.bsView.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
            '
            'bsTools
            '
            Me.bsTools.Caption = "&Tools"
            Me.bsTools.Id = 3
            Me.bsTools.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bsSkins)})
            Me.bsTools.Name = "bsTools"
            Me.bsTools.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
            '
            'bsSkins
            '
            Me.bsSkins.Caption = "&Skins"
            Me.bsSkins.Id = 7
            Me.bsSkins.Name = "bsSkins"
            Me.bsSkins.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
            '
            'bsHelp
            '
            Me.bsHelp.Caption = "&Help"
            Me.bsHelp.Id = 5
            Me.bsHelp.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.biAbout)})
            Me.bsHelp.Name = "bsHelp"
            Me.bsHelp.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
            '
            'biAbout
            '
            Me.biAbout.Caption = "&About"
            Me.biAbout.Glyph = Global.My.Resources.Resources.Help_16x16
            Me.biAbout.Id = 6
            Me.biAbout.LargeGlyph = Global.My.Resources.Resources.Help_32x32
            Me.biAbout.Name = "biAbout"
            '
            'biExit
            '
            Me.biExit.Caption = "&Exit"
            Me.biExit.Id = 12
            Me.biExit.Name = "biExit"
            '
            'barButtonItem2
            '
            Me.barButtonItem2.Caption = "Delete Folder"
            Me.barButtonItem2.Id = 13
            Me.barButtonItem2.Name = "barButtonItem2"
            '
            'biRemoveAlbum
            '
            Me.biRemoveAlbum.Caption = "Remove Album"
            Me.biRemoveAlbum.Glyph = Global.My.Resources.Resources.RemoveAlbum_16x16
            Me.biRemoveAlbum.Id = 14
            Me.biRemoveAlbum.LargeGlyph = Global.My.Resources.Resources.RemoveAlbum_32x32
            Me.biRemoveAlbum.Name = "biRemoveAlbum"
            '
            'biRemoveFolder
            '
            Me.biRemoveFolder.Caption = "Remove Folder"
            Me.biRemoveFolder.Glyph = Global.My.Resources.Resources.RemoveFolder_16x16
            Me.biRemoveFolder.Id = 15
            Me.biRemoveFolder.LargeGlyph = Global.My.Resources.Resources.RemoveFolder_32x32
            Me.biRemoveFolder.Name = "biRemoveFolder"
            '
            'biEditAlbum
            '
            Me.biEditAlbum.Caption = "Edit Album"
            Me.biEditAlbum.Glyph = Global.My.Resources.Resources.Edit_16x16
            Me.biEditAlbum.Id = 17
            Me.biEditAlbum.LargeGlyph = Global.My.Resources.Resources.Edit_32x32
            Me.biEditAlbum.Name = "biEditAlbum"
            '
            'albumSubItem
            '
            Me.albumSubItem.Caption = "&Album"
            Me.albumSubItem.Id = 18
            Me.albumSubItem.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.biNewAlbum), New DevExpress.XtraBars.LinkPersistInfo(Me.biEditAlbum, True), New DevExpress.XtraBars.LinkPersistInfo(Me.biRemoveAlbum)})
            Me.albumSubItem.Name = "albumSubItem"
            Me.albumSubItem.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
            '
            'skinGalleryBarItem
            '
            '
            '
            '
            Me.skinGalleryBarItem.Gallery.AllowHoverImages = True
            Me.skinGalleryBarItem.Gallery.FixedHoverImageSize = False
            GalleryItemGroup1.Caption = "Standard"
            GalleryItemGroup2.Caption = "Bonus"
            GalleryItemGroup2.Visible = False
            GalleryItemGroup3.Caption = "Office"
            GalleryItemGroup3.Visible = False
            Me.skinGalleryBarItem.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {GalleryItemGroup1, GalleryItemGroup2, GalleryItemGroup3})
            Me.skinGalleryBarItem.Gallery.ImageSize = New System.Drawing.Size(58, 43)
            Me.skinGalleryBarItem.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleRadio
            Me.skinGalleryBarItem.Id = 1
            Me.skinGalleryBarItem.Name = "skinGalleryBarItem"
            '
            'biAddToLibrary
            '
            Me.biAddToLibrary.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.biAddToLibrary.Caption = "Add to Library"
            Me.biAddToLibrary.DropDownControl = Me.addToLibraryMenu
            Me.biAddToLibrary.Glyph = Global.My.Resources.Resources.AddToLibrary_16x16
            Me.biAddToLibrary.Hint = "Add files or folder to library"
            Me.biAddToLibrary.Id = 5
            Me.biAddToLibrary.LargeGlyph = Global.My.Resources.Resources.AddToLibrary_32x32
            Me.biAddToLibrary.Name = "biAddToLibrary"
            '
            'addToLibraryMenu
            '
            Me.addToLibraryMenu.ItemLinks.Add(Me.biAddFolder)
            Me.addToLibraryMenu.ItemLinks.Add(Me.biAddFile)
            Me.addToLibraryMenu.Name = "addToLibraryMenu"
            Me.addToLibraryMenu.Ribbon = Me.mainRibbon
            Me.addToLibraryMenu.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
            '
            'biSaveImage
            '
            Me.biSaveImage.Caption = "Save"
            Me.biSaveImage.Glyph = Global.My.Resources.Resources.Save_16x16
            Me.biSaveImage.Id = 14
            Me.biSaveImage.LargeGlyph = Global.My.Resources.Resources.Save_32x32
            Me.biSaveImage.Name = "biSaveImage"
            '
            'barButtonGroup1
            '
            Me.barButtonGroup1.Caption = "barButtonGroup1"
            Me.barButtonGroup1.Id = 23
            Me.barButtonGroup1.Name = "barButtonGroup1"
            Me.barButtonGroup1.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
            '
            'barButtonGroup2
            '
            Me.barButtonGroup2.Caption = "barButtonGroup2"
            Me.barButtonGroup2.Id = 24
            Me.barButtonGroup2.Name = "barButtonGroup2"
            Me.barButtonGroup2.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
            '
            'barButtonGroup3
            '
            Me.barButtonGroup3.Caption = "barButtonGroup3"
            Me.barButtonGroup3.Id = 25
            Me.barButtonGroup3.Name = "barButtonGroup3"
            Me.barButtonGroup3.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
            '
            'barButtonGroup4
            '
            Me.barButtonGroup4.Caption = "barButtonGroup4"
            Me.barButtonGroup4.Id = 26
            Me.barButtonGroup4.Name = "barButtonGroup4"
            Me.barButtonGroup4.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
            '
            'BBColorMix
            '
            Me.BBColorMix.Caption = "Color Mix"
            Me.BBColorMix.Glyph = Global.My.Resources.Resources.ColorMixer_16x16
            Me.BBColorMix.Id = 28
            Me.BBColorMix.LargeGlyph = Global.My.Resources.Resources.ColorMixer_32x32
            Me.BBColorMix.Name = "BBColorMix"
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
            'viewPageCategory
            '
            Me.viewPageCategory.Name = "viewPageCategory"
            Me.viewPageCategory.Text = "View"
            Me.viewPageCategory.Visible = False
            '
            'imagePage
            '
            Me.imagePage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.imageGeneralPageGroup})
            Me.imagePage.Name = "imagePage"
            Me.imagePage.Text = "Image"
            '
            'imageGeneralPageGroup
            '
            Me.imageGeneralPageGroup.ItemLinks.Add(Me.biAddToLibrary)
            Me.imageGeneralPageGroup.Name = "imageGeneralPageGroup"
            Me.imageGeneralPageGroup.Text = "General"
            '
            'folderPage
            '
            Me.folderPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.folderPageGroup})
            Me.folderPage.Name = "folderPage"
            Me.folderPage.Text = "Folder"
            '
            'folderPageGroup
            '
            Me.folderPageGroup.ItemLinks.Add(Me.biAddFolder)
            Me.folderPageGroup.ItemLinks.Add(Me.biAddFile)
            Me.folderPageGroup.ItemLinks.Add(Me.biRemoveFolder)
            Me.folderPageGroup.Name = "folderPageGroup"
            Me.folderPageGroup.Text = "General"
            '
            'albumPage
            '
            Me.albumPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.albumPageGroup})
            Me.albumPage.Name = "albumPage"
            Me.albumPage.Text = "Album"
            '
            'albumPageGroup
            '
            Me.albumPageGroup.ItemLinks.Add(Me.biNewAlbum)
            Me.albumPageGroup.ItemLinks.Add(Me.biEditAlbum)
            Me.albumPageGroup.ItemLinks.Add(Me.biRemoveAlbum)
            Me.albumPageGroup.Name = "albumPageGroup"
            Me.albumPageGroup.Text = "General"
            '
            'viewPage
            '
            Me.viewPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.skinsPageGroup})
            Me.viewPage.Name = "viewPage"
            Me.viewPage.Text = "View"
            '
            'skinsPageGroup
            '
            Me.skinsPageGroup.ItemLinks.Add(Me.skinGalleryBarItem)
            Me.skinsPageGroup.ItemLinks.Add(Me.BBColorMix)
            Me.skinsPageGroup.Name = "skinsPageGroup"
            Me.skinsPageGroup.Text = "Skins"
            '
            'ribbonStatusBar1
            '
            Me.ribbonStatusBar1.Location = New System.Drawing.Point(0, 746)
            Me.ribbonStatusBar1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.ribbonStatusBar1.Name = "ribbonStatusBar1"
            Me.ribbonStatusBar1.Ribbon = Me.mainRibbon
            Me.ribbonStatusBar1.Size = New System.Drawing.Size(1112, 23)
            '
            'navBar
            '
            Me.navBar.ActiveGroup = Me.albumGroup
            Me.navBar.Dock = System.Windows.Forms.DockStyle.Left
            Me.navBar.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None
            Me.navBar.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.albumGroup, Me.foldersGroup, Me.othersGroup})
            Me.navBar.LinkSelectionMode = DevExpress.XtraNavBar.LinkSelectionModeType.OneInControl
            Me.navBar.Location = New System.Drawing.Point(0, 147)
            Me.navBar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.navBar.MenuManager = Me.mainRibbon
            Me.navBar.Name = "navBar"
            Me.navBar.OptionsNavPane.ExpandedWidth = 186
            Me.navBar.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane
            Me.mainRibbon.SetPopupContextMenu(Me.navBar, Me.albumPopupMenu)
            Me.navBar.Size = New System.Drawing.Size(186, 599)
            Me.navBar.SkinExplorerBarViewScrollStyle = DevExpress.XtraNavBar.SkinExplorerBarViewScrollStyle.ScrollBar
            Me.navBar.TabIndex = 0
            '
            'albumGroup
            '
            Me.albumGroup.Caption = "Albums"
            Me.albumGroup.Expanded = True
            Me.albumGroup.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
            Me.albumGroup.LargeImage = Global.My.Resources.Resources.Album_32x32
            Me.albumGroup.Name = "albumGroup"
            Me.albumGroup.SmallImage = Global.My.Resources.Resources.Album_16x16
            '
            'foldersGroup
            '
            Me.foldersGroup.Caption = "Folders"
            Me.foldersGroup.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
            Me.foldersGroup.LargeImage = Global.My.Resources.Resources.Folder_32x32
            Me.foldersGroup.Name = "foldersGroup"
            Me.foldersGroup.SmallImage = Global.My.Resources.Resources.Folder_16x16
            '
            'othersGroup
            '
            Me.othersGroup.Caption = "Other"
            Me.othersGroup.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
            Me.othersGroup.LargeImage = Global.My.Resources.Resources.Other_32x32
            Me.othersGroup.Name = "othersGroup"
            Me.othersGroup.SmallImage = Global.My.Resources.Resources.Other_16x16
            '
            'albumPopupMenu
            '
            Me.albumPopupMenu.ItemLinks.Add(Me.biRemoveAlbum)
            Me.albumPopupMenu.ItemLinks.Add(Me.biEditAlbum)
            Me.albumPopupMenu.Name = "albumPopupMenu"
            Me.albumPopupMenu.Ribbon = Me.mainRibbon
            Me.albumPopupMenu.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
            '
            'dockPanel2
            '
            Me.dockPanel2.Controls.Add(Me.controlContainer2)
            Me.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.dockPanel2.ID = New System.Guid("b921466f-3e4f-4a20-8f62-f73e3660d5d9")
            Me.dockPanel2.Location = New System.Drawing.Point(0, 252)
            Me.dockPanel2.Name = "dockPanel2"
            Me.dockPanel2.OriginalSize = New System.Drawing.Size(347, 347)
            Me.dockPanel2.Size = New System.Drawing.Size(347, 347)
            Me.dockPanel2.Text = "Date Filter"
            '
            'controlContainer2
            '
            Me.defaultToolTipController1.SetAllowHtmlText(Me.controlContainer2, DevExpress.Utils.DefaultBoolean.[Default])
            Me.controlContainer2.Controls.Add(Me.dateFilter)
            Me.controlContainer2.Location = New System.Drawing.Point(3, 29)
            Me.controlContainer2.Name = "controlContainer2"
            Me.controlContainer2.Size = New System.Drawing.Size(341, 315)
            Me.controlContainer2.TabIndex = 0
            '
            'dateFilter
            '
            Me.defaultToolTipController1.SetAllowHtmlText(Me.dateFilter, DevExpress.Utils.DefaultBoolean.[Default])
            Me.dateFilter.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dateFilter.Location = New System.Drawing.Point(0, 0)
            Me.dateFilter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.dateFilter.Name = "dateFilter"
            Me.dateFilter.Size = New System.Drawing.Size(341, 315)
            Me.dateFilter.TabIndex = 0
            '
            'folderPopupMenu
            '
            Me.folderPopupMenu.ItemLinks.Add(Me.biRemoveFolder)
            Me.folderPopupMenu.Name = "folderPopupMenu"
            Me.folderPopupMenu.Ribbon = Me.mainRibbon
            Me.folderPopupMenu.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
            '
            'galleryItemMenu
            '
            Me.galleryItemMenu.Name = "galleryItemMenu"
            Me.galleryItemMenu.Ribbon = Me.mainRibbon
            Me.galleryItemMenu.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
            '
            'imageDialog
            '
            Me.imageDialog.Filter = "Image files (BMP,JPG,PNG,GIF) |*.bmp;*.jpg;*.png;*.gif| All files|*.*"
            Me.imageDialog.Multiselect = True
            '
            'dockManager
            '
            Me.dockManager.Controller = Me.barAndDockingController
            Me.dockManager.Form = Me
            Me.dockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.panelContainer1})
            Me.dockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
            '
            'documentManager
            '
            Me.documentManager.BarAndDockingController = Me.barAndDockingController
            Me.documentManager.MdiParent = Me
            Me.documentManager.MenuManager = Me.mainRibbon
            Me.documentManager.View = Me.tabbedView
            Me.documentManager.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.tabbedView})
            '
            'MainForm
            '
            Me.defaultToolTipController1.SetAllowHtmlText(Me, DevExpress.Utils.DefaultBoolean.[Default])
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1112, 769)
            Me.Controls.Add(Me.navBar)
            Me.Controls.Add(Me.popupControlContainer1)
            Me.Controls.Add(Me.panelContainer1)
            Me.Controls.Add(Me.ribbonStatusBar1)
            Me.Controls.Add(Me.mainRibbon)
            Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.IsMdiContainer = True
            Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.Name = "MainForm"
            Me.Ribbon = Me.mainRibbon
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StatusBar = Me.ribbonStatusBar1
            Me.Text = "PhotoViewer"
            Me.panelContainer1.ResumeLayout(False)
            Me.dockPanel1.ResumeLayout(False)
            Me.controlContainer1.ResumeLayout(False)
            CType(Me.selectedPictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.mainRibbon, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.applicationMenu1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.popupControlContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.popupControlContainer1.ResumeLayout(False)
            CType(Me.barAndDockingController, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.addToLibraryMenu, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.navBar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.albumPopupMenu, System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanel2.ResumeLayout(False)
            Me.controlContainer2.ResumeLayout(False)
            CType(Me.folderPopupMenu, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.galleryItemMenu, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dockManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.documentManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tabbedView, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

		Private bsView As DevExpress.XtraBars.BarSubItem
		Private bsTools As DevExpress.XtraBars.BarSubItem
		Private bsHelp As DevExpress.XtraBars.BarSubItem
		Private WithEvents biAbout As DevExpress.XtraBars.BarButtonItem
		Private bsSkins As DevExpress.XtraBars.BarSubItem
		Private WithEvents biNewAlbum As DevExpress.XtraBars.BarButtonItem
		Private WithEvents biAddFolder As DevExpress.XtraBars.BarButtonItem
		Private WithEvents biAddFile As DevExpress.XtraBars.BarButtonItem
		Private biExit As DevExpress.XtraBars.BarButtonItem
		Private defaultToolTipController1 As DevExpress.Utils.DefaultToolTipController
		Private folderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
		Private WithEvents albumPopupMenu As DevExpress.XtraBars.PopupMenu
		Private barButtonItem2 As DevExpress.XtraBars.BarButtonItem
		Private WithEvents biRemoveAlbum As DevExpress.XtraBars.BarButtonItem
		Private folderPopupMenu As DevExpress.XtraBars.PopupMenu
		Private WithEvents biRemoveFolder As DevExpress.XtraBars.BarButtonItem
		Private galleryItemMenu As DevExpress.XtraBars.PopupMenu
		Private WithEvents biEditAlbum As DevExpress.XtraBars.BarButtonItem
		Private albumSubItem As DevExpress.XtraBars.BarSubItem
		Private WithEvents mainRibbon As DevExpress.XtraBars.Ribbon.RibbonControl
		Private imagePage As DevExpress.XtraBars.Ribbon.RibbonPage
		Private imageGeneralPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private folderPage As DevExpress.XtraBars.Ribbon.RibbonPage
		Private viewPageCategory As DevExpress.XtraBars.Ribbon.RibbonPageCategory
		Private albumPage As DevExpress.XtraBars.Ribbon.RibbonPage
		Private viewPage As DevExpress.XtraBars.Ribbon.RibbonPage
		Private folderPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private albumPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private applicationMenu1 As DevExpress.XtraBars.Ribbon.ApplicationMenu
		Private skinGalleryBarItem As DevExpress.XtraBars.RibbonGalleryBarItem
		Private skinsPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private popupControlContainer1 As DevExpress.XtraBars.PopupControlContainer
		Private WithEvents exitButton As DevExpress.XtraEditors.SimpleButton
		Private WithEvents biAddToLibrary As DevExpress.XtraBars.BarButtonItem
		Private addToLibraryMenu As DevExpress.XtraBars.PopupMenu
		Private WithEvents biSaveImage As DevExpress.XtraBars.BarButtonItem
        Private WithEvents biGenerateData As DevExpress.XtraBars.BarButtonItem
		Private imageDialog As System.Windows.Forms.OpenFileDialog
		Private ribbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
		Private barButtonGroup1 As DevExpress.XtraBars.BarButtonGroup
		Private barButtonGroup2 As DevExpress.XtraBars.BarButtonGroup
		Private barButtonGroup3 As DevExpress.XtraBars.BarButtonGroup
		Private barButtonGroup4 As DevExpress.XtraBars.BarButtonGroup
		Private ribbonMiniToolbar1 As DevExpress.XtraBars.Ribbon.RibbonMiniToolbar
		Private WithEvents navBar As DevExpress.XtraNavBar.NavBarControl
		Private albumGroup As DevExpress.XtraNavBar.NavBarGroup
		Private foldersGroup As DevExpress.XtraNavBar.NavBarGroup
		Private othersGroup As DevExpress.XtraNavBar.NavBarGroup

		Private dockManager As DevExpress.XtraBars.Docking.DockManager
		Private panelContainer1 As DevExpress.XtraBars.Docking.DockPanel
		Private dockPanel1 As DevExpress.XtraBars.Docking.DockPanel
		Private controlContainer1 As DevExpress.XtraBars.Docking.ControlContainer
		Private selectedPictureEdit As DevExpress.XtraEditors.PictureEdit
		Private dockPanel2 As DevExpress.XtraBars.Docking.DockPanel
		Private controlContainer2 As DevExpress.XtraBars.Docking.ControlContainer
		Private WithEvents dateFilter As DateFilter

		Private documentManager As DevExpress.XtraBars.Docking2010.DocumentManager
		Private tabbedView As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView
        Private barAndDockingController As DevExpress.XtraBars.BarAndDockingController
        Friend WithEvents BBColorMix As DevExpress.XtraBars.BarButtonItem
	End Class
End Namespace

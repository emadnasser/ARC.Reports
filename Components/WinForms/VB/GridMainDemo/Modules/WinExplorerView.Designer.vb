Imports DevExpress.XtraEditors
Imports DevExpress.XtraNavBar
Namespace DevExpress.XtraGrid.Demos
    Partial Public Class ExplorerView
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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExplorerView))
            Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim GalleryItemGroup1 As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Dim GalleryItem1 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim GalleryItem2 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim GalleryItem3 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim GalleryItem4 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim GalleryItem5 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim GalleryItem6 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim GalleryItem7 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim SkinPaddingEdges1 As DevExpress.Skins.SkinPaddingEdges = New DevExpress.Skins.SkinPaddingEdges()
            Dim SkinPaddingEdges2 As DevExpress.Skins.SkinPaddingEdges = New DevExpress.Skins.SkinPaddingEdges()
            Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim BreadCrumbNode1 As DevExpress.XtraEditors.BreadCrumbNode = New DevExpress.XtraEditors.BreadCrumbNode()
            Dim BreadCrumbNode2 As DevExpress.XtraEditors.BreadCrumbNode = New DevExpress.XtraEditors.BreadCrumbNode()
            Me.repositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.repositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.imgs = New DevExpress.Utils.ImageCollection(Me.components)
            Me.ButtonItemHelp = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemNavigationPane = New DevExpress.XtraBars.BarSubItem()
            Me.ButtonCheckItemNavigationPane = New DevExpress.XtraBars.BarCheckItem()
            Me.ButtonCheckItemShowFavorites = New DevExpress.XtraBars.BarCheckItem()
            Me.ButtonCheckItemShowLibraries = New DevExpress.XtraBars.BarCheckItem()
            Me.ButtonItemItemCheckBoxes = New DevExpress.XtraBars.BarCheckItem()
            Me.ButtonItemFileNameExtensions = New DevExpress.XtraBars.BarCheckItem()
            Me.ButtonItemHiddenItems = New DevExpress.XtraBars.BarCheckItem()
            Me.btnHideSelectedItems = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemCopy = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemPaste = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemCut = New DevExpress.XtraBars.BarButtonItem()
            Me.btnCopyItem = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemMoveTo = New DevExpress.XtraBars.BarSubItem()
            Me.ButtonItemDocuments = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemMusic = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemVideos = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemPictures = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemChooseLocation = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemCopyTo = New DevExpress.XtraBars.BarSubItem()
            Me.ButtonItemRename = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemNewFolder = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemNewItem = New DevExpress.XtraBars.BarSubItem()
            Me.ButtonItemNewShortcut = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemNewBitmapImage = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemNewContact = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemNewJournalDocument = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemNewRichTextDocument = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemNewTextDocument = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemCompressedFolder = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemEdit = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemSelectAll = New DevExpress.XtraBars.BarButtonItem()
            Me.btnSelectNone = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemInvertSelection = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemPropertiesFolder = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemRemoveProperties = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemDelete = New DevExpress.XtraBars.BarButtonItem()
            Me.PopupMenuDeleteButton = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.ButtonItemRecycle = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemPermanentlyDelete = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemShowRecycleConfirmation = New DevExpress.XtraBars.BarCheckItem()
            Me.ButtonItemProperties = New DevExpress.XtraBars.BarButtonItem()
            Me.PopupMenuPropertiesButton = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.btnOpen = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemOptions = New DevExpress.XtraBars.BarButtonItem()
            Me.PopupMenuOptionsButton = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.ButtonItemChangeFilderOptions = New DevExpress.XtraBars.BarButtonItem()
            Me.rgbiViewStyle = New DevExpress.XtraBars.RibbonGalleryBarItem()
            Me.ContextItemOpen = New DevExpress.XtraBars.BarButtonItem()
            Me.ContextItemCut = New DevExpress.XtraBars.BarButtonItem()
            Me.ContextItemCopy = New DevExpress.XtraBars.BarButtonItem()
            Me.ContextItemPaste = New DevExpress.XtraBars.BarButtonItem()
            Me.ContextItemDelete = New DevExpress.XtraBars.BarButtonItem()
            Me.ContextItemRename = New DevExpress.XtraBars.BarButtonItem()
            Me.ContextItemProperties = New DevExpress.XtraBars.BarButtonItem()
            Me.PageHome = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.PageGroupClipboard = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.PageGroupOrganize = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.PageGroupNew = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.PageGroupOpen = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.PageGroupSelect = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.PageView = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.PageGroupViewPanes = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.PageGroupViewLayouts = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.PageGroupViewShowHide = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.PageGroupViewEmpty = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.repositoryItemRadioGroup1 = New DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup()
            Me.repositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.navBar = New DevExpress.XtraNavBar.NavBarControl()
            Me.groupFavorites = New DevExpress.XtraNavBar.NavBarGroup()
            Me.navPanelItemDesktop = New DevExpress.XtraNavBar.NavBarItem()
            Me.navPanelItemDownloads = New DevExpress.XtraNavBar.NavBarItem()
            Me.navPanelItemRecent = New DevExpress.XtraNavBar.NavBarItem()
            Me.groupLibraries = New DevExpress.XtraNavBar.NavBarGroup()
            Me.navPanelItemDocuments = New DevExpress.XtraNavBar.NavBarItem()
            Me.navPanelItemMusic = New DevExpress.XtraNavBar.NavBarItem()
            Me.navPanelItemPictures = New DevExpress.XtraNavBar.NavBarItem()
            Me.navPanelItemVideos = New DevExpress.XtraNavBar.NavBarItem()
            Me.navigationPanel = New DevExpress.XtraEditors.PanelControl()
            Me.btnNavigationHistory = New DevExpress.XtraEditors.LabelControl()
            Me.btnUpTo = New DevExpress.XtraEditors.LabelControl()
            Me.imgArrows = New DevExpress.Utils.ImageCollection(Me.components)
            Me.btnForward = New DevExpress.XtraEditors.LabelControl()
            Me.btnBack = New DevExpress.XtraEditors.LabelControl()
            Me.EditSearch = New DevExpress.XtraEditors.ButtonEdit()
            Me.editBreadCrumb = New DevExpress.XtraEditors.BreadCrumbEdit()
            Me.contentPanel = New DevExpress.XtraEditors.PanelControl()
            Me.LayoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.winExplorerView = New DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView()
            Me.columnName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.columnPath = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.columnCheck = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.columnGroup = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.columnImage = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.LayoutControlMainGroup = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlItemExplorerView = New DevExpress.XtraLayout.LayoutControlItem()
            Me.SplitterItem1 = New DevExpress.XtraLayout.SplitterItem()
            Me.liNavPaneRight = New DevExpress.XtraLayout.LayoutControlItem()
            Me.itemPopupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.navigationMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
            CType(Me.repositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.imgs, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenuDeleteButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenuPropertiesButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenuOptionsButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemRadioGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.navBar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.navigationPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPanel.SuspendLayout()
            CType(Me.imgArrows, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.EditSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.editBreadCrumb.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.contentPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.contentPanel.SuspendLayout()
            CType(Me.LayoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.LayoutControl.SuspendLayout()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.winExplorerView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlMainGroup, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItemExplorerView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.liNavPaneRight, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.itemPopupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.navigationMenu, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'repositoryItemTextEdit3
            '
            Me.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3"
            '
            'repositoryItemTextEdit4
            '
            Me.repositoryItemTextEdit4.Name = "repositoryItemTextEdit4"
            '
            'RibbonControl
            '
            Me.RibbonControl.ApplicationButtonText = "File"
            Me.RibbonControl.ExpandCollapseItem.Id = 0
            Me.RibbonControl.Images = Me.imgs
            Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.ButtonItemHelp, Me.ButtonItemNavigationPane, Me.ButtonItemItemCheckBoxes, Me.ButtonItemFileNameExtensions, Me.ButtonItemHiddenItems, Me.btnHideSelectedItems, Me.ButtonCheckItemNavigationPane, Me.ButtonItemCopy, Me.ButtonItemPaste, Me.ButtonItemCut, Me.btnCopyItem, Me.ButtonItemMoveTo, Me.ButtonItemCopyTo, Me.ButtonItemRename, Me.ButtonItemNewFolder, Me.ButtonItemNewItem, Me.ButtonItemEdit, Me.ButtonItemSelectAll, Me.btnSelectNone, Me.ButtonItemInvertSelection, Me.ButtonItemPropertiesFolder, Me.ButtonItemRemoveProperties, Me.ButtonItemDelete, Me.ButtonItemRecycle, Me.ButtonItemPermanentlyDelete, Me.ButtonItemShowRecycleConfirmation, Me.ButtonItemProperties, Me.ButtonItemDocuments, Me.ButtonItemMusic, Me.ButtonItemVideos, Me.ButtonItemPictures, Me.ButtonItemChooseLocation, Me.ButtonCheckItemShowFavorites, Me.ButtonCheckItemShowLibraries, Me.ButtonItemNewShortcut, Me.ButtonItemNewBitmapImage, Me.ButtonItemNewContact, Me.ButtonItemNewJournalDocument, Me.ButtonItemNewRichTextDocument, Me.ButtonItemNewTextDocument, Me.ButtonItemCompressedFolder, Me.btnOpen, Me.ButtonItemOptions, Me.ButtonItemChangeFilderOptions, Me.rgbiViewStyle, Me.ContextItemOpen, Me.ContextItemCut, Me.ContextItemCopy, Me.ContextItemPaste, Me.ContextItemDelete, Me.ContextItemRename, Me.ContextItemProperties})
            Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
            Me.RibbonControl.MaxItemId = 175
            Me.RibbonControl.Name = "RibbonControl"
            Me.RibbonControl.PageHeaderItemLinks.Add(Me.ButtonItemHelp)
            Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.PageHome, Me.PageView})
            Me.RibbonControl.QuickToolbarItemLinks.Add(Me.ButtonItemPropertiesFolder)
            Me.RibbonControl.QuickToolbarItemLinks.Add(Me.ButtonItemNewFolder)
            Me.RibbonControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemTextEdit1, Me.repositoryItemRadioGroup1, Me.repositoryItemTextEdit2})
            Me.RibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
            Me.RibbonControl.Size = New System.Drawing.Size(1216, 141)
            '
            'imgs
            '
            Me.imgs.ImageStream = CType(resources.GetObject("imgs.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
            Me.imgs.Images.SetKeyName(0, "open_16x16.png")
            Me.imgs.Images.SetKeyName(1, "hoverDown.png")
            Me.imgs.Images.SetKeyName(2, "normalDown.png")
            Me.imgs.Images.SetKeyName(3, "pressedDown.png")
            '
            'ButtonItemHelp
            '
            Me.ButtonItemHelp.Caption = "Help"
            Me.ButtonItemHelp.Id = 15
            Me.ButtonItemHelp.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
            Me.ButtonItemHelp.ImageOptions.Image = CType(resources.GetObject("ButtonItemHelp.ImageOptions.Image"), System.Drawing.Image)
            Me.ButtonItemHelp.ImageOptions.LargeImage = CType(resources.GetObject("ButtonItemHelp.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.ButtonItemHelp.Name = "ButtonItemHelp"
            '
            'ButtonItemNavigationPane
            '
            Me.ButtonItemNavigationPane.Caption = "Navigation pane"
            Me.ButtonItemNavigationPane.Id = 16
            Me.ButtonItemNavigationPane.ImageOptions.LargeImage = Global.My.Resources.Resources.NavigationPaneLarge
            Me.ButtonItemNavigationPane.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.ButtonCheckItemNavigationPane), New DevExpress.XtraBars.LinkPersistInfo(Me.ButtonCheckItemShowFavorites, True), New DevExpress.XtraBars.LinkPersistInfo(Me.ButtonCheckItemShowLibraries)})
            Me.ButtonItemNavigationPane.Name = "ButtonItemNavigationPane"
            Me.ButtonItemNavigationPane.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            '
            'ButtonCheckItemNavigationPane
            '
            Me.ButtonCheckItemNavigationPane.BindableChecked = True
            Me.ButtonCheckItemNavigationPane.Caption = "Navigation pane"
            Me.ButtonCheckItemNavigationPane.Checked = True
            Me.ButtonCheckItemNavigationPane.Id = 37
            Me.ButtonCheckItemNavigationPane.Name = "ButtonCheckItemNavigationPane"
            '
            'ButtonCheckItemShowFavorites
            '
            Me.ButtonCheckItemShowFavorites.BindableChecked = True
            Me.ButtonCheckItemShowFavorites.Caption = "Show favorites"
            Me.ButtonCheckItemShowFavorites.Checked = True
            Me.ButtonCheckItemShowFavorites.Id = 118
            Me.ButtonCheckItemShowFavorites.Name = "ButtonCheckItemShowFavorites"
            '
            'ButtonCheckItemShowLibraries
            '
            Me.ButtonCheckItemShowLibraries.BindableChecked = True
            Me.ButtonCheckItemShowLibraries.Caption = "Show libraries"
            Me.ButtonCheckItemShowLibraries.Checked = True
            Me.ButtonCheckItemShowLibraries.Id = 119
            Me.ButtonCheckItemShowLibraries.Name = "ButtonCheckItemShowLibraries"
            '
            'ButtonItemItemCheckBoxes
            '
            Me.ButtonItemItemCheckBoxes.Caption = "Item check boxes"
            Me.ButtonItemItemCheckBoxes.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.ButtonItemItemCheckBoxes.Id = 26
            Me.ButtonItemItemCheckBoxes.Name = "ButtonItemItemCheckBoxes"
            '
            'ButtonItemFileNameExtensions
            '
            Me.ButtonItemFileNameExtensions.Caption = "File name extensions"
            Me.ButtonItemFileNameExtensions.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.ButtonItemFileNameExtensions.Id = 27
            Me.ButtonItemFileNameExtensions.Name = "ButtonItemFileNameExtensions"
            '
            'ButtonItemHiddenItems
            '
            Me.ButtonItemHiddenItems.Caption = "Hidden items"
            Me.ButtonItemHiddenItems.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.ButtonItemHiddenItems.Id = 28
            Me.ButtonItemHiddenItems.Name = "ButtonItemHiddenItems"
            '
            'btnHideSelectedItems
            '
            Me.btnHideSelectedItems.Caption = "Hide selected items"
            Me.btnHideSelectedItems.Id = 29
            Me.btnHideSelectedItems.ImageOptions.LargeImage = Global.My.Resources.Resources.HideSelectedItemsLarge
            Me.btnHideSelectedItems.Name = "btnHideSelectedItems"
            Me.btnHideSelectedItems.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            '
            'ButtonItemCopy
            '
            Me.ButtonItemCopy.Caption = "Copy"
            Me.ButtonItemCopy.Id = 38
            Me.ButtonItemCopy.ImageOptions.LargeImage = Global.My.Resources.Resources.CopyLarge
            Me.ButtonItemCopy.Name = "ButtonItemCopy"
            Me.ButtonItemCopy.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ToolTipItem1.Text = "The command is not implemented"
            SuperToolTip1.Items.Add(ToolTipItem1)
            Me.ButtonItemCopy.SuperTip = SuperToolTip1
            '
            'ButtonItemPaste
            '
            Me.ButtonItemPaste.Caption = "Paste"
            Me.ButtonItemPaste.Id = 39
            Me.ButtonItemPaste.ImageOptions.LargeImage = Global.My.Resources.Resources.PasteLarge
            Me.ButtonItemPaste.Name = "ButtonItemPaste"
            Me.ButtonItemPaste.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            Me.ButtonItemPaste.SuperTip = SuperToolTip1
            '
            'ButtonItemCut
            '
            Me.ButtonItemCut.Caption = "Cut"
            Me.ButtonItemCut.Id = 40
            Me.ButtonItemCut.ImageOptions.Image = Global.My.Resources.Resources.CutSmall
            Me.ButtonItemCut.Name = "ButtonItemCut"
            Me.ButtonItemCut.SuperTip = SuperToolTip1
            '
            'btnCopyItem
            '
            Me.btnCopyItem.Caption = "Copy path"
            Me.btnCopyItem.Enabled = False
            Me.btnCopyItem.Id = 41
            Me.btnCopyItem.ImageOptions.Image = Global.My.Resources.Resources.CopyPathSmall
            Me.btnCopyItem.Name = "btnCopyItem"
            '
            'ButtonItemMoveTo
            '
            Me.ButtonItemMoveTo.Caption = "Move to"
            Me.ButtonItemMoveTo.Enabled = False
            Me.ButtonItemMoveTo.Id = 43
            Me.ButtonItemMoveTo.ImageOptions.LargeImage = Global.My.Resources.Resources.MoveToLarge
            Me.ButtonItemMoveTo.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.ButtonItemDocuments), New DevExpress.XtraBars.LinkPersistInfo(Me.ButtonItemMusic), New DevExpress.XtraBars.LinkPersistInfo(Me.ButtonItemVideos), New DevExpress.XtraBars.LinkPersistInfo(Me.ButtonItemPictures), New DevExpress.XtraBars.LinkPersistInfo(Me.ButtonItemChooseLocation, True)})
            Me.ButtonItemMoveTo.Name = "ButtonItemMoveTo"
            Me.ButtonItemMoveTo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            '
            'ButtonItemDocuments
            '
            Me.ButtonItemDocuments.Caption = "Documents"
            Me.ButtonItemDocuments.Id = 106
            Me.ButtonItemDocuments.ImageOptions.Image = Global.My.Resources.Resources.DocumentsSmall
            Me.ButtonItemDocuments.Name = "ButtonItemDocuments"
            Me.ButtonItemDocuments.SuperTip = SuperToolTip1
            '
            'ButtonItemMusic
            '
            Me.ButtonItemMusic.Caption = "Music"
            Me.ButtonItemMusic.Id = 107
            Me.ButtonItemMusic.ImageOptions.Image = Global.My.Resources.Resources.MusicSmall
            Me.ButtonItemMusic.Name = "ButtonItemMusic"
            Me.ButtonItemMusic.SuperTip = SuperToolTip1
            '
            'ButtonItemVideos
            '
            Me.ButtonItemVideos.Caption = "Videos"
            Me.ButtonItemVideos.Id = 108
            Me.ButtonItemVideos.ImageOptions.Image = Global.My.Resources.Resources.VideosSmall
            Me.ButtonItemVideos.Name = "ButtonItemVideos"
            Me.ButtonItemVideos.SuperTip = SuperToolTip1
            '
            'ButtonItemPictures
            '
            Me.ButtonItemPictures.Caption = "Pictures"
            Me.ButtonItemPictures.Id = 109
            Me.ButtonItemPictures.ImageOptions.Image = Global.My.Resources.Resources.Large
            Me.ButtonItemPictures.Name = "ButtonItemPictures"
            Me.ButtonItemPictures.SuperTip = SuperToolTip1
            '
            'ButtonItemChooseLocation
            '
            Me.ButtonItemChooseLocation.Caption = "Choose location..."
            Me.ButtonItemChooseLocation.Id = 110
            Me.ButtonItemChooseLocation.Name = "ButtonItemChooseLocation"
            '
            'ButtonItemCopyTo
            '
            Me.ButtonItemCopyTo.Caption = "Copy to"
            Me.ButtonItemCopyTo.Enabled = False
            Me.ButtonItemCopyTo.Id = 44
            Me.ButtonItemCopyTo.ImageOptions.Image = Global.My.Resources.Resources.CopyToLarge
            Me.ButtonItemCopyTo.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.ButtonItemDocuments), New DevExpress.XtraBars.LinkPersistInfo(Me.ButtonItemMusic), New DevExpress.XtraBars.LinkPersistInfo(Me.ButtonItemVideos), New DevExpress.XtraBars.LinkPersistInfo(Me.ButtonItemPictures), New DevExpress.XtraBars.LinkPersistInfo(Me.ButtonItemChooseLocation, True)})
            Me.ButtonItemCopyTo.Name = "ButtonItemCopyTo"
            Me.ButtonItemCopyTo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            '
            'ButtonItemRename
            '
            Me.ButtonItemRename.Caption = "Rename"
            Me.ButtonItemRename.Id = 46
            Me.ButtonItemRename.ImageOptions.LargeImage = Global.My.Resources.Resources.RenameLarge
            Me.ButtonItemRename.Name = "ButtonItemRename"
            Me.ButtonItemRename.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            Me.ButtonItemRename.SuperTip = SuperToolTip1
            '
            'ButtonItemNewFolder
            '
            Me.ButtonItemNewFolder.Caption = "New folder"
            Me.ButtonItemNewFolder.Id = 47
            Me.ButtonItemNewFolder.ImageOptions.Image = Global.My.Resources.Resources.NewFolderSmall
            Me.ButtonItemNewFolder.Name = "ButtonItemNewFolder"
            Me.ButtonItemNewFolder.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            Me.ButtonItemNewFolder.SuperTip = SuperToolTip1
            '
            'ButtonItemNewItem
            '
            Me.ButtonItemNewItem.Caption = "New item"
            Me.ButtonItemNewItem.Id = 48
            Me.ButtonItemNewItem.ImageOptions.Image = Global.My.Resources.Resources.NewItemSmall
            Me.ButtonItemNewItem.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.ButtonItemNewFolder), New DevExpress.XtraBars.LinkPersistInfo(Me.ButtonItemNewShortcut), New DevExpress.XtraBars.LinkPersistInfo(Me.ButtonItemNewBitmapImage), New DevExpress.XtraBars.LinkPersistInfo(Me.ButtonItemNewContact), New DevExpress.XtraBars.LinkPersistInfo(Me.ButtonItemNewJournalDocument), New DevExpress.XtraBars.LinkPersistInfo(Me.ButtonItemNewRichTextDocument), New DevExpress.XtraBars.LinkPersistInfo(Me.ButtonItemNewTextDocument), New DevExpress.XtraBars.LinkPersistInfo(Me.ButtonItemCompressedFolder)})
            Me.ButtonItemNewItem.Name = "ButtonItemNewItem"
            '
            'ButtonItemNewShortcut
            '
            Me.ButtonItemNewShortcut.Caption = "Shortcut"
            Me.ButtonItemNewShortcut.Id = 120
            Me.ButtonItemNewShortcut.Name = "ButtonItemNewShortcut"
            Me.ButtonItemNewShortcut.SuperTip = SuperToolTip1
            '
            'ButtonItemNewBitmapImage
            '
            Me.ButtonItemNewBitmapImage.Caption = "Bitmap image"
            Me.ButtonItemNewBitmapImage.Id = 121
            Me.ButtonItemNewBitmapImage.Name = "ButtonItemNewBitmapImage"
            Me.ButtonItemNewBitmapImage.SuperTip = SuperToolTip1
            '
            'ButtonItemNewContact
            '
            Me.ButtonItemNewContact.Caption = "Contact"
            Me.ButtonItemNewContact.Id = 122
            Me.ButtonItemNewContact.Name = "ButtonItemNewContact"
            Me.ButtonItemNewContact.SuperTip = SuperToolTip1
            '
            'ButtonItemNewJournalDocument
            '
            Me.ButtonItemNewJournalDocument.Caption = "Journal document"
            Me.ButtonItemNewJournalDocument.Id = 123
            Me.ButtonItemNewJournalDocument.Name = "ButtonItemNewJournalDocument"
            Me.ButtonItemNewJournalDocument.SuperTip = SuperToolTip1
            '
            'ButtonItemNewRichTextDocument
            '
            Me.ButtonItemNewRichTextDocument.Caption = "Rich text document"
            Me.ButtonItemNewRichTextDocument.Id = 124
            Me.ButtonItemNewRichTextDocument.Name = "ButtonItemNewRichTextDocument"
            Me.ButtonItemNewRichTextDocument.SuperTip = SuperToolTip1
            '
            'ButtonItemNewTextDocument
            '
            Me.ButtonItemNewTextDocument.Caption = "Text document"
            Me.ButtonItemNewTextDocument.Id = 125
            Me.ButtonItemNewTextDocument.Name = "ButtonItemNewTextDocument"
            Me.ButtonItemNewTextDocument.SuperTip = SuperToolTip1
            '
            'ButtonItemCompressedFolder
            '
            Me.ButtonItemCompressedFolder.Caption = "Compressed (zipped) folder"
            Me.ButtonItemCompressedFolder.Id = 126
            Me.ButtonItemCompressedFolder.Name = "ButtonItemCompressedFolder"
            Me.ButtonItemCompressedFolder.SuperTip = SuperToolTip1
            '
            'ButtonItemEdit
            '
            Me.ButtonItemEdit.Caption = "Edit"
            Me.ButtonItemEdit.Id = 52
            Me.ButtonItemEdit.ImageOptions.Image = Global.My.Resources.Resources.EditSmall
            Me.ButtonItemEdit.Name = "ButtonItemEdit"
            Me.ButtonItemEdit.SuperTip = SuperToolTip1
            '
            'ButtonItemSelectAll
            '
            Me.ButtonItemSelectAll.Caption = "Select all"
            Me.ButtonItemSelectAll.Id = 54
            Me.ButtonItemSelectAll.ImageOptions.Image = Global.My.Resources.Resources.SelectedAllSmall
            Me.ButtonItemSelectAll.Name = "ButtonItemSelectAll"
            '
            'btnSelectNone
            '
            Me.btnSelectNone.Caption = "Select none"
            Me.btnSelectNone.Id = 55
            Me.btnSelectNone.ImageOptions.Image = Global.My.Resources.Resources.SelectedNoneSmall
            Me.btnSelectNone.Name = "btnSelectNone"
            '
            'ButtonItemInvertSelection
            '
            Me.ButtonItemInvertSelection.Caption = "Invert selection"
            Me.ButtonItemInvertSelection.Id = 56
            Me.ButtonItemInvertSelection.ImageOptions.Image = Global.My.Resources.Resources.InvertSelectionSmall
            Me.ButtonItemInvertSelection.Name = "ButtonItemInvertSelection"
            '
            'ButtonItemPropertiesFolder
            '
            Me.ButtonItemPropertiesFolder.Caption = "Properties"
            Me.ButtonItemPropertiesFolder.Id = 97
            Me.ButtonItemPropertiesFolder.Name = "ButtonItemPropertiesFolder"
            '
            'ButtonItemRemoveProperties
            '
            Me.ButtonItemRemoveProperties.Caption = "Remove properties"
            Me.ButtonItemRemoveProperties.Enabled = False
            Me.ButtonItemRemoveProperties.Id = 98
            Me.ButtonItemRemoveProperties.Name = "ButtonItemRemoveProperties"
            '
            'ButtonItemDelete
            '
            Me.ButtonItemDelete.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.ButtonItemDelete.Caption = "Delete"
            Me.ButtonItemDelete.DropDownControl = Me.PopupMenuDeleteButton
            Me.ButtonItemDelete.Id = 99
            Me.ButtonItemDelete.ImageOptions.LargeImage = Global.My.Resources.Resources.DeleteLarge
            Me.ButtonItemDelete.Name = "ButtonItemDelete"
            Me.ButtonItemDelete.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            Me.ButtonItemDelete.SuperTip = SuperToolTip1
            '
            'PopupMenuDeleteButton
            '
            Me.PopupMenuDeleteButton.ItemLinks.Add(Me.ButtonItemRecycle)
            Me.PopupMenuDeleteButton.ItemLinks.Add(Me.ButtonItemPermanentlyDelete)
            Me.PopupMenuDeleteButton.ItemLinks.Add(Me.ButtonItemShowRecycleConfirmation, True)
            Me.PopupMenuDeleteButton.Name = "PopupMenuDeleteButton"
            Me.PopupMenuDeleteButton.Ribbon = Me.RibbonControl
            '
            'ButtonItemRecycle
            '
            Me.ButtonItemRecycle.Caption = "Recycle"
            Me.ButtonItemRecycle.Id = 100
            Me.ButtonItemRecycle.Name = "ButtonItemRecycle"
            '
            'ButtonItemPermanentlyDelete
            '
            Me.ButtonItemPermanentlyDelete.Caption = "Peramnently delete"
            Me.ButtonItemPermanentlyDelete.Id = 101
            Me.ButtonItemPermanentlyDelete.Name = "ButtonItemPermanentlyDelete"
            '
            'ButtonItemShowRecycleConfirmation
            '
            Me.ButtonItemShowRecycleConfirmation.Caption = "Show recycle confirmation"
            Me.ButtonItemShowRecycleConfirmation.Id = 103
            Me.ButtonItemShowRecycleConfirmation.Name = "ButtonItemShowRecycleConfirmation"
            '
            'ButtonItemProperties
            '
            Me.ButtonItemProperties.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.ButtonItemProperties.Caption = "Properties"
            Me.ButtonItemProperties.DropDownControl = Me.PopupMenuPropertiesButton
            Me.ButtonItemProperties.Id = 104
            Me.ButtonItemProperties.ImageOptions.LargeImage = Global.My.Resources.Resources.PropertiesLarge
            Me.ButtonItemProperties.Name = "ButtonItemProperties"
            Me.ButtonItemProperties.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            '
            'PopupMenuPropertiesButton
            '
            Me.PopupMenuPropertiesButton.ItemLinks.Add(Me.ButtonItemPropertiesFolder)
            Me.PopupMenuPropertiesButton.ItemLinks.Add(Me.ButtonItemRemoveProperties, True)
            Me.PopupMenuPropertiesButton.Name = "PopupMenuPropertiesButton"
            Me.PopupMenuPropertiesButton.Ribbon = Me.RibbonControl
            '
            'btnOpen
            '
            Me.btnOpen.Caption = "Open"
            Me.btnOpen.Enabled = False
            Me.btnOpen.Id = 134
            Me.btnOpen.ImageOptions.Image = Global.My.Resources.Resources.OpenSmall
            Me.btnOpen.Name = "btnOpen"
            '
            'ButtonItemOptions
            '
            Me.ButtonItemOptions.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.ButtonItemOptions.Caption = "Options"
            Me.ButtonItemOptions.DropDownControl = Me.PopupMenuOptionsButton
            Me.ButtonItemOptions.Id = 135
            Me.ButtonItemOptions.ImageOptions.Image = Global.My.Resources.Resources.OptionsLarge
            Me.ButtonItemOptions.Name = "ButtonItemOptions"
            Me.ButtonItemOptions.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            '
            'PopupMenuOptionsButton
            '
            Me.PopupMenuOptionsButton.ItemLinks.Add(Me.ButtonItemChangeFilderOptions)
            Me.PopupMenuOptionsButton.Name = "PopupMenuOptionsButton"
            Me.PopupMenuOptionsButton.Ribbon = Me.RibbonControl
            '
            'ButtonItemChangeFilderOptions
            '
            Me.ButtonItemChangeFilderOptions.Caption = "Change folder and search options"
            Me.ButtonItemChangeFilderOptions.Id = 136
            Me.ButtonItemChangeFilderOptions.Name = "ButtonItemChangeFilderOptions"
            '
            'rgbiViewStyle
            '
            Me.rgbiViewStyle.Caption = "View"
            '
            '
            '
            Me.rgbiViewStyle.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseFont = True
            Me.rgbiViewStyle.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = True
            Me.rgbiViewStyle.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.rgbiViewStyle.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.rgbiViewStyle.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = True
            Me.rgbiViewStyle.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = True
            Me.rgbiViewStyle.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.rgbiViewStyle.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.rgbiViewStyle.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseFont = True
            Me.rgbiViewStyle.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = True
            Me.rgbiViewStyle.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.rgbiViewStyle.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.rgbiViewStyle.Gallery.ColumnCount = 3
            Me.rgbiViewStyle.Gallery.DrawImageBackground = False
            GalleryItemGroup1.Caption = "ViewStyleGroup"
            GalleryItem1.Caption = "Extra large view"
            GalleryItem1.Image = Global.My.Resources.Resources.ExtraLarge
            GalleryItem1.Tag = 1
            GalleryItem2.Caption = "Large icons"
            GalleryItem2.Checked = True
            GalleryItem2.Image = Global.My.Resources.Resources.Large
            GalleryItem2.Tag = 2
            GalleryItem3.Caption = "Medium icons"
            GalleryItem3.Image = Global.My.Resources.Resources.Medium
            GalleryItem3.Tag = 3
            GalleryItem4.Caption = "Small icons"
            GalleryItem4.Image = Global.My.Resources.Resources.Small
            GalleryItem4.Tag = 4
            GalleryItem5.Caption = "List"
            GalleryItem5.Image = Global.My.Resources.Resources.List
            GalleryItem5.Tag = 6
            GalleryItem6.Caption = "Tiles"
            GalleryItem6.Image = Global.My.Resources.Resources.Tiles
            GalleryItem6.Tag = 5
            GalleryItem7.Caption = "Content"
            GalleryItem7.Image = Global.My.Resources.Resources.Content
            GalleryItem7.Tag = 7
            GalleryItemGroup1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {GalleryItem1, GalleryItem2, GalleryItem3, GalleryItem4, GalleryItem5, GalleryItem6, GalleryItem7})
            Me.rgbiViewStyle.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {GalleryItemGroup1})
            Me.rgbiViewStyle.Gallery.ImageSize = New System.Drawing.Size(18, 18)
            Me.rgbiViewStyle.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleRadio
            Me.rgbiViewStyle.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            SkinPaddingEdges1.Bottom = -3
            SkinPaddingEdges1.Top = -3
            Me.rgbiViewStyle.Gallery.ItemImagePadding = SkinPaddingEdges1
            SkinPaddingEdges2.Bottom = -1
            SkinPaddingEdges2.Top = -1
            Me.rgbiViewStyle.Gallery.ItemTextPadding = SkinPaddingEdges2
            Me.rgbiViewStyle.Gallery.ShowItemText = True
            Me.rgbiViewStyle.Id = 141
            Me.rgbiViewStyle.Name = "rgbiViewStyle"
            '
            'ContextItemOpen
            '
            Me.ContextItemOpen.Caption = "Open"
            Me.ContextItemOpen.Id = 151
            Me.ContextItemOpen.ItemAppearance.Disabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.ContextItemOpen.ItemAppearance.Disabled.Options.UseFont = True
            Me.ContextItemOpen.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.ContextItemOpen.ItemAppearance.Hovered.Options.UseFont = True
            Me.ContextItemOpen.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.ContextItemOpen.ItemAppearance.Normal.Options.UseFont = True
            Me.ContextItemOpen.ItemAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.ContextItemOpen.ItemAppearance.Pressed.Options.UseFont = True
            Me.ContextItemOpen.Name = "ContextItemOpen"
            '
            'ContextItemCut
            '
            Me.ContextItemCut.Caption = "Cut"
            Me.ContextItemCut.Id = 158
            Me.ContextItemCut.Name = "ContextItemCut"
            Me.ContextItemCut.SuperTip = SuperToolTip1
            '
            'ContextItemCopy
            '
            Me.ContextItemCopy.Caption = "Copy"
            Me.ContextItemCopy.Id = 159
            Me.ContextItemCopy.Name = "ContextItemCopy"
            Me.ContextItemCopy.SuperTip = SuperToolTip1
            '
            'ContextItemPaste
            '
            Me.ContextItemPaste.Caption = "Paste"
            Me.ContextItemPaste.Id = 160
            Me.ContextItemPaste.Name = "ContextItemPaste"
            Me.ContextItemPaste.SuperTip = SuperToolTip1
            '
            'ContextItemDelete
            '
            Me.ContextItemDelete.Caption = "Delete"
            Me.ContextItemDelete.Id = 162
            Me.ContextItemDelete.Name = "ContextItemDelete"
            Me.ContextItemDelete.SuperTip = SuperToolTip1
            '
            'ContextItemRename
            '
            Me.ContextItemRename.Caption = "Rename"
            Me.ContextItemRename.Id = 163
            Me.ContextItemRename.Name = "ContextItemRename"
            '
            'ContextItemProperties
            '
            Me.ContextItemProperties.Caption = "Properties"
            Me.ContextItemProperties.Id = 164
            Me.ContextItemProperties.Name = "ContextItemProperties"
            '
            'PageHome
            '
            Me.PageHome.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.PageGroupClipboard, Me.PageGroupOrganize, Me.PageGroupNew, Me.PageGroupOpen, Me.PageGroupSelect})
            Me.PageHome.Name = "PageHome"
            Me.PageHome.Text = "Home"
            '
            'PageGroupClipboard
            '
            Me.PageGroupClipboard.ItemLinks.Add(Me.ButtonItemCopy)
            Me.PageGroupClipboard.ItemLinks.Add(Me.ButtonItemPaste)
            Me.PageGroupClipboard.ItemLinks.Add(Me.ButtonItemCut)
            Me.PageGroupClipboard.ItemLinks.Add(Me.btnCopyItem)
            Me.PageGroupClipboard.Name = "PageGroupClipboard"
            Me.PageGroupClipboard.ShowCaptionButton = False
            Me.PageGroupClipboard.Text = "Clipboard"
            '
            'PageGroupOrganize
            '
            Me.PageGroupOrganize.ItemLinks.Add(Me.ButtonItemMoveTo)
            Me.PageGroupOrganize.ItemLinks.Add(Me.ButtonItemCopyTo)
            Me.PageGroupOrganize.ItemLinks.Add(Me.ButtonItemDelete, True)
            Me.PageGroupOrganize.ItemLinks.Add(Me.ButtonItemRename)
            Me.PageGroupOrganize.Name = "PageGroupOrganize"
            Me.PageGroupOrganize.ShowCaptionButton = False
            Me.PageGroupOrganize.Text = "Organize"
            '
            'PageGroupNew
            '
            Me.PageGroupNew.ItemLinks.Add(Me.ButtonItemNewFolder)
            Me.PageGroupNew.ItemLinks.Add(Me.ButtonItemNewItem)
            Me.PageGroupNew.Name = "PageGroupNew"
            Me.PageGroupNew.ShowCaptionButton = False
            Me.PageGroupNew.Text = "New"
            '
            'PageGroupOpen
            '
            Me.PageGroupOpen.ItemLinks.Add(Me.ButtonItemProperties)
            Me.PageGroupOpen.ItemLinks.Add(Me.btnOpen)
            Me.PageGroupOpen.ItemLinks.Add(Me.ButtonItemEdit)
            Me.PageGroupOpen.Name = "PageGroupOpen"
            Me.PageGroupOpen.ShowCaptionButton = False
            Me.PageGroupOpen.Text = "Open"
            '
            'PageGroupSelect
            '
            Me.PageGroupSelect.ItemLinks.Add(Me.ButtonItemSelectAll)
            Me.PageGroupSelect.ItemLinks.Add(Me.btnSelectNone)
            Me.PageGroupSelect.ItemLinks.Add(Me.ButtonItemInvertSelection)
            Me.PageGroupSelect.Name = "PageGroupSelect"
            Me.PageGroupSelect.ShowCaptionButton = False
            Me.PageGroupSelect.Text = "Select"
            '
            'PageView
            '
            Me.PageView.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.PageGroupViewPanes, Me.PageGroupViewLayouts, Me.PageGroupViewShowHide, Me.PageGroupViewEmpty})
            Me.PageView.Name = "PageView"
            Me.PageView.Text = "View"
            '
            'PageGroupViewPanes
            '
            Me.PageGroupViewPanes.ItemLinks.Add(Me.ButtonItemNavigationPane)
            Me.PageGroupViewPanes.Name = "PageGroupViewPanes"
            Me.PageGroupViewPanes.ShowCaptionButton = False
            Me.PageGroupViewPanes.Text = "Panes"
            '
            'PageGroupViewLayouts
            '
            Me.PageGroupViewLayouts.ItemLinks.Add(Me.rgbiViewStyle)
            Me.PageGroupViewLayouts.Name = "PageGroupViewLayouts"
            Me.PageGroupViewLayouts.ShowCaptionButton = False
            Me.PageGroupViewLayouts.Text = "Layouts"
            '
            'PageGroupViewShowHide
            '
            Me.PageGroupViewShowHide.ItemLinks.Add(Me.ButtonItemItemCheckBoxes)
            Me.PageGroupViewShowHide.ItemLinks.Add(Me.ButtonItemFileNameExtensions)
            Me.PageGroupViewShowHide.ItemLinks.Add(Me.ButtonItemHiddenItems)
            Me.PageGroupViewShowHide.ItemLinks.Add(Me.btnHideSelectedItems)
            Me.PageGroupViewShowHide.Name = "PageGroupViewShowHide"
            Me.PageGroupViewShowHide.ShowCaptionButton = False
            Me.PageGroupViewShowHide.Text = "Show/Hide"
            '
            'PageGroupViewEmpty
            '
            Me.PageGroupViewEmpty.ItemLinks.Add(Me.ButtonItemOptions)
            Me.PageGroupViewEmpty.Name = "PageGroupViewEmpty"
            Me.PageGroupViewEmpty.ShowCaptionButton = False
            '
            'repositoryItemTextEdit1
            '
            Me.repositoryItemTextEdit1.AutoHeight = False
            Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
            '
            'repositoryItemRadioGroup1
            '
            Me.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1"
            '
            'repositoryItemTextEdit2
            '
            Me.repositoryItemTextEdit2.AutoHeight = False
            Me.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2"
            '
            'navBar
            '
            Me.navBar.ActiveGroup = Me.groupFavorites
            Me.navBar.Appearance.GroupHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.navBar.Appearance.GroupHeader.Options.UseFont = True
            Me.navBar.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.navBar.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None
            Me.navBar.ExplorerBarGroupOuterIndent = 10
            Me.navBar.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.groupFavorites, Me.groupLibraries})
            Me.navBar.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.navPanelItemDesktop, Me.navPanelItemDownloads, Me.navPanelItemRecent, Me.navPanelItemDocuments, Me.navPanelItemMusic, Me.navPanelItemPictures, Me.navPanelItemVideos})
            Me.navBar.LinkInterval = 0
            Me.navBar.LinkSelectionMode = DevExpress.XtraNavBar.LinkSelectionModeType.OneInControl
            Me.navBar.Location = New System.Drawing.Point(919, 2)
            Me.navBar.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
            Me.navBar.Name = "navBar"
            Me.navBar.OptionsNavPane.ExpandedWidth = 291
            Me.navBar.Size = New System.Drawing.Size(291, 538)
            Me.navBar.TabIndex = 1
            Me.navBar.Text = "navigationPanel"
            '
            'groupFavorites
            '
            Me.groupFavorites.Caption = "Favorites"
            Me.groupFavorites.Expanded = True
            Me.groupFavorites.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.navPanelItemDesktop), New DevExpress.XtraNavBar.NavBarItemLink(Me.navPanelItemDownloads), New DevExpress.XtraNavBar.NavBarItemLink(Me.navPanelItemRecent)})
            Me.groupFavorites.Name = "groupFavorites"
            Me.groupFavorites.SmallImage = Global.My.Resources.Resources.FavoritesSmall
            '
            'navPanelItemDesktop
            '
            Me.navPanelItemDesktop.Caption = "Desktop"
            Me.navPanelItemDesktop.Name = "navPanelItemDesktop"
            Me.navPanelItemDesktop.SmallImage = Global.My.Resources.Resources.DesktopSmall
            '
            'navPanelItemDownloads
            '
            Me.navPanelItemDownloads.Caption = "Downloads"
            Me.navPanelItemDownloads.Name = "navPanelItemDownloads"
            Me.navPanelItemDownloads.SmallImage = Global.My.Resources.Resources.DownloadsSmall
            '
            'navPanelItemRecent
            '
            Me.navPanelItemRecent.Caption = "Recent places"
            Me.navPanelItemRecent.Name = "navPanelItemRecent"
            Me.navPanelItemRecent.SmallImage = Global.My.Resources.Resources.RecentPlacesSmall
            '
            'groupLibraries
            '
            Me.groupLibraries.Caption = "Libraries"
            Me.groupLibraries.Expanded = True
            Me.groupLibraries.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.navPanelItemDocuments), New DevExpress.XtraNavBar.NavBarItemLink(Me.navPanelItemMusic), New DevExpress.XtraNavBar.NavBarItemLink(Me.navPanelItemPictures), New DevExpress.XtraNavBar.NavBarItemLink(Me.navPanelItemVideos)})
            Me.groupLibraries.Name = "groupLibraries"
            Me.groupLibraries.SmallImage = Global.My.Resources.Resources.LibrarySmall
            '
            'navPanelItemDocuments
            '
            Me.navPanelItemDocuments.Caption = "Documents"
            Me.navPanelItemDocuments.Name = "navPanelItemDocuments"
            Me.navPanelItemDocuments.SmallImage = Global.My.Resources.Resources.DocumentsSmall
            '
            'navPanelItemMusic
            '
            Me.navPanelItemMusic.Caption = "Music"
            Me.navPanelItemMusic.Name = "navPanelItemMusic"
            Me.navPanelItemMusic.SmallImage = Global.My.Resources.Resources.MusicSmall
            '
            'navPanelItemPictures
            '
            Me.navPanelItemPictures.Caption = "Pictures"
            Me.navPanelItemPictures.Name = "navPanelItemPictures"
            Me.navPanelItemPictures.SmallImage = Global.My.Resources.Resources.Large
            '
            'navPanelItemVideos
            '
            Me.navPanelItemVideos.Caption = "Videos"
            Me.navPanelItemVideos.Name = "navPanelItemVideos"
            Me.navPanelItemVideos.SmallImage = Global.My.Resources.Resources.VideosSmall
            '
            'navigationPanel
            '
            Me.navigationPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.navigationPanel.Controls.Add(Me.btnNavigationHistory)
            Me.navigationPanel.Controls.Add(Me.btnUpTo)
            Me.navigationPanel.Controls.Add(Me.btnForward)
            Me.navigationPanel.Controls.Add(Me.btnBack)
            Me.navigationPanel.Controls.Add(Me.EditSearch)
            Me.navigationPanel.Controls.Add(Me.editBreadCrumb)
            Me.navigationPanel.Location = New System.Drawing.Point(0, 145)
            Me.navigationPanel.Margin = New System.Windows.Forms.Padding(0)
            Me.navigationPanel.Name = "navigationPanel"
            Me.navigationPanel.Size = New System.Drawing.Size(1216, 34)
            Me.navigationPanel.TabIndex = 3
            '
            'btnNavigationHistory
            '
            Me.btnNavigationHistory.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
            Me.btnNavigationHistory.Appearance.ImageIndex = 2
            Me.btnNavigationHistory.Appearance.ImageList = Me.imgs
            Me.btnNavigationHistory.Appearance.Options.UseImageIndex = True
            Me.btnNavigationHistory.Appearance.Options.UseImageList = True
            Me.btnNavigationHistory.AppearanceHovered.ImageIndex = 1
            Me.btnNavigationHistory.AppearanceHovered.Options.UseImageIndex = True
            Me.btnNavigationHistory.AppearancePressed.ImageIndex = 3
            Me.btnNavigationHistory.AppearancePressed.Options.UseImageIndex = True
            Me.btnNavigationHistory.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.btnNavigationHistory.Location = New System.Drawing.Point(60, 8)
            Me.btnNavigationHistory.Name = "btnNavigationHistory"
            Me.btnNavigationHistory.Size = New System.Drawing.Size(16, 18)
            Me.btnNavigationHistory.TabIndex = 8
            '
            'btnUpTo
            '
            Me.btnUpTo.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
            Me.btnUpTo.Appearance.ImageIndex = 5
            Me.btnUpTo.Appearance.ImageList = Me.imgArrows
            Me.btnUpTo.Appearance.Options.UseImageIndex = True
            Me.btnUpTo.Appearance.Options.UseImageList = True
            Me.btnUpTo.AppearanceHovered.ImageIndex = 2
            Me.btnUpTo.AppearanceHovered.Options.UseImageIndex = True
            Me.btnUpTo.AppearancePressed.ImageIndex = 8
            Me.btnUpTo.AppearancePressed.Options.UseImageIndex = True
            Me.btnUpTo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.btnUpTo.Location = New System.Drawing.Point(76, 5)
            Me.btnUpTo.Name = "btnUpTo"
            Me.btnUpTo.Size = New System.Drawing.Size(24, 24)
            Me.btnUpTo.TabIndex = 7
            '
            'imgArrows
            '
            Me.imgArrows.ImageSize = New System.Drawing.Size(24, 24)
            Me.imgArrows.ImageStream = CType(resources.GetObject("imgArrows.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
            Me.imgArrows.Images.SetKeyName(0, "hoverBack.png")
            Me.imgArrows.Images.SetKeyName(1, "hoverNext.png")
            Me.imgArrows.Images.SetKeyName(2, "hoverUp.png")
            Me.imgArrows.Images.SetKeyName(3, "normalBack.png")
            Me.imgArrows.Images.SetKeyName(4, "normalNext.png")
            Me.imgArrows.Images.SetKeyName(5, "normalUp.png")
            Me.imgArrows.Images.SetKeyName(6, "pressedBack.png")
            Me.imgArrows.Images.SetKeyName(7, "pressedNext.png")
            Me.imgArrows.Images.SetKeyName(8, "pressedUp.png")
            '
            'btnForward
            '
            Me.btnForward.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
            Me.btnForward.Appearance.ImageIndex = 4
            Me.btnForward.Appearance.ImageList = Me.imgArrows
            Me.btnForward.Appearance.Options.UseImageIndex = True
            Me.btnForward.Appearance.Options.UseImageList = True
            Me.btnForward.AppearanceHovered.ImageIndex = 1
            Me.btnForward.AppearanceHovered.Options.UseImageIndex = True
            Me.btnForward.AppearancePressed.ImageIndex = 7
            Me.btnForward.AppearancePressed.Options.UseImageIndex = True
            Me.btnForward.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.btnForward.Location = New System.Drawing.Point(36, 8)
            Me.btnForward.Name = "btnForward"
            Me.btnForward.Size = New System.Drawing.Size(18, 18)
            Me.btnForward.TabIndex = 6
            '
            'btnBack
            '
            Me.btnBack.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
            Me.btnBack.Appearance.ImageIndex = 3
            Me.btnBack.Appearance.ImageList = Me.imgArrows
            Me.btnBack.Appearance.Options.UseImageIndex = True
            Me.btnBack.Appearance.Options.UseImageList = True
            Me.btnBack.AppearanceHovered.ImageIndex = 0
            Me.btnBack.AppearanceHovered.Options.UseImageIndex = True
            Me.btnBack.AppearancePressed.ImageIndex = 6
            Me.btnBack.AppearancePressed.Options.UseImageIndex = True
            Me.btnBack.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.btnBack.Location = New System.Drawing.Point(7, 8)
            Me.btnBack.Name = "btnBack"
            Me.btnBack.Size = New System.Drawing.Size(18, 18)
            Me.btnBack.TabIndex = 5
            '
            'EditSearch
            '
            Me.EditSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.EditSearch.Location = New System.Drawing.Point(941, 5)
            Me.EditSearch.MenuManager = Me.RibbonControl
            Me.EditSearch.Name = "EditSearch"
            Me.EditSearch.Properties.AutoHeight = False
            Me.EditSearch.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("EditSearch.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
            Me.EditSearch.Size = New System.Drawing.Size(263, 24)
            Me.EditSearch.TabIndex = 4
            '
            'editBreadCrumb
            '
            Me.editBreadCrumb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.editBreadCrumb.Location = New System.Drawing.Point(106, 5)
            Me.editBreadCrumb.MenuManager = Me.RibbonControl
            Me.editBreadCrumb.Name = "editBreadCrumb"
            Me.editBreadCrumb.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.SpinDown, "", 18, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo, "", 15, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing, True)})
            Me.editBreadCrumb.Properties.DropDownRows = 12
            Me.editBreadCrumb.Properties.ImageIndex = 0
            Me.editBreadCrumb.Properties.Images = Me.imgs
            BreadCrumbNode1.Caption = "Root"
            BreadCrumbNode1.Persistent = True
            BreadCrumbNode1.PopulateOnDemand = True
            BreadCrumbNode1.ShowCaption = False
            BreadCrumbNode1.Value = "Root"
            BreadCrumbNode2.Caption = "Computer"
            BreadCrumbNode2.Persistent = True
            BreadCrumbNode2.PopulateOnDemand = True
            BreadCrumbNode2.Value = "Computer"
            Me.editBreadCrumb.Properties.Nodes.AddRange(New DevExpress.XtraEditors.BreadCrumbNode() {BreadCrumbNode1, BreadCrumbNode2})
            Me.editBreadCrumb.Properties.RootImageIndex = 0
            Me.editBreadCrumb.Properties.SortNodesByCaption = True
            Me.editBreadCrumb.Size = New System.Drawing.Size(828, 22)
            Me.editBreadCrumb.TabIndex = 3
            '
            'contentPanel
            '
            Me.contentPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.contentPanel.Controls.Add(Me.LayoutControl)
            Me.contentPanel.Location = New System.Drawing.Point(0, 179)
            Me.contentPanel.Margin = New System.Windows.Forms.Padding(0)
            Me.contentPanel.Name = "contentPanel"
            Me.contentPanel.Size = New System.Drawing.Size(1216, 546)
            Me.contentPanel.TabIndex = 5
            '
            'LayoutControl
            '
            Me.LayoutControl.Controls.Add(Me.gridControl)
            Me.LayoutControl.Controls.Add(Me.navBar)
            Me.LayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LayoutControl.Location = New System.Drawing.Point(2, 2)
            Me.LayoutControl.Name = "LayoutControl"
            Me.LayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(318, 324, 836, 529)
            Me.LayoutControl.Root = Me.LayoutControlMainGroup
            Me.LayoutControl.Size = New System.Drawing.Size(1212, 542)
            Me.LayoutControl.TabIndex = 3
            Me.LayoutControl.Text = "LayoutControl"
            '
            'gridControl
            '
            Me.gridControl.Location = New System.Drawing.Point(2, 2)
            Me.gridControl.MainView = Me.winExplorerView
            Me.gridControl.MenuManager = Me.RibbonControl
            Me.gridControl.Name = "gridControl"
            Me.gridControl.Size = New System.Drawing.Size(908, 538)
            Me.gridControl.TabIndex = 2
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.winExplorerView})
            '
            'winExplorerView
            '
            Me.winExplorerView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.winExplorerView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.columnName, Me.columnPath, Me.columnCheck, Me.columnGroup, Me.columnImage})
            Me.winExplorerView.ColumnSet.CheckBoxColumn = Me.columnCheck
            Me.winExplorerView.ColumnSet.DescriptionColumn = Me.columnPath
            Me.winExplorerView.ColumnSet.ExtraLargeImageColumn = Me.columnImage
            Me.winExplorerView.ColumnSet.GroupColumn = Me.columnGroup
            Me.winExplorerView.ColumnSet.LargeImageColumn = Me.columnImage
            Me.winExplorerView.ColumnSet.MediumImageColumn = Me.columnImage
            Me.winExplorerView.ColumnSet.SmallImageColumn = Me.columnImage
            Me.winExplorerView.ColumnSet.TextColumn = Me.columnName
            Me.winExplorerView.GridControl = Me.gridControl
            Me.winExplorerView.GroupCount = 1
            Me.winExplorerView.Name = "winExplorerView"
            Me.winExplorerView.OptionsBehavior.Editable = False
            Me.winExplorerView.OptionsSelection.AllowMarqueeSelection = True
            Me.winExplorerView.OptionsSelection.ItemSelectionMode = DevExpress.XtraGrid.Views.WinExplorer.IconItemSelectionMode.Click
            Me.winExplorerView.OptionsSelection.MultiSelect = True
            Me.winExplorerView.OptionsView.ImageLayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.Stretch
            Me.winExplorerView.OptionsView.ShowViewCaption = True
            Me.winExplorerView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.columnGroup, DevExpress.Data.ColumnSortOrder.Ascending)})
            '
            'columnName
            '
            Me.columnName.Caption = "columnName"
            Me.columnName.FieldName = "Name"
            Me.columnName.Name = "columnName"
            Me.columnName.Visible = True
            Me.columnName.VisibleIndex = 0
            '
            'columnPath
            '
            Me.columnPath.Caption = "columnPath"
            Me.columnPath.FieldName = "Path"
            Me.columnPath.Name = "columnPath"
            Me.columnPath.Visible = True
            Me.columnPath.VisibleIndex = 0
            '
            'columnCheck
            '
            Me.columnCheck.Caption = "columnCheck"
            Me.columnCheck.FieldName = "IsCheck"
            Me.columnCheck.Name = "columnCheck"
            Me.columnCheck.Visible = True
            Me.columnCheck.VisibleIndex = 0
            '
            'columnGroup
            '
            Me.columnGroup.Caption = "columnGroup"
            Me.columnGroup.FieldName = "Group"
            Me.columnGroup.Name = "columnGroup"
            Me.columnGroup.Visible = True
            Me.columnGroup.VisibleIndex = 0
            '
            'columnImage
            '
            Me.columnImage.Caption = "columnImage"
            Me.columnImage.FieldName = "Image"
            Me.columnImage.Name = "columnImage"
            Me.columnImage.Visible = True
            Me.columnImage.VisibleIndex = 0
            '
            'LayoutControlMainGroup
            '
            Me.LayoutControlMainGroup.CustomizationFormText = "Root"
            Me.LayoutControlMainGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.LayoutControlMainGroup.GroupBordersVisible = False
            Me.LayoutControlMainGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItemExplorerView, Me.SplitterItem1, Me.liNavPaneRight})
            Me.LayoutControlMainGroup.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlMainGroup.Name = "Root"
            Me.LayoutControlMainGroup.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 10, 10, 10)
            Me.LayoutControlMainGroup.Size = New System.Drawing.Size(1212, 542)
            Me.LayoutControlMainGroup.TextVisible = False
            '
            'LayoutControlItemExplorerView
            '
            Me.LayoutControlItemExplorerView.Control = Me.gridControl
            Me.LayoutControlItemExplorerView.CustomizationFormText = "LayoutControlItemExplorerView"
            Me.LayoutControlItemExplorerView.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItemExplorerView.Name = "LayoutControlItemExplorerView"
            Me.LayoutControlItemExplorerView.Size = New System.Drawing.Size(912, 542)
            Me.LayoutControlItemExplorerView.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItemExplorerView.TextVisible = False
            '
            'SplitterItem1
            '
            Me.SplitterItem1.AllowHotTrack = True
            Me.SplitterItem1.CustomizationFormText = "SplitterItem1"
            Me.SplitterItem1.Location = New System.Drawing.Point(912, 0)
            Me.SplitterItem1.Name = "SplitterItem1"
            Me.SplitterItem1.Size = New System.Drawing.Size(5, 542)
            '
            'liNavPaneRight
            '
            Me.liNavPaneRight.Control = Me.navBar
            Me.liNavPaneRight.CustomizationFormText = "LayoutControlItemNavigationPaneRight"
            Me.liNavPaneRight.Location = New System.Drawing.Point(917, 0)
            Me.liNavPaneRight.Name = "LayoutControlItemNavigationPaneRight"
            Me.liNavPaneRight.Size = New System.Drawing.Size(295, 542)
            Me.liNavPaneRight.TextSize = New System.Drawing.Size(0, 0)
            Me.liNavPaneRight.TextVisible = False
            '
            'itemPopupMenu
            '
            Me.itemPopupMenu.ItemLinks.Add(Me.ContextItemOpen)
            Me.itemPopupMenu.ItemLinks.Add(Me.ContextItemCut, True)
            Me.itemPopupMenu.ItemLinks.Add(Me.ContextItemCopy)
            Me.itemPopupMenu.ItemLinks.Add(Me.ContextItemPaste)
            Me.itemPopupMenu.ItemLinks.Add(Me.ContextItemDelete)
            Me.itemPopupMenu.ItemLinks.Add(Me.ContextItemRename)
            Me.itemPopupMenu.ItemLinks.Add(Me.ContextItemProperties, True)
            Me.itemPopupMenu.Name = "itemPopupMenu"
            Me.itemPopupMenu.Ribbon = Me.RibbonControl
            '
            'navigationMenu
            '
            Me.navigationMenu.Name = "navigationMenu"
            Me.navigationMenu.Ribbon = Me.RibbonControl
            '
            'ExplorerView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Appearance.Options.UseFont = True
            Me.Controls.Add(Me.contentPanel)
            Me.Controls.Add(Me.navigationPanel)
            Me.Controls.Add(Me.RibbonControl)
            Me.Name = "ExplorerView"
            Me.Size = New System.Drawing.Size(1216, 725)
            CType(Me.repositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.imgs, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenuDeleteButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenuPropertiesButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenuOptionsButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemRadioGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.navBar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.navigationPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPanel.ResumeLayout(False)
            CType(Me.imgArrows, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.EditSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.editBreadCrumb.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.contentPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.contentPanel.ResumeLayout(False)
            CType(Me.LayoutControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.LayoutControl.ResumeLayout(False)
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.winExplorerView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlMainGroup, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItemExplorerView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.liNavPaneRight, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.itemPopupMenu, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.navigationMenu, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
#End Region

        Private RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
        Private PageHome As DevExpress.XtraBars.Ribbon.RibbonPage
        Private PageView As DevExpress.XtraBars.Ribbon.RibbonPage
        Private PageGroupViewPanes As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Private PageGroupViewLayouts As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Private PageGroupViewShowHide As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Private PageGroupViewEmpty As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Private WithEvents ButtonItemHelp As DevExpress.XtraBars.BarButtonItem
        Private ButtonItemNavigationPane As DevExpress.XtraBars.BarSubItem
        Private WithEvents ButtonItemItemCheckBoxes As DevExpress.XtraBars.BarCheckItem
        Private WithEvents ButtonItemFileNameExtensions As DevExpress.XtraBars.BarCheckItem
        Private WithEvents ButtonItemHiddenItems As DevExpress.XtraBars.BarCheckItem
        Private btnHideSelectedItems As DevExpress.XtraBars.BarButtonItem
        Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Private WithEvents navBar As DevExpress.XtraNavBar.NavBarControl
        Private groupFavorites As DevExpress.XtraNavBar.NavBarGroup
        Private navPanelItemDesktop As DevExpress.XtraNavBar.NavBarItem
        Private navPanelItemDownloads As DevExpress.XtraNavBar.NavBarItem
        Private navPanelItemRecent As DevExpress.XtraNavBar.NavBarItem
        Private WithEvents ButtonCheckItemNavigationPane As DevExpress.XtraBars.BarCheckItem
        Private ButtonItemCopy As DevExpress.XtraBars.BarButtonItem
        Private ButtonItemPaste As DevExpress.XtraBars.BarButtonItem
        Private ButtonItemCut As DevExpress.XtraBars.BarButtonItem
        Private WithEvents btnCopyItem As DevExpress.XtraBars.BarButtonItem
        Private ButtonItemMoveTo As DevExpress.XtraBars.BarSubItem
        Private ButtonItemCopyTo As DevExpress.XtraBars.BarSubItem
        Private ButtonItemRename As DevExpress.XtraBars.BarButtonItem
        Private ButtonItemNewFolder As DevExpress.XtraBars.BarButtonItem
        Private ButtonItemNewItem As DevExpress.XtraBars.BarSubItem
        Private ButtonItemEdit As DevExpress.XtraBars.BarButtonItem
        Private WithEvents ButtonItemSelectAll As DevExpress.XtraBars.BarButtonItem
        Private WithEvents btnSelectNone As DevExpress.XtraBars.BarButtonItem
        Private WithEvents ButtonItemInvertSelection As DevExpress.XtraBars.BarButtonItem
        Private PageGroupClipboard As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Private PageGroupOrganize As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Private PageGroupNew As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Private PageGroupOpen As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Private PageGroupSelect As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Private navigationPanel As DevExpress.XtraEditors.PanelControl
        Private contentPanel As DevExpress.XtraEditors.PanelControl
        Private groupLibraries As DevExpress.XtraNavBar.NavBarGroup
        Private navPanelItemDocuments As DevExpress.XtraNavBar.NavBarItem
        Private navPanelItemMusic As DevExpress.XtraNavBar.NavBarItem
        Private navPanelItemPictures As DevExpress.XtraNavBar.NavBarItem
        Private navPanelItemVideos As DevExpress.XtraNavBar.NavBarItem
        Private WithEvents ButtonItemPropertiesFolder As DevExpress.XtraBars.BarButtonItem
        Private ButtonItemRemoveProperties As DevExpress.XtraBars.BarButtonItem
        Private ButtonItemDelete As DevExpress.XtraBars.BarButtonItem
        Private ButtonItemPermanentlyDelete As DevExpress.XtraBars.BarButtonItem
        Private PopupMenuDeleteButton As DevExpress.XtraBars.PopupMenu
        Private ButtonItemRecycle As DevExpress.XtraBars.BarButtonItem
        Private ButtonItemShowRecycleConfirmation As DevExpress.XtraBars.BarCheckItem
        Private WithEvents ButtonItemProperties As DevExpress.XtraBars.BarButtonItem
        Private PopupMenuPropertiesButton As DevExpress.XtraBars.PopupMenu
        Private ButtonItemDocuments As DevExpress.XtraBars.BarButtonItem
        Private ButtonItemMusic As DevExpress.XtraBars.BarButtonItem
        Private ButtonItemVideos As DevExpress.XtraBars.BarButtonItem
        Private ButtonItemPictures As DevExpress.XtraBars.BarButtonItem
        Private ButtonItemChooseLocation As DevExpress.XtraBars.BarButtonItem
        Private WithEvents ButtonCheckItemShowFavorites As DevExpress.XtraBars.BarCheckItem
        Private WithEvents ButtonCheckItemShowLibraries As DevExpress.XtraBars.BarCheckItem
        Private ButtonItemNewShortcut As DevExpress.XtraBars.BarButtonItem
        Private ButtonItemNewBitmapImage As DevExpress.XtraBars.BarButtonItem
        Private ButtonItemNewContact As DevExpress.XtraBars.BarButtonItem
        Private ButtonItemNewJournalDocument As DevExpress.XtraBars.BarButtonItem
        Private ButtonItemNewRichTextDocument As DevExpress.XtraBars.BarButtonItem
        Private ButtonItemNewTextDocument As DevExpress.XtraBars.BarButtonItem
        Private ButtonItemCompressedFolder As DevExpress.XtraBars.BarButtonItem
        Private WithEvents EditSearch As ButtonEdit
        Private WithEvents editBreadCrumb As BreadCrumbEdit
        Private WithEvents btnOpen As DevExpress.XtraBars.BarButtonItem
        Private WithEvents ButtonItemOptions As DevExpress.XtraBars.BarButtonItem
        Private WithEvents ButtonItemChangeFilderOptions As DevExpress.XtraBars.BarButtonItem
        Private PopupMenuOptionsButton As DevExpress.XtraBars.PopupMenu
        Private repositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Private repositoryItemRadioGroup1 As DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup
        Private WithEvents rgbiViewStyle As DevExpress.XtraBars.RibbonGalleryBarItem
        Private gridControl As DevExpress.XtraGrid.GridControl
        Private WithEvents winExplorerView As DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView
        Private repositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Private repositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Private WithEvents btnBack As LabelControl
        Private WithEvents btnForward As LabelControl
        Private WithEvents btnUpTo As LabelControl
        Private LayoutControl As DevExpress.XtraLayout.LayoutControl
        Private LayoutControlMainGroup As DevExpress.XtraLayout.LayoutControlGroup
        Private LayoutControlItemExplorerView As DevExpress.XtraLayout.LayoutControlItem
        Private liNavPaneRight As DevExpress.XtraLayout.LayoutControlItem
        Private SplitterItem1 As DevExpress.XtraLayout.SplitterItem
        Private WithEvents ContextItemOpen As DevExpress.XtraBars.BarButtonItem
        Private ContextItemCut As DevExpress.XtraBars.BarButtonItem
        Private ContextItemCopy As DevExpress.XtraBars.BarButtonItem
        Private ContextItemPaste As DevExpress.XtraBars.BarButtonItem
        Private ContextItemDelete As DevExpress.XtraBars.BarButtonItem
        Private ContextItemRename As DevExpress.XtraBars.BarButtonItem
        Private WithEvents ContextItemProperties As DevExpress.XtraBars.BarButtonItem
        Private imgArrows As Utils.ImageCollection
        Private imgs As Utils.ImageCollection
        Private columnName As Columns.GridColumn
        Private columnPath As Columns.GridColumn
        Private columnCheck As Columns.GridColumn
        Private columnGroup As Columns.GridColumn
        Private columnImage As Columns.GridColumn
        Private itemPopupMenu As XtraBars.PopupMenu
        Private WithEvents btnNavigationHistory As LabelControl
        Private navigationMenu As XtraBars.PopupMenu
    End Class
End Namespace


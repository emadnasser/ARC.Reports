Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraSplashScreen
Namespace DevExpress.XtraBars.Demos.RibbonSimplePad
	Partial Public Class frmMain

		#Region "Designer generated code"
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim GalleryItemGroup1 As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
            Dim GalleryItemGroup2 As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Dim GalleryItemGroup3 As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Dim GalleryItemGroup4 As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Dim GalleryItemGroup5 As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim ToolTipSeparatorItem1 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
            Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim ToolTipTitleItem3 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim SuperToolTip3 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim ToolTipTitleItem4 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim ToolTipItem3 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim SuperToolTip4 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim ToolTipTitleItem5 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim ToolTipItem4 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim SuperToolTip5 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim ToolTipTitleItem6 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim ToolTipItem5 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Me.iWeb = New DevExpress.XtraBars.BarButtonItem()
            Me.iAbout = New DevExpress.XtraBars.BarButtonItem()
            Me.iCenter = New DevExpress.XtraBars.BarButtonItem()
            Me.iSelectAll = New DevExpress.XtraBars.BarButtonItem()
            Me.iCopy = New DevExpress.XtraBars.BarButtonItem()
            Me.iCut = New DevExpress.XtraBars.BarButtonItem()
            Me.iPaste = New DevExpress.XtraBars.BarButtonItem()
            Me.iClear = New DevExpress.XtraBars.BarButtonItem()
            Me.iFont = New DevExpress.XtraBars.BarButtonItem()
            Me.gddFont = New DevExpress.XtraBars.Ribbon.GalleryDropDown(Me.components)
            Me.beiFontSize = New DevExpress.XtraBars.BarEditItem()
            Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.bbiFontColorPopup = New DevExpress.XtraBars.BarButtonItem()
            Me.popupControlContainer1 = New DevExpress.XtraBars.PopupControlContainer(Me.components)
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.pmAppMain = New DevExpress.XtraBars.Ribbon.ApplicationMenu(Me.components)
            Me.pccBottom = New DevExpress.XtraBars.PopupControlContainer(Me.components)
            Me.sbExit = New DevExpress.XtraEditors.SimpleButton()
            Me.imageCollection2 = New DevExpress.Utils.ImageCollection(Me.components)
            Me.idNew = New DevExpress.XtraBars.BarButtonItem()
            Me.pmNew = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.iNew = New DevExpress.XtraBars.BarButtonItem()
            Me.iTemplate = New DevExpress.XtraBars.BarButtonItem()
            Me.iOpen = New DevExpress.XtraBars.BarButtonItem()
            Me.sbiSave = New DevExpress.XtraBars.BarSubItem()
            Me.iSave = New DevExpress.XtraBars.BarButtonItem()
            Me.iSaveAs = New DevExpress.XtraBars.BarButtonItem()
            Me.iPrint = New DevExpress.XtraBars.BarButtonItem()
            Me.iClose = New DevExpress.XtraBars.BarButtonItem()
            Me.pccAppMenu = New DevExpress.XtraBars.Demos.RibbonSimplePad.Office2007PopupControlContainer()
            Me.pcAppMenuFileLabels = New DevExpress.XtraEditors.PanelControl()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.iUndo = New DevExpress.XtraBars.BarButtonItem()
            Me.iReplace = New DevExpress.XtraBars.BarButtonItem()
            Me.iExit = New DevExpress.XtraBars.BarButtonItem()
            Me.iFind = New DevExpress.XtraBars.BarButtonItem()
            Me.iBullets = New DevExpress.XtraBars.BarButtonItem()
            Me.iProtected = New DevExpress.XtraBars.BarButtonItem()
            Me.iBold = New DevExpress.XtraBars.BarButtonItem()
            Me.iItalic = New DevExpress.XtraBars.BarButtonItem()
            Me.iUnderline = New DevExpress.XtraBars.BarButtonItem()
            Me.iAlignLeft = New DevExpress.XtraBars.BarButtonItem()
            Me.iAlignRight = New DevExpress.XtraBars.BarButtonItem()
            Me.iFontColor = New DevExpress.XtraBars.BarButtonItem()
            Me.gddFontColor = New DevExpress.XtraBars.Ribbon.GalleryDropDown(Me.components)
            Me.siPosition = New DevExpress.XtraBars.BarButtonItem()
            Me.siModified = New DevExpress.XtraBars.BarButtonItem()
            Me.siDocName = New DevExpress.XtraBars.BarStaticItem()
            Me.bgFontStyle = New DevExpress.XtraBars.BarButtonGroup()
            Me.bgAlign = New DevExpress.XtraBars.BarButtonGroup()
            Me.bgFont = New DevExpress.XtraBars.BarButtonGroup()
            Me.bgBullets = New DevExpress.XtraBars.BarButtonGroup()
            Me.sbiPaste = New DevExpress.XtraBars.BarSubItem()
            Me.iPasteSpecial = New DevExpress.XtraBars.BarButtonItem()
            Me.sbiFind = New DevExpress.XtraBars.BarSubItem()
            Me.iLargeUndo = New DevExpress.XtraBars.BarLargeButtonItem()
            Me.iPaintStyle = New DevExpress.XtraBars.BarButtonItem()
            Me.rgbiSkins = New DevExpress.XtraBars.RibbonGalleryBarItem()
            Me.rgbiFont = New DevExpress.XtraBars.RibbonGalleryBarItem()
            Me.rgbiFontColor = New DevExpress.XtraBars.RibbonGalleryBarItem()
            Me.barEditItem1 = New DevExpress.XtraBars.BarEditItem()
            Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
            Me.biStyle = New DevExpress.XtraBars.BarEditItem()
            Me.riicStyle = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.editButtonGroup = New DevExpress.XtraBars.BarButtonGroup()
            Me.beScheme = New DevExpress.XtraBars.BarEditItem()
            Me.repositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.barToggleSwitchItem1 = New DevExpress.XtraBars.BarToggleSwitchItem()
            Me.bbColorMix = New DevExpress.XtraBars.BarButtonItem()
            Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
            Me.selectionMiniToolbar = New DevExpress.XtraBars.Ribbon.RibbonMiniToolbar(Me.components)
            Me.ribbonPageCategory1 = New DevExpress.XtraBars.Ribbon.RibbonPageCategory()
            Me.ribbonPage4 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup12 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup13 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup10 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup9 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup7 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup8 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPage3 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup11 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.rpgFont = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.rpgFontColor = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.repositoryItemTrackBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemTrackBar()
            Me.ribbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            Me.xtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
            Me.pmMain = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.imageCollection3 = New DevExpress.Utils.ImageCollection(Me.components)
            Me.backstageViewControl1 = New DevExpress.XtraBars.Ribbon.BackstageViewControl()
            Me.backstageViewClientControl9 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
            Me.recentOpen = New DevExpress.XtraBars.Ribbon.RecentItemControl()
            Me.recentStackPanel1 = New DevExpress.XtraBars.Ribbon.RecentStackPanel()
            Me.recentStackPanel2 = New DevExpress.XtraBars.Ribbon.RecentStackPanel()
            Me.recentTabItem1 = New DevExpress.XtraBars.Ribbon.RecentTabItem()
            Me.recentStackPanel3 = New DevExpress.XtraBars.Ribbon.RecentStackPanel()
            Me.recentTabItem2 = New DevExpress.XtraBars.Ribbon.RecentTabItem()
            Me.recentStackPanel4 = New DevExpress.XtraBars.Ribbon.RecentStackPanel()
            Me.backstageViewClientControl8 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
            Me.recentSaveAs = New DevExpress.XtraBars.Ribbon.RecentItemControl()
            Me.recentStackPanel5 = New DevExpress.XtraBars.Ribbon.RecentStackPanel()
            Me.recentStackPanel6 = New DevExpress.XtraBars.Ribbon.RecentStackPanel()
            Me.recentTabItem3 = New DevExpress.XtraBars.Ribbon.RecentTabItem()
            Me.recentStackPanel7 = New DevExpress.XtraBars.Ribbon.RecentStackPanel()
            Me.backstageViewClientControl11 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
            Me.recentControlPrint = New DevExpress.XtraBars.Ribbon.RecentItemControl()
            Me.recentPrintOptionsContainer = New DevExpress.XtraBars.Ribbon.RecentControlItemControlContainer()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.ddbDuplex = New DevExpress.XtraEditors.DropDownButton()
            Me.ddbOrientation = New DevExpress.XtraEditors.DropDownButton()
            Me.ddbPaperSize = New DevExpress.XtraEditors.DropDownButton()
            Me.ddbMargins = New DevExpress.XtraEditors.DropDownButton()
            Me.ddbCollate = New DevExpress.XtraEditors.DropDownButton()
            Me.backstageViewLabel2 = New DevExpress.XtraBars.Demos.RibbonSimplePad.BackstageViewLabel()
            Me.ddbPrinter = New DevExpress.XtraEditors.DropDownButton()
            Me.printerLabel = New DevExpress.XtraBars.Demos.RibbonSimplePad.BackstageViewLabel()
            Me.printButton = New DevExpress.XtraEditors.SimpleButton()
            Me.copySpinEdit = New DevExpress.XtraEditors.SpinEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciCopiesSpinEdit = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.recentPrintPreviewContainer = New DevExpress.XtraBars.Ribbon.RecentControlItemControlContainer()
            Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
            Me.printControl2 = New DevExpress.XtraPrinting.Control.PrintControl()
            Me.panelControl3 = New DevExpress.XtraEditors.PanelControl()
            Me.zoomTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.panel2 = New System.Windows.Forms.Panel()
            Me.pageButtonEdit = New DevExpress.XtraEditors.ButtonEdit()
            Me.zoomTrackBarControl1 = New DevExpress.XtraEditors.ZoomTrackBarControl()
            Me.recentStackPanel8 = New DevExpress.XtraBars.Ribbon.RecentStackPanel()
            Me.recentPrintPreview = New DevExpress.XtraBars.Ribbon.RecentControlContainerItem()
            Me.recentStackPanel9 = New DevExpress.XtraBars.Ribbon.RecentStackPanel()
            Me.recentPrintOptions = New DevExpress.XtraBars.Ribbon.RecentControlContainerItem()
            Me.backstageViewClientControl10 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
            Me.recentControlExport = New DevExpress.XtraBars.Ribbon.RecentItemControl()
            Me.recentStackPanel14 = New DevExpress.XtraBars.Ribbon.RecentStackPanel()
            Me.recentStackPanel10 = New DevExpress.XtraBars.Ribbon.RecentStackPanel()
            Me.recentTabItem4 = New DevExpress.XtraBars.Ribbon.RecentTabItem()
            Me.recentStackPanel11 = New DevExpress.XtraBars.Ribbon.RecentStackPanel()
            Me.recentControlRecentItem1 = New DevExpress.XtraBars.Ribbon.RecentPinItem()
            Me.recentControlRecentItem2 = New DevExpress.XtraBars.Ribbon.RecentPinItem()
            Me.recentControlRecentItem4 = New DevExpress.XtraBars.Ribbon.RecentPinItem()
            Me.recentControlRecentItem5 = New DevExpress.XtraBars.Ribbon.RecentPinItem()
            Me.recentControlRecentItem6 = New DevExpress.XtraBars.Ribbon.RecentPinItem()
            Me.recentControlRecentItem7 = New DevExpress.XtraBars.Ribbon.RecentPinItem()
            Me.recentControlRecentItem8 = New DevExpress.XtraBars.Ribbon.RecentPinItem()
            Me.recentControlRecentItem9 = New DevExpress.XtraBars.Ribbon.RecentPinItem()
            Me.backstageViewClientControl2 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
            Me.recentItemControl1 = New DevExpress.XtraBars.Ribbon.RecentItemControl()
            Me.recentStackPanel12 = New DevExpress.XtraBars.Ribbon.RecentStackPanel()
            Me.recentLabelItem1 = New DevExpress.XtraBars.Ribbon.RecentLabelItem()
            Me.recentHyperlinkItem1 = New DevExpress.XtraBars.Ribbon.RecentHyperlinkItem()
            Me.recentLabelItem2 = New DevExpress.XtraBars.Ribbon.RecentLabelItem()
            Me.recentStackPanel13 = New DevExpress.XtraBars.Ribbon.RecentStackPanel()
            Me.recentPinItem2 = New DevExpress.XtraBars.Ribbon.RecentPinItem()
            Me.recentPinItem3 = New DevExpress.XtraBars.Ribbon.RecentPinItem()
            Me.recentPinItem4 = New DevExpress.XtraBars.Ribbon.RecentPinItem()
            Me.backstageViewTabItem3 = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
            Me.bvItemSave = New DevExpress.XtraBars.Ribbon.BackstageViewButtonItem()
            Me.backstageViewTabItem1 = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
            Me.backstageViewTabItem5 = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
            Me.backstageViewTabItem4 = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
            Me.backstageViewTabItem6 = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
            Me.bvItemClose = New DevExpress.XtraBars.Ribbon.BackstageViewButtonItem()
            Me.bvItemExit = New DevExpress.XtraBars.Ribbon.BackstageViewButtonItem()
            Me.printControl1 = New DevExpress.XtraPrinting.Control.PrintControl()
            Me.recentControlRecentItem10 = New DevExpress.XtraBars.Ribbon.RecentPinItem()
            Me.recentControlButtonItem1 = New DevExpress.XtraBars.Ribbon.RecentButtonItem()
            Me.backstageViewClientControl7 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
            Me.backstageViewClientControl1 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
            Me.backstageViewClientControl3 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
            Me.taskbarAssistant1 = New DevExpress.Utils.Taskbar.TaskbarAssistant()
            Me.thumbButtonNewDoc = New DevExpress.Utils.Taskbar.ThumbnailButton()
            Me.thumbButtonPrev = New DevExpress.Utils.Taskbar.ThumbnailButton()
            Me.thumbButtonNext = New DevExpress.Utils.Taskbar.ThumbnailButton()
            Me.thumbButtonExit = New DevExpress.Utils.Taskbar.ThumbnailButton()
            Me.backstageViewTabItem2 = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
            Me.bvTabPrint = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
            Me.backstageViewClientControl4 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
            CType(Me.gddFont, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.popupControlContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pmAppMain, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pccBottom, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pccBottom.SuspendLayout()
            CType(Me.imageCollection2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pmNew, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pccAppMenu, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pccAppMenu.SuspendLayout()
            CType(Me.pcAppMenuFileLabels, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gddFontColor, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.riicStyle, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemTrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.xtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pmMain, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.imageCollection3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.backstageViewControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.backstageViewControl1.SuspendLayout()
            Me.backstageViewClientControl9.SuspendLayout()
            CType(Me.recentOpen, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.backstageViewClientControl8.SuspendLayout()
            CType(Me.recentSaveAs, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.backstageViewClientControl11.SuspendLayout()
            CType(Me.recentControlPrint, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.recentControlPrint.SuspendLayout()
            Me.recentPrintOptionsContainer.SuspendLayout()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType(Me.copySpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciCopiesSpinEdit, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.recentPrintPreviewContainer.SuspendLayout()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl2.SuspendLayout()
            CType(Me.panelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl3.SuspendLayout()
            CType(Me.zoomTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pageButtonEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.zoomTrackBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.zoomTrackBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.backstageViewClientControl10.SuspendLayout()
            CType(Me.recentControlExport, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.backstageViewClientControl2.SuspendLayout()
            CType(Me.recentItemControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.backstageViewClientControl4.SuspendLayout()
            Me.SuspendLayout()
            '
            'iWeb
            '
            Me.iWeb.Caption = "&DevExpress on the Web"
            Me.iWeb.CategoryGuid = New System.Guid("e07a4c24-66ac-4de6-bbcb-c0b6cfa7798b")
            Me.iWeb.Description = "Opens the web page."
            Me.iWeb.Hint = "DevExpress on the Web"
            Me.iWeb.Id = 21
            Me.iWeb.ImageIndex = 24
            Me.iWeb.Name = "iWeb"
            '
            'iAbout
            '
            Me.iAbout.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
            Me.iAbout.Caption = "&About"
            Me.iAbout.CategoryGuid = New System.Guid("e07a4c24-66ac-4de6-bbcb-c0b6cfa7798b")
            Me.iAbout.Description = "Displays the description of this program."
            Me.iAbout.Hint = "Displays the About dialog"
            Me.iAbout.Id = 22
            Me.iAbout.ImageIndex = 28
            Me.iAbout.Name = "iAbout"
            Me.iAbout.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '
            'iCenter
            '
            Me.iCenter.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.iCenter.Caption = "&Center"
            Me.iCenter.CategoryGuid = New System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258")
            Me.iCenter.Description = "Centers the selected text."
            Me.iCenter.GroupIndex = 1
            Me.iCenter.Hint = "Center"
            Me.iCenter.Id = 28
            Me.iCenter.ImageIndex = 19
            Me.iCenter.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E))
            Me.iCenter.Name = "iCenter"
            '
            'iSelectAll
            '
            Me.iSelectAll.Caption = "Select A&ll"
            Me.iSelectAll.CategoryGuid = New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")
            Me.iSelectAll.Description = "Selects all text in the active document."
            Me.iSelectAll.Hint = "Selects all text in the active document."
            Me.iSelectAll.Id = 13
            Me.iSelectAll.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A))
            Me.iSelectAll.Name = "iSelectAll"
            '
            'iCopy
            '
            Me.iCopy.Caption = "&Copy"
            Me.iCopy.CategoryGuid = New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")
            Me.iCopy.Description = "Copies the selection to the Clipboard."
            Me.iCopy.Hint = "Copy"
            Me.iCopy.Id = 10
            Me.iCopy.ImageIndex = 1
            Me.iCopy.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C))
            Me.iCopy.Name = "iCopy"
            '
            'iCut
            '
            Me.iCut.Caption = "Cu&t"
            Me.iCut.CategoryGuid = New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")
            Me.iCut.Description = "Removes the selection from the active document and places it on the Clipboard."
            Me.iCut.Hint = "Cut"
            Me.iCut.Id = 9
            Me.iCut.ImageIndex = 2
            Me.iCut.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X))
            Me.iCut.Name = "iCut"
            '
            'iPaste
            '
            Me.iPaste.Caption = "&Paste"
            Me.iPaste.CategoryGuid = New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")
            Me.iPaste.Description = "Inserts the contents of the Clipboard at the insertion point, and replaces any se" & _
        "lection. This command is available only if you have cut or copied a text."
            Me.iPaste.Hint = "Paste"
            Me.iPaste.Id = 11
            Me.iPaste.ImageIndex = 8
            Me.iPaste.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V))
            Me.iPaste.Name = "iPaste"
            '
            'iClear
            '
            Me.iClear.Caption = "Cle&ar"
            Me.iClear.CategoryGuid = New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")
            Me.iClear.Description = "Deletes the selected text without putting it on the Clipboard. This command is av" & _
        "ailable only if a text is selected. "
            Me.iClear.Hint = "Clear"
            Me.iClear.Id = 12
            Me.iClear.ImageIndex = 13
            Me.iClear.Name = "iClear"
            '
            'iFont
            '
            Me.iFont.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.iFont.Caption = "&Font..."
            Me.iFont.CategoryGuid = New System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258")
            Me.iFont.Description = "Changes the font and character spacing formats of the selected text."
            Me.iFont.DropDownControl = Me.gddFont
            Me.iFont.Hint = "Font Dialog"
            Me.iFont.Id = 17
            Me.iFont.ImageIndex = 4
            Me.iFont.Name = "iFont"
            Me.iFont.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            '
            'gddFont
            '
            '
            '
            '
            Me.gddFont.Gallery.Appearance.ItemCaptionAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.75!)
            Me.gddFont.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseFont = True
            Me.gddFont.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = True
            Me.gddFont.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.gddFont.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.gddFont.Gallery.Appearance.ItemCaptionAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.75!)
            Me.gddFont.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = True
            Me.gddFont.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = True
            Me.gddFont.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.gddFont.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.gddFont.Gallery.Appearance.ItemCaptionAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 9.75!)
            Me.gddFont.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseFont = True
            Me.gddFont.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = True
            Me.gddFont.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.gddFont.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.gddFont.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseTextOptions = True
            Me.gddFont.Gallery.Appearance.ItemDescriptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.gddFont.Gallery.Appearance.ItemDescriptionAppearance.Hovered.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.gddFont.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseTextOptions = True
            Me.gddFont.Gallery.Appearance.ItemDescriptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.gddFont.Gallery.Appearance.ItemDescriptionAppearance.Normal.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.gddFont.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseTextOptions = True
            Me.gddFont.Gallery.Appearance.ItemDescriptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.gddFont.Gallery.Appearance.ItemDescriptionAppearance.Pressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.gddFont.Gallery.ColumnCount = 1
            Me.gddFont.Gallery.FixedImageSize = False
            GalleryItemGroup1.Caption = "Main"
            Me.gddFont.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {GalleryItemGroup1})
            Me.gddFont.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.gddFont.Gallery.RowCount = 6
            Me.gddFont.Gallery.ShowGroupCaption = False
            Me.gddFont.Gallery.ShowItemText = True
            Me.gddFont.Gallery.SizeMode = DevExpress.XtraBars.Ribbon.GallerySizeMode.Vertical
            Me.gddFont.ItemLinks.Add(Me.beiFontSize)
            Me.gddFont.ItemLinks.Add(Me.bbiFontColorPopup)
            Me.gddFont.MenuCaption = "Fonts"
            Me.gddFont.Name = "gddFont"
            Me.gddFont.Ribbon = Me.ribbonControl1
            Me.gddFont.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
            '
            'beiFontSize
            '
            Me.beiFontSize.Caption = "Font Size"
            Me.beiFontSize.Edit = Me.repositoryItemSpinEdit1
            Me.beiFontSize.Hint = "Font Size"
            Me.beiFontSize.Id = 27
            Me.beiFontSize.Name = "beiFontSize"
            '
            'repositoryItemSpinEdit1
            '
            Me.repositoryItemSpinEdit1.AutoHeight = False
            Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemSpinEdit1.MaxValue = New Decimal(New Integer() {50, 0, 0, 0})
            Me.repositoryItemSpinEdit1.MinValue = New Decimal(New Integer() {6, 0, 0, 0})
            Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
            '
            'bbiFontColorPopup
            '
            Me.bbiFontColorPopup.ActAsDropDown = True
            Me.bbiFontColorPopup.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.bbiFontColorPopup.Caption = "Font Color"
            Me.bbiFontColorPopup.Description = "Formats the selected text with the color you click"
            Me.bbiFontColorPopup.DropDownControl = Me.popupControlContainer1
            Me.bbiFontColorPopup.Hint = "Formats the selected text with the color you click"
            Me.bbiFontColorPopup.Id = 36
            Me.bbiFontColorPopup.Name = "bbiFontColorPopup"
            '
            'popupControlContainer1
            '
            Me.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.popupControlContainer1.Location = New System.Drawing.Point(0, 0)
            Me.popupControlContainer1.Name = "popupControlContainer1"
            Me.popupControlContainer1.Size = New System.Drawing.Size(0, 0)
            Me.popupControlContainer1.TabIndex = 6
            Me.popupControlContainer1.Visible = False
            '
            'ribbonControl1
            '
            Me.ribbonControl1.AllowCustomization = True
            Me.ribbonControl1.ApplicationButtonDropDownControl = Me.pmAppMain
            Me.ribbonControl1.ApplicationButtonText = Nothing
            Me.ribbonControl1.AutoSizeItems = True
            Me.ribbonControl1.Categories.AddRange(New DevExpress.XtraBars.BarManagerCategory() {New DevExpress.XtraBars.BarManagerCategory("File", New System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f")), New DevExpress.XtraBars.BarManagerCategory("Edit", New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")), New DevExpress.XtraBars.BarManagerCategory("Format", New System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258")), New DevExpress.XtraBars.BarManagerCategory("Help", New System.Guid("e07a4c24-66ac-4de6-bbcb-c0b6cfa7798b")), New DevExpress.XtraBars.BarManagerCategory("Status", New System.Guid("77795bb7-9bc5-4dd2-a297-cc758682e23d"))})
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Images = Me.imageCollection2
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.iOpen, Me.iSave, Me.iUndo, Me.iReplace, Me.idNew, Me.iClose, Me.iSaveAs, Me.iPrint, Me.iExit, Me.iCut, Me.iCopy, Me.iPaste, Me.iClear, Me.iSelectAll, Me.iFind, Me.iFont, Me.iBullets, Me.iProtected, Me.iWeb, Me.iAbout, Me.iBold, Me.iItalic, Me.iUnderline, Me.iAlignLeft, Me.iCenter, Me.iAlignRight, Me.iFontColor, Me.siPosition, Me.siModified, Me.siDocName, Me.bgFontStyle, Me.bgAlign, Me.bgFont, Me.bgBullets, Me.sbiSave, Me.sbiPaste, Me.sbiFind, Me.iPasteSpecial, Me.iNew, Me.iLargeUndo, Me.iTemplate, Me.iPaintStyle, Me.rgbiSkins, Me.beiFontSize, Me.rgbiFont, Me.bbiFontColorPopup, Me.rgbiFontColor, Me.barEditItem1, Me.biStyle, Me.editButtonGroup, Me.beScheme, Me.barToggleSwitchItem1, Me.bbColorMix})
            Me.ribbonControl1.LargeImages = Me.imageCollection1
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 407
            Me.ribbonControl1.MiniToolbars.Add(Me.selectionMiniToolbar)
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.OptionsTouch.ShowTouchUISelectorInQAT = True
            Me.ribbonControl1.OptionsTouch.ShowTouchUISelectorVisibilityItemInQATMenu = True
            Me.ribbonControl1.PageCategories.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageCategory() {Me.ribbonPageCategory1})
            Me.ribbonControl1.PageCategoryAlignment = DevExpress.XtraBars.Ribbon.RibbonPageCategoryAlignment.Right
            Me.ribbonControl1.PageHeaderItemLinks.Add(Me.biStyle)
            Me.ribbonControl1.PageHeaderItemLinks.Add(Me.beScheme)
            Me.ribbonControl1.PageHeaderItemLinks.Add(Me.iAbout)
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1, Me.ribbonPage2, Me.ribbonPage3})
            Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemSpinEdit1, Me.repositoryItemPictureEdit1, Me.riicStyle, Me.repositoryItemComboBox1, Me.repositoryItemTrackBar1})
            Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
            Me.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[True]
            Me.ribbonControl1.Size = New System.Drawing.Size(1057, 147)
            Me.ribbonControl1.StatusBar = Me.ribbonStatusBar1
            Me.ribbonControl1.Toolbar.ItemLinks.Add(Me.iOpen)
            Me.ribbonControl1.Toolbar.ItemLinks.Add(Me.iSave)
            Me.ribbonControl1.Toolbar.ItemLinks.Add(Me.iUndo)
            Me.ribbonControl1.Toolbar.ItemLinks.Add(Me.iReplace, True)
            Me.ribbonControl1.Toolbar.ItemLinks.Add(Me.iPaintStyle)
            Me.ribbonControl1.TransparentEditors = True
            '
            'pmAppMain
            '
            Me.pmAppMain.BottomPaneControlContainer = Me.pccBottom
            Me.pmAppMain.ItemLinks.Add(Me.idNew)
            Me.pmAppMain.ItemLinks.Add(Me.iOpen)
            Me.pmAppMain.ItemLinks.Add(Me.sbiSave, True)
            Me.pmAppMain.ItemLinks.Add(Me.iPrint)
            Me.pmAppMain.ItemLinks.Add(Me.iClose, True)
            Me.pmAppMain.Name = "pmAppMain"
            Me.pmAppMain.Ribbon = Me.ribbonControl1
            Me.pmAppMain.RightPaneControlContainer = Me.pccAppMenu
            Me.pmAppMain.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
            Me.pmAppMain.ShowRightPane = True
            '
            'pccBottom
            '
            Me.pccBottom.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.pccBottom.Appearance.Options.UseBackColor = True
            Me.pccBottom.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pccBottom.Controls.Add(Me.sbExit)
            Me.pccBottom.Location = New System.Drawing.Point(573, 527)
            Me.pccBottom.Name = "pccBottom"
            Me.pccBottom.Ribbon = Me.ribbonControl1
            Me.pccBottom.Size = New System.Drawing.Size(115, 28)
            Me.pccBottom.TabIndex = 6
            Me.pccBottom.Visible = False
            Me.pccBottom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.pccBottom.AutoSize = True
            '
            'sbExit
            '
            Me.sbExit.AllowFocus = False
            Me.sbExit.ImageIndex = 13
            Me.sbExit.ImageList = Me.imageCollection2
            Me.sbExit.Location = New System.Drawing.Point(3, 3)
            Me.sbExit.Name = "sbExit"
            Me.sbExit.Size = New System.Drawing.Size(108, 21)
            Me.sbExit.AutoSize = True
            Me.sbExit.TabIndex = 0
            Me.sbExit.Text = "E&xit Application"
            '
            'imageCollection2
            '
            Me.imageCollection2.ImageStream = CType(resources.GetObject("imageCollection2.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
            '
            'idNew
            '
            Me.idNew.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.idNew.Caption = "New"
            Me.idNew.CategoryGuid = New System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f")
            Me.idNew.Description = "Creates a new, blank file."
            Me.idNew.DropDownControl = Me.pmNew
            Me.idNew.Hint = "Creates a new, blank file"
            Me.idNew.Id = 0
            Me.idNew.ImageIndex = 6
            Me.idNew.LargeImageIndex = 0
            Me.idNew.Name = "idNew"
            '
            'pmNew
            '
            Me.pmNew.ItemLinks.Add(Me.iNew)
            Me.pmNew.ItemLinks.Add(Me.iTemplate)
            Me.pmNew.MenuCaption = "New"
            Me.pmNew.Name = "pmNew"
            Me.pmNew.Ribbon = Me.ribbonControl1
            Me.pmNew.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
            '
            'iNew
            '
            Me.iNew.Caption = "&New"
            Me.iNew.CategoryGuid = New System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f")
            Me.iNew.Description = "Creates a new, blank file."
            Me.iNew.Hint = "Creates a new, blank file"
            Me.iNew.Id = 0
            Me.iNew.ImageIndex = 6
            Me.iNew.LargeImageIndex = 0
            Me.iNew.Name = "iNew"
            '
            'iTemplate
            '
            Me.iTemplate.Caption = "Template..."
            Me.iTemplate.CategoryGuid = New System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f")
            Me.iTemplate.Description = "Creates a new template"
            Me.iTemplate.Enabled = False
            Me.iTemplate.Hint = "Creates a new template"
            Me.iTemplate.Id = 1
            Me.iTemplate.ImageIndex = 6
            Me.iTemplate.Name = "iTemplate"
            '
            'iOpen
            '
            Me.iOpen.Caption = "&Open..."
            Me.iOpen.CategoryGuid = New System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f")
            Me.iOpen.Description = "Opens a file."
            Me.iOpen.Hint = "Open a file"
            Me.iOpen.Id = 1
            Me.iOpen.ImageIndex = 7
            Me.iOpen.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O))
            Me.iOpen.LargeImageIndex = 9
            Me.iOpen.Name = "iOpen"
            Me.iOpen.RibbonStyle = CType((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
            '
            'sbiSave
            '
            Me.sbiSave.Caption = "Save"
            Me.sbiSave.CategoryGuid = New System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f")
            Me.sbiSave.Description = "Saves the active document"
            Me.sbiSave.Hint = "Saves the active document"
            Me.sbiSave.Id = 0
            Me.sbiSave.ImageIndex = 10
            Me.sbiSave.LargeImageIndex = 2
            Me.sbiSave.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.iSave), New DevExpress.XtraBars.LinkPersistInfo(Me.iSaveAs)})
            Me.sbiSave.MenuCaption = "Save"
            Me.sbiSave.Name = "sbiSave"
            Me.sbiSave.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
            '
            'iSave
            '
            Me.iSave.Caption = "&Save"
            Me.iSave.CategoryGuid = New System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f")
            Me.iSave.Description = "Saves the active document with its current file name."
            Me.iSave.Hint = "Saves the active document with its current file name"
            Me.iSave.Id = 3
            Me.iSave.ImageIndex = 10
            Me.iSave.LargeImageIndex = 7
            Me.iSave.Name = "iSave"
            Me.iSave.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            '
            'iSaveAs
            '
            Me.iSaveAs.Caption = "Save &As..."
            Me.iSaveAs.CategoryGuid = New System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f")
            Me.iSaveAs.Description = "Saves the active document with a different file name."
            Me.iSaveAs.Hint = "Saves the active document with a different file name"
            Me.iSaveAs.Id = 4
            Me.iSaveAs.ImageIndex = 21
            Me.iSaveAs.LargeImageIndex = 2
            Me.iSaveAs.Name = "iSaveAs"
            '
            'iPrint
            '
            Me.iPrint.Caption = "&Print"
            Me.iPrint.CategoryGuid = New System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f")
            Me.iPrint.Description = "Prints the active document."
            Me.iPrint.Hint = "Prints the active document"
            Me.iPrint.Id = 5
            Me.iPrint.ImageIndex = 9
            Me.iPrint.LargeImageIndex = 6
            Me.iPrint.Name = "iPrint"
            Me.iPrint.RibbonStyle = CType((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
            '
            'iClose
            '
            Me.iClose.Caption = "&Close"
            Me.iClose.CategoryGuid = New System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f")
            Me.iClose.Description = "Closes the active document."
            Me.iClose.Hint = "Closes the active document"
            Me.iClose.Id = 2
            Me.iClose.ImageIndex = 12
            Me.iClose.LargeImageIndex = 8
            Me.iClose.Name = "iClose"
            Me.iClose.RibbonStyle = CType((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
            '
            'pccAppMenu
            '
            Me.pccAppMenu.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.pccAppMenu.Appearance.Options.UseBackColor = True
            Me.pccAppMenu.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pccAppMenu.Controls.Add(Me.pcAppMenuFileLabels)
            Me.pccAppMenu.Controls.Add(Me.labelControl1)
            Me.pccAppMenu.Controls.Add(Me.panelControl1)
            Me.pccAppMenu.Location = New System.Drawing.Point(573, 359)
            Me.pccAppMenu.Name = "pccAppMenu"
            Me.pccAppMenu.Ribbon = Me.ribbonControl1
            Me.pccAppMenu.Size = New System.Drawing.Size(310, 162)
            Me.pccAppMenu.TabIndex = 3
            Me.pccAppMenu.Visible = False
            '
            'pcAppMenuFileLabels
            '
            Me.pcAppMenuFileLabels.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pcAppMenuFileLabels.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pcAppMenuFileLabels.Location = New System.Drawing.Point(10, 19)
            Me.pcAppMenuFileLabels.Name = "pcAppMenuFileLabels"
            Me.pcAppMenuFileLabels.Size = New System.Drawing.Size(300, 143)
            Me.pcAppMenuFileLabels.TabIndex = 2
            '
            'labelControl1
            '
            Me.labelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.labelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
            Me.labelControl1.LineVisible = True
            Me.labelControl1.Location = New System.Drawing.Point(10, 0)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(300, 19)
            Me.labelControl1.TabIndex = 0
            Me.labelControl1.Text = "Recent Documents:"
            '
            'panelControl1
            '
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Left
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(10, 162)
            Me.panelControl1.TabIndex = 1
            '
            'iUndo
            '
            Me.iUndo.Caption = "&Undo"
            Me.iUndo.CategoryGuid = New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")
            Me.iUndo.Description = "Reverses the last command or deletes the last entry you typed."
            Me.iUndo.Hint = "Undo"
            Me.iUndo.Id = 8
            Me.iUndo.ImageIndex = 11
            Me.iUndo.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z))
            Me.iUndo.Name = "iUndo"
            '
            'iReplace
            '
            Me.iReplace.Caption = "R&eplace..."
            Me.iReplace.CategoryGuid = New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")
            Me.iReplace.Description = "Searches for and replaces the specified text."
            Me.iReplace.Hint = "Replace"
            Me.iReplace.Id = 15
            Me.iReplace.ImageIndex = 14
            Me.iReplace.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H))
            Me.iReplace.Name = "iReplace"
            '
            'iExit
            '
            Me.iExit.Caption = "E&xit"
            Me.iExit.CategoryGuid = New System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f")
            Me.iExit.Description = "Closes this program after prompting you to save unsaved document."
            Me.iExit.Hint = "Closes this program after prompting you to save unsaved document."
            Me.iExit.Id = 6
            Me.iExit.ImageIndex = 22
            Me.iExit.LargeImageIndex = 1
            Me.iExit.Name = "iExit"
            '
            'iFind
            '
            Me.iFind.Caption = "&Find..."
            Me.iFind.CategoryGuid = New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")
            Me.iFind.Description = "Searches for the specified text."
            Me.iFind.Hint = "Find"
            Me.iFind.Id = 14
            Me.iFind.ImageIndex = 3
            Me.iFind.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F))
            Me.iFind.Name = "iFind"
            '
            'iBullets
            '
            Me.iBullets.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.iBullets.Caption = "&Bullets"
            Me.iBullets.CategoryGuid = New System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258")
            Me.iBullets.Description = "Adds bullets to or removes bullets from selected paragraphs."
            Me.iBullets.Hint = "Bullets"
            Me.iBullets.Id = 18
            Me.iBullets.ImageIndex = 0
            Me.iBullets.Name = "iBullets"
            '
            'iProtected
            '
            Me.iProtected.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.iProtected.Caption = "P&rotected"
            Me.iProtected.CategoryGuid = New System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258")
            Me.iProtected.Description = "Protects the selected text."
            Me.iProtected.Hint = "Protects the selected text"
            Me.iProtected.Id = 19
            Me.iProtected.Name = "iProtected"
            '
            'iBold
            '
            Me.iBold.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.iBold.Caption = "&Bold"
            Me.iBold.CategoryGuid = New System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258")
            Me.iBold.Description = "Makes selected text and numbers bold. If the selection is already bold, clicking " & _
        "button removes bold formatting."
            Me.iBold.Hint = "Bold"
            Me.iBold.Id = 24
            Me.iBold.ImageIndex = 15
            Me.iBold.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B))
            Me.iBold.Name = "iBold"
            '
            'iItalic
            '
            Me.iItalic.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.iItalic.Caption = "&Italic"
            Me.iItalic.CategoryGuid = New System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258")
            Me.iItalic.Description = "Makes selected text and numbers italic. If the selection is already italic, click" & _
        "ing button removes italic formatting."
            Me.iItalic.Hint = "Italic"
            Me.iItalic.Id = 25
            Me.iItalic.ImageIndex = 16
            Me.iItalic.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I))
            Me.iItalic.Name = "iItalic"
            '
            'iUnderline
            '
            Me.iUnderline.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.iUnderline.Caption = "&Underline"
            Me.iUnderline.CategoryGuid = New System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258")
            Me.iUnderline.Description = "Underlines selected text and numbers. If the selection is already underlined, cli" & _
        "cking button removes underlining."
            Me.iUnderline.Hint = "Underline"
            Me.iUnderline.Id = 26
            Me.iUnderline.ImageIndex = 17
            Me.iUnderline.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U))
            Me.iUnderline.Name = "iUnderline"
            '
            'iAlignLeft
            '
            Me.iAlignLeft.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.iAlignLeft.Caption = "Align &Left"
            Me.iAlignLeft.CategoryGuid = New System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258")
            Me.iAlignLeft.Description = "Aligns the selected text to the left."
            Me.iAlignLeft.GroupIndex = 1
            Me.iAlignLeft.Hint = "Align Left"
            Me.iAlignLeft.Id = 27
            Me.iAlignLeft.ImageIndex = 18
            Me.iAlignLeft.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L))
            Me.iAlignLeft.Name = "iAlignLeft"
            '
            'iAlignRight
            '
            Me.iAlignRight.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.iAlignRight.Caption = "Align &Right"
            Me.iAlignRight.CategoryGuid = New System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258")
            Me.iAlignRight.Description = "Aligns the selected text to the right."
            Me.iAlignRight.GroupIndex = 1
            Me.iAlignRight.Hint = "Align Right"
            Me.iAlignRight.Id = 29
            Me.iAlignRight.ImageIndex = 20
            Me.iAlignRight.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R))
            Me.iAlignRight.Name = "iAlignRight"
            '
            'iFontColor
            '
            Me.iFontColor.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.iFontColor.Caption = "Font C&olor"
            Me.iFontColor.CategoryGuid = New System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258")
            Me.iFontColor.Description = "Formats the selected text with the color you click."
            Me.iFontColor.DropDownControl = Me.gddFontColor
            Me.iFontColor.Hint = "Font Color"
            Me.iFontColor.Id = 30
            Me.iFontColor.ImageIndex = 5
            Me.iFontColor.Name = "iFontColor"
            '
            'gddFontColor
            '
            '
            '
            '
            Me.gddFontColor.Gallery.Appearance.ItemCaptionAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 6.75!)
            Me.gddFontColor.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseFont = True
            Me.gddFontColor.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.gddFontColor.Gallery.Appearance.ItemCaptionAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 6.75!)
            Me.gddFontColor.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = True
            Me.gddFontColor.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.gddFontColor.Gallery.Appearance.ItemCaptionAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 6.75!)
            Me.gddFontColor.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseFont = True
            Me.gddFontColor.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.gddFontColor.Gallery.FilterCaption = "All Colors"
            Me.gddFontColor.Gallery.FixedImageSize = False
            GalleryItemGroup2.Caption = "Web Colors"
            GalleryItemGroup3.Caption = "System Colors"
            Me.gddFontColor.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {GalleryItemGroup2, GalleryItemGroup3})
            Me.gddFontColor.Gallery.ImageSize = New System.Drawing.Size(48, 16)
            Me.gddFontColor.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Top
            Me.gddFontColor.Gallery.RowCount = 5
            Me.gddFontColor.Gallery.ShowItemText = True
            Me.gddFontColor.Gallery.SizeMode = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
            Me.gddFontColor.MenuCaption = "Font Colors"
            Me.gddFontColor.Name = "gddFontColor"
            Me.gddFontColor.Ribbon = Me.ribbonControl1
            Me.gddFontColor.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
            '
            'siPosition
            '
            Me.siPosition.CategoryGuid = New System.Guid("77795bb7-9bc5-4dd2-a297-cc758682e23d")
            Me.siPosition.Id = 0
            Me.siPosition.Name = "siPosition"
            '
            'siModified
            '
            Me.siModified.CategoryGuid = New System.Guid("77795bb7-9bc5-4dd2-a297-cc758682e23d")
            Me.siModified.Id = 1
            Me.siModified.ImageIndex = 27
            Me.siModified.Name = "siModified"
            '
            'siDocName
            '
            Me.siDocName.CategoryGuid = New System.Guid("77795bb7-9bc5-4dd2-a297-cc758682e23d")
            Me.siDocName.Id = 2
            Me.siDocName.Name = "siDocName"
            Me.siDocName.TextAlignment = System.Drawing.StringAlignment.Near
            '
            'bgFontStyle
            '
            Me.bgFontStyle.Caption = "FontStyle"
            Me.bgFontStyle.Id = 0
            Me.bgFontStyle.ItemLinks.Add(Me.iBold)
            Me.bgFontStyle.ItemLinks.Add(Me.iItalic)
            Me.bgFontStyle.ItemLinks.Add(Me.iUnderline)
            Me.bgFontStyle.Name = "bgFontStyle"
            Me.bgFontStyle.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
            '
            'bgAlign
            '
            Me.bgAlign.Caption = "Align"
            Me.bgAlign.Id = 0
            Me.bgAlign.ItemLinks.Add(Me.iAlignLeft)
            Me.bgAlign.ItemLinks.Add(Me.iCenter)
            Me.bgAlign.ItemLinks.Add(Me.iAlignRight)
            Me.bgAlign.Name = "bgAlign"
            Me.bgAlign.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
            '
            'bgFont
            '
            Me.bgFont.Caption = "Font"
            Me.bgFont.Id = 0
            Me.bgFont.ItemLinks.Add(Me.iFont)
            Me.bgFont.ItemLinks.Add(Me.iFontColor)
            Me.bgFont.Name = "bgFont"
            Me.bgFont.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
            '
            'bgBullets
            '
            Me.bgBullets.Caption = "Bullets"
            Me.bgBullets.Id = 1
            Me.bgBullets.ItemLinks.Add(Me.iBullets)
            Me.bgBullets.ItemLinks.Add(Me.iProtected)
            Me.bgBullets.Name = "bgBullets"
            Me.bgBullets.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
            '
            'sbiPaste
            '
            Me.sbiPaste.Caption = "Paste"
            Me.sbiPaste.CategoryGuid = New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")
            Me.sbiPaste.Description = "Inserts the contents of the Clipboard at the insertion point"
            Me.sbiPaste.Hint = "Inserts the contents of the Clipboard at the insertion point"
            Me.sbiPaste.Id = 1
            Me.sbiPaste.ImageIndex = 8
            Me.sbiPaste.LargeImageIndex = 3
            Me.sbiPaste.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.iPaste), New DevExpress.XtraBars.LinkPersistInfo(Me.iPasteSpecial)})
            Me.sbiPaste.MenuCaption = "Paste"
            Me.sbiPaste.Name = "sbiPaste"
            Me.sbiPaste.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
            '
            'iPasteSpecial
            '
            Me.iPasteSpecial.Caption = "Paste &Special..."
            Me.iPasteSpecial.CategoryGuid = New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")
            Me.iPasteSpecial.Description = "Opens the Paste Special dialog"
            Me.iPasteSpecial.Enabled = False
            Me.iPasteSpecial.Hint = "Opens the Paste Special dialog"
            Me.iPasteSpecial.Id = 3
            Me.iPasteSpecial.ImageIndex = 8
            Me.iPasteSpecial.Name = "iPasteSpecial"
            '
            'sbiFind
            '
            Me.sbiFind.Caption = "Find"
            Me.sbiFind.CategoryGuid = New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")
            Me.sbiFind.Description = "Searches for the specified text"
            Me.sbiFind.Hint = "Searches for the specified text"
            Me.sbiFind.Id = 2
            Me.sbiFind.ImageIndex = 3
            Me.sbiFind.LargeImageIndex = 4
            Me.sbiFind.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.iFind), New DevExpress.XtraBars.LinkPersistInfo(Me.iReplace)})
            Me.sbiFind.MenuCaption = "Find and Replace"
            Me.sbiFind.Name = "sbiFind"
            Me.sbiFind.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
                Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
            Me.sbiFind.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
            '
            'iLargeUndo
            '
            Me.iLargeUndo.Caption = "&Undo"
            Me.iLargeUndo.CategoryGuid = New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")
            Me.iLargeUndo.Hint = "Undo"
            Me.iLargeUndo.Id = 0
            Me.iLargeUndo.ImageIndex = 11
            Me.iLargeUndo.LargeImageIndex = 5
            Me.iLargeUndo.Name = "iLargeUndo"
            '
            'iPaintStyle
            '
            Me.iPaintStyle.ActAsDropDown = True
            Me.iPaintStyle.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.iPaintStyle.Caption = "Paint style"
            Me.iPaintStyle.Description = "Select a paint scheme"
            Me.iPaintStyle.Hint = "Select a paint scheme"
            Me.iPaintStyle.Id = 7
            Me.iPaintStyle.ImageIndex = 26
            Me.iPaintStyle.Name = "iPaintStyle"
            '
            'rgbiSkins
            '
            Me.rgbiSkins.Caption = "Skins"
            '
            '
            '
            Me.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseFont = True
            Me.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = True
            Me.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = True
            Me.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = True
            Me.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseFont = True
            Me.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = True
            Me.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.rgbiSkins.Id = 13
            Me.rgbiSkins.Name = "rgbiSkins"
            '
            'rgbiFont
            '
            Me.rgbiFont.Caption = "Font"
            '
            '
            '
            GalleryItemGroup4.Caption = "Main"
            Me.rgbiFont.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {GalleryItemGroup4})
            Me.rgbiFont.Gallery.ImageSize = New System.Drawing.Size(40, 40)
            Me.rgbiFont.GalleryDropDown = Me.gddFont
            Me.rgbiFont.Id = 29
            Me.rgbiFont.Name = "rgbiFont"
            '
            'rgbiFontColor
            '
            Me.rgbiFontColor.Caption = "Color"
            '
            '
            '
            Me.rgbiFontColor.Gallery.ColumnCount = 10
            GalleryItemGroup5.Caption = "Main"
            Me.rgbiFontColor.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {GalleryItemGroup5})
            Me.rgbiFontColor.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.Stretch
            Me.rgbiFontColor.Gallery.ImageSize = New System.Drawing.Size(20, 14)
            Me.rgbiFontColor.GalleryDropDown = Me.gddFontColor
            Me.rgbiFontColor.Id = 37
            Me.rgbiFontColor.Name = "rgbiFontColor"
            '
            'barEditItem1
            '
            Me.barEditItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
            Me.barEditItem1.CanOpenEdit = False
            Me.barEditItem1.Edit = Me.repositoryItemPictureEdit1
            Me.barEditItem1.EditWidth = 130
            Me.barEditItem1.Id = 94
            Me.barEditItem1.Name = "barEditItem1"
            '
            'repositoryItemPictureEdit1
            '
            Me.repositoryItemPictureEdit1.AllowFocused = False
            Me.repositoryItemPictureEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
            '
            'biStyle
            '
            Me.biStyle.Edit = Me.riicStyle
            Me.biStyle.EditWidth = 75
            Me.biStyle.Hint = "Ribbon Style"
            Me.biStyle.Id = 106
            Me.biStyle.Name = "biStyle"
            '
            'riicStyle
            '
            Me.riicStyle.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.riicStyle.Appearance.Options.UseFont = True
            Me.riicStyle.AutoHeight = False
            Me.riicStyle.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.riicStyle.Name = "riicStyle"
            '
            'editButtonGroup
            '
            Me.editButtonGroup.Id = 145
            Me.editButtonGroup.ItemLinks.Add(Me.iCut)
            Me.editButtonGroup.ItemLinks.Add(Me.iCopy)
            Me.editButtonGroup.ItemLinks.Add(Me.iPaste)
            Me.editButtonGroup.ItemLinks.Add(Me.iClear)
            Me.editButtonGroup.Name = "editButtonGroup"
            Me.editButtonGroup.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
            '
            'beScheme
            '
            Me.beScheme.Edit = Me.repositoryItemComboBox1
            Me.beScheme.EditWidth = 75
            Me.beScheme.Id = 188
            Me.beScheme.Name = "beScheme"
            '
            'repositoryItemComboBox1
            '
            Me.repositoryItemComboBox1.AutoHeight = False
            Me.repositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemComboBox1.Name = "repositoryItemComboBox1"
            Me.repositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            '
            'barToggleSwitchItem1
            '
            Me.barToggleSwitchItem1.Caption = "Auto Save"
            Me.barToggleSwitchItem1.Id = 213
            Me.barToggleSwitchItem1.Name = "barToggleSwitchItem1"
            Me.barToggleSwitchItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '
            'bbColorMix
            '
            Me.bbColorMix.Caption = "&Color Mix"
            Me.bbColorMix.Glyph = CType(resources.GetObject("bbColorMix.Glyph"), System.Drawing.Image)
            Me.bbColorMix.Id = 238
            Me.bbColorMix.LargeGlyph = CType(resources.GetObject("bbColorMix.LargeGlyph"), System.Drawing.Image)
            Me.bbColorMix.LargeImageIndex = 0
            Me.bbColorMix.Name = "bbColorMix"
            '
            'imageCollection1
            '
            Me.imageCollection1.ImageSize = New System.Drawing.Size(32, 32)
            Me.imageCollection1.ImageStream = CType(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
            '
            'selectionMiniToolbar
            '
            Me.selectionMiniToolbar.Alignment = System.Drawing.ContentAlignment.TopRight
            Me.selectionMiniToolbar.ItemLinks.Add(Me.bgFont)
            Me.selectionMiniToolbar.ItemLinks.Add(Me.bgFontStyle)
            Me.selectionMiniToolbar.ItemLinks.Add(Me.bgAlign)
            Me.selectionMiniToolbar.ItemLinks.Add(Me.editButtonGroup)
            Me.selectionMiniToolbar.ParentControl = Me
            '
            'ribbonPageCategory1
            '
            Me.ribbonPageCategory1.Name = "ribbonPageCategory1"
            Me.ribbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage4})
            Me.ribbonPageCategory1.Text = "Selection"
            '
            'ribbonPage4
            '
            Me.ribbonPage4.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup12, Me.ribbonPageGroup13})
            Me.ribbonPage4.Name = "ribbonPage4"
            Me.ribbonPage4.Text = "Selection"
            '
            'ribbonPageGroup12
            '
            Me.ribbonPageGroup12.ItemLinks.Add(Me.sbiPaste)
            Me.ribbonPageGroup12.ItemLinks.Add(Me.iCut, True)
            Me.ribbonPageGroup12.ItemLinks.Add(Me.iCopy)
            Me.ribbonPageGroup12.ItemLinks.Add(Me.iClear)
            Me.ribbonPageGroup12.Name = "ribbonPageGroup12"
            Me.ribbonPageGroup12.ShowCaptionButton = False
            Me.ribbonPageGroup12.Text = "Edit"
            '
            'ribbonPageGroup13
            '
            Me.ribbonPageGroup13.ItemLinks.Add(Me.iBold)
            Me.ribbonPageGroup13.ItemLinks.Add(Me.iItalic)
            Me.ribbonPageGroup13.ItemLinks.Add(Me.iUnderline)
            Me.ribbonPageGroup13.ItemLinks.Add(Me.rgbiFont)
            Me.ribbonPageGroup13.ItemLinks.Add(Me.rgbiFontColor)
            Me.ribbonPageGroup13.Name = "ribbonPageGroup13"
            Me.ribbonPageGroup13.ShowCaptionButton = False
            Me.ribbonPageGroup13.Text = "Format"
            '
            'ribbonPage1
            '
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1, Me.ribbonPageGroup2, Me.ribbonPageGroup3, Me.ribbonPageGroup10, Me.ribbonPageGroup4, Me.ribbonPageGroup9})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "Home"
            '
            'ribbonPageGroup1
            '
            Me.ribbonPageGroup1.ImageIndex = 1
            Me.ribbonPageGroup1.ItemLinks.Add(Me.idNew)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.iOpen)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.iClose)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.iPrint)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.barToggleSwitchItem1)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.sbiSave, True)
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            ToolTipTitleItem1.Text = "Open File Dialog"
            ToolTipItem1.Appearance.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
            ToolTipItem1.Appearance.Options.UseImage = True
            ToolTipItem1.Image = CType(resources.GetObject("ToolTipItem1.Image"), System.Drawing.Image)
            ToolTipItem1.Text = "Show the Open file dialog box"
            ToolTipTitleItem2.Appearance.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
            ToolTipTitleItem2.Appearance.Options.UseImage = True
            ToolTipTitleItem2.Image = CType(resources.GetObject("ToolTipTitleItem2.Image"), System.Drawing.Image)
            ToolTipTitleItem2.Text = "For more information see help"
            SuperToolTip1.Items.Add(ToolTipTitleItem1)
            SuperToolTip1.Items.Add(ToolTipItem1)
            SuperToolTip1.Items.Add(ToolTipSeparatorItem1)
            SuperToolTip1.Items.Add(ToolTipTitleItem2)
            Me.ribbonPageGroup1.SuperTip = SuperToolTip1
            Me.ribbonPageGroup1.Text = "File"
            '
            'ribbonPageGroup2
            '
            Me.ribbonPageGroup2.ImageIndex = 2
            Me.ribbonPageGroup2.ItemLinks.Add(Me.sbiPaste)
            Me.ribbonPageGroup2.ItemLinks.Add(Me.iCut)
            Me.ribbonPageGroup2.ItemLinks.Add(Me.iCopy)
            Me.ribbonPageGroup2.ItemLinks.Add(Me.iClear)
            Me.ribbonPageGroup2.ItemLinks.Add(Me.iUndo, True)
            Me.ribbonPageGroup2.ItemLinks.Add(Me.iSelectAll)
            Me.ribbonPageGroup2.Name = "ribbonPageGroup2"
            ToolTipTitleItem3.Text = "Edit Popup Menu"
            ToolTipItem2.Appearance.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
            ToolTipItem2.Appearance.Options.UseImage = True
            ToolTipItem2.Image = CType(resources.GetObject("ToolTipItem2.Image"), System.Drawing.Image)
            ToolTipItem2.Text = "Show the Edit popup menu"
            SuperToolTip2.Items.Add(ToolTipTitleItem3)
            SuperToolTip2.Items.Add(ToolTipItem2)
            Me.ribbonPageGroup2.SuperTip = SuperToolTip2
            Me.ribbonPageGroup2.Text = "Edit"
            '
            'ribbonPageGroup3
            '
            Me.ribbonPageGroup3.ImageIndex = 26
            Me.ribbonPageGroup3.ItemLinks.Add(Me.bgFontStyle)
            Me.ribbonPageGroup3.ItemLinks.Add(Me.bgFont)
            Me.ribbonPageGroup3.ItemLinks.Add(Me.bgBullets)
            Me.ribbonPageGroup3.ItemLinks.Add(Me.bgAlign)
            Me.ribbonPageGroup3.Name = "ribbonPageGroup3"
            Me.ribbonPageGroup3.ShowCaptionButton = False
            Me.ribbonPageGroup3.Text = "Format"
            '
            'ribbonPageGroup10
            '
            Me.ribbonPageGroup10.ItemLinks.Add(Me.rgbiSkins)
            Me.ribbonPageGroup10.ItemLinks.Add(Me.bbColorMix)
            Me.ribbonPageGroup10.Name = "ribbonPageGroup10"
            Me.ribbonPageGroup10.ShowCaptionButton = False
            Me.ribbonPageGroup10.Text = "Skins"
            '
            'ribbonPageGroup4
            '
            Me.ribbonPageGroup4.ImageIndex = 3
            Me.ribbonPageGroup4.ItemLinks.Add(Me.sbiFind)
            Me.ribbonPageGroup4.Name = "ribbonPageGroup4"
            Me.ribbonPageGroup4.ShowCaptionButton = False
            Me.ribbonPageGroup4.Text = "Find"
            '
            'ribbonPageGroup9
            '
            Me.ribbonPageGroup9.AllowTextClipping = False
            Me.ribbonPageGroup9.ImageIndex = 22
            Me.ribbonPageGroup9.ItemLinks.Add(Me.iExit)
            Me.ribbonPageGroup9.Name = "ribbonPageGroup9"
            ToolTipTitleItem4.Text = "Save File Dialog"
            ToolTipItem3.Appearance.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
            ToolTipItem3.Appearance.Options.UseImage = True
            ToolTipItem3.Image = CType(resources.GetObject("ToolTipItem3.Image"), System.Drawing.Image)
            ToolTipItem3.Text = "Show the Save file dialog box"
            SuperToolTip3.Items.Add(ToolTipTitleItem4)
            SuperToolTip3.Items.Add(ToolTipItem3)
            Me.ribbonPageGroup9.SuperTip = SuperToolTip3
            Me.ribbonPageGroup9.Text = "Exit"
            '
            'ribbonPage2
            '
            Me.ribbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup5, Me.ribbonPageGroup6, Me.ribbonPageGroup7, Me.ribbonPageGroup8})
            Me.ribbonPage2.Name = "ribbonPage2"
            Me.ribbonPage2.Text = "Alternative Page"
            '
            'ribbonPageGroup5
            '
            Me.ribbonPageGroup5.ImageIndex = 1
            Me.ribbonPageGroup5.ItemLinks.Add(Me.idNew)
            Me.ribbonPageGroup5.ItemLinks.Add(Me.iOpen)
            Me.ribbonPageGroup5.ItemLinks.Add(Me.iSave)
            Me.ribbonPageGroup5.ItemLinks.Add(Me.iPrint)
            Me.ribbonPageGroup5.ItemLinks.Add(Me.iCut, True)
            Me.ribbonPageGroup5.ItemLinks.Add(Me.iCopy)
            Me.ribbonPageGroup5.ItemLinks.Add(Me.iPaste)
            Me.ribbonPageGroup5.ItemLinks.Add(Me.iLargeUndo)
            Me.ribbonPageGroup5.Name = "ribbonPageGroup5"
            Me.ribbonPageGroup5.ShowCaptionButton = False
            Me.ribbonPageGroup5.Text = "Standard"
            '
            'ribbonPageGroup6
            '
            Me.ribbonPageGroup6.ImageIndex = 26
            Me.ribbonPageGroup6.ItemLinks.Add(Me.iBold)
            Me.ribbonPageGroup6.ItemLinks.Add(Me.iItalic)
            Me.ribbonPageGroup6.ItemLinks.Add(Me.iUnderline)
            Me.ribbonPageGroup6.ItemLinks.Add(Me.iAlignLeft, True)
            Me.ribbonPageGroup6.ItemLinks.Add(Me.iCenter)
            Me.ribbonPageGroup6.ItemLinks.Add(Me.iAlignRight)
            Me.ribbonPageGroup6.ItemLinks.Add(Me.iBullets, True)
            Me.ribbonPageGroup6.ItemLinks.Add(Me.iProtected)
            Me.ribbonPageGroup6.Name = "ribbonPageGroup6"
            Me.ribbonPageGroup6.ShowCaptionButton = False
            Me.ribbonPageGroup6.Text = "Format"
            '
            'ribbonPageGroup7
            '
            Me.ribbonPageGroup7.ImageIndex = 4
            Me.ribbonPageGroup7.ItemLinks.Add(Me.iFont)
            Me.ribbonPageGroup7.ItemLinks.Add(Me.iFontColor)
            Me.ribbonPageGroup7.Name = "ribbonPageGroup7"
            Me.ribbonPageGroup7.ShowCaptionButton = False
            Me.ribbonPageGroup7.Text = "Font"
            '
            'ribbonPageGroup8
            '
            Me.ribbonPageGroup8.ImageIndex = 25
            Me.ribbonPageGroup8.ItemLinks.Add(Me.iWeb)
            Me.ribbonPageGroup8.ItemLinks.Add(Me.iAbout)
            Me.ribbonPageGroup8.Name = "ribbonPageGroup8"
            Me.ribbonPageGroup8.ShowCaptionButton = False
            Me.ribbonPageGroup8.Text = "Help"
            '
            'ribbonPage3
            '
            Me.ribbonPage3.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup11, Me.rpgFont, Me.rpgFontColor})
            Me.ribbonPage3.Name = "ribbonPage3"
            Me.ribbonPage3.Text = "Gallery Page"
            '
            'ribbonPageGroup11
            '
            Me.ribbonPageGroup11.ItemLinks.Add(Me.rgbiSkins)
            Me.ribbonPageGroup11.Name = "ribbonPageGroup11"
            Me.ribbonPageGroup11.ShowCaptionButton = False
            Me.ribbonPageGroup11.Text = "Skins"
            '
            'rpgFont
            '
            Me.rpgFont.ItemLinks.Add(Me.rgbiFont)
            Me.rpgFont.Name = "rpgFont"
            ToolTipTitleItem5.Text = "Font Dialog"
            ToolTipItem4.Appearance.Image = CType(resources.GetObject("resource.Image4"), System.Drawing.Image)
            ToolTipItem4.Appearance.Options.UseImage = True
            ToolTipItem4.Image = CType(resources.GetObject("ToolTipItem4.Image"), System.Drawing.Image)
            ToolTipItem4.Text = "Show the Font dialog box"
            SuperToolTip4.Items.Add(ToolTipTitleItem5)
            SuperToolTip4.Items.Add(ToolTipItem4)
            Me.rpgFont.SuperTip = SuperToolTip4
            Me.rpgFont.Text = "Font"
            '
            'rpgFontColor
            '
            Me.rpgFontColor.ItemLinks.Add(Me.rgbiFontColor)
            Me.rpgFontColor.Name = "rpgFontColor"
            ToolTipTitleItem6.Text = "Color Edit"
            ToolTipItem5.Appearance.Image = CType(resources.GetObject("resource.Image5"), System.Drawing.Image)
            ToolTipItem5.Appearance.Options.UseImage = True
            ToolTipItem5.Image = CType(resources.GetObject("ToolTipItem5.Image"), System.Drawing.Image)
            ToolTipItem5.Text = "Show the Color edit popup"
            SuperToolTip5.Items.Add(ToolTipTitleItem6)
            SuperToolTip5.Items.Add(ToolTipItem5)
            Me.rpgFontColor.SuperTip = SuperToolTip5
            Me.rpgFontColor.Text = "Font Color"
            '
            'repositoryItemTrackBar1
            '
            Me.repositoryItemTrackBar1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.repositoryItemTrackBar1.LabelAppearance.Options.UseTextOptions = True
            Me.repositoryItemTrackBar1.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.repositoryItemTrackBar1.Maximum = 1000
            Me.repositoryItemTrackBar1.Name = "repositoryItemTrackBar1"
            '
            'ribbonStatusBar1
            '
            Me.ribbonStatusBar1.ItemLinks.Add(Me.siPosition)
            Me.ribbonStatusBar1.ItemLinks.Add(Me.siModified, True)
            Me.ribbonStatusBar1.ItemLinks.Add(Me.siDocName, True)
            Me.ribbonStatusBar1.ItemLinks.Add(Me.barEditItem1)
            Me.ribbonStatusBar1.Location = New System.Drawing.Point(0, 718)
            Me.ribbonStatusBar1.Name = "ribbonStatusBar1"
            Me.ribbonStatusBar1.Ribbon = Me.ribbonControl1
            Me.ribbonStatusBar1.Size = New System.Drawing.Size(1057, 23)
            '
            'defaultLookAndFeel1
            '
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Black"
            '
            'xtraTabbedMdiManager1
            '
            Me.xtraTabbedMdiManager1.FloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[True]
            Me.xtraTabbedMdiManager1.FloatOnDrag = DevExpress.Utils.DefaultBoolean.[True]
            Me.xtraTabbedMdiManager1.MdiParent = Me
            '
            'pmMain
            '
            Me.pmMain.ItemLinks.Add(Me.iUndo)
            Me.pmMain.ItemLinks.Add(Me.iCopy, True)
            Me.pmMain.ItemLinks.Add(Me.iCut)
            Me.pmMain.ItemLinks.Add(Me.iPaste)
            Me.pmMain.ItemLinks.Add(Me.iClear)
            Me.pmMain.ItemLinks.Add(Me.iSelectAll)
            Me.pmMain.ItemLinks.Add(Me.iFont, True)
            Me.pmMain.ItemLinks.Add(Me.iBullets)
            Me.pmMain.MenuCaption = "Edit Menu"
            Me.pmMain.MultiColumn = DevExpress.Utils.DefaultBoolean.[True]
            Me.pmMain.Name = "pmMain"
            Me.pmMain.OptionsMultiColumn.ShowItemText = DevExpress.Utils.DefaultBoolean.[True]
            Me.pmMain.Ribbon = Me.ribbonControl1
            Me.pmMain.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[False]
            '
            'imageCollection3
            '
            Me.imageCollection3.ImageSize = New System.Drawing.Size(15, 15)
            Me.imageCollection3.ImageStream = CType(resources.GetObject("imageCollection3.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
            '
            'backstageViewControl1
            '
            Me.backstageViewControl1.BackstageViewShowRibbonItems = CType((DevExpress.XtraBars.Ribbon.BackstageViewShowRibbonItems.FormButtons Or DevExpress.XtraBars.Ribbon.BackstageViewShowRibbonItems.Title), DevExpress.XtraBars.Ribbon.BackstageViewShowRibbonItems)
            Me.backstageViewControl1.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Yellow
            Me.backstageViewControl1.Controls.Add(Me.backstageViewClientControl9)
            Me.backstageViewControl1.Controls.Add(Me.backstageViewClientControl8)
            Me.backstageViewControl1.Controls.Add(Me.backstageViewClientControl11)
            Me.backstageViewControl1.Controls.Add(Me.backstageViewClientControl10)
            Me.backstageViewControl1.Controls.Add(Me.backstageViewClientControl2)
            Me.backstageViewControl1.Images = Me.imageCollection2
            Me.backstageViewControl1.Items.Add(Me.backstageViewTabItem3)
            Me.backstageViewControl1.Items.Add(Me.bvItemSave)
            Me.backstageViewControl1.Items.Add(Me.backstageViewTabItem1)
            Me.backstageViewControl1.Items.Add(Me.backstageViewTabItem5)
            Me.backstageViewControl1.Items.Add(Me.backstageViewTabItem4)
            Me.backstageViewControl1.Items.Add(Me.backstageViewTabItem6)
            Me.backstageViewControl1.Items.Add(Me.bvItemClose)
            Me.backstageViewControl1.Items.Add(Me.bvItemExit)
            Me.backstageViewControl1.Location = New System.Drawing.Point(12, 91)
            Me.backstageViewControl1.Name = "backstageViewControl1"
            Me.backstageViewControl1.Office2013StyleOptions.RightPaneContentVerticalOffset = 70
            Me.backstageViewControl1.Ribbon = Me.ribbonControl1
            Me.backstageViewControl1.SelectedTab = Me.backstageViewTabItem6
            Me.backstageViewControl1.SelectedTabIndex = 5
            Me.backstageViewControl1.Size = New System.Drawing.Size(967, 611)
            Me.backstageViewControl1.TabIndex = 9
            Me.backstageViewControl1.Text = "backstageViewControl1"
            '
            'backstageViewClientControl9
            '
            Me.backstageViewClientControl9.Controls.Add(Me.recentOpen)
            Me.backstageViewClientControl9.Location = New System.Drawing.Point(133, 71)
            Me.backstageViewClientControl9.Name = "backstageViewClientControl9"
            Me.backstageViewClientControl9.Size = New System.Drawing.Size(833, 539)
            Me.backstageViewClientControl9.TabIndex = 7
            '
            'recentOpen
            '
            Me.recentOpen.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.recentOpen.ContentPanelMinWidth = 100
            Me.recentOpen.DefaultContentPanel = Me.recentStackPanel1
            Me.recentOpen.Dock = System.Windows.Forms.DockStyle.Fill
            Me.recentOpen.Location = New System.Drawing.Point(0, 0)
            Me.recentOpen.MainPanel = Me.recentStackPanel2
            Me.recentOpen.MainPanelMinWidth = 100
            Me.recentOpen.MinimumSize = New System.Drawing.Size(400, 500)
            Me.recentOpen.Name = "recentOpen"
            Me.recentOpen.SelectedTab = Me.recentTabItem2
            Me.recentOpen.ShowTitle = False
            Me.recentOpen.Size = New System.Drawing.Size(833, 539)
            Me.recentOpen.TabIndex = 0
            Me.recentOpen.Text = "recentItemControl1"
            Me.recentOpen.Title = "Open"
            '
            'recentStackPanel1
            '
            Me.recentStackPanel1.Caption = "Computer"
            Me.recentStackPanel1.CaptionToContentIndent = 46
            Me.recentStackPanel1.Name = "recentStackPanel1"
            '
            'recentStackPanel2
            '
            Me.recentStackPanel2.Caption = "Open"
            Me.recentStackPanel2.CaptionToContentIndent = 46
            Me.recentStackPanel2.Items.AddRange(New DevExpress.XtraBars.Ribbon.RecentItemBase() {Me.recentTabItem1, Me.recentTabItem2})
            Me.recentStackPanel2.Name = "recentStackPanel2"
            '
            'recentTabItem1
            '
            Me.recentTabItem1.Caption = "Recent Documents"
            Me.recentTabItem1.Name = "recentTabItem1"
            Me.recentTabItem1.SuperTip = Nothing
            Me.recentTabItem1.TabPanel = Me.recentStackPanel3
            '
            'recentStackPanel3
            '
            Me.recentStackPanel3.Caption = "Recent Documents"
            Me.recentStackPanel3.CaptionToContentIndent = 46
            Me.recentStackPanel3.Name = "recentStackPanel3"
            '
            'recentTabItem2
            '
            Me.recentTabItem2.Caption = "Computer"
            Me.recentTabItem2.Name = "recentTabItem2"
            Me.recentTabItem2.SuperTip = Nothing
            Me.recentTabItem1.TabPanel = Me.recentStackPanel4
            '
            'recentStackPanel4
            '
            Me.recentStackPanel4.Caption = "Computer"
            Me.recentStackPanel4.CaptionToContentIndent = 46
            Me.recentStackPanel4.Name = "recentStackPanel4"
            '
            'backstageViewClientControl8
            '
            Me.backstageViewClientControl8.Controls.Add(Me.recentSaveAs)
            Me.backstageViewClientControl8.Location = New System.Drawing.Point(133, 71)
            Me.backstageViewClientControl8.Name = "backstageViewClientControl8"
            Me.backstageViewClientControl8.Size = New System.Drawing.Size(833, 539)
            Me.backstageViewClientControl8.TabIndex = 6
            '
            'recentSaveAs
            '
            Me.recentSaveAs.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.recentSaveAs.ContentPanelMinWidth = 100
            Me.recentSaveAs.DefaultContentPanel = Me.recentStackPanel5
            Me.recentSaveAs.Dock = System.Windows.Forms.DockStyle.Fill
            Me.recentSaveAs.Location = New System.Drawing.Point(0, 0)
            Me.recentSaveAs.MainPanel = recentStackPanel6
            Me.recentSaveAs.MainPanelMinWidth = 100
            Me.recentSaveAs.MinimumSize = New System.Drawing.Size(400, 500)
            Me.recentSaveAs.Name = "recentSaveAs"
            Me.recentSaveAs.SelectedTab = Me.recentTabItem3
            Me.recentSaveAs.ShowTitle = False
            Me.recentSaveAs.Size = New System.Drawing.Size(833, 539)
            Me.recentSaveAs.TabIndex = 0
            Me.recentSaveAs.Text = "recentItemControl1"
            Me.recentSaveAs.Title = "Save As"
            '
            'recentStackPanel5
            '
            Me.recentStackPanel5.Caption = "Computer"
            Me.recentStackPanel5.CaptionToContentIndent = 46
            Me.recentStackPanel5.Name = "recentStackPanel5"
            '
            'recentStackPanel6
            '
            Me.recentStackPanel6.Caption = "Save As"
            Me.recentStackPanel6.CaptionToContentIndent = 46
            Me.recentStackPanel6.Items.AddRange(New DevExpress.XtraBars.Ribbon.RecentItemBase() {Me.recentTabItem3})
            Me.recentStackPanel6.Name = "recentStackPanel6"
            '
            'recentTabItem3
            '
            Me.recentTabItem3.Caption = "Computer"
            Me.recentTabItem3.Name = "recentTabItem3"
            Me.recentTabItem3.SuperTip = Nothing
            Me.recentTabItem3.TabPanel = Me.recentStackPanel7
            '
            'recentStackPanel7
            '
            Me.recentStackPanel7.Caption = "Computer"
            Me.recentStackPanel7.CaptionToContentIndent = 46
            Me.recentStackPanel7.Name = "recentStackPanel7"
            '
            'backstageViewClientControl11
            '
            Me.backstageViewClientControl11.Controls.Add(Me.recentControlPrint)
            Me.backstageViewClientControl11.Location = New System.Drawing.Point(133, 71)
            Me.backstageViewClientControl11.Name = "backstageViewClientControl11"
            Me.backstageViewClientControl11.Size = New System.Drawing.Size(833, 539)
            Me.backstageViewClientControl11.TabIndex = 9
            '
            'recentControlPrint
            '
            Me.recentControlPrint.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.recentControlPrint.ContentPanelMinWidth = 100
            Me.recentControlPrint.Controls.Add(Me.recentPrintOptionsContainer)
            Me.recentControlPrint.Controls.Add(Me.recentPrintPreviewContainer)
            Me.recentControlPrint.DefaultContentPanel = Me.recentStackPanel8
            Me.recentControlPrint.Dock = System.Windows.Forms.DockStyle.Fill
            Me.recentControlPrint.Location = New System.Drawing.Point(0, 0)
            Me.recentControlPrint.MainPanel = Me.recentStackPanel9
            Me.recentControlPrint.MainPanelMinWidth = 100
            Me.recentControlPrint.Name = "recentControlPrint"
            Me.recentControlPrint.SelectedTab = Nothing
            Me.recentControlPrint.ShowTitle = False
            Me.recentControlPrint.Size = New System.Drawing.Size(833, 539)
            Me.recentControlPrint.TabIndex = 0
            Me.recentControlPrint.Text = "recentControl1"
            Me.recentControlPrint.Title = "Print"
            '
            'recentStackPanel8
            '
            Me.recentStackPanel8.Items.AddRange(New DevExpress.XtraBars.Ribbon.RecentItemBase() {Me.recentPrintPreview})
            Me.recentStackPanel8.Name = "recentStackPanel8"
            Me.recentStackPanel8.PanelPadding = New System.Windows.Forms.Padding(1)
            '
            'recentStackPanel9
            '
            Me.recentStackPanel9.Caption = "Print"
            Me.recentStackPanel9.Items.AddRange(New DevExpress.XtraBars.Ribbon.RecentItemBase() {Me.recentPrintOptions})
            Me.recentStackPanel9.Name = "recentStackPanel9"
            '
            'recentPrintOptionsContainer
            '
            Me.recentPrintOptionsContainer.Appearance.BackColor = System.Drawing.SystemColors.Control
            Me.recentPrintOptionsContainer.Appearance.Options.UseBackColor = True
            Me.recentPrintOptionsContainer.Controls.Add(Me.layoutControl1)
            Me.recentPrintOptionsContainer.Name = "recentPrintOptionsContainer"
            Me.recentPrintOptionsContainer.Size = New System.Drawing.Size(267, 441)
            Me.recentPrintOptionsContainer.TabIndex = 1
            '
            'layoutControl1
            '
            Me.layoutControl1.Controls.Add(Me.ddbDuplex)
            Me.layoutControl1.Controls.Add(Me.ddbOrientation)
            Me.layoutControl1.Controls.Add(Me.ddbPaperSize)
            Me.layoutControl1.Controls.Add(Me.ddbMargins)
            Me.layoutControl1.Controls.Add(Me.ddbCollate)
            Me.layoutControl1.Controls.Add(Me.backstageViewLabel2)
            Me.layoutControl1.Controls.Add(Me.ddbPrinter)
            Me.layoutControl1.Controls.Add(Me.printerLabel)
            Me.layoutControl1.Controls.Add(Me.printButton)
            Me.layoutControl1.Controls.Add(Me.copySpinEdit)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(267, 441)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            '
            'ddbDuplex
            '
            Me.ddbDuplex.Appearance.Options.UseTextOptions = True
            Me.ddbDuplex.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.ddbDuplex.Location = New System.Drawing.Point(2, 186)
            Me.ddbDuplex.Name = "ddbDuplex"
            Me.ddbDuplex.Size = New System.Drawing.Size(263, 52)
            Me.ddbDuplex.StyleController = Me.layoutControl1
            Me.ddbDuplex.TabIndex = 17
            Me.ddbDuplex.Text = "Print OneSided"
            '
            'ddbOrientation
            '
            Me.ddbOrientation.Appearance.Options.UseTextOptions = True
            Me.ddbOrientation.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.ddbOrientation.Location = New System.Drawing.Point(2, 242)
            Me.ddbOrientation.Name = "ddbOrientation"
            Me.ddbOrientation.Size = New System.Drawing.Size(263, 52)
            Me.ddbOrientation.StyleController = Me.layoutControl1
            Me.ddbOrientation.TabIndex = 13
            Me.ddbOrientation.Text = "Orientation"
            '
            'ddbPaperSize
            '
            Me.ddbPaperSize.Appearance.Options.UseTextOptions = True
            Me.ddbPaperSize.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.ddbPaperSize.Location = New System.Drawing.Point(2, 298)
            Me.ddbPaperSize.Name = "ddbPaperSize"
            Me.ddbPaperSize.Size = New System.Drawing.Size(263, 52)
            Me.ddbPaperSize.StyleController = Me.layoutControl1
            Me.ddbPaperSize.TabIndex = 15
            Me.ddbPaperSize.Text = "Paper Size"
            '
            'ddbMargins
            '
            Me.ddbMargins.Appearance.Options.UseTextOptions = True
            Me.ddbMargins.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.ddbMargins.Location = New System.Drawing.Point(2, 354)
            Me.ddbMargins.Name = "ddbMargins"
            Me.ddbMargins.Size = New System.Drawing.Size(263, 52)
            Me.ddbMargins.StyleController = Me.layoutControl1
            Me.ddbMargins.TabIndex = 14
            Me.ddbMargins.Text = "Margins"
            '
            'ddbCollate
            '
            Me.ddbCollate.Appearance.Options.UseTextOptions = True
            Me.ddbCollate.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.ddbCollate.Location = New System.Drawing.Point(2, 410)
            Me.ddbCollate.Name = "ddbCollate"
            Me.ddbCollate.Size = New System.Drawing.Size(263, 52)
            Me.ddbCollate.StyleController = Me.layoutControl1
            Me.ddbCollate.TabIndex = 16
            Me.ddbCollate.Text = "Collated"
            '
            'backstageViewLabel2
            '
            Me.backstageViewLabel2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.backstageViewLabel2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.backstageViewLabel2.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
            Me.backstageViewLabel2.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
            Me.backstageViewLabel2.LineVisible = True
            Me.backstageViewLabel2.Location = New System.Drawing.Point(2, 162)
            Me.backstageViewLabel2.Name = "backstageViewLabel2"
            Me.backstageViewLabel2.ShowLineShadow = False
            Me.backstageViewLabel2.Size = New System.Drawing.Size(263, 20)
            Me.backstageViewLabel2.StyleController = Me.layoutControl1
            Me.backstageViewLabel2.TabIndex = 12
            Me.backstageViewLabel2.Text = "Settings"
            '
            'ddbPrinter
            '
            Me.ddbPrinter.Appearance.Options.UseTextOptions = True
            Me.ddbPrinter.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.ddbPrinter.AutoWidthInLayoutControl = True
            Me.ddbPrinter.Location = New System.Drawing.Point(0, 104)
            Me.ddbPrinter.Name = "ddbPrinter"
            Me.ddbPrinter.Size = New System.Drawing.Size(267, 56)
            Me.ddbPrinter.StyleController = Me.layoutControl1
            Me.ddbPrinter.TabIndex = 11
            Me.ddbPrinter.Text = "Printer"
            '
            'printerLabel
            '
            Me.printerLabel.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.printerLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.printerLabel.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
            Me.printerLabel.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
            Me.printerLabel.LineVisible = True
            Me.printerLabel.Location = New System.Drawing.Point(2, 82)
            Me.printerLabel.Name = "printerLabel"
            Me.printerLabel.ShowLineShadow = False
            Me.printerLabel.Size = New System.Drawing.Size(263, 20)
            Me.printerLabel.StyleController = Me.layoutControl1
            Me.printerLabel.TabIndex = 10
            Me.printerLabel.Text = "Printer"
            '
            'printButton
            '
            Me.printButton.Image = CType(resources.GetObject("printButton.Image"), System.Drawing.Image)
            Me.printButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
            Me.printButton.Location = New System.Drawing.Point(2, 2)
            Me.printButton.Name = "printButton"
            Me.printButton.Size = New System.Drawing.Size(80, 76)
            Me.printButton.StyleController = Me.layoutControl1
            Me.printButton.TabIndex = 5
            Me.printButton.Text = "Print"
            '
            'copySpinEdit
            '
            Me.copySpinEdit.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.copySpinEdit.Location = New System.Drawing.Point(143, 2)
            Me.copySpinEdit.Name = "copySpinEdit"
            Me.copySpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.copySpinEdit.Properties.IsFloatValue = False
            Me.copySpinEdit.Properties.Mask.EditMask = "N00"
            Me.copySpinEdit.Properties.MaxValue = New Decimal(New Integer() {30, 0, 0, 0})
            Me.copySpinEdit.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.copySpinEdit.Size = New System.Drawing.Size(101, 20)
            Me.copySpinEdit.StyleController = Me.layoutControl1
            Me.copySpinEdit.TabIndex = 6
            '
            'layoutControlGroup1
            '
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.lciCopiesSpinEdit, Me.layoutControlItem3, Me.layoutControlItem2, Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem6, Me.layoutControlItem7, Me.layoutControlItem8, Me.layoutControlItem9})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(267, 464)
            Me.layoutControlGroup1.TextVisible = False
            '
            'layoutControlItem1
            '
            Me.layoutControlItem1.Control = Me.printButton
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.MaxSize = New System.Drawing.Size(84, 80)
            Me.layoutControlItem1.MinSize = New System.Drawing.Size(84, 80)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(84, 80)
            Me.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            '
            'lciCopiesSpinEdit
            '
            Me.lciCopiesSpinEdit.Control = Me.copySpinEdit
            Me.lciCopiesSpinEdit.CustomizationFormText = "Copies:"
            Me.lciCopiesSpinEdit.Location = New System.Drawing.Point(84, 0)
            Me.lciCopiesSpinEdit.MaxSize = New System.Drawing.Size(180, 24)
            Me.lciCopiesSpinEdit.MinSize = New System.Drawing.Size(180, 24)
            Me.lciCopiesSpinEdit.Name = "lciCopiesSpinEdit"
            Me.lciCopiesSpinEdit.Padding = New DevExpress.XtraLayout.Utils.Padding(20, 20, 2, 2)
            Me.lciCopiesSpinEdit.Size = New System.Drawing.Size(183, 80)
            Me.lciCopiesSpinEdit.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.lciCopiesSpinEdit.Text = "Copies:"
            Me.lciCopiesSpinEdit.TextSize = New System.Drawing.Size(36, 13)
            '
            'layoutControlItem3
            '
            Me.layoutControlItem3.Control = Me.printerLabel
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 80)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(267, 24)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            '
            'layoutControlItem2
            '
            Me.layoutControlItem2.Control = Me.ddbPrinter
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 104)
            Me.layoutControlItem2.MaxSize = New System.Drawing.Size(0, 56)
            Me.layoutControlItem2.MinSize = New System.Drawing.Size(100, 56)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem2.Size = New System.Drawing.Size(267, 56)
            Me.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            '
            'layoutControlItem4
            '
            Me.layoutControlItem4.Control = Me.backstageViewLabel2
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 160)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(267, 24)
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            '
            'layoutControlItem5
            '
            Me.layoutControlItem5.Control = Me.ddbDuplex
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 184)
            Me.layoutControlItem5.MaxSize = New System.Drawing.Size(0, 56)
            Me.layoutControlItem5.MinSize = New System.Drawing.Size(100, 56)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(267, 56)
            Me.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem5.TextVisible = False
            '
            'layoutControlItem6
            '
            Me.layoutControlItem6.Control = Me.ddbOrientation
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 240)
            Me.layoutControlItem6.MaxSize = New System.Drawing.Size(0, 56)
            Me.layoutControlItem6.MinSize = New System.Drawing.Size(83, 56)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(267, 56)
            Me.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem6.TextVisible = False
            '
            'layoutControlItem7
            '
            Me.layoutControlItem7.Control = Me.ddbPaperSize
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 296)
            Me.layoutControlItem7.MaxSize = New System.Drawing.Size(0, 56)
            Me.layoutControlItem7.MinSize = New System.Drawing.Size(79, 56)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Size = New System.Drawing.Size(267, 56)
            Me.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem7.TextVisible = False
            '
            'layoutControlItem8
            '
            Me.layoutControlItem8.Control = Me.ddbMargins
            Me.layoutControlItem8.Location = New System.Drawing.Point(0, 352)
            Me.layoutControlItem8.MaxSize = New System.Drawing.Size(0, 56)
            Me.layoutControlItem8.MinSize = New System.Drawing.Size(66, 56)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.Size = New System.Drawing.Size(267, 56)
            Me.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem8.TextVisible = False
            '
            'layoutControlItem9
            '
            Me.layoutControlItem9.Control = Me.ddbCollate
            Me.layoutControlItem9.Location = New System.Drawing.Point(0, 408)
            Me.layoutControlItem9.MaxSize = New System.Drawing.Size(0, 56)
            Me.layoutControlItem9.MinSize = New System.Drawing.Size(68, 56)
            Me.layoutControlItem9.Name = "layoutControlItem9"
            Me.layoutControlItem9.Size = New System.Drawing.Size(267, 56)
            Me.layoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem9.TextVisible = False
            '
            'recentPrintPreviewContainer
            '
            Me.recentPrintPreviewContainer.Appearance.BackColor = System.Drawing.SystemColors.Control
            Me.recentPrintPreviewContainer.Appearance.Options.UseBackColor = True
            Me.recentPrintPreviewContainer.Controls.Add(Me.panelControl2)
            Me.recentPrintPreviewContainer.Name = "recentPrintPreviewContainer"
            Me.recentPrintPreviewContainer.Size = New System.Drawing.Size(500, 527)
            Me.recentPrintPreviewContainer.TabIndex = 2
            '
            'panelControl2
            '
            Me.panelControl2.Controls.Add(Me.printControl2)
            Me.panelControl2.Controls.Add(Me.panelControl3)
            Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl2.Location = New System.Drawing.Point(0, 0)
            Me.panelControl2.Name = "panelControl2"
            Me.panelControl2.Size = New System.Drawing.Size(500, 527)
            Me.panelControl2.TabIndex = 0
            '
            'printControl2
            '
            Me.printControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.printControl2.IsMetric = True
            Me.printControl2.Location = New System.Drawing.Point(2, 2)
            Me.printControl2.Name = "printControl2"
            Me.printControl2.Size = New System.Drawing.Size(496, 495)
            Me.printControl2.TabIndex = 3
            '
            'panelControl3
            '
            Me.panelControl3.Controls.Add(Me.zoomTextEdit)
            Me.panelControl3.Controls.Add(Me.panel2)
            Me.panelControl3.Controls.Add(Me.pageButtonEdit)
            Me.panelControl3.Controls.Add(Me.zoomTrackBarControl1)
            Me.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panelControl3.Location = New System.Drawing.Point(2, 497)
            Me.panelControl3.Name = "panelControl3"
            Me.panelControl3.Size = New System.Drawing.Size(496, 28)
            Me.panelControl3.TabIndex = 2
            '
            'zoomTextEdit
            '
            Me.zoomTextEdit.Dock = System.Windows.Forms.DockStyle.Right
            Me.zoomTextEdit.EditValue = CType(100, Short)
            Me.zoomTextEdit.Location = New System.Drawing.Point(197, 2)
            Me.zoomTextEdit.Name = "zoomTextEdit"
            Me.zoomTextEdit.Properties.DisplayFormat.FormatString = "{0}%"
            Me.zoomTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.zoomTextEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.zoomTextEdit.Properties.Mask.EditMask = "n0"
            Me.zoomTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.zoomTextEdit.Size = New System.Drawing.Size(73, 20)
            Me.zoomTextEdit.TabIndex = 6
            '
            'panel2
            '
            Me.panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.panel2.Location = New System.Drawing.Point(270, 2)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(10, 24)
            Me.panel2.TabIndex = 5
            '
            'pageButtonEdit
            '
            Me.pageButtonEdit.Dock = System.Windows.Forms.DockStyle.Left
            Me.pageButtonEdit.EditValue = "1"
            Me.pageButtonEdit.Location = New System.Drawing.Point(2, 2)
            Me.pageButtonEdit.Name = "pageButtonEdit"
            Me.pageButtonEdit.Properties.Appearance.Options.UseTextOptions = True
            Me.pageButtonEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.pageButtonEdit.Properties.AutoHeight = False
            Me.pageButtonEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pageButtonEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Left, "", -1, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Right)})
            Me.pageButtonEdit.Properties.DisplayFormat.FormatString = "Page {0} of 1"
            Me.pageButtonEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.pageButtonEdit.Size = New System.Drawing.Size(118, 24)
            Me.pageButtonEdit.TabIndex = 4
            '
            'zoomTrackBarControl1
            '
            Me.zoomTrackBarControl1.Dock = System.Windows.Forms.DockStyle.Right
            Me.zoomTrackBarControl1.EditValue = 40
            Me.zoomTrackBarControl1.Location = New System.Drawing.Point(280, 2)
            Me.zoomTrackBarControl1.MenuManager = Me.ribbonControl1
            Me.zoomTrackBarControl1.Name = "zoomTrackBarControl1"
            Me.zoomTrackBarControl1.Properties.Maximum = 80
            Me.zoomTrackBarControl1.Properties.Middle = 40
            Me.zoomTrackBarControl1.Properties.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight
            Me.zoomTrackBarControl1.Properties.SmallChange = 2
            Me.zoomTrackBarControl1.Size = New System.Drawing.Size(214, 24)
            Me.zoomTrackBarControl1.TabIndex = 0
            Me.zoomTrackBarControl1.Value = 40
            '
            'recentPrintPreview
            '
            Me.recentPrintPreview.ControlContainer = Me.recentPrintPreviewContainer
            Me.recentPrintPreview.FillSpace = True
            Me.recentPrintPreview.Name = "recentPrintPreview"
            Me.recentPrintPreview.SuperTip = Nothing
            '
            'recentPrintOptions
            '
            Me.recentPrintOptions.ControlContainer = Me.recentPrintOptionsContainer
            Me.recentPrintOptions.FillSpace = True
            Me.recentPrintOptions.Name = "recentPrintOptions"
            Me.recentPrintOptions.SuperTip = Nothing
            '
            'backstageViewClientControl10
            '
            Me.backstageViewClientControl10.Controls.Add(Me.recentControlExport)
            Me.backstageViewClientControl10.Location = New System.Drawing.Point(133, 71)
            Me.backstageViewClientControl10.Name = "backstageViewClientControl10"
            Me.backstageViewClientControl10.Size = New System.Drawing.Size(833, 539)
            Me.backstageViewClientControl10.TabIndex = 8
            '
            'recentControlExport
            '
            Me.recentControlExport.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.recentControlExport.ContentPanelMinWidth = 100
            Me.recentControlExport.DefaultContentPanel = Me.recentStackPanel14
            Me.recentControlExport.Dock = System.Windows.Forms.DockStyle.Fill
            Me.recentControlExport.Location = New System.Drawing.Point(0, 0)
            Me.recentControlExport.MainPanel = Me.recentStackPanel10
            Me.recentControlExport.MainPanelMinWidth = 100
            Me.recentControlExport.MinimumSize = New System.Drawing.Size(400, 100)
            Me.recentControlExport.Name = "recentControlExport"
            Me.recentControlExport.SelectedTab = Me.recentTabItem4
            Me.recentControlExport.ShowTitle = False
            Me.recentControlExport.Size = New System.Drawing.Size(833, 539)
            Me.recentControlExport.TabIndex = 0
            Me.recentControlExport.Text = "recentItemControl1"
            Me.recentControlExport.Title = "Title"
            '
            'recentStackPanel14
            '
            Me.recentStackPanel14.Name = "recentStackPanel14"
            '
            'recentStackPanel10
            '
            Me.recentStackPanel10.Caption = "Export"
            Me.recentStackPanel10.CaptionToContentIndent = 46
            Me.recentStackPanel10.Items.AddRange(New DevExpress.XtraBars.Ribbon.RecentItemBase() {Me.recentTabItem4})
            Me.recentStackPanel10.Name = "recentStackPanel10"
            '
            'recentTabItem4
            '
            Me.recentTabItem4.Caption = "Export To"
            Me.recentTabItem4.Name = "recentTabItem4"
            Me.recentTabItem4.SuperTip = Nothing
            Me.recentTabItem4.TabPanel = Me.recentStackPanel11
            '
            'recentStackPanel11
            '
            Me.recentStackPanel11.Caption = "Export To"
            Me.recentStackPanel11.CaptionToContentIndent = 46
            Me.recentStackPanel11.Items.AddRange(New DevExpress.XtraBars.Ribbon.RecentItemBase() {
                                                 Me.recentControlRecentItem1,
                                                 Me.recentControlRecentItem2,
                                                 Me.recentControlRecentItem4,
                                                 Me.recentControlRecentItem5,
                                                 Me.recentControlRecentItem6,
                                                 Me.recentControlRecentItem7,
                                                 Me.recentControlRecentItem8,
                                                 Me.recentControlRecentItem9})
            Me.recentStackPanel11.Name = "recentStackPanel11"
            '
            'recentControlRecentItem1
            '
            Me.recentControlRecentItem1.Caption = "PDF  File"
            Me.recentControlRecentItem1.Description = "Adobe Portable Document Format"
            Me.recentControlRecentItem1.Glyph = CType(resources.GetObject("recentControlRecentItem1.Glyph"), System.Drawing.Image)
            Me.recentControlRecentItem1.GlyphAlignment = DevExpress.XtraBars.Ribbon.RecentPinItemGlyphAlignment.Center
            Me.recentControlRecentItem1.Name = "recentControlRecentItem1"
            Me.recentControlRecentItem1.PinButtonVisibility = DevExpress.XtraBars.Ribbon.RecentPinButtonVisibility.Never
            Me.recentControlRecentItem1.SuperTip = Nothing
            '
            'recentControlRecentItem2
            '
            Me.recentControlRecentItem2.Caption = "HTML File"
            Me.recentControlRecentItem2.Description = "Web Page"
            Me.recentControlRecentItem2.Glyph = CType(resources.GetObject("recentControlRecentItem2.Glyph"), System.Drawing.Image)
            Me.recentControlRecentItem2.GlyphAlignment = DevExpress.XtraBars.Ribbon.RecentPinItemGlyphAlignment.Center
            Me.recentControlRecentItem2.Name = "recentControlRecentItem2"
            Me.recentControlRecentItem2.PinButtonVisibility = DevExpress.XtraBars.Ribbon.RecentPinButtonVisibility.Never
            Me.recentControlRecentItem2.SuperTip = Nothing
            '
            'recentControlRecentItem4
            '
            Me.recentControlRecentItem4.Caption = "MHT File"
            Me.recentControlRecentItem4.Description = "Single File Web Page"
            Me.recentControlRecentItem4.Glyph = CType(resources.GetObject("recentControlRecentItem4.Glyph"), System.Drawing.Image)
            Me.recentControlRecentItem4.GlyphAlignment = DevExpress.XtraBars.Ribbon.RecentPinItemGlyphAlignment.Center
            Me.recentControlRecentItem4.Name = "recentControlRecentItem4"
            Me.recentControlRecentItem4.PinButtonVisibility = DevExpress.XtraBars.Ribbon.RecentPinButtonVisibility.Never
            Me.recentControlRecentItem4.SuperTip = Nothing
            '
            'recentControlRecentItem5
            '
            Me.recentControlRecentItem5.Caption = "RTF File"
            Me.recentControlRecentItem5.Description = "Rich Text Format"
            Me.recentControlRecentItem5.Glyph = CType(resources.GetObject("recentControlRecentItem5.Glyph"), System.Drawing.Image)
            Me.recentControlRecentItem5.GlyphAlignment = DevExpress.XtraBars.Ribbon.RecentPinItemGlyphAlignment.Center
            Me.recentControlRecentItem5.Name = "recentControlRecentItem5"
            Me.recentControlRecentItem5.PinButtonVisibility = DevExpress.XtraBars.Ribbon.RecentPinButtonVisibility.Never
            Me.recentControlRecentItem5.SuperTip = Nothing
            '
            'recentControlRecentItem6
            '
            Me.recentControlRecentItem6.Caption = "XLS File"
            Me.recentControlRecentItem6.Description = "Microsoft Excel 2000-2003 Workbook"
            Me.recentControlRecentItem6.Glyph = CType(resources.GetObject("recentControlRecentItem6.Glyph"), System.Drawing.Image)
            Me.recentControlRecentItem6.GlyphAlignment = DevExpress.XtraBars.Ribbon.RecentPinItemGlyphAlignment.Center
            Me.recentControlRecentItem6.Name = "recentControlRecentItem6"
            Me.recentControlRecentItem6.PinButtonVisibility = DevExpress.XtraBars.Ribbon.RecentPinButtonVisibility.Never
            Me.recentControlRecentItem6.SuperTip = Nothing
            '
            'recentControlRecentItem7
            '
            Me.recentControlRecentItem7.Caption = "XLSX File"
            Me.recentControlRecentItem7.Description = "Microsoft Excel 2007-2016 Workbook"
            Me.recentControlRecentItem7.Glyph = CType(resources.GetObject("recentControlRecentItem7.Glyph"), System.Drawing.Image)
            Me.recentControlRecentItem7.GlyphAlignment = DevExpress.XtraBars.Ribbon.RecentPinItemGlyphAlignment.Center
            Me.recentControlRecentItem7.Name = "recentControlRecentItem7"
            Me.recentControlRecentItem7.PinButtonVisibility = DevExpress.XtraBars.Ribbon.RecentPinButtonVisibility.Never
            Me.recentControlRecentItem7.SuperTip = Nothing
            '
            'recentControlRecentItem8
            '
            Me.recentControlRecentItem8.Caption = "CSV File"
            Me.recentControlRecentItem8.Description = "Comma-Separated Values Text"
            Me.recentControlRecentItem8.Glyph = CType(resources.GetObject("recentControlRecentItem8.Glyph"), System.Drawing.Image)
            Me.recentControlRecentItem8.GlyphAlignment = DevExpress.XtraBars.Ribbon.RecentPinItemGlyphAlignment.Center
            Me.recentControlRecentItem8.Name = "recentControlRecentItem8"
            Me.recentControlRecentItem8.PinButtonVisibility = DevExpress.XtraBars.Ribbon.RecentPinButtonVisibility.Never
            Me.recentControlRecentItem8.SuperTip = Nothing
            '
            'recentControlRecentItem9
            '
            Me.recentControlRecentItem9.Caption = "Text File"
            Me.recentControlRecentItem9.Description = "Plain Text"
            Me.recentControlRecentItem9.Glyph = CType(resources.GetObject("recentControlRecentItem9.Glyph"), System.Drawing.Image)
            Me.recentControlRecentItem9.GlyphAlignment = DevExpress.XtraBars.Ribbon.RecentPinItemGlyphAlignment.Center
            Me.recentControlRecentItem9.Name = "recentControlRecentItem9"
            Me.recentControlRecentItem9.PinButtonVisibility = DevExpress.XtraBars.Ribbon.RecentPinButtonVisibility.Never
            Me.recentControlRecentItem9.SuperTip = Nothing
            '
            'backstageViewClientControl2
            '
            Me.backstageViewClientControl2.Controls.Add(Me.recentItemControl1)
            Me.backstageViewClientControl2.Location = New System.Drawing.Point(133, 71)
            Me.backstageViewClientControl2.Name = "backstageViewClientControl2"
            Me.backstageViewClientControl2.Size = New System.Drawing.Size(833, 539)
            Me.backstageViewClientControl2.TabIndex = 10
            '
            'recentItemControl1
            '
            Me.recentItemControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.recentItemControl1.ContentPanelMinWidth = 350
            Me.recentItemControl1.DefaultContentPanel = Me.recentStackPanel12
            Me.recentItemControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.recentItemControl1.Location = New System.Drawing.Point(0, 0)
            Me.recentItemControl1.MainPanel = Me.recentStackPanel13
            Me.recentItemControl1.MainPanelMinWidth = 530
            Me.recentItemControl1.Name = "recentItemControl1"
            Me.recentItemControl1.SelectedTab = Nothing
            Me.recentItemControl1.ShowTitle = False
            Me.recentItemControl1.Size = New System.Drawing.Size(833, 539)
            Me.recentItemControl1.SplitterPosition = 530
            Me.recentItemControl1.TabIndex = 0
            Me.recentItemControl1.Text = "recentItemControl1"
            Me.recentItemControl1.Title = "Title"
            '
            'recentStackPanel12
            '
            Me.recentStackPanel12.Caption = "About"
            Me.recentStackPanel12.CaptionToContentIndent = 46
            Me.recentStackPanel12.Items.AddRange(New DevExpress.XtraBars.Ribbon.RecentItemBase() {
                                                 Me.recentLabelItem1,
                                                 Me.recentHyperlinkItem1,
                                                 Me.recentLabelItem2})
            Me.recentStackPanel12.Name = "recentStackPanel12"
            '
            'recentStackPanel13
            '
            Me.recentStackPanel13.Caption = "Support"
            Me.recentStackPanel13.CaptionToContentIndent = 46
            Me.recentStackPanel13.Items.AddRange(New DevExpress.XtraBars.Ribbon.RecentItemBase() {
                                                 Me.recentPinItem2,
                                                 Me.recentPinItem3,
                                                 Me.recentPinItem4})
            Me.recentStackPanel13.Name = "recentStackPanel13"
            '
            'recentLabelItem1
            '
            Me.recentLabelItem1.Caption = Nothing
            Me.recentLabelItem1.Glyph = Global.Resources.XtraBars
            Me.recentLabelItem1.Name = "recentLabelItem1"
            Me.recentLabelItem1.SuperTip = Nothing
            '
            'recentHyperlinkItem1
            '
            Me.recentHyperlinkItem1.AllowSelect = DevExpress.Utils.DefaultBoolean.[False]
            Me.recentHyperlinkItem1.Caption = "www.devexpress.com"
            Me.recentHyperlinkItem1.LinkColor = System.Drawing.Color.Empty
            Me.recentHyperlinkItem1.Name = "recentHyperlinkItem1"
            Me.recentHyperlinkItem1.SuperTip = Nothing
            Me.recentHyperlinkItem1.VisitedColor = System.Drawing.Color.Empty
            '
            'recentLabelItem2
            '
            Me.recentLabelItem2.AllowSelect = DevExpress.Utils.DefaultBoolean.[False]
            Me.recentLabelItem2.Caption = "Copyright (c) 2000-2013 DevExpress inc. ALL RIGHTS RESERVED."
            Me.recentLabelItem2.Name = "recentLabelItem2"
            Me.recentLabelItem2.SuperTip = Nothing
            '
            'recentPinItem2
            '
            Me.recentPinItem2.Caption = "DevExpress Online Help"
            Me.recentPinItem2.Description = "Get help using DevExpress components"
            Me.recentPinItem2.Glyph = Global.Resources.Online_Help
            Me.recentPinItem2.GlyphAlignment = DevExpress.XtraBars.Ribbon.RecentPinItemGlyphAlignment.Center
            Me.recentPinItem2.Name = "recentPinItem2"
            Me.recentPinItem2.PinButtonVisibility = DevExpress.XtraBars.Ribbon.RecentPinButtonVisibility.Never
            Me.recentPinItem2.SuperTip = Nothing
            '
            'recentPinItem3
            '
            Me.recentPinItem3.Caption = "Getting Started"
            Me.recentPinItem3.Description = "See what's new and find resources to help you learn the basics quickly."
            Me.recentPinItem3.Glyph = Global.Resources.Code_Central
            Me.recentPinItem3.GlyphAlignment = DevExpress.XtraBars.Ribbon.RecentPinItemGlyphAlignment.Center
            Me.recentPinItem3.Name = "recentPinItem3"
            Me.recentPinItem3.PinButtonVisibility = DevExpress.XtraBars.Ribbon.RecentPinButtonVisibility.Never
            Me.recentPinItem3.SuperTip = Nothing
            '
            'recentPinItem4
            '
            Me.recentPinItem4.Caption = "Contact Us"
            Me.recentPinItem4.Description = "Let us know if you need help or how we can make our components better"
            Me.recentPinItem4.Glyph = Global.Resources.Contact_Us
            Me.recentPinItem4.GlyphAlignment = DevExpress.XtraBars.Ribbon.RecentPinItemGlyphAlignment.Center
            Me.recentPinItem4.Name = "recentPinItem4"
            Me.recentPinItem4.PinButtonVisibility = DevExpress.XtraBars.Ribbon.RecentPinButtonVisibility.Never
            Me.recentPinItem4.SuperTip = Nothing
            '
            'backstageViewTabItem3
            '
            Me.backstageViewTabItem3.Caption = "Open"
            Me.backstageViewTabItem3.ContentControl = Me.backstageViewClientControl9
            Me.backstageViewTabItem3.Name = "backstageViewTabItem3"
            Me.backstageViewTabItem3.Selected = False
            '
            'bvItemSave
            '
            Me.bvItemSave.Caption = "Save"
            Me.bvItemSave.Name = "bvItemSave"
            '
            'backstageViewTabItem1
            '
            Me.backstageViewTabItem1.Caption = "Save As"
            Me.backstageViewTabItem1.ContentControl = Me.backstageViewClientControl8
            Me.backstageViewTabItem1.Name = "backstageViewTabItem1"
            Me.backstageViewTabItem1.Selected = False
            '
            'backstageViewTabItem5
            '
            Me.backstageViewTabItem5.Caption = "Print"
            Me.backstageViewTabItem5.ContentControl = Me.backstageViewClientControl11
            Me.backstageViewTabItem5.Name = "backstageViewTabItem5"
            Me.backstageViewTabItem5.Selected = False
            '
            'backstageViewTabItem4
            '
            Me.backstageViewTabItem4.Caption = "Export"
            Me.backstageViewTabItem4.ContentControl = Me.backstageViewClientControl10
            Me.backstageViewTabItem4.Name = "backstageViewTabItem4"
            Me.backstageViewTabItem4.Selected = False
            '
            'backstageViewTabItem6
            '
            Me.backstageViewTabItem6.Caption = "Help"
            Me.backstageViewTabItem6.ContentControl = Me.backstageViewClientControl2
            Me.backstageViewTabItem6.Name = "backstageViewTabItem6"
            Me.backstageViewTabItem6.Selected = True
            '
            'bvItemClose
            '
            Me.bvItemClose.Caption = "Close"
            Me.bvItemClose.Name = "bvItemClose"
            '
            'bvItemExit
            '
            Me.bvItemExit.Caption = "Exit"
            Me.bvItemExit.Name = "bvItemExit"
            '
            'printControl1
            '
            Me.printControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.printControl1.IsMetric = True
            Me.printControl1.Location = New System.Drawing.Point(0, 0)
            Me.printControl1.Name = "printControl1"
            Me.printControl1.Size = New System.Drawing.Size(639, 539)
            Me.printControl1.TabIndex = 3
            '
            'recentControlRecentItem10
            '
            Me.recentControlRecentItem10.Caption = "Image File"
            Me.recentControlRecentItem10.Description = "BMP, GIF, JPEG, PNG, TIFF, EMF, WMF"
            Me.recentControlRecentItem10.Glyph = CType(resources.GetObject("recentControlRecentItem10.Glyph"), System.Drawing.Image)
            Me.recentControlRecentItem10.GlyphAlignment = DevExpress.XtraBars.Ribbon.RecentPinItemGlyphAlignment.Center
            Me.recentControlRecentItem10.Name = "recentControlRecentItem10"
            Me.recentControlRecentItem10.PinButtonVisibility = DevExpress.XtraBars.Ribbon.RecentPinButtonVisibility.Never
            Me.recentControlRecentItem10.SuperTip = Nothing
            '
            'recentControlButtonItem1
            '
            Me.recentControlButtonItem1.Caption = "Save As"
            Me.recentControlButtonItem1.Name = "recentControlButtonItem1"
            Me.recentControlButtonItem1.Orientation = System.Windows.Forms.Orientation.Vertical
            Me.recentControlButtonItem1.Size = New System.Drawing.Size(89, 92)
            Me.recentControlButtonItem1.SuperTip = Nothing
            '
            'backstageViewClientControl7
            '
            Me.backstageViewClientControl7.Location = New System.Drawing.Point(0, 0)
            Me.backstageViewClientControl7.Name = "backstageViewClientControl7"
            Me.backstageViewClientControl7.Size = New System.Drawing.Size(150, 150)
            Me.backstageViewClientControl7.TabIndex = 6
            '
            'backstageViewClientControl1
            '
            Me.backstageViewClientControl1.Location = New System.Drawing.Point(0, 0)
            Me.backstageViewClientControl1.Name = "backstageViewClientControl1"
            Me.backstageViewClientControl1.Size = New System.Drawing.Size(150, 150)
            Me.backstageViewClientControl1.TabIndex = 0
            '
            'backstageViewClientControl3
            '
            Me.backstageViewClientControl3.Location = New System.Drawing.Point(0, 0)
            Me.backstageViewClientControl3.Name = "backstageViewClientControl3"
            Me.backstageViewClientControl3.Size = New System.Drawing.Size(150, 150)
            Me.backstageViewClientControl3.TabIndex = 2
            '
            'taskbarAssistant1
            '
            Me.taskbarAssistant1.ParentControl = Me
            Me.taskbarAssistant1.ThumbnailButtons.Add(Me.thumbButtonNewDoc)
            Me.taskbarAssistant1.ThumbnailButtons.Add(Me.thumbButtonPrev)
            Me.taskbarAssistant1.ThumbnailButtons.Add(Me.thumbButtonNext)
            Me.taskbarAssistant1.ThumbnailButtons.Add(Me.thumbButtonExit)
            '
            'thumbButtonNewDoc
            '
            Me.thumbButtonNewDoc.Image = CType(resources.GetObject("thumbButtonNewDoc.Image"), System.Drawing.Bitmap)
            Me.thumbButtonNewDoc.Tooltip = "Create New Document"
            '
            'thumbButtonPrev
            '
            Me.thumbButtonPrev.Image = CType(resources.GetObject("thumbButtonPrev.Image"), System.Drawing.Bitmap)
            Me.thumbButtonPrev.Tooltip = "Previous Document"
            '
            'thumbButtonNext
            '
            Me.thumbButtonNext.Image = CType(resources.GetObject("thumbButtonNext.Image"), System.Drawing.Bitmap)
            Me.thumbButtonNext.Tooltip = "Next Document"
            '
            'thumbButtonExit
            '
            Me.thumbButtonExit.Image = CType(resources.GetObject("thumbButtonExit.Image"), System.Drawing.Bitmap)
            Me.thumbButtonExit.Tooltip = "Exit"
            '
            'backstageViewTabItem2
            '
            Me.backstageViewTabItem2.Caption = "Open"
            Me.backstageViewTabItem2.ContentControl = Me.backstageViewClientControl8
            Me.backstageViewTabItem2.Name = "backstageViewTabItem2"
            Me.backstageViewTabItem2.Selected = False
            '
            'bvTabPrint
            '
            Me.bvTabPrint.Caption = "Print"
            Me.bvTabPrint.ContentControl = Nothing
            Me.bvTabPrint.Name = "bvTabPrint"
            Me.bvTabPrint.Selected = False
            '
            'backstageViewClientControl4
            '
            Me.backstageViewClientControl4.Controls.Add(Me.printControl1)
            Me.backstageViewClientControl4.Location = New System.Drawing.Point(133, 71)
            Me.backstageViewClientControl4.Name = "backstageViewClientControl4"
            Me.backstageViewClientControl4.Size = New System.Drawing.Size(639, 539)
            Me.backstageViewClientControl4.TabIndex = 3
            '
            'frmMain
            '
            Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[False]
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
            Me.ClientSize = New System.Drawing.Size(1057, 741)
            Me.Controls.Add(Me.backstageViewControl1)
            Me.Controls.Add(Me.pccBottom)
            Me.Controls.Add(Me.pccAppMenu)
            Me.Controls.Add(Me.ribbonStatusBar1)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.IsMdiContainer = True
            Me.Name = "frmMain"
            Me.Ribbon = Me.ribbonControl1
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StatusBar = Me.ribbonStatusBar1
            Me.Text = "SimplePad (C# Demo)"
            CType(Me.gddFont, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.popupControlContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pmAppMain, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pccBottom, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pccBottom.ResumeLayout(False)
            CType(Me.imageCollection2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pmNew, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pccAppMenu, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pccAppMenu.ResumeLayout(False)
            CType(Me.pcAppMenuFileLabels, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gddFontColor, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.riicStyle, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemTrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pmMain, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.imageCollection3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.backstageViewControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.backstageViewControl1.ResumeLayout(False)
            Me.backstageViewClientControl9.ResumeLayout(False)
            CType(Me.recentOpen, System.ComponentModel.ISupportInitialize).EndInit()
            Me.backstageViewClientControl8.ResumeLayout(False)
            CType(Me.recentSaveAs, System.ComponentModel.ISupportInitialize).EndInit()
            Me.backstageViewClientControl11.ResumeLayout(False)
            CType(Me.recentControlPrint, System.ComponentModel.ISupportInitialize).EndInit()
            Me.recentControlPrint.ResumeLayout(False)
            Me.recentPrintOptionsContainer.ResumeLayout(False)
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType(Me.copySpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciCopiesSpinEdit, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
            Me.recentPrintPreviewContainer.ResumeLayout(False)
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl2.ResumeLayout(False)
            CType(Me.panelControl3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl3.ResumeLayout(False)
            Me.panelControl3.PerformLayout()
            CType(Me.zoomTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pageButtonEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.zoomTrackBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.zoomTrackBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.backstageViewClientControl10.ResumeLayout(False)
            CType(Me.recentControlExport, System.ComponentModel.ISupportInitialize).EndInit()
            Me.backstageViewClientControl2.ResumeLayout(False)
            CType(Me.recentItemControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.backstageViewClientControl4.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region
		Private WithEvents iClose As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iSave As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iOpen As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iSaveAs As DevExpress.XtraBars.BarButtonItem
		Private WithEvents idNew As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iExit As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iPrint As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iClear As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iPaste As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iFind As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iCut As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iCopy As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iUndo As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iReplace As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iSelectAll As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iBold As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iAlignRight As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iCenter As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iUnderline As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iAlignLeft As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iItalic As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iFont As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iBullets As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iProtected As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iFontColor As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iWeb As DevExpress.XtraBars.BarButtonItem
		Private siPosition As DevExpress.XtraBars.BarButtonItem
		Private siModified As DevExpress.XtraBars.BarButtonItem
		Private siDocName As DevExpress.XtraBars.BarStaticItem
		Private popupControlContainer1 As DevExpress.XtraBars.PopupControlContainer
		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
		Private WithEvents ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
		Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
		Private WithEvents ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private WithEvents ribbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private ribbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private WithEvents ribbonPageGroup9 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private ribbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
		Private ribbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private ribbonPageGroup6 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private ribbonPageGroup7 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private WithEvents xtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
		Private imageCollection1 As DevExpress.Utils.ImageCollection
		Private ribbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
		Private bgAlign As DevExpress.XtraBars.BarButtonGroup
		Private bgFontStyle As DevExpress.XtraBars.BarButtonGroup
		Private bgFont As DevExpress.XtraBars.BarButtonGroup
		Private bgBullets As DevExpress.XtraBars.BarButtonGroup
		Private ribbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private sbiSave As DevExpress.XtraBars.BarSubItem
		Private sbiPaste As DevExpress.XtraBars.BarSubItem
		Private sbiFind As DevExpress.XtraBars.BarSubItem
		Private iPasteSpecial As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iNew As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iLargeUndo As DevExpress.XtraBars.BarLargeButtonItem
		Private ribbonPageGroup8 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private iTemplate As DevExpress.XtraBars.BarButtonItem
		Private pmNew As DevExpress.XtraBars.PopupMenu
		Private pmMain As DevExpress.XtraBars.PopupMenu
		Private iPaintStyle As DevExpress.XtraBars.BarButtonItem
		Private rgbiSkins As DevExpress.XtraBars.RibbonGalleryBarItem
		Private ribbonPageGroup10 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private pmAppMain As DevExpress.XtraBars.Ribbon.ApplicationMenu
		Private WithEvents gddFont As DevExpress.XtraBars.Ribbon.GalleryDropDown
		Private WithEvents beiFontSize As DevExpress.XtraBars.BarEditItem
		Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
		Private ribbonPage3 As DevExpress.XtraBars.Ribbon.RibbonPage
		Private ribbonPageGroup11 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private WithEvents rpgFont As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private WithEvents rgbiFont As DevExpress.XtraBars.RibbonGalleryBarItem
		Private WithEvents gddFontColor As DevExpress.XtraBars.Ribbon.GalleryDropDown
		Private bbiFontColorPopup As DevExpress.XtraBars.BarButtonItem
		Private WithEvents rpgFontColor As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private WithEvents rgbiFontColor As DevExpress.XtraBars.RibbonGalleryBarItem
		Private WithEvents iAbout As DevExpress.XtraBars.BarButtonItem
		Private imageCollection2 As DevExpress.Utils.ImageCollection
		Private ribbonPageCategory1 As DevExpress.XtraBars.Ribbon.RibbonPageCategory
		Private ribbonPage4 As DevExpress.XtraBars.Ribbon.RibbonPage
		Private ribbonPageGroup12 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private ribbonPageGroup13 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private pccAppMenu As Office2007PopupControlContainer
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private pcAppMenuFileLabels As DevExpress.XtraEditors.PanelControl
		Private imageCollection3 As DevExpress.Utils.ImageCollection
		Private WithEvents barEditItem1 As BarEditItem
		Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
		Private WithEvents biStyle As BarEditItem
		Private riicStyle As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private pccBottom As PopupControlContainer
		Private WithEvents sbExit As DevExpress.XtraEditors.SimpleButton
		Private selectionMiniToolbar As DevExpress.XtraBars.Ribbon.RibbonMiniToolbar
		Private editButtonGroup As BarButtonGroup
		Private backstageViewControl1 As DevExpress.XtraBars.Ribbon.BackstageViewControl
		Private backstageViewClientControl1 As DevExpress.XtraBars.Ribbon.BackstageViewClientControl
		Private backstageViewClientControl3 As DevExpress.XtraBars.Ribbon.BackstageViewClientControl
		Private WithEvents bvItemSave As DevExpress.XtraBars.Ribbon.BackstageViewButtonItem
		Private WithEvents bvItemClose As DevExpress.XtraBars.Ribbon.BackstageViewButtonItem
		Private WithEvents bvItemExit As DevExpress.XtraBars.Ribbon.BackstageViewButtonItem
		Private backstageViewClientControl7 As DevExpress.XtraBars.Ribbon.BackstageViewClientControl
		Private WithEvents beScheme As BarEditItem
		Private repositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
		Private taskbarAssistant1 As DevExpress.Utils.Taskbar.TaskbarAssistant
		Private WithEvents thumbButtonNewDoc As DevExpress.Utils.Taskbar.ThumbnailButton
		Private WithEvents thumbButtonNext As DevExpress.Utils.Taskbar.ThumbnailButton
		Private WithEvents thumbButtonExit As DevExpress.Utils.Taskbar.ThumbnailButton
		Private WithEvents thumbButtonPrev As DevExpress.Utils.Taskbar.ThumbnailButton
		Private barToggleSwitchItem1 As BarToggleSwitchItem
		Private repositoryItemTrackBar1 As XtraEditors.Repository.RepositoryItemTrackBar
		Private WithEvents bbColorMix As BarButtonItem
		Private components As System.ComponentModel.IContainer
		Private backstageViewClientControl8 As Ribbon.BackstageViewClientControl
		Private backstageViewTabItem1 As Ribbon.BackstageViewTabItem
		Private backstageViewTabItem2 As Ribbon.BackstageViewTabItem
		Private backstageViewClientControl9 As Ribbon.BackstageViewClientControl
		Private backstageViewTabItem3 As Ribbon.BackstageViewTabItem
		Private backstageViewClientControl10 As Ribbon.BackstageViewClientControl
		Private backstageViewTabItem4 As Ribbon.BackstageViewTabItem
		Private recentControlRecentItem1 As Ribbon.RecentPinItem
		Private recentControlRecentItem2 As Ribbon.RecentPinItem
		Private recentControlRecentItem4 As Ribbon.RecentPinItem
		Private recentControlRecentItem5 As Ribbon.RecentPinItem
		Private recentControlRecentItem6 As Ribbon.RecentPinItem
		Private recentControlRecentItem7 As Ribbon.RecentPinItem
		Private recentControlRecentItem8 As Ribbon.RecentPinItem
		Private recentControlRecentItem9 As Ribbon.RecentPinItem
		Private recentControlRecentItem10 As Ribbon.RecentPinItem
		Private recentControlButtonItem1 As Ribbon.RecentButtonItem
		Private backstageViewClientControl11 As Ribbon.BackstageViewClientControl
		Private recentControlPrint As Ribbon.RecentItemControl
		Private recentPrintOptionsContainer As Ribbon.RecentControlItemControlContainer
		Private recentPrintPreviewContainer As Ribbon.RecentControlItemControlContainer
		Private recentPrintOptions As Ribbon.RecentControlContainerItem
		Private recentPrintPreview As Ribbon.RecentControlContainerItem
		Private backstageViewTabItem5 As Ribbon.BackstageViewTabItem
		Private WithEvents bvTabPrint As Ribbon.BackstageViewTabItem
		'private DevExpress.XtraPrinting.Control.PrintControl printControl1;
		Private backstageViewClientControl4 As Ribbon.BackstageViewClientControl
		Private panelControl2 As XtraEditors.PanelControl
		Private panelControl3 As XtraEditors.PanelControl
		Private printControl1 As XtraPrinting.Control.PrintControl
		Private WithEvents zoomTrackBarControl1 As XtraEditors.ZoomTrackBarControl
		Private WithEvents pageButtonEdit As XtraEditors.ButtonEdit
		Private panel2 As System.Windows.Forms.Panel
		Private layoutControl1 As XtraLayout.LayoutControl
		Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
		Private WithEvents printButton As XtraEditors.SimpleButton
		Private layoutControlItem1 As XtraLayout.LayoutControlItem
		Private copySpinEdit As XtraEditors.SpinEdit
		Private lciCopiesSpinEdit As XtraLayout.LayoutControlItem
		Private printerLabel As BackstageViewLabel
		Private layoutControlItem3 As XtraLayout.LayoutControlItem
		Private WithEvents zoomTextEdit As XtraEditors.TextEdit
		Private ddbPrinter As XtraEditors.DropDownButton
		Private layoutControlItem2 As XtraLayout.LayoutControlItem
		Private WithEvents recentOpen As Ribbon.RecentItemControl
		Private recentTabItem1 As Ribbon.RecentTabItem
		Private recentTabItem2 As Ribbon.RecentTabItem
		Private WithEvents recentSaveAs As Ribbon.RecentItemControl
		Private recentTabItem3 As Ribbon.RecentTabItem
		Private WithEvents recentControlExport As Ribbon.RecentItemControl
		Private recentTabItem4 As Ribbon.RecentTabItem
		Private backstageViewClientControl2 As Ribbon.BackstageViewClientControl
		Private recentItemControl1 As Ribbon.RecentItemControl
		Private recentPinItem2 As Ribbon.RecentPinItem
		Private recentPinItem3 As Ribbon.RecentPinItem
		Private backstageViewTabItem6 As Ribbon.BackstageViewTabItem
		Private recentPinItem4 As Ribbon.RecentPinItem
		Private recentLabelItem1 As Ribbon.RecentLabelItem
		Private recentHyperlinkItem1 As Ribbon.RecentHyperlinkItem
		Private recentLabelItem2 As Ribbon.RecentLabelItem
		Private ddbDuplex As XtraEditors.DropDownButton
		Private ddbOrientation As XtraEditors.DropDownButton
		Private ddbPaperSize As XtraEditors.DropDownButton
		Private ddbMargins As XtraEditors.DropDownButton
		Private ddbCollate As XtraEditors.DropDownButton
		Private backstageViewLabel2 As BackstageViewLabel
		Private layoutControlItem4 As XtraLayout.LayoutControlItem
		Private layoutControlItem5 As XtraLayout.LayoutControlItem
		Private layoutControlItem6 As XtraLayout.LayoutControlItem
		Private layoutControlItem7 As XtraLayout.LayoutControlItem
		Private layoutControlItem8 As XtraLayout.LayoutControlItem
		Private layoutControlItem9 As XtraLayout.LayoutControlItem
        Private WithEvents printControl2 As XtraPrinting.Control.PrintControl
        Private recentStackPanel1 As RecentStackPanel
        Private recentStackPanel2 As RecentStackPanel
        Private recentStackPanel3 As RecentStackPanel
        Private recentStackPanel4 As RecentStackPanel
        Private recentStackPanel5 As RecentStackPanel
        Private recentStackPanel6 As RecentStackPanel
        Private recentStackPanel7 As RecentStackPanel
        Private recentStackPanel8 As RecentStackPanel
        Private recentStackPanel9 As RecentStackPanel
        Private recentStackPanel10 As RecentStackPanel
        Private recentStackPanel11 As RecentStackPanel
        Private recentStackPanel12 As RecentStackPanel
        Private recentStackPanel13 As RecentStackPanel
        Private recentStackPanel14 As RecentStackPanel
    End Class
End Namespace

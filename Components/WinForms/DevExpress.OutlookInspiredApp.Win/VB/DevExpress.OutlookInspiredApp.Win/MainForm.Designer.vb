Namespace DevExpress.DevAV
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
            Me.components = New System.ComponentModel.Container()
            Dim transition1 As New DevExpress.Utils.Animation.Transition()
            Dim slideFadeTransition1 As New DevExpress.Utils.Animation.SlideFadeTransition()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
            Me.modulesContainer = New DevExpress.XtraEditors.XtraUserControl()
            Me.navBar = New DevExpress.XtraNavBar.NavBarControl()
            Me.notificationManager = New DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(Me.components)
            Me.overviewControl = New DevExpress.DevAV.Modules.OverviewControl()
            Me.officeNavigationBar = New DevExpress.XtraBars.Navigation.OfficeNavigationBar()
            Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.backstageViewControl = New DevExpress.XtraBars.Ribbon.BackstageViewControl()
            Me.backstageViewClientControl1 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
            Me.backstageViewClientControl2 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
            Me.backstageViewClientControl3 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
            Me.tabBackstageViewAbout = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
            Me.tabBackstageViewExport = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
            Me.tabBackstageViewPrint = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
            Me.backstageViewItemSeparator1 = New DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator()
            Me.biBackstageViewGetStarted = New DevExpress.XtraBars.Ribbon.BackstageViewButtonItem()
            Me.biBackstageViewGetSupport = New DevExpress.XtraBars.Ribbon.BackstageViewButtonItem()
            Me.biBackstageViewBuyNow = New DevExpress.XtraBars.Ribbon.BackstageViewButtonItem()
            Me.skinRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
            Me.barNavigationItem = New DevExpress.XtraBars.BarSubItem()
            Me.biFolderPaneSubItem = New DevExpress.XtraBars.BarSubItem()
            Me.bmiFolderNormal = New DevExpress.XtraBars.BarCheckItem()
            Me.bmiFolderMinimized = New DevExpress.XtraBars.BarCheckItem()
            Me.bmiFolderOff = New DevExpress.XtraBars.BarCheckItem()
            Me.biGetStarted = New DevExpress.XtraBars.BarButtonItem()
            Me.biGetSupport = New DevExpress.XtraBars.BarButtonItem()
            Me.biBuyNow = New DevExpress.XtraBars.BarButtonItem()
            Me.biAbout = New DevExpress.XtraBars.BarButtonItem()
            Me.bbiNormal = New DevExpress.XtraBars.BarCheckItem()
            Me.beZoomLevel = New DevExpress.XtraBars.BarEditItem()
            Me.zoomLevelTrackBar = New DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar()
            Me.bbiReading = New DevExpress.XtraBars.BarCheckItem()
            Me.bbiZoomDialog = New DevExpress.XtraBars.BarButtonItem()
            Me.ribbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
            Me.dockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.transitionManager = New DevExpress.Utils.Animation.TransitionManager()
            Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
            Me.modulesContainer.SuspendLayout()
            CType(Me.navBar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.notificationManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.officeNavigationBar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.backstageViewControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.backstageViewControl.SuspendLayout()
            Me.backstageViewClientControl1.SuspendLayout()
            CType(Me.zoomLevelTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dockManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.modulesContainer.Controls.Add(Me.navBar)
            Me.modulesContainer.Dock = System.Windows.Forms.DockStyle.Fill
            Me.modulesContainer.Location = New System.Drawing.Point(0, 143)
            Me.modulesContainer.Margin = New System.Windows.Forms.Padding(24, 23, 24, 3)
            Me.modulesContainer.Name = "modulesContainer"
            Me.modulesContainer.Size = New System.Drawing.Size(1368, 604)
            Me.modulesContainer.TabIndex = 2
            Me.navBar.ActiveGroup = Nothing
            Me.navBar.AllowHorizontalResizing = DevExpress.Utils.DefaultBoolean.True
            Me.navBar.Dock = System.Windows.Forms.DockStyle.Left
            Me.navBar.Location = New System.Drawing.Point(0, 0)
            Me.navBar.Name = "navBar"
            Me.navBar.OptionsNavPane.CollapsedWidth = 41
            Me.navBar.OptionsNavPane.ExpandedWidth = 200
            Me.navBar.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane
            Me.navBar.Size = New System.Drawing.Size(200, 604)
            Me.navBar.TabIndex = 5
            Me.navBar.Text = "navBarControl1"
            Me.notificationManager.ApplicationId = "Components_v16_1_Demo_Center_v16_1"
            Me.notificationManager.ApplicationName = "DevAV"
            Me.notificationManager.Notifications.AddRange(New DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties() {
                New DevExpress.XtraBars.ToastNotifications.ToastNotification("04d87d90-04d2-44a5-8d06-74dcf65cf013", Nothing, "DevAV Tips & Tricks", "Become a UI Superhero, check out", "our WYSIWYG Reporting in the Sales Module", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.Text04),
                New DevExpress.XtraBars.ToastNotifications.ToastNotification("04d87d90-04d2-44a5-8d06-74dcf65cf014", Nothing, "DevAV Tips & Tricks", "Become a UI Superhero, take users ", "where they want to go with DevExpress Maps", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.Text04),
                New DevExpress.XtraBars.ToastNotifications.ToastNotification("04d87d90-04d2-44a5-8d06-74dcf65cf015", Nothing, "DevAV Tips & Tricks", "Become a UI Superhero, explore", "PDF-documents with DevExpress PDF Viewer", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.Text04),
                New DevExpress.XtraBars.ToastNotifications.ToastNotification("04d87d90-04d2-44a5-8d06-74dcf65cf016", Nothing, "DevAV Tips & Tricks", "Become a UI Superhero, check out our", "straightforward and easy-to-use Spreadsheet", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.Text04)
            })
            Me.overviewControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.overviewControl.Location = New System.Drawing.Point(0, 0)
            Me.overviewControl.Name = "overviewControl"
            Me.overviewControl.Size = New System.Drawing.Size(1234, 540)
            Me.overviewControl.TabIndex = 0
            Me.officeNavigationBar.AllowDrag = True
            Me.officeNavigationBar.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.officeNavigationBar.Location = New System.Drawing.Point(0, 747)
            Me.officeNavigationBar.MenuManager = Me.ribbonControl
            Me.officeNavigationBar.MinimumSize = New System.Drawing.Size(0, 21)
            Me.officeNavigationBar.Name = "officeNavigationBar"
            Me.officeNavigationBar.OptionsPeekFormButtonPanel.AllowGlyphSkinning = True
            Me.officeNavigationBar.OptionsPeekFormButtonPanel.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() { New DevExpress.Utils.PeekFormButton("", My.Resources.icon_docking_16, False, True, "")})
            Me.officeNavigationBar.OptionsPeekFormButtonPanel.Padding = New System.Windows.Forms.Padding(0, 0, 8, 0)
            Me.officeNavigationBar.OptionsPeekFormButtonPanel.ShowButtonPanel = True
            Me.officeNavigationBar.PeekFormSize = New System.Drawing.Size(250, 350)
            Me.officeNavigationBar.Size = New System.Drawing.Size(1368, 21)
            Me.officeNavigationBar.TabIndex = 3
            Me.ribbonControl.ApplicationButtonDropDownControl = Me.backstageViewControl
            Me.ribbonControl.ExpandCollapseItem.Id = 0
            Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl.ExpandCollapseItem, Me.skinRibbonGalleryBarItem1, Me.barNavigationItem, Me.biFolderPaneSubItem, Me.bmiFolderNormal, Me.bmiFolderMinimized, Me.bmiFolderOff, Me.biGetStarted, Me.biGetSupport, Me.biBuyNow, Me.biAbout, Me.bbiNormal, Me.beZoomLevel, Me.bbiReading, Me.bbiZoomDialog})
            Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl.MaxItemId = 12
            Me.ribbonControl.Name = "ribbonControl"
            Me.ribbonControl.OptionsTouch.ShowTouchUISelectorInQAT = True
            Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage2, Me.ribbonPage1})
            Me.ribbonControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.zoomLevelTrackBar})
            Me.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
            Me.ribbonControl.Size = New System.Drawing.Size(1368, 143)
            Me.ribbonControl.StatusBar = Me.ribbonStatusBar1
            Me.ribbonControl.TransparentEditors = True
            Me.backstageViewControl.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Default
            Me.backstageViewControl.Controls.Add(Me.backstageViewClientControl1)
            Me.backstageViewControl.Controls.Add(Me.backstageViewClientControl2)
            Me.backstageViewControl.Controls.Add(Me.backstageViewClientControl3)
            Me.backstageViewControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.backstageViewControl.Items.Add(Me.tabBackstageViewAbout)
            Me.backstageViewControl.Items.Add(Me.tabBackstageViewExport)
            Me.backstageViewControl.Items.Add(Me.tabBackstageViewPrint)
            Me.backstageViewControl.Items.Add(Me.backstageViewItemSeparator1)
            Me.backstageViewControl.Items.Add(Me.biBackstageViewGetStarted)
            Me.backstageViewControl.Items.Add(Me.biBackstageViewGetSupport)
            Me.backstageViewControl.Items.Add(Me.biBackstageViewBuyNow)
            Me.backstageViewControl.Location = New System.Drawing.Point(0, 143)
            Me.backstageViewControl.Name = "backstageViewControl"
            Me.backstageViewControl.OwnerControl = Me.ribbonControl
            Me.backstageViewControl.SelectedTab = Me.tabBackstageViewAbout
            Me.backstageViewControl.SelectedTabIndex = 0
            Me.backstageViewControl.Size = New System.Drawing.Size(1368, 604)
            Me.backstageViewControl.Style = DevExpress.XtraBars.Ribbon.BackstageViewStyle.Office2013
            Me.backstageViewControl.TabIndex = 6
            Me.backstageViewClientControl1.Controls.Add(Me.overviewControl)
            Me.backstageViewClientControl1.Location = New System.Drawing.Point(133, 63)
            Me.backstageViewClientControl1.Name = "backstageViewClientControl1"
            Me.backstageViewClientControl1.Size = New System.Drawing.Size(1234, 540)
            Me.backstageViewClientControl1.TabIndex = 0
            Me.backstageViewClientControl2.Location = New System.Drawing.Point(133, 63)
            Me.backstageViewClientControl2.Name = "backstageViewClientControl2"
            Me.backstageViewClientControl2.Size = New System.Drawing.Size(1234, 540)
            Me.backstageViewClientControl2.TabIndex = 1
            Me.backstageViewClientControl3.Location = New System.Drawing.Point(133, 63)
            Me.backstageViewClientControl3.Name = "backstageViewClientControl3"
            Me.backstageViewClientControl3.Size = New System.Drawing.Size(1234, 540)
            Me.backstageViewClientControl3.TabIndex = 2
            Me.tabBackstageViewAbout.Caption = "About"
            Me.tabBackstageViewAbout.CaptionHorizontalAlignment = DevExpress.Utils.Drawing.ItemHorizontalAlignment.Left
            Me.tabBackstageViewAbout.ContentControl = Me.backstageViewClientControl1
            Me.tabBackstageViewAbout.Name = "tabBackstageViewAbout"
            Me.tabBackstageViewAbout.Selected = True
            Me.tabBackstageViewExport.Caption = "Export"
            Me.tabBackstageViewExport.CaptionHorizontalAlignment = DevExpress.Utils.Drawing.ItemHorizontalAlignment.Left
            Me.tabBackstageViewExport.ContentControl = Me.backstageViewClientControl2
            Me.tabBackstageViewExport.Name = "tabBackstageViewExport"
            Me.tabBackstageViewExport.Selected = False
            Me.tabBackstageViewPrint.Caption = "Print"
            Me.tabBackstageViewPrint.CaptionHorizontalAlignment = DevExpress.Utils.Drawing.ItemHorizontalAlignment.Left
            Me.tabBackstageViewPrint.ContentControl = Me.backstageViewClientControl3
            Me.tabBackstageViewPrint.Name = "tabBackstageViewPrint"
            Me.tabBackstageViewPrint.Selected = False
            Me.backstageViewItemSeparator1.Name = "backstageViewItemSeparator1"
            Me.biBackstageViewGetStarted.Caption = "Get Started"
            Me.biBackstageViewGetStarted.CaptionHorizontalAlignment = DevExpress.Utils.Drawing.ItemHorizontalAlignment.Left
            Me.biBackstageViewGetStarted.Name = "biBackstageViewGetStarted"
            Me.biBackstageViewGetSupport.Caption = "Get Support"
            Me.biBackstageViewGetSupport.CaptionHorizontalAlignment = DevExpress.Utils.Drawing.ItemHorizontalAlignment.Left
            Me.biBackstageViewGetSupport.Name = "biBackstageViewGetSupport"
            Me.biBackstageViewBuyNow.Caption = "Buy Now"
            Me.biBackstageViewBuyNow.CaptionHorizontalAlignment = DevExpress.Utils.Drawing.ItemHorizontalAlignment.Left
            Me.biBackstageViewBuyNow.Name = "biBackstageViewBuyNow"
            Me.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1"
            Me.skinRibbonGalleryBarItem1.Id = 1
            Me.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1"
            Me.barNavigationItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.barNavigationItem.Caption = "Navigation"
            Me.barNavigationItem.Id = 2
            Me.barNavigationItem.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.barNavigationItem.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Navigation.svg"
            Me.barNavigationItem.LargeImageIndex = 43
            Me.barNavigationItem.Name = "barNavigationItem"
            Me.barNavigationItem.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True
            Me.biFolderPaneSubItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biFolderPaneSubItem.Caption = "Folder Pane"
            Me.biFolderPaneSubItem.Id = 10
            Me.biFolderPaneSubItem.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biFolderPaneSubItem.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.FolderPanel2.svg"
            Me.biFolderPaneSubItem.LargeImageIndex = 42
            Me.biFolderPaneSubItem.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
                New DevExpress.XtraBars.LinkPersistInfo(Me.bmiFolderNormal),
                New DevExpress.XtraBars.LinkPersistInfo(Me.bmiFolderMinimized),
                New DevExpress.XtraBars.LinkPersistInfo(Me.bmiFolderOff)
            })
            Me.biFolderPaneSubItem.Name = "biFolderPaneSubItem"
            Me.biFolderPaneSubItem.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True
            Me.bmiFolderNormal.Caption = "Normal"
            Me.bmiFolderNormal.GroupIndex = 4
            Me.bmiFolderNormal.Id = 6
            Me.bmiFolderNormal.Name = "bmiFolderNormal"
            Me.bmiFolderMinimized.Caption = "Minimized"
            Me.bmiFolderMinimized.GroupIndex = 4
            Me.bmiFolderMinimized.Id = 7
            Me.bmiFolderMinimized.Name = "bmiFolderMinimized"
            Me.bmiFolderOff.Caption = "Off"
            Me.bmiFolderOff.GroupIndex = 4
            Me.bmiFolderOff.Id = 7
            Me.bmiFolderOff.Name = "bmiFolderOff"
            Me.biGetStarted.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biGetStarted.Caption = "Getting Started"
            Me.biGetStarted.Id = 3
            Me.biGetStarted.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biGetStarted.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.GettingStarted.svg"
            Me.biGetStarted.Name = "biGetStarted"
            Me.biGetSupport.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biGetSupport.Caption = "Get Free Support"
            Me.biGetSupport.Id = 4
            Me.biGetSupport.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biGetSupport.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Support.svg"
            Me.biGetSupport.Name = "biGetSupport"
            Me.biBuyNow.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biBuyNow.Caption = "Buy Now"
            Me.biBuyNow.Id = 5
            Me.biBuyNow.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biBuyNow.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Buy.svg"
            Me.biBuyNow.Name = "biBuyNow"
            Me.biAbout.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biAbout.Caption = "About"
            Me.biAbout.Id = 6
            Me.biAbout.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biAbout.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.About.svg"
            Me.biAbout.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F1)
            Me.biAbout.Name = "biAbout"
            Me.bbiNormal.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
            Me.bbiNormal.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True
            Me.bbiNormal.BindableChecked = True
            Me.bbiNormal.Caption = "Normal"
            Me.bbiNormal.Checked = True
            Me.bbiNormal.Glyph = My.Resources.icon_normal_bottom_16
            Me.bbiNormal.Id = 8
            Me.bbiNormal.Name = "bbiNormal"
            Me.bbiNormal.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            Me.beZoomLevel.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
            Me.beZoomLevel.CaptionAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.beZoomLevel.Edit = Me.zoomLevelTrackBar
            Me.beZoomLevel.EditValue = 10
            Me.beZoomLevel.EditWidth = 150
            Me.beZoomLevel.Id = 9
            Me.beZoomLevel.Name = "beZoomLevel"
            Me.zoomLevelTrackBar.Alignment = DevExpress.Utils.VertAlignment.Center
            Me.zoomLevelTrackBar.AllowUseMiddleValue = True
            Me.zoomLevelTrackBar.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.zoomLevelTrackBar.Maximum = 20
            Me.zoomLevelTrackBar.Middle = 10
            Me.zoomLevelTrackBar.Minimum = 1
            Me.zoomLevelTrackBar.Name = "zoomLevelTrackBar"
            Me.zoomLevelTrackBar.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight
            Me.bbiReading.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
            Me.bbiReading.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True
            Me.bbiReading.Caption = "Reading"
            Me.bbiReading.Glyph = My.Resources.icon_reading_bottom_16
            Me.bbiReading.Id = 10
            Me.bbiReading.Name = "bbiReading"
            Me.bbiReading.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            Me.bbiZoomDialog.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
            Me.bbiZoomDialog.Caption = "100%"
            Me.bbiZoomDialog.Id = 11
            Me.bbiZoomDialog.Name = "bbiZoomDialog"
            Me.bbiZoomDialog.SmallWithTextWidth = 50
            Me.ribbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup4})
            Me.ribbonPage2.Name = "ribbonPage2"
            Me.ribbonPage2.Text = "HOME"
            Me.ribbonPageGroup4.ItemLinks.Add(Me.biGetStarted)
            Me.ribbonPageGroup4.ItemLinks.Add(Me.biGetSupport)
            Me.ribbonPageGroup4.ItemLinks.Add(Me.biBuyNow)
            Me.ribbonPageGroup4.ItemLinks.Add(Me.biAbout)
            Me.ribbonPageGroup4.Name = "ribbonPageGroup4"
            Me.ribbonPageGroup4.ShowCaptionButton = False
            Me.ribbonPageGroup4.Text = "DevExpress"
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup3, Me.ribbonPageGroup2, Me.ribbonPageGroup1})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "VIEW"
            Me.ribbonPageGroup3.AllowTextClipping = False
            Me.ribbonPageGroup3.ItemLinks.Add(Me.barNavigationItem)
            Me.ribbonPageGroup3.MergeOrder = 0
            Me.ribbonPageGroup3.Name = "ribbonPageGroup3"
            Me.ribbonPageGroup3.ShowCaptionButton = False
            Me.ribbonPageGroup3.Text = "Module"
            Me.ribbonPageGroup2.AllowTextClipping = False
            Me.ribbonPageGroup2.ItemLinks.Add(Me.biFolderPaneSubItem)
            Me.ribbonPageGroup2.MergeOrder = 1
            Me.ribbonPageGroup2.Name = "ribbonPageGroup2"
            Me.ribbonPageGroup2.ShowCaptionButton = False
            Me.ribbonPageGroup2.Text = "Layout"
            Me.ribbonPageGroup1.AllowTextClipping = False
            Me.ribbonPageGroup1.ItemLinks.Add(Me.skinRibbonGalleryBarItem1)
            Me.ribbonPageGroup1.MergeOrder = 2
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.ShowCaptionButton = False
            Me.ribbonPageGroup1.Text = "Appearance"
            Me.ribbonStatusBar1.ItemLinks.Add(Me.bbiNormal)
            Me.ribbonStatusBar1.ItemLinks.Add(Me.bbiReading)
            Me.ribbonStatusBar1.ItemLinks.Add(Me.beZoomLevel)
            Me.ribbonStatusBar1.ItemLinks.Add(Me.bbiZoomDialog)
            Me.ribbonStatusBar1.Location = New System.Drawing.Point(0, 768)
            Me.ribbonStatusBar1.Name = "ribbonStatusBar1"
            Me.ribbonStatusBar1.Ribbon = Me.ribbonControl
            Me.ribbonStatusBar1.Size = New System.Drawing.Size(1368, 31)
            Me.dockManager.DockingOptions.FloatOnDblClick = False
            Me.dockManager.DockingOptions.ShowAutoHideButton = False
            Me.dockManager.DockingOptions.ShowMaximizeButton = False
            Me.dockManager.Form = Me.modulesContainer
            Me.dockManager.MenuManager = Me.ribbonControl
            Me.dockManager.TopZIndexControls.AddRange(New String() { "DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
            Me.transitionManager.ShowWaitingIndicator = False
            transition1.Control = Me.modulesContainer
            slideFadeTransition1.Parameters.EffectOptions = DevExpress.Utils.Animation.PushEffectOptions.FromRight
            slideFadeTransition1.Parameters.FrameInterval = 5000
            transition1.TransitionType = slideFadeTransition1
            Me.transitionManager.Transitions.Add(transition1)
            Me.mvvmContext.ContainerControl = Me
            Me.mvvmContext.ViewModelType = GetType(DevExpress.DevAV.ViewModels.MainViewModel)
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1368, 799)
            Me.Controls.Add(Me.backstageViewControl)
            Me.Controls.Add(Me.modulesContainer)
            Me.Controls.Add(Me.officeNavigationBar)
            Me.Controls.Add(Me.ribbonStatusBar1)
            Me.Controls.Add(Me.ribbonControl)
            Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
            Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
            Me.Name = "MainForm"
            Me.Ribbon = Me.ribbonControl
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StatusBar = Me.ribbonStatusBar1
            Me.Text = "DevAV"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.modulesContainer.ResumeLayout(False)
            CType(Me.navBar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.notificationManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.officeNavigationBar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.backstageViewControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.backstageViewControl.ResumeLayout(False)
            Me.backstageViewClientControl1.ResumeLayout(False)
            CType(Me.zoomLevelTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dockManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        #End Region

        Private ribbonControl As XtraBars.Ribbon.RibbonControl
        Private ribbonPage1 As XtraBars.Ribbon.RibbonPage
        Private ribbonPageGroup1 As XtraBars.Ribbon.RibbonPageGroup
        Private ribbonStatusBar1 As XtraBars.Ribbon.RibbonStatusBar
        Private skinRibbonGalleryBarItem1 As XtraBars.SkinRibbonGalleryBarItem
        Private ribbonPageGroup3 As XtraBars.Ribbon.RibbonPageGroup
        Private ribbonPageGroup2 As XtraBars.Ribbon.RibbonPageGroup
        Private ribbonPage2 As XtraBars.Ribbon.RibbonPage
        Private ribbonPageGroup4 As XtraBars.Ribbon.RibbonPageGroup
        Private officeNavigationBar As XtraBars.Navigation.OfficeNavigationBar
        Private dockManager As XtraBars.Docking.DockManager
        Private transitionManager As Utils.Animation.TransitionManager
        Private notificationManager As DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager
        Private modulesContainer As DevExpress.XtraEditors.XtraUserControl
        Private barNavigationItem As XtraBars.BarSubItem
        Private navBar As XtraNavBar.NavBarControl
        Private biGetStarted As XtraBars.BarButtonItem
        Private biGetSupport As XtraBars.BarButtonItem
        Private biBuyNow As XtraBars.BarButtonItem
        Private biAbout As XtraBars.BarButtonItem
        Private biFolderPaneSubItem As XtraBars.BarSubItem
        Private bmiFolderNormal As XtraBars.BarCheckItem
        Private bmiFolderMinimized As XtraBars.BarCheckItem
        Private bmiFolderOff As XtraBars.BarCheckItem
        Private backstageViewControl As XtraBars.Ribbon.BackstageViewControl
        Private backstageViewClientControl1 As XtraBars.Ribbon.BackstageViewClientControl
        Private backstageViewClientControl2 As XtraBars.Ribbon.BackstageViewClientControl
        Private backstageViewClientControl3 As XtraBars.Ribbon.BackstageViewClientControl
        Private tabBackstageViewAbout As XtraBars.Ribbon.BackstageViewTabItem
        Private tabBackstageViewExport As XtraBars.Ribbon.BackstageViewTabItem
        Private tabBackstageViewPrint As XtraBars.Ribbon.BackstageViewTabItem
        Private backstageViewItemSeparator1 As XtraBars.Ribbon.BackstageViewItemSeparator
        Private biBackstageViewGetStarted As XtraBars.Ribbon.BackstageViewButtonItem
        Private biBackstageViewGetSupport As XtraBars.Ribbon.BackstageViewButtonItem
        Private biBackstageViewBuyNow As XtraBars.Ribbon.BackstageViewButtonItem
        Private overviewControl As DevExpress.DevAV.Modules.OverviewControl
        Private bbiNormal As XtraBars.BarCheckItem
        Private bbiReading As XtraBars.BarCheckItem
        Private beZoomLevel As XtraBars.BarEditItem
        Private zoomLevelTrackBar As XtraEditors.Repository.RepositoryItemZoomTrackBar
        Private bbiZoomDialog As XtraBars.BarButtonItem
        Private mvvmContext As Utils.MVVM.MVVMContext
    End Class
End Namespace

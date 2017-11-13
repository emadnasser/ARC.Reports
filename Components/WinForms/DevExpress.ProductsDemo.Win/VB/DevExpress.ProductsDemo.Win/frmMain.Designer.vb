Namespace DevExpress.ProductsDemo.Win
	Partial Public Class frmMain
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
			Dim galleryItemGroup1 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
			Dim galleryItem1 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem2 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem3 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem4 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem5 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem6 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem7 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem8 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItemGroup2 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
			Dim galleryItem9 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem10 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem11 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem12 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
			Me.backstageViewControl1 = New DevExpress.XtraBars.Ribbon.BackstageViewControl()
			Me.backstageViewClientControl1 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
			Me.helpControl1 = New DevExpress.ProductsDemo.Win.Controls.HelpControl()
			Me.backstageViewClientControl3 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
			Me.printControl1 = New DevExpress.ProductsDemo.Win.Controls.PrintControl()
			Me.backstageViewClientControl4 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
			Me.exportControl1 = New DevExpress.ProductsDemo.Win.Controls.ExportControl()
			Me.bvbiSaveAs = New DevExpress.XtraBars.Ribbon.BackstageViewButtonItem()
			Me.bvbiSaveAttachment = New DevExpress.XtraBars.Ribbon.BackstageViewButtonItem()
			Me.bvtiInfo = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
			Me.bvtiPrint = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
			Me.bvtiExport = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
			Me.bvbiExit = New DevExpress.XtraBars.Ribbon.BackstageViewButtonItem()
			Me.rgbiSkins = New DevExpress.XtraBars.RibbonGalleryBarItem()
			Me.bsiNavigation = New DevExpress.XtraBars.BarSubItem()
			Me.bsiInfo = New DevExpress.XtraBars.BarStaticItem()
			Me.beiZoom = New DevExpress.XtraBars.BarEditItem()
			Me.repositoryItemZoomTrackBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar()
			Me.bbiNormal = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiReading = New DevExpress.XtraBars.BarButtonItem()
			Me.bsiTemp = New DevExpress.XtraBars.BarStaticItem()
			Me.bbiManageView = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiSaveCurrentView = New DevExpress.XtraBars.BarButtonItem()
            Me.rgbiCurrentViewTasks = New DevExpress.XtraBars.RibbonGalleryBarItem()
            Me.BBColorMix = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiTodayFlag = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiTomorrowFlag = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiThisWeekFlag = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiNextWeekFlag = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiNoDateFlag = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiCustomFlag = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiNewTask = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiEditTask = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiDeleteTask = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiNewContact = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiEditContact = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiDeleteContact = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiFlipLayout = New DevExpress.XtraBars.BarButtonItem()
			Me.rgbiCurrentView = New DevExpress.XtraBars.RibbonGalleryBarItem()
			Me.biPrintPreview = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiReminder = New DevExpress.XtraBars.BarButtonItem()
			Me.rpTasks = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.rpgTasks = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.rpgFollowUp = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.rpdCurrentViewTasks = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.rpContacts = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.rpgContacts = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.rpgCurrentView = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.rpgLayoutContacts = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.rpView = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.rpgNavigation = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.prgAppearance = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.rpgPrint = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
			Me.repositoryItemDuration1 = New DevExpress.XtraScheduler.UI.RepositoryItemDuration()
			Me.ribbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
			Me.navBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
			Me.nbgModules = New DevExpress.XtraNavBar.NavBarGroup()
			Me.nbiGrid = New DevExpress.XtraNavBar.NavBarItem()
			Me.nbiGridCardView = New DevExpress.XtraNavBar.NavBarItem()
			Me.nbiSpreadsheet = New DevExpress.XtraNavBar.NavBarItem()
			Me.nbiWord = New DevExpress.XtraNavBar.NavBarItem()
			Me.nbiSnap = New DevExpress.XtraNavBar.NavBarItem()
			Me.nbiReports = New DevExpress.XtraNavBar.NavBarItem()
			Me.nbiPivot = New DevExpress.XtraNavBar.NavBarItem()
			Me.nbiCharts = New DevExpress.XtraNavBar.NavBarItem()
			Me.nbiMaps = New DevExpress.XtraNavBar.NavBarItem()
			Me.nbiScheduler = New DevExpress.XtraNavBar.NavBarItem()
			Me.nbiPdf = New DevExpress.XtraNavBar.NavBarItem()
			Me.pcMain = New DevExpress.XtraEditors.PanelControl()
			Me.pmFlagStatus = New DevExpress.XtraBars.PopupMenu(Me.components)
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.backstageViewControl1.SuspendLayout()
			Me.backstageViewClientControl1.SuspendLayout()
			Me.backstageViewClientControl3.SuspendLayout()
			Me.backstageViewClientControl4.SuspendLayout()
			CType(Me.repositoryItemZoomTrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemDuration1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pcMain, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pcMain.SuspendLayout()
			CType(Me.pmFlagStatus, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' ribbonControl1
			' 
			Me.ribbonControl1.ApplicationButtonDropDownControl = Me.backstageViewControl1
			Me.ribbonControl1.Categories.AddRange(New DevExpress.XtraBars.BarManagerCategory() { (CType(resources.GetObject("ribbonControl1.Categories"), DevExpress.XtraBars.BarManagerCategory)), (CType(resources.GetObject("ribbonControl1.Categories1"), DevExpress.XtraBars.BarManagerCategory)), (CType(resources.GetObject("ribbonControl1.Categories2"), DevExpress.XtraBars.BarManagerCategory)), (CType(resources.GetObject("ribbonControl1.Categories3"), DevExpress.XtraBars.BarManagerCategory)), (CType(resources.GetObject("ribbonControl1.Categories4"), DevExpress.XtraBars.BarManagerCategory))})
			Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.rgbiSkins, Me.bsiNavigation, Me.bsiInfo, Me.beiZoom, Me.bbiNormal, Me.bbiReading, Me.bsiTemp, Me.bbiManageView, Me.bbiSaveCurrentView, Me.rgbiCurrentViewTasks, Me.bbiTodayFlag, Me.bbiTomorrowFlag, Me.bbiThisWeekFlag, Me.bbiNextWeekFlag, Me.bbiNoDateFlag, Me.bbiCustomFlag, Me.bbiNewTask, Me.bbiEditTask, Me.bbiDeleteTask, Me.bbiNewContact, Me.bbiEditContact, Me.bbiDeleteContact, Me.bbiFlipLayout, Me.rgbiCurrentView, Me.biPrintPreview, Me.bbiReminder, Me.BBColorMix})
			resources.ApplyResources(Me.ribbonControl1, "ribbonControl1")
			Me.ribbonControl1.MaxItemId = 104
			Me.ribbonControl1.Name = "ribbonControl1"
			Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.rpTasks, Me.rpContacts, Me.rpView})
			Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemZoomTrackBar1, Me.repositoryItemSpinEdit1, Me.repositoryItemDuration1})
			Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
			Me.ribbonControl1.StatusBar = Me.ribbonStatusBar1
			Me.ribbonControl1.TransparentEditors = True
'			Me.ribbonControl1.BeforeApplicationButtonContentControlShow += New System.EventHandler(Me.ribbonControl1_BeforeApplicationButtonContentControlShow)
'			Me.ribbonControl1.ShowCustomizationMenu += New DevExpress.XtraBars.Ribbon.RibbonCustomizationMenuEventHandler(Me.ribbonControl1_ShowCustomizationMenu)
			' 
			' backstageViewControl1
			' 
			Me.backstageViewControl1.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Yellow
			Me.backstageViewControl1.Controls.Add(Me.backstageViewClientControl1)
			Me.backstageViewControl1.Controls.Add(Me.backstageViewClientControl3)
			Me.backstageViewControl1.Controls.Add(Me.backstageViewClientControl4)
			Me.backstageViewControl1.Items.Add(Me.bvbiSaveAs)
			Me.backstageViewControl1.Items.Add(Me.bvbiSaveAttachment)
			Me.backstageViewControl1.Items.Add(Me.bvtiInfo)
			Me.backstageViewControl1.Items.Add(Me.bvtiPrint)
			Me.backstageViewControl1.Items.Add(Me.bvtiExport)
			Me.backstageViewControl1.Items.Add(Me.bvbiExit)
			resources.ApplyResources(Me.backstageViewControl1, "backstageViewControl1")
			Me.backstageViewControl1.Name = "backstageViewControl1"
			Me.backstageViewControl1.Ribbon = Me.ribbonControl1
			Me.backstageViewControl1.SelectedTab = Me.bvtiInfo
			Me.backstageViewControl1.SelectedTabIndex = 2
'			Me.backstageViewControl1.ItemClick += New DevExpress.XtraBars.Ribbon.BackstageViewItemEventHandler(Me.backstageViewControl1_ItemClick)
			' 
			' backstageViewClientControl1
			' 
			Me.backstageViewClientControl1.Controls.Add(Me.helpControl1)
			resources.ApplyResources(Me.backstageViewClientControl1, "backstageViewClientControl1")
			Me.backstageViewClientControl1.Name = "backstageViewClientControl1"
			' 
			' helpControl1
			' 
			resources.ApplyResources(Me.helpControl1, "helpControl1")
			Me.helpControl1.ForeColor = System.Drawing.Color.Transparent
			Me.helpControl1.Name = "helpControl1"
			' 
			' backstageViewClientControl3
			' 
			Me.backstageViewClientControl3.Controls.Add(Me.printControl1)
			resources.ApplyResources(Me.backstageViewClientControl3, "backstageViewClientControl3")
			Me.backstageViewClientControl3.Name = "backstageViewClientControl3"
			' 
			' printControl1
			' 
			resources.ApplyResources(Me.printControl1, "printControl1")
			Me.printControl1.ForeColor = System.Drawing.Color.Transparent
			Me.printControl1.Name = "printControl1"
			' 
			' backstageViewClientControl4
			' 
			Me.backstageViewClientControl4.Controls.Add(Me.exportControl1)
			resources.ApplyResources(Me.backstageViewClientControl4, "backstageViewClientControl4")
			Me.backstageViewClientControl4.Name = "backstageViewClientControl4"
			' 
			' exportControl1
			' 
			resources.ApplyResources(Me.exportControl1, "exportControl1")
			Me.exportControl1.ForeColor = System.Drawing.Color.Transparent
			Me.exportControl1.Name = "exportControl1"
			' 
			' bvbiSaveAs
			' 
			resources.ApplyResources(Me.bvbiSaveAs, "bvbiSaveAs")
			Me.bvbiSaveAs.Name = "bvbiSaveAs"
			' 
			' bvbiSaveAttachment
			' 
			resources.ApplyResources(Me.bvbiSaveAttachment, "bvbiSaveAttachment")
			Me.bvbiSaveAttachment.Name = "bvbiSaveAttachment"
			' 
			' bvtiInfo
			' 
			resources.ApplyResources(Me.bvtiInfo, "bvtiInfo")
			Me.bvtiInfo.ContentControl = Me.backstageViewClientControl1
			Me.bvtiInfo.Name = "bvtiInfo"
			Me.bvtiInfo.Selected = True
			' 
			' bvtiPrint
			' 
			resources.ApplyResources(Me.bvtiPrint, "bvtiPrint")
			Me.bvtiPrint.ContentControl = Me.backstageViewClientControl3
			Me.bvtiPrint.Name = "bvtiPrint"
			Me.bvtiPrint.Selected = False
'			Me.bvtiPrint.SelectedChanged += New DevExpress.XtraBars.Ribbon.BackstageViewItemEventHandler(Me.bvtiPrint_SelectedChanged)
			' 
			' bvtiExport
			' 
			resources.ApplyResources(Me.bvtiExport, "bvtiExport")
			Me.bvtiExport.ContentControl = Me.backstageViewClientControl4
			Me.bvtiExport.Name = "bvtiExport"
            Me.bvtiExport.Selected = False
            '
            'BBColorMix
            '
            Me.BBColorMix.Caption = "Color Mix"
            Me.BBColorMix.Glyph = My.Resources.ColorMixer_16x16
            Me.BBColorMix.Id = 122
            Me.BBColorMix.LargeGlyph = My.Resources.ColorMixer_32x32
            Me.BBColorMix.LargeImageIndex = 0
            Me.BBColorMix.Name = "BBColorMix"
			' 
			' bvbiExit
			' 
			resources.ApplyResources(Me.bvbiExit, "bvbiExit")
			Me.bvbiExit.Glyph = My.Resources.Close_16x16
			Me.bvbiExit.Name = "bvbiExit"
'			Me.bvbiExit.ItemClick += New DevExpress.XtraBars.Ribbon.BackstageViewItemEventHandler(Me.bvbiExit_ItemClick)
			' 
			' rgbiSkins
			' 
			resources.ApplyResources(Me.rgbiSkins, "rgbiSkins")
			Me.rgbiSkins.Id = 1
			Me.rgbiSkins.Name = "rgbiSkins"
			' 
			' bsiNavigation
			' 
			resources.ApplyResources(Me.bsiNavigation, "bsiNavigation")
			Me.bsiNavigation.Glyph = My.Resources.NavigationBar_16x16
			Me.bsiNavigation.Id = 16
			Me.bsiNavigation.LargeGlyph = My.Resources.NavigationBar_32x32
			Me.bsiNavigation.Name = "bsiNavigation"
			' 
			' bsiInfo
			' 
			Me.bsiInfo.Id = 37
			Me.bsiInfo.Name = "bsiInfo"
			Me.bsiInfo.TextAlignment = System.Drawing.StringAlignment.Near
			' 
			' beiZoom
			' 
			Me.beiZoom.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
			Me.beiZoom.Edit = Me.repositoryItemZoomTrackBar1
			Me.beiZoom.EditValue = 10
			Me.beiZoom.Id = 38
			Me.beiZoom.Name = "beiZoom"
			resources.ApplyResources(Me.beiZoom, "beiZoom")
			' 
			' repositoryItemZoomTrackBar1
			' 
			Me.repositoryItemZoomTrackBar1.Alignment = DevExpress.Utils.VertAlignment.Center
			Me.repositoryItemZoomTrackBar1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.repositoryItemZoomTrackBar1.Maximum = 19
			Me.repositoryItemZoomTrackBar1.Middle = 5
			Me.repositoryItemZoomTrackBar1.Minimum = 1
			Me.repositoryItemZoomTrackBar1.Name = "repositoryItemZoomTrackBar1"
			Me.repositoryItemZoomTrackBar1.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight
			' 
			' bbiNormal
			' 
			Me.bbiNormal.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
			Me.bbiNormal.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			Me.bbiNormal.Glyph = My.Resources.normal
			resources.ApplyResources(Me.bbiNormal, "bbiNormal")
			Me.bbiNormal.Id = 39
			Me.bbiNormal.Name = "bbiNormal"
'			Me.bbiNormal.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.bbiNormal_ItemClick)
			' 
			' bbiReading
			' 
			Me.bbiReading.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
			Me.bbiReading.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			Me.bbiReading.Glyph = My.Resources.reading
			resources.ApplyResources(Me.bbiReading, "bbiReading")
			Me.bbiReading.Id = 40
			Me.bbiReading.Name = "bbiReading"
'			Me.bbiReading.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.bbiReading_ItemClick)
			' 
			' bsiTemp
			' 
			Me.bsiTemp.Id = 41
			Me.bsiTemp.Name = "bsiTemp"
			Me.bsiTemp.TextAlignment = System.Drawing.StringAlignment.Near
			' 
			' bbiManageView
			' 
			resources.ApplyResources(Me.bbiManageView, "bbiManageView")
			Me.bbiManageView.Enabled = False
			Me.bbiManageView.Id = 42
			Me.bbiManageView.Name = "bbiManageView"
			' 
			' bbiSaveCurrentView
			' 
			resources.ApplyResources(Me.bbiSaveCurrentView, "bbiSaveCurrentView")
			Me.bbiSaveCurrentView.Enabled = False
			Me.bbiSaveCurrentView.Id = 43
			Me.bbiSaveCurrentView.Name = "bbiSaveCurrentView"
			' 
			' rgbiCurrentViewTasks
			' 
			resources.ApplyResources(Me.rgbiCurrentViewTasks, "rgbiCurrentViewTasks")
			' 
			' 
			' 
			Me.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Disabled.Options.UseFont = True
			Me.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseFont = True
			Me.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = True
			Me.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = True
			Me.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = True
			Me.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseFont = True
			Me.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = True
			Me.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.rgbiCurrentViewTasks.Gallery.ColumnCount = 4
			resources.ApplyResources(galleryItemGroup1, "galleryItemGroup1")
			resources.ApplyResources(galleryItem1, "galleryItem1")
			galleryItem1.Checked = True
			galleryItem1.Image = My.Resources.ListByDate_32x32
			galleryItem1.Tag = "TaskList"
			resources.ApplyResources(galleryItem2, "galleryItem2")
			galleryItem2.Image = My.Resources.ToDoList_32x32
			galleryItem2.Tag = "TaskToDoList"
			resources.ApplyResources(galleryItem3, "galleryItem3")
			galleryItem3.Image = My.Resources.Completed_32x32
			galleryItem3.Tag = "TaskCompleted"
			resources.ApplyResources(galleryItem4, "galleryItem4")
			galleryItem4.Image = My.Resources.Today_32x32
			galleryItem4.Tag = "TaskToday"
			resources.ApplyResources(galleryItem5, "galleryItem5")
			galleryItem5.Image = My.Resources.Prioritized_32x32
			galleryItem5.Tag = "TaskPrioritized"
			resources.ApplyResources(galleryItem6, "galleryItem6")
			galleryItem6.Image = My.Resources.Overdue_32x32
			galleryItem6.Tag = "TaskOverdue"
			resources.ApplyResources(galleryItem7, "galleryItem7")
			galleryItem7.Image = My.Resources.List_32x32
			galleryItem7.Tag = "TaskSimpleList"
			resources.ApplyResources(galleryItem8, "galleryItem8")
			galleryItem8.Image = My.Resources.Deferred_32x32
			galleryItem8.Tag = "TaskDeferred"
			galleryItemGroup1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { galleryItem1, galleryItem2, galleryItem3, galleryItem4, galleryItem5, galleryItem6, galleryItem7, galleryItem8})
			Me.rgbiCurrentViewTasks.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { galleryItemGroup1})
			Me.rgbiCurrentViewTasks.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.rgbiCurrentViewTasks.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleRadio
			Me.rgbiCurrentViewTasks.Gallery.RowCount = 2
			Me.rgbiCurrentViewTasks.Gallery.ShowItemText = True
			Me.rgbiCurrentViewTasks.Id = 44
			Me.rgbiCurrentViewTasks.Name = "rgbiCurrentViewTasks"
'			Me.rgbiCurrentViewTasks.GalleryItemClick += New DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(Me.rgbiCurrentViewTasks_GalleryItemClick)
'			Me.rgbiCurrentViewTasks.GalleryInitDropDownGallery += New DevExpress.XtraBars.Ribbon.InplaceGalleryEventHandler(Me.rgbiCurrentView_GalleryInitDropDownGallery)
			' 
			' bbiTodayFlag
			' 
			Me.bbiTodayFlag.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			resources.ApplyResources(Me.bbiTodayFlag, "bbiTodayFlag")
			Me.bbiTodayFlag.Glyph = My.Resources.Today_Flag
			Me.bbiTodayFlag.Id = 45
			Me.bbiTodayFlag.Name = "bbiTodayFlag"
			' 
			' bbiTomorrowFlag
			' 
			Me.bbiTomorrowFlag.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			resources.ApplyResources(Me.bbiTomorrowFlag, "bbiTomorrowFlag")
			Me.bbiTomorrowFlag.Glyph = My.Resources.Tomorrow_Flag
			Me.bbiTomorrowFlag.Id = 46
			Me.bbiTomorrowFlag.Name = "bbiTomorrowFlag"
			' 
			' bbiThisWeekFlag
			' 
			Me.bbiThisWeekFlag.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			resources.ApplyResources(Me.bbiThisWeekFlag, "bbiThisWeekFlag")
			Me.bbiThisWeekFlag.Glyph = My.Resources.ThisWeek_Flag
			Me.bbiThisWeekFlag.Id = 47
			Me.bbiThisWeekFlag.Name = "bbiThisWeekFlag"
			' 
			' bbiNextWeekFlag
			' 
			Me.bbiNextWeekFlag.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			resources.ApplyResources(Me.bbiNextWeekFlag, "bbiNextWeekFlag")
			Me.bbiNextWeekFlag.Glyph = My.Resources.NextWeek_Flag
			Me.bbiNextWeekFlag.Id = 48
			Me.bbiNextWeekFlag.Name = "bbiNextWeekFlag"
			' 
			' bbiNoDateFlag
			' 
			Me.bbiNoDateFlag.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			resources.ApplyResources(Me.bbiNoDateFlag, "bbiNoDateFlag")
			Me.bbiNoDateFlag.Glyph = My.Resources.NoDate_Flag
			Me.bbiNoDateFlag.Id = 49
			Me.bbiNoDateFlag.Name = "bbiNoDateFlag"
			' 
			' bbiCustomFlag
			' 
			resources.ApplyResources(Me.bbiCustomFlag, "bbiCustomFlag")
			Me.bbiCustomFlag.Glyph = My.Resources.Custom_Flag
			Me.bbiCustomFlag.Id = 50
			Me.bbiCustomFlag.Name = "bbiCustomFlag"
			' 
			' bbiNewTask
			' 
			resources.ApplyResources(Me.bbiNewTask, "bbiNewTask")
			Me.bbiNewTask.Glyph = My.Resources.NewTask_16x16
			Me.bbiNewTask.Id = 54
			Me.bbiNewTask.LargeGlyph = My.Resources.NewTask_32x32
			Me.bbiNewTask.Name = "bbiNewTask"
			' 
			' bbiEditTask
			' 
			resources.ApplyResources(Me.bbiEditTask, "bbiEditTask")
			Me.bbiEditTask.Glyph = My.Resources.EditTask_16x16
			Me.bbiEditTask.Id = 55
			Me.bbiEditTask.LargeGlyph = My.Resources.EditTask_32x32
			Me.bbiEditTask.Name = "bbiEditTask"
			' 
			' bbiDeleteTask
			' 
			resources.ApplyResources(Me.bbiDeleteTask, "bbiDeleteTask")
			Me.bbiDeleteTask.Glyph = My.Resources.Delete_16x16
			Me.bbiDeleteTask.Id = 56
			Me.bbiDeleteTask.LargeGlyph = My.Resources.Delete_32x32
			Me.bbiDeleteTask.Name = "bbiDeleteTask"
			' 
			' bbiNewContact
			' 
			resources.ApplyResources(Me.bbiNewContact, "bbiNewContact")
			Me.bbiNewContact.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
			Me.bbiNewContact.Glyph = My.Resources.NewContact_16x16
			Me.bbiNewContact.Id = 97
			Me.bbiNewContact.LargeGlyph = My.Resources.NewContact_32x32
			Me.bbiNewContact.Name = "bbiNewContact"
			' 
			' bbiEditContact
			' 
			resources.ApplyResources(Me.bbiEditContact, "bbiEditContact")
			Me.bbiEditContact.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
			Me.bbiEditContact.Glyph = My.Resources.EditContact_16x16
			Me.bbiEditContact.Id = 98
			Me.bbiEditContact.LargeGlyph = My.Resources.EditContact_32x32
			Me.bbiEditContact.Name = "bbiEditContact"
			' 
			' bbiDeleteContact
			' 
			resources.ApplyResources(Me.bbiDeleteContact, "bbiDeleteContact")
			Me.bbiDeleteContact.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
			Me.bbiDeleteContact.Glyph = My.Resources.Delete_16x16
			Me.bbiDeleteContact.Id = 99
			Me.bbiDeleteContact.LargeGlyph = My.Resources.Delete_32x32
			Me.bbiDeleteContact.Name = "bbiDeleteContact"
			' 
			' bbiFlipLayout
			' 
			resources.ApplyResources(Me.bbiFlipLayout, "bbiFlipLayout")
			Me.bbiFlipLayout.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
			Me.bbiFlipLayout.Glyph = My.Resources.LayoutFlip_16x16
			Me.bbiFlipLayout.Id = 100
			Me.bbiFlipLayout.LargeGlyph = My.Resources.LayoutFlip_32x32
			Me.bbiFlipLayout.Name = "bbiFlipLayout"
			' 
			' rgbiCurrentView
			' 
			resources.ApplyResources(Me.rgbiCurrentView, "rgbiCurrentView")
			' 
			' 
			' 
			Me.rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseFont = True
			Me.rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = True
			Me.rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = True
			Me.rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = True
			Me.rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseFont = True
			Me.rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = True
			Me.rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.rgbiCurrentView.Gallery.ColumnCount = 4
			resources.ApplyResources(galleryItemGroup2, "galleryItemGroup2")
			resources.ApplyResources(galleryItem9, "galleryItem9")
			galleryItem9.Image = My.Resources.List_32x32
			galleryItem9.Tag = "List"
			resources.ApplyResources(galleryItem10, "galleryItem10")
			galleryItem10.Image = My.Resources.SortAsc_32x32
			galleryItem10.Tag = "Alphabetical"
			resources.ApplyResources(galleryItem11, "galleryItem11")
			galleryItem11.Image = My.Resources.ByState_32x32
			galleryItem11.Tag = "ByState"
			resources.ApplyResources(galleryItem12, "galleryItem12")
			galleryItem12.Checked = True
			galleryItem12.Image = My.Resources.Card_32x32
			galleryItem12.Tag = "Card"
			galleryItemGroup2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { galleryItem9, galleryItem10, galleryItem11, galleryItem12})
			Me.rgbiCurrentView.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { galleryItemGroup2})
			Me.rgbiCurrentView.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.rgbiCurrentView.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleRadio
			Me.rgbiCurrentView.Gallery.RowCount = 1
			Me.rgbiCurrentView.Gallery.ShowItemText = True
			Me.rgbiCurrentView.Id = 101
			Me.rgbiCurrentView.Name = "rgbiCurrentView"
'			Me.rgbiCurrentView.GalleryItemClick += New DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(Me.galleryControlGallery1_ItemClick)
'			Me.rgbiCurrentView.GalleryInitDropDownGallery += New DevExpress.XtraBars.Ribbon.InplaceGalleryEventHandler(Me.rgbiCurrentView_GalleryInitDropDownGallery)
			' 
			' biPrintPreview
			' 
			resources.ApplyResources(Me.biPrintPreview, "biPrintPreview")
			Me.biPrintPreview.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
			Me.biPrintPreview.Glyph = (CType(resources.GetObject("biPrintPreview.Glyph"), System.Drawing.Image))
			Me.biPrintPreview.Id = 102
			Me.biPrintPreview.LargeGlyph = (CType(resources.GetObject("biPrintPreview.LargeGlyph"), System.Drawing.Image))
			Me.biPrintPreview.Name = "biPrintPreview"
'			Me.biPrintPreview.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.biPrintPreview_ItemClick)
			' 
			' bbiReminder
			' 
			Me.bbiReminder.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True
			Me.bbiReminder.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
			Me.bbiReminder.Glyph = My.Resources.reminder
			Me.bbiReminder.Id = 103
			Me.bbiReminder.Name = "bbiReminder"
'			Me.bbiReminder.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.bbiReminder_ItemClick)
			' 
			' rpTasks
			' 
			Me.rpTasks.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.rpgTasks, Me.rpgFollowUp, Me.rpdCurrentViewTasks})
			Me.rpTasks.Name = "rpTasks"
			Me.rpTasks.Tag = "Tasks"
			resources.ApplyResources(Me.rpTasks, "rpTasks")
			' 
			' rpgTasks
			' 
			Me.rpgTasks.ItemLinks.Add(Me.bbiNewTask)
			Me.rpgTasks.ItemLinks.Add(Me.bbiEditTask)
			Me.rpgTasks.ItemLinks.Add(Me.bbiDeleteTask, True)
			Me.rpgTasks.Name = "rpgTasks"
			Me.rpgTasks.ShowCaptionButton = False
			resources.ApplyResources(Me.rpgTasks, "rpgTasks")
			' 
			' rpgFollowUp
			' 
			Me.rpgFollowUp.ItemLinks.Add(Me.bbiTodayFlag)
			Me.rpgFollowUp.ItemLinks.Add(Me.bbiTomorrowFlag)
			Me.rpgFollowUp.ItemLinks.Add(Me.bbiThisWeekFlag)
			Me.rpgFollowUp.ItemLinks.Add(Me.bbiNextWeekFlag)
			Me.rpgFollowUp.ItemLinks.Add(Me.bbiNoDateFlag)
			Me.rpgFollowUp.ItemLinks.Add(Me.bbiCustomFlag)
			Me.rpgFollowUp.Name = "rpgFollowUp"
			Me.rpgFollowUp.ShowCaptionButton = False
			resources.ApplyResources(Me.rpgFollowUp, "rpgFollowUp")
			' 
			' rpdCurrentViewTasks
			' 
			Me.rpdCurrentViewTasks.ItemLinks.Add(Me.rgbiCurrentViewTasks)
			Me.rpdCurrentViewTasks.Name = "rpdCurrentViewTasks"
			Me.rpdCurrentViewTasks.ShowCaptionButton = False
			resources.ApplyResources(Me.rpdCurrentViewTasks, "rpdCurrentViewTasks")
			' 
			' rpContacts
			' 
			Me.rpContacts.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.rpgContacts, Me.rpgCurrentView, Me.rpgLayoutContacts})
			Me.rpContacts.Name = "rpContacts"
			Me.rpContacts.Tag = "Contacts"
			resources.ApplyResources(Me.rpContacts, "rpContacts")
			' 
			' rpgContacts
			' 
			Me.rpgContacts.ItemLinks.Add(Me.bbiNewContact)
			Me.rpgContacts.ItemLinks.Add(Me.bbiEditContact)
			Me.rpgContacts.ItemLinks.Add(Me.bbiDeleteContact, True)
			Me.rpgContacts.Name = "rpgContacts"
			Me.rpgContacts.ShowCaptionButton = False
			resources.ApplyResources(Me.rpgContacts, "rpgContacts")
			' 
			' rpgCurrentView
			' 
			Me.rpgCurrentView.ItemLinks.Add(Me.rgbiCurrentView)
			Me.rpgCurrentView.Name = "rpgCurrentView"
			Me.rpgCurrentView.ShowCaptionButton = False
			resources.ApplyResources(Me.rpgCurrentView, "rpgCurrentView")
			' 
			' rpgLayoutContacts
			' 
			Me.rpgLayoutContacts.ItemLinks.Add(Me.bbiFlipLayout)
			Me.rpgLayoutContacts.Name = "rpgLayoutContacts"
			Me.rpgLayoutContacts.ShowCaptionButton = False
			resources.ApplyResources(Me.rpgLayoutContacts, "rpgLayoutContacts")
			' 
			' rpView
			' 
			Me.rpView.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.rpgNavigation, Me.prgAppearance, Me.rpgPrint})
			Me.rpView.Name = "rpView"
			resources.ApplyResources(Me.rpView, "rpView")
			' 
			' rpgNavigation
			' 
			Me.rpgNavigation.AllowTextClipping = False
			Me.rpgNavigation.ItemLinks.Add(Me.bsiNavigation)
			Me.rpgNavigation.Name = "rpgNavigation"
			Me.rpgNavigation.ShowCaptionButton = False
			resources.ApplyResources(Me.rpgNavigation, "rpgNavigation")
			' 
			' prgAppearance
			' 
            Me.prgAppearance.ItemLinks.Add(Me.rgbiSkins)
            Me.prgAppearance.ItemLinks.Add(Me.BBColorMix)
			Me.prgAppearance.Name = "prgAppearance"
			Me.prgAppearance.ShowCaptionButton = False
			resources.ApplyResources(Me.prgAppearance, "prgAppearance")
			' 
			' rpgPrint
			' 
			Me.rpgPrint.AllowTextClipping = False
			Me.rpgPrint.ItemLinks.Add(Me.biPrintPreview)
			Me.rpgPrint.Name = "rpgPrint"
			Me.rpgPrint.ShowCaptionButton = False
			resources.ApplyResources(Me.rpgPrint, "rpgPrint")
			' 
			' repositoryItemSpinEdit1
			' 
			resources.ApplyResources(Me.repositoryItemSpinEdit1, "repositoryItemSpinEdit1")
			Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.repositoryItemSpinEdit1.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
			Me.repositoryItemSpinEdit1.MaxValue = New Decimal(New Integer() { 200, 0, 0, 0})
			Me.repositoryItemSpinEdit1.MinValue = New Decimal(New Integer() { 10, 0, 0, 0})
			Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
			' 
			' repositoryItemDuration1
			' 
			Me.repositoryItemDuration1.AllowNullInput = DevExpress.Utils.DefaultBoolean.False
			resources.ApplyResources(Me.repositoryItemDuration1, "repositoryItemDuration1")
			Me.repositoryItemDuration1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("repositoryItemDuration1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			Me.repositoryItemDuration1.Name = "repositoryItemDuration1"
			Me.repositoryItemDuration1.ShowEmptyItem = True
			Me.repositoryItemDuration1.ValidateOnEnterKey = True
			' 
			' ribbonStatusBar1
			' 
			Me.ribbonStatusBar1.ItemLinks.Add(Me.bsiInfo)
			Me.ribbonStatusBar1.ItemLinks.Add(Me.bbiNormal)
			Me.ribbonStatusBar1.ItemLinks.Add(Me.bbiReading)
			Me.ribbonStatusBar1.ItemLinks.Add(Me.beiZoom, True)
			Me.ribbonStatusBar1.ItemLinks.Add(Me.bbiReminder, True)
			Me.ribbonStatusBar1.ItemLinks.Add(Me.bsiTemp, True)
			resources.ApplyResources(Me.ribbonStatusBar1, "ribbonStatusBar1")
			Me.ribbonStatusBar1.Name = "ribbonStatusBar1"
			Me.ribbonStatusBar1.Ribbon = Me.ribbonControl1
			' 
			' navBarControl1
			' 
			Me.navBarControl1.ActiveGroup = Me.nbgModules
            Me.navBarControl1.LinkSelectionMode = XtraNavBar.LinkSelectionModeType.OneInControl
			resources.ApplyResources(Me.navBarControl1, "navBarControl1")
			Me.navBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() { Me.nbgModules})
			Me.navBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() { Me.nbiGrid, Me.nbiSpreadsheet, Me.nbiWord, Me.nbiSnap, Me.nbiReports, Me.nbiPivot, Me.nbiCharts, Me.nbiMaps, Me.nbiScheduler, Me.nbiGridCardView, Me.nbiPdf})
			Me.navBarControl1.MenuManager = Me.ribbonControl1
			Me.navBarControl1.Name = "navBarControl1"
			Me.navBarControl1.NavigationPaneGroupClientHeight = 320
			Me.navBarControl1.OptionsNavPane.ExpandedWidth = (CInt(Fix(resources.GetObject("resource.ExpandedWidth"))))
			Me.navBarControl1.OptionsNavPane.ShowOverflowButton = False
			Me.navBarControl1.OptionsNavPane.ShowOverflowPanel = False
			Me.navBarControl1.OptionsNavPane.ShowSplitter = False
			Me.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane
			Me.navBarControl1.StoreDefaultPaintStyleName = True
'			Me.navBarControl1.SelectedLinkChanged += New DevExpress.XtraNavBar.ViewInfo.NavBarSelectedLinkChangedEventHandler(Me.navBarControl1_SelectedLinkChanged)
'			Me.navBarControl1.NavPaneStateChanged += New System.EventHandler(Me.navBarControl1_NavPaneStateChanged)
			' 
			' nbgModules
			' 
			resources.ApplyResources(Me.nbgModules, "nbgModules")
			Me.nbgModules.Expanded = True
			Me.nbgModules.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
			Me.nbgModules.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText
			Me.nbgModules.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiGrid), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiGridCardView), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiSpreadsheet), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiWord), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiSnap), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiReports), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiPivot), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiCharts), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiMaps), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiScheduler), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiPdf)})
			Me.nbgModules.Name = "nbgModules"
			Me.nbgModules.NavigationPaneVisible = False
			Me.nbgModules.SelectedLinkIndex = 9
			' 
			' nbiGrid
			' 
			resources.ApplyResources(Me.nbiGrid, "nbiGrid")
			Me.nbiGrid.LargeImage = My.Resources.GridTasks
			Me.nbiGrid.Name = "nbiGrid"
			' 
			' nbiGridCardView
			' 
			resources.ApplyResources(Me.nbiGridCardView, "nbiGridCardView")
			Me.nbiGridCardView.LargeImage = My.Resources.GridContacts
			Me.nbiGridCardView.Name = "nbiGridCardView"
			' 
			' nbiSpreadsheet
			' 
			resources.ApplyResources(Me.nbiSpreadsheet, "nbiSpreadsheet")
			Me.nbiSpreadsheet.LargeImage = My.Resources.Spreadsheet
			Me.nbiSpreadsheet.Name = "nbiSpreadsheet"
			' 
			' nbiWord
			' 
			resources.ApplyResources(Me.nbiWord, "nbiWord")
			Me.nbiWord.LargeImage = My.Resources.WordProcessing
			Me.nbiWord.Name = "nbiWord"
			' 
			' nbiSnap
			' 
			resources.ApplyResources(Me.nbiSnap, "nbiSnap")
			Me.nbiSnap.LargeImage = My.Resources.WYSIWYGReports
			Me.nbiSnap.Name = "nbiSnap"
			' 
			' nbiReports
			' 
			resources.ApplyResources(Me.nbiReports, "nbiReports")
			Me.nbiReports.LargeImage = My.Resources.BandedReports
			Me.nbiReports.Name = "nbiReports"
			' 
			' nbiPivot
			' 
			resources.ApplyResources(Me.nbiPivot, "nbiPivot")
			Me.nbiPivot.LargeImage = My.Resources.Pivot
			Me.nbiPivot.Name = "nbiPivot"
			' 
			' nbiCharts
			' 
			resources.ApplyResources(Me.nbiCharts, "nbiCharts")
			Me.nbiCharts.LargeImage = My.Resources.Analytics
			Me.nbiCharts.Name = "nbiCharts"
			' 
			' nbiMaps
			' 
			resources.ApplyResources(Me.nbiMaps, "nbiMaps")
			Me.nbiMaps.LargeImage = My.Resources.WeatherMap
			Me.nbiMaps.Name = "nbiMaps"
			' 
			' nbiScheduler
			' 
			resources.ApplyResources(Me.nbiScheduler, "nbiScheduler")
			Me.nbiScheduler.LargeImage = My.Resources.Scheduler
			Me.nbiScheduler.Name = "nbiScheduler"
			' 
			' nbiPdf
			' 
			resources.ApplyResources(Me.nbiPdf, "nbiPdf")
			Me.nbiPdf.LargeImage = My.Resources.PDFViewer
			Me.nbiPdf.Name = "nbiPdf"
			' 
			' pcMain
			' 
			Me.pcMain.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pcMain.Controls.Add(Me.backstageViewControl1)
			resources.ApplyResources(Me.pcMain, "pcMain")
			Me.pcMain.Name = "pcMain"
			' 
			' pmFlagStatus
			' 
			Me.pmFlagStatus.ItemLinks.Add(Me.bbiTodayFlag)
			Me.pmFlagStatus.ItemLinks.Add(Me.bbiTomorrowFlag)
			Me.pmFlagStatus.ItemLinks.Add(Me.bbiThisWeekFlag)
			Me.pmFlagStatus.ItemLinks.Add(Me.bbiNextWeekFlag)
			Me.pmFlagStatus.ItemLinks.Add(Me.bbiNoDateFlag)
			Me.pmFlagStatus.ItemLinks.Add(Me.bbiCustomFlag, True)
			Me.pmFlagStatus.Name = "pmFlagStatus"
			Me.pmFlagStatus.Ribbon = Me.ribbonControl1
			' 
			' frmMain
			' 
			resources.ApplyResources(Me, "$this")
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.pcMain)
			Me.Controls.Add(Me.navBarControl1)
			Me.Controls.Add(Me.ribbonStatusBar1)
			Me.Controls.Add(Me.ribbonControl1)
			Me.KeyPreview = True
			Me.Name = "frmMain"
			Me.Ribbon = Me.ribbonControl1
			Me.StatusBar = Me.ribbonStatusBar1
'			Me.KeyDown += New System.Windows.Forms.KeyEventHandler(Me.frmMain_KeyDown)
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.backstageViewControl1.ResumeLayout(False)
			Me.backstageViewClientControl1.ResumeLayout(False)
			Me.backstageViewClientControl3.ResumeLayout(False)
			Me.backstageViewClientControl4.ResumeLayout(False)
			CType(Me.repositoryItemZoomTrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemDuration1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pcMain, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pcMain.ResumeLayout(False)
			CType(Me.pmFlagStatus, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
		Private ribbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
		Private WithEvents navBarControl1 As DevExpress.XtraNavBar.NavBarControl
		Private pcMain As DevExpress.XtraEditors.PanelControl
		Private nbgModules As DevExpress.XtraNavBar.NavBarGroup
		Private rpTasks As DevExpress.XtraBars.Ribbon.RibbonPage
		Private rpView As DevExpress.XtraBars.Ribbon.RibbonPage
		Private rgbiSkins As DevExpress.XtraBars.RibbonGalleryBarItem
		Private rpgNavigation As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private prgAppearance As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private bsiNavigation As DevExpress.XtraBars.BarSubItem
		Private WithEvents backstageViewControl1 As DevExpress.XtraBars.Ribbon.BackstageViewControl
		Private bvbiSaveAs As DevExpress.XtraBars.Ribbon.BackstageViewButtonItem
		Private backstageViewClientControl1 As DevExpress.XtraBars.Ribbon.BackstageViewClientControl
		Private bvbiSaveAttachment As DevExpress.XtraBars.Ribbon.BackstageViewButtonItem
		Private bvtiInfo As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
		Private WithEvents bvbiExit As DevExpress.XtraBars.Ribbon.BackstageViewButtonItem
		Private bsiInfo As DevExpress.XtraBars.BarStaticItem
		Private beiZoom As DevExpress.XtraBars.BarEditItem
		Private repositoryItemZoomTrackBar1 As DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar
		Private WithEvents bbiNormal As DevExpress.XtraBars.BarButtonItem
		Private WithEvents bbiReading As DevExpress.XtraBars.BarButtonItem
		Private bsiTemp As DevExpress.XtraBars.BarStaticItem
		Private bbiManageView As DevExpress.XtraBars.BarButtonItem
		Private bbiSaveCurrentView As DevExpress.XtraBars.BarButtonItem
		Private WithEvents rgbiCurrentViewTasks As DevExpress.XtraBars.RibbonGalleryBarItem
		Private rpdCurrentViewTasks As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private bbiTodayFlag As DevExpress.XtraBars.BarButtonItem
		Private bbiTomorrowFlag As DevExpress.XtraBars.BarButtonItem
		Private bbiThisWeekFlag As DevExpress.XtraBars.BarButtonItem
		Private bbiNextWeekFlag As DevExpress.XtraBars.BarButtonItem
		Private bbiNoDateFlag As DevExpress.XtraBars.BarButtonItem
		Private bbiCustomFlag As DevExpress.XtraBars.BarButtonItem
		Private rpgFollowUp As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private pmFlagStatus As DevExpress.XtraBars.PopupMenu
		Private backstageViewClientControl3 As DevExpress.XtraBars.Ribbon.BackstageViewClientControl
		Private printControl1 As DevExpress.ProductsDemo.Win.Controls.PrintControl
		Private WithEvents bvtiPrint As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
		Private helpControl1 As DevExpress.ProductsDemo.Win.Controls.HelpControl
		Private backstageViewClientControl4 As DevExpress.XtraBars.Ribbon.BackstageViewClientControl
		Private exportControl1 As DevExpress.ProductsDemo.Win.Controls.ExportControl
		Private bvtiExport As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
		Private bbiNewTask As DevExpress.XtraBars.BarButtonItem
		Private bbiEditTask As DevExpress.XtraBars.BarButtonItem
		Private bbiDeleteTask As DevExpress.XtraBars.BarButtonItem
		Private rpgTasks As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private repositoryItemDuration1 As DevExpress.XtraScheduler.UI.RepositoryItemDuration
		Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
		Private nbiGrid As XtraNavBar.NavBarItem
		Private nbiSpreadsheet As XtraNavBar.NavBarItem
		Private nbiWord As XtraNavBar.NavBarItem
		Private nbiSnap As XtraNavBar.NavBarItem
		Private nbiReports As XtraNavBar.NavBarItem
		Private nbiPivot As XtraNavBar.NavBarItem
		Private nbiCharts As XtraNavBar.NavBarItem
		Private nbiMaps As XtraNavBar.NavBarItem
		Private nbiScheduler As XtraNavBar.NavBarItem
		Private nbiGridCardView As XtraNavBar.NavBarItem
		Private rpContacts As XtraBars.Ribbon.RibbonPage
		Private bbiNewContact As XtraBars.BarButtonItem
		Private bbiEditContact As XtraBars.BarButtonItem
		Private bbiDeleteContact As XtraBars.BarButtonItem
		Private bbiFlipLayout As XtraBars.BarButtonItem
		Private rpgContacts As XtraBars.Ribbon.RibbonPageGroup
		Private rpgCurrentView As XtraBars.Ribbon.RibbonPageGroup
		Private rpgLayoutContacts As XtraBars.Ribbon.RibbonPageGroup
		Private WithEvents rgbiCurrentView As XtraBars.RibbonGalleryBarItem
		Private nbiPdf As XtraNavBar.NavBarItem
		Private WithEvents biPrintPreview As XtraBars.BarButtonItem
		Private rpgPrint As XtraBars.Ribbon.RibbonPageGroup
        Private WithEvents bbiReminder As XtraBars.BarButtonItem
        Friend WithEvents BBColorMix As DevExpress.XtraBars.BarButtonItem
	End Class
End Namespace


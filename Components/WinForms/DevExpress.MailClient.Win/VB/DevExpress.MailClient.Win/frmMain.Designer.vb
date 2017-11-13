Namespace DevExpress.MailClient.Win
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
			Dim galleryItemGroup2 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
			Dim galleryItem2 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem3 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem4 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem5 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItemGroup3 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
			Dim galleryItem6 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem7 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem8 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem9 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem10 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem11 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem12 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem13 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
			Me.backstageViewControl1 = New DevExpress.XtraBars.Ribbon.BackstageViewControl()
			Me.backstageViewClientControl1 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
			Me.helpControl1 = New DevExpress.MailClient.Win.Controls.HelpControl()
			Me.backstageViewClientControl2 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
			Me.galleryControl1 = New DevExpress.XtraBars.Ribbon.GalleryControl()
			Me.galleryControlClient1 = New DevExpress.XtraBars.Ribbon.GalleryControlClient()
			Me.backstageViewClientControl3 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
			Me.printControl1 = New DevExpress.MailClient.Win.Controls.PrintControl()
			Me.backstageViewClientControl4 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
			Me.exportControl1 = New DevExpress.MailClient.Win.Controls.ExportControl()
			Me.bvbiSaveAs = New DevExpress.XtraBars.Ribbon.BackstageViewButtonItem()
			Me.bvbiSaveAttachment = New DevExpress.XtraBars.Ribbon.BackstageViewButtonItem()
			Me.bvbiSaveCalendar = New DevExpress.XtraBars.Ribbon.BackstageViewButtonItem()
			Me.bvtiInfo = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
			Me.bvtiOpen = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
			Me.bvtiPrint = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
			Me.bvtiExport = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
			Me.bvbiExit = New DevExpress.XtraBars.Ribbon.BackstageViewButtonItem()
			Me.rgbiSkins = New DevExpress.XtraBars.RibbonGalleryBarItem()
			Me.bbiRotateLayout = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiFlipLayout = New DevExpress.XtraBars.BarButtonItem()
			Me.bciShowUnreadMessageCount = New DevExpress.XtraBars.BarCheckItem()
			Me.bciShowAllMessageCount = New DevExpress.XtraBars.BarCheckItem()
			Me.bbiDelete = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiNew = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiReply = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiForward = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiReplyAll = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiUnreadRead = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiPriority = New DevExpress.XtraBars.BarButtonItem()
			Me.bsiNavigation = New DevExpress.XtraBars.BarSubItem()
			Me.bbiCloseSearch = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiShowUnread = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiImportant = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiHasAttachment = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiResetColumnsToDefault = New DevExpress.XtraBars.BarButtonItem()
			Me.bsiColumns = New DevExpress.XtraBars.BarSubItem()
			Me.bbiSubjectColumn = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiFromColumn = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiDateColumn = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiPriorityColumn = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiAttachmentColumn = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiDate = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiClearFilter = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiNewFeed = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiEditFeed = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiDeleteFeed = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiRefreshFeed = New DevExpress.XtraBars.BarButtonItem()
			Me.rgbiCurrentView = New DevExpress.XtraBars.RibbonGalleryBarItem()
			Me.bsiInfo = New DevExpress.XtraBars.BarStaticItem()
			Me.beiZoom = New DevExpress.XtraBars.BarEditItem()
			Me.repositoryItemZoomTrackBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar()
			Me.bbiNormal = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiReading = New DevExpress.XtraBars.BarButtonItem()
			Me.bsiTemp = New DevExpress.XtraBars.BarStaticItem()
			Me.bbiManageView = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiSaveCurrentView = New DevExpress.XtraBars.BarButtonItem()
			Me.rgbiCurrentViewTasks = New DevExpress.XtraBars.RibbonGalleryBarItem()
			Me.bbiTodayFlag = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiTomorrowFlag = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiThisWeekFlag = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiNextWeekFlag = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiNoDateFlag = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiCustomFlag = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiNewContact = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiEditContact = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiDeleteContact = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiNewTask = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiEditTask = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiDeleteTask = New DevExpress.XtraBars.BarButtonItem()
			Me.newAppointmentItem1 = New DevExpress.XtraScheduler.UI.NewAppointmentItem()
			Me.newRecurringAppointmentItem1 = New DevExpress.XtraScheduler.UI.NewRecurringAppointmentItem()
			Me.navigateViewBackwardItem1 = New DevExpress.XtraScheduler.UI.NavigateViewBackwardItem()
			Me.navigateViewForwardItem1 = New DevExpress.XtraScheduler.UI.NavigateViewForwardItem()
			Me.gotoTodayItem1 = New DevExpress.XtraScheduler.UI.GotoTodayItem()
			Me.viewZoomInItem1 = New DevExpress.XtraScheduler.UI.ViewZoomInItem()
			Me.viewZoomOutItem1 = New DevExpress.XtraScheduler.UI.ViewZoomOutItem()
			Me.switchToDayViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToDayViewItem()
			Me.switchToWorkWeekViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToWorkWeekViewItem()
			Me.switchToWeekViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToWeekViewItem()
			Me.switchToMonthViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToMonthViewItem()
			Me.switchToTimelineViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToTimelineViewItem()
			Me.groupByNoneItem1 = New DevExpress.XtraScheduler.UI.GroupByNoneItem()
			Me.groupByDateItem1 = New DevExpress.XtraScheduler.UI.GroupByDateItem()
			Me.groupByResourceItem1 = New DevExpress.XtraScheduler.UI.GroupByResourceItem()
			Me.switchTimeScalesItem1 = New DevExpress.XtraScheduler.UI.SwitchTimeScalesItem()
			Me.switchCompressWeekendItem1 = New DevExpress.XtraScheduler.UI.SwitchCompressWeekendItem()
			Me.switchShowWorkTimeOnlyItem1 = New DevExpress.XtraScheduler.UI.SwitchShowWorkTimeOnlyItem()
			Me.editAppointmentQueryItem1 = New DevExpress.XtraScheduler.UI.EditAppointmentQueryItem()
			Me.editOccurrenceUICommandItem1 = New DevExpress.XtraScheduler.UI.EditOccurrenceUICommandItem()
			Me.editSeriesUICommandItem1 = New DevExpress.XtraScheduler.UI.EditSeriesUICommandItem()
			Me.deleteAppointmentsItem1 = New DevExpress.XtraScheduler.UI.DeleteAppointmentsItem()
			Me.deleteOccurrenceItem1 = New DevExpress.XtraScheduler.UI.DeleteOccurrenceItem()
			Me.deleteSeriesItem1 = New DevExpress.XtraScheduler.UI.DeleteSeriesItem()
			Me.splitAppointmentItem1 = New DevExpress.XtraScheduler.UI.SplitAppointmentItem()
			Me.changeAppointmentStatusItem1 = New DevExpress.XtraScheduler.UI.ChangeAppointmentStatusItem()
			Me.changeAppointmentLabelItem1 = New DevExpress.XtraScheduler.UI.ChangeAppointmentLabelItem()
			Me.toggleRecurrenceItem1 = New DevExpress.XtraScheduler.UI.ToggleRecurrenceItem()
			Me.changeAppointmentReminderItem1 = New DevExpress.XtraScheduler.UI.ChangeAppointmentReminderItem()
			Me.repositoryItemDuration1 = New DevExpress.XtraScheduler.UI.RepositoryItemDuration()
			Me.bbiShowPreview = New DevExpress.XtraBars.BarButtonItem()
			Me.bsiConnected = New DevExpress.XtraBars.BarStaticItem()
			Me.biRename = New DevExpress.XtraBars.BarButtonItem()
			Me.biCreateFolder = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiReminder = New DevExpress.XtraBars.BarButtonItem()
			Me.bbColorMix = New DevExpress.XtraBars.BarButtonItem()
			Me.rpcSearch = New DevExpress.XtraBars.Ribbon.RibbonPageCategory()
			Me.rpSearch = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.rpgFind = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.rpgFilterColumns = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.rbgClose = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.calendarToolsRibbonPageCategory1 = New DevExpress.XtraScheduler.UI.CalendarToolsRibbonPageCategory()
			Me.appointmentRibbonPage1 = New DevExpress.XtraScheduler.UI.AppointmentRibbonPage()
			Me.actionsRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.ActionsRibbonPageGroup()
			Me.optionsRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.OptionsRibbonPageGroup()
			Me.rpMail = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.rpgNew = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.rpgDelete = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.rpgTags = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.rpgLayoutMail = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.rpCalendar = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.appointmentRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.AppointmentRibbonPageGroup()
			Me.navigatorRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.NavigatorRibbonPageGroup()
			Me.arrangeRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.ArrangeRibbonPageGroup()
			Me.groupByRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.GroupByRibbonPageGroup()
			Me.layoutRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.LayoutRibbonPageGroup()
			Me.rpContacts = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.rpgContacts = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.rpgCurrentView = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.rpgLayoutContacts = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.rpFeeds = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.rpgFeeds = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.rpgActionsFeeds = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.rpgLayoutFeeds = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.rpTasks = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.rpgTasks = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.rpgFollowUp = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.rpdCurrentViewTasks = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.rpView = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.rpgNavigation = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.prgAppearance = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
			Me.ribbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
			Me.navBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
			Me.nbgMail = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarGroupControlContainer1 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
			Me.ucMailTree1 = New DevExpress.MailClient.Win.ucMailTree()
			Me.navBarGroupControlContainer2 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
			Me.ucCalendar1 = New DevExpress.MailClient.Win.Controls.ucCalendar()
			Me.navBarGroupControlContainer3 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
			Me.ucContacts1 = New DevExpress.MailClient.Win.Controls.ucContacts()
			Me.navBarGroupControlContainer4 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
			Me.navBarControl2 = New DevExpress.XtraNavBar.NavBarControl()
			Me.nbgTasks = New DevExpress.XtraNavBar.NavBarGroup()
			Me.nbgCalendar = New DevExpress.XtraNavBar.NavBarGroup()
			Me.nbgContacts = New DevExpress.XtraNavBar.NavBarGroup()
			Me.nbgFeeds = New DevExpress.XtraNavBar.NavBarGroup()
			Me.pcMain = New DevExpress.XtraEditors.PanelControl()
			Me.pmTreeView = New DevExpress.XtraBars.PopupMenu(Me.components)
			Me.pmMessage = New DevExpress.XtraBars.PopupMenu(Me.components)
			Me.pmFlagStatus = New DevExpress.XtraBars.PopupMenu(Me.components)
			Me.schedulerBarController1 = New DevExpress.XtraScheduler.UI.SchedulerBarController()
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.backstageViewControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.backstageViewControl1.SuspendLayout()
            Me.backstageViewClientControl1.SuspendLayout()
            Me.backstageViewClientControl2.SuspendLayout()
            CType(Me.galleryControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.galleryControl1.SuspendLayout()
            Me.backstageViewClientControl3.SuspendLayout()
            Me.backstageViewClientControl4.SuspendLayout()
            CType(Me.repositoryItemZoomTrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemDuration1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navBarControl1.SuspendLayout()
            Me.navBarGroupControlContainer1.SuspendLayout()
            Me.navBarGroupControlContainer2.SuspendLayout()
            Me.navBarGroupControlContainer3.SuspendLayout()
            Me.navBarGroupControlContainer4.SuspendLayout()
            CType(Me.navBarControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pcMain, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pcMain.SuspendLayout()
            CType(Me.pmTreeView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pmMessage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pmFlagStatus, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.schedulerBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' ribbonControl1
            ' 
            resources.ApplyResources(Me.ribbonControl1, "ribbonControl1")
            Me.ribbonControl1.ApplicationButtonDropDownControl = Me.backstageViewControl1
            Me.ribbonControl1.Categories.AddRange(New DevExpress.XtraBars.BarManagerCategory() {(CType(resources.GetObject("ribbonControl1.Categories"), DevExpress.XtraBars.BarManagerCategory)), (CType(resources.GetObject("ribbonControl1.Categories1"), DevExpress.XtraBars.BarManagerCategory)), (CType(resources.GetObject("ribbonControl1.Categories2"), DevExpress.XtraBars.BarManagerCategory)), (CType(resources.GetObject("ribbonControl1.Categories3"), DevExpress.XtraBars.BarManagerCategory)), (CType(resources.GetObject("ribbonControl1.Categories4"), DevExpress.XtraBars.BarManagerCategory))})
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.rgbiSkins, Me.bbiRotateLayout, Me.bbiFlipLayout, Me.bciShowUnreadMessageCount, Me.bciShowAllMessageCount, Me.bbiDelete, Me.bbiNew, Me.bbiReply, Me.bbiForward, Me.bbiReplyAll, Me.bbiUnreadRead, Me.bbiPriority, Me.bsiNavigation, Me.bbiCloseSearch, Me.bbiShowUnread, Me.bbiImportant, Me.bbiHasAttachment, Me.bbiResetColumnsToDefault, Me.bsiColumns, Me.bbiSubjectColumn, Me.bbiFromColumn, Me.bbiDateColumn, Me.bbiPriorityColumn, Me.bbiAttachmentColumn, Me.bbiDate, Me.bbiClearFilter, Me.bbiNewFeed, Me.bbiEditFeed, Me.bbiDeleteFeed, Me.bbiRefreshFeed, Me.rgbiCurrentView, Me.bsiInfo, Me.beiZoom, Me.bbiNormal, Me.bbiReading, Me.bsiTemp, Me.bbiManageView, Me.bbiSaveCurrentView, Me.rgbiCurrentViewTasks, Me.bbiTodayFlag, Me.bbiTomorrowFlag, Me.bbiThisWeekFlag, Me.bbiNextWeekFlag, Me.bbiNoDateFlag, Me.bbiCustomFlag, Me.bbiNewContact, Me.bbiEditContact, Me.bbiDeleteContact, Me.bbiNewTask, Me.bbiEditTask, Me.bbiDeleteTask, Me.newAppointmentItem1, Me.newRecurringAppointmentItem1, Me.navigateViewBackwardItem1, Me.navigateViewForwardItem1, Me.gotoTodayItem1, Me.viewZoomInItem1, Me.viewZoomOutItem1, Me.switchToDayViewItem1, Me.switchToWorkWeekViewItem1, Me.switchToWeekViewItem1, Me.switchToMonthViewItem1, Me.switchToTimelineViewItem1, Me.groupByNoneItem1, Me.groupByDateItem1, Me.groupByResourceItem1, Me.switchTimeScalesItem1, Me.switchCompressWeekendItem1, Me.switchShowWorkTimeOnlyItem1, Me.editAppointmentQueryItem1, Me.editOccurrenceUICommandItem1, Me.editSeriesUICommandItem1, Me.deleteAppointmentsItem1, Me.deleteOccurrenceItem1, Me.deleteSeriesItem1, Me.splitAppointmentItem1, Me.changeAppointmentStatusItem1, Me.changeAppointmentLabelItem1, Me.toggleRecurrenceItem1, Me.changeAppointmentReminderItem1, Me.bbiShowPreview, Me.bsiConnected, Me.biRename, Me.biCreateFolder, Me.bbiReminder, Me.bbColorMix})
            Me.ribbonControl1.MaxItemId = 101
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.PageCategories.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageCategory() {Me.rpcSearch, Me.calendarToolsRibbonPageCategory1})
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rpMail, Me.rpCalendar, Me.rpContacts, Me.rpFeeds, Me.rpTasks, Me.rpView})
            Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemZoomTrackBar1, Me.repositoryItemSpinEdit1, Me.repositoryItemDuration1})
            Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
            Me.ribbonControl1.StatusBar = Me.ribbonStatusBar1
            Me.ribbonControl1.TransparentEditors = True
            '			Me.ribbonControl1.BeforeApplicationButtonContentControlShow += New System.EventHandler(Me.ribbonControl1_BeforeApplicationButtonContentControlShow)
            '			Me.ribbonControl1.ShowCustomizationMenu += New DevExpress.XtraBars.Ribbon.RibbonCustomizationMenuEventHandler(Me.ribbonControl1_ShowCustomizationMenu)
            ' 
            ' backstageViewControl1
            ' 
            resources.ApplyResources(Me.backstageViewControl1, "backstageViewControl1")
            Me.backstageViewControl1.Appearance.FontSizeDelta = (CType(resources.GetObject("backstageViewControl1.Appearance.FontSizeDelta"), Integer))
            Me.backstageViewControl1.Appearance.FontStyleDelta = (CType(resources.GetObject("backstageViewControl1.Appearance.FontStyleDelta"), System.Drawing.FontStyle))
            Me.backstageViewControl1.Appearance.GradientMode = (CType(resources.GetObject("backstageViewControl1.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.backstageViewControl1.Appearance.Image = (CType(resources.GetObject("backstageViewControl1.Appearance.Image"), System.Drawing.Image))
            Me.backstageViewControl1.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Yellow
            Me.backstageViewControl1.Controls.Add(Me.backstageViewClientControl1)
            Me.backstageViewControl1.Controls.Add(Me.backstageViewClientControl2)
            Me.backstageViewControl1.Controls.Add(Me.backstageViewClientControl3)
            Me.backstageViewControl1.Controls.Add(Me.backstageViewClientControl4)
            Me.backstageViewControl1.Items.Add(Me.bvbiSaveAs)
            Me.backstageViewControl1.Items.Add(Me.bvbiSaveAttachment)
            Me.backstageViewControl1.Items.Add(Me.bvbiSaveCalendar)
            Me.backstageViewControl1.Items.Add(Me.bvtiInfo)
            Me.backstageViewControl1.Items.Add(Me.bvtiOpen)
            Me.backstageViewControl1.Items.Add(Me.bvtiPrint)
            Me.backstageViewControl1.Items.Add(Me.bvtiExport)
            Me.backstageViewControl1.Items.Add(Me.bvbiExit)
            Me.backstageViewControl1.Name = "backstageViewControl1"
            Me.backstageViewControl1.Ribbon = Me.ribbonControl1
            Me.backstageViewControl1.SelectedTab = Me.bvtiInfo
            Me.backstageViewControl1.SelectedTabIndex = 3
            '			Me.backstageViewControl1.ItemClick += New DevExpress.XtraBars.Ribbon.BackstageViewItemEventHandler(Me.backstageViewControl1_ItemClick)
            ' 
            ' backstageViewClientControl1
            ' 
            resources.ApplyResources(Me.backstageViewClientControl1, "backstageViewClientControl1")
            Me.backstageViewClientControl1.Controls.Add(Me.helpControl1)
            Me.backstageViewClientControl1.Name = "backstageViewClientControl1"
            ' 
            ' helpControl1
            ' 
            resources.ApplyResources(Me.helpControl1, "helpControl1")
            Me.helpControl1.ForeColor = System.Drawing.Color.Transparent
            Me.helpControl1.Name = "helpControl1"
            ' 
            ' backstageViewClientControl2
            ' 
            resources.ApplyResources(Me.backstageViewClientControl2, "backstageViewClientControl2")
            Me.backstageViewClientControl2.Controls.Add(Me.galleryControl1)
            Me.backstageViewClientControl2.Name = "backstageViewClientControl2"
            ' 
            ' galleryControl1
            ' 
            resources.ApplyResources(Me.galleryControl1, "galleryControl1")
            Me.galleryControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.galleryControl1.Controls.Add(Me.galleryControlClient1)
            Me.galleryControl1.DesignGalleryGroupIndex = 0
            Me.galleryControl1.DesignGalleryItemIndex = 0
            ' 
            ' 
            ' 
            Me.galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Hovered.FontSizeDelta = (CType(resources.GetObject("galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Hovered.FontSizeDelta"), Integer))
            Me.galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Hovered.FontStyleDelta = (CType(resources.GetObject("galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Hovered.FontStyleDelta"), System.Drawing.FontStyle))
            Me.galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Hovered.GradientMode = (CType(resources.GetObject("galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Hovered.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Hovered.Image = (CType(resources.GetObject("galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Hovered.Image"), System.Drawing.Image))
            Me.galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = True
            Me.galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Normal.FontSizeDelta = (CType(resources.GetObject("galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Normal.FontSizeDelta"), Integer))
            Me.galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Normal.FontStyleDelta = (CType(resources.GetObject("galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Normal.FontStyleDelta"), System.Drawing.FontStyle))
            Me.galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Normal.GradientMode = (CType(resources.GetObject("galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Normal.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Normal.Image = (CType(resources.GetObject("galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Normal.Image"), System.Drawing.Image))
            Me.galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = True
            Me.galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Pressed.FontSizeDelta = (CType(resources.GetObject("galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Pressed.FontSizeDelta"), Integer))
            Me.galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Pressed.FontStyleDelta = (CType(resources.GetObject("galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Pressed.FontStyleDelta"), System.Drawing.FontStyle))
            Me.galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Pressed.GradientMode = (CType(resources.GetObject("galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Pressed.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Pressed.Image = (CType(resources.GetObject("galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Pressed.Image"), System.Drawing.Image))
            Me.galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = True
            Me.galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.galleryControl1.Gallery.AutoFitColumns = False
            Me.galleryControl1.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.None
            Me.galleryControl1.Gallery.BackColor = System.Drawing.Color.Transparent
            Me.galleryControl1.Gallery.ColumnCount = 1
            Me.galleryControl1.Gallery.FixedImageSize = False
            galleryItem1.Image = My.Resources.OpenClendar_64x64
            galleryItem1.Tag = "OpenCalendar"
            galleryItemGroup1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {galleryItem1})
            Me.galleryControl1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {galleryItemGroup1})
            Me.galleryControl1.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.galleryControl1.Gallery.ShowGroupCaption = False
            Me.galleryControl1.Gallery.ShowItemText = True
            Me.galleryControl1.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Hide
            '			Me.galleryControl1.Gallery.ItemClick += New DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(Me.galleryControlGallery1_ItemClick)
            Me.galleryControl1.Name = "galleryControl1"
            ' 
            ' galleryControlClient1
            ' 
            resources.ApplyResources(Me.galleryControlClient1, "galleryControlClient1")
            Me.galleryControlClient1.GalleryControl = Me.galleryControl1
            ' 
            ' backstageViewClientControl3
            ' 
            resources.ApplyResources(Me.backstageViewClientControl3, "backstageViewClientControl3")
            Me.backstageViewClientControl3.Controls.Add(Me.printControl1)
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
            resources.ApplyResources(Me.backstageViewClientControl4, "backstageViewClientControl4")
            Me.backstageViewClientControl4.Controls.Add(Me.exportControl1)
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
            Me.bvbiSaveAs.Appearance.FontSizeDelta = (CType(resources.GetObject("bvbiSaveAs.Appearance.FontSizeDelta"), Integer))
            Me.bvbiSaveAs.Appearance.FontStyleDelta = (CType(resources.GetObject("bvbiSaveAs.Appearance.FontStyleDelta"), System.Drawing.FontStyle))
            Me.bvbiSaveAs.Appearance.GradientMode = (CType(resources.GetObject("bvbiSaveAs.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.bvbiSaveAs.Appearance.Image = (CType(resources.GetObject("bvbiSaveAs.Appearance.Image"), System.Drawing.Image))
            Me.bvbiSaveAs.AppearanceDisabled.FontSizeDelta = (CType(resources.GetObject("bvbiSaveAs.AppearanceDisabled.FontSizeDelta"), Integer))
            Me.bvbiSaveAs.AppearanceDisabled.FontStyleDelta = (CType(resources.GetObject("bvbiSaveAs.AppearanceDisabled.FontStyleDelta"), System.Drawing.FontStyle))
            Me.bvbiSaveAs.AppearanceDisabled.GradientMode = (CType(resources.GetObject("bvbiSaveAs.AppearanceDisabled.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.bvbiSaveAs.AppearanceDisabled.Image = (CType(resources.GetObject("bvbiSaveAs.AppearanceDisabled.Image"), System.Drawing.Image))
            Me.bvbiSaveAs.AppearanceHover.FontSizeDelta = (CType(resources.GetObject("bvbiSaveAs.AppearanceHover.FontSizeDelta"), Integer))
            Me.bvbiSaveAs.AppearanceHover.FontStyleDelta = (CType(resources.GetObject("bvbiSaveAs.AppearanceHover.FontStyleDelta"), System.Drawing.FontStyle))
            Me.bvbiSaveAs.AppearanceHover.GradientMode = (CType(resources.GetObject("bvbiSaveAs.AppearanceHover.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.bvbiSaveAs.AppearanceHover.Image = (CType(resources.GetObject("bvbiSaveAs.AppearanceHover.Image"), System.Drawing.Image))
            Me.bvbiSaveAs.AppearancePressed.FontSizeDelta = (CType(resources.GetObject("bvbiSaveAs.AppearancePressed.FontSizeDelta"), Integer))
            Me.bvbiSaveAs.AppearancePressed.FontStyleDelta = (CType(resources.GetObject("bvbiSaveAs.AppearancePressed.FontStyleDelta"), System.Drawing.FontStyle))
            Me.bvbiSaveAs.AppearancePressed.GradientMode = (CType(resources.GetObject("bvbiSaveAs.AppearancePressed.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.bvbiSaveAs.AppearancePressed.Image = (CType(resources.GetObject("bvbiSaveAs.AppearancePressed.Image"), System.Drawing.Image))
            resources.ApplyResources(Me.bvbiSaveAs, "bvbiSaveAs")
            Me.bvbiSaveAs.Name = "bvbiSaveAs"
            ' 
            ' bvbiSaveAttachment
            ' 
            Me.bvbiSaveAttachment.Appearance.FontSizeDelta = (CType(resources.GetObject("bvbiSaveAttachment.Appearance.FontSizeDelta"), Integer))
            Me.bvbiSaveAttachment.Appearance.FontStyleDelta = (CType(resources.GetObject("bvbiSaveAttachment.Appearance.FontStyleDelta"), System.Drawing.FontStyle))
            Me.bvbiSaveAttachment.Appearance.GradientMode = (CType(resources.GetObject("bvbiSaveAttachment.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.bvbiSaveAttachment.Appearance.Image = (CType(resources.GetObject("bvbiSaveAttachment.Appearance.Image"), System.Drawing.Image))
            Me.bvbiSaveAttachment.AppearanceDisabled.FontSizeDelta = (CType(resources.GetObject("bvbiSaveAttachment.AppearanceDisabled.FontSizeDelta"), Integer))
            Me.bvbiSaveAttachment.AppearanceDisabled.FontStyleDelta = (CType(resources.GetObject("bvbiSaveAttachment.AppearanceDisabled.FontStyleDelta"), System.Drawing.FontStyle))
            Me.bvbiSaveAttachment.AppearanceDisabled.GradientMode = (CType(resources.GetObject("bvbiSaveAttachment.AppearanceDisabled.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.bvbiSaveAttachment.AppearanceDisabled.Image = (CType(resources.GetObject("bvbiSaveAttachment.AppearanceDisabled.Image"), System.Drawing.Image))
            Me.bvbiSaveAttachment.AppearanceHover.FontSizeDelta = (CType(resources.GetObject("bvbiSaveAttachment.AppearanceHover.FontSizeDelta"), Integer))
            Me.bvbiSaveAttachment.AppearanceHover.FontStyleDelta = (CType(resources.GetObject("bvbiSaveAttachment.AppearanceHover.FontStyleDelta"), System.Drawing.FontStyle))
            Me.bvbiSaveAttachment.AppearanceHover.GradientMode = (CType(resources.GetObject("bvbiSaveAttachment.AppearanceHover.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.bvbiSaveAttachment.AppearanceHover.Image = (CType(resources.GetObject("bvbiSaveAttachment.AppearanceHover.Image"), System.Drawing.Image))
            Me.bvbiSaveAttachment.AppearancePressed.FontSizeDelta = (CType(resources.GetObject("bvbiSaveAttachment.AppearancePressed.FontSizeDelta"), Integer))
            Me.bvbiSaveAttachment.AppearancePressed.FontStyleDelta = (CType(resources.GetObject("bvbiSaveAttachment.AppearancePressed.FontStyleDelta"), System.Drawing.FontStyle))
            Me.bvbiSaveAttachment.AppearancePressed.GradientMode = (CType(resources.GetObject("bvbiSaveAttachment.AppearancePressed.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.bvbiSaveAttachment.AppearancePressed.Image = (CType(resources.GetObject("bvbiSaveAttachment.AppearancePressed.Image"), System.Drawing.Image))
            resources.ApplyResources(Me.bvbiSaveAttachment, "bvbiSaveAttachment")
            Me.bvbiSaveAttachment.Name = "bvbiSaveAttachment"
            ' 
            ' bvbiSaveCalendar
            ' 
            Me.bvbiSaveCalendar.Appearance.FontSizeDelta = (CType(resources.GetObject("bvbiSaveCalendar.Appearance.FontSizeDelta"), Integer))
            Me.bvbiSaveCalendar.Appearance.FontStyleDelta = (CType(resources.GetObject("bvbiSaveCalendar.Appearance.FontStyleDelta"), System.Drawing.FontStyle))
            Me.bvbiSaveCalendar.Appearance.GradientMode = (CType(resources.GetObject("bvbiSaveCalendar.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.bvbiSaveCalendar.Appearance.Image = (CType(resources.GetObject("bvbiSaveCalendar.Appearance.Image"), System.Drawing.Image))
            Me.bvbiSaveCalendar.AppearanceDisabled.FontSizeDelta = (CType(resources.GetObject("bvbiSaveCalendar.AppearanceDisabled.FontSizeDelta"), Integer))
            Me.bvbiSaveCalendar.AppearanceDisabled.FontStyleDelta = (CType(resources.GetObject("bvbiSaveCalendar.AppearanceDisabled.FontStyleDelta"), System.Drawing.FontStyle))
            Me.bvbiSaveCalendar.AppearanceDisabled.GradientMode = (CType(resources.GetObject("bvbiSaveCalendar.AppearanceDisabled.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.bvbiSaveCalendar.AppearanceDisabled.Image = (CType(resources.GetObject("bvbiSaveCalendar.AppearanceDisabled.Image"), System.Drawing.Image))
            Me.bvbiSaveCalendar.AppearanceHover.FontSizeDelta = (CType(resources.GetObject("bvbiSaveCalendar.AppearanceHover.FontSizeDelta"), Integer))
            Me.bvbiSaveCalendar.AppearanceHover.FontStyleDelta = (CType(resources.GetObject("bvbiSaveCalendar.AppearanceHover.FontStyleDelta"), System.Drawing.FontStyle))
            Me.bvbiSaveCalendar.AppearanceHover.GradientMode = (CType(resources.GetObject("bvbiSaveCalendar.AppearanceHover.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.bvbiSaveCalendar.AppearanceHover.Image = (CType(resources.GetObject("bvbiSaveCalendar.AppearanceHover.Image"), System.Drawing.Image))
            Me.bvbiSaveCalendar.AppearancePressed.FontSizeDelta = (CType(resources.GetObject("bvbiSaveCalendar.AppearancePressed.FontSizeDelta"), Integer))
            Me.bvbiSaveCalendar.AppearancePressed.FontStyleDelta = (CType(resources.GetObject("bvbiSaveCalendar.AppearancePressed.FontStyleDelta"), System.Drawing.FontStyle))
            Me.bvbiSaveCalendar.AppearancePressed.GradientMode = (CType(resources.GetObject("bvbiSaveCalendar.AppearancePressed.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.bvbiSaveCalendar.AppearancePressed.Image = (CType(resources.GetObject("bvbiSaveCalendar.AppearancePressed.Image"), System.Drawing.Image))
            resources.ApplyResources(Me.bvbiSaveCalendar, "bvbiSaveCalendar")
            Me.bvbiSaveCalendar.Name = "bvbiSaveCalendar"
            ' 
            ' bvtiInfo
            ' 
            Me.bvtiInfo.Appearance.FontSizeDelta = (CType(resources.GetObject("bvtiInfo.Appearance.FontSizeDelta"), Integer))
            Me.bvtiInfo.Appearance.FontStyleDelta = (CType(resources.GetObject("bvtiInfo.Appearance.FontStyleDelta"), System.Drawing.FontStyle))
            Me.bvtiInfo.Appearance.GradientMode = (CType(resources.GetObject("bvtiInfo.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.bvtiInfo.Appearance.Image = (CType(resources.GetObject("bvtiInfo.Appearance.Image"), System.Drawing.Image))
            Me.bvtiInfo.AppearanceDisabled.FontSizeDelta = (CType(resources.GetObject("bvtiInfo.AppearanceDisabled.FontSizeDelta"), Integer))
            Me.bvtiInfo.AppearanceDisabled.FontStyleDelta = (CType(resources.GetObject("bvtiInfo.AppearanceDisabled.FontStyleDelta"), System.Drawing.FontStyle))
            Me.bvtiInfo.AppearanceDisabled.GradientMode = (CType(resources.GetObject("bvtiInfo.AppearanceDisabled.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.bvtiInfo.AppearanceDisabled.Image = (CType(resources.GetObject("bvtiInfo.AppearanceDisabled.Image"), System.Drawing.Image))
            Me.bvtiInfo.AppearanceHover.FontSizeDelta = (CType(resources.GetObject("bvtiInfo.AppearanceHover.FontSizeDelta"), Integer))
            Me.bvtiInfo.AppearanceHover.FontStyleDelta = (CType(resources.GetObject("bvtiInfo.AppearanceHover.FontStyleDelta"), System.Drawing.FontStyle))
            Me.bvtiInfo.AppearanceHover.GradientMode = (CType(resources.GetObject("bvtiInfo.AppearanceHover.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.bvtiInfo.AppearanceHover.Image = (CType(resources.GetObject("bvtiInfo.AppearanceHover.Image"), System.Drawing.Image))
            Me.bvtiInfo.AppearanceSelected.FontSizeDelta = (CType(resources.GetObject("bvtiInfo.AppearanceSelected.FontSizeDelta"), Integer))
            Me.bvtiInfo.AppearanceSelected.FontStyleDelta = (CType(resources.GetObject("bvtiInfo.AppearanceSelected.FontStyleDelta"), System.Drawing.FontStyle))
            Me.bvtiInfo.AppearanceSelected.GradientMode = (CType(resources.GetObject("bvtiInfo.AppearanceSelected.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.bvtiInfo.AppearanceSelected.Image = (CType(resources.GetObject("bvtiInfo.AppearanceSelected.Image"), System.Drawing.Image))
            resources.ApplyResources(Me.bvtiInfo, "bvtiInfo")
            Me.bvtiInfo.ContentControl = Me.backstageViewClientControl1
            Me.bvtiInfo.Name = "bvtiInfo"
            Me.bvtiInfo.Selected = True
            ' 
            ' bvtiOpen
            ' 
            Me.bvtiOpen.Appearance.FontSizeDelta = (CType(resources.GetObject("bvtiOpen.Appearance.FontSizeDelta"), Integer))
            Me.bvtiOpen.Appearance.FontStyleDelta = (CType(resources.GetObject("bvtiOpen.Appearance.FontStyleDelta"), System.Drawing.FontStyle))
            Me.bvtiOpen.Appearance.GradientMode = (CType(resources.GetObject("bvtiOpen.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.bvtiOpen.Appearance.Image = (CType(resources.GetObject("bvtiOpen.Appearance.Image"), System.Drawing.Image))
            Me.bvtiOpen.AppearanceDisabled.FontSizeDelta = (CType(resources.GetObject("bvtiOpen.AppearanceDisabled.FontSizeDelta"), Integer))
            Me.bvtiOpen.AppearanceDisabled.FontStyleDelta = (CType(resources.GetObject("bvtiOpen.AppearanceDisabled.FontStyleDelta"), System.Drawing.FontStyle))
            Me.bvtiOpen.AppearanceDisabled.GradientMode = (CType(resources.GetObject("bvtiOpen.AppearanceDisabled.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.bvtiOpen.AppearanceDisabled.Image = (CType(resources.GetObject("bvtiOpen.AppearanceDisabled.Image"), System.Drawing.Image))
            Me.bvtiOpen.AppearanceHover.FontSizeDelta = (CType(resources.GetObject("bvtiOpen.AppearanceHover.FontSizeDelta"), Integer))
            Me.bvtiOpen.AppearanceHover.FontStyleDelta = (CType(resources.GetObject("bvtiOpen.AppearanceHover.FontStyleDelta"), System.Drawing.FontStyle))
            Me.bvtiOpen.AppearanceHover.GradientMode = (CType(resources.GetObject("bvtiOpen.AppearanceHover.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.bvtiOpen.AppearanceHover.Image = (CType(resources.GetObject("bvtiOpen.AppearanceHover.Image"), System.Drawing.Image))
            Me.bvtiOpen.AppearanceSelected.FontSizeDelta = (CType(resources.GetObject("bvtiOpen.AppearanceSelected.FontSizeDelta"), Integer))
            Me.bvtiOpen.AppearanceSelected.FontStyleDelta = (CType(resources.GetObject("bvtiOpen.AppearanceSelected.FontStyleDelta"), System.Drawing.FontStyle))
            Me.bvtiOpen.AppearanceSelected.GradientMode = (CType(resources.GetObject("bvtiOpen.AppearanceSelected.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.bvtiOpen.AppearanceSelected.Image = (CType(resources.GetObject("bvtiOpen.AppearanceSelected.Image"), System.Drawing.Image))
            resources.ApplyResources(Me.bvtiOpen, "bvtiOpen")
            Me.bvtiOpen.ContentControl = Me.backstageViewClientControl2
            Me.bvtiOpen.Name = "bvtiOpen"
            Me.bvtiOpen.Selected = False
            ' 
            ' bvtiPrint
            ' 
            Me.bvtiPrint.Appearance.FontSizeDelta = (CType(resources.GetObject("bvtiPrint.Appearance.FontSizeDelta"), Integer))
            Me.bvtiPrint.Appearance.FontStyleDelta = (CType(resources.GetObject("bvtiPrint.Appearance.FontStyleDelta"), System.Drawing.FontStyle))
            Me.bvtiPrint.Appearance.GradientMode = (CType(resources.GetObject("bvtiPrint.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.bvtiPrint.Appearance.Image = (CType(resources.GetObject("bvtiPrint.Appearance.Image"), System.Drawing.Image))
            Me.bvtiPrint.AppearanceDisabled.FontSizeDelta = (CType(resources.GetObject("bvtiPrint.AppearanceDisabled.FontSizeDelta"), Integer))
            Me.bvtiPrint.AppearanceDisabled.FontStyleDelta = (CType(resources.GetObject("bvtiPrint.AppearanceDisabled.FontStyleDelta"), System.Drawing.FontStyle))
            Me.bvtiPrint.AppearanceDisabled.GradientMode = (CType(resources.GetObject("bvtiPrint.AppearanceDisabled.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.bvtiPrint.AppearanceDisabled.Image = (CType(resources.GetObject("bvtiPrint.AppearanceDisabled.Image"), System.Drawing.Image))
            Me.bvtiPrint.AppearanceHover.FontSizeDelta = (CType(resources.GetObject("bvtiPrint.AppearanceHover.FontSizeDelta"), Integer))
            Me.bvtiPrint.AppearanceHover.FontStyleDelta = (CType(resources.GetObject("bvtiPrint.AppearanceHover.FontStyleDelta"), System.Drawing.FontStyle))
            Me.bvtiPrint.AppearanceHover.GradientMode = (CType(resources.GetObject("bvtiPrint.AppearanceHover.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.bvtiPrint.AppearanceHover.Image = (CType(resources.GetObject("bvtiPrint.AppearanceHover.Image"), System.Drawing.Image))
            Me.bvtiPrint.AppearanceSelected.FontSizeDelta = (CType(resources.GetObject("bvtiPrint.AppearanceSelected.FontSizeDelta"), Integer))
            Me.bvtiPrint.AppearanceSelected.FontStyleDelta = (CType(resources.GetObject("bvtiPrint.AppearanceSelected.FontStyleDelta"), System.Drawing.FontStyle))
            Me.bvtiPrint.AppearanceSelected.GradientMode = (CType(resources.GetObject("bvtiPrint.AppearanceSelected.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.bvtiPrint.AppearanceSelected.Image = (CType(resources.GetObject("bvtiPrint.AppearanceSelected.Image"), System.Drawing.Image))
            resources.ApplyResources(Me.bvtiPrint, "bvtiPrint")
            Me.bvtiPrint.ContentControl = Me.backstageViewClientControl3
            Me.bvtiPrint.Name = "bvtiPrint"
            Me.bvtiPrint.Selected = False
            '			Me.bvtiPrint.SelectedChanged += New DevExpress.XtraBars.Ribbon.BackstageViewItemEventHandler(Me.bvtiPrint_SelectedChanged)
            ' 
            ' bvtiExport
            ' 
            Me.bvtiExport.Appearance.FontSizeDelta = (CType(resources.GetObject("bvtiExport.Appearance.FontSizeDelta"), Integer))
            Me.bvtiExport.Appearance.FontStyleDelta = (CType(resources.GetObject("bvtiExport.Appearance.FontStyleDelta"), System.Drawing.FontStyle))
            Me.bvtiExport.Appearance.GradientMode = (CType(resources.GetObject("bvtiExport.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.bvtiExport.Appearance.Image = (CType(resources.GetObject("bvtiExport.Appearance.Image"), System.Drawing.Image))
            Me.bvtiExport.AppearanceDisabled.FontSizeDelta = (CType(resources.GetObject("bvtiExport.AppearanceDisabled.FontSizeDelta"), Integer))
            Me.bvtiExport.AppearanceDisabled.FontStyleDelta = (CType(resources.GetObject("bvtiExport.AppearanceDisabled.FontStyleDelta"), System.Drawing.FontStyle))
            Me.bvtiExport.AppearanceDisabled.GradientMode = (CType(resources.GetObject("bvtiExport.AppearanceDisabled.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.bvtiExport.AppearanceDisabled.Image = (CType(resources.GetObject("bvtiExport.AppearanceDisabled.Image"), System.Drawing.Image))
            Me.bvtiExport.AppearanceHover.FontSizeDelta = (CType(resources.GetObject("bvtiExport.AppearanceHover.FontSizeDelta"), Integer))
            Me.bvtiExport.AppearanceHover.FontStyleDelta = (CType(resources.GetObject("bvtiExport.AppearanceHover.FontStyleDelta"), System.Drawing.FontStyle))
            Me.bvtiExport.AppearanceHover.GradientMode = (CType(resources.GetObject("bvtiExport.AppearanceHover.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.bvtiExport.AppearanceHover.Image = (CType(resources.GetObject("bvtiExport.AppearanceHover.Image"), System.Drawing.Image))
            Me.bvtiExport.AppearanceSelected.FontSizeDelta = (CType(resources.GetObject("bvtiExport.AppearanceSelected.FontSizeDelta"), Integer))
            Me.bvtiExport.AppearanceSelected.FontStyleDelta = (CType(resources.GetObject("bvtiExport.AppearanceSelected.FontStyleDelta"), System.Drawing.FontStyle))
            Me.bvtiExport.AppearanceSelected.GradientMode = (CType(resources.GetObject("bvtiExport.AppearanceSelected.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.bvtiExport.AppearanceSelected.Image = (CType(resources.GetObject("bvtiExport.AppearanceSelected.Image"), System.Drawing.Image))
            resources.ApplyResources(Me.bvtiExport, "bvtiExport")
            Me.bvtiExport.ContentControl = Me.backstageViewClientControl4
            Me.bvtiExport.Name = "bvtiExport"
            Me.bvtiExport.Selected = False
            ' 
            ' bvbiExit
            ' 
            Me.bvbiExit.Appearance.FontSizeDelta = (CType(resources.GetObject("bvbiExit.Appearance.FontSizeDelta"), Integer))
            Me.bvbiExit.Appearance.FontStyleDelta = (CType(resources.GetObject("bvbiExit.Appearance.FontStyleDelta"), System.Drawing.FontStyle))
            Me.bvbiExit.Appearance.GradientMode = (CType(resources.GetObject("bvbiExit.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.bvbiExit.Appearance.Image = (CType(resources.GetObject("bvbiExit.Appearance.Image"), System.Drawing.Image))
            Me.bvbiExit.AppearanceDisabled.FontSizeDelta = (CType(resources.GetObject("bvbiExit.AppearanceDisabled.FontSizeDelta"), Integer))
            Me.bvbiExit.AppearanceDisabled.FontStyleDelta = (CType(resources.GetObject("bvbiExit.AppearanceDisabled.FontStyleDelta"), System.Drawing.FontStyle))
            Me.bvbiExit.AppearanceDisabled.GradientMode = (CType(resources.GetObject("bvbiExit.AppearanceDisabled.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.bvbiExit.AppearanceDisabled.Image = (CType(resources.GetObject("bvbiExit.AppearanceDisabled.Image"), System.Drawing.Image))
            Me.bvbiExit.AppearanceHover.FontSizeDelta = (CType(resources.GetObject("bvbiExit.AppearanceHover.FontSizeDelta"), Integer))
            Me.bvbiExit.AppearanceHover.FontStyleDelta = (CType(resources.GetObject("bvbiExit.AppearanceHover.FontStyleDelta"), System.Drawing.FontStyle))
            Me.bvbiExit.AppearanceHover.GradientMode = (CType(resources.GetObject("bvbiExit.AppearanceHover.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.bvbiExit.AppearanceHover.Image = (CType(resources.GetObject("bvbiExit.AppearanceHover.Image"), System.Drawing.Image))
            Me.bvbiExit.AppearancePressed.FontSizeDelta = (CType(resources.GetObject("bvbiExit.AppearancePressed.FontSizeDelta"), Integer))
            Me.bvbiExit.AppearancePressed.FontStyleDelta = (CType(resources.GetObject("bvbiExit.AppearancePressed.FontStyleDelta"), System.Drawing.FontStyle))
            Me.bvbiExit.AppearancePressed.GradientMode = (CType(resources.GetObject("bvbiExit.AppearancePressed.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.bvbiExit.AppearancePressed.Image = (CType(resources.GetObject("bvbiExit.AppearancePressed.Image"), System.Drawing.Image))
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
            ' bbiRotateLayout
            ' 
            resources.ApplyResources(Me.bbiRotateLayout, "bbiRotateLayout")
            Me.bbiRotateLayout.Glyph = My.Resources.LayoutRotate_16x16
            Me.bbiRotateLayout.Id = 2
            Me.bbiRotateLayout.LargeGlyph = My.Resources.LayoutRotate_32x32
            Me.bbiRotateLayout.Name = "bbiRotateLayout"
            ' 
            ' bbiFlipLayout
            ' 
            resources.ApplyResources(Me.bbiFlipLayout, "bbiFlipLayout")
            Me.bbiFlipLayout.Glyph = My.Resources.LayoutFlip_16x16
            Me.bbiFlipLayout.Id = 3
            Me.bbiFlipLayout.LargeGlyph = My.Resources.LayoutFlip_32x32
            Me.bbiFlipLayout.Name = "bbiFlipLayout"
            ' 
            ' bciShowUnreadMessageCount
            ' 
            resources.ApplyResources(Me.bciShowUnreadMessageCount, "bciShowUnreadMessageCount")
            Me.bciShowUnreadMessageCount.CloseSubMenuOnClick = False
            Me.bciShowUnreadMessageCount.Id = 4
            Me.bciShowUnreadMessageCount.Name = "bciShowUnreadMessageCount"
            '			Me.bciShowUnreadMessageCount.CheckedChanged += New DevExpress.XtraBars.ItemClickEventHandler(Me.bciShowUnreadMessageCount_CheckedChanged)
            ' 
            ' bciShowAllMessageCount
            ' 
            resources.ApplyResources(Me.bciShowAllMessageCount, "bciShowAllMessageCount")
            Me.bciShowAllMessageCount.CloseSubMenuOnClick = False
            Me.bciShowAllMessageCount.Id = 5
            Me.bciShowAllMessageCount.Name = "bciShowAllMessageCount"
            '			Me.bciShowAllMessageCount.CheckedChanged += New DevExpress.XtraBars.ItemClickEventHandler(Me.bciShowAllMessageCount_CheckedChanged)
            ' 
            ' bbiDelete
            ' 
            resources.ApplyResources(Me.bbiDelete, "bbiDelete")
            Me.bbiDelete.Glyph = My.Resources.Delete_16x16
            Me.bbiDelete.Id = 6
            Me.bbiDelete.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D))
            Me.bbiDelete.LargeGlyph = My.Resources.Delete_32x32
            Me.bbiDelete.Name = "bbiDelete"
            ' 
            ' bbiNew
            ' 
            resources.ApplyResources(Me.bbiNew, "bbiNew")
            Me.bbiNew.Glyph = My.Resources.NewMail_16x16
            Me.bbiNew.Id = 7
            Me.bbiNew.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N))
            Me.bbiNew.LargeGlyph = My.Resources.NewMail_32x32
            Me.bbiNew.Name = "bbiNew"
            ' 
            ' bbiReply
            ' 
            resources.ApplyResources(Me.bbiReply, "bbiReply")
            Me.bbiReply.Glyph = My.Resources.Reply
            Me.bbiReply.Id = 8
            Me.bbiReply.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R))
            Me.bbiReply.Name = "bbiReply"
            ' 
            ' bbiForward
            ' 
            resources.ApplyResources(Me.bbiForward, "bbiForward")
            Me.bbiForward.Glyph = My.Resources.Forward
            Me.bbiForward.Id = 9
            Me.bbiForward.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F))
            Me.bbiForward.Name = "bbiForward"
            ' 
            ' bbiReplyAll
            ' 
            resources.ApplyResources(Me.bbiReplyAll, "bbiReplyAll")
            Me.bbiReplyAll.Glyph = My.Resources.ReplyAll
            Me.bbiReplyAll.Id = 10
            Me.bbiReplyAll.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) Or System.Windows.Forms.Keys.R))
            Me.bbiReplyAll.Name = "bbiReplyAll"
            ' 
            ' bbiUnreadRead
            ' 
            resources.ApplyResources(Me.bbiUnreadRead, "bbiUnreadRead")
            Me.bbiUnreadRead.Glyph = My.Resources.Mail_16x16
            Me.bbiUnreadRead.Id = 12
            Me.bbiUnreadRead.Name = "bbiUnreadRead"
            ' 
            ' bbiPriority
            ' 
            resources.ApplyResources(Me.bbiPriority, "bbiPriority")
            Me.bbiPriority.ActAsDropDown = True
            Me.bbiPriority.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.bbiPriority.Glyph = My.Resources.Priority_16x16
            Me.bbiPriority.Id = 15
            Me.bbiPriority.Name = "bbiPriority"
            ' 
            ' bsiNavigation
            ' 
            resources.ApplyResources(Me.bsiNavigation, "bsiNavigation")
            Me.bsiNavigation.Glyph = My.Resources.NavigationBar_16x16
            Me.bsiNavigation.Id = 16
            Me.bsiNavigation.LargeGlyph = My.Resources.NavigationBar_32x32
            Me.bsiNavigation.MenuAppearance.HeaderItemAppearance.FontSizeDelta = (CType(resources.GetObject("bsiNavigation.MenuAppearance.HeaderItemAppearance.FontSizeDelta"), Integer))
            Me.bsiNavigation.MenuAppearance.HeaderItemAppearance.FontStyleDelta = (CType(resources.GetObject("bsiNavigation.MenuAppearance.HeaderItemAppearance.FontStyleDelta"), System.Drawing.FontStyle))
            Me.bsiNavigation.MenuAppearance.HeaderItemAppearance.GradientMode = (CType(resources.GetObject("bsiNavigation.MenuAppearance.HeaderItemAppearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.bsiNavigation.MenuAppearance.HeaderItemAppearance.Image = (CType(resources.GetObject("bsiNavigation.MenuAppearance.HeaderItemAppearance.Image"), System.Drawing.Image))
            Me.bsiNavigation.Name = "bsiNavigation"
            ' 
            ' bbiCloseSearch
            ' 
            resources.ApplyResources(Me.bbiCloseSearch, "bbiCloseSearch")
            Me.bbiCloseSearch.Glyph = My.Resources.Close_16x16
            Me.bbiCloseSearch.Id = 17
            Me.bbiCloseSearch.LargeGlyph = My.Resources.Close_32x32
            Me.bbiCloseSearch.Name = "bbiCloseSearch"
            ' 
            ' bbiShowUnread
            ' 
            resources.ApplyResources(Me.bbiShowUnread, "bbiShowUnread")
            Me.bbiShowUnread.Glyph = My.Resources.Mail_16x16
            Me.bbiShowUnread.Id = 18
            Me.bbiShowUnread.LargeGlyph = My.Resources.Mail_32x32
            Me.bbiShowUnread.Name = "bbiShowUnread"
            ' 
            ' bbiImportant
            ' 
            resources.ApplyResources(Me.bbiImportant, "bbiImportant")
            Me.bbiImportant.Glyph = My.Resources.Important_16x16
            Me.bbiImportant.Id = 19
            Me.bbiImportant.Name = "bbiImportant"
            ' 
            ' bbiHasAttachment
            ' 
            resources.ApplyResources(Me.bbiHasAttachment, "bbiHasAttachment")
            Me.bbiHasAttachment.Glyph = My.Resources.AttachmentObject_16x16
            Me.bbiHasAttachment.Id = 20
            Me.bbiHasAttachment.Name = "bbiHasAttachment"
            ' 
            ' bbiResetColumnsToDefault
            ' 
            resources.ApplyResources(Me.bbiResetColumnsToDefault, "bbiResetColumnsToDefault")
            Me.bbiResetColumnsToDefault.Glyph = My.Resources.ResetToDefault_16x16
            Me.bbiResetColumnsToDefault.Id = 23
            Me.bbiResetColumnsToDefault.Name = "bbiResetColumnsToDefault"
            ' 
            ' bsiColumns
            ' 
            resources.ApplyResources(Me.bsiColumns, "bsiColumns")
            Me.bsiColumns.Id = 24
            Me.bsiColumns.MenuAppearance.HeaderItemAppearance.FontSizeDelta = (CType(resources.GetObject("bsiColumns.MenuAppearance.HeaderItemAppearance.FontSizeDelta"), Integer))
            Me.bsiColumns.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiSubjectColumn),
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiFromColumn),
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiDateColumn),
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiPriorityColumn),
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAttachmentColumn)
            })
            Me.bsiColumns.MenuAppearance.HeaderItemAppearance.FontStyleDelta = (CType(resources.GetObject("bsiColumns.MenuAppearance.HeaderItemAppearance.FontStyleDelta"), System.Drawing.FontStyle))
            Me.bsiColumns.MenuAppearance.HeaderItemAppearance.GradientMode = (CType(resources.GetObject("bsiColumns.MenuAppearance.HeaderItemAppearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.bsiColumns.MenuAppearance.HeaderItemAppearance.Image = (CType(resources.GetObject("bsiColumns.MenuAppearance.HeaderItemAppearance.Image"), System.Drawing.Image))
            Me.bsiColumns.Name = "bsiColumns"
            ' 
            ' bbiSubjectColumn
            ' 
            resources.ApplyResources(Me.bbiSubjectColumn, "bbiSubjectColumn")
            Me.bbiSubjectColumn.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.bbiSubjectColumn.CloseSubMenuOnClick = False
            Me.bbiSubjectColumn.Id = 25
            Me.bbiSubjectColumn.Name = "bbiSubjectColumn"
            ' 
            ' bbiFromColumn
            ' 
            resources.ApplyResources(Me.bbiFromColumn, "bbiFromColumn")
            Me.bbiFromColumn.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.bbiFromColumn.CloseSubMenuOnClick = False
            Me.bbiFromColumn.Id = 26
            Me.bbiFromColumn.Name = "bbiFromColumn"
            ' 
            ' bbiDateColumn
            ' 
            resources.ApplyResources(Me.bbiDateColumn, "bbiDateColumn")
            Me.bbiDateColumn.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.bbiDateColumn.CloseSubMenuOnClick = False
            Me.bbiDateColumn.Id = 27
            Me.bbiDateColumn.Name = "bbiDateColumn"
            ' 
            ' bbiPriorityColumn
            ' 
            resources.ApplyResources(Me.bbiPriorityColumn, "bbiPriorityColumn")
            Me.bbiPriorityColumn.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.bbiPriorityColumn.CloseSubMenuOnClick = False
            Me.bbiPriorityColumn.Id = 28
            Me.bbiPriorityColumn.Name = "bbiPriorityColumn"
            ' 
            ' bbiAttachmentColumn
            ' 
            resources.ApplyResources(Me.bbiAttachmentColumn, "bbiAttachmentColumn")
            Me.bbiAttachmentColumn.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.bbiAttachmentColumn.CloseSubMenuOnClick = False
            Me.bbiAttachmentColumn.Id = 29
            Me.bbiAttachmentColumn.Name = "bbiAttachmentColumn"
            ' 
            ' bbiDate
            ' 
            resources.ApplyResources(Me.bbiDate, "bbiDate")
            Me.bbiDate.ActAsDropDown = True
            Me.bbiDate.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.bbiDate.Glyph = My.Resources.Today_16x16
            Me.bbiDate.Id = 30
            Me.bbiDate.LargeGlyph = My.Resources.Today_32x32
            Me.bbiDate.Name = "bbiDate"
            ' 
            ' bbiClearFilter
            ' 
            resources.ApplyResources(Me.bbiClearFilter, "bbiClearFilter")
            Me.bbiClearFilter.Glyph = My.Resources.Delete_16x16
            Me.bbiClearFilter.Id = 31
            Me.bbiClearFilter.LargeGlyph = My.Resources.Delete_32x32
            Me.bbiClearFilter.Name = "bbiClearFilter"
            ' 
            ' bbiNewFeed
            ' 
            resources.ApplyResources(Me.bbiNewFeed, "bbiNewFeed")
            Me.bbiNewFeed.Glyph = My.Resources.NewFeed_16x16
            Me.bbiNewFeed.Id = 32
            Me.bbiNewFeed.LargeGlyph = My.Resources.NewFeed_32x32
            Me.bbiNewFeed.Name = "bbiNewFeed"
            ' 
            ' bbiEditFeed
            ' 
            resources.ApplyResources(Me.bbiEditFeed, "bbiEditFeed")
            Me.bbiEditFeed.Glyph = My.Resources.EditFeed_16x16
            Me.bbiEditFeed.Id = 33
            Me.bbiEditFeed.LargeGlyph = My.Resources.EditFeed_32x32
            Me.bbiEditFeed.Name = "bbiEditFeed"
            ' 
            ' bbiDeleteFeed
            ' 
            resources.ApplyResources(Me.bbiDeleteFeed, "bbiDeleteFeed")
            Me.bbiDeleteFeed.Glyph = My.Resources.Delete_16x16
            Me.bbiDeleteFeed.Id = 34
            Me.bbiDeleteFeed.LargeGlyph = My.Resources.Delete_32x32
            Me.bbiDeleteFeed.Name = "bbiDeleteFeed"
            ' 
            ' bbiRefreshFeed
            ' 
            resources.ApplyResources(Me.bbiRefreshFeed, "bbiRefreshFeed")
            Me.bbiRefreshFeed.Glyph = My.Resources.Refresh_16x16
            Me.bbiRefreshFeed.Id = 35
            Me.bbiRefreshFeed.LargeGlyph = My.Resources.Refresh_32x32
            Me.bbiRefreshFeed.Name = "bbiRefreshFeed"
            ' 
            ' rgbiCurrentView
            ' 
            resources.ApplyResources(Me.rgbiCurrentView, "rgbiCurrentView")
            ' 
            ' 
            ' 
            Me.rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Hovered.FontSizeDelta = (CType(resources.GetObject("rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Hovered.FontSizeDelta"), Integer))
            Me.rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Hovered.FontStyleDelta = (CType(resources.GetObject("rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Hovered.FontStyleDelta"), System.Drawing.FontStyle))
            Me.rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Hovered.GradientMode = (CType(resources.GetObject("rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Hovered.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Hovered.Image = (CType(resources.GetObject("rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Hovered.Image"), System.Drawing.Image))
            Me.rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseFont = True
            Me.rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = True
            Me.rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Normal.FontSizeDelta = (CType(resources.GetObject("rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Normal.FontSizeDelta"), Integer))
            Me.rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Normal.FontStyleDelta = (CType(resources.GetObject("rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Normal.FontStyleDelta"), System.Drawing.FontStyle))
            Me.rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Normal.GradientMode = (CType(resources.GetObject("rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Normal.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Normal.Image = (CType(resources.GetObject("rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Normal.Image"), System.Drawing.Image))
            Me.rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = True
            Me.rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = True
            Me.rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Pressed.FontSizeDelta = (CType(resources.GetObject("rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Pressed.FontSizeDelta"), Integer))
            Me.rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Pressed.FontStyleDelta = (CType(resources.GetObject("rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Pressed.FontStyleDelta"), System.Drawing.FontStyle))
            Me.rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Pressed.GradientMode = (CType(resources.GetObject("rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Pressed.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Pressed.Image = (CType(resources.GetObject("rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Pressed.Image"), System.Drawing.Image))
            Me.rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseFont = True
            Me.rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = True
            Me.rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.rgbiCurrentView.Gallery.ColumnCount = 4
            galleryItem2.Checked = True
            galleryItem2.Image = My.Resources.List_32x32
            galleryItem2.Tag = "List"
            galleryItem3.Image = My.Resources.SortAsc_32x32
            galleryItem3.Tag = "Alphabetical"
            galleryItem4.Image = My.Resources.ByState_32x32
            galleryItem4.Tag = "ByState"
            galleryItem5.Image = My.Resources.Card_32x32
            galleryItem5.Tag = "Card"
            galleryItemGroup2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {galleryItem2, galleryItem3, galleryItem4, galleryItem5})
            Me.rgbiCurrentView.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {galleryItemGroup2})
            Me.rgbiCurrentView.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.rgbiCurrentView.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleRadio
            Me.rgbiCurrentView.Gallery.RowCount = 1
            Me.rgbiCurrentView.Gallery.ShowItemText = True
            Me.rgbiCurrentView.Id = 36
            Me.rgbiCurrentView.Name = "rgbiCurrentView"
            '			Me.rgbiCurrentView.GalleryInitDropDownGallery += New DevExpress.XtraBars.Ribbon.InplaceGalleryEventHandler(Me.rgbiCurrentView_GalleryInitDropDownGallery)
            ' 
            ' bsiInfo
            ' 
            resources.ApplyResources(Me.bsiInfo, "bsiInfo")
            Me.bsiInfo.Id = 37
            Me.bsiInfo.Name = "bsiInfo"
            Me.bsiInfo.TextAlignment = System.Drawing.StringAlignment.Near
            ' 
            ' beiZoom
            ' 
            resources.ApplyResources(Me.beiZoom, "beiZoom")
            Me.beiZoom.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
            Me.beiZoom.Edit = Me.repositoryItemZoomTrackBar1
            Me.beiZoom.EditValue = 10
            Me.beiZoom.Id = 38
            Me.beiZoom.Name = "beiZoom"
            ' 
            ' repositoryItemZoomTrackBar1
            ' 
            resources.ApplyResources(Me.repositoryItemZoomTrackBar1, "repositoryItemZoomTrackBar1")
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
            resources.ApplyResources(Me.bbiNormal, "bbiNormal")
            Me.bbiNormal.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
            Me.bbiNormal.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.bbiNormal.Glyph = My.Resources.normal
            Me.bbiNormal.Id = 39
            Me.bbiNormal.Name = "bbiNormal"
            '			Me.bbiNormal.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.bbiNormal_ItemClick)
            ' 
            ' bbiReading
            ' 
            resources.ApplyResources(Me.bbiReading, "bbiReading")
            Me.bbiReading.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
            Me.bbiReading.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.bbiReading.Glyph = My.Resources.reading
            Me.bbiReading.Id = 40
            Me.bbiReading.Name = "bbiReading"
            '			Me.bbiReading.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.bbiReading_ItemClick)
            ' 
            ' bsiTemp
            ' 
            resources.ApplyResources(Me.bsiTemp, "bsiTemp")
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
            Me.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Disabled.FontSizeDelta = (CType(resources.GetObject("rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Disabled.FontSizeDe" & "lta"), Integer))
            Me.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Disabled.FontStyleDelta = (CType(resources.GetObject("rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Disabled.FontStyleD" & "elta"), System.Drawing.FontStyle))
            Me.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Disabled.GradientMode = (CType(resources.GetObject("rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Disabled.GradientMo" & "de"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Disabled.Image = (CType(resources.GetObject("rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Disabled.Image"), System.Drawing.Image))
            Me.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Disabled.Options.UseFont = True
            Me.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Hovered.FontSizeDelta = (CType(resources.GetObject("rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Hovered.FontSizeDel" & "ta"), Integer))
            Me.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Hovered.FontStyleDelta = (CType(resources.GetObject("rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Hovered.FontStyleDe" & "lta"), System.Drawing.FontStyle))
            Me.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Hovered.GradientMode = (CType(resources.GetObject("rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Hovered.GradientMod" & "e"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Hovered.Image = (CType(resources.GetObject("rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Hovered.Image"), System.Drawing.Image))
            Me.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseFont = True
            Me.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = True
            Me.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Normal.FontSizeDelta = (CType(resources.GetObject("rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Normal.FontSizeDelt" & "a"), Integer))
            Me.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Normal.FontStyleDelta = (CType(resources.GetObject("rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Normal.FontStyleDel" & "ta"), System.Drawing.FontStyle))
            Me.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Normal.GradientMode = (CType(resources.GetObject("rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Normal.GradientMode" & ""), System.Drawing.Drawing2D.LinearGradientMode))
            Me.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Normal.Image = (CType(resources.GetObject("rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Normal.Image"), System.Drawing.Image))
            Me.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = True
            Me.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = True
            Me.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Pressed.FontSizeDelta = (CType(resources.GetObject("rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Pressed.FontSizeDel" & "ta"), Integer))
            Me.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Pressed.FontStyleDelta = (CType(resources.GetObject("rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Pressed.FontStyleDe" & "lta"), System.Drawing.FontStyle))
            Me.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Pressed.GradientMode = (CType(resources.GetObject("rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Pressed.GradientMod" & "e"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Pressed.Image = (CType(resources.GetObject("rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Pressed.Image"), System.Drawing.Image))
            Me.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseFont = True
            Me.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = True
            Me.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.rgbiCurrentViewTasks.Gallery.ColumnCount = 4
            galleryItem6.Image = My.Resources.ListByDate_32x32
            galleryItem6.Tag = "TaskList"
            galleryItem7.Image = My.Resources.ToDoList_32x32
            galleryItem7.Tag = "TaskToDoList"
            galleryItem8.Image = My.Resources.Completed_32x32
            galleryItem8.Tag = "TaskCompleted"
            galleryItem9.Image = My.Resources.Today_32x32
            galleryItem9.Tag = "TaskToday"
            galleryItem10.Image = My.Resources.Prioritized_32x32
            galleryItem10.Tag = "TaskPrioritized"
            galleryItem11.Image = My.Resources.Overdue_32x32
            galleryItem11.Tag = "TaskOverdue"
            galleryItem12.Image = My.Resources.List_32x32
            galleryItem12.Tag = "TaskSimpleList"
            galleryItem13.Checked = True
            galleryItem13.Image = My.Resources.Deferred_32x32
            galleryItem13.Tag = "TaskDeferred"
            galleryItemGroup3.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {galleryItem6, galleryItem7, galleryItem8, galleryItem9, galleryItem10, galleryItem11, galleryItem12, galleryItem13})
            Me.rgbiCurrentViewTasks.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {galleryItemGroup3})
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
            resources.ApplyResources(Me.bbiTodayFlag, "bbiTodayFlag")
            Me.bbiTodayFlag.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.bbiTodayFlag.Glyph = My.Resources.Today_Flag
            Me.bbiTodayFlag.Id = 45
            Me.bbiTodayFlag.Name = "bbiTodayFlag"
            ' 
            ' bbiTomorrowFlag
            ' 
            resources.ApplyResources(Me.bbiTomorrowFlag, "bbiTomorrowFlag")
            Me.bbiTomorrowFlag.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.bbiTomorrowFlag.Glyph = My.Resources.Tomorrow_Flag
            Me.bbiTomorrowFlag.Id = 46
            Me.bbiTomorrowFlag.Name = "bbiTomorrowFlag"
            ' 
            ' bbiThisWeekFlag
            ' 
            resources.ApplyResources(Me.bbiThisWeekFlag, "bbiThisWeekFlag")
            Me.bbiThisWeekFlag.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.bbiThisWeekFlag.Glyph = My.Resources.ThisWeek_Flag
            Me.bbiThisWeekFlag.Id = 47
            Me.bbiThisWeekFlag.Name = "bbiThisWeekFlag"
            ' 
            ' bbiNextWeekFlag
            ' 
            resources.ApplyResources(Me.bbiNextWeekFlag, "bbiNextWeekFlag")
            Me.bbiNextWeekFlag.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.bbiNextWeekFlag.Glyph = My.Resources.NextWeek_Flag
            Me.bbiNextWeekFlag.Id = 48
            Me.bbiNextWeekFlag.Name = "bbiNextWeekFlag"
            ' 
            ' bbiNoDateFlag
            ' 
            resources.ApplyResources(Me.bbiNoDateFlag, "bbiNoDateFlag")
            Me.bbiNoDateFlag.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
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
            ' bbiNewContact
            ' 
            resources.ApplyResources(Me.bbiNewContact, "bbiNewContact")
            Me.bbiNewContact.Glyph = My.Resources.NewContact_16x16
            Me.bbiNewContact.Id = 51
            Me.bbiNewContact.LargeGlyph = My.Resources.NewContact_32x32
            Me.bbiNewContact.Name = "bbiNewContact"
            ' 
            ' bbiEditContact
            ' 
            resources.ApplyResources(Me.bbiEditContact, "bbiEditContact")
            Me.bbiEditContact.Glyph = My.Resources.EditContact_16x16
            Me.bbiEditContact.Id = 52
            Me.bbiEditContact.LargeGlyph = My.Resources.EditContact_32x32
            Me.bbiEditContact.Name = "bbiEditContact"
            ' 
            ' bbiDeleteContact
            ' 
            resources.ApplyResources(Me.bbiDeleteContact, "bbiDeleteContact")
            Me.bbiDeleteContact.Glyph = My.Resources.Delete_16x16
            Me.bbiDeleteContact.Id = 53
            Me.bbiDeleteContact.LargeGlyph = My.Resources.Delete_32x32
            Me.bbiDeleteContact.Name = "bbiDeleteContact"
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
            ' newAppointmentItem1
            ' 
            resources.ApplyResources(Me.newAppointmentItem1, "newAppointmentItem1")
            Me.newAppointmentItem1.Enabled = False
            Me.newAppointmentItem1.Id = 67
            Me.newAppointmentItem1.Name = "newAppointmentItem1"
            ' 
            ' newRecurringAppointmentItem1
            ' 
            resources.ApplyResources(Me.newRecurringAppointmentItem1, "newRecurringAppointmentItem1")
            Me.newRecurringAppointmentItem1.Enabled = False
            Me.newRecurringAppointmentItem1.Id = 68
            Me.newRecurringAppointmentItem1.Name = "newRecurringAppointmentItem1"
            ' 
            ' navigateViewBackwardItem1
            ' 
            resources.ApplyResources(Me.navigateViewBackwardItem1, "navigateViewBackwardItem1")
            Me.navigateViewBackwardItem1.Enabled = False
            Me.navigateViewBackwardItem1.Id = 69
            Me.navigateViewBackwardItem1.Name = "navigateViewBackwardItem1"
            ' 
            ' navigateViewForwardItem1
            ' 
            resources.ApplyResources(Me.navigateViewForwardItem1, "navigateViewForwardItem1")
            Me.navigateViewForwardItem1.Enabled = False
            Me.navigateViewForwardItem1.Id = 70
            Me.navigateViewForwardItem1.Name = "navigateViewForwardItem1"
            ' 
            ' gotoTodayItem1
            ' 
            resources.ApplyResources(Me.gotoTodayItem1, "gotoTodayItem1")
            Me.gotoTodayItem1.Enabled = False
            Me.gotoTodayItem1.Id = 71
            Me.gotoTodayItem1.Name = "gotoTodayItem1"
            ' 
            ' viewZoomInItem1
            ' 
            resources.ApplyResources(Me.viewZoomInItem1, "viewZoomInItem1")
            Me.viewZoomInItem1.Enabled = False
            Me.viewZoomInItem1.Id = 72
            Me.viewZoomInItem1.Name = "viewZoomInItem1"
            ' 
            ' viewZoomOutItem1
            ' 
            resources.ApplyResources(Me.viewZoomOutItem1, "viewZoomOutItem1")
            Me.viewZoomOutItem1.Enabled = False
            Me.viewZoomOutItem1.Id = 73
            Me.viewZoomOutItem1.Name = "viewZoomOutItem1"
            ' 
            ' switchToDayViewItem1
            ' 
            resources.ApplyResources(Me.switchToDayViewItem1, "switchToDayViewItem1")
            Me.switchToDayViewItem1.Enabled = False
            Me.switchToDayViewItem1.Id = 74
            Me.switchToDayViewItem1.Name = "switchToDayViewItem1"
            ' 
            ' switchToWorkWeekViewItem1
            ' 
            resources.ApplyResources(Me.switchToWorkWeekViewItem1, "switchToWorkWeekViewItem1")
            Me.switchToWorkWeekViewItem1.Enabled = False
            Me.switchToWorkWeekViewItem1.Id = 75
            Me.switchToWorkWeekViewItem1.Name = "switchToWorkWeekViewItem1"
            ' 
            ' switchToWeekViewItem1
            ' 
            resources.ApplyResources(Me.switchToWeekViewItem1, "switchToWeekViewItem1")
            Me.switchToWeekViewItem1.Enabled = False
            Me.switchToWeekViewItem1.Id = 76
            Me.switchToWeekViewItem1.Name = "switchToWeekViewItem1"
            ' 
            ' switchToMonthViewItem1
            ' 
            resources.ApplyResources(Me.switchToMonthViewItem1, "switchToMonthViewItem1")
            Me.switchToMonthViewItem1.Enabled = False
            Me.switchToMonthViewItem1.Id = 77
            Me.switchToMonthViewItem1.Name = "switchToMonthViewItem1"
            ' 
            ' switchToTimelineViewItem1
            ' 
            resources.ApplyResources(Me.switchToTimelineViewItem1, "switchToTimelineViewItem1")
            Me.switchToTimelineViewItem1.Enabled = False
            Me.switchToTimelineViewItem1.Id = 78
            Me.switchToTimelineViewItem1.Name = "switchToTimelineViewItem1"
            ' 
            ' groupByNoneItem1
            ' 
            resources.ApplyResources(Me.groupByNoneItem1, "groupByNoneItem1")
            Me.groupByNoneItem1.Enabled = False
            Me.groupByNoneItem1.Id = 79
            Me.groupByNoneItem1.Name = "groupByNoneItem1"
            ' 
            ' groupByDateItem1
            ' 
            resources.ApplyResources(Me.groupByDateItem1, "groupByDateItem1")
            Me.groupByDateItem1.Enabled = False
            Me.groupByDateItem1.Id = 80
            Me.groupByDateItem1.Name = "groupByDateItem1"
            ' 
            ' groupByResourceItem1
            ' 
            resources.ApplyResources(Me.groupByResourceItem1, "groupByResourceItem1")
            Me.groupByResourceItem1.Enabled = False
            Me.groupByResourceItem1.Id = 81
            Me.groupByResourceItem1.Name = "groupByResourceItem1"
            ' 
            ' switchTimeScalesItem1
            ' 
            resources.ApplyResources(Me.switchTimeScalesItem1, "switchTimeScalesItem1")
            Me.switchTimeScalesItem1.Enabled = False
            Me.switchTimeScalesItem1.Id = 82
            Me.switchTimeScalesItem1.Name = "switchTimeScalesItem1"
            ' 
            ' switchCompressWeekendItem1
            ' 
            resources.ApplyResources(Me.switchCompressWeekendItem1, "switchCompressWeekendItem1")
            Me.switchCompressWeekendItem1.Enabled = False
            Me.switchCompressWeekendItem1.Id = 83
            Me.switchCompressWeekendItem1.Name = "switchCompressWeekendItem1"
            ' 
            ' switchShowWorkTimeOnlyItem1
            ' 
            resources.ApplyResources(Me.switchShowWorkTimeOnlyItem1, "switchShowWorkTimeOnlyItem1")
            Me.switchShowWorkTimeOnlyItem1.Enabled = False
            Me.switchShowWorkTimeOnlyItem1.Id = 84
            Me.switchShowWorkTimeOnlyItem1.Name = "switchShowWorkTimeOnlyItem1"
            ' 
            ' editAppointmentQueryItem1
            ' 
            resources.ApplyResources(Me.editAppointmentQueryItem1, "editAppointmentQueryItem1")
            Me.editAppointmentQueryItem1.Enabled = False
            Me.editAppointmentQueryItem1.Id = 85
            Me.editAppointmentQueryItem1.MenuAppearance.HeaderItemAppearance.FontSizeDelta = (CType(resources.GetObject("editAppointmentQueryItem1.MenuAppearance.HeaderItemAppearance.FontSizeDelta"), Integer))
            Me.editAppointmentQueryItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
                New DevExpress.XtraBars.LinkPersistInfo(Me.editOccurrenceUICommandItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.editSeriesUICommandItem1)
            })
            Me.editAppointmentQueryItem1.MenuAppearance.HeaderItemAppearance.FontStyleDelta = (CType(resources.GetObject("editAppointmentQueryItem1.MenuAppearance.HeaderItemAppearance.FontStyleDelta"), System.Drawing.FontStyle))
            Me.editAppointmentQueryItem1.MenuAppearance.HeaderItemAppearance.GradientMode = (CType(resources.GetObject("editAppointmentQueryItem1.MenuAppearance.HeaderItemAppearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.editAppointmentQueryItem1.MenuAppearance.HeaderItemAppearance.Image = (CType(resources.GetObject("editAppointmentQueryItem1.MenuAppearance.HeaderItemAppearance.Image"), System.Drawing.Image))
            Me.editAppointmentQueryItem1.Name = "editAppointmentQueryItem1"
            Me.editAppointmentQueryItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
            ' 
            ' editOccurrenceUICommandItem1
            ' 
            resources.ApplyResources(Me.editOccurrenceUICommandItem1, "editOccurrenceUICommandItem1")
            Me.editOccurrenceUICommandItem1.Enabled = False
            Me.editOccurrenceUICommandItem1.Id = 86
            Me.editOccurrenceUICommandItem1.Name = "editOccurrenceUICommandItem1"
            ' 
            ' editSeriesUICommandItem1
            ' 
            resources.ApplyResources(Me.editSeriesUICommandItem1, "editSeriesUICommandItem1")
            Me.editSeriesUICommandItem1.Enabled = False
            Me.editSeriesUICommandItem1.Id = 87
            Me.editSeriesUICommandItem1.Name = "editSeriesUICommandItem1"
            ' 
            ' deleteAppointmentsItem1
            ' 
            resources.ApplyResources(Me.deleteAppointmentsItem1, "deleteAppointmentsItem1")
            Me.deleteAppointmentsItem1.Enabled = False
            Me.deleteAppointmentsItem1.Id = 88
            Me.deleteAppointmentsItem1.MenuAppearance.HeaderItemAppearance.FontSizeDelta = (CType(resources.GetObject("deleteAppointmentsItem1.MenuAppearance.HeaderItemAppearance.FontSizeDelta"), Integer))
            Me.deleteAppointmentsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
                New DevExpress.XtraBars.LinkPersistInfo(Me.deleteOccurrenceItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.deleteSeriesItem1)
            })
            Me.deleteAppointmentsItem1.MenuAppearance.HeaderItemAppearance.FontStyleDelta = (CType(resources.GetObject("deleteAppointmentsItem1.MenuAppearance.HeaderItemAppearance.FontStyleDelta"), System.Drawing.FontStyle))
            Me.deleteAppointmentsItem1.MenuAppearance.HeaderItemAppearance.GradientMode = (CType(resources.GetObject("deleteAppointmentsItem1.MenuAppearance.HeaderItemAppearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.deleteAppointmentsItem1.MenuAppearance.HeaderItemAppearance.Image = (CType(resources.GetObject("deleteAppointmentsItem1.MenuAppearance.HeaderItemAppearance.Image"), System.Drawing.Image))
            Me.deleteAppointmentsItem1.Name = "deleteAppointmentsItem1"
            Me.deleteAppointmentsItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
            ' 
            ' deleteOccurrenceItem1
            ' 
            resources.ApplyResources(Me.deleteOccurrenceItem1, "deleteOccurrenceItem1")
            Me.deleteOccurrenceItem1.Enabled = False
            Me.deleteOccurrenceItem1.Id = 89
            Me.deleteOccurrenceItem1.Name = "deleteOccurrenceItem1"
            ' 
            ' deleteSeriesItem1
            ' 
            resources.ApplyResources(Me.deleteSeriesItem1, "deleteSeriesItem1")
            Me.deleteSeriesItem1.Enabled = False
            Me.deleteSeriesItem1.Id = 90
            Me.deleteSeriesItem1.Name = "deleteSeriesItem1"
            ' 
            ' splitAppointmentItem1
            ' 
            resources.ApplyResources(Me.splitAppointmentItem1, "splitAppointmentItem1")
            Me.splitAppointmentItem1.Enabled = False
            Me.splitAppointmentItem1.Id = 91
            Me.splitAppointmentItem1.Name = "splitAppointmentItem1"
            ' 
            ' changeAppointmentStatusItem1
            ' 
            resources.ApplyResources(Me.changeAppointmentStatusItem1, "changeAppointmentStatusItem1")
            Me.changeAppointmentStatusItem1.Enabled = False
            Me.changeAppointmentStatusItem1.Id = 92
            Me.changeAppointmentStatusItem1.Name = "changeAppointmentStatusItem1"
            ' 
            ' changeAppointmentLabelItem1
            ' 
            resources.ApplyResources(Me.changeAppointmentLabelItem1, "changeAppointmentLabelItem1")
            Me.changeAppointmentLabelItem1.Enabled = False
            Me.changeAppointmentLabelItem1.Id = 93
            Me.changeAppointmentLabelItem1.Name = "changeAppointmentLabelItem1"
            ' 
            ' toggleRecurrenceItem1
            ' 
            resources.ApplyResources(Me.toggleRecurrenceItem1, "toggleRecurrenceItem1")
            Me.toggleRecurrenceItem1.Enabled = False
            Me.toggleRecurrenceItem1.Id = 94
            Me.toggleRecurrenceItem1.Name = "toggleRecurrenceItem1"
            ' 
            ' changeAppointmentReminderItem1
            ' 
            resources.ApplyResources(Me.changeAppointmentReminderItem1, "changeAppointmentReminderItem1")
            Me.changeAppointmentReminderItem1.Edit = Me.repositoryItemDuration1
            Me.changeAppointmentReminderItem1.Enabled = False
            Me.changeAppointmentReminderItem1.Id = 95
            Me.changeAppointmentReminderItem1.Name = "changeAppointmentReminderItem1"
            ' 
            ' repositoryItemDuration1
            ' 
            resources.ApplyResources(Me.repositoryItemDuration1, "repositoryItemDuration1")
            Me.repositoryItemDuration1.AllowNullInput = DevExpress.Utils.DefaultBoolean.False
            Me.repositoryItemDuration1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("repositoryItemDuration1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.repositoryItemDuration1.DisabledStateText = Nothing
            Me.repositoryItemDuration1.Name = "repositoryItemDuration1"
            Me.repositoryItemDuration1.ShowEmptyItem = True
            Me.repositoryItemDuration1.ValidateOnEnterKey = True
            ' 
            ' bbiShowPreview
            ' 
            resources.ApplyResources(Me.bbiShowPreview, "bbiShowPreview")
            Me.bbiShowPreview.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.bbiShowPreview.Down = True
            Me.bbiShowPreview.Glyph = (CType(resources.GetObject("bbiShowPreview.Glyph"), System.Drawing.Image))
            Me.bbiShowPreview.Id = 96
            Me.bbiShowPreview.LargeGlyph = (CType(resources.GetObject("bbiShowPreview.LargeGlyph"), System.Drawing.Image))
            Me.bbiShowPreview.Name = "bbiShowPreview"
            ' 
            ' bsiConnected
            ' 
            resources.ApplyResources(Me.bsiConnected, "bsiConnected")
            Me.bsiConnected.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
            Me.bsiConnected.Id = 97
            Me.bsiConnected.Name = "bsiConnected"
            Me.bsiConnected.TextAlignment = System.Drawing.StringAlignment.Near
            ' 
            ' biRename
            ' 
            resources.ApplyResources(Me.biRename, "biRename")
            Me.biRename.Id = 98
            Me.biRename.Name = "biRename"
            '			Me.biRename.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.biRename_ItemClick)
            ' 
            ' biCreateFolder
            ' 
            resources.ApplyResources(Me.biCreateFolder, "biCreateFolder")
            Me.biCreateFolder.Id = 99
            Me.biCreateFolder.Name = "biCreateFolder"
            '			Me.biCreateFolder.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.biCreateFolder_ItemClick)
            ' 
            ' bbiReminder
            ' 
            resources.ApplyResources(Me.bbiReminder, "bbiReminder")
            Me.bbiReminder.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True
            Me.bbiReminder.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
            Me.bbiReminder.Id = 100
            Me.bbiReminder.Name = "bbiReminder"
            '			Me.bbiReminder.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.bbiReminder_ItemClick)
            ' 
            ' bbColorMix
            ' 
            resources.ApplyResources(Me.bbColorMix, "bbColorMix")
            Me.bbColorMix.Glyph = My.Resources.ColorMixer_16x16
            Me.bbColorMix.Id = 238
            Me.bbColorMix.LargeGlyph = My.Resources.ColorMixer_32x32
            Me.bbColorMix.LargeImageIndex = 0
            Me.bbColorMix.Name = "bbColorMix"
            '			Me.bbColorMix.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.bbColorMix_ItemClick)
            ' 
            ' rpcSearch
            ' 
            resources.ApplyResources(Me.rpcSearch, "rpcSearch")
            Me.rpcSearch.Name = "rpcSearch"
            Me.rpcSearch.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rpSearch})
            ' 
            ' rpSearch
            ' 
            Me.rpSearch.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgFind, Me.rpgFilterColumns, Me.rbgClose})
            Me.rpSearch.Name = "rpSearch"
            resources.ApplyResources(Me.rpSearch, "rpSearch")
            Me.rpSearch.Visible = False
            ' 
            ' rpgFind
            ' 
            Me.rpgFind.ItemLinks.Add(Me.bbiShowUnread)
            Me.rpgFind.ItemLinks.Add(Me.bbiDate)
            Me.rpgFind.ItemLinks.Add(Me.bbiImportant)
            Me.rpgFind.ItemLinks.Add(Me.bbiHasAttachment)
            Me.rpgFind.ItemLinks.Add(Me.bbiClearFilter)
            Me.rpgFind.Name = "rpgFind"
            Me.rpgFind.ShowCaptionButton = False
            resources.ApplyResources(Me.rpgFind, "rpgFind")
            ' 
            ' rpgFilterColumns
            ' 
            Me.rpgFilterColumns.ItemLinks.Add(Me.bsiColumns)
            Me.rpgFilterColumns.ItemLinks.Add(Me.bbiResetColumnsToDefault)
            Me.rpgFilterColumns.Name = "rpgFilterColumns"
            Me.rpgFilterColumns.ShowCaptionButton = False
            resources.ApplyResources(Me.rpgFilterColumns, "rpgFilterColumns")
            ' 
            ' rbgClose
            ' 
            Me.rbgClose.AllowTextClipping = False
            Me.rbgClose.ItemLinks.Add(Me.bbiCloseSearch)
            Me.rbgClose.Name = "rbgClose"
            Me.rbgClose.ShowCaptionButton = False
            resources.ApplyResources(Me.rbgClose, "rbgClose")
            ' 
            ' calendarToolsRibbonPageCategory1
            ' 
            Me.calendarToolsRibbonPageCategory1.Control = Nothing
            Me.calendarToolsRibbonPageCategory1.Name = "calendarToolsRibbonPageCategory1"
            Me.calendarToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.appointmentRibbonPage1})
            Me.calendarToolsRibbonPageCategory1.Tag = "CalendarTools"
            resources.ApplyResources(Me.calendarToolsRibbonPageCategory1, "calendarToolsRibbonPageCategory1")
            ' 
            ' appointmentRibbonPage1
            ' 
            Me.appointmentRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.actionsRibbonPageGroup1, Me.optionsRibbonPageGroup1})
            Me.appointmentRibbonPage1.Name = "appointmentRibbonPage1"
            Me.appointmentRibbonPage1.Tag = "Appointment"
            resources.ApplyResources(Me.appointmentRibbonPage1, "appointmentRibbonPage1")
            Me.appointmentRibbonPage1.Visible = False
            ' 
            ' actionsRibbonPageGroup1
            ' 
            Me.actionsRibbonPageGroup1.ItemLinks.Add(Me.editAppointmentQueryItem1)
            Me.actionsRibbonPageGroup1.ItemLinks.Add(Me.deleteAppointmentsItem1)
            Me.actionsRibbonPageGroup1.ItemLinks.Add(Me.splitAppointmentItem1)
            Me.actionsRibbonPageGroup1.Name = "actionsRibbonPageGroup1"
            ' 
            ' optionsRibbonPageGroup1
            ' 
            Me.optionsRibbonPageGroup1.ItemLinks.Add(Me.changeAppointmentStatusItem1)
            Me.optionsRibbonPageGroup1.ItemLinks.Add(Me.changeAppointmentLabelItem1)
            Me.optionsRibbonPageGroup1.ItemLinks.Add(Me.toggleRecurrenceItem1)
            Me.optionsRibbonPageGroup1.ItemLinks.Add(Me.changeAppointmentReminderItem1)
            Me.optionsRibbonPageGroup1.Name = "optionsRibbonPageGroup1"
            ' 
            ' rpMail
            ' 
            Me.rpMail.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgNew, Me.rpgDelete, Me.rpgTags, Me.rpgLayoutMail})
            Me.rpMail.Name = "rpMail"
            Me.rpMail.Tag = "Mail"
            resources.ApplyResources(Me.rpMail, "rpMail")
            ' 
            ' rpgNew
            ' 
            Me.rpgNew.ItemLinks.Add(Me.bbiNew)
            Me.rpgNew.ItemLinks.Add(Me.bbiReply, True)
            Me.rpgNew.ItemLinks.Add(Me.bbiReplyAll)
            Me.rpgNew.ItemLinks.Add(Me.bbiForward)
            Me.rpgNew.Name = "rpgNew"
            Me.rpgNew.ShowCaptionButton = False
            resources.ApplyResources(Me.rpgNew, "rpgNew")
            ' 
            ' rpgDelete
            ' 
            Me.rpgDelete.AllowTextClipping = False
            Me.rpgDelete.ItemLinks.Add(Me.bbiDelete)
            Me.rpgDelete.Name = "rpgDelete"
            Me.rpgDelete.ShowCaptionButton = False
            resources.ApplyResources(Me.rpgDelete, "rpgDelete")
            ' 
            ' rpgTags
            ' 
            Me.rpgTags.ItemLinks.Add(Me.bbiUnreadRead)
            Me.rpgTags.ItemLinks.Add(Me.bbiPriority)
            Me.rpgTags.Name = "rpgTags"
            Me.rpgTags.ShowCaptionButton = False
            resources.ApplyResources(Me.rpgTags, "rpgTags")
            ' 
            ' rpgLayoutMail
            ' 
            Me.rpgLayoutMail.ItemLinks.Add(Me.bbiRotateLayout)
            Me.rpgLayoutMail.ItemLinks.Add(Me.bbiFlipLayout)
            Me.rpgLayoutMail.ItemLinks.Add(Me.bbiShowPreview)
            Me.rpgLayoutMail.Name = "rpgLayoutMail"
            Me.rpgLayoutMail.ShowCaptionButton = False
            resources.ApplyResources(Me.rpgLayoutMail, "rpgLayoutMail")
            ' 
            ' rpCalendar
            ' 
            Me.rpCalendar.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.appointmentRibbonPageGroup1, Me.navigatorRibbonPageGroup1, Me.arrangeRibbonPageGroup1, Me.groupByRibbonPageGroup1, Me.layoutRibbonPageGroup1})
            Me.rpCalendar.Name = "rpCalendar"
            Me.rpCalendar.Tag = "Calendar"
            resources.ApplyResources(Me.rpCalendar, "rpCalendar")
            ' 
            ' appointmentRibbonPageGroup1
            ' 
            Me.appointmentRibbonPageGroup1.ItemLinks.Add(Me.newAppointmentItem1)
            Me.appointmentRibbonPageGroup1.ItemLinks.Add(Me.newRecurringAppointmentItem1)
            Me.appointmentRibbonPageGroup1.Name = "appointmentRibbonPageGroup1"
            ' 
            ' navigatorRibbonPageGroup1
            ' 
            Me.navigatorRibbonPageGroup1.ItemLinks.Add(Me.navigateViewBackwardItem1)
            Me.navigatorRibbonPageGroup1.ItemLinks.Add(Me.navigateViewForwardItem1)
            Me.navigatorRibbonPageGroup1.ItemLinks.Add(Me.gotoTodayItem1)
            Me.navigatorRibbonPageGroup1.ItemLinks.Add(Me.viewZoomInItem1)
            Me.navigatorRibbonPageGroup1.ItemLinks.Add(Me.viewZoomOutItem1)
            Me.navigatorRibbonPageGroup1.Name = "navigatorRibbonPageGroup1"
            ' 
            ' arrangeRibbonPageGroup1
            ' 
            Me.arrangeRibbonPageGroup1.ItemLinks.Add(Me.switchToDayViewItem1)
            Me.arrangeRibbonPageGroup1.ItemLinks.Add(Me.switchToWorkWeekViewItem1)
            Me.arrangeRibbonPageGroup1.ItemLinks.Add(Me.switchToWeekViewItem1)
            Me.arrangeRibbonPageGroup1.ItemLinks.Add(Me.switchToMonthViewItem1)
            Me.arrangeRibbonPageGroup1.ItemLinks.Add(Me.switchToTimelineViewItem1)
            Me.arrangeRibbonPageGroup1.Name = "arrangeRibbonPageGroup1"
            ' 
            ' groupByRibbonPageGroup1
            ' 
            Me.groupByRibbonPageGroup1.ItemLinks.Add(Me.groupByNoneItem1)
            Me.groupByRibbonPageGroup1.ItemLinks.Add(Me.groupByDateItem1)
            Me.groupByRibbonPageGroup1.ItemLinks.Add(Me.groupByResourceItem1)
            Me.groupByRibbonPageGroup1.Name = "groupByRibbonPageGroup1"
            ' 
            ' layoutRibbonPageGroup1
            ' 
            Me.layoutRibbonPageGroup1.ItemLinks.Add(Me.switchCompressWeekendItem1)
            Me.layoutRibbonPageGroup1.ItemLinks.Add(Me.switchShowWorkTimeOnlyItem1)
            Me.layoutRibbonPageGroup1.ItemLinks.Add(Me.switchTimeScalesItem1)
            Me.layoutRibbonPageGroup1.Name = "layoutRibbonPageGroup1"
            ' 
            ' rpContacts
            ' 
            Me.rpContacts.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgContacts, Me.rpgCurrentView, Me.rpgLayoutContacts})
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
            Me.rpgLayoutContacts.AllowTextClipping = False
            Me.rpgLayoutContacts.ItemLinks.Add(Me.bbiFlipLayout)
            Me.rpgLayoutContacts.Name = "rpgLayoutContacts"
            Me.rpgLayoutContacts.ShowCaptionButton = False
            resources.ApplyResources(Me.rpgLayoutContacts, "rpgLayoutContacts")
            ' 
            ' rpFeeds
            ' 
            Me.rpFeeds.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgFeeds, Me.rpgActionsFeeds, Me.rpgLayoutFeeds})
            Me.rpFeeds.Name = "rpFeeds"
            Me.rpFeeds.Tag = "Feeds"
            resources.ApplyResources(Me.rpFeeds, "rpFeeds")
            ' 
            ' rpgFeeds
            ' 
            Me.rpgFeeds.ItemLinks.Add(Me.bbiNewFeed)
            Me.rpgFeeds.ItemLinks.Add(Me.bbiEditFeed)
            Me.rpgFeeds.ItemLinks.Add(Me.bbiDeleteFeed, True)
            Me.rpgFeeds.Name = "rpgFeeds"
            Me.rpgFeeds.ShowCaptionButton = False
            resources.ApplyResources(Me.rpgFeeds, "rpgFeeds")
            ' 
            ' rpgActionsFeeds
            ' 
            Me.rpgActionsFeeds.AllowTextClipping = False
            Me.rpgActionsFeeds.ItemLinks.Add(Me.bbiRefreshFeed)
            Me.rpgActionsFeeds.Name = "rpgActionsFeeds"
            Me.rpgActionsFeeds.ShowCaptionButton = False
            resources.ApplyResources(Me.rpgActionsFeeds, "rpgActionsFeeds")
            ' 
            ' rpgLayoutFeeds
            ' 
            Me.rpgLayoutFeeds.ItemLinks.Add(Me.bbiRotateLayout)
            Me.rpgLayoutFeeds.ItemLinks.Add(Me.bbiFlipLayout)
            Me.rpgLayoutFeeds.Name = "rpgLayoutFeeds"
            Me.rpgLayoutFeeds.ShowCaptionButton = False
            resources.ApplyResources(Me.rpgLayoutFeeds, "rpgLayoutFeeds")
            ' 
            ' rpTasks
            ' 
            Me.rpTasks.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgTasks, Me.rpgFollowUp, Me.rpdCurrentViewTasks})
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
            ' rpView
            ' 
            Me.rpView.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgNavigation, Me.prgAppearance})
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
            Me.prgAppearance.ItemLinks.Add(Me.bbColorMix)
            Me.prgAppearance.Name = "prgAppearance"
            Me.prgAppearance.ShowCaptionButton = False
            resources.ApplyResources(Me.prgAppearance, "prgAppearance")
            ' 
            ' repositoryItemSpinEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemSpinEdit1, "repositoryItemSpinEdit1")
            Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemSpinEdit1.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
            Me.repositoryItemSpinEdit1.Mask.AutoComplete = (CType(resources.GetObject("repositoryItemSpinEdit1.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType))
            Me.repositoryItemSpinEdit1.Mask.BeepOnError = (CType(resources.GetObject("repositoryItemSpinEdit1.Mask.BeepOnError"), Boolean))
            Me.repositoryItemSpinEdit1.Mask.EditMask = resources.GetString("repositoryItemSpinEdit1.Mask.EditMask")
            Me.repositoryItemSpinEdit1.Mask.IgnoreMaskBlank = (CType(resources.GetObject("repositoryItemSpinEdit1.Mask.IgnoreMaskBlank"), Boolean))
            Me.repositoryItemSpinEdit1.Mask.MaskType = (CType(resources.GetObject("repositoryItemSpinEdit1.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType))
            Me.repositoryItemSpinEdit1.Mask.PlaceHolder = (CType(resources.GetObject("repositoryItemSpinEdit1.Mask.PlaceHolder"), Char))
            Me.repositoryItemSpinEdit1.Mask.SaveLiteral = (CType(resources.GetObject("repositoryItemSpinEdit1.Mask.SaveLiteral"), Boolean))
            Me.repositoryItemSpinEdit1.Mask.ShowPlaceHolders = (CType(resources.GetObject("repositoryItemSpinEdit1.Mask.ShowPlaceHolders"), Boolean))
            Me.repositoryItemSpinEdit1.Mask.UseMaskAsDisplayFormat = (CType(resources.GetObject("repositoryItemSpinEdit1.Mask.UseMaskAsDisplayFormat"), Boolean))
            Me.repositoryItemSpinEdit1.MaxValue = New Decimal(New Integer() {200, 0, 0, 0})
            Me.repositoryItemSpinEdit1.MinValue = New Decimal(New Integer() {10, 0, 0, 0})
            Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
            ' 
            ' ribbonStatusBar1
            ' 
            resources.ApplyResources(Me.ribbonStatusBar1, "ribbonStatusBar1")
            Me.ribbonStatusBar1.ItemLinks.Add(Me.bsiInfo)
            Me.ribbonStatusBar1.ItemLinks.Add(Me.bbiReminder, True)
            Me.ribbonStatusBar1.ItemLinks.Add(Me.bsiConnected)
            Me.ribbonStatusBar1.ItemLinks.Add(Me.bbiNormal)
            Me.ribbonStatusBar1.ItemLinks.Add(Me.bbiReading)
            Me.ribbonStatusBar1.ItemLinks.Add(Me.beiZoom, True)
            Me.ribbonStatusBar1.ItemLinks.Add(Me.bsiTemp, True)
            Me.ribbonStatusBar1.Name = "ribbonStatusBar1"
            Me.ribbonStatusBar1.Ribbon = Me.ribbonControl1
            ' 
            ' navBarControl1
            ' 
            resources.ApplyResources(Me.navBarControl1, "navBarControl1")
            Me.navBarControl1.ActiveGroup = Me.nbgMail
            Me.navBarControl1.Controls.Add(Me.navBarGroupControlContainer1)
            Me.navBarControl1.Controls.Add(Me.navBarGroupControlContainer2)
            Me.navBarControl1.Controls.Add(Me.navBarGroupControlContainer3)
            Me.navBarControl1.Controls.Add(Me.navBarGroupControlContainer4)
            Me.navBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.nbgMail, Me.nbgTasks, Me.nbgCalendar, Me.nbgContacts, Me.nbgFeeds})
            Me.navBarControl1.MenuManager = Me.ribbonControl1
            Me.navBarControl1.Name = "navBarControl1"
            Me.navBarControl1.NavigationPaneGroupClientHeight = 320
            Me.navBarControl1.OptionsNavPane.CollapsedWidth = (CType(resources.GetObject("resource.CollapsedWidth1"), Integer))
            Me.navBarControl1.OptionsNavPane.ExpandedWidth = (CType(resources.GetObject("resource.ExpandedWidth1"), Integer))
            Me.navBarControl1.View = New DevExpress.XtraNavBar.ViewInfo.SkinNavigationPaneViewInfoRegistrator()
            '			Me.navBarControl1.NavPaneStateChanged += New System.EventHandler(Me.navBarControl1_NavPaneStateChanged)
            '			Me.navBarControl1.ActiveGroupChanged += New DevExpress.XtraNavBar.NavBarGroupEventHandler(Me.navBarControl1_ActiveGroupChanged)
            Me.navBarControl1.SuspendFormLayoutInAnimation = False
            ' 
            ' nbgMail
            ' 
            resources.ApplyResources(Me.nbgMail, "nbgMail")
            Me.nbgMail.ControlContainer = Me.navBarGroupControlContainer1
            Me.nbgMail.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None
            Me.nbgMail.Expanded = True
            Me.nbgMail.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
            Me.nbgMail.GroupClientHeight = 80
            Me.nbgMail.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
            Me.nbgMail.LargeImage = My.Resources.Mail_32x32
            Me.nbgMail.Name = "nbgMail"
            Me.nbgMail.SmallImage = My.Resources.Mail_16x16
            ' 
            ' navBarGroupControlContainer1
            ' 
            resources.ApplyResources(Me.navBarGroupControlContainer1, "navBarGroupControlContainer1")
            Me.navBarGroupControlContainer1.Controls.Add(Me.ucMailTree1)
            Me.navBarGroupControlContainer1.Name = "navBarGroupControlContainer1"
            ' 
            ' ucMailTree1
            ' 
            resources.ApplyResources(Me.ucMailTree1, "ucMailTree1")
            Me.ucMailTree1.Name = "ucMailTree1"
            '			Me.ucMailTree1.DataSourceChanged += New DevExpress.MailClient.Win.DataSourceChangedEventHandler(Me.ucMailTree1_DataSourceChanged)
            '			Me.ucMailTree1.ShowMenu += New System.Windows.Forms.MouseEventHandler(Me.ucMailTree1_ShowMenu)
            '			Me.ucMailTree1.UCTreeDragDrop += New DevExpress.MailClient.Win.UCTreeDragDropEventHandler(Me.ucMailTree1_UCTreeDragDrop)
            ' 
            ' navBarGroupControlContainer2
            ' 
            resources.ApplyResources(Me.navBarGroupControlContainer2, "navBarGroupControlContainer2")
            Me.navBarGroupControlContainer2.Controls.Add(Me.ucCalendar1)
            Me.navBarGroupControlContainer2.Name = "navBarGroupControlContainer2"
            ' 
            ' ucCalendar1
            ' 
            resources.ApplyResources(Me.ucCalendar1, "ucCalendar1")
            Me.ucCalendar1.Appearance.BackColor = (CType(resources.GetObject("ucCalendar1.Appearance.BackColor"), System.Drawing.Color))
            Me.ucCalendar1.Appearance.FontSizeDelta = (CType(resources.GetObject("ucCalendar1.Appearance.FontSizeDelta"), Integer))
            Me.ucCalendar1.Appearance.FontStyleDelta = (CType(resources.GetObject("ucCalendar1.Appearance.FontStyleDelta"), System.Drawing.FontStyle))
            Me.ucCalendar1.Appearance.GradientMode = (CType(resources.GetObject("ucCalendar1.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.ucCalendar1.Appearance.Image = (CType(resources.GetObject("ucCalendar1.Appearance.Image"), System.Drawing.Image))
            Me.ucCalendar1.Appearance.Options.UseBackColor = True
            Me.ucCalendar1.Name = "ucCalendar1"
            Me.ucCalendar1.State = DevExpress.XtraNavBar.NavPaneState.Collapsed
            '			Me.ucCalendar1.VisibleChanged += New System.EventHandler(Me.ucCalendar1_VisibleChanged)
            ' 
            ' navBarGroupControlContainer3
            ' 
            resources.ApplyResources(Me.navBarGroupControlContainer3, "navBarGroupControlContainer3")
            Me.navBarGroupControlContainer3.Controls.Add(Me.ucContacts1)
            Me.navBarGroupControlContainer3.Name = "navBarGroupControlContainer3"
            ' 
            ' ucContacts1
            ' 
            resources.ApplyResources(Me.ucContacts1, "ucContacts1")
            Me.ucContacts1.Name = "ucContacts1"
            '			Me.ucContacts1.CheckedChanged += New System.EventHandler(Me.ucContacts1_CheckedChanged)
            ' 
            ' navBarGroupControlContainer4
            ' 
            resources.ApplyResources(Me.navBarGroupControlContainer4, "navBarGroupControlContainer4")
            Me.navBarGroupControlContainer4.Controls.Add(Me.navBarControl2)
            Me.navBarGroupControlContainer4.Name = "navBarGroupControlContainer4"
            ' 
            ' navBarControl2
            ' 
            resources.ApplyResources(Me.navBarControl2, "navBarControl2")
            Me.navBarControl2.ActiveGroup = Nothing
            Me.navBarControl2.LinkSelectionMode = DevExpress.XtraNavBar.LinkSelectionModeType.OneInControl
            Me.navBarControl2.Name = "navBarControl2"
            Me.navBarControl2.OptionsNavPane.CollapsedWidth = (CType(resources.GetObject("resource.CollapsedWidth"), Integer))
            Me.navBarControl2.OptionsNavPane.ExpandedWidth = (CType(resources.GetObject("resource.ExpandedWidth"), Integer))
            ' 
            ' nbgTasks
            ' 
            resources.ApplyResources(Me.nbgTasks, "nbgTasks")
            Me.nbgTasks.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
            Me.nbgTasks.LargeImage = My.Resources.BO_Task_Large
            Me.nbgTasks.Name = "nbgTasks"
            Me.nbgTasks.SmallImage = My.Resources.BO_Task
            ' 
            ' nbgCalendar
            ' 
            resources.ApplyResources(Me.nbgCalendar, "nbgCalendar")
            Me.nbgCalendar.ControlContainer = Me.navBarGroupControlContainer2
            Me.nbgCalendar.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None
            Me.nbgCalendar.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
            Me.nbgCalendar.GroupClientHeight = 80
            Me.nbgCalendar.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
            Me.nbgCalendar.LargeImage = My.Resources.Today_32x32
            Me.nbgCalendar.Name = "nbgCalendar"
            Me.nbgCalendar.SmallImage = My.Resources.Today_16x16
            ' 
            ' nbgContacts
            ' 
            resources.ApplyResources(Me.nbgContacts, "nbgContacts")
            Me.nbgContacts.ControlContainer = Me.navBarGroupControlContainer3
            Me.nbgContacts.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None
            Me.nbgContacts.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
            Me.nbgContacts.GroupClientHeight = 80
            Me.nbgContacts.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
            Me.nbgContacts.LargeImage = My.Resources.Contact_32x32
            Me.nbgContacts.Name = "nbgContacts"
            Me.nbgContacts.SmallImage = My.Resources.Contact_16x16
            ' 
            ' nbgFeeds
            ' 
            resources.ApplyResources(Me.nbgFeeds, "nbgFeeds")
            Me.nbgFeeds.ControlContainer = Me.navBarGroupControlContainer4
            Me.nbgFeeds.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None
            Me.nbgFeeds.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
            Me.nbgFeeds.GroupClientHeight = 80
            Me.nbgFeeds.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
            Me.nbgFeeds.LargeImage = My.Resources.BO_Feeds_Large
            Me.nbgFeeds.Name = "nbgFeeds"
            Me.nbgFeeds.SmallImage = My.Resources.BO_Feeds
            Me.nbgFeeds.Visible = False
            ' 
            ' pcMain
            ' 
            resources.ApplyResources(Me.pcMain, "pcMain")
            Me.pcMain.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pcMain.Controls.Add(Me.backstageViewControl1)
            Me.pcMain.Name = "pcMain"
            ' 
            ' pmTreeView
            ' 
            Me.pmTreeView.ItemLinks.Add(Me.bciShowAllMessageCount)
            Me.pmTreeView.ItemLinks.Add(Me.bciShowUnreadMessageCount)
            Me.pmTreeView.ItemLinks.Add(Me.biCreateFolder, True)
            Me.pmTreeView.ItemLinks.Add(Me.biRename)
            Me.pmTreeView.MenuAppearance.HeaderItemAppearance.FontSizeDelta = (CType(resources.GetObject("pmTreeView.MenuAppearance.HeaderItemAppearance.FontSizeDelta"), Integer))
            Me.pmTreeView.MenuAppearance.HeaderItemAppearance.FontStyleDelta = (CType(resources.GetObject("pmTreeView.MenuAppearance.HeaderItemAppearance.FontStyleDelta"), System.Drawing.FontStyle))
            Me.pmTreeView.MenuAppearance.HeaderItemAppearance.GradientMode = (CType(resources.GetObject("pmTreeView.MenuAppearance.HeaderItemAppearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.pmTreeView.MenuAppearance.HeaderItemAppearance.Image = (CType(resources.GetObject("pmTreeView.MenuAppearance.HeaderItemAppearance.Image"), System.Drawing.Image))
            Me.pmTreeView.Name = "pmTreeView"
            Me.pmTreeView.Ribbon = Me.ribbonControl1
            '			Me.pmTreeView.BeforePopup += New System.ComponentModel.CancelEventHandler(Me.pmTreeView_BeforePopup)
            ' 
            ' pmMessage
            ' 
            Me.pmMessage.ItemLinks.Add(Me.bbiReply)
            Me.pmMessage.ItemLinks.Add(Me.bbiReplyAll)
            Me.pmMessage.ItemLinks.Add(Me.bbiForward)
            Me.pmMessage.ItemLinks.Add(Me.bbiDelete, True)
            Me.pmMessage.ItemLinks.Add(Me.bbiUnreadRead, True)
            Me.pmMessage.ItemLinks.Add(Me.bbiPriority)
            Me.pmMessage.MenuAppearance.HeaderItemAppearance.FontSizeDelta = (CType(resources.GetObject("pmMessage.MenuAppearance.HeaderItemAppearance.FontSizeDelta"), Integer))
            Me.pmMessage.MenuAppearance.HeaderItemAppearance.FontStyleDelta = (CType(resources.GetObject("pmMessage.MenuAppearance.HeaderItemAppearance.FontStyleDelta"), System.Drawing.FontStyle))
            Me.pmMessage.MenuAppearance.HeaderItemAppearance.GradientMode = (CType(resources.GetObject("pmMessage.MenuAppearance.HeaderItemAppearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.pmMessage.MenuAppearance.HeaderItemAppearance.Image = (CType(resources.GetObject("pmMessage.MenuAppearance.HeaderItemAppearance.Image"), System.Drawing.Image))
            Me.pmMessage.Name = "pmMessage"
            Me.pmMessage.Ribbon = Me.ribbonControl1
            ' 
            ' pmFlagStatus
            ' 
            Me.pmFlagStatus.ItemLinks.Add(Me.bbiTodayFlag)
            Me.pmFlagStatus.ItemLinks.Add(Me.bbiTomorrowFlag)
            Me.pmFlagStatus.ItemLinks.Add(Me.bbiThisWeekFlag)
            Me.pmFlagStatus.ItemLinks.Add(Me.bbiNextWeekFlag)
            Me.pmFlagStatus.ItemLinks.Add(Me.bbiNoDateFlag)
            Me.pmFlagStatus.ItemLinks.Add(Me.bbiCustomFlag, True)
            Me.pmFlagStatus.MenuAppearance.HeaderItemAppearance.FontSizeDelta = (CType(resources.GetObject("pmFlagStatus.MenuAppearance.HeaderItemAppearance.FontSizeDelta"), Integer))
            Me.pmFlagStatus.MenuAppearance.HeaderItemAppearance.FontStyleDelta = (CType(resources.GetObject("pmFlagStatus.MenuAppearance.HeaderItemAppearance.FontStyleDelta"), System.Drawing.FontStyle))
            Me.pmFlagStatus.MenuAppearance.HeaderItemAppearance.GradientMode = (CType(resources.GetObject("pmFlagStatus.MenuAppearance.HeaderItemAppearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.pmFlagStatus.MenuAppearance.HeaderItemAppearance.Image = (CType(resources.GetObject("pmFlagStatus.MenuAppearance.HeaderItemAppearance.Image"), System.Drawing.Image))
            Me.pmFlagStatus.Name = "pmFlagStatus"
            Me.pmFlagStatus.Ribbon = Me.ribbonControl1
            ' 
            ' schedulerBarController1
            ' 
            Me.schedulerBarController1.BarItems.Add(Me.newAppointmentItem1)
            Me.schedulerBarController1.BarItems.Add(Me.newRecurringAppointmentItem1)
            Me.schedulerBarController1.BarItems.Add(Me.navigateViewBackwardItem1)
            Me.schedulerBarController1.BarItems.Add(Me.navigateViewForwardItem1)
            Me.schedulerBarController1.BarItems.Add(Me.gotoTodayItem1)
            Me.schedulerBarController1.BarItems.Add(Me.viewZoomInItem1)
            Me.schedulerBarController1.BarItems.Add(Me.viewZoomOutItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchToDayViewItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchToWorkWeekViewItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchToWeekViewItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchToMonthViewItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchToTimelineViewItem1)
            Me.schedulerBarController1.BarItems.Add(Me.groupByNoneItem1)
            Me.schedulerBarController1.BarItems.Add(Me.groupByDateItem1)
            Me.schedulerBarController1.BarItems.Add(Me.groupByResourceItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchTimeScalesItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchCompressWeekendItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchShowWorkTimeOnlyItem1)
            Me.schedulerBarController1.BarItems.Add(Me.editAppointmentQueryItem1)
            Me.schedulerBarController1.BarItems.Add(Me.editOccurrenceUICommandItem1)
            Me.schedulerBarController1.BarItems.Add(Me.editSeriesUICommandItem1)
            Me.schedulerBarController1.BarItems.Add(Me.deleteAppointmentsItem1)
            Me.schedulerBarController1.BarItems.Add(Me.deleteOccurrenceItem1)
            Me.schedulerBarController1.BarItems.Add(Me.deleteSeriesItem1)
            Me.schedulerBarController1.BarItems.Add(Me.splitAppointmentItem1)
            Me.schedulerBarController1.BarItems.Add(Me.changeAppointmentStatusItem1)
            Me.schedulerBarController1.BarItems.Add(Me.changeAppointmentLabelItem1)
            Me.schedulerBarController1.BarItems.Add(Me.toggleRecurrenceItem1)
            Me.schedulerBarController1.BarItems.Add(Me.changeAppointmentReminderItem1)
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
            CType(Me.backstageViewControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.backstageViewControl1.ResumeLayout(False)
            Me.backstageViewClientControl1.ResumeLayout(False)
            Me.backstageViewClientControl2.ResumeLayout(False)
            CType(Me.galleryControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.galleryControl1.ResumeLayout(False)
            Me.backstageViewClientControl3.ResumeLayout(False)
            Me.backstageViewClientControl4.ResumeLayout(False)
            CType(Me.repositoryItemZoomTrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemDuration1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.navBarControl1.ResumeLayout(False)
            Me.navBarGroupControlContainer1.ResumeLayout(False)
            Me.navBarGroupControlContainer2.ResumeLayout(False)
            Me.navBarGroupControlContainer3.ResumeLayout(False)
            Me.navBarGroupControlContainer4.ResumeLayout(False)
            CType(Me.navBarControl2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pcMain, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pcMain.ResumeLayout(False)
            CType(Me.pmTreeView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pmMessage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pmFlagStatus, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.schedulerBarController1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
		Private rpMail As DevExpress.XtraBars.Ribbon.RibbonPage
		Private rpgNew As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private ribbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
		Private WithEvents navBarControl1 As DevExpress.XtraNavBar.NavBarControl
		Private nbgMail As DevExpress.XtraNavBar.NavBarGroup
		Private pcMain As DevExpress.XtraEditors.PanelControl
		Private nbgCalendar As DevExpress.XtraNavBar.NavBarGroup
		Private nbgContacts As DevExpress.XtraNavBar.NavBarGroup
		Private nbgFeeds As DevExpress.XtraNavBar.NavBarGroup
		Private nbgTasks As DevExpress.XtraNavBar.NavBarGroup
		Private rpgDelete As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private navBarGroupControlContainer1 As DevExpress.XtraNavBar.NavBarGroupControlContainer
		Private WithEvents ucMailTree1 As ucMailTree
		Private rpCalendar As DevExpress.XtraBars.Ribbon.RibbonPage
		Private rpContacts As DevExpress.XtraBars.Ribbon.RibbonPage
		Private rpFeeds As DevExpress.XtraBars.Ribbon.RibbonPage
		Private rpTasks As DevExpress.XtraBars.Ribbon.RibbonPage
		Private rpView As DevExpress.XtraBars.Ribbon.RibbonPage
		Private rgbiSkins As DevExpress.XtraBars.RibbonGalleryBarItem
		Private rpgNavigation As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private prgAppearance As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private bbiRotateLayout As DevExpress.XtraBars.BarButtonItem
		Private bbiFlipLayout As DevExpress.XtraBars.BarButtonItem
		Private rpgLayoutMail As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private WithEvents bciShowUnreadMessageCount As DevExpress.XtraBars.BarCheckItem
		Private WithEvents bciShowAllMessageCount As DevExpress.XtraBars.BarCheckItem
		Private WithEvents pmTreeView As DevExpress.XtraBars.PopupMenu
		Private bbiDelete As DevExpress.XtraBars.BarButtonItem
		Private rpgTags As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private bbiNew As DevExpress.XtraBars.BarButtonItem
		Private bbiReply As DevExpress.XtraBars.BarButtonItem
		Private bbiForward As DevExpress.XtraBars.BarButtonItem
		Private bbiReplyAll As DevExpress.XtraBars.BarButtonItem
		Private bbiUnreadRead As DevExpress.XtraBars.BarButtonItem
		Private bbiPriority As DevExpress.XtraBars.BarButtonItem
		Private pmMessage As DevExpress.XtraBars.PopupMenu
		Private bsiNavigation As DevExpress.XtraBars.BarSubItem
		Private navBarGroupControlContainer2 As DevExpress.XtraNavBar.NavBarGroupControlContainer
		Private rpcSearch As DevExpress.XtraBars.Ribbon.RibbonPageCategory
		Private rpSearch As DevExpress.XtraBars.Ribbon.RibbonPage
		Private rpgFilterColumns As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private rpgFind As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private rbgClose As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private bbiCloseSearch As DevExpress.XtraBars.BarButtonItem
		Private bbiShowUnread As DevExpress.XtraBars.BarButtonItem
		Private bbiImportant As DevExpress.XtraBars.BarButtonItem
		Private bbiHasAttachment As DevExpress.XtraBars.BarButtonItem
		Private bbiResetColumnsToDefault As DevExpress.XtraBars.BarButtonItem
		Private bsiColumns As DevExpress.XtraBars.BarSubItem
		Private bbiSubjectColumn As DevExpress.XtraBars.BarButtonItem
		Private bbiFromColumn As DevExpress.XtraBars.BarButtonItem
		Private bbiDateColumn As DevExpress.XtraBars.BarButtonItem
		Private bbiPriorityColumn As DevExpress.XtraBars.BarButtonItem
		Private bbiAttachmentColumn As DevExpress.XtraBars.BarButtonItem
		Private bbiDate As DevExpress.XtraBars.BarButtonItem
		Private bbiClearFilter As DevExpress.XtraBars.BarButtonItem
		Private WithEvents ucCalendar1 As DevExpress.MailClient.Win.Controls.ucCalendar
		Private navBarGroupControlContainer3 As DevExpress.XtraNavBar.NavBarGroupControlContainer
		Private WithEvents ucContacts1 As DevExpress.MailClient.Win.Controls.ucContacts
		Private navBarGroupControlContainer4 As DevExpress.XtraNavBar.NavBarGroupControlContainer
		Private navBarControl2 As DevExpress.XtraNavBar.NavBarControl
		Private WithEvents backstageViewControl1 As DevExpress.XtraBars.Ribbon.BackstageViewControl
		Private bvbiSaveAs As DevExpress.XtraBars.Ribbon.BackstageViewButtonItem
		Private backstageViewClientControl1 As DevExpress.XtraBars.Ribbon.BackstageViewClientControl
		Private bvbiSaveAttachment As DevExpress.XtraBars.Ribbon.BackstageViewButtonItem
		Private bvbiSaveCalendar As DevExpress.XtraBars.Ribbon.BackstageViewButtonItem
		Private bvtiInfo As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
		Private WithEvents bvbiExit As DevExpress.XtraBars.Ribbon.BackstageViewButtonItem
		Private backstageViewClientControl2 As DevExpress.XtraBars.Ribbon.BackstageViewClientControl
		Private bvtiOpen As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
		Private WithEvents galleryControl1 As DevExpress.XtraBars.Ribbon.GalleryControl
		Private galleryControlClient1 As DevExpress.XtraBars.Ribbon.GalleryControlClient
		Private rpgLayoutContacts As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private rpgLayoutFeeds As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private bbiNewFeed As DevExpress.XtraBars.BarButtonItem
		Private bbiEditFeed As DevExpress.XtraBars.BarButtonItem
		Private rpgFeeds As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private bbiDeleteFeed As DevExpress.XtraBars.BarButtonItem
		Private bbiRefreshFeed As DevExpress.XtraBars.BarButtonItem
		Private rpgActionsFeeds As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private WithEvents rgbiCurrentView As DevExpress.XtraBars.RibbonGalleryBarItem
		Private rpgCurrentView As DevExpress.XtraBars.Ribbon.RibbonPageGroup
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
		Private printControl1 As DevExpress.MailClient.Win.Controls.PrintControl
		Private WithEvents bvtiPrint As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
		Private helpControl1 As DevExpress.MailClient.Win.Controls.HelpControl
		Private backstageViewClientControl4 As DevExpress.XtraBars.Ribbon.BackstageViewClientControl
		Private exportControl1 As DevExpress.MailClient.Win.Controls.ExportControl
		Private bvtiExport As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
		Private bbiNewContact As DevExpress.XtraBars.BarButtonItem
		Private bbiEditContact As DevExpress.XtraBars.BarButtonItem
		Private bbiDeleteContact As DevExpress.XtraBars.BarButtonItem
		Private bbiNewTask As DevExpress.XtraBars.BarButtonItem
		Private bbiEditTask As DevExpress.XtraBars.BarButtonItem
		Private bbiDeleteTask As DevExpress.XtraBars.BarButtonItem
		Private rpgContacts As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private rpgTasks As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private newAppointmentItem1 As DevExpress.XtraScheduler.UI.NewAppointmentItem
		Private newRecurringAppointmentItem1 As DevExpress.XtraScheduler.UI.NewRecurringAppointmentItem
		Private navigateViewBackwardItem1 As DevExpress.XtraScheduler.UI.NavigateViewBackwardItem
		Private navigateViewForwardItem1 As DevExpress.XtraScheduler.UI.NavigateViewForwardItem
		Private gotoTodayItem1 As DevExpress.XtraScheduler.UI.GotoTodayItem
		Private viewZoomInItem1 As DevExpress.XtraScheduler.UI.ViewZoomInItem
		Private viewZoomOutItem1 As DevExpress.XtraScheduler.UI.ViewZoomOutItem
		Private switchToDayViewItem1 As DevExpress.XtraScheduler.UI.SwitchToDayViewItem
		Private switchToWorkWeekViewItem1 As DevExpress.XtraScheduler.UI.SwitchToWorkWeekViewItem
		Private switchToWeekViewItem1 As DevExpress.XtraScheduler.UI.SwitchToWeekViewItem
		Private switchToMonthViewItem1 As DevExpress.XtraScheduler.UI.SwitchToMonthViewItem
		Private switchToTimelineViewItem1 As DevExpress.XtraScheduler.UI.SwitchToTimelineViewItem
		Private groupByNoneItem1 As DevExpress.XtraScheduler.UI.GroupByNoneItem
		Private groupByDateItem1 As DevExpress.XtraScheduler.UI.GroupByDateItem
		Private groupByResourceItem1 As DevExpress.XtraScheduler.UI.GroupByResourceItem
		Private switchTimeScalesItem1 As DevExpress.XtraScheduler.UI.SwitchTimeScalesItem
		Private switchCompressWeekendItem1 As DevExpress.XtraScheduler.UI.SwitchCompressWeekendItem
		Private switchShowWorkTimeOnlyItem1 As DevExpress.XtraScheduler.UI.SwitchShowWorkTimeOnlyItem
		Private editAppointmentQueryItem1 As DevExpress.XtraScheduler.UI.EditAppointmentQueryItem
		Private editOccurrenceUICommandItem1 As DevExpress.XtraScheduler.UI.EditOccurrenceUICommandItem
		Private editSeriesUICommandItem1 As DevExpress.XtraScheduler.UI.EditSeriesUICommandItem
		Private deleteAppointmentsItem1 As DevExpress.XtraScheduler.UI.DeleteAppointmentsItem
		Private deleteOccurrenceItem1 As DevExpress.XtraScheduler.UI.DeleteOccurrenceItem
		Private deleteSeriesItem1 As DevExpress.XtraScheduler.UI.DeleteSeriesItem
		Private splitAppointmentItem1 As DevExpress.XtraScheduler.UI.SplitAppointmentItem
		Private changeAppointmentStatusItem1 As DevExpress.XtraScheduler.UI.ChangeAppointmentStatusItem
		Private changeAppointmentLabelItem1 As DevExpress.XtraScheduler.UI.ChangeAppointmentLabelItem
		Private toggleRecurrenceItem1 As DevExpress.XtraScheduler.UI.ToggleRecurrenceItem
		Private changeAppointmentReminderItem1 As DevExpress.XtraScheduler.UI.ChangeAppointmentReminderItem
		Private repositoryItemDuration1 As DevExpress.XtraScheduler.UI.RepositoryItemDuration
		Private calendarToolsRibbonPageCategory1 As DevExpress.XtraScheduler.UI.CalendarToolsRibbonPageCategory
		Private appointmentRibbonPage1 As DevExpress.XtraScheduler.UI.AppointmentRibbonPage
		Private actionsRibbonPageGroup1 As DevExpress.XtraScheduler.UI.ActionsRibbonPageGroup
		Private optionsRibbonPageGroup1 As DevExpress.XtraScheduler.UI.OptionsRibbonPageGroup
		Private appointmentRibbonPageGroup1 As DevExpress.XtraScheduler.UI.AppointmentRibbonPageGroup
		Private navigatorRibbonPageGroup1 As DevExpress.XtraScheduler.UI.NavigatorRibbonPageGroup
		Private arrangeRibbonPageGroup1 As DevExpress.XtraScheduler.UI.ArrangeRibbonPageGroup
		Private groupByRibbonPageGroup1 As DevExpress.XtraScheduler.UI.GroupByRibbonPageGroup
		Private layoutRibbonPageGroup1 As DevExpress.XtraScheduler.UI.LayoutRibbonPageGroup
		Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
		Private schedulerBarController1 As DevExpress.XtraScheduler.UI.SchedulerBarController
		Private bbiShowPreview As XtraBars.BarButtonItem
		Private bsiConnected As XtraBars.BarStaticItem
		Private WithEvents biRename As XtraBars.BarButtonItem
		Private WithEvents biCreateFolder As XtraBars.BarButtonItem
		Private WithEvents bbiReminder As XtraBars.BarButtonItem
		Private WithEvents bbColorMix As XtraBars.BarButtonItem
	End Class
End Namespace


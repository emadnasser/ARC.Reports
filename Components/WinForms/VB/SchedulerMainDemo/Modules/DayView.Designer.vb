Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms

Namespace DevExpress.XtraScheduler.Demos
	Partial Public Class DayViewModule
		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim timeRuler1 As New DevExpress.XtraScheduler.TimeRuler()
			Dim timeRuler2 As New DevExpress.XtraScheduler.TimeRuler()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(DayViewModule))
			Me.schedulerControl = New DevExpress.XtraScheduler.SchedulerControl()
			Me.schedulerStorage = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
			Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
			Me.openScheduleItem1 = New DevExpress.XtraScheduler.UI.OpenScheduleItem()
			Me.saveScheduleItem1 = New DevExpress.XtraScheduler.UI.SaveScheduleItem()
			Me.printPreviewItem1 = New DevExpress.XtraScheduler.UI.PrintPreviewItem()
			Me.printItem1 = New DevExpress.XtraScheduler.UI.PrintItem()
			Me.printPageSetupItem1 = New DevExpress.XtraScheduler.UI.PrintPageSetupItem()
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
			Me.switchToFullWeekViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToFullWeekViewItem()
			Me.switchToMonthViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToMonthViewItem()
			Me.switchToTimelineViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToTimelineViewItem()
			Me.switchToGanttViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToGanttViewItem()
			Me.groupByNoneItem1 = New DevExpress.XtraScheduler.UI.GroupByNoneItem()
			Me.groupByDateItem1 = New DevExpress.XtraScheduler.UI.GroupByDateItem()
			Me.groupByResourceItem1 = New DevExpress.XtraScheduler.UI.GroupByResourceItem()
			Me.switchTimeScalesItem1 = New DevExpress.XtraScheduler.UI.SwitchTimeScalesItem()
			Me.changeScaleWidthItem1 = New DevExpress.XtraScheduler.UI.ChangeScaleWidthItem()
			Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
			Me.switchTimeScalesCaptionItem1 = New DevExpress.XtraScheduler.UI.SwitchTimeScalesCaptionItem()
			Me.switchCompressWeekendItem1 = New DevExpress.XtraScheduler.UI.SwitchCompressWeekendItem()
			Me.switchShowWorkTimeOnlyItem1 = New DevExpress.XtraScheduler.UI.SwitchShowWorkTimeOnlyItem()
			Me.switchCellsAutoHeightItem1 = New DevExpress.XtraScheduler.UI.SwitchCellsAutoHeightItem()
			Me.changeSnapToCellsUIItem1 = New DevExpress.XtraScheduler.UI.ChangeSnapToCellsUIItem()
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
			Me.switchToAgendaViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToAgendaViewItem()
			Me.calendarToolsRibbonPageCategory1 = New DevExpress.XtraScheduler.UI.CalendarToolsRibbonPageCategory()
			Me.appointmentRibbonPage1 = New DevExpress.XtraScheduler.UI.AppointmentRibbonPage()
			Me.actionsRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.ActionsRibbonPageGroup()
			Me.optionsRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.OptionsRibbonPageGroup()
			Me.fileRibbonPage1 = New DevExpress.XtraScheduler.UI.FileRibbonPage()
			Me.commonRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.CommonRibbonPageGroup()
			Me.printRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.PrintRibbonPageGroup()
			Me.homeRibbonPage1 = New DevExpress.XtraScheduler.UI.HomeRibbonPage()
			Me.appointmentRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.AppointmentRibbonPageGroup()
			Me.navigatorRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.NavigatorRibbonPageGroup()
			Me.arrangeRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.ArrangeRibbonPageGroup()
			Me.viewRibbonPage1 = New DevExpress.XtraScheduler.UI.ViewRibbonPage()
			Me.activeViewRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.ActiveViewRibbonPageGroup()
			Me.timeScaleRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.TimeScaleRibbonPageGroup()
			Me.layoutRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.LayoutRibbonPageGroup()
			Me.schedulerBarController1 = New DevExpress.XtraScheduler.UI.SchedulerBarController()
			Me.navigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage()
			Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
			Me.chkShowOverAppointment = New DevExpress.XtraEditors.CheckEdit()
			Me.cbTimeMarkerVisibility = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.cbTimeIndicatorVisibility = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.chkAppointmentShadows = New DevExpress.XtraEditors.CheckEdit()
			Me.spinDaysCount = New DevExpress.XtraEditors.SpinEdit()
			Me.cbStatus = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.cbSnapToCellsMode = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.cbAllDayStatus = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.chkShowRightTimeRuler = New DevExpress.XtraEditors.CheckEdit()
			Me.chkShowWorkTimeOnly = New DevExpress.XtraEditors.CheckEdit()
			Me.chkShowAllDayArea = New DevExpress.XtraEditors.CheckEdit()
			Me.chkShowDayHeaders = New DevExpress.XtraEditors.CheckEdit()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.groupCurrentTimeVisualization = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.navigationPane1 = New DevExpress.XtraBars.Navigation.NavigationPane()
			Me.schedulerPanel = New System.Windows.Forms.Panel()
			CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemDuration1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.schedulerBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.navigationPage1.SuspendLayout()
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControl1.SuspendLayout()
			CType(Me.chkShowOverAppointment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbTimeMarkerVisibility.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbTimeIndicatorVisibility.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkAppointmentShadows.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinDaysCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbSnapToCellsMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbAllDayStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkShowRightTimeRuler.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkShowWorkTimeOnly.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkShowAllDayArea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkShowDayHeaders.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupCurrentTimeVisualization, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.navigationPane1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.navigationPane1.SuspendLayout()
			Me.schedulerPanel.SuspendLayout()
			Me.SuspendLayout()
			' 
			' schedulerControl
			' 
			Me.schedulerControl.DataStorage = Me.schedulerStorage
			Me.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.schedulerControl.Location = New System.Drawing.Point(0, 0)
			Me.schedulerControl.MenuManager = Me.ribbonControl1
			Me.schedulerControl.Name = "schedulerControl"
			Me.schedulerControl.Size = New System.Drawing.Size(775, 512)
			Me.schedulerControl.Start = New System.DateTime(2010, 7, 5, 0, 0, 0, 0)
			Me.schedulerControl.TabIndex = 0
			Me.schedulerControl.Text = "schedulerControl1"
			Me.schedulerControl.Views.DayView.DayCount = 3
			timeRuler2.HorizontalAlignment = DevExpress.XtraScheduler.TimeRulerHorizontalAlignment.Far
			Me.schedulerControl.Views.DayView.TimeRulers.Add(timeRuler1)
			Me.schedulerControl.Views.DayView.TimeRulers.Add(timeRuler2)
			Me.schedulerControl.Views.GanttView.Enabled = False
			Me.schedulerControl.Views.MonthView.Enabled = False
			Me.schedulerControl.Views.TimelineView.Enabled = False
			Me.schedulerControl.Views.WeekView.Enabled = False
			Me.schedulerControl.Views.WorkWeekView.Enabled = False
'			Me.schedulerControl.PopupMenuShowing += New DevExpress.XtraScheduler.PopupMenuShowingEventHandler(Me.schedulerControl_PopupMenuShowing);
			' 
			' ribbonControl1
			' 
			Me.ribbonControl1.ExpandCollapseItem.Id = 0
			Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.openScheduleItem1, Me.saveScheduleItem1, Me.printPreviewItem1, Me.printItem1, Me.printPageSetupItem1, Me.newAppointmentItem1, Me.newRecurringAppointmentItem1, Me.navigateViewBackwardItem1, Me.navigateViewForwardItem1, Me.gotoTodayItem1, Me.viewZoomInItem1, Me.viewZoomOutItem1, Me.switchToDayViewItem1, Me.switchToWorkWeekViewItem1, Me.switchToWeekViewItem1, Me.switchToFullWeekViewItem1, Me.switchToMonthViewItem1, Me.switchToTimelineViewItem1, Me.switchToGanttViewItem1, Me.groupByNoneItem1, Me.groupByDateItem1, Me.groupByResourceItem1, Me.switchTimeScalesItem1, Me.changeScaleWidthItem1, Me.switchTimeScalesCaptionItem1, Me.switchCompressWeekendItem1, Me.switchShowWorkTimeOnlyItem1, Me.switchCellsAutoHeightItem1, Me.changeSnapToCellsUIItem1, Me.editAppointmentQueryItem1, Me.editOccurrenceUICommandItem1, Me.editSeriesUICommandItem1, Me.deleteAppointmentsItem1, Me.deleteOccurrenceItem1, Me.deleteSeriesItem1, Me.splitAppointmentItem1, Me.changeAppointmentStatusItem1, Me.changeAppointmentLabelItem1, Me.toggleRecurrenceItem1, Me.changeAppointmentReminderItem1, Me.switchToAgendaViewItem1})
			Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
			Me.ribbonControl1.MaxItemId = 42
			Me.ribbonControl1.Name = "ribbonControl1"
			Me.ribbonControl1.PageCategories.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageCategory() { Me.calendarToolsRibbonPageCategory1})
			Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.fileRibbonPage1, Me.homeRibbonPage1, Me.viewRibbonPage1})
			Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemSpinEdit1, Me.repositoryItemDuration1})
			Me.ribbonControl1.Size = New System.Drawing.Size(1065, 141)
			' 
			' openScheduleItem1
			' 
			Me.openScheduleItem1.Id = 1
			Me.openScheduleItem1.Name = "openScheduleItem1"
			' 
			' saveScheduleItem1
			' 
			Me.saveScheduleItem1.Id = 2
			Me.saveScheduleItem1.Name = "saveScheduleItem1"
			' 
			' printPreviewItem1
			' 
			Me.printPreviewItem1.Id = 3
			Me.printPreviewItem1.Name = "printPreviewItem1"
			' 
			' printItem1
			' 
			Me.printItem1.Id = 4
			Me.printItem1.Name = "printItem1"
			' 
			' printPageSetupItem1
			' 
			Me.printPageSetupItem1.Id = 5
			Me.printPageSetupItem1.Name = "printPageSetupItem1"
			' 
			' newAppointmentItem1
			' 
			Me.newAppointmentItem1.Id = 6
			Me.newAppointmentItem1.Name = "newAppointmentItem1"
			' 
			' newRecurringAppointmentItem1
			' 
			Me.newRecurringAppointmentItem1.Id = 7
			Me.newRecurringAppointmentItem1.Name = "newRecurringAppointmentItem1"
			' 
			' navigateViewBackwardItem1
			' 
			Me.navigateViewBackwardItem1.Id = 8
			Me.navigateViewBackwardItem1.Name = "navigateViewBackwardItem1"
			' 
			' navigateViewForwardItem1
			' 
			Me.navigateViewForwardItem1.Id = 9
			Me.navigateViewForwardItem1.Name = "navigateViewForwardItem1"
			' 
			' gotoTodayItem1
			' 
			Me.gotoTodayItem1.Id = 10
			Me.gotoTodayItem1.Name = "gotoTodayItem1"
			' 
			' viewZoomInItem1
			' 
			Me.viewZoomInItem1.Id = 11
			Me.viewZoomInItem1.Name = "viewZoomInItem1"
			' 
			' viewZoomOutItem1
			' 
			Me.viewZoomOutItem1.Id = 12
			Me.viewZoomOutItem1.Name = "viewZoomOutItem1"
			' 
			' switchToDayViewItem1
			' 
			Me.switchToDayViewItem1.Id = 13
			Me.switchToDayViewItem1.Name = "switchToDayViewItem1"
			' 
			' switchToWorkWeekViewItem1
			' 
			Me.switchToWorkWeekViewItem1.Id = 14
			Me.switchToWorkWeekViewItem1.Name = "switchToWorkWeekViewItem1"
			' 
			' switchToWeekViewItem1
			' 
			Me.switchToWeekViewItem1.Id = 15
			Me.switchToWeekViewItem1.Name = "switchToWeekViewItem1"
			' 
			' switchToFullWeekViewItem1
			' 
			Me.switchToFullWeekViewItem1.Id = 16
			Me.switchToFullWeekViewItem1.Name = "switchToFullWeekViewItem1"
			' 
			' switchToMonthViewItem1
			' 
			Me.switchToMonthViewItem1.Id = 17
			Me.switchToMonthViewItem1.Name = "switchToMonthViewItem1"
			' 
			' switchToTimelineViewItem1
			' 
			Me.switchToTimelineViewItem1.Id = 18
			Me.switchToTimelineViewItem1.Name = "switchToTimelineViewItem1"
			' 
			' switchToGanttViewItem1
			' 
			Me.switchToGanttViewItem1.Id = 19
			Me.switchToGanttViewItem1.Name = "switchToGanttViewItem1"
			' 
			' groupByNoneItem1
			' 
			Me.groupByNoneItem1.Id = 20
			Me.groupByNoneItem1.Name = "groupByNoneItem1"
			' 
			' groupByDateItem1
			' 
			Me.groupByDateItem1.Id = 21
			Me.groupByDateItem1.Name = "groupByDateItem1"
			' 
			' groupByResourceItem1
			' 
			Me.groupByResourceItem1.Id = 22
			Me.groupByResourceItem1.Name = "groupByResourceItem1"
			' 
			' switchTimeScalesItem1
			' 
			Me.switchTimeScalesItem1.Id = 23
			Me.switchTimeScalesItem1.Name = "switchTimeScalesItem1"
			' 
			' changeScaleWidthItem1
			' 
			Me.changeScaleWidthItem1.Edit = Me.repositoryItemSpinEdit1
			Me.changeScaleWidthItem1.Id = 24
			Me.changeScaleWidthItem1.Name = "changeScaleWidthItem1"
			Me.changeScaleWidthItem1.UseCommandCaption = True
			' 
			' repositoryItemSpinEdit1
			' 
			Me.repositoryItemSpinEdit1.AutoHeight = False
			Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemSpinEdit1.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
			Me.repositoryItemSpinEdit1.MaxValue = New Decimal(New Integer() { 200, 0, 0, 0})
			Me.repositoryItemSpinEdit1.MinValue = New Decimal(New Integer() { 10, 0, 0, 0})
			Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
			' 
			' switchTimeScalesCaptionItem1
			' 
			Me.switchTimeScalesCaptionItem1.Id = 25
			Me.switchTimeScalesCaptionItem1.Name = "switchTimeScalesCaptionItem1"
			' 
			' switchCompressWeekendItem1
			' 
			Me.switchCompressWeekendItem1.Id = 26
			Me.switchCompressWeekendItem1.Name = "switchCompressWeekendItem1"
			' 
			' switchShowWorkTimeOnlyItem1
			' 
			Me.switchShowWorkTimeOnlyItem1.Id = 27
			Me.switchShowWorkTimeOnlyItem1.Name = "switchShowWorkTimeOnlyItem1"
			' 
			' switchCellsAutoHeightItem1
			' 
			Me.switchCellsAutoHeightItem1.Id = 28
			Me.switchCellsAutoHeightItem1.Name = "switchCellsAutoHeightItem1"
			' 
			' changeSnapToCellsUIItem1
			' 
			Me.changeSnapToCellsUIItem1.Id = 29
			Me.changeSnapToCellsUIItem1.Name = "changeSnapToCellsUIItem1"
			' 
			' editAppointmentQueryItem1
			' 
			Me.editAppointmentQueryItem1.Id = 30
			Me.editAppointmentQueryItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.editOccurrenceUICommandItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.editSeriesUICommandItem1)})
			Me.editAppointmentQueryItem1.Name = "editAppointmentQueryItem1"
			Me.editAppointmentQueryItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
			' 
			' editOccurrenceUICommandItem1
			' 
			Me.editOccurrenceUICommandItem1.Id = 31
			Me.editOccurrenceUICommandItem1.Name = "editOccurrenceUICommandItem1"
			' 
			' editSeriesUICommandItem1
			' 
			Me.editSeriesUICommandItem1.Id = 32
			Me.editSeriesUICommandItem1.Name = "editSeriesUICommandItem1"
			' 
			' deleteAppointmentsItem1
			' 
			Me.deleteAppointmentsItem1.Id = 33
			Me.deleteAppointmentsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.deleteOccurrenceItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.deleteSeriesItem1)})
			Me.deleteAppointmentsItem1.Name = "deleteAppointmentsItem1"
			Me.deleteAppointmentsItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
			' 
			' deleteOccurrenceItem1
			' 
			Me.deleteOccurrenceItem1.Id = 34
			Me.deleteOccurrenceItem1.Name = "deleteOccurrenceItem1"
			' 
			' deleteSeriesItem1
			' 
			Me.deleteSeriesItem1.Id = 35
			Me.deleteSeriesItem1.Name = "deleteSeriesItem1"
			' 
			' splitAppointmentItem1
			' 
			Me.splitAppointmentItem1.Id = 36
			Me.splitAppointmentItem1.Name = "splitAppointmentItem1"
			' 
			' changeAppointmentStatusItem1
			' 
			Me.changeAppointmentStatusItem1.Id = 37
			Me.changeAppointmentStatusItem1.Name = "changeAppointmentStatusItem1"
			' 
			' changeAppointmentLabelItem1
			' 
			Me.changeAppointmentLabelItem1.Id = 38
			Me.changeAppointmentLabelItem1.Name = "changeAppointmentLabelItem1"
			' 
			' toggleRecurrenceItem1
			' 
			Me.toggleRecurrenceItem1.Id = 39
			Me.toggleRecurrenceItem1.Name = "toggleRecurrenceItem1"
			' 
			' changeAppointmentReminderItem1
			' 
			Me.changeAppointmentReminderItem1.Edit = Me.repositoryItemDuration1
			Me.changeAppointmentReminderItem1.Id = 40
			Me.changeAppointmentReminderItem1.Name = "changeAppointmentReminderItem1"
			' 
			' repositoryItemDuration1
			' 
			Me.repositoryItemDuration1.AllowNullInput = DevExpress.Utils.DefaultBoolean.False
			Me.repositoryItemDuration1.AutoHeight = False
			Me.repositoryItemDuration1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemDuration1.DisabledStateText = Nothing
			Me.repositoryItemDuration1.Name = "repositoryItemDuration1"
			Me.repositoryItemDuration1.NullValuePromptShowForEmptyValue = True
			Me.repositoryItemDuration1.ShowEmptyItem = True
			Me.repositoryItemDuration1.ValidateOnEnterKey = True
			' 
			' switchToAgendaViewItem1
			' 
			Me.switchToAgendaViewItem1.Id = 41
			Me.switchToAgendaViewItem1.Name = "switchToAgendaViewItem1"
			' 
			' calendarToolsRibbonPageCategory1
			' 
			Me.calendarToolsRibbonPageCategory1.Control = Me.schedulerControl
			Me.calendarToolsRibbonPageCategory1.Name = "calendarToolsRibbonPageCategory1"
			Me.calendarToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.appointmentRibbonPage1})
			Me.calendarToolsRibbonPageCategory1.Visible = False
			' 
			' appointmentRibbonPage1
			' 
			Me.appointmentRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.actionsRibbonPageGroup1, Me.optionsRibbonPageGroup1})
			Me.appointmentRibbonPage1.Name = "appointmentRibbonPage1"
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
			' fileRibbonPage1
			' 
			Me.fileRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.commonRibbonPageGroup1, Me.printRibbonPageGroup1})
			Me.fileRibbonPage1.Name = "fileRibbonPage1"
			' 
			' commonRibbonPageGroup1
			' 
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.openScheduleItem1)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.saveScheduleItem1)
			Me.commonRibbonPageGroup1.Name = "commonRibbonPageGroup1"
			' 
			' printRibbonPageGroup1
			' 
			Me.printRibbonPageGroup1.ItemLinks.Add(Me.printPreviewItem1)
			Me.printRibbonPageGroup1.ItemLinks.Add(Me.printItem1)
			Me.printRibbonPageGroup1.ItemLinks.Add(Me.printPageSetupItem1)
			Me.printRibbonPageGroup1.Name = "printRibbonPageGroup1"
			' 
			' homeRibbonPage1
			' 
			Me.homeRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.appointmentRibbonPageGroup1, Me.navigatorRibbonPageGroup1, Me.arrangeRibbonPageGroup1})
			Me.homeRibbonPage1.Name = "homeRibbonPage1"
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
			Me.arrangeRibbonPageGroup1.ItemLinks.Add(Me.switchToFullWeekViewItem1)
			Me.arrangeRibbonPageGroup1.ItemLinks.Add(Me.switchToMonthViewItem1)
			Me.arrangeRibbonPageGroup1.ItemLinks.Add(Me.switchToTimelineViewItem1)
			Me.arrangeRibbonPageGroup1.ItemLinks.Add(Me.switchToGanttViewItem1)
			Me.arrangeRibbonPageGroup1.Name = "arrangeRibbonPageGroup1"
			' 
			' viewRibbonPage1
			' 
			Me.viewRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.activeViewRibbonPageGroup1, Me.timeScaleRibbonPageGroup1, Me.layoutRibbonPageGroup1})
			Me.viewRibbonPage1.Name = "viewRibbonPage1"
			' 
			' activeViewRibbonPageGroup1
			' 
			Me.activeViewRibbonPageGroup1.ItemLinks.Add(Me.switchToDayViewItem1)
			Me.activeViewRibbonPageGroup1.ItemLinks.Add(Me.switchToWorkWeekViewItem1)
			Me.activeViewRibbonPageGroup1.ItemLinks.Add(Me.switchToWeekViewItem1)
			Me.activeViewRibbonPageGroup1.ItemLinks.Add(Me.switchToMonthViewItem1)
			Me.activeViewRibbonPageGroup1.ItemLinks.Add(Me.switchToTimelineViewItem1)
			Me.activeViewRibbonPageGroup1.ItemLinks.Add(Me.switchToGanttViewItem1)
			Me.activeViewRibbonPageGroup1.ItemLinks.Add(Me.switchToAgendaViewItem1)
			Me.activeViewRibbonPageGroup1.Name = "activeViewRibbonPageGroup1"
			' 
			' timeScaleRibbonPageGroup1
			' 
			Me.timeScaleRibbonPageGroup1.ItemLinks.Add(Me.switchTimeScalesItem1)
			Me.timeScaleRibbonPageGroup1.ItemLinks.Add(Me.changeScaleWidthItem1)
			Me.timeScaleRibbonPageGroup1.ItemLinks.Add(Me.switchTimeScalesCaptionItem1)
			Me.timeScaleRibbonPageGroup1.Name = "timeScaleRibbonPageGroup1"
			' 
			' layoutRibbonPageGroup1
			' 
			Me.layoutRibbonPageGroup1.ItemLinks.Add(Me.switchCompressWeekendItem1)
			Me.layoutRibbonPageGroup1.ItemLinks.Add(Me.switchShowWorkTimeOnlyItem1)
			Me.layoutRibbonPageGroup1.ItemLinks.Add(Me.switchCellsAutoHeightItem1)
			Me.layoutRibbonPageGroup1.ItemLinks.Add(Me.changeSnapToCellsUIItem1)
			Me.layoutRibbonPageGroup1.Name = "layoutRibbonPageGroup1"
			' 
			' schedulerBarController1
			' 
			Me.schedulerBarController1.BarItems.Add(Me.openScheduleItem1)
			Me.schedulerBarController1.BarItems.Add(Me.saveScheduleItem1)
			Me.schedulerBarController1.BarItems.Add(Me.printPreviewItem1)
			Me.schedulerBarController1.BarItems.Add(Me.printItem1)
			Me.schedulerBarController1.BarItems.Add(Me.printPageSetupItem1)
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
			Me.schedulerBarController1.BarItems.Add(Me.switchToFullWeekViewItem1)
			Me.schedulerBarController1.BarItems.Add(Me.switchToMonthViewItem1)
			Me.schedulerBarController1.BarItems.Add(Me.switchToTimelineViewItem1)
			Me.schedulerBarController1.BarItems.Add(Me.switchToGanttViewItem1)
			Me.schedulerBarController1.BarItems.Add(Me.groupByNoneItem1)
			Me.schedulerBarController1.BarItems.Add(Me.groupByDateItem1)
			Me.schedulerBarController1.BarItems.Add(Me.groupByResourceItem1)
			Me.schedulerBarController1.BarItems.Add(Me.switchTimeScalesItem1)
			Me.schedulerBarController1.BarItems.Add(Me.changeScaleWidthItem1)
			Me.schedulerBarController1.BarItems.Add(Me.switchTimeScalesCaptionItem1)
			Me.schedulerBarController1.BarItems.Add(Me.switchCompressWeekendItem1)
			Me.schedulerBarController1.BarItems.Add(Me.switchShowWorkTimeOnlyItem1)
			Me.schedulerBarController1.BarItems.Add(Me.switchCellsAutoHeightItem1)
			Me.schedulerBarController1.BarItems.Add(Me.changeSnapToCellsUIItem1)
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
			Me.schedulerBarController1.BarItems.Add(Me.switchToAgendaViewItem1)
			Me.schedulerBarController1.Control = Me.schedulerControl
			' 
			' navigationPage1
			' 
			Me.navigationPage1.BackgroundPadding = New System.Windows.Forms.Padding(0)
			Me.navigationPage1.Caption = "Options"
			Me.navigationPage1.Controls.Add(Me.layoutControl1)
			Me.navigationPage1.Image = (CType(resources.GetObject("navigationPage1.Image"), System.Drawing.Image))
			Me.navigationPage1.Margin = New System.Windows.Forms.Padding(0)
			Me.navigationPage1.Name = "navigationPage1"
			Me.navigationPage1.Size = New System.Drawing.Size(260, 468)
			' 
			' layoutControl1
			' 
			Me.layoutControl1.Controls.Add(Me.chkShowOverAppointment)
			Me.layoutControl1.Controls.Add(Me.cbTimeMarkerVisibility)
			Me.layoutControl1.Controls.Add(Me.cbTimeIndicatorVisibility)
			Me.layoutControl1.Controls.Add(Me.chkAppointmentShadows)
			Me.layoutControl1.Controls.Add(Me.spinDaysCount)
			Me.layoutControl1.Controls.Add(Me.cbStatus)
			Me.layoutControl1.Controls.Add(Me.cbSnapToCellsMode)
			Me.layoutControl1.Controls.Add(Me.cbAllDayStatus)
			Me.layoutControl1.Controls.Add(Me.chkShowRightTimeRuler)
			Me.layoutControl1.Controls.Add(Me.chkShowWorkTimeOnly)
			Me.layoutControl1.Controls.Add(Me.chkShowAllDayArea)
			Me.layoutControl1.Controls.Add(Me.chkShowDayHeaders)
			Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControl1.Name = "layoutControl1"
			Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(532, 347, 650, 400)
			Me.layoutControl1.Root = Me.layoutControlGroup1
			Me.layoutControl1.Size = New System.Drawing.Size(260, 468)
			Me.layoutControl1.TabIndex = 92
			Me.layoutControl1.Text = "layoutControl1"
			' 
			' chkShowOverAppointment
			' 
			Me.chkShowOverAppointment.Location = New System.Drawing.Point(13, 370)
			Me.chkShowOverAppointment.MenuManager = Me
			Me.chkShowOverAppointment.Name = "chkShowOverAppointment"
			Me.chkShowOverAppointment.Properties.Caption = "Show TimeIndicator Over Appointment"
			Me.chkShowOverAppointment.Size = New System.Drawing.Size(234, 19)
			Me.chkShowOverAppointment.StyleController = Me.layoutControl1
			Me.chkShowOverAppointment.TabIndex = 91
'			Me.chkShowOverAppointment.CheckedChanged += New System.EventHandler(Me.chkShowOverAppointment_CheckedChanged);
			' 
			' cbTimeMarkerVisibility
			' 
			Me.cbTimeMarkerVisibility.Location = New System.Drawing.Point(152, 322)
			Me.cbTimeMarkerVisibility.MenuManager = Me
			Me.cbTimeMarkerVisibility.Name = "cbTimeMarkerVisibility"
			Me.cbTimeMarkerVisibility.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbTimeMarkerVisibility.Properties.Items.AddRange(New Object() { DevExpress.XtraScheduler.TimeMarkerVisibility.Always, DevExpress.XtraScheduler.TimeMarkerVisibility.Never, DevExpress.XtraScheduler.TimeMarkerVisibility.TodayView})
			Me.cbTimeMarkerVisibility.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbTimeMarkerVisibility.Size = New System.Drawing.Size(95, 20)
			Me.cbTimeMarkerVisibility.StyleController = Me.layoutControl1
			Me.cbTimeMarkerVisibility.TabIndex = 4
'			Me.cbTimeMarkerVisibility.SelectedIndexChanged += New System.EventHandler(Me.cbTimeMarkerVisibility_SelectedIndexChanged);
			' 
			' cbTimeIndicatorVisibility
			' 
			Me.cbTimeIndicatorVisibility.Location = New System.Drawing.Point(152, 346)
			Me.cbTimeIndicatorVisibility.MenuManager = Me
			Me.cbTimeIndicatorVisibility.Name = "cbTimeIndicatorVisibility"
			Me.cbTimeIndicatorVisibility.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbTimeIndicatorVisibility.Properties.Items.AddRange(New Object() { DevExpress.XtraScheduler.TimeIndicatorVisibility.Always, DevExpress.XtraScheduler.TimeIndicatorVisibility.Never, DevExpress.XtraScheduler.TimeIndicatorVisibility.TodayView, DevExpress.XtraScheduler.TimeIndicatorVisibility.CurrentDate})
			Me.cbTimeIndicatorVisibility.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbTimeIndicatorVisibility.Size = New System.Drawing.Size(95, 20)
			Me.cbTimeIndicatorVisibility.StyleController = Me.layoutControl1
			Me.cbTimeIndicatorVisibility.TabIndex = 1
'			Me.cbTimeIndicatorVisibility.SelectedIndexChanged += New System.EventHandler(Me.cbTimeIndicatorVisibility_SelectedIndexChanged);
			' 
			' chkAppointmentShadows
			' 
			Me.chkAppointmentShadows.Location = New System.Drawing.Point(13, 259)
			Me.chkAppointmentShadows.Name = "chkAppointmentShadows"
			Me.chkAppointmentShadows.Properties.Caption = "Appointment Shadows"
			Me.chkAppointmentShadows.Size = New System.Drawing.Size(234, 19)
			Me.chkAppointmentShadows.StyleController = Me.layoutControl1
			Me.chkAppointmentShadows.TabIndex = 2
'			Me.chkAppointmentShadows.CheckedChanged += New System.EventHandler(Me.chkAppointmentShadows_CheckedChanged);
			' 
			' spinDaysCount
			' 
			Me.spinDaysCount.EditValue = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.spinDaysCount.Location = New System.Drawing.Point(152, 31)
			Me.spinDaysCount.Name = "spinDaysCount"
			Me.spinDaysCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinDaysCount.Properties.IsFloatValue = False
			Me.spinDaysCount.Properties.Mask.EditMask = "N00"
			Me.spinDaysCount.Properties.MaxValue = New Decimal(New Integer() { 10, 0, 0, 0})
			Me.spinDaysCount.Properties.MinValue = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.spinDaysCount.Size = New System.Drawing.Size(95, 20)
			Me.spinDaysCount.StyleController = Me.layoutControl1
			Me.spinDaysCount.TabIndex = 1
			' 
			' cbStatus
			' 
			Me.cbStatus.EditValue = ""
			Me.cbStatus.Location = New System.Drawing.Point(152, 235)
			Me.cbStatus.Name = "cbStatus"
			Me.cbStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbStatus.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Never", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Never, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Time", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Time, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Bounds", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Bounds, -1)})
			Me.cbStatus.Size = New System.Drawing.Size(95, 20)
			Me.cbStatus.StyleController = Me.layoutControl1
			Me.cbStatus.TabIndex = 89
'			Me.cbStatus.SelectedIndexChanged += New System.EventHandler(Me.cbStatus_SelectedIndexChanged);
			' 
			' cbSnapToCellsMode
			' 
			Me.cbSnapToCellsMode.Location = New System.Drawing.Point(152, 187)
			Me.cbSnapToCellsMode.Name = "cbSnapToCellsMode"
			Me.cbSnapToCellsMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbSnapToCellsMode.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Auto", DevExpress.XtraScheduler.AppointmentSnapToCellsMode.Auto, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Always", DevExpress.XtraScheduler.AppointmentSnapToCellsMode.Always, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Never", DevExpress.XtraScheduler.AppointmentSnapToCellsMode.Never, -1)})
			Me.cbSnapToCellsMode.Size = New System.Drawing.Size(95, 20)
			Me.cbSnapToCellsMode.StyleController = Me.layoutControl1
			Me.cbSnapToCellsMode.TabIndex = 90
'			Me.cbSnapToCellsMode.SelectedIndexChanged += New System.EventHandler(Me.cbSnapToCellsMode_SelectedIndexChanged);
			' 
			' cbAllDayStatus
			' 
			Me.cbAllDayStatus.EditValue = ""
			Me.cbAllDayStatus.Location = New System.Drawing.Point(152, 211)
			Me.cbAllDayStatus.Name = "cbAllDayStatus"
			Me.cbAllDayStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbAllDayStatus.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Never", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Never, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Time", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Time, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Bounds", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Bounds, -1)})
			Me.cbAllDayStatus.Size = New System.Drawing.Size(95, 20)
			Me.cbAllDayStatus.StyleController = Me.layoutControl1
			Me.cbAllDayStatus.TabIndex = 87
'			Me.cbAllDayStatus.SelectedIndexChanged += New System.EventHandler(Me.cbAllDayStatus_SelectedIndexChanged);
			' 
			' chkShowRightTimeRuler
			' 
			Me.chkShowRightTimeRuler.Location = New System.Drawing.Point(13, 124)
			Me.chkShowRightTimeRuler.MenuManager = Me
			Me.chkShowRightTimeRuler.Name = "chkShowRightTimeRuler"
			Me.chkShowRightTimeRuler.Properties.Caption = "TimeRuler On The Right"
			Me.chkShowRightTimeRuler.Size = New System.Drawing.Size(234, 19)
			Me.chkShowRightTimeRuler.StyleController = Me.layoutControl1
			Me.chkShowRightTimeRuler.TabIndex = 5
'			Me.chkShowRightTimeRuler.CheckedChanged += New System.EventHandler(Me.chkShowRightTimeRuler_CheckedChanged);
			' 
			' chkShowWorkTimeOnly
			' 
			Me.chkShowWorkTimeOnly.Location = New System.Drawing.Point(13, 101)
			Me.chkShowWorkTimeOnly.Name = "chkShowWorkTimeOnly"
			Me.chkShowWorkTimeOnly.Properties.Caption = "Show Work Time Only"
			Me.chkShowWorkTimeOnly.Size = New System.Drawing.Size(234, 19)
			Me.chkShowWorkTimeOnly.StyleController = Me.layoutControl1
			Me.chkShowWorkTimeOnly.TabIndex = 0
'			Me.chkShowWorkTimeOnly.CheckedChanged += New System.EventHandler(Me.chkShowWorkTimeOnly_CheckedChanged);
			' 
			' chkShowAllDayArea
			' 
			Me.chkShowAllDayArea.Location = New System.Drawing.Point(13, 78)
			Me.chkShowAllDayArea.Name = "chkShowAllDayArea"
			Me.chkShowAllDayArea.Properties.Caption = "Show All Day Area"
			Me.chkShowAllDayArea.Size = New System.Drawing.Size(234, 19)
			Me.chkShowAllDayArea.StyleController = Me.layoutControl1
			Me.chkShowAllDayArea.TabIndex = 1
'			Me.chkShowAllDayArea.CheckedChanged += New System.EventHandler(Me.chkShowAllDayArea_CheckedChanged);
			' 
			' chkShowDayHeaders
			' 
			Me.chkShowDayHeaders.Location = New System.Drawing.Point(13, 55)
			Me.chkShowDayHeaders.Name = "chkShowDayHeaders"
			Me.chkShowDayHeaders.Properties.Caption = "Show Day Headers"
			Me.chkShowDayHeaders.Size = New System.Drawing.Size(234, 19)
			Me.chkShowDayHeaders.StyleController = Me.layoutControl1
			Me.chkShowDayHeaders.TabIndex = 3
'			Me.chkShowDayHeaders.CheckedChanged += New System.EventHandler(Me.chkShowDayHeaders_CheckedChanged);
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroup1.GroupBordersVisible = False
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.emptySpaceItem1, Me.layoutControlGroup2, Me.layoutControlGroup4, Me.groupCurrentTimeVisualization, Me.emptySpaceItem5, Me.emptySpaceItem2})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "Root"
			Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.layoutControlGroup1.Size = New System.Drawing.Size(260, 468)
			Me.layoutControlGroup1.TextVisible = False
			' 
			' emptySpaceItem1
			' 
			Me.emptySpaceItem1.AllowHotTrack = False
			Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 146)
			Me.emptySpaceItem1.MaxSize = New System.Drawing.Size(0, 10)
			Me.emptySpaceItem1.MinSize = New System.Drawing.Size(10, 10)
			Me.emptySpaceItem1.Name = "emptySpaceItem1"
			Me.emptySpaceItem1.Size = New System.Drawing.Size(250, 10)
			Me.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
			' 
			' layoutControlGroup2
			' 
			Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem2, Me.layoutControlItem6, Me.layoutControlItem5, Me.layoutControlItem3, Me.layoutControlItem4})
			Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup2.Name = "layoutControlGroup2"
			Me.layoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
			Me.layoutControlGroup2.Size = New System.Drawing.Size(250, 146)
			Me.layoutControlGroup2.Text = "View"
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.spinDaysCount
			Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(238, 24)
			Me.layoutControlItem2.Text = "Day Count:"
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(136, 13)
			' 
			' layoutControlItem6
			' 
			Me.layoutControlItem6.Control = Me.chkShowDayHeaders
			Me.layoutControlItem6.Location = New System.Drawing.Point(0, 24)
			Me.layoutControlItem6.Name = "layoutControlItem6"
			Me.layoutControlItem6.Size = New System.Drawing.Size(238, 23)
			Me.layoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem6.TextVisible = False
			' 
			' layoutControlItem5
			' 
			Me.layoutControlItem5.Control = Me.chkShowAllDayArea
			Me.layoutControlItem5.Location = New System.Drawing.Point(0, 47)
			Me.layoutControlItem5.Name = "layoutControlItem5"
			Me.layoutControlItem5.Size = New System.Drawing.Size(238, 23)
			Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem5.TextVisible = False
			' 
			' layoutControlItem3
			' 
			Me.layoutControlItem3.Control = Me.chkShowWorkTimeOnly
			Me.layoutControlItem3.Location = New System.Drawing.Point(0, 70)
			Me.layoutControlItem3.Name = "layoutControlItem3"
			Me.layoutControlItem3.Size = New System.Drawing.Size(238, 23)
			Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem3.TextVisible = False
			' 
			' layoutControlItem4
			' 
			Me.layoutControlItem4.Control = Me.chkShowRightTimeRuler
			Me.layoutControlItem4.Location = New System.Drawing.Point(0, 93)
			Me.layoutControlItem4.Name = "layoutControlItem4"
			Me.layoutControlItem4.Size = New System.Drawing.Size(238, 23)
			Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem4.TextVisible = False
			' 
			' layoutControlGroup4
			' 
			Me.layoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem13, Me.layoutControlItem11, Me.layoutControlItem12, Me.layoutControlItem7})
			Me.layoutControlGroup4.Location = New System.Drawing.Point(0, 156)
			Me.layoutControlGroup4.Name = "layoutControlGroup4"
			Me.layoutControlGroup4.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
			Me.layoutControlGroup4.Size = New System.Drawing.Size(250, 125)
			Me.layoutControlGroup4.Text = "Appointment"
			' 
			' layoutControlItem13
			' 
			Me.layoutControlItem13.Control = Me.cbAllDayStatus
			Me.layoutControlItem13.Location = New System.Drawing.Point(0, 24)
			Me.layoutControlItem13.Name = "layoutControlItem13"
			Me.layoutControlItem13.Size = New System.Drawing.Size(238, 24)
			Me.layoutControlItem13.Text = "All-Day Appointment Status:"
			Me.layoutControlItem13.TextSize = New System.Drawing.Size(136, 13)
			' 
			' layoutControlItem11
			' 
			Me.layoutControlItem11.Control = Me.cbSnapToCellsMode
			Me.layoutControlItem11.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem11.Name = "layoutControlItem11"
			Me.layoutControlItem11.Size = New System.Drawing.Size(238, 24)
			Me.layoutControlItem11.Text = "Snap To Cells Mode:"
			Me.layoutControlItem11.TextSize = New System.Drawing.Size(136, 13)
			' 
			' layoutControlItem12
			' 
			Me.layoutControlItem12.Control = Me.cbStatus
			Me.layoutControlItem12.Location = New System.Drawing.Point(0, 48)
			Me.layoutControlItem12.Name = "layoutControlItem12"
			Me.layoutControlItem12.Size = New System.Drawing.Size(238, 24)
			Me.layoutControlItem12.Text = "Appointment Status:"
			Me.layoutControlItem12.TextSize = New System.Drawing.Size(136, 13)
			' 
			' layoutControlItem7
			' 
			Me.layoutControlItem7.Control = Me.chkAppointmentShadows
			Me.layoutControlItem7.Location = New System.Drawing.Point(0, 72)
			Me.layoutControlItem7.Name = "layoutControlItem7"
			Me.layoutControlItem7.Size = New System.Drawing.Size(238, 23)
			Me.layoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem7.TextVisible = False
			' 
			' groupCurrentTimeVisualization
			' 
			Me.groupCurrentTimeVisualization.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.layoutControlItem8, Me.layoutControlItem9})
			Me.groupCurrentTimeVisualization.Location = New System.Drawing.Point(0, 291)
			Me.groupCurrentTimeVisualization.Name = "groupCurrentTimeVisualization"
			Me.groupCurrentTimeVisualization.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
			Me.groupCurrentTimeVisualization.Size = New System.Drawing.Size(250, 101)
			Me.groupCurrentTimeVisualization.Text = "Current Time Visualization"
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.cbTimeMarkerVisibility
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Size = New System.Drawing.Size(238, 24)
			Me.layoutControlItem1.Text = "TimeMarker Visibility:"
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(136, 13)
			' 
			' layoutControlItem8
			' 
			Me.layoutControlItem8.Control = Me.cbTimeIndicatorVisibility
			Me.layoutControlItem8.Location = New System.Drawing.Point(0, 24)
			Me.layoutControlItem8.Name = "layoutControlItem8"
			Me.layoutControlItem8.Size = New System.Drawing.Size(238, 24)
			Me.layoutControlItem8.Text = "TimeIndicator Visibility:"
			Me.layoutControlItem8.TextSize = New System.Drawing.Size(136, 13)
			' 
			' layoutControlItem9
			' 
			Me.layoutControlItem9.Control = Me.chkShowOverAppointment
			Me.layoutControlItem9.Location = New System.Drawing.Point(0, 48)
			Me.layoutControlItem9.Name = "layoutControlItem9"
			Me.layoutControlItem9.Size = New System.Drawing.Size(238, 23)
			Me.layoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem9.TextVisible = False
			' 
			' emptySpaceItem5
			' 
			Me.emptySpaceItem5.AllowHotTrack = False
			Me.emptySpaceItem5.Location = New System.Drawing.Point(0, 281)
			Me.emptySpaceItem5.MaxSize = New System.Drawing.Size(0, 10)
			Me.emptySpaceItem5.MinSize = New System.Drawing.Size(10, 10)
			Me.emptySpaceItem5.Name = "emptySpaceItem5"
			Me.emptySpaceItem5.Size = New System.Drawing.Size(250, 10)
			Me.emptySpaceItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.emptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
			' 
			' emptySpaceItem2
			' 
			Me.emptySpaceItem2.AllowHotTrack = False
			Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 392)
			Me.emptySpaceItem2.Name = "emptySpaceItem2"
			Me.emptySpaceItem2.Size = New System.Drawing.Size(250, 66)
			Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
			' 
			' navigationPane1
			' 
			Me.navigationPane1.Controls.Add(Me.navigationPage1)
			Me.navigationPane1.Dock = System.Windows.Forms.DockStyle.Right
			Me.navigationPane1.ItemOrientation = System.Windows.Forms.Orientation.Vertical
			Me.navigationPane1.Location = New System.Drawing.Point(775, 141)
			Me.navigationPane1.Name = "navigationPane1"
			Me.navigationPane1.PageProperties.ShowExpandButton = False
			Me.navigationPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() { Me.navigationPage1})
			Me.navigationPane1.RegularSize = New System.Drawing.Size(290, 512)
			Me.navigationPane1.SelectedPage = Me.navigationPage1
			Me.navigationPane1.Size = New System.Drawing.Size(290, 512)
			Me.navigationPane1.TabIndex = 11
			' 
			' schedulerPanel
			' 
			Me.schedulerPanel.Controls.Add(Me.schedulerControl)
			Me.schedulerPanel.Dock = System.Windows.Forms.DockStyle.Fill
			Me.schedulerPanel.Location = New System.Drawing.Point(0, 141)
			Me.schedulerPanel.Name = "schedulerPanel"
			Me.schedulerPanel.Size = New System.Drawing.Size(775, 512)
			Me.schedulerPanel.TabIndex = 13
			' 
			' DayViewModule
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.schedulerPanel)
			Me.Controls.Add(Me.navigationPane1)
			Me.Controls.Add(Me.ribbonControl1)
			Me.Name = "DayViewModule"
			Me.Size = New System.Drawing.Size(1065, 653)
'			Me.Load += New System.EventHandler(Me.DayViewModule_Load);
'			Me.VisibleChanged += New System.EventHandler(Me.DayViewModule_VisibleChanged);
			CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemDuration1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.schedulerBarController1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.navigationPage1.ResumeLayout(False)
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControl1.ResumeLayout(False)
			CType(Me.chkShowOverAppointment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbTimeMarkerVisibility.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbTimeIndicatorVisibility.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkAppointmentShadows.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinDaysCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbSnapToCellsMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbAllDayStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkShowRightTimeRuler.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkShowWorkTimeOnly.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkShowAllDayArea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkShowDayHeaders.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupCurrentTimeVisualization, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.navigationPane1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.navigationPane1.ResumeLayout(False)
			Me.schedulerPanel.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents schedulerControl As DevExpress.XtraScheduler.SchedulerControl
		Private schedulerStorage As DevExpress.XtraScheduler.SchedulerStorage
		Private components As System.ComponentModel.IContainer = Nothing
		Private schedulerBarController1 As UI.SchedulerBarController
		Private ribbonControl1 As XtraBars.Ribbon.RibbonControl
		Private openScheduleItem1 As UI.OpenScheduleItem
		Private saveScheduleItem1 As UI.SaveScheduleItem
		Private printPreviewItem1 As UI.PrintPreviewItem
		Private printItem1 As UI.PrintItem
		Private printPageSetupItem1 As UI.PrintPageSetupItem
		Private newAppointmentItem1 As UI.NewAppointmentItem
		Private newRecurringAppointmentItem1 As UI.NewRecurringAppointmentItem
		Private navigateViewBackwardItem1 As UI.NavigateViewBackwardItem
		Private navigateViewForwardItem1 As UI.NavigateViewForwardItem
		Private gotoTodayItem1 As UI.GotoTodayItem
		Private viewZoomInItem1 As UI.ViewZoomInItem
		Private viewZoomOutItem1 As UI.ViewZoomOutItem
		Private switchToDayViewItem1 As UI.SwitchToDayViewItem
		Private switchToWorkWeekViewItem1 As UI.SwitchToWorkWeekViewItem
		Private switchToWeekViewItem1 As UI.SwitchToWeekViewItem
		Private switchToFullWeekViewItem1 As UI.SwitchToFullWeekViewItem
		Private switchToMonthViewItem1 As UI.SwitchToMonthViewItem
		Private switchToTimelineViewItem1 As UI.SwitchToTimelineViewItem
		Private switchToGanttViewItem1 As UI.SwitchToGanttViewItem
		Private groupByNoneItem1 As UI.GroupByNoneItem
		Private groupByDateItem1 As UI.GroupByDateItem
		Private groupByResourceItem1 As UI.GroupByResourceItem
		Private switchTimeScalesItem1 As UI.SwitchTimeScalesItem
		Private changeScaleWidthItem1 As UI.ChangeScaleWidthItem
		Private repositoryItemSpinEdit1 As XtraEditors.Repository.RepositoryItemSpinEdit
		Private switchTimeScalesCaptionItem1 As UI.SwitchTimeScalesCaptionItem
		Private switchCompressWeekendItem1 As UI.SwitchCompressWeekendItem
		Private switchShowWorkTimeOnlyItem1 As UI.SwitchShowWorkTimeOnlyItem
		Private switchCellsAutoHeightItem1 As UI.SwitchCellsAutoHeightItem
		Private changeSnapToCellsUIItem1 As UI.ChangeSnapToCellsUIItem
		Private editAppointmentQueryItem1 As UI.EditAppointmentQueryItem
		Private editOccurrenceUICommandItem1 As UI.EditOccurrenceUICommandItem
		Private editSeriesUICommandItem1 As UI.EditSeriesUICommandItem
		Private deleteAppointmentsItem1 As UI.DeleteAppointmentsItem
		Private deleteOccurrenceItem1 As UI.DeleteOccurrenceItem
		Private deleteSeriesItem1 As UI.DeleteSeriesItem
		Private splitAppointmentItem1 As UI.SplitAppointmentItem
		Private changeAppointmentStatusItem1 As UI.ChangeAppointmentStatusItem
		Private changeAppointmentLabelItem1 As UI.ChangeAppointmentLabelItem
		Private toggleRecurrenceItem1 As UI.ToggleRecurrenceItem
		Private changeAppointmentReminderItem1 As UI.ChangeAppointmentReminderItem
		Private repositoryItemDuration1 As UI.RepositoryItemDuration
		Private calendarToolsRibbonPageCategory1 As UI.CalendarToolsRibbonPageCategory
		Private appointmentRibbonPage1 As UI.AppointmentRibbonPage
		Private actionsRibbonPageGroup1 As UI.ActionsRibbonPageGroup
		Private optionsRibbonPageGroup1 As UI.OptionsRibbonPageGroup
		Private fileRibbonPage1 As UI.FileRibbonPage
		Private commonRibbonPageGroup1 As UI.CommonRibbonPageGroup
		Private printRibbonPageGroup1 As UI.PrintRibbonPageGroup
		Private homeRibbonPage1 As UI.HomeRibbonPage
		Private appointmentRibbonPageGroup1 As UI.AppointmentRibbonPageGroup
		Private navigatorRibbonPageGroup1 As UI.NavigatorRibbonPageGroup
		Private arrangeRibbonPageGroup1 As UI.ArrangeRibbonPageGroup
		Private viewRibbonPage1 As UI.ViewRibbonPage
		Private activeViewRibbonPageGroup1 As UI.ActiveViewRibbonPageGroup
		Private timeScaleRibbonPageGroup1 As UI.TimeScaleRibbonPageGroup
		Private layoutRibbonPageGroup1 As UI.LayoutRibbonPageGroup
		Private switchToAgendaViewItem1 As UI.SwitchToAgendaViewItem
		Private navigationPage1 As XtraBars.Navigation.NavigationPage
		Private WithEvents chkAppointmentShadows As XtraEditors.CheckEdit
		Private spinDaysCount As XtraEditors.SpinEdit
		Private WithEvents cbAllDayStatus As XtraEditors.ImageComboBoxEdit
		Private WithEvents cbSnapToCellsMode As XtraEditors.ImageComboBoxEdit
		Private WithEvents chkShowWorkTimeOnly As XtraEditors.CheckEdit
		Private WithEvents chkShowRightTimeRuler As XtraEditors.CheckEdit
		Private navigationPane1 As XtraBars.Navigation.NavigationPane
		Private WithEvents chkShowAllDayArea As XtraEditors.CheckEdit
		Private WithEvents chkShowDayHeaders As XtraEditors.CheckEdit
		Private WithEvents cbStatus As XtraEditors.ImageComboBoxEdit
		Private layoutControl1 As XtraLayout.LayoutControl
		Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
		Private WithEvents cbTimeMarkerVisibility As XtraEditors.ComboBoxEdit
		Private WithEvents cbTimeIndicatorVisibility As XtraEditors.ComboBoxEdit
		Private WithEvents chkShowOverAppointment As XtraEditors.CheckEdit
		Private schedulerPanel As Panel
		Private emptySpaceItem5 As XtraLayout.EmptySpaceItem
		Private emptySpaceItem1 As XtraLayout.EmptySpaceItem
		Private layoutControlGroup2 As XtraLayout.LayoutControlGroup
		Private layoutControlItem2 As XtraLayout.LayoutControlItem
		Private layoutControlItem6 As XtraLayout.LayoutControlItem
		Private layoutControlItem5 As XtraLayout.LayoutControlItem
		Private layoutControlItem3 As XtraLayout.LayoutControlItem
		Private layoutControlItem4 As XtraLayout.LayoutControlItem
		Private layoutControlGroup4 As XtraLayout.LayoutControlGroup
		Private layoutControlItem13 As XtraLayout.LayoutControlItem
		Private layoutControlItem11 As XtraLayout.LayoutControlItem
		Private layoutControlItem12 As XtraLayout.LayoutControlItem
		Private layoutControlItem7 As XtraLayout.LayoutControlItem
		Private groupCurrentTimeVisualization As XtraLayout.LayoutControlGroup
		Private layoutControlItem1 As XtraLayout.LayoutControlItem
		Private layoutControlItem8 As XtraLayout.LayoutControlItem
		Private layoutControlItem9 As XtraLayout.LayoutControlItem
		Private emptySpaceItem2 As XtraLayout.EmptySpaceItem
	End Class
End Namespace
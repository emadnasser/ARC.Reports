Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraScheduler.Demos
	Partial Public Class AppearanceModule
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
			Dim timeRuler3 As New DevExpress.XtraScheduler.TimeRuler()
			Me.schedulerControl = New DevExpress.XtraScheduler.SchedulerControl()
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
			Me.groupByRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.GroupByRibbonPageGroup()
			Me.viewRibbonPage1 = New DevExpress.XtraScheduler.UI.ViewRibbonPage()
			Me.activeViewRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.ActiveViewRibbonPageGroup()
			Me.timeScaleRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.TimeScaleRibbonPageGroup()
			Me.layoutRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.LayoutRibbonPageGroup()
			Me.schedulerStorage = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
			Me.panelControl = New DevExpress.XtraEditors.PanelControl()
			Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
			Me.rgrpEdit = New DevExpress.XtraEditors.RadioGroup()
			Me.panelSeparatorControl = New DevExpress.XtraEditors.PanelControl()
			Me.schedulerBarController1 = New DevExpress.XtraScheduler.UI.SchedulerBarController()
			Me.switchToAgendaViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToAgendaViewItem()
			CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemDuration1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl.SuspendLayout()
			CType(Me.rgrpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.schedulerBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' schedulerControl
			' 
			Me.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.schedulerControl.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource
			Me.schedulerControl.Location = New System.Drawing.Point(0, 195)
			Me.schedulerControl.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
			Me.schedulerControl.LookAndFeel.UseDefaultLookAndFeel = False
			Me.schedulerControl.MenuManager = Me.ribbonControl1
			Me.schedulerControl.Name = "schedulerControl"
			Me.schedulerControl.Size = New System.Drawing.Size(704, 209)
			Me.schedulerControl.Start = New System.DateTime(2010, 7, 5, 0, 0, 0, 0)
			Me.schedulerControl.DataStorage = Me.schedulerStorage
			Me.schedulerControl.TabIndex = 0
			Me.schedulerControl.Text = "schedulerControl1"
			Me.schedulerControl.Views.DayView.DayCount = 3
			Me.schedulerControl.Views.DayView.ResourcesPerPage = 2
			Me.schedulerControl.Views.DayView.TimeRulers.Add(timeRuler1)
			Me.schedulerControl.Views.FullWeekView.Enabled = True
			Me.schedulerControl.Views.GanttView.Enabled = False
			Me.schedulerControl.Views.MonthView.ResourcesPerPage = 2
			Me.schedulerControl.Views.TimelineView.ResourcesPerPage = 2
			Me.schedulerControl.Views.WeekView.Enabled = False
			Me.schedulerControl.Views.WeekView.ResourcesPerPage = 2
			Me.schedulerControl.Views.WorkWeekView.ResourcesPerPage = 2
			Me.schedulerControl.Views.WorkWeekView.TimeRulers.Add(timeRuler2)
			Me.schedulerControl.Views.FullWeekView.TimeRulers.Add(timeRuler3)
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
			Me.ribbonControl1.Size = New System.Drawing.Size(704, 142)
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
			Me.repositoryItemDuration1.Name = "repositoryItemDuration1"
			Me.repositoryItemDuration1.NullValuePromptShowForEmptyValue = True
			Me.repositoryItemDuration1.ShowEmptyItem = True
			Me.repositoryItemDuration1.ValidateOnEnterKey = True
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
			Me.homeRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.appointmentRibbonPageGroup1, Me.navigatorRibbonPageGroup1, Me.arrangeRibbonPageGroup1, Me.groupByRibbonPageGroup1})
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
			' groupByRibbonPageGroup1
			' 
			Me.groupByRibbonPageGroup1.ItemLinks.Add(Me.groupByNoneItem1)
			Me.groupByRibbonPageGroup1.ItemLinks.Add(Me.groupByDateItem1)
			Me.groupByRibbonPageGroup1.ItemLinks.Add(Me.groupByResourceItem1)
			Me.groupByRibbonPageGroup1.Name = "groupByRibbonPageGroup1"
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
			Me.activeViewRibbonPageGroup1.ItemLinks.Add(Me.switchToFullWeekViewItem1)
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
			' panelControl
			' 
			Me.panelControl.Controls.Add(Me.btnEdit)
			Me.panelControl.Controls.Add(Me.rgrpEdit)
			Me.panelControl.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl.Location = New System.Drawing.Point(0, 142)
			Me.panelControl.Name = "panelControl"
			Me.panelControl.Size = New System.Drawing.Size(704, 45)
			Me.panelControl.TabIndex = 26
			' 
			' btnEdit
			' 
			Me.btnEdit.ImageIndex = 2
			Me.btnEdit.Location = New System.Drawing.Point(456, 5)
			Me.btnEdit.Name = "btnEdit"
			Me.btnEdit.Size = New System.Drawing.Size(73, 24)
			Me.btnEdit.TabIndex = 84
			Me.btnEdit.Text = "&Edit..."
'			Me.btnEdit.Click += New System.EventHandler(Me.btnEdit_Click);
			' 
			' rgrpEdit
			' 
			Me.rgrpEdit.EditValue = 0
			Me.rgrpEdit.Location = New System.Drawing.Point(5, 5)
			Me.rgrpEdit.Name = "rgrpEdit"
			Me.rgrpEdit.Properties.Columns = 3
			Me.rgrpEdit.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() { New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Scheduler Appearances"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "View Appearances"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Resource Color Schemas")})
			Me.rgrpEdit.Size = New System.Drawing.Size(445, 35)
			Me.rgrpEdit.TabIndex = 83
			' 
			' panelSeparatorControl
			' 
			Me.panelSeparatorControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelSeparatorControl.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelSeparatorControl.Location = New System.Drawing.Point(0, 187)
			Me.panelSeparatorControl.Name = "panelSeparatorControl"
			Me.panelSeparatorControl.Size = New System.Drawing.Size(704, 8)
			Me.panelSeparatorControl.TabIndex = 27
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
			' switchToAgendaViewItem1
			' 
			Me.switchToAgendaViewItem1.Id = 41
			Me.switchToAgendaViewItem1.Name = "switchToAgendaViewItem1"
			' 
			' AppearanceModule
			' 
			Me.Controls.Add(Me.schedulerControl)
			Me.Controls.Add(Me.panelSeparatorControl)
			Me.Controls.Add(Me.panelControl)
			Me.Controls.Add(Me.ribbonControl1)
			Me.Name = "AppearanceModule"
			Me.Size = New System.Drawing.Size(704, 404)
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
'			Me.Load += New System.EventHandler(Me.DayViewModule_Load);
			CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemDuration1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl.ResumeLayout(False)
			CType(Me.rgrpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.schedulerBarController1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub
		#End Region

		Private schedulerControl As DevExpress.XtraScheduler.SchedulerControl
		Private schedulerStorage As DevExpress.XtraScheduler.SchedulerStorage
		Private panelControl As DevExpress.XtraEditors.PanelControl
		Private rgrpEdit As DevExpress.XtraEditors.RadioGroup
		Private WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
		Private components As System.ComponentModel.IContainer = Nothing
		Private panelSeparatorControl As DevExpress.XtraEditors.PanelControl
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
		Private groupByRibbonPageGroup1 As UI.GroupByRibbonPageGroup
		Private viewRibbonPage1 As UI.ViewRibbonPage
		Private timeScaleRibbonPageGroup1 As UI.TimeScaleRibbonPageGroup
		Private layoutRibbonPageGroup1 As UI.LayoutRibbonPageGroup
		Private activeViewRibbonPageGroup1 As UI.ActiveViewRibbonPageGroup
		Private switchToAgendaViewItem1 As UI.SwitchToAgendaViewItem
	End Class
End Namespace

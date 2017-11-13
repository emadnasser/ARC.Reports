Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.Xpo

Namespace DevExpress.XtraScheduler.Demos
	Partial Public Class OutlookSynchronizationModule
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(OutlookSynchronizationModule))
			Me.schedulerStorage = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
			Me.xpCollectionEvents = New DevExpress.Xpo.XPCollection(Me.components)
			Me.session1 = New DevExpress.Xpo.Session(Me.components)
			Me.chkDontDeleteExisting = New DevExpress.XtraEditors.CheckEdit()
			Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
			Me.btnSynchronize = New DevExpress.XtraEditors.SimpleButton()
			Me.chkDeleteInsteadReplace = New DevExpress.XtraEditors.CheckEdit()
			Me.chkDontCreateNew = New DevExpress.XtraEditors.CheckEdit()
			Me.cbCancelingTypes = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.cbCalendarFolderPaths = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.lbApplyTypes = New DevExpress.XtraEditors.LabelControl()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.calendarTabPage = New DevExpress.XtraTab.XtraTabPage()
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
			Me.switchToAgendaViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToAgendaViewItem()
			Me.calendarToolsRibbonPageCategory1 = New DevExpress.XtraScheduler.UI.CalendarToolsRibbonPageCategory()
			Me.appointmentRibbonPage1 = New DevExpress.XtraScheduler.UI.AppointmentRibbonPage()
			Me.actionsRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.ActionsRibbonPageGroup()
			Me.optionsRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.OptionsRibbonPageGroup()
			Me.fileRibbonPage1 = New DevExpress.XtraScheduler.UI.FileRibbonPage()
			Me.printRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.PrintRibbonPageGroup()
			Me.homeRibbonPage1 = New DevExpress.XtraScheduler.UI.HomeRibbonPage()
			Me.appointmentRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.AppointmentRibbonPageGroup()
			Me.navigatorRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.NavigatorRibbonPageGroup()
			Me.arrangeRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.ArrangeRibbonPageGroup()
			Me.viewRibbonPage1 = New DevExpress.XtraScheduler.UI.ViewRibbonPage()
			Me.activeViewRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.ActiveViewRibbonPageGroup()
			Me.timeScaleRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.TimeScaleRibbonPageGroup()
			Me.layoutRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.LayoutRibbonPageGroup()
			Me.logTabPage = New DevExpress.XtraTab.XtraTabPage()
			Me.lbcLog = New DevExpress.XtraEditors.ListBoxControl()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.lblLogInfo = New DevExpress.XtraEditors.LabelControl()
			Me.btnClearLog = New DevExpress.XtraEditors.SimpleButton()
			Me.ProgressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
			Me.schedulerBarController1 = New DevExpress.XtraScheduler.UI.SchedulerBarController()
			Me.navigationPane1 = New DevExpress.XtraBars.Navigation.NavigationPane()
			Me.navigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage()
			Me.emptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
			CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xpCollectionEvents, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.session1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkDontDeleteExisting.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControl1.SuspendLayout()
			CType(Me.chkDeleteInsteadReplace.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkDontCreateNew.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbCancelingTypes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbCalendarFolderPaths.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.calendarTabPage.SuspendLayout()
			CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemDuration1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.logTabPage.SuspendLayout()
			CType(Me.lbcLog, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.schedulerBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.navigationPane1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.navigationPane1.SuspendLayout()
			Me.navigationPage1.SuspendLayout()
			CType(Me.emptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' schedulerStorage
			' 
			Me.schedulerStorage.Appointments.DataSource = Me.xpCollectionEvents
			Me.schedulerStorage.Appointments.Mappings.AllDay = "AllDayEvent"
			Me.schedulerStorage.Appointments.Mappings.Description = "Body"
			Me.schedulerStorage.Appointments.Mappings.End = "End"
			Me.schedulerStorage.Appointments.Mappings.Label = "Label"
			Me.schedulerStorage.Appointments.Mappings.Location = "Location"
			Me.schedulerStorage.Appointments.Mappings.RecurrenceInfo = "RecurrencePattern"
			Me.schedulerStorage.Appointments.Mappings.ReminderInfo = "ReminderSet"
			Me.schedulerStorage.Appointments.Mappings.Start = "Start"
			Me.schedulerStorage.Appointments.Mappings.Status = "BusyStatus"
			Me.schedulerStorage.Appointments.Mappings.Subject = "Subject"
			Me.schedulerStorage.Appointments.Mappings.Type = "AppointmentType"
'			Me.schedulerStorage.AppointmentsInserted += New DevExpress.XtraScheduler.PersistentObjectsEventHandler(Me.schedulerStorage_AppointmentsChanged);
'			Me.schedulerStorage.AppointmentsChanged += New DevExpress.XtraScheduler.PersistentObjectsEventHandler(Me.schedulerStorage_AppointmentsChanged);
			' 
			' xpCollectionEvents
			' 
			Me.xpCollectionEvents.DeleteObjectOnRemove = True
			Me.xpCollectionEvents.ObjectType = GetType(DevExpress.XtraScheduler.Demos.OlAppointment)
			Me.xpCollectionEvents.Session = Me.session1
			' 
			' session1
			' 
			Me.session1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Mode=Share Deny None;data source=OutlookSync.mdb" & ";user id=Admin;XPOProvider=MSAccessSafe;"
			Me.session1.IsObjectModifiedOnNonPersistentPropertyChange = Nothing
			Me.session1.TrackPropertiesModifications = False
			' 
			' chkDontDeleteExisting
			' 
			Me.chkDontDeleteExisting.Cursor = System.Windows.Forms.Cursors.Default
			Me.chkDontDeleteExisting.Location = New System.Drawing.Point(7, 115)
			Me.chkDontDeleteExisting.Name = "chkDontDeleteExisting"
			Me.chkDontDeleteExisting.Properties.Caption = "Don't delete existing"
			Me.chkDontDeleteExisting.Size = New System.Drawing.Size(276, 19)
			Me.chkDontDeleteExisting.StyleController = Me.layoutControl1
			Me.chkDontDeleteExisting.TabIndex = 92
			' 
			' layoutControl1
			' 
			Me.layoutControl1.Controls.Add(Me.btnSynchronize)
			Me.layoutControl1.Controls.Add(Me.chkDeleteInsteadReplace)
			Me.layoutControl1.Controls.Add(Me.chkDontDeleteExisting)
			Me.layoutControl1.Controls.Add(Me.chkDontCreateNew)
			Me.layoutControl1.Controls.Add(Me.cbCancelingTypes)
			Me.layoutControl1.Controls.Add(Me.cbCalendarFolderPaths)
			Me.layoutControl1.Controls.Add(Me.lbApplyTypes)
			Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControl1.Name = "layoutControl1"
			Me.layoutControl1.Root = Me.layoutControlGroup1
			Me.layoutControl1.Size = New System.Drawing.Size(290, 314)
			Me.layoutControl1.TabIndex = 0
			Me.layoutControl1.Text = "layoutControl1"
			' 
			' btnSynchronize
			' 
			Me.btnSynchronize.ImageIndex = 2
			Me.btnSynchronize.Location = New System.Drawing.Point(7, 171)
			Me.btnSynchronize.Name = "btnSynchronize"
			Me.btnSynchronize.Size = New System.Drawing.Size(276, 22)
			Me.btnSynchronize.StyleController = Me.layoutControl1
			Me.btnSynchronize.TabIndex = 88
			Me.btnSynchronize.Text = "&Synchronize"
'			Me.btnSynchronize.Click += New System.EventHandler(Me.btnSynchronize_Click);
			' 
			' chkDeleteInsteadReplace
			' 
			Me.chkDeleteInsteadReplace.Location = New System.Drawing.Point(7, 138)
			Me.chkDeleteInsteadReplace.Name = "chkDeleteInsteadReplace"
			Me.chkDeleteInsteadReplace.Properties.Caption = "Delete instead Replace"
			Me.chkDeleteInsteadReplace.Size = New System.Drawing.Size(276, 19)
			Me.chkDeleteInsteadReplace.StyleController = Me.layoutControl1
			Me.chkDeleteInsteadReplace.TabIndex = 90
			' 
			' chkDontCreateNew
			' 
			Me.chkDontCreateNew.Location = New System.Drawing.Point(7, 92)
			Me.chkDontCreateNew.Name = "chkDontCreateNew"
			Me.chkDontCreateNew.Properties.Caption = "Don't create new"
			Me.chkDontCreateNew.Size = New System.Drawing.Size(276, 19)
			Me.chkDontCreateNew.StyleController = Me.layoutControl1
			Me.chkDontCreateNew.TabIndex = 91
			' 
			' cbCancelingTypes
			' 
			Me.cbCancelingTypes.EditValue = ""
			Me.cbCancelingTypes.Location = New System.Drawing.Point(7, 58)
			Me.cbCancelingTypes.Name = "cbCancelingTypes"
			Me.cbCancelingTypes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbCancelingTypes.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem("None", DevExpress.XtraScheduler.UsedAppointmentType.None, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Recurring", DevExpress.XtraScheduler.UsedAppointmentType.Recurring, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("NonRecurring", DevExpress.XtraScheduler.UsedAppointmentType.NonRecurring, -1)})
			Me.cbCancelingTypes.Size = New System.Drawing.Size(276, 20)
			Me.cbCancelingTypes.StyleController = Me.layoutControl1
			Me.cbCancelingTypes.TabIndex = 93
			' 
			' cbCalendarFolderPaths
			' 
			Me.cbCalendarFolderPaths.Location = New System.Drawing.Point(96, 7)
			Me.cbCalendarFolderPaths.Name = "cbCalendarFolderPaths"
			Me.cbCalendarFolderPaths.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbCalendarFolderPaths.Size = New System.Drawing.Size(187, 20)
			Me.cbCalendarFolderPaths.StyleController = Me.layoutControl1
			Me.cbCalendarFolderPaths.TabIndex = 96
			' 
			' lbApplyTypes
			' 
			Me.lbApplyTypes.Location = New System.Drawing.Point(7, 41)
			Me.lbApplyTypes.Name = "lbApplyTypes"
			Me.lbApplyTypes.Size = New System.Drawing.Size(271, 13)
			Me.lbApplyTypes.StyleController = Me.layoutControl1
			Me.lbApplyTypes.TabIndex = 89
			Me.lbApplyTypes.Text = "Cancel Synchronization For The Following Appointments:"
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroup1.GroupBordersVisible = False
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.emptySpaceItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem6, Me.emptySpaceItem2, Me.layoutControlItem7, Me.emptySpaceItem4, Me.emptySpaceItem3})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "layoutControlGroup1"
			Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.layoutControlGroup1.Size = New System.Drawing.Size(290, 314)
			Me.layoutControlGroup1.TextVisible = False
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.cbCalendarFolderPaths
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Size = New System.Drawing.Size(280, 24)
			Me.layoutControlItem1.Text = "Choose Calendar:"
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(86, 13)
			' 
			' emptySpaceItem1
			' 
			Me.emptySpaceItem1.AllowHotTrack = False
			Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 24)
			Me.emptySpaceItem1.MaxSize = New System.Drawing.Size(0, 10)
			Me.emptySpaceItem1.MinSize = New System.Drawing.Size(10, 10)
			Me.emptySpaceItem1.Name = "emptySpaceItem1"
			Me.emptySpaceItem1.Size = New System.Drawing.Size(280, 10)
			Me.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.lbApplyTypes
			Me.layoutControlItem2.Location = New System.Drawing.Point(0, 34)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(280, 17)
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem2.TextVisible = False
			' 
			' layoutControlItem3
			' 
			Me.layoutControlItem3.Control = Me.cbCancelingTypes
			Me.layoutControlItem3.Location = New System.Drawing.Point(0, 51)
			Me.layoutControlItem3.Name = "layoutControlItem3"
			Me.layoutControlItem3.Size = New System.Drawing.Size(280, 24)
			Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem3.TextVisible = False
			' 
			' layoutControlItem4
			' 
			Me.layoutControlItem4.Control = Me.chkDontCreateNew
			Me.layoutControlItem4.Location = New System.Drawing.Point(0, 85)
			Me.layoutControlItem4.Name = "layoutControlItem4"
			Me.layoutControlItem4.Size = New System.Drawing.Size(280, 23)
			Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem4.TextVisible = False
			' 
			' layoutControlItem5
			' 
			Me.layoutControlItem5.Control = Me.chkDontDeleteExisting
			Me.layoutControlItem5.Location = New System.Drawing.Point(0, 108)
			Me.layoutControlItem5.Name = "layoutControlItem5"
			Me.layoutControlItem5.Size = New System.Drawing.Size(280, 23)
			Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem5.TextVisible = False
			' 
			' layoutControlItem6
			' 
			Me.layoutControlItem6.Control = Me.chkDeleteInsteadReplace
			Me.layoutControlItem6.Location = New System.Drawing.Point(0, 131)
			Me.layoutControlItem6.Name = "layoutControlItem6"
			Me.layoutControlItem6.Size = New System.Drawing.Size(280, 23)
			Me.layoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem6.TextVisible = False
			' 
			' emptySpaceItem3
			' 
			Me.emptySpaceItem3.AllowHotTrack = False
			Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 154)
			Me.emptySpaceItem3.MaxSize = New System.Drawing.Size(0, 10)
			Me.emptySpaceItem3.MinSize = New System.Drawing.Size(10, 10)
			Me.emptySpaceItem3.Name = "emptySpaceItem3"
			Me.emptySpaceItem3.Size = New System.Drawing.Size(280, 10)
			Me.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.emptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
			' 
			' emptySpaceItem2
			' 
			Me.emptySpaceItem2.AllowHotTrack = False
			Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 75)
			Me.emptySpaceItem2.MaxSize = New System.Drawing.Size(0, 10)
			Me.emptySpaceItem2.MinSize = New System.Drawing.Size(10, 10)
			Me.emptySpaceItem2.Name = "emptySpaceItem2"
			Me.emptySpaceItem2.Size = New System.Drawing.Size(280, 10)
			Me.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
			' 
			' layoutControlItem7
			' 
			Me.layoutControlItem7.Control = Me.btnSynchronize
			Me.layoutControlItem7.Location = New System.Drawing.Point(0, 164)
			Me.layoutControlItem7.Name = "layoutControlItem7"
			Me.layoutControlItem7.Size = New System.Drawing.Size(280, 26)
			Me.layoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem7.TextVisible = False
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraTabControl1.Location = New System.Drawing.Point(0, 141)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.calendarTabPage
			Me.xtraTabControl1.Size = New System.Drawing.Size(384, 346)
			Me.xtraTabControl1.TabIndex = 3
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.calendarTabPage, Me.logTabPage})
			' 
			' calendarTabPage
			' 
			Me.calendarTabPage.Controls.Add(Me.schedulerControl)
			Me.calendarTabPage.Name = "calendarTabPage"
			Me.calendarTabPage.Size = New System.Drawing.Size(378, 318)
			Me.calendarTabPage.Text = "Calendar"
			' 
			' schedulerControl
			' 
			Me.schedulerControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.schedulerControl.DataStorage = Me.schedulerStorage
			Me.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.schedulerControl.Location = New System.Drawing.Point(0, 0)
			Me.schedulerControl.MenuManager = Me.ribbonControl1
			Me.schedulerControl.Name = "schedulerControl"
			Me.schedulerControl.Size = New System.Drawing.Size(378, 318)
			Me.schedulerControl.Start = New System.DateTime(2010, 7, 5, 0, 0, 0, 0)
			Me.schedulerControl.TabIndex = 2
			Me.schedulerControl.Text = "schedulerControl1"
			Me.schedulerControl.Views.DayView.DayCount = 5
			Me.schedulerControl.Views.DayView.TimeRulers.Add(timeRuler1)
			Me.schedulerControl.Views.FullWeekView.Enabled = True
			Me.schedulerControl.Views.FullWeekView.TimeRulers.Add(timeRuler2)
			Me.schedulerControl.Views.GanttView.Enabled = False
			Me.schedulerControl.Views.MonthView.ResourcesPerPage = 2
			Me.schedulerControl.Views.MonthView.WeekCount = 2
			Me.schedulerControl.Views.WeekView.Enabled = False
			Me.schedulerControl.Views.WeekView.ResourcesPerPage = 2
			Me.schedulerControl.Views.WorkWeekView.ResourcesPerPage = 2
			Me.schedulerControl.Views.WorkWeekView.TimeRulers.Add(timeRuler3)
			' 
			' ribbonControl1
			' 
			Me.ribbonControl1.ExpandCollapseItem.Id = 0
			Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.openScheduleItem1, Me.saveScheduleItem1, Me.printPreviewItem1, Me.printItem1, Me.printPageSetupItem1, Me.newAppointmentItem1, Me.newRecurringAppointmentItem1, Me.navigateViewBackwardItem1, Me.navigateViewForwardItem1, Me.gotoTodayItem1, Me.viewZoomInItem1, Me.viewZoomOutItem1, Me.switchToDayViewItem1, Me.switchToWorkWeekViewItem1, Me.switchToWeekViewItem1, Me.switchToFullWeekViewItem1, Me.switchToMonthViewItem1, Me.switchToTimelineViewItem1, Me.switchToGanttViewItem1, Me.groupByNoneItem1, Me.groupByDateItem1, Me.groupByResourceItem1, Me.switchTimeScalesItem1, Me.changeScaleWidthItem1, Me.switchTimeScalesCaptionItem1, Me.switchCompressWeekendItem1, Me.switchShowWorkTimeOnlyItem1, Me.switchCellsAutoHeightItem1, Me.changeSnapToCellsUIItem1, Me.editAppointmentQueryItem1, Me.editOccurrenceUICommandItem1, Me.editSeriesUICommandItem1, Me.deleteAppointmentsItem1, Me.deleteOccurrenceItem1, Me.deleteSeriesItem1, Me.splitAppointmentItem1, Me.changeAppointmentStatusItem1, Me.changeAppointmentLabelItem1, Me.toggleRecurrenceItem1, Me.changeAppointmentReminderItem1, Me.switchToAgendaViewItem1})
			Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
			Me.ribbonControl1.MaxItemId = 41
			Me.ribbonControl1.Name = "ribbonControl1"
			Me.ribbonControl1.PageCategories.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageCategory() { Me.calendarToolsRibbonPageCategory1})
			Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.fileRibbonPage1, Me.homeRibbonPage1, Me.viewRibbonPage1})
			Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemSpinEdit1, Me.repositoryItemDuration1})
			Me.ribbonControl1.Size = New System.Drawing.Size(704, 141)
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
			Me.fileRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.printRibbonPageGroup1})
			Me.fileRibbonPage1.Name = "fileRibbonPage1"
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
			' logTabPage
			' 
			Me.logTabPage.Controls.Add(Me.lbcLog)
			Me.logTabPage.Controls.Add(Me.panelControl1)
			Me.logTabPage.Name = "logTabPage"
			Me.logTabPage.Size = New System.Drawing.Size(378, 318)
			Me.logTabPage.Text = "Log"
			' 
			' lbcLog
			' 
			Me.lbcLog.Dock = System.Windows.Forms.DockStyle.Fill
			Me.lbcLog.Location = New System.Drawing.Point(0, 32)
			Me.lbcLog.Name = "lbcLog"
			Me.lbcLog.Size = New System.Drawing.Size(378, 286)
			Me.lbcLog.TabIndex = 5
			' 
			' panelControl1
			' 
			Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl1.Controls.Add(Me.lblLogInfo)
			Me.panelControl1.Controls.Add(Me.btnClearLog)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(378, 32)
			Me.panelControl1.TabIndex = 6
			' 
			' lblLogInfo
			' 
			Me.lblLogInfo.Location = New System.Drawing.Point(3, 8)
			Me.lblLogInfo.Name = "lblLogInfo"
			Me.lblLogInfo.Size = New System.Drawing.Size(120, 13)
			Me.lblLogInfo.TabIndex = 90
			Me.lblLogInfo.Text = "Synchronization process:"
			' 
			' btnClearLog
			' 
			Me.btnClearLog.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.btnClearLog.ImageIndex = 2
			Me.btnClearLog.Location = New System.Drawing.Point(311, 4)
			Me.btnClearLog.Name = "btnClearLog"
			Me.btnClearLog.Size = New System.Drawing.Size(64, 24)
			Me.btnClearLog.TabIndex = 76
			Me.btnClearLog.Text = "&Clear"
'			Me.btnClearLog.Click += New System.EventHandler(Me.btnClearLog_Click);
			' 
			' ProgressBarControl1
			' 
			Me.ProgressBarControl1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.ProgressBarControl1.Location = New System.Drawing.Point(0, 487)
			Me.ProgressBarControl1.Name = "ProgressBarControl1"
			Me.ProgressBarControl1.Properties.Step = 1
			Me.ProgressBarControl1.Size = New System.Drawing.Size(384, 12)
			Me.ProgressBarControl1.TabIndex = 8
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
			' navigationPane1
			' 
			Me.navigationPane1.Controls.Add(Me.navigationPage1)
			Me.navigationPane1.Dock = System.Windows.Forms.DockStyle.Right
			Me.navigationPane1.ItemOrientation = System.Windows.Forms.Orientation.Vertical
			Me.navigationPane1.Location = New System.Drawing.Point(384, 141)
			Me.navigationPane1.Name = "navigationPane1"
			Me.navigationPane1.PageProperties.ShowExpandButton = False
			Me.navigationPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() { Me.navigationPage1})
			Me.navigationPane1.RegularSize = New System.Drawing.Size(320, 358)
			Me.navigationPane1.SelectedPage = Me.navigationPage1
			Me.navigationPane1.Size = New System.Drawing.Size(320, 358)
			Me.navigationPane1.TabIndex = 11
			Me.navigationPane1.Text = "navigationPane1"
			' 
			' navigationPage1
			' 
			Me.navigationPage1.BackgroundPadding = New System.Windows.Forms.Padding(0)
			Me.navigationPage1.Caption = "Options"
			Me.navigationPage1.Controls.Add(Me.layoutControl1)
			Me.navigationPage1.Image = (CType(resources.GetObject("navigationPage1.Image"), System.Drawing.Image))
			Me.navigationPage1.Name = "navigationPage1"
			Me.navigationPage1.Size = New System.Drawing.Size(290, 314)
			' 
			' emptySpaceItem4
			' 
			Me.emptySpaceItem4.AllowHotTrack = False
			Me.emptySpaceItem4.Location = New System.Drawing.Point(0, 190)
			Me.emptySpaceItem4.Name = "emptySpaceItem4"
			Me.emptySpaceItem4.Size = New System.Drawing.Size(280, 114)
			Me.emptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
			' 
			' OutlookSynchronizationModule
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Controls.Add(Me.ProgressBarControl1)
			Me.Controls.Add(Me.navigationPane1)
			Me.Controls.Add(Me.ribbonControl1)
			Me.Name = "OutlookSynchronizationModule"
			Me.Size = New System.Drawing.Size(704, 499)
'			Me.Load += New System.EventHandler(Me.OutlookSynchronizationModule_Load);
'			Me.VisibleChanged += New System.EventHandler(Me.OutlookSynchronizationModule_VisibleChanged);
			CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xpCollectionEvents, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.session1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkDontDeleteExisting.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControl1.ResumeLayout(False)
			CType(Me.chkDeleteInsteadReplace.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkDontCreateNew.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbCancelingTypes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbCalendarFolderPaths.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.calendarTabPage.ResumeLayout(False)
			CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemDuration1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.logTabPage.ResumeLayout(False)
			CType(Me.lbcLog, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.panelControl1.PerformLayout()
			CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.schedulerBarController1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.navigationPane1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.navigationPane1.ResumeLayout(False)
			Me.navigationPage1.ResumeLayout(False)
			CType(Me.emptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents schedulerStorage As DevExpress.XtraScheduler.SchedulerStorage
		Private xpCollectionEvents As DevExpress.Xpo.XPCollection
		Private session1 As Session
		Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private calendarTabPage As DevExpress.XtraTab.XtraTabPage
		Private logTabPage As DevExpress.XtraTab.XtraTabPage
		Private schedulerControl As SchedulerControl
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private lbcLog As DevExpress.XtraEditors.ListBoxControl
		Private WithEvents btnClearLog As DevExpress.XtraEditors.SimpleButton
		Private cbCancelingTypes As DevExpress.XtraEditors.ImageComboBoxEdit
		Private chkDontDeleteExisting As DevExpress.XtraEditors.CheckEdit
		Private chkDontCreateNew As DevExpress.XtraEditors.CheckEdit
		Private chkDeleteInsteadReplace As DevExpress.XtraEditors.CheckEdit
		Private lbApplyTypes As DevExpress.XtraEditors.LabelControl
		Private WithEvents btnSynchronize As DevExpress.XtraEditors.SimpleButton
		Private lblLogInfo As DevExpress.XtraEditors.LabelControl
		Private components As System.ComponentModel.IContainer = Nothing
		Private cbCalendarFolderPaths As DevExpress.XtraEditors.ComboBoxEdit
		Friend ProgressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
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
		Private navigationPane1 As XtraBars.Navigation.NavigationPane
		Private navigationPage1 As XtraBars.Navigation.NavigationPage
		Private layoutControl1 As XtraLayout.LayoutControl
		Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
		Private layoutControlItem1 As XtraLayout.LayoutControlItem
		Private emptySpaceItem1 As XtraLayout.EmptySpaceItem
		Private emptySpaceItem2 As XtraLayout.EmptySpaceItem
		Private layoutControlItem2 As XtraLayout.LayoutControlItem
		Private layoutControlItem3 As XtraLayout.LayoutControlItem
		Private layoutControlItem4 As XtraLayout.LayoutControlItem
		Private layoutControlItem5 As XtraLayout.LayoutControlItem
		Private layoutControlItem6 As XtraLayout.LayoutControlItem
		Private emptySpaceItem3 As XtraLayout.EmptySpaceItem
		Private layoutControlItem7 As XtraLayout.LayoutControlItem
		Private emptySpaceItem4 As XtraLayout.EmptySpaceItem
	End Class
End Namespace

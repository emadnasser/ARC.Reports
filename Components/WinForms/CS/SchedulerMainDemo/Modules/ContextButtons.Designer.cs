using System;
using System.Windows.Forms;

namespace DevExpress.XtraScheduler.Demos {
    partial class ContextButtonsModule {
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing) {
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            this.schedulerControl = new DevExpress.XtraScheduler.SchedulerControl();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.openScheduleItem1 = new DevExpress.XtraScheduler.UI.OpenScheduleItem();
            this.saveScheduleItem1 = new DevExpress.XtraScheduler.UI.SaveScheduleItem();
            this.printPreviewItem1 = new DevExpress.XtraScheduler.UI.PrintPreviewItem();
            this.printItem1 = new DevExpress.XtraScheduler.UI.PrintItem();
            this.printPageSetupItem1 = new DevExpress.XtraScheduler.UI.PrintPageSetupItem();
            this.newAppointmentItem1 = new DevExpress.XtraScheduler.UI.NewAppointmentItem();
            this.newRecurringAppointmentItem1 = new DevExpress.XtraScheduler.UI.NewRecurringAppointmentItem();
            this.navigateViewBackwardItem1 = new DevExpress.XtraScheduler.UI.NavigateViewBackwardItem();
            this.navigateViewForwardItem1 = new DevExpress.XtraScheduler.UI.NavigateViewForwardItem();
            this.gotoTodayItem1 = new DevExpress.XtraScheduler.UI.GotoTodayItem();
            this.viewZoomInItem1 = new DevExpress.XtraScheduler.UI.ViewZoomInItem();
            this.viewZoomOutItem1 = new DevExpress.XtraScheduler.UI.ViewZoomOutItem();
            this.switchToDayViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToDayViewItem();
            this.switchToWorkWeekViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToWorkWeekViewItem();
            this.switchToWeekViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToWeekViewItem();
            this.switchToFullWeekViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToFullWeekViewItem();
            this.switchToMonthViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToMonthViewItem();
            this.switchToTimelineViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToTimelineViewItem();
            this.switchTimeScalesItem1 = new DevExpress.XtraScheduler.UI.SwitchTimeScalesItem();
            this.switchTimeScalesCaptionItem1 = new DevExpress.XtraScheduler.UI.SwitchTimeScalesCaptionItem();
            this.switchCompressWeekendItem1 = new DevExpress.XtraScheduler.UI.SwitchCompressWeekendItem();
            this.editAppointmentQueryItem1 = new DevExpress.XtraScheduler.UI.EditAppointmentQueryItem();
            this.editOccurrenceUICommandItem1 = new DevExpress.XtraScheduler.UI.EditOccurrenceUICommandItem();
            this.editSeriesUICommandItem1 = new DevExpress.XtraScheduler.UI.EditSeriesUICommandItem();
            this.deleteAppointmentsItem1 = new DevExpress.XtraScheduler.UI.DeleteAppointmentsItem();
            this.deleteOccurrenceItem1 = new DevExpress.XtraScheduler.UI.DeleteOccurrenceItem();
            this.deleteSeriesItem1 = new DevExpress.XtraScheduler.UI.DeleteSeriesItem();
            this.splitAppointmentItem1 = new DevExpress.XtraScheduler.UI.SplitAppointmentItem();
            this.changeAppointmentStatusItem1 = new DevExpress.XtraScheduler.UI.ChangeAppointmentStatusItem();
            this.changeAppointmentLabelItem1 = new DevExpress.XtraScheduler.UI.ChangeAppointmentLabelItem();
            this.toggleRecurrenceItem1 = new DevExpress.XtraScheduler.UI.ToggleRecurrenceItem();
            this.changeAppointmentReminderItem1 = new DevExpress.XtraScheduler.UI.ChangeAppointmentReminderItem();
            this.repositoryItemDuration1 = new DevExpress.XtraScheduler.UI.RepositoryItemDuration();
            this.calendarToolsRibbonPageCategory1 = new DevExpress.XtraScheduler.UI.CalendarToolsRibbonPageCategory();
            this.appointmentRibbonPage1 = new DevExpress.XtraScheduler.UI.AppointmentRibbonPage();
            this.actionsRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.ActionsRibbonPageGroup();
            this.optionsRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.OptionsRibbonPageGroup();
            this.fileRibbonPage1 = new DevExpress.XtraScheduler.UI.FileRibbonPage();
            this.commonRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.CommonRibbonPageGroup();
            this.printRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.PrintRibbonPageGroup();
            this.homeRibbonPage1 = new DevExpress.XtraScheduler.UI.HomeRibbonPage();
            this.appointmentRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.AppointmentRibbonPageGroup();
            this.navigatorRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.NavigatorRibbonPageGroup();
            this.arrangeRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.ArrangeRibbonPageGroup();
            this.viewRibbonPage1 = new DevExpress.XtraScheduler.UI.ViewRibbonPage();
            this.activeViewRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.ActiveViewRibbonPageGroup();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.schedulerStorage = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.panelControl = new DevExpress.XtraEditors.PanelControl();
            this.contextButtonOptionsGroup = new DevExpress.XtraEditors.GroupControl();
            this.chEditKeepInView = new DevExpress.XtraEditors.CheckEdit();
            this.contextButtonGroup = new DevExpress.XtraEditors.GroupControl();
            this.lbContextButtonAlignment = new DevExpress.XtraEditors.LabelControl();
            this.cbContextButtonAlignment = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.lbContextButtonVisibility = new DevExpress.XtraEditors.LabelControl();
            this.cbContextButtonVisibility = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.panelSeparatorControl = new DevExpress.XtraEditors.PanelControl();
            this.schedulerBarController1 = new DevExpress.XtraScheduler.UI.SchedulerBarController();
            this.timeScaleRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.TimeScaleRibbonPageGroup();
            this.changeScaleWidthItem1 = new DevExpress.XtraScheduler.UI.ChangeScaleWidthItem();
            this.groupByRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.GroupByRibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDuration1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contextButtonOptionsGroup)).BeginInit();
            this.contextButtonOptionsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chEditKeepInView.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextButtonGroup)).BeginInit();
            this.contextButtonGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbContextButtonAlignment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbContextButtonVisibility.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelSeparatorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBarController1)).BeginInit();
            this.SuspendLayout();
            // 
            // schedulerControl
            // 
            this.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl.Location = new System.Drawing.Point(0, 231);
            this.schedulerControl.MenuManager = this.ribbonControl1;
            this.schedulerControl.Name = "schedulerControl";
            //this.schedulerControl.OptionsAppointmentContextButtons.FarPanelPadding = new System.Windows.Forms.Padding(3);
            //this.schedulerControl.OptionsAppointmentContextButtons.TopPanelPadding = new System.Windows.Forms.Padding(3);
            this.schedulerControl.Size = new System.Drawing.Size(784, 315);
            this.schedulerControl.Start = new System.DateTime(2010, 7, 5, 0, 0, 0, 0);
            this.schedulerControl.DataStorage = this.schedulerStorage;
            this.schedulerControl.TabIndex = 0;
            this.schedulerControl.Text = "schedulerControl1";
            this.schedulerControl.Views.DayView.DayCount = 3;
            this.schedulerControl.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl.Views.FullWeekView.Enabled = true;
            this.schedulerControl.Views.GanttView.Enabled = false;
            this.schedulerControl.Views.WorkWeekView.TimeRulers.Add(timeRuler2);
            this.schedulerControl.PopupMenuShowing += new DevExpress.XtraScheduler.PopupMenuShowingEventHandler(this.schedulerControl_PopupMenuShowing);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.openScheduleItem1,
            this.saveScheduleItem1,
            this.printPreviewItem1,
            this.printItem1,
            this.printPageSetupItem1,
            this.newAppointmentItem1,
            this.newRecurringAppointmentItem1,
            this.navigateViewBackwardItem1,
            this.navigateViewForwardItem1,
            this.gotoTodayItem1,
            this.viewZoomInItem1,
            this.viewZoomOutItem1,
            this.switchToDayViewItem1,
            this.switchToWorkWeekViewItem1,
            this.switchToWeekViewItem1,
            this.switchToFullWeekViewItem1,
            this.switchToMonthViewItem1,
            this.switchToTimelineViewItem1,
            this.switchTimeScalesItem1,
            this.switchTimeScalesCaptionItem1,
            this.switchCompressWeekendItem1,
            this.editAppointmentQueryItem1,
            this.editOccurrenceUICommandItem1,
            this.editSeriesUICommandItem1,
            this.deleteAppointmentsItem1,
            this.deleteOccurrenceItem1,
            this.deleteSeriesItem1,
            this.splitAppointmentItem1,
            this.changeAppointmentStatusItem1,
            this.changeAppointmentLabelItem1,
            this.toggleRecurrenceItem1,
            this.changeAppointmentReminderItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 41;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.calendarToolsRibbonPageCategory1});
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.fileRibbonPage1,
            this.homeRibbonPage1,
            this.viewRibbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit1,
            this.repositoryItemDuration1});
            this.ribbonControl1.Size = new System.Drawing.Size(784, 141);
            // 
            // openScheduleItem1
            // 
            this.openScheduleItem1.Id = 1;
            this.openScheduleItem1.Name = "openScheduleItem1";
            // 
            // saveScheduleItem1
            // 
            this.saveScheduleItem1.Id = 2;
            this.saveScheduleItem1.Name = "saveScheduleItem1";
            // 
            // printPreviewItem1
            // 
            this.printPreviewItem1.Id = 3;
            this.printPreviewItem1.Name = "printPreviewItem1";
            // 
            // printItem1
            // 
            this.printItem1.Id = 4;
            this.printItem1.Name = "printItem1";
            // 
            // printPageSetupItem1
            // 
            this.printPageSetupItem1.Id = 5;
            this.printPageSetupItem1.Name = "printPageSetupItem1";
            // 
            // newAppointmentItem1
            // 
            this.newAppointmentItem1.Id = 6;
            this.newAppointmentItem1.Name = "newAppointmentItem1";
            // 
            // newRecurringAppointmentItem1
            // 
            this.newRecurringAppointmentItem1.Id = 7;
            this.newRecurringAppointmentItem1.Name = "newRecurringAppointmentItem1";
            // 
            // navigateViewBackwardItem1
            // 
            this.navigateViewBackwardItem1.Id = 8;
            this.navigateViewBackwardItem1.Name = "navigateViewBackwardItem1";
            // 
            // navigateViewForwardItem1
            // 
            this.navigateViewForwardItem1.Id = 9;
            this.navigateViewForwardItem1.Name = "navigateViewForwardItem1";
            // 
            // gotoTodayItem1
            // 
            this.gotoTodayItem1.Id = 10;
            this.gotoTodayItem1.Name = "gotoTodayItem1";
            // 
            // viewZoomInItem1
            // 
            this.viewZoomInItem1.Id = 11;
            this.viewZoomInItem1.Name = "viewZoomInItem1";
            // 
            // viewZoomOutItem1
            // 
            this.viewZoomOutItem1.Id = 12;
            this.viewZoomOutItem1.Name = "viewZoomOutItem1";
            // 
            // switchToDayViewItem1
            // 
            this.switchToDayViewItem1.Id = 13;
            this.switchToDayViewItem1.Name = "switchToDayViewItem1";
            // 
            // switchToWorkWeekViewItem1
            // 
            this.switchToWorkWeekViewItem1.Id = 14;
            this.switchToWorkWeekViewItem1.Name = "switchToWorkWeekViewItem1";
            // 
            // switchToWeekViewItem1
            // 
            this.switchToWeekViewItem1.Id = 15;
            this.switchToWeekViewItem1.Name = "switchToWeekViewItem1";
            // 
            // switchToFullWeekViewItem1
            // 
            this.switchToFullWeekViewItem1.Id = 16;
            this.switchToFullWeekViewItem1.Name = "switchToFullWeekViewItem1";
            // 
            // switchToMonthViewItem1
            // 
            this.switchToMonthViewItem1.Id = 17;
            this.switchToMonthViewItem1.Name = "switchToMonthViewItem1";
            // 
            // switchToTimelineViewItem1
            // 
            this.switchToTimelineViewItem1.Id = 18;
            this.switchToTimelineViewItem1.Name = "switchToTimelineViewItem1";
            // 
            // switchTimeScalesItem1
            // 
            this.switchTimeScalesItem1.Id = 23;
            this.switchTimeScalesItem1.Name = "switchTimeScalesItem1";
            // 
            // switchTimeScalesCaptionItem1
            // 
            this.switchTimeScalesCaptionItem1.Id = 25;
            this.switchTimeScalesCaptionItem1.Name = "switchTimeScalesCaptionItem1";
            // 
            // switchCompressWeekendItem1
            // 
            this.switchCompressWeekendItem1.Id = 26;
            this.switchCompressWeekendItem1.Name = "switchCompressWeekendItem1";
            // 
            // editAppointmentQueryItem1
            // 
            this.editAppointmentQueryItem1.Id = 30;
            this.editAppointmentQueryItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.editOccurrenceUICommandItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.editSeriesUICommandItem1)});
            this.editAppointmentQueryItem1.Name = "editAppointmentQueryItem1";
            this.editAppointmentQueryItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // editOccurrenceUICommandItem1
            // 
            this.editOccurrenceUICommandItem1.Id = 31;
            this.editOccurrenceUICommandItem1.Name = "editOccurrenceUICommandItem1";
            // 
            // editSeriesUICommandItem1
            // 
            this.editSeriesUICommandItem1.Id = 32;
            this.editSeriesUICommandItem1.Name = "editSeriesUICommandItem1";
            // 
            // deleteAppointmentsItem1
            // 
            this.deleteAppointmentsItem1.Id = 33;
            this.deleteAppointmentsItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.deleteOccurrenceItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.deleteSeriesItem1)});
            this.deleteAppointmentsItem1.Name = "deleteAppointmentsItem1";
            this.deleteAppointmentsItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // deleteOccurrenceItem1
            // 
            this.deleteOccurrenceItem1.Id = 34;
            this.deleteOccurrenceItem1.Name = "deleteOccurrenceItem1";
            // 
            // deleteSeriesItem1
            // 
            this.deleteSeriesItem1.Id = 35;
            this.deleteSeriesItem1.Name = "deleteSeriesItem1";
            // 
            // splitAppointmentItem1
            // 
            this.splitAppointmentItem1.Id = 36;
            this.splitAppointmentItem1.Name = "splitAppointmentItem1";
            // 
            // changeAppointmentStatusItem1
            // 
            this.changeAppointmentStatusItem1.Id = 37;
            this.changeAppointmentStatusItem1.Name = "changeAppointmentStatusItem1";
            // 
            // changeAppointmentLabelItem1
            // 
            this.changeAppointmentLabelItem1.Id = 38;
            this.changeAppointmentLabelItem1.Name = "changeAppointmentLabelItem1";
            // 
            // toggleRecurrenceItem1
            // 
            this.toggleRecurrenceItem1.Id = 39;
            this.toggleRecurrenceItem1.Name = "toggleRecurrenceItem1";
            // 
            // changeAppointmentReminderItem1
            // 
            this.changeAppointmentReminderItem1.Edit = this.repositoryItemDuration1;
            this.changeAppointmentReminderItem1.Id = 40;
            this.changeAppointmentReminderItem1.Name = "changeAppointmentReminderItem1";
            // 
            // repositoryItemDuration1
            // 
            this.repositoryItemDuration1.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemDuration1.AutoHeight = false;
            this.repositoryItemDuration1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDuration1.DisabledStateText = null;
            this.repositoryItemDuration1.Name = "repositoryItemDuration1";
            this.repositoryItemDuration1.NullValuePromptShowForEmptyValue = true;
            this.repositoryItemDuration1.ShowEmptyItem = true;
            this.repositoryItemDuration1.ValidateOnEnterKey = true;
            // 
            // calendarToolsRibbonPageCategory1
            // 
            this.calendarToolsRibbonPageCategory1.Control = this.schedulerControl;
            this.calendarToolsRibbonPageCategory1.Name = "calendarToolsRibbonPageCategory1";
            this.calendarToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.appointmentRibbonPage1});
            this.calendarToolsRibbonPageCategory1.Visible = false;
            // 
            // appointmentRibbonPage1
            // 
            this.appointmentRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.actionsRibbonPageGroup1,
            this.optionsRibbonPageGroup1});
            this.appointmentRibbonPage1.Name = "appointmentRibbonPage1";
            this.appointmentRibbonPage1.Visible = false;
            // 
            // actionsRibbonPageGroup1
            // 
            this.actionsRibbonPageGroup1.ItemLinks.Add(this.editAppointmentQueryItem1);
            this.actionsRibbonPageGroup1.ItemLinks.Add(this.deleteAppointmentsItem1);
            this.actionsRibbonPageGroup1.ItemLinks.Add(this.splitAppointmentItem1);
            this.actionsRibbonPageGroup1.Name = "actionsRibbonPageGroup1";
            // 
            // optionsRibbonPageGroup1
            // 
            this.optionsRibbonPageGroup1.ItemLinks.Add(this.changeAppointmentStatusItem1);
            this.optionsRibbonPageGroup1.ItemLinks.Add(this.changeAppointmentLabelItem1);
            this.optionsRibbonPageGroup1.ItemLinks.Add(this.toggleRecurrenceItem1);
            this.optionsRibbonPageGroup1.ItemLinks.Add(this.changeAppointmentReminderItem1);
            this.optionsRibbonPageGroup1.Name = "optionsRibbonPageGroup1";
            // 
            // fileRibbonPage1
            // 
            this.fileRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.commonRibbonPageGroup1,
            this.printRibbonPageGroup1});
            this.fileRibbonPage1.Name = "fileRibbonPage1";
            // 
            // commonRibbonPageGroup1
            // 
            this.commonRibbonPageGroup1.ItemLinks.Add(this.openScheduleItem1);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.saveScheduleItem1);
            this.commonRibbonPageGroup1.Name = "commonRibbonPageGroup1";
            // 
            // printRibbonPageGroup1
            // 
            this.printRibbonPageGroup1.ItemLinks.Add(this.printPreviewItem1);
            this.printRibbonPageGroup1.ItemLinks.Add(this.printItem1);
            this.printRibbonPageGroup1.ItemLinks.Add(this.printPageSetupItem1);
            this.printRibbonPageGroup1.Name = "printRibbonPageGroup1";
            // 
            // homeRibbonPage1
            // 
            this.homeRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.appointmentRibbonPageGroup1,
            this.navigatorRibbonPageGroup1,
            this.arrangeRibbonPageGroup1});
            this.homeRibbonPage1.Name = "homeRibbonPage1";
            // 
            // appointmentRibbonPageGroup1
            // 
            this.appointmentRibbonPageGroup1.ItemLinks.Add(this.newAppointmentItem1);
            this.appointmentRibbonPageGroup1.ItemLinks.Add(this.newRecurringAppointmentItem1);
            this.appointmentRibbonPageGroup1.Name = "appointmentRibbonPageGroup1";
            // 
            // navigatorRibbonPageGroup1
            // 
            this.navigatorRibbonPageGroup1.ItemLinks.Add(this.navigateViewBackwardItem1);
            this.navigatorRibbonPageGroup1.ItemLinks.Add(this.navigateViewForwardItem1);
            this.navigatorRibbonPageGroup1.ItemLinks.Add(this.gotoTodayItem1);
            this.navigatorRibbonPageGroup1.ItemLinks.Add(this.viewZoomInItem1);
            this.navigatorRibbonPageGroup1.ItemLinks.Add(this.viewZoomOutItem1);
            this.navigatorRibbonPageGroup1.Name = "navigatorRibbonPageGroup1";
            // 
            // arrangeRibbonPageGroup1
            // 
            this.arrangeRibbonPageGroup1.ItemLinks.Add(this.switchToDayViewItem1);
            this.arrangeRibbonPageGroup1.ItemLinks.Add(this.switchToWorkWeekViewItem1);
            this.arrangeRibbonPageGroup1.ItemLinks.Add(this.switchToWeekViewItem1);
            this.arrangeRibbonPageGroup1.ItemLinks.Add(this.switchToFullWeekViewItem1);
            this.arrangeRibbonPageGroup1.ItemLinks.Add(this.switchToMonthViewItem1);
            this.arrangeRibbonPageGroup1.ItemLinks.Add(this.switchToTimelineViewItem1);
            this.arrangeRibbonPageGroup1.Name = "arrangeRibbonPageGroup1";
            // 
            // viewRibbonPage1
            // 
            this.viewRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.activeViewRibbonPageGroup1});
            this.viewRibbonPage1.Name = "viewRibbonPage1";
            // 
            // activeViewRibbonPageGroup1
            // 
            this.activeViewRibbonPageGroup1.ItemLinks.Add(this.switchToDayViewItem1);
            this.activeViewRibbonPageGroup1.ItemLinks.Add(this.switchToWorkWeekViewItem1);
            this.activeViewRibbonPageGroup1.ItemLinks.Add(this.switchToWeekViewItem1);
            this.activeViewRibbonPageGroup1.ItemLinks.Add(this.switchToFullWeekViewItem1);
            this.activeViewRibbonPageGroup1.ItemLinks.Add(this.switchToMonthViewItem1);
            this.activeViewRibbonPageGroup1.ItemLinks.Add(this.switchToTimelineViewItem1);
            this.activeViewRibbonPageGroup1.Name = "activeViewRibbonPageGroup1";
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.repositoryItemSpinEdit1.MaxValue = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.repositoryItemSpinEdit1.MinValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.contextButtonOptionsGroup);
            this.panelControl.Controls.Add(this.contextButtonGroup);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl.Location = new System.Drawing.Point(0, 141);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(784, 82);
            this.panelControl.TabIndex = 2;
            // 
            // contextButtonOptionsGroup
            // 
            this.contextButtonOptionsGroup.Controls.Add(this.chEditKeepInView);
            this.contextButtonOptionsGroup.Location = new System.Drawing.Point(215, 1);
            this.contextButtonOptionsGroup.Name = "contextButtonOptionsGroup";
            this.contextButtonOptionsGroup.Size = new System.Drawing.Size(156, 75);
            this.contextButtonOptionsGroup.TabIndex = 94;
            this.contextButtonOptionsGroup.Text = "ContextButtonOptions";
            // 
            // chEditKeepInView
            // 
            this.chEditKeepInView.Location = new System.Drawing.Point(5, 21);
            this.chEditKeepInView.MenuManager = this;
            this.chEditKeepInView.Name = "chEditKeepInView";
            this.chEditKeepInView.Properties.Caption = "KeepInView";
            this.chEditKeepInView.Size = new System.Drawing.Size(75, 19);
            this.chEditKeepInView.TabIndex = 93;
            this.chEditKeepInView.CheckedChanged += new System.EventHandler(this.chEditKeepInView_CheckedChanged);
            // 
            // contextButtonGroup
            // 
            this.contextButtonGroup.Controls.Add(this.lbContextButtonAlignment);
            this.contextButtonGroup.Controls.Add(this.cbContextButtonAlignment);
            this.contextButtonGroup.Controls.Add(this.lbContextButtonVisibility);
            this.contextButtonGroup.Controls.Add(this.cbContextButtonVisibility);
            this.contextButtonGroup.Location = new System.Drawing.Point(3, 1);
            this.contextButtonGroup.Name = "contextButtonGroup";
            this.contextButtonGroup.Size = new System.Drawing.Size(206, 75);
            this.contextButtonGroup.TabIndex = 92;
            this.contextButtonGroup.Text = "ContextButtons";
            // 
            // lbContextButtonAlignment
            // 
            this.lbContextButtonAlignment.Location = new System.Drawing.Point(6, 52);
            this.lbContextButtonAlignment.Name = "lbContextButtonAlignment";
            this.lbContextButtonAlignment.Size = new System.Drawing.Size(47, 13);
            this.lbContextButtonAlignment.TabIndex = 3;
            this.lbContextButtonAlignment.Text = "Alignment";
            // 
            // cbContextButtonAlignment
            // 
            this.cbContextButtonAlignment.Location = new System.Drawing.Point(63, 49);
            this.cbContextButtonAlignment.MenuManager = this;
            this.cbContextButtonAlignment.Name = "cbContextButtonAlignment";
            this.cbContextButtonAlignment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbContextButtonAlignment.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("BottomFar", DevExpress.Utils.ContextItemAlignment.BottomFar, 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("BottomNear", DevExpress.Utils.ContextItemAlignment.BottomNear, 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Center", DevExpress.Utils.ContextItemAlignment.Center, 2),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("CenterFar", DevExpress.Utils.ContextItemAlignment.CenterFar, 3),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("CenterNear", DevExpress.Utils.ContextItemAlignment.CenterNear, 4),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("FarBottom", DevExpress.Utils.ContextItemAlignment.FarBottom, 5),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("FarCenter", DevExpress.Utils.ContextItemAlignment.FarCenter, 6),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("FarTop", DevExpress.Utils.ContextItemAlignment.FarTop, 7),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("MiddleBottom", DevExpress.Utils.ContextItemAlignment.MiddleBottom, 8),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("MiddleTop", DevExpress.Utils.ContextItemAlignment.MiddleTop, 9),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("NearBottom", DevExpress.Utils.ContextItemAlignment.NearBottom, 10),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("NearCenter", DevExpress.Utils.ContextItemAlignment.NearCenter, 11),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("NearTop", DevExpress.Utils.ContextItemAlignment.NearTop, 12),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("TopFar", DevExpress.Utils.ContextItemAlignment.TopFar, 13),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("TopNear", DevExpress.Utils.ContextItemAlignment.TopNear, 14)});
            this.cbContextButtonAlignment.Size = new System.Drawing.Size(130, 20);
            this.cbContextButtonAlignment.TabIndex = 2;
            this.cbContextButtonAlignment.SelectedIndexChanged += new System.EventHandler(this.cbContextButtonAlignment_SelectedIndexChanged);
            // 
            // lbContextButtonVisibility
            // 
            this.lbContextButtonVisibility.Location = new System.Drawing.Point(6, 26);
            this.lbContextButtonVisibility.Name = "lbContextButtonVisibility";
            this.lbContextButtonVisibility.Size = new System.Drawing.Size(37, 13);
            this.lbContextButtonVisibility.TabIndex = 1;
            this.lbContextButtonVisibility.Text = "Visibility";
            // 
            // cbContextButtonVisibility
            // 
            this.cbContextButtonVisibility.Location = new System.Drawing.Point(63, 23);
            this.cbContextButtonVisibility.MenuManager = this;
            this.cbContextButtonVisibility.Name = "cbContextButtonVisibility";
            this.cbContextButtonVisibility.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbContextButtonVisibility.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Auto", DevExpress.Utils.ContextItemVisibility.Auto, 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Hidden", DevExpress.Utils.ContextItemVisibility.Hidden, 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Visible", DevExpress.Utils.ContextItemVisibility.Visible, 2)});
            this.cbContextButtonVisibility.Size = new System.Drawing.Size(130, 20);
            this.cbContextButtonVisibility.TabIndex = 0;
            this.cbContextButtonVisibility.SelectedIndexChanged += new System.EventHandler(this.cbOpenContextButtonVisibility_SelectedIndexChanged);
            // 
            // panelSeparatorControl
            // 
            this.panelSeparatorControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelSeparatorControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSeparatorControl.Location = new System.Drawing.Point(0, 223);
            this.panelSeparatorControl.Name = "panelSeparatorControl";
            this.panelSeparatorControl.Size = new System.Drawing.Size(784, 8);
            this.panelSeparatorControl.TabIndex = 9;
            // 
            // schedulerBarController1
            // 
            this.schedulerBarController1.BarItems.Add(this.openScheduleItem1);
            this.schedulerBarController1.BarItems.Add(this.saveScheduleItem1);
            this.schedulerBarController1.BarItems.Add(this.printPreviewItem1);
            this.schedulerBarController1.BarItems.Add(this.printItem1);
            this.schedulerBarController1.BarItems.Add(this.printPageSetupItem1);
            this.schedulerBarController1.BarItems.Add(this.newAppointmentItem1);
            this.schedulerBarController1.BarItems.Add(this.newRecurringAppointmentItem1);
            this.schedulerBarController1.BarItems.Add(this.navigateViewBackwardItem1);
            this.schedulerBarController1.BarItems.Add(this.navigateViewForwardItem1);
            this.schedulerBarController1.BarItems.Add(this.gotoTodayItem1);
            this.schedulerBarController1.BarItems.Add(this.viewZoomInItem1);
            this.schedulerBarController1.BarItems.Add(this.viewZoomOutItem1);
            this.schedulerBarController1.BarItems.Add(this.switchToDayViewItem1);
            this.schedulerBarController1.BarItems.Add(this.switchToWorkWeekViewItem1);
            this.schedulerBarController1.BarItems.Add(this.switchToWeekViewItem1);
            this.schedulerBarController1.BarItems.Add(this.switchToFullWeekViewItem1);
            this.schedulerBarController1.BarItems.Add(this.switchToMonthViewItem1);
            this.schedulerBarController1.BarItems.Add(this.switchToTimelineViewItem1);
            this.schedulerBarController1.BarItems.Add(this.switchTimeScalesItem1);
            this.schedulerBarController1.BarItems.Add(this.switchTimeScalesCaptionItem1);
            this.schedulerBarController1.BarItems.Add(this.switchCompressWeekendItem1);
            this.schedulerBarController1.BarItems.Add(this.editAppointmentQueryItem1);
            this.schedulerBarController1.BarItems.Add(this.editOccurrenceUICommandItem1);
            this.schedulerBarController1.BarItems.Add(this.editSeriesUICommandItem1);
            this.schedulerBarController1.BarItems.Add(this.deleteAppointmentsItem1);
            this.schedulerBarController1.BarItems.Add(this.deleteOccurrenceItem1);
            this.schedulerBarController1.BarItems.Add(this.deleteSeriesItem1);
            this.schedulerBarController1.BarItems.Add(this.splitAppointmentItem1);
            this.schedulerBarController1.BarItems.Add(this.changeAppointmentStatusItem1);
            this.schedulerBarController1.BarItems.Add(this.changeAppointmentLabelItem1);
            this.schedulerBarController1.BarItems.Add(this.toggleRecurrenceItem1);
            this.schedulerBarController1.BarItems.Add(this.changeAppointmentReminderItem1);
            this.schedulerBarController1.Control = this.schedulerControl;
            // 
            // timeScaleRibbonPageGroup1
            // 
            this.timeScaleRibbonPageGroup1.ItemLinks.Add(this.switchTimeScalesItem1);
            this.timeScaleRibbonPageGroup1.Name = "timeScaleRibbonPageGroup1";
            this.timeScaleRibbonPageGroup1.Text = "";
            // 
            // changeScaleWidthItem1
            // 
            this.changeScaleWidthItem1.Edit = this.repositoryItemSpinEdit1;
            this.changeScaleWidthItem1.Id = 24;
            this.changeScaleWidthItem1.Name = "changeScaleWidthItem1";
            this.changeScaleWidthItem1.UseCommandCaption = true;
            // 
            // groupByRibbonPageGroup1
            // 
            this.groupByRibbonPageGroup1.Name = "groupByRibbonPageGroup1";
            this.groupByRibbonPageGroup1.Text = "";
            // 
            // ContextButtonsModule
            // 
            this.Controls.Add(this.schedulerControl);
            this.Controls.Add(this.panelSeparatorControl);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "ContextButtonsModule";
            this.Size = new System.Drawing.Size(784, 546);
            this.Load += new System.EventHandler(this.ContextButtonsModule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDuration1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
            this.panelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contextButtonOptionsGroup)).EndInit();
            this.contextButtonOptionsGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chEditKeepInView.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextButtonGroup)).EndInit();
            this.contextButtonGroup.ResumeLayout(false);
            this.contextButtonGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbContextButtonAlignment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbContextButtonVisibility.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelSeparatorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBarController1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
        private  DevExpress.XtraScheduler.SchedulerControl schedulerControl;
        private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage;
        private DevExpress.XtraEditors.PanelControl panelControl;
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.PanelControl panelSeparatorControl;
        private UI.SchedulerBarController schedulerBarController1;
        private XtraEditors.GroupControl contextButtonGroup;
        private XtraBars.Ribbon.RibbonControl ribbonControl1;
        private UI.OpenScheduleItem openScheduleItem1;
        private UI.SaveScheduleItem saveScheduleItem1;
        private UI.PrintPreviewItem printPreviewItem1;
        private UI.PrintItem printItem1;
        private UI.PrintPageSetupItem printPageSetupItem1;
        private UI.NewAppointmentItem newAppointmentItem1;
        private UI.NewRecurringAppointmentItem newRecurringAppointmentItem1;
        private UI.NavigateViewBackwardItem navigateViewBackwardItem1;
        private UI.NavigateViewForwardItem navigateViewForwardItem1;
        private UI.GotoTodayItem gotoTodayItem1;
        private UI.ViewZoomInItem viewZoomInItem1;
        private UI.ViewZoomOutItem viewZoomOutItem1;
        private UI.SwitchToDayViewItem switchToDayViewItem1;
        private UI.SwitchToWorkWeekViewItem switchToWorkWeekViewItem1;
        private UI.SwitchToWeekViewItem switchToWeekViewItem1;
        private UI.SwitchToFullWeekViewItem switchToFullWeekViewItem1;
        private UI.SwitchToMonthViewItem switchToMonthViewItem1;
        private UI.SwitchToTimelineViewItem switchToTimelineViewItem1;
        private UI.SwitchTimeScalesItem switchTimeScalesItem1;
        private XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private UI.SwitchTimeScalesCaptionItem switchTimeScalesCaptionItem1;
        private UI.SwitchCompressWeekendItem switchCompressWeekendItem1;
        private UI.EditAppointmentQueryItem editAppointmentQueryItem1;
        private UI.EditOccurrenceUICommandItem editOccurrenceUICommandItem1;
        private UI.EditSeriesUICommandItem editSeriesUICommandItem1;
        private UI.DeleteAppointmentsItem deleteAppointmentsItem1;
        private UI.DeleteOccurrenceItem deleteOccurrenceItem1;
        private UI.DeleteSeriesItem deleteSeriesItem1;
        private UI.SplitAppointmentItem splitAppointmentItem1;
        private UI.ChangeAppointmentStatusItem changeAppointmentStatusItem1;
        private UI.ChangeAppointmentLabelItem changeAppointmentLabelItem1;
        private UI.ToggleRecurrenceItem toggleRecurrenceItem1;
        private UI.ChangeAppointmentReminderItem changeAppointmentReminderItem1;
        private UI.RepositoryItemDuration repositoryItemDuration1;
        private UI.CalendarToolsRibbonPageCategory calendarToolsRibbonPageCategory1;
        private UI.AppointmentRibbonPage appointmentRibbonPage1;
        private UI.ActionsRibbonPageGroup actionsRibbonPageGroup1;
        private UI.OptionsRibbonPageGroup optionsRibbonPageGroup1;
        private UI.FileRibbonPage fileRibbonPage1;
        private UI.CommonRibbonPageGroup commonRibbonPageGroup1;
        private UI.PrintRibbonPageGroup printRibbonPageGroup1;
        private UI.HomeRibbonPage homeRibbonPage1;
        private UI.AppointmentRibbonPageGroup appointmentRibbonPageGroup1;
        private UI.NavigatorRibbonPageGroup navigatorRibbonPageGroup1;
        private UI.ArrangeRibbonPageGroup arrangeRibbonPageGroup1;
        private UI.ViewRibbonPage viewRibbonPage1;
        private UI.ActiveViewRibbonPageGroup activeViewRibbonPageGroup1;
        private UI.TimeScaleRibbonPageGroup timeScaleRibbonPageGroup1;
        private UI.ChangeScaleWidthItem changeScaleWidthItem1;
        private UI.GroupByRibbonPageGroup groupByRibbonPageGroup1;
        private XtraEditors.CheckEdit chEditKeepInView;
        private XtraEditors.LabelControl lbContextButtonVisibility;
        private XtraEditors.ImageComboBoxEdit cbContextButtonVisibility;
        private XtraEditors.GroupControl contextButtonOptionsGroup;
        private XtraEditors.LabelControl lbContextButtonAlignment;
        private XtraEditors.ImageComboBoxEdit cbContextButtonAlignment;

	}
}

using System;
using DevExpress.XtraScheduler;
using DevExpress.Web.ASPxScheduler;
using System.Threading;

public partial class ViewTypes_WorkWeekView : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        /*
            The following code utilizes the DataHelper class, which is implemented
            solely for the ASPxScheduler Demo project.
            It is intended to hide unnecessary details and clarify the main idea.
            For the recommended data binding techniques, please refer to the
            Data Binding section modules:
              ~/DataBinding/BoundMode.aspx for MS Access database
              ~/DataBinding/ListBoundMode.aspx for the object with IBindingList interface.
              ~/DataBinding/XPOBoundMode.aspx for XPO data framework.
        */
        SchedulerDemoUtils.ApplyDefaults(this, ASPxScheduler1);
        DataHelper.SetupDefaultMappings(ASPxScheduler1);
        DataHelper.ProvideRowInsertion(ASPxScheduler1, AppointmentDataSource);
        DataHelper.SetupStatuses(ASPxScheduler1);
        DataHelper.SetupLabels(ASPxScheduler1);
        ApplyWorkDays();
        ASPxScheduler1.DataBind();
    }

    void ApplyWorkDays() {
        WeekDays weekDays = (WeekDays)0;

        if(chkSunday.Checked)
            weekDays |= WeekDays.Sunday;
        if(chkMonday.Checked)
            weekDays |= WeekDays.Monday;
        if(chkTuesday.Checked)
            weekDays |= WeekDays.Tuesday;
        if(chkWednesday.Checked)
            weekDays |= WeekDays.Wednesday;
        if(chkThursday.Checked)
            weekDays |= WeekDays.Thursday;
        if(chkFriday.Checked)
            weekDays |= WeekDays.Friday;
        if(chkSaturday.Checked)
            weekDays |= WeekDays.Saturday;

        ASPxScheduler1.BeginUpdate();
        try {
            WorkDaysCollection workDays = ASPxScheduler1.WorkDays;
            workDays.Clear();
            workDays.Add(weekDays);
        } finally {
            ASPxScheduler1.EndUpdate();
        }

        ASPxScheduler1.WorkWeekView.TimeIndicatorDisplayOptions.Visibility = (TimeIndicatorVisibility)cbTimeIndicatorVisibility.Value;
        ASPxScheduler1.WorkWeekView.TimeMarkerVisibility = (TimeMarkerVisibility)cbTimeMarkerVisibility.Value;
        ApplyCommonOptions();
        ASPxScheduler1.ApplyChanges(ASPxSchedulerChangeAction.NotifyVisibleIntervalsChanged);
    }

    void ApplyCommonOptions() {
        ASPxScheduler1.OptionsBehavior.HighlightSelectionHeaders = HighlightSelectionCheckBox.Checked;
        ASPxScheduler1.OptionsView.AppointmentSelectionAppearanceMode = (AppointmentSelectionAppearanceMode)SelectionAppearanceModeComboBox.Value;
        ASPxScheduler1.OptionsBehavior.ShowViewNavigator = ShowViewNavigatorCheckBox.Checked;
        ASPxScheduler1.OptionsBehavior.ShowViewVisibleInterval = ShowViewVisibleIntervalCheckBox.Checked;
    }
}

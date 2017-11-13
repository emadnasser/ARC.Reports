using System;
using DevExpress.Web.ASPxScheduler;

public partial class ViewTypes_MonthView : System.Web.UI.Page {
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
        ApplyOptions();
        ASPxScheduler1.DataBind();
    }
    void ApplyOptions() {
        ASPxScheduler1.BeginUpdate();
        try {
            DevExpress.Web.ASPxScheduler.MonthView monthView = ASPxScheduler1.MonthView;
            monthView.ShowWeekend = chkShowWeekend.Checked;
            monthView.CompressWeekend = chkCompressWeekend.Checked;
            monthView.ShowMoreButtons = chkShowMoreButtons.Checked;
            monthView.WeekCount = (int)cbWeekCount.Value;
        } finally {
            ASPxScheduler1.EndUpdate();
        }
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

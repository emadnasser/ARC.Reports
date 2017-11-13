using System;
using DevExpress.Web.ASPxScheduler;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Native;

public partial class Miscellaneous_TimeZones : System.Web.UI.Page {
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
        SchedulerDemoUtils.ApplyWorkTime(this, ASPxScheduler1);
        DataHelper.SetupDefaultMappings(ASPxScheduler1);
        DataHelper.ProvideRowInsertion(ASPxScheduler1, AppointmentDataSource);
        DataHelper.SetupStatuses(ASPxScheduler1);
        DataHelper.SetupLabels(ASPxScheduler1);
        ASPxScheduler1.DataBind();

        UpdateTimeRulers();
    }
    protected void ASPxScheduler1_AfterExecuteCallbackCommand(object sender, SchedulerCallbackCommandEventArgs e) {
        if(e.CommandId == SchedulerCallbackCommandId.ChangeTimeZone)
            UpdateTimeRulers();
    }
    void UpdateTimeRulers() {
        ASPxScheduler1.BeginUpdate();
        try {
            UpdateClientTimeRuler(ASPxScheduler1.DayView);
            UpdateClientTimeRuler(ASPxScheduler1.WorkWeekView);
            UpdateClientTimeRuler(ASPxScheduler1.FullWeekView);
            UpdateServerTimeRuler(ASPxScheduler1.DayView);
            UpdateServerTimeRuler(ASPxScheduler1.WorkWeekView);
            UpdateServerTimeRuler(ASPxScheduler1.FullWeekView);
        } finally {
            ASPxScheduler1.EndUpdate();
        }
    }
    void UpdateClientTimeRuler(DevExpress.Web.ASPxScheduler.DayView view) {
        TimeRuler ruler = view.TimeRulers[2];
        string tzId = ASPxScheduler1.OptionsBehavior.ClientTimeZoneId;
        TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById(tzId);
        ruler.TimeZoneId = tzId;
        ruler.Caption = String.Format("Client: {0}", tzi.DisplayName);
    }
    void UpdateServerTimeRuler(DevExpress.Web.ASPxScheduler.DayView view) {
        TimeRuler ruler = view.TimeRulers[1];
        ruler.TimeZoneId = TimeZoneInfo.Local.Id;
    }
}

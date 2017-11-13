using System;
using System.Web.UI;
using DevExpress.Web.ASPxScheduler;
using DevExpress.Web.ASPxScheduler.Internal;
using DevExpress.XtraScheduler;

public partial class Miscellaneous_Reminders : System.Web.UI.Page {
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
        DataHelper.SetupCustomEventsMappings(ASPxScheduler1);
        DataHelper.ProvideRowInsertion(ASPxScheduler1, schedulerDataSource.AppointmentDataSource);
        schedulerDataSource.AttachTo(ASPxScheduler1);
    }
    protected void SPxScheduler1_OnBeforeExecuteCallbackCommand(object sender, SchedulerCallbackCommandEventArgs e) {
        if(e.CommandId == "CREATAPTWR")
            e.Command = new CreateAppointmentWithReminderCallbackCommand(ASPxScheduler1);
    }
}

#region CreateAppointmentWithReminderCallbackCommand
public class CreateAppointmentWithReminderCallbackCommand : SchedulerCallbackCommand {
    public CreateAppointmentWithReminderCallbackCommand(ASPxScheduler control)
        : base(control) {
    }

    public override string Id { get { return "CREATAPTWR"; } }
    public override bool RequiresControlHierarchy { get { return true; } }

    protected override void ParseParameters(string parameters) {
        // do nothing
    }
    protected override void ExecuteCore() {
        DateTime nowTime = DateTime.Now;
        DateTime now = new DateTime(nowTime.Year, nowTime.Month, nowTime.Day, nowTime.Hour, nowTime.Minute, nowTime.Second);
        now = now + TimeSpan.FromMinutes(5) + TimeSpan.FromSeconds(5);
        Appointment apt = Control.Storage.CreateAppointment(AppointmentType.Normal);
        apt.Start = now;
        apt.Duration = TimeSpan.FromHours(2);
        apt.Subject = "Appointment with Reminder";
        apt.HasReminder = true;
        apt.Reminder.TimeBeforeStart = TimeSpan.FromMinutes(5);
        apt.ResourceId = EmptyResourceId.Id;
        apt.StatusKey = (int)AppointmentStatusType.Busy;
        apt.LabelKey = 1;
        Control.Storage.Appointments.Add(apt);
        Control.Start = DateTime.Today;
    }
}
#endregion

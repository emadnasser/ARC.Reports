using System;
using System.Web.UI;
using DevExpress.Schedule;
using DevExpress.Web.ASPxScheduler;
using DevExpress.Web.ASPxScheduler.Internal;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Native;

public partial class Miscellaneous_Holidays : System.Web.UI.Page {
    protected bool IsLocationSelected { get { return cbLocation.SelectedIndex > 0; } }
    protected string SelectedLocation { get { return cbLocation.Text; } }

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
        DataHelper.ProvideRowInsertion(ASPxScheduler1, DataSource1.AppointmentDataSource);
        DataSource1.AttachTo(ASPxScheduler1);

        if (IsLocationSelected) {
            HolidayBaseCollection holidays = SchedulerDemoUtils.LoadHolidaysFromXml(Page.MapPath("~/App_Data/holidays.xml"), SelectedLocation);
            AddHolidaysToScheduler(holidays);
            btnGenerate.ClientEnabled = true;
            btnClear.ClientEnabled = true;
        }
        if (!IsPostBack) {
            Clear();
            GenerateDefaultAppointmentsHolidays();
            AppointmentBaseCollection appointments = ASPxScheduler1.Storage.GetAppointments(DateTime.Now, DateTime.Now.AddMonths(6));
            appointments.Sort(new AppointmentStartDateComparer());
            if (appointments.Count > 0)
                ASPxScheduler1.Start = appointments[0].Start;
        }

        ASPxScheduler1.ApplyChanges(ASPxSchedulerChangeAction.RenderAppointments | ASPxSchedulerChangeAction.NotifyVisibleIntervalsChanged);
    }

    private void Clear() {
        HolidaysClearCallbackCommand command = new HolidaysClearCallbackCommand(ASPxScheduler1);
        command.Execute(String.Empty);
    }
    private void GenerateDefaultAppointmentsHolidays() {
        HolidaysGenerateCallbackCommand command = new HolidaysGenerateCallbackCommand(ASPxScheduler1);
        command.Execute(String.Empty);
    }
    private void AddHolidaysToScheduler(HolidayBaseCollection holidays) {
        ASPxScheduler1.BeginUpdate();
        try {
            ASPxScheduler1.WorkDays.Clear();
            ASPxScheduler1.WorkDays.Add(WeekDays.WorkDays);
            ASPxScheduler1.WorkDays.AddRange(holidays);
        } finally {
            ASPxScheduler1.EndUpdate();
        }
    }
    protected void ASPxScheduler1_BeforeExecuteCallbackCommand(object sender, SchedulerCallbackCommandEventArgs e) {
        if (e.CommandId == "HOLGNR")
            e.Command = new HolidaysGenerateCallbackCommand(ASPxScheduler1);
        if (e.CommandId == "HOLCLEAR")
            e.Command = new HolidaysClearCallbackCommand(ASPxScheduler1);
    }
}
#region HolidaysGenerateCallbackCommand
public class HolidaysGenerateCallbackCommand : SchedulerCallbackCommand {
    public HolidaysGenerateCallbackCommand(ASPxScheduler control)
        : base(control) {
    }
    public override string Id { get { return "HOLGNR"; } }

    protected override void ParseParameters(string parameters) {
        //do nothing
    }
    protected override void ExecuteCore() {
        ASPxSchedulerStorage storage = Control.Storage;
        AppointmentBaseCollection apts = HolidaysHelper.GenerateHolidayAppointments(storage, Control.WorkDays);
        storage.BeginUpdate();
        try {
            storage.Appointments.Items.AddRange(apts);
        } finally {
            storage.EndUpdate();
        }
    }
}
#endregion

#region HolidaysClearCallbackCommand
public class HolidaysClearCallbackCommand : SchedulerCallbackCommand {
    public HolidaysClearCallbackCommand(ASPxScheduler control)
        : base(control) {
    }
    public override string Id { get { return "HOLCLEAR"; } }

    protected override void ParseParameters(string parameters) {
        //do nothing
    }
    protected override void ExecuteCore() {
        Control.Storage.Appointments.Items.Clear();
    }
}
#endregion

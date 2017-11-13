using System;
using System.IO;
using System.Web.UI;
using DevExpress.Web.ASPxScheduler;
using DevExpress.Web.ASPxScheduler.Internal;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.iCalendar;

public partial class iCalendar_iCalendarExport : System.Web.UI.Page {
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

        if (Request.QueryString.Count == 1 && Request.QueryString[0] == "DevExpressCalendar.ics")
            PostCalendarFile();
    }
    void PostCalendarFile() {
        iCalendarExporter exporter = new iCalendarExporter(ASPxScheduler1.Storage);
        using (MemoryStream memoryStream = new MemoryStream()) {
            exporter.Export(memoryStream);
            Stream responseStream = Response.OutputStream;
            memoryStream.WriteTo(responseStream);
            responseStream.Flush();
        }
        Response.ContentType = "text/calendar";
        Response.AddHeader("Content-Disposition", "attachment; filename=DevExpressCalendar.ics");
        Response.End();
    }
    protected void ASPxScheduler1_PopupMenuShowing(object sender, DevExpress.Web.ASPxScheduler.PopupMenuShowingEventArgs e) {
        ASPxSchedulerPopupMenu menu = e.Menu;
        if (menu.MenuId.Equals(SchedulerMenuItemId.AppointmentMenu)) {
            DevExpress.Web.MenuItem item = new DevExpress.Web.MenuItem("Export Appointment", "ExportAppointment");
            menu.Items.Insert(1, item);
            menu.ClientSideEvents.ItemClick = "function(s, e) { OnMenuClick(s,e); }";
        }
    }
    protected void ASPxScheduler1_BeforeExecuteCallbackCommand(object sender, DevExpress.Web.ASPxScheduler.SchedulerCallbackCommandEventArgs e) {
        if (e.CommandId == "EXPORTAPT") {
            e.Command = new ExportAppointmentCallbackCommand((ASPxScheduler)sender);
        }
    }
}
public class ExportAppointmentCallbackCommand : SchedulerCallbackCommand {
    public ExportAppointmentCallbackCommand(ASPxScheduler control)
        : base(control) {
    }

    public override string Id { get { return "EXPORTAPT"; } }
    protected override void ParseParameters(string parameters) {
    }
    protected override void ExecuteCore() {
        PostCalendarFile(Control.SelectedAppointments);
    }
    void PostCalendarFile(AppointmentBaseCollection appointments) {
        iCalendarExporter exporter = new iCalendarExporter(Control.Storage, appointments);
        if (appointments.Count == 0)
            return;
        using (MemoryStream memoryStream = new MemoryStream()) {
            exporter.Export(memoryStream);
            Stream outputStream = Control.Page.Response.OutputStream;
            memoryStream.WriteTo(outputStream);
            outputStream.Flush();
        }
        Control.Page.Response.ContentType = "text/calendar";
        Control.Page.Response.AddHeader("Content-Disposition", "attachment; filename=appointment.ics");
        Control.Page.Response.End();
    }

}

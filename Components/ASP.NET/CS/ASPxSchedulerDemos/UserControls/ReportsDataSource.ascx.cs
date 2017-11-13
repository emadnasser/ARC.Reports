using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxScheduler;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Xml;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Linq;
using DevExpress.XtraScheduler.Reporting;

public partial class ReportsDataSource : System.Web.UI.UserControl {
    public SchedulerPrintAdapter SchedulerStorageAdapter { get { return ASPxStoragePrintAdapter.SchedulerAdapter; } }

    protected void Page_Load(object sender, EventArgs e) {
        SchedulerDemoUtils.ApplyDefaults(this, ASPxSchedulerControl);
        DataHelper.SetupDefaultMappings(ASPxSchedulerControl);
        ASPxSchedulerControl.AppointmentDataSource = this.efAppointmentDataSource;
        ASPxSchedulerControl.ResourceDataSource = this.efResourceDataSource;
        SetupStatuses(ASPxSchedulerControl);
        SetupLabels(ASPxSchedulerControl);
        ASPxSchedulerControl.DataBind();    
    }
    public void SetupLabels(ASPxScheduler control) {
        DevExpress.Web.ASPxScheduler.AppointmentLabelCollection labels = control.Storage.Appointments.Labels;
        labels.Clear();
        labels.Add(1, "Routine", "Routine", Color.FromArgb(100, 75, 194, 80));
        labels.Add(2, "Follow-Up", "Follow-Up", Color.FromArgb(100, 58, 159, 254));
        labels.Add(3, "Urgent", "Urgent", Color.FromArgb(100, 255, 89, 50));
        labels.Add(4, "Lab Testing", "Lab Testing", Color.FromArgb(100, 92, 107, 192));
        labels.Add(5, "Service", "Service", Color.FromArgb(100, 159, 159, 159));
    }
    public void SetupStatuses(ASPxScheduler control) {
        DevExpress.Web.ASPxScheduler.AppointmentStatusCollection statuses = control.Storage.Appointments.Statuses;
        statuses.Clear();
        statuses.Add(1, AppointmentStatusType.Custom, "Confirmed", "Confirmed", Color.FromArgb(200, 0, 171, 71));
        statuses.Add(1, AppointmentStatusType.Custom, "Awaiting Confirmation", "Awaiting Confirmation", Color.FromArgb(200, 94, 53, 177));
        statuses.Add(3, AppointmentStatusType.Custom, "Cancelled", "Cancelled", Color.FromArgb(200, 255, 255, 255));
    }
}

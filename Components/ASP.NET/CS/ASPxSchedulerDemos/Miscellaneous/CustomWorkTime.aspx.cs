using System;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxScheduler;
using DevExpress.XtraScheduler;

public partial class Miscellaneous_CustomWorkTime : System.Web.UI.Page {
    ASPxSchedulerStorage Storage { get { return ASPxScheduler1.Storage; } }
    protected void Page_Load(object sender, EventArgs e) {
        SchedulerDemoUtils.ApplyDefaults(this, ASPxScheduler1);
        DataHelper.SetupDefaultMappings(ASPxScheduler1);
        DataHelper.ProvideRowInsertion(ASPxScheduler1, AppointmentDataSource);
        DataHelper.SetupStatuses(ASPxScheduler1);
        DataHelper.SetupLabels(ASPxScheduler1);

        if(ASPxScheduler1.ActiveViewType.Equals(SchedulerViewType.Timeline) && !IsCallback)
            ASPxScheduler1.Start = ASPxScheduler1.Start.AddHours(5);

        ASPxScheduler1.DataBind();
        if(chkCustomWorkTime.Checked)
            ASPxScheduler1.JSProperties["cp_workTimes"] = workTimes;
        else
            ASPxScheduler1.JSProperties["cp_workTimes"] = defaultWorkTime;
    }

    TimeOfDayInterval[] workTimes = new TimeOfDayInterval[] {
            new TimeOfDayInterval(TimeSpan.FromHours(7), TimeSpan.FromHours(16)),
            new TimeOfDayInterval(TimeSpan.FromHours(8), TimeSpan.FromHours(19)),
            new TimeOfDayInterval(TimeSpan.FromHours(7), TimeSpan.FromHours(18)),
            new TimeOfDayInterval(TimeSpan.FromHours(7), TimeSpan.FromHours(19)),
            new TimeOfDayInterval(TimeSpan.FromHours(8), TimeSpan.FromHours(20)),
            new TimeOfDayInterval(TimeSpan.FromHours(7), TimeSpan.FromHours(19)),
            new TimeOfDayInterval(TimeSpan.FromHours(6), TimeSpan.FromHours(17))
        };


    TimeOfDayInterval[] defaultWorkTime = new TimeOfDayInterval[] {
            new TimeOfDayInterval(TimeSpan.FromHours(9), TimeSpan.FromHours(18))
        };

    protected void ASPxScheduler1_QueryWorkTime(object sender, QueryWorkTimeEventArgs e) {
        if(!chkCustomWorkTime.Checked || ASPxScheduler1.Storage.Resources == null)
            return;

        int resourceIndex;
        Int32.TryParse(e.Resource.Id.ToString(), out resourceIndex);
        if(resourceIndex >= 0)
            e.WorkTime = workTimes[resourceIndex];
    }
}

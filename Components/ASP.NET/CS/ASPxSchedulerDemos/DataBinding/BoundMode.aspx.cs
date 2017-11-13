using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Web.UI;
using System.Linq;
using DevExpress.Web.ASPxScheduler;
using DevExpress.XtraScheduler;

public partial class DataBinding_BoundMode : System.Web.UI.Page {
    protected override void OnInitComplete(EventArgs e) {
        base.OnInitComplete(e);

        DataHelper.ProvideRowInsertion(ASPxScheduler1, AppointmentDataSource);
        DataHelper.SetupStatuses(ASPxScheduler1);
        DataHelper.SetupLabels(ASPxScheduler1);
        ASPxScheduler1.OptionsBehavior.ShowDetailedErrorInfo = false;
        DataHelper.EnsureOnlineVersionModificationLock(ASPxScheduler1);
    }
    protected void Page_Load(object sender, EventArgs e) {
        SchedulerDemoUtils.ApplyDefaults(this, ASPxScheduler1);
    }
}

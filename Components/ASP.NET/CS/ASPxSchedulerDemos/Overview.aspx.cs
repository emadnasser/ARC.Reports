using System;
using System.Web.UI;
using DevExpress.Web.ASPxScheduler;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using DevExpress.XtraScheduler;
using System.Collections.Generic;

public partial class Overview: System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        SchedulerDemoUtils.ApplyDefaults(this, ASPxScheduler1);
        DataHelper.ProvideRowInsertion(ASPxScheduler1, AppointmentDataSource);
        DataHelper.SetupLabels(ASPxScheduler1);
        DataHelper.SetupStatuses(ASPxScheduler1);
        PrepareViews(ASPxScheduler1);
    }
    void PrepareViews(ASPxScheduler scheduler) {
        PrepareResourceImageStyle(scheduler.Views.DayView.DayViewStyles.HorizontalResourceHeader);
        PrepareResourceImageStyle(scheduler.Views.WorkWeekView.WorkWeekViewStyles.HorizontalResourceHeader);
        PrepareResourceImageStyle(scheduler.Views.WeekView.WeekViewStyles.HorizontalResourceHeader);
        PrepareResourceImageStyle(scheduler.Views.TimelineView.TimelineViewStyles.VerticalResourceHeader);
    }
    void PrepareResourceImageStyle(ResourceHeaderStyle style) {
        style.ResourceImageStyle.Width = Unit.Pixel(120);
    }
}

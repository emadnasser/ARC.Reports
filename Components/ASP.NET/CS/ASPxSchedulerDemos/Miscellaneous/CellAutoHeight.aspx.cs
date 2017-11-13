using System;
using System.Web.UI;
using DevExpress.Web.ASPxScheduler;
using SchedulerViewType = DevExpress.XtraScheduler.SchedulerViewType;
using TimeScaleCollection = DevExpress.XtraScheduler.TimeScaleCollection;
using TimeScaleWeek = DevExpress.XtraScheduler.TimeScaleWeek;
using TimeScaleMonth = DevExpress.XtraScheduler.TimeScaleMonth;

public partial class Miscellaneous_CellAutoHeight : Page {
    protected void Page_Load(object sender, EventArgs e) {
        SchedulerDemoUtils.ApplyDefaults(this, ASPxScheduler1);
        DataHelper.SetupDefaultMappings(ASPxScheduler1);
        DataHelper.ProvideRowInsertion(ASPxScheduler1, AppointmentDataSource);
        DataHelper.SetupStatuses(ASPxScheduler1);
        DataHelper.SetupLabels(ASPxScheduler1);
        ApplyCellAutoHeightMode();
        ASPxScheduler1.DataBind();
    }
    void SetUpTimelineTimescale() {
        TimeScaleCollection scales = ASPxScheduler1.TimelineView.Scales;
        scales.BeginUpdate();
        scales.Clear();
        TimeScaleWeek week = new TimeScaleWeek();
        week.Visible = false;
        scales.Add(week);
        TimeScaleMonth month = new TimeScaleMonth();
        scales.Add(month);
        scales.EndUpdate();
    }
    void ApplyCellAutoHeightMode() {
        ASPxScheduler1.BeginUpdate();
        try {
            string typeAsString = rbCellAutoHeghtMode.Value as string;
            SchedulerViewType[] viewTypes = new SchedulerViewType[] { SchedulerViewType.Week, SchedulerViewType.Month, SchedulerViewType.Timeline};
            AutoHeightMode mode = (AutoHeightMode)Enum.Parse(typeof(AutoHeightMode), typeAsString);

            foreach(SchedulerViewType viewType in viewTypes) {
                DevExpress.Web.ASPxScheduler.SchedulerViewBase view = ASPxScheduler1.Views[viewType];
                ASPxSchedulerOptionsCellAutoHeight options = GetCellAutoHeightOptions(view);
                if(options == null)
                    continue;
                SetCellAutoHeightOptions(mode, options);
            }           
        }
        finally {
            ASPxScheduler1.EndUpdate();
        }
        ASPxScheduler1.ApplyChanges(ASPxSchedulerChangeAction.All);
    }

    ASPxSchedulerOptionsCellAutoHeight GetCellAutoHeightOptions(SchedulerViewBase view) {
        WeekView weekView = view as WeekView;
        if(weekView != null)
            return weekView.CellAutoHeightOptions;
        MonthView monthView = view as MonthView;
        if(monthView != null)
            return monthView.CellAutoHeightOptions;
        TimelineView timelineView = view as TimelineView;
        if(timelineView != null)
            return timelineView.CellAutoHeightOptions;
        return null;
    }
    void SetCellAutoHeightOptions(AutoHeightMode mode, ASPxSchedulerOptionsCellAutoHeight options) {
        options.Mode = mode;
        options.MinHeight = 100;
        options.MaxHeight = 230;
    }
    
}

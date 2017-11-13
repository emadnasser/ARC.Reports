using System;
using System.Collections;
using System.Collections.Generic;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Reporting;

public partial class Reporting_DataValidation : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        SchedulerPrintAdapter adapter = ReportsDataSource1.SchedulerStorageAdapter;
        adapter.ValidateResources += new ResourcesValidationEventHandler(SchedulerPrintAdapter_ValidateResources);
        adapter.ValidateAppointments += new AppointmentsValidationEventHandler(SchedulerPrintAdapter_ValidateAppointments);
        adapter.ValidateTimeIntervals += new TimeIntervalsValidationEventHandler(SchedulerPrintAdapter_ValidateTimeIntervals);

        DataValidationReport report = new DataValidationReport();
        report.SchedulerAdapter = adapter;
        report.SchedulerAdapter.TimeInterval = new TimeInterval(SchedulerDemoUtils.BaseDate, SchedulerDemoUtils.BaseDate.AddDays(21));

        ReportViewer.Report = report;
    }

    void SchedulerPrintAdapter_ValidateTimeIntervals(object sender, TimeIntervalsValidationEventArgs e) {
        int weekDays = (int)cbDays.Value;
        if(weekDays == (int)DevExpress.XtraScheduler.WeekDays.EveryDay)
            return;

        int count = e.Intervals.Count;

        DayIntervalCollection result = new DayIntervalCollection();
        for(int i = count - 1; i >= 0; i--) {
            DayIntervalCollection sourceDays = new DayIntervalCollection();
            sourceDays.Add(e.Intervals[i]);
            FilterDays(sourceDays, weekDays);
            result.AddRange(sourceDays);
        }

        e.Intervals.Clear();
        for(int i = 0; i < result.Count; i++) {
            e.Intervals.Add(result[i]);
        }

    }
    void FilterDays(DayIntervalCollection dayIntervals, int validDaysMask) {
        int count = dayIntervals.Count;
        for(int i = count - 1; i >= 0; i--) {
            DayOfWeek day = dayIntervals[i].Start.DayOfWeek;
            WeekDays weekDay = DevExpress.XtraScheduler.Native.DateTimeHelper.ToWeekDays(day);

            int weekDayMask = Convert.ToInt32(weekDay);

            if((weekDayMask & validDaysMask) != weekDayMask)
                dayIntervals.RemoveAt(i);
        }
    }
    void SchedulerPrintAdapter_ValidateResources(object sender, ResourcesValidationEventArgs e) {
        int resourceMode = cbResources.SelectedIndex;
        if(resourceMode == 1) {
            int count = e.Resources.Count;
            for(int i = count - 1; i >= 3; i--) {
                e.Resources.RemoveAt(i);
            }
        }
        if(resourceMode == 2) {
            e.Resources.Sort(new ResourceCaptionComparer());
        }
        if(resourceMode == 3) {
            e.Resources.Sort(new ResourceCaptionReverseComparer());
        }
    }

    void SchedulerPrintAdapter_ValidateAppointments(object sender, AppointmentsValidationEventArgs e) {
        int aptType = (int)cbAppointments.Value;
        if(aptType == (int)UsedAppointmentType.All)
            return;

        int count = e.Appointments.Count;
        AppointmentBaseCollection result = new AppointmentBaseCollection();
        for(int i = 0; i < count; i++) {
            Appointment apt = e.Appointments[i];
            if(aptType == (int)UsedAppointmentType.Recurring && apt.IsRecurring)
                result.Add(apt);
            if(aptType == (int)UsedAppointmentType.NonRecurring && !apt.IsRecurring)
                result.Add(apt);
        }
        e.Appointments.Clear();
        e.Appointments.AddRange(result);
    }
    public class ResourceCaptionComparer : IComparer<Resource>, IComparer {

        #region IComparer Members
        int IComparer.Compare(object x, object y) {
            return CompareCore(x, y);
        }
        public int Compare(Resource x, Resource y) {
            return CompareCore(x, y);
        }
        #endregion

        protected virtual int CompareCore(object x, object y) {
            Resource xRes = (Resource)x;
            Resource yRes = (Resource)y;
            if(xRes == null || yRes == null)
                return 0;
            if (EmptyResourceId.Id.Equals(xRes.Id) || EmptyResourceId.Id.Equals(yRes.Id))
                return 0;
            return CompareCaptions(xRes, yRes);
        }
        protected virtual int CompareCaptions(Resource xRes, Resource yRes) {
            return String.Compare(xRes.Caption, yRes.Caption);
        }

    }
    public class ResourceCaptionReverseComparer : ResourceCaptionComparer {
        protected override int CompareCaptions(Resource xRes, Resource yRes) {
            return String.Compare(yRes.Caption, xRes.Caption);
        }
    }

}

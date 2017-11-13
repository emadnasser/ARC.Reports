using System;
using System.Collections.Generic;
using System.Web.UI;
using DevExpress.Web;

public partial class ASPxCalendar_CustomDisabledDates : Page {
    protected void Page_Load(object sender, EventArgs e) {
        ASPxCalendar2.DisabledDates.AddRange(GetDisabledDates());
    }

    public IEnumerable<DateTime> GetDisabledDates() {
        List<DateTime> disabledDates = new List<DateTime>();

        disabledDates.Add(new DateTime(DateTime.Today.Year, DateTime.Today.Month, 7));
        disabledDates.Add(new DateTime(DateTime.Today.Year, DateTime.Today.Month, 11));
        disabledDates.Add(new DateTime(DateTime.Today.Year, DateTime.Today.Month, 13));
        disabledDates.Add(new DateTime(DateTime.Today.Year, DateTime.Today.Month, 17));
        disabledDates.Add(new DateTime(DateTime.Today.Year, DateTime.Today.Month, 19));

        return disabledDates;
    }
    protected void ASPxCalendar1_CustomDisabledDate(object sender, CalendarCustomDisabledDateEventArgs e) {
        if(e.Date.DayOfWeek == DayOfWeek.Wednesday)
            e.IsDisabled = true;
    }
}

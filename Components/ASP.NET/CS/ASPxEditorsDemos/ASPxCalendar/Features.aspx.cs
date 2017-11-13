using System.Web.UI;
using System;

public partial class ASPxCalendar_Features : Page {
    const int AutoSelectedDatesCount = 5; 

    protected void Page_Load(object sender, EventArgs e) {
        calendar.HighlightToday = cbHighlightToday.Checked;
        calendar.HighlightWeekends = cbHighlightWeekends.Checked;
        calendar.ShowClearButton = cbShowClearButton.Checked;
        calendar.ShowTodayButton = cbShowTodayButton.Checked;
        calendar.ShowDayHeaders = cbShowDayHeaders.Checked;
        calendar.ShowHeader = cbShowHeader.Checked;
        calendar.ShowWeekNumbers = cbShowWeekNumber.Checked;
        ToggleMultiSelect();
    }

    protected void ToggleMultiSelect() {
        calendar.EnableMultiSelect = cbEnableMultiSelect.Checked;
        if (calendar.EnableMultiSelect) {
            int visibleDaysCount = (calendar.GetLastVisibleDate() - calendar.GetFirstVisibleDate()).Days;
            Random rnd = new Random();
            for (int i = 0; i < AutoSelectedDatesCount; i++) {
                DateTime selectedDate = calendar.GetFirstVisibleDate().AddDays(rnd.Next(visibleDaysCount));
                calendar.SelectedDates.Add(selectedDate);
            }
        } else
            calendar.SelectedDates.Clear();
    }
}

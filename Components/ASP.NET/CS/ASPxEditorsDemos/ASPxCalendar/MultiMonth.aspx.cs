using System.Web.UI;

public partial class ASPxCalendar_MultiMonth : Page {
    protected void ddlDayNameFormat_SelectedIndexChanged(object sender, System.EventArgs e) {
        switch (ddlColumnsPerRows.SelectedItem.Value.ToString()) { 
            case "2x2":
                calendar.Rows = 2;
                calendar.Columns = 2;
                break;
            case "1x3":
                calendar.Columns = 1;
                calendar.Rows = 3;
                break;
            case "2x1":
                calendar.Columns = 2;
                calendar.Rows = 1;
                break;
        }
    }
}

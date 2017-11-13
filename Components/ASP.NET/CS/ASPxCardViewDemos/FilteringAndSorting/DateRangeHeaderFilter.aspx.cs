using System;
using System.Linq;
using System.Web.UI;
using DevExpress.Web;
using DevExpress.Web.Demos;

public partial class FilteringAndSorting_DateRangeHeaderFilter : Page {
    static string[] WideThemes = new string[] { "Metropolis", "MetropolisBlue", "Moderno", "Mulberry", "SoftOrange" };

    protected GridHeaderFilterMode HeaderFilterMode { get { return (GridHeaderFilterMode)cmbHeaderFilterMode.Value; } }

    protected void Page_Load(object sender, EventArgs e) {
        CardView.Columns["VisitDate"].SettingsHeaderFilter.Mode = HeaderFilterMode;
        CardView.SettingsPopup.HeaderFilter.Width = GetHeaderFilterPopupWidth();
    }
    int GetHeaderFilterPopupWidth() {
        return object.Equals(HeaderFilterMode, GridHeaderFilterMode.DateRangeCalendar) && WideThemes.Contains(Utils.CurrentTheme) ? 360 : 300;
    }
}

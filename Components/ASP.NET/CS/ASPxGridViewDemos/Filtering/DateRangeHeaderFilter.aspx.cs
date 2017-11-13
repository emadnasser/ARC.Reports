using System;
using System.Linq;
using System.Web.UI;
using DevExpress.Web;
using DevExpress.Web.Demos;

public partial class Filtering_HeaderFilter : Page {
    static string[] WideThemes = new string[] { "iOS", "Material", "Metropolis", "MetropolisBlue", "Moderno", "Mulberry", "SoftOrange" };

    protected GridHeaderFilterMode HeaderFilterMode { get { return (GridHeaderFilterMode)cmbHeaderFilterMode.Value; } }
    bool IsWideHeaderFilterPopupContent { get { return object.Equals(HeaderFilterMode, GridHeaderFilterMode.DateRangeCalendar) && WideThemes.Contains(Utils.CurrentTheme); } }

    protected void Page_Load(object sender, EventArgs e) {
        grid.DataColumns["VisitDate"].SettingsHeaderFilter.Mode = HeaderFilterMode;
        grid.SettingsPopup.HeaderFilter.Width = IsWideHeaderFilterPopupContent ? 360 : 300;
        grid.SettingsPopup.HeaderFilter.Height = IsWideHeaderFilterPopupContent ? 510 : 320;
    }
}

using System;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Docking_Widgets : Page {
    protected void Page_Load(object sender, EventArgs e) {
        string[] widgetNames = { "DateTime", "Mail", "News", "Trading", "Weather", "Calendar" };
        repeater.DataSource = widgetNames;
        repeater.DataBind();
    }

    protected string GetClientButtonClickHandler(RepeaterItem container) {
        return string.Format("function(s, e) {{ ShowWidgetPanel('{0}') }}", container.DataItem);
    }
}

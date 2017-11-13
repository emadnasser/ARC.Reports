using System;
using System.IO;
using System.Web.SessionState;
using System.Web.UI.WebControls;
using DevExpress.Web;
using DevExpress.XtraCharts.Web;
using DevExpress.XtraCharts.Web.Designer;

public partial class ChartDesignerPage : System.Web.UI.Page {
    static WebChartControl LoadChartFromSession(HttpSessionState session) {
        var layoutXml = (string)session["ChartLayout"];
        if (layoutXml == null)
            return null;
        var chart = new WebChartControl();
        chart.LoadFromXml(layoutXml);
        return chart;
    }

    protected void Page_Init(object sender, EventArgs e) {
        Header.Title = "Chart Designer";
        if (!IsPostBack) {
            WebChartControl chart = LoadChartFromSession(Session);
            if (chart == null) {
                Response.Redirect("~/Miscellaneous/ChartDesigner.aspx");
            }
            chart.Width = (Unit)Session["ChartWidth"];
            chart.Height = (Unit)Session["ChartHeight"];
            this.chartDesigner.OpenChart(chart);
        }
        
    }
    
    protected void chartDesigner_SaveChartLayout(object sender, SaveChartLayoutEventArgs e) {
        Session["ChartLayout"] = e.ChartLayoutXml;
        ASPxWebControl.RedirectOnCallback("~/Miscellaneous/ChartDesigner.aspx");
    }
}

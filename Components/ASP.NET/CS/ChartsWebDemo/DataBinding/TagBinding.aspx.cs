using System;
using System.Data;
using DevExpress.Utils;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;

public partial class TagBinding : ChartBasePage {
    Series Series { get { return WebChartControl1.Series[0]; } }

    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack)
            cbShowLabels.Checked = Series.LabelsVisibility == DefaultBoolean.True;
    }
    protected void WebChartControl1_CustomDrawSeriesPoint(object sender, CustomDrawSeriesPointEventArgs e) {
        e.LegendText = (string)((DataRowView)e.SeriesPoint.Tag)["OfficialName"];
    }
    protected void WebChartControl1_CustomCallback(object sender, CustomCallbackEventArgs e) {
        Series.LabelsVisibility = cbShowLabels.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        WebChartControl1.CrosshairEnabled = cbShowLabels.Checked ? DefaultBoolean.False : DefaultBoolean.True;
    }
}

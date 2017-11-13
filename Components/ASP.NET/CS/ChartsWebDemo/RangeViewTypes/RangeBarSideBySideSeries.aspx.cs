using System;
using DevExpress.Utils;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;

public partial class RangeBarSideBySideSeries : ChartBasePage {
    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            cbShowLabels.Checked = WebChartControl1.Series[0].LabelsVisibility == DefaultBoolean.True;
        }
        WebChartControl1.Series[0].DataSource = SourceOfEnergy.GetEuropeBrentPrices();
        WebChartControl1.Series[1].DataSource = SourceOfEnergy.GetOkWtiPrices();
    }
    protected void WebChartControl1_CustomCallback(object sender, CustomCallbackEventArgs e) {
        foreach(Series series in WebChartControl1.Series)
            series.LabelsVisibility = cbShowLabels.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        WebChartControl1.ToolTipEnabled = cbShowLabels.Checked ? DefaultBoolean.False : DefaultBoolean.True;
    }
}

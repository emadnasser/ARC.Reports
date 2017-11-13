using System;
using DevExpress.Utils;
using DevExpress.XtraCharts;

public partial class SplineAreaFullStackedSeries : ChartBasePage {
    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            SeriesBase series = WebChartControl1.SeriesTemplate;
            cbShowLabels.Checked = series.LabelsVisibility == DevExpress.Utils.DefaultBoolean.True;
            if (series != null && series.Label != null && !string.IsNullOrEmpty(series.Label.TextPattern))
                cbValueAsPercent.Checked = series.Label.TextPattern.Contains("VP");
        }
        cbValueAsPercent.ClientEnabled = cbShowLabels.Checked;
    }
    protected void WebChartControl1_CustomCallback(object sender, DevExpress.XtraCharts.Web.CustomCallbackEventArgs e) {
        string labeltextPattern = cbValueAsPercent.Checked ? "{VP:P0}" : "${V}M";
        WebChartControl1.SeriesTemplate.Label.TextPattern = labeltextPattern;
        WebChartControl1.SeriesTemplate.LabelsVisibility = cbShowLabels.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        WebChartControl1.CrosshairEnabled = cbShowLabels.Checked ? DefaultBoolean.False : DefaultBoolean.True;
    }
}

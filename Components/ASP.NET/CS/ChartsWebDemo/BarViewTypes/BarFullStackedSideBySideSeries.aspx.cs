using System;
using DevExpress.Utils;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;

public partial class BarFullStackedSideBySideSeries : ChartBasePage {
    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            SeriesBase series = WebChartControl1.SeriesTemplate;
            if (series != null && series.Label != null && !string.IsNullOrEmpty(series.Label.TextPattern))
                cbValueAsPercent.Checked = series.Label.TextPattern.Contains("VP");
            cbShowLabels.Checked = series.LabelsVisibility == DefaultBoolean.True;
            rbSex.Checked = true;
        }
        cbValueAsPercent.ClientEnabled = cbShowLabels.Checked;
    }
    protected void WebChartControl1_CustomCallback(object sender, CustomCallbackEventArgs e) {
        string labeltextPattern = cbValueAsPercent.Checked ? "{VP:P0}" : "{V:0,,.00}";        
        WebChartControl1.SeriesTemplate.Label.TextPattern = labeltextPattern;
        WebChartControl1.SeriesTemplate.LabelsVisibility = cbShowLabels.Checked ? DefaultBoolean.True : DefaultBoolean.False;        
        WebChartControl1.CrosshairEnabled = cbShowLabels.Checked ? DefaultBoolean.False : DefaultBoolean.True;
    }
    protected void WebChartControl1_BoundDataChanged(object sender, EventArgs e) {
        foreach (Series series in WebChartControl1.Series) {
            ISupportStackedGroup view = series.View as ISupportStackedGroup;
            GenderAgeInfo genderAge = (GenderAgeInfo)series.Tag;
            if (view != null)
                view.StackedGroup = rbSex.Checked ? genderAge.Gender : genderAge.Age;
        }
    }
}

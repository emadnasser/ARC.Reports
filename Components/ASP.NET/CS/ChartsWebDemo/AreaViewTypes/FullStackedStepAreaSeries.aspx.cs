using System;
using DevExpress.Utils;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;

public partial class FullStackedStepAreaSeries : ChartBasePage {
    void PerformInvertedAction() {
        foreach (Series series in WebChartControl1.Series) {
            var view = (FullStackedStepAreaSeriesView)series.View;
            view.InvertedStep = cbInverted.Checked;
        }
    }
    void PerformShowLabelsAction() {
        foreach (Series series in WebChartControl1.Series) {
            series.LabelsVisibility = cbShowLabels.Checked ? DefaultBoolean.True : DefaultBoolean.False;
            WebChartControl1.CrosshairEnabled = cbShowLabels.Checked ? DefaultBoolean.False : DefaultBoolean.True;
        }
    }
    void PerformValueAsPercentAction() {
        string labeltextPattern = cbValueAsPercent.Checked ? "{VP:P0}" : "{V:F1}";
        foreach(Series series in WebChartControl1.Series)
            series.Label.TextPattern = labeltextPattern;
    }

    protected void WebChartControl1_CustomCallback(object sender, CustomCallbackEventArgs e) {
        switch (e.Parameter) {
            case "Inverted":
                PerformInvertedAction();
                break;
            case "ShowLabels":
                PerformShowLabelsAction();
                break;
            case "ValueAsPercent":
                PerformValueAsPercentAction();
                break;
        }
    }
    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            Series series = WebChartControl1.Series[0];
            cbShowLabels.Checked = series.LabelsVisibility == DevExpress.Utils.DefaultBoolean.True;
            if (series != null && series.Label != null && !string.IsNullOrEmpty(series.Label.TextPattern))
                cbValueAsPercent.Checked = series.Label.TextPattern.Contains("VP");
            PerformValueAsPercentAction();
        }
        cbValueAsPercent.ClientEnabled = cbShowLabels.Checked;
    }
}

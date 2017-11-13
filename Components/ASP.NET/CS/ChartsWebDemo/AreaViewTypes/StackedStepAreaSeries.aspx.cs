using System;
using DevExpress.Utils;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;

public partial class StackedStepAreaSeries : ChartBasePage {
    void PerformInvertedAction() {
        foreach (Series series in WebChartControl1.Series) {
            var view = (StackedStepAreaSeriesView)series.View;
            view.InvertedStep = cbInverted.Checked;
        }
    }
    void PerformShowLabelsAction() {
        foreach (Series series in WebChartControl1.Series) {
            series.LabelsVisibility = cbShowLabels.Checked ? DefaultBoolean.True : DefaultBoolean.False;
            WebChartControl1.CrosshairEnabled = cbShowLabels.Checked ? DefaultBoolean.False : DefaultBoolean.True;
        }
    }

    protected void WebChartControl1_CustomCallback(object sender, CustomCallbackEventArgs e) {
        switch (e.Parameter) {
            case "Inverted":
                PerformInvertedAction();
                break;
            case "ShowLabels":
                PerformShowLabelsAction();
                break;
        }
    }
}

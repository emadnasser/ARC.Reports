using System;
using DevExpress.Utils;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;

public partial class BarFullStackedSeries : ChartBasePage {
    void Page_Load(object sender, EventArgs e) {
        StackedBarSeriesLabel label = (StackedBarSeriesLabel)WebChartControl1.SeriesTemplate.Label;
        if (!IsPostBack) {
            ComboBoxHelper.PrepareComboBox(cbTextOrientation, TextOrientation.Horizontal);
            ComboBoxHelper.PrepareComboBox(cbLabelPosition, new string[] { "Top Inside", "Center", "Bottom Inside" });
            SeriesBase series = WebChartControl1.SeriesTemplate;
            chbShowLabels.Checked = series.LabelsVisibility == DevExpress.Utils.DefaultBoolean.True;
            if (series != null && series.Label != null && !string.IsNullOrEmpty(series.Label.TextPattern))
                cbValueAsPercent.Checked = series.Label.TextPattern.Contains("VP");
            spnLabelIndent.Value = label.Indent;
            cbTextOrientation.SelectedIndex = (int)label.TextOrientation;
            switch (label.Position) {
                case BarSeriesLabelPosition.TopInside:
                    cbLabelPosition.Value = "Top Inside";
                    break;
                case BarSeriesLabelPosition.Center:
                    cbLabelPosition.Value = "Center";
                    break;
                case BarSeriesLabelPosition.BottomInside:
                    cbLabelPosition.Value = "Bottom Inside";
                    break;
                default:
                    cbLabelPosition.Value = "Center";
                    break;
            }
        }
        lblLabelPosition.ClientEnabled = chbShowLabels.Checked;
        cbLabelPosition.ClientEnabled = chbShowLabels.Checked;
        lbTextOrientation.ClientEnabled = chbShowLabels.Checked;
        cbTextOrientation.ClientEnabled = chbShowLabels.Checked;
        bool indentEnabled = chbShowLabels.Checked &&
            (label.Position == BarSeriesLabelPosition.TopInside || label.Position == BarSeriesLabelPosition.BottomInside);
        cbValueAsPercent.ClientEnabled = chbShowLabels.Checked;
        lblLabelIndent.ClientEnabled = indentEnabled;
        spnLabelIndent.ClientEnabled = indentEnabled;
    }
    void PerformLabelPositionAction() {
        BarSeriesLabelPosition position;
        switch ((string)cbLabelPosition.Value) {
            case "Top Inside":
                position = BarSeriesLabelPosition.TopInside;
                break;
            case "Center":
                position = BarSeriesLabelPosition.Center;
                break;
            case "Bottom Inside":
                position = BarSeriesLabelPosition.BottomInside;
                break;
            default:
                position = BarSeriesLabelPosition.Center;
                break;
        }
        ((StackedBarSeriesLabel)WebChartControl1.SeriesTemplate.Label).Position = position;
    }
    void PerformShowLabelsAction() {
        WebChartControl1.SeriesTemplate.LabelsVisibility = chbShowLabels.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        WebChartControl1.CrosshairEnabled = chbShowLabels.Checked ? DefaultBoolean.False : DefaultBoolean.True;
    }
    void PerformTextOrientationAction() {
        WebChartControl1.SeriesTemplate.Label.TextOrientation = (TextOrientation)cbTextOrientation.SelectedIndex;
    }
    void PerformValueAsPercentAction(){
        string labeltextPattern = cbValueAsPercent.Checked ? "{VP:P0}" : "{V:F1}K";
        WebChartControl1.SeriesTemplate.Label.TextPattern = labeltextPattern;
    }
    void PerformLabelIndentAction() {
        ((BarSeriesLabel)WebChartControl1.SeriesTemplate.Label).Indent = Convert.ToInt32(spnLabelIndent.Value);
    }
    protected void WebChartControl1_CustomCallback(object sender, CustomCallbackEventArgs e) {
        if (e.Parameter == "ShowLabels")
            PerformShowLabelsAction();
        else if (e.Parameter == "LabelPosition")
            PerformLabelPositionAction();
        else if (e.Parameter == "TextOrientation")
            PerformTextOrientationAction();
        else if (e.Parameter == "ValueAsPercent")
            PerformValueAsPercentAction();
        else if (e.Parameter == "LabelIndent")
            PerformLabelIndentAction();
    }
}
using System;
using DevExpress.Utils;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;

public partial class BarSeries : ChartBasePage {
    void Page_Load(object sender, EventArgs e) {
        SideBySideBarSeriesLabel label = (SideBySideBarSeriesLabel)WebChartControl1.SeriesTemplate.Label;
        if (!IsPostBack) {
            ComboBoxHelper.PrepareComboBox(cbTextOrientation, TextOrientation.Horizontal);
            ComboBoxHelper.PrepareComboBox(cbLabelPosition, new string[] { "Top", "Top Inside", "Center", "Bottom Inside" });
            chbShowLabels.Checked = WebChartControl1.SeriesTemplate.LabelsVisibility == DefaultBoolean.True;
            spnLabelIndent.Value = label.Indent;
            cbTextOrientation.SelectedIndex = (int)label.TextOrientation;
            switch (label.Position) {
                case BarSeriesLabelPosition.Top:
                    cbLabelPosition.Value = "Top";
                    break;
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
        lblLabelIndent.ClientEnabled = indentEnabled;
        spnLabelIndent.ClientEnabled = indentEnabled;
        WebChartControl1.CrosshairOptions.CrosshairLabelMode = CrosshairLabelMode.ShowForNearestSeries;
    }
    void PerformLabelPositionAction() {
        BarSeriesLabelPosition position;
        switch ((string)cbLabelPosition.Value) {
            case "Top": 
                position = BarSeriesLabelPosition.Top;
                break;
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
                position = BarSeriesLabelPosition.Top;
                break;
        }
        ((SideBySideBarSeriesLabel)WebChartControl1.SeriesTemplate.Label).Position = position;
    }
    void PerformShowLabelsAction() {
        WebChartControl1.SeriesTemplate.LabelsVisibility = chbShowLabels.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        WebChartControl1.CrosshairEnabled = chbShowLabels.Checked ? DefaultBoolean.False : DefaultBoolean.True;
    }
    void PerformTextOrientationAction() {
        WebChartControl1.SeriesTemplate.Label.TextOrientation = (TextOrientation)cbTextOrientation.SelectedIndex;
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
        else if (e.Parameter == "LabelIndent")
            PerformLabelIndentAction();
    }
}

using System;
using System.Globalization;
using DevExpress.Utils;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;

public partial class CandleStickSeries : ChartBasePage {
    Axis AxisX { get { return ((XYDiagram)WebChartControl1.Diagram).AxisX; } }
    Series Series { get { return WebChartControl1.Series[0]; } }
    CandleStickSeriesView View { get { return (CandleStickSeriesView)Series.View; } }

    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            cbWorkdaysOnly.Checked = AxisX.DateTimeScaleOptions.WorkdaysOnly;
            cbShowLabels.Checked = Series.LabelsVisibility == DefaultBoolean.True;
            ComboBoxHelper.PrepareComboBox(cbReductionLevel, View.ReductionOptions.Level);
            ComboBoxHelper.PrepareComboBox(cbLabelLevel, new string[] { "Low", "High", "Open", "Close" }, "Close");
        }
        lblLabelLevel.ClientEnabled = cbShowLabels.Checked;
        cbLabelLevel.ClientEnabled = cbShowLabels.Checked;
    }
    void PerformReductionLevelAction() {
        View.ReductionOptions.Level = (StockLevel)ComboBoxHelper.GetSelectedItem(cbReductionLevel, typeof(StockLevel));
    }
    void PerformLabelLevelAction() {
        string pattern = "{CV:F2}";
        switch (cbLabelLevel.SelectedItem.Text) {
            case "Low": pattern = "{LV:F2}";
                break;
            case "High": pattern = "{HV:F2}";
                break;
            case "Open": pattern = "{OV:F2}";
                break;
            default: pattern = "{CV:F2}";
                break;
        }
        Series.Label.TextPattern = pattern;
    }
    void PerformShowLabelsAction() {
        Series.LabelsVisibility = cbShowLabels.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        WebChartControl1.CrosshairEnabled = cbShowLabels.Checked ? DefaultBoolean.False : DefaultBoolean.True;
    }
    void PerformWorkdaysOnlyAction() {
        AxisX.DateTimeScaleOptions.WorkdaysOnly = cbWorkdaysOnly.Checked;
    }
    protected void WebChartControl1_CustomCallback(object sender, CustomCallbackEventArgs e) {
        if (e.Parameter == "ReductionLevel")
            PerformReductionLevelAction();
        else if (e.Parameter == "LabelLevel")
            PerformLabelLevelAction();
        else if (e.Parameter == "ShowLabels")
            PerformShowLabelsAction();
        else if (e.Parameter == "WorkdaysOnly")
            PerformWorkdaysOnlyAction();
    }
}

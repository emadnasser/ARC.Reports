using System;
using System.Web.UI.WebControls;
using DevExpress.Utils;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;

public partial class FunnelSeries : ChartBasePage {
    bool loading = false;
    
    Series Series { get { return WebChartControl1.Series[0]; } }
    FunnelSeriesLabel Label { get { return (FunnelSeriesLabel)Series.Label; } }
    FunnelSeriesView View { get { return (FunnelSeriesView)Series.View; } }
    
    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            try {
                loading = true;
                cbShowLabels.Checked = Series.LabelsVisibility == DevExpress.Utils.DefaultBoolean.True;
                ComboBoxHelper.PrepareComboBox(cbLabelPosition, FunnelSeriesLabelPosition.Right);
                ComboBoxHelper.PrepareComboBox(cbHeightToWidthRatio, new double[] { 0.1, 0.25, 0.5, 0.75, 1, 2, 4, 6, 8, 10 }, View.HeightToWidthRatio);
                if (Series != null && Series.Label != null && !string.IsNullOrEmpty(Series.Label.TextPattern))
                    cbValueAsPercent.Checked = Series.Label.TextPattern.Contains("VP");
                cbHeightToWidthRatioAuto.Checked = View.HeightToWidthRatioAuto;
                cbHeightToWidthRatio.ClientEnabled = !View.HeightToWidthRatioAuto;
                cbAlignToCenter.Checked = View.AlignToCenter;
                spinPointDistance.Value = View.PointDistance;
            }
            finally {
                loading = false;
            }
        }
        lblLabelPosition.ClientEnabled = cbShowLabels.Checked;
        cbLabelPosition.ClientEnabled = cbShowLabels.Checked;
        cbValueAsPercent.ClientEnabled = cbShowLabels.Checked;
        lblHeightToWidthRatio.ClientEnabled = !cbHeightToWidthRatioAuto.Checked;
        cbHeightToWidthRatio.ClientEnabled = !cbHeightToWidthRatioAuto.Checked;
    }
    void PerformLabelPositionAction() {
        if (loading)
            return;
        FunnelSeriesLabelPosition position = (FunnelSeriesLabelPosition)ComboBoxHelper.GetSelectedItem(cbLabelPosition, typeof(FunnelSeriesLabelPosition));
        Label.Position = position;
    }
    void PerformValueAsPercentAction() {
        if (loading)
            return;
        Series.Label.TextPattern = cbValueAsPercent.Checked ? "{A}: {VP:P0}" : "{A}: {V:F1}";
    }
    void PerformShowLabelsAction() {
        if (loading)
            return;
        Series.LabelsVisibility = cbShowLabels.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        WebChartControl1.ToolTipEnabled = cbShowLabels.Checked ? DefaultBoolean.False : DefaultBoolean.True;
    }
    void PerformAlignToCenterAction() {
        if (loading)
            return;
        View.AlignToCenter = cbAlignToCenter.Checked;
    }
    void PerformHeightToWidthRatioAutoAction() {
        if (loading)
            return;
        View.HeightToWidthRatioAuto = cbHeightToWidthRatioAuto.Checked;
    }
    void PerformHeightToWidthRatioAction() {
        if (loading)
            return;
        View.HeightToWidthRatio = Convert.ToDouble(cbHeightToWidthRatio.SelectedItem.Value);
    }
    void PerformPointDistanceAction() {
        if (loading)
            return;
        View.PointDistance = Convert.ToInt32(spinPointDistance.Value);
    }
    protected void WebChartControl1_CustomCallback1(object sender, CustomCallbackEventArgs e) {
        if (e.Parameter == "LabelPosition")
            PerformLabelPositionAction();
        else if (e.Parameter == "ValueAsPercent")
            PerformValueAsPercentAction();
        else if (e.Parameter == "ShowLabels")
            PerformShowLabelsAction();
        else if (e.Parameter == "AlignToCenter")
            PerformAlignToCenterAction();
        else if (e.Parameter == "HeightToWidthRatioAuto")
            PerformHeightToWidthRatioAutoAction();
        else if (e.Parameter == "HeightToWidthRatio")
            PerformHeightToWidthRatioAction();
        else if (e.Parameter == "PointDistance")
            PerformPointDistanceAction();

    }
}

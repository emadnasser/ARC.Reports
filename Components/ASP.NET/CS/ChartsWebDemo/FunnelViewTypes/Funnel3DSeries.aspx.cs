using System;
using System.Web.UI.WebControls;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;

public partial class Funnel3DSeries : ChartBasePage {
    bool isLoading = false;
    
    Series Series { get { return WebChartControl1.Series[0]; } }
    FunnelSeriesLabel Label { get { return (Funnel3DSeriesLabel)Series.Label; } }
    Funnel3DSeriesView View { get { return (Funnel3DSeriesView)Series.View; } }
    
    protected void Page_Load(object sender, EventArgs e) {
        try {
            isLoading = true;
            if (!IsPostBack) {
                cbShowLabels.Checked = Series.LabelsVisibility != DevExpress.Utils.DefaultBoolean.False;
                ComboBoxHelper.PrepareComboBox(cbLabelPosition, FunnelSeriesLabelPosition.Right);
                cbHeightToWidthRatio.Items.AddRange(new double[] { 0.1, 0.25, 0.5, 0.75, 1, 2, 4, 6, 8, 10 });
                cbHeightToWidthRatio.SelectedIndex = 4;
                if (Series != null && Series.Label != null && !string.IsNullOrEmpty(Series.Label.TextPattern))
                    cbValueAsPercent.Checked = Series.Label.TextPattern.Contains("VP");
                spinPointDistance.Value = View.PointDistance;
                spinHoleRadius.Value = View.HoleRadiusPercent;
            }
        }
        finally {
            isLoading = false;
        }
        lblLabelPosition.ClientEnabled = cbShowLabels.Checked;
        cbLabelPosition.ClientEnabled = cbShowLabels.Checked;
        cbValueAsPercent.ClientEnabled = cbShowLabels.Checked;        
    }
    protected void WebChartControl1_CustomCallback1(object sender, CustomCallbackEventArgs e) {
        if (e.Parameter == "LabelPosition")
            PerformLabelPositionAction();
        else if (e.Parameter == "ValueAsPercent")
            PerformValueAsPercentAction();
        else if (e.Parameter == "ShowLabels")
            PerformShowLabelsAction();
        else if (e.Parameter == "HeightToWidthRatio")
            PerformHeightToWidthRatioAction();  
        else if (e.Parameter == "PointDistance")
            PerformPointDistanceAction();  
        else if (e.Parameter == "HoleRadius")
            PerformHoleRadiusAction();
       
    }
    void PerformLabelPositionAction() {
        if (isLoading)
            return;
        FunnelSeriesLabelPosition position = (FunnelSeriesLabelPosition)ComboBoxHelper.GetSelectedItem(cbLabelPosition, typeof(FunnelSeriesLabelPosition));
        Label.Position = position;
    }
    void PerformValueAsPercentAction() {
        if (isLoading)
            return;
        Series.Label.TextPattern = cbValueAsPercent.Checked ? "{A}: {VP:P0}" : "{A}: {V:F1}";
    }
    void PerformShowLabelsAction() {
        if (isLoading)
            return;
        Series.LabelsVisibility = cbShowLabels.Checked ? DevExpress.Utils.DefaultBoolean.True : DevExpress.Utils.DefaultBoolean.False;
    }
    void PerformHeightToWidthRatioAction() {
        if (isLoading)
            return;
        View.HeightToWidthRatio = Convert.ToDouble(cbHeightToWidthRatio.SelectedItem.Value);
    }
    void PerformPointDistanceAction() {
        if (isLoading)
            return;
        View.PointDistance = Convert.ToInt32(spinPointDistance.Value);
    }
    void PerformHoleRadiusAction() {
        if (isLoading)
            return;
        View.HoleRadiusPercent = Convert.ToInt32(spinHoleRadius.Value);
    }
}

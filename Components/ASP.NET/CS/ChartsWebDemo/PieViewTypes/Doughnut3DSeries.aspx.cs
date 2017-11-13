using System;
using System.Web.UI.WebControls;
using DevExpress.Utils;
using DevExpress.XtraCharts;

public partial class Doughnut3DSeries : ChartBasePage {
    Series Series { get { return WebChartControl1.Series[0]; } }
    Pie3DSeriesLabel Label { get { return (Pie3DSeriesLabel)Series.Label; } }
    Doughnut3DSeriesView View { get { return (Doughnut3DSeriesView)Series.View; } }

    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            cbShowLabels.Checked = Series.LabelsVisibility != DevExpress.Utils.DefaultBoolean.False;
            if (Label != null && !string.IsNullOrEmpty(Label.TextPattern))
                cbValueAsPercent.Checked = Label.TextPattern.Contains("VP");
            ComboBoxHelper.PreparePieLabelsComboBox(cbLabelPosition);
            ComboBoxHelper.PrepareExplodedPointsComboBox(cbExplodedPoints, Series.Points, false);
            ComboBoxHelper.PrepareDoughnutHolePercentComboBox(cbHoleRadius);
            cbLabelPosition.SelectedIndex = 3;
        }
        lblLabelPosition.ClientEnabled = cbShowLabels.Checked;
        cbLabelPosition.ClientEnabled = cbShowLabels.Checked;
    }
    protected void WebChartControl1_CustomCallback(object sender, DevExpress.XtraCharts.Web.CustomCallbackEventArgs e) {
        if (e.Parameter == "LabelPosition")
            PerformLabelPositionAction();
        else if (e.Parameter == "ValueAsPercent")
            PerformValueAsPercentAction();
        else if (e.Parameter == "ExplodedPoints")
            PerformExplodedPointsAction();
        else if (e.Parameter == "HoleRadius")
            PerformHoleRadiusAction();
        else if (e.Parameter == "ShowLabels")
            PerformShowLabelsAction();
    }
    void PerformLabelPositionAction() {
        Label.Position = (PieSeriesLabelPosition)ComboBoxHelper.GetSelectedItem(cbLabelPosition, typeof(PieSeriesLabelPosition));
    }
    void PerformValueAsPercentAction() {
        Label.TextPattern = cbValueAsPercent.Checked ? "{A}: {VP:P0}" : "{A}: {V:F1}";
    }
    void PerformExplodedPointsAction() {
        ComboBoxHelper.ApplySelectedExplodingMode(cbExplodedPoints, View);
    }
    void PerformHoleRadiusAction() {
        View.HoleRadiusPercent = ComboBoxHelper.GetSelectedDoughnutHolePercent(cbHoleRadius);
    }
    void PerformShowLabelsAction() {
        Series.LabelsVisibility = cbShowLabels.Checked ? DevExpress.Utils.DefaultBoolean.True : DevExpress.Utils.DefaultBoolean.False;
    }
}
using System;
using System.Drawing;
using System.Web.UI.WebControls;
using DevExpress.Utils;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;

public partial class DoughnutSeries : ChartBasePage {
    Series Series { get { return WebChartControl1.Series[0]; } }
    DoughnutSeriesLabel Label { get { return (DoughnutSeriesLabel)Series.Label; } }
    DoughnutSeriesView View { get { return (DoughnutSeriesView)Series.View; } }

    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            cbShowLabels.Checked = Series.LabelsVisibility != DevExpress.Utils.DefaultBoolean.False;
            if (Label != null && !string.IsNullOrEmpty(Label.TextPattern))
                cbValueAsPercent.Checked = Label.TextPattern.Contains("VP");
            ComboBoxHelper.PreparePieLabelsComboBox(cbLabelPosition);
            ComboBoxHelper.PrepareExplodedPointsComboBox(cbExplodedPoints, Series.Points, true);
            ComboBoxHelper.PrepareDoughnutHolePercentComboBox(cbHoleRadius);
            cbLabelPosition.SelectedIndex = 3;
        }
        lblLabelPosition.ClientEnabled = cbShowLabels.Checked;
        cbLabelPosition.ClientEnabled = cbShowLabels.Checked;
    }
    void PerformLabelPositionAction() {
        PieSeriesLabelPosition position = (PieSeriesLabelPosition)ComboBoxHelper.GetSelectedItem(cbLabelPosition, typeof(PieSeriesLabelPosition));
        Label.Position = position;
        Label.TextColor = (position.Equals(PieSeriesLabelPosition.Outside) || position.Equals(PieSeriesLabelPosition.TwoColumns)) ? Color.Empty : Color.Black;
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
        Series.LabelsVisibility = cbShowLabels.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        WebChartControl1.ToolTipEnabled = cbShowLabels.Checked ? DefaultBoolean.False : DefaultBoolean.True;
    }
    protected void WebChartControl1_ObjectSelected(object sender, HotTrackEventArgs e) {
        Series series = e.Object as Series;
        if (series != null) {
            ExplodedSeriesPointCollection explodedPoints = ((PieSeriesViewBase)series.View).ExplodedPoints;
            SeriesPoint point = (SeriesPoint)e.AdditionalObject;
            explodedPoints.ToggleExplodedState(point);
        }
        e.Cancel = series == null;
    }
    protected void WebChartControl1_CustomCallback(object sender, CustomCallbackEventArgs e) {
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
}

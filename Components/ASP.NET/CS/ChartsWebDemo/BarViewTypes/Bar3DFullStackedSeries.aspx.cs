using System;
using DevExpress.XtraCharts;

public partial class Bar3DFullStackedSeries : ChartBasePage {
    Diagram3D Diagram { get { return (Diagram3D)WebChartControl1.Diagram; } }

    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            SeriesBase series = WebChartControl1.SeriesTemplate;
            cbShowLabels.Checked = series.LabelsVisibility != DevExpress.Utils.DefaultBoolean.False;
            cbShowFacet.Checked = ((Bar3DSeriesView)series.View).ShowFacet;
            if (series != null && series.Label != null && !string.IsNullOrEmpty(series.Label.TextPattern))
                cbValueAsPercent.Checked = series.Label.TextPattern.Contains("VP");
            ComboBoxHelper.PreparePerspectiveAngleComboBox(cbPerspectiveAngle);
            ComboBoxHelper.PrepareTransparencyComboBox(cbTransparency, ((Bar3DSeriesView)series.View).Transparency);
            ComboBoxHelper.PrepareZoomPercentComboBox(cbZoomPercent, Diagram.ZoomPercent);
            ComboBoxHelper.PrepareBar3DModelComboBox(cb3DModel);
        }

        cbValueAsPercent.ClientEnabled = cbShowLabels.Checked;
    }
    protected void WebChartControl1_CustomCallback(object sender, DevExpress.XtraCharts.Web.CustomCallbackEventArgs e) {
        if (e.Parameter == "ValueAsPercent")
            PerformValueAsPercentAction();
        else if (e.Parameter == "Transparency")
            PerformTransparencyAction();
        else if (e.Parameter == "PerspectiveAngle")
            PerformPerspectiveAngleAction();
        else if (e.Parameter == "ZoomPercent")
            PerformZoomPercentAction();
        else if (e.Parameter == "ShowLabels")
            PerformShowLabelsAction();
        else if (e.Parameter == "ShowFacet")
            PerformShowFacetAction();
        else if (e.Parameter == "Bar3DModel")
            PerformBar3DModelAction();
    }
    void PerformShowFacetAction() {
        ((Bar3DSeriesView)WebChartControl1.SeriesTemplate.View).ShowFacet = cbShowFacet.Checked;
    }
    void PerformBar3DModelAction() {
        Bar3DModel model = (Bar3DModel)cb3DModel.SelectedIndex;
        ((Bar3DSeriesView)WebChartControl1.SeriesTemplate.View).Model = model;
    }
    void PerformValueAsPercentAction() {
        string labeltextPattern = cbValueAsPercent.Checked ? "{VP:P0}" : "{V:F1}K";
        WebChartControl1.SeriesTemplate.Label.TextPattern = labeltextPattern;
    }
    void PerformTransparencyAction() {
        byte transparency = Convert.ToByte(cbTransparency.SelectedItem.Text);
        ((Bar3DSeriesView)WebChartControl1.SeriesTemplate.View).Transparency = transparency;
    }
    void PerformPerspectiveAngleAction() {
        Diagram.PerspectiveAngle = ComboBoxHelper.GetSelectedPerspectiveAngle(cbPerspectiveAngle);
    }
    void PerformShowLabelsAction() {
        WebChartControl1.SeriesTemplate.LabelsVisibility = cbShowLabels.Checked ? DevExpress.Utils.DefaultBoolean.True : DevExpress.Utils.DefaultBoolean.False;
    }
    void PerformZoomPercentAction() {
        Diagram.ZoomPercent = Convert.ToInt32(cbZoomPercent.SelectedItem.Text);
    }
}

using System;
using DevExpress.XtraCharts;

public partial class FullStackedLine3DSeries : ChartBasePage {
    Diagram3D Diagram { get { return (Diagram3D)WebChartControl1.Diagram; } }
    SeriesBase Series { get { return WebChartControl1.SeriesTemplate; } }

    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            cbShowLabels.Checked = Series.LabelsVisibility != DevExpress.Utils.DefaultBoolean.False;
            if (Series != null && Series.Label != null && !string.IsNullOrEmpty(Series.Label.TextPattern))
                cbValueAsPercent.Checked = Series.Label.TextPattern.Contains("VP");
            ComboBoxHelper.PreparePerspectiveAngleComboBox(cbPerspectiveAngle);
            ComboBoxHelper.PrepareZoomPercentComboBox(cbZoomPercent, Diagram.ZoomPercent);
        }
        cbValueAsPercent.ClientEnabled = cbShowLabels.Checked;
    }
    protected void WebChartControl1_CustomCallback(object sender, DevExpress.XtraCharts.Web.CustomCallbackEventArgs e) {
        if(e.Parameter == "ShowLabels")
            PerformShowLabelsAction();
        else if(e.Parameter == "PerspectiveAngle")
            PerformPerspectiveAngleAction();
        else if(e.Parameter == "ZoomPercent")
            PerformZoomPercentAction();
        else if (e.Parameter == "ValueAsPercent")
            PerformValueAsPercentAction();
    }
    void PerformShowLabelsAction() {
        Series.LabelsVisibility = cbShowLabels.Checked ? DevExpress.Utils.DefaultBoolean.True : DevExpress.Utils.DefaultBoolean.False;
    }
    void PerformPerspectiveAngleAction() {
        Diagram.PerspectiveAngle = ComboBoxHelper.GetSelectedPerspectiveAngle(cbPerspectiveAngle);
    }
    void PerformZoomPercentAction() {
        Diagram.ZoomPercent = Convert.ToInt32(cbZoomPercent.SelectedItem.Text);
    }
    void PerformValueAsPercentAction() {
        string labeltextPattern = cbValueAsPercent.Checked ? "{VP:P0}" : "${V:F2}M";
        Series.Label.TextPattern = labeltextPattern;
    }
}

using System;
using DevExpress.XtraCharts;

public partial class SplineArea3DFullStackedSeries : ChartBasePage {
    Diagram3D Diagram { get { return (Diagram3D)WebChartControl1.Diagram; } }

    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            SeriesBase series = WebChartControl1.SeriesTemplate;
            cbShowLabels.Checked = series.LabelsVisibility != DevExpress.Utils.DefaultBoolean.False;
            ComboBoxHelper.PreparePerspectiveAngleComboBox(cbPerspectiveAngle);
            ComboBoxHelper.PrepareTransparencyComboBox(cbTransparency, ((FullStackedSplineArea3DSeriesView)series.View).Transparency);
            ComboBoxHelper.PrepareZoomPercentComboBox(cbZoomPercent, Diagram.ZoomPercent);
        }
    }
    protected void WebChartControl1_CustomCallback(object sender, DevExpress.XtraCharts.Web.CustomCallbackEventArgs e) {
        if(e.Parameter == "ShowLabels")
            PerformShowLabelsAction();
        else if(e.Parameter == "Transparency")
            PerformTransparencyAction();
        else if(e.Parameter == "PerspectiveAngle")
            PerformPerspectiveAngleAction();
        else if(e.Parameter == "ZoomPercent")
            PerformZoomPercentAction();
    }
    void PerformShowLabelsAction() {
        WebChartControl1.SeriesTemplate.LabelsVisibility = cbShowLabels.Checked ? DevExpress.Utils.DefaultBoolean.True : DevExpress.Utils.DefaultBoolean.False;
    }
    void PerformTransparencyAction() {
        byte transparency = Convert.ToByte(cbTransparency.SelectedItem.Text);        
        ((FullStackedSplineArea3DSeriesView)WebChartControl1.SeriesTemplate.View).Transparency = transparency;
    }
    void PerformPerspectiveAngleAction() {
        Diagram.PerspectiveAngle = ComboBoxHelper.GetSelectedPerspectiveAngle(cbPerspectiveAngle);
    }
    void PerformZoomPercentAction() {
        Diagram.ZoomPercent = Convert.ToInt32(cbZoomPercent.SelectedItem.Text);
    }
}

using System;
using System.Web.UI.WebControls;
using DevExpress.XtraCharts;

public partial class StepLine3DSeries : ChartBasePage {
    Diagram3D Diagram { get { return (Diagram3D)WebChartControl1.Diagram; } }
    Series Series { get { return WebChartControl1.Series[0]; } }
    StepLine3DSeriesView View { get { return (StepLine3DSeriesView)Series.View; } }
      
    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            cbShowLabels.Checked = Series.LabelsVisibility != DevExpress.Utils.DefaultBoolean.False;
            cbInvertStep.Checked = View.InvertedStep;
            ComboBoxHelper.PreparePerspectiveAngleComboBox(cbPerspectiveAngle);
            ComboBoxHelper.PrepareZoomPercentComboBox(cbZoomPercent, Diagram.ZoomPercent);
        }
    }
    protected void WebChartControl1_CustomCallback(object sender, DevExpress.XtraCharts.Web.CustomCallbackEventArgs e) {
        if(e.Parameter == "ShowLabels")
            PerformShowLabelsAction();
        else if(e.Parameter == "InvertStep")
            PerformInvertStepAction();
        else if(e.Parameter == "PerspectiveAngle")
            PerformPerspectiveAngleAction();
        else if(e.Parameter == "ZoomPercent")
            PerformZoomPercentAction();
    }
    void PerformShowLabelsAction() {
        Series.LabelsVisibility = cbShowLabels.Checked ? DevExpress.Utils.DefaultBoolean.True : DevExpress.Utils.DefaultBoolean.False;
    }
    void PerformInvertStepAction() {
        View.InvertedStep = cbInvertStep.Checked;
    }
    void PerformPerspectiveAngleAction() {
        Diagram.PerspectiveAngle = ComboBoxHelper.GetSelectedPerspectiveAngle(cbPerspectiveAngle);
    }
    void PerformZoomPercentAction() {
        Diagram.ZoomPercent = Convert.ToInt32(cbZoomPercent.SelectedItem.Text);
    }
}



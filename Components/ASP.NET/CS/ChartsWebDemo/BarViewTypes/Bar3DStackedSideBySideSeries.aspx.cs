using System;
using DevExpress.XtraCharts;

public partial class Bar3DStackedSideBySideSeries : ChartBasePage {
    Diagram3D Diagram { get { return (Diagram3D)WebChartControl1.Diagram; } }

    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            SeriesBase series = WebChartControl1.SeriesTemplate;
            cbShowLabels.Checked = series.LabelsVisibility != DevExpress.Utils.DefaultBoolean.False;
            ComboBoxHelper.PreparePerspectiveAngleComboBox(cbPerspectiveAngle);
            ComboBoxHelper.PrepareZoomPercentComboBox(cbZoomPercent, Diagram.ZoomPercent);
            rbSex.Checked = true;
        }
    }
    protected void WebChartControl1_CustomCallback(object sender, DevExpress.XtraCharts.Web.CustomCallbackEventArgs e) {
        if(e.Parameter == "ShowLabels")
            PerformShowLabelsAction();
        else if(e.Parameter == "PerspectiveAngle")
            PerformPerspectiveAngleAction();
        else if(e.Parameter == "ZoomPercent")
            PerformZoomPercentAction();
    } 
    void PerformShowLabelsAction() {
        WebChartControl1.SeriesTemplate.LabelsVisibility = cbShowLabels.Checked ? DevExpress.Utils.DefaultBoolean.True : DevExpress.Utils.DefaultBoolean.False;
    }
    void PerformPerspectiveAngleAction() {
        Diagram.PerspectiveAngle = ComboBoxHelper.GetSelectedPerspectiveAngle(cbPerspectiveAngle);
    }
    void PerformZoomPercentAction() {
        Diagram.ZoomPercent = Convert.ToInt32(cbZoomPercent.SelectedItem.Text);
    }
    protected void WebChartControl1_BoundDataChanged(object sender, EventArgs e) {
        foreach (Series series in WebChartControl1.Series) {
            ISupportStackedGroup view = series.View as ISupportStackedGroup;
            GenderAgeInfo genderAge = (GenderAgeInfo)series.Tag;
            if (view != null)
                view.StackedGroup = rbSex.Checked ? genderAge.Gender : genderAge.Age;
        }
    }
}

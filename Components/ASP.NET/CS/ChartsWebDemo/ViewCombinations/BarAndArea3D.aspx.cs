using System;
using DevExpress.XtraCharts;

public partial class BarAndArea3D : ChartBasePage {
    Diagram3D Diagram { get { return (Diagram3D)WebChartControl1.Diagram; } }

    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            cbShowLabels.Checked = WebChartControl1.Series[0].LabelsVisibility != DevExpress.Utils.DefaultBoolean.False;
            ComboBoxHelper.PrepareZoomPercentComboBox(cbZoomPercent, Diagram.ZoomPercent);
        }
    }
    protected void WebChartControl1_CustomCallback(object sender, DevExpress.XtraCharts.Web.CustomCallbackEventArgs e) {
        if(e.Parameter == "ShowLabels")
            PerformShowLabelsAction();
        else if(e.Parameter == "ZoomPercent")
            PerformZoomPercentAction();
    }
    void PerformShowLabelsAction() {
        foreach(Series series in WebChartControl1.Series)
            series.LabelsVisibility = cbShowLabels.Checked ? DevExpress.Utils.DefaultBoolean.True : DevExpress.Utils.DefaultBoolean.False;
    }
    void PerformZoomPercentAction() {
        Diagram.ZoomPercent = Convert.ToInt32(cbZoomPercent.SelectedItem.Text);
    }
}

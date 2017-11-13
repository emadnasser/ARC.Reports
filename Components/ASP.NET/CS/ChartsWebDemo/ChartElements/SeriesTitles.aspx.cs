using System;
using DevExpress.Utils;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;

public partial class SeriesTitles : ChartBasePage {
    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            cbShowLabels.Checked = WebChartControl1.SeriesTemplate.LabelsVisibility != DefaultBoolean.False;
            ComboBoxHelper.PreparePieViewTypeComboBox(cbViewType);
        }
    }
    void PerformShowLabelsAction() {
        WebChartControl1.SeriesTemplate.LabelsVisibility = cbShowLabels.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        WebChartControl1.ToolTipEnabled = cbShowLabels.Checked ? DefaultBoolean.False : DefaultBoolean.True;
    }
    void PerformViewTypeAction() {
        ViewType viewType;
        switch (cbViewType.SelectedItem.Text) {
            case "Pie 3D":
                viewType = ViewType.Pie3D;
                break;
            case "Doughnut":
                viewType = ViewType.Doughnut;
                break;
            case "Doughnut 3D":
                viewType = ViewType.Doughnut3D;
                break;
            default:
                viewType = ViewType.Pie;
                break;
        }
        WebChartControl1.SeriesTemplate.ChangeView(viewType);
        Diagram3D diagram = WebChartControl1.Diagram as Diagram3D;
        if (diagram != null) {
            diagram.RuntimeRotation = true;
            diagram.RuntimeScrolling = true;
            diagram.RuntimeZooming = true;
        }
    }
    protected void WebChartControl1_CustomDrawSeriesPoint(object sender, CustomDrawSeriesPointEventArgs e) {
        if (WebChartControl1.Series.Count > 0 && !ReferenceEquals(WebChartControl1.Series[0], e.Series))
            e.LegendText = "";
    }
    protected void WebChartControl1_CustomCallback(object sender, CustomCallbackEventArgs e) {
        if (e.Parameter == "ShowLabels")
            PerformShowLabelsAction();
        else if (e.Parameter == "ViewType")
            PerformViewTypeAction();
    }
}

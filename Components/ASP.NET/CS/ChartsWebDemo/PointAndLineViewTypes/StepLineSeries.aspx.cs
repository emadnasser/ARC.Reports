using System;
using System.Web.UI.WebControls;
using DevExpress.XtraCharts;

public partial class StepLineSeries : ChartBasePage {
    Series Series { get { return WebChartControl1.Series[0]; } }
    StepLineSeriesView View { get { return (StepLineSeriesView)Series.View; } }
    PointSeriesLabel Label { get { return (PointSeriesLabel)Series.Label; } } 

    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            cbShowLabels.Checked = Series.LabelsVisibility == DevExpress.Utils.DefaultBoolean.True;
            ComboBoxHelper.PrepareLabelAngleComboBox(cbLabelAngle, Label.Angle);
            ComboBoxHelper.PrepareMarkerKindComboBox(cbMarkerKind, View.PointMarkerOptions.Kind, View.PointMarkerOptions.StarPointCount);
            ComboBoxHelper.PrepareMarkerSizeComboBox(cbMarkerSize, View.PointMarkerOptions.Size);            
        }
        lblLabelAngle.ClientEnabled = cbShowLabels.Checked;
        cbLabelAngle.ClientEnabled = cbShowLabels.Checked;
    }
    void PerformLabelAngleAction() {
        Label.Angle = Convert.ToInt32(cbLabelAngle.SelectedItem.Text);
    }
    void PerformMarkerKindAction() {
        MarkerKindItem item = ComboBoxHelper.GetSelectedMarkerKindItem(cbMarkerKind);
        int pointCount = 0;
        StarMarkerKindItem starItem = item as StarMarkerKindItem;
        if(starItem != null)
            pointCount = starItem.PointCount;
        foreach(Series series in WebChartControl1.Series) {
            PointSeriesView view = (PointSeriesView)series.View;
            view.PointMarkerOptions.Kind = item.MarkerKind;
            if(pointCount != 0)
                view.PointMarkerOptions.StarPointCount = pointCount;
        }
    }
    void PerformMarkerSizeAction() {
        View.PointMarkerOptions.Size = Convert.ToInt32(cbMarkerSize.SelectedItem.Text);
    }
    void PerformShowLabelsAction() {
        Series.LabelsVisibility = cbShowLabels.Checked ? DevExpress.Utils.DefaultBoolean.True : DevExpress.Utils.DefaultBoolean.False;
        WebChartControl1.CrosshairEnabled = cbShowLabels.Checked ? DevExpress.Utils.DefaultBoolean.False : DevExpress.Utils.DefaultBoolean.True;
    }
    protected void WebChartControl1_CustomCallback(object sender, DevExpress.XtraCharts.Web.CustomCallbackEventArgs e) {
        if (e.Parameter == "LabelAngle")
            PerformLabelAngleAction();
        else if (e.Parameter == "MarkerKind")
            PerformMarkerKindAction();
        else if (e.Parameter == "MarkerSize")
            PerformMarkerSizeAction();
        else if (e.Parameter == "ShowLabels")
            PerformShowLabelsAction();
    }
}

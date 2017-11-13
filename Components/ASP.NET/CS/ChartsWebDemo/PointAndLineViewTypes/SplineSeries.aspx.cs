using System;
using DevExpress.XtraCharts;

public partial class SplineSeries : ChartBasePage {
    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            SeriesBase series = WebChartControl1.SeriesTemplate;
            PointSeriesLabel label = (PointSeriesLabel)series.Label;
            SplineSeriesView view = (SplineSeriesView)series.View;

            cbShowLabels.Checked = series.LabelsVisibility == DevExpress.Utils.DefaultBoolean.True;
            ComboBoxHelper.PrepareLabelAngleComboBox(cbLabelAngle, label.Angle);
            ComboBoxHelper.PrepareMarkerKindComboBox(cbMarkerKind, view.PointMarkerOptions.Kind, view.PointMarkerOptions.StarPointCount);
            ComboBoxHelper.PrepareMarkerSizeComboBox(cbMarkerSize, view.PointMarkerOptions.Size);
            ComboBoxHelper.PrepareLineTensionComboBox(cbLineTension, view.LineTensionPercent);
        }
        lblLabelAngle.ClientEnabled = cbShowLabels.Checked;
        cbLabelAngle.ClientEnabled = cbShowLabels.Checked;        
    }
    void PerformLabelAngleAction() {
        int labelAngle = Convert.ToInt32(cbLabelAngle.SelectedItem.Text);
        ((PointSeriesLabel)WebChartControl1.SeriesTemplate.Label).Angle = labelAngle;
    }
    void PerformMarkerKindAction() {
        MarkerKindItem item = ComboBoxHelper.GetSelectedMarkerKindItem(cbMarkerKind);
        int pointCount = 0;
        StarMarkerKindItem starItem = item as StarMarkerKindItem;
        if (starItem != null)
            pointCount = starItem.PointCount;
        PointSeriesView view = (PointSeriesView)WebChartControl1.SeriesTemplate.View;
        view.PointMarkerOptions.Kind = item.MarkerKind;
        if (pointCount != 0)
            view.PointMarkerOptions.StarPointCount = pointCount;
    }
    void PerformMarkerSizeAction() {
        int size = Convert.ToInt32(cbMarkerSize.SelectedItem.Text);
        ((PointSeriesView)WebChartControl1.SeriesTemplate.View).PointMarkerOptions.Size = size;
    }
    void PerformLineTensionAction() {
        int lineTension = ComboBoxHelper.GetSelectedLineTension(cbLineTension);
        ((SplineSeriesView)WebChartControl1.SeriesTemplate.View).LineTensionPercent = lineTension;
    }
    void PerformShowLabelsAction() {
        WebChartControl1.SeriesTemplate.LabelsVisibility = cbShowLabels.Checked ? DevExpress.Utils.DefaultBoolean.True : DevExpress.Utils.DefaultBoolean.False;
        WebChartControl1.CrosshairEnabled = cbShowLabels.Checked ? DevExpress.Utils.DefaultBoolean.False : DevExpress.Utils.DefaultBoolean.True;
    }
    protected void WebChartControl1_CustomCallback(object sender, DevExpress.XtraCharts.Web.CustomCallbackEventArgs e) {
        if (e.Parameter == "LabelAngle")
            PerformLabelAngleAction();
        else if (e.Parameter == "MarkerKind")
            PerformMarkerKindAction();
        else if (e.Parameter == "MarkerSize")
            PerformMarkerSizeAction();
        else if (e.Parameter == "LineTension")
            PerformLineTensionAction();
        else if (e.Parameter == "ShowLabels")
            PerformShowLabelsAction();
    }
}

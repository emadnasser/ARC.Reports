using System;
using DevExpress.Utils;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;

public partial class RadarRangeAreaSeries : ChartBasePage {
    RadarDiagram Diagram { get { return (RadarDiagram)WebChartControl1.Diagram; } }

    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            Series series = WebChartControl1.Series[0];
            var view = (RadarRangeAreaSeriesView)series.View;
            cbShowLabels.Checked = series.LabelsVisibility == DefaultBoolean.True;
            cbShowMarkers.Checked = view.Marker1Visibility == DefaultBoolean.True;
            ComboBoxHelper.PrepareMarkerKindComboBox(cbMarkerKind, view.Marker1.Kind, view.Marker1.StarPointCount);
            ComboBoxHelper.PrepareMarkerSizeComboBox(cbMarkerSize, view.Marker1.Size);
            ComboBoxHelper.PrepareComboBox(cbDiagramType, Diagram.DrawingStyle);
            ComboBoxHelper.PrepareComboBox(cbTextDirection, Diagram.AxisX.Label.TextDirection);
        }
        lblMarkerKind.ClientEnabled = cbShowMarkers.Checked;
        lblMarkerSize.ClientEnabled = cbShowMarkers.Checked;
        cbMarkerKind.ClientEnabled = cbShowMarkers.Checked;
        cbMarkerSize.ClientEnabled = cbShowMarkers.Checked;
    }
    protected void WebChartControl1_CustomCallback(object sender, CustomCallbackEventArgs e) {
        if (e.Parameter == "ShowLabels")
            PerformShowLabelsAction();
        else if (e.Parameter == "MarkerKind")
            PerformMarkerKindAction();
        else if (e.Parameter == "DiagramType")
            PerformDiagramTypeAction();
        else if (e.Parameter == "MarkerSize")
            PerformMarkerSizeAction();
        else if (e.Parameter == "TextDirection")
            PerformTextDirectionAction();
        else if (e.Parameter == "ShowMarkers")
            PerformShowMarkersAction();
    }
    void PerformShowLabelsAction() {
        WebChartControl1.Series[0].LabelsVisibility = cbShowLabels.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        WebChartControl1.ToolTipEnabled = cbShowLabels.Checked ? DefaultBoolean.False : DefaultBoolean.True;
    }
    void PerformMarkerKindAction() {
        MarkerKindItem item = ComboBoxHelper.GetSelectedMarkerKindItem(cbMarkerKind);
        int pointCount = 0;
        StarMarkerKindItem starItem = item as StarMarkerKindItem;
        if (starItem != null)
            pointCount = starItem.PointCount;
        var view = (RadarRangeAreaSeriesView)WebChartControl1.Series[0].View;
        view.Marker1.Kind = item.MarkerKind;
        view.Marker2.Kind = item.MarkerKind;
        if (pointCount != 0) {
            view.Marker1.StarPointCount = pointCount;
            view.Marker2.StarPointCount = pointCount;
        }

    }
    void PerformDiagramTypeAction() {
        Diagram.DrawingStyle = (RadarDiagramDrawingStyle)ComboBoxHelper.GetSelectedItem(cbDiagramType, typeof(RadarDiagramDrawingStyle));
    }
    void PerformMarkerSizeAction() {
        int size = Convert.ToInt32(cbMarkerSize.SelectedItem.Text);
        var view = (RadarRangeAreaSeriesView)WebChartControl1.Series[0].View;
        view.Marker1.Size = size;
        view.Marker2.Size = size;
    }
    void PerformTextDirectionAction() {
        RadarAxisXLabel label = Diagram.AxisX.Label;
        label.TextDirection = (RadarAxisXLabelTextDirection)ComboBoxHelper.GetSelectedItem(cbTextDirection, typeof(RadarAxisXLabelTextDirection));
    }
    void PerformShowMarkersAction() {
        var view = (RadarRangeAreaSeriesView)WebChartControl1.Series[0].View;
        view.Marker1Visibility = cbShowMarkers.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        view.Marker2Visibility = cbShowMarkers.Checked ? DefaultBoolean.True : DefaultBoolean.False;
    }
}

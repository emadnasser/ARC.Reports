using System;
using DevExpress.Utils;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;

public partial class RadarLineSeries : ChartBasePage {
    RadarDiagram Diagram { get { return (RadarDiagram)WebChartControl1.Diagram; } }

	protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            Series series = WebChartControl1.Series[0];
            RadarLineSeriesView view = (RadarLineSeriesView)series.View;
            cbShowLabels.Checked = series.LabelsVisibility == DefaultBoolean.True;
            cbShowMarkers.Checked = view.MarkerVisibility != DefaultBoolean.False;
            ComboBoxHelper.PrepareMarkerKindComboBox(cbMarkerKind, view.PointMarkerOptions.Kind, view.PointMarkerOptions.StarPointCount);
            ComboBoxHelper.PrepareMarkerSizeComboBox(cbMarkerSize, view.PointMarkerOptions.Size);
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
        foreach(Series series in WebChartControl1.Series)
            series.LabelsVisibility = cbShowLabels.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        WebChartControl1.ToolTipEnabled = cbShowLabels.Checked ? DefaultBoolean.False : DefaultBoolean.True;
    }
    void PerformMarkerKindAction() {
        MarkerKindItem item = ComboBoxHelper.GetSelectedMarkerKindItem(cbMarkerKind);
        int pointCount = 0;
        StarMarkerKindItem starItem = item as StarMarkerKindItem;
        if(starItem != null)
            pointCount = starItem.PointCount;
        foreach(Series series in WebChartControl1.Series) {
            RadarPointSeriesView view = (RadarPointSeriesView)series.View;
            view.PointMarkerOptions.Kind = item.MarkerKind;
            if(pointCount != 0)
                view.PointMarkerOptions.StarPointCount = pointCount;
        }
    }
    void PerformDiagramTypeAction() {
        Diagram.DrawingStyle = (RadarDiagramDrawingStyle)ComboBoxHelper.GetSelectedItem(cbDiagramType, typeof(RadarDiagramDrawingStyle));
    }
    void PerformMarkerSizeAction() {
        int size = Convert.ToInt32(cbMarkerSize.SelectedItem.Text);
        foreach(Series series in WebChartControl1.Series)
            ((RadarPointSeriesView)series.View).PointMarkerOptions.Size = size;
    }
    void PerformTextDirectionAction() {
        RadarAxisXLabel label = Diagram.AxisX.Label;
        label.TextDirection = (RadarAxisXLabelTextDirection)ComboBoxHelper.GetSelectedItem(cbTextDirection, typeof(RadarAxisXLabelTextDirection));
    }
    void PerformShowMarkersAction() {
        foreach (Series series in WebChartControl1.Series)
            ((RadarLineSeriesView)series.View).MarkerVisibility = cbShowMarkers.Checked ? DefaultBoolean.True : DefaultBoolean.False;
    }
}

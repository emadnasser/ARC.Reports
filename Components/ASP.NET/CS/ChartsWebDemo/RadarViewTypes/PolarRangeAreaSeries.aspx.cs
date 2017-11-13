using System;
using System.Web.UI.WebControls;
using DevExpress.Utils;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;

public partial class PolarRangeAreaSeries : ChartBasePage {
	const int defaultPointsCount = 72;

    Series Series { get { return WebChartControl1.Series[0]; } }
    RadarRangeAreaSeriesView View { get { return (RadarRangeAreaSeriesView)Series.View; } }
    RadarDiagram Diagram { get { return (RadarDiagram)WebChartControl1.Diagram; } }

	protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            cbShowLabels.Checked = Series.LabelsVisibility == DefaultBoolean.True;
            cbShowMarkers.Checked = View.Marker1Visibility == DefaultBoolean.True;
            ComboBoxHelper.PrepareMarkerKindComboBox(cbMarkerKind, View.Marker1.Kind, View.Marker1.StarPointCount);
            ComboBoxHelper.PrepareMarkerSizeComboBox(cbMarkerSize, View.Marker1.Size);
            ComboBoxHelper.PrepareComboBox(cbDiagramType, Diagram.DrawingStyle);
            ComboBoxHelper.PrepareFunctionTypeComboBox(cbFunctionType);
            Series.Points.AddRange(PolarFunctionCalculator.GenerateFunctionPoints(2, defaultPointsCount, 2));
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
        else if (e.Parameter == "FunctionType")
            PerformFunctionTypeAction();
        else if (e.Parameter == "ShowMarkers")
            PerformShowMarkersAction();
    }
    void PerformShowLabelsAction() {
        Series.LabelsVisibility = cbShowLabels.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        WebChartControl1.ToolTipEnabled = cbShowLabels.Checked ? DefaultBoolean.False : DefaultBoolean.True;
    }
    void PerformMarkerKindAction() {
        MarkerKindItem item = ComboBoxHelper.GetSelectedMarkerKindItem(cbMarkerKind);
        int pointCount = 0;
        StarMarkerKindItem starItem = item as StarMarkerKindItem;
        if(starItem != null)
            pointCount = starItem.PointCount;
        foreach(Series series in WebChartControl1.Series) {
            var view = (RadarRangeAreaSeriesView)series.View;
            view.Marker1.Kind = item.MarkerKind;
            view.Marker2.Kind = item.MarkerKind;
            if (pointCount != 0)
                view.PointMarkerOptions.StarPointCount = pointCount;
        }
    }
    void PerformDiagramTypeAction() {
        Diagram.DrawingStyle = (RadarDiagramDrawingStyle)ComboBoxHelper.GetSelectedItem(cbDiagramType, typeof(RadarDiagramDrawingStyle));
    }
    void PerformMarkerSizeAction() {
        View.Marker1.Size = Convert.ToInt32(cbMarkerSize.SelectedItem.Text);
        View.Marker2.Size = Convert.ToInt32(cbMarkerSize.SelectedItem.Text);
    }
    void PerformFunctionTypeAction() {
        Series.Points.Clear();
        Series.Points.AddRange(PolarFunctionCalculator.GenerateFunctionPoints(cbFunctionType.SelectedIndex, defaultPointsCount, 2));
    }
    void PerformShowMarkersAction() {
        View.Marker1Visibility = cbShowMarkers.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        View.Marker2Visibility = cbShowMarkers.Checked ? DefaultBoolean.True : DefaultBoolean.False;
    }
}

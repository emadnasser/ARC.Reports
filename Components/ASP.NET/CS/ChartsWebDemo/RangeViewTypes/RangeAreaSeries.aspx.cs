using System;
using DevExpress.Utils;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;

public partial class RangeAreaSeries : ChartBasePage {
    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            Series series = WebChartControl1.Series[0];
            RangeAreaSeriesView view = (RangeAreaSeriesView)series.View;

            cbShowLabels.Checked = series.LabelsVisibility == DefaultBoolean.True;
            cbShowMarker1.Checked = view.Marker1Visibility == DefaultBoolean.True;
            cbShowMarker2.Checked = view.Marker2Visibility == DefaultBoolean.True;
            ComboBoxHelper.PrepareComboBox(cbLabelKind, new string[] { "One Label", "Two Labels", "Min Value Label", "Max Value Label", "Value 1 Label", "Value 2 Label" }, "Two Labels");
            ComboBoxHelper.PrepareMarkerKindComboBox(cbMarker1Kind, view.Marker1.Kind, view.Marker1.StarPointCount);
            ComboBoxHelper.PrepareMarkerSizeComboBox(cbMarker1Size, view.Marker1.Size);
            ComboBoxHelper.PrepareMarkerKindComboBox(cbMarker2Kind, view.Marker2.Kind, view.Marker2.StarPointCount);
            ComboBoxHelper.PrepareMarkerSizeComboBox(cbMarker2Size, view.Marker2.Size);
        }
        lblMarker1Kind.ClientEnabled = cbShowMarker1.Checked;
        cbMarker1Kind.ClientEnabled = cbShowMarker1.Checked;
        lblMarker1Size.ClientEnabled = cbShowMarker1.Checked;
        cbMarker1Size.ClientEnabled = cbShowMarker1.Checked;
        lblMarker2Kind.ClientEnabled = cbShowMarker2.Checked;
        cbMarker2Kind.ClientEnabled = cbShowMarker2.Checked;
        lblMarker2Size.ClientEnabled = cbShowMarker2.Checked;
        cbMarker2Size.ClientEnabled = cbShowMarker2.Checked;
        lblLabelKind.ClientEnabled = cbShowLabels.Checked;
        cbLabelKind.ClientEnabled = cbShowLabels.Checked;
    }
    void PerformShowMarker1Action() {
        foreach (Series series in WebChartControl1.Series)
            ((RangeAreaSeriesView)series.View).Marker1Visibility = cbShowMarker1.Checked ? DefaultBoolean.True : DefaultBoolean.False;
    }
    void PerformShowMarker2Action() {
        foreach (Series series in WebChartControl1.Series)
            ((RangeAreaSeriesView)series.View).Marker2Visibility = cbShowMarker2.Checked ? DefaultBoolean.True : DefaultBoolean.False;
    }
    void PerformMarkerKindAction(Marker marker, MarkerKindItem item) {
        int pointCount = 0;
        StarMarkerKindItem starItem = item as StarMarkerKindItem;
        if (starItem != null)
            pointCount = starItem.PointCount;
        marker.Kind = item.MarkerKind;
        if (pointCount != 0)
            marker.StarPointCount = pointCount;
    }
    void PerformMarker1KindAction() {
        MarkerKindItem item = ComboBoxHelper.GetSelectedMarkerKindItem(cbMarker1Kind);
        Marker marker1 = ((RangeAreaSeriesView)WebChartControl1.Series[0].View).Marker1;
        PerformMarkerKindAction(marker1, item);
    }
    void PerformMarker2KindAction() {
        MarkerKindItem item = ComboBoxHelper.GetSelectedMarkerKindItem(cbMarker2Kind);
        Marker marker2 = ((RangeAreaSeriesView)WebChartControl1.Series[0].View).Marker2;
        PerformMarkerKindAction(marker2, item);
    }
    void PerformMarker1SizeAction() {
        int size = Convert.ToInt32(cbMarker1Size.SelectedItem.Text);
        foreach (Series series in WebChartControl1.Series)
            ((RangeAreaSeriesView)series.View).Marker1.Size = size;
    }
    void PerformMarker2SizeAction() {
        int size = Convert.ToInt32(cbMarker2Size.SelectedItem.Text);
        foreach (Series series in WebChartControl1.Series)
            ((RangeAreaSeriesView)series.View).Marker2.Size = size;
    }
    void PerformLabelKindAction() {
        RangeAreaLabelKind kind;
        switch ((string)cbLabelKind.Value) {
            case "One Label":
                kind = RangeAreaLabelKind.OneLabel;
                break;
            case "Two Labels":
                kind = RangeAreaLabelKind.TwoLabels;
                break;
            case "Min Value Label":
                kind = RangeAreaLabelKind.MinValueLabel;
                break;
            case "Max Value Label":
                kind = RangeAreaLabelKind.MaxValueLabel;
                break;
            case "Value 1 Label":
                kind = RangeAreaLabelKind.Value1Label;
                break;
            case "Value 2 Label":
                kind = RangeAreaLabelKind.Value2Label;
                break;
            default:
                kind = RangeAreaLabelKind.OneLabel;
                break;
        }
        foreach (Series series in WebChartControl1.Series) {
            RangeAreaSeriesLabel label = (RangeAreaSeriesLabel)series.Label;
            label.Kind = kind;
            if (label.Kind == RangeAreaLabelKind.OneLabel)
                series.Label.TextPattern = "{VD:F2}";
            else
                series.Label.TextPattern = "{V:F2}";
        }
    }
    void PerformShowLabelsAction() {
        foreach (Series series in WebChartControl1.Series)
            series.LabelsVisibility = cbShowLabels.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        WebChartControl1.CrosshairEnabled = cbShowLabels.Checked ? DefaultBoolean.False : DefaultBoolean.True;
    }
    protected void WebChartControl1_CustomCallback(object sender, CustomCallbackEventArgs e) {
        if (e.Parameter == "ShowMarker1")
            PerformShowMarker1Action();
        else if (e.Parameter == "Marker1Kind")
            PerformMarker1KindAction();
        else if (e.Parameter == "Marker1Size")
            PerformMarker1SizeAction();
        if (e.Parameter == "ShowMarker2")
            PerformShowMarker2Action();
        else if (e.Parameter == "Marker2Kind")
            PerformMarker2KindAction();
        else if (e.Parameter == "Marker2Size")
            PerformMarker2SizeAction();
        else if (e.Parameter == "LabelKind")
            PerformLabelKindAction();
        else if (e.Parameter == "ShowLabels")
            PerformShowLabelsAction();
    }
}

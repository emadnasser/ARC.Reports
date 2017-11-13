using System;
using DevExpress.XtraCharts;
using DevExpress.Utils;

public partial class ScatterLineSeries : ChartBasePage {
    const int a = 10;
    const int archimedeanSpiralIndex = 0;
    const int cardioidIndex = 1;
    const int cartesianFoliumIndex = 2;

    SeriesCollection Series { get { return WebChartControl1.Series; } }
    Series ArchimedeanSpiralSeries { get { return Series[archimedeanSpiralIndex]; } }
    Series CardioidSeries { get { return Series[cardioidIndex]; } }
    Series CartesianFoliumSeries { get { return Series[cartesianFoliumIndex]; } }

    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            cbShowLabels.Checked = ArchimedeanSpiralSeries.LabelsVisibility == DevExpress.Utils.DefaultBoolean.True;
            ScatterLineSeriesView view = WebChartControl1.Series[0].View as ScatterLineSeriesView;
            cbShowMarkers.Checked = view.MarkerVisibility != DefaultBoolean.False;
            ComboBoxHelper.PrepareMarkerKindComboBox(cbMarkerKind, view.PointMarkerOptions.Kind, view.PointMarkerOptions.StarPointCount);
            ComboBoxHelper.PrepareMarkerSizeComboBox(cbMarkerSize, view.PointMarkerOptions.Size);
            ComboBoxHelper.PrepareFunctionTypeScatterLineComboBox(cbFunctionType);
            PerformFunctionTypeAction();
        }
        lblMarkerKind.ClientEnabled = cbShowMarkers.Checked;
        lblMarkerSize.ClientEnabled = cbShowMarkers.Checked;
        cbMarkerKind.ClientEnabled = cbShowMarkers.Checked;
        cbMarkerSize.ClientEnabled = cbShowMarkers.Checked;
    }
    void CreateArchimedeanSpiralPoints() {
        for (int i = 0; i < 720; i += 10) {
            double t = (double)i / 180 * Math.PI;
            double x = t * Math.Cos(t);
            double y = t * Math.Sin(t);
            ArchimedeanSpiralSeries.Points.Add(new SeriesPoint(x, y));
        }
    }
    void CreateCardioidPoints() {
        for (int i = 0; i < 360; i += 10) {
            double t = (double)i / 180 * Math.PI;
            double x = a * (2 * Math.Cos(t) - Math.Cos(2 * t));
            double y = a * (2 * Math.Sin(t) - Math.Sin(2 * t));
            CardioidSeries.Points.Add(new SeriesPoint(x, y));
        }
    }
    void CreateCartesianFoliumPoints() {
        for (int i = -30; i < 125; i += 5) {
            double t = Math.Tan((double)i / 180 * Math.PI);
            double x = 3 * (double)a * t / (t * t * t + 1);
            double y = x * t;
            CartesianFoliumSeries.Points.Add(new SeriesPoint(x, y));
        }
    }
    void ShowSeries(Series visibleSeries) {
        foreach (Series series in Series) {
            if (series == visibleSeries)
                visibleSeries.Visible = true;
            else
                series.Visible = false;
        }
    }
    void PerformShowLabelsAction() {
        foreach(Series series in Series)
            series.LabelsVisibility = cbShowLabels.Checked ? DevExpress.Utils.DefaultBoolean.True : DevExpress.Utils.DefaultBoolean.False;
        WebChartControl1.ToolTipEnabled = cbShowLabels.Checked ? DevExpress.Utils.DefaultBoolean.False : DevExpress.Utils.DefaultBoolean.True;
    }
    void PerformMarkerKindAction() {
        MarkerKindItem item = ComboBoxHelper.GetSelectedMarkerKindItem(cbMarkerKind);
        int pointCount = 0;
        StarMarkerKindItem starItem = item as StarMarkerKindItem;
        if (starItem != null)
            pointCount = starItem.PointCount;
        foreach (Series series in WebChartControl1.Series) {
            ScatterLineSeriesView view = (ScatterLineSeriesView)series.View;
            view.PointMarkerOptions.Kind = item.MarkerKind;
            if (pointCount != 0)
                view.PointMarkerOptions.StarPointCount = pointCount;
        }
    }
    void PerformMarkerSizeAction() {
        foreach (Series series in Series)
            ((ScatterLineSeriesView)series.View).LineMarkerOptions.Size = Convert.ToInt32(cbMarkerSize.SelectedItem.Text);
    }
    void PerformFunctionTypeAction() {
        if (cbFunctionType.SelectedIndex == archimedeanSpiralIndex) {
            if (ArchimedeanSpiralSeries.Points.Count == 0)
                CreateArchimedeanSpiralPoints();
            ShowSeries(ArchimedeanSpiralSeries);
        }
        else if (cbFunctionType.SelectedIndex == cardioidIndex) {
            if (CardioidSeries.Points.Count == 0)
                CreateCardioidPoints();
            ShowSeries(CardioidSeries);
        }
        else if (cbFunctionType.SelectedIndex == cartesianFoliumIndex) {
            if (CartesianFoliumSeries.Points.Count == 0)
                CreateCartesianFoliumPoints();
            ShowSeries(CartesianFoliumSeries);
        }
    }
    void PerformShowMarkersAction() {
        foreach (Series series in Series)
            ((ScatterLineSeriesView)series.View).MarkerVisibility = cbShowMarkers.Checked ? DefaultBoolean.True : DefaultBoolean.False;
    }
    protected void WebChartControl1_CustomCallback(object sender, DevExpress.XtraCharts.Web.CustomCallbackEventArgs e) {
        if (e.Parameter == "ShowLabels")
            PerformShowLabelsAction();
        else if (e.Parameter == "MarkerKind")
            PerformMarkerKindAction();
        else if (e.Parameter == "MarkerSize")
            PerformMarkerSizeAction();
        else if (e.Parameter == "FunctionType")
            PerformFunctionTypeAction();
        else if (e.Parameter == "ShowMarkers")
            PerformShowMarkersAction();
    }
}

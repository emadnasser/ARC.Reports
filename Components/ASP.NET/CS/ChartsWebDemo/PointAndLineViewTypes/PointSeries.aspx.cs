using System;
using System.Drawing;
using DevExpress.XtraCharts;

public partial class PointSeries : ChartBasePage {
    static Point[] CalcRandomPoints(Random random, int count, int xMin, int xMax, int yMin, int yMax) {
        if (count > Math.Abs(xMax - xMin) * Math.Abs(yMax - yMin))
            throw new ArgumentException("Parameter \"count\" very large. Can't calculate unique random points.");
        Point[] points = new Point[count];
        for (int i = 0; i < points.Length; i++) {
            bool repeat;
            do {
                repeat = false;
                points[i].X = random.Next(xMin, xMax);
                points[i].Y = random.Next(yMin, yMax);
                for (int k = 0; k < i; k++)
                    if (points[k] == points[i]) {
                        repeat = true;
                        break;
                    }
            } while (repeat);
        }
        return points;
    }
    static SeriesPoint[] CalcRandomSeriesPoints(Random random, int count, int xMin, int xMax, int yMin, int yMax) {
        Point[] points = CalcRandomPoints(random, count, xMin, xMax, yMin, yMax);
        SeriesPoint[] seriesPoints = new SeriesPoint[points.Length];
        for (int i = 0; i < points.Length; i++)
            seriesPoints[i] = new SeriesPoint(points[i].X.ToString(), new double[] { points[i].Y });
        return seriesPoints;
    }

    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            InitSeries();
            Series series = WebChartControl1.Series[0];
            PointSeriesLabel label = (PointSeriesLabel)series.Label;
            PointSeriesView view = (PointSeriesView)series.View;

            cbShowLabels.Checked = series.LabelsVisibility == DevExpress.Utils.DefaultBoolean.True;
            ComboBoxHelper.PrepareLabelAngleComboBox(cbLabelAngle, label.Angle);
            ComboBoxHelper.PrepareMarkerKindComboBox(cbMarkerKind, view.PointMarkerOptions.Kind, view.PointMarkerOptions.StarPointCount);
            ComboBoxHelper.PrepareMarkerSizeComboBox(cbMarkerSize, view.PointMarkerOptions.Size);
        }
        lblLabelAngle.ClientEnabled = cbShowLabels.Checked;
        cbLabelAngle.ClientEnabled = cbShowLabels.Checked;
        lblLabelPosition.ClientEnabled = cbShowLabels.Checked;
        cbLabelPosition.ClientEnabled = cbShowLabels.Checked;
    }
    void InitSeries() {
        Random random = new Random();
        WebChartControl1.Series[0].Points.Clear();
        WebChartControl1.Series[0].Points.AddRange(CalcRandomSeriesPoints(random, 20, 1, 8, 5, 12));
        WebChartControl1.Series[1].Points.Clear();
        WebChartControl1.Series[1].Points.AddRange(CalcRandomSeriesPoints(random, 20, 9, 16, 1, 8));
        WebChartControl1.Series[2].Points.Clear();
        WebChartControl1.Series[2].Points.AddRange(CalcRandomSeriesPoints(random, 20, 6, 13, 14, 21));
    }
    void PerformLabelAngleAction() {
        int labelAngle = Convert.ToInt32(cbLabelAngle.SelectedItem.Text);
        foreach(Series series in WebChartControl1.Series)
            ((PointSeriesLabel)series.Label).Angle = labelAngle;
    }
    void PerformLabelPositionAction() {
        PointLabelPosition labelPosition = (PointLabelPosition)cbLabelPosition.SelectedIndex;
        foreach (Series series in WebChartControl1.Series)
            ((PointSeriesLabel)series.Label).Position = labelPosition;
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
        int size = Convert.ToInt32(cbMarkerSize.SelectedItem.Text);
        foreach(Series series in WebChartControl1.Series)
            ((PointSeriesView)series.View).PointMarkerOptions.Size = size;
    }
    void PeformCreatePointsAction() {
        InitSeries();
    }
    void PerformShowLabelsAction() {
        foreach (Series series in WebChartControl1.Series)
            series.LabelsVisibility = cbShowLabels.Checked ? DevExpress.Utils.DefaultBoolean.True : DevExpress.Utils.DefaultBoolean.False;
        WebChartControl1.CrosshairEnabled = cbShowLabels.Checked ? DevExpress.Utils.DefaultBoolean.False : DevExpress.Utils.DefaultBoolean.True;
    }
    protected void WebChartControl1_CustomCallback(object sender, DevExpress.XtraCharts.Web.CustomCallbackEventArgs e) {
        if (e.Parameter == "LabelAngle")
            PerformLabelAngleAction();
        if (e.Parameter == "LabelPosition")
            PerformLabelPositionAction();
        else if (e.Parameter == "MarkerKind")
            PerformMarkerKindAction();
        else if (e.Parameter == "MarkerSize")
            PerformMarkerSizeAction();
        else if (e.Parameter == "CreatePoints")
            PeformCreatePointsAction();
        else if (e.Parameter == "ShowLabels")
            PerformShowLabelsAction();
    }
}

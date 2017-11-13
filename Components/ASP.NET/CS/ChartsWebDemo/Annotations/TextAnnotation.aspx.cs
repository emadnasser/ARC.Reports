using System;
using System.Drawing;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;
using DevExpress.Web;

public partial class TextAnnotationDemo : ChartBasePage {
    void AddAnnotation(SeriesPoint point, bool isMaximum) {
        TextAnnotation annotation = point.Annotations.AddTextAnnotation();
        if (isMaximum) {
            annotation.Name = "Maximum";
            annotation.Text = "This is a <b><size=+3>maximum</size></b> point.";
        }
        else {
            annotation.Name = "Minimum";
            annotation.Text = "This is a <b><size=+3>minimum</size></b> point.";
        }
        RelativePosition position = annotation.ShapePosition as RelativePosition;
        SeriesPointAnchorPoint anchorPoint = annotation.AnchorPoint as SeriesPointAnchorPoint;
        if (position != null && anchorPoint != null) {
            position.ConnectorLength = 75;
            if (anchorPoint.SeriesPoint.NumericalArgument > 5)
                position.Angle = 125;
        }
    }
    void GeneratePoints() {
        Random random = new Random();
        Series series = WebChartControl1.Series[0];
        series.Points.Clear();
        SeriesPoint maxPoint = null;
        SeriesPoint minPoint = null;
        for (int i = 0; i < 10; i++) {
            double value = Math.Round(random.NextDouble() * 8, 2) + 2;
            SeriesPoint point = new SeriesPoint(i + 1, value);
            if (maxPoint == null || value > maxPoint.Values[0])
                maxPoint = point;
            if (minPoint == null || value < minPoint.Values[0])
                minPoint = point;
            series.Points.Add(point);
        }
        AddAnnotation(maxPoint, true);
        AddAnnotation(minPoint, false);
    }
    void Update() {
        WebChartControl1.Series[0].LabelsVisibility = chbShowLabels.Checked ? DevExpress.Utils.DefaultBoolean.True : DevExpress.Utils.DefaultBoolean.False;
        foreach (TextAnnotation annotation in WebChartControl1.AnnotationRepository) {
            if (cbAngle.SelectedItem != null)
                annotation.Angle = Convert.ToInt32(cbAngle.SelectedItem.Value);
            annotation.ConnectorStyle = (AnnotationConnectorStyle)cbConnector.SelectedIndex;
            annotation.ShapeKind = (ShapeKind)cbShape.SelectedIndex;
        }
    }
    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            GeneratePoints();
            for (int i = 0; i < 360; i += 45)
                cbAngle.Items.Add(new ListEditItem(i.ToString(), i));
            cbAngle.SelectedIndex = 0;
        }
        Update();
    }
    protected void WebChartControl1_CustomCallback(object sender, CustomCallbackEventArgs e) {
        if (e.Parameter == "Points")
            GeneratePoints();
        Update();
    }
}

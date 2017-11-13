using System;
using DevExpress.Utils;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;

public partial class RegressionLines : ChartBasePage {
    const int xMin = 0;
    const int xMax = 100;
    const int pointCount = 40;    
    readonly Random random = new Random();

    Series Series { get { return WebChartControl1.Series[0]; } }
    RegressionLine RegressionLine {
        get { return (RegressionLine)((XYDiagramSeriesViewBase)Series.View).Indicators[0]; }
    }

    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            InitSeries();
            Series series = WebChartControl1.Series[0];
            PointSeriesView view = (PointSeriesView)series.View;

            cbShowLabels.Checked = series.LabelsVisibility == DefaultBoolean.True;
            ComboBoxHelper.PrepareRegressionLineColorComboBox(cbColor);
            ComboBoxHelper.PrepareDashStyleCombobox(cbDashStyle, RegressionLine.LineStyle.DashStyle);
            spnThickness.Value = RegressionLine.LineStyle.Thickness;
        }
    }
    void InitSeries() {
        if (Series != null && Series.View.GetType().Equals(typeof(PointSeriesView))) {
            Series.Points.Clear();
            Series.Points.AddRange(CalcRandomPointsAroundLine());
        }
    }
    void PeformCreatePointsAction() {
        InitSeries();
    }
    void PerformShowLabelsAction() {
        Series.LabelsVisibility = cbShowLabels.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        WebChartControl1.CrosshairEnabled = cbShowLabels.Checked ? DefaultBoolean.False : DefaultBoolean.True;
    }
    void PerformColorAction() {
        RegressionLine.Color = ComboBoxHelper.GetSelectedRegressionLineColor(cbColor);
    }
    void PerformDashStyleAction() {
        RegressionLine.LineStyle.DashStyle = (DashStyle)ComboBoxHelper.GetSelectedItem(cbDashStyle, typeof(DashStyle));
    }
    void PerformThicknessAction() {
        RegressionLine.LineStyle.Thickness = Convert.ToInt32(spnThickness.Value);
    }
    double[] CalcRandomY(int[] arrayX) {
        double k = (double)random.Next(-100, 100) / 10;
        if (k < 0.1 && k >= 0)
            k = 0.1;
        if (k > -0.1 && k < 0)
            k = -0.1;
        double b = (double)random.Next(-100, 100) / 10;
        double deviation = Math.Abs(k * (xMax - xMin) * 0.4);
        double[] arrayY = new double[arrayX.Length];
        for (int i = 0; i < arrayY.Length; i++) {
            bool isNegativeDelta = random.Next(0, 1) == 0;
            double delta = deviation * random.NextDouble();
            if (isNegativeDelta)
                delta = -delta;
            arrayY[i] = k * arrayX[i] + b + delta;
        }
        return arrayY;
    }
    int[] CalcRandomX() {
        int[] arrayX = new int[pointCount];
        for (int i = 0; i < arrayX.Length; i++)
            arrayX[i] = random.Next(xMin, xMax);
        return arrayX;
    }
    SeriesPoint[] CalcRandomPointsAroundLine() {
        int[] arrayX = CalcRandomX();
        double[] arrayY = CalcRandomY(arrayX);
        SeriesPoint[] seriesPoints = new SeriesPoint[arrayX.Length];
        for (int i = 0; i < arrayX.Length; i++)
            seriesPoints[i] = new SeriesPoint(arrayX[i], arrayY[i]);
        return seriesPoints;
    }
    protected void WebChartControl1_CustomCallback(object sender, CustomCallbackEventArgs e) {
        if (e.Parameter == "Color")
            PerformColorAction();
        else if (e.Parameter == "DashStyle")
            PerformDashStyleAction();
        else if (e.Parameter == "Thickness")
            PerformThicknessAction();
        else if (e.Parameter == "CreatePoints")
            PeformCreatePointsAction();
        else if (e.Parameter == "ShowLabels")
            PerformShowLabelsAction();
    }
}

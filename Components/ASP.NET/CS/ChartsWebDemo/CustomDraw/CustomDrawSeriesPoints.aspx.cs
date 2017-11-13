using System;
using System.Drawing;
using DevExpress.XtraCharts;

public partial class CustomDrawSeriesPoints : ChartBasePage {
    Series Series { get { return WebChartControl1.Series[0]; } }

    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            InitSeries();
            cbShowLabels.Checked = Series.LabelsVisibility == DevExpress.Utils.DefaultBoolean.True;
            cbCustomDraw.Checked = true;
            SetPointsColor(cbCustomDraw.Checked);
        }
    }    
    protected void WebChartControl1_CustomDrawSeriesPoint(object sender, CustomDrawSeriesPointEventArgs e) {
        if (cbCustomDraw.Checked) {
            string color = GetColorName(e.SeriesPoint[0]); 
            if (!String.IsNullOrEmpty(color))
                e.LabelText = color + ": " + e.LabelText;
        }
    }
    protected void WebChartControl1_CustomCallback(object sender, DevExpress.XtraCharts.Web.CustomCallbackEventArgs e) {
        if (e.Parameter == "ShowLabels")
            PerformShowLabelsAction();
        else if (e.Parameter == "CreateBars")
            InitSeries();
        else if (e.Parameter == "CustomDraw")
            SetPointsColor(cbCustomDraw.Checked);
    }
    void PerformShowLabelsAction() {
        Series.LabelsVisibility = cbShowLabels.Checked ? DevExpress.Utils.DefaultBoolean.True : DevExpress.Utils.DefaultBoolean.False;
    }
    void InitSeries() {
        Random random = new Random();
        Series.Points.Clear();
        for (int i = 0; i < 25; i++)
            Series.Points.Add(new SeriesPoint(i.ToString(), new double[] { random.NextDouble() * 3 }));
        SetPointsColor(cbCustomDraw.Checked);
    }
    string GetColorName(double val) {
        if (val < 1)
            return "Green";
        else if (val < 2)
            return "Yellow";
        else
            return "Red";
    }
    void SetPointsColor(bool colorize) {
        if (Series != null && SupportType()) {
            for (int i = 0; i < Series.Points.Count; i++)
                SetColor(Series.Points[i], colorize);
        }
    }
    bool SupportType() {
        return WebChartControl1.Series[0].View is SideBySideBarSeriesView ||
               WebChartControl1.Series[0].View is LineSeriesView ||
               WebChartControl1.Series[0].View is AreaSeriesView ||
               WebChartControl1.Series[0].View is PointSeriesView;
    }
    void SetColor(SeriesPoint point, bool colorize) {
        double val = point.Values[0];
        Color color;
        if (colorize) {
            if (val < 1)
                color = Color.FromArgb(81, 137, 3);
            else if (val < 2)
                color = Color.FromArgb(249, 170, 15);
            else
                color = Color.FromArgb(199, 57, 12);
        }
        else
            color = Color.Empty;
        point.Color = color;
    }
    protected void cbCustomDraw_CheckedChanged(object sender, EventArgs e) {
        SetPointsColor(cbCustomDraw.Checked);
    }
}

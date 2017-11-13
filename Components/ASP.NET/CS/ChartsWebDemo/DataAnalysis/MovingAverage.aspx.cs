using System;
using System.Globalization;
using System.Collections.Generic;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;
using System.Diagnostics;
using System.Data;

public partial class MovingAveragePage : ChartBasePage {
    Axis AxisX { get { return ((XYDiagram)WebChartControl1.Diagram).AxisX; } }
    Series Series { get { return WebChartControl1.Series[0]; } }
    List<MovingAverage> MovingAverageIndicators {
        get {
            if (WebChartControl1.Series.Count == 0)
                return null;
            XYDiagram2DSeriesViewBase view = WebChartControl1.Series[0].View as XYDiagram2DSeriesViewBase;
            if (view == null)
                return null;
            List<MovingAverage> movingAverageIndicators = new List<MovingAverage>();
            foreach (Indicator indicator in view.Indicators) {
                MovingAverage movingAverage = indicator as MovingAverage;
                if (movingAverage != null)
                    movingAverageIndicators.Add(movingAverage);
            }
            if (movingAverageIndicators != null)
                return movingAverageIndicators;
            return null;
        }
    }

    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            ComboBoxHelper.PrepareComboBox(cmbType, new string[] { "Simple", "Exponential", "Weighted", "Triangular", "Triple Exponential (TEMA)" });
            ComboBoxHelper.PrepareComboBox(cmbKind, new string[] { "Moving Average", "Envelope", "Moving Average And Envelope" });
            spnPointsCount.MaxValue = ((DataView)chartDataSource.Select()).Table.Rows.Count;
            if (MovingAverageIndicators.Count > 0)
                if (MovingAverageIndicators[0] != null) {
                    cmbKind.SelectedIndex = (int)MovingAverageIndicators[0].Kind;
                    spnPointsCount.Value = MovingAverageIndicators[0].PointsCount;
                    spnEnvelopePercent.Value = MovingAverageIndicators[0].EnvelopePercent;
                }
            SetVisibleIndicator();
        }
        bool enableEnvelopePercent = (string)cmbKind.Value == "Envelope" || (string)cmbKind.Value == "Moving Average And Envelope";
        lblEnvelopePercent.ClientEnabled = enableEnvelopePercent;
        spnEnvelopePercent.ClientEnabled = enableEnvelopePercent;
    }
    void SetVisibleIndicator() {
        switch ((string)cmbType.Value) {
            case "Simple":
                foreach (MovingAverage indicator in MovingAverageIndicators)
                    indicator.Visible = indicator is SimpleMovingAverage;
                break;
            case "Exponential":
                foreach (MovingAverage indicator in MovingAverageIndicators)
                    indicator.Visible = indicator is ExponentialMovingAverage;
                break;
            case "Weighted":
                foreach (MovingAverage indicator in MovingAverageIndicators)
                    indicator.Visible = indicator is WeightedMovingAverage;
                break;
            case "Triangular":
                foreach (MovingAverage indicator in MovingAverageIndicators)
                    indicator.Visible = indicator is TriangularMovingAverage;
                break;
            case "Triple Exponential (TEMA)":
                foreach (MovingAverage indicator in MovingAverageIndicators)
                    indicator.Visible = indicator is TripleExponentialMovingAverageTema;
                break;
            default:
                foreach (MovingAverage indicator in MovingAverageIndicators)
                    indicator.Visible = indicator is SimpleMovingAverage;
                break;
        }
    }
    protected void WebChartControl1_CustomCallback(object sender, DevExpress.XtraCharts.Web.CustomCallbackEventArgs e) {
        if (e.Parameter == "Type")
             PerformTypeAction();
        else if (e.Parameter == "Kind")
             PerformKindAction();
        else if (e.Parameter == "PointsCount")
             PerformPointsCountAction();
        else if (e.Parameter == "EnvelopePercent")
             PerformEnvelopePercentAction();
    }
    void PerformTypeAction() {
        SetVisibleIndicator();
    }
    void PerformKindAction() {
        foreach (MovingAverage indicator in MovingAverageIndicators)
            indicator.Kind = (MovingAverageKind)cmbKind.SelectedIndex;
    }
    void PerformPointsCountAction() {
        foreach (MovingAverage indicator in MovingAverageIndicators)
            indicator.PointsCount = Convert.ToInt32(spnPointsCount.Value);
    }
    void PerformEnvelopePercentAction() {
        foreach (MovingAverage indicator in MovingAverageIndicators)
            indicator.EnvelopePercent = Convert.ToDouble(spnEnvelopePercent.Value);
    }
}

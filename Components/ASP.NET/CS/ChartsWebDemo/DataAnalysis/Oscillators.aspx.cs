using System;
using DevExpress.Web;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;

public partial class Oscillators : ChartBasePage {
    StockSeriesView SeriesView { get { return (StockSeriesView)WebChartControl1.Series[0].View; } }
    XYDiagram Diagram { get { return (XYDiagram)WebChartControl1.Diagram; } }

    SeparatePaneIndicator CreateIndicator() {
        switch (cmbOscillator.SelectedIndex) {
            case 1:
                return new CommodityChannelIndex("(CCI) Commodity Channel Index");
            case 2:
                return new DetrendedPriceOscillator("(DPO) Detrended Price Oscillator");
            case 3:
                return new MovingAverageConvergenceDivergence("(MACD) Moving Average Convergence Divergence");
            case 4:
                return new RateOfChange("(RoC) Rate of Change");
            case 5:
                return new RelativeStrengthIndex("(RSI) Relative Strength Index");
            case 6:
                return new ChaikinsVolatility("(CHV) Chaikins Volatility");
            case 7:
                return new WilliamsR("(%R) Williams %R");
            case 0:
            default:
                return new AverageTrueRange("(ATR) Average True Range");
        }
    }
    protected void WebChartControl1_CustomCallback(object sender, CustomCallbackEventArgs e) {
        SeriesView.Indicators.Clear();
        SeparatePaneIndicator indicator = CreateIndicator();
        indicator.Pane = Diagram.Panes[0];
        indicator.AxisY = Diagram.SecondaryAxesY[0];
        SeriesView.Indicators.Add(indicator);
        ((TextAnnotation)WebChartControl1.Annotations[0]).Text = indicator.Name;
    }
    public override WebChartControl FindWebChartControl() {
        return WebChartControl1;
    }
}

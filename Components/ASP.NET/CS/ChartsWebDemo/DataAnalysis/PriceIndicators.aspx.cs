using System;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;

public partial class PriceIndicators : ChartBasePage {
    StockSeriesView SeriesView { get { return ((StockSeriesView)WebChartControl1.Series[0].View); } }
    Indicator PriceIndicator { get { return SeriesView.Indicators[0]; } }

    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            ComboBoxHelper.PrepareRegressionLineColorComboBox(cbColor);
            ComboBoxHelper.PrepareDashStyleCombobox(cbDashStyle, PriceIndicator.LineStyle.DashStyle);
            spnThickness.Value = PriceIndicator.LineStyle.Thickness;
        }
    }
    void PerformColorAction() {
        PriceIndicator.Color = ComboBoxHelper.GetSelectedRegressionLineColor(cbColor);
    }
    void PerformDashStyleAction() {
        PriceIndicator.LineStyle.DashStyle = (DashStyle)ComboBoxHelper.GetSelectedItem(cbDashStyle, typeof(DashStyle));
    }
    void PerformThicknessAction() {
        PriceIndicator.LineStyle.Thickness = Convert.ToInt32(spnThickness.Value);
    }
    void PeformUpdateIndicatorAction() {
        Indicator oldIndicator = PriceIndicator;
        SeriesView.Indicators.Clear();
        Indicator indicator = null;
        if (cmbPriceIndicator.SelectedIndex == 0)
            indicator = new MedianPrice("Median Price");
        else if (cmbPriceIndicator.SelectedIndex == 1)
            indicator = new TypicalPrice("Typical Price");
        else
            indicator = new WeightedClose("Weighted Close");
        indicator.Assign(oldIndicator);
        SeriesView.Indicators.Add(indicator);
    }
    protected void WebChartControl1_CustomCallback(object sender, CustomCallbackEventArgs e) {
        if (e.Parameter == "Color")
            PerformColorAction();
        else if (e.Parameter == "DashStyle")
            PerformDashStyleAction();
        else if (e.Parameter == "Thickness")
            PerformThicknessAction();
        else if (e.Parameter == "Indicator")
            PeformUpdateIndicatorAction();
    }
    public override WebChartControl FindWebChartControl() {
        return WebChartControl1;
    }
}

using System;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;

public partial class UserControls_Charts_ProductsRevenueChart : ChartUserControl {
    public override WebChartControl Chart { get { return RevenueChart; } }

    protected void Page_Load(object sender, EventArgs e) {
        Chart.Series[0].DataSource = DataProvider.GetRevenueChartData();
    }

    protected void RevenueChart_CustomDrawSeriesPoint(object sender, CustomDrawSeriesPointEventArgs e) {
        OnCustomDrawSeriesPoint(e);
    }
    protected void RevenueChart_CustomCallback(object sender, CustomCallbackEventArgs e) {
        ChangeChartWidth(Convert.ToInt32(e.Parameter));
    }
}

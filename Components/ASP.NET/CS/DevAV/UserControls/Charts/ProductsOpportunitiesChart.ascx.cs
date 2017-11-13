using System;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;

public partial class UserControls_Charts_ProductsOpportunitiesChart : ChartUserControl {
    public override WebChartControl Chart { get { return OpportunitiesChart; } }

    protected void Page_Load(object sender, EventArgs e) {
        OpportunitiesChart.Series[0].DataSource = DataProvider.GetOpportunitiesChartData();
    }

    protected void OpportunitiesChart_CustomDrawSeriesPoint(object sender, CustomDrawSeriesPointEventArgs e) {
        OnCustomDrawSeriesPoint(e);
    }
    protected void OpportunitiesChart_CustomCallback(object sender, CustomCallbackEventArgs e) {
        ChangeChartWidth(Convert.ToInt32(e.Parameter));
    }
}

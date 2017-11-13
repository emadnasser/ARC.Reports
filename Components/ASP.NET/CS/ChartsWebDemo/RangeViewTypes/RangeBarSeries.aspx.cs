using System;

public partial class RangeBarSeries : ChartBasePage {
    protected void Page_Load(object sender, EventArgs e) {
        WebChartControl1.Series[0].DataSource = SourceOfEnergy.GetEuropeBrentPrices();
        WebChartControl1.Series[1].DataSource = SourceOfEnergy.GetOkWtiPrices();
    }
}

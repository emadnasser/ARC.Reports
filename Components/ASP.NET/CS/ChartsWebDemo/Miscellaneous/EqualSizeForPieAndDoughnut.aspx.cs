using System;
using System.Drawing;
using DevExpress.Web;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;

public partial class PointSeries : ChartBasePage {
    
    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            cbMinAllowedSize.Items.Add(new ListEditItem("0%",     0));
            cbMinAllowedSize.Items.Add(new ListEditItem("10%",   10));
            cbMinAllowedSize.Items.Add(new ListEditItem("20%",   20));
            cbMinAllowedSize.Items.Add(new ListEditItem("30%",   30));
            cbMinAllowedSize.Items.Add(new ListEditItem("40%",   40));
            cbMinAllowedSize.Items.Add(new ListEditItem("50%",   50));
            cbMinAllowedSize.Items.Add(new ListEditItem("60%",   60));
            cbMinAllowedSize.Items.Add(new ListEditItem("70%",   70));
            cbMinAllowedSize.Items.Add(new ListEditItem("80%",   80));
            cbMinAllowedSize.Items.Add(new ListEditItem("90%",   90));
            cbMinAllowedSize.Items.Add(new ListEditItem("100%", 100));
            cbMinAllowedSize.SelectedIndex = 0;
            cbView.Items.Add("Pie");
            cbView.Items.Add("Doughnut");
            cbView.SelectedIndex = 0;
        }
    }
    void PerformSetEqualPieSizeAction() {
        ((SimpleDiagram)WebChartControl1.Diagram).EqualPieSize = chbEqualSize.Checked;
    }
    void PerformSetMinAllowedSizePercentageAction() {
        ((PieSeriesView)WebChartControl1.Series["Condiments"].View).MinAllowedSizePercentage = int.Parse((string)cbMinAllowedSize.SelectedItem.Value);
    }
    void PerformChangeViewAction() {
        if ((string)cbView.SelectedItem.Text == "Pie")
            foreach (Series series in WebChartControl1.Series)
                series.ChangeView(ViewType.Pie);
        else
            foreach (Series series in WebChartControl1.Series)
                series.ChangeView(ViewType.Doughnut);
    }
    void PerformRestoreDefaultLayoutAction() {
        PerformChangeViewAction();
        PerformSetEqualPieSizeAction();
        PerformSetMinAllowedSizePercentageAction();
    }

    protected void WebChartControl1_CustomCallback(object sender, CustomCallbackEventArgs e) {
        if (e.Parameter == "EqualSize")
            PerformSetEqualPieSizeAction();
        else if (e.Parameter == "MinAllowedSize")
            PerformSetMinAllowedSizePercentageAction();
        else if (e.Parameter == "View")
            PerformChangeViewAction();
        else if (e.Parameter == "Reset")
            PerformRestoreDefaultLayoutAction();
    }

}

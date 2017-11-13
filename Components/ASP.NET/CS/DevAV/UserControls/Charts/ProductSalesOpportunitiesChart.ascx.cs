using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using DevExpress.DevAV;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraCharts.Web;

public partial class UserControls_Charts_ProductSalesOpportunitiesChart : ChartUserControl {
    long selectedItemID = DataProvider.emptyEntryID;

    public override WebChartControl Chart { get { return SalesOpportunitiesChart; } }

    public override long SelectedItemID {
        get { return selectedItemID; }
        set {
            selectedItemID = value;
            LoadChartData();
        }
    }
    public Product SelectedProduct { get { return DataProvider.Products.FirstOrDefault(p => p.Id == SelectedItemID); } }

    protected void LoadChartData() {
        var product = SelectedProduct;
        if(product == null)
            return;

        SalesOpportunitiesChart.GetSeriesByName("Sales").DataSource = DataProvider.GetProductSalesChartData(product);
        SalesOpportunitiesChart.GetSeriesByName("Opportunities").DataSource = DataProvider.GetProductOpportunitiesChartData(product);
    }

    public void CreateImage(string imagePath, List<DataEntryInfo> sales, List<DataEntryInfo> opportunities) {
        SalesOpportunitiesChart.GetSeriesByName("Sales").DataSource = sales;
        SalesOpportunitiesChart.GetSeriesByName("Opportunities").DataSource = opportunities;
        ((IChartContainer)SalesOpportunitiesChart).Chart.ExportToImage(imagePath, ImageFormat.Png);
    }
}

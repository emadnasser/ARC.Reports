using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxPivotGrid;

public partial class ProductReports : Page {

    public enum ProductReportKind {
        CategorySales, IntervalGrouping, AverageSales,
        ProductSales, MultipleSubtotals, Top3Products
    }

    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack)
            UpdatePivotGridFieldLayout();
    }
    protected void tblDemoKind_SelectedIndexChanged(object sender, EventArgs e) {
        UpdatePivotGridFieldLayout();
    }
    protected void ddlIntervalGrouping_SelectedIndexChanged(object sender, EventArgs e) {
        UpdatePivotGridFieldLayout();
    }
    protected void cbProductSales_CheckedChanged(object sender, EventArgs e) {
        UpdatePivotGridFieldLayout();
    }
    protected void cbShowOthers_CheckedChanged(object sender, EventArgs e) {
        UpdatePivotGridFieldLayout();
    }
    void UpdatePivotGridFieldLayout() {
        int index = tblDemoKind.SelectedIndex > -1 ? tblDemoKind.SelectedIndex : 0;
        ChangePivotGridFieldLayout((ProductReportKind)index);
    }
    void ChangePivotGridFieldLayout(ProductReportKind kind) {
        pivotGrid.BeginUpdate();
        foreach(PivotGridField field in pivotGrid.Fields) {
            field.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea;
            field.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Ascending;
        }
        pnlIntervalGrouping.Visible = kind == ProductReportKind.IntervalGrouping;
        cbProductSales.Visible = kind == ProductReportKind.ProductSales;
        cbShowOthers.Visible = kind == ProductReportKind.Top3Products;

        pivotGrid.Fields["Sales"].Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
        pivotGrid.Fields["Category"].Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
        pivotGrid.Fields["Category"].AreaIndex = 0;
        pivotGrid.Fields["Category"].TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.AutomaticTotals;
        pivotGrid.Fields["AvgSale"].Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
        pivotGrid.Fields["MinSale"].Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
        pivotGrid.Fields["AvgSale"].Visible = kind == ProductReportKind.AverageSales;
        pivotGrid.Fields["MinSale"].Visible = kind == ProductReportKind.AverageSales;
        pivotGrid.Fields["Product"].SortBySummaryInfo.FieldName = "";
        pivotGrid.Fields["Product"].TopValueCount = 0;

        switch(kind) {
            case ProductReportKind.CategorySales:
                break;
            case ProductReportKind.IntervalGrouping:
                pivotGrid.Fields["Product"].Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
                pivotGrid.Fields["Product"].AreaIndex = 1;
                ApplyIntervalGrouping();
                break;
            case ProductReportKind.AverageSales:
                pivotGrid.Fields["Quarter"].Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
                pivotGrid.Fields["Quarter"].AreaIndex = 0;
                break;
            case ProductReportKind.ProductSales:
                if(!cbProductSales.Checked)
                    pivotGrid.Fields["Category"].Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea;
                pivotGrid.Fields["Product"].Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
                break;
            case ProductReportKind.MultipleSubtotals:
                pivotGrid.Fields["Product"].Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
                pivotGrid.Fields["Product"].AreaIndex = 1;
                pivotGrid.Fields["Year"].Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
                pivotGrid.Fields["Year"].AreaIndex = 0;
                pivotGrid.Fields["Quarter"].Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
                pivotGrid.Fields["Quarter"].AreaIndex = 1;
                pivotGrid.Fields["Category"].TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.CustomTotals;
                break;
            case ProductReportKind.Top3Products:
                pivotGrid.Fields["Product"].Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
                pivotGrid.Fields["Product"].AreaIndex = 1;
                pivotGrid.Fields["Product"].SortBySummaryInfo.FieldName = "ProductSales";
                pivotGrid.Fields["Product"].SortBySummaryInfo.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Sum;
                pivotGrid.Fields["Product"].SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
                pivotGrid.Fields["Product"].TopValueCount = 3;
                pivotGrid.Fields["Product"].TopValueShowOthers = cbShowOthers.Checked;
                break;
        }
        pivotGrid.Width = kind == ProductReportKind.AverageSales ? Unit.Empty : Unit.Percentage(100);
        pivotGrid.EndUpdate();
    }
    void ApplyIntervalGrouping() {
        pivotGrid.Fields["Month"].Visible = ddlIntervalGrouping.SelectedIndex > 1;
        switch(ddlIntervalGrouping.SelectedIndex) {
            case 0:
                pivotGrid.Fields["Year"].Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
                break;
            case 1:
                pivotGrid.Fields["Quarter"].Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
                break;
            case 2:
                pivotGrid.Fields["Month"].Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
                break;
            case 3:
                pivotGrid.Fields["Year"].Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
                pivotGrid.Fields["Quarter"].Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
                pivotGrid.Fields["Month"].Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
                break;
        }
    }
}

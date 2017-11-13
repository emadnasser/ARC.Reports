using System;
using System.Web.UI;
using DevExpress.Web;
using DevExpress.Web.ASPxPivotGrid;

public partial class CustomerReports : Page {

    public enum CustomerReportKind { Customers, Filtered, Top2Products, Top10Customers }

    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack)
            UpdatePivotGridLayout();
    }
    protected void tblDemoKind_SelectedIndexChanged(object sender, EventArgs e) {
        UpdatePivotGridLayout();
    }
    protected void filterYear_SelectedIndexChanged(object sender, EventArgs e) {
        ApplyFilter();
    }
    void UpdatePivotGridLayout() {
        int index = tblDemoKind.SelectedIndex > -1 ? tblDemoKind.SelectedIndex : 0;
        ChangePivotGridFieldLayout((CustomerReportKind)index);
    }
    void ChangePivotGridFieldLayout(CustomerReportKind kind) {
        pivotGrid.BeginUpdate();
        pivotGrid.Fields["Year"].Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
        pivotGrid.Fields["Year"].AreaIndex = 0;
        pivotGrid.Fields["Quarter"].Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
        pivotGrid.Fields["Quarter"].AreaIndex = 1;
        pivotGrid.Fields["ProductAmount"].Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;        
        pivotGrid.Fields["Customer"].Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
        pivotGrid.Fields["Customer"].AreaIndex = 0;
        pivotGrid.Fields["Customer"].SortOrder = kind == CustomerReportKind.Top10Customers ?
            DevExpress.XtraPivotGrid.PivotSortOrder.Descending : DevExpress.XtraPivotGrid.PivotSortOrder.Ascending;
        pivotGrid.Fields["Customer"].TopValueCount = 0;
        pivotGrid.Fields["Customer"].SortBySummaryInfo.FieldName = "";
        pivotGrid.Fields["ProductName"].Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea;
        pivotGrid.Fields["ProductName"].SortOrder = kind == CustomerReportKind.Top2Products ?
            DevExpress.XtraPivotGrid.PivotSortOrder.Descending : DevExpress.XtraPivotGrid.PivotSortOrder.Ascending;
        pivotGrid.Fields["ProductName"].TopValueCount = 0;
        pivotGrid.Fields["ProductName"].SortBySummaryInfo.FieldName = "";

        filterPanel.Visible = kind == CustomerReportKind.Filtered;

        switch(kind) {
            case CustomerReportKind.Customers:
                break;
            case CustomerReportKind.Filtered:
                pivotGrid.Fields["Customer"].Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea;
                pivotGrid.Fields["ProductName"].Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
                break;
            case CustomerReportKind.Top2Products:
                pivotGrid.Fields["ProductName"].Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
                pivotGrid.Fields["ProductName"].TopValueCount = 2;
                pivotGrid.Fields["ProductName"].SortBySummaryInfo.FieldName = "ProductAmount";
                pivotGrid.Fields["Year"].Area = pivotGrid.Fields["Quarter"].Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea;
                break;
            case CustomerReportKind.Top10Customers:
                pivotGrid.Fields["Customer"].TopValueCount = 10;
                pivotGrid.Fields["Customer"].SortBySummaryInfo.FieldName = "ProductAmount";
                pivotGrid.Fields["Year"].Area = pivotGrid.Fields["Quarter"].Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea;
                break;
        }
        if(kind != CustomerReportKind.Filtered) {
            filterYear.SelectedIndex = 0;
            filterQuarter.SelectedIndex = 0;
        }        
        ApplyFilter();
        pivotGrid.EndUpdate();
    }
    void ApplyFilter() {
        pivotGrid.BeginUpdate();
        ApplyFilter(pivotGrid.Fields["Year"], filterYear);
        ApplyFilter(pivotGrid.Fields["Quarter"], filterQuarter);
        pivotGrid.EndUpdate();
    }
    void ApplyFilter(PivotGridField field, ASPxComboBox filter) {
        field.FilterValues.Clear();
        if(filter.SelectedIndex > 0) {
            field.FilterValues.FilterType = DevExpress.XtraPivotGrid.PivotFilterType.Included;
            field.FilterValues.Add(filter.SelectedItem.Value);
        } else {
            field.FilterValues.FilterType = DevExpress.XtraPivotGrid.PivotFilterType.Excluded;
        }
    }
}

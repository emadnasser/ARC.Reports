using DevExpress.Web.Mvc;
using DevExpress.XtraPivotGrid;

namespace DevExpress.Web.Demos {
    public class PivotGridSampleReportsDemosHelper {
        public static void UpdatePivotGridLayoutForSampleReportsDemo(MVCxPivotGrid pivotGrid, PivotGridReportsDemoOptions options) {
            ChangePivotGridFieldLayout(pivotGrid, options ?? new PivotGridReportsDemoOptions());
        }
        static void ChangePivotGridFieldLayout(MVCxPivotGrid pivotGrid, PivotGridReportsDemoOptions options) {
            pivotGrid.BeginUpdate();
            pivotGrid.Fields["Year"].Area = PivotArea.ColumnArea;
            pivotGrid.Fields["Year"].AreaIndex = 0;
            pivotGrid.Fields["Quarter"].Area = PivotArea.ColumnArea;
            pivotGrid.Fields["Quarter"].AreaIndex = 1;
            pivotGrid.Fields["ProductAmount"].Area = PivotArea.DataArea;
            pivotGrid.Fields["Customer"].Area = PivotArea.RowArea;
            pivotGrid.Fields["Customer"].AreaIndex = 0;
            pivotGrid.Fields["Customer"].SortOrder = options.DemoKind == CustomerReportKind.Top10Customers ?
                PivotSortOrder.Descending : PivotSortOrder.Ascending;
            pivotGrid.Fields["Customer"].TopValueCount = 0;
            pivotGrid.Fields["Customer"].SortBySummaryInfo.FieldName = string.Empty;
            pivotGrid.Fields["ProductName"].Area = PivotArea.FilterArea;
            pivotGrid.Fields["ProductName"].SortOrder = options.DemoKind == CustomerReportKind.Top2Products ?
                PivotSortOrder.Descending : PivotSortOrder.Ascending;
            pivotGrid.Fields["ProductName"].TopValueCount = 0;
            pivotGrid.Fields["ProductName"].SortBySummaryInfo.FieldName = string.Empty;
            pivotGrid.Fields["Customer"].SortOrder = options.DemoKind == CustomerReportKind.Top10Customers ?
                PivotSortOrder.Descending : PivotSortOrder.Ascending;
            pivotGrid.Fields["ProductName"].SortOrder = options.DemoKind == CustomerReportKind.Top2Products ?
                PivotSortOrder.Descending : PivotSortOrder.Ascending;

            switch(options.DemoKind) {
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
            ApplyFilter(pivotGrid, options);
            pivotGrid.EndUpdate();
        }
        static void ApplyFilter(MVCxPivotGrid pivotGrid, PivotGridReportsDemoOptions options) {
            pivotGrid.BeginUpdate();
            ApplyFilter(pivotGrid.Fields["Year"], options.FilterYearIndex, 1995);
            ApplyFilter(pivotGrid.Fields["Quarter"], options.FilterQuarterIndex, 0);
            pivotGrid.EndUpdate();
        }
        static void ApplyFilter(ASPxPivotGrid.PivotGridField field, int selectedIndex, int filterIndex) {
            field.FilterValues.Clear();
            if(selectedIndex > 0) {
                field.FilterValues.FilterType = PivotFilterType.Included;
                field.FilterValues.Add(filterIndex + selectedIndex);
            }
            else {
                field.FilterValues.FilterType = DevExpress.XtraPivotGrid.PivotFilterType.Excluded;
            }
        }
    }
}

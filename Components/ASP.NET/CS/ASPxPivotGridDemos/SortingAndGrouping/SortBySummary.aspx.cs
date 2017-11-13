using System;
using System.Web.UI;
using DevExpress.Web.ASPxPivotGrid;

public partial class SortBySummaryDemo : Page {

    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack && !IsCallback) {
            SetYearFilter();
        }
        SetSortBySummary();
    }
    void SetYearFilter() {
        pivotGrid.Fields["Year"].FilterValues.FilterType = DevExpress.XtraPivotGrid.PivotFilterType.Included;
        pivotGrid.Fields["Year"].FilterValues.Add(1996);
    }
    void SetSortBySummary() {
        foreach(PivotGridField field in pivotGrid.Fields) {
            if(field.Area == DevExpress.XtraPivotGrid.PivotArea.DataArea) {
                field.CellStyle.Font.Bold = false;
                field.HeaderStyle.Font.Bold = false;
            }
        }
        PivotGridField selectedField = pivotGrid.Fields[ddlSortByField.SelectedItem.Text];
        if(selectedField == null) return;
        selectedField.CellStyle.Font.Bold = true;
        selectedField.HeaderStyle.Font.Bold = true;
        pivotGrid.Fields["Sales_Person"].SortBySummaryInfo.FieldName = selectedField.FieldName;
        pivotGrid.Fields["Sales_Person"].SortBySummaryInfo.SummaryType = selectedField.SummaryType;
    }
}

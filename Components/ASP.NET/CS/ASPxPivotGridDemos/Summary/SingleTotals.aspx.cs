using System;
using System.Web.UI;
using DevExpress.Data.PivotGrid;
using DevExpress.Web;
using DevExpress.Web.ASPxPivotGrid;

public partial class SingleTotalsDemo : Page {

    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack && !IsCallback) {
            SetYearFilter();
            SetSummaryDropDownList();
            SetOptionsViewCheckBoxes();
            SetDataFieldsProperties();
        }
        else {
            SetOptionsViewProperties();
        }
    }
    void SetYearFilter() {
        pivotGrid.Fields["Year"].FilterValues.FilterType = DevExpress.XtraPivotGrid.PivotFilterType.Included;
        pivotGrid.Fields["Year"].FilterValues.Add(1997);
    }
    void SetOptionsViewCheckBoxes() {
        cbShowColumnGrandTotals.Checked = pivotGrid.OptionsView.ShowColumnGrandTotals;
        cbShowColumnTotals.Checked = pivotGrid.OptionsView.ShowColumnTotals;
        cbShowRowGrandTotals.Checked = pivotGrid.OptionsView.ShowRowGrandTotals;
        cbShowRowTotals.Checked = pivotGrid.OptionsView.ShowRowTotals;
        cbShowGrandTotalsForSingleValues.Checked = pivotGrid.OptionsView.ShowGrandTotalsForSingleValues;
        cbShowTotalsForSingleValues.Checked = pivotGrid.OptionsView.ShowTotalsForSingleValues;
    }
    void SetSummaryDropDownList() {
        foreach(PivotSummaryType type in Enum.GetValues(typeof(PivotSummaryType))) {
			ddlSummaryType.Items.Add(new ListEditItem(type.ToString()));
        }
    }
    void SetOptionsViewProperties() {
        pivotGrid.OptionsView.ShowColumnGrandTotals = cbShowColumnGrandTotals.Checked;
        pivotGrid.OptionsView.ShowColumnTotals = cbShowColumnTotals.Checked;
        pivotGrid.OptionsView.ShowRowGrandTotals = cbShowRowGrandTotals.Checked;
        pivotGrid.OptionsView.ShowRowTotals = cbShowRowTotals.Checked;
        pivotGrid.OptionsView.ShowGrandTotalsForSingleValues = cbShowGrandTotalsForSingleValues.Checked;
        pivotGrid.OptionsView.ShowTotalsForSingleValues = cbShowTotalsForSingleValues.Checked;
    }
    void SetDataFieldsProperties() {
        foreach(PivotGridField field in pivotGrid.Fields) {
            if(field.Area == DevExpress.XtraPivotGrid.PivotArea.DataArea) {
                field.HeaderStyle.Font.Bold = false;
				field.HeaderStyle.HoverStyle.Font.Bold = false;
                field.Caption = string.Format("{0}({1})", field.FieldName, ddlSummaryType.Items[(int)field.SummaryType]);
            }
        }
        if(SelectedDataField != null) {
            SelectedDataField.HeaderStyle.Font.Bold = true;
			SelectedDataField.HeaderStyle.HoverStyle.Font.Bold = true;
            if(SelectedDataField.SummaryType != (PivotSummaryType)ddlSummaryType.SelectedIndex)
                ddlSummaryType.SelectedIndex = (int)SelectedDataField.SummaryType;
        }
    }
    PivotGridField SelectedDataField {
        get { return pivotGrid.Fields[ddlField.SelectedItem.Text.Replace(" ", string.Empty)]; }
    }
    protected void ddlField_SelectedIndexChanged(object sender, EventArgs e) {
        SetDataFieldsProperties();
    }
    protected void ddlSummaryType_SelectedIndexChanged(object sender, EventArgs e) {
        if(SelectedDataField != null) {
            SelectedDataField.SummaryType = (PivotSummaryType)ddlSummaryType.SelectedIndex;
        }
        SetDataFieldsProperties();
    }
}

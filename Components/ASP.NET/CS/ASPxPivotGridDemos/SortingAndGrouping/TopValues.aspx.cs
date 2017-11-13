using System;
using System.Web.UI;
using DevExpress.Web.ASPxPivotGrid;

public partial class TopValuesDemo : Page {

    const int MaxTopValueCount = 20;

    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack && !IsCallback) {
            SetShowTopValuesDropDownList();
        }
        SetSortBySummary();
    }
    void SetShowTopValuesDropDownList() {
        for(int i = 1; i <= MaxTopValueCount; i ++ ) {
            ddlTopCount.Items.Add(i.ToString());
        }
        ddlTopCount.SelectedIndex = MaxTopValueCount / 5;
    }
    void SetSortBySummary() {
        PivotGridField fieldOrderAmount = pivotGrid.Fields["fieldOrderAmount"];
        foreach(PivotGridField field in pivotGrid.Fields) {
            if(field != fieldOrderAmount) {
                field.Visible = false;
            }
        }
        PivotGridField selField = pivotGrid.Fields[ddlField.SelectedItem.Text];
        if(selField == null) return;
        selField.Visible = true;
        selField.TopValueCount = int.Parse(ddlTopCount.SelectedItem.Text);
        selField.TopValueShowOthers = cbShowOthers.Checked;
    }
}

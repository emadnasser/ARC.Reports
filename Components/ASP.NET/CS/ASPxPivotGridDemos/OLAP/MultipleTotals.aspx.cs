using System;
using System.Collections.Generic;
using System.Web.UI;
using DevExpress.Data.PivotGrid;

public partial class OLAP_CustomTotals : Page
{
	const string CategoriesFieldName = "[Categories].[Category Name].[Category Name]";
	const string ProductsFieldName = "[Products].[Products].[Products]";

	protected void Page_Load(object sender, EventArgs e) {
        string error = OLAPConnector.TryConnect(pivotGrid);
        if(!string.IsNullOrEmpty(error)) {
            Control errorPanel = OLAPConnector.CreateErrorPanel(error);
            pivotGrid.Parent.Controls.AddAt(0, errorPanel);
        }
		SetCustomTotals(pivotGrid.Fields[CategoriesFieldName].CustomTotals);
	}
	void SetCustomTotals(DevExpress.Web.ASPxPivotGrid.PivotGridCustomTotalCollection totals) {
		totals.Clear();
		if(average.Checked == true) 
			totals.Add(PivotSummaryType.Average);
		if(count.Checked == true) 
			totals.Add(PivotSummaryType.Count);
		if(max.Checked == true) 
			totals.Add(PivotSummaryType.Max);
		if(min.Checked == true) 
			totals.Add(PivotSummaryType.Min);
		if(stdev.Checked == true) 
			totals.Add(PivotSummaryType.StdDev);
		if(stdevp.Checked == true) 
			totals.Add(PivotSummaryType.StdDevp);
		if(sum.Checked == true) 
			totals.Add(PivotSummaryType.Sum);
		if(var.Checked == true) 
			totals.Add(PivotSummaryType.Var);
		if(varp.Checked == true) 
			totals.Add(PivotSummaryType.Varp);
	}
	void SetProductsFilter() {
		DevExpress.Web.ASPxPivotGrid.PivotGridField field = pivotGrid.Fields[ProductsFieldName];
		object[] values = field.GetUniqueValues();
		List<object> includedValues = new List<object>(values.Length / 3);
        for(int i = 0; i < values.Length; i++) {
            if(i % 3 == 0)
                includedValues.Add(values[i]);
        }
		field.FilterValues.ValuesIncluded = includedValues.ToArray();
	}
    protected void pivotGrid_DataBound(object sender, EventArgs e) {
        if(!IsPostBack && pivotGrid.IsDataBound) {
            SetProductsFilter();
            pivotGrid.Fields[CategoriesFieldName].ExpandValue("Beverages");
        }
    }
}

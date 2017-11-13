using System;
using System.Collections.Generic;
using System.Web.UI;
using DevExpress.Data.PivotGrid;
using DevExpress.Web.ASPxPivotGrid;

public partial class MultipleTotalsDemo : Page {

    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack && !IsCallback) {
            SetYearFilter();
            pivotGrid.Fields["CategoryName"].ExpandValue("Beverages");
        }
		SetCustomTotals(pivotGrid.Fields["CategoryName"].CustomTotals);
    }
    void SetYearFilter() {
        pivotGrid.Fields["Year"].FilterValues.FilterType = DevExpress.XtraPivotGrid.PivotFilterType.Included;
        pivotGrid.Fields["Year"].FilterValues.Add(1996);
    }
	void SetCustomTotals(DevExpress.Web.ASPxPivotGrid.PivotGridCustomTotalCollection totals) {
        List<PivotSummaryType> newTotals = GetCustomTotals();
        if(CustomTotalsEqual(totals, newTotals)) return;
		totals.Clear();
        for(int i = 0; i < newTotals.Count; i++)
            totals.Add(newTotals[i]);
	}
    bool CustomTotalsEqual(PivotGridCustomTotalCollection totals, List<PivotSummaryType> newTotals) {
        if(totals.Count != newTotals.Count) return false;
        for(int i = 0; i < newTotals.Count; i++) {
            if(!totals.Contains(newTotals[i]))
                return false;
        }
        return true;
    }
    List<PivotSummaryType> GetCustomTotals() {
        List<PivotSummaryType> res = new List<PivotSummaryType>();
        if(average.Checked)
            res.Add(PivotSummaryType.Average);
        if(count.Checked)
            res.Add(PivotSummaryType.Count);
        if(max.Checked)
            res.Add(PivotSummaryType.Max);
        if(min.Checked)
            res.Add(PivotSummaryType.Min);
        if(stdev.Checked)
            res.Add(PivotSummaryType.StdDev);
        if(stdevp.Checked)
            res.Add(PivotSummaryType.StdDevp);
        if(sum.Checked)
            res.Add(PivotSummaryType.Sum);
        if(var.Checked)
            res.Add(PivotSummaryType.Var);
        if(varp.Checked)
            res.Add(PivotSummaryType.Varp);
        return res;
	}
}

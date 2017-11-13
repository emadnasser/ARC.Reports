using System;
using System.Web.UI;

public partial class SummaryVariationDemo : Page {

    protected void Page_Load(object sender, EventArgs e) {
		ASPxPivotGrid1.Fields["fieldQuarter"].RunningTotal = cbRunningTotals.Checked;
        ASPxPivotGrid1.OptionsData.AllowCrossGroupVariation = cbAllowCrossGroupRunningTotals.Checked;
    }
}

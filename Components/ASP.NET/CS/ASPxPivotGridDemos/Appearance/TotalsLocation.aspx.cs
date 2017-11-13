using System;
using System.Web.UI;

public partial class TotalsLocationDemo : Page {

    protected void Page_Load(object sender, EventArgs e) {
        pivotGrid.OptionsView.SetBothTotalsLocation((DevExpress.XtraPivotGrid.PivotTotalsLocation)ddlTotalsLocation.SelectedIndex);
    }
}

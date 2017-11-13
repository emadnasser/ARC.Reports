using System;
using System.Web.UI;

public partial class Appearance_DataHeadersDisplayMode : Page {
    protected void Page_Load(object sender, EventArgs e) {
        pivotGrid.OptionsView.DataHeadersDisplayMode = (DevExpress.Web.ASPxPivotGrid.PivotDataHeadersDisplayMode)ddlDataHeadersStyle.SelectedIndex;
        pivotGrid.OptionsView.DataHeadersPopupMinCount = Convert.ToInt32(seDataHeadersLimit.Value);
    }
}

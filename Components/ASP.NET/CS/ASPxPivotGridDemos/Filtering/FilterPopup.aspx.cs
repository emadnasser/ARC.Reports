using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.Web.ASPxPivotGrid;

public partial class FilterPopup : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack)
            ASPxPivotGrid1.Fields["Category"].FilterValues.ValuesIncluded = new object[] { "Beverages" };
        ASPxPivotGrid1.OptionsFilter.ShowOnlyAvailableItems = cbShowOnlyAvailableItems.Checked;
        ASPxPivotGrid1.ReloadData();
        Page.ClientScript.RegisterStartupScript(this.GetType(), "startup", "setTimeout(\"showFilterPopup('Product')\", 500)", true);
    }
    protected void cbShowHiddenItems_CheckedChanged(object sender, EventArgs e) {
        ASPxPivotGrid1.OptionsFilter.ShowHiddenItems = cbShowHiddenItems.Checked;
    }
    protected void cbShowOnlyAvailableItems_CheckedChanged(object sender, EventArgs e) {
        cbShowHiddenItems.Enabled = cbShowOnlyAvailableItems.Checked;
    }
    protected void cbNativeCheckBoxes_CheckedChanged(object sender, EventArgs e) {
        ASPxPivotGrid1.OptionsFilter.NativeCheckBoxes = cbNativeCheckBoxes.Checked;
    }
}

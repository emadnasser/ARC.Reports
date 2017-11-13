using System;
using System.Web.UI;
using DevExpress.Web;

public partial class CloudControl_Features : Page {
    protected void Page_Load(object sender, EventArgs e) {
        ASPxCloudControl1.ShowValues = cbShowValues.Checked;
        ASPxCloudControl1.RankCount = byte.Parse(ddlRankCount.SelectedItem.Value.ToString());
        switch(ddlScales.SelectedItem.Value.ToString()) {
            case "Linear":
                ASPxCloudControl1.Scale = Scales.Linear;
                break;
            case "Logarithmic":
                ASPxCloudControl1.Scale = Scales.Logarithmic;
                break;
        }
    }
}

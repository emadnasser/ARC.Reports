using System;
using System.Text;
using System.Web.UI;
using DevExpress.Web;

public partial class ASPxListBox_MultiSelect : Page {
    const string DefaultXPath = "//Model";
    protected void Page_Load(object sender, EventArgs e) {
    }
    protected void lbModels_Callback(object sender, DevExpress.Web.CallbackEventArgsBase e) {
        FilterModels(lbFeatures.Items);
        lbModels.DataBind();
    }
    protected void FilterModels(ListEditItemCollection items) {
        StringBuilder sb = new StringBuilder(DefaultXPath);
        bool firstAttribute = true;
        foreach(ListEditItem item in items) {
            if(!item.Selected)
                continue;
            if(firstAttribute) {
                firstAttribute = false;
                sb.Append("[");
            } else
                sb.Append(" and ");
            sb.AppendFormat("@{0}=\"{1}\"", item.Value, item.Selected.ToString().ToLower());
        }
        if(!firstAttribute)
            sb.Append("]");
        PhoneModels.XPath = sb.ToString();
    }
    protected void ResetFiltration() {
        lbFeatures.Value = null;
        PhoneModels.XPath = DefaultXPath;
        lbModels.DataBind();
    }
    protected void lbSelectionMode_SelectedIndexChanged(object sender, EventArgs e) {
        ASPxComboBox cb = (ASPxComboBox)sender;
        ListEditSelectionMode newSelectionMode = (ListEditSelectionMode)Enum.Parse(typeof(ListEditSelectionMode), cb.SelectedItem.Text);
        lbFeatures.SelectionMode = newSelectionMode;
        lbModels.SelectionMode = newSelectionMode;
        ResetFiltration();
    }
}

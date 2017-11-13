using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;

public partial class ASPxComboBox_ItemAppearanceCustomization : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e) {

    }
    string GetItemTooltip(ListEditItem item) {
        return string.Format("Country: {0}\r\nCity: {1} \r\nAddress: {2}",
            item.GetFieldValue("Country"), item.GetFieldValue("City"), item.GetFieldValue("Address"));
    }
    protected void customersComboBox_ItemTextCellPrepared(object sender, ListBoxItemTextCellPreparedEventArgs e) {        
        if(e.Column.FieldName == "ContactName") {
            string contactTitle = e.Item.GetFieldValue("ContactTitle").ToString();
            if(contactTitle == "Owner") {
                e.TextCell.CssClass += " owner";
                e.TextCell.ToolTip = "Owner";
            }
        }
        if(e.Column.FieldName == "Phone")
            e.TextCell.CssClass += " phone";

    }
    protected void customersComboBox_ItemRowPrepared(object sender, ListBoxItemRowPreparedEventArgs e) {
        e.Row.ToolTip = GetItemTooltip(e.Item);
    }
}

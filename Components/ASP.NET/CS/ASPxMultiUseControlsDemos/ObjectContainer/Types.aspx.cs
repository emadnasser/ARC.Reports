using System;
using System.Web.UI;
using DevExpress.Web;

public partial class ObjectContainer_Types : Page {
    string UserControlName {
        get {
            string name = Request.QueryString["Name"];
            return name == null ? string.Empty : name;
        }
    }
    protected void Page_Load(object sender, EventArgs e) {
        DataBind();
        string itemName = "ObjectTypes/" + UserControlName + ".ascx";
        MenuItem selectedItem = mSelector.Items.FindByName(itemName);
        if (selectedItem == null)
            selectedItem = mSelector.Items[0];
        phAppearances.Controls.Add(LoadControl(selectedItem.Name));
    }
}

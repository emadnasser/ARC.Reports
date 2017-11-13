using System;
using System.Web.UI;

public partial class Menu_DataBinding : Page {
    protected void Page_Load(object sender, EventArgs e) {
        XmlDataSource1.XPath = (string)ddlXPath.SelectedItem.Value;
        lblXPath.Text = XmlDataSource1.XPath;
    }
}

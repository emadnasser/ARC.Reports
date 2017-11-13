using System;
using DevExpress.Web;
using System.Threading;
using System.Web.UI;
using System.Xml;

public partial class NavBar_EnableCallBacks : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(IsCallback) {
            // Intentionally pauses server-side processing, 
            // to demonstrate the Loading Panel functionality.
            Thread.Sleep(1000);
        }
        if(!IsPostBack) {
            ASPxNavBar1.DataBind();
            ASPxNavBar1.Groups.CollapseAll();
            ASPxNavBar1.Groups[0].Expanded = true;
        }
    }

    protected void ASPxNavBar1_GroupDataBound(object sender, NavBarGroupEventArgs e) {
        IHierarchyData hierarchyData = (e.Group.DataItem as IHierarchyData);
        XmlElement xmlElement = hierarchyData.Item as XmlElement;
        XmlAttributeCollection attributes = xmlElement.Attributes;

        if(xmlElement.Attributes["View"] != null)
            e.Group.Text = xmlElement.Attributes["View"].Value;
    }
}

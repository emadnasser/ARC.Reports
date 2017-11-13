using System;
using DevExpress.Web;
using System.Web.UI;
using System.Xml;

public partial class NavBar_Templates : Page {
    const string ClickHandlerScript = "return DXDemo.ShowScreenshotWindow(event, this);";

    protected void Page_Load(object sender, EventArgs e) {

    }

    protected void ASPxNavBar1_GroupDataBound(object sender, NavBarGroupEventArgs e) {
        XmlElement xmlElement = (e.Group.DataItem as IHierarchyData).Item as XmlElement;
        Control ucContentTemplate = LoadControl("ContentTemplate.ascx");
        e.Group.ContentTemplate = ucContentTemplate as ITemplate;
        DataBindContentUserControl(xmlElement, ucContentTemplate);
    }

    protected void Watch_OnPreRender(object sender, EventArgs e) {
        ASPxHyperLink lWatch = sender as ASPxHyperLink;
        if(lWatch != null)
            lWatch.Attributes.Add("onclick", ClickHandlerScript);
    }

    void DataBindContentUserControl(XmlElement xmlElement, Control userControl) {
        ASPxLabel htText = userControl.FindControl("htText") as ASPxLabel;
        if(htText != null)
            htText.Text = xmlElement.InnerXml;
        ASPxHyperLink htImage = userControl.FindControl("htImage") as ASPxHyperLink;
        if(htImage == null || xmlElement.Attributes["ImageUrl"] == null ||
            xmlElement.Attributes["NavigateUrl"] == null)
            return;
        htImage.NavigateUrl = xmlElement.Attributes["NavigateUrl"].Value;
        htImage.Target = "_blank";
        htImage.Attributes.Add("onclick", ClickHandlerScript);
        htImage.ImageUrl = xmlElement.Attributes["ImageUrl"].Value;
    }

}

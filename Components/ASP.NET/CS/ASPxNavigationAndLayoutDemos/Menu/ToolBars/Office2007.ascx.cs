using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using DevExpress.Web;

public partial class Menu_Toolbars_Office2007 : UserControl {

    protected void ASPxMenu1_ItemDataBound(object sender, MenuItemEventArgs e) {
        if(e.Item.Depth != 0) return;
        IHierarchyData itemHierarchyData = (e.Item.DataItem as IHierarchyData);
        Control ucItemTemplate = LoadControl("Office2007Children.ascx");
        e.Item.Template = ucItemTemplate as ITemplate;
        DataBindUserControl(itemHierarchyData, ucItemTemplate);
    }

    protected void DataBindUserControl(IHierarchyData itemHierarchyData, Control userControl) {
        XmlElement xmlElement = itemHierarchyData.Item as XmlElement;

        ASPxRoundPanel rPanel = userControl.FindControl("rpRibbon") as ASPxRoundPanel;
        if(rPanel == null) return;

        ASPxMenu menu = rPanel.FindControl("mRibbonChilds") as ASPxMenu;
        if(menu == null) return;


        Label headerText = rPanel.FindControl("lblWatch") as Label;
        if(headerText != null) {
            headerText.Text = xmlElement.Attributes["Text"] != null ?
                xmlElement.Attributes["Text"].Value : "";
        }

        XmlDataSource ds = userControl.FindControl("XmlDataSource1") as XmlDataSource;
        if(ds != null) {
            ds.XPath = itemHierarchyData.Path + "/*";
        }
    }
}

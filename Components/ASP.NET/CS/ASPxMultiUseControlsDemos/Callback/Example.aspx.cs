using System;
using System.Xml;
using System.Threading;
using DevExpress.Web;
using System.Web.UI;

public partial class Callback_Example : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(IsCallback) {
            // Intentionally pauses server-side processing,
            // to demonstrate the Loading Panel functionality.    
            Thread.Sleep(500);
        }
    }

    protected void ASPxCallback1_Callback(object sender, CallbackEventArgs e) {
        string xpath = string.Format("//items/item[@newsID='{0}']", e.Parameter);
        XmlNode node = XmlDataSource1.GetXmlDocument().SelectSingleNode(xpath);
        if(node != null)
            e.Result = node.Attributes["Description"].Value;
    }
}

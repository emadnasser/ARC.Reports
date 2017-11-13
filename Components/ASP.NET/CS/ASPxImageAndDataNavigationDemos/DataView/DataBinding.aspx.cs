using System;
using System.Web.UI;
using DevExpress.Web.Demos;

public partial class DataViewControl_Example : Page {
    protected void Page_Load(object sender, EventArgs e) {
        Utils.RegisterCssLink(this, "~/DataView/CSS/DataBinding.css");
        if(IsCallback) {
            // Intentionally pauses server-side processing, 
            // to demonstrate the Loading Panel functionality.
            System.Threading.Thread.Sleep(500);
        }
    }
}

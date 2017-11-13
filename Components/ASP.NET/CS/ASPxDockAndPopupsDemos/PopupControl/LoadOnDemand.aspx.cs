using System;
using System.Web.UI;
using System.Threading;

public partial class PopupControl_LoadOnDemand : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(PopupControl.IsCallback) {
            // Intentionally pauses server-side processing, 
            // to demonstrate the Loading Panel functionality.
            Thread.Sleep(1000);
        }
    }
}

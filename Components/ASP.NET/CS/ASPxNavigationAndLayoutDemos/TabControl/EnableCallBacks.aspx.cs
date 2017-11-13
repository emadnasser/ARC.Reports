using System;
using System.Web.UI;
using System.Threading;

public partial class TabControl_EnableCallBacks : Page {
    protected void Page_Load(object sender, EventArgs e) {
        // Intentionally pauses server-side processing, 
        // to demonstrate the Loading Panel functionality.
        if(IsCallback)
            Thread.Sleep(1000);
    }
}

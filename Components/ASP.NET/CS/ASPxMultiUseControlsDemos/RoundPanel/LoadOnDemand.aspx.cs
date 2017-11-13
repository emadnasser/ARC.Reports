using System;
using System.Web.UI;

public partial class RoundPanel_LoadOnDemand: Page {
    protected void Page_Load(object sender, EventArgs e) {
        // Intentionally pauses server-side processing, 
        // to demonstrate the Loading Panel functionality.
        if(ASPxRoundPanel1.IsCallback)
            System.Threading.Thread.Sleep(2000);
    }
}

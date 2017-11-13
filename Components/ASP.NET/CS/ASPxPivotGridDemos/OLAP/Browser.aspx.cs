using System;
using System.Web.UI;

public partial class Features_OLAP : Page {	

    protected void Page_Load(object sender, EventArgs e) {
        string error = OLAPConnector.TryConnect(pivotGrid);
        if(!string.IsNullOrEmpty(error)) {            
            Control errorPanel = OLAPConnector.CreateErrorPanel(error);
            pivotGrid.Parent.Controls.AddAt(0, errorPanel);
        }
	}
}

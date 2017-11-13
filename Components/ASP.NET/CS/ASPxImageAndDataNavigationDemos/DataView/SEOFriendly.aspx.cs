using System;
using System.Web.UI;

public partial class DataViewControl_Example : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(IsPostBack) {
            // Rebind is called, since BinaryImage doesn't store its content in 
            // View State by default. To change this behavior, 
            // toggle the StoreContentBytesInViewState option.
            ASPxDataView1.DataBind();
        }
    }
}

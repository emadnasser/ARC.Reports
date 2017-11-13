using System;
using System.Web.UI;

public partial class Data_Hierarchical : Page {
	protected void Page_Load(object sender, EventArgs e) {
		if(!IsPostBack) {
			DataBind();
			treeList.ExpandToLevel(1);
		}
	}
}

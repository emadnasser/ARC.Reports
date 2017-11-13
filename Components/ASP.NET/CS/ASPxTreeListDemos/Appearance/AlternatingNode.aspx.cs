using System;
using System.Web.UI;

public partial class Appearance_AlternatingNode : Page {
	protected void Page_Load(object sender, EventArgs e) {
		if(!IsPostBack) {
			DataBind();
			treeList.ExpandToLevel(2);
		}
	}
}

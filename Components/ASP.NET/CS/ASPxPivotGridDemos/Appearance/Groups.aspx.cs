using System;
using System.Web.UI;
using DevExpress.XtraPivotGrid;

public partial class Features_Groups : Page
{
    protected void Page_Load(object sender, EventArgs e) { }
	void GroupsExpandCollapse(bool expand) {
		foreach(PivotGridGroup group in pivotGrid.Groups)
			foreach(PivotGridFieldBase field in group)
				field.ExpandedInFieldsGroup = expand;
	}
	protected void buttonExpandAll_Click(object sender, EventArgs e) {
		GroupsExpandCollapse(true);
	}
	protected void buttonCollapseAll_Click(object sender, EventArgs e) {
		GroupsExpandCollapse(false);
	}
}

using System;
using System.Web.UI;

public partial class UserControls_ShowQueryBuilderButtonControl : UserControl {
    public UserControls_ShowQueryBuilderButtonControl(): base() {
        this.Init += showQueryBuilderButton_Init;
    }
    protected void showQueryBuilderButton_Init(object sender, EventArgs e) {
        this.hfShowTooltip["showTooltip"] = QueryBuilderHelper.NeedToShowTooltip(Session);
    }
}

using System;

public partial class Cards_Selection : System.Web.UI.Page {
    protected void CardView_PreRender(object sender, EventArgs e) {
        CardView.Selection.SelectCard(1);
        CardView.Selection.SelectCard(2);
    }
}

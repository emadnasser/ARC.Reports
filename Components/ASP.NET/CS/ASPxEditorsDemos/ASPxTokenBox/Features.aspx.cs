using System;
using System.Web.UI;
using DevExpress.Web;

public partial class ASPxTokenBox_Features : Page {
    protected void Page_Load(object sender, EventArgs e) {
        ASPxTokenBox1.IncrementalFilteringMode = (IncrementalFilteringMode)ddlIncrementalFilteringMode.Value;
        ASPxTokenBox1.ShowDropDownOnFocus = (ShowDropDownOnFocusMode)ddlShowDropDownOnFocus.Value;
        ASPxTokenBox1.AllowCustomTokens = chAllowCustomTokens.Checked;

        if(!IsPostBack) {
            ASPxTokenBox1.Tokens.Add("Julia Evans");
            ASPxTokenBox1.Tokens.Add("Kevin Collins");
            ASPxTokenBox1.Tokens.Add("Diana Martin");
        }
    }
}

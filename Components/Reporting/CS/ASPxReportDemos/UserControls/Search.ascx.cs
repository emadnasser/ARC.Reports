using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using DevExpress.Web;
using DevExpress.Web.Demos;

public partial class UserControls_Search : System.Web.UI.UserControl {
    public bool FocusOnLoad { get; set; }

    protected void Page_Load(object sender, EventArgs e) {
        if(FocusOnLoad)
            TbSearch.Focus();

        if (Utils.IsAccessibilityDemo)
            TbSearch.NullText = "Search";
    }
    protected void SearchPopup_WindowCallback(object source, DevExpress.Web.PopupWindowCallbackArgs e) {
        var text = e.Parameter;
        var results = SearchUtils.DoSearch(text);
        var resultsPanel = SearchPopup.FindControl("ResultsPanel");
        var noResultsPanel = SearchPopup.FindControl("NoResultsPanel");
        if(results.Count > 0) {
            resultsPanel.Visible = true;
            noResultsPanel.Visible = false;
            var grouppedResults = results.GroupBy(sr => sr.Product);
            foreach(var productGroup in grouppedResults) {
                var product = productGroup.Key;
                var group = SearchResultsNavBar.Groups.Add(product.NavItemTitle.ToUpper(), string.Empty, string.Empty, Utils.GenerateDemoUrl(product.Intro));
                foreach(var res in productGroup) {
                    group.Items.Add(res.Text, string.Empty, string.Empty, Utils.GenerateDemoUrl(res.Demo));
                }
            }
        }
        else {
            resultsPanel.Visible = false;
            noResultsPanel.Visible = true;
            var requestText = noResultsPanel.FindControl("RequestText") as HtmlGenericControl;
            requestText.InnerHtml = text;
        }
    }
}

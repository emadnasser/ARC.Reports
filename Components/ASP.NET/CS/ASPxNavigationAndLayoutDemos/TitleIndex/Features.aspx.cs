using System;
using System.Web.UI;
using DevExpress.Web;
using System.Web.UI.WebControls;

public partial class TitleIndex_IndexPanel : Page {
    IndexPanelBehavior CurrentIndexPanelBehavior {
        get {
            return (IndexPanelBehavior)Enum.Parse(typeof(IndexPanelBehavior), 
                ddlBehavior.SelectedItem.Value.ToString());
        }
    }
    PagerPosition CurrentIndexPanelPosition {
        get {
            return (PagerPosition)Enum.Parse(typeof(PagerPosition), 
                ddlPosition.SelectedItem.Value.ToString());
        }
    }

    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack)
            return;
        ASPxTitleIndex1.IndexPanel.Behavior = CurrentIndexPanelBehavior;
        ASPxTitleIndex1.IndexPanel.Position = CurrentIndexPanelPosition;
        ASPxTitleIndex1.ShowBackToTop = cbShowBackToTop.Checked;
        ASPxTitleIndex1.Categorized = cbCategorized.Checked;
    }

    protected void btnApply_Click(object sender, EventArgs e) {
        int result = 0;
        lblColumnCountError.Visible =
            !int.TryParse(tbColumnCount.Text, out result) || result <= 0;
        if(!lblColumnCountError.Visible)
            ASPxTitleIndex1.ColumnCount = (byte)result;
    }
}

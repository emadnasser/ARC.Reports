using System;
using DevExpress.Web;
using System.Web.UI.WebControls;

public partial class PagingAndScrolling_PagerSettings: System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        CardView.SettingsPager.Position = (PagerPosition)Enum.Parse(typeof(PagerPosition), Position.Text);
        CardView.SettingsPager.ShowDisabledButtons = ShowDisabledButtons.Checked;
        CardView.SettingsPager.ShowNumericButtons = ShowNumericButtons.Checked;
        CardView.SettingsPager.ShowSeparators = ShowSeparators.Checked;
        CardView.SettingsPager.Summary.Visible = ShowSummary.Checked;
        CardView.SettingsPager.PageSizeItemSettings.Visible = ShowPageSizeItems.Checked;
        CardView.SettingsPager.PageSizeItemSettings.Position = (PagerPageSizePosition)Enum.Parse(typeof(PagerPageSizePosition), PageSizePosition.Text);
    }
}

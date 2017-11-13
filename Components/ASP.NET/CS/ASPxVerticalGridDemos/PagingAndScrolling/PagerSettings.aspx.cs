using System;
using DevExpress.Web;
using System.Web.UI.WebControls;

public partial class PagingAndScrolling_PagerSettings: System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        VerticalGrid.SettingsPager.Position = (PagerPosition)Enum.Parse(typeof(PagerPosition), Position.Text);
        VerticalGrid.SettingsPager.ShowDisabledButtons = ShowDisabledButtons.Checked;
        VerticalGrid.SettingsPager.ShowNumericButtons = ShowNumericButtons.Checked;
        VerticalGrid.SettingsPager.ShowSeparators = ShowSeparators.Checked;
        VerticalGrid.SettingsPager.Summary.Visible = ShowSummary.Checked;
        VerticalGrid.SettingsPager.PageSizeItemSettings.Visible = ShowPageSizeItems.Checked;
        VerticalGrid.SettingsPager.PageSizeItemSettings.Position = (PagerPageSizePosition)Enum.Parse(typeof(PagerPageSizePosition), PageSizePosition.Text);
    }
}

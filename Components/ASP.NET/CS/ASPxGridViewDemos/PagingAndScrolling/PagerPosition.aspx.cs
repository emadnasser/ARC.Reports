using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;

public partial class PagingAndScrolling_PagerPosition : Page {
    PagerPosition CurrentPagerPosition {
        get {
            return (PagerPosition)Enum.Parse(typeof(PagerPosition),
                cbPagerPosition.SelectedItem.Value.ToString());
        }
    }
    PagerPageSizePosition CurrentPageSizePosition {
        get {
            return (PagerPageSizePosition)Enum.Parse(typeof(PagerPageSizePosition),
                cbPageSizeItemPosition.SelectedItem.Value.ToString());
        }
    }

    protected void Page_Load(object sender, EventArgs e) {
        grid.SettingsPager.Position = CurrentPagerPosition;
        grid.SettingsPager.ShowDisabledButtons = cbShowDisabledButtons.Checked;
        grid.SettingsPager.ShowNumericButtons = cbShowNumericButtons.Checked;
        grid.SettingsPager.ShowSeparators = cbShowSeparators.Checked;
        grid.SettingsPager.Summary.Visible = cbShowSummary.Checked;
        grid.SettingsPager.PageSizeItemSettings.Visible = cbShowPageSizeItem.Checked;
        grid.SettingsPager.PageSizeItemSettings.Position = CurrentPageSizePosition;
    }
}

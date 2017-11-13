using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;

public partial class Shaping_Paging : Page {
    PagerPosition CurrentPagerPosition {
        get {
            return (PagerPosition)Enum.Parse(typeof(PagerPosition),
                cmbPosition.SelectedItem.Value.ToString());
        }
    }
    PagerPageSizePosition CurrentPageSizePosition {
        get {
            return (PagerPageSizePosition)Enum.Parse(typeof(PagerPageSizePosition),
                cmbPageSizeItemPosition.SelectedItem.Value.ToString());
        }
    }

	protected void Page_Load(object sender, EventArgs e) {
        treeList.SettingsPager.Position = CurrentPagerPosition;
        treeList.SettingsPager.ShowDisabledButtons = cbShowDisabledButtons.Checked;
        treeList.SettingsPager.ShowNumericButtons = cbShowNumericButtons.Checked;
        treeList.SettingsPager.ShowSeparators = cbShowSeparators.Checked;
        treeList.SettingsPager.Summary.Visible = cbShowSummary.Checked;
        treeList.SettingsPager.PageSizeItemSettings.Visible = cbShowPageSizeItem.Checked;
        treeList.SettingsPager.PageSizeItemSettings.Position = CurrentPageSizePosition;
	}
}

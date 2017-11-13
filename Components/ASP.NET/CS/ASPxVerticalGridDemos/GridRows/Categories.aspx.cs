using System;
using System.Linq;
using System.Threading;
using System.Web.UI;
using DevExpress.Web;
using DevExpress.Web.Demos;

public partial class PagingAndScrolling_Categories : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(IsCallback)
            Thread.Sleep(1000);
        
        VerticalGrid.SettingsBehavior.AllowExpandAnimation = chbEnableAnimation.Checked;
        VerticalGrid.SettingsBehavior.AllowRowExpanding = chbAllowExpanding.Checked;
        VerticalGrid.Settings.ShowCategoryIndents = VerticalGrid.Settings.MergeHeaderIndents = chbShowIndents.Checked;
        VerticalGrid.Settings.RecordWidth = Utils.IsLargeTheme ? 200 : 185;

        var rowLoadingMode = chbEnableCallbackMode.Checked ? VerticalGridRowLoadingMode.Callback : VerticalGridRowLoadingMode.Full;
        if(!VerticalGrid.Settings.RowLoadingMode.Equals(rowLoadingMode) && rowLoadingMode.Equals(VerticalGridRowLoadingMode.Callback)) // TODO VG instant vb
            CollapseCategoriesForCallbackMode();
        
        VerticalGrid.Settings.RowLoadingMode = rowLoadingMode;
        var headphones = HeadphonesDataProvider.SelectHeadphones().Take(4);
        VerticalGrid.DataSource = headphones;
        VerticalGrid.DataBind();
    }

    protected void CollapseCategoriesForCallbackMode() {
        var categories = VerticalGrid.Rows.OfType<VerticalGridCategoryRow>();
        foreach(var category in categories)
            category.Expanded = false;
    }
}

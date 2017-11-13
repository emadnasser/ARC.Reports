using System;
using System.Linq;
using System.Threading;
using System.Web.UI;
using DevExpress.Web;
using DevExpress.Web.Demos;

public partial class PagingAndScrolling_FixedRows : Page {
    protected void Page_Load(object sender, EventArgs e) {
        
        VerticalGrid.Settings.VerticalScrollBarMode = chbEnableVerticalScrolling.Checked ? ScrollBarMode.Visible : ScrollBarMode.Hidden;
        VerticalGrid.Settings.RecordWidth = Utils.IsLargeTheme ? 200 : 185;

        string[] rowsToFix = { "PhotoUrl", "Brand", "Model" };
        foreach(var row in rowsToFix)
            VerticalGrid.Rows[row].Fixed = chbEnableFixedRows.Checked;

        var headphones = HeadphonesDataProvider.SelectHeadphones().Take(4);
        VerticalGrid.DataSource = headphones;
        VerticalGrid.DataBind();
    }
}

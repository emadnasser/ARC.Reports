using System;
using System.Web.UI;
using DevExpress.Web;

public partial class Filtering_FilterRow : Page {
    protected void Page_Load(object sender, EventArgs e) { }

    protected void Grid_Load(object sender, EventArgs e) {
        Grid.Settings.ShowFilterRowMenu = chkFilterRowMenu.Checked;
        Grid.SettingsBehavior.FilterRowMode = (GridViewFilterRowMode)Enum.Parse(typeof(GridViewFilterRowMode), filterRowModeCombo.Text, true);
    }
}

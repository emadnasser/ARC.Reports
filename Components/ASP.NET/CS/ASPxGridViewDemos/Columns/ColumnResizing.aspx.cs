using System;
using System.Web.UI;
using DevExpress.Web;

public partial class Columns_ColumnResizing : Page {
    protected void Page_Load(object sender, EventArgs args) {
        grid.SettingsResizing.ColumnResizeMode = (ColumnResizeMode)Enum.Parse(typeof(ColumnResizeMode), ddlResizingMode.Text, true);
        grid.SettingsResizing.Visualization = (ResizingMode)Enum.Parse(typeof(ResizingMode), ddlResizingVisualization.Text, true);
    }
}

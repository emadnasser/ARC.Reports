using System;
using DevExpress.Web;

public partial class Shaping_ColumnResizing : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        treeList.SettingsResizing.ColumnResizeMode = (ColumnResizeMode)Enum.Parse(typeof(ColumnResizeMode), ddlResizingMode.Text, true);
        treeList.SettingsResizing.Visualization = (ResizingMode)Enum.Parse(typeof(ResizingMode), ddlResizingVisualization.Text, true);
    }
}

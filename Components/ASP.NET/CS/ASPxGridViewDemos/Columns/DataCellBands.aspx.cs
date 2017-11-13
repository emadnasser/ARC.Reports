using System;
using DevExpress.Web;

public partial class Columns_DataCellBands : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        Grid.SettingsBehavior.ColumnMoveMode = (GridColumnMoveMode)ColumnMoveMode.Value;
    }
}

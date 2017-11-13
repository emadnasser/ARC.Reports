using System;
using System.Threading;
using DevExpress.Web;

public partial class Columns_ColumnMoving : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        Grid.SettingsBehavior.ColumnMoveMode = (GridColumnMoveMode)cpColumnMoveMode.Value;
        Grid.SettingsBehavior.ProcessColumnMoveOnClient = cbProcessColumnMoveOnClient.Checked;
        if(IsCallback && !cbProcessColumnMoveOnClient.Checked)
            Thread.Sleep(1500); // Extend the callback delay for demonstration purposes.
    }
}

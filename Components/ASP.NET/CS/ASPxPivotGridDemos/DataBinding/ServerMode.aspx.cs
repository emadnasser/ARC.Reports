using System;
using System.Web.UI;
using DevExpress.Web.ASPxPivotGrid;
using DevExpress.Web.Demos;

public partial class ServerModeDemo : Page {

    static ServerModeDemo() {
        PivotGridServerModeDataGenerator.Register();
    }

    protected void Page_Init(object sender, EventArgs e) {
        bool ready = DatabaseGenerator.IsReady(CreateDatabaseControl.TableKey);
        CreateDatabaseControl.Visible = !ready;
        Demo.Visible = ready;
    }

    protected void ASPxPivotGrid1_CustomCallback(object sender, PivotGridCustomCallbackEventArgs e) {
        ASPxPivotGrid1.ReloadData();
    }
}

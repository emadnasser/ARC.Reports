using System;
using DevExpress.Web.Demos;

public partial class Data_LargeDatabase: System.Web.UI.Page {
    static Data_LargeDatabase() {
        EmailDataGenerator.Register();
    }

    protected void Page_Init(object sender, EventArgs e) {
        bool ready = DatabaseGenerator.IsReady(CreateDatabaseControl.TableKey);
        CreateDatabaseControl.Visible = !ready;
        Demo.Visible = ready;
    }

    protected void Page_Load(object sender, EventArgs e) {
        CardView.DataSourceID = rbEntityDevExpress.Checked ? "EntityServerModeDataSource" : "EntityDataSource";
    }
}

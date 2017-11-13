using System;
using System.Web.UI;
using DevExpress.Web.Demos;
using DevExpress.Web;

public partial class DataBinding_LargeDatabase : Page {

    static DataBinding_LargeDatabase() {
        EmailDataGenerator.Register();
    }

    protected void Page_Init(object sender, EventArgs e) {
        bool ready = DatabaseGenerator.IsReady(CreateDatabaseControl.TableKey);
        CreateDatabaseControl.Visible = !ready;
        Demo.Visible = ready;
    }

    protected void Page_Load(object sender, EventArgs e) {
        VerticalGrid.Settings.HeaderAreaWidth = Utils.IsLargeTheme ? 130 : 100;
        VerticalGrid.DataSourceID = rbEntityDevExpress.Checked ? "EntityServerModeDataSource" : "EntityDataSource";
    }

    protected void grid_CustomRowDisplayText(object sender, ASPxVerticalGridRowDisplayTextEventArgs e) {
        if(e.Row.FieldName == "Size")
            e.DisplayText = Utils.FormatSize(e.Value);
    }
}

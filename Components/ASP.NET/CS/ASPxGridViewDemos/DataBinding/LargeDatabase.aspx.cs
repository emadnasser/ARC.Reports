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
        grid.DataSourceID = rbEntityDevExpress.Checked ? "EntityServerModeDataSource" : "EntityDataSource";
    }

    protected void grid_CustomColumnDisplayText(object sender, ASPxGridViewColumnDisplayTextEventArgs e) {
        if(e.Column.FieldName == "Size")
            e.DisplayText = Utils.FormatSize(e.Value);
    }

    protected void grid_SummaryDisplayText(object sender, ASPxGridViewSummaryDisplayTextEventArgs e) {
        if(e.Item.FieldName == "Size")
            e.Text = string.Format("Sum = {0}", Utils.FormatSize(e.Value));
    }
}

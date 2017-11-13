using DevExpress.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GridView_LargeDataBase : System.Web.UI.Page {
    static GridView_LargeDataBase() {
        EmailDataGenerator.Register();
    }

    protected void Page_Init(object sender, EventArgs e) {
        BindingToDatabaseDemo.IsDatabaseCreated = DatabaseGenerator.IsReady(CreateDatabaseControl.TableKey);
    }

    protected void GridView1_CustomColumnDisplayText(object sender, ASPxGridViewColumnDisplayTextEventArgs e) {
        if(e.Column.FieldName == "Size")
            e.DisplayText = FormatByteSize(e.Value);
    }

    protected void GridView1_SummaryDisplayText(object sender, ASPxGridViewSummaryDisplayTextEventArgs e) {
        if(e.Item.FieldName == "Size")
            e.Text = string.Format("Sum = {0}", FormatByteSize(e.Value));
    }

    protected string FormatByteSize(object value) {
        string[] sizes = { "B", "KB", "MB", "GB" };
        double len = Convert.ToDouble(value);
        int order = 0;
        while(len >= 1024 && ++order < sizes.Length)
            len = len / 1024;
        return String.Format("{0:0.##} {1}", len, sizes[order]);
    }
}

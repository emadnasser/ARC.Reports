using System;
using System.Web.UI;
using DevExpress.Web;

public partial class CloudControl_DataBinding : Page {
    protected void Page_Load(object sender, EventArgs e) {
        string sql = "select c.Name, c.Area, c.Population from countries AS c";
        if(ddlFilter.SelectedItem.Value.ToString() != "")
            sql += " where " + ddlFilter.SelectedItem.Value.ToString();
        CountriesDataSource.CommandText = sql;
        ASPxCloudControl1.ValueField = ddlValueField.SelectedItem.Value.ToString();
    }

    protected void ASPxCloudControl1_ItemDataBound(object sender, CloudControlItemEventArgs e) {
        e.Item.Text = e.Item.Text.ToUpper();
    }
}

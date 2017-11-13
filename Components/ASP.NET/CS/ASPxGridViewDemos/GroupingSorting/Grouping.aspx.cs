using System;
using System.Web.UI;
using DevExpress.Web;

public partial class GroupingSorting_Grouping : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack)
            ApplyLayout(0);
    }

    protected void grid_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e) {
        ApplyLayout(Int32.Parse(e.Parameters));
    }

    void ApplyLayout(int layoutIndex) {
        grid.BeginUpdate();
        try {
            grid.ClearSort();
            switch(layoutIndex) {
                case 0:
                    grid.GroupBy(grid.Columns["Country"]);
                    break;
                case 1:
                    grid.GroupBy(grid.Columns["Country"]);
                    grid.GroupBy(grid.Columns["City"]);
                    break;
                case 2:
                    grid.GroupBy(grid.Columns["CompanyName"]);
                    break;
            }
        } finally {
            grid.EndUpdate();
        }
        grid.ExpandAll();
    }
}

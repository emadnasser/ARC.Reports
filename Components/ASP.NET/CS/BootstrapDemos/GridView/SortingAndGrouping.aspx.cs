using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;

public partial class GridView_GroupingAndSorting : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack)
            ApplyLayout(0);
    }
    protected void GridView1_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e) {
        ApplyLayout(Int32.Parse(e.Parameters));
    }

    void ApplyLayout(int layoutIndex) {
        GridView1.BeginUpdate();
        try {
            GridView1.ClearSort();
            switch(layoutIndex) {
                case 0:
                    GridView1.GroupBy(GridView1.Columns["Country"]);
                    break;
                case 1:
                    GridView1.GroupBy(GridView1.Columns["Country"]);
                    GridView1.GroupBy(GridView1.Columns["City"]);
                    break;
                case 2:
                    GridView1.GroupBy(GridView1.Columns["CompanyName"]);
                    break;
            }
        }
        finally {
            GridView1.EndUpdate();
        }
        GridView1.ExpandAll();
    }
}

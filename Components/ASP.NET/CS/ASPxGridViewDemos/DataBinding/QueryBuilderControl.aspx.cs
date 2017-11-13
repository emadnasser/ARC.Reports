using System;
using DevExpress.Web;

public partial class DataBinding_QueryBuilderControl : System.Web.UI.Page {
    protected void NorthwindDataSource_Init(object sender, EventArgs e) {
        NorthwindDataSource.ConnectionString = QueryBuilderHelper.NorthwindConnectionString;
        NorthwindDataSource.SelectCommand = QueryBuilderHelper.LoadSelectCommand(Session);
    }
    protected void grid_DataBound(object sender, EventArgs e) {
        SetColumnsWidth(sender as ASPxGridView);
    }
    private void SetColumnsWidth(ASPxGridView grid){
        var demoAreaWidth = 918;
        var columnWidth = Math.Max(115, demoAreaWidth/grid.Columns.Count);
        for(var i = 1; i < grid.Columns.Count; i++) {
            grid.Columns[i].MinWidth = columnWidth;
        }
        grid.Columns[0].MinWidth = demoAreaWidth - (grid.Columns.Count - 1)*columnWidth;
    }
}

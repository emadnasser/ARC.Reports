using DevExpress.Web;
using DevExpress.Web.Demos;
using DevExpress.XtraReports.Web;
using System;
using System.Web.UI;

public partial class DataBinding_QueryBuilder : Page {
    protected void Page_Init(object sender, EventArgs e) {
        Header.Title = Utils.GetCurrentDemoPageTitle();
        if(!IsPostBack) {
            queryBuilder.OpenConnection(QueryBuilderHelper.NorthwindConnectionParameters, QueryBuilderHelper.LoadQuery(Session));
        }
        QueryBuilderHelper.HideTooltip(Session);
    }
    protected void queryBuilder_SaveQuery(object sender, SaveQueryEventArgs e) {
        QueryBuilderHelper.SaveQuery(e.SelectStatement, e.ResultQuery, Session);
        ASPxWebControl.RedirectOnCallback("~/DataBinding/QueryBuilderControl.aspx");
    }
}

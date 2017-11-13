using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.Demos;

public partial class Features_DataBinding : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack)
            ClubMemberCard.ChangeMode(DetailsViewMode.Edit);
    }

    protected void OnClubMemberDataSourceModifying(object sender, Microsoft.AspNet.EntityDataSource.EntityDataSourceChangingEventArgs e) {
        if(Utils.IsSiteMode) {
            ReadonlyMessageHolder.InnerHtml = Utils.GetReadOnlyMessageHtml();
            e.Cancel = true;
        }
    }
    protected void OnDataBound(object sender, EventArgs e) {
        DetailsView detailsView = (DetailsView)sender;
        if(detailsView.Rows.Count == 0)
            detailsView.ChangeMode(DetailsViewMode.Insert);
    }
}

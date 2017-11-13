using System;
using System.Web.UI;
using DevExpress.Web.Demos;

public partial class DataView_EnableCallback : Page {
    protected string sortField = "";
    protected bool sortDescending = false;

    protected void Page_Load(object sender, EventArgs e) {
        Utils.RegisterCssLink(this, "~/DataView/CSS/CustomCallback.css");
        if(IsPostBack)
            PrepareQuery();
    }


    public string ImagePath {
        get { return @"~\DataView\Images\Cameras\"; }
    }

    public string SortColor(string parameter) {
        return this.sortField.Equals(parameter) ? "dvcSortColor" : "";
    }

    protected void PrepareQuery() {
        this.sortField = (cbSortField.Value != null) ? cbSortField.Value.ToString() : "";
        this.sortDescending = cbSortOrder.SelectedIndex == 1;
        string sortOrder = sortDescending ? "DESC" : string.Empty;
        if(!string.IsNullOrEmpty(this.sortField))
            CamerasDataSource.OrderBy += string.Format("it.{0} {1}", sortField, sortOrder);
        dvCameras.DataBind();
    }
}

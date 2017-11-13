using System;
using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;
using DevExpress.DataAccess.ConnectionParameters;

public partial class ProductDetails : DashboardBasePage {
    protected void OnViewerConfigureDataConnection(object sender, ConfigureDataConnectionWebEventArgs e) {
        XmlFileConnectionParameters parameters = e.ConnectionParameters as XmlFileConnectionParameters;
        parameters.FileName = Server.MapPath("~\\App_Data\\DashboardProductDetails.xml");
    }

    protected void OnViewerDashboardLoaded(object sender, DashboardLoadedWebEventArgs e) {
        string applicationPath = Request.ApplicationPath.TrimEnd('/') + "/";
        BoundImageDashboardItem primaryImage = e.Dashboard.Items["primaryImage"] as BoundImageDashboardItem;
        if(primaryImage != null)
            primaryImage.UriPattern = applicationPath + "Content/ProductDetailsImages/{0}.jpg";
        BoundImageDashboardItem secondaryImage = e.Dashboard.Items["secondaryImage"] as BoundImageDashboardItem;
        if(secondaryImage != null)
            secondaryImage.UriPattern = applicationPath + "Content/ProductDetailsImages/{0} Secondary.jpg";
    }
}

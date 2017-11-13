using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.SessionState;
using System.Web.UI.WebControls;
using System.Xml.Linq;

public partial class _Default : System.Web.UI.Page {

    WorkingMode WorkingMode {
        get {
            string workingModeString = this.Request.QueryString["mode"];
            if(!string.IsNullOrEmpty(workingModeString) && workingModeString == "designer")
                return WorkingMode.Designer;
            return WorkingMode.Viewer;
        }
    }
    
    protected void Page_Init(object sender, EventArgs e) {
        ASPxWebDashboard1.JSProperties["cpIsSqlExpressInstalled"] = DevExpress.Internal.DbEngineDetector.IsSqlExpressInstalled || DevExpress.Internal.DbEngineDetector.IsLocalDbInstalled;
    }
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsCallback && !IsPostBack) {
            ASPxWebDashboard1.WorkingMode = WorkingMode;
        }

        DashboardInMemoryStorage dashboardStorage = Session["DashboardStorage"] as DashboardInMemoryStorage;
        // Uncomment this line to use the App_Data/Dashboards folder to store dashboards.
        //DashboardFileStorage dashboardStorage = new DashboardFileStorage(@"~/App_Data/Dashboards");
        ASPxWebDashboard1.SetDashboardStorage(dashboardStorage);

        DataSourceInMemoryStorage dataSourceStorage = new DataSourceInMemoryStorage();
        dataSourceStorage.RegisterDataSource(DataSourceGenerator.CreateNWindDataSource().SaveToXml());
        ASPxWebDashboard1.SetDataSourceStorage(dataSourceStorage);
        ASPxWebDashboard1.SetConnectionStringsProvider(new ConnectionStringsProvider());
    }

    protected void OnConfigureDataConnection(object sender, DevExpress.DashboardWeb.ConfigureDataConnectionWebEventArgs e) {
        if(e.ConnectionName == "DashboardProductDetailsConnection") {
            DevExpress.DataAccess.ConnectionParameters.XmlFileConnectionParameters parameters = new DevExpress.DataAccess.ConnectionParameters.XmlFileConnectionParameters();
            parameters.FileName = DashboardMainDemo.DataLoader.GetProductDetailsXmlDataSource();
            e.ConnectionParameters = parameters;
        }
    }
    protected void OnDataLoading(object sender, DevExpress.DashboardWeb.DataLoadingWebEventArgs e) {
        DashboardMainDemo.DataLoader.LoadData(e);
    }

    protected void OnDashboardLoading(object sender, DashboardLoadingWebEventArgs e) {
        HttpContext httpContext = HttpContext.Current;
        if(e.DashboardId == "ProductDetails" && httpContext != null) {
            Dashboard dashboard = new Dashboard();
            dashboard.LoadFromXDocument(e.DashboardXml);
            string applicationPath = httpContext.Request.ApplicationPath.TrimEnd('/') + "/";
            BoundImageDashboardItem primaryImage = dashboard.Items["primaryImage"] as BoundImageDashboardItem;
            if(primaryImage != null)
                primaryImage.UriPattern = applicationPath + "Content/ProductDetailsImages/{0}.jpg";
            BoundImageDashboardItem secondaryImage = dashboard.Items["secondaryImage"] as BoundImageDashboardItem;
            if(secondaryImage != null)
                secondaryImage.UriPattern = applicationPath + "Content/ProductDetailsImages/{0} Secondary.jpg";
            e.DashboardXml = dashboard.SaveToXDocument();
        }
    }
}

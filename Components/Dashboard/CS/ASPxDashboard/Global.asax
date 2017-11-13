<%@ Application Language="C#" %>

<script runat="server">
    
    void Application_Start(object sender, EventArgs e) {
       
    }
    protected void Session_Start(object sender, EventArgs e) {
        DevExpress.Utils.UrlAccessSecurityLevelSetting.RegisterCustomBaseDirectories(HttpContext.Current.Server.MapPath("~/Content/ProductDetailsImages"));
        DevExpress.DashboardWeb.DashboardInMemoryStorage storage = new DevExpress.DashboardWeb.DashboardInMemoryStorage();
        RegisterDashboard(storage, "SalesOverview");
        RegisterDashboard(storage, "SalesPerformance");
        RegisterDashboard(storage, "SalesDetails");
        RegisterDashboard(storage, "RevenueAnalysis");
        RegisterDashboard(storage, "HumanResources");
        RegisterDashboard(storage, "CustomerSupport");
        RegisterDashboard(storage, "RevenueByIndustry");
        RegisterDashboard(storage, "EnergyConsumption");
        RegisterDashboard(storage, "EnergyStatistics");
        RegisterDashboard(storage, "WebsiteStatistics");
        RegisterDashboard(storage, "ChampionsLeagueStatistics");
        RegisterDashboard(storage, "ProductDetails");
        RegisterDashboard(storage, "EUTradeOverview");
        HttpContext.Current.Session["DashboardStorage"] = storage;
    }
    void RegisterDashboard(DevExpress.DashboardWeb.DashboardInMemoryStorage storage, string dashboardId) {
        string dashboardLocalPath = Server.MapPath(string.Format(@"~/App_Data/Dashboards/{0}.xml", dashboardId));
        storage.RegisterDashboard(dashboardId, XDocument.Load(dashboardLocalPath));
    }

   
</script>

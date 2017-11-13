using System;
using System.Web;
using System.Web.Routing;
using System.Xml.Linq;

namespace DevExpress.Web.Demos {
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication {
        

        protected void Application_Start() {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            DashboardConfig.RegisterService(RouteTable.Routes);
            DevExpress.Utils.UrlAccessSecurityLevelSetting.RegisterCustomBaseDirectories(HttpContext.Current.Server.MapPath("~/Content/ProductDetailsImages"));
            DevExpress.Web.ASPxWebControl.CallbackError += new EventHandler(CallbackError);
        }


        protected void Session_Start() {
            RegisterDefaultDashboard("SalesOverview");
            RegisterDefaultDashboard("SalesPerformance");
            RegisterDefaultDashboard("SalesDetails");
            RegisterDefaultDashboard("RevenueAnalysis");
            RegisterDefaultDashboard("HumanResources");
            RegisterDefaultDashboard("CustomerSupport");
            RegisterDefaultDashboard("RevenueByIndustry");
            RegisterDefaultDashboard("EnergyConsumption");
            RegisterDefaultDashboard("EnergyStatistics");
            RegisterDefaultDashboard("WebsiteStatistics");
            RegisterDefaultDashboard("ChampionsLeagueStatistics");
            RegisterDefaultDashboard("ProductDetails");
            RegisterDefaultDashboard("EUTradeOverview");

        }
        void RegisterDefaultDashboard(string dashboardId) {
            string dashboardLocalPath = Server.MapPath(string.Format(@"~/App_Data/Dashboards/{0}.xml", dashboardId));
            SessionDashboardStorage.Instance.RegisterDashboard(dashboardId, XDocument.Load(dashboardLocalPath));
        }

        void CallbackError(object sender, EventArgs e) {
            // Logging exceptions occur on callback events of DevExpress ASP.NET MVC controls. 
            // To learn more, see http://www.devexpress.com/Support/Center/Example/Details/E4588
        }
    }
}

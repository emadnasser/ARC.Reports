using System.Web.Routing;
using DevExpress.DashboardWeb.Mvc;
using DevExpress.DashboardWeb;

namespace DevExpress.Web.Demos {
    public class DashboardConfig {
        public static void RegisterService(RouteCollection routes) {
            routes.MapDashboardRoute();

            
            DashboardConfigurator.Default.SetDashboardStorage(SessionDashboardStorage.Instance);

            DataSourceInMemoryStorage dataSourceStorage = new DataSourceInMemoryStorage();
            dataSourceStorage.RegisterDataSource(DataSourceGenerator.CreateNWindDataSource().SaveToXml());
            DashboardConfigurator.Default.SetDataSourceStorage(dataSourceStorage);
            DashboardConfigurator.Default.SetConnectionStringsProvider(new ConnectionStringsProvider());

            DashboardConfigurator.Default.DataLoading += (s, e) => {
                DashboardMainDemo.DataLoader.LoadData(e);
            };
            DashboardConfigurator.Default.ConfigureDataConnection += (s, e) => {
                if(e.ConnectionName == "DashboardProductDetailsConnection") {
                    DevExpress.DataAccess.ConnectionParameters.XmlFileConnectionParameters parameters = new DevExpress.DataAccess.ConnectionParameters.XmlFileConnectionParameters();
                    parameters.FileName = DashboardMainDemo.DataLoader.GetProductDetailsXmlDataSource();
                    e.ConnectionParameters = parameters;
                }
            };
        }
    }
   
    
}

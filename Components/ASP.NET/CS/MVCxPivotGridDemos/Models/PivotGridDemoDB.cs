using System.Web;
using DevExpress.Web.Demos.Models;
using System.Linq;
using DevExpress.Web.Demos.PivotModels;

namespace DevExpress.Web.Demos {
    public static class PivotGridDemoDBProvider {
        const string ServerModeDataContextKey = "DXServerModeDataContext";

        public static PivotGridDemoDBDataContext DB {
            get {
                if(HttpContext.Current.Items[ServerModeDataContextKey] == null)
                    HttpContext.Current.Items[ServerModeDataContextKey] = new PivotGridDemoDBDataContextExt();
                return (PivotGridDemoDBDataContext)HttpContext.Current.Items[ServerModeDataContextKey];
            }
        }

        public static IQueryable<Sale> Sales { get { return DB.Sales; } }
    }
}

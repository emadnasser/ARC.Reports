using System.Web;
using System.Web.Mvc;

namespace DX_Bootstrapped {
    public class FilterConfig {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
using DevExpress.DashboardWeb;
using System.Web.Mvc;

namespace DashboardMvcDemo.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            string workingModeString = this.Request.QueryString["mode"];
            var workingMode = !string.IsNullOrEmpty(workingModeString) && workingModeString == "designer" ? WorkingMode.Designer : WorkingMode.Viewer;
            return View(workingMode);
        }
    }
}

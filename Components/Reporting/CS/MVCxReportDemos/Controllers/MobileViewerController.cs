using System.Web.Mvc;

namespace DevExpress.Web.Demos.Controllers {
    public class MobileViewerController : Controller {
        public ActionResult Index(string reportName) {
            var model = ReportDemoHelper.CreateModel(reportName, Session, Request);
            return View(model);
        }
    }
}

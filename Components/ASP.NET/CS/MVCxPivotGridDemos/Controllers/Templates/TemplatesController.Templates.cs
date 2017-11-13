using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class TemplatesController: DemoController {
        public ActionResult Templates() {
            return DemoView("Templates", NorthwindDataProvider.GetProductReports());
        }
        public ActionResult TemplatesPartial() {
            return PartialView("TemplatesPartial", NorthwindDataProvider.GetProductReports());
        }
    }
}

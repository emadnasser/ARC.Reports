using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AdaptivityController : DemoController {
        public ActionResult AdaptiveLayoutWithFormLayout() {
            return DemoView("AdaptiveLayoutWithFormLayout");
        }
        public ActionResult AdaptiveLayoutWithFormLayoutPage() {
            return View("AdaptiveLayoutWithFormLayoutPage", NorthwindDataProvider.GetProducts());
        }
        public ActionResult AdaptiveLayoutWithFormLayoutPagePartial() {
            return PartialView("AdaptiveLayoutWithFormLayoutPagePartial", NorthwindDataProvider.GetProducts());
        }
    }
}

using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AdaptivityController: DemoController {
        public ActionResult Ellipsis() {
            return DemoView("Ellipsis", NorthwindDataProvider.GetEmployees());
        }
        public ActionResult EllipsisPartial(bool? enableEllipsis) {
            ViewBag.EnableEllipsis = enableEllipsis.HasValue ? enableEllipsis.Value : true;
            return PartialView("EllipsisPartial", NorthwindDataProvider.GetEmployees());
        }
    }
}

using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AccessibilityController : DemoController {
        public ActionResult KeyboardSupport() {
            return DemoView("KeyboardSupport", NorthwindDataProvider.GetProducts());
        }
        public ActionResult KeyboardSupportPartial() {
            return PartialView("KeyboardSupportPartial", NorthwindDataProvider.GetProducts());
        }
    }
}

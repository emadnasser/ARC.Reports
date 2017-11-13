using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ColumnsController : DemoController {
        public ActionResult CustomizationWindow() {
            return DemoView("CustomizationWindow", NorthwindDataProvider.GetCustomers());
        }
        public ActionResult CustomizationWindowPartial() {
            return PartialView("CustomizationWindowPartial", NorthwindDataProvider.GetCustomers());
        }
    }
}

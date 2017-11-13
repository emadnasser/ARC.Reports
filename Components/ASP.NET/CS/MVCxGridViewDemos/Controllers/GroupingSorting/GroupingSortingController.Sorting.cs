using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class GroupingSortingController: DemoController {
        public ActionResult Sorting() {
            return DemoView("Sorting", NorthwindDataProvider.GetCustomers());
        }
        public ActionResult SortingPartial() {
            return PartialView("SortingPartial", NorthwindDataProvider.GetCustomers());
        }
    }
}

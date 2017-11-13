using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class GroupingSortingController: DemoController {
        public ActionResult FixedGroups() {
            return DemoView("FixedGroups", NorthwindDataProvider.GetCustomers());
        }
        public ActionResult FixedGroupsPartial() {
            return PartialView("FixedGroupsPartial", NorthwindDataProvider.GetCustomers());
        }
    }
}

using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FilteringAndSortingController: DemoController {
        public ActionResult Sorting() {
            return DemoView("Sorting", HomesDataProvider.Homes);
        }
        public ActionResult SortingPartial() {
            return PartialView("SortingPartial", HomesDataProvider.Homes);
        }
    }
}

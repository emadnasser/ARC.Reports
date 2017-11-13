using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class SelectionController: DemoController {
        public ActionResult AdvancedSelection() {
            return DemoView("AdvancedSelection", NorthwindDataProvider.GetCustomers());
        }
        [HttpPost]
        public ActionResult AdvancedSelection(GridViewSelectAllCheckBoxMode selectAllMode) {
            GridViewSelectionDemoHelper.SelectAllButtonMode = selectAllMode;
            return DemoView("AdvancedSelection", NorthwindDataProvider.GetCustomers());
        }
        public ActionResult AdvancedSelectionPartial() {
            return PartialView("AdvancedSelectionPartial", NorthwindDataProvider.GetCustomers());
        }
    }
}

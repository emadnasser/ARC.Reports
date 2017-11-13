using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class SelectionController : DemoController {
        public ActionResult RowSelection() {
            return DemoView("RowSelection", NorthwindDataProvider.GetCustomers());
        }
        public ActionResult RowSelectionPartial() {
            return PartialView("RowSelectionPartial", NorthwindDataProvider.GetCustomers());
        }
    }
}

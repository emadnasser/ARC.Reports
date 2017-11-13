using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ColumnsController: DemoController {
        public ActionResult ColumnResizing() {
            return DemoView("ColumnResizing", NorthwindDataProvider.GetCustomers());
        }
        public ActionResult ColumnResizingPartial() {
            return PartialView("ColumnResizingPartial", NorthwindDataProvider.GetCustomers());
        }
        [HttpPost]
        public ActionResult ColumnResizing(ColumnResizingDemoOptions options) {
            ColumnResizingDemoHelper.Options = options;
            return DemoView("ColumnResizing", NorthwindDataProvider.GetCustomers());
        }
    }
}

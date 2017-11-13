using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ShapingController : DemoController {
        public ActionResult ColumnResizing() {
            return DemoView("ColumnResizing", DepartmentsProvider.GetDepartments());
        }
        
        public ActionResult ColumnResizingPartial() {
            return PartialView("ColumnResizingPartial", DepartmentsProvider.GetDepartments());
        }
        
        [HttpPost]
        public ActionResult ColumnResizing(ColumnResizingDemoOptions options) {
            ColumnResizingDemoHelper.Options = options;
            return DemoView("ColumnResizing", DepartmentsProvider.GetDepartments());
        }
    }
}

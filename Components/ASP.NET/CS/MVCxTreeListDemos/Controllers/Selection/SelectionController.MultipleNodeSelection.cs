using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class SelectionController : DemoController {
        public ActionResult MultipleNodeSelection() {
            Session["SelectionOptions"] = new TreeListMultipleSelectionDemoOptions { SelectMode = "All" };
            return DemoView("MultipleNodeSelection", DepartmentsProvider.GetDepartments());
        }
        [HttpPost]
        public ActionResult MultipleNodeSelection([Bind] TreeListMultipleSelectionDemoOptions options) {
            Session["SelectionOptions"] = options;
            return DemoView("MultipleNodeSelection", DepartmentsProvider.GetDepartments());
        }
        public ActionResult MultipleNodeSelectionPartial() {
            return PartialView("MultipleNodeSelectionPartial", DepartmentsProvider.GetDepartments());
        }
    }
}

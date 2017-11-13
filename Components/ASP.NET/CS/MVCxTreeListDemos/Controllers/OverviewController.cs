using System.Web.Mvc;
using System.Collections;
using DevExpress.Web.Mvc;
using System.Collections.Generic;

namespace DevExpress.Web.Demos {
    public partial class OverviewController: DemoController {
        public override string Name { get { return ""; } }

        public ActionResult Index() {
            return DemoView("Overview", DepartmentsProvider.GetDepartments());
        }
        public ActionResult OverviewPartial() {
            return PartialView("OverviewPartial", DepartmentsProvider.GetDepartments());
        }
    }
}

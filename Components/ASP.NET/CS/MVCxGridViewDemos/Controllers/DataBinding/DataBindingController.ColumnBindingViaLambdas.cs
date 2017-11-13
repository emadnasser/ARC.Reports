using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class DataBindingController: DemoController {
        public ActionResult ColumnBindingViaLambdas() {
            return DemoView("ColumnBindingViaLambdas", NorthwindDataProvider.GetEditableCustomers());
        }
        public ActionResult ColumnBindingViaLambdasPartial() {
            return PartialView("ColumnBindingViaLambdasPartial", NorthwindDataProvider.GetEditableCustomers());
        }
    }
}

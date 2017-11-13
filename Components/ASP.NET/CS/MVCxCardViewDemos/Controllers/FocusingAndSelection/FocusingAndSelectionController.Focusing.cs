using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FocusingAndSelectionController: DemoController {
        public ActionResult Focusing() {
            return DemoView("Focusing", NorthwindDataProvider.GetEmployees());
        }
        public ActionResult FocusingPartial() {
            return PartialView("FocusingPartial", NorthwindDataProvider.GetEmployees());
        }
    }
}

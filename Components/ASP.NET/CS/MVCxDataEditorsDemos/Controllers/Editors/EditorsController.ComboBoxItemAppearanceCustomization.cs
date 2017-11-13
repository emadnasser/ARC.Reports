using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditorsController : DemoController {
        public ActionResult ComboBoxItemAppearanceCustomization() {
            ViewData["Customers"] = NorthwindDataProvider.GetCustomers();
            return DemoView("ComboBoxItemAppearanceCustomization");
        }
        public ActionResult ComboBoxItemAppearanceCustomizationPartial() {
            ViewData["Customers"] = NorthwindDataProvider.GetCustomers();
            return PartialView();
        }
    }
}

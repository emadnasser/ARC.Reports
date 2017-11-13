using System;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AccessibilityController : DemoController {
        public ActionResult RightToLeft() {
            return DemoView("RightToLeft", NorthwindDataProvider.GetEditableCustomers());
        }
        public ActionResult RightToLeftPartial() {
            return PartialView("RightToLeftPartial", NorthwindDataProvider.GetEditableCustomers());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult RightToLeftUpdatePartial(EditableCustomer customer) {
            if(ModelState.IsValid) {
                try {
                    NorthwindDataProvider.UpdateCustomer(customer);
                }
                catch(Exception e) {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("RightToLeftPartial", NorthwindDataProvider.GetEditableCustomers());
        }
    }
}

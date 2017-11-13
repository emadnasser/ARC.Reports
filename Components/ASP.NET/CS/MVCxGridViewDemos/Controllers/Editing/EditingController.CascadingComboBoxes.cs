using System;
using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditingController : DemoController {
        public ActionResult CascadingComboBoxes() {
            return DemoView("CascadingComboBoxes", NorthwindDataProvider.GetEditableCustomers());
        }
        [ValidateInput(false)]
        public ActionResult CascadingComboBoxesPartial() {
            return PartialView("CascadingComboBoxesPartial", NorthwindDataProvider.GetEditableCustomers());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult CascadingComboBoxesUpdatePartial(EditableCustomer customer) {
            if(ModelState.IsValid) {
                try {
                    NorthwindDataProvider.UpdateCustomer(customer);
                }
                catch(Exception e) {
                    ViewBag.EditError = e.Message;
                }
            }
            else
                ViewBag.EditError = "Please, correct all errors.";

            return PartialView("CascadingComboBoxesPartial", NorthwindDataProvider.GetEditableCustomers());
        }
        public ActionResult GetCities(string countryName, string textField) {
            return GridViewExtension.GetComboBoxCallbackResult(p => {
                p.TextField = textField;
                p.BindList(WorldCitiesDataProvider.GetCities(countryName));
            });
        }
    }
}

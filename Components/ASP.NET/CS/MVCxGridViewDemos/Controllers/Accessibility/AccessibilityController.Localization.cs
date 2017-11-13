using System;
using System.Globalization;
using System.Threading;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AccessibilityController : DemoController {
        public ActionResult Localization() {
            return DemoView("Localization", NorthwindDataProvider.GetEditableEmployees());
        }
        [HttpPost]
        public ActionResult Localization(string language) {
            Session["CurrentCulture"] = CultureInfo.GetCultureInfo(language);
            GridViewAccessibilityDemoHelper.ApplyCurrentCulture();
            return DemoView("Localization", NorthwindDataProvider.GetEditableEmployees());
        }
        public ActionResult LocalizationPartial() {
            GridViewAccessibilityDemoHelper.ApplyCurrentCulture();
            return PartialView("LocalizationPartial", NorthwindDataProvider.GetEditableEmployees());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult LocalizationUpdatePartial(EditableEmployee employee) {
            if(ModelState.IsValid) {
                try {
                    NorthwindDataProvider.UpdateEditableEmployee(employee);
                }
                catch(Exception e) {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("LocalizationPartial", NorthwindDataProvider.GetEditableEmployees());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult LocalizationAddNewPartial(EditableEmployee employee) {
            if(ModelState.IsValid) {
                try {
                    NorthwindDataProvider.InsertEditableEmployee(employee);
                }
                catch(Exception e) {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("LocalizationPartial", NorthwindDataProvider.GetEditableEmployees());
        }
    }
}

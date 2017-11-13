using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditingController: DemoController {
        public ActionResult BinaryImageColumn() {
            return DemoView("BinaryImageColumn", NorthwindDataProvider.GetEditableEmployees());
        }
        public ActionResult BinaryImageColumnPartial() {
            return PartialView("BinaryImageColumnpartial", NorthwindDataProvider.GetEditableEmployees());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult BinaryImageColumnUpdatePartial(EditableEmployee employee) {
            if(ModelState.IsValid) {
                try {
                    NorthwindDataProvider.UpdateEditableEmployee(employee);
                }
                catch(Exception e) {
                    ViewData["EditError"] = e.Message;
                }
            }
            else {
                ViewData["EditError"] = "Please, correct all errors.";
            }

            return PartialView("BinaryImageColumnpartial", NorthwindDataProvider.GetEditableEmployees());
        }
        public ActionResult BinaryImageColumnPhotoUpdate() {
            return BinaryImageEditExtension.GetCallbackResult();
        }
    }
}

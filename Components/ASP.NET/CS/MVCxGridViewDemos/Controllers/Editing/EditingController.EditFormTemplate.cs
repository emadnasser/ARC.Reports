using System;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditingController : DemoController {
        public ActionResult EditFormTemplate() {
            return DemoView("EditFormTemplate", NorthwindDataProvider.GetEditableProducts());
        }
        [ValidateInput(false)]
        public ActionResult EditFormTemplatePartial() {
            return PartialView("EditFormTemplatePartial", NorthwindDataProvider.GetEditableProducts());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult EditFormTemplateAddNewPartial(EditableProduct product) {
            if(ModelState.IsValid) {
                try {
                    NorthwindDataProvider.InsertProduct(product);
                }
                catch(Exception e) {
                    ViewData["EditError"] = e.Message;
                }
            }
            else {
                ViewData["EditError"] = "Please, correct all errors.";
                ViewData["EditableProduct"] = product;
            }
            return PartialView("EditFormTemplatePartial", NorthwindDataProvider.GetEditableProducts());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult EditFormTemplateUpdatePartial(EditableProduct product) {
            if(ModelState.IsValid) {
                try {
                    NorthwindDataProvider.UpdateProduct(product);
                }
                catch(Exception e) {
                    ViewData["EditError"] = e.Message;
                }
            }
            else {
                ViewData["EditError"] = "Please, correct all errors.";
                ViewData["EditableProduct"] = product;
            }

            return PartialView("EditFormTemplatePartial", NorthwindDataProvider.GetEditableProducts());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult EditFormTemplateDeletePartial(int productID) {
            if(productID > 0) {
                try {
                    NorthwindDataProvider.DeleteProduct(productID);
                }
                catch(Exception e) {
                    ViewData["EditError"] = e.Message;
                }
            }
            return PartialView("EditFormTemplatePartial", NorthwindDataProvider.GetEditableProducts());
        }
    }
}

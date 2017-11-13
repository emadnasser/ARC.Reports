using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevExpress.Web.Demos
{
    public partial class EditingController : DemoController {

        public ActionResult EditFormLayout() {
            return DemoView("EditFormLayout", NorthwindDataProvider.GetEditableProducts());
        }
        [ValidateInput(false)]
        public ActionResult EditFormLayoutPartial() {
            return PartialView("EditFormLayoutPartial", NorthwindDataProvider.GetEditableProducts());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult EditFormLayoutAddNewPartial(EditableProduct product) {
            if(ModelState.IsValid) {
                try {
                    NorthwindDataProvider.InsertProduct(product);
                }
                catch(Exception e) {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("EditFormLayoutPartial", NorthwindDataProvider.GetEditableProducts());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult EditFormLayoutUpdatePartial(EditableProduct product) {
            if(ModelState.IsValid) {
                try {
                    NorthwindDataProvider.UpdateProduct(product);
                }
                catch(Exception e) {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("EditFormLayoutPartial", NorthwindDataProvider.GetEditableProducts());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult EditFormLayoutDeletePartial(int productID) {
            if(productID > 0) {
                try {
                    NorthwindDataProvider.DeleteProduct(productID);
                }
                catch(Exception e) {
                    ViewData["EditError"] = e.Message;
                }
            }
            return PartialView("EditFormLayoutPartial", NorthwindDataProvider.GetEditableProducts());
        }

    }
}

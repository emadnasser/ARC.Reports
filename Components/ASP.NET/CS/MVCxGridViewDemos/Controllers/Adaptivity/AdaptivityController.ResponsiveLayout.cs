using System.Web.Mvc;
using System;

namespace DevExpress.Web.Demos {
    public partial class AdaptivityController : DemoController {
        public ActionResult ResponsiveLayout() {
            return DemoView("ResponsiveLayout");
        }
        public ActionResult ResponsiveLayoutPage() {
            return View("ResponsiveLayoutPage", NorthwindDataProvider.GetProducts());
        }
        public ActionResult ResponsiveLayoutPagePartial() {
            return PartialView("ResponsiveLayoutPagePartial", NorthwindDataProvider.GetEditableProducts());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult ResponsiveLayoutAddNewPartial(EditableProduct product) {
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
            return PartialView("ResponsiveLayoutPagePartial", NorthwindDataProvider.GetEditableProducts());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult ResponsiveLayoutUpdatePartial(EditableProduct product) {
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

            return PartialView("ResponsiveLayoutPagePartial", NorthwindDataProvider.GetEditableProducts());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult ResponsiveLayoutDeletePartial(int productID) {
            if(productID >= 0) {
                try {
                    NorthwindDataProvider.DeleteProduct(productID);
                }
                catch(Exception e) {
                    ViewData["EditError"] = e.Message;
                }
            }
            return PartialView("ResponsiveLayoutPagePartial", NorthwindDataProvider.GetEditableProducts());
        }
    }
}

using System;
using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AccessibilityController : DemoController {
        public ActionResult ComplianceEditing() {
            return DemoView("ComplianceEditing", NorthwindDataProvider.GetEditableProducts());
        }
        [HttpPost]
        public ActionResult ComplianceEditing(GridViewEditingMode editMode) {
            GridViewAccessibilityDemoHelper.EditMode = editMode;
            return DemoView("ComplianceEditing", NorthwindDataProvider.GetEditableProducts());
        }
        public ActionResult ComplianceEditingPartial() {
            return PartialView("ComplianceEditingPartial", NorthwindDataProvider.GetEditableProducts());
        }
        [ValidateInput(false)]
        public ActionResult ComplianceEditingUpdateModel(EditableProduct product) {
            if(ModelState.IsValid) {
                try {
                    NorthwindDataProvider.UpdateProduct(product);
                } catch(Exception e) {
                    ViewData["EditError"] = e.Message;
                }
            } else
                ViewData["EditError"] = "Please, correct all errors.";

            return PartialView("ComplianceEditingPartial", NorthwindDataProvider.GetEditableProducts());
        }
        [ValidateInput(false)]
        public ActionResult ComplianceBatchEditingUpdateModel(MVCxGridViewBatchUpdateValues<EditableProduct, int> updateValues) {
            foreach(var product in updateValues.Update) {
                if(updateValues.IsValid(product)) {
                    try {
                        NorthwindDataProvider.UpdateProduct(product);
                    } catch(Exception e) {
                        updateValues.SetErrorText(product, e.Message);
                    }
                }
            }
            return PartialView("ComplianceEditingPartial", NorthwindDataProvider.GetEditableProducts());
        }
    }
}

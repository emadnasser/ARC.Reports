using System.Web.Mvc;

namespace DevExpress.Web.Demos {

    public partial class FeaturesController : DemoController {
        public ActionResult Validation() {
            return DemoView("Validation", ValidationDemoModel.CreateDefault());
        }
        [HttpPost]
        public ActionResult Validation([ModelBinder(typeof(ValidationDemoBinder))]ValidationDemoModel model) {
            if(ModelState.IsValid)
                return DemoView("Validation", "ValidationSuccess");
            return DemoView("Validation", model);
        }
        public ActionResult ValidationPartial(ValidationDemoModel model) {
            return PartialView("ValidationPartial", model);
        }
    }
}

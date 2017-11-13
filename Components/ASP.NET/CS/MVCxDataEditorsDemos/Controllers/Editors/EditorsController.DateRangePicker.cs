using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditorsController : DemoController {
        public ActionResult DateRangePicker() {
            return DemoView("DateRangePicker", new DateRangePickerModel());
        }
        [HttpPost]
        public ActionResult DateRangePicker(DateRangePickerModel model) {
            if(Request.Params["Submit"] == null)
                ModelState.Clear();
            else
                ViewBag.SuccessValidation = true;
            return DemoView("DateRangePicker", model);
        }
    }
}

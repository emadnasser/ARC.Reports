using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditorsController : DemoController {
        [HttpGet]
        public ActionResult CheckBoxList() {
            ViewData["Options"] = new CheckListDemoOptions();
            return DemoView("CheckBoxList");
        }
        [HttpPost]
        public ActionResult CheckBoxList([Bind]CheckListDemoOptions options) {
            ViewData["Options"] = options;
            return DemoView("CheckBoxList");
        }
    }
}

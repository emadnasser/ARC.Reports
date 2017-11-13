using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditorsController : DemoController {
        public ActionResult TokenBox() {
            ViewData["TokenBoxOptions"] = new TokenBoxOptions();
            return DemoView("TokenBox");
        }
        [HttpPost]
        public ActionResult TokenBox(TokenBoxOptions options) {
            ViewData["TokenBoxOptions"] = options;
            return DemoView("TokenBox");
        }
    }
}

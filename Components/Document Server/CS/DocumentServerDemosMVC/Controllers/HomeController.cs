using System;
using System.Web.Mvc;
using System.Web;
using System.Collections;

namespace DevExpress.Web.Demos {
    [HandleError]
    public class HomeController : DemoController {
        public override string Name {
            get {
                return "Home";
            }
        }

        public ActionResult Index() {
            return DemoView("Index");
        }
        public ActionResult DemoTabsPartial(string group, string demo) {
            Utils.RegisterCurrentMvcDemo(group, demo);
            return PartialView("DemoTabsPartial");
        }
        public ActionResult SearchListPartial(string text) {
            ViewData["RequestText"] = text;
            return PartialView("SearchListPartial", SearchUtils.DoSearch(text));
        }
    }
}

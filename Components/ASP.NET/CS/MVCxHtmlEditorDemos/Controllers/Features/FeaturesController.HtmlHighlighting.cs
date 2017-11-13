using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FeaturesController: DemoController {
        public ActionResult HtmlHighlighting() {
            Session["Options"] = new HtmlEditorHtmlHighlightingDemoOptions();
            return DemoView("HtmlHighlighting", Session["Options"]);
        }
        [HttpPost]
        public ActionResult HtmlHighlighting([Bind]HtmlEditorHtmlHighlightingDemoOptions options) {
            Session["Options"] = options;
            return DemoView("HtmlHighlighting", options);
        }
        public ActionResult HtmlHighlightingPartial() {
            return PartialView("HtmlHighlightingPartial", Session["Options"]);
        }
    }
}

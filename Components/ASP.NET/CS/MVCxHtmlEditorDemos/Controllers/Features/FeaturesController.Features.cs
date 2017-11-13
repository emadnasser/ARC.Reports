using System.Web.Mvc;
using DevExpress.Web.ASPxHtmlEditor;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FeaturesController : DemoController {
        public ActionResult Features() {
            var FeaturesHtml = HtmlEditorFeaturesDemosHelper.GeHtmlContentByFileName("General.html");
            Session["Options"] = new HtmlEditorFeaturesDemoOptions();
            return DemoView("Features", new MvcHtmlString(FeaturesHtml));
        }
        [HttpPost]
        public ActionResult Features(string FeaturesHtml, [Bind]HtmlEditorFeaturesDemoOptions options) {
            Session["Options"] = options;
            return DemoView("Features", new MvcHtmlString(FeaturesHtml));
        }
        public ActionResult FeaturesPartial() {
            return PartialView("FeaturesPartial");
        }
        public ActionResult FeaturesImageSelectorUpload() {
            HtmlEditorExtension.SaveUploadedImage("FeaturesHtml", HtmlEditorFeaturesDemosHelper.ImageSelectorSettings);
            return null;
        }
    }
}

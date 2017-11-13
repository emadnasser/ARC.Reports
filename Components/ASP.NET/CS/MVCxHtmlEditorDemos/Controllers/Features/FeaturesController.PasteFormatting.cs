using System.Web.Mvc;
using DevExpress.Web.ASPxHtmlEditor;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FeaturesController: DemoController {
        public ActionResult PasteFormatting() {
            Session["Options"] = new HtmlEditorPasteFormattingDemoOptions();
            return DemoView("PasteFormatting", Session["Options"]);
        }
        [HttpPost]
        public ActionResult PasteFormatting([Bind]HtmlEditorPasteFormattingDemoOptions options) {
            Session["Options"] = options;
            return DemoView("PasteFormatting", options);
        }
        public ActionResult PasteFormattingPartial() {
            return PartialView("PasteFormattingPartial", Session["Options"]);
        }
    }
    public class HtmlEditorPasteFormattingDemoOptions {
        public HtmlEditorPasteFormattingDemoOptions() {
            EnablePasteOptions = true;
            PasteMode = ASPxHtmlEditor.HtmlEditorPasteMode.SourceFormatting;
        }
        public bool EnablePasteOptions { get; set; }
        public HtmlEditorPasteMode PasteMode { get; set; }
    }
}

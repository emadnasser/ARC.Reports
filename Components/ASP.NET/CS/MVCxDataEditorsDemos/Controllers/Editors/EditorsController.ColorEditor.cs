using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditorsController : DemoController {
        [HttpGet]
        public ActionResult ColorEditor() {
            ColorEditorDemoHelper.Options = new ColorEditorDemoOptions();
            return DemoView("ColorEditor", new RoundPanelAppearance());
        }
        [HttpPost]
        public ActionResult ColorEditor(ColorEditorDemoOptions options, RoundPanelAppearance roundPanelAppearance) {
            ColorEditorDemoHelper.Options = options;
            return DemoView("ColorEditor", roundPanelAppearance);
        }
    }
}

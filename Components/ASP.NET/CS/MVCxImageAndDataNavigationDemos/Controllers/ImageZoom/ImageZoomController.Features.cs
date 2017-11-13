using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ImageZoomController: DemoController {
        public ActionResult Features() {
            return DemoView("Features", new ImageZoomFeaturesOptions());
        }
        [HttpPost]
        public ActionResult Features(ImageZoomFeaturesOptions options) {
            return DemoView("Features", options);
        }
    }
}

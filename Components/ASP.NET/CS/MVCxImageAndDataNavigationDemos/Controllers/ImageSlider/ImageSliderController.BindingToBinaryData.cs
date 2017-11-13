using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ImageSliderController : DemoController {
        public ActionResult BindingToBinaryData() {
            return DemoView("BindingToBinaryData", BinaryImages.GetData());
        }
        [HttpPost]
        public ActionResult BindingToBinaryData(int? categoryId) {
            return DemoView("BindingToBinaryData", BinaryImages.GetData(categoryId));
        }
    }
}

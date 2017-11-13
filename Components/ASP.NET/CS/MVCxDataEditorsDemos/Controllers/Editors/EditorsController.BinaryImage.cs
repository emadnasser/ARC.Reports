using System.IO;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditorsController: DemoController {
        const string FileName = @"~\Content\Editors\BinaryImage\Thumbs\people_1200px.jpg";

        public ActionResult BinaryImage() {
            ViewBag.DemoOptions = new BinaryImageDemoOptions();
            return DemoView("BinaryImage");
        }
        public ActionResult BinaryImagePartial(BinaryImageDemoOptions options) {
            ViewBag.DemoOptions = options;
            return PartialView("BinaryImagePartial", GetByteArrayFromImage());
        }

        protected byte[] GetByteArrayFromImage() {
            using (FileStream stream = new FileStream(Server.MapPath(FileName), FileMode.Open, FileAccess.Read)) {
                byte[] imageInByteArray = new byte[stream.Length];
                stream.Read(imageInByteArray, 0, (int)stream.Length);
                return imageInByteArray;
            }
        }
    }
}

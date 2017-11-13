using DevExpress.Web;
using DevExpress.Web.Internal;
using System.Web.Mvc;
using System.Web.UI;
using System.IO;
using System;
using DevExpress.XtraRichEdit;

namespace DevExpress.Web.Demos {
    public partial class MiscellaneousController : DemoController {
        public override string Name { get { return "Miscellaneous"; } }

        public ActionResult Index() {
            return RedirectToAction("EncodingDetection");
        }
    }
}

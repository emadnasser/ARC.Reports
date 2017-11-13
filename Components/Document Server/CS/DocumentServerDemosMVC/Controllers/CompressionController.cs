using DevExpress.Web;
using DevExpress.Web.Internal;
using System.Web.Mvc;
using System.Web.UI;
using DevExpress.Spreadsheet;
using System.IO;
using System;

namespace DevExpress.Web.Demos {
    public partial class CompressionController : DemoController {
        public override string Name { get { return "Compression"; } }

        public ActionResult Index() {
            return RedirectToAction("Compress");
        }
    }
}

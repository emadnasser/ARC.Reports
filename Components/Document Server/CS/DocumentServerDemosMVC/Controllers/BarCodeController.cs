using DevExpress.Web;
using DevExpress.Web.Internal;
using System.Web.Mvc;
using System.Web.UI;
using System.IO;
using System;
using DevExpress.XtraRichEdit;

namespace DevExpress.Web.Demos {
    public partial class BarCodeController : DemoController {
        public override string Name { get { return "BarCode"; } }

        public ActionResult Index() {
            return RedirectToAction("BarCodeVisualization");
        }
    }
}

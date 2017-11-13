using DevExpress.XtraCharts;
using System.Collections.Generic;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class MiscellaneousController: DemoController {
        List<DataFilter> filters = new List<DataFilter>();

        public override string Name { get { return "Miscellaneous"; } }
        public int Angle { get; set; }           

        public ActionResult Index() {
            return RedirectToAction("HitTesting");
        }
    }
}

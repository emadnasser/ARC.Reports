using System.Web.Mvc;
using DevExpress.Web.Mvc;
using DevExpress.XtraReports.UI;

namespace DevExpress.Web.Demos {
    public partial class OverviewController: DemoController {
        public override string Name { get { return ""; } }

        public ActionResult Index() {
            var model = ReportDemoHelper.CreateModel("Overview", Session, Request);
            return DemoView("Overview", model);
        }
        public ActionResult OverviewPartial() {
            var model = ReportDemoHelper.CreateModel("Overview", Session, Request);
            return PartialView("OverviewPartial", model);
        }
        public ActionResult DocumentViewerExportTo() {
            return DocumentViewerExtension.ExportTo(GetReport());
        }
        XtraReport GetReport() {
            return new XtraReportsDemos.Overview.Report();
        }
    }
}

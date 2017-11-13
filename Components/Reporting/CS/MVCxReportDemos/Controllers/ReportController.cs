using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public abstract class ReportDemoController: DemoController {
        public ActionResult DocumentViewerExportTo(string reportID) {
            return DocumentViewerExtension.ExportTo(ReportDemoHelper.CreateModel(reportID, Session, Request).Report);
        }
    }
}

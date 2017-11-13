using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AppearanceController: ReportDemoController {
        public ActionResult FormattingRulesReport() {
            var model = ReportDemoHelper.CreateModel("FormattingRules", Session, Request);
            return DemoView("FormattingRulesReport", "FormattingRules", model);
        }

        public ActionResult FormattingRulesViewerPartial(string reportID) {
            return PartialView("FormattingRulesViewerPartial", ReportDemoHelper.CreateModel(reportID, Session, Request));
        }
    }
}

﻿using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ReportTypesController: ReportDemoController {
        public ActionResult SideBySideReport() {
            var model = ReportDemoHelper.CreateModel("SideBySide", Session, Request);
            return DemoView("SideBySideReport", "SideBySide", model);
        }

        public ActionResult SideBySideViewerPartial(string reportID) {
            return PartialView("SideBySideViewerPartial", ReportDemoHelper.CreateModel(reportID, Session, Request));
        }
    }
}

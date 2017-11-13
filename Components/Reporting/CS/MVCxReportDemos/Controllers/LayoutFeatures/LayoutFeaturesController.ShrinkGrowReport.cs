﻿using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class LayoutFeaturesController: ReportDemoController {
        public ActionResult ShrinkGrowReport() {
            var model = ReportDemoHelper.CreateModel("ShrinkGrow", Session, Request);
            return DemoView("ShrinkGrowReport", "ShrinkGrow", model);
        }

        public ActionResult ShrinkGrowViewerPartial(string reportID) {
            return PartialView("ShrinkGrowViewerPartial", ReportDemoHelper.CreateModel(reportID, Session, Request));
        }
    }
}

﻿using System.Collections;
using System.Linq;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ReportControlsController: ReportDemoController {
        public ActionResult CustomControlReport() {
            var model = ReportDemoHelper.CreateModel("CustomControl", Session, Request);
            return DemoView("CustomControlReport", "CustomControl", model);
        }

        public ActionResult CustomControlViewerPartial(string reportID) {
            return PartialView("CustomControlViewerPartial", ReportDemoHelper.CreateModel(reportID, Session, Request));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ReportControlsController : ReportDemoController {
        public ActionResult CharacterCombReport() {
            var model = ReportDemoHelper.CreateModel("CharacterComb", Session, Request);
            return DemoView("CharacterCombReport", "CharacterComb", model);
        }

        public ActionResult CharacterCombViewerPartial(string reportID) {
            return PartialView("CharacterCombViewerPartial", ReportDemoHelper.CreateModel(reportID, Session, Request));
        }
    }
}

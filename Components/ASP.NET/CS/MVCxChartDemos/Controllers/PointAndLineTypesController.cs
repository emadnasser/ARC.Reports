﻿using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class PointAndLineTypesController : DemoController {
        public override string Name { get { return "PointAndLineTypes"; } }
        public ActionResult Index() {
            return RedirectToAction("PointAndLineView");
        }
    }
}

﻿using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class BarTypesController : DemoController {
        public override string Name { get { return "BarTypes"; } }
        public ActionResult Index() {
            return RedirectToAction("BarView");
        }
    }
}

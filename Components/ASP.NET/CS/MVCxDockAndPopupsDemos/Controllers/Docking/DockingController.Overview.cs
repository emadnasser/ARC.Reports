﻿using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class DockingController: DemoController {     
        public ActionResult Overview() {
            return DemoView("Overview");
        }
    }
}
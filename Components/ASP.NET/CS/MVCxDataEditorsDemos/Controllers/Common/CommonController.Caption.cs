﻿using System.Web.Mvc;
using DevExpress.Web.Mvc;
using System.Threading;

namespace DevExpress.Web.Demos {
    public partial class CommonController : DemoController {
        public ActionResult Caption() {
            return DemoView("Caption");
        }        
    }
}
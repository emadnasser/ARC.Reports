﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FilteringController: DemoController {
        public override string Name { get { return "Filtering"; } }
        
        public ActionResult Index() {
            return RedirectToAction("Filtering");
        }
    }
}
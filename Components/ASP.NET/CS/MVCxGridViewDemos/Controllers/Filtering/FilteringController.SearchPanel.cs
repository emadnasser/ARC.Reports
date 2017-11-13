﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Demos;

namespace DevExpress.Web.Demos {
    public partial class FilteringController : DemoController {
        public ActionResult SearchPanel() {
            return DemoView("SearchPanel", NorthwindDataProvider.GetCustomers());
        }
        public ActionResult SearchPanelPartial() {
            return PartialView("SearchPanelPartial", NorthwindDataProvider.GetCustomers());
        }
    }
}

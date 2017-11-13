using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class GridLookupController: DemoController {
        public ActionResult AdvancedLookup() {
            return DemoView("AdvancedLookup", NorthwindDataProvider.GetEmployees());
        }
        public ActionResult AdvancedLookupPartial() {
            return PartialView("AdvancedLookupPartial", NorthwindDataProvider.GetEmployees());
        }
    }
}

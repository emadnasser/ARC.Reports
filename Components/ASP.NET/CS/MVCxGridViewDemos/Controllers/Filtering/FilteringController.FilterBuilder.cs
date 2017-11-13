using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Demos;

namespace DevExpress.Web.Demos {
    public partial class FilteringController : DemoController {
        public ActionResult FilterBuilder() {
            return DemoView("FilterBuilder", NorthwindDataProvider.GetProducts());
        }
        [HttpPost]
        public ActionResult FilterBuilder(FilterBuilderDemoOptions options) {
            FilterBuilderDemoHelper.Options = options;
            return DemoView("FilterBuilder", NorthwindDataProvider.GetProducts());
        }
        public ActionResult FilterBuilderPartial() {
            return PartialView("FilterBuilderPartial", NorthwindDataProvider.GetProducts());
        }
    }
}


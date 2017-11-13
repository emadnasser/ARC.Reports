using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading;

namespace DevExpress.Web.Demos {
    public partial class ColumnsController: DemoController {
        public ActionResult ColumnMoving() {
            return DemoView("ColumnMoving", NorthwindDataProvider.GetProducts());
        }
        public ActionResult ColumnMovingPartial() {
            Thread.Sleep(1500); // Extend the callback delay for demonstration purposes
            return PartialView("ColumnMovingPartial", NorthwindDataProvider.GetProducts());
        }
        [HttpPost]
        public ActionResult ColumnMoving(ColumnMovingDemoOptions options) {
            ColumnMovingDemoHelper.Options = options;
            return DemoView("ColumnMoving", NorthwindDataProvider.GetProducts());
        }
    }
}

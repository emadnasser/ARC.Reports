using System.Collections;
using System.Linq;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class OverviewController : DemoController {
        public override string Name { get { return ""; } }

        public ActionResult Index() {
            return DemoView("Overview", GetOrders());
        }
        public ActionResult OverviewPartial() {
            return PartialView("OverviewPartial", GetOrders());
        }
        public static IEnumerable GetOrders() {
            NorthwindContext DB = new NorthwindContext();
            return DB.Orders.ToList();
        }
    }
}

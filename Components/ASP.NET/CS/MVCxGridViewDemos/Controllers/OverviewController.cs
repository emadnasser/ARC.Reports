using System.Web.Mvc;
using System.Collections;
using DevExpress.Web.Demos.Models;
	using System.Linq;

namespace DevExpress.Web.Demos {
    public partial class OverviewController: DemoController {
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

using System.Web.Mvc;
using System.Collections;
using DevExpress.Web.Mvc;
using DevExpress.Web.Demos.Models;
using System.Data.Linq;
using System.Linq;

namespace DevExpress.Web.Demos {
    public partial class OverviewController: DemoController {
        public override string Name { get { return ""; } }

        public ActionResult Index() {
            return DemoView("Overview", GetSalesPerson());
        }
        public ActionResult OverviewPartial() {
            return PartialView("OverviewPartial", GetSalesPerson());
        }
        public static IEnumerable GetSalesPerson() {
            NorthwindContext db = new NorthwindContext();
            return db.SalesPersons.ToList();
        }
    }
}

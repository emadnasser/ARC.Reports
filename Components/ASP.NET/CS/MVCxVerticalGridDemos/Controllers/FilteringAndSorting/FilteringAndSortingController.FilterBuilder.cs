using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FilteringAndSortingController: DemoController {
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

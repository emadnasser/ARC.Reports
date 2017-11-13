using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class BarTypesController : DemoController {
        [HttpGet]
        public ActionResult FullStackedBarView() {
            ChartBarFullStackedDemoOptions options = new ChartBarFullStackedDemoOptions(); 
            options.ShowLabels = true;
            options.View = DevExpress.XtraCharts.ViewType.FullStackedBar;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("FullStackedBarView", DevAV.GetSalesMixByRegion());
        }
        [HttpPost]
        public ActionResult FullStackedBarView([Bind]ChartBarFullStackedDemoOptions options) {
            ViewData[ChartDemoHelper.OptionsKey] = options;
            options.View = DevExpress.XtraCharts.ViewType.FullStackedBar;
            return DemoView("FullStackedBarView", DevAV.GetSalesMixByRegion());
        }
    }
}


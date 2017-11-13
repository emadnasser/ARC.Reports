using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AreaTypesController : DemoController {
        [HttpGet]
        public ActionResult SplineFullStackedAreaView() {
            ChartAreaFullStckedDemoOptions options = new ChartAreaFullStckedDemoOptions();
            options.View = DevExpress.XtraCharts.ViewType.FullStackedSplineArea;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("SplineFullStackedAreaView", DevAV.GetBranchesSales());
        }
        [HttpPost]
        public ActionResult SplineFullStackedAreaView([Bind] ChartAreaFullStckedDemoOptions options) {
            options.View = DevExpress.XtraCharts.ViewType.FullStackedSplineArea;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("SplineFullStackedAreaView", DevAV.GetBranchesSales());
        }
    }
}

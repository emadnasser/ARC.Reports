using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AreaTypesController : DemoController {
        [HttpGet]
        public ActionResult FullStackedAreaView() {
            ChartAreaFullStckedDemoOptions options = new ChartAreaFullStckedDemoOptions();
            options.View = DevExpress.XtraCharts.ViewType.FullStackedArea;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("FullStackedAreaView", DevAV.GetBranchesSales());
        }
        [HttpPost]
        public ActionResult FullStackedAreaView([Bind] ChartAreaFullStckedDemoOptions options) {
            options.View = DevExpress.XtraCharts.ViewType.FullStackedArea;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("FullStackedAreaView", DevAV.GetBranchesSales());
        }
    }
}

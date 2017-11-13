using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class PointAndLineTypesController : DemoController {
        [HttpGet]
        public ActionResult FullStackedLineView() {
            ChartLineFullStckedDemoOptions options = new ChartLineFullStckedDemoOptions();
            options.View = DevExpress.XtraCharts.ViewType.FullStackedLine;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("FullStackedLineView", DevAV.GetBranchesSales());
        }
        [HttpPost]
        public ActionResult FullStackedLineView([Bind] ChartLineFullStckedDemoOptions options) {
            options.View = DevExpress.XtraCharts.ViewType.FullStackedLine;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("FullStackedLineView", DevAV.GetBranchesSales());
        }
    }
}

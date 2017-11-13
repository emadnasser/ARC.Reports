using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AreaTypesController : DemoController {
        [HttpGet]
        public ActionResult FullStackedStepAreaView() {
            ChartStepAreaFullStckedDemoOptions options = new ChartStepAreaFullStckedDemoOptions();
            options.View = DevExpress.XtraCharts.ViewType.FullStackedStepArea;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("FullStackedStepAreaView", CommentsInSite.GetCommentsValues());
        }
        [HttpPost]
        public ActionResult FullStackedStepAreaView([Bind] ChartStepAreaFullStckedDemoOptions options) {
            options.View = DevExpress.XtraCharts.ViewType.FullStackedStepArea;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("FullStackedStepAreaView", CommentsInSite.GetCommentsValues());
        }
    }
}

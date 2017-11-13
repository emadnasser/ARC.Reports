using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AreaTypesController : DemoController {
        [HttpGet]
        public ActionResult StackedStepAreaView() {
            ChartStepAreaDemoOptions options = new ChartStepAreaDemoOptions();
            options.View = DevExpress.XtraCharts.ViewType.StackedStepArea;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("StackedStepAreaView", CommentsInSite.GetCommentsValues());
        }
        [HttpPost]
        public ActionResult StackedStepAreaView([Bind] ChartStepAreaDemoOptions options) {
            options.View = DevExpress.XtraCharts.ViewType.StackedStepArea;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("StackedStepAreaView", CommentsInSite.GetCommentsValues());
        }
    }
}

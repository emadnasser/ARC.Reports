using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class PointAndLineTypesController : DemoController {
        [HttpGet]
        public ActionResult BubbleView() {
            ChartBubbleDemoOptions options = new ChartBubbleDemoOptions();
            options.Transparency = 90;
            options.View = DevExpress.XtraCharts.ViewType.Bubble;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("BubbleView", BubbleData.GetData());
        }
        [HttpPost]
        public ActionResult BubbleView([Bind] ChartBubbleDemoOptions options) {
            options.View = DevExpress.XtraCharts.ViewType.Bubble;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("BubbleView", BubbleData.GetData());
        }
    }
}

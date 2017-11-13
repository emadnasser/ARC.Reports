using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class PointAndLineTypesController : DemoController {
        [HttpGet]
        public ActionResult StackedLineView() {
            ChartMarkerDemoOptions options = new ChartMarkerDemoOptions();
            options.ShowLabels = true;
            options.View = DevExpress.XtraCharts.ViewType.StackedLine;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("StackedLineView", DevAV.GetSalesByLast10Years());
        }
        [HttpPost]
        public ActionResult StackedLineView([Bind] ChartMarkerDemoOptions options) {
            options.View = DevExpress.XtraCharts.ViewType.StackedLine;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("StackedLineView", DevAV.GetSalesByLast10Years());
        }
    }
}

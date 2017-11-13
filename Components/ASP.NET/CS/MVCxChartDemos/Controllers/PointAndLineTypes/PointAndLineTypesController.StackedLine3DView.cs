using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class PointAndLineTypesController : DemoController {
        [HttpGet]
        public ActionResult StackedLine3DView() {
            Chart3DDemoOptions options = new Chart3DDemoOptions();
            options.View = DevExpress.XtraCharts.ViewType.StackedLine3D;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("StackedLine3DView", DevAV.GetSalesByLast10Years());
        }
        [HttpPost]
        public ActionResult StackedLine3DView([Bind] Chart3DDemoOptions options) {
            options.View = DevExpress.XtraCharts.ViewType.StackedLine3D;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("StackedLine3DView", DevAV.GetSalesByLast10Years());
        }
    }
}

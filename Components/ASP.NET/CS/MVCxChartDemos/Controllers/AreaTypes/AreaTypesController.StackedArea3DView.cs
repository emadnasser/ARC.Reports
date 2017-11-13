using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AreaTypesController : DemoController {
        [HttpGet]
        public ActionResult StackedArea3DView() {
            ChartArea3DDemoOptions options = new ChartArea3DDemoOptions();
            options.View = DevExpress.XtraCharts.ViewType.StackedArea3D;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("StackedArea3DView", DevAV.GetSalesByLast10Years());
        }
        [HttpPost]
        public ActionResult StackedArea3DView([Bind] ChartArea3DDemoOptions options) {
            options.View = DevExpress.XtraCharts.ViewType.StackedArea3D;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("StackedArea3DView", DevAV.GetSalesByLast10Years());
        }
    }
}

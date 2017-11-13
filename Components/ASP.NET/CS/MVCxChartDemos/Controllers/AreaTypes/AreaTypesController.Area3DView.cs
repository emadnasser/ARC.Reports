using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AreaTypesController : DemoController {
        [HttpGet]
        public ActionResult Area3DView() {
            ChartArea3DDemoOptions options = new ChartArea3DDemoOptions();
            options.View = DevExpress.XtraCharts.ViewType.Area3D;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("Area3DView", DevAV.GetOutsideVendorCosts());
        }
        [HttpPost]
        public ActionResult Area3DView([Bind] ChartArea3DDemoOptions options) {
            options.View = DevExpress.XtraCharts.ViewType.Area3D;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("Area3DView", DevAV.GetOutsideVendorCosts());
        }
    }
}

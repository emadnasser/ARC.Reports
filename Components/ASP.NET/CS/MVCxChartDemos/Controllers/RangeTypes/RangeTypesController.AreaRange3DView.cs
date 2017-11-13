using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class RangeTypesController : DemoController {
        [HttpGet]
        public ActionResult AreaRange3DView() {
            ChartRange3DDemoOptions options = new ChartRange3DDemoOptions();
            options.View = DevExpress.XtraCharts.ViewType.RangeArea3D;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("AreaRange3DView", SourceOfEnergy.GetOkWtiPrices());
        }
        [HttpPost]
        public ActionResult AreaRange3DView([Bind] ChartRange3DDemoOptions options) {
            options.View = DevExpress.XtraCharts.ViewType.RangeArea3D;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("AreaRange3DView", SourceOfEnergy.GetOkWtiPrices());
        }
    }
}

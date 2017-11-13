using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AreaTypesController : DemoController {
        [HttpGet]
        public ActionResult StepArea3DView() {
            ChartStepArea3DDemoOptions options = new ChartStepArea3DDemoOptions();
            options.View = DevExpress.XtraCharts.ViewType.StepArea3D;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("StepArea3DView", SourceOfEnergy.GetGasolinePrices());
        }
        [HttpPost]
        public ActionResult StepArea3DView([Bind] ChartStepArea3DDemoOptions options) {
            options.View = DevExpress.XtraCharts.ViewType.StepArea3D;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("StepArea3DView", SourceOfEnergy.GetGasolinePrices());
        }
    }
}

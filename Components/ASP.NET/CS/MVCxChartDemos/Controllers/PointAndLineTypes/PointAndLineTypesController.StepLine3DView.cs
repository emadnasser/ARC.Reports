using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class PointAndLineTypesController : DemoController {
        [HttpGet]
        public ActionResult StepLine3DView() {
            ChartStepLine3DDemoOptions options = new ChartStepLine3DDemoOptions();
            options.View = DevExpress.XtraCharts.ViewType.StepLine3D;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("StepLine3DView", SourceOfEnergy.GetGasolinePrices());
        }
        [HttpPost]
        public ActionResult StepLine3DView([Bind] ChartStepLine3DDemoOptions options) {
            options.View = DevExpress.XtraCharts.ViewType.StepLine3D;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("StepLine3DView", SourceOfEnergy.GetGasolinePrices());
        }
    }
}

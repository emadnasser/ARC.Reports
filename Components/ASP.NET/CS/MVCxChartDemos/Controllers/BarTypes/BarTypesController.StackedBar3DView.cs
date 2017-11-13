using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class BarTypesController : DemoController {
        [HttpGet]
        public ActionResult StackedBar3DView() {
            ChartBar3DDemoOptions options = new ChartBar3DDemoOptions();
            options.ShowLabels = true;
            options.View = DevExpress.XtraCharts.ViewType.StackedBar3D;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("StackedBar3DView", AgeStructure.GetDataByFemaleAge());
        }
        [HttpPost]
        public ActionResult StackedBar3DView([Bind]ChartBar3DDemoOptions options) {
            ViewData[ChartDemoHelper.OptionsKey] = options;
            options.View = DevExpress.XtraCharts.ViewType.StackedBar3D;
            return DemoView("StackedBar3DView", AgeStructure.GetDataByFemaleAge());
        }
    }
}


using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class BarTypesController : DemoController {
        [HttpGet]
        public ActionResult StackedSideBySideBar3DView() {
            ChartSideBySideBar3DDemoOptions options = new ChartSideBySideBar3DDemoOptions();
            options.View = DevExpress.XtraCharts.ViewType.SideBySideStackedBar3D;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("StackedSideBySideBar3DView", AgeStructure.GetDataByAgeAndGender());
        }
        [HttpPost]
        public ActionResult StackedSideBySideBar3DView([Bind]ChartSideBySideBar3DDemoOptions options) {
            ViewData[ChartDemoHelper.OptionsKey] = options;
            options.View = DevExpress.XtraCharts.ViewType.SideBySideStackedBar3D;
            return DemoView("StackedSideBySideBar3DView", AgeStructure.GetDataByAgeAndGender());
        }
    }
}

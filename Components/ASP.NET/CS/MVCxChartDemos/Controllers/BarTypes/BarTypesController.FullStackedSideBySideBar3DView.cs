using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class BarTypesController : DemoController {
        [HttpGet]
        public ActionResult FullStackedSideBySideBar3DView() {
            ChartSideBySideBar3DDemoOptions options = new ChartSideBySideBar3DDemoOptions();     
            options.View = DevExpress.XtraCharts.ViewType.SideBySideFullStackedBar3D;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("FullStackedSideBySideBar3DView", AgeStructure.GetDataByAgeAndGender());
        }
        [HttpPost]
        public ActionResult FullStackedSideBySideBar3DView([Bind]ChartSideBySideBar3DDemoOptions options) {
            ViewData[ChartDemoHelper.OptionsKey] = options;
            options.View = DevExpress.XtraCharts.ViewType.SideBySideFullStackedBar3D;
            return DemoView("FullStackedSideBySideBar3DView", AgeStructure.GetDataByAgeAndGender());
        }
    }
}

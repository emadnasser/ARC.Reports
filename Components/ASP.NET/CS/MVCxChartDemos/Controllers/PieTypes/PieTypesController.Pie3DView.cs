using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class PieTypesController : DemoController {
        [HttpGet]
        public ActionResult Pie3DView() {
            ViewData[ChartDemoHelper.OptionsKey] = new ChartPieDoughnutDemoOptions() { View = XtraCharts.ViewType.Pie3D, ShowLabels = true };
            return DemoView("Pie3DView", CountriesProvider.GetCountries());
        }
        [HttpPost]
        public ActionResult Pie3DView([Bind] ChartPieDoughnutDemoOptions options) {
            options.View = XtraCharts.ViewType.Pie3D;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("Pie3DView", CountriesProvider.GetCountries());
        }
    }
}

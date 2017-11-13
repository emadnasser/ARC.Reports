using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class PieTypesController : DemoController {
        [HttpGet]
        public ActionResult DoughnutPie3DView() {
            ViewData[ChartDemoHelper.OptionsKey] = new ChartPieDoughnutDemoOptions() { View = XtraCharts.ViewType.Doughnut3D, HoleRadiusPercent = 50, ShowLabels = true };
            return DemoView("DoughnutPie3DView", CountriesProvider.GetCountries());
        }
        [HttpPost]
        public ActionResult DoughnutPie3DView([Bind] ChartPieDoughnutDemoOptions options) {
            options.View = XtraCharts.ViewType.Doughnut3D;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("DoughnutPie3DView", CountriesProvider.GetCountries());
        }
    }
}

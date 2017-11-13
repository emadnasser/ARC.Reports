using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class RadarTypesController : DemoController {
        [HttpGet]
        public ActionResult RadarPointView() {
            ViewData[ChartDemoHelper.OptionsKey] = new ChartRadarDemoOptions() { View = XtraCharts.ViewType.RadarPoint };
            return DemoView("RadarPointView", WeatherInLondon.GetTemperatureHistory());
        }
        [HttpPost]
        public ActionResult RadarPointView([Bind] ChartRadarDemoOptions options) {
            options.View = XtraCharts.ViewType.RadarPoint;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("RadarPointView", WeatherInLondon.GetTemperatureHistory());
        }
    }
}

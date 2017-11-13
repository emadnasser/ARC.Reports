using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class RadarTypesController : DemoController {
        [HttpGet]
        public ActionResult RadarRangeAreaView() {
            ViewData[ChartDemoHelper.OptionsKey] = new ChartRadarRangeDemoOptions() { View = XtraCharts.ViewType.RadarRangeArea, TextDirection = XtraCharts.RadarAxisXLabelTextDirection.LeftToRight };
            return DemoView("RadarRangeAreaView", WeatherInLondon.GetTemperatureRangeHistory());
        }
        [HttpPost]
        public ActionResult RadarRangeAreaView([Bind] ChartRadarRangeDemoOptions options) {
            options.View = XtraCharts.ViewType.RadarRangeArea;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("RadarRangeAreaView", WeatherInLondon.GetTemperatureRangeHistory());
        }
    }
}

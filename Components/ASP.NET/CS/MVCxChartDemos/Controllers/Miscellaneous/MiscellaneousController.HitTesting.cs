using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class MiscellaneousController : DemoController {
        public ActionResult HitTesting() {
            return DemoView("HitTesting", WeatherInLondon.GetWeatherHistory());
        }
    }
}

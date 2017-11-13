using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FilteringController: DemoController {
        const GridHeaderFilterMode DefaultHeaderFilterMode = GridHeaderFilterMode.DateRangePicker;

        public ActionResult DateRangeHeaderFilter() {
            return DemoView("DateRangeHeaderFilter", DefaultHeaderFilterMode);
        }
        public ActionResult DateRangeHeaderFilterPartial(GridHeaderFilterMode? headerFilterMode) {
            ViewBag.HeaderFilterMode = headerFilterMode.HasValue ? headerFilterMode.Value : DefaultHeaderFilterMode;
            return PartialView("DateRangeHeaderFilterPartial", PatientsDataGenerator.GetInMemoryData());
        }
    }
}

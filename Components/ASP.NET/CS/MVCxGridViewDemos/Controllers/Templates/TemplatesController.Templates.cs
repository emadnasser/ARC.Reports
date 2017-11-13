using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class TemplatesController : DemoController {
        public ActionResult Templates() {
            return DemoView("Templates", NorthwindDataProvider.GetEmployees());
        }
        public ActionResult TemplatesPartial() {
            return PartialView("TemplatesPartial", NorthwindDataProvider.GetEmployees());
        }
        public ActionResult CustomTemplatesPartial(int pageSize) {
            if (pageSize > 0)
                GridViewTemplatesDemoHelper.PageSize = pageSize;
            return PartialView("TemplatesPartial", NorthwindDataProvider.GetEmployees());
        }
    }
}

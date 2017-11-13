using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AdaptivityController : DemoController {
        public override string Name { get { return "Adaptivity"; } }

        public ActionResult Index() {
            return RedirectToAction("ResponsiveLayout");
        }

        protected override void OnActionExecuted(ActionExecutedContext filterContext) {
            base.OnActionExecuted(filterContext);
            string actionName = filterContext.ActionDescriptor.ActionName;
            if((Utils.CurrentDemo == null || Utils.IsBogusDemo) && (actionName.StartsWith("ResponsiveLayout") || actionName.StartsWith("AdaptiveLayout"))) {
                DevExpressHelper.Theme = "Moderno";
                Utils.ResetThemeParameters();
            }
        }
    }
}

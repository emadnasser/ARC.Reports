using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    [ValidateInput(false)]
    public partial class FormLayoutController : DemoController {
        public override string Name { get { return "FormLayout"; } }

        public ActionResult Index() {
            return RedirectToAction("Features");
        }

        protected override void OnActionExecuted(ActionExecutedContext filterContext) {
            base.OnActionExecuted(filterContext);
            if((Utils.CurrentDemo == null || Utils.IsBogusDemo) && filterContext.ActionDescriptor.ActionName.StartsWith("ResponsiveLayout")) {
                DevExpressHelper.Theme = "Moderno";
                Utils.ResetThemeParameters();
            }
        }
    }
}
